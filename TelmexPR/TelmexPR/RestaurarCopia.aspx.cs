using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Data.Common;
using System.Configuration;
using Logica;

namespace TelmexPR
{
    public partial class RestaurarCopia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
         
        }

        protected void btnRestaurar_Click(object sender, EventArgs e)
        {
            string excelPath = Server.MapPath("~/Fuentes/temp/") + Path.GetFileName(FileBackup.PostedFile.FileName);
            FileBackup.SaveAs(excelPath);

        }
    }
}