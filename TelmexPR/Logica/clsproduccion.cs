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
    public class clsproduccion
    {
        public string cadena;
        public string ID_PRODUCCION;
        public string ID_USUARIO = clslogueo.idUsuario.ToString();
        public string ID_TRABAJADOR;
        public string EXPEDIENTE;

        public DataTable consultaProduccion()
        {
            clsconexion conn = new clsconexion();
            SqlCommand cmd = new SqlCommand();
            DataTable DT;

            cmd.CommandText = "BUSCAR_PRODUCCION";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cadena", cadena);
            DT = conn.GetDTable(cmd);
            return DT;
        }

    }
}
