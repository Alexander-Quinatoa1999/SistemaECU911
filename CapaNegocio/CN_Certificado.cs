using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Certificado
    {
        //private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();
        private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        //metodo traer para traer Datos Generales Certificado x persona
        public static Tbl_DatosGeneralesCertificado obtenerDatosGeneralesxPerCertificado(int personaid)
        {
            var datgencertificado = dc.Tbl_DatosGeneralesCertificado.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.datGen_estado == "A");
            return datgencertificado;
        }

        //metodo traer para traer APTITUD MÉDICA LABORAL Certificado x persona
        public static Tbl_AptitudMedicaCertificado obtenerAptiMedLaboralxPerCertificado(int personaid)
        {
            var aptmedlabocertificado = dc.Tbl_AptitudMedicaCertificado.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.AptMedCertificado_estado == "A");
            return aptmedlabocertificado;
        }

        //metodo traer para traer EVALUACIÓN MÉDICA DE RETIRO Certificado x persona
        public static Tbl_EvaMedicaRetiroCertificado obtenerEvaMedRetiroxPerCertificado(int personaid)
        {
            var evamedretcertificado = dc.Tbl_EvaMedicaRetiroCertificado.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.evaMedRet_estado == "A");
            return evamedretcertificado;
        }        

        //metodo traer para traer Recomendaciones Certificado x persona
        public static Tbl_RecomendacionesCertificado obtenerRecomendacionesxPerCertificado(int personaid)
        {
            var recocertificado = dc.Tbl_RecomendacionesCertificado.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.reco_estado == "A");
            return recocertificado;
        }

        //metodo traer para traer datos profesional x persona
        public static Tbl_DatProfesionalCertificado obtenerDatosProfesionalxPerCertificado(int personaid)
        {
            var datprofcertificado = dc.Tbl_DatProfesionalCertificado.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.DatProfeCertificado_estado == "A");
            return datprofcertificado;
        }

        //----------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------ METODOS PARA GUARDAR Y MODIFICAR DATOS  -----------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------

        //B. DATOS GENERALES

        //Metodo para guardar datos DATOS GENERALES
        public static void guardarDatosGeneralesCertificado(Tbl_DatosGeneralesCertificado datgencertificado)
        {
            try
            {
                datgencertificado.datGen_estado = "A";
                dc.Tbl_DatosGeneralesCertificado.InsertOnSubmit(datgencertificado);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //C. APTITUD MÉDICA LABORAL

        //Metodo para guardar datos APTITUD MÉDICA LABORAL
        public static void guardarAptiMedLaboralCertificado(Tbl_AptitudMedicaCertificado aptmedlabcertificado)
        {
            try
            {
                aptmedlabcertificado.AptMedCertificado_estado = "A";
                dc.Tbl_AptitudMedicaCertificado.InsertOnSubmit(aptmedlabcertificado);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //D. EVALUACIÓN MÉDICA DE RETIRO

        //Metodo para guardar datos EVALUACIÓN MÉDICA DE RETIRO
        public static void guardarEvaMedRetCertificado(Tbl_EvaMedicaRetiroCertificado evamedretcertificado)
        {
            try
            {
                evamedretcertificado.evaMedRet_estado = "A";
                dc.Tbl_EvaMedicaRetiroCertificado.InsertOnSubmit(evamedretcertificado);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //E. RECOMENDACIONES 

        //Metodo para guardar datos RECOMENDACIONES 
        public static void guardarRecomenCertificado(Tbl_RecomendacionesCertificado recocertificado)
        {
            try
            {
                recocertificado.reco_estado = "A";
                dc.Tbl_RecomendacionesCertificado.InsertOnSubmit(recocertificado);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

        //F. DATOS DEL PROFESIONAL

        //Metodo para guardar datos DATOS DEL PROFESIONAL
        public static void guardarDatosProfesionalCertificado(Tbl_DatProfesionalCertificado datprofcertificado)
        {
            try
            {
                datprofcertificado.DatProfeCertificado_estado = "A";
                dc.Tbl_DatProfesionalCertificado.InsertOnSubmit(datprofcertificado);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }
    }
}
