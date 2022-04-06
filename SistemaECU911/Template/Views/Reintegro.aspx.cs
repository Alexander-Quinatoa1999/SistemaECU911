using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaNegocio;

namespace SistemaECU911.Template.Views
{
    public partial class Reintegro : System.Web.UI.Page
    {
        DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        //Objeto de la tabla personas
        private Tbl_Personas per = new Tbl_Personas();

        //A. Objeto de la tabla Datos del establecimiento Emp - Usu
        private Tbl_DatEstableEmpUsuReintegro datestable = new Tbl_DatEstableEmpUsuReintegro();

        //B. Objeto de la tabla MOTIVO CONSULTA 
        private Tbl_MotivoConsultaReintegro motconreintegro = new Tbl_MotivoConsultaReintegro();

        //C. Objeto de la tabla ENFERMEDAD ACTUAL
        private Tbl_EnfermedadActualReintegro enferactreintegro = new Tbl_EnfermedadActualReintegro();

        //E. Objeto de la tabla EXAMEN FÍSICO REGIONAL
        private Tbl_ExaFisRegionalReintegro exafisregreintegro = new Tbl_ExaFisRegionalReintegro();

        //F. Objeto de la tabla RESULTADO DE EXAMENES GENERALES
        private Tbl_ResExaGenEspRiesTrabajoReintegro resexamenreintegro = new Tbl_ResExaGenEspRiesTrabajoReintegro();

        //G. Objeto de la tabla DIAGNÓSTICO
        private Tbl_DiagnosticoReintegro diagreintegro = new Tbl_DiagnosticoReintegro();

        //H. Objeto de la tabla APTITUD MÉDICA PARA EL TRABAJO
        private Tbl_AptitudMedicaReintegro aptmedreintegro = new Tbl_AptitudMedicaReintegro();

        //I. Objeto de la tabla RECOMENDACIONES Y/O TRATAMIENTO
        private Tbl_RecoTratamientoReintegro tratamientoreintegro = new Tbl_RecoTratamientoReintegro();

        //J. Objeto de la tabla DATOS DEL PROFESIONAL
        private Tbl_DatProfesionalReintegro datprofreintegro = new Tbl_DatProfesionalReintegro();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarDatosModificar();
                cargarProfesional();
            }
        }

        protected void txt_numHClinica_TextChanged(object sender, EventArgs e)
        {
            per = CN_HistorialMedico.obtenerPersonasxCedula(Convert.ToInt32(txt_numHClinica.Text));

            if (per != null)
            {
                txt_priNombre.Text = per.Per_priNombre.ToString();
                txt_segNombre.Text = per.Per_segNombre.ToString();
                txt_priApellido.Text = per.Per_priApellido.ToString();
                txt_segApellido.Text = per.Per_segApellido.ToString();
                txt_sexo.Text = per.Per_genero.ToString();
                txt_edad.Text = per.Per_fechNacimiento.ToString();
            }
        }

        private void CargarDatosModificar()
        {
            try
            {
                if (Request["cod"] != null)
                {
                    int codigo = Convert.ToInt32(Request["cod"]);

                    per = CN_HistorialMedico.ObtenerPersonasxId(codigo);
                    int perso = Convert.ToInt32(per.Per_id.ToString());

                    datestable = CN_Reintegro.obtenerDatEstEmpUsuReintegro(perso);
                    motconreintegro = CN_Reintegro.obtenerMotivoConsultaxPerReintegro(perso);
                    enferactreintegro = CN_Reintegro.obtenerEnferActxPerReintegro(perso);
                    exafisregreintegro = CN_Reintegro.obtenerExaFisRegxPerReintegro(perso);
                    resexamenreintegro = CN_Reintegro.obtenerResExaGenEspRiesTrabaxPerReintegro(perso);
                    diagreintegro = CN_Reintegro.obtenerDiagnosticoxPerReintegro(perso);
                    aptmedreintegro = CN_Reintegro.obtenerAptMedicaxPerReintegro(perso);
                    tratamientoreintegro = CN_Reintegro.obtenerTratamientoxPerReintegro(perso);
                    datprofreintegro = CN_Reintegro.obtenerDatosProfesionalxPerReintegro(perso);

                    btn_guardareintegro.Visible = true;

                    if (per != null || datestable != null || motconreintegro != null || enferactreintegro != null || exafisregreintegro != null ||
                        resexamenreintegro != null || diagreintegro != null || aptmedreintegro != null ||
                        tratamientoreintegro != null || datprofreintegro != null)
                    {
                        //A
                        txt_priNombre.Text = per.Per_priNombre.ToString();
                        txt_segNombre.Text = per.Per_segNombre.ToString();
                        txt_priApellido.Text = per.Per_priApellido.ToString();
                        txt_segApellido.Text = per.Per_segApellido.ToString();
                        txt_sexo.Text = per.Per_genero.ToString();
                        txt_numHClinica.Text = per.Per_Cedula.ToString();

                        //A
                        txt_fechaUltiDiaLaboral.Text = datestable.datEstable__fechUltDiaLaboral.ToString();
                        txt_fechaReingreso.Text = datestable.datEstable_fechReingreso.ToString();
                        txt_total.Text = datestable.datEstable_total.ToString();
                        txt_causaSalida.Text = datestable.datEstable_causaSalida.ToString();

                        //B
                        txt_motivoconsultareintegro.Text = motconreintegro.motConReintegro_descrip.ToString();

                        //C
                        txt_enfermedadactualreintegro.Text = enferactreintegro.enfActualReintegro_descrip.ToString();

                        //E
                        txt_cicatrices.Text = exafisregreintegro.exaFisRegReintegro_cicatricesPiel.ToString();
                        txt_tatuajes.Text = exafisregreintegro.exaFisRegReintegro_tatuajesPiel.ToString();
                        txt_pielyfaneras.Text = exafisregreintegro.exaFisRegReintegro_pielFacerasPiel.ToString();
                        txt_parpados.Text = exafisregreintegro.exaFisRegReintegro_parpadosOjos.ToString();
                        txt_conjuntivas.Text = exafisregreintegro.exaFisRegReintegro_conjuntuvasOjos.ToString();
                        txt_pupilas.Text = exafisregreintegro.exaFisRegReintegro_pupilasOjos.ToString();
                        txt_cornea.Text = exafisregreintegro.exaFisRegReintegro_corneaOjos.ToString();
                        txt_motilidad.Text = exafisregreintegro.exaFisRegReintegro_motilidadOjos.ToString();
                        txt_auditivoexterno.Text = exafisregreintegro.exaFisRegReintegro_cAudiExtreOido.ToString();
                        txt_pabellon.Text = exafisregreintegro.exaFisRegReintegro_pabellonOido.ToString();
                        txt_timpanos.Text = exafisregreintegro.exaFisRegReintegro_timpanosOido.ToString();
                        txt_labios.Text = exafisregreintegro.exaFisRegReintegro_labiosOroFa.ToString();
                        txt_lengua.Text = exafisregreintegro.exaFisRegReintegro_lenguaOroFa.ToString();
                        txt_faringe.Text = exafisregreintegro.exaFisRegReintegro_faringeOroFa.ToString();
                        txt_amigdalas.Text = exafisregreintegro.exaFisRegReintegro_amigdalasOroFa.ToString();
                        txt_dentadura.Text = exafisregreintegro.exaFisRegReintegro_dentaduraOroFa.ToString();
                        txt_tabique.Text = exafisregreintegro.exaFisRegReintegro_tabiqueNariz.ToString();
                        txt_cornetes.Text = exafisregreintegro.exaFisRegReintegro_cornetesNariz.ToString();
                        txt_mucosa.Text = exafisregreintegro.exaFisRegReintegro_mucosasNariz.ToString();
                        txt_senosparanasales.Text = exafisregreintegro.exaFisRegReintegro_senosParanaNariz.ToString();
                        txt_tiroides.Text = exafisregreintegro.exaFisRegReintegro_tiroiMasasCuello.ToString();
                        txt_movilidad.Text = exafisregreintegro.exaFisRegReintegro_movilidadCuello.ToString();
                        txt_mamas.Text = exafisregreintegro.exaFisRegReintegro_mamasTorax.ToString();
                        txt_corazon.Text = exafisregreintegro.exaFisRegReintegro_corazonTorax.ToString();
                        txt_pulmones.Text = exafisregreintegro.exaFisRegReintegro_pulmonesTorax2.ToString();
                        txt_parrillacostal.Text = exafisregreintegro.exaFisRegReintegro_parriCostalTorax2.ToString();
                        txt_visceras.Text = exafisregreintegro.exaFisRegReintegro_viscerasAbdomen.ToString();
                        txt_paredabdominal.Text = exafisregreintegro.exaFisRegReintegro_paredAbdomiAbdomen.ToString();
                        txt_flexibilidad.Text = exafisregreintegro.exaFisRegReintegro_flexibilidadColumna.ToString();
                        txt_desviacion.Text = exafisregreintegro.exaFisRegReintegro_desviacionColumna.ToString();
                        txt_dolor.Text = exafisregreintegro.exaFisRegReintegro_dolorColumna.ToString();
                        txt_pelvis.Text = exafisregreintegro.exaFisRegReintegro_pelvisPelvis.ToString();
                        txt_genitales.Text = exafisregreintegro.exaFisRegReintegro_genitalesPelvis.ToString();
                        txt_vascular.Text = exafisregreintegro.exaFisRegReintegro_vascularExtre.ToString();
                        txt_miembrosuperiores.Text = exafisregreintegro.exaFisRegReintegro_miemSupeExtre.ToString();
                        txt_miembrosinferiores.Text = exafisregreintegro.exaFisRegReintegro_miemInfeExtre.ToString();
                        txt_fuerza.Text = exafisregreintegro.exaFisRegReintegro_fuerzaNeuro.ToString();
                        txt_sensibilidad.Text = exafisregreintegro.exaFisRegReintegro_sensibiNeuro.ToString();
                        txt_marcha.Text = exafisregreintegro.exaFisRegReintegro_marchaNeuro.ToString();
                        txt_reflejos.Text = exafisregreintegro.exaFisRegReintegro_refleNeuro.ToString();
                        txt_obervexamenfisicoregional.Text = exafisregreintegro.exaFisRegReintegro_observa.ToString();

                        //F
                        txt_examen.Text = resexamenreintegro.ResExaGenEspRiesTrabajoReintegro_examen.ToString();
                        txt_fechaexamen.Text = resexamenreintegro.ResExaGenEspRiesTrabajoReintegro_fecha.ToString();
                        txt_resultadoexamen.Text = resexamenreintegro.ResExaGenEspRiesTrabajoReintegro_resultados.ToString();
                        txt_observacionexamen.Text = resexamenreintegro.ResExaGenEspRiesTrabajoReintegro_observaciones.ToString();

                        //G
                        txt_descripdiagnostico.Text = diagreintegro.DiagReintegro_descripcion.ToString();
                        txt_cie.Text = diagreintegro.DiagReintegro_cie.ToString();
                        txt_pre.Text = diagreintegro.DiagReintegro_pre.ToString();
                        txt_def.Text = diagreintegro.DiagReintegro_def.ToString();

                        //H
                        txt_apto.Text = aptmedreintegro.AptMedReintegro_apto.ToString();
                        txt_aptoobservacion.Text = aptmedreintegro.AptMedReintegro_aptoObserva.ToString();
                        txt_aptolimitacion.Text = aptmedreintegro.AptMedReintegro_aptoLimi.ToString();
                        txt_noapto.Text = aptmedreintegro.AptMedReintegro_NoApto.ToString();
                        txt_observacionaptitud.Text = aptmedreintegro.AptMedReintegro_Observ.ToString();
                        txt_limitacionaptitud.Text = aptmedreintegro.AptMedReintegro_Limit.ToString();
                        txt_reubicacionaptitud.Text = aptmedreintegro.AptMedReintegro_Reubica.ToString();

                        //I
                        txt_descripciontratamientoreintegro.Text = tratamientoreintegro.RecTraReintegro_descripcion.ToString();

                        //J
                        txt_fechaDatProf.Text = datprofreintegro.DatProfeReintegro_fecha_hora.ToString();
                        ddl_profesional.SelectedValue = datprofreintegro.prof_id.ToString();
                        txt_codigoDatProf.Text = datprofreintegro.DatProfeReintegro_cod.ToString();

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

        private void guardar_modificar_datos(int perid, int datempusuperid, int motconperid, int enfactperid, int exafiregperid,
            int resexgenperid, int diagperid, int aptmedperid, int traperid, int datproperid)
        {
            if (perid == 0 || datempusuperid == 0 || motconperid == 0 || enfactperid == 0 || exafiregperid == 0
                || resexgenperid == 0 || diagperid == 0 || aptmedperid == 0 || traperid == 0 || datproperid == 0)
            {
                GuardarReintegro();
            }
            else
            {
                per = CN_HistorialMedico.ObtenerPersonasxId(perid);
                int perso = Convert.ToInt32(per.Per_id.ToString());

                motconreintegro = CN_Reintegro.obtenerMotivoConsultaxPerReintegro(perso);
                enferactreintegro = CN_Reintegro.obtenerEnferActxPerReintegro(perso);
                exafisregreintegro = CN_Reintegro.obtenerExaFisRegxPerReintegro(perso);
                resexamenreintegro = CN_Reintegro.obtenerResExaGenEspRiesTrabaxPerReintegro(perso);
                diagreintegro = CN_Reintegro.obtenerDiagnosticoxPerReintegro(perso);
                aptmedreintegro = CN_Reintegro.obtenerAptMedicaxPerReintegro(perso);
                tratamientoreintegro = CN_Reintegro.obtenerTratamientoxPerReintegro(perso);
                datprofreintegro = CN_Reintegro.obtenerDatosProfesionalxPerReintegro(perso);

                if (per != null || motconreintegro != null || enferactreintegro != null || exafisregreintegro != null ||
                    resexamenreintegro != null || diagreintegro != null || aptmedreintegro != null ||
                    tratamientoreintegro != null || datprofreintegro != null)
                {
                    //ModificarHistorial(per, emplant, antper, acctrabajo, enferprof, facriesgotractual, actvextralaboral,
                    //    exagenesperiespues, diagnostico, aptitudmedica);
                }

            }
        }

        private void GuardarReintegro()
        {
            try
            {
                per = CN_HistorialMedico.ObtenerIdPersonasxCedula(Convert.ToInt32(txt_numHClinica.Text));

                int perso = Convert.ToInt32(per.Per_id.ToString());

                //A
                datestable = new Tbl_DatEstableEmpUsuReintegro();
                // B
                motconreintegro = new Tbl_MotivoConsultaReintegro();
                // C
                enferactreintegro = new Tbl_EnfermedadActualReintegro();
                // E
                exafisregreintegro = new Tbl_ExaFisRegionalReintegro();
                // F
                resexamenreintegro = new Tbl_ResExaGenEspRiesTrabajoReintegro();
                // G
                diagreintegro = new Tbl_DiagnosticoReintegro();
                // H
                aptmedreintegro = new Tbl_AptitudMedicaReintegro();
                // I
                tratamientoreintegro = new Tbl_RecoTratamientoReintegro();
                // J
                datprofreintegro = new Tbl_DatProfesionalReintegro();

                //A. Captura de datos Datos Establecimiento
                datestable.datEstable__fechUltDiaLaboral = Convert.ToDateTime(txt_fechaUltiDiaLaboral.Text);
                datestable.datEstable_fechReingreso = Convert.ToDateTime(txt_fechaReingreso.Text);
                datestable.datEstable_total = Convert.ToInt32(txt_total.Text);
                datestable.datEstable_causaSalida = txt_causaSalida.Text;
                datestable.Per_id = perso;

                //B. Captura de datos Motivo de Consulta
                motconreintegro.motConReintegro_descrip = txt_motivoconsultareintegro.Text;
                motconreintegro.Per_id = perso;

                //C. Captura de Datos Enfermedad Actual
                enferactreintegro.enfActualReintegro_descrip = txt_enfermedadactualreintegro.Text;
                enferactreintegro.Per_id = perso;

                //E. Captura de Datos Examen Fisico Regional
                exafisregreintegro.exaFisRegReintegro_cicatricesPiel = txt_cicatrices.Text;
                exafisregreintegro.exaFisRegReintegro_tatuajesPiel = txt_tatuajes.Text;
                exafisregreintegro.exaFisRegReintegro_pielFacerasPiel = txt_pielyfaneras.Text;
                exafisregreintegro.exaFisRegReintegro_parpadosOjos = txt_parpados.Text;
                exafisregreintegro.exaFisRegReintegro_conjuntuvasOjos = txt_conjuntivas.Text;
                exafisregreintegro.exaFisRegReintegro_pupilasOjos = txt_pupilas.Text;
                exafisregreintegro.exaFisRegReintegro_corneaOjos = txt_cornea.Text;
                exafisregreintegro.exaFisRegReintegro_motilidadOjos = txt_motilidad.Text;
                exafisregreintegro.exaFisRegReintegro_cAudiExtreOido = txt_auditivoexterno.Text;
                exafisregreintegro.exaFisRegReintegro_pabellonOido = txt_pabellon.Text;
                exafisregreintegro.exaFisRegReintegro_timpanosOido = txt_timpanos.Text;
                exafisregreintegro.exaFisRegReintegro_labiosOroFa = txt_labios.Text;
                exafisregreintegro.exaFisRegReintegro_lenguaOroFa = txt_lengua.Text;
                exafisregreintegro.exaFisRegReintegro_faringeOroFa = txt_faringe.Text;
                exafisregreintegro.exaFisRegReintegro_amigdalasOroFa = txt_amigdalas.Text;
                exafisregreintegro.exaFisRegReintegro_dentaduraOroFa = txt_dentadura.Text;
                exafisregreintegro.exaFisRegReintegro_tabiqueNariz = txt_tabique.Text;
                exafisregreintegro.exaFisRegReintegro_cornetesNariz = txt_cornetes.Text;
                exafisregreintegro.exaFisRegReintegro_mucosasNariz = txt_mucosa.Text;
                exafisregreintegro.exaFisRegReintegro_senosParanaNariz = txt_senosparanasales.Text;
                exafisregreintegro.exaFisRegReintegro_tiroiMasasCuello = txt_tiroides.Text;
                exafisregreintegro.exaFisRegReintegro_movilidadCuello = txt_movilidad.Text;
                exafisregreintegro.exaFisRegReintegro_mamasTorax = txt_mamas.Text;
                exafisregreintegro.exaFisRegReintegro_corazonTorax = txt_corazon.Text;
                exafisregreintegro.exaFisRegReintegro_pulmonesTorax2 = txt_pulmones.Text;
                exafisregreintegro.exaFisRegReintegro_parriCostalTorax2 = txt_parrillacostal.Text;
                exafisregreintegro.exaFisRegReintegro_viscerasAbdomen = txt_visceras.Text;
                exafisregreintegro.exaFisRegReintegro_paredAbdomiAbdomen = txt_paredabdominal.Text;
                exafisregreintegro.exaFisRegReintegro_flexibilidadColumna = txt_flexibilidad.Text;
                exafisregreintegro.exaFisRegReintegro_desviacionColumna = txt_desviacion.Text;
                exafisregreintegro.exaFisRegReintegro_dolorColumna = txt_dolor.Text;
                exafisregreintegro.exaFisRegReintegro_pelvisPelvis = txt_pelvis.Text;
                exafisregreintegro.exaFisRegReintegro_genitalesPelvis = txt_genitales.Text;
                exafisregreintegro.exaFisRegReintegro_vascularExtre = txt_vascular.Text;
                exafisregreintegro.exaFisRegReintegro_miemSupeExtre = txt_miembrosuperiores.Text;
                exafisregreintegro.exaFisRegReintegro_miemInfeExtre = txt_miembrosinferiores.Text;
                exafisregreintegro.exaFisRegReintegro_fuerzaNeuro = txt_fuerza.Text;
                exafisregreintegro.exaFisRegReintegro_sensibiNeuro = txt_sensibilidad.Text;
                exafisregreintegro.exaFisRegReintegro_marchaNeuro = txt_marcha.Text;
                exafisregreintegro.exaFisRegReintegro_refleNeuro = txt_reflejos.Text;
                exafisregreintegro.exaFisRegReintegro_observa = txt_obervexamenfisicoregional.Text;
                exafisregreintegro.Per_id = perso;

                //F. Captura de Datos Tbl_ResExaGenEspRiesTrabajo
                resexamenreintegro.ResExaGenEspRiesTrabajoReintegro_examen = txt_examen.Text;
                resexamenreintegro.ResExaGenEspRiesTrabajoReintegro_fecha = Convert.ToDateTime(txt_fechaexamen.Text);
                resexamenreintegro.ResExaGenEspRiesTrabajoReintegro_resultados = txt_resultadoexamen.Text;
                resexamenreintegro.ResExaGenEspRiesTrabajoReintegro_observaciones = txt_observacionexamen.Text;
                resexamenreintegro.Per_id = perso;

                //G. Captura de Datos Tbl_Diagnostico
                diagreintegro.DiagReintegro_descripcion = txt_descripdiagnostico.Text;
                diagreintegro.DiagReintegro_cie = txt_cie.Text;
                diagreintegro.DiagReintegro_pre = txt_pre.Text;
                diagreintegro.DiagReintegro_def = txt_def.Text;
                diagreintegro.Per_id = perso;

                //H.Captura de Datos Tbl_AptitudMedica
                aptmedreintegro.AptMedReintegro_apto = txt_apto.Text;
                aptmedreintegro.AptMedReintegro_aptoObserva = txt_aptoobservacion.Text;
                aptmedreintegro.AptMedReintegro_aptoLimi = txt_aptolimitacion.Text;
                aptmedreintegro.AptMedReintegro_NoApto = txt_noapto.Text;
                aptmedreintegro.AptMedReintegro_Observ = txt_observacionaptitud.Text;
                aptmedreintegro.AptMedReintegro_Limit = txt_limitacionaptitud.Text;
                aptmedreintegro.AptMedReintegro_Reubica = txt_reubicacionaptitud.Text;
                aptmedreintegro.Per_id = perso;

                //I. Captura de Datos Recomendaciones y/o Tratamiento
                tratamientoreintegro.RecTraReintegro_descripcion = txt_descripciontratamientoreintegro.Text;
                tratamientoreintegro.Per_id = perso;

                //J. Captura de Datos RProfesional
                datprofreintegro.DatProfeReintegro_fecha_hora = Convert.ToDateTime(txt_fechaDatProf.Text);
                datprofreintegro.prof_id = Convert.ToInt32(ddl_profesional.SelectedValue);
                datprofreintegro.DatProfeReintegro_cod = txt_codigoDatProf.Text;
                datprofreintegro.Per_id = perso;


                //A. Metodo para guardar Datos Establecimiento
                CN_Reintegro.guardarDatEstEmpreUsuarReintegro(datestable);
                //B . Método para guardar Datos Motivo Consulta
                CN_Reintegro.guardarMotivoConsultaReintegro(motconreintegro);
                //F. Método de guardar Datos Enfermedad Actual
                CN_Reintegro.guardarEnfermedadActualReintegro(enferactreintegro);
                //I. Método de guardar Datos Examen Fisico Regional
                CN_Reintegro.guardarExamenFisicoRegionalReintegro(exafisregreintegro);
                //J. Método de guardar Datos Resul. Exam. General
                CN_Reintegro.guardarExaGeneralReintegro(resexamenreintegro);
                //K. Método de guardar Datos diagnostico
                CN_Reintegro.guardarDiagnosticoReintegro(diagreintegro);
                //L. Método de guardar Datos aptitud medica para el trabajo
                CN_Reintegro.guardarAptiMediTrabajoReintegro(aptmedreintegro);
                //M. Método de guardar Datos recomendaciones y tratamiento
                CN_Reintegro.guardarRecomendacionesTratamientoReintegro(tratamientoreintegro);
                //N. Método de guardar Datos del profesional
                CN_Reintegro.guardarDatosProfesionalReintegro(datprofreintegro);


                //Mensaje de confirmacion
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Guardados Exitosamente')", true);

                Response.Redirect("~/Template/Views/PacientesReintegro.aspx");
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
            listaProf = CN_HistorialMedico.ObtenerProfesional();
            listaProf.Insert(0, new Tbl_Profesional() { prof_NomApe = "Seleccione ........" });

            ddl_profesional.DataSource = listaProf;
            ddl_profesional.DataTextField = "prof_NomApe";
            ddl_profesional.DataValueField = "prof_id";
            ddl_profesional.DataBind();
        }

        private void limpiar()
        {

        }

        protected void btn_guardareintegro_Click(object sender, EventArgs e)
        {
            guardar_modificar_datos(Convert.ToInt32(Request["cod"]), Convert.ToInt32(per.Per_id.ToString()),
            Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()),
            Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()),
            Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()));
        }

        protected void btn_modificareintegro_Click(object sender, EventArgs e)
        {

        }

        protected void btn_cancelareintegro_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/Views/Inicio.aspx");
        }


    }
}