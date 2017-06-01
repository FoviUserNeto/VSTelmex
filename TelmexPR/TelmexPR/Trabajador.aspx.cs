using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;
using System.Data;

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
            this.gvUsuarios.DataSource = dt;
            this.gvUsuarios.DataBind();
        }

        protected void gvOcurrencias_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombre.Text = gvUsuarios.SelectedRow.Cells[2].Text;
            txtCargo.Text = gvUsuarios.SelectedRow.Cells[3].Text;
            txtUsuario.Text = gvUsuarios.SelectedRow.Cells[4].Text;
            txtContrasena.Text = gvUsuarios.SelectedRow.Cells[5].Text;
        }




        private void limpiar()
        {
            //Cuadros de texto
            this.txtNombre.Text = "";
            this.txtCargo.Text = "";
            this.txtUsuario.Text = "";
            this.txtContrasena.Text = "";
            this.txtRepetir.Text = "";

        }


        protected void btnGuardar_Click1(object sender, ImageClickEventArgs e)
        {
            clsusuario obj = new clsusuario();
            obj.nombreUsuario = this.txtNombre.Text;
            obj.cargo = this.txtCargo.Text;
            obj.usuario = this.txtUsuario.Text;
            obj.contraseña = this.txtContrasena.Text;
            if (this.gvUsuarios.SelectedIndex == -1)
            {
                obj.Insertar();
            }
            else
            {
                obj.idUsuario = this.gvUsuarios.SelectedValue.ToString();
                obj.nombreUsuario = this.txtNombre.Text;
                obj.cargo = this.txtCargo.Text;
                obj.usuario = this.txtUsuario.Text;
                obj.contraseña = this.txtContrasena.Text;
                obj.Editar();
                this.gvUsuarios.SelectedIndex = -1;
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
            txtNombre.Text = gv.Cells[2].Text;
            txtCargo.Text = gv.Cells[3].Text;
            txtUsuario.Text = gv.Cells[4].Text;
            txtContrasena.Text = gv.Cells[5].Text;
            this.ModalPopupExtender1.Show();

        }

        protected void btnEliminar_Click(object sender, ImageClickEventArgs e)
        {
            clsusuario obj = new clsusuario();
            obj.idUsuario = this.gvUsuarios.SelectedValue.ToString();
            obj.Eliminar();
            this.gvUsuarios.SelectedIndex = -1;
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
    }
}