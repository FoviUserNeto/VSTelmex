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
    public partial class Pendientes : System.Web.UI.Page
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
            clsPendientes obj = new clsPendientes();
            DataTable dt;
            obj.cadena = this.txtBuscar.Text;
            dt = obj.consultaPendiente();
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
                dtExcelData.Columns.AddRange(new DataColumn[33] { new DataColumn("FOLIO", typeof(int)),
                new DataColumn("EXPEDIENTE", typeof(string)),
                new DataColumn("NOMBRE_TECNICO",typeof(string)),
                new DataColumn("FOLIO_PISA",typeof(string)),
                new DataColumn("TIPO_TAREA",typeof(string)),
                new DataColumn("TELEFONO",typeof(string)),
                new DataColumn("NOMBRE_CLIENTE",typeof(string)),
                new DataColumn("DISTRITO",typeof(string)),
                new DataColumn("ZONA",typeof(string)),
                new DataColumn("FECHA_CONTRATACION_RECEPCION",typeof(string)),
                new DataColumn("FECHA_LLEGADA_PISAPLEX",typeof(string)),
                new DataColumn("FECHA_AGENDACION_ACTUALIZADA",typeof(string)),
                new DataColumn("GRUPO_ASIGNACION",typeof(string)),
                new DataColumn("DILACION",typeof(string)),
                new DataColumn("ESTADO",typeof(string)),
                
                new DataColumn("CALIFICADOR", typeof(string)),
                new DataColumn("FECHA_SISA",typeof(string)),
                new DataColumn("LIBRERIA",typeof(string)),
                new DataColumn("NUMERO_REFERENCIA_ARGOS",typeof(string)),
                new DataColumn("FOLIO_ARGOS",typeof(string)),
                new DataColumn("DIRECCION",typeof(string)),
                new DataColumn("CABLE_PAR",typeof(string)),
                new DataColumn("POSICION_DG",typeof(string)),
                new DataColumn("ATENCION",typeof(string)),
                new DataColumn("VALOR_CLIENTE",typeof(string)),
                new DataColumn("MERCADO",typeof(string)),
                new DataColumn("SEGMENTO",typeof(string)),
                new DataColumn("TECNOLOGIA",typeof(string)),
                new DataColumn("FAMILIA",typeof(string)),

                new DataColumn("PAQUETE",typeof(string)),
                new DataColumn("SERVICIO_DESAGREGACION",typeof(string)),
                new DataColumn("NUMERO_CONTACTO",typeof(string)),
                new DataColumn("NUMERO_CELULAR",typeof(string))
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
                        sqlBulkCopy.DestinationTableName = "T_PENDIENTES";

                        //[OPTIONAL]: Map the Excel columns with that of the database table
                        sqlBulkCopy.ColumnMappings.Add("FOLIO", "FOLIO");
                        sqlBulkCopy.ColumnMappings.Add("EXPEDIENTE", "EXPEDIENTE");
                        sqlBulkCopy.ColumnMappings.Add("NOMBRE_TECNICO", "NOMBRE_TECNICO");
                        sqlBulkCopy.ColumnMappings.Add("FOLIO_PISA", "FOLIO_PISA");
                        sqlBulkCopy.ColumnMappings.Add("TIPO_TAREA", "TIPO_TAREA");
                        sqlBulkCopy.ColumnMappings.Add("TELEFONO", "TELEFONO");
                        sqlBulkCopy.ColumnMappings.Add("NOMBRE_CLIENTE", "NOMBRE_CLIENTE");
                        sqlBulkCopy.ColumnMappings.Add("DISTRITO", "DISTRITO");
                        sqlBulkCopy.ColumnMappings.Add("ZONA", "ZONA");
                        sqlBulkCopy.ColumnMappings.Add("FECHA_CONTRATACION_RECEPCION", "FECHA_CONTRATACION_RECEPCION");
                        sqlBulkCopy.ColumnMappings.Add("FECHA_LLEGADA_PISAPLEX", "FECHA_LLEGADA_PISAPLEX");
                        sqlBulkCopy.ColumnMappings.Add("FECHA_AGENDACION_ACTUALIZADA", "FECHA_AGENDACION_ACTUALIZADA");
                        sqlBulkCopy.ColumnMappings.Add("GRUPO_ASIGNACION", "GRUPO_ASIGNACION");
                        sqlBulkCopy.ColumnMappings.Add("DILACION", "DILACION");
                        sqlBulkCopy.ColumnMappings.Add("ESTADO", "ESTADO");

                        sqlBulkCopy.ColumnMappings.Add("CALIFICADOR", "CALIFICADOR");
                        sqlBulkCopy.ColumnMappings.Add("FECHA_SISA", "FECHA_SISA");
                        sqlBulkCopy.ColumnMappings.Add("LIBRERIA", "LIBRERIA");
                        sqlBulkCopy.ColumnMappings.Add("NUMERO_REFERENCIA_ARGOS", "NUMERO_REFERENCIA_ARGOS");
                        sqlBulkCopy.ColumnMappings.Add("FOLIO_ARGOS", "FOLIO_ARGOS");
                        sqlBulkCopy.ColumnMappings.Add("DIRECCION", "DIRECCION");
                        sqlBulkCopy.ColumnMappings.Add("CABLE_PAR", "CABLE_PAR");
                        sqlBulkCopy.ColumnMappings.Add("POSICION_DG", "POSICION_DG");
                        sqlBulkCopy.ColumnMappings.Add("ATENCION", "ATENCION");
                        sqlBulkCopy.ColumnMappings.Add("VALOR_CLIENTE", "VALOR_CLIENTE");
                        sqlBulkCopy.ColumnMappings.Add("MERCADO", "MERCADO");
                        sqlBulkCopy.ColumnMappings.Add("SEGMENTO", "SEGMENTO");
                        sqlBulkCopy.ColumnMappings.Add("TECNOLOGIA", "TECNOLOGIA");
                        sqlBulkCopy.ColumnMappings.Add("FAMILIA", "FAMILIA");
                        sqlBulkCopy.ColumnMappings.Add("PAQUETE", "PAQUETE");

                        sqlBulkCopy.ColumnMappings.Add("SERVICIO_DESAGREGACION", "SERVICIO_DESAGREGACION");
                        sqlBulkCopy.ColumnMappings.Add("NUMERO_CONTACTO", "NUMERO_CONTACTO");
                        sqlBulkCopy.ColumnMappings.Add("NUMERO_CELULAR", "NUMERO_CELULAR");
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