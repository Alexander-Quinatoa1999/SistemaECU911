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
        public static List<Tbl_Empresa> obtenerEmpresa()
        {
            var listaEmp = dc.Tbl_Empresa.Where(emp => emp.Emp_estado == 'A');
            return listaEmp.ToList();
        }

        //metodo traer para todos los usuarios
        public static List<Tbl_Personas> obtenerPersonas()
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

        //metodo traer para todos los usuarios x ID
        public static Tbl_Personas obtenerPersonasxId(int personaid)
        {
            var perid = dc.Tbl_Personas.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.Per_estado == "A");
            return perid;
        }

        //metodo traer para todos los ID personas x cedula
        public static Tbl_Personas obtenerIdPersonasxCedula(int perced)
        {
            var perid = dc.Tbl_Personas.FirstOrDefault(per => per.Per_Cedula.Equals(perced) && per.Per_estado == "A");
            return perid;
        }

        //----------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------- METODOS PARA OBTENER DATOS POR PERSONA ---------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------


        //metodo traer para traer motivo de consulta x persona
        public static Tbl_MotivoConsulta obtenerMotivoxPerFecha(int personaid, DateTime fechamot)
        {
            var motid = dc.Tbl_MotivoConsulta.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.Mcon_fecha_hora.Equals(fechamot) && per.Mcon_estado == "A");
            return motid;
        }

        public static Tbl_MotivoConsulta obtenerMotivoxPer(int personaid)
        {
            var motid = dc.Tbl_MotivoConsulta.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.Mcon_estado == "A");
            return motid;
        }

        //metodo traer para traer antecedente personal x persona
        public static Tbl_AntePersonales obtenerAntePersonalxPer(int personaid)
        {
            var antperid = dc.Tbl_AntePersonales.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.AntPer_estado == "A");
            return antperid;
        }

        //metodo traer para traer antecedente familiar x persona
        public static Tbl_AnteFamiliares obtenerAnteFamiliarxPer(int personaid)
        {
            var antfamid = dc.Tbl_AnteFamiliares.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.AntFami_estado == "A");
            return antfamid;
        }

        //metodo traer para traer enfermedad actual x persona
        public static Tbl_EnfermedadActual obtenerEnferActualxPer(int personaid)
        {
            var enfactid = dc.Tbl_EnfermedadActual.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.EnfActu_estado == "A");
            return enfactid;
        }

        //metodo traer para traer revision organos y sistemas x persona
        public static Tbl_ReviOrgaSistemasFichMed obtenerRevOrganosSistemasxPer(int personaid)
        {
            var revOrgSistid = dc.Tbl_ReviOrgaSistemasFichMed.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.revorgsisFM_estado == "A");
            return revOrgSistid;
        }

        //metodo traer para traer signos vitales y antropometricos x persona
        public static Tbl_ConsVitAntro obtenerConsVitAntroxPer(int personaid)
        {
            var consvitid = dc.Tbl_ConsVitAntro.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.ConsVitAntro_estado == "A");
            return consvitid;
        }

        //metodo traer para traer examen fisico x persona
        public static Tbl_ExaFisRegional obtenerExamenFisxPer(int personaid)
        {
            var exafisid = dc.Tbl_ExaFisRegional.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.ExaFisRegional_estado == "A");
            return exafisid;
        }

        //metodo traer para traer daignostico x persona
        public static Tbl_DiagnosticoFichMed obtenerDiagnosticoxPer(int personaid)
        {
            var diagid = dc.Tbl_DiagnosticoFichMed.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.diag_estado == "A");
            return diagid;
        }

        //metodo traer para traer plan de tratamiento x persona
        public static Tbl_RecoTratamiento obtenerPlanTratamientoxPer(int personaid)
        {
            var rectraid = dc.Tbl_RecoTratamiento.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.RecTra_estado == "A");
            return rectraid;
        }

        //metodo traer para traer evolucion x persona
        public static Tbl_Evolucion obtenerEvolucionxPer(int personaid)
        {
            var evoid = dc.Tbl_Evolucion.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.Evolucion_estado == "A");
            return evoid;
        }

        //metodo traer para traer prescipciones x persona
        public static Tbl_Prescipciones obtenerPrescripcionxPer(int personaid)
        {
            var presid = dc.Tbl_Prescipciones.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.Pres_estado == "A");
            return presid;
        }

        //metodo traer para traer profesionales x persona
        public static Tbl_DatProfesional obtenerProfesionalesxPer(int personaid)
        {
            var profid = dc.Tbl_DatProfesional.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.DatProfe_estado == "A");
            return profid;
        }

        //----------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------

        //metodo para traer region x examen fisico
        public static Tbl_Regiones obtenerRegionesxid(int regid)
        {
            var reg = dc.Tbl_Regiones.FirstOrDefault(regi => regi.Regiones_id.Equals(regid) && regi.Regiones_estado == "A");
            return reg;
        }

        //metodo para traer tiporegion x region
        public static Tbl_TipoExaFisRegional obtenerTipoRegionxReg(int tipexafisid)
        {
            var tipexaf = dc.Tbl_TipoExaFisRegional.FirstOrDefault(tipexafis => tipexafis.Regiones_id.Equals(tipexafisid) && tipexafis.tipoExa_estado == "A");
            return tipexaf;
        }

        //metodo para traer tiporegion x id
        public static Tbl_TipoExaFisRegional obtenerTipoRegionxid(int tipexafisid)
        {
            var tipexaf = dc.Tbl_TipoExaFisRegional.FirstOrDefault(tipexafis => tipexafis.tipoExa_id.Equals(tipexafisid) && tipexafis.tipoExa_estado == "A");
            return tipexaf;
        }

        //metodo para traer motivo de consulta x ID
        public static Tbl_MotivoConsulta obtenerMotivoConsultaxid(int motivoconsid)
        {
            var motconsid = dc.Tbl_MotivoConsulta.FirstOrDefault(motcons => motcons.Mcon_id.Equals(motivoconsid) && motcons.Mcon_estado == "A");
            return motconsid;
        }

        //metodo traer para tipo de antecedente
        public static List<Tbl_Tipos_de_Enfermedades> obtenerTipoAntecedente()
        {
            var lista = dc.Tbl_Tipos_de_Enfermedades.Where(tipant => tipant.TiEnf_estado == "A");
            return lista.ToList();
        }

        //metodo para traer regiones de examenes
        public static List<Tbl_Regiones> obtenerRegion()
        {
            var lista = dc.Tbl_Regiones.Where(reg => reg.Regiones_estado == "A");
            return lista.ToList();
        }

        public static List<Tbl_EviPatologica1> obtenerEviPatologica1()
        {
            var lista = dc.Tbl_EviPatologica1.Where(evi => evi.eviPat1_estado == "A");
            return lista.ToList();
        }

        public static List<Tbl_EviPatologica2> obtenerEviPatologica2()
        {
            var lista = dc.Tbl_EviPatologica2.Where(evi => evi.eviPat2_estado == "A");
            return lista.ToList();
        }

        public static List<Tbl_EviPatologica3> obtenerEviPatologica3()
        {
            var lista = dc.Tbl_EviPatologica3.Where(evi => evi.eviPat3_estado == "A");
            return lista.ToList();
        }
        public static List<Tbl_EviPatologica4> obtenerEviPatologica4()
        {
            var lista = dc.Tbl_EviPatologica4.Where(evi => evi.eviPat4_estado == "A");
            return lista.ToList();
        }
        public static List<Tbl_EviPatologica5> obtenerEviPatologica5()
        {
            var lista = dc.Tbl_EviPatologica5.Where(evi => evi.eviPat5_estado == "A");
            return lista.ToList();
        }
        public static List<Tbl_EviPatologica6> obtenerEviPatologica6()
        {
            var lista = dc.Tbl_EviPatologica6.Where(evi => evi.eviPat6_estado == "A");
            return lista.ToList();
        }
        public static List<Tbl_EviPatologica7> obtenerEviPatologica7()
        {
            var lista = dc.Tbl_EviPatologica7.Where(evi => evi.eviPat7_estado == "A");
            return lista.ToList();
        }
        public static List<Tbl_EviPatologica8> obtenerEviPatologica8()
        {
            var lista = dc.Tbl_EviPatologica8.Where(evi => evi.eviPat8_estado == "A");
            return lista.ToList();
        }
        public static List<Tbl_EviPatologica9> obtenerEviPatologica9()
        {
            var lista = dc.Tbl_EviPatologica9.Where(evi => evi.eviPat9_estado == "A");
            return lista.ToList();
        }
        public static List<Tbl_EviPatologica10> obtenerEviPatologica10()
        {
            var lista = dc.Tbl_EviPatologica10.Where(evi => evi.eviPat10_estado == "A");
            return lista.ToList();
        }
        public static List<Tbl_EviPatologica11> obtenerEviPatologica11()
        {
            var lista = dc.Tbl_EviPatologica11.Where(evi => evi.eviPat11_estado == "A");
            return lista.ToList();
        }
        public static List<Tbl_EviPatologica12> obtenerEviPatologica12()
        {
            var lista = dc.Tbl_EviPatologica12.Where(evi => evi.eviPat12_estado == "A");
            return lista.ToList();
        }

        ////metodo para traer tipos de regiones de examenes
        //public static List<Tbl_TipoExaFisRegional> obtenerTipoExamenRegionxId(int regionid)
        //{
        //    var lista = dc.Tbl_TipoExaFisRegional.Where(tipreg => tipreg.Regiones_id.Equals(regionid) && tipreg.tipoExa_estado == "A");
        //    return lista.ToList();
        //}

        //metodo traer especialidad
        public static List<Tbl_Especialidad> obtenerEspecialidad()
        {
            var lista = dc.Tbl_Especialidad.Where(espec => espec.espec_estado == "A");
            return lista.ToList();
        }

        //metodo para traer profesional
        public static List<Tbl_Profesional> obtenerProfesional()
        {
            var lista = dc.Tbl_Profesional.Where(prof => prof.prof_estado == "A");
            return lista.ToList();
        }

        //----------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------ METODOS PARA GUARDAR Y MODIFICAR DATOS  -----------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------

        //1. Metodo para guardar datos de Ficha Medica
        public static void GuardarFichaMedica(FichasMedicas fichasmedicas)
        {
            try
            {
                fichasmedicas.estado = "A";
                fichasmedicas.fechaHora = DateTime.Now;
                dc.FichasMedicas.InsertOnSubmit(fichasmedicas);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de la ficha medica" + ex.Message);
            }
        }

        //1. Metodo para guardar datos motivo de consulta
        public static void guardarPersonas(Tbl_Personas per)
        {
            try
            {
                per.Per_estado = "A";
                dc.Tbl_Personas.InsertOnSubmit(per);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de Persona" + ex.Message);
            }
        }

        //1. Metodo para guardar datos motivo de consulta
        public static void guardarMotiConsulta(Tbl_MotivoConsulta motcons)
        {
            try
            {
                motcons.Mcon_estado = "A";
                dc.Tbl_MotivoConsulta.InsertOnSubmit(motcons);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de Motivo de Consulta" + ex.Message);
            }
        }

        //1.1. Metodo para modificar datos motivo de consulta
        public static void modificarMotiConsulta(Tbl_MotivoConsulta motcons)
        {
            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //2. Metodo para guardar datos antecedentes personales
        public static void guardarAntecedentesPersonales(Tbl_AntePersonales antper)
        {
            try
            {
                antper.AntPer_estado = "A";
                dc.Tbl_AntePersonales.InsertOnSubmit(antper);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de Antecedentes Personales" + ex.Message);
            }
        }

        //2.1. Metodo para modificar datos antecedentes personales
        public static void modificarAntecedentesPersonales(Tbl_AntePersonales antper)
        {
            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //3. Metodo para guardar datos antecedentes familiares
        public static void guardarAntecedentesFamiliares(Tbl_AnteFamiliares antfam)
        {
            try
            {
                antfam.AntFami_estado = "A";
                dc.Tbl_AnteFamiliares.InsertOnSubmit(antfam);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de Antecedentes Familiares" + ex.Message);
            }
        }

        //3.1. Metodo para modificar datos antecedentes familiares
        public static void modificarAntecedentesFamiliares(Tbl_AnteFamiliares antfam)
        {
            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //4. Metodo para guardar datos enfermedad actual
        public static void guardarEnfermedadActual(Tbl_EnfermedadActual enfact)
        {
            try
            {
                enfact.EnfActu_estado = "A";
                dc.Tbl_EnfermedadActual.InsertOnSubmit(enfact);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de Enfermedad Actual" + ex.Message);
            }
        }

        //4.1 Metodo para modificar datos enfermedad actual
        public static void modificarEnfermedadActual(Tbl_EnfermedadActual enfact)
        {
            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        

        //5. Metodo para guardar datos organos y sistemas
        public static void guardarRevisionOrganosSistemas(Tbl_ReviOrgaSistemasFichMed revOrSis)
        {
            try
            {
                revOrSis.revorgsisFM_estado = "A";
                dc.Tbl_ReviOrgaSistemasFichMed.InsertOnSubmit(revOrSis);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de Revision Organos y Sistemas" + ex.Message);
            }
        }

        //5.1. Metodo para modificar datos signos vitales
        public static void modificarRevisionOrganosSistemas(Tbl_ReviOrgaSistemasFichMed revOrSis)
        {
            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //6. Metodo para guardar datos signos vitales y antropometricos 2
        public static void guardarSisgnosVitalesAntropometricos2(Tbl_ConsVitAntro consVitAntro)
        {
            try
            {
                consVitAntro.ConsVitAntro_estado = "A";
                dc.Tbl_ConsVitAntro.InsertOnSubmit(consVitAntro);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de Signos Vitales" + ex.Message);
            }
        }

        //6.1 Metodo para modificar datos signos vitales y antropometricos 2
        public static void modificarSisgnosVitalesAntropometricos2(Tbl_ConsVitAntro consVitAntro)
        {
            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //7. Metodo para guardar datos examen fisico
        public static void guardarExamenFisico(Tbl_ExaFisRegional exafis)
        {
            try
            {
                exafis.ExaFisRegional_estado = "A";
                dc.Tbl_ExaFisRegional.InsertOnSubmit(exafis);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de Examen Fisico" + ex.Message);
            }
        }

        //7.1 Metodo para modificar datos examen fisico
        public static void modificarExamenFisico(Tbl_ExaFisRegional exafis)
        {
            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //8. Metodo para guardar datos diagnostico
        public static void guardarDiagnostico(Tbl_DiagnosticoFichMed diag)
        {
            try
            {
                diag.diag_estado = "A";
                dc.Tbl_DiagnosticoFichMed.InsertOnSubmit(diag);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de Diagnostico" + ex.Message);
            }
        }

        //8.1. Metodo para modificar datos diagnostico
        public static void modificarDiagnostico(Tbl_DiagnosticoFichMed diag)
        {
            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //9. Metodo para guardar datos plan de tratamiento
        public static void guardarPlanTratamiento(Tbl_RecoTratamiento rectra)
        {
            try
            {
                rectra.RecTra_estado = "A";
                dc.Tbl_RecoTratamiento.InsertOnSubmit(rectra);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de Plan de Tratamiento" + ex.Message);
            }
        }

        //9.1 Metodo para modificar datos plan de tratamiento
        public static void modificarPlanTratamiento(Tbl_RecoTratamiento rectra)
        {
            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //10. Metodo para guardar datos evolucion
        public static void guardarEvolucion(Tbl_Evolucion evo)
        {
            try
            {
                evo.Evolucion_estado = "A";
                dc.Tbl_Evolucion.InsertOnSubmit(evo);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de Evolución" + ex.Message);
            }
        }

        //10.1 Metodo para modificar datos evolucion
        public static void modificarEvolucion(Tbl_Evolucion evo)
        {
            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //11. Metodo para guardar datos prescripcion
        public static void guardarPrescripcion(Tbl_Prescipciones pres)
        {
            try
            {
                pres.Pres_estado = "A";
                dc.Tbl_Prescipciones.InsertOnSubmit(pres);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de Prescripciones " + ex.Message);
            }
        }

        //11.1 Metodo para modificar datos prescripcion
        public static void modificarPrescripcion(Tbl_Prescipciones pres)
        {
            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //12. Metodo para guardar datos profesional
        public static void guardarProfesional(Tbl_DatProfesional prof)
        {
            try
            {
                prof.DatProfe_estado = "A";
                dc.Tbl_DatProfesional.InsertOnSubmit(prof);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos del Profesional" + ex.Message);
            }
        }

        //12.1 Metodo para modificar datos profesional
        public static void modificarProfesional(Tbl_DatProfesional prof)
        {
            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------
    }
}
