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

        //metodo traer para la empresa
        public static List<Tbl_Empresa> obtenerEmpresa()
        {
            var listaEmp = dc.Tbl_Empresa.Where(emp => emp.Emp_estado == 'A');
            return listaEmp.ToList();
        }

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

        //1. Metodo para guardar datos motivo de consulta
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

        //2. Metodo para guardar datos antecedentes personales
        public static void guardarAntecedentesPersonales(Tbl_AntePersonales antper)
        {
            try
            {
                antper.AntPer_estado = 'A';
                dc.Tbl_AntePersonales.InsertOnSubmit(antper);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //3. Metodo para guardar datos antecedentes familiares
        public static void guardarAntecedentesFamiliares(Tbl_AnteFamiliares antfam)
        {
            try
            {
                antfam.AntFami_estado = 'A';
                dc.Tbl_AnteFamiliares.InsertOnSubmit(antfam);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //4. Metodo para guardar datos enfermedad actual
        public static void guardarEnfermedadActual(Tbl_EnfermedadActual enfact)
        {
            try
            {
                enfact.EnfActu_estado = 'A';
                dc.Tbl_EnfermedadActual.InsertOnSubmit(enfact);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //5. Metodo para guardar datos organos y sistemas
        public static void guardarRevisionOrganosSistemasPrincipal(Tbl_RevisionOrganosSistemasPrincipal revOrSisPrin)
        {
            try
            {
                revOrSisPrin.RevOrgSisPrin_estado = 'A';
                dc.Tbl_RevisionOrganosSistemasPrincipal.InsertOnSubmit(revOrSisPrin);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //6. Metodo para guardar datos signos vitales y antropometricos
        public static void guardarSisgnosVitalesAntropometricos(Tbl_RevisionOrganosSistemasPrincipal revOrSisPrin)
        {
            try
            {
                revOrSisPrin.RevOrgSisPrin_estado = 'A';
                dc.Tbl_RevisionOrganosSistemasPrincipal.InsertOnSubmit(revOrSisPrin);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //7. Metodo para guardar datos examen fisico
        public static void guardarExamenFisico(Tbl_ExaFisRegional exafis)
        {
            try
            {
                exafis.ExaFisRegional_estado = 'A';
                dc.Tbl_ExaFisRegional.InsertOnSubmit(exafis);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //9. Metodo para guardar datos plan de tratamiento
        public static void guardarPlanTratamiento(Tbl_RecoTratamiento rectra)
        {
            try
            {
                rectra.RecTra_estado = 'A';
                dc.Tbl_RecoTratamiento.InsertOnSubmit(rectra);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //10. Metodo para guardar datos evolucion
        public static void guardarEvolucion(Tbl_Evolucion evo)
        {
            try
            {
                evo.Evolucion_estado = 'A';
                dc.Tbl_Evolucion.InsertOnSubmit(evo);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //11. Metodo para guardar datos prescripcion
        public static void guardarPrescripcion(Tbl_Prescipciones pres)
        {
            try
            {
                pres.Pres_estado = 'A';
                dc.Tbl_Prescipciones.InsertOnSubmit(pres);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //12. Metodo para guardar datos profesional
        public static void guardarProfesional(Tbl_DatProfesional prof)
        {
            try
            {
                prof.Profe_estado = 'A';
                dc.Tbl_DatProfesional.InsertOnSubmit(prof);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }
    }
}
