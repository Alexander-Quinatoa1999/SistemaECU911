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
        //private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        ////metodo traer para traer Datos Establecimeinto Empresa Usuario x persona
        //public static Tbl_DatEstableEmpUsuRetiro obtenerDatEstEmpUsuRetiro(int personaid)
        //{
        //    var datempusuid = dc.Tbl_DatEstableEmpUsuRetiro.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.datEstable_estado == "A");
        //    return datempusuid;
        //}

        ////metodo traer para traer Antecedentes personales Retiro x persona
        //public static Tbl_AntecedentesPersonalesRetiro obtenerAntecedentesPersonalesxPerRetiro(int personaid)
        //{
        //    var antperetiro = dc.Tbl_AntecedentesPersonalesRetiro.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.antPerRetiro_estado == "A");
        //    return antperetiro;
        //}

        ////metodo traer para traer Examen fisico regional Retiro x persona
        //public static Tbl_ExaFisRegionalRetiro obtenerExaFisRegxPerRetiro(int personaid)
        //{
        //    var exafisregretiro = dc.Tbl_ExaFisRegionalRetiro.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.exaFisRegRetiro_estado == "A");
        //    return exafisregretiro;
        //}

        ////metodo traer para traer res Examen General Retiro x persona
        //public static Tbl_ResExaGenEspRiesTrabajoRetiro obtenerResExaGenEspRiesTrabaxPerRetiro(int personaid)
        //{
        //    var resexagenretiro = dc.Tbl_ResExaGenEspRiesTrabajoRetiro.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.ResExaGenEspRiesTrabajoRetiro_estado == "A");
        //    return resexagenretiro;
        //}

        ////metodo traer para traer Diagnostico Retiro x persona
        //public static Tbl_DiagnosticoRetiro obtenerDiagnosticoxPerRetiro(int personaid)
        //{
        //    var diagretiro = dc.Tbl_DiagnosticoRetiro.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.DiagRetiro_estado == "A");
        //    return diagretiro;
        //}

        ////metodo traer para traer Evaluación Medica Retiro x persona
        //public static Tbl_EvaluacionMedicaRetiro obtenerEvalMedicaxPerRetiro(int personaid)
        //{
        //    var evamedretiro = dc.Tbl_EvaluacionMedicaRetiro.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.evaMedRet_estado == "A");
        //    return evamedretiro;
        //}

        ////metodo traer para traer Recomendaciones y tratamiento Retiro x persona
        //public static Tbl_RecoTratamientoRetiro obtenerTratamientoxPerRetiro(int personaid)
        //{
        //    var tratamientoretiro = dc.Tbl_RecoTratamientoRetiro.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.RecTraRetiro_estado == "A");
        //    return tratamientoretiro;
        //}

        ////metodo traer para traer datos profesional x persona
        //public static Tbl_DatProfesionalRetiro obtenerDatosProfesionalxPerRetiro(int personaid)
        //{
        //    var datprofretiro = dc.Tbl_DatProfesionalRetiro.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.DatProfeRetiro_estado == "A");
        //    return datprofretiro;
        //}

        ////----------------------------------------------------------------------------------------------------------------------------
        ////------------------------------------------ METODOS PARA GUARDAR Y MODIFICAR DATOS  -----------------------------------------
        ////----------------------------------------------------------------------------------------------------------------------------

        ////A. DATOS DEL ESTABLECIMIENTO - EMPRESA Y USUARIO

        ////Metodo para guardar datos DATOS DE EMPRESA Y USUARIO
        //public static void guardarDatEstEmpUsuRetiro(Tbl_DatEstableEmpUsuRetiro datosestempresausu)
        //{
        //    try
        //    {
        //        datosestempresausu.datEstable_estado = "A";
        //        dc.Tbl_DatEstableEmpUsuRetiro.InsertOnSubmit(datosestempresausu);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}

        ////B. ANTECEDENTES PERSONALES

        ////Metodo para guardar datos Antecedentes Personales
        //public static void guardarAntPersonalesRetiro(Tbl_AntecedentesPersonalesRetiro antperetiro)
        //{
        //    try
        //    {
        //        antperetiro.antPerRetiro_estado = "A";
        //        dc.Tbl_AntecedentesPersonalesRetiro.InsertOnSubmit(antperetiro);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}

        ////D. EXAMEN FÍSICO REGIONAL

        ////Metodo para guardar datos REVISIÓN ACTUAL DE ÓRGANOS Y SISTEMAS
        //public static void guardarExamenFisicoRegionalRetiro(Tbl_ExaFisRegionalRetiro exafisregretiro)
        //{
        //    try
        //    {
        //        exafisregretiro.exaFisRegRetiro_estado = "A";
        //        dc.Tbl_ExaFisRegionalRetiro.InsertOnSubmit(exafisregretiro);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}

        ////E. RESULTADO DE EXAMENES GENERALES Y ESPECIFICOS DE ACUERDO AL RIESGO Y PUESTO DE TRABAJO

        ////Metodo para guardar datos resultado examenes generales
        //public static void guardarExaGenEspeRiesyPuesRetiro(Tbl_ResExaGenEspRiesTrabajoRetiro resexagenretiro)
        //{
        //    try
        //    {
        //        resexagenretiro.ResExaGenEspRiesTrabajoRetiro_estado = "A";
        //        dc.Tbl_ResExaGenEspRiesTrabajoRetiro.InsertOnSubmit(resexagenretiro);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}

        ////F. DIAGNÓSTICO

        ////Metodo para guardar datos DIAGNÓSTICO
        //public static void guardarDiagnosticoRetiro(Tbl_DiagnosticoRetiro diagretiro)
        //{
        //    try
        //    {
        //        diagretiro.DiagRetiro_estado = "A";
        //        dc.Tbl_DiagnosticoRetiro.InsertOnSubmit(diagretiro);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}

        ////G. EVALUACION MEDICA RETIRO

        ////Metodo para guardar datos Evaluacion medica
        //public static void guardarEvaluacionMedicaRetiro(Tbl_EvaluacionMedicaRetiro evamedretiro)
        //{
        //    try
        //    {
        //        evamedretiro.evaMedRet_estado = "A";
        //        dc.Tbl_EvaluacionMedicaRetiro.InsertOnSubmit(evamedretiro);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}

        ////H. RECOMENDACIONES Y/O TRATAMIENTO

        ////Metodo para guardar datos recomendacion y tratamiento
        //public static void guardarRecomendacionesTratamientoRetiro(Tbl_RecoTratamientoRetiro tratamientoretiro)
        //{
        //    try
        //    {
        //        tratamientoretiro.RecTraRetiro_estado = "A";
        //        dc.Tbl_RecoTratamientoRetiro.InsertOnSubmit(tratamientoretiro);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}

        ////I. DATOS DEL PROFESIONAL

        ////Metodo para guardar datos profesional
        //public static void guardarDatosProfesionalRetiro(Tbl_DatProfesionalRetiro datprofretiro)
        //{
        //    try
        //    {
        //        datprofretiro.DatProfeRetiro_estado = "A";
        //        dc.Tbl_DatProfesionalRetiro.InsertOnSubmit(datprofretiro);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}
    }
}
