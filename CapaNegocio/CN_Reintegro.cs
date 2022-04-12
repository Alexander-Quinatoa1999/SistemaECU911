using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Reintegro
    {
        ////private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();
        //private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        ////metodo traer para traer Datos Establecimeinto Empresa Usuario x persona
        //public static Tbl_DatEstableEmpUsuReintegro obtenerDatEstEmpUsuReintegro(int personaid)
        //{
        //    var datempusuid = dc.Tbl_DatEstableEmpUsuReintegro.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.datEstable_estado == "A");
        //    return datempusuid;
        //}

        ////metodo traer para traer Motivo Consulta Reintegro x persona
        //public static Tbl_MotivoConsultaReintegro obtenerMotivoConsultaxPerReintegro(int personaid)
        //{
        //    var motconreintegro = dc.Tbl_MotivoConsultaReintegro.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.motConReintegro_estado == "A");
        //    return motconreintegro;
        //}

        ////metodo traer para traer Enfermedad Actual Reintegro x persona
        //public static Tbl_EnfermedadActualReintegro obtenerEnferActxPerReintegro(int personaid)
        //{
        //    var enferactreintegro = dc.Tbl_EnfermedadActualReintegro.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.enfActualReintegro_estado == "A");
        //    return enferactreintegro;
        //}

        ////metodo traer para traer Examen fisico regional Reintegro x persona
        //public static Tbl_ExaFisRegionalReintegro obtenerExaFisRegxPerReintegro(int personaid)
        //{
        //    var exafisregreintegro = dc.Tbl_ExaFisRegionalReintegro.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.exaFisRegReintegro_estado == "A");
        //    return exafisregreintegro;
        //}

        ////metodo traer para traer Examen (Imagen, Laboratorio y otros) Reintegro x persona
        //public static Tbl_ResExaGenEspRiesTrabajoReintegro obtenerResExaGenEspRiesTrabaxPerReintegro(int personaid)
        //{
        //    var resexamenreintegro = dc.Tbl_ResExaGenEspRiesTrabajoReintegro.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.ResExaGenEspRiesTrabajoReintegro_estado == "A");
        //    return resexamenreintegro;
        //}

        ////metodo traer para traer Diagnostico Reintegro x persona
        //public static Tbl_DiagnosticoReintegro obtenerDiagnosticoxPerReintegro(int personaid)
        //{
        //    var diagreintegro = dc.Tbl_DiagnosticoReintegro.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.DiagReintegro_estado == "A");
        //    return diagreintegro;
        //}

        ////metodo traer para traer Aptitud Medica Reintegro x persona
        //public static Tbl_AptitudMedicaReintegro obtenerAptMedicaxPerReintegro(int personaid)
        //{
        //    var aptmedreintegro = dc.Tbl_AptitudMedicaReintegro.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.AptMedReintegro_estado == "A");
        //    return aptmedreintegro;
        //}

        ////metodo traer para traer Recomendaciones y tratamiento Reintegro x persona
        //public static Tbl_RecoTratamientoReintegro obtenerTratamientoxPerReintegro(int personaid)
        //{
        //    var tratamientoreintegro = dc.Tbl_RecoTratamientoReintegro.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.RecTraReintegro_estado == "A");
        //    return tratamientoreintegro;
        //}

        ////metodo traer para traer datos profesional x persona
        //public static Tbl_DatProfesionalReintegro obtenerDatosProfesionalxPerReintegro(int personaid)
        //{
        //    var datprofreintegro = dc.Tbl_DatProfesionalReintegro.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.DatProfeReintegro_estado == "A");
        //    return datprofreintegro;
        //}

        ////----------------------------------------------------------------------------------------------------------------------------
        ////------------------------------------------ METODOS PARA GUARDAR Y MODIFICAR DATOS  -----------------------------------------
        ////----------------------------------------------------------------------------------------------------------------------------

        ////A. DATOS DEL ESTABLECIMIENTO - EMPRESA Y USUARIO

        ////Metodo para guardar datos DATOS DE EMPRESA Y USUARIO
        //public static void guardarDatEstEmpreUsuarReintegro(Tbl_DatEstableEmpUsuReintegro datosestempresausu)
        //{
        //    try
        //    {
        //        datosestempresausu.datEstable_estado = "A";
        //        dc.Tbl_DatEstableEmpUsuReintegro.InsertOnSubmit(datosestempresausu);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}

        ////B. MOTIVO DE CONSULTA

        ////Metodo para guardar datos MOTIVO CONSULTA
        //public static void guardarMotivoConsultaReintegro(Tbl_MotivoConsultaReintegro motconreintegro)
        //{
        //    try
        //    {
        //        motconreintegro.motConReintegro_estado = "A";
        //        dc.Tbl_MotivoConsultaReintegro.InsertOnSubmit(motconreintegro);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}

        ////C. ENFERMEDAD ACTUAL

        ////Metodo para guardar datos Enfermedad Actual
        //public static void guardarEnfermedadActualReintegro(Tbl_EnfermedadActualReintegro enferactreintegro)
        //{
        //    try
        //    {
        //        enferactreintegro.enfActualReintegro_estado = "A";
        //        dc.Tbl_EnfermedadActualReintegro.InsertOnSubmit(enferactreintegro);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}

        ////E. EXAMEN FÍSICO REGIONAL

        ////Metodo para guardar datos REVISIÓN ACTUAL DE ÓRGANOS Y SISTEMAS
        //public static void guardarExamenFisicoRegionalReintegro(Tbl_ExaFisRegionalReintegro exafisregreintegro)
        //{
        //    try
        //    {
        //        exafisregreintegro.exaFisRegReintegro_estado = "A";
        //        dc.Tbl_ExaFisRegionalReintegro.InsertOnSubmit(exafisregreintegro);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}

        ////F. RESULTADO DE EXAMENES GENERALES 
        ////Metodo para guardar datos RESULTADO DE EXAMENES GENERALES 
        //public static void guardarExaGeneralReintegro(Tbl_ResExaGenEspRiesTrabajoReintegro resexamenreintegro)
        //{
        //    try
        //    {
        //        resexamenreintegro.ResExaGenEspRiesTrabajoReintegro_estado = "A";
        //        dc.Tbl_ResExaGenEspRiesTrabajoReintegro.InsertOnSubmit(resexamenreintegro);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}

        ////G. DIAGNÓSTICO

        ////Metodo para guardar datos DIAGNÓSTICO
        //public static void guardarDiagnosticoReintegro(Tbl_DiagnosticoReintegro diagreintegro)
        //{
        //    try
        //    {
        //        diagreintegro.DiagReintegro_estado = "A";
        //        dc.Tbl_DiagnosticoReintegro.InsertOnSubmit(diagreintegro);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}


        ////H. APTITUD MÉDICA PARA EL TRABAJO

        ////Metodo para guardar datos APTITUD MÉDICA PARA EL TRABAJO
        //public static void guardarAptiMediTrabajoReintegro(Tbl_AptitudMedicaReintegro aptmedreintegro)
        //{
        //    try
        //    {
        //        aptmedreintegro.AptMedReintegro_estado = "A";
        //        dc.Tbl_AptitudMedicaReintegro.InsertOnSubmit(aptmedreintegro);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}

        ////I. RECOMENDACIONES Y/O TRATAMIENTO

        ////Metodo para guardar datos APTITUD MÉDICA PARA EL TRABAJO
        //public static void guardarRecomendacionesTratamientoReintegro(Tbl_RecoTratamientoReintegro tratamientoreintegro)
        //{
        //    try
        //    {
        //        tratamientoreintegro.RecTraReintegro_estado = "A";
        //        dc.Tbl_RecoTratamientoReintegro.InsertOnSubmit(tratamientoreintegro);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}

        ////J. DATOS DEL PROFESIONAL

        ////Metodo para guardar datos DATOS DEL PROFESIONAL
        //public static void guardarDatosProfesionalReintegro(Tbl_DatProfesionalReintegro datprofreintegro)
        //{
        //    try
        //    {
        //        datprofreintegro.DatProfeReintegro_estado = "A";
        //        dc.Tbl_DatProfesionalReintegro.InsertOnSubmit(datprofreintegro);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}
    }
}
