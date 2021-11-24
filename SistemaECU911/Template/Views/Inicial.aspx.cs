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
	public partial class Inicial : System.Web.UI.Page
	{

		DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        //Objeto de la tabla motivo de consulta
        private Tbl_AntecedentesCliQuiru antcliqui = new Tbl_AntecedentesCliQuiru();

        protected void Page_Load(object sender, EventArgs e)
		{
            
		}

        private void GuardarHistorial()
        {
            try
            {
                //Guardar Persona
                if (string.IsNullOrEmpty(txt_antCliQuiDescripcion.Text) || string.IsNullOrEmpty(txt_moConsulta.Text) ||
                    string.IsNullOrEmpty(txt_codigo.Text))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Complete los campos')", true);
                }
                else
                {

                    antcliqui = new Tbl_AntecedentesCliQuiru();


                    //captura de datos tbl_motivoconsulta
                    antcliqui.AntCliQuiru_descripcion = txt_antCliQuiDescripcion.Text;                    

                    //metodo de guardar motivo de consulta
                    CN_Inicial.guardarAntCliniQuirur(antcliqui);                    

                    //Mensaje de confirmacion
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Guardados Exitosamente')", true);

                    Response.Redirect("~/Template/Views/Pacientes.aspx");
                    limpiar();

                }

            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Guardados')", true);
            }

        }

        private void limpiar()
        {
            txt_antCliQuiDescripcion.Text = "";  
        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            GuardarHistorial();
        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/Views/Inicio.aspx");
        }
    }
}