 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaECU911.Template.Views
{
    public partial class Secundario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Timeout = 1;
            if (Session["Usuario"] !=null)
            {
                string usulogeado = Session["Usuario"].ToString();
                lbl_nombre.Text = "Bienvenido " + usulogeado;
            }
            else
            {
                Response.Redirect("../../index.aspx");
            }
        }

        protected void btn_cerrarsesion_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("../../index.aspx");
        }
    }
}