using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaNegocio;

namespace SistemaECU911
{
    public partial class index : System.Web.UI.Page
    {

        private static int con = 1;

        //Instanciamos la BD
        DataClassesECU911DataContext dc = new DataClassesECU911DataContext();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Timer1.Enabled = false;
            }
            Session["con"] = Session["Conantiguo"];
        }

        private void logear()
        {
            bool existenom = CN_Usuarios.autentificarxNom(txt_user.Text);
            bool existe = CN_Usuarios.autentificar(txt_user.Text, /*encriptar(*/txt_pass.Text)/*)*/;
            {
                if (existenom)
                {
                    if (existe)
                    {
                        Tbl_Usuario usuario = new Tbl_Usuario();
                        Tbl_TipoUsuario tusu = new Tbl_TipoUsuario();
                        usuario = CN_Usuarios.autentificarxLogin(txt_user.Text, /*encriptar(*/txt_pass.Text)/*)*/;
                        int rol = Convert.ToInt32(usuario.tusu_id.ToString());
                        tusu = CN_TipoUsuario.obtenerTusuarioxUsuario(Convert.ToInt32(rol));
                        int tusuario = Convert.ToInt32(usuario.tusu_id);
                        if (tusuario == 1)
                        {
                            Session["ADMIN"] = usuario.usu_id.ToString();
                            Session["nombre"] = usuario.usu_nombre.ToString();
                            Session["apellido"] = usuario.usu_apellido.ToString();
                            Session["rol"] = tusu.tusu_nombre.ToString();
                            Response.Redirect("~/Template/Views/Inicio.aspx");
                            limpiar();
                        }
                        else 
                        {
                            Session["PASANTE"] = usuario.usu_id.ToString();
                            Session["nombre"] = usuario.usu_nombre.ToString();
                            Session["apellido"] = usuario.usu_apellido.ToString();
                            Session["rol"] = tusu.tusu_nombre.ToString();
                            Response.Redirect("~/Template/Views/Secundario.aspx");
                            limpiar();
                        }
                    }
                    else
                    {
                        string intentos = (con + (Convert.ToInt32(Session["con"]))).ToString();
                        Session["Conantiguo"] = intentos.ToString();
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "mensaje", "swal('Error!', 'Credenciales Incorrectas! Intento #" + intentos + "', 'error')", true);
                        txt_pass.Text = "";
                        if (Convert.ToInt32(intentos) == 2)
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "mensaje", "swal('Error!', 'A superado el limite de intentos.', 'error')", true);
                            btn_ingresar.Visible = false;
                            Session.RemoveAll();
                            Timer1.Enabled = true;
                        }
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "mensaje", "swal('Error!', 'El usuario no existe.', 'error')", true);
                    limpiar();
                }
            }
        }

        protected void btn_ingresar_Click(object sender, EventArgs e)
        {
            logear();
        }

        private void limpiar()
        {
            txt_user.Text = txt_pass.Text = "";
        }

        string encriptar(string cadena)
        {
            string resultado = string.Empty;
            byte[] encriptar = System.Text.Encoding.Unicode.GetBytes(cadena);
            resultado = Convert.ToBase64String(encriptar);
            return resultado;
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}