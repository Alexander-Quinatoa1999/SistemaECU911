using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.Linq;

namespace CapaNegocio
{
    public class CN_HistorialMedico
    {

        private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        //metodo traer para todos los usuarios
        public static List<Tbl_Personas> obtenerPersonas()
        {
            var listaPer = dc.Tbl_Personas.Where(per => per.Per_estado == 'A');
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
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //Metodo para guardar datos motivo de consulta
        public static void guardarMotiConsulta(Tbl_MotivoConsulta motcons)
        {
            try
            {
                motcons.Mcon_estado = 'A';
                dc.Tbl_MotivoConsulta.InsertOnSubmit(motcons);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //Obtener los datos para historial medico

    }


}
