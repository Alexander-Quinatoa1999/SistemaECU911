using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaECU911
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btn_ingresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Template/Views/Principal.aspx");
        }
    }
}