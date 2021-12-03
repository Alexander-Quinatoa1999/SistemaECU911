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
	public partial class Inicial : System.Web.UI.Page
	{

		DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        //Objeto de la tabla personas
        private Tbl_Personas per = new Tbl_Personas();

        //A. Objeto de la tabla DATOS DEL ESTABLECIMIENTO - EMPRESA Y USUARIO (DESDE RELIGION)
        private Tbl_DatEstableEmpUsu datosestempresausu = new Tbl_DatEstableEmpUsu();

        //B. Objeto de la tabla MOTIVO CONSULTA
        private Tbl_MotivoConsultaInicial motconini = new Tbl_MotivoConsultaInicial();
        
        //C. Objeto de la tabla NTECEDENTES PERSONALES
        private Tbl_AntecedentesCliQuiru antcliqui = new Tbl_AntecedentesCliQuiru();
        
        //D. Objeto de la tabla ANTECEDENTES DE EMPLEOS ANTERIORES
        private Tbl_AntecedentesEmplAnteriores emplant = new Tbl_AntecedentesEmplAnteriores();

        //Objeto de la tabla ACCIDENTES DE TRABAJO (DESCRIPCIÓN)
        private Tbl_AccidentesTrabajoDesc acctrabajo = new Tbl_AccidentesTrabajoDesc();

        //Objeto de la tabla ENFERMEDADES PROFESIONALES 
        private Tbl_EnfermedadesProfesionales enferprof = new Tbl_EnfermedadesProfesionales();
        
        //E. Objeto de la tabla ANTECEDENTES FAMILIARES
        private Tbl_AntecedentesFamiliaresDetParentesco AnteFamiDetParentesco = new Tbl_AntecedentesFamiliaresDetParentesco();
        
        //F. Objeto de la tabla RIESGO DEL PUESTO DE TRABAJO ACTUAL
        private Tbl_FacRiesTrabAct facriesgotractual = new Tbl_FacRiesTrabAct();
        
        //G. Objeto de la tabla ACTIVIDADES EXTRA LABORALES
        private Tbl_ActividadesExtraLaborales actvextralaboral = new Tbl_ActividadesExtraLaborales();
        
        //H. Objeto de la tabla ENFERMEDAD ACTUAL
        private Tbl_EnfermedadActualInicial enferactualinicial = new Tbl_EnfermedadActualInicial();
        
        //I. Objeto de la tabla REVISIÓN ACTUAL DE ÓRGANOS Y SISTEMAS
        private Tbl_RevisionActualOrganosSistemas revisionactualorganossistemas = new Tbl_RevisionActualOrganosSistemas();
        
        //K. Objeto de la tabla EXAMEN FÍSICO REGIONAL
        private Tbl_ExaFisRegionalInicial examfisregional = new Tbl_ExaFisRegionalInicial();
        
        //L. Objeto de la tabla RESULTADO DE EXAMENES GENERALES Y ESPECIFICOS DE ACUERDO AL RIESGO Y PUESTO DE TRABAJO
        private Tbl_ResExaGenEspRiesTrabajo exagenesperiespues = new Tbl_ResExaGenEspRiesTrabajo();
        
        //M. Objeto de la tabla DIAGNÓSTICO
        private Tbl_Diagnostico diagnostico = new Tbl_Diagnostico();
        
        //N. Objeto de la tabla APTITUD MÉDICA PARA EL TRABAJO
        private Tbl_AptitudMedica aptitudmedica = new Tbl_AptitudMedica();
        
        //O. Objeto de la tabla RECOMENDACIONES Y/O TRATAMIENTO
        private Tbl_TratamientoInicial tratamientoinicial = new Tbl_TratamientoInicial();

        protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                CargarDatosModificar();
            }
		}

        private void CargarDatosModificar()
        {
            if (Request["cod"] != null)
            {
                int codigo = Convert.ToInt32(Request["cod"]);

                per = CN_HistorialMedico.obtenerPersonasxId(codigo);
                int perso = Convert.ToInt32(per.Per_id.ToString());

                datosestempresausu = new Tbl_DatEstableEmpUsu();
                motconini = new Tbl_MotivoConsultaInicial();
                emplant = new Tbl_AntecedentesEmplAnteriores();
                acctrabajo = new Tbl_AccidentesTrabajoDesc();
                enferprof = new Tbl_EnfermedadesProfesionales();
                AnteFamiDetParentesco = new Tbl_AntecedentesFamiliaresDetParentesco();
                facriesgotractual = new Tbl_FacRiesTrabAct();
                actvextralaboral = new Tbl_ActividadesExtraLaborales();
                enferactualinicial = new Tbl_EnfermedadActualInicial();
                revisionactualorganossistemas = new Tbl_RevisionActualOrganosSistemas();
                examfisregional = new Tbl_ExaFisRegionalInicial();
                exagenesperiespues = new Tbl_ResExaGenEspRiesTrabajo();
                diagnostico = new Tbl_Diagnostico();
                aptitudmedica = new Tbl_AptitudMedica();
                tratamientoinicial = new Tbl_TratamientoInicial();

                datosestempresausu = CN_Inicial.obtenerDatEstEmpreUsuar(perso);
                motconini = CN_Inicial.obtenerMotivoConsultaInicial(perso);
                emplant = CN_Inicial.obtenerEmpAntexPer(perso);
                acctrabajo = CN_Inicial.obtenerAcciTraDescxPer(perso);
                enferprof = CN_Inicial.obtenerEnfProfxPer(perso);
                AnteFamiDetParentesco = CN_Inicial.obtenerAntFamDetPar(perso);
                facriesgotractual = CN_Inicial.obtenerFacRiesTrabActxPer(perso);
                actvextralaboral = CN_Inicial.obtenerActiExtraLabxPer(perso);
                enferactualinicial = CN_Inicial.obtenerEnferActInixPer(perso);
                revisionactualorganossistemas = CN_Inicial.obtenerRevActOrgSisxPer(perso);
                examfisregional = CN_Inicial.obtenerExaFisRegPer(perso);
                exagenesperiespues = CN_Inicial.obtenerResExaGenEspRiesTrabaxPer(perso);
                diagnostico = CN_Inicial.obtenerDiagnosticoxPer(perso);
                aptitudmedica = CN_Inicial.obtenerAptMedicaxPer(perso);
                tratamientoinicial = CN_Inicial.obtenerTratamientoInixPer(perso);

                btn_guardar.Visible = true;

                if (per != null || datosestempresausu != null || motconini != null || emplant != null || acctrabajo != null || 
                    enferprof != null || AnteFamiDetParentesco != null || facriesgotractual != null || actvextralaboral != null ||
                    enferactualinicial != null || revisionactualorganossistemas != null || examfisregional != null || 
                    exagenesperiespues != null || diagnostico != null || aptitudmedica != null || tratamientoinicial != null)
                {
                    //A
                    txt_priApellido.Text = per.Per_priApellido.ToString();
                    txt_segApellido.Text = per.Per_segApellido.ToString();
                    txt_priNombre.Text = per.Per_priNombre.ToString();
                    txt_segNombre.Text = per.Per_segNombre.ToString();
                    txt_numHClinica.Text = per.Per_Cedula.ToString();
                    txt_sexo.Text = per.Per_genero.ToString();
                    //Falta la edad
                    txt_catolica.Text = datosestempresausu.datEstable_catolicaRel.ToString();
                    txt_evangelica.Text = datosestempresausu.datEstable_evangelicaRel.ToString();
                    txt_testigo.Text = datosestempresausu.datEstable_testJehovaRel.ToString();
                    txt_mormona.Text = datosestempresausu.datEstable_mormonaRel.ToString();
                    txt_otrareligion.Text = datosestempresausu.datEstable_otrasRel.ToString();
                    txt_gruposanguineo.Text = datosestempresausu.datEstable_groSanguineo.ToString();
                    txt_lateralidad.Text = datosestempresausu.datEstable_lateralidad.ToString();
                    txt_gay.Text = datosestempresausu.datEstable_gayOriSex.ToString();
                    txt_bisexual.Text = datosestempresausu.datEstable_bisexualOriSex.ToString();
                    txt_heterosexual.Text = datosestempresausu.datEstable_heterosexualOriSex.ToString();
                    txt_noRespondeOriSex.Text = datosestempresausu.datEstable_norespondeOriSex.ToString();
                    txt_femenino.Text = datosestempresausu.datEstable_femeninoIdenGen.ToString();
                    txt_masculino.Text = datosestempresausu.datEstable_masculinoIdenGen.ToString();
                    txt_transfemenino.Text = datosestempresausu.datEstable_transFemeninoIdenGen.ToString();
                    txt_transmasculino.Text = datosestempresausu.datEstable_transMasculinoIdenGen.ToString();
                    txt_noRespondeIdeGen.Text = datosestempresausu.datEstable_norespondeIdenGen.ToString();
                    txt_sidiscapacidad.Text = datosestempresausu.datEstable_siDis.ToString();
                    txt_nodiscapacidad.Text = datosestempresausu.datEstable_noDis.ToString();
                    txt_tipodiscapacidad.Text = datosestempresausu.datEstable_tipoDis.ToString();
                    txt_porcentajediscapacidad.Text = datosestempresausu.datEstable_porcentDis.ToString();
                    txt_actividadesrelevantes.Text = datosestempresausu.datEstable_actRelevantesTrabOcupar.ToString();

                    //B
                    txt_motivoconsultainicial.Text = motconini.motConIni_descrip.ToString();

                    //D
                    txt_empresa.Text = emplant.AntEmpAnte_nomEmpresa.ToString();
                    txt_puestotrabajo.Text = emplant.AntEmpAnte_puestoTrabajo.ToString();
                    txt_actdesempeña.Text = emplant.AntEmpAnte_actDesemp.ToString();
                    txt_tiempotrabajo.Text = emplant.AntEmpAnte_tiemTrabajo.ToString();
                    txt_fisico.Text = emplant.AntEmpAnte_nomEmpresa.ToString();
                    txt_mecanico.Text = emplant.AntEmpAnte_nomEmpresa.ToString();
                    txt_quimico.Text = emplant.AntEmpAnte_nomEmpresa.ToString();
                    txt_biologico.Text = emplant.AntEmpAnte_nomEmpresa.ToString();
                    txt_ergonomico.Text = emplant.AntEmpAnte_nomEmpresa.ToString();
                    txt_psicosocial.Text = emplant.AntEmpAnte_nomEmpresa.ToString();
                    txt_observaciones1.Text = emplant.AntEmpAnte_nomEmpresa.ToString();

                    //E
                    txt_enfermedadcardiovascular.Text = AnteFamiDetParentesco.AntFamDetPare_enfCarVas.ToString();
                    txt_enfermedadmetabolica.Text = AnteFamiDetParentesco.AntFamDetPare_enfMeta.ToString();
                    txt_enfermedadneurologica.Text = AnteFamiDetParentesco.AntFamDetPare_enfNeuro.ToString();
                    txt_enfermedadoncologica.Text = AnteFamiDetParentesco.AntFamDetPare_enfOnco.ToString();
                    txt_enfermedadinfecciosa.Text = AnteFamiDetParentesco.AntFamDetPare_enfInfe.ToString();
                    txt_enfermedadhereditaria.Text = AnteFamiDetParentesco.AntFamDetPare_enfHereConge.ToString();
                    txt_discapacidades.Text = AnteFamiDetParentesco.AntFamDetPare_discapa.ToString();
                    txt_otrosenfer.Text = AnteFamiDetParentesco.AntFamDetPare_otros.ToString();
                    txt_descripcionantefamiliares.Text = AnteFamiDetParentesco.AntFamDetPare_descripcion.ToString();

                    //F
                    txt_puestodetrabajo.Text = facriesgotractual.FacRiesTrabAct_area.ToString();
                    txt_act.Text = facriesgotractual.FacRiesTrabAct_actividades.ToString();
                    txt_tempaltas.Text = facriesgotractual.FacRiesTrabAct_temAltasFis.ToString();
                    txt_atrapmaquinas.Text = facriesgotractual.FacRiesTrabAct_atraMaquinasMec.ToString();
                    txt_solidos.Text = facriesgotractual.FacRiesTrabAct_solidosQui.ToString();
                    txt_virus.Text = facriesgotractual.FacRiesTrabAct_virusBio.ToString();
                    txt_manmanualcargas.Text = facriesgotractual.FacRiesTrabAct_maneManCarErg.ToString();
                    txt_montrabajo.Text = facriesgotractual.FacRiesTrabAct_monoTrabPsi.ToString();
                    txt_medpreventivas.Text = facriesgotractual.FacRiesTrabAct_medPreventivas.ToString();

                    //G
                    txt_descrextralaborales.Text = actvextralaboral.ActExtLab_descrip.ToString();

                    //H
                    txt_enfermedadactualinicial.Text = enferactualinicial.enfActual_descrip.ToString();

                    //I
                    txt_pielanexos.Text = revisionactualorganossistemas.RevActOrgSis_pielAnexos.ToString();
                    txt_organossentidos.Text = revisionactualorganossistemas.RevActOrgSis_orgSentidos.ToString();
                    txt_respiratorio.Text = revisionactualorganossistemas.RevActOrgSis_respiratorio.ToString();
                    txt_cardiovascular.Text = revisionactualorganossistemas.RevActOrgSis_cardVascular.ToString();
                    txt_digestivo.Text = revisionactualorganossistemas.RevActOrgSis_digestivo.ToString();
                    txt_genitourinario.Text = revisionactualorganossistemas.RevActOrgSis_genUrinario.ToString();
                    txt_musculosesqueleticos.Text = revisionactualorganossistemas.RevActOrgSis_muscEsqueletico.ToString();
                    txt_musculosesqueleticos.Text = revisionactualorganossistemas.RevActOrgSis_endocrino.ToString();
                    txt_hemolinfatico.Text = revisionactualorganossistemas.RevActOrgSis_hemoLimfa.ToString();
                    txt_nervioso.Text = revisionactualorganossistemas.RevActOrgSis_nervioso.ToString();
                    txt_descrorganosysistemas.Text = revisionactualorganossistemas.RevActOrgSis_descrip.ToString();

                    //K
                    txt_cicatrices.Text = examfisregional.exaFisRegInicial_cicatricesPiel.ToString();
                    txt_tatuajes.Text = examfisregional.exaFisRegInicial_tatuajesPiel.ToString();
                    txt_pielyfaneras.Text = examfisregional.exaFisRegInicial_pielFacerasPiel.ToString();
                    txt_parpados.Text = examfisregional.exaFisRegInicial_parpadosOjos.ToString();
                    txt_conjuntivas.Text = examfisregional.exaFisRegInicial_conjuntuvasOjos.ToString();
                    txt_pupilas.Text = examfisregional.exaFisRegInicial_pupilasOjos.ToString();
                    txt_cornea.Text = examfisregional.exaFisRegInicial_corneaOjos.ToString();
                    txt_motilidad.Text = examfisregional.exaFisRegInicial_motilidadOjos.ToString();
                    txt_auditivoexterno.Text = examfisregional.exaFisRegInicial_cAudiExtreOido.ToString();
                    txt_pabellon.Text = examfisregional.exaFisRegInicial_pabellonOido.ToString();
                    txt_timpanos.Text = examfisregional.exaFisRegInicial_timpanosOido.ToString();
                    txt_labios.Text = examfisregional.exaFisRegInicial_labiosOroFa.ToString();
                    txt_lengua.Text = examfisregional.exaFisRegInicial_lenguaOroFa.ToString();
                    txt_faringe.Text = examfisregional.exaFisRegInicial_faringeOroFa.ToString();
                    txt_amigdalas.Text = examfisregional.exaFisRegInicial_amigdalasOroFa.ToString();
                    txt_dentadura.Text = examfisregional.exaFisRegInicial_dentaduraOroFa.ToString();
                    txt_tabique.Text = examfisregional.exaFisRegInicial_tabiqueNariz.ToString();
                    txt_cornetes.Text = examfisregional.exaFisRegInicial_cornetesNariz.ToString();
                    txt_mucosa.Text = examfisregional.exaFisRegInicial_mucosasNariz.ToString();
                    txt_senosparanasales.Text = examfisregional.exaFisRegInicial_senosParanaNariz.ToString();
                    txt_tiroides.Text = examfisregional.exaFisRegInicial_tiroiMasasCuello.ToString();
                    txt_movilidad.Text = examfisregional.exaFisRegInicial_movilidadCuello.ToString();
                    txt_mamas.Text = examfisregional.exaFisRegInicial_mamasTorax.ToString();
                    txt_corazon.Text = examfisregional.exaFisRegInicial_corazonTorax.ToString();
                    txt_pulmones.Text = examfisregional.exaFisRegInicial_pulmonesTorax2.ToString();
                    txt_parrillacostal.Text = examfisregional.exaFisRegInicial_parriCostalTorax2.ToString();
                    txt_visceras.Text = examfisregional.exaFisRegInicial_viscerasAbdomen.ToString();
                    txt_paredabdominal.Text = examfisregional.exaFisRegInicial_paredAbdomiAbdomen.ToString();
                    txt_flexibilidad.Text = examfisregional.exaFisRegInicial_flexibilidadColumna.ToString();
                    txt_desviacion.Text = examfisregional.exaFisRegInicial_desviacionColumna.ToString();
                    txt_dolor.Text = examfisregional.exaFisRegInicial_dolorColumna.ToString();
                    txt_pelvis.Text = examfisregional.exaFisRegInicial_pelvisPelvis.ToString();
                    txt_genitales.Text = examfisregional.exaFisRegInicial_genitalesPelvis.ToString();
                    txt_vascular.Text = examfisregional.exaFisRegInicial_vascularExtre.ToString();
                    txt_miembrosuperiores.Text = examfisregional.exaFisRegInicial_miemSupeExtre.ToString();
                    txt_miembrosinferiores.Text= examfisregional.exaFisRegInicial_miemInfeExtre.ToString();
                    txt_fuerza.Text = examfisregional.exaFisRegInicial_fuerzaNeuro.ToString();
                    txt_sensibilidad.Text = examfisregional.exaFisRegInicial_sensibiNeuro.ToString();
                    txt_marcha.Text = examfisregional.exaFisRegInicial_marchaNeuro.ToString();
                    txt_reflejos.Text = examfisregional.exaFisRegInicial_refleNeuro.ToString();
                    txt_obervexamenfisicoregional.Text = examfisregional.exaFisRegInicial_observa.ToString();

                    //L
                    txt_examen.Text = exagenesperiespues.ResExaGenEspRiesTrabajo_examen.ToString();
                    txt_fechaexamen.Text = exagenesperiespues.ResExaGenEspRiesTrabajo_fecha.ToString();
                    txt_resultadoexamen.Text = exagenesperiespues.ResExaGenEspRiesTrabajo_resultados.ToString();
                    txt_observacionexamen.Text = exagenesperiespues.ResExaGenEspRiesTrabajo_observaciones.ToString();

                    //M
                    txt_descripdiagnostico.Text = diagnostico.Diag_descripcion.ToString();
                    txt_pre.Text = diagnostico.Diag_pre.ToString();
                    txt_def.Text = diagnostico.Diag_def.ToString();

                    //N
                    txt_apto.Text = aptitudmedica.AptMed_apto.ToString();
                    txt_observacionaptitud.Text = aptitudmedica.AptMed_Observ.ToString();
                    txt_limitacionaptitud.Text = aptitudmedica.AptMed_Limit.ToString();

                    //O
                    txt_descripciontratamiento.Text = tratamientoinicial.trataInicial_descrip.ToString();
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Error')", true);
                }
            }
        }

        private void guardar_modificar_datos(int perid, int datosestempresausuid, int motconiniid, int antcliquiid, int emplanteid, 
            int accitrabid, int enfprofid, int AnteFamiDetParid, int facriestrabid, int actextralabid, int enferactualiniid,
            int revactrgsisid, int resexagenid, int exagenesperiespuesid, int diagid, int aptmedid, int traIniid)
        {
            if (perid == 0 || datosestempresausuid == 0 || motconiniid == 0 || antcliquiid == 0 || emplanteid == 0 || 
                accitrabid == 0 || enfprofid == 0 || AnteFamiDetParid == 0 || facriestrabid == 0 || actextralabid == 0 ||
                enferactualiniid == 0 || revactrgsisid == 0 || resexagenid == 0 || exagenesperiespuesid == 0 || diagid == 0 || 
                aptmedid == 0 || traIniid == 0)
            {
                GuardarHistorial();
            }
            else
            {

                per = CN_HistorialMedico.obtenerPersonasxId(perid);
                int perso = Convert.ToInt32(per.Per_id.ToString());

                emplant = CN_Inicial.obtenerEmpAntexPer(perso);
                acctrabajo = CN_Inicial.obtenerAcciTraDescxPer(perso);
                enferprof = CN_Inicial.obtenerEnfProfxPer(perso);
                facriesgotractual = CN_Inicial.obtenerFacRiesTrabActxPer(perso);
                actvextralaboral = CN_Inicial.obtenerActiExtraLabxPer(perso);
                exagenesperiespues = CN_Inicial.obtenerResExaGenEspRiesTrabaxPer(perso);
                diagnostico = CN_Inicial.obtenerDiagnosticoxPer(perso);
                aptitudmedica = CN_Inicial.obtenerAptMedicaxPer(perso);                

                if (per != null || emplant != null || acctrabajo != null || enferprof != null || facriesgotractual != null || 
                    actvextralaboral != null || exagenesperiespues != null || diagnostico != null || aptitudmedica != null)
                {
                    ModificarHistorial(per, emplant, antcliqui, acctrabajo, enferprof, facriesgotractual, actvextralaboral,
                        exagenesperiespues, diagnostico, aptitudmedica);
                }

            }
        }               

        private void GuardarHistorial()
        {
            try
            {
                //Guardar Persona D - F - G - L - M - N
                if (string.IsNullOrEmpty(txt_catolica.Text)) 
                //   || string.IsNullOrEmpty(txt_puestotrabajo.Text) || string.IsNullOrEmpty(txt_actdesempeña.Text) ||
                //    string.IsNullOrEmpty(txt_tiempotrabajo.Text) || string.IsNullOrEmpty(txt_fisico.Text) || string.IsNullOrEmpty(txt_mecanico.Text) || 
                //    string.IsNullOrEmpty(txt_quimico.Text) || string.IsNullOrEmpty(txt_biologico.Text) || string.IsNullOrEmpty(txt_ergonomico.Text) ||
                //    string.IsNullOrEmpty(txt_psicosocial.Text) || string.IsNullOrEmpty(txt_observaciones1.Text) || 

                //    /*string.IsNullOrEmpty(txt_si.Text) || string.IsNullOrEmpty(txt_especificar.Text) || string.IsNullOrEmpty(txt_no.Text) || 
                //    string.IsNullOrEmpty(txt_fecha.Text) || string.IsNullOrEmpty(txt_observaciones2.Text) || 

                //    string.IsNullOrEmpty(txt_siprofesional.Text) || string.IsNullOrEmpty(txt_espeprofesional.Text) || string.IsNullOrEmpty(txt_noprofesional.Text) || 
                //    string.IsNullOrEmpty(txt_fechaprofesional.Text) || string.IsNullOrEmpty(txt_observaciones3.Text) ||*/

                //    string.IsNullOrEmpty(txt_puestodetrabajo.Text) || string.IsNullOrEmpty(txt_act.Text) || string.IsNullOrEmpty(txt_tempaltas.Text) ||
                //    string.IsNullOrEmpty(txt_atrapmaquinas.Text) || string.IsNullOrEmpty(txt_solidos.Text) ||

                //    string.IsNullOrEmpty(txt_puestodetrabajo2.Text) || string.IsNullOrEmpty(txt_act2.Text) || string.IsNullOrEmpty(txt_virus.Text) ||
                //    string.IsNullOrEmpty(txt_manmanualcargas.Text) || string.IsNullOrEmpty(txt_montrabajo.Text) || string.IsNullOrEmpty(txt_medpreventivas.Text) ||

                //    string.IsNullOrEmpty(txt_descrextralaborales.Text) ||

                //    string.IsNullOrEmpty(txt_examen.Text) || string.IsNullOrEmpty(txt_fechaexamen.Text) || string.IsNullOrEmpty(txt_resultadoexamen.Text) ||
                //    string.IsNullOrEmpty(txt_observacionexamen.Text) ||

                //    string.IsNullOrEmpty(txt_descripdiagnostico.Text) ||  string.IsNullOrEmpty(txt_pre.Text) || string.IsNullOrEmpty(txt_def.Text) ||

                //    string.IsNullOrEmpty(txt_apto.Text) || string.IsNullOrEmpty(txt_observacionaptitud.Text) || string.IsNullOrEmpty(txt_limitacionaptitud.Text))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Complete los campos')", true);
                }
                else
                {

                    per = CN_HistorialMedico.obtenerIdPersonasxCedula(Convert.ToInt32(txt_numHClinica.Text));

                    int perso = Convert.ToInt32(per.Per_id.ToString());                    

                    // A
                    datosestempresausu = new Tbl_DatEstableEmpUsu();
                    // B
                    motconini = new Tbl_MotivoConsultaInicial();
                    // C
                    antcliqui = new Tbl_AntecedentesCliQuiru();
                    // D
                    emplant = new Tbl_AntecedentesEmplAnteriores();
                    acctrabajo = new Tbl_AccidentesTrabajoDesc();
                    enferprof = new Tbl_EnfermedadesProfesionales();
                    // E
                    AnteFamiDetParentesco = new Tbl_AntecedentesFamiliaresDetParentesco();
                    // F
                    facriesgotractual = new Tbl_FacRiesTrabAct();
                    // G
                    actvextralaboral = new Tbl_ActividadesExtraLaborales();
                    // H
                    enferactualinicial = new Tbl_EnfermedadActualInicial();
                    // I
                    revisionactualorganossistemas = new Tbl_RevisionActualOrganosSistemas();
                    // K
                    examfisregional = new Tbl_ExaFisRegionalInicial();
                    // L
                    exagenesperiespues = new Tbl_ResExaGenEspRiesTrabajo();
                    // M
                    diagnostico = new Tbl_Diagnostico();
                    // N
                    aptitudmedica = new Tbl_AptitudMedica();
                    // O
                    tratamientoinicial = new Tbl_TratamientoInicial();

                    //A. Captura de Datos Establecimiento Empresa Usuario
                    datosestempresausu.datEstable_catolicaRel = txt_catolica.Text;
                    datosestempresausu.datEstable_evangelicaRel = txt_evangelica.Text;
                    datosestempresausu.datEstable_testJehovaRel = txt_testigo.Text;
                    datosestempresausu.datEstable_mormonaRel = txt_mormona.Text;
                    datosestempresausu.datEstable_otrasRel = txt_otrareligion.Text;
                    datosestempresausu.datEstable_groSanguineo = txt_gruposanguineo.Text;
                    datosestempresausu.datEstable_lateralidad = txt_lateralidad.Text;
                    datosestempresausu.datEstable_gayOriSex = txt_gay.Text;
                    datosestempresausu.datEstable_bisexualOriSex = txt_bisexual.Text;
                    datosestempresausu.datEstable_heterosexualOriSex = txt_heterosexual.Text;
                    datosestempresausu.datEstable_norespondeOriSex = txt_noRespondeOriSex.Text;
                    datosestempresausu.datEstable_femeninoIdenGen = txt_femenino.Text;
                    datosestempresausu.datEstable_masculinoIdenGen = txt_masculino.Text;
                    datosestempresausu.datEstable_transFemeninoIdenGen = txt_transfemenino.Text;
                    datosestempresausu.datEstable_transMasculinoIdenGen = txt_transmasculino.Text;
                    datosestempresausu.datEstable_norespondeIdenGen = txt_noRespondeIdeGen.Text;
                    datosestempresausu.datEstable_siDis = txt_sidiscapacidad.Text;
                    datosestempresausu.datEstable_noDis = txt_nodiscapacidad.Text;
                    datosestempresausu.datEstable_tipoDis = txt_tipodiscapacidad.Text;
                    datosestempresausu.datEstable_porcentDis = Convert.ToInt32(txt_porcentajediscapacidad.Text);
                    datosestempresausu.datEstable_actRelevantesTrabOcupar = txt_actividadesrelevantes.Text;
                    datosestempresausu.Per_id = perso;

                    // B. Captura de datos Motivo de Consulta
                    motconini.motConIni_descrip = txt_motivoconsultainicial.Text;
                    motconini.Per_id = perso;

                    //C. Captura de datos tbl_AntecedentesCliQuiru(
                    //antcliqui.AntCliQuiru_descripcion = txt_antCliQuiDescripcion.Text;

                    //D. Captura de Datos Tbl_AntecedentesEmplAnteriores 
                    emplant.AntEmpAnte_nomEmpresa = txt_empresa.Text;
                    emplant.AntEmpAnte_puestoTrabajo = txt_puestotrabajo.Text;
                    emplant.AntEmpAnte_actDesemp = txt_actdesempeña.Text;
                    emplant.AntEmpAnte_tiemTrabajo = Convert.ToInt32(txt_tiempotrabajo.Text);
                    emplant.AntEmpAnte_nomEmpresa = txt_fisico.Text;
                    emplant.AntEmpAnte_nomEmpresa = txt_mecanico.Text;
                    emplant.AntEmpAnte_nomEmpresa = txt_quimico.Text;
                    emplant.AntEmpAnte_nomEmpresa = txt_biologico.Text;
                    emplant.AntEmpAnte_nomEmpresa = txt_ergonomico.Text;
                    emplant.AntEmpAnte_nomEmpresa = txt_psicosocial.Text;
                    emplant.AntEmpAnte_nomEmpresa = txt_observaciones1.Text;
                    emplant.Per_id = perso;

                    //E. Captura de Datos ANTECEDENTES FAMILIARES (DETALLAR EL PARENTESCO)
                    AnteFamiDetParentesco.AntFamDetPare_enfCarVas = txt_enfermedadcardiovascular.Text;
                    AnteFamiDetParentesco.AntFamDetPare_enfMeta = txt_enfermedadmetabolica.Text;
                    AnteFamiDetParentesco.AntFamDetPare_enfNeuro = txt_enfermedadneurologica.Text;
                    AnteFamiDetParentesco.AntFamDetPare_enfOnco = txt_enfermedadoncologica.Text;
                    AnteFamiDetParentesco.AntFamDetPare_enfInfe = txt_enfermedadinfecciosa.Text;
                    AnteFamiDetParentesco.AntFamDetPare_enfHereConge = txt_enfermedadhereditaria.Text;
                    AnteFamiDetParentesco.AntFamDetPare_discapa = txt_discapacidades.Text;
                    AnteFamiDetParentesco.AntFamDetPare_otros = txt_otrosenfer.Text;
                    AnteFamiDetParentesco.AntFamDetPare_descripcion = txt_descripcionantefamiliares.Text;
                    AnteFamiDetParentesco.Per_id = perso;

                    //F. Captura de Datos Tbl_FacRiesTrabAct
                    facriesgotractual.FacRiesTrabAct_area = txt_puestodetrabajo.Text;
                    facriesgotractual.FacRiesTrabAct_actividades = txt_act.Text;
                    facriesgotractual.FacRiesTrabAct_temAltasFis = txt_tempaltas.Text;
                    facriesgotractual.FacRiesTrabAct_atraMaquinasMec = txt_atrapmaquinas.Text;
                    facriesgotractual.FacRiesTrabAct_solidosQui = txt_solidos.Text;
                    facriesgotractual.FacRiesTrabAct_virusBio = txt_virus.Text;
                    facriesgotractual.FacRiesTrabAct_maneManCarErg = txt_manmanualcargas.Text;
                    facriesgotractual.FacRiesTrabAct_monoTrabPsi = txt_montrabajo.Text;
                    facriesgotractual.FacRiesTrabAct_medPreventivas = txt_medpreventivas.Text;
                    facriesgotractual.Per_id = perso;

                    //G. Captura de Datos Tbl_ActividadesExtraLaborales
                    actvextralaboral.ActExtLab_descrip = txt_descrextralaborales.Text;
                    actvextralaboral.Per_id = perso;

                    //H. Captura de Datos Enfermedad Actual
                    enferactualinicial.enfActual_descrip = txt_enfermedadactualinicial.Text;
                    enferactualinicial.Per_id = perso;

                    //I. Captura de Datos REVISIÓN ACTUAL DE ÓRGANOS Y SISTEMAS
                    revisionactualorganossistemas.RevActOrgSis_pielAnexos = txt_pielanexos.Text;
                    revisionactualorganossistemas.RevActOrgSis_orgSentidos = txt_organossentidos.Text;
                    revisionactualorganossistemas.RevActOrgSis_respiratorio = txt_respiratorio.Text;
                    revisionactualorganossistemas.RevActOrgSis_cardVascular = txt_cardiovascular.Text;
                    revisionactualorganossistemas.RevActOrgSis_digestivo = txt_digestivo.Text;
                    revisionactualorganossistemas.RevActOrgSis_genUrinario = txt_genitourinario.Text;
                    revisionactualorganossistemas.RevActOrgSis_muscEsqueletico = txt_musculosesqueleticos.Text;
                    revisionactualorganossistemas.RevActOrgSis_endocrino = txt_musculosesqueleticos.Text;
                    revisionactualorganossistemas.RevActOrgSis_hemoLimfa = txt_hemolinfatico.Text;
                    revisionactualorganossistemas.RevActOrgSis_nervioso = txt_nervioso.Text;
                    revisionactualorganossistemas.RevActOrgSis_descrip = txt_descrorganosysistemas.Text;
                    revisionactualorganossistemas.Per_id = perso;

                    //K. Captura de Datos Examen Fisico Regional
                    examfisregional.exaFisRegInicial_cicatricesPiel = txt_cicatrices.Text;
                    examfisregional.exaFisRegInicial_tatuajesPiel = txt_tatuajes.Text;
                    examfisregional.exaFisRegInicial_pielFacerasPiel = txt_pielyfaneras.Text;
                    examfisregional.exaFisRegInicial_parpadosOjos = txt_parpados.Text;
                    examfisregional.exaFisRegInicial_conjuntuvasOjos = txt_conjuntivas.Text;
                    examfisregional.exaFisRegInicial_pupilasOjos = txt_pupilas.Text;
                    examfisregional.exaFisRegInicial_corneaOjos = txt_cornea.Text;
                    examfisregional.exaFisRegInicial_motilidadOjos = txt_motilidad.Text;
                    examfisregional.exaFisRegInicial_cAudiExtreOido = txt_auditivoexterno.Text;
                    examfisregional.exaFisRegInicial_pabellonOido = txt_pabellon.Text;
                    examfisregional.exaFisRegInicial_timpanosOido = txt_timpanos.Text;
                    examfisregional.exaFisRegInicial_labiosOroFa = txt_labios.Text;
                    examfisregional.exaFisRegInicial_lenguaOroFa = txt_lengua.Text;
                    examfisregional.exaFisRegInicial_faringeOroFa = txt_faringe.Text;
                    examfisregional.exaFisRegInicial_amigdalasOroFa = txt_amigdalas.Text;
                    examfisregional.exaFisRegInicial_dentaduraOroFa = txt_dentadura.Text;
                    examfisregional.exaFisRegInicial_tabiqueNariz = txt_tabique.Text;
                    examfisregional.exaFisRegInicial_cornetesNariz = txt_cornetes.Text;
                    examfisregional.exaFisRegInicial_mucosasNariz = txt_mucosa.Text;
                    examfisregional.exaFisRegInicial_senosParanaNariz = txt_senosparanasales.Text;
                    examfisregional.exaFisRegInicial_tiroiMasasCuello = txt_tiroides.Text;
                    examfisregional.exaFisRegInicial_movilidadCuello = txt_movilidad.Text;
                    examfisregional.exaFisRegInicial_mamasTorax = txt_mamas.Text;
                    examfisregional.exaFisRegInicial_corazonTorax = txt_corazon.Text;
                    examfisregional.exaFisRegInicial_pulmonesTorax2 = txt_pulmones.Text;
                    examfisregional.exaFisRegInicial_parriCostalTorax2 = txt_parrillacostal.Text;
                    examfisregional.exaFisRegInicial_viscerasAbdomen = txt_visceras.Text;
                    examfisregional.exaFisRegInicial_paredAbdomiAbdomen = txt_paredabdominal.Text;
                    examfisregional.exaFisRegInicial_flexibilidadColumna = txt_flexibilidad.Text;
                    examfisregional.exaFisRegInicial_desviacionColumna = txt_desviacion.Text;
                    examfisregional.exaFisRegInicial_dolorColumna = txt_dolor.Text;
                    examfisregional.exaFisRegInicial_pelvisPelvis = txt_pelvis.Text;
                    examfisregional.exaFisRegInicial_genitalesPelvis = txt_genitales.Text;
                    examfisregional.exaFisRegInicial_vascularExtre = txt_vascular.Text;
                    examfisregional.exaFisRegInicial_miemSupeExtre = txt_miembrosuperiores.Text;
                    examfisregional.exaFisRegInicial_miemInfeExtre = txt_miembrosinferiores.Text;
                    examfisregional.exaFisRegInicial_fuerzaNeuro = txt_fuerza.Text;
                    examfisregional.exaFisRegInicial_sensibiNeuro = txt_sensibilidad.Text;
                    examfisregional.exaFisRegInicial_marchaNeuro = txt_marcha.Text;
                    examfisregional.exaFisRegInicial_refleNeuro = txt_reflejos.Text;
                    examfisregional.exaFisRegInicial_observa = txt_obervexamenfisicoregional.Text;
                    examfisregional.Per_id = perso;

                    //L. Captura de Datos Tbl_ResExaGenEspRiesTrabajo
                    exagenesperiespues.ResExaGenEspRiesTrabajo_examen = txt_examen.Text;
                    exagenesperiespues.ResExaGenEspRiesTrabajo_fecha = Convert.ToDateTime(txt_fechaexamen.Text);
                    exagenesperiespues.ResExaGenEspRiesTrabajo_resultados = txt_resultadoexamen.Text;
                    exagenesperiespues.ResExaGenEspRiesTrabajo_observaciones = txt_observacionexamen.Text;
                    exagenesperiespues.Per_id = perso;

                    //M. Captura de Datos Tbl_Diagnostico
                    diagnostico.Diag_descripcion = txt_descripdiagnostico.Text;
                    diagnostico.Diag_pre = txt_pre.Text;
                    diagnostico.Diag_def = txt_def.Text;
                    diagnostico.Per_id = perso;

                    //N.Captura de Datos Tbl_AptitudMedica
                    aptitudmedica.AptMed_apto = txt_apto.Text;
                    aptitudmedica.AptMed_aptoObserva = txt_aptoobservacion.Text;
                    aptitudmedica.AptMed_aptoLimi = txt_aptolimitacion.Text;
                    aptitudmedica.AptMed_NoApto = txt_noapto.Text;
                    aptitudmedica.AptMed_Observ = txt_observacionaptitud.Text;
                    aptitudmedica.AptMed_Limit = txt_limitacionaptitud.Text;
                    aptitudmedica.Per_id = perso;

                    //O. Captura de Datos Recomendaciones y/o Tratamiento
                    tratamientoinicial.trataInicial_descrip = txt_descripciontratamiento.Text;
                    tratamientoinicial.Per_id = perso;

                    //A . Método para guardar Datos Establecimeinto Empresa Usuarios
                    CN_Inicial.guardarDatosEstablecimientoEmpresaUsuario(datosestempresausu);
                    //B . Método para guardar Datos Motivo Consulta
                    CN_Inicial.guardarMotivoConsultaInicial(motconini);
                    //D. Método de guardar Datos Antec. Empleados Anteriores
                    CN_Inicial.guardarEmpleAnteriores(emplant);
                    //E. Método de guardar Datos ANTECEDENTES FAMILIARES (DETALLAR EL PARENTESCO)
                    CN_Inicial.guardarAntecedentesFamiliaresDetParentesco(AnteFamiDetParentesco);
                    //F. Método de guardar Datos Riesgo Puesto Trabajo Actual
                    CN_Inicial.guardarRiesgoPuesTrabaActual(facriesgotractual);
                    //G. Método de guardar Datos Actividad Extra Laboral
                    CN_Inicial.guardarActivextralaboral(actvextralaboral);
                    //H. Método de guardar Datos Enfermedad Actual
                    CN_Inicial.guardarEnfermedadActual(enferactualinicial);
                    //I. Método de guardar Datos REVISIÓN ACTUAL DE ÓRGANOS Y SISTEMAS
                    CN_Inicial.guardarReviActualOrganSistemas(revisionactualorganossistemas);
                    //K. Método de guardar Datos Examen Fisico Regional
                    CN_Inicial.guardarExamenFisicoRegional(examfisregional);
                    //L. Método de guardar Datos Resul. Exam. General y Espec de acuerdo al Riesgo y puesto de trabajo
                    CN_Inicial.guardarExaGenEspeRiesyPues(exagenesperiespues);
                    //M. Método de guardar Datos Diagnostico
                    CN_Inicial.guardarDiagnostico(diagnostico);
                    //N. Método de guardar Datos Aptitud Medica
                    CN_Inicial.guardarAptiMediTrabajo(aptitudmedica);
                    //O. Método de guardar Datos Recomendaciones y/o Tratamiento
                    CN_Inicial.guardarRecomendacionesTratamiento(tratamientoinicial);

                    //Mensaje de confirmacion
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Guardados Exitosamente')", true);

                    Response.Redirect("~/Template/Views/PacientesInicial.aspx");
                    limpiar();

                }

            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Guardados')", true);
            }

        }

        private void ModificarHistorial(Tbl_Personas per, Tbl_AntecedentesEmplAnteriores emplant, Tbl_AntecedentesCliQuiru antcliqui, 
            Tbl_AccidentesTrabajoDesc acctrabajo, Tbl_EnfermedadesProfesionales enferprof, Tbl_FacRiesTrabAct facriesgotractual,
            Tbl_ActividadesExtraLaborales actvextralaboral, Tbl_ResExaGenEspRiesTrabajo exagenesperiespues, 
            Tbl_Diagnostico diagnostico, Tbl_AptitudMedica aptitudmedica)
        {

            try
            {
                //antcliqui = new Tbl_AntecedentesCliQuiru();
                emplant = new Tbl_AntecedentesEmplAnteriores();
                acctrabajo = new Tbl_AccidentesTrabajoDesc();
                enferprof = new Tbl_EnfermedadesProfesionales();
                facriesgotractual = new Tbl_FacRiesTrabAct();
                actvextralaboral = new Tbl_ActividadesExtraLaborales();
                exagenesperiespues = new Tbl_ResExaGenEspRiesTrabajo();
                diagnostico = new Tbl_Diagnostico();
                aptitudmedica = new Tbl_AptitudMedica();

                //captura de datos tbl_motivoconsulta
                //antcliqui.AntCliQuiru_descripcion = txt_antCliQuiDescripcion.Text;

                //captura de datos Tbl_AntecedentesEmplAnteriores 
                emplant.AntEmpAnte_nomEmpresa = txt_empresa.Text;
                emplant.AntEmpAnte_puestoTrabajo = txt_puestotrabajo.Text;
                emplant.AntEmpAnte_actDesemp = txt_actdesempeña.Text;
                emplant.AntEmpAnte_tiemTrabajo = Convert.ToInt32(txt_tiempotrabajo.Text);
                emplant.AntEmpAnte_nomEmpresa = txt_fisico.Text;
                emplant.AntEmpAnte_nomEmpresa = txt_mecanico.Text;
                emplant.AntEmpAnte_nomEmpresa = txt_quimico.Text;
                emplant.AntEmpAnte_nomEmpresa = txt_biologico.Text;
                emplant.AntEmpAnte_nomEmpresa = txt_ergonomico.Text;
                emplant.AntEmpAnte_nomEmpresa = txt_psicosocial.Text;
                emplant.AntEmpAnte_nomEmpresa = txt_observaciones1.Text;

                //captura de datos Tbl_AccidentesTrabajoDesc

                //captura de datos Tbl_EnfermedadesProfesionales

                //captura de datos Tbl_FacRiesTrabAct
                facriesgotractual.FacRiesTrabAct_area = txt_puestodetrabajo.Text;
                facriesgotractual.FacRiesTrabAct_actividades = txt_act.Text;
                facriesgotractual.FacRiesTrabAct_temAltasFis = txt_tempaltas.Text;
                facriesgotractual.FacRiesTrabAct_atraMaquinasMec = txt_atrapmaquinas.Text;
                facriesgotractual.FacRiesTrabAct_solidosQui = txt_solidos.Text;
                facriesgotractual.FacRiesTrabAct_virusBio = txt_virus.Text;
                facriesgotractual.FacRiesTrabAct_maneManCarErg = txt_manmanualcargas.Text;
                facriesgotractual.FacRiesTrabAct_monoTrabPsi = txt_montrabajo.Text;
                facriesgotractual.FacRiesTrabAct_medPreventivas = txt_medpreventivas.Text;

                //captura de datos Tbl_ActividadesExtraLaborales
                actvextralaboral.ActExtLab_descrip = txt_descrextralaborales.Text;

                //captura de datos Tbl_ResExaGenEspRiesTrabajo
                exagenesperiespues.ResExaGenEspRiesTrabajo_examen = txt_examen.Text;
                exagenesperiespues.ResExaGenEspRiesTrabajo_fecha = Convert.ToDateTime(txt_fechaexamen.Text);
                exagenesperiespues.ResExaGenEspRiesTrabajo_resultados = txt_resultadoexamen.Text;
                exagenesperiespues.ResExaGenEspRiesTrabajo_observaciones = txt_observacionexamen.Text;

                //captura de datos Tbl_Diagnostico
                diagnostico.Diag_descripcion = txt_descripdiagnostico.Text;
                diagnostico.Diag_pre = txt_pre.Text;
                diagnostico.Diag_def = txt_def.Text;

                //captura de datos Tbl_AptitudMedica
                aptitudmedica.AptMed_apto = txt_apto.Text;
                aptitudmedica.AptMed_Observ = txt_observacionaptitud.Text;
                aptitudmedica.AptMed_Limit = txt_limitacionaptitud.Text;

                //metodo de guardar Antec. Empleados Anteriores
                CN_Inicial.guardarEmpleAnteriores(emplant);

                //metodo de guardar Accid. de trabajo
                //metodo de guardar Enfer. Profesionales

                //metodo de guardar Riesgo Puesto Trabajo Actual
                CN_Inicial.guardarRiesgoPuesTrabaActual(facriesgotractual);

                //metodo de guardar Actividad Extra Laboral
                CN_Inicial.guardarActivextralaboral(actvextralaboral);

                //metodo de guardar Resul. Exam. General y Espec de acuerdo al Riesgo y puesto de trabajo
                CN_Inicial.guardarExaGenEspeRiesyPues(exagenesperiespues);

                //metodo de guardar Diagnostico
                CN_Inicial.guardarDiagnostico(diagnostico);

                //metodo de guardar Aptitud Medica
                CN_Inicial.guardarAptiMediTrabajo(aptitudmedica);

                //metodo de guardar motivo de consulta
                //CN_Inicial.guardarAntCliniQuirur(antcliqui);                    

                //Mensaje de confirmacion
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Guardados Exitosamente')", true);

                Response.Redirect("~/Template/Views/PacientesInicial.aspx");
                limpiar();
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Modificados')", true);
            }
            
        }

        private void limpiar()
        {
            txt_antCliQuiDescripcion.Text = "";
            txt_empresa.Text = txt_puestotrabajo.Text = txt_actdesempeña.Text = txt_tiempotrabajo.Text = txt_fisico.Text = txt_mecanico.Text=
            txt_quimico.Text = txt_biologico.Text = txt_ergonomico.Text = txt_psicosocial.Text = txt_observaciones1.Text = txt_si.Text =
            txt_especificar.Text = txt_no.Text = txt_fecha.Text = txt_observaciones2.Text = txt_siprofesional.Text = txt_espeprofesional.Text =
            txt_noprofesional.Text = txt_fechaprofesional.Text = txt_observaciones3.Text = txt_puestodetrabajo.Text = txt_act.Text = 
            txt_tempaltas.Text = txt_atrapmaquinas.Text = txt_solidos.Text = txt_puestodetrabajo2.Text = txt_act2.Text = txt_virus.Text = 
            txt_manmanualcargas.Text = txt_montrabajo.Text = txt_medpreventivas.Text = txt_descrextralaborales.Text = txt_examen.Text = 
            txt_fechaexamen.Text = txt_resultadoexamen.Text = txt_observacionexamen.Text = txt_descripdiagnostico.Text = txt_pre.Text = 
            txt_def.Text = txt_apto.Text = txt_observacionaptitud.Text = txt_limitacionaptitud.Text = "";

        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            guardar_modificar_datos(Convert.ToInt32(Request["cod"]), Convert.ToInt32(per.Per_id.ToString()), 
                Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()),
                Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()),
                Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), 
                Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), 
                Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()));
        }

        protected void btn_modificar_Click(object sender, EventArgs e)
        {
            guardar_modificar_datos(Convert.ToInt32(Request["cod"]), Convert.ToInt32(per.Per_id.ToString()),
                Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()),
                Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()),
                Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()),
                Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()),
                Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()));
        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/Views/Inicio.aspx");
        }

        
    }
}