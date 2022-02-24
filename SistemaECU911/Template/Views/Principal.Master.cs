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
            if (Session["Admin"] != null)
            {
                string usulogeado = Session["Admin"].ToString();
                string resNom = Session["nombre"].ToString();
                string resApe = Session["apellido"].ToString();
                string resRol = Session["rol"].ToString();
                lbl_nombre.Text = resNom + " " + resApe;
                //lblRol.Text = resRol;
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