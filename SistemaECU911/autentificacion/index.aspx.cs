using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit.HtmlEditor.ToolbarButtons;
using CapaDatos;
using CapaNegocio;

namespace SistemaECU911.autentificacion
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
            bool existe = CN_Usuarios.autentificar(txt_user.Text, GetMD5(txt_pass.Text));
            {
                if (String.IsNullOrEmpty(txt_user.Text) || String.IsNullOrEmpty(txt_pass.Text))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "mensaje", "swal('Error!', 'Complete los campos', 'error')", true);
                }
                else
                {
                    if (existenom)
                    {
                        if (existe)
                        {
                            Tbl_Usuarios usuario = new Tbl_Usuarios();
                            Tbl_TipoUsuario tusu = new Tbl_TipoUsuario();

                            usuario = CN_Usuarios.autentificarxLogin(txt_user.Text, GetMD5(txt_pass.Text));
                            int rol = Convert.ToInt32(usuario.tusu_id.ToString());
                            tusu = CN_TipoUsuario.obtenerTusuarioxUsuario(Convert.ToInt32(rol));
                            int tusuario = Convert.ToInt32(usuario.tusu_id);
                            if (tusuario == 1)
                            {
                                Session["Administrador"] = usuario.usu_id.ToString();
                                Session["prinombre"] = usuario.usu_priNombre.ToString();
                                Session["segnombre"] = usuario.usu_segNombre.ToString();
                                Session["priapellido"] = usuario.usu_priApellido.ToString();
                                Session["segapellido"] = usuario.usu_segApellido.ToString();
                                Session["rol"] = tusu.tusu_nombre.ToString();

                                //--------------------Datos Cambiar Usuario--------------------

                                Session["correo"] = usuario.usu_correo.ToString();
                                Session["telefono"] = usuario.usu_telefono.ToString();
                                Session["direccion"] = usuario.usu_direccion.ToString();

                                Response.Redirect("~/Template/Views/Inicio.aspx");
                                limpiar();
                            }
                            else if (tusuario == 2)
                            {
                                Session["Paciente"] = usuario.usu_id.ToString();
                                Session["Cedula"] = usuario.usu_cedula.ToString();
                                Session["prinombre"] = usuario.usu_priNombre.ToString();
                                Session["segnombre"] = usuario.usu_segNombre.ToString();
                                Session["priapellido"] = usuario.usu_priApellido.ToString();
                                Session["segapellido"] = usuario.usu_segApellido.ToString();
                                Session["rol"] = tusu.tusu_nombre.ToString();
                                Response.Redirect("~/Template/Views_Pacientes/Inicio.aspx");
                                limpiar();
                            }
                            else
                            {
                                Session["TrabajoSocial"] = usuario.usu_id.ToString();
                                Session["prinombre"] = usuario.usu_priNombre.ToString();
                                Session["segnombre"] = usuario.usu_segNombre.ToString();
                                Session["priapellido"] = usuario.usu_priApellido.ToString();
                                Session["segapellido"] = usuario.usu_segApellido.ToString();
                                Session["rol"] = tusu.tusu_nombre.ToString();
                                Response.Redirect("~/Template/Views_Socio_Economico/Inicio.aspx");
                                limpiar();
                            }
                        }
                        else
                        {
                            string intentos = (con + (Convert.ToInt32(Session["con"]))).ToString();
                            Session["Conantiguo"] = intentos.ToString();
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "mensaje", "swal('Error!', 'Credenciales Incorrectas! Intento #" + intentos + "', 'error')", true);
                            txt_pass.Text = "";
                            if (Convert.ToInt32(intentos) == 3)
                            {
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "mensaje", "swal('Error!', 'A superado el limite de intentos', 'error')", true);
                                btn_ingresar.Visible = false;
                                Session.RemoveAll();
                                Timer1.Enabled = true;
                            }
                        }
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "mensaje", "swal('Error!', 'El usuario no existe', 'error')", true);
                        limpiar();
                    }
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

        public static string GetMD5(string str)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Response.Redirect("autentificacion/Recuperar.aspx");
        }
    }
}