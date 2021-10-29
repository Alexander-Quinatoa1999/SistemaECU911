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
            var query = from hm in dc.Tbl_HistorialMed
                        join p in dc.Tbl_Personas on hm.per_id equals p.Per_id  
                        join m in dc.Tbl_MotivoConsulta on hm.Mcon_id equals m.Mcon_id
                        select new
                        {
                            hm.histo_id,
                            hm.per_id,
                            hm.Mcon_id
                        };
            grvPacientes.DataSource = query.ToList();
            grvPacientes.DataBind();

            //List<Tbl_Personas> listaPer = new List<Tbl_Personas>();
            //listaPer = CN_HistorialMedico.obtenerPersonas();
            //if (listaPer != null)
            //{
            //    grvPacientes.DataSource = listaPer;
            //    grvPacientes.DataBind();
            //}
        }

        protected void grvPacientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int codigo = Convert.ToInt32(e.CommandArgument);
            //int codigo2 = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Editar")
            {
                Response.Redirect("~/Template/Views/Historial.aspx?cod=" + codigo, true);
            }            
        }

        protected void grvPacientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            //if (txt_buscar.Text == "")
            //{
            //    cargarPaciente();
            //}
            //else
            //{
            //    var query = from p in dc.Tbl_Personas
            //                where p.Per_Cedula == Convert.ToInt32(txt_buscar.Text)
            //                select new { p.Per_Cedula, p.Per_priNombre, p.Per_priApellido, p.Per_genero, p.Per_estado, p.Per_id };

            //    if (query != null)
            //    {
            //        grvPacientes.DataSource = query.ToList();
            //        grvPacientes.DataBind();
            //    }
            //    else
            //    {
            //        cargarPaciente();
            //    }
            //}
        }
    }
}