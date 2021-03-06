using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaECU911.Template.Views
{
    public partial class PacientesSocioEconomico : System.Web.UI.Page
    {

        DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarPaciente();
                //grvPacientes.VirtualItemCount = Count();
            }
        }

        private void cargarPaciente()
        {
            List<Tbl_Personas> listaPer = new List<Tbl_Personas>();
            listaPer = CN_HistorialMedico.ObtenerPersonas();

            if (listaPer != null)
            {
                grvPacientesSocioEconomico.DataSource = listaPer;
                grvPacientesSocioEconomico.DataBind();
            }
        }

        protected void grvPacientesSocioEconomico_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int codigo = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Editar")
            {
                Response.Redirect("~/Template/Views/SocioEconomico.aspx?cod=" + codigo, true);
            }
        }

    }
}