﻿using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaECU911.Template.Views
{
    public partial class PacientesEvolucion : System.Web.UI.Page
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
            var query = from e in dc.Tbl_Evolucion
                        join p in dc.Tbl_Personas on e.Per_id equals p.Per_id
                        orderby e.evo_fechaHora descending
                        select new
                        {
                            e.evo_id,
                            p.Per_Cedula,
                            p.Per_priNombre,
                            p.Per_priApellido,
                            e.evo_fechaHora
                        };

            grvPacientesEvolucion.DataSource = query.ToList();
            grvPacientesEvolucion.DataBind();
        }

        protected void grvPacientesEvolucion_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int codigo = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Editar")
            {
                Response.Redirect("~/Template/Views/Evolucion.aspx?cod=" + codigo, true);
            }
        }
    }
}