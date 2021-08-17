using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaECU911.Template.Views
{
    public partial class Principal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Timeout = 30;
            if (Session["Admin"] != null)
            {
                string usulogeado = Session["Admin"].ToString();
                lbl_nombre.Text = "Bienvenido " + usulogeado;
            }
            else
            {
                Response.Redirect("../../index.aspx");
            }
        }

        protected void Lnb_CerrarSesion_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("../../index.aspx");
        }
    }
}