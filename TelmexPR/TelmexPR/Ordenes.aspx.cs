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
    public partial class Ordenes : System.Web.UI.Page
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
            clsordenes obj = new clsordenes();
            DataTable dt;
            obj.cadena = this.txtBuscar.Text;
            dt = obj.consultaOrdenes();
            this.gvOrdenes.DataSource = dt;
            this.gvOrdenes.DataBind();
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
                dtExcelData.Columns.AddRange(new DataColumn[21] { new DataColumn("TT", typeof(int)),
                new DataColumn("CLAVE", typeof(string)),
                new DataColumn("RANGO",typeof(string)),
                new DataColumn("Libreria",typeof(string)),
                new DataColumn("Area",typeof(string)),
                new DataColumn("CT",typeof(string)),
                new DataColumn("CAT",typeof(string)),
                new DataColumn("OFICINA",typeof(string)),
                new DataColumn("Folio",typeof(string)),
                new DataColumn("Telefono",typeof(string)),
                new DataColumn("Tel_Factura",typeof(string)),
                new DataColumn("Tipo_OS",typeof(string)),
                new DataColumn("Clase_Serv",typeof(string)),
                new DataColumn("Dilacion",typeof(string)),
                new DataColumn("Etapa_Actual",typeof(string)),
                
                new DataColumn("Deptoid", typeof(string)),
                new DataColumn("Dilacion_Etapa",typeof(string)),
                new DataColumn("Fecha_Entrada",typeof(string)),
                new DataColumn("Ultima_Etapa",typeof(string)),
                new DataColumn("Fecha_Ultima_Etapa",typeof(string)),
                new DataColumn("Distrito",typeof(string))
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
                        sqlBulkCopy.DestinationTableName = "T_ORDENES";

                        //[OPTIONAL]: Map the Excel columns with that of the database table
                        sqlBulkCopy.ColumnMappings.Add("TT", "TT");
                        sqlBulkCopy.ColumnMappings.Add("CLAVE", "CLAVE");
                        sqlBulkCopy.ColumnMappings.Add("RANGO", "RANGO");
                        sqlBulkCopy.ColumnMappings.Add("Libreria", "Libreria");
                        sqlBulkCopy.ColumnMappings.Add("Area", "Area");
                        sqlBulkCopy.ColumnMappings.Add("CT", "CT");
                        sqlBulkCopy.ColumnMappings.Add("CAT", "CAT");
                        sqlBulkCopy.ColumnMappings.Add("OFICINA", "OFICINA");
                        sqlBulkCopy.ColumnMappings.Add("Folio", "Folio");
                        sqlBulkCopy.ColumnMappings.Add("Telefono", "Telefono");
                        sqlBulkCopy.ColumnMappings.Add("Tel_Factura", "Tel_Factura");
                        sqlBulkCopy.ColumnMappings.Add("Tipo_OS", "Tipo_OS");
                        sqlBulkCopy.ColumnMappings.Add("Clase_Serv", "Clase_Serv");
                        sqlBulkCopy.ColumnMappings.Add("Dilacion", "Dilacion");
                        sqlBulkCopy.ColumnMappings.Add("Etapa_Actual", "Etapa_Actual");

                        sqlBulkCopy.ColumnMappings.Add("Deptoid", "Deptoid");
                        sqlBulkCopy.ColumnMappings.Add("Dilacion_Etapa", "Dilacion_Etapa");
                        sqlBulkCopy.ColumnMappings.Add("Fecha_Entrada", "Fecha_Entrada");
                        sqlBulkCopy.ColumnMappings.Add("Ultima_Etapa", "Ultima_Etapa");
                        sqlBulkCopy.ColumnMappings.Add("Fecha_Ultima_Etapa", "Fecha_Ultima_Etapa");
                        sqlBulkCopy.ColumnMappings.Add("Distrito", "Distrito");
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
            Response.Redirect("Reportes/ReportePendiente.aspx");
        }
    }
}