using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Usuarios
    {

        //Instanciamos el dbml
        private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();
        //metodo para verificar credenciales
        public static bool autentificar(string usuario, string pass)
        {
            var auto = dc.Tbl_Usuarios.Any(usu => usu.usu_estado == "A" && usu.usu_nomlogin.Equals(usuario) && usu.usu_pass.Equals(pass));
            return auto;
        }
        //metodo para verificar si existe el usuario
        public static Tbl_Usuarios obtenerUsuariosxCedula(string cedula)
        {
            var usuced = dc.Tbl_Usuarios.FirstOrDefault(usu => usu.usu_cedula.Equals(cedula) && usu.usu_estado == "A");
            return usuced;
        }
        //metodo para verificar si existe el nombre
        public static bool autentificarxCedula(int cedula)
        {
            var auto = dc.Tbl_Usuarios.Any(usu => usu.usu_estado == "A" && usu.usu_cedula.Equals(cedula));
            return auto;
        }
        //metodo para verificar si existe el nombre de usuario
        public static Tbl_Usuarios obtenerUsuariosxNomUsuario(string usuario)
        {
            var usunom = dc.Tbl_Usuarios.FirstOrDefault(usu => usu.usu_nomlogin.Equals(usuario) && usu.usu_estado == "A");
            return usunom;
        }
        //metodo para verificar si existe el nombre
        public static bool autentificarxNomUsuario(string usuario)
        {
            var auto = dc.Tbl_Usuarios.Any(usu => usu.usu_estado == "A" && usu.usu_nomlogin.Equals(usuario));
            return auto;
        }
        //metodo para verificar si existe el nombre
        public static bool autentificarxNom(string usuario)
        {
            var auto = dc.Tbl_Usuarios.Any(usu => usu.usu_estado == "A" && usu.usu_nomlogin.Equals(usuario));
            return auto;
        }
        //metodo para traer el objeto
        public static Tbl_Usuarios autentificarxLogin(string usuario, string pass)
        {
            var nlogin = dc.Tbl_Usuarios.Single(usu => usu.usu_estado == "A" && usu.usu_nomlogin.Equals(usuario) && usu.usu_pass.Equals(pass));
            return nlogin;
        }
        //metodo para obtener los usuarios por su id
        public static Tbl_Usuarios obtenerUsuariosxId(int id)
        {
            var respid = dc.Tbl_Usuarios.FirstOrDefault(usu => usu.usu_id.Equals(id) && usu.usu_estado == "A");
            return respid;
        }
        ////metodo para obtener los cedula por id persona
        //public static Tbl_Personas obtenerCedulaxIdPersona(int id)
        //{
        //    var respid = dc.Tbl_Personas.FirstOrDefault(per => per.Per_id.Equals(id) && per.Per_estado == "A");
        //    return respid;
        //}
        //Metodo para obtener contraseña anterior
        public static bool autentificarxUsuario(int usu, string pass)
        {
            var auto = dc.Tbl_Usuarios.Any(usup => usup.usu_estado == "A" && usup.usu_id.Equals(usu) && usup.usu_pass.Equals(pass));
            return auto;
        }
        //metodo para verificar si existe el correo
        public static bool autentificarxCorreo(string correo)
        {
            var auto = dc.Tbl_Usuarios.Any(usu => usu.usu_estado == "A" && usu.usu_correo == (correo));
            return auto;
        }
        //metodo para obtener el correo
        public static Tbl_Usuarios obtenerCorreo(string correo)
        {
            var contra = dc.Tbl_Usuarios.Single(usu => usu.usu_estado == "A" && usu.usu_correo.Equals(correo));
            return contra;
        }

        public static void GuardarUsuario(Tbl_Usuarios usu)
        {
            try
            {
                dc.Tbl_Usuarios.InsertOnSubmit(usu);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Los datos no han sido guardados <br/>" + ex.Message);
            }
        }
        public static void ModificarUsuarios(Tbl_Usuarios usu)
        {
            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Los datos no han sido modificados <br/>" + ex.Message);
            }
        }
        //public static void delete(Tbl_Usuarios usu)
        //{
        //    try
        //    {
        //        usu.usu_estado = "I";
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Los datos no han sido eliminados <br/>" + ex.Message);
        //    }
        //}
        //public static void change(Tbl_Usuarios usu)
        //{
        //    try
        //    {
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Los datos no han sido modificados <br/>" + ex.Message);
        //    }
        //}

    }
}
