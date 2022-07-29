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
            var auto = dc.Tbl_Usuario.Any(usu => usu.usu_estado == "A" && usu.usu_nomlogin.Equals(usuario) && usu.usu_pass.Equals(pass));
            return auto;
        }
        //metodo para verificar si existe el usuario
        public static Tbl_Usuario obtenerUsuariosxCedula(int cedula)
        {
            var usuced = dc.Tbl_Usuario.FirstOrDefault(usu => usu.usu_cedula.Equals(cedula) && usu.usu_estado == "A");
            return usuced;
        }
        //metodo para verificar si existe el nombre
        public static bool autentificarxCedula(int cedula)
        {
            var auto = dc.Tbl_Usuario.Any(usu => usu.usu_estado == "A" && usu.usu_cedula.Equals(cedula));
            return auto;
        }
        //metodo para verificar si existe el nombre de usuario
        public static Tbl_Usuario obtenerUsuariosxNomUsuario(string usuario)
        {
            var usunom = dc.Tbl_Usuario.FirstOrDefault(usu => usu.usu_nomlogin.Equals(usuario) && usu.usu_estado == "A");
            return usunom;
        }
        //metodo para verificar si existe el nombre
        public static bool autentificarxNomUsuario(string usuario)
        {
            var auto = dc.Tbl_Usuario.Any(usu => usu.usu_estado == "A" && usu.usu_nomlogin.Equals(usuario));
            return auto;
        }
        //metodo para verificar si existe el nombre
        public static bool autentificarxNom(string usuario)
        {
            var auto = dc.Tbl_Usuario.Any(usu => usu.usu_estado == "A" && usu.usu_nomlogin.Equals(usuario));
            return auto;
        }
        //metodo para traer el objeto
        public static Tbl_Usuario autentificarxLogin(string usuario, string pass)
        {
            var nlogin = dc.Tbl_Usuario.Single(usu => usu.usu_estado == "A" && usu.usu_nomlogin.Equals(usuario) && usu.usu_pass.Equals(pass));
            return nlogin;
        }
        //metodo para obtener los usuarios por su id
        public static Tbl_Usuario obtenerUsuariosxId(int id)
        {
            var respid = dc.Tbl_Usuario.FirstOrDefault(usu => usu.usu_id.Equals(id) && usu.usu_estado == "A");
            return respid;
        }
        //Metodo para obtener contraseña anterior
        public static bool autentificarxUsuario(int usu, string pass)
        {
            var auto = dc.Tbl_Usuario.Any(usup => usup.usu_estado == "A" && usup.usu_id.Equals(usu) && usup.usu_pass.Equals(pass));
            return auto;
        }
        //metodo para verificar si existe el correo
        public static bool autentificarxCorreo(string correo)
        {
            var auto = dc.Tbl_Usuario.Any(usu => usu.usu_estado == "A" && usu.usu_correo == (correo));
            return auto;
        }
        //metodo para obtener el correo
        public static Tbl_Usuario obtenerCorreo(string correo)
        {
            var contra = dc.Tbl_Usuario.Single(usu => usu.usu_estado == "A" && usu.usu_correo.Equals(correo));
            return contra;
        }
        public static void save(Tbl_Usuario usu)
        {
            try
            {
                usu.usu_estado = "A";
                dc.Tbl_Usuario.InsertOnSubmit(usu);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Los datos no han sido guardados <br/>" + ex.Message);
            }
        }
        public static void modify(Tbl_Usuario usu)
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
        public static void delete(Tbl_Usuario usu)
        {
            try
            {
                usu.usu_estado = "I";
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Los datos no han sido eliminados <br/>" + ex.Message);
            }
        }
        public static void change(Tbl_Usuario usu)
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

    }
}
