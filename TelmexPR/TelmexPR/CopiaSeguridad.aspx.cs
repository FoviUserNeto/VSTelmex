using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace TelmexPR
{
    public partial class CopiaSeguridad : System.Web.UI.Page
    {
        SqlConnection conexion = new SqlConnection("Data Source=localhost;Initial Catalog=TelmexOrden; Integrated security=true;");
        protected void Page_Load(object sender, EventArgs e)
        {
            //   conString = ConfigurationManager.ConnectionStrings["connTelmex1"].ConnectionString;
        }

        protected void btnBackup_Click(object sender, EventArgs e)
        {



            string nombre_copia = (System.DateTime.Today.Day.ToString() + "-" + System.DateTime.Today.Month.ToString() + "-" + System.DateTime.Today.Year.ToString() + "-" + System.DateTime.Now.Hour.ToString() + "-" + System.DateTime.Now.Minute.ToString() + "-" + System.DateTime.Now.Second.ToString() + " MiPrograma");

            string comando_consulta = "BACKUP DATABASE [TelmexOrden] TO  DISK = N'C:\\Respaldo\\" + nombre_copia + ".bak" + "' WITH NOFORMAT, NOINIT,  NAME = N'TelmexOrden-Completa Base de datos Copia de seguridad', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";

            SqlCommand cmd = new SqlCommand(comando_consulta, conexion);

            try
            {
                conexion.Open();
                cmd.ExecuteNonQuery();
                //MessageBox.Show("La Copia se ha creado Satisfactoriamente");
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Si desea realizar otra copia de seguridad, porfavor cierre el formulario e intentalo de nuevo");
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }
        }

      
        }
    }
