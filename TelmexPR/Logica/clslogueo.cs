using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos;

namespace Logica
{
    public class clslogueo
    {
        public static int idUsuario;
        public static string nombreUsuario;
        public static string cargo;
        public static string usuario;
        public static string contrasena;

        public DataTable consultaPersonal()
        {
            clsconexion conn = new clsconexion();
            SqlCommand cmd = new SqlCommand();
            DataTable DT;

            cmd.CommandText = "SELECT * FROM T_USUARIOS";
            cmd.CommandType = CommandType.Text;
            DT = conn.GetDTable(cmd);
            return DT;
        }

        public static Boolean Credenciales(string User, string Contr)
        {
            bool resultado = false;

            clsconexion conn = new clsconexion(); 

            SqlCommand cmd = new SqlCommand();
            SqlDataReader Lector;

            cmd.CommandText = "LOGUEO";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@USUARIO", User);
            cmd.Parameters.AddWithValue("@CONTRASEÑA", Contr);

            conn.EjecutarComando(cmd);
            Lector = cmd.ExecuteReader();
            if (Lector.HasRows)
            {
                Lector.Read();

                //obtenemos los datos que necesitamos 
                idUsuario = Lector.GetInt32(0);
                nombreUsuario = Lector.GetString(1);
                cargo = Lector.GetString(2);
                usuario = Lector.GetString(3);
                contrasena = Lector.GetString(4);

                resultado = true;// al haber obtenido algo en la consulta cambiamos el valor del resultado
            }

            Lector.Close();
            conn.cerrarConexion();
            return resultado;
        }
    }
}
