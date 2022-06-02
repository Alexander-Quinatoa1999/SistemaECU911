using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.Linq;

namespace CapaNegocio
{
    public class CN_Inicial
    {

        private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        public static List<Tbl_Empresa> ObtenerEmpresa()
        {
            var listaEmp = dc.Tbl_Empresa.Where(emp => emp.Emp_estado == "A");
            return listaEmp.ToList();
        }

        public static Tbl_Inicial ObtenerInicialPorId(int id)
        {
            var iniid = dc.Tbl_Inicial.FirstOrDefault(inicial => inicial.inicial_id.Equals(id) && inicial.inicial_estado == "A");
            return iniid;
        }

        public static Tbl_Inicial ObtenerInicialPer(int personaid)
        {
            var iniid = dc.Tbl_Inicial.FirstOrDefault(inicial => inicial.Per_id.Equals(personaid) && inicial.inicial_estado == "A");
            return iniid;
        }

        public static List<Tbl_Profesional> ObtenerProfesional()
        {
            var lista = dc.Tbl_Profesional.Where(prof => prof.prof_estado == "A");
            return lista.ToList();
        }

        //----------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------ METODOS PARA GUARDAR Y MODIFICAR DATOS  -----------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------

        public static void GuardarInicial(Tbl_Inicial inicial)
        {
            try
            {
                inicial.inicial_estado = "A";
                inicial.inicial_fechaHoraGuardado = DateTime.Now;
                dc.Tbl_Inicial.InsertOnSubmit(inicial);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de HC INICIAL" + ex.Message);
            }
        }

        public static void ModificarInicial(Tbl_Inicial inicial)
        {
            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de HC INICIAL" + ex.Message);
            }
        }

    }
}
