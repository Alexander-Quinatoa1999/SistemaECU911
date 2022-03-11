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
        private Tbl_AntecedentesPersonalesInicial antper = new Tbl_AntecedentesPersonalesInicial();
        
        //D. Objeto de la tabla ANTECEDENTES DE EMPLEOS ANTERIORES
        private Tbl_AntecedentesEmplAnteriores emplant = new Tbl_AntecedentesEmplAnteriores();
        
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

        //P. Objeto de la tabla DATOS DEL PROFESIONAL
        private Tbl_DatProfesionalInicial datosProfesional = new Tbl_DatProfesionalInicial();

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
                txt_edadinicial.Text = per.Per_fechNacimiento.ToString();
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

                    datosestempresausu = CN_Inicial.obtenerDatEstEmpreUsuar(perso);
                    motconini = CN_Inicial.obtenerMotivoConsultaInicial(perso);
                    antper = CN_Inicial.obtenerAntecedentesPersonalesInicial(perso);
                    emplant = CN_Inicial.obtenerEmpAntexPer(perso);
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
                    datosProfesional = CN_Inicial.obtenerDatosProfesionalxPer(perso);

                    btn_guardar.Visible = true;

                    if (per != null || datosestempresausu != null || motconini != null || antper != null || emplant != null || 
                        AnteFamiDetParentesco != null || facriesgotractual != null || actvextralaboral != null ||
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
                        txt_edadinicial.Text = per.Per_fechNacimiento.ToString();
                        //txt_catolica.Text = datosestempresausu.datEstable_catolicaRel.ToString();
                        //txt_evangelica.Text = datosestempresausu.datEstable_evangelicaRel.ToString();
                        //txt_testigo.Text = datosestempresausu.datEstable_testJehovaRel.ToString();
                        //txt_mormona.Text = datosestempresausu.datEstable_mormonaRel.ToString();
                        //txt_otrareligion.Text = datosestempresausu.datEstable_otrasRel.ToString();
                        txt_gruposanguineo.Text = datosestempresausu.datEstable_groSanguineo.ToString();
                        txt_lateralidad.Text = datosestempresausu.datEstable_lateralidad.ToString();
                        //txt_lesbiana.Text = datosestempresausu.datEstable__lesbianaOriSex.ToString();
                        //txt_gay.Text = datosestempresausu.datEstable_gayOriSex.ToString();
                        //txt_bisexual.Text = datosestempresausu.datEstable_bisexualOriSex.ToString();
                        //txt_heterosexual.Text = datosestempresausu.datEstable_heterosexualOriSex.ToString();
                        //txt_noRespondeOriSex.Text = datosestempresausu.datEstable_norespondeOriSex.ToString();
                        //txt_femenino.Text = datosestempresausu.datEstable_femeninoIdenGen.ToString();
                        //txt_masculino.Text = datosestempresausu.datEstable_masculinoIdenGen.ToString();
                        //txt_transfemenino.Text = datosestempresausu.datEstable_transFemeninoIdenGen.ToString();
                        //txt_transmasculino.Text = datosestempresausu.datEstable_transMasculinoIdenGen.ToString();
                        //txt_noRespondeIdeGen.Text = datosestempresausu.datEstable_norespondeIdenGen.ToString();
                        //txt_sidiscapacidad.Text = datosestempresausu.datEstable_siDis.ToString();
                        //txt_nodiscapacidad.Text = datosestempresausu.datEstable_noDis.ToString();
                        txt_tipodiscapacidad.Text = datosestempresausu.datEstable_tipoDis.ToString();
                        txt_porcentajediscapacidad.Text = datosestempresausu.datEstable_porcentDis.ToString();
                        txt_actividadesrelevantes.Text = datosestempresausu.datEstable_actRelevantesTrabOcupar.ToString();

                        //B
                        txt_motivoconsultainicial.Text = motconini.motConIni_descrip.ToString();

                        //C
                        txt_antCliQuiDescripcion.Text = antper.antPerInicial_descripcion.ToString();
                        txt_menarquiaAntGinObste.Text = antper.antPerInicial_menarquia.ToString();
                        txt_ciclosAntGinObste.Text = antper.antPerInicial_ciclos.ToString();
                        txt_fechUltiMensAntGinObste.Text = antper.antPerInicial_fechUltiMenstrua.ToString();
                        txt_gestasAntGinObste.Text = antper.antPerInicial_gestas.ToString();
                        txt_partosAntGinObste.Text = antper.antPerInicial_partos.ToString();
                        txt_cesareasAntGinObste.Text = antper.antPerInicial_cesareas.ToString();
                        txt_abortosAntGinObste.Text = antper.antPerInicial_abortos.ToString();
                        txt_vivosAntGinObste.Text = antper.antPerInicial_vivosHij.ToString();
                        txt_muertosAntGinObste.Text = antper.antPerInicial_muertosHij.ToString();
                        //txt_siVidSexAntGinObste.Text = antper.antPerInicial_siVidaSexActiva.ToString();
                        //txt_noVidSexAntGinObste.Text = antper.antPerInicial_noVidaSexActiva.ToString();
                        //txt_siMetPlaniAntGinObste.Text = antper.antPerInicial_siMetPlanifiFamiliar.ToString();
                        //txt_noMetPlaniAntGinObste.Text = antper.antPerInicial_noMetPlanifiFamiliar.ToString();
                        txt_tipoMetPlaniAntGinObste.Text = antper.antPerInicial_tipoMetPlanifiFamiliar.ToString();
                        //txt_siPapaniAntGinObste.Text = antper.antPerInicial_siExaRealiPapanicolaou.ToString();
                        //txt_noPapaniAntGinObste.Text = antper.antPerInicial_noExaRealiPapanicolaou.ToString();
                        txt_tiempoPapaniAntGinObste.Text = antper.antPerInicial_tiempoExaRealiPapanicolaou.ToString();
                        txt_resultadoPapaniAntGinObste.Text = antper.antPerInicial_resultadoExaRealiPapanicolaou.ToString();
                        //txt_siEcoMamaAntGinObste.Text = antper.antPerInicial_siExaRealiEcoMamario.ToString();
                        //txt_noEcoMamaAntGinObste.Text = antper.antPerInicial_noExaRealiEcoMamario.ToString();
                        txt_tiempoEcoMamaAntGinObste.Text = antper.antPerInicial_tiempoExaRealiEcoMamario.ToString();
                        txt_resultadoEcoMamaAntGinObste.Text = antper.antPerInicial_resultadoExaRealiEcoMamario.ToString();
                        //txt_siColposAntGinObste.Text = antper.antPerInicial_siExaRealiColposcopia.ToString();
                        //txt_noColposAntGinObste.Text = antper.antPerInicial_noExaRealiColposcopia.ToString();
                        txt_tiempoColposAntGinObste.Text = antper.antPerInicial_tiempoExaRealiColposcopia.ToString();
                        txt_resultadoColposAntGinObste.Text = antper.antPerInicial_resultadoExaRealiColposcopia.ToString();
                        //txt_siMamograAntGinObste.Text = antper.antPerInicial_siExaRealiMamografia.ToString();
                        //txt_noMamograAntGinObste.Text = antper.antPerInicial_noExaRealiMamografia.ToString();
                        txt_tiempoMamograAntGinObste.Text = antper.antPerInicial_tiempoExaRealiMamografia.ToString();
                        txt_resultadoMamograAntGinObste.Text = antper.antPerInicial_resultadoExaRealiMamografia.ToString();
                        //txt_siExaRealiAntProstaAntReproMascu.Text = antper.antPerInicial_siExaRealiAntiProstatico.ToString();
                        //txt_noExaRealiAntProstaAntReproMascu.Text = antper.antPerInicial_noExaRealiAntiProstatico.ToString();
                        txt_tiempoExaRealiAntProstaAntReproMascu.Text = antper.antPerInicial_tiempoExaRealiAntiProstatico.ToString();
                        txt_resultadoExaRealiAntProstaAntReproMascu.Text = antper.antPerInicial_resultadoExaRealiAntiProstatico.ToString();
                        //txt_siMetPlaniAntReproMascu.Text = antper.antPerInicial_siMetPlanifiFamiAntReproMascu.ToString();
                        //txt_noMetPlaniAntReproMascu.Text = antper.antPerInicial_noMetPlanifiFamiAntReproMascu.ToString();
                        txt_tipo1MetPlaniAntReproMascu.Text = antper.antPerInicial_tipo1MetPlanifiFamiAntReproMascu.ToString();
                        txt_vivosHijosAntReproMascu.Text = antper.antPerInicial_vivosHijAntReproMascu.ToString();
                        txt_muertosHijosAntReproMascu.Text = antper.antPerInicial_muertosHijAntReproMascu.ToString();
                        //txt_siExaRealiEcoProstaAntReproMascu.Text = antper.antPerInicial_siExaRealiEcoProstatico.ToString();
                        //txt_noExaRealiEcoProstaAntReproMascu.Text = antper.antPerInicial_noExaRealiEcoProstatico.ToString();
                        txt_tiempoExaRealiEcoProstaAntReproMascu.Text = antper.antPerInicial_tiempoExaRealiEcoProstatico.ToString();
                        txt_resultadoExaRealiEcoProstaAntReproMascu.Text = antper.antPerInicial_resultadoExaRealiEcoProstatico.ToString();
                        txt_tipo2MetPlaniAntReproMascu.Text = antper.antPerInicial_tipo2MetPlanifiFamiAntReproMascu.ToString();
                        //txt_siConsuNociTabaHabToxi.Text = antper.antPerInicial_siConsuNocivosTabaco.ToString();
                        //txt_noConsuNociTabaHabToxi.Text = antper.antPerInicial_noConsuNocivosTabaco.ToString();
                        txt_tiemConConsuNociTabaHabToxi.Text = antper.antPerInicial_tiempoConsuConsuNocivosTabaco.ToString();
                        txt_cantiConsuNociTabaHabToxi.Text = antper.antPerInicial_cantidadConsuNocivosTabaco.ToString();
                        txt_exConsumiConsuNociTabaHabToxi.Text = antper.antPerInicial_exConsumiConsuNocivosTabaco.ToString();
                        txt_tiemAbstiConsuNociTabaHabToxi.Text = antper.antPerInicial_tiempoAbstiConsuNocivosTabaco.ToString();
                        //txt_siConsuNociAlcoHabToxi.Text = antper.antPerInicial_siConsuNocivosAlcohol.ToString();
                        //txt_noConsuNociAlcoHabToxi.Text = antper.antPerInicial_noConsuNocivosAlcohol.ToString();
                        txt_tiemConConsuNociAlcoHabToxi.Text = antper.antPerInicial_tiempoConsuConsuNocivosAlcohol.ToString();
                        txt_cantiConsuNociAlcoHabToxi.Text = antper.antPerInicial_cantidadConsuNocivosAlcohol.ToString();
                        txt_exConsumiConsuNociAlcoHabToxi.Text = antper.antPerInicial_exConsumiConsuNocivosAlcohol.ToString();
                        txt_tiemAbstiConsuNociAlcoHabToxi.Text = antper.antPerInicial_tiempoAbstiConsuNocivosAlcohol.ToString();
                        //txt_siConsuNociOtrasDroHabToxi.Text = antper.antPerInicial_siConsuNocivosOtrasDrogas.ToString();
                        //txt_noConsuNociOtrasDroHabToxi.Text = antper.antPerInicial_noConsuNocivosOtrasDrogas.ToString();
                        txt_tiemCon1ConsuNociOtrasDroHabToxi.Text = antper.antPerInicial_tiempoConsu1ConsuNocivosOtrasDrogas.ToString();
                        txt_canti1ConsuNociOtrasDroHabToxi.Text = antper.antPerInicial_cantidad1ConsuNocivosOtrasDrogas.ToString();
                        txt_exConsumi1ConsuNociOtrasDroHabToxi.Text = antper.antPerInicial_exConsumi1ConsuNocivosOtrasDrogas.ToString();
                        txt_tiemAbsti1ConsuNociOtrasDroHabToxi.Text = antper.antPerInicial_tiempoAbsti1ConsuNocivosOtrasDrogas.ToString();
                        txt_otrasConsuNociOtrasDroHabToxi.Text = antper.antPerInicial_otrasConsuNocivos.ToString();
                        txt_tiemCon2ConsuNociOtrasDroHabToxi.Text = antper.antPerInicial_tiempoConsu2ConsuNocivosOtrasDrogas.ToString();
                        txt_canti2ConsuNociOtrasDroHabToxi.Text = antper.antPerInicial_cantidad2ConsuNocivosOtrasDrogas.ToString();
                        txt_exConsumi2ConsuNociOtrasDroHabToxi.Text = antper.antPerInicial_exConsumi2ConsuNocivosOtrasDrogas.ToString();
                        txt_tiemAbsti2ConsuNociOtrasDroHabToxi.Text = antper.antPerInicial_tiempoAbsti2ConsuNocivosOtrasDrogas.ToString();
                        //txt_siEstVidaActFisiEstVida.Text = antper.antPerInicial_siEstiVidaActFisica.ToString();
                        //txt_noEstVidaActFisiEstVida.Text = antper.antPerInicial_noEstiVidaActFisica.ToString();
                        txt_cualEstVidaActFisiEstVida.Text = antper.antPerInicial_cualEstiVidaActFisica.ToString();
                        txt_tiemCanEstVidaActFisiEstVida.Text = antper.antPerInicial_tiem_cantEstiVidaActFisica.ToString();
                        //txt_siEstVidaMedHabiEstVida.Text = antper.antPerInicial_siEstiVidaMediHabitual.ToString();
                        //txt_noEstVidaMedHabiEstVida.Text = antper.antPerInicial_noEstiVidaMediHabitual.ToString();
                        txt_cual1EstVidaMedHabiEstVida.Text = antper.antPerInicial_cual1EstiVidaMediHabitual.ToString();
                        txt_tiemCan1EstVidaMedHabiEstVida.Text = antper.antPerInicial_tiem_cant1EstiVidaMediHabitual.ToString();
                        txt_cual2EstVidaMedHabiEstVida.Text = antper.antPerInicial_cual2EstiVidaMediHabitual.ToString();
                        txt_tiemCan2EstVidaMedHabiEstVida.Text = antper.antPerInicial_tiem_cant2EstiVidaMediHabitual.ToString();
                        txt_cual3EstVidaMedHabiEstVida.Text = antper.antPerInicial_cual3EstiVidaMediHabitual.ToString();
                        txt_tiemCan3EstVidaMedHabiEstVida.Text = antper.antPerInicial_tiem_cant3EstiVidaMediHabitual.ToString();

                        //D
                        txt_empresa.Text = emplant.AntTrabajoInicial_nomEmpresa.ToString();
                        txt_puestotrabajo.Text = emplant.AntTrabajoInicial_puestoTrabajo.ToString();
                        txt_actdesempeña.Text = emplant.AntTrabajoInicial_actDesemp.ToString();
                        txt_tiempotrabajo.Text = emplant.AntTrabajoInicial_tiemTrabajo.ToString();
                        //txt_fisico.Text = emplant.AntTrabajoInicial_fisicoRies.ToString();
                        //txt_mecanico.Text = emplant.AntTrabajoInicial_mecanicoRies.ToString();
                        //txt_quimico.Text = emplant.AntTrabajoInicial_quimicoRies.ToString();
                        //txt_biologico.Text = emplant.AntTrabajoInicial_biologicoRies.ToString();
                        //txt_ergonomico.Text = emplant.AntTrabajoInicial_ergonomicoRies.ToString();
                        //txt_psicosocial.Text = emplant.AntTrabajoInicial_psicosocial.ToString();
                        txt_obseantempleanteriores.Text = emplant.AntTrabajoInicial_observaciones.ToString();
                        //txt_si.Text = emplant.AntTrabajoInicial_siCalificadoIESSAcciTrabajo.ToString();
                        txt_especificar.Text = emplant.AntTrabajoInicial_especificarCalificadoIESSAcciTrabajo.ToString();
                        //txt_no.Text = emplant.AntTrabajoInicial_noCalificadoIESSAcciTrabajo.ToString();
                        txt_fecha.Text = emplant.AntTrabajoInicial_fechaCalificadoIESSAcciTrabajo.ToString();
                        txt_observaciones2.Text = emplant.AntTrabajoInicial_obserAcciTrabajo.ToString();
                        //txt_siprofesional.Text = emplant.AntTrabajoInicial_siCalificadoIESSEnfProfesionales.ToString();
                        txt_espeprofesional.Text = emplant.AntTrabajoInicial_especificarCalificadoIESSEnfProfesionales.ToString();
                        //txt_noprofesional.Text = emplant.AntTrabajoInicial_noCalificadoIESSEnfProfesionales.ToString();
                        txt_fechaprofesional.Text = emplant.AntTrabajoInicial_fechaCalificadoIESSEnfProfesionales.ToString();

                        //E
                        //txt_enfermedadcardiovascular.Text = AnteFamiDetParentesco.AntFamDetPare_enfCarVas.ToString();
                        //txt_enfermedadmetabolica.Text = AnteFamiDetParentesco.AntFamDetPare_enfMeta.ToString();
                        //txt_enfermedadneurologica.Text = AnteFamiDetParentesco.AntFamDetPare_enfNeuro.ToString();
                        //txt_enfermedadoncologica.Text = AnteFamiDetParentesco.AntFamDetPare_enfOnco.ToString();
                        //txt_enfermedadinfecciosa.Text = AnteFamiDetParentesco.AntFamDetPare_enfInfe.ToString();
                        //txt_enfermedadhereditaria.Text = AnteFamiDetParentesco.AntFamDetPare_enfHereConge.ToString();
                        //txt_discapacidades.Text = AnteFamiDetParentesco.AntFamDetPare_discapa.ToString();
                        //txt_otrosenfer.Text = AnteFamiDetParentesco.AntFamDetPare_otros.ToString();
                        txt_descripcionantefamiliares.Text = AnteFamiDetParentesco.AntFamDetPare_descripcion.ToString();

                        //F
                        txt_puestodetrabajo.Text = facriesgotractual.FacRiesTrabAct_area.ToString();
                        txt_act.Text = facriesgotractual.FacRiesTrabAct_actividades.ToString();
                        txt_tempbajas.Text = facriesgotractual.FacRiesTrabAct_temBajasFis.ToString();
                        txt_radiacion.Text = facriesgotractual.FacRiesTrabAct_radIonizanteFis.ToString();
                        txt_noradiacion.Text = facriesgotractual.FacRiesTrabAct_radNoIonizanteFis.ToString();
                        txt_ruido.Text = facriesgotractual.FacRiesTrabAct_ruidoFis.ToString();
                        txt_vibracion.Text = facriesgotractual.FacRiesTrabAct_vibracionFis.ToString();
                        txt_iluminacion.Text = facriesgotractual.FacRiesTrabAct_iluminacionFis.ToString();
                        txt_ventilacion.Text = facriesgotractual.FacRiesTrabAct_ventilacionFis.ToString();
                        txt_fluidoelectrico.Text = facriesgotractual.FacRiesTrabAct_fluElectricoFis.ToString();
                        txt_otrosFisico.Text = facriesgotractual.FacRiesTrabAct_otrosFis.ToString();
                        txt_atrapmaquinas.Text = facriesgotractual.FacRiesTrabAct_atraMaquinasMec.ToString();
                        txt_atrapsuperficie.Text = facriesgotractual.FacRiesTrabAct_atraSuperfiiesMec.ToString();
                        txt_atrapobjetos.Text = facriesgotractual.FacRiesTrabAct_atraObjetosMec.ToString();
                        txt_caidaobjetos.Text = facriesgotractual.FacRiesTrabAct_caidaObjetosMec.ToString();
                        txt_caidamisnivel.Text = facriesgotractual.FacRiesTrabAct_caidaMisNivelMec.ToString();
                        txt_caidadifnivel.Text = facriesgotractual.FacRiesTrabAct_caidaDifNivelMec.ToString();
                        txt_contaelectrico.Text = facriesgotractual.FacRiesTrabAct_contactoElecMec.ToString();
                        txt_contasuptrabajo.Text = facriesgotractual.FacRiesTrabAct_conSuperTrabaMec.ToString();
                        txt_proyparticulas.Text = facriesgotractual.FacRiesTrabAct_proPartiFragMec.ToString();
                        txt_proyefluidos.Text = facriesgotractual.FacRiesTrabAct_proFluidosMec.ToString();
                        txt_pinchazos.Text = facriesgotractual.FacRiesTrabAct_pinchazosMec.ToString();
                        txt_cortes.Text = facriesgotractual.FacRiesTrabAct_cortesMec.ToString();
                        txt_atroporvehiculos.Text = facriesgotractual.FacRiesTrabAct_atropeVehiMec.ToString();
                        txt_choques.Text = facriesgotractual.FacRiesTrabAct_coliVehiMec.ToString();
                        txt_otrosMecanico.Text = facriesgotractual.FacRiesTrabAct_otrosMec.ToString();
                        txt_solidos.Text = facriesgotractual.FacRiesTrabAct_solidosQui.ToString();
                        txt_polvos.Text = facriesgotractual.FacRiesTrabAct_polvosQui.ToString();
                        txt_humos.Text = facriesgotractual.FacRiesTrabAct_humosQui.ToString();
                        txt_liquidos.Text = facriesgotractual.FacRiesTrabAct_liquidosQui.ToString();
                        txt_vapores.Text = facriesgotractual.FacRiesTrabAct_vaporesQui.ToString();
                        txt_aerosoles.Text = facriesgotractual.FacRiesTrabAct_aerosolesQui.ToString();
                        txt_neblinas.Text = facriesgotractual.FacRiesTrabAct_neblinasQui.ToString();
                        txt_gaseosos.Text = facriesgotractual.FacRiesTrabAct_gaseososQui.ToString();
                        txt_otrosQuimico.Text = facriesgotractual.FacRiesTrabAct_otrosBio.ToString();
                        txt_virus.Text = facriesgotractual.FacRiesTrabAct_virusBio.ToString();
                        txt_hongos.Text = facriesgotractual.FacRiesTrabAct_hongosBio.ToString();
                        txt_bacterias.Text = facriesgotractual.FacRiesTrabAct_bacteriasBio.ToString();
                        txt_parasitos.Text = facriesgotractual.FacRiesTrabAct_parasitosBio.ToString();
                        txt_expoavectores.Text = facriesgotractual.FacRiesTrabAct_expVectBio.ToString();
                        txt_expoanimselvaticos.Text = facriesgotractual.FacRiesTrabAct_expAniSelvaBio.ToString();
                        txt_otrosBiologico.Text = facriesgotractual.FacRiesTrabAct_otrosBio.ToString();
                        txt_manmanualcargas.Text = facriesgotractual.FacRiesTrabAct_maneManCarErg.ToString();
                        txt_movrepetitivo.Text = facriesgotractual.FacRiesTrabAct_movRepeErg.ToString();
                        txt_postforzadas.Text = facriesgotractual.FacRiesTrabAct_posForzaErg.ToString();
                        txt_trabajopvd.Text = facriesgotractual.FacRiesTrabAct_trabPvdErg.ToString();
                        txt_otrosErgonomico.Text = facriesgotractual.FacRiesTrabAct_otrosErg.ToString();
                        txt_montrabajo.Text = facriesgotractual.FacRiesTrabAct_monoTrabPsi.ToString();
                        txt_sobrecargalaboral.Text = facriesgotractual.FacRiesTrabAct_sobrecarLabPsi.ToString();
                        txt_minustarea.Text = facriesgotractual.FacRiesTrabAct_minuTareaPsi.ToString();
                        txt_altarespon.Text = facriesgotractual.FacRiesTrabAct_altaResponPsi.ToString();
                        txt_automadesiciones.Text = facriesgotractual.FacRiesTrabAct_autoTomaDesiPsi.ToString();
                        txt_supyestdireficiente.Text = facriesgotractual.FacRiesTrabAct_supEstDirecDefiPsi.ToString();
                        txt_conflictorol.Text = facriesgotractual.FacRiesTrabAct_conflicRolPsi.ToString();
                        txt_faltaclarfunciones.Text = facriesgotractual.FacRiesTrabAct_falClariFunPsi.ToString();
                        txt_incorrdistrabajo.Text = facriesgotractual.FacRiesTrabAct_incoDistriTrabPsi.ToString();
                        txt_turnorotat.Text = facriesgotractual.FacRiesTrabAct_turnosRotaPsi.ToString();
                        txt_relacinterpersonales.Text = facriesgotractual.FacRiesTrabAct_relInterperPsi.ToString();
                        txt_inestalaboral.Text = facriesgotractual.FacRiesTrabAct_inesLabPsi.ToString();
                        txt_otrosPsicosocial.Text = facriesgotractual.FacRiesTrabAct_otrosPsi.ToString();
                        txt_medpreventivas.Text = facriesgotractual.FacRiesTrabAct_medPreventivas.ToString();

                        //G
                        txt_descrextralaborales.Text = actvextralaboral.ActExtLab_descrip.ToString();

                        //H
                        txt_enfermedadactualinicial.Text = enferactualinicial.enfActual_descrip.ToString();

                        //I
                        //txt_pielanexos.Text = revisionactualorganossistemas.RevActOrgSis_pielAnexos.ToString();
                        //txt_organossentidos.Text = revisionactualorganossistemas.RevActOrgSis_orgSentidos.ToString();
                        //txt_respiratorio.Text = revisionactualorganossistemas.RevActOrgSis_respiratorio.ToString();
                        //txt_cardiovascular.Text = revisionactualorganossistemas.RevActOrgSis_cardVascular.ToString();
                        //txt_digestivo.Text = revisionactualorganossistemas.RevActOrgSis_digestivo.ToString();
                        //txt_genitourinario.Text = revisionactualorganossistemas.RevActOrgSis_genUrinario.ToString();
                        //txt_musculosesqueleticos.Text = revisionactualorganossistemas.RevActOrgSis_muscEsqueletico.ToString();
                        //txt_endocrino.Text = revisionactualorganossistemas.RevActOrgSis_endocrino.ToString();
                        //txt_hemolinfatico.Text = revisionactualorganossistemas.RevActOrgSis_hemoLimfa.ToString();
                        //txt_nervioso.Text = revisionactualorganossistemas.RevActOrgSis_nervioso.ToString();
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
                        txt_miembrosinferiores.Text = examfisregional.exaFisRegInicial_miemInfeExtre.ToString();
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
                        txt_cie.Text = diagnostico.Diag_cie.ToString();
                        //txt_pre.Text = diagnostico.Diag_pre.ToString();
                        //txt_def.Text = diagnostico.Diag_def.ToString();

                        //N
                        //txt_apto.Text = aptitudmedica.AptMed_apto.ToString();
                        //txt_aptoobservacion.Text = aptitudmedica.AptMed_aptoObserva.ToString();
                        //txt_aptolimitacion.Text = aptitudmedica.AptMed_aptoLimi.ToString();
                        //txt_noapto.Text = aptitudmedica.AptMed_NoApto.ToString();
                        txt_observacionaptitud.Text = aptitudmedica.AptMed_Observ.ToString();
                        txt_limitacionaptitud.Text = aptitudmedica.AptMed_Limit.ToString();

                        //O
                        txt_descripciontratamiento.Text = tratamientoinicial.trataInicial_descrip.ToString();

                        //P
                        txt_fechaDatProf.Text = datosProfesional.DatProfeInicial_fecha_hora.ToString();
                        ddl_profesional.SelectedValue = datosProfesional.prof_id.ToString();
                        txt_codigoDatProf.Text = datosProfesional.DatProfeInicial_cod.ToString();
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

                datosestempresausu = CN_Inicial.obtenerDatEstEmpreUsuar(perso);
                motconini = CN_Inicial.obtenerMotivoConsultaInicial(perso);
                antper = CN_Inicial.obtenerAntecedentesPersonalesInicial(perso);
                emplant = CN_Inicial.obtenerEmpAntexPer(perso);
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
                datosProfesional = CN_Inicial.obtenerDatosProfesionalxPer(perso);

                if (per != null || datosestempresausu != null || motconini != null || antper != null || emplant != null || 
                    AnteFamiDetParentesco != null || facriesgotractual != null || 
                    actvextralaboral != null || enferactualinicial != null || revisionactualorganossistemas != null ||
                    examfisregional != null || exagenesperiespues != null || diagnostico != null || aptitudmedica != null || 
                    tratamientoinicial != null || datosProfesional != null)
                {
                    ModificarHistorial(per, emplant, antper, facriesgotractual, actvextralaboral,
                        exagenesperiespues, diagnostico, aptitudmedica);
                }

            }
        }               

        private void GuardarHistorial()
        {
            try
            {
                per = CN_HistorialMedico.obtenerIdPersonasxCedula(Convert.ToInt32(txt_numHClinica.Text));

                int perso = Convert.ToInt32(per.Per_id.ToString());

                // A
                datosestempresausu = new Tbl_DatEstableEmpUsu();
                // B
                motconini = new Tbl_MotivoConsultaInicial();
                // C
                antper = new Tbl_AntecedentesPersonalesInicial();
                // D
                emplant = new Tbl_AntecedentesEmplAnteriores();
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
                //datosestempresausu.datEstable_catolicaRel = txt_catolica.Text;
                //datosestempresausu.datEstable_evangelicaRel = txt_evangelica.Text;
                //datosestempresausu.datEstable_testJehovaRel = txt_testigo.Text;
                //datosestempresausu.datEstable_mormonaRel = txt_mormona.Text;
                //datosestempresausu.datEstable_otrasRel = txt_otrareligion.Text;
                datosestempresausu.datEstable_groSanguineo = txt_gruposanguineo.Text;
                datosestempresausu.datEstable_lateralidad = txt_lateralidad.Text;
                //datosestempresausu.datEstable__lesbianaOriSex = txt_lesbiana.Text;
                //datosestempresausu.datEstable_gayOriSex = txt_gay.Text;
                //datosestempresausu.datEstable_bisexualOriSex = txt_bisexual.Text;
                //datosestempresausu.datEstable_heterosexualOriSex = txt_heterosexual.Text;
                //datosestempresausu.datEstable_norespondeOriSex = txt_noRespondeOriSex.Text;
                //datosestempresausu.datEstable_femeninoIdenGen = txt_femenino.Text;
                //datosestempresausu.datEstable_masculinoIdenGen = txt_masculino.Text;
                //datosestempresausu.datEstable_transFemeninoIdenGen = txt_transfemenino.Text;
                //datosestempresausu.datEstable_transMasculinoIdenGen = txt_transmasculino.Text;
                //datosestempresausu.datEstable_norespondeIdenGen = txt_noRespondeIdeGen.Text;
                //datosestempresausu.datEstable_siDis = txt_sidiscapacidad.Text;
                //datosestempresausu.datEstable_noDis = txt_nodiscapacidad.Text;
                datosestempresausu.datEstable_tipoDis = txt_tipodiscapacidad.Text;
                datosestempresausu.datEstable_porcentDis = Convert.ToInt32(txt_porcentajediscapacidad.Text);
                datosestempresausu.datEstable_actRelevantesTrabOcupar = txt_actividadesrelevantes.Text;
                datosestempresausu.Per_id = perso;

                // B. Captura de datos Motivo de Consulta
                motconini.motConIni_descrip = txt_motivoconsultainicial.Text;
                motconini.Per_id = perso;

                //C. Captura de datos tbl_AntecedentesCliQuiru(
                antper.antPerInicial_descripcion = txt_antCliQuiDescripcion.Text;
                antper.antPerInicial_menarquia = txt_menarquiaAntGinObste.Text;
                antper.antPerInicial_ciclos = txt_ciclosAntGinObste.Text;
                antper.antPerInicial_fechUltiMenstrua = Convert.ToDateTime(txt_fechUltiMensAntGinObste.Text);
                antper.antPerInicial_gestas = txt_gestasAntGinObste.Text;
                antper.antPerInicial_partos = txt_partosAntGinObste.Text;
                antper.antPerInicial_cesareas = txt_cesareasAntGinObste.Text;
                antper.antPerInicial_abortos = txt_abortosAntGinObste.Text;
                antper.antPerInicial_vivosHij = Convert.ToInt32(txt_vivosAntGinObste.Text);
                antper.antPerInicial_muertosHij = Convert.ToInt32(txt_muertosAntGinObste.Text);
                //antper.antPerInicial_siVidaSexActiva = txt_siVidSexAntGinObste.Text;
                //antper.antPerInicial_noVidaSexActiva = txt_noVidSexAntGinObste.Text;
                //antper.antPerInicial_siMetPlanifiFamiliar = txt_siMetPlaniAntGinObste.Text;
                //antper.antPerInicial_noMetPlanifiFamiliar = txt_noMetPlaniAntGinObste.Text;
                antper.antPerInicial_tipoMetPlanifiFamiliar = txt_tipoMetPlaniAntGinObste.Text;
                //antper.antPerInicial_siExaRealiPapanicolaou = txt_siPapaniAntGinObste.Text;
                //antper.antPerInicial_noExaRealiPapanicolaou = txt_noPapaniAntGinObste.Text;
                antper.antPerInicial_tiempoExaRealiPapanicolaou = Convert.ToInt32(txt_tiempoPapaniAntGinObste.Text);
                antper.antPerInicial_resultadoExaRealiPapanicolaou = txt_resultadoPapaniAntGinObste.Text;
                //antper.antPerInicial_siExaRealiEcoMamario = txt_siEcoMamaAntGinObste.Text;
                //antper.antPerInicial_noExaRealiEcoMamario = txt_noEcoMamaAntGinObste.Text;
                antper.antPerInicial_tiempoExaRealiEcoMamario = Convert.ToInt32(txt_tiempoEcoMamaAntGinObste.Text);
                antper.antPerInicial_resultadoExaRealiEcoMamario = txt_resultadoEcoMamaAntGinObste.Text;
                //antper.antPerInicial_siExaRealiColposcopia = txt_siColposAntGinObste.Text;
                //antper.antPerInicial_noExaRealiColposcopia = txt_noColposAntGinObste.Text;
                antper.antPerInicial_tiempoExaRealiColposcopia = Convert.ToInt32(txt_tiempoColposAntGinObste.Text);
                antper.antPerInicial_resultadoExaRealiColposcopia = txt_resultadoColposAntGinObste.Text;
                //antper.antPerInicial_siExaRealiMamografia = txt_siMamograAntGinObste.Text;
                //antper.antPerInicial_noExaRealiMamografia = txt_noMamograAntGinObste.Text;
                antper.antPerInicial_tiempoExaRealiMamografia = Convert.ToInt32(txt_tiempoMamograAntGinObste.Text);
                antper.antPerInicial_resultadoExaRealiMamografia = txt_resultadoMamograAntGinObste.Text;
                //antper.antPerInicial_siExaRealiAntiProstatico = txt_siExaRealiAntProstaAntReproMascu.Text;
                //antper.antPerInicial_noExaRealiAntiProstatico = txt_noExaRealiAntProstaAntReproMascu.Text;
                antper.antPerInicial_tiempoExaRealiAntiProstatico = Convert.ToInt32(txt_tiempoExaRealiAntProstaAntReproMascu.Text);
                antper.antPerInicial_resultadoExaRealiAntiProstatico = txt_resultadoExaRealiAntProstaAntReproMascu.Text;
                //antper.antPerInicial_siMetPlanifiFamiAntReproMascu = txt_siMetPlaniAntReproMascu.Text;
                //antper.antPerInicial_noMetPlanifiFamiAntReproMascu = txt_noMetPlaniAntReproMascu.Text;
                antper.antPerInicial_tipo1MetPlanifiFamiAntReproMascu = txt_tipo1MetPlaniAntReproMascu.Text;
                antper.antPerInicial_vivosHijAntReproMascu = Convert.ToInt32(txt_vivosHijosAntReproMascu.Text);
                antper.antPerInicial_muertosHijAntReproMascu = Convert.ToInt32(txt_muertosHijosAntReproMascu.Text);
                //antper.antPerInicial_siExaRealiEcoProstatico = txt_siExaRealiEcoProstaAntReproMascu.Text;
                //antper.antPerInicial_noExaRealiEcoProstatico = txt_noExaRealiEcoProstaAntReproMascu.Text;
                antper.antPerInicial_tiempoExaRealiEcoProstatico = Convert.ToInt32(txt_tiempoExaRealiEcoProstaAntReproMascu.Text);
                antper.antPerInicial_resultadoExaRealiEcoProstatico = txt_resultadoExaRealiEcoProstaAntReproMascu.Text;
                antper.antPerInicial_tipo2MetPlanifiFamiAntReproMascu = txt_tipo2MetPlaniAntReproMascu.Text;
                //antper.antPerInicial_siConsuNocivosTabaco = txt_siConsuNociTabaHabToxi.Text;
                //antper.antPerInicial_noConsuNocivosTabaco = txt_noConsuNociTabaHabToxi.Text;
                antper.antPerInicial_tiempoConsuConsuNocivosTabaco = Convert.ToInt32(txt_tiemConConsuNociTabaHabToxi.Text);
                antper.antPerInicial_cantidadConsuNocivosTabaco = txt_cantiConsuNociTabaHabToxi.Text;
                antper.antPerInicial_exConsumiConsuNocivosTabaco = txt_exConsumiConsuNociTabaHabToxi.Text;
                antper.antPerInicial_tiempoAbstiConsuNocivosTabaco = Convert.ToInt32(txt_tiemAbstiConsuNociTabaHabToxi.Text);
                //antper.antPerInicial_siConsuNocivosAlcohol = txt_siConsuNociAlcoHabToxi.Text;
                //antper.antPerInicial_noConsuNocivosAlcohol = txt_noConsuNociAlcoHabToxi.Text;
                antper.antPerInicial_tiempoConsuConsuNocivosAlcohol = Convert.ToInt32(txt_tiemConConsuNociAlcoHabToxi.Text);
                antper.antPerInicial_cantidadConsuNocivosAlcohol = txt_cantiConsuNociAlcoHabToxi.Text;
                antper.antPerInicial_exConsumiConsuNocivosAlcohol = txt_exConsumiConsuNociAlcoHabToxi.Text;
                antper.antPerInicial_tiempoAbstiConsuNocivosAlcohol = Convert.ToInt32(txt_tiemAbstiConsuNociAlcoHabToxi.Text);
                //antper.antPerInicial_siConsuNocivosOtrasDrogas = txt_siConsuNociOtrasDroHabToxi.Text;
                //antper.antPerInicial_noConsuNocivosOtrasDrogas = txt_noConsuNociOtrasDroHabToxi.Text;
                antper.antPerInicial_tiempoConsu1ConsuNocivosOtrasDrogas = Convert.ToInt32(txt_tiemCon1ConsuNociOtrasDroHabToxi.Text);
                antper.antPerInicial_cantidad1ConsuNocivosOtrasDrogas = txt_canti1ConsuNociOtrasDroHabToxi.Text;
                antper.antPerInicial_exConsumi1ConsuNocivosOtrasDrogas = txt_exConsumi1ConsuNociOtrasDroHabToxi.Text;
                antper.antPerInicial_tiempoAbsti1ConsuNocivosOtrasDrogas = Convert.ToInt32(txt_tiemAbsti1ConsuNociOtrasDroHabToxi.Text);
                antper.antPerInicial_otrasConsuNocivos = txt_otrasConsuNociOtrasDroHabToxi.Text;
                antper.antPerInicial_tiempoConsu2ConsuNocivosOtrasDrogas = Convert.ToInt32(txt_tiemCon2ConsuNociOtrasDroHabToxi.Text);
                antper.antPerInicial_cantidad2ConsuNocivosOtrasDrogas = txt_canti2ConsuNociOtrasDroHabToxi.Text;
                antper.antPerInicial_exConsumi2ConsuNocivosOtrasDrogas = txt_exConsumi2ConsuNociOtrasDroHabToxi.Text;
                antper.antPerInicial_tiempoAbsti2ConsuNocivosOtrasDrogas = Convert.ToInt32(txt_tiemAbsti2ConsuNociOtrasDroHabToxi.Text);
                //antper.antPerInicial_siEstiVidaActFisica = txt_siEstVidaActFisiEstVida.Text;
                //antper.antPerInicial_noEstiVidaActFisica = txt_noEstVidaActFisiEstVida.Text;
                antper.antPerInicial_cualEstiVidaActFisica = txt_cualEstVidaActFisiEstVida.Text;
                antper.antPerInicial_tiem_cantEstiVidaActFisica = txt_tiemCanEstVidaActFisiEstVida.Text;
                //antper.antPerInicial_siEstiVidaMediHabitual = txt_siEstVidaMedHabiEstVida.Text;
                //antper.antPerInicial_noEstiVidaMediHabitual = txt_noEstVidaMedHabiEstVida.Text;
                antper.antPerInicial_cual1EstiVidaMediHabitual = txt_cual1EstVidaMedHabiEstVida.Text;
                antper.antPerInicial_tiem_cant1EstiVidaMediHabitual = txt_tiemCan1EstVidaMedHabiEstVida.Text;
                antper.antPerInicial_cual2EstiVidaMediHabitual = txt_cual2EstVidaMedHabiEstVida.Text;
                antper.antPerInicial_tiem_cant2EstiVidaMediHabitual = txt_tiemCan2EstVidaMedHabiEstVida.Text;
                antper.antPerInicial_cual3EstiVidaMediHabitual = txt_cual3EstVidaMedHabiEstVida.Text;
                antper.antPerInicial_tiem_cant3EstiVidaMediHabitual = txt_tiemCan3EstVidaMedHabiEstVida.Text;
                antper.Per_id = perso;

                //D. Captura de Datos Tbl_AntecedentesEmplAnteriores 
                emplant.AntTrabajoInicial_nomEmpresa = txt_empresa.Text;
                emplant.AntTrabajoInicial_puestoTrabajo = txt_puestotrabajo.Text;
                emplant.AntTrabajoInicial_actDesemp = txt_actdesempeña.Text;
                emplant.AntTrabajoInicial_tiemTrabajo = txt_tiempotrabajo.Text;
                //emplant.AntTrabajoInicial_fisicoRies = txt_fisico.Text;
                //emplant.AntTrabajoInicial_mecanicoRies = txt_mecanico.Text;
                //emplant.AntTrabajoInicial_quimicoRies = txt_quimico.Text;
                //emplant.AntTrabajoInicial_biologicoRies = txt_biologico.Text;
                //emplant.AntTrabajoInicial_ergonomicoRies = txt_ergonomico.Text;
                //emplant.AntTrabajoInicial_psicosocial = txt_psicosocial.Text;
                emplant.AntTrabajoInicial_observaciones = txt_obseantempleanteriores.Text;
                //emplant.AntTrabajoInicial_siCalificadoIESSAcciTrabajo = txt_si.Text;
                emplant.AntTrabajoInicial_especificarCalificadoIESSAcciTrabajo = txt_especificar.Text;
                //emplant.AntTrabajoInicial_noCalificadoIESSAcciTrabajo = txt_no.Text;
                emplant.AntTrabajoInicial_fechaCalificadoIESSAcciTrabajo = Convert.ToDateTime(txt_fecha.Text);
                emplant.AntTrabajoInicial_obserAcciTrabajo = txt_observaciones2.Text;
                //emplant.AntTrabajoInicial_siCalificadoIESSEnfProfesionales = txt_siprofesional.Text;
                emplant.AntTrabajoInicial_especificarCalificadoIESSEnfProfesionales = txt_espeprofesional.Text;
                //emplant.AntTrabajoInicial_noCalificadoIESSEnfProfesionales = txt_noprofesional.Text;
                emplant.AntTrabajoInicial_fechaCalificadoIESSEnfProfesionales = Convert.ToDateTime(txt_fechaprofesional.Text);
                emplant.Per_id = perso;

                //E. Captura de Datos ANTECEDENTES FAMILIARES (DETALLAR EL PARENTESCO)
                //AnteFamiDetParentesco.AntFamDetPare_enfCarVas = txt_enfermedadcardiovascular.Text;
                //AnteFamiDetParentesco.AntFamDetPare_enfMeta = txt_enfermedadmetabolica.Text;
                //AnteFamiDetParentesco.AntFamDetPare_enfNeuro = txt_enfermedadneurologica.Text;
                //AnteFamiDetParentesco.AntFamDetPare_enfOnco = txt_enfermedadoncologica.Text;
                //AnteFamiDetParentesco.AntFamDetPare_enfInfe = txt_enfermedadinfecciosa.Text;
                //AnteFamiDetParentesco.AntFamDetPare_enfHereConge = txt_enfermedadhereditaria.Text;
                //AnteFamiDetParentesco.AntFamDetPare_discapa = txt_discapacidades.Text;
                //AnteFamiDetParentesco.AntFamDetPare_otros = txt_otrosenfer.Text;
                AnteFamiDetParentesco.AntFamDetPare_descripcion = txt_descripcionantefamiliares.Text;
                AnteFamiDetParentesco.Per_id = perso;

                //F. Captura de Datos Tbl_FacRiesTrabAct
                facriesgotractual.FacRiesTrabAct_area = txt_puestodetrabajo.Text;
                facriesgotractual.FacRiesTrabAct_actividades = txt_act.Text;
                facriesgotractual.FacRiesTrabAct_temAltasFis = txt_tempaltas.Text;
                facriesgotractual.FacRiesTrabAct_temBajasFis = txt_tempbajas.Text;
                facriesgotractual.FacRiesTrabAct_radIonizanteFis = txt_radiacion.Text;
                facriesgotractual.FacRiesTrabAct_radNoIonizanteFis = txt_noradiacion.Text;
                facriesgotractual.FacRiesTrabAct_ruidoFis = txt_ruido.Text;
                facriesgotractual.FacRiesTrabAct_vibracionFis = txt_vibracion.Text;
                facriesgotractual.FacRiesTrabAct_iluminacionFis = txt_iluminacion.Text;
                facriesgotractual.FacRiesTrabAct_ventilacionFis = txt_ventilacion.Text;
                facriesgotractual.FacRiesTrabAct_fluElectricoFis = txt_fluidoelectrico.Text;
                facriesgotractual.FacRiesTrabAct_otrosFis = txt_otrosFisico.Text;
                facriesgotractual.FacRiesTrabAct_atraMaquinasMec = txt_atrapmaquinas.Text;
                facriesgotractual.FacRiesTrabAct_atraSuperfiiesMec = txt_atrapsuperficie.Text;
                facriesgotractual.FacRiesTrabAct_atraObjetosMec = txt_atrapobjetos.Text;
                facriesgotractual.FacRiesTrabAct_caidaObjetosMec = txt_caidaobjetos.Text;
                facriesgotractual.FacRiesTrabAct_caidaMisNivelMec = txt_caidamisnivel.Text;
                facriesgotractual.FacRiesTrabAct_caidaDifNivelMec = txt_caidadifnivel.Text;
                facriesgotractual.FacRiesTrabAct_contactoElecMec = txt_contaelectrico.Text;
                facriesgotractual.FacRiesTrabAct_conSuperTrabaMec = txt_contasuptrabajo.Text;
                facriesgotractual.FacRiesTrabAct_proPartiFragMec = txt_proyparticulas.Text;
                facriesgotractual.FacRiesTrabAct_proFluidosMec = txt_proyefluidos.Text;
                facriesgotractual.FacRiesTrabAct_pinchazosMec = txt_pinchazos.Text;
                facriesgotractual.FacRiesTrabAct_cortesMec = txt_cortes.Text;
                facriesgotractual.FacRiesTrabAct_atropeVehiMec = txt_atroporvehiculos.Text;
                facriesgotractual.FacRiesTrabAct_coliVehiMec = txt_choques.Text;
                facriesgotractual.FacRiesTrabAct_otrosMec = txt_otrosMecanico.Text;
                facriesgotractual.FacRiesTrabAct_solidosQui = txt_solidos.Text;
                facriesgotractual.FacRiesTrabAct_polvosQui = txt_polvos.Text;
                facriesgotractual.FacRiesTrabAct_humosQui = txt_humos.Text;
                facriesgotractual.FacRiesTrabAct_liquidosQui = txt_liquidos.Text;
                facriesgotractual.FacRiesTrabAct_vaporesQui = txt_vapores.Text;
                facriesgotractual.FacRiesTrabAct_aerosolesQui = txt_aerosoles.Text;
                facriesgotractual.FacRiesTrabAct_neblinasQui = txt_neblinas.Text;
                facriesgotractual.FacRiesTrabAct_gaseososQui = txt_gaseosos.Text;
                facriesgotractual.FacRiesTrabAct_otrosBio = txt_otrosQuimico.Text;
                facriesgotractual.FacRiesTrabAct_virusBio = txt_virus.Text;
                facriesgotractual.FacRiesTrabAct_hongosBio = txt_hongos.Text;
                facriesgotractual.FacRiesTrabAct_bacteriasBio = txt_bacterias.Text;
                facriesgotractual.FacRiesTrabAct_parasitosBio = txt_parasitos.Text;
                facriesgotractual.FacRiesTrabAct_expVectBio = txt_expoavectores.Text;
                facriesgotractual.FacRiesTrabAct_expAniSelvaBio = txt_expoanimselvaticos.Text;
                facriesgotractual.FacRiesTrabAct_otrosBio = txt_otrosBiologico.Text;
                facriesgotractual.FacRiesTrabAct_maneManCarErg = txt_manmanualcargas.Text;
                facriesgotractual.FacRiesTrabAct_movRepeErg = txt_movrepetitivo.Text;
                facriesgotractual.FacRiesTrabAct_posForzaErg = txt_postforzadas.Text;
                facriesgotractual.FacRiesTrabAct_trabPvdErg = txt_trabajopvd.Text;
                facriesgotractual.FacRiesTrabAct_otrosErg = txt_otrosErgonomico.Text;
                facriesgotractual.FacRiesTrabAct_monoTrabPsi = txt_montrabajo.Text;
                facriesgotractual.FacRiesTrabAct_sobrecarLabPsi = txt_sobrecargalaboral.Text;
                facriesgotractual.FacRiesTrabAct_minuTareaPsi = txt_minustarea.Text;
                facriesgotractual.FacRiesTrabAct_altaResponPsi = txt_altarespon.Text;
                facriesgotractual.FacRiesTrabAct_autoTomaDesiPsi = txt_automadesiciones.Text;
                facriesgotractual.FacRiesTrabAct_supEstDirecDefiPsi = txt_supyestdireficiente.Text;
                facriesgotractual.FacRiesTrabAct_conflicRolPsi = txt_conflictorol.Text;
                facriesgotractual.FacRiesTrabAct_falClariFunPsi = txt_faltaclarfunciones.Text;
                facriesgotractual.FacRiesTrabAct_incoDistriTrabPsi = txt_incorrdistrabajo.Text;
                facriesgotractual.FacRiesTrabAct_turnosRotaPsi = txt_turnorotat.Text;
                facriesgotractual.FacRiesTrabAct_relInterperPsi = txt_relacinterpersonales.Text;
                facriesgotractual.FacRiesTrabAct_inesLabPsi = txt_inestalaboral.Text;
                facriesgotractual.FacRiesTrabAct_otrosPsi = txt_otrosErgonomico.Text;
                facriesgotractual.FacRiesTrabAct_medPreventivas = txt_medpreventivas.Text;
                facriesgotractual.Per_id = perso;

                //G. Captura de Datos Tbl_ActividadesExtraLaborales
                actvextralaboral.ActExtLab_descrip = txt_descrextralaborales.Text;
                actvextralaboral.Per_id = perso;

                //H. Captura de Datos Enfermedad Actual
                enferactualinicial.enfActual_descrip = txt_enfermedadactualinicial.Text;
                enferactualinicial.Per_id = perso;

                //I. Captura de Datos REVISIÓN ACTUAL DE ÓRGANOS Y SISTEMAS
                //revisionactualorganossistemas.RevActOrgSis_pielAnexos = txt_pielanexos.Text;
                //revisionactualorganossistemas.RevActOrgSis_orgSentidos = txt_organossentidos.Text;
                //revisionactualorganossistemas.RevActOrgSis_respiratorio = txt_respiratorio.Text;
                //revisionactualorganossistemas.RevActOrgSis_cardVascular = txt_cardiovascular.Text;
                //revisionactualorganossistemas.RevActOrgSis_digestivo = txt_digestivo.Text;
                //revisionactualorganossistemas.RevActOrgSis_genUrinario = txt_genitourinario.Text;
                //revisionactualorganossistemas.RevActOrgSis_muscEsqueletico = txt_musculosesqueleticos.Text;
                //revisionactualorganossistemas.RevActOrgSis_endocrino = txt_endocrino.Text;
                //revisionactualorganossistemas.RevActOrgSis_hemoLimfa = txt_hemolinfatico.Text;
                //revisionactualorganossistemas.RevActOrgSis_nervioso = txt_nervioso.Text;
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
                diagnostico.Diag_cie = txt_cie.Text;
                //diagnostico.Diag_pre = txt_pre.Text;
                //diagnostico.Diag_def = txt_def.Text;
                diagnostico.Per_id = perso;

                //N.Captura de Datos Tbl_AptitudMedica
                //aptitudmedica.AptMed_apto = txt_apto.Text;
                //aptitudmedica.AptMed_aptoObserva = txt_aptoobservacion.Text;
                //aptitudmedica.AptMed_aptoLimi = txt_aptolimitacion.Text;
                //aptitudmedica.AptMed_NoApto = txt_noapto.Text;
                aptitudmedica.AptMed_Observ = txt_observacionaptitud.Text;
                aptitudmedica.AptMed_Limit = txt_limitacionaptitud.Text;
                aptitudmedica.Per_id = perso;

                //O. Captura de Datos Recomendaciones y/o Tratamiento
                tratamientoinicial.trataInicial_descrip = txt_descripciontratamiento.Text;
                tratamientoinicial.Per_id = perso;

                //P
                datosProfesional.DatProfeInicial_fecha_hora = Convert.ToDateTime(txt_fechaDatProf.Text);
                datosProfesional.prof_id = Convert.ToInt32(ddl_profesional.SelectedValue);
                datosProfesional.DatProfeInicial_cod = txt_codigoDatProf.Text;
                datosProfesional.Per_id = perso;

                //A . Método para guardar Datos Establecimeinto Empresa Usuarios
                CN_Inicial.guardarDatosEstablecimientoEmpresaUsuario(datosestempresausu);
                //B . Método para guardar Datos Motivo Consulta
                CN_Inicial.guardarMotivoConsultaInicial(motconini);
                //C . Método para guardar Datos Antecedentes Personales
                CN_Inicial.guardarAntPersonales(antper);
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
                //P. Método de guardar Datos del Profesional
                CN_Inicial.guardarDatosProfesional(datosProfesional);

                //Mensaje de confirmacion
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Guardados Exitosamente')", true);

                Response.Redirect("~/Template/Views/PacientesInicial.aspx");
                limpiar();
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Guardados Correctamente')", true);
            }

        }

        private void ModificarHistorial(Tbl_Personas per, Tbl_AntecedentesEmplAnteriores emplant, Tbl_AntecedentesPersonalesInicial antper, 
            Tbl_FacRiesTrabAct facriesgotractual, Tbl_ActividadesExtraLaborales actvextralaboral, Tbl_ResExaGenEspRiesTrabajo exagenesperiespues, 
            Tbl_Diagnostico diagnostico, Tbl_AptitudMedica aptitudmedica)
        {

            try
            {
                //antcliqui = new Tbl_AntecedentesCliQuiru();
                emplant = new Tbl_AntecedentesEmplAnteriores();
                facriesgotractual = new Tbl_FacRiesTrabAct();
                actvextralaboral = new Tbl_ActividadesExtraLaborales();
                exagenesperiespues = new Tbl_ResExaGenEspRiesTrabajo();
                diagnostico = new Tbl_Diagnostico();
                aptitudmedica = new Tbl_AptitudMedica();

                //captura de datos tbl_motivoconsulta
                //antcliqui.AntCliQuiru_descripcion = txt_antCliQuiDescripcion.Text;

                //captura de datos Tbl_AntecedentesEmplAnteriores 
                emplant.AntTrabajoInicial_nomEmpresa = txt_empresa.Text;
                emplant.AntTrabajoInicial_puestoTrabajo = txt_puestotrabajo.Text;
                emplant.AntTrabajoInicial_actDesemp = txt_actdesempeña.Text;
                emplant.AntTrabajoInicial_tiemTrabajo = txt_tiempotrabajo.Text;
                //emplant.AntTrabajoInicial_fisicoRies = txt_fisico.Text;
                //emplant.AntTrabajoInicial_mecanicoRies = txt_mecanico.Text;
                //emplant.AntTrabajoInicial_quimicoRies = txt_quimico.Text;
                //emplant.AntTrabajoInicial_biologicoRies = txt_biologico.Text;
                //emplant.AntTrabajoInicial_ergonomicoRies = txt_ergonomico.Text;
                //emplant.AntTrabajoInicial_psicosocial = txt_psicosocial.Text;
                emplant.AntTrabajoInicial_observaciones = txt_obseantempleanteriores.Text;

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
                diagnostico.Diag_cie = txt_cie.Text;
                //diagnostico.Diag_pre = txt_pre.Text;
                //diagnostico.Diag_def = txt_def.Text;

                //captura de datos Tbl_AptitudMedica
                //aptitudmedica.AptMed_apto = txt_apto.Text;
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
            //txt_antCliQuiDescripcion.Text = "";
            //txt_empresa.Text = txt_puestotrabajo.Text = txt_actdesempeña.Text = txt_tiempotrabajo.Text = txt_fisico.Text = txt_mecanico.Text=
            //txt_quimico.Text = txt_biologico.Text = txt_ergonomico.Text = txt_psicosocial.Text = txt_obseantempleanteriores.Text = txt_si.Text =
            //txt_especificar.Text = txt_no.Text = txt_fecha.Text = txt_observaciones2.Text = txt_siprofesional.Text = txt_espeprofesional.Text =
            //txt_noprofesional.Text = txt_fechaprofesional.Text = txt_observaciones3.Text = txt_puestodetrabajo.Text = txt_act.Text = 
            //txt_tempaltas.Text = txt_atrapmaquinas.Text = txt_solidos.Text = txt_puestodetrabajo2.Text = txt_act2.Text = txt_virus.Text = 
            //txt_manmanualcargas.Text = txt_montrabajo.Text = txt_medpreventivas.Text = txt_descrextralaborales.Text = txt_examen.Text = 
            //txt_fechaexamen.Text = txt_resultadoexamen.Text = txt_observacionexamen.Text = txt_descripdiagnostico.Text = txt_pre.Text = 
            //txt_def.Text = txt_apto.Text = txt_observacionaptitud.Text = txt_limitacionaptitud.Text = "";

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