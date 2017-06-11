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
    public class clsordenes
    {
        public string cadena;
        public string ID_ORDEN;
        public string ID_USUARIO = clslogueo.idUsuario.ToString();
        public string ID_TRABAJADOR;
        public string TT;
        public string CLAVE;
        public string RANGO;
        public string Libreria;
        public string Area;
        public string CT;
        public string CAT;
        public string OFICINA;
        public string Folio;
        public string Telefono;
        public string Tel_Factura;
        public string Tipo_OS;
        public string Clase_Serv;
        public string Dilacion;
        public string Etapa_Actual;
        public string Deptoid;
        public string Dilacion_Etapa;
        public DateTime Fecha_Entrada;

        public string Ultima_Etapa;
        public DateTime Fecha_Ultima_Etapa;
        public string Distrito;

        //public void Insertar()
        //{
        //    clsconexion conn = new clsconexion();

        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.CommandText = "PENDIENTES_I";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@ID_USUARIO", ID_USUARIO);
        //    cmd.Parameters.AddWithValue("@ID_TRABAJADOR", ID_TRABAJADOR);
        //    cmd.Parameters.AddWithValue("@ID_PRIORIDAD", ID_PRIORIDAD);
        //    cmd.Parameters.AddWithValue("@FOLIO", FOLIO);
        //    cmd.Parameters.AddWithValue("@EXPEDIENTE", EXPEDIENTE);
        //    cmd.Parameters.AddWithValue("@NOMBRE_TECNICO", NOMBRE_TECNICO);
        //    cmd.Parameters.AddWithValue("@FOLIO_PISA", FOLIO_PISA);
        //    cmd.Parameters.AddWithValue("@TIPO_TAREA", TIPO_TAREA);
        //    cmd.Parameters.AddWithValue("@TELEFONO", TELEFONO);
        //    cmd.Parameters.AddWithValue("@NOMBRE_CLIENTE", NOMBRE_CLIENTE);
        //    cmd.Parameters.AddWithValue("@DISTRITO", DISTRITO);
        //    cmd.Parameters.AddWithValue("@ZONA", ZONA);
        //    cmd.Parameters.AddWithValue("@FECHA_CONTRATACION_RECEPCION", FECHA_CONTRATACION_RECEPCION);
        //    cmd.Parameters.AddWithValue("@FECHA_LLEGADA_PISAPLEX", FECHA_LLEGADA_PISAPLEX);
        //    cmd.Parameters.AddWithValue("@FECHA_AGENDACION_ACTUALIZADA", FECHA_AGENDACION_ACTUALIZADA);
        //    cmd.Parameters.AddWithValue("@GRUPO_ASIGNACION", GRUPO_ASIGNACION);
        //    cmd.Parameters.AddWithValue("@DILACION", DILACION);
        //    cmd.Parameters.AddWithValue("@ESTADO", ESTADO);
        //    cmd.Parameters.AddWithValue("@CALIFICADOR", CALIFICADOR);
        //    cmd.Parameters.AddWithValue("@FECHA_SISA", FECHA_SISA);//
        //    cmd.Parameters.AddWithValue("@LIBRERIA", LIBRERIA);
        //    cmd.Parameters.AddWithValue("@NUMERO_REFERENCIA_ARGOS", NUMERO_REFERENCIA_ARGOS);
        //    cmd.Parameters.AddWithValue("@FOLIO_ARGOS", FOLIO_ARGOS);
        //    cmd.Parameters.AddWithValue("@DIRECCION", DIRECCION);
        //    cmd.Parameters.AddWithValue("@CABLE_PAR", CABLE_PAR);
        //    cmd.Parameters.AddWithValue("@POSICION_DG", POSICION_DG);
        //    cmd.Parameters.AddWithValue("@ATENCION", ATENCION);
        //    cmd.Parameters.AddWithValue("@VALOR_CLIENTE", VALOR_CLIENTE);
        //    cmd.Parameters.AddWithValue("@MERCADO", MERCADO);
        //    cmd.Parameters.AddWithValue("@SEGMENTO", SEGMENTO);
        //    cmd.Parameters.AddWithValue("@TECNOLOGIA", TECNOLOGIA);
        //    cmd.Parameters.AddWithValue("@FAMILIA", FAMILIA);
        //    cmd.Parameters.AddWithValue("@PAQUETE", PAQUETE);
        //    cmd.Parameters.AddWithValue("@SERVICIO_DESAGREGACION", SERVICIO_DESAGREGACION);
        //    cmd.Parameters.AddWithValue("@NUMERO_CONTACTO", NUMERO_CONTACTO);
        //    cmd.Parameters.AddWithValue("@NUMERO_CELULAR", NUMERO_CELULAR);
        //    conn.EjecutarComando(cmd);
        //}

        //public void Eliminar()
        //{
        //    clsconexion conn = new clsconexion();

        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.CommandText = "PENDIENTES_D";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@ID_PENDIENTE", ID_PENDIENTE);
        //    conn.EjecutarComando(cmd);
        //}

        //public void Editar()
        //{
        //    clsconexion conn = new clsconexion();

        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.CommandText = "PENDIENTES_U";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@ID_PENDIENTE", ID_PENDIENTE);
        //    cmd.Parameters.AddWithValue("@ID_USUARIO", ID_USUARIO);
        //    cmd.Parameters.AddWithValue("@ID_TRABAJADOR", ID_TRABAJADOR);
        //    cmd.Parameters.AddWithValue("@ID_PRIORIDAD", ID_PRIORIDAD);
        //    cmd.Parameters.AddWithValue("@FOLIO", FOLIO);
        //    cmd.Parameters.AddWithValue("@EXPEDIENTE", EXPEDIENTE);
        //    cmd.Parameters.AddWithValue("@NOMBRE_TECNICO", NOMBRE_TECNICO);
        //    cmd.Parameters.AddWithValue("@FOLIO_PISA", FOLIO_PISA);
        //    cmd.Parameters.AddWithValue("@TIPO_TAREA", TIPO_TAREA);
        //    cmd.Parameters.AddWithValue("@TELEFONO", TELEFONO);
        //    cmd.Parameters.AddWithValue("@NOMBRE_CLIENTE", NOMBRE_CLIENTE);
        //    cmd.Parameters.AddWithValue("@DISTRITO", DISTRITO);
        //    cmd.Parameters.AddWithValue("@ZONA", ZONA);
        //    cmd.Parameters.AddWithValue("@FECHA_CONTRATACION_RECEPCION", FECHA_CONTRATACION_RECEPCION);
        //    cmd.Parameters.AddWithValue("@FECHA_LLEGADA_PISAPLEX", FECHA_LLEGADA_PISAPLEX);
        //    cmd.Parameters.AddWithValue("@FECHA_AGENDACION_ACTUALIZADA", FECHA_AGENDACION_ACTUALIZADA);
        //    cmd.Parameters.AddWithValue("@GRUPO_ASIGNACION", GRUPO_ASIGNACION);
        //    cmd.Parameters.AddWithValue("@DILACION", DILACION);
        //    cmd.Parameters.AddWithValue("@ESTADO", ESTADO);
        //    cmd.Parameters.AddWithValue("@CALIFICADOR", CALIFICADOR);
        //    cmd.Parameters.AddWithValue("@FECHA_SISA", FECHA_SISA);//
        //    cmd.Parameters.AddWithValue("@LIBRERIA", LIBRERIA);
        //    cmd.Parameters.AddWithValue("@NUMERO_REFERENCIA_ARGOS", NUMERO_REFERENCIA_ARGOS);
        //    cmd.Parameters.AddWithValue("@FOLIO_ARGOS", FOLIO_ARGOS);
        //    cmd.Parameters.AddWithValue("@DIRECCION", DIRECCION);
        //    cmd.Parameters.AddWithValue("@CABLE_PAR", CABLE_PAR);
        //    cmd.Parameters.AddWithValue("@POSICION_DG", POSICION_DG);
        //    cmd.Parameters.AddWithValue("@ATENCION", ATENCION);
        //    cmd.Parameters.AddWithValue("@VALOR_CLIENTE", VALOR_CLIENTE);
        //    cmd.Parameters.AddWithValue("@MERCADO", MERCADO);
        //    cmd.Parameters.AddWithValue("@SEGMENTO", SEGMENTO);
        //    cmd.Parameters.AddWithValue("@TECNOLOGIA", TECNOLOGIA);
        //    cmd.Parameters.AddWithValue("@FAMILIA", FAMILIA);
        //    cmd.Parameters.AddWithValue("@PAQUETE", PAQUETE);
        //    cmd.Parameters.AddWithValue("@SERVICIO_DESAGREGACION", SERVICIO_DESAGREGACION);
        //    cmd.Parameters.AddWithValue("@NUMERO_CONTACTO", NUMERO_CONTACTO);
        //    cmd.Parameters.AddWithValue("@NUMERO_CELULAR", NUMERO_CELULAR);
        //    conn.EjecutarComando(cmd);
        //}
        //public DataTable consultaPorExpediente()
        //{
        //    clsconexion conn = new clsconexion();
        //    SqlCommand cmd = new SqlCommand();
        //    DataTable DT;

        //    cmd.CommandText = "PENDIENTE_EXPEDIENTE";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@EXPENDIENTE", EXPEDIENTE);

        //    DT = conn.GetDTable(cmd);
        //    return DT;
        //}
        public DataTable consultaOrdenes()
        {
            clsconexion conn = new clsconexion();
            SqlCommand cmd = new SqlCommand();
            DataTable DT;

            cmd.CommandText = "BUSCAR_ORDENES";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cadena", cadena);
            DT = conn.GetDTable(cmd);
            return DT;
        }

    }
}
