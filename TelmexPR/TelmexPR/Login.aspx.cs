using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Logica;

namespace TelmexPR
{
    public partial class Login : System.Web.UI.Page
    {
               protected void ddwUsuario_SelectedIndexChanged1(object sender, EventArgs e)
        {
            txtUsuario.Text = Convert.ToString(ddwUsuario.SelectedValue);

        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                clslogueo obj = new clslogueo();
                ddwUsuario.DataSource = obj.consultaPersonal();
                ddwUsuario.DataValueField = "USUARIO";
                ddwUsuario.DataTextField = "NOMBRE";
                ddwUsuario.DataBind();
                this.ddwUsuario.Items.Insert(0, new ListItem("Elija una Opcion..", "0"));

            }


            HttpCookie cookie = Request.Cookies["UserInfo"];
            if (cookie != null)
            {
                string id = cookie["ID_USUARIO"].ToString();
                //Session["UserName"] = usuario;
                Response.Redirect("~/Inicio.aspx");
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Usuarios.aspx");

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }


        protected void btnIngresar_Click1(object sender, EventArgs e)
        {
            if (clslogueo.Credenciales(txtUsuario.Text, txtContraseña.Text) == true)
            {
                if (ckRecordar.Checked == true)
                {
                    HttpCookie aCookie = new HttpCookie("UserInfo");
                    aCookie.Values["ID_USUARIO"] = clslogueo.idUsuario.ToString();
                    aCookie.Values["NOMBRE"] = clslogueo.nombreUsuario.ToString();
                    aCookie.Values["CARGO"] = clslogueo.cargo.ToString();
                    aCookie.Values["USUARIO"] = clslogueo.usuario.ToString();
                    aCookie.Values["CONTRASEÑA"] = clslogueo.contrasena.ToString();
                    aCookie.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(aCookie);

                    Response.Redirect("~/Inicio.aspx");

                }
                else
                {
                    Response.Redirect("~/Inicio.aspx");

                }

            }
        }
        
    }
}