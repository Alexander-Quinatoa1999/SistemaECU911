using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_SocioEconomico
    {

        private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        public static Tbl_SocioEconomico ObtenerSocioEconomicoPorId(int id)
        {
            var ssoid = dc.Tbl_SocioEconomico.FirstOrDefault(socioEconomico => socioEconomico.Socio_economico_id.Equals(id) && socioEconomico.Socio_economico__estado == "A");
            return ssoid;
        }

        public static Tbl_SocioEconomico ObtenerSocioEconomicoPer(int personaid)
        {
            var ssoid = dc.Tbl_SocioEconomico.FirstOrDefault(socioEconomico => socioEconomico.Per_id.Equals(personaid) && socioEconomico.Socio_economico__estado == "A");
            return ssoid;
        }

        public static List<Tbl_Profesional> ObtenerProfesional()
        {
            var lista = dc.Tbl_Profesional.Where(prof => prof.prof_estado == "A");
            return lista.ToList();
        }

        //----------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------ METODOS PARA GUARDAR Y MODIFICAR DATOS  -----------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------

        public static void GuardarSocioEconomico(Tbl_SocioEconomico socioEconomico)
        {
            try
            {
                socioEconomico.Socio_economico__estado = "A";
                socioEconomico.Socio_economico_fechaHoraGuardado = DateTime.Now;
                dc.Tbl_SocioEconomico.InsertOnSubmit(socioEconomico);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de SOCIO ECONOMICO" + ex.Message);
            }
        }

        public static void ModificarSocioEconomico(Tbl_SocioEconomico socioEconomico)
        {
            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de SOCIO ECONOMICO" + ex.Message);
            }
        }

    }
}
