using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaECU911.Template.Views
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txt_fecha.Text = DateTime.Now.ToString(" dd/MM/yyyy " + " HH:mm ");
                txt_fecha.Enabled = false;
            }
        }
    }
}