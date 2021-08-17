using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaNegocio;

namespace SistemaECU911.Template.Views
{
    public partial class Pacientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarPaciente();
            }
        }

        private void cargarPaciente()
        {
            List<Tbl_Personas> listaPer = new List<Tbl_Personas>();
            listaPer = CN_HistorialMedico.obtenerPersonas();
            if (listaPer != null)
            {
                grvPacientes.DataSource = listaPer;
                grvPacientes.DataBind();
            }
        }
    }
}