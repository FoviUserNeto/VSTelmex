using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;
using System.Data.SqlClient;

namespace Logica
{
    public class clstrabajador
    {
        public string cadena;
        public string IDTRABAJADOR;
        public string EXPEDIENTE;
        public string NOMBRE;
        public string APELLIDOS;
        public string SEXO;
        public string FECHANAC;
        public string DIRECCION;
        public string TELEFONO;
        public string EMAIL;


        public string idUsuario = clslogueo.idUsuario.ToString();

        public void Insertar()
        {
            clsconexion conn = new clsconexion();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "TRABAJADOR_I";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_USUARIO", idUsuario);
            cmd.Parameters.AddWithValue("@EXPEDIENTE", EXPEDIENTE);
            cmd.Parameters.AddWithValue("@NOMBRE", NOMBRE);
            cmd.Parameters.AddWithValue("@APELLIDOS", APELLIDOS);
            cmd.Parameters.AddWithValue("@SEXO", SEXO);
            cmd.Parameters.AddWithValue("@FECHANAC", FECHANAC);
            cmd.Parameters.AddWithValue("@DIRECCION", DIRECCION);
            cmd.Parameters.AddWithValue("@TELEFONO", TELEFONO);
            cmd.Parameters.AddWithValue("@EMAIL", EMAIL);
            conn.EjecutarComando(cmd);
        }

        public void Eliminar()
    {
        clsconexion conn = new clsconexion();

        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.CommandText = "TRABAJADOR_D";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@IDTRABAJADOR", IDTRABAJADOR);
        conn.EjecutarComando(cmd);
    }

        public void Editar()
    {
        clsconexion conn = new clsconexion();

        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.CommandText = "TRABAJADOR_U";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ID_TRABAJADOR", IDTRABAJADOR);
        cmd.Parameters.AddWithValue("@ID_USUARIO", idUsuario);
        cmd.Parameters.AddWithValue("@EXPEDIENTE", EXPEDIENTE);
        cmd.Parameters.AddWithValue("@NOMBRE", NOMBRE);
        cmd.Parameters.AddWithValue("@APELLIDOS", APELLIDOS);
        cmd.Parameters.AddWithValue("@SEXO", SEXO);
        cmd.Parameters.AddWithValue("@FECHANAC", FECHANAC);
        cmd.Parameters.AddWithValue("@DIRECCION", DIRECCION);
        cmd.Parameters.AddWithValue("@TELEFONO", TELEFONO);
        cmd.Parameters.AddWithValue("@EMAIL", EMAIL);
        conn.EjecutarComando(cmd);
    }

        public DataTable consultaTrabajador()
    {
        clsconexion conn = new clsconexion();
        SqlCommand cmd = new SqlCommand();
        DataTable DT;

        cmd.CommandText = "TRABAJADOR_S";
        cmd.CommandType = CommandType.StoredProcedure;
        //cmd.Parameters.AddWithValue("@titulo", titulo);
        DT = conn.GetDTable(cmd);
        return DT;
    }

        public DataTable consultaTrabajadorFull()
        {
            clsconexion conn = new clsconexion();
            SqlCommand cmd = new SqlCommand();
            DataTable DT;

            cmd.CommandText = "TRABAJADOR_BUSC";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cadena", cadena);
            DT = conn.GetDTable(cmd);
            return DT;
        }

        
    }

    }

