using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Periodica
    {
        ////private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();
        //private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        ////metodo traer para traer Datos Establecimeinto Empresa Usuario x persona
        //public static Tbl_DatEstableEmpUsu obtenerDatEstEmpreUsuar(int personaid)
        //{
        //    var datempusuid = dc.Tbl_DatEstableEmpUsu.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.datEstable_estado == "A");
        //    return datempusuid;
        //}

        ////metodo traer para traer Motivo Consulta Periodica x persona
        //public static Tbl_MotivoConsultaPeriodica obtenerMotivoConsultaxPerPeriodica(int personaid)
        //{
        //    var motconper = dc.Tbl_MotivoConsultaPeriodica.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.motConPeriodica_estado == "A");
        //    return motconper;
        //}

        ////metodo traer para traer Antecedentes personales Periodica x persona
        //public static Tbl_AntecedentesPersonalesPeriodica obtenerAntecedentesPersonalesxPerPeriodica(int personaid)
        //{
        //    var antpersperiodica = dc.Tbl_AntecedentesPersonalesPeriodica.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.antPerPeriodica_estado == "A");
        //    return antpersperiodica;
        //}

        ////metodo traer para traer AnteFamiDetParentesco Periodica x persona
        //public static Tbl_AntecedentesFamiliaresDetParentescoPeriodica obtenerAntFamDetParxPerPeriodica(int personaid)
        //{
        //    var obtantfamparperiodica = dc.Tbl_AntecedentesFamiliaresDetParentescoPeriodica.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.AntFamDetParePeriodica_estado == "A");
        //    return obtantfamparperiodica;
        //}

        ////metodo traer para traer Factores Riesgo Trab Act Periodica x persona
        //public static Tbl_FacRiesTrabActPeriodica obtenerFacRiesTrabActxPerPeriodica(int personaid)
        //{
        //    var facriestrabperiodica = dc.Tbl_FacRiesTrabActPeriodica.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.FacRiesTrabActPeriodica_estado == "A");
        //    return facriestrabperiodica;
        //}

        ////metodo traer para traer Enfermedad Actual Periodica x persona
        //public static Tbl_EnfermedadActualPeriodica obtenerEnferActxPerPeriodica(int personaid)
        //{
        //    var enferactperiodica = dc.Tbl_EnfermedadActualPeriodica.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.enfActualPeriodica_estado == "A");
        //    return enferactperiodica;
        //}

        ////metodo traer para traer Revision actual organos y sistemas Periodica x persona
        //public static Tbl_RevisionActualOrganosSistemasPeriodica obtenerRevActOrgSisxPerPeriodica(int personaid)
        //{
        //    var obtrevactorgsisperiodica = dc.Tbl_RevisionActualOrganosSistemasPeriodica.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.RevActOrgSisPeriodica_estado == "A");
        //    return obtrevactorgsisperiodica;
        //}

        ////metodo traer para traer Examen fisico regional Periodica x persona
        //public static Tbl_ExaFisRegionalPeriodica obtenerExaFisRegxPerPeriodica(int personaid)
        //{
        //    var exafisregperiodica = dc.Tbl_ExaFisRegionalPeriodica.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.exaFisRegPeriodica_estado == "A");
        //    return exafisregperiodica;
        //}

        ////metodo traer para traer res Exa Gen Esp Ries Trabajo Periodica x persona
        //public static Tbl_ResExaGenEspRiesTrabajoPeriodica obtenerResExaGenEspRiesTrabaxPerPeriodica(int personaid)
        //{
        //    var resexagenperiodica = dc.Tbl_ResExaGenEspRiesTrabajoPeriodica.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.ResExaGenEspRiesTrabajoPeriodica_estado == "A");
        //    return resexagenperiodica;
        //}

        ////metodo traer para traer Diagnostico Periodica x persona
        //public static Tbl_DiagnosticoPeriodica obtenerDiagnosticoxPerPeriodica(int personaid)
        //{
        //    var diagperiodica = dc.Tbl_DiagnosticoPeriodica.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.DiagPeriodica_estado == "A");
        //    return diagperiodica;
        //}

        ////metodo traer para traer Aptitud Medica Periodica x persona
        //public static Tbl_AptitudMedicaPeriodica obtenerAptMedicaxPerPeriodica(int personaid)
        //{
        //    var aptmedperiodica = dc.Tbl_AptitudMedicaPeriodica.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.AptMedPeriodica_estado == "A");
        //    return aptmedperiodica;
        //}

        ////metodo traer para traer Recomendaciones y tratamiento Periodica x persona
        //public static Tbl_RecoTratamientoPeriodica obtenerTratamientoxPerPeriodica(int personaid)
        //{
        //    var tratamientoperiodica = dc.Tbl_RecoTratamientoPeriodica.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.RecTraPeriodica_estado == "A");
        //    return tratamientoperiodica;
        //}

        ////metodo traer para traer datos profesional x persona
        //public static Tbl_DatProfesionalPeriodica obtenerDatosProfesionalxPerPeriodica(int personaid)
        //{
        //    var tratamientoperiodica = dc.Tbl_DatProfesionalPeriodica.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.DatProfePeriodica_estado == "A");
        //    return tratamientoperiodica;
        //}

        ////----------------------------------------------------------------------------------------------------------------------------
        ////------------------------------------------ METODOS PARA GUARDAR Y MODIFICAR DATOS  -----------------------------------------
        ////----------------------------------------------------------------------------------------------------------------------------

        ////A. DATOS DEL ESTABLECIMIENTO - EMPRESA Y USUARIO

        ////Metodo para guardar datos DATOS DE EMPRESA Y USUARIO
        //public static void guardarDatEstEmpreUsuarPeriodica(Tbl_DatEstableEmpUsu datosestempresausu)
        //{
        //    try
        //    {
        //        datosestempresausu.datEstable_estado = "A";
        //        dc.Tbl_DatEstableEmpUsu.InsertOnSubmit(datosestempresausu);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}

        ////B. MOTIVO DE CONSULTA

        ////Metodo para guardar datos MOTIVO CONSULTA
        //public static void guardarMotivoConsultaPeriodica(Tbl_MotivoConsultaPeriodica motconper)
        //{
        //    try
        //    {
        //        motconper.motConPeriodica_estado = "A";
        //        dc.Tbl_MotivoConsultaPeriodica.InsertOnSubmit(motconper);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}

        ////C. ANTECEDENTES PERSONALES

        ////Metodo para guardar datos ANTECEDENTES CLÍNICOS Y QUIRÚRGICOS
        //public static void guardarAntPersonalesPeriodica(Tbl_AntecedentesPersonalesPeriodica antpersperiodica)
        //{
        //    try
        //    {
        //        antpersperiodica.antPerPeriodica_estado = "A";
        //        dc.Tbl_AntecedentesPersonalesPeriodica.InsertOnSubmit(antpersperiodica);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}

        ////D. ANTECEDENTES FAMILIARES

        ////Metodo para guardar datos ANTECEDENTES FAMILIARES
        //public static void guardarAntecedentesFamiliaresDetParentescoPeriodica(Tbl_AntecedentesFamiliaresDetParentescoPeriodica antfamparperiodica)
        //{
        //    try
        //    {
        //        antfamparperiodica.AntFamDetParePeriodica_estado = "A";
        //        dc.Tbl_AntecedentesFamiliaresDetParentescoPeriodica.InsertOnSubmit(antfamparperiodica);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}

        ////E. FACTORES DE RIESGO DEL PUESTO DE TRABAJO ACTUAL

        ////Metodo para guardar datos RIESGO DEL PUESTO DE TRABAJO ACTUAL
        //public static void guardarRiesgoPuesTrabaActualPeriodica(Tbl_FacRiesTrabActPeriodica facriestrabperiodica)
        //{
        //    try
        //    {
        //        facriestrabperiodica.FacRiesTrabActPeriodica_estado = "A";
        //        dc.Tbl_FacRiesTrabActPeriodica.InsertOnSubmit(facriestrabperiodica);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}

        ////F. ENFERMEDAD ACTUAL

        ////Metodo para guardar datos Enfermedad Actual
        //public static void guardarEnfermedadActualPeriodica(Tbl_EnfermedadActualPeriodica enferactperiodica)
        //{
        //    try
        //    {
        //        enferactperiodica.enfActualPeriodica_estado = "A";
        //        dc.Tbl_EnfermedadActualPeriodica.InsertOnSubmit(enferactperiodica);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}

        ////G. REVISIÓN ACTUAL DE ÓRGANOS Y SISTEMAS

        ////Metodo para guardar datos REVISIÓN ACTUAL DE ÓRGANOS Y SISTEMAS
        //public static void guardarReviActualOrganSistemasPeriodica(Tbl_RevisionActualOrganosSistemasPeriodica revactorgsisperiodica)
        //{
        //    try
        //    {
        //        revactorgsisperiodica.RevActOrgSisPeriodica_estado = "A";
        //        dc.Tbl_RevisionActualOrganosSistemasPeriodica.InsertOnSubmit(revactorgsisperiodica);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}

        ////I. EXAMEN FÍSICO REGIONAL

        ////Metodo para guardar datos REVISIÓN ACTUAL DE ÓRGANOS Y SISTEMAS
        //public static void guardarExamenFisicoRegionalPeriodica(Tbl_ExaFisRegionalPeriodica exafisregperiodica)
        //{
        //    try
        //    {
        //        exafisregperiodica.exaFisRegPeriodica_estado = "A";
        //        dc.Tbl_ExaFisRegionalPeriodica.InsertOnSubmit(exafisregperiodica);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}

        ////L. RESULTADO DE EXAMENES GENERALES Y ESPECIFICOS DE ACUERDO AL RIESGO Y PUESTO DE TRABAJO

        ////Metodo para guardar datos RESULTADO DE EXAMENES GENERALES Y ESPECIFICOS DE ACUERDO AL RIESGO Y PUESTO DE TRABAJO
        //public static void guardarExaGenEspeRiesyPuesPeriodica(Tbl_ResExaGenEspRiesTrabajoPeriodica resexagenperiodica)
        //{
        //    try
        //    {
        //        resexagenperiodica.ResExaGenEspRiesTrabajoPeriodica_estado = "A";
        //        dc.Tbl_ResExaGenEspRiesTrabajoPeriodica.InsertOnSubmit(resexagenperiodica);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}

        ////M. DIAGNÓSTICO

        ////Metodo para guardar datos DIAGNÓSTICO
        //public static void guardarDiagnosticoPeriodica(Tbl_DiagnosticoPeriodica diagperiodica)
        //{
        //    try
        //    {
        //        diagperiodica.DiagPeriodica_estado = "A";
        //        dc.Tbl_DiagnosticoPeriodica.InsertOnSubmit(diagperiodica);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}


        ////N. APTITUD MÉDICA PARA EL TRABAJO

        ////Metodo para guardar datos APTITUD MÉDICA PARA EL TRABAJO
        //public static void guardarAptiMediTrabajoPeriodica(Tbl_AptitudMedicaPeriodica aptmedperiodica)
        //{
        //    try
        //    {
        //        aptmedperiodica.AptMedPeriodica_estado = "A";
        //        dc.Tbl_AptitudMedicaPeriodica.InsertOnSubmit(aptmedperiodica);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}

        ////O. RECOMENDACIONES Y/O TRATAMIENTO

        ////Metodo para guardar datos recomendacion y tratamiento
        //public static void guardarRecomendacionesTratamientoPeriodica(Tbl_RecoTratamientoPeriodica tratamientoperiodica)
        //{
        //    try
        //    {
        //        tratamientoperiodica.RecTraPeriodica_estado = "A";
        //        dc.Tbl_RecoTratamientoPeriodica.InsertOnSubmit(tratamientoperiodica);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}

        ////P. DATOS DEL PROFESIONAL

        ////Metodo para guardar datos profesional
        //public static void guardarDatosProfesionalPeriodica(Tbl_DatProfesionalPeriodica datprofperiodica)
        //{
        //    try
        //    {
        //        datprofperiodica.DatProfePeriodica_estado = "A";
        //        dc.Tbl_DatProfesionalPeriodica.InsertOnSubmit(datprofperiodica);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}
    }
}
