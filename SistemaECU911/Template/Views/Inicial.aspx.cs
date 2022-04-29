using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaNegocio;

namespace SistemaECU911.Template.Views
{
	public partial class Inicial : System.Web.UI.Page
	{

		private readonly DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        private Tbl_Personas per = new Tbl_Personas();
        private Tbl_Inicial inicial = new Tbl_Inicial();
       

        protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                if (Request["cod"] != null)
                {
                    int codigo = Convert.ToInt32(Request["cod"]);
                    inicial = CN_Inicial.ObtenerInicialPorId(codigo);
                    int personasid = Convert.ToInt32(inicial.Per_id.ToString());
                    per = CN_HistorialMedico.ObtenerPersonasxId(personasid);

                    btn_guardar.Text = "Actualizar";

                    if (per != null)
                    {
                        txt_priNombre.Text = per.Per_priNombre.ToString();
                        txt_segNombre.Text = per.Per_segNombre.ToString();
                        txt_priApellido.Text = per.Per_priApellido.ToString();
                        txt_segApellido.Text = per.Per_segApellido.ToString();
                        txt_sexo.Text = per.Per_genero.ToString();
                        txt_numHClinica.Text = per.Per_cedula.ToString();
                        txt_fechaingresotrabajo.Text = per.Per_fechInicioTrabajo.ToString();
                        txt_puestodetrabajo.Text = per.Per_puestoTrabajo.ToString();
                        txt_areadetrabajo.Text = per.Per_areaTrabajo.ToString();

                        if (inicial != null)
                        {
                            //A
                            txt_numArchivo.Text = inicial.inicial_numArchivo.ToString();
                            txt_edad.Text = inicial.inicial_edad.ToString();
                            //txt_catolica.Text = inicial.inicial_catolicaRel.ToString();
                            //txt_evangelica.Text = inicial.inicial_evangelicaRel.ToString();
                            //txt_testigo.Text = inicial.inicial_testJehovaRel.ToString();
                            //txt_mormona.Text = inicial.inicial_mormonaRel.ToString();
                            //txt_otrareligion.Text = inicial.inicial_otrasRel.ToString();
                            txt_gruposanguineo.Text = inicial.inicial_groSanguineo.ToString();
                            txt_lateralidad.Text = inicial.inicial_lateralidad.ToString();
                            //txt_lesbiana.Text = inicial.inicial__lesbianaOriSex.ToString();
                            //txt_gay.Text = inicial.inicial_gayOriSex.ToString();
                            //txt_bisexual.Text = inicial.inicial_bisexualOriSex.ToString();
                            //txt_heterosexual.Text = inicial.inicial_heterosexualOriSex.ToString();
                            //txt_noRespondeOriSex.Text = inicial.inicial_norespondeOriSex.ToString();
                            //txt_femenino.Text = inicial.inicial_femeninoIdenGen.ToString();
                            //txt_masculino.Text = inicial.inicial_masculinoIdenGen.ToString();
                            //txt_transfemenino.Text = inicial.inicial_transFemeninoIdenGen.ToString();
                            //txt_transmasculino.Text = inicial.inicial_transMasculinoIdenGen.ToString();
                            //txt_noRespondeIdeGen.Text = inicial.inicial_norespondeIdenGen.ToString();
                            //txt_sidiscapacidad.Text = inicial.inicial_siDis.ToString();
                            //txt_nodiscapacidad.Text = inicial.inicial_noDis.ToString();
                            txt_tipodiscapacidad.Text = inicial.inicial_tipoDis.ToString();
                            txt_porcentajediscapacidad.Text = inicial.inicial_porcentDis.ToString();
                            txt_actividadesrelevantes.Text = inicial.inicial_actRelePuesTrabajo.ToString();

                            //B
                            txt_motivoconsultainicial.Text = inicial.inicial_descripcionMotivoConsulta.ToString();

                            //C
                            txt_antCliQuiDescripcion.Text = inicial.inicial_descripcionAnteceCliniQuirur.ToString();
                            txt_menarquiaAntGinObste.Text = inicial.inicial_menarquia.ToString();
                            txt_ciclosAntGinObste.Text = inicial.inicial_ciclos.ToString();
                            txt_fechUltiMensAntGinObste.Text = inicial.inicial_fechUltiMenstrua.ToString();
                            txt_gestasAntGinObste.Text = inicial.inicial_gestas.ToString();
                            txt_partosAntGinObste.Text = inicial.inicial_partos.ToString();
                            txt_cesareasAntGinObste.Text = inicial.inicial_cesareas.ToString();
                            txt_abortosAntGinObste.Text = inicial.inicial_abortos.ToString();
                            txt_vivosAntGinObste.Text = inicial.inicial_vivosHij.ToString();
                            txt_muertosAntGinObste.Text = inicial.inicial_muertosHij.ToString();
                            //txt_siVidSexAntGinObste.Text = antper.inicial_siVidaSexActiva.ToString();
                            //txt_noVidSexAntGinObste.Text = antper.inicial_noVidaSexActiva.ToString();
                            //txt_siMetPlaniAntGinObste.Text = antper.inicial_siMetPlanifiFamiliar.ToString();
                            //txt_noMetPlaniAntGinObste.Text = antper.inicial_noMetPlanifiFamiliar.ToString();
                            txt_tipoMetPlaniAntGinObste.Text = inicial.inicial_tipoMetPlanifiFamiliar.ToString();
                            //txt_siPapaniAntGinObste.Text = antper.inicial_siExaRealiPapanicolaou.ToString();
                            //txt_noPapaniAntGinObste.Text = antper.inicial_noExaRealiPapanicolaou.ToString();
                            txt_tiempoPapaniAntGinObste.Text = inicial.inicial_tiempoExaRealiPapanicolaou.ToString();
                            txt_resultadoPapaniAntGinObste.Text = inicial.inicial_resultadoExaRealiPapanicolaou.ToString();
                            //txt_siEcoMamaAntGinObste.Text = antper.inicial_siExaRealiEcoMamario.ToString();
                            //txt_noEcoMamaAntGinObste.Text = antper.inicial_noExaRealiEcoMamario.ToString();
                            txt_tiempoEcoMamaAntGinObste.Text = inicial.inicial_tiempoExaRealiEcoMamario.ToString();
                            txt_resultadoEcoMamaAntGinObste.Text = inicial.inicial_resultadoExaRealiEcoMamario.ToString();
                            //txt_siColposAntGinObste.Text = antper.inicial_siExaRealiColposcopia.ToString();
                            //txt_noColposAntGinObste.Text = antper.inicial_noExaRealiColposcopia.ToString();
                            txt_tiempoColposAntGinObste.Text = inicial.inicial_tiempoExaRealiColposcopia.ToString();
                            txt_resultadoColposAntGinObste.Text = inicial.inicial_resultadoExaRealiColposcopia.ToString();
                            //txt_siMamograAntGinObste.Text = antper.inicial_siExaRealiMamografia.ToString();
                            //txt_noMamograAntGinObste.Text = antper.inicial_noExaRealiMamografia.ToString();
                            txt_tiempoMamograAntGinObste.Text = inicial.inicial_tiempoExaRealiMamografia.ToString();
                            txt_resultadoMamograAntGinObste.Text = inicial.inicial_resultadoExaRealiMamografia.ToString();
                            //txt_siExaRealiAntProstaAntReproMascu.Text = antper.inicial_siExaRealiAntiProstatico.ToString();
                            //txt_noExaRealiAntProstaAntReproMascu.Text = antper.inicial_noExaRealiAntiProstatico.ToString();
                            txt_tiempoExaRealiAntProstaAntReproMascu.Text = inicial.inicial_tiempoExaRealiAntiProstatico.ToString();
                            txt_resultadoExaRealiAntProstaAntReproMascu.Text = inicial.inicial_resultadoExaRealiAntiProstatico.ToString();
                            //txt_siMetPlaniAntReproMascu.Text = antper.inicial_siMetPlanifiFamiAntReproMascu.ToString();
                            //txt_noMetPlaniAntReproMascu.Text = antper.inicial_noMetPlanifiFamiAntReproMascu.ToString();
                            txt_tipo1MetPlaniAntReproMascu.Text = inicial.inicial_tipo1MetPlanifiFamiAntReproMascu.ToString();
                            txt_vivosHijosAntReproMascu.Text = inicial.inicial_vivosHijAntReproMascu.ToString();
                            txt_muertosHijosAntReproMascu.Text = inicial.inicial_muertosHijAntReproMascu.ToString();
                            //txt_siExaRealiEcoProstaAntReproMascu.Text = antper.inicial_siExaRealiEcoProstatico.ToString();
                            //txt_noExaRealiEcoProstaAntReproMascu.Text = antper.inicial_noExaRealiEcoProstatico.ToString();
                            txt_tiempoExaRealiEcoProstaAntReproMascu.Text = inicial.inicial_tiempoExaRealiEcoProstatico.ToString();
                            txt_resultadoExaRealiEcoProstaAntReproMascu.Text = inicial.inicial_resultadoExaRealiEcoProstatico.ToString();
                            txt_tipo2MetPlaniAntReproMascu.Text = inicial.inicial_tipo2MetPlanifiFamiAntReproMascu.ToString();
                            //txt_siConsuNociTabaHabToxi.Text = antper.inicial_siConsuNocivosTabaco.ToString();
                            //txt_noConsuNociTabaHabToxi.Text = antper.inicial_noConsuNocivosTabaco.ToString();
                            txt_tiemConConsuNociTabaHabToxi.Text = inicial.inicial_tiempoConsuConsuNocivosTabaco.ToString();
                            txt_cantiConsuNociTabaHabToxi.Text = inicial.inicial_cantidadConsuNocivosTabaco.ToString();
                            txt_exConsumiConsuNociTabaHabToxi.Text = inicial.inicial_exConsumiConsuNocivosTabaco.ToString();
                            txt_tiemAbstiConsuNociTabaHabToxi.Text = inicial.inicial_tiempoAbstiConsuNocivosTabaco.ToString();
                            //txt_siConsuNociAlcoHabToxi.Text = antper.inicial_siConsuNocivosAlcohol.ToString();
                            //txt_noConsuNociAlcoHabToxi.Text = antper.inicial_noConsuNocivosAlcohol.ToString();
                            txt_tiemConConsuNociAlcoHabToxi.Text = inicial.inicial_tiempoConsuConsuNocivosAlcohol.ToString();
                            txt_cantiConsuNociAlcoHabToxi.Text = inicial.inicial_cantidadConsuNocivosAlcohol.ToString();
                            txt_exConsumiConsuNociAlcoHabToxi.Text = inicial.inicial_exConsumiConsuNocivosAlcohol.ToString();
                            txt_tiemAbstiConsuNociAlcoHabToxi.Text = inicial.inicial_tiempoAbstiConsuNocivosAlcohol.ToString();
                            //txt_siConsuNociOtrasDroHabToxi.Text = antper.inicial_siConsuNocivosOtrasDrogas.ToString();
                            //txt_noConsuNociOtrasDroHabToxi.Text = antper.inicial_noConsuNocivosOtrasDrogas.ToString();
                            txt_tiemCon1ConsuNociOtrasDroHabToxi.Text = inicial.inicial_tiempoConsu1ConsuNocivosOtrasDrogas.ToString();
                            txt_canti1ConsuNociOtrasDroHabToxi.Text = inicial.inicial_cantidad1ConsuNocivosOtrasDrogas.ToString();
                            txt_exConsumi1ConsuNociOtrasDroHabToxi.Text = inicial.inicial_exConsumi1ConsuNocivosOtrasDrogas.ToString();
                            txt_tiemAbsti1ConsuNociOtrasDroHabToxi.Text = inicial.inicial_tiempoAbsti1ConsuNocivosOtrasDrogas.ToString();
                            txt_otrasConsuNociOtrasDroHabToxi.Text = inicial.inicial_otrasConsuNocivos.ToString();
                            txt_tiemCon2ConsuNociOtrasDroHabToxi.Text = inicial.inicial_tiempoConsu2ConsuNocivosOtrasDrogas.ToString();
                            txt_canti2ConsuNociOtrasDroHabToxi.Text = inicial.inicial_cantidad2ConsuNocivosOtrasDrogas.ToString();
                            txt_exConsumi2ConsuNociOtrasDroHabToxi.Text = inicial.inicial_exConsumi2ConsuNocivosOtrasDrogas.ToString();
                            txt_tiemAbsti2ConsuNociOtrasDroHabToxi.Text = inicial.inicial_tiempoAbsti2ConsuNocivosOtrasDrogas.ToString();
                            //txt_siEstVidaActFisiEstVida.Text = antper.inicial_siEstiVidaActFisica.ToString();
                            //txt_noEstVidaActFisiEstVida.Text = antper.inicial_noEstiVidaActFisica.ToString();
                            txt_cualEstVidaActFisiEstVida.Text = inicial.inicial_cualEstiVidaActFisica.ToString();
                            txt_tiemCanEstVidaActFisiEstVida.Text = inicial.inicial_tiem_cantEstiVidaActFisica.ToString();
                            //txt_siEstVidaMedHabiEstVida.Text = antper.inicial_siEstiVidaMediHabitual.ToString();
                            //txt_noEstVidaMedHabiEstVida.Text = antper.inicial_noEstiVidaMediHabitual.ToString();
                            txt_cual1EstVidaMedHabiEstVida.Text = inicial.inicial_cual2EstiVidaMediHabitual.ToString();
                            txt_tiemCan1EstVidaMedHabiEstVida.Text = inicial.inicial_tiem_cant2EstiVidaMediHabitual.ToString();
                            txt_cual2EstVidaMedHabiEstVida.Text = inicial.inicial_cual3EstiVidaMediHabitual.ToString();
                            txt_tiemCan2EstVidaMedHabiEstVida.Text = inicial.inicial_tiem_cant3EstiVidaMediHabitual.ToString();
                            txt_cual3EstVidaMedHabiEstVida.Text = inicial.inicial_cual4EstiVidaMediHabitual.ToString();
                            txt_tiemCan3EstVidaMedHabiEstVida.Text = inicial.inicial_tiem_cant4EstiVidaMediHabitual.ToString();

                            //D
                            txt_empresa.Text = inicial.inicial_nomEmpresa.ToString();
                            txt_puestotrabajo.Text = inicial.inicial_puestoTrabajo.ToString();
                            txt_actdesempeña.Text = inicial.inicial_actDesemp.ToString();
                            txt_tiempotrabajo.Text = inicial.inicial_tiemTrabajo.ToString();
                            //txt_fisico.Text = inicial.inicial_fisicoRies.ToString();
                            //txt_mecanico.Text = inicial.inicial_mecanicoRies.ToString();
                            //txt_quimico.Text = inicial.inicial_quimicoRies.ToString();
                            //txt_biologico.Text = inicial.inicial_biologicoRies.ToString();
                            //txt_ergonomico.Text = inicial.inicial_ergonomicoRies.ToString();
                            //txt_psicosocial.Text = inicial.inicial_psicosocial.ToString();
                            txt_obseantempleanteriores.Text = inicial.inicial_observacionesAnteEmpleAnteriores.ToString();
                            //txt_si.Text = inicial.inicial_siCalificadoIESSAcciTrabajo.ToString();
                            txt_especificar.Text = inicial.inicial_especificarCalificadoIESSAcciTrabajo.ToString();
                            //txt_no.Text = inicial.inicial_noCalificadoIESSAcciTrabajo.ToString();
                            txt_fecha.Text = inicial.inicial_fechaCalificadoIESSAcciTrabajo.ToString();
                            txt_observaciones2.Text = inicial.inicial_obserAcciTrabajo.ToString();
                            //txt_siprofesional.Text = inicial.inicial_siCalificadoIESSEnfProfesionales.ToString();
                            txt_espeprofesional.Text = inicial.inicial_especificarCalificadoIESSEnfProfesionales.ToString();
                            //txt_noprofesional.Text = inicial.inicial_noCalificadoIESSEnfProfesionales.ToString();
                            txt_fechaprofesional.Text = inicial.inicial_fechaCalificadoIESSEnfProfesionales.ToString();

                            //E
                            //txt_enfermedadcardiovascular.Text = inicial.inicial_enfCarVas.ToString();
                            //txt_enfermedadmetabolica.Text = inicial.inicial_enfMeta.ToString();
                            //txt_enfermedadneurologica.Text = inicial.inicial_enfNeuro.ToString();
                            //txt_enfermedadoncologica.Text = inicial.inicial_enfOnco.ToString();
                            //txt_enfermedadinfecciosa.Text = inicial.inicial_enfInfe.ToString();
                            //txt_enfermedadhereditaria.Text = inicial.inicial_enfHereConge.ToString();
                            //txt_discapacidades.Text = inicial.inicial_discapa.ToString();
                            //txt_otrosenfer.Text = inicial.inicial_otros.ToString();
                            txt_descripcionantefamiliares.Text = inicial.inicial_descripcionAnteFamiliares.ToString();

                            //F
                            txt_puestodetrabajo.Text = inicial.inicial_area.ToString();
                            txt_act.Text = inicial.inicial_actividades.ToString();
                            //txt_tempbajas.Text = inicial.inicial_temBajasFis.ToString();
                            //txt_radiacion.Text = inicial.inicial_radIonizanteFis.ToString();
                            //txt_noradiacion.Text = inicial.inicial_radNoIonizanteFis.ToString();
                            //txt_ruido.Text = inicial.inicial_ruidoFis.ToString();
                            //txt_vibracion.Text = inicial.inicial_vibracionFis.ToString();
                            //txt_iluminacion.Text = inicial.inicial_iluminacionFis.ToString();
                            //txt_ventilacion.Text = inicial.inicial_ventilacionFis.ToString();
                            //txt_fluidoelectrico.Text = inicial.inicial_fluElectricoFis.ToString();
                            //txt_otrosFisico.Text = inicial.inicial_otrosFis.ToString();
                            //txt_atrapmaquinas.Text = inicial.inicial_atraMaquinasMec.ToString();
                            //txt_atrapsuperficie.Text = inicial.inicial_atraSuperfiiesMec.ToString();
                            //txt_atrapobjetos.Text = inicial.inicial_atraObjetosMec.ToString();
                            //txt_caidaobjetos.Text = inicial.inicial_caidaObjetosMec.ToString();
                            //txt_caidamisnivel.Text = inicial.inicial_caidaMisNivelMec.ToString();
                            //txt_caidadifnivel.Text = inicial.inicial_caidaDifNivelMec.ToString();
                            //txt_contaelectrico.Text = inicial.inicial_contactoElecMec.ToString();
                            //txt_contasuptrabajo.Text = inicial.inicial_conSuperTrabaMec.ToString();
                            //txt_proyparticulas.Text = inicial.inicial_proPartiFragMec.ToString();
                            //txt_proyefluidos.Text = inicial.inicial_proFluidosMec.ToString();
                            //txt_pinchazos.Text = inicial.inicial_pinchazosMec.ToString();
                            //txt_cortes.Text = inicial.inicial_cortesMec.ToString();
                            //txt_atroporvehiculos.Text = inicial.inicial_atropeVehiMec.ToString();
                            //txt_choques.Text = inicial.inicial_coliVehiMec.ToString();
                            //txt_otrosMecanico.Text = inicial.inicial_otrosMec.ToString();
                            //txt_solidos.Text = inicial.inicial_solidosQui.ToString();
                            //txt_polvos.Text = inicial.inicial_polvosQui.ToString();
                            //txt_humos.Text = inicial.inicial_humosQui.ToString();
                            //txt_liquidos.Text = inicial.inicial_liquidosQui.ToString();
                            //txt_vapores.Text = inicial.inicial_vaporesQui.ToString();
                            //txt_aerosoles.Text = inicial.inicial_aerosolesQui.ToString();
                            //txt_neblinas.Text = inicial.inicial_neblinasQui.ToString();
                            //txt_gaseosos.Text = inicial.inicial_gaseososQui.ToString();
                            //txt_otrosQuimico.Text = inicial.inicial_otrosBio.ToString();
                            //txt_virus.Text = inicial.inicial_virusBio.ToString();
                            //txt_hongos.Text = inicial.inicial_hongosBio.ToString();
                            //txt_bacterias.Text = inicial.inicial_bacteriasBio.ToString();
                            //txt_parasitos.Text = inicial.inicial_parasitosBio.ToString();
                            //txt_expoavectores.Text = inicial.inicial_expVectBio.ToString();
                            //txt_expoanimselvaticos.Text = inicial.inicial_expAniSelvaBio.ToString();
                            //txt_otrosBiologico.Text = inicial.inicial_otrosBio.ToString();
                            //txt_manmanualcargas.Text = inicial.inicial_maneManCarErg.ToString();
                            //txt_movrepetitivo.Text = inicial.inicial_movRepeErg.ToString();
                            //txt_postforzadas.Text = inicial.inicial_posForzaErg.ToString();
                            //txt_trabajopvd.Text = inicial.inicial_trabPvdErg.ToString();
                            //txt_otrosErgonomico.Text = inicial.inicial_otrosErg.ToString();
                            //txt_montrabajo.Text = inicial.inicial_monoTrabPsi.ToString();
                            //txt_sobrecargalaboral.Text = inicial.inicial_sobrecarLabPsi.ToString();
                            //txt_minustarea.Text = inicial.inicial_minuTareaPsi.ToString();
                            //txt_altarespon.Text = inicial.inicial_altaResponPsi.ToString();
                            //txt_automadesiciones.Text = inicial.inicial_autoTomaDesiPsi.ToString();
                            //txt_supyestdireficiente.Text = inicial.inicial_supEstDirecDefiPsi.ToString();
                            //txt_conflictorol.Text = inicial.inicial_conflicRolPsi.ToString();
                            //txt_faltaclarfunciones.Text = inicial.inicial_falClariFunPsi.ToString();
                            //txt_incorrdistrabajo.Text = inicial.inicial_incoDistriTrabPsi.ToString();
                            //txt_turnorotat.Text = inicial.inicial_turnosRotaPsi.ToString();
                            //txt_relacinterpersonales.Text = inicial.inicial_relInterperPsi.ToString();
                            //txt_inestalaboral.Text = inicial.inicial_inesLabPsi.ToString();
                            //txt_otrosPsicosocial.Text = inicial.inicial_otrosPsi.ToString();
                            txt_medpreventivas.Text = inicial.inicial_medPreventivas.ToString();

                            //G
                            txt_descrextralaborales.Text = inicial.inicial_descripActExtLab.ToString();

                            //H
                            txt_enfermedadactualinicial.Text = inicial.inicial_descripEnfActual.ToString();

                            //I
                            //txt_pielanexos.Text = inicial.RevActOrgSis_pielAnexos.ToString();
                            //txt_organossentidos.Text = inicial.RevActOrgSis_orgSentidos.ToString();
                            //txt_respiratorio.Text = inicial.RevActOrgSis_respiratorio.ToString();
                            //txt_cardiovascular.Text = inicial.RevActOrgSis_cardVascular.ToString();
                            //txt_digestivo.Text = inicial.RevActOrgSis_digestivo.ToString();
                            //txt_genitourinario.Text = inicial.RevActOrgSis_genUrinario.ToString();
                            //txt_musculosesqueleticos.Text = inicial.RevActOrgSis_muscEsqueletico.ToString();
                            //txt_endocrino.Text = inicial.RevActOrgSis_endocrino.ToString();
                            //txt_hemolinfatico.Text = inicial.RevActOrgSis_hemoLimfa.ToString();
                            //txt_nervioso.Text = inicial.RevActOrgSis_nervioso.ToString();
                            txt_descrorganosysistemas.Text = inicial.inicial_descripRevActOrgSis.ToString();

                            //K
                            //txt_cicatrices.Text = examfisregional.exaFisRegInicial_cicatricesPiel.ToString();
                            //txt_tatuajes.Text = examfisregional.exaFisRegInicial_tatuajesPiel.ToString();
                            //txt_pielyfaneras.Text = examfisregional.exaFisRegInicial_pielFacerasPiel.ToString();
                            //txt_parpados.Text = examfisregional.exaFisRegInicial_parpadosOjos.ToString();
                            //txt_conjuntivas.Text = examfisregional.exaFisRegInicial_conjuntuvasOjos.ToString();
                            //txt_pupilas.Text = examfisregional.exaFisRegInicial_pupilasOjos.ToString();
                            //txt_cornea.Text = examfisregional.exaFisRegInicial_corneaOjos.ToString();
                            //txt_motilidad.Text = examfisregional.exaFisRegInicial_motilidadOjos.ToString();
                            //txt_auditivoexterno.Text = examfisregional.exaFisRegInicial_cAudiExtreOido.ToString();
                            //txt_pabellon.Text = examfisregional.exaFisRegInicial_pabellonOido.ToString();
                            //txt_timpanos.Text = examfisregional.exaFisRegInicial_timpanosOido.ToString();
                            //txt_labios.Text = examfisregional.exaFisRegInicial_labiosOroFa.ToString();
                            //txt_lengua.Text = examfisregional.exaFisRegInicial_lenguaOroFa.ToString();
                            //txt_faringe.Text = examfisregional.exaFisRegInicial_faringeOroFa.ToString();
                            //txt_amigdalas.Text = examfisregional.exaFisRegInicial_amigdalasOroFa.ToString();
                            //txt_dentadura.Text = examfisregional.exaFisRegInicial_dentaduraOroFa.ToString();
                            //txt_tabique.Text = examfisregional.exaFisRegInicial_tabiqueNariz.ToString();
                            //txt_cornetes.Text = examfisregional.exaFisRegInicial_cornetesNariz.ToString();
                            //txt_mucosa.Text = examfisregional.exaFisRegInicial_mucosasNariz.ToString();
                            //txt_senosparanasales.Text = examfisregional.exaFisRegInicial_senosParanaNariz.ToString();
                            //txt_tiroides.Text = examfisregional.exaFisRegInicial_tiroiMasasCuello.ToString();
                            //txt_movilidad.Text = examfisregional.exaFisRegInicial_movilidadCuello.ToString();
                            //txt_mamas.Text = examfisregional.exaFisRegInicial_mamasTorax.ToString();
                            //txt_corazon.Text = examfisregional.exaFisRegInicial_corazonTorax.ToString();
                            //txt_pulmones.Text = examfisregional.exaFisRegInicial_pulmonesTorax2.ToString();
                            //txt_parrillacostal.Text = examfisregional.exaFisRegInicial_parriCostalTorax2.ToString();
                            //txt_visceras.Text = examfisregional.exaFisRegInicial_viscerasAbdomen.ToString();
                            //txt_paredabdominal.Text = examfisregional.exaFisRegInicial_paredAbdomiAbdomen.ToString();
                            //txt_flexibilidad.Text = examfisregional.exaFisRegInicial_flexibilidadColumna.ToString();
                            //txt_desviacion.Text = examfisregional.exaFisRegInicial_desviacionColumna.ToString();
                            //txt_dolor.Text = examfisregional.exaFisRegInicial_dolorColumna.ToString();
                            //txt_pelvis.Text = examfisregional.exaFisRegInicial_pelvisPelvis.ToString();
                            //txt_genitales.Text = examfisregional.exaFisRegInicial_genitalesPelvis.ToString();
                            //txt_vascular.Text = examfisregional.exaFisRegInicial_vascularExtre.ToString();
                            //txt_miembrosuperiores.Text = examfisregional.exaFisRegInicial_miemSupeExtre.ToString();
                            //txt_miembrosinferiores.Text = examfisregional.exaFisRegInicial_miemInfeExtre.ToString();
                            //txt_fuerza.Text = examfisregional.exaFisRegInicial_fuerzaNeuro.ToString();
                            //txt_sensibilidad.Text = examfisregional.exaFisRegInicial_sensibiNeuro.ToString();
                            //txt_marcha.Text = examfisregional.exaFisRegInicial_marchaNeuro.ToString();
                            //txt_reflejos.Text = examfisregional.exaFisRegInicial_refleNeuro.ToString();
                            txt_obervexamenfisicoregional.Text = inicial.inicial_observaExaFisRegInicial.ToString();

                            //L
                            txt_examen.Text = inicial.inicial_examen.ToString();
                            txt_fechaexamen.Text = inicial.inicial_fecha.ToString();
                            txt_resultadoexamen.Text = inicial.inicial_resultados.ToString();
                            txt_observacionexamen.Text = inicial.inicial_observacionesResExaGenEspRiesTrabajo.ToString();

                            //M
                            txt_descripdiagnostico.Text = inicial.inicial_descripciondiagnostico.ToString();
                            txt_cie.Text = inicial.inicial_cie.ToString();
                            //txt_pre.Text = inicial.Diag_pre.ToString();
                            //txt_def.Text = inicial.Diag_def.ToString();

                            //N
                            //txt_apto.Text = inicial.inicial_apto.ToString();
                            //txt_aptoobservacion.Text = inicial.inicial_aptoObserva.ToString();
                            //txt_aptolimitacion.Text = inicial.inicial_aptoLimi.ToString();
                            //txt_noapto.Text = inicial.inicial_NoApto.ToString();
                            txt_observacionaptitud.Text = inicial.inicial_ObservAptMed.ToString();
                            txt_limitacionaptitud.Text = inicial.inicial_LimitAptMed.ToString();

                            //O
                            txt_descripciontratamiento.Text = inicial.inicial_descripcionRecTra.ToString();

                            //P
                            txt_fechahora.Text = inicial.inicial_fecha_hora.ToString();
                            ddl_profesional.SelectedValue = inicial.prof_id.ToString();
                            txt_codigoDatProf.Text = inicial.inicial_cod.ToString();
                        }
                    }
                }
                txt_fechahora.Text = DateTime.Now.ToString(" dd/MM/yyyy " + " HH:mm ");
                cargarProfesional();
            }
		}

        //Metodo obtener cedula por numero de historia clinica
        [WebMethod]
        [ScriptMethod]
        public static List<string> ObtenerNumHClinica(string prefixText)
        {
            List<string> lista = new List<string>();
            try
            {
                string oConn = @"Data Source=.;Initial Catalog=SistemaECU911;Integrated Security=True";

                SqlConnection con = new SqlConnection(oConn);
                con.Open();
                SqlCommand cmd = new SqlCommand("select top(10) Per_Cedula from Tbl_Personas where Per_Cedula LIKE + @Cedula + '%'", con);
                cmd.Parameters.AddWithValue("@Cedula", prefixText);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                IDataReader lector = cmd.ExecuteReader();

                while (lector.Read())
                {
                    lista.Add(lector.GetString(0));
                }

                lector.Close();
                return lista;
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                return null;
            }
        }

        protected void txt_numHClinica_TextChanged(object sender, EventArgs e)
        {
            ObtenerCedula();
        }

        private void ObtenerCedula()
        {
            string cedula = txt_numHClinica.Text;

            var lista = from c in dc.Tbl_Personas
                        where c.Per_cedula == cedula
                        select c;

            foreach (var item in lista)
            {
                string priNombre = item.Per_priNombre;
                txt_priNombre.Text = priNombre;

                string segNombre = item.Per_segNombre;
                txt_segNombre.Text = segNombre;

                string priApellido = item.Per_priApellido;
                txt_priApellido.Text = priApellido;

                string segApellido = item.Per_segApellido;
                txt_segApellido.Text = segApellido;

                string sexo = item.Per_genero;
                txt_sexo.Text = sexo;

                //DateTime fechaIngresoTrabajo = Convert.ToDateTime(item.Per_fechInicioTrabajo);
                //txt_fechaingresotrabajo.Text = fechaIngresoTrabajo;

                string puestoTrabajo = item.Per_puestoTrabajo;
                txt_puestodetrabajociuo.Text = puestoTrabajo;

                string areaTrabajo = item.Per_areaTrabajo;
                txt_areadetrabajo.Text = areaTrabajo;

            }
        }

        //Metodo obtener codigo cie10
        [WebMethod]
        [ScriptMethod]
        public static List<string> ObtenerCie10(string prefixText)
        {
            List<string> lista = new List<string>();
            try
            {
                string oConn = @"Data Source=.;Initial Catalog=SistemaECU911;Integrated Security=True";

                SqlConnection con = new SqlConnection(oConn);
                con.Open();
                SqlCommand cmd = new SqlCommand("select top(10) dec10 from cie10 where dec10 LIKE + @Name + '%'", con);
                cmd.Parameters.AddWithValue("@Name", prefixText);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                IDataReader lector = cmd.ExecuteReader();

                while (lector.Read())
                {
                    lista.Add(lector.GetString(0));
                }

                lector.Close();
                return lista;
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                return null;
            }
        }

        protected void txt_descripdiagnostico_TextChanged(object sender, EventArgs e)
        {
            ObtenerCodigo();
        }

        private void ObtenerCodigo()
        {
            string descripcion = txt_descripdiagnostico.Text;

            var lista = from c in dc.cie10
                        where c.dec10 == descripcion
                        select c;

            foreach (var item in lista)
            {
                string codigo = item.id10;
                txt_cie.Text = codigo;
            }
        }
        
        private void GuardarHistorial()
        {
            try
            {
                per = CN_HistorialMedico.ObtenerIdPersonasxCedula(Convert.ToInt32(txt_numHClinica.Text));

                int perso = Convert.ToInt32(per.Per_id.ToString());

                inicial = new Tbl_Inicial
                {
                    //A.
                    inicial_numArchivo = txt_numArchivo.Text,
                    inicial_edad = Convert.ToInt32(txt_edad.Text),
                    //inicial.inicial_catolicaRel = txt_catolica.Text;
                    //inicial.inicial_evangelicaRel = txt_evangelica.Text;
                    //inicial.inicial_testJehovaRel = txt_testigo.Text;
                    //inicial.inicial_mormonaRel = txt_mormona.Text;
                    //inicial.inicial_otrasRel = txt_otrareligion.Text;
                    inicial_groSanguineo = txt_gruposanguineo.Text,
                    inicial_lateralidad = txt_lateralidad.Text,
                    //inicial.inicial__lesbianaOriSex = txt_lesbiana.Text;
                    //inicial.inicial_gayOriSex = txt_gay.Text;
                    //inicial.inicial_bisexualOriSex = txt_bisexual.Text;
                    //inicial.inicial_heterosexualOriSex = txt_heterosexual.Text;
                    //inicial.inicial_norespondeOriSex = txt_noRespondeOriSex.Text;
                    //inicial.inicial_femeninoIdenGen = txt_femenino.Text;
                    //inicial.inicial_masculinoIdenGen = txt_masculino.Text;
                    //inicial.inicial_transFemeninoIdenGen = txt_transfemenino.Text;
                    //inicial.inicial_transMasculinoIdenGen = txt_transmasculino.Text;
                    //inicial.inicial_norespondeIdenGen = txt_noRespondeIdeGen.Text;
                    //inicial.inicial_siDis = txt_sidiscapacidad.Text;
                    //inicial.inicial_noDis = txt_nodiscapacidad.Text;
                    inicial_tipoDis = txt_tipodiscapacidad.Text,
                    inicial_porcentDis = Convert.ToInt32(txt_porcentajediscapacidad.Text),
                    inicial_actRelePuesTrabajo = txt_actividadesrelevantes.Text,
                    
                    //B.
                    inicial_descripcionMotivoConsulta = txt_motivoconsultainicial.Text,

                    //C.
                    inicial_descripcionAnteceCliniQuirur = txt_antCliQuiDescripcion.Text,
                    inicial_menarquia = txt_menarquiaAntGinObste.Text,
                    inicial_ciclos = txt_ciclosAntGinObste.Text,
                    inicial_fechUltiMenstrua = Convert.ToDateTime(txt_fechUltiMensAntGinObste.Text),
                    inicial_gestas = txt_gestasAntGinObste.Text,
                    inicial_partos = txt_partosAntGinObste.Text,
                    inicial_cesareas = txt_cesareasAntGinObste.Text,
                    inicial_abortos = txt_abortosAntGinObste.Text,
                    inicial_vivosHij = Convert.ToInt32(txt_vivosAntGinObste.Text),
                    inicial_muertosHij = Convert.ToInt32(txt_muertosAntGinObste.Text),
                    //antper.inicial_siVidaSexActiva = txt_siVidSexAntGinObste.Text;
                    //antper.inicial_noVidaSexActiva = txt_noVidSexAntGinObste.Text;
                    //antper.inicial_siMetPlanifiFamiliar = txt_siMetPlaniAntGinObste.Text;
                    //antper.inicial_noMetPlanifiFamiliar = txt_noMetPlaniAntGinObste.Text;
                    inicial_tipoMetPlanifiFamiliar = txt_tipoMetPlaniAntGinObste.Text,
                    //antper.inicial_siExaRealiPapanicolaou = txt_siPapaniAntGinObste.Text;
                    //antper.inicial_noExaRealiPapanicolaou = txt_noPapaniAntGinObste.Text;
                    inicial_tiempoExaRealiPapanicolaou = Convert.ToInt32(txt_tiempoPapaniAntGinObste.Text),
                    inicial_resultadoExaRealiPapanicolaou = txt_resultadoPapaniAntGinObste.Text,
                    //antper.inicial_siExaRealiEcoMamario = txt_siEcoMamaAntGinObste.Text;
                    //antper.inicial_noExaRealiEcoMamario = txt_noEcoMamaAntGinObste.Text;
                    inicial_tiempoExaRealiEcoMamario = Convert.ToInt32(txt_tiempoEcoMamaAntGinObste.Text),
                    inicial_resultadoExaRealiEcoMamario = txt_resultadoEcoMamaAntGinObste.Text,
                    //antper.inicial_siExaRealiColposcopia = txt_siColposAntGinObste.Text;
                    //antper.inicial_noExaRealiColposcopia = txt_noColposAntGinObste.Text;
                    inicial_tiempoExaRealiColposcopia = Convert.ToInt32(txt_tiempoColposAntGinObste.Text),
                    inicial_resultadoExaRealiColposcopia = txt_resultadoColposAntGinObste.Text,
                    //antper.inicial_siExaRealiMamografia = txt_siMamograAntGinObste.Text;
                    //antper.inicial_noExaRealiMamografia = txt_noMamograAntGinObste.Text;
                    inicial_tiempoExaRealiMamografia = Convert.ToInt32(txt_tiempoMamograAntGinObste.Text),
                    inicial_resultadoExaRealiMamografia = txt_resultadoMamograAntGinObste.Text,
                    //antper.inicial_siExaRealiAntiProstatico = txt_siExaRealiAntProstaAntReproMascu.Text;
                    //antper.inicial_noExaRealiAntiProstatico = txt_noExaRealiAntProstaAntReproMascu.Text;
                    inicial_tiempoExaRealiAntiProstatico = Convert.ToInt32(txt_tiempoExaRealiAntProstaAntReproMascu.Text),
                    inicial_resultadoExaRealiAntiProstatico = txt_resultadoExaRealiAntProstaAntReproMascu.Text,
                    //antper.inicial_siMetPlanifiFamiAntReproMascu = txt_siMetPlaniAntReproMascu.Text;
                    //antper.inicial_noMetPlanifiFamiAntReproMascu = txt_noMetPlaniAntReproMascu.Text;
                    inicial_tipo1MetPlanifiFamiAntReproMascu = txt_tipo1MetPlaniAntReproMascu.Text,
                    inicial_vivosHijAntReproMascu = Convert.ToInt32(txt_vivosHijosAntReproMascu.Text),
                    inicial_muertosHijAntReproMascu = Convert.ToInt32(txt_muertosHijosAntReproMascu.Text),
                    //antper.inicial_siExaRealiEcoProstatico = txt_siExaRealiEcoProstaAntReproMascu.Text;
                    //antper.inicial_noExaRealiEcoProstatico = txt_noExaRealiEcoProstaAntReproMascu.Text;
                    inicial_tiempoExaRealiEcoProstatico = Convert.ToInt32(txt_tiempoExaRealiEcoProstaAntReproMascu.Text),
                    inicial_resultadoExaRealiEcoProstatico = txt_resultadoExaRealiEcoProstaAntReproMascu.Text,
                    inicial_tipo2MetPlanifiFamiAntReproMascu = txt_tipo2MetPlaniAntReproMascu.Text,
                    //antper.inicial_siConsuNocivosTabaco = txt_siConsuNociTabaHabToxi.Text;
                    //antper.inicial_noConsuNocivosTabaco = txt_noConsuNociTabaHabToxi.Text;
                    inicial_tiempoConsuConsuNocivosTabaco = Convert.ToInt32(txt_tiemConConsuNociTabaHabToxi.Text),
                    inicial_cantidadConsuNocivosTabaco = txt_cantiConsuNociTabaHabToxi.Text,
                    inicial_exConsumiConsuNocivosTabaco = txt_exConsumiConsuNociTabaHabToxi.Text,
                    inicial_tiempoAbstiConsuNocivosTabaco = Convert.ToInt32(txt_tiemAbstiConsuNociTabaHabToxi.Text),
                    //antper.inicial_siConsuNocivosAlcohol = txt_siConsuNociAlcoHabToxi.Text;
                    //antper.inicial_noConsuNocivosAlcohol = txt_noConsuNociAlcoHabToxi.Text;
                    inicial_tiempoConsuConsuNocivosAlcohol = Convert.ToInt32(txt_tiemConConsuNociAlcoHabToxi.Text),
                    inicial_cantidadConsuNocivosAlcohol = txt_cantiConsuNociAlcoHabToxi.Text,
                    inicial_exConsumiConsuNocivosAlcohol = txt_exConsumiConsuNociAlcoHabToxi.Text,
                    inicial_tiempoAbstiConsuNocivosAlcohol = Convert.ToInt32(txt_tiemAbstiConsuNociAlcoHabToxi.Text),
                    //antper.inicial_siConsuNocivosOtrasDrogas = txt_siConsuNociOtrasDroHabToxi.Text;
                    //antper.inicial_noConsuNocivosOtrasDrogas = txt_noConsuNociOtrasDroHabToxi.Text;
                    inicial_tiempoConsu1ConsuNocivosOtrasDrogas = Convert.ToInt32(txt_tiemCon1ConsuNociOtrasDroHabToxi.Text),
                    inicial_cantidad1ConsuNocivosOtrasDrogas = txt_canti1ConsuNociOtrasDroHabToxi.Text,
                    inicial_exConsumi1ConsuNocivosOtrasDrogas = txt_exConsumi1ConsuNociOtrasDroHabToxi.Text,
                    inicial_tiempoAbsti1ConsuNocivosOtrasDrogas = Convert.ToInt32(txt_tiemAbsti1ConsuNociOtrasDroHabToxi.Text),
                    inicial_otrasConsuNocivos = txt_otrasConsuNociOtrasDroHabToxi.Text,
                    inicial_tiempoConsu2ConsuNocivosOtrasDrogas = Convert.ToInt32(txt_tiemCon2ConsuNociOtrasDroHabToxi.Text),
                    inicial_cantidad2ConsuNocivosOtrasDrogas = txt_canti2ConsuNociOtrasDroHabToxi.Text,
                    inicial_exConsumi2ConsuNocivosOtrasDrogas = txt_exConsumi2ConsuNociOtrasDroHabToxi.Text,
                    inicial_tiempoAbsti2ConsuNocivosOtrasDrogas = Convert.ToInt32(txt_tiemAbsti2ConsuNociOtrasDroHabToxi.Text),
                    //antper.inicial_siEstiVidaActFisica = txt_siEstVidaActFisiEstVida.Text;
                    //antper.inicial_noEstiVidaActFisica = txt_noEstVidaActFisiEstVida.Text;
                    inicial_cualEstiVidaActFisica = txt_cualEstVidaActFisiEstVida.Text,
                    inicial_tiem_cantEstiVidaActFisica = txt_tiemCanEstVidaActFisiEstVida.Text,
                    //antper.inicial_siEstiVidaMediHabitual = txt_siEstVidaMedHabiEstVida.Text;
                    //antper.inicial_noEstiVidaMediHabitual = txt_noEstVidaMedHabiEstVida.Text;
                    inicial_cual2EstiVidaMediHabitual = txt_cual1EstVidaMedHabiEstVida.Text,
                    inicial_tiem_cant2EstiVidaMediHabitual = txt_tiemCan1EstVidaMedHabiEstVida.Text,
                    inicial_cual3EstiVidaMediHabitual = txt_cual2EstVidaMedHabiEstVida.Text,
                    inicial_tiem_cant3EstiVidaMediHabitual = txt_tiemCan2EstVidaMedHabiEstVida.Text,
                    inicial_cual4EstiVidaMediHabitual = txt_cual3EstVidaMedHabiEstVida.Text,
                    inicial_tiem_cant4EstiVidaMediHabitual = txt_tiemCan3EstVidaMedHabiEstVida.Text,

                    //D.
                    inicial_nomEmpresa = txt_empresa.Text,
                    inicial_puestoTrabajo = txt_puestotrabajo.Text,
                    inicial_actDesemp = txt_actdesempeña.Text,
                    inicial_tiemTrabajo = txt_tiempotrabajo.Text,
                    //inicial_fisicoRies = txt_fisico.Text;
                    //inicial_mecanicoRies = txt_mecanico.Text;
                    //inicial_quimicoRies = txt_quimico.Text;
                    //inicial_biologicoRies = txt_biologico.Text;
                    //inicial_ergonomicoRies = txt_ergonomico.Text;
                    //inicial_psicosocial = txt_psicosocial.Text;
                    inicial_observacionesAnteEmpleAnteriores = txt_obseantempleanteriores.Text,
                    //inicial_siCalificadoIESSAcciTrabajo = txt_si.Text;
                    inicial_especificarCalificadoIESSAcciTrabajo = txt_especificar.Text,
                    //inicial_noCalificadoIESSAcciTrabajo = txt_no.Text;
                    inicial_fechaCalificadoIESSAcciTrabajo = Convert.ToDateTime(txt_fecha.Text),
                    inicial_obserAcciTrabajo = txt_observaciones2.Text,
                    //inicial_siCalificadoIESSEnfProfesionales = txt_siprofesional.Text;
                    inicial_especificarCalificadoIESSEnfProfesionales = txt_espeprofesional.Text,
                    //inicial_noCalificadoIESSEnfProfesionales = txt_noprofesional.Text;
                    inicial_fechaCalificadoIESSEnfProfesionales = Convert.ToDateTime(txt_fechaprofesional.Text),

                    //E.
                    //inicial_enfCarVas = txt_enfermedadcardiovascular.Text;
                    //inicial_enfMeta = txt_enfermedadmetabolica.Text;
                    //inicial_enfNeuro = txt_enfermedadneurologica.Text;
                    //inicial_enfOnco = txt_enfermedadoncologica.Text;
                    //inicial_enfInfe = txt_enfermedadinfecciosa.Text;
                    //inicial_enfHereConge = txt_enfermedadhereditaria.Text;
                    //inicial_discapa = txt_discapacidades.Text;
                    //inicial_otros = txt_otrosenfer.Text;
                    inicial_descripcionAnteFamiliares = txt_descripcionantefamiliares.Text,

                    //F.
                    inicial_area = txt_puestodetrabajo.Text,
                    inicial_actividades = txt_act.Text,
                    //inicial_temAltasFis = txt_tempaltas.Text;
                    //inicial_temBajasFis = txt_tempbajas.Text;
                    //inicial_radIonizanteFis = txt_radiacion.Text;
                    //inicial_radNoIonizanteFis = txt_noradiacion.Text;
                    //inicial_ruidoFis = txt_ruido.Text;
                    //inicial_vibracionFis = txt_vibracion.Text;
                    //inicial_iluminacionFis = txt_iluminacion.Text;
                    //inicial_ventilacionFis = txt_ventilacion.Text;
                    //inicial_fluElectricoFis = txt_fluidoelectrico.Text;
                    //inicial_otrosFis = txt_otrosFisico.Text;
                    //inicial_atraMaquinasMec = txt_atrapmaquinas.Text;
                    //inicial_atraSuperfiiesMec = txt_atrapsuperficie.Text;
                    //inicial_atraObjetosMec = txt_atrapobjetos.Text;
                    //inicial_caidaObjetosMec = txt_caidaobjetos.Text;
                    //inicial_caidaMisNivelMec = txt_caidamisnivel.Text;
                    //inicial_caidaDifNivelMec = txt_caidadifnivel.Text;
                    //inicial_contactoElecMec = txt_contaelectrico.Text;
                    //inicial_conSuperTrabaMec = txt_contasuptrabajo.Text;
                    //inicial_proPartiFragMec = txt_proyparticulas.Text;
                    //inicial_proFluidosMec = txt_proyefluidos.Text;
                    //inicial_pinchazosMec = txt_pinchazos.Text;
                    //inicial_cortesMec = txt_cortes.Text;
                    //inicial_atropeVehiMec = txt_atroporvehiculos.Text;
                    //inicial_coliVehiMec = txt_choques.Text;
                    //inicial_otrosMec = txt_otrosMecanico.Text;
                    //inicial_solidosQui = txt_solidos.Text;
                    //inicial_polvosQui = txt_polvos.Text;
                    //inicial_humosQui = txt_humos.Text;
                    //inicial_liquidosQui = txt_liquidos.Text;
                    //inicial_vaporesQui = txt_vapores.Text;
                    //inicial_aerosolesQui = txt_aerosoles.Text;
                    //inicial_neblinasQui = txt_neblinas.Text;
                    //inicial_gaseososQui = txt_gaseosos.Text;
                    //inicial_otrosBio = txt_otrosQuimico.Text;
                    //inicial_virusBio = txt_virus.Text;
                    //inicial_hongosBio = txt_hongos.Text;
                    //inicial_bacteriasBio = txt_bacterias.Text;
                    //inicial_parasitosBio = txt_parasitos.Text;
                    //inicial_expVectBio = txt_expoavectores.Text;
                    //inicial_expAniSelvaBio = txt_expoanimselvaticos.Text;
                    //inicial_otrosBio = txt_otrosBiologico.Text;
                    //inicial_maneManCarErg = txt_manmanualcargas.Text;
                    //inicial_movRepeErg = txt_movrepetitivo.Text;
                    //inicial_posForzaErg = txt_postforzadas.Text;
                    //inicial_trabPvdErg = txt_trabajopvd.Text;
                    //inicial_otrosErg = txt_otrosErgonomico.Text;
                    //inicial_monoTrabPsi = txt_montrabajo.Text;
                    //inicial_sobrecarLabPsi = txt_sobrecargalaboral.Text;
                    //inicial_minuTareaPsi = txt_minustarea.Text;
                    //inicial_altaResponPsi = txt_altarespon.Text;
                    //inicial_autoTomaDesiPsi = txt_automadesiciones.Text;
                    //inicial_supEstDirecDefiPsi = txt_supyestdireficiente.Text;
                    //inicial_conflicRolPsi = txt_conflictorol.Text;
                    //inicial_falClariFunPsi = txt_faltaclarfunciones.Text;
                    //inicial_incoDistriTrabPsi = txt_incorrdistrabajo.Text;
                    //inicial_turnosRotaPsi = txt_turnorotat.Text;
                    //inicial_relInterperPsi = txt_relacinterpersonales.Text;
                    //inicial_inesLabPsi = txt_inestalaboral.Text;
                    //inicial_otrosPsi = txt_otrosErgonomico.Text;
                    inicial_medPreventivas = txt_medpreventivas.Text,

                    //G.
                    inicial_descripActExtLab = txt_descrextralaborales.Text,

                    //H.
                    inicial_descripEnfActual = txt_enfermedadactualinicial.Text,

                    //I.
                    //inicial.RevActOrgSis_pielAnexos = txt_pielanexos.Text;
                    //inicial.RevActOrgSis_orgSentidos = txt_organossentidos.Text;
                    //inicial.RevActOrgSis_respiratorio = txt_respiratorio.Text;
                    //inicial.RevActOrgSis_cardVascular = txt_cardiovascular.Text;
                    //inicial.RevActOrgSis_digestivo = txt_digestivo.Text;
                    //inicial.RevActOrgSis_genUrinario = txt_genitourinario.Text;
                    //inicial.RevActOrgSis_muscEsqueletico = txt_musculosesqueleticos.Text;
                    //inicial.RevActOrgSis_endocrino = txt_endocrino.Text;
                    //inicial.RevActOrgSis_hemoLimfa = txt_hemolinfatico.Text;
                    //inicial.RevActOrgSis_nervioso = txt_nervioso.Text;
                    inicial_descripRevActOrgSis = txt_descrorganosysistemas.Text,

                    //K.
                    //examfisregional.exaFisRegInicial_cicatricesPiel = txt_cicatrices.Text;
                    //examfisregional.exaFisRegInicial_tatuajesPiel = txt_tatuajes.Text;
                    //examfisregional.exaFisRegInicial_pielFacerasPiel = txt_pielyfaneras.Text;
                    //examfisregional.exaFisRegInicial_parpadosOjos = txt_parpados.Text;
                    //examfisregional.exaFisRegInicial_conjuntuvasOjos = txt_conjuntivas.Text;
                    //examfisregional.exaFisRegInicial_pupilasOjos = txt_pupilas.Text;
                    //examfisregional.exaFisRegInicial_corneaOjos = txt_cornea.Text;
                    //examfisregional.exaFisRegInicial_motilidadOjos = txt_motilidad.Text;
                    //examfisregional.exaFisRegInicial_cAudiExtreOido = txt_auditivoexterno.Text;
                    //examfisregional.exaFisRegInicial_pabellonOido = txt_pabellon.Text;
                    //examfisregional.exaFisRegInicial_timpanosOido = txt_timpanos.Text;
                    //examfisregional.exaFisRegInicial_labiosOroFa = txt_labios.Text;
                    //examfisregional.exaFisRegInicial_lenguaOroFa = txt_lengua.Text;
                    //examfisregional.exaFisRegInicial_faringeOroFa = txt_faringe.Text;
                    //examfisregional.exaFisRegInicial_amigdalasOroFa = txt_amigdalas.Text;
                    //examfisregional.exaFisRegInicial_dentaduraOroFa = txt_dentadura.Text;
                    //examfisregional.exaFisRegInicial_tabiqueNariz = txt_tabique.Text;
                    //examfisregional.exaFisRegInicial_cornetesNariz = txt_cornetes.Text;
                    //examfisregional.exaFisRegInicial_mucosasNariz = txt_mucosa.Text;
                    //examfisregional.exaFisRegInicial_senosParanaNariz = txt_senosparanasales.Text;
                    //examfisregional.exaFisRegInicial_tiroiMasasCuello = txt_tiroides.Text;
                    //examfisregional.exaFisRegInicial_movilidadCuello = txt_movilidad.Text;
                    //examfisregional.exaFisRegInicial_mamasTorax = txt_mamas.Text;
                    //examfisregional.exaFisRegInicial_corazonTorax = txt_corazon.Text;
                    //examfisregional.exaFisRegInicial_pulmonesTorax2 = txt_pulmones.Text;
                    //examfisregional.exaFisRegInicial_parriCostalTorax2 = txt_parrillacostal.Text;
                    //examfisregional.exaFisRegInicial_viscerasAbdomen = txt_visceras.Text;
                    //examfisregional.exaFisRegInicial_paredAbdomiAbdomen = txt_paredabdominal.Text;
                    //examfisregional.exaFisRegInicial_flexibilidadColumna = txt_flexibilidad.Text;
                    //examfisregional.exaFisRegInicial_desviacionColumna = txt_desviacion.Text;
                    //examfisregional.exaFisRegInicial_dolorColumna = txt_dolor.Text;
                    //examfisregional.exaFisRegInicial_pelvisPelvis = txt_pelvis.Text;
                    //examfisregional.exaFisRegInicial_genitalesPelvis = txt_genitales.Text;
                    //examfisregional.exaFisRegInicial_vascularExtre = txt_vascular.Text;
                    //examfisregional.exaFisRegInicial_miemSupeExtre = txt_miembrosuperiores.Text;
                    //examfisregional.exaFisRegInicial_miemInfeExtre = txt_miembrosinferiores.Text;
                    //examfisregional.exaFisRegInicial_fuerzaNeuro = txt_fuerza.Text;
                    //examfisregional.exaFisRegInicial_sensibiNeuro = txt_sensibilidad.Text;
                    //examfisregional.exaFisRegInicial_marchaNeuro = txt_marcha.Text;
                    //examfisregional.exaFisRegInicial_refleNeuro = txt_reflejos.Text;
                    inicial_observaExaFisRegInicial = txt_obervexamenfisicoregional.Text,

                    //L.
                    inicial_examen = txt_examen.Text,
                    inicial_fecha = Convert.ToDateTime(txt_fechaexamen.Text),
                    inicial_resultados = txt_resultadoexamen.Text,
                    inicial_observacionesResExaGenEspRiesTrabajo = txt_observacionexamen.Text,

                    //M.
                    inicial_descripciondiagnostico = txt_descripdiagnostico.Text,
                    inicial_cie = txt_cie.Text,
                    //inicial.Diag_pre = txt_pre.Text;
                    //inicial.Diag_def = txt_def.Text;

                    //N.
                    //inicial_apto = txt_apto.Text;
                    //inicial_aptoObserva = txt_aptoobservacion.Text;
                    //inicial_aptoLimi = txt_aptolimitacion.Text;
                    //inicial_NoApto = txt_noapto.Text;
                    inicial_ObservAptMed = txt_observacionaptitud.Text,
                    inicial_LimitAptMed = txt_limitacionaptitud.Text,

                    //O.
                    inicial_descripcionRecTra = txt_descripciontratamiento.Text,

                    //P
                    inicial_fecha_hora = Convert.ToDateTime(txt_fechahora.Text),
                    prof_id = Convert.ToInt32(ddl_profesional.SelectedValue),
                    inicial_cod = txt_codigoDatProf.Text,
                    Per_id = perso
                };                

                CN_Inicial.GuardarInicial(inicial);

                //Mensaje de confirmacion
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Guardados Exitosamente')", true);

                Response.Redirect("~/Template/Views/PacientesInicial.aspx");
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Guardados Correctamente')", true);
            }

        }

        private void ModificarHistorial(Tbl_Inicial inicial)
        {
            try
            {
                //A.
                inicial.inicial_numArchivo = txt_numArchivo.Text;
                inicial.inicial_edad = Convert.ToInt32(txt_edad.Text);
                //inicial.inicial_catolicaRel = txt_catolica.Text;
                //inicial.inicial_evangelicaRel = txt_evangelica.Text;
                //inicial.inicial_testJehovaRel = txt_testigo.Text;
                //inicial.inicial_mormonaRel = txt_mormona.Text;
                //inicial.inicial_otrasRel = txt_otrareligion.Text;
                inicial.inicial_groSanguineo = txt_gruposanguineo.Text;
                inicial.inicial_lateralidad = txt_lateralidad.Text;
                //inicial.inicial__lesbianaOriSex = txt_lesbiana.Text;
                //inicial.inicial_gayOriSex = txt_gay.Text;
                //inicial.inicial_bisexualOriSex = txt_bisexual.Text;
                //inicial.inicial_heterosexualOriSex = txt_heterosexual.Text;
                //inicial.inicial_norespondeOriSex = txt_noRespondeOriSex.Text;
                //inicial.inicial_femeninoIdenGen = txt_femenino.Text;
                //inicial.inicial_masculinoIdenGen = txt_masculino.Text;
                //inicial.inicial_transFemeninoIdenGen = txt_transfemenino.Text;
                //inicial.inicial_transMasculinoIdenGen = txt_transmasculino.Text;
                //inicial.inicial_norespondeIdenGen = txt_noRespondeIdeGen.Text;
                //inicial.inicial_siDis = txt_sidiscapacidad.Text;
                //inicial.inicial_noDis = txt_nodiscapacidad.Text;
                inicial.inicial_tipoDis = txt_tipodiscapacidad.Text;
                inicial.inicial_porcentDis = Convert.ToInt32(txt_porcentajediscapacidad.Text);
                inicial.inicial_actRelePuesTrabajo = txt_actividadesrelevantes.Text;

                // B.
                inicial.inicial_descripcionMotivoConsulta = txt_motivoconsultainicial.Text;

                //C.
                inicial.inicial_descripcionAnteceCliniQuirur = txt_antCliQuiDescripcion.Text;
                inicial.inicial_menarquia = txt_menarquiaAntGinObste.Text;
                inicial.inicial_ciclos = txt_ciclosAntGinObste.Text;
                inicial.inicial_fechUltiMenstrua = Convert.ToDateTime(txt_fechUltiMensAntGinObste.Text);
                inicial.inicial_gestas = txt_gestasAntGinObste.Text;
                inicial.inicial_partos = txt_partosAntGinObste.Text;
                inicial.inicial_cesareas = txt_cesareasAntGinObste.Text;
                inicial.inicial_abortos = txt_abortosAntGinObste.Text;
                inicial.inicial_vivosHij = Convert.ToInt32(txt_vivosAntGinObste.Text);
                inicial.inicial_muertosHij = Convert.ToInt32(txt_muertosAntGinObste.Text);
                //antper.inicial_siVidaSexActiva = txt_siVidSexAntGinObste.Text;
                //antper.inicial_noVidaSexActiva = txt_noVidSexAntGinObste.Text;
                //antper.inicial_siMetPlanifiFamiliar = txt_siMetPlaniAntGinObste.Text;
                //antper.inicial_noMetPlanifiFamiliar = txt_noMetPlaniAntGinObste.Text;
                inicial.inicial_tipoMetPlanifiFamiliar = txt_tipoMetPlaniAntGinObste.Text;
                //antper.inicial_siExaRealiPapanicolaou = txt_siPapaniAntGinObste.Text;
                //antper.inicial_noExaRealiPapanicolaou = txt_noPapaniAntGinObste.Text;
                inicial.inicial_tiempoExaRealiPapanicolaou = Convert.ToInt32(txt_tiempoPapaniAntGinObste.Text);
                inicial.inicial_resultadoExaRealiPapanicolaou = txt_resultadoPapaniAntGinObste.Text;
                //antper.inicial_siExaRealiEcoMamario = txt_siEcoMamaAntGinObste.Text;
                //antper.inicial_noExaRealiEcoMamario = txt_noEcoMamaAntGinObste.Text;
                inicial.inicial_tiempoExaRealiEcoMamario = Convert.ToInt32(txt_tiempoEcoMamaAntGinObste.Text);
                inicial.inicial_resultadoExaRealiEcoMamario = txt_resultadoEcoMamaAntGinObste.Text;
                //antper.inicial_siExaRealiColposcopia = txt_siColposAntGinObste.Text;
                //antper.inicial_noExaRealiColposcopia = txt_noColposAntGinObste.Text;
                inicial.inicial_tiempoExaRealiColposcopia = Convert.ToInt32(txt_tiempoColposAntGinObste.Text);
                inicial.inicial_resultadoExaRealiColposcopia = txt_resultadoColposAntGinObste.Text;
                //antper.inicial_siExaRealiMamografia = txt_siMamograAntGinObste.Text;
                //antper.inicial_noExaRealiMamografia = txt_noMamograAntGinObste.Text;
                inicial.inicial_tiempoExaRealiMamografia = Convert.ToInt32(txt_tiempoMamograAntGinObste.Text);
                inicial.inicial_resultadoExaRealiMamografia = txt_resultadoMamograAntGinObste.Text;
                //antper.inicial_siExaRealiAntiProstatico = txt_siExaRealiAntProstaAntReproMascu.Text;
                //antper.inicial_noExaRealiAntiProstatico = txt_noExaRealiAntProstaAntReproMascu.Text;
                inicial.inicial_tiempoExaRealiAntiProstatico = Convert.ToInt32(txt_tiempoExaRealiAntProstaAntReproMascu.Text);
                inicial.inicial_resultadoExaRealiAntiProstatico = txt_resultadoExaRealiAntProstaAntReproMascu.Text;
                //antper.inicial_siMetPlanifiFamiAntReproMascu = txt_siMetPlaniAntReproMascu.Text;
                //antper.inicial_noMetPlanifiFamiAntReproMascu = txt_noMetPlaniAntReproMascu.Text;
                inicial.inicial_tipo1MetPlanifiFamiAntReproMascu = txt_tipo1MetPlaniAntReproMascu.Text;
                inicial.inicial_vivosHijAntReproMascu = Convert.ToInt32(txt_vivosHijosAntReproMascu.Text);
                inicial.inicial_muertosHijAntReproMascu = Convert.ToInt32(txt_muertosHijosAntReproMascu.Text);
                //antper.inicial_siExaRealiEcoProstatico = txt_siExaRealiEcoProstaAntReproMascu.Text;
                //antper.inicial_noExaRealiEcoProstatico = txt_noExaRealiEcoProstaAntReproMascu.Text;
                inicial.inicial_tiempoExaRealiEcoProstatico = Convert.ToInt32(txt_tiempoExaRealiEcoProstaAntReproMascu.Text);
                inicial.inicial_resultadoExaRealiEcoProstatico = txt_resultadoExaRealiEcoProstaAntReproMascu.Text;
                inicial.inicial_tipo2MetPlanifiFamiAntReproMascu = txt_tipo2MetPlaniAntReproMascu.Text;
                //antper.inicial_siConsuNocivosTabaco = txt_siConsuNociTabaHabToxi.Text;
                //antper.inicial_noConsuNocivosTabaco = txt_noConsuNociTabaHabToxi.Text;
                inicial.inicial_tiempoConsuConsuNocivosTabaco = Convert.ToInt32(txt_tiemConConsuNociTabaHabToxi.Text);
                inicial.inicial_cantidadConsuNocivosTabaco = txt_cantiConsuNociTabaHabToxi.Text;
                inicial.inicial_exConsumiConsuNocivosTabaco = txt_exConsumiConsuNociTabaHabToxi.Text;
                inicial.inicial_tiempoAbstiConsuNocivosTabaco = Convert.ToInt32(txt_tiemAbstiConsuNociTabaHabToxi.Text);
                //antper.inicial_siConsuNocivosAlcohol = txt_siConsuNociAlcoHabToxi.Text;
                //antper.inicial_noConsuNocivosAlcohol = txt_noConsuNociAlcoHabToxi.Text;
                inicial.inicial_tiempoConsuConsuNocivosAlcohol = Convert.ToInt32(txt_tiemConConsuNociAlcoHabToxi.Text);
                inicial.inicial_cantidadConsuNocivosAlcohol = txt_cantiConsuNociAlcoHabToxi.Text;
                inicial.inicial_exConsumiConsuNocivosAlcohol = txt_exConsumiConsuNociAlcoHabToxi.Text;
                inicial.inicial_tiempoAbstiConsuNocivosAlcohol = Convert.ToInt32(txt_tiemAbstiConsuNociAlcoHabToxi.Text);
                //antper.inicial_siConsuNocivosOtrasDrogas = txt_siConsuNociOtrasDroHabToxi.Text;
                //antper.inicial_noConsuNocivosOtrasDrogas = txt_noConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_tiempoConsu1ConsuNocivosOtrasDrogas = Convert.ToInt32(txt_tiemCon1ConsuNociOtrasDroHabToxi.Text);
                inicial.inicial_cantidad1ConsuNocivosOtrasDrogas = txt_canti1ConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_exConsumi1ConsuNocivosOtrasDrogas = txt_exConsumi1ConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_tiempoAbsti1ConsuNocivosOtrasDrogas = Convert.ToInt32(txt_tiemAbsti1ConsuNociOtrasDroHabToxi.Text);
                inicial.inicial_otrasConsuNocivos = txt_otrasConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_tiempoConsu2ConsuNocivosOtrasDrogas = Convert.ToInt32(txt_tiemCon2ConsuNociOtrasDroHabToxi.Text);
                inicial.inicial_cantidad2ConsuNocivosOtrasDrogas = txt_canti2ConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_exConsumi2ConsuNocivosOtrasDrogas = txt_exConsumi2ConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_tiempoAbsti2ConsuNocivosOtrasDrogas = Convert.ToInt32(txt_tiemAbsti2ConsuNociOtrasDroHabToxi.Text);
                //antper.inicial_siEstiVidaActFisica = txt_siEstVidaActFisiEstVida.Text;
                //antper.inicial_noEstiVidaActFisica = txt_noEstVidaActFisiEstVida.Text;
                inicial.inicial_cualEstiVidaActFisica = txt_cualEstVidaActFisiEstVida.Text;
                inicial.inicial_tiem_cantEstiVidaActFisica = txt_tiemCanEstVidaActFisiEstVida.Text;
                //antper.inicial_siEstiVidaMediHabitual = txt_siEstVidaMedHabiEstVida.Text;
                //antper.inicial_noEstiVidaMediHabitual = txt_noEstVidaMedHabiEstVida.Text;
                inicial.inicial_cual2EstiVidaMediHabitual = txt_cual1EstVidaMedHabiEstVida.Text;
                inicial.inicial_tiem_cant2EstiVidaMediHabitual = txt_tiemCan1EstVidaMedHabiEstVida.Text;
                inicial.inicial_cual3EstiVidaMediHabitual = txt_cual2EstVidaMedHabiEstVida.Text;
                inicial.inicial_tiem_cant3EstiVidaMediHabitual = txt_tiemCan2EstVidaMedHabiEstVida.Text;
                inicial.inicial_cual4EstiVidaMediHabitual = txt_cual3EstVidaMedHabiEstVida.Text;
                inicial.inicial_tiem_cant4EstiVidaMediHabitual = txt_tiemCan3EstVidaMedHabiEstVida.Text;

                //D.
                inicial.inicial_nomEmpresa = txt_empresa.Text;
                inicial.inicial_puestoTrabajo = txt_puestotrabajo.Text;
                inicial.inicial_actDesemp = txt_actdesempeña.Text;
                inicial.inicial_tiemTrabajo = txt_tiempotrabajo.Text;
                //inicial.inicial_fisicoRies = txt_fisico.Text;
                //inicial.inicial_mecanicoRies = txt_mecanico.Text;
                //inicial.inicial_quimicoRies = txt_quimico.Text;
                //inicial.inicial_biologicoRies = txt_biologico.Text;
                //inicial.inicial_ergonomicoRies = txt_ergonomico.Text;
                //inicial.inicial_psicosocial = txt_psicosocial.Text;
                inicial.inicial_observacionesAnteEmpleAnteriores = txt_obseantempleanteriores.Text;
                //inicial.inicial_siCalificadoIESSAcciTrabajo = txt_si.Text;
                inicial.inicial_especificarCalificadoIESSAcciTrabajo = txt_especificar.Text;
                //inicial.inicial_noCalificadoIESSAcciTrabajo = txt_no.Text;
                inicial.inicial_fechaCalificadoIESSAcciTrabajo = Convert.ToDateTime(txt_fecha.Text);
                inicial.inicial_obserAcciTrabajo = txt_observaciones2.Text;
                //inicial.inicial_siCalificadoIESSEnfProfesionales = txt_siprofesional.Text;
                inicial.inicial_especificarCalificadoIESSEnfProfesionales = txt_espeprofesional.Text;
                //inicial.inicial_noCalificadoIESSEnfProfesionales = txt_noprofesional.Text;
                inicial.inicial_fechaCalificadoIESSEnfProfesionales = Convert.ToDateTime(txt_fechaprofesional.Text);

                //E.
                //inicial.inicial_enfCarVas = txt_enfermedadcardiovascular.Text;
                //inicial.inicial_enfMeta = txt_enfermedadmetabolica.Text;
                //inicial.inicial_enfNeuro = txt_enfermedadneurologica.Text;
                //inicial.inicial_enfOnco = txt_enfermedadoncologica.Text;
                //inicial.inicial_enfInfe = txt_enfermedadinfecciosa.Text;
                //inicial.inicial_enfHereConge = txt_enfermedadhereditaria.Text;
                //inicial.inicial_discapa = txt_discapacidades.Text;
                //inicial.inicial_otros = txt_otrosenfer.Text;
                inicial.inicial_descripcionAnteFamiliares = txt_descripcionantefamiliares.Text;

                //F.
                inicial.inicial_area = txt_puestodetrabajo.Text;
                inicial.inicial_actividades = txt_act.Text;
                //inicial.inicial_temAltasFis = txt_tempaltas.Text;
                //inicial.inicial_temBajasFis = txt_tempbajas.Text;
                //inicial.inicial_radIonizanteFis = txt_radiacion.Text;
                //inicial.inicial_radNoIonizanteFis = txt_noradiacion.Text;
                //inicial.inicial_ruidoFis = txt_ruido.Text;
                //inicial.inicial_vibracionFis = txt_vibracion.Text;
                //inicial.inicial_iluminacionFis = txt_iluminacion.Text;
                //inicial.inicial_ventilacionFis = txt_ventilacion.Text;
                //inicial.inicial_fluElectricoFis = txt_fluidoelectrico.Text;
                //inicial.inicial_otrosFis = txt_otrosFisico.Text;
                //inicial.inicial_atraMaquinasMec = txt_atrapmaquinas.Text;
                //inicial.inicial_atraSuperfiiesMec = txt_atrapsuperficie.Text;
                //inicial.inicial_atraObjetosMec = txt_atrapobjetos.Text;
                //inicial.inicial_caidaObjetosMec = txt_caidaobjetos.Text;
                //inicial.inicial_caidaMisNivelMec = txt_caidamisnivel.Text;
                //inicial.inicial_caidaDifNivelMec = txt_caidadifnivel.Text;
                //inicial.inicial_contactoElecMec = txt_contaelectrico.Text;
                //inicial.inicial_conSuperTrabaMec = txt_contasuptrabajo.Text;
                //inicial.inicial_proPartiFragMec = txt_proyparticulas.Text;
                //inicial.inicial_proFluidosMec = txt_proyefluidos.Text;
                //inicial.inicial_pinchazosMec = txt_pinchazos.Text;
                //inicial.inicial_cortesMec = txt_cortes.Text;
                //inicial.inicial_atropeVehiMec = txt_atroporvehiculos.Text;
                //inicial.inicial_coliVehiMec = txt_choques.Text;
                //inicial.inicial_otrosMec = txt_otrosMecanico.Text;
                //inicial.inicial_solidosQui = txt_solidos.Text;
                //inicial.inicial_polvosQui = txt_polvos.Text;
                //inicial.inicial_humosQui = txt_humos.Text;
                //inicial.inicial_liquidosQui = txt_liquidos.Text;
                //inicial.inicial_vaporesQui = txt_vapores.Text;
                //inicial.inicial_aerosolesQui = txt_aerosoles.Text;
                //inicial.inicial_neblinasQui = txt_neblinas.Text;
                //inicial.inicial_gaseososQui = txt_gaseosos.Text;
                //inicial.inicial_otrosBio = txt_otrosQuimico.Text;
                //inicial.inicial_virusBio = txt_virus.Text;
                //inicial.inicial_hongosBio = txt_hongos.Text;
                //inicial.inicial_bacteriasBio = txt_bacterias.Text;
                //inicial.inicial_parasitosBio = txt_parasitos.Text;
                //inicial.inicial_expVectBio = txt_expoavectores.Text;
                //inicial.inicial_expAniSelvaBio = txt_expoanimselvaticos.Text;
                //inicial.inicial_otrosBio = txt_otrosBiologico.Text;
                //inicial.inicial_maneManCarErg = txt_manmanualcargas.Text;
                //inicial.inicial_movRepeErg = txt_movrepetitivo.Text;
                //inicial.inicial_posForzaErg = txt_postforzadas.Text;
                //inicial.inicial_trabPvdErg = txt_trabajopvd.Text;
                //inicial.inicial_otrosErg = txt_otrosErgonomico.Text;
                //inicial.inicial_monoTrabPsi = txt_montrabajo.Text;
                //inicial.inicial_sobrecarLabPsi = txt_sobrecargalaboral.Text;
                //inicial.inicial_minuTareaPsi = txt_minustarea.Text;
                //inicial.inicial_altaResponPsi = txt_altarespon.Text;
                //inicial.inicial_autoTomaDesiPsi = txt_automadesiciones.Text;
                //inicial.inicial_supEstDirecDefiPsi = txt_supyestdireficiente.Text;
                //inicial.inicial_conflicRolPsi = txt_conflictorol.Text;
                //inicial.inicial_falClariFunPsi = txt_faltaclarfunciones.Text;
                //inicial.inicial_incoDistriTrabPsi = txt_incorrdistrabajo.Text;
                //inicial.inicial_turnosRotaPsi = txt_turnorotat.Text;
                //inicial.inicial_relInterperPsi = txt_relacinterpersonales.Text;
                //inicial.inicial_inesLabPsi = txt_inestalaboral.Text;
                //inicial.inicial_otrosPsi = txt_otrosErgonomico.Text;
                inicial.inicial_medPreventivas = txt_medpreventivas.Text;

                //G.
                inicial.inicial_descripActExtLab = txt_descrextralaborales.Text;

                //H.
                inicial.inicial_descripEnfActual = txt_enfermedadactualinicial.Text;

                //I.
                //inicial.RevActOrgSis_pielAnexos = txt_pielanexos.Text;
                //inicial.RevActOrgSis_orgSentidos = txt_organossentidos.Text;
                //inicial.RevActOrgSis_respiratorio = txt_respiratorio.Text;
                //inicial.RevActOrgSis_cardVascular = txt_cardiovascular.Text;
                //inicial.RevActOrgSis_digestivo = txt_digestivo.Text;
                //inicial.RevActOrgSis_genUrinario = txt_genitourinario.Text;
                //inicial.RevActOrgSis_muscEsqueletico = txt_musculosesqueleticos.Text;
                //inicial.RevActOrgSis_endocrino = txt_endocrino.Text;
                //inicial.RevActOrgSis_hemoLimfa = txt_hemolinfatico.Text;
                //inicial.RevActOrgSis_nervioso = txt_nervioso.Text;
                inicial.inicial_descripRevActOrgSis = txt_descrorganosysistemas.Text;

                //K.
                //examfisregional.exaFisRegInicial_cicatricesPiel = txt_cicatrices.Text;
                //examfisregional.exaFisRegInicial_tatuajesPiel = txt_tatuajes.Text;
                //examfisregional.exaFisRegInicial_pielFacerasPiel = txt_pielyfaneras.Text;
                //examfisregional.exaFisRegInicial_parpadosOjos = txt_parpados.Text;
                //examfisregional.exaFisRegInicial_conjuntuvasOjos = txt_conjuntivas.Text;
                //examfisregional.exaFisRegInicial_pupilasOjos = txt_pupilas.Text;
                //examfisregional.exaFisRegInicial_corneaOjos = txt_cornea.Text;
                //examfisregional.exaFisRegInicial_motilidadOjos = txt_motilidad.Text;
                //examfisregional.exaFisRegInicial_cAudiExtreOido = txt_auditivoexterno.Text;
                //examfisregional.exaFisRegInicial_pabellonOido = txt_pabellon.Text;
                //examfisregional.exaFisRegInicial_timpanosOido = txt_timpanos.Text;
                //examfisregional.exaFisRegInicial_labiosOroFa = txt_labios.Text;
                //examfisregional.exaFisRegInicial_lenguaOroFa = txt_lengua.Text;
                //examfisregional.exaFisRegInicial_faringeOroFa = txt_faringe.Text;
                //examfisregional.exaFisRegInicial_amigdalasOroFa = txt_amigdalas.Text;
                //examfisregional.exaFisRegInicial_dentaduraOroFa = txt_dentadura.Text;
                //examfisregional.exaFisRegInicial_tabiqueNariz = txt_tabique.Text;
                //examfisregional.exaFisRegInicial_cornetesNariz = txt_cornetes.Text;
                //examfisregional.exaFisRegInicial_mucosasNariz = txt_mucosa.Text;
                //examfisregional.exaFisRegInicial_senosParanaNariz = txt_senosparanasales.Text;
                //examfisregional.exaFisRegInicial_tiroiMasasCuello = txt_tiroides.Text;
                //examfisregional.exaFisRegInicial_movilidadCuello = txt_movilidad.Text;
                //examfisregional.exaFisRegInicial_mamasTorax = txt_mamas.Text;
                //examfisregional.exaFisRegInicial_corazonTorax = txt_corazon.Text;
                //examfisregional.exaFisRegInicial_pulmonesTorax2 = txt_pulmones.Text;
                //examfisregional.exaFisRegInicial_parriCostalTorax2 = txt_parrillacostal.Text;
                //examfisregional.exaFisRegInicial_viscerasAbdomen = txt_visceras.Text;
                //examfisregional.exaFisRegInicial_paredAbdomiAbdomen = txt_paredabdominal.Text;
                //examfisregional.exaFisRegInicial_flexibilidadColumna = txt_flexibilidad.Text;
                //examfisregional.exaFisRegInicial_desviacionColumna = txt_desviacion.Text;
                //examfisregional.exaFisRegInicial_dolorColumna = txt_dolor.Text;
                //examfisregional.exaFisRegInicial_pelvisPelvis = txt_pelvis.Text;
                //examfisregional.exaFisRegInicial_genitalesPelvis = txt_genitales.Text;
                //examfisregional.exaFisRegInicial_vascularExtre = txt_vascular.Text;
                //examfisregional.exaFisRegInicial_miemSupeExtre = txt_miembrosuperiores.Text;
                //examfisregional.exaFisRegInicial_miemInfeExtre = txt_miembrosinferiores.Text;
                //examfisregional.exaFisRegInicial_fuerzaNeuro = txt_fuerza.Text;
                //examfisregional.exaFisRegInicial_sensibiNeuro = txt_sensibilidad.Text;
                //examfisregional.exaFisRegInicial_marchaNeuro = txt_marcha.Text;
                //examfisregional.exaFisRegInicial_refleNeuro = txt_reflejos.Text;
                inicial.inicial_observaExaFisRegInicial = txt_obervexamenfisicoregional.Text;

                //L.
                inicial.inicial_examen = txt_examen.Text;
                inicial.inicial_fecha = Convert.ToDateTime(txt_fechaexamen.Text);
                inicial.inicial_resultados = txt_resultadoexamen.Text;
                inicial.inicial_observacionesResExaGenEspRiesTrabajo = txt_observacionexamen.Text;

                //M.
                inicial.inicial_descripciondiagnostico = txt_descripdiagnostico.Text;
                inicial.inicial_cie = txt_cie.Text;
                //inicial.Diag_pre = txt_pre.Text;
                //inicial.Diag_def = txt_def.Text;

                //N.
                //inicial.inicial_apto = txt_apto.Text;
                //inicial.inicial_aptoObserva = txt_aptoobservacion.Text;
                //inicial.inicial_aptoLimi = txt_aptolimitacion.Text;
                //inicial.inicial_NoApto = txt_noapto.Text;
                inicial.inicial_ObservAptMed = txt_observacionaptitud.Text;
                inicial.inicial_LimitAptMed = txt_limitacionaptitud.Text;

                //O.
                inicial.inicial_descripcionRecTra = txt_descripciontratamiento.Text;

                //P
                inicial.inicial_fecha_hora = Convert.ToDateTime(txt_fechahora.Text);
                inicial.prof_id = Convert.ToInt32(ddl_profesional.SelectedValue);
                inicial.inicial_cod = txt_codigoDatProf.Text;

                CN_Inicial.ModificarInicial(inicial);
              
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Modificados Exitosamente')", true);
                Response.Redirect("~/Template/Views/PacientesInicial.aspx");
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Modificados')", true);
            }
            
        }

        private void Guardar_modificar_datos(int ini)
        {
            if (ini == 0)
            {
                GuardarHistorial();
            }
            else
            {
                inicial = CN_Inicial.ObtenerInicialPorId(ini);
                if (inicial != null)
                {
                    ModificarHistorial(inicial);
                }
            }
        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            Guardar_modificar_datos(Convert.ToInt32(Request["cod"]));
        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/Views/Inicio.aspx");
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
            //txt_antCliQuiDescripcion.Text = "";
            //txt_empresa.Text = txt_puestotrabajo.Text = txt_actdesempeña.Text = txt_tiempotrabajo.Text = txt_fisico.Text = txt_mecanico.Text=
            //txt_quimico.Text = txt_biologico.Text = txt_ergonomico.Text = txt_psicosocial.Text = txt_obseantempleanteriores.Text = txt_si.Text =
            //txt_especificar.Text = txt_no.Text = txt_fecha.Text = txt_observaciones2.Text = txt_siprofesional.Text = txt_espeprofesional.Text =
            //txt_noprofesional.Text = txt_fechaprofesional.Text = txt_observaciones3.Text = txt_puestodetrabajo.Text = txt_act.Text = 
            //txt_tempaltas.Text = txt_atrapmaquinas.Text = txt_solidos.Text = txt_puestodetrabajo2.Text = txt_act2.Text = txt_virus.Text = 
            //txt_manmanualcargas.Text = txt_montrabajo.Text = txt_medpreventivas.Text = txt_descrextralaborales.Text = txt_examen.Text = 
            //txt_fechaexamen.Text = txt_resultadoexamen.Text = txt_observacionexamen.Text = txt_descripinicial.Text = txt_pre.Text = 
            //txt_def.Text = txt_apto.Text = txt_observacionaptitud.Text = txt_limitacionaptitud.Text = "";

        }
        
    }
}