﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TelmexPR.Reportes
{
    public partial class ReportPendientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPrincipal_Click(object sender, ImageClickEventArgs e)
        {

            Response.Redirect("~/Inicio.aspx");
        }
    }
}