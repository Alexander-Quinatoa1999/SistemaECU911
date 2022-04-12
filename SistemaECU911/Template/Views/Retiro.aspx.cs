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
    public partial class Retiro : System.Web.UI.Page
    {
        //DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        ////Objeto de la tabla personas
        //private Tbl_Personas per = new Tbl_Personas();

        ////A. Objeto de la tabla Datos Establecimiento
        //private Tbl_DatEstableEmpUsuRetiro datestable = new Tbl_DatEstableEmpUsuRetiro();

        ////B. Objeto de la tabla ANTECEDENTES PERSONALES
        //private Tbl_AntecedentesPersonalesRetiro antperetiro = new Tbl_AntecedentesPersonalesRetiro();

        ////D. Objeto de la tabla EXAMEN FÍSICO REGIONAL
        //private Tbl_ExaFisRegionalRetiro exafisregretiro = new Tbl_ExaFisRegionalRetiro();

        ////E. Objeto de la tabla RESULTADO DE EXAMENES GENERALES
        //private Tbl_ResExaGenEspRiesTrabajoRetiro resexagenretiro = new Tbl_ResExaGenEspRiesTrabajoRetiro();

        ////F. Objeto de la tabla DIAGNÓSTICO
        //private Tbl_DiagnosticoRetiro diagretiro = new Tbl_DiagnosticoRetiro();

        ////G. Objeto de la tabla EVALUACION MEDICA
        //private Tbl_EvaluacionMedicaRetiro evamedretiro = new Tbl_EvaluacionMedicaRetiro();

        ////H. Objeto de la tabla RECOMENDACIONES Y/O TRATAMIENTO
        //private Tbl_RecoTratamientoRetiro tratamientoretiro = new Tbl_RecoTratamientoRetiro();

        ////I. Objeto de la tabla DATOS DEL PROFESIONAL
        //private Tbl_DatProfesionalRetiro datprofretiro = new Tbl_DatProfesionalRetiro();

        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    if (!IsPostBack)
        //    {
        //        CargarDatosModificar();
        //        cargarProfesional();
        //    }
        //}

        //protected void txt_numHClinica_TextChanged(object sender, EventArgs e)
        //{
        //    per = CN_HistorialMedico.obtenerPersonasxCedula(Convert.ToInt32(txt_numHClinica.Text));

        //    if (per != null)
        //    {
        //        txt_priNombre.Text = per.Per_priNombre.ToString();
        //        txt_segNombre.Text = per.Per_segNombre.ToString();
        //        txt_priApellido.Text = per.Per_priApellido.ToString();
        //        txt_segApellido.Text = per.Per_segApellido.ToString();
        //        txt_sexo.Text = per.Per_genero.ToString();
        //    }
        //}

        //private void CargarDatosModificar()
        //{
        //    try
        //    {
        //        if (Request["cod"] != null)
        //        {
        //            int codigo = Convert.ToInt32(Request["cod"]);

        //            per = CN_HistorialMedico.ObtenerPersonasxId(codigo);
        //            int perso = Convert.ToInt32(per.Per_id.ToString());

        //            datestable = CN_Retiro.obtenerDatEstEmpUsuRetiro(perso);
        //            antperetiro = CN_Retiro.obtenerAntecedentesPersonalesxPerRetiro(perso);
        //            exafisregretiro = CN_Retiro.obtenerExaFisRegxPerRetiro(perso);
        //            resexagenretiro = CN_Retiro.obtenerResExaGenEspRiesTrabaxPerRetiro(perso);
        //            diagretiro = CN_Retiro.obtenerDiagnosticoxPerRetiro(perso);
        //            evamedretiro = CN_Retiro.obtenerEvalMedicaxPerRetiro(perso);
        //            tratamientoretiro = CN_Retiro.obtenerTratamientoxPerRetiro(perso);
        //            datprofretiro = CN_Retiro.obtenerDatosProfesionalxPerRetiro(perso);

        //            btn_guardarretiro.Visible = true;

        //            if (per != null || antperetiro != null || exafisregretiro != null || resexagenretiro != null ||
        //                diagretiro != null || evamedretiro != null || tratamientoretiro != null || datprofretiro != null)
        //            {
        //                //A
        //                txt_priNombre.Text = per.Per_priNombre.ToString();
        //                txt_segNombre.Text = per.Per_segNombre.ToString();
        //                txt_priApellido.Text = per.Per_priApellido.ToString();
        //                txt_segApellido.Text = per.Per_segApellido.ToString();
        //                txt_sexo.Text = per.Per_genero.ToString();
        //                txt_numHClinica.Text = per.Per_Cedula.ToString();

        //                //A
        //                txt_fechaIniLabores.Text = datestable.datEstable__fechIniLabores.ToString();
        //                txt_fechaSalida.Text = datestable.datEstable_fechSalida.ToString();
        //                txt_tiempo.Text = datestable.datEstable_tiempo.ToString();
        //                txt_actividades1.Text = datestable.datEstable_actividades.ToString();
        //                txt_facRiesgo1.Text = datestable.datEstable_facRiesgo.ToString();

        //                //B
        //                txt_descripcionantiqui.Text = antperetiro.antPerRetiro_descripAntCliQuiru.ToString();

        //                txt_siCalificadoIESSAcciTrabajo.Text = antperetiro.antPerRetiro_siCalificadoIESSAcciTrabajo.ToString();
        //                txt_EspecifiCalificadoIESSAcciTrabajo.Text = antperetiro.antPerRetiro_EspecifiCalificadoIESSAcciTrabajo.ToString();
        //                txt_noCalificadoIESSAcciTrabajo.Text = antperetiro.antPerRetiro_noCalificadoIESSAcciTrabajo.ToString();
        //                txt_fechaCalificadoIESSAcciTrabajo.Text = antperetiro.antPerRetiro_fechaCalificadoIESSAcciTrabajo.ToString();
        //                txt_observacionesAcciTrabajo.Text = antperetiro.antPerRetiro_observacionesAcciTrabajo.ToString();
        //                txt_detalleAcciTrabajo.Text = antperetiro.antPerRetiro_detalleAcciTrabajo.ToString();

        //                txt_siCalificadoIESSEnferProfesionales.Text = antperetiro.antPerRetiro_siCalificadoIESSEnferProfesionales.ToString();
        //                txt_EspecifiCalificadoIESSEnferProfesionales.Text = antperetiro.antPerRetiro_EspecifiCalificadoIESSEnferProfesionales.ToString();
        //                txt_noCalificadoIESSEnferProfesionales.Text = antperetiro.antPerRetiro_noCalificadoIESSEnferProfesionales.ToString();
        //                txt_fechaCalificadoIESSEnferProfesionales.Text = antperetiro.antPerRetiro_fechaCalificadoIESSEnferProfesionales.ToString();
        //                txt_observacionesEnferProfesionales.Text = antperetiro.antPerRetiro_observacionesEnferProfesionales.ToString();
        //                txt_detalleEnferProfesionales.Text = antperetiro.antPerRetiro_detalleEnferProfesionales.ToString();

        //                //D
        //                txt_cicatrices.Text = exafisregretiro.exaFisRegRetiro_cicatricesPiel.ToString();
        //                txt_tatuajes.Text = exafisregretiro.exaFisRegRetiro_tatuajesPiel.ToString();
        //                txt_pielyfaneras.Text = exafisregretiro.exaFisRegRetiro_pielFacerasPiel.ToString();
        //                txt_parpados.Text = exafisregretiro.exaFisRegRetiro_parpadosOjos.ToString();
        //                txt_conjuntivas.Text = exafisregretiro.exaFisRegRetiro_conjuntuvasOjos.ToString();
        //                txt_pupilas.Text = exafisregretiro.exaFisRegRetiro_pupilasOjos.ToString();
        //                txt_cornea.Text = exafisregretiro.exaFisRegRetiro_corneaOjos.ToString();
        //                txt_motilidad.Text = exafisregretiro.exaFisRegRetiro_motilidadOjos.ToString();
        //                txt_auditivoexterno.Text = exafisregretiro.exaFisRegRetiro_cAudiExtreOido.ToString();
        //                txt_pabellon.Text = exafisregretiro.exaFisRegRetiro_pabellonOido.ToString();
        //                txt_timpanos.Text = exafisregretiro.exaFisRegRetiro_timpanosOido.ToString();
        //                txt_labios.Text = exafisregretiro.exaFisRegRetiro_labiosOroFa.ToString();
        //                txt_lengua.Text = exafisregretiro.exaFisRegRetiro_lenguaOroFa.ToString();
        //                txt_faringe.Text = exafisregretiro.exaFisRegRetiro_faringeOroFa.ToString();
        //                txt_amigdalas.Text = exafisregretiro.exaFisRegRetiro_amigdalasOroFa.ToString();
        //                txt_dentadura.Text = exafisregretiro.exaFisRegRetiro_dentaduraOroFa.ToString();
        //                txt_tabique.Text = exafisregretiro.exaFisRegRetiro_tabiqueNariz.ToString();
        //                txt_cornetes.Text = exafisregretiro.exaFisRegRetiro_cornetesNariz.ToString();
        //                txt_mucosa.Text = exafisregretiro.exaFisRegRetiro_mucosasNariz.ToString();
        //                txt_senosparanasales.Text = exafisregretiro.exaFisRegRetiro_senosParanaNariz.ToString();
        //                txt_tiroides.Text = exafisregretiro.exaFisRegRetiro_tiroiMasasCuello.ToString();
        //                txt_movilidad.Text = exafisregretiro.exaFisRegRetiro_movilidadCuello.ToString();
        //                txt_mamas.Text = exafisregretiro.exaFisRegRetiro_mamasTorax.ToString();
        //                txt_corazon.Text = exafisregretiro.exaFisRegRetiro_corazonTorax.ToString();
        //                txt_pulmones.Text = exafisregretiro.exaFisRegRetiro_pulmonesTorax2.ToString();
        //                txt_parrillacostal.Text = exafisregretiro.exaFisRegRetiro_parriCostalTorax2.ToString();
        //                txt_visceras.Text = exafisregretiro.exaFisRegRetiro_viscerasAbdomen.ToString();
        //                txt_paredabdominal.Text = exafisregretiro.exaFisRegRetiro_paredAbdomiAbdomen.ToString();
        //                txt_flexibilidad.Text = exafisregretiro.exaFisRegRetiro_flexibilidadColumna.ToString();
        //                txt_desviacion.Text = exafisregretiro.exaFisRegRetiro_desviacionColumna.ToString();
        //                txt_dolor.Text = exafisregretiro.exaFisRegRetiro_dolorColumna.ToString();
        //                txt_pelvis.Text = exafisregretiro.exaFisRegRetiro_pelvisPelvis.ToString();
        //                txt_genitales.Text = exafisregretiro.exaFisRegRetiro_genitalesPelvis.ToString();
        //                txt_vascular.Text = exafisregretiro.exaFisRegRetiro_vascularExtre.ToString();
        //                txt_miembrosuperiores.Text = exafisregretiro.exaFisRegRetiro_miemSupeExtre.ToString();
        //                txt_miembrosinferiores.Text = exafisregretiro.exaFisRegRetiro_miemInfeExtre.ToString();
        //                txt_fuerza.Text = exafisregretiro.exaFisRegRetiro_fuerzaNeuro.ToString();
        //                txt_sensibilidad.Text = exafisregretiro.exaFisRegRetiro_sensibiNeuro.ToString();
        //                txt_marcha.Text = exafisregretiro.exaFisRegRetiro_marchaNeuro.ToString();
        //                txt_reflejos.Text = exafisregretiro.exaFisRegRetiro_refleNeuro.ToString();
        //                txt_obervexamenfisicoregional.Text = exafisregretiro.exaFisRegRetiro_observa.ToString();

        //                //E
        //                txt_examen.Text = resexagenretiro.ResExaGenEspRiesTrabajoRetiro_examen.ToString();
        //                txt_fechaexamen.Text = resexagenretiro.ResExaGenEspRiesTrabajoRetiro_fecha.ToString();
        //                txt_resultadoexamen.Text = resexagenretiro.ResExaGenEspRiesTrabajoRetiro_resultados.ToString();
        //                txt_observacionexamen.Text = resexagenretiro.ResExaGenEspRiesTrabajoRetiro_observaciones.ToString();

        //                //F
        //                txt_descripdiagnostico.Text = diagretiro.DiagRetiro_descripcion.ToString();
        //                txt_cie.Text = diagretiro.DiagRetiro_cie.ToString();
        //                txt_pre.Text = diagretiro.DiagRetiro_pre.ToString();
        //                txt_def.Text = diagretiro.DiagRetiro_def.ToString();

        //                //G
        //                txt_sievamed.Text = evamedretiro.evaMedRet_si.ToString();
        //                txt_noevamed.Text = evamedretiro.evaMedRet_no.ToString();
        //                txt_obserevamed.Text = evamedretiro.evaMedRet_observaciones.ToString();

        //                //H
        //                txt_descripciontratamientoretiro.Text = tratamientoretiro.RecTraRetiro_descripcion.ToString();

        //                //I
        //                txt_fechaDatProf.Text = datprofretiro.DatProfeRetiro_fecha_hora.ToString();
        //                ddl_profesional.SelectedValue = datprofretiro.prof_id.ToString();
        //                txt_codigoDatProf.Text = datprofretiro.DatProfeRetiro_cod.ToString();

        //            }
        //            else
        //            {
        //                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Error')", true);
        //            }

        //        }
        //    }
        //    catch (Exception)
        //    {
        //        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Guardados Incompletos')", true);
        //    }
        //}

        //private void guardar_modificar_datos(int perid, int antperid, int exafiregperid, int resexgenperid, int diagperid, 
        //    int evamedperid, int traperid, int datproperid)
        //{
        //    if (perid == 0 || antperid == 0 || exafiregperid == 0 || resexgenperid == 0 || diagperid == 0 || evamedperid == 0 
        //        || traperid == 0 || datproperid == 0)
        //    {
        //        GuardarRetiro();
        //    }
        //    else
        //    {
        //        per = CN_HistorialMedico.ObtenerPersonasxId(perid);
        //        int perso = Convert.ToInt32(per.Per_id.ToString());

        //        antperetiro = CN_Retiro.obtenerAntecedentesPersonalesxPerRetiro(perso);
        //        exafisregretiro = CN_Retiro.obtenerExaFisRegxPerRetiro(perso);
        //        resexagenretiro = CN_Retiro.obtenerResExaGenEspRiesTrabaxPerRetiro(perso);
        //        diagretiro = CN_Retiro.obtenerDiagnosticoxPerRetiro(perso);
        //        evamedretiro = CN_Retiro.obtenerEvalMedicaxPerRetiro(perso);
        //        tratamientoretiro = CN_Retiro.obtenerTratamientoxPerRetiro(perso);
        //        datprofretiro = CN_Retiro.obtenerDatosProfesionalxPerRetiro(perso);

        //        if (per != null || antperetiro != null || exafisregretiro != null || resexagenretiro != null || diagretiro != null || 
        //            evamedretiro != null || tratamientoretiro != null || datprofretiro != null)
        //        {
        //            //ModificarHistorial(per, emplant, antper, acctrabajo, enferprof, facriesgotractual, actvextralaboral,
        //            //    exagenesperiespues, diagnostico, aptitudmedica);
        //        }

        //    }
        //}

        //private void GuardarRetiro()
        //{
        //    try
        //    {
        //        per = CN_HistorialMedico.ObtenerIdPersonasxCedula(Convert.ToInt32(txt_numHClinica.Text));

        //        int perso = Convert.ToInt32(per.Per_id.ToString());

        //        // A
        //        datestable = new Tbl_DatEstableEmpUsuRetiro();
        //        // B
        //        antperetiro = new Tbl_AntecedentesPersonalesRetiro();
        //        // D
        //        exafisregretiro = new Tbl_ExaFisRegionalRetiro();
        //        // E
        //        resexagenretiro = new Tbl_ResExaGenEspRiesTrabajoRetiro();
        //        // F
        //        diagretiro = new Tbl_DiagnosticoRetiro();
        //        // G
        //        evamedretiro = new Tbl_EvaluacionMedicaRetiro();
        //        // H
        //        tratamientoretiro = new Tbl_RecoTratamientoRetiro();
        //        // I
        //        datprofretiro = new Tbl_DatProfesionalRetiro();

        //        //A. Captura de datos Datos Establecimiento
        //        datestable.datEstable__fechIniLabores = Convert.ToDateTime(txt_fechaIniLabores.Text);
        //        datestable.datEstable_fechSalida = Convert.ToDateTime(txt_fechaSalida.Text);
        //        datestable.datEstable_tiempo = Convert.ToInt32(txt_tiempo.Text);
        //        datestable.datEstable_actividades = txt_actividades1.Text;
        //        datestable.datEstable_facRiesgo = txt_facRiesgo1.Text;
        //        datestable.Per_id = perso;

        //        //B. Captura de datos Antecedenetes personales
        //        antperetiro.antPerRetiro_descripAntCliQuiru = txt_descripcionantiqui.Text;

        //        antperetiro.antPerRetiro_siCalificadoIESSAcciTrabajo = txt_siCalificadoIESSAcciTrabajo.Text;
        //        antperetiro.antPerRetiro_EspecifiCalificadoIESSAcciTrabajo = txt_EspecifiCalificadoIESSAcciTrabajo.Text;
        //        antperetiro.antPerRetiro_noCalificadoIESSAcciTrabajo = txt_noCalificadoIESSAcciTrabajo.Text;
        //        antperetiro.antPerRetiro_fechaCalificadoIESSAcciTrabajo = Convert.ToDateTime(txt_fechaCalificadoIESSAcciTrabajo.Text);
        //        antperetiro.antPerRetiro_observacionesAcciTrabajo = txt_observacionesAcciTrabajo.Text;
        //        antperetiro.antPerRetiro_detalleAcciTrabajo = txt_detalleAcciTrabajo.Text;

        //        antperetiro.antPerRetiro_siCalificadoIESSEnferProfesionales = txt_siCalificadoIESSEnferProfesionales.Text;
        //        antperetiro.antPerRetiro_EspecifiCalificadoIESSEnferProfesionales = txt_EspecifiCalificadoIESSEnferProfesionales.Text;
        //        antperetiro.antPerRetiro_noCalificadoIESSEnferProfesionales = txt_noCalificadoIESSEnferProfesionales.Text;
        //        antperetiro.antPerRetiro_fechaCalificadoIESSEnferProfesionales = Convert.ToDateTime(txt_fechaCalificadoIESSEnferProfesionales.Text);
        //        antperetiro.antPerRetiro_observacionesEnferProfesionales = txt_observacionesEnferProfesionales.Text;
        //        antperetiro.antPerRetiro_detalleEnferProfesionales = txt_detalleEnferProfesionales.Text;
        //        antperetiro.Per_id = perso;

        //        //D. Captura de Datos Examen Fisico Regional
        //        exafisregretiro.exaFisRegRetiro_cicatricesPiel = txt_cicatrices.Text;
        //        exafisregretiro.exaFisRegRetiro_tatuajesPiel = txt_tatuajes.Text;
        //        exafisregretiro.exaFisRegRetiro_pielFacerasPiel = txt_pielyfaneras.Text;
        //        exafisregretiro.exaFisRegRetiro_parpadosOjos = txt_parpados.Text;
        //        exafisregretiro.exaFisRegRetiro_conjuntuvasOjos = txt_conjuntivas.Text;
        //        exafisregretiro.exaFisRegRetiro_pupilasOjos = txt_pupilas.Text;
        //        exafisregretiro.exaFisRegRetiro_corneaOjos = txt_cornea.Text;
        //        exafisregretiro.exaFisRegRetiro_motilidadOjos = txt_motilidad.Text;
        //        exafisregretiro.exaFisRegRetiro_cAudiExtreOido = txt_auditivoexterno.Text;
        //        exafisregretiro.exaFisRegRetiro_pabellonOido = txt_pabellon.Text;
        //        exafisregretiro.exaFisRegRetiro_timpanosOido = txt_timpanos.Text;
        //        exafisregretiro.exaFisRegRetiro_labiosOroFa = txt_labios.Text;
        //        exafisregretiro.exaFisRegRetiro_lenguaOroFa = txt_lengua.Text;
        //        exafisregretiro.exaFisRegRetiro_faringeOroFa = txt_faringe.Text;
        //        exafisregretiro.exaFisRegRetiro_amigdalasOroFa = txt_amigdalas.Text;
        //        exafisregretiro.exaFisRegRetiro_dentaduraOroFa = txt_dentadura.Text;
        //        exafisregretiro.exaFisRegRetiro_tabiqueNariz = txt_tabique.Text;
        //        exafisregretiro.exaFisRegRetiro_cornetesNariz = txt_cornetes.Text;
        //        exafisregretiro.exaFisRegRetiro_mucosasNariz = txt_mucosa.Text;
        //        exafisregretiro.exaFisRegRetiro_senosParanaNariz = txt_senosparanasales.Text;
        //        exafisregretiro.exaFisRegRetiro_tiroiMasasCuello = txt_tiroides.Text;
        //        exafisregretiro.exaFisRegRetiro_movilidadCuello = txt_movilidad.Text;
        //        exafisregretiro.exaFisRegRetiro_mamasTorax = txt_mamas.Text;
        //        exafisregretiro.exaFisRegRetiro_corazonTorax = txt_corazon.Text;
        //        exafisregretiro.exaFisRegRetiro_pulmonesTorax2 = txt_pulmones.Text;
        //        exafisregretiro.exaFisRegRetiro_parriCostalTorax2 = txt_parrillacostal.Text;
        //        exafisregretiro.exaFisRegRetiro_viscerasAbdomen = txt_visceras.Text;
        //        exafisregretiro.exaFisRegRetiro_paredAbdomiAbdomen = txt_paredabdominal.Text;
        //        exafisregretiro.exaFisRegRetiro_flexibilidadColumna = txt_flexibilidad.Text;
        //        exafisregretiro.exaFisRegRetiro_desviacionColumna = txt_desviacion.Text;
        //        exafisregretiro.exaFisRegRetiro_dolorColumna = txt_dolor.Text;
        //        exafisregretiro.exaFisRegRetiro_pelvisPelvis = txt_pelvis.Text;
        //        exafisregretiro.exaFisRegRetiro_genitalesPelvis = txt_genitales.Text;
        //        exafisregretiro.exaFisRegRetiro_vascularExtre = txt_vascular.Text;
        //        exafisregretiro.exaFisRegRetiro_miemSupeExtre = txt_miembrosuperiores.Text;
        //        exafisregretiro.exaFisRegRetiro_miemInfeExtre = txt_miembrosinferiores.Text;
        //        exafisregretiro.exaFisRegRetiro_fuerzaNeuro = txt_fuerza.Text;
        //        exafisregretiro.exaFisRegRetiro_sensibiNeuro = txt_sensibilidad.Text;
        //        exafisregretiro.exaFisRegRetiro_marchaNeuro = txt_marcha.Text;
        //        exafisregretiro.exaFisRegRetiro_refleNeuro = txt_reflejos.Text;
        //        exafisregretiro.exaFisRegRetiro_observa = txt_obervexamenfisicoregional.Text;
        //        exafisregretiro.Per_id = perso;

        //        //E. Captura de Datos Tbl_ResExaGenEspRiesTrabajo
        //        resexagenretiro.ResExaGenEspRiesTrabajoRetiro_examen = txt_examen.Text;
        //        resexagenretiro.ResExaGenEspRiesTrabajoRetiro_fecha = Convert.ToDateTime(txt_fechaexamen.Text);
        //        resexagenretiro.ResExaGenEspRiesTrabajoRetiro_resultados = txt_resultadoexamen.Text;
        //        resexagenretiro.ResExaGenEspRiesTrabajoRetiro_observaciones = txt_observacionexamen.Text;
        //        resexagenretiro.Per_id = perso;

        //        //F. Captura de Datos Tbl_Diagnostico
        //        diagretiro.DiagRetiro_descripcion = txt_descripdiagnostico.Text;
        //        diagretiro.DiagRetiro_cie = txt_cie.Text;
        //        diagretiro.DiagRetiro_pre = txt_pre.Text;
        //        diagretiro.DiagRetiro_def = txt_def.Text;
        //        diagretiro.Per_id = perso;

        //        //G.Captura de Datos Tbl_EvaluacionMedicaRetiro
        //        evamedretiro.evaMedRet_si = txt_sievamed.Text;
        //        evamedretiro.evaMedRet_no = txt_noevamed.Text;
        //        evamedretiro.evaMedRet_observaciones = txt_obserevamed.Text;
        //        evamedretiro.Per_id = perso;

        //        //H. Captura de Datos Recomendaciones y/o Tratamiento
        //        tratamientoretiro.RecTraRetiro_descripcion = txt_descripciontratamientoretiro.Text;
        //        tratamientoretiro.Per_id = perso;

        //        //I. Captura de Datos RProfesional
        //        datprofretiro.DatProfeRetiro_fecha_hora = Convert.ToDateTime(txt_fechaDatProf.Text);
        //        datprofretiro.prof_id = Convert.ToInt32(ddl_profesional.SelectedValue);
        //        datprofretiro.DatProfeRetiro_cod = txt_codigoDatProf.Text;
        //        datprofretiro.Per_id = perso;

        //        //A. Método para guardar Datos Establecimiento
        //        CN_Retiro.guardarDatEstEmpUsuRetiro(datestable);
        //        //B . Método para guardar Datos Antecedentes personales
        //        CN_Retiro.guardarAntPersonalesRetiro(antperetiro);
        //        //D. Método de guardar Datos Examen fisico regional
        //        CN_Retiro.guardarExamenFisicoRegionalRetiro(exafisregretiro);
        //        //E. Método de guardar Datos Resultado examenes generales
        //        CN_Retiro.guardarExaGenEspeRiesyPuesRetiro(resexagenretiro);
        //        //G. Método de guardar Datos diagnostico
        //        CN_Retiro.guardarDiagnosticoRetiro(diagretiro);
        //        //H. Método de guardar Datos evaluacion medica
        //        CN_Retiro.guardarEvaluacionMedicaRetiro(evamedretiro);
        //        //I. Método de guardar Datos recomendaciones y tratamiento
        //        CN_Retiro.guardarRecomendacionesTratamientoRetiro(tratamientoretiro);
        //        //J. Método de guardar Datos del profesional
        //        CN_Retiro.guardarDatosProfesionalRetiro(datprofretiro);


        //        //Mensaje de confirmacion
        //        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Guardados Exitosamente')", true);

        //        Response.Redirect("~/Template/Views/PacientesRetiro.aspx");
        //        limpiar();
        //    }
        //    catch (Exception)
        //    {
        //        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Guardados')", true);
        //    }

        //}

        //private void cargarProfesional()
        //{
        //    List<Tbl_Profesional> listaProf = new List<Tbl_Profesional>();
        //    listaProf = CN_HistorialMedico.ObtenerProfesional();
        //    listaProf.Insert(0, new Tbl_Profesional() { prof_NomApe = "Seleccione ........" });

        //    ddl_profesional.DataSource = listaProf;
        //    ddl_profesional.DataTextField = "prof_NomApe";
        //    ddl_profesional.DataValueField = "prof_id";
        //    ddl_profesional.DataBind();
        //}

        //private void limpiar()
        //{

        //}

        //protected void btn_guardarretiro_Click(object sender, EventArgs e)
        //{
        //    guardar_modificar_datos(Convert.ToInt32(Request["cod"]), Convert.ToInt32(per.Per_id.ToString()),
        //    Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()),
        //    Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()));
        //}

        //protected void btn_modificaretiro_Click(object sender, EventArgs e)
        //{

        //}

        //protected void btn_cancelaretiro_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("~/Template/Views/Inicio.aspx");
        //}
    }
}