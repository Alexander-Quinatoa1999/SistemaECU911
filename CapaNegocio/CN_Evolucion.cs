using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Evolucion
    {

        private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        public static List<Tbl_Empresa> ObtenerEmpresa()
        {
            var listaEmp = dc.Tbl_Empresa.Where(emp => emp.Emp_estado == "A");
            return listaEmp.ToList();
        }

        public static Tbl_Evolucion ObtenerEvolucionPorId(int id)
        {
            var evoid = dc.Tbl_Evolucion.FirstOrDefault(evolucion => evolucion.evo_id.Equals(id) && evolucion.evo_estado == "A");
            return evoid;
        }

        public static Tbl_Evolucion ObtenerEvolucionPer(int personaid)
        {
            var evoid = dc.Tbl_Evolucion.FirstOrDefault(evolucion => evolucion.Per_id.Equals(personaid) && evolucion.evo_estado == "A");
            return evoid;
        }

        public static List<Tbl_Profesional> ObtenerProfesional()
        {
            var lista = dc.Tbl_Profesional.Where(prof => prof.prof_estado == "A");
            return lista.ToList();
        }

        //----------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------ METODOS PARA GUARDAR Y MODIFICAR DATOS  -----------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------

        public static void GuardarEvolucion(Tbl_Evolucion evolucion)
        {
            try
            {
                evolucion.evo_estado = "A";
                dc.Tbl_Evolucion.InsertOnSubmit(evolucion);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de HC EVOLUCION" + ex.Message);
            }
        }

        public static void ModificarEvolucion(Tbl_Evolucion evolucion)
        {
            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de HC EVOLUCION" + ex.Message);
            }
        }

    }
}
