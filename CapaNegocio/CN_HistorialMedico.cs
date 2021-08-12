using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_HistorialMedico
    {

        private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        //metodo traer para todos los usuarios
        public static List<Tbl_Personas> obtenerPersonas()
        {
            var listaPer = dc.Tbl_Personas.Where(per => per. == 'A');
            return listaPer.ToList();
        }

        //Metodo para guardar datos Persona
        public static void guardarPersona(Tbl_Personas per)
        {
            try
            {
                per.Per_estado = 'A';
                dc.Tbl_Personas.InsertOnSubmit(per);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos no guardados <br/>" + ex.Message);
            }
        }

        //Obtener los datos para historial medico

    }

    
}
