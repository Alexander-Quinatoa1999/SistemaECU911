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
    public partial class Historial : System.Web.UI.Page
    {
        DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        //Objeto de la tabla personas
        private Tbl_Personas per = new Tbl_Personas();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_priNombre.Text) || string.IsNullOrEmpty(txt_priApellido.Text) || 
                string.IsNullOrEmpty(txt_sexo.Text) || string.IsNullOrEmpty(txt_edad.Text) || string.IsNullOrEmpty(txt_numHClinica.Text))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Complete los campos')", true);
            }
            else
            {
                try
                {
                    Tbl_Personas per = new Tbl_Personas();

                    per.Per_priNombre = txt_priNombre.Text;
                    per.Per_priApellido = txt_priApellido.Text;
                    per.Per_sexo = Convert.ToChar(txt_sexo.Text);
                    per.Per_edad = Convert.ToInt32(txt_edad.Text);
                    per.Per_CedulaHisCli = Convert.ToInt32(txt_numHClinica.Text);

                    dc.SubmitChanges(per);
                    
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Guardados Exitosamente')", true);

                    limpiar();

                }
                catch (Exception)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Guardados')", true);
                }
            }
        }

        private void limpiar()
        {
            txt_priNombre.Text = txt_priApellido.Text = txt_sexo.Text = txt_edad.Text = txt_numHClinica.Text = "";
        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Inicio.aspx");
        }
    }
}