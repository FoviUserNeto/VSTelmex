using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;
using System.Data;
using AjaxControlToolkit;

namespace TelmexPR
{
    public partial class Trabajador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                llenarTabla();
            }
        }
        public void llenarTabla()
        {
            clstrabajador obj = new clstrabajador();
            DataTable dt;

            dt = obj.consultaUsuarios();
            this.gvTrabajador.DataSource = dt;
            this.gvTrabajador.DataBind();
        }

   
        private void limpiar()
        {
            //Cuadros de texto
            this.txtNombre.Text = "";
            this.txtExpediente.Text = "";
            this.txtApellidos.Text = "";
            this.txtFecha.Text = "";
            this.txtDireccion.Text = "";
            this.txtTelefono.Text = "";
            this.txtEmail.Text = "";

        }


        protected void btnGuardar_Click1(object sender, ImageClickEventArgs e)
        {
            clstrabajador obj = new clstrabajador();
            obj.EXPEDIENTE = this.txtExpediente.Text;
            obj.NOMBRE = this.txtNombre.Text;
            obj.APELLIDOS = this.txtApellidos.Text;
            obj.SEXO = this.ddwSexo.Text;
            obj.FECHANAC = this.txtFecha.Text;
            obj.DIRECCION = this.txtDireccion.Text;
            obj.TELEFONO = this.txtTelefono.Text;
            obj.EMAIL = this.txtEmail.Text;
            if (this.gvTrabajador.SelectedIndex == -1)
            {
                obj.Insertar();
            }
            else
            {
                obj.IDTRABAJADOR = this.gvTrabajador.SelectedValue.ToString();
                obj.EXPEDIENTE = this.txtExpediente.Text;
                obj.NOMBRE = this.txtNombre.Text;
                obj.APELLIDOS = this.txtApellidos.Text;
                obj.SEXO = this.ddwSexo.Text;
                obj.FECHANAC = this.txtFecha.Text;
                obj.DIRECCION = this.txtDireccion.Text;
                obj.TELEFONO = this.txtTelefono.Text;
                obj.EMAIL = this.txtEmail.Text;
                obj.Editar();
                this.gvTrabajador.SelectedIndex = -1;
            }

            llenarTabla();
            limpiar();
        }

        protected void btnEliminar_Click1(object sender, ImageClickEventArgs e)
        {

        }

        protected void btnSalir_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }

        protected void btnEditar_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton imgBtn = (ImageButton)sender;
            GridViewRow gv = (GridViewRow)imgBtn.NamingContainer;
            txtExpediente.Text = gv.Cells[2].Text;
            txtNombre.Text = gv.Cells[3].Text;
            txtApellidos.Text = gv.Cells[4].Text;
            ddwSexo.Text = gv.Cells[5].Text;
            txtFecha.Text = gv.Cells[6].Text;
            txtDireccion.Text = gv.Cells[7].Text;
            txtTelefono.Text = gv.Cells[8].Text;
            txtEmail.Text = gv.Cells[9].Text;
            this.ModalPopupExtender1.Show();

        }

        protected void btnEliminar_Click(object sender, ImageClickEventArgs e)
        {
            clstrabajador obj = new clstrabajador();
            obj.IDTRABAJADOR = this.gvTrabajador.SelectedValue.ToString();
            obj.Eliminar();
            this.gvTrabajador.SelectedIndex = -1;
            llenarTabla();
            limpiar();

        }

        protected void btnNuevo_Click(object sender, ImageClickEventArgs e)
        {
            this.ModalPopupExtender1.Show();
        }

        protected void btnImprimir_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Reportes/ReporteTrabajador.aspx");
        }

        protected void btnBuscar_Click(object sender, ImageClickEventArgs e)
        {
            LlenarUsuarios();
        }
        private void LlenarUsuarios()
        {
            //clsUsuarios obj = new clsUsuarios();
            //obj.cadena = this.txtBuscar.Text;
            //gvUsuarios.DataSource = obj.consultaUsuarios();
            //gvUsuarios.DataBind();
        }

        protected void gvTrabajador_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtExpediente.Text = gvTrabajador.SelectedRow.Cells[2].Text;
            txtNombre.Text = gvTrabajador.SelectedRow.Cells[3].Text;
            txtApellidos.Text = gvTrabajador.SelectedRow.Cells[4].Text;
            ddwSexo.Text = gvTrabajador.SelectedRow.Cells[5].Text;
            txtFecha.Text = gvTrabajador.SelectedRow.Cells[6].Text;
            txtDireccion.Text = gvTrabajador.SelectedRow.Cells[7].Text;
            txtTelefono.Text = gvTrabajador.SelectedRow.Cells[8].Text;
            txtEmail.Text = gvTrabajador.SelectedRow.Cells[9].Text;
        }
    }
}