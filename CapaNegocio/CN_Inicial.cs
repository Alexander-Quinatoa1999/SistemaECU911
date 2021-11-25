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

        //----------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------ METODOS PARA GUARDAR Y MODIFICAR DATOS  -----------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------


        //C. ANTECEDENTES PERSONALES

        //Metodo para guardar datos ANTECEDENTES CLÍNICOS Y QUIRÚRGICOS
        public static void guardarAntCliniQuirur(Tbl_AntecedentesCliQuiru antcliqui)
        {
            try
            {
                antcliqui.AntCliQuiru_estado = "A";
                dc.Tbl_AntecedentesCliQuiru.InsertOnSubmit(antcliqui);
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
    }
}
