using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaNegocio;

namespace CapaNegocio
{
    public class CN_Inicial
    {
        //private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();
        private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        //metodo traer para traer Datos Establecimeinto Empresa Usuario x persona
        public static Tbl_DatEstableEmpUsu obtenerDatEstEmpreUsuar(int personaid)
        {
            var datempusuid = dc.Tbl_DatEstableEmpUsu.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.datEstable_estado == "A");
            return datempusuid;
        }

        //metodo traer para traer Motivo Consulta Inicial x persona
        public static Tbl_MotivoConsultaInicial obtenerMotivoConsultaInicial(int personaid)
        {
            var motconini = dc.Tbl_MotivoConsultaInicial.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.motConIni_estado == "A");
            return motconini;
        }

        //metodo traer para traer Antecedentes personales x persona
        public static Tbl_AntecedentesPersonalesInicial obtenerAntecedentesPersonalesInicial(int personaid)
        {
            var antper = dc.Tbl_AntecedentesPersonalesInicial.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.antPerInicial_estado == "A");
            return antper;
        }

        //metodo traer para traer Antecedentes Emple Anteriores x persona
        public static Tbl_AntecedentesEmplAnteriores obtenerEmpAntexPer(int personaid)
        {
            var emplanteid = dc.Tbl_AntecedentesEmplAnteriores.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.AntEmpAnte_estado == "A");
            return emplanteid;
        }

        //metodo traer para traer Accidentes trabajo Desc x persona
        public static Tbl_AccidentesTrabajoDesc obtenerAcciTraDescxPer(int personaid)
        {
            var accitrabid = dc.Tbl_AccidentesTrabajoDesc.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.AntTrabDesc_estado == "A");
            return accitrabid;
        }

        //metodo traer para traer Enfermedades Profesionales x persona
        public static Tbl_EnfermedadesProfesionales obtenerEnfProfxPer(int personaid)
        {
            var enfprofid = dc.Tbl_EnfermedadesProfesionales.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.EnfProfesionales_estado == "A");
            return enfprofid;
        }

        //metodo traer para traer Factores Riesgo Trab Act x persona
        public static Tbl_FacRiesTrabAct obtenerFacRiesTrabActxPer(int personaid)
        {
            var facriestrabid = dc.Tbl_FacRiesTrabAct.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.FacRiesTrabAct_estado == "A");
            return facriestrabid;
        }

        //metodo traer para traer AnteFamiDetParentesco x persona
        public static Tbl_AntecedentesFamiliaresDetParentesco obtenerAntFamDetPar(int personaid)
        {
            var obtantfampar = dc.Tbl_AntecedentesFamiliaresDetParentesco.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.AntFamDetPare_estado == "A");
            return obtantfampar;
        }

        //metodo traer para traer Actividades extra laborales x persona
        public static Tbl_ActividadesExtraLaborales obtenerActiExtraLabxPer(int personaid)
        {
            var actextralabid = dc.Tbl_ActividadesExtraLaborales.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.ActExtLab_estado == "A");
            return actextralabid;
        }

        //metodo traer para traer Enfermedad Actual Inicial x persona
        public static Tbl_EnfermedadActualInicial obtenerEnferActInixPer(int personaid)
        {
            var enferactini = dc.Tbl_EnfermedadActualInicial.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.enfActual_estado == "A");
            return enferactini;
        }

        //metodo traer para traer Revision actual organos y sistemas x persona
        public static Tbl_RevisionActualOrganosSistemas obtenerRevActOrgSisxPer(int personaid)
        {
            var obtrevactorgsis = dc.Tbl_RevisionActualOrganosSistemas.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.RevActOrgSis_estado == "A");
            return obtrevactorgsis;
        }

        //metodo traer para traer Examen fisico regional x persona
        public static Tbl_ExaFisRegionalInicial obtenerExaFisRegPer(int personaid)
        {
            var exafisreg = dc.Tbl_ExaFisRegionalInicial.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.exaFisRegInicial_estado == "A");
            return exafisreg;
        }

        //metodo traer para traer res Exa Gen Esp Ries Trabajo x persona
        public static Tbl_ResExaGenEspRiesTrabajo obtenerResExaGenEspRiesTrabaxPer(int personaid)
        {
            var resexagenid = dc.Tbl_ResExaGenEspRiesTrabajo.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.ResExaGenEspRiesTrabajo_estado == "A");
            return resexagenid;
        }
        
        //metodo traer para traer Diagnostico x persona
        public static Tbl_Diagnostico obtenerDiagnosticoxPer(int personaid)
        {
            var diagid = dc.Tbl_Diagnostico.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.Diag_esatdo == "A");
            return diagid;
        }
        
        //metodo traer para traer Aptitud Medica x persona
        public static Tbl_AptitudMedica obtenerAptMedicaxPer(int personaid)
        {
            var aptmedid = dc.Tbl_AptitudMedica.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.AptMed_estado == "A");
            return aptmedid;
        }

        //metodo traer para traer REcomendaciones y tratamiento x persona
        public static Tbl_TratamientoInicial obtenerTratamientoInixPer(int personaid)
        {
            var tratamientoinicial = dc.Tbl_TratamientoInicial.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.trataInicial_estado == "A");
            return tratamientoinicial;
        }


        //----------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------ METODOS PARA GUARDAR Y MODIFICAR DATOS  -----------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------

        //A. DATOS DEL ESTABLECIMIENTO - EMPRESA Y USUARIO

        //Metodo para guardar datos DATOS DE EMPRESA Y USUARIO DESDE RELIGION
        public static void guardarDatosEstablecimientoEmpresaUsuario(Tbl_DatEstableEmpUsu datosestempresausu)
        {
            try
            {
                datosestempresausu.datEstable_estado = "A";
                dc.Tbl_DatEstableEmpUsu.InsertOnSubmit(datosestempresausu);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //B. MOTIVO DE CONSULTA

        //Metodo para guardar datos MOTIVO CONSULTA
        public static void guardarMotivoConsultaInicial(Tbl_MotivoConsultaInicial motconini)
        {
            try
            {
                motconini.motConIni_estado = "A";
                dc.Tbl_MotivoConsultaInicial.InsertOnSubmit(motconini);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //C. ANTECEDENTES PERSONALES

        //Metodo para guardar datos ANTECEDENTES CLÍNICOS Y QUIRÚRGICOS
        public static void guardarAntPersonales(Tbl_AntecedentesPersonalesInicial antper)
        {
            try
            {
                antper.antPerInicial_estado = "A";
                dc.Tbl_AntecedentesPersonalesInicial.InsertOnSubmit(antper);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //Metodo para guardar datos ANTECEDENTES GINECO OBSTÉTRICOS
        public static void guardarAntGinObste(Tbl_AntecedentesGinObste antginobste)
        {
            try
            {
                antginobste.AntGinObst_estado = "A";
                dc.Tbl_AntecedentesGinObste.InsertOnSubmit(antginobste);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //Metodo para guardar datos VIDA SEXUAL ACTIVA
        public static void guardarVidSexActiva(Tbl_VidaSexualActiva vidsexact)
        {
            try
            {
                vidsexact.VidSexAct_estado = "A";
                dc.Tbl_VidaSexualActiva.InsertOnSubmit(vidsexact);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }   
        
        //Metodo para guardar datos METODO PLANIFICACION FAMILIAR
        public static void guardarMetPlaniFami(Tbl_MetodoPlanificacionFamiliar metplanfam)
        {
            try
            {
                metplanfam.MePlaFamiliar_estado = "A";
                dc.Tbl_MetodoPlanificacionFamiliar.InsertOnSubmit(metplanfam);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }
        
        //Metodo para guardar datos EXAMENES REALIZADOS 1
        public static void guardarExaReali1(Tbl_ExamenesRealizados1 exareali1)
        {
            try
            {
                exareali1.ExamRealizado1_estado = "A";
                dc.Tbl_ExamenesRealizados1.InsertOnSubmit(exareali1);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //Metodo para guardar datos EXAMENES REALIZADOS 2
        public static void guardarExaReali2(Tbl_ExamenesRealizados2 exareali2)
        {
            try
            {
                exareali2.ExamRealizado2_estado = "A";
                dc.Tbl_ExamenesRealizados2.InsertOnSubmit(exareali2);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //Metodo para guardar datos EXAMENES REALIZADOS 1
        public static void guardarExaReali3(Tbl_ExamenesRealizados3 exareali3)
        {
            try
            {
                exareali3.ExamRealizado3_estado = "A";
                dc.Tbl_ExamenesRealizados3.InsertOnSubmit(exareali3);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //Metodo para guardar datos METODO PLANIFICACION FAMILIAR 2
        public static void guardarMetPlaniFami2(Tbl_MetodoPlanificacionFamiliar2 metplanfam2)
        {
            try
            {
                metplanfam2.MePlaFamiliar2_estado = "A";
                dc.Tbl_MetodoPlanificacionFamiliar2.InsertOnSubmit(metplanfam2);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //Metodo para guardar datos CONSUMOS NOCIVOS
        public static void guardarConsNosivos(Tbl_ConsumosNocivos connosi)
        {
            try
            {
                connosi.ConNocivos_estado = "A";
                dc.Tbl_ConsumosNocivos.InsertOnSubmit(connosi);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }
        
        //Metodo para guardar datos ESTILO DE VIDA
        public static void guardarEstilo(Tbl_Estilo esti)
        {
            try
            {
                esti.Est_estado  = "A";
                dc.Tbl_Estilo.InsertOnSubmit(esti);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //D.ANTECEDENTES DE TRABAJO

        //Metodo para guardar datos ANTECEDENTES DE EMPLEOS ANTERIORES
        public static void guardarEmpleAnteriores(Tbl_AntecedentesEmplAnteriores emplant)
        {
            try
            {
                emplant.AntEmpAnte_estado = "A";
                dc.Tbl_AntecedentesEmplAnteriores.InsertOnSubmit(emplant);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //Metodo para guardar datos ACCIDENTES DE TRABAJO
        public static void guardarAccTrabajo(Tbl_AccidentesTrabajoDesc acctrabajo)
        {
            try
            {
                acctrabajo.AntTrabDesc_estado = "A";
                dc.Tbl_AccidentesTrabajoDesc.InsertOnSubmit(acctrabajo);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //Metodo para guardar datos ENFERMEDADES PROFESIONALES
        public static void guardarEnferProfes(Tbl_EnfermedadesProfesionales enferprof)
        {
            try
            {
                enferprof.EnfProfesionales_estado = "A";
                dc.Tbl_EnfermedadesProfesionales.InsertOnSubmit(enferprof);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //E. ANTECEDENTES FAMILIARES

        //Metodo para guardar datos ANTECEDENTES FAMILIARES
        public static void guardarAntecedentesFamiliaresDetParentesco(Tbl_AntecedentesFamiliaresDetParentesco AnteFamiDetParentesco)
        {
            try
            {
                AnteFamiDetParentesco.AntFamDetPare_estado = "A";
                dc.Tbl_AntecedentesFamiliaresDetParentesco.InsertOnSubmit(AnteFamiDetParentesco);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //F. FACTORES DE RIESGO DEL PUESTO DE TRABAJO ACTUAL

        //Metodo para guardar datos RIESGO DEL PUESTO DE TRABAJO ACTUAL
        public static void guardarRiesgoPuesTrabaActual(Tbl_FacRiesTrabAct facriesgotractual)
        {
            try
            {
                facriesgotractual.FacRiesTrabAct_estado = "A";
                dc.Tbl_FacRiesTrabAct.InsertOnSubmit(facriesgotractual);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }


        //G. ACTIVIDADES EXTRA LABORALES

        //Metodo para guardar datos ACTIVIDADES EXTRA LABORALES
        public static void guardarActivextralaboral(Tbl_ActividadesExtraLaborales actvextralaboral)
        {
            try
            {
                actvextralaboral.ActExtLab_estado = "A";
                dc.Tbl_ActividadesExtraLaborales.InsertOnSubmit(actvextralaboral);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //H. ENFERMEDAD ACTUAL

        //Metodo para guardar datos Enfermedad Actual
        public static void guardarEnfermedadActual(Tbl_EnfermedadActualInicial enferactualinicial)
        {
            try
            {
                enferactualinicial.enfActual_estado = "A";
                dc.Tbl_EnfermedadActualInicial.InsertOnSubmit(enferactualinicial);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //I. REVISIÓN ACTUAL DE ÓRGANOS Y SISTEMAS

        //Metodo para guardar datos REVISIÓN ACTUAL DE ÓRGANOS Y SISTEMAS
        public static void guardarReviActualOrganSistemas(Tbl_RevisionActualOrganosSistemas revisionactualorganossistemas)
        {
            try
            {
                revisionactualorganossistemas.RevActOrgSis_estado = "A";
                dc.Tbl_RevisionActualOrganosSistemas.InsertOnSubmit(revisionactualorganossistemas);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //K. EXAMEN FÍSICO REGIONAL

        //Metodo para guardar datos REVISIÓN ACTUAL DE ÓRGANOS Y SISTEMAS
        public static void guardarExamenFisicoRegional(Tbl_ExaFisRegionalInicial examfisregional)
        {
            try
            {
                examfisregional.exaFisRegInicial_estado = "A";
                dc.Tbl_ExaFisRegionalInicial.InsertOnSubmit(examfisregional);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //L. RESULTADO DE EXAMENES GENERALES Y ESPECIFICOS DE ACUERDO AL RIESGO Y PUESTO DE TRABAJO

        //Metodo para guardar datos RESULTADO DE EXAMENES GENERALES Y ESPECIFICOS DE ACUERDO AL RIESGO Y PUESTO DE TRABAJO
        public static void guardarExaGenEspeRiesyPues(Tbl_ResExaGenEspRiesTrabajo exagenesperiespues)
        {
            try
            {
                exagenesperiespues.ResExaGenEspRiesTrabajo_estado = "A";
                dc.Tbl_ResExaGenEspRiesTrabajo.InsertOnSubmit(exagenesperiespues);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }


        //M. DIAGNÓSTICO

        //Metodo para guardar datos DIAGNÓSTICO
        public static void guardarDiagnostico(Tbl_Diagnostico diagnostico)
        {
            try
            {
                diagnostico.Diag_esatdo = "A";
                dc.Tbl_Diagnostico.InsertOnSubmit(diagnostico);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }


        //N. APTITUD MÉDICA PARA EL TRABAJO

        //Metodo para guardar datos APTITUD MÉDICA PARA EL TRABAJO
        public static void guardarAptiMediTrabajo(Tbl_AptitudMedica aptitudmedica)
        {
            try
            {
                aptitudmedica.AptMed_estado = "A";
                dc.Tbl_AptitudMedica.InsertOnSubmit(aptitudmedica);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //O. RECOMENDACIONES Y/O TRATAMIENTO

        //Metodo para guardar datos APTITUD MÉDICA PARA EL TRABAJO
        public static void guardarRecomendacionesTratamiento(Tbl_TratamientoInicial tratamientoinicial)
        {
            try
            {
                tratamientoinicial.trataInicial_estado = "A";
                dc.Tbl_TratamientoInicial.InsertOnSubmit(tratamientoinicial);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }
    }
}
