using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Periodica
    {
        private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        public static List<Tbl_Empresa> ObtenerEmpresa()
        {
            var listaEmp = dc.Tbl_Empresa.Where(emp => emp.Emp_estado == 'A');
            return listaEmp.ToList();
        }

        public static Tbl_Periodica ObtenerPeriodicaPorId(int id)
        {
            var perioid = dc.Tbl_Periodica.FirstOrDefault(periodica => periodica.perio_id.Equals(id) && periodica.perio_estado == "A");
            return perioid;
        }

        public static Tbl_Periodica ObtenerPeriodicaPer(int personaid)
        {
            var perioid = dc.Tbl_Periodica.FirstOrDefault(periodica => periodica.Per_id.Equals(personaid) && periodica.perio_estado == "A");
            return perioid;
        }

        //metodo para traer profesional
        public static List<Tbl_Profesional> ObtenerProfesional()
        {
            var lista = dc.Tbl_Profesional.Where(prof => prof.prof_estado == "A");
            return lista.ToList();
        }

        //----------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------ METODOS PARA GUARDAR Y MODIFICAR DATOS  -----------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------

        // Metodo para guardar datos de Ficha Medica
        public static void GuardarPeriodica(Tbl_Periodica periodica)
        {
            try
            {
                periodica.perio_estado = "A";
                periodica.perio_fecha_hora = DateTime.Now;
                dc.Tbl_Periodica.InsertOnSubmit(periodica);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de HC INIPERIODICACIAL" + ex.Message);
            }
        }

        public static void ModificarPeriodica(Tbl_Periodica periodica)
        {
            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de HC PERIODICA" + ex.Message);
            }
        }
    }
}
