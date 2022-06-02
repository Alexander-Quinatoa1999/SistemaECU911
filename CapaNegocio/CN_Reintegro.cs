using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Reintegro
    {
        private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        public static List<Tbl_Empresa> ObtenerEmpresa()
        {
            var listaEmp = dc.Tbl_Empresa.Where(emp => emp.Emp_estado == 'A');
            return listaEmp.ToList();
        }

        public static Tbl_Reintegro ObtenerReintegroPorId(int id)
        {
            var reinid = dc.Tbl_Reintegro.FirstOrDefault(reintegro => reintegro.rein_id.Equals(id) && reintegro.rein_estado == "A");
            return reinid;
        }

        public static Tbl_Reintegro ObtenerReintegroPer(int personaid)
        {
            var reinid = dc.Tbl_Reintegro.FirstOrDefault(reintegro => reintegro.Per_id.Equals(personaid) && reintegro.rein_estado == "A");
            return reinid;
        }

        public static List<Tbl_Profesional> ObtenerProfesional()
        {
            var lista = dc.Tbl_Profesional.Where(prof => prof.prof_estado == "A");
            return lista.ToList();
        }

        //----------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------ METODOS PARA GUARDAR Y MODIFICAR DATOS  -----------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------

        public static void GuardarReintegro(Tbl_Reintegro reintegro)
        {
            try
            {
                reintegro.rein_estado = "A";
                reintegro.rein_fechaHoraGuardado = DateTime.Now;
                dc.Tbl_Reintegro.InsertOnSubmit(reintegro);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de HC REINTEGRO" + ex.Message);
            }
        }

        public static void ModificarReintegro(Tbl_Reintegro reintegro)
        {
            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de HC REINTEGRO" + ex.Message);
            }
        }
    }
}
