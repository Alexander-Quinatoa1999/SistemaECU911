using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Personas
    {

        //private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();
        private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        //metodo traer para todos los usuarios x ID
        public static Tbl_Personas obtenerPersonasxCedula(int ced)
        {
            var perid = dc.Tbl_Personas.FirstOrDefault(per => per.Per_cedula.Equals(ced) && per.Per_estado == "A");
            return perid;
        }

        public static Tbl_Personas ObtenerPersonaPorId(int id)
        {
            var perid = dc.Tbl_Personas.FirstOrDefault(per => per.Per_id.Equals(id));
            return perid;
        }

        //metodo para traer empresa
        public static List<Tbl_Empresa> ObtenerEmpresa()
        {
            var lista = dc.Tbl_Empresa.Where(prof => prof.Emp_estado == "A");
            return lista.ToList();
        }

        // Metodo para guardar datos de las persona
        public static void GuardarPersona(Tbl_Personas per)
        {
            try
            {
                dc.Tbl_Personas.InsertOnSubmit(per);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de la persona" + ex.Message);
            }
        }

        // Metodo para modificar datos de las personas
        public static void ModificarPersona(Tbl_Personas per)
        {
            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de la persona" + ex.Message);
            }
        }

    }
}
