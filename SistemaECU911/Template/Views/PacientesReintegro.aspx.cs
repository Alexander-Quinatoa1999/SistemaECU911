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
    public partial class PacientesReintegro : System.Web.UI.Page
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
            var query = from r in dc.Tbl_Reintegro
                        join p in dc.Tbl_Personas on r.Per_id equals p.Per_id
                        join pro in dc.Tbl_Profesional on r.prof_id equals pro.prof_id
                        orderby r.rein_fecha_hora descending
                        select new
                        {
                            r.rein_id,
                            p.Per_Cedula,
                            p.Per_priNombre,
                            p.Per_priApellido,
                            pro.prof_NomApe,
                            r.rein_fecha_hora
                        };

            grvPacientesReintegro.DataSource = query.ToList();
            grvPacientesReintegro.DataBind();
        }

        protected void grvPacientesReintegro_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int codigo = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Editar")
            {
                Response.Redirect("~/Template/Views/Reintegro.aspx?cod=" + codigo, true);
            }
        }
    }
}