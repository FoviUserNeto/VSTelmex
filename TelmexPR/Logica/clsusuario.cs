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
    public class clsusuario
    {
         public string nombreUsuario;
        public string cargo;
        public string usuario;
        public string contraseña;
        public string idUsuario = clslogueo.idUsuario.ToString();

        public void Insertar()
        {
            clsconexion conn = new clsconexion();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "USUARIO_I";
            cmd.CommandType = CommandType.StoredProcedure;
           //cmd.Parameters.AddWithValue("@ID_USUARIO", idUsuario);
            cmd.Parameters.AddWithValue("@NOMBRE", nombreUsuario);
            cmd.Parameters.AddWithValue("@CARGO", cargo);
            cmd.Parameters.AddWithValue("@USUARIO", usuario);
            cmd.Parameters.AddWithValue("@CONTRASEÑA", contraseña);
            conn.EjecutarComando(cmd);
        }

        public void Eliminar()
    {
        clsconexion conn = new clsconexion();

        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.CommandText = "USUARIO_D";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ID_USUARIO", idUsuario);
        conn.EjecutarComando(cmd);
    }

        public void Editar()
    {
        clsconexion conn = new clsconexion();

        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.CommandText = "USUARIO_U";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ID_USUARIO", idUsuario);
        cmd.Parameters.AddWithValue("@NOMBRE", nombreUsuario);
        cmd.Parameters.AddWithValue("@CARGO", cargo);
        cmd.Parameters.AddWithValue("@USUARIO", usuario);
        cmd.Parameters.AddWithValue("@CONTRASEÑA", contraseña);

        conn.EjecutarComando(cmd);
    }

        public DataTable consultaUsuarios()
    {
        clsconexion conn = new clsconexion();
        SqlCommand cmd = new SqlCommand();
        DataTable DT;

        cmd.CommandText = "USUARIO_S";
        cmd.CommandType = CommandType.StoredProcedure;
        //cmd.Parameters.AddWithValue("@titulo", titulo);
        DT = conn.GetDTable(cmd);
        return DT;
    }

        
    }

    }
