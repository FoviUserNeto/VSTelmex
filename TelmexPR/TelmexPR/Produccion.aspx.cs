using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Data.Common;
using System.Configuration;
using Logica;

namespace TelmexPR
{
    public partial class Produccion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.IsPostBack)
            {
                //llenarTabla();
            }
        }
        public void LlenarTabla()
        {
            clsproduccion obj = new clsproduccion();
            DataTable dt;
            obj.cadena = this.txtBuscar.Text;
            dt = obj.consultaProduccion();
            this.gvPlantilla.DataSource = dt;
            this.gvPlantilla.DataBind();
        }

        protected void btnBuscar_Click(object sender, ImageClickEventArgs e)
        {
            LlenarTabla();
        }

        private void limpiar()
        {
            this.txtBuscar.Text = "";

        }
        protected void Importar_Click(object sender, ImageClickEventArgs e)
        {
            //Upload and save the file
            string excelPath = Server.MapPath("~/Fuentes/temp/") + Path.GetFileName(FilePlantilla.PostedFile.FileName);
            FilePlantilla.SaveAs(excelPath);

            string conString = string.Empty;
            string extension = Path.GetExtension(FilePlantilla.PostedFile.FileName);
            switch (extension)
            {
                case ".xls": //Excel 97-03
                    conString = ConfigurationManager.ConnectionStrings["connTelmex1"].ConnectionString;
                    break;
                case ".xlsx": //Excel 07 or higher
                    conString = ConfigurationManager.ConnectionStrings["connTelmex2"].ConnectionString;
                    break;

            }
            conString = string.Format(conString, excelPath);
            using (OleDbConnection excel_con = new OleDbConnection(conString))
            {
                excel_con.Open();
                string sheet1 = excel_con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null).Rows[0]["TABLE_NAME"].ToString();
                DataTable dtExcelData = new DataTable();

                //[OPTIONAL]: It is recommended as otherwise the data will be considered as String by default.
                dtExcelData.Columns.AddRange(new DataColumn[43] { new DataColumn("EXPEDIENTE", typeof(string)),
                new DataColumn("NOMBRE_TECNICO", typeof(string)),
                new DataColumn("LBAS",typeof(string)),
                new DataColumn("LBBS",typeof(string)),
                new DataColumn("LBCD",typeof(string)),
                new DataColumn("LBM",typeof(string)),
                new DataColumn("LBMS",typeof(string)),
                new DataColumn("LBQ",typeof(string)),
                new DataColumn("L_LPI_AS",typeof(string)),
                new DataColumn("L_LPI_BS",typeof(string)),
                new DataColumn("L_LPI_CD",typeof(string)),
                new DataColumn("L_LPI_MS",typeof(string)),
                new DataColumn("L_LPI_Q",typeof(string)),
                new DataColumn("LFAS",typeof(string)),
                new DataColumn("LFBS",typeof(string)),
                new DataColumn("LFCD",typeof(string)),
                new DataColumn("LFMS", typeof(string)),
                new DataColumn("L_GPON_AS",typeof(string)),
                new DataColumn("L_GPON_BS",typeof(string)),
                new DataColumn("L_GPON_CD",typeof(string)),
                new DataColumn("L_GPON_MS",typeof(string)),
                new DataColumn("LICD",typeof(string)),
                new DataColumn("LIMS",typeof(string)),
                new DataColumn("LIAS",typeof(string)),
                new DataColumn("LIBS",typeof(string)),
                new DataColumn("LICDD",typeof(string)),
                new DataColumn("LIMSS",typeof(string)),
                new DataColumn("L_IPTV_MS",typeof(string)),
                new DataColumn("L_MULTI_AS",typeof(string)),
                new DataColumn("L_MULTI_BS",typeof(string)),

                new DataColumn("L_MULTI_CD",typeof(string)),
                new DataColumn("L_MULT_IMS",typeof(string)),
                new DataColumn("L_TBA_AS",typeof(string)),
                new DataColumn("L_TBA_BS",typeof(string)),
                new DataColumn("L_TBA_CD",typeof(string)),
                new DataColumn("L_TBA_MS",typeof(string)),
                new DataColumn("L_VDSL_AS",typeof(string)),
                new DataColumn("L_VDSL_BS",typeof(string)),
                new DataColumn("L_VDSL_MS",typeof(string)),
                new DataColumn("QUITAR_CD",typeof(string)),
                new DataColumn("QUITAR_MS",typeof(string)),
                new DataColumn("TOTAL",typeof(string)),
                new DataColumn("FECHA",typeof(string))
                                      
                });

                using (OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM [" + sheet1 + "]", excel_con))
                {
                    oda.Fill(dtExcelData);
                }
                excel_con.Close();

                string consString = ConfigurationManager.ConnectionStrings["connTelmex"].ConnectionString;
                using (SqlConnection con = new SqlConnection(consString))
                {
                    using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                    {
                        //Set the database table name
                        sqlBulkCopy.DestinationTableName = "T_PRODUCCION";

                        //[OPTIONAL]: Map the Excel columns with that of the database table
                        sqlBulkCopy.ColumnMappings.Add("EXPEDIENTE", "EXPEDIENTE");
                        sqlBulkCopy.ColumnMappings.Add("NOMBRE_TECNICO", "NOMBRE_TECNICO");
                        sqlBulkCopy.ColumnMappings.Add("LBAS", "LBAS");
                        sqlBulkCopy.ColumnMappings.Add("LBBS", "LBBS");
                        sqlBulkCopy.ColumnMappings.Add("LBCD", "LBCD");
                        sqlBulkCopy.ColumnMappings.Add("LBM", "LBM");
                        sqlBulkCopy.ColumnMappings.Add("LBMS", "LBMS");
                        sqlBulkCopy.ColumnMappings.Add("LBQ", "LBQ");
                        sqlBulkCopy.ColumnMappings.Add("L_LPI_AS", "L_LPI_AS");
                        sqlBulkCopy.ColumnMappings.Add("L_LPI_BS", "L_LPI_BS");
                        sqlBulkCopy.ColumnMappings.Add("L_LPI_CD", "L_LPI_CD");
                        sqlBulkCopy.ColumnMappings.Add("L_LPI_MS", "L_LPI_MS");
                        sqlBulkCopy.ColumnMappings.Add("L_LPI_Q", "L_LPI_Q");
                        sqlBulkCopy.ColumnMappings.Add("LFAS", "LFAS");
                        sqlBulkCopy.ColumnMappings.Add("LFBS", "LFBS");

                        sqlBulkCopy.ColumnMappings.Add("LFCD", "LFCD");
                        sqlBulkCopy.ColumnMappings.Add("LFMS", "LFMS");
                        sqlBulkCopy.ColumnMappings.Add("L_GPON_AS", "L_GPON_AS");
                        sqlBulkCopy.ColumnMappings.Add("L_GPON_BS", "L_GPON_BS");
                        sqlBulkCopy.ColumnMappings.Add("L_GPON_CD", "L_GPON_CD");
                        sqlBulkCopy.ColumnMappings.Add("L_GPON_MS", "L_GPON_MS");
                        sqlBulkCopy.ColumnMappings.Add("LICD", "LICD");
                        sqlBulkCopy.ColumnMappings.Add("LIMS", "LIMS");
                        sqlBulkCopy.ColumnMappings.Add("LIAS", "LIAS");
                        sqlBulkCopy.ColumnMappings.Add("LIBS", "LIBS");
                        sqlBulkCopy.ColumnMappings.Add("LICDD", "LICDD");
                        sqlBulkCopy.ColumnMappings.Add("LIMSS", "LIMSS");
                        sqlBulkCopy.ColumnMappings.Add("L_IPTV_MS", "L_IPTV_MS");
                        sqlBulkCopy.ColumnMappings.Add("L_MULTI_AS", "L_MULTI_AS");
                        sqlBulkCopy.ColumnMappings.Add("L_MULTI_BS", "L_MULTI_BS");

                        sqlBulkCopy.ColumnMappings.Add("L_MULTI_CD", "L_MULTI_CD");
                        sqlBulkCopy.ColumnMappings.Add("L_MULT_IMS", "L_MULT_IMS");
                        sqlBulkCopy.ColumnMappings.Add("L_TBA_AS", "L_TBA_AS");

                        sqlBulkCopy.ColumnMappings.Add("L_TBA_BS", "L_TBA_BS");
                        sqlBulkCopy.ColumnMappings.Add("L_TBA_CD", "L_TBA_CD");
                        sqlBulkCopy.ColumnMappings.Add("L_TBA_MS", "L_TBA_MS");
                        sqlBulkCopy.ColumnMappings.Add("L_VDSL_AS", "L_VDSL_AS");
                        sqlBulkCopy.ColumnMappings.Add("L_VDSL_BS", "L_VDSL_BS");
                        sqlBulkCopy.ColumnMappings.Add("L_VDSL_MS", "L_VDSL_MS");
                        sqlBulkCopy.ColumnMappings.Add("QUITAR_CD", "QUITAR_CD");
                        sqlBulkCopy.ColumnMappings.Add("QUITAR_MS", "QUITAR_MS");
                        sqlBulkCopy.ColumnMappings.Add("TOTAL", "TOTAL");
                        sqlBulkCopy.ColumnMappings.Add("FECHA", "FECHA");
                        con.Open();
                        sqlBulkCopy.WriteToServer(dtExcelData);
                        con.Close();
                    }
                }
            }

        }

        protected void btnSalir_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }

        protected void btnNuevo_Click(object sender, ImageClickEventArgs e)
        {
            this.ModalPopupExtender1.Show();
        }

        protected void btnImprimir_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Reportes/ReporteProduccion.aspx");
        }
    }
}