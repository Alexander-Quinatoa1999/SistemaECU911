using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Inmunizaciones
    {
        private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        public static List<Tbl_Empresa> ObtenerEmpresa()
        {
            var listaEmp = dc.Tbl_Empresa.Where(emp => emp.Emp_estado == 'A');
            return listaEmp.ToList();
        }

        public static Tbl_Inmunizaciones ObtenerInmunizacionesPorId(int id)
        {
            var inmuid = dc.Tbl_Inmunizaciones.FirstOrDefault(inmunizaciones => inmunizaciones.inmu_id.Equals(id) && inmunizaciones.inmu_estado == "A");
            return inmuid;
        }

        public static Tbl_Inmunizaciones ObtenerInmunizacionesPer(int personaid)
        {
            var iniid = dc.Tbl_Inmunizaciones.FirstOrDefault(inmunizaciones => inmunizaciones.Per_id.Equals(personaid) && inmunizaciones.inmu_estado == "A");
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

        public static void GuardarInmunizaciones(Tbl_Inmunizaciones inmunizaciones)
        {
            try
            {
                inmunizaciones.inmu_estado = "A";
                inmunizaciones.inmu_fechaHora = DateTime.Now;
                dc.Tbl_Inmunizaciones.InsertOnSubmit(inmunizaciones);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de HC INMUNIZACIONES" + ex.Message);
            }
        }

        public static void ModificarInmunizaciones(Tbl_Inmunizaciones inmunizaciones)
        {
            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de HC INMUNIZACIONES" + ex.Message);
            }
        }
    }
}
