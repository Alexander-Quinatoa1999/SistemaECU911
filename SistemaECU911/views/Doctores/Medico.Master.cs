using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaECU911.views.Doctores
{
    public partial class Medico : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbn_configuracion_Click(object sender, EventArgs e)
        {
            Response.Redirect("Configuracion.aspx");
        }

        protected void lnb_cerrarsesion_Click(object sender, EventArgs e)
        {

        }
               
    }
}