using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Retiro
    {
        private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        public static List<Tbl_Empresa> ObtenerEmpresa()
        {
            var listaEmp = dc.Tbl_Empresa.Where(emp => emp.Emp_estado == "A");
            return listaEmp.ToList();
        }

        public static Tbl_Retiro ObtenerRetiroPorId(int id)
        {
            var retiid = dc.Tbl_Retiro.FirstOrDefault(retiro => retiro.ret_id.Equals(id) && retiro.ret_estado == "A");
            return retiid;
        }

        public static Tbl_Retiro ObtenerRetiroPer(int personaid)
        {
            var retiid = dc.Tbl_Retiro.FirstOrDefault(retiro => retiro.Per_id.Equals(personaid) && retiro.ret_estado == "A");
            return retiid;
        }

        public static List<Tbl_Profesional> ObtenerProfesional()
        {
            var lista = dc.Tbl_Profesional.Where(prof => prof.prof_estado == "A");
            return lista.ToList();
        }

        //----------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------ METODOS PARA GUARDAR Y MODIFICAR DATOS  -----------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------

        public static void GuardarrRetiro(Tbl_Retiro retiro)
        {
            try
            {
                retiro.ret_estado = "A";
                dc.Tbl_Retiro.InsertOnSubmit(retiro);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de HC RETIRO" + ex.Message);
            }
        }

        public static void ModificarRetiro(Tbl_Retiro retiro)
        {
            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de HC RETIRO" + ex.Message);
            }
        }
    }
}
