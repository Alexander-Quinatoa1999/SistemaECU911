using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;

namespace SistemaECU911
{
    public partial class index : System.Web.UI.Page
    {

        private static int contador = 1;

        //Instanciamos la BD
        DataClassesECU911DataContext dc = new DataClassesECU911DataContext();
        
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_user.Text) || string.IsNullOrEmpty(txt_pass.Text))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Llene los Datos!!')", true);
            }
            else
            {
                logear(txt_user.Text, txt_pass.Text);
            }
        }

        private void logear(string usu, string pass)
        {

            var query1 = dc.Autentificacion_Usuario(usu, pass);
            var query = dc.Validar_Existencia(usu);

            if (query.ToList().Count == 1)
            {

                if (query1.ToList().Count > 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Bienvenido')", true);
                    Response.Redirect("~/Template/Views/Principal.aspx");
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Usuario y/o Contraseña Incorrecta va " + contador + " intentos')", true);
                    contador++;

                    if (contador > 3)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Supero el limite te intentos')", true);
                        limpiar();
                        btn_ingresar.Visible = false;
                    }
                }

            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('El usuario no existe !!')", true);
            }
        }

        private void limpiar()
        {
            txt_user.Text = txt_pass.Text = "";
        }

        private object pass_encriptada(string text)
        {
            throw new NotImplementedException();
        }
    }
}