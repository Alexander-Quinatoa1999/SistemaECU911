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
            var listaEmp = dc.Tbl_Empresa.Where(emp => emp.Emp_estado == 'A');
            return listaEmp.ToList();
        }

        public static List<Tbl_FichasMedicas> ObtenerFichasMedicas()
        {
            var listaFichMed = dc.Tbl_FichasMedicas.Where(fich => fich.estado == "A");
            return listaFichMed.ToList();
        }

        //metodo traer para todos los usuarios
        public static List<Tbl_Personas> ObtenerPersonas()
        {
            var listaPer = dc.Tbl_Personas.Where(per => per.Per_estado == "A");
            return listaPer.ToList();
        }

        //metodo traer para todos los usuarios x ID
        public static Tbl_Personas obtenerPersonasxCedula(int ced)
        {
            var perid = dc.Tbl_Personas.FirstOrDefault(per => per.Per_Cedula.Equals(ced) && per.Per_estado == "A");
            return perid;
        }

        public static Tbl_FichasMedicas ObtenerFichasMedicasPorId(int id)
        {
            var fmid = dc.Tbl_FichasMedicas.FirstOrDefault(fm => fm.idFichaMedica.Equals(id) && fm.estado == "A");
            return fmid;
        }

        //metodo traer para todos los usuarios x ID
        public static Tbl_Personas ObtenerPersonasxId(int personaid)
        {
            var perid = dc.Tbl_Personas.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.Per_estado == "A");
            return perid;
        }

        //metodo traer para todos los ID personas x cedula
        public static Tbl_Personas ObtenerIdPersonasxCedula(int perced)
        {
            var perid = dc.Tbl_Personas.FirstOrDefault(per => per.Per_Cedula.Equals(perced) && per.Per_estado == "A");
            return perid;
        }

        public static Tbl_FichasMedicas ObtenerFichaMedicaPer(int personaid)
        {
            var fmid = dc.Tbl_FichasMedicas.FirstOrDefault(fm => fm.Per_id.Equals(personaid) && fm.estado == "A");
            return fmid;
        }

        //metodo para traer tiporegion x region
        public static Tbl_TipoExaFisRegional ObtenerTipoRegionxReg(int tipexafisid)
        {
            var tipexaf = dc.Tbl_TipoExaFisRegional.FirstOrDefault(tipexafis => tipexafis.Regiones_id.Equals(tipexafisid) && tipexafis.tipoExa_estado == "A");
            return tipexaf;
        }
        //metodo para traer regiones de examenes
        public static List<Tbl_Regiones> ObtenerRegion()
        {
            var lista = dc.Tbl_Regiones.Where(reg => reg.Regiones_estado == "A");
            return lista.ToList();
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
                fichasmedicas.fechaHora = DateTime.Now;
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
