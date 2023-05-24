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

        //private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();
        private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        //metodo traer para la empresa
        public static List<Tbl_Empresa> ObtenerEmpresa()
        {
            var listaEmp = dc.Tbl_Empresa.Where(emp => emp.Emp_estado == "A");
            return listaEmp.ToList();
        }

        public static List<Tbl_FichasMedicas> ObtenerFichasMedicas()
        {
            var listaFichMed = dc.Tbl_FichasMedicas.Where(fich => fich.estado == "A");
            return listaFichMed.ToList();
        }

        //metodo traer para todos los usuarios
        public static List<Tbl_Person> ObtenerPersonas()
        {
            var listaPer = dc.Tbl_Person.Where(per => per.Per_estado == "AP");
            return listaPer.ToList();
        }

        //metodo traer para todos los usuarios x ID
        public static Tbl_Person obtenerPersonasxCedula(int ced)
        {
            var usuid = dc.Tbl_Person.FirstOrDefault(per => per.Per_cedula.Equals(ced) && per.Per_estado == "AP");
            return usuid;
        }

        public static Tbl_FichasMedicas ObtenerFichasMedicasPorId(int id)
        {
            var fmid = dc.Tbl_FichasMedicas.FirstOrDefault(fm => fm.idFichaMedica.Equals(id) && fm.estado == "A");
            return fmid;
        }

        //metodo traer para todos los usuarios x ID
        public static Tbl_Person ObtenerPersonasxId(int personaid)
        {
            var perid = dc.Tbl_Person.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.Per_estado == "AP");
            return perid;
        }

        //metodo traer para todos las empresas x ID
        public static Tbl_Empresa ObtenerEmpresaxId(int empresaid)
        {
            var empid = dc.Tbl_Empresa.FirstOrDefault(emp => emp.Emp_id.Equals(empresaid) && emp.Emp_estado == "A");
            return empid;
        }

        //metodo traer para todos los ID personas x cedula
        public static Tbl_Person ObtenerIdPersonasxCedula(string perced)
        {
            var perid = dc.Tbl_Person.FirstOrDefault(per => per.Per_cedula.Equals(perced) && per.Per_estado == "AP");
            return perid;
        }

        //metodo traer para todos el ID de la empresa x usu_id (Cedula)
        public static Tbl_Person ObtenerIdEmpresaxCedula(string perced)
        {
            var perid = dc.Tbl_Person.FirstOrDefault(per => per.Per_cedula.Equals(perced) && per.Per_estado == "AP");
            return perid;
        }

        public static Tbl_FichasMedicas ObtenerFichaMedicaPer(int personaid)
        {
            var fmid = dc.Tbl_FichasMedicas.FirstOrDefault(fm => fm.Per_id.Equals(personaid) && fm.estado == "A");
            return fmid;
        }


        //metodo traer especialidad
        public static List<Tbl_Especialidad> ObtenerEspecialidad()
        {
            var lista = dc.Tbl_Especialidad.Where(espec => espec.espec_estado == "A");
            return lista.ToList();
        }

        //metodo para traer profesional
        public static List<Tbl_Profesional> ObtenerProfesional()
        {
            var lista = dc.Tbl_Profesional.Where(prof => prof.prof_estado == "A");
            return lista.ToList();
        }

        // Metodo para guardar datos de Ficha Medica
        public static void GuardarFichaMedica(Tbl_FichasMedicas fichasmedicas)
        {
            try
            {
                fichasmedicas.estado = "A";
                dc.Tbl_FichasMedicas.InsertOnSubmit(fichasmedicas);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de la ficha medica" + ex.Message);
            }
        }

        // Metodo para modificar datos de la Ficha Medica
        public static void ModificarFichaMedica(Tbl_FichasMedicas fichasmedicas)
        {
            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de la ficha medica" + ex.Message);
            }
        }

    }
}
