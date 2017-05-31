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
    public class clsPendientes
    {
        public string cadena;
        public string ID_PENDIENTE;
        public string ID_USUARIO = clslogueo.idUsuario.ToString();
        public string FOLIO;
        public string EXPEDIENTE;
        public string NOMBRE_TECNICO;
        public string FOLIO_PISA;
        public string TIPO_TAREA;
        public string TELEFONO;
        public string NOMBRE_CLIENTE;
        public string DISTRITO;
        public string ZONA;
        public DateTime FECHA_CONTRATACION_RECEPCION;
        public DateTime FECHA_LLEGADA_PISAPLEX;
        public DateTime FECHA_AGENDACION_ACTUALIZADA;
        public string GRUPO_ASIGNACION;
        public string DILACION;
        public string ESTADO;
        public string CALIFICADOR;
        public DateTime FECHA_SISA;

        public string LIBRERIA;
        public string NUMERO_REFERENCIA_ARGOS;
        public string FOLIO_ARGOS;
        public string DIRECCION;
        public string CABLE_PAR;
        public string POSICION_DG;
        public string ATENCION;
        public string VALOR_CLIENTE;
        public string MERCADO;

        public string SEGMENTO;
        public string TECNOLOGIA;
        public string FAMILIA;
        public string PAQUETE;
        public string SERVICIO_DESAGREGACION;
        public string NUMERO_CONTACTO;
        public string NUMERO_CELULAR;
        
        public void Insertar()
        {
            clsconexion conn = new clsconexion();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "PENDIENTES_I";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_USUARIO", ID_USUARIO);
            cmd.Parameters.AddWithValue("@FOLIO", FOLIO);
            cmd.Parameters.AddWithValue("@EXPEDIENTE", EXPEDIENTE);
            cmd.Parameters.AddWithValue("@NOMBRE_TECNICO", NOMBRE_TECNICO);
            cmd.Parameters.AddWithValue("@FOLIO_PISA", FOLIO_PISA);
            cmd.Parameters.AddWithValue("@TIPO_TAREA", TIPO_TAREA);
            cmd.Parameters.AddWithValue("@TELEFONO", TELEFONO);
            cmd.Parameters.AddWithValue("@NOMBRE_CLIENTE", NOMBRE_CLIENTE);
            cmd.Parameters.AddWithValue("@DISTRITO", DISTRITO);
            cmd.Parameters.AddWithValue("@ZONA", ZONA);
            cmd.Parameters.AddWithValue("@FECHA_CONTRATACION_RECEPCION", FECHA_CONTRATACION_RECEPCION);
            cmd.Parameters.AddWithValue("@FECHA_LLEGADA_PISAPLEX", FECHA_LLEGADA_PISAPLEX);
            cmd.Parameters.AddWithValue("@FECHA_AGENDACION_ACTUALIZADA", FECHA_AGENDACION_ACTUALIZADA);
            cmd.Parameters.AddWithValue("@GRUPO_ASIGNACION", GRUPO_ASIGNACION);
            cmd.Parameters.AddWithValue("@DILACION", DILACION);
            cmd.Parameters.AddWithValue("@ESTADO", ESTADO);
            cmd.Parameters.AddWithValue("@CALIFICADOR", CALIFICADOR);
            cmd.Parameters.AddWithValue("@FECHA_SISA", FECHA_SISA);//
            cmd.Parameters.AddWithValue("@LIBRERIA", LIBRERIA);
            cmd.Parameters.AddWithValue("@NUMERO_REFERENCIA_ARGOS", NUMERO_REFERENCIA_ARGOS);
            cmd.Parameters.AddWithValue("@FOLIO_ARGOS", FOLIO_ARGOS);
            cmd.Parameters.AddWithValue("@DIRECCION", DIRECCION);
            cmd.Parameters.AddWithValue("@CABLE_PAR", CABLE_PAR);
            cmd.Parameters.AddWithValue("@POSICION_DG", POSICION_DG);
            cmd.Parameters.AddWithValue("@ATENCION", ATENCION);
            cmd.Parameters.AddWithValue("@VALOR_CLIENTE", VALOR_CLIENTE);
            cmd.Parameters.AddWithValue("@MERCADO", MERCADO);
            cmd.Parameters.AddWithValue("@SEGMENTO", SEGMENTO);
            cmd.Parameters.AddWithValue("@TECNOLOGIA", TECNOLOGIA);
            cmd.Parameters.AddWithValue("@FAMILIA", FAMILIA);
            cmd.Parameters.AddWithValue("@PAQUETE", PAQUETE);
            cmd.Parameters.AddWithValue("@SERVICIO_DESAGREGACION", SERVICIO_DESAGREGACION);
            cmd.Parameters.AddWithValue("@NUMERO_CONTACTO", NUMERO_CONTACTO);
            cmd.Parameters.AddWithValue("@NUMERO_CELULAR", NUMERO_CELULAR);
            conn.EjecutarComando(cmd);
        }

        public void Eliminar()
        {
            clsconexion conn = new clsconexion();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "PENDIENTES_D";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_PENDIENTE", ID_PENDIENTE);
            conn.EjecutarComando(cmd);
        }

        public void Editar()
        {
            clsconexion conn = new clsconexion();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "PLANTILLA_U";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_PENDIENTE", ID_PENDIENTE);
            cmd.Parameters.AddWithValue("@ID_USUARIO", ID_USUARIO);
            cmd.Parameters.AddWithValue("@FOLIO", FOLIO);
            cmd.Parameters.AddWithValue("@EXPEDIENTE", EXPEDIENTE);
            cmd.Parameters.AddWithValue("@NOMBRE_TECNICO", NOMBRE_TECNICO);
            cmd.Parameters.AddWithValue("@FOLIO_PISA", FOLIO_PISA);
            cmd.Parameters.AddWithValue("@TIPO_TAREA", TIPO_TAREA);
            cmd.Parameters.AddWithValue("@TELEFONO", TELEFONO);
            cmd.Parameters.AddWithValue("@NOMBRE_CLIENTE", NOMBRE_CLIENTE);
            cmd.Parameters.AddWithValue("@DISTRITO", DISTRITO);
            cmd.Parameters.AddWithValue("@ZONA", ZONA);
            cmd.Parameters.AddWithValue("@FECHA_CONTRATACION_RECEPCION", FECHA_CONTRATACION_RECEPCION);
            cmd.Parameters.AddWithValue("@FECHA_LLEGADA_PISAPLEX", FECHA_LLEGADA_PISAPLEX);
            cmd.Parameters.AddWithValue("@FECHA_AGENDACION_ACTUALIZADA", FECHA_AGENDACION_ACTUALIZADA);
            cmd.Parameters.AddWithValue("@GRUPO_ASIGNACION", GRUPO_ASIGNACION);
            cmd.Parameters.AddWithValue("@DILACION", DILACION);
            cmd.Parameters.AddWithValue("@ESTADO", ESTADO);
            cmd.Parameters.AddWithValue("@CALIFICADOR", CALIFICADOR);
            cmd.Parameters.AddWithValue("@FECHA_SISA", FECHA_SISA);//
            cmd.Parameters.AddWithValue("@LIBRERIA", LIBRERIA);
            cmd.Parameters.AddWithValue("@NUMERO_REFERENCIA_ARGOS", NUMERO_REFERENCIA_ARGOS);
            cmd.Parameters.AddWithValue("@FOLIO_ARGOS", FOLIO_ARGOS);
            cmd.Parameters.AddWithValue("@DIRECCION", DIRECCION);
            cmd.Parameters.AddWithValue("@CABLE_PAR", CABLE_PAR);
            cmd.Parameters.AddWithValue("@POSICION_DG", POSICION_DG);
            cmd.Parameters.AddWithValue("@ATENCION", ATENCION);
            cmd.Parameters.AddWithValue("@VALOR_CLIENTE", VALOR_CLIENTE);
            cmd.Parameters.AddWithValue("@MERCADO", MERCADO);
            cmd.Parameters.AddWithValue("@SEGMENTO", SEGMENTO);
            cmd.Parameters.AddWithValue("@TECNOLOGIA", TECNOLOGIA);
            cmd.Parameters.AddWithValue("@FAMILIA", FAMILIA);
            cmd.Parameters.AddWithValue("@PAQUETE", PAQUETE);
            cmd.Parameters.AddWithValue("@SERVICIO_DESAGREGACION", SERVICIO_DESAGREGACION);
            cmd.Parameters.AddWithValue("@NUMERO_CONTACTO", NUMERO_CONTACTO);
            cmd.Parameters.AddWithValue("@NUMERO_CELULAR", NUMERO_CELULAR);
            conn.EjecutarComando(cmd);
        }
        public DataTable consultaPorClave()
        {
            clsconexion conn = new clsconexion();
            SqlCommand cmd = new SqlCommand();
            DataTable DT;

            cmd.CommandText = "PLANTILLA_EXPEDIENTE";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EXPENDIENTE", EXPEDIENTE);

            DT = conn.GetDTable(cmd);
            return DT;
        }
        public DataTable consultaPlantilla()
        {
            clsconexion conn = new clsconexion();
            SqlCommand cmd = new SqlCommand();
            DataTable DT;

            cmd.CommandText = "BUSCAR_PENDIENTES";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cadena", cadena);
            DT = conn.GetDTable(cmd);
            return DT;
        }

    }
}
