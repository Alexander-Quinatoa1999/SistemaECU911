using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaECU911.Template.Views
{
    public partial class Certificado : System.Web.UI.Page
    {

        DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        //Objeto de la tabla personas
        private Tbl_Personas per = new Tbl_Personas();

        //B. Objeto de la tabla Datos Gnerales
        private Tbl_DatosGeneralesCertificado datgen = new Tbl_DatosGeneralesCertificado();

        //C. Objeto de la tabla Aptitud Medica Laboral
        private Tbl_AptitudMedicaCertificado aptmed = new Tbl_AptitudMedicaCertificado();

        //D. Objeto de la tabla Evaluacion Medica de Retiro
        private Tbl_EvaMedicaRetiroCertificado evamed = new Tbl_EvaMedicaRetiroCertificado();

        //E. Objeto de la tabla Recomendaciones
        private Tbl_RecomendacionesCertificado reco = new Tbl_RecomendacionesCertificado();

        //F. Objeto de la tabla Datos Profesional
        private Tbl_DatProfesionalCertificado datprof = new Tbl_DatProfesionalCertificado();

        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatosModificar();
            cargarProfesional();
        }      

        protected void txt_numHistoCli_TextChanged(object sender, EventArgs e)
        {
            per = CN_HistorialMedico.obtenerPersonasxCedula(Convert.ToInt32(txt_numHClinica.Text));

            if (per != null)
            {
                txt_priNombre.Text = per.Per_priNombre.ToString();
                txt_segNombre.Text = per.Per_segNombre.ToString();
                txt_priApellido.Text = per.Per_priApellido.ToString();
                txt_segApellido.Text = per.Per_segApellido.ToString();
                txt_sexo.Text = per.Per_genero.ToString();
            }
        }

        private void CargarDatosModificar()
        {
            try
            {
                if (Request["cod"] != null)
                {
                    int codigo = Convert.ToInt32(Request["cod"]);

                    per = CN_HistorialMedico.obtenerPersonasxId(codigo);
                    int perso = Convert.ToInt32(per.Per_id.ToString());

                    datgen = CN_Certificado.obtenerDatosGeneralesxPerCertificado(perso);
                    aptmed = CN_Certificado.obtenerAptiMedLaboralxPerCertificado(perso);
                    evamed = CN_Certificado.obtenerEvaMedRetiroxPerCertificado(perso);
                    reco = CN_Certificado.obtenerRecomendacionesxPerCertificado(perso);
                    datprof = CN_Certificado.obtenerDatosProfesionalxPerCertificado(perso);                    

                    btn_guardacertificado.Visible = true;

                    if (per != null || datgen != null || aptmed != null || evamed != null ||
                        reco != null || datprof != null)
                    {
                        //A
                        txt_priNombre.Text = per.Per_priNombre.ToString();
                        txt_segNombre.Text = per.Per_segNombre.ToString();
                        txt_priApellido.Text = per.Per_priApellido.ToString();
                        txt_segApellido.Text = per.Per_segApellido.ToString();
                        txt_sexo.Text = per.Per_genero.ToString();
                        txt_numHClinica.Text = per.Per_Cedula.ToString();

                        //B
                        txt_fechaEmision.Text = datgen.datGen_fechEmision.ToString();
                        txt_ingreso.Text = datgen.datGen_ingreso.ToString();
                        txt_periodico.Text = datgen.datGen_periodico.ToString();
                        txt_reintegro.Text = datgen.datGen_reintegro.ToString();
                        txt_retiro.Text = datgen.datGen_retiro.ToString();

                        //C
                        txt_apto.Text = aptmed.AptMedCertificado_apto.ToString();
                        txt_aptoObservacion.Text = aptmed.AptMedCertificado_aptoObserva.ToString();
                        txt_aptoLimitaciones.Text = aptmed.AptMedCertificado_aptoLimi.ToString();
                        txt_noApto.Text = aptmed.AptMedCertificado_NoApto.ToString();
                        txt_detaObservaAptiMedLaboral.Text = aptmed.AptMedCertificado_Observ.ToString();

                        //D
                        txt_siEvaMedRetiro.Text = evamed.evaMedRet_siUsuEvaMed.ToString();
                        txt_noEvaMedRetiro.Text = evamed.evaMedRet_noUsuEvaMed.ToString();
                        txt_presuntivaEvaMedRetiro.Text = evamed.evaMedRet_presunCondiDiag.ToString();
                        txt_definitivaEvaMedRetiro.Text = evamed.evaMedRet_defiCondiDiag.ToString();
                        txt_noAplicaEvaMedRetiro.Text = evamed.evaMedRet_noAplicaCondiDiag.ToString();
                        txt_si2EvaMedRetiro.Text = evamed.evaMedRet_siCondiSalud.ToString();
                        txt_no2EvaMedRetiro.Text = evamed.evaMedRet_noAplicaCondiSalud.ToString();
                        txt_noAplica2EvaMedRetiro.Text = evamed.evaMedRet_noAplicaCondiSalud.ToString();

                        //E
                        txt_descripRecomendaciones.Text = reco.reco_descripcion.ToString();

                        //F
                        ddl_profesional.SelectedValue = datprof.prof_id.ToString();
                        txt_codigo.Text = datprof.DatProfeCertificado_cod.ToString();

                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Error')", true);
                    }

                }
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Guardados Incompletos')", true);
            }
        }

        private void guardar_modificar_datos(int perid, int datgenid, int aptmedlabid, int evamedretid, int recoid,
            int datprofid)
        {
            if (perid == 0 || datgenid == 0 || aptmedlabid == 0 || evamedretid == 0 || recoid == 0 || datprofid == 0)
            {
                GuardarCertificado();
            }
            else
            {
                per = CN_HistorialMedico.obtenerPersonasxId(perid);
                int perso = Convert.ToInt32(per.Per_id.ToString());

                datgen = CN_Certificado.obtenerDatosGeneralesxPerCertificado(perso);
                aptmed = CN_Certificado.obtenerAptiMedLaboralxPerCertificado(perso);
                evamed = CN_Certificado.obtenerEvaMedRetiroxPerCertificado(perso);
                reco = CN_Certificado.obtenerRecomendacionesxPerCertificado(perso);
                datprof = CN_Certificado.obtenerDatosProfesionalxPerCertificado(perso);

                if (per != null || datgen != null || aptmed != null || evamed != null ||
                    reco != null || datprof != null)
                {
                    //ModificarHistorial(per, emplant, antper, acctrabajo, enferprof, facriesgotractual, actvextralaboral,
                    //    exagenesperiespues, diagnostico, aptitudmedica);
                }

            }
        }

        private void GuardarCertificado()
        {
            try
            {
                per = CN_HistorialMedico.obtenerIdPersonasxCedula(Convert.ToInt32(txt_numHClinica.Text));

                int perso = Convert.ToInt32(per.Per_id.ToString());

                // B
                datgen = new Tbl_DatosGeneralesCertificado();
                // C
                aptmed = new Tbl_AptitudMedicaCertificado();
                // D
                evamed = new Tbl_EvaMedicaRetiroCertificado();
                // E
                reco = new Tbl_RecomendacionesCertificado();
                // F
                datprof = new Tbl_DatProfesionalCertificado();


                //B. Captura de datos Datos Generales
                datgen.datGen_fechEmision = Convert.ToDateTime(txt_fechaEmision.Text);
                datgen.datGen_ingreso = txt_ingreso.Text;
                datgen.datGen_periodico = txt_periodico.Text;
                datgen.datGen_reintegro = txt_reintegro.Text;
                datgen.datGen_retiro = txt_retiro.Text;
                datgen.Per_id = perso;

                //C. Captura de Datos Aptitud Medica Laboral
                aptmed.AptMedCertificado_apto = txt_apto.Text;
                aptmed.AptMedCertificado_aptoObserva = txt_aptoObservacion.Text;
                aptmed.AptMedCertificado_aptoLimi = txt_aptoLimitaciones.Text;
                aptmed.AptMedCertificado_NoApto = txt_noApto.Text;
                aptmed.AptMedCertificado_Observ = txt_detaObservaAptiMedLaboral.Text;
                aptmed.Per_id = perso;

                //D. Captura de Datos Evaluacion Medica de Retiro
                evamed.evaMedRet_siUsuEvaMed = txt_siEvaMedRetiro.Text;
                evamed.evaMedRet_noUsuEvaMed = txt_noEvaMedRetiro.Text;
                evamed.evaMedRet_presunCondiDiag = txt_presuntivaEvaMedRetiro.Text;
                evamed.evaMedRet_defiCondiDiag = txt_definitivaEvaMedRetiro.Text;
                evamed.evaMedRet_noAplicaCondiDiag = txt_noAplicaEvaMedRetiro.Text;
                evamed.evaMedRet_siCondiSalud = txt_si2EvaMedRetiro.Text;
                evamed.evaMedRet_noAplicaCondiSalud = txt_no2EvaMedRetiro.Text;
                evamed.evaMedRet_noAplicaCondiSalud = txt_noAplica2EvaMedRetiro.Text;
                evamed.Per_id = perso;

                //E. Captura de Datos Recomendaciones
                reco.reco_descripcion = txt_descripRecomendaciones.Text;
                reco.Per_id = perso;

                //F. Captura de Datos Tbl_ResExaGenEspRiesTrabajo
                datprof.prof_id = Convert.ToInt32(ddl_profesional.SelectedValue);
                datprof.DatProfeCertificado_cod = txt_codigo.Text;
                datprof.Per_id = perso;

                //B . Método para guardar Datos Datos Generales
                CN_Certificado.guardarDatosGeneralesCertificado(datgen);
                //C. Metodo para guardar Datos Aptitud Medica Laboral
                CN_Certificado.guardarAptiMedLaboralCertificado(aptmed);
                //D. Método de guardar Datos Evaluacion Medica de Retiro
                CN_Certificado.guardarEvaMedRetCertificado(evamed);
                //E. Método de guardar Datos Recomendaciones
                CN_Certificado.guardarRecomenCertificado(reco);
                //F. Método de guardar Datos del profesional
                CN_Certificado.guardarDatosProfesionalCertificado(datprof);


                //Mensaje de confirmacion
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Guardados Exitosamente')", true);

                Response.Redirect("~/Template/Views/PacientesCertificado.aspx");
                limpiar();
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Guardados')", true);
            }
        }

        private void cargarProfesional()
        {
            List<Tbl_Profesional> listaProf = new List<Tbl_Profesional>();
            listaProf = CN_HistorialMedico.obtenerProfesional();
            listaProf.Insert(0, new Tbl_Profesional() { prof_NomApe = "Seleccione ........" });

            ddl_profesional.DataSource = listaProf;
            ddl_profesional.DataTextField = "prof_NomApe";
            ddl_profesional.DataValueField = "prof_id";
            ddl_profesional.DataBind();
        }

        private void limpiar()
        {
            throw new NotImplementedException();
        }

        protected void btn_guardacertificado_Click(object sender, EventArgs e)
        {
            guardar_modificar_datos(Convert.ToInt32(Request["cod"]), Convert.ToInt32(per.Per_id.ToString()),
            Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()),
            Convert.ToInt32(per.Per_id.ToString()));
        }

        protected void btn_modificacertificado_Click(object sender, EventArgs e)
        {

        }

        protected void btn_cancelacertificado_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/Views/Inicio.aspx");
        }
    }
}