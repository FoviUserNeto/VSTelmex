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
   public class clsprioridad
    {
       public string cadena;
       public string ID_PRIORIDAD;
       public string ID_USUARIO = clslogueo.idUsuario.ToString();
       public string TIPO_TAREA;
       public string TIPO_TABLA;
       public string PRIORIDAD;


       public DataTable consultaPrioridad()
       {
           clsconexion conn = new clsconexion();
           SqlCommand cmd = new SqlCommand();
           DataTable DT;

           cmd.CommandText = "BUSCAR_PRIORIDAD";
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.AddWithValue("@cadena", cadena);
           DT = conn.GetDTable(cmd);
           return DT;
       }

    }
}
