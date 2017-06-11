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
    public partial class Prioridad : System.Web.UI.Page
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
            clsprioridad obj = new clsprioridad();
            DataTable dt;
            obj.cadena = this.txtBuscar.Text;
            dt = obj.consultaPrioridad();
            this.gvPrioridad.DataSource = dt;
            this.gvPrioridad.DataBind();
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
                dtExcelData.Columns.AddRange(new DataColumn[3] { new DataColumn("TIPO_TAREA", typeof(string)),
                new DataColumn("TIPO_TABLA", typeof(string)),
                new DataColumn("PRIORIDAD",typeof(int))
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
                        sqlBulkCopy.DestinationTableName = "T_PRIORIDAD";

                        //[OPTIONAL]: Map the Excel columns with that of the database table
                        sqlBulkCopy.ColumnMappings.Add("TIPO_TAREA", "TIPO_TAREA");
                        sqlBulkCopy.ColumnMappings.Add("TIPO_TABLA", "TIPO_TABLA");
                        sqlBulkCopy.ColumnMappings.Add("PRIORIDAD", "PRIORIDAD");
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
            Response.Redirect("Reportes/ReportePrioridad.aspx");
        }
    }
}