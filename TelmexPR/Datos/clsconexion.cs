using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Datos
{
    public class clsconexion
    {
        
        string cadena = "";
        public clsconexion()
        {
            cadena = ConfigurationManager.ConnectionStrings["connTelmex"].ConnectionString;
        }

        SqlConnection conn = new SqlConnection();

        public void EjecutarComando (SqlCommand cmd) //void porque no va devolver nada
        {         
            
            conn.ConnectionString = cadena;
            cmd.Connection = conn;

            conn.Open();
            cmd.ExecuteNonQuery(); //Este ejecuta un SQL que NO devuelve ningún valor
            //cmd.ExecuteScalar(); Este ejecuta un SQL que devuelve un valor
                   
        }

        public void cerrarConexion()
        {
            conn.Close(); 
        }

        public DataTable GetDTable(SqlCommand cmd)
        {
            cadena = ConfigurationManager.ConnectionStrings["connTelmex"].ConnectionString;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = cadena;
            cmd.Connection = conn;

            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            adaptador.Fill(DT);
            return DT;

        }
    }
    }

