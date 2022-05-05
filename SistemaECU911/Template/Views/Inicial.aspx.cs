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
                string oConn = @"Data Source=MAYCKYANDER\MAYCKYANDER;Initial Catalog=SistemaECU911;Integrated Security=True";

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

                DateTime fechaIngresoTrabajo = Convert.ToDateTime(item.Per_fechInicioTrabajo);
                txt_fechaingresotrabajo.Text = Convert.ToString(fechaIngresoTrabajo);

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
                string oConn = @"Data Source=MAYCKYANDER\MAYCKYANDER;Initial Catalog=SistemaECU911;Integrated Security=True";

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

                inicial = new Tbl_Inicial();
                if (ckb_catolica.Checked == true)
                {
                    inicial.inicial_catolicaRel = "Si";
                }
                if (ckb_evangelica.Checked == true)
                {
                    inicial.inicial_evangelicaRel = "Si";
                }
                if (cbk_testigo.Checked == true)
                {
                    inicial.inicial_testJehovaRel = "Si";
                }
                if (cbk_mormona.Checked == true)
                {
                    inicial.inicial_mormonaRel = "Si";
                }
                if (cbk_otrareligion.Checked == true)
                {
                    inicial.inicial_otrasRel = "Si";
                }
                inicial.inicial_groSanguineo = txt_gruposanguineo.Text;
                inicial.inicial_lateralidad = txt_lateralidad.Text;
                if (cbk_gay.Checked == true)
                {
                    inicial.inicial_gayOriSex = "Si";
                }
                if (cbk_lesbiana.Checked == true)
                {
                    inicial.inicial__lesbianaOriSex = "Si";
                }
                if (cbk_bisexual.Checked == true)
                {
                    inicial.inicial_bisexualOriSex = "Si";
                }
                if (cbk_heterosexual.Checked == true)
                {
                    inicial.inicial_heterosexualOriSex = "Si";
                }
                if (cbk_noRespondeOriSex.Checked == true)
                {
                    inicial.inicial_norespondeOriSex = "Si";
                }
                if (cbk_femenino.Checked == true)
                {
                    inicial.inicial_femeninoIdenGen = "Si";
                }
                if (cbk_masculino.Checked == true)
                {
                    inicial.inicial_masculinoIdenGen = "Si";
                }
                if (cbk_transfemenino.Checked == true)
                {
                    inicial.inicial_transFemeninoIdenGen = "Si";
                }
                if (cbk_transmasculino.Checked == true)
                {
                    inicial.inicial_transMasculinoIdenGen = "Si";
                }
                if (cbk_noRespondeIdeGen.Checked == true)
                {
                    inicial.inicial_norespondeIdenGen = "Si";
                }
                if (cbk_sidiscapacidad.Checked == true)
                {
                    inicial.inicial_siDis = "Si";
                }
                if (cbk_nodiscapacidad.Checked == true)
                {
                    inicial.inicial_noDis = "No";
                }
                inicial.inicial_tipoDis = txt_tipodiscapacidad.Text;
                inicial.inicial_porcentDis = Convert.ToInt32(txt_porcentajediscapacidad.Text);
                inicial.inicial_actRelePuesTrabajo = txt_actividadesrelevantes.Text;
                inicial.inicial_descripcionMotivoConsulta = txt_motivoconsultainicial.Text;
                inicial.inicial_descripcionAnteceCliniQuirur = txt_antCliQuiDescripcion.Text;
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
                if (ckb_siVidSexAntGinObste.Checked == true)
                {
                    inicial.inicial_siVidaSexActiva = "Si";
                }
                if (ckb_noVidSexAntGinObste.Checked == true)
                {
                    inicial.inicial_noVidaSexActiva = "No";
                }
                if (ckb_siMetPlaniAntGinObste.Checked == true)
                {
                    inicial.inicial_siMetPlanifiFamiliar = "Si";
                }
                if (ckb_noMetPlaniAntGinObste.Checked == true)
                {
                    inicial.inicial_noMetPlanifiFamiliar = "No";
                }
                inicial.inicial_tipoMetPlanifiFamiliar = txt_tipoMetPlaniAntGinObste.Text;
                if (ckb_siPapaniAntGinObste.Checked == true)
                {
                    inicial.inicial_siExaRealiPapanicolaou = "Si";
                }
                if (ckb_noPapaniAntGinObste.Checked == true)
                {
                    inicial.inicial_noExaRealiPapanicolaou = "No";
                }
                inicial.inicial_tiempoExaRealiPapanicolaou = Convert.ToInt32(txt_tiempoPapaniAntGinObste.Text);
                inicial.inicial_resultadoExaRealiPapanicolaou = txt_resultadoPapaniAntGinObste.Text;
                if (ckb_siEcoMamaAntGinObste.Checked == true)
                {
                    inicial.inicial_siExaRealiEcoMamario = "Si";
                }
                if (ckb_noEcoMamaAntGinObste.Checked == true)
                {
                    inicial.inicial_noExaRealiEcoMamario = "No";
                }
                inicial.inicial_tiempoExaRealiEcoMamario = Convert.ToInt32(txt_tiempoEcoMamaAntGinObste.Text);
                inicial.inicial_resultadoExaRealiEcoMamario = txt_resultadoEcoMamaAntGinObste.Text;
                if (ckb_siColposAntGinObste.Checked == true)
                {
                    inicial.inicial_siExaRealiColposcopia = "Si";
                }
                if (ckb_noColposAntGinObste.Checked == true)
                {
                    inicial.inicial_noExaRealiColposcopia = "No";
                }
                inicial.inicial_tiempoExaRealiColposcopia = Convert.ToInt32(txt_tiempoColposAntGinObste.Text);
                inicial.inicial_resultadoExaRealiColposcopia = txt_resultadoColposAntGinObste.Text;
                if (ckb_siMamograAntGinObste.Checked == true)
                {
                    inicial.inicial_siExaRealiMamografia = "Si";
                }
                if (ckb_noMamograAntGinObste.Checked == true)
                {
                    inicial.inicial_noExaRealiMamografia = "No";
                }
                inicial.inicial_tiempoExaRealiMamografia = Convert.ToInt32(txt_tiempoMamograAntGinObste.Text);
                inicial.inicial_resultadoExaRealiMamografia = txt_resultadoMamograAntGinObste.Text;
                if (ckb_siExaRealiAntProstaAntReproMascu.Checked == true)
                {
                    inicial.inicial_siExaRealiAntiProstatico = "Si";
                }
                if (ckb_noExaRealiAntProstaAntReproMascu.Checked == true)
                {
                    inicial.inicial_noExaRealiAntiProstatico = "No";
                }
                inicial.inicial_tiempoExaRealiAntiProstatico = Convert.ToInt32(txt_tiempoExaRealiAntProstaAntReproMascu.Text);
                inicial.inicial_resultadoExaRealiAntiProstatico = txt_resultadoExaRealiAntProstaAntReproMascu.Text;
                if (ckb_siMetPlaniAntReproMascu.Checked == true)
                {
                    inicial.inicial_siMetPlanifiFamiAntReproMascu = "Si";
                }
                if (ckb_noMetPlaniAntReproMascu.Checked == true)
                {
                    inicial.inicial_noMetPlanifiFamiAntReproMascu = "No";
                }
                inicial.inicial_tipo1MetPlanifiFamiAntReproMascu = txt_tipo1MetPlaniAntReproMascu.Text;
                inicial.inicial_vivosHijAntReproMascu = Convert.ToInt32(txt_vivosHijosAntReproMascu.Text);
                inicial.inicial_muertosHijAntReproMascu = Convert.ToInt32(txt_muertosHijosAntReproMascu.Text);
                if (ckb_siExaRealiEcoProstaAntReproMascu.Checked == true)
                {
                    inicial.inicial_siExaRealiEcoProstatico = "Si";
                }
                if (ckb_noExaRealiEcoProstaAntReproMascu.Checked == true)
                {
                    inicial.inicial_noExaRealiEcoProstatico = "No";
                }
                inicial.inicial_tiempoExaRealiEcoProstatico = Convert.ToInt32(txt_tiempoExaRealiEcoProstaAntReproMascu.Text);
                inicial.inicial_resultadoExaRealiEcoProstatico = txt_resultadoExaRealiEcoProstaAntReproMascu.Text;
                inicial.inicial_tipo2MetPlanifiFamiAntReproMascu = txt_tipo2MetPlaniAntReproMascu.Text;
                if (ckb_siConsuNociTabaHabToxi.Checked == true)
                {
                    inicial.inicial_siConsuNocivosTabaco = "Si";
                }
                if (ckb_noConsuNociTabaHabToxi.Checked == true)
                {
                    inicial.inicial_noConsuNocivosTabaco = "No";
                }
                inicial.inicial_tiempoConsuConsuNocivosTabaco = Convert.ToInt32(txt_tiemConConsuNociTabaHabToxi.Text);
                inicial.inicial_cantidadConsuNocivosTabaco = txt_cantiConsuNociTabaHabToxi.Text;
                inicial.inicial_exConsumiConsuNocivosTabaco = txt_exConsumiConsuNociTabaHabToxi.Text;
                inicial.inicial_tiempoAbstiConsuNocivosTabaco = Convert.ToInt32(txt_tiemAbstiConsuNociTabaHabToxi.Text);
                if (ckb_siConsuNociAlcoHabToxi.Checked == true)
                {
                    inicial.inicial_siConsuNocivosAlcohol = "Si";
                }
                if (ckb_noConsuNociAlcoHabToxi.Checked == true)
                {
                    inicial.inicial_noConsuNocivosAlcohol = "No";
                }
                inicial.inicial_tiempoConsuConsuNocivosAlcohol = Convert.ToInt32(txt_tiemConConsuNociAlcoHabToxi.Text);
                inicial.inicial_cantidadConsuNocivosAlcohol = txt_cantiConsuNociAlcoHabToxi.Text;
                inicial.inicial_exConsumiConsuNocivosAlcohol = txt_exConsumiConsuNociAlcoHabToxi.Text;
                inicial.inicial_tiempoAbstiConsuNocivosAlcohol = Convert.ToInt32(txt_tiemAbstiConsuNociAlcoHabToxi.Text);
                if (ckb_siConsuNociOtrasDroHabToxi.Checked == true)
                {
                    inicial.inicial_siConsuNocivosOtrasDrogas = "Si";
                }
                if (ckb_noConsuNociOtrasDroHabToxi.Checked == true)
                {
                    inicial.inicial_noConsuNocivosOtrasDrogas = "No";
                }
                inicial.inicial_tiempoConsu1ConsuNocivosOtrasDrogas = Convert.ToInt32(txt_tiemCon1ConsuNociOtrasDroHabToxi.Text);
                inicial.inicial_cantidad1ConsuNocivosOtrasDrogas = txt_canti1ConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_exConsumi1ConsuNocivosOtrasDrogas = txt_exConsumi1ConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_tiempoAbsti1ConsuNocivosOtrasDrogas = Convert.ToInt32(txt_tiemAbsti1ConsuNociOtrasDroHabToxi.Text);
                inicial.inicial_otrasConsuNocivos = txt_otrasConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_tiempoConsu2ConsuNocivosOtrasDrogas = Convert.ToInt32(txt_tiemCon2ConsuNociOtrasDroHabToxi.Text);
                inicial.inicial_cantidad2ConsuNocivosOtrasDrogas = txt_canti2ConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_exConsumi2ConsuNocivosOtrasDrogas = txt_exConsumi2ConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_tiempoAbsti2ConsuNocivosOtrasDrogas = Convert.ToInt32(txt_tiemAbsti2ConsuNociOtrasDroHabToxi.Text);
                if (ckb_siEstVidaActFisiEstVida.Checked == true)
                {
                    inicial.inicial_siEstiVidaActFisica = "Si";
                }
                if (ckb_noEstVidaActFisiEstVida.Checked == true)
                {
                    inicial.inicial_noEstiVidaActFisica = "No";
                }
                inicial.inicial_cualEstiVidaActFisica = txt_cualEstVidaActFisiEstVida.Text;
                inicial.inicial_tiem_cantEstiVidaActFisica = txt_tiemCanEstVidaActFisiEstVida.Text;
                if (ckb_siEstVidaMedHabiEstVida.Checked == true)
                {
                    inicial.inicial_siEstiVidaMediHabitual = "Si";
                }
                if (ckb_noEstVidaMedHabiEstVida.Checked == true)
                {
                    inicial.inicial_noEstiVidaMediHabitual = "No";
                }
                inicial.inicial_cual2EstiVidaMediHabitual = txt_cual1EstVidaMedHabiEstVida.Text;
                inicial.inicial_tiem_cant2EstiVidaMediHabitual = txt_tiemCan1EstVidaMedHabiEstVida.Text;
                inicial.inicial_cual3EstiVidaMediHabitual = txt_cual2EstVidaMedHabiEstVida.Text;
                inicial.inicial_tiem_cant3EstiVidaMediHabitual = txt_tiemCan2EstVidaMedHabiEstVida.Text;
                inicial.inicial_cual4EstiVidaMediHabitual = txt_cual3EstVidaMedHabiEstVida.Text;
                inicial.inicial_tiem_cant4EstiVidaMediHabitual = txt_tiemCan3EstVidaMedHabiEstVida.Text;
                inicial.inicial_nomEmpresa = txt_empresa.Text;
                inicial.inicial_puestoTrabajo = txt_puestotrabajo.Text;
                inicial.inicial_actDesemp = txt_actdesempeña.Text;
                inicial.inicial_tiemTrabajo = txt_tiempotrabajo.Text;
                if (ckb_fisico.Checked == true)
                {
                    inicial.inicial_fisicoRies = "Si";
                }
                if (ckb_mecanico.Checked == true)
                {
                    inicial.inicial_mecanicoRies = "Si";
                }
                if (ckb_quimico.Checked == true)
                {
                    inicial.inicial_quimicoRies = "Si";
                }
                if (ckb_biologico.Checked == true)
                {
                    inicial.inicial_biologicoRies = "Si";
                }
                if (ckb_ergonomico.Checked == true)
                {
                    inicial.inicial_ergonomicoRies = "Si";
                }
                if (ckb_psicosocial.Checked == true)
                {
                    inicial.inicial_psicosocial = "Si";
                }
                inicial.inicial_observacionesAnteEmpleAnteriores = txt_obseantempleanteriores.Text;
                if (ckb_fisico2.Checked == true)
                {
                    inicial.inicial_fisicoRies2 = "Si";
                }
                if (ckb_mecanico2.Checked == true)
                {
                    inicial.inicial_mecanicoRies2 = "Si";
                }
                if (ckb_quimico2.Checked == true)
                {
                    inicial.inicial_quimicoRies2 = "Si";
                }
                if (ckb_biologico2.Checked == true)
                {
                    inicial.inicial_biologicoRies2 = "Si";
                }
                if (ckb_ergonomico2.Checked == true)
                {
                    inicial.inicial_ergonomicoRies2 = "Si";
                }
                if (ckb_psicosocial2.Checked == true)
                {
                    inicial.inicial_psicosocial2 = "Si";
                }
                inicial.inicial_observacionesAnteEmpleAnteriores2 = txt_obseantempleanteriores.Text;
                if (ckb_fisico3.Checked == true)
                {
                    inicial.inicial_fisicoRies3 = "Si";
                }
                if (ckb_mecanico3.Checked == true)
                {
                    inicial.inicial_mecanicoRies3 = "Si";
                }
                if (ckb_quimico3.Checked == true)
                {
                    inicial.inicial_quimicoRies3 = "Si";
                }
                if (ckb_biologico3.Checked == true)
                {
                    inicial.inicial_biologicoRies3 = "Si";
                }
                if (ckb_ergonomico3.Checked == true)
                {
                    inicial.inicial_ergonomicoRies3 = "Si";
                }
                if (ckb_psicosocial3.Checked == true)
                {
                    inicial.inicial_psicosocial3 = "Si";
                }
                inicial.inicial_observacionesAnteEmpleAnteriores3 = txt_obseantempleanteriores.Text;
                if (ckb_fisico4.Checked == true)
                {
                    inicial.inicial_fisicoRies4 = "Si";
                }
                if (ckb_mecanico4.Checked == true)
                {
                    inicial.inicial_mecanicoRies4 = "Si";
                }
                if (ckb_quimico4.Checked == true)
                {
                    inicial.inicial_quimicoRies4 = "Si";
                }
                if (ckb_biologico4.Checked == true)
                {
                    inicial.inicial_biologicoRies4 = "Si";
                }
                if (ckb_ergonomico4.Checked == true)
                {
                    inicial.inicial_ergonomicoRies4 = "Si";
                }
                if (ckb_psicosocial4.Checked == true)
                {
                    inicial.inicial_psicosocial4 = "Si";
                }
                inicial.inicial_observacionesAnteEmpleAnteriores4 = txt_obseantempleanteriores.Text;
                if (ckb_siAccTrabDescrip.Checked == true)
                {
                    inicial.inicial_siCalificadoIESSAcciTrabajo = "Si";
                }
                inicial.inicial_especificarCalificadoIESSAcciTrabajo = txt_especificar.Text;
                if (ckb_noAccTrabDescrip.Checked == true)
                {
                    inicial.inicial_noCalificadoIESSAcciTrabajo = "No";
                }
                inicial.inicial_fechaCalificadoIESSAcciTrabajo = Convert.ToDateTime(txt_fecha.Text);
                inicial.inicial_obserAcciTrabajo = txt_observaciones2.Text;
                if (ckb_siprofesional.Checked == true)
                {
                    inicial.inicial_siCalificadoIESSEnfProfesionales = "Si";
                }
                inicial.inicial_especificarCalificadoIESSEnfProfesionales = txt_espeprofesional.Text;
                if (ckb_noprofesional.Checked == true)
                {
                    inicial.inicial_noCalificadoIESSEnfProfesionales = "No";
                }
                inicial.inicial_fechaCalificadoIESSEnfProfesionales = Convert.ToDateTime(txt_fechaprofesional.Text);
                inicial.inicial_obserEnfProfesionales = txt_observaciones3.Text;
                if (ckb_enfermedadcardiovascular.Checked == true)
                {
                    inicial.inicial_enfCarVasAnteFamiliares = "Si";
                }
                if (ckb_enfermedadmetabolica.Checked == true)
                {
                    inicial.inicial_enfMetaAnteFamiliares = "Si";
                }
                if (ckb_enfermedadneurologica.Checked == true)
                {
                    inicial.inicial_enfNeuroAnteFamiliares = "Si";
                }
                if (ckb_enfermedadoncologica.Checked == true)
                {
                    inicial.inicial_enfOncoAnteFamiliares = "Si";
                }
                if (ckb_enfermedadinfecciosa.Checked == true)
                {
                    inicial.inicial_enfInfeAnteFamiliares = "Si";
                }
                if (ckb_enfermedadhereditaria.Checked == true)
                {
                    inicial.inicial_enfHereCongeAnteFamiliares = "Si";
                }
                if (ckb_discapacidades.Checked == true)
                {
                    inicial.inicial_discapaAnteFamiliares = "Si";
                }
                if (ckb_otrosenfer.Checked == true)
                {
                    inicial.inicial_otrosAnteFamiliares = "Si";
                }
                inicial.inicial_descripcionAnteFamiliares = txt_descripcionantefamiliares.Text;
                inicial.inicial_area = txt_puestodetrabajo.Text;
                inicial.inicial_actividades = txt_act.Text;
                if (ckb_tempaltas.Checked == true)
                {
                    inicial.inicial_temAltasFis = "Si";
                }
                if (ckb_tempbajas.Checked == true)
                {
                    inicial.inicial_temBajasFis = "Si";
                }
                if (ckb_radiacion.Checked == true)
                {
                    inicial.inicial_radIonizanteFis = "Si";
                }
                if (ckb_noradiacion.Checked == true)
                {
                    inicial.inicial_radNoIonizanteFis = "Si";
                }
                if (ckb_ruido.Checked == true)
                {
                    inicial.inicial_ruidoFis = "Si";
                }
                if (ckb_vibracion.Checked == true)
                {
                    inicial.inicial_vibracionFis = "Si";
                }
                if (ckb_iluminacion.Checked == true)
                {
                    inicial.inicial_iluminacionFis = "Si";
                }
                if (ckb_ventilacion.Checked == true)
                {
                    inicial.inicial_ventilacionFis = "Si";
                }
                if (ckb_fluidoelectrico.Checked == true)
                {
                    inicial.inicial_fluElectricoFis = "Si";
                }
                if (ckb_otrosFisico.Checked == true)
                {
                    inicial.inicial_otrosFis = "Si";
                }
                inicial.inicial_area2 = txt_puestodetrabajo.Text;
                inicial.inicial_actividades2 = txt_act.Text;
                if (ckb_tempaltas2.Checked == true)
                {
                    inicial.inicial_temAltasFis2 = "Si";
                }
                if (ckb_tempbajas2.Checked == true)
                {
                    inicial.inicial_temBajasFis2 = "Si";
                }
                if (ckb_radiacion2.Checked == true)
                {
                    inicial.inicial_radIonizanteFis2 = "Si";
                }
                if (ckb_noradiacion2.Checked == true)
                {
                    inicial.inicial_radNoIonizanteFis2 = "Si";
                }
                if (ckb_ruido2.Checked == true)
                {
                    inicial.inicial_ruidoFis2 = "Si";
                }
                if (ckb_vibracion2.Checked == true)
                {
                    inicial.inicial_vibracionFis2 = "Si";
                }
                if (ckb_iluminacion2.Checked == true)
                {
                    inicial.inicial_iluminacionFis2 = "Si";
                }
                if (ckb_ventilacion2.Checked == true)
                {
                    inicial.inicial_ventilacionFis2 = "Si";
                }
                if (ckb_fluidoelectrico2.Checked == true)
                {
                    inicial.inicial_fluElectricoFis2 = "Si";
                }
                if (ckb_otrosFisico2.Checked == true)
                {
                    inicial.inicial_otrosFis2 = "Si";
                }
                inicial.inicial_area3 = txt_puestodetrabajo.Text;
                inicial.inicial_actividades3 = txt_act.Text;
                if (ckb_tempaltas3.Checked == true)
                {
                    inicial.inicial_temAltasFis3 = "Si";
                }
                if (ckb_tempbajas3.Checked == true)
                {
                    inicial.inicial_temBajasFis3 = "Si";
                }
                if (ckb_radiacion3.Checked == true)
                {
                    inicial.inicial_radIonizanteFis3 = "Si";
                }
                if (ckb_noradiacion3.Checked == true)
                {
                    inicial.inicial_radNoIonizanteFis3 = "Si";
                }
                if (ckb_ruido3.Checked == true)
                {
                    inicial.inicial_ruidoFis3 = "Si";
                }
                if (ckb_vibracion3.Checked == true)
                {
                    inicial.inicial_vibracionFis3 = "Si";
                }
                if (ckb_iluminacion3.Checked == true)
                {
                    inicial.inicial_iluminacionFis3 = "Si";
                }
                if (ckb_ventilacion3.Checked == true)
                {
                    inicial.inicial_ventilacionFis3 = "Si";
                }
                if (ckb_fluidoelectrico3.Checked == true)
                {
                    inicial.inicial_fluElectricoFis3 = "Si";
                }
                if (ckb_otrosFisico3.Checked == true)
                {
                    inicial.inicial_otrosFis3 = "Si";
                }
                inicial.inicial_area4 = txt_puestodetrabajo.Text;
                inicial.inicial_actividades4 = txt_act.Text;
                if (ckb_tempaltas4.Checked == true)
                {
                    inicial.inicial_temAltasFis4 = "Si";
                }
                if (ckb_tempbajas4.Checked == true)
                {
                    inicial.inicial_temBajasFis4 = "Si";
                }
                if (ckb_radiacion4.Checked == true)
                {
                    inicial.inicial_radIonizanteFis4 = "Si";
                }
                if (ckb_noradiacion4.Checked == true)
                {
                    inicial.inicial_radNoIonizanteFis4 = "Si";
                }
                if (ckb_ruido4.Checked == true)
                {
                    inicial.inicial_ruidoFis4 = "Si";
                }
                if (ckb_vibracion4.Checked == true)
                {
                    inicial.inicial_vibracionFis4 = "Si";
                }
                if (ckb_iluminacion4.Checked == true)
                {
                    inicial.inicial_iluminacionFis4 = "Si";
                }
                if (ckb_ventilacion4.Checked == true)
                {
                    inicial.inicial_ventilacionFis4 = "Si";
                }
                if (ckb_fluidoelectrico4.Checked == true)
                {
                    inicial.inicial_fluElectricoFis4 = "Si";
                }
                if (ckb_otrosFisico4.Checked == true)
                {
                    inicial.inicial_otrosFis4 = "Si";
                }
                if (ckb_atrapmaquinas.Checked == true)
                {
                    inicial.inicial_atraMaquinasMec = "Si";
                }
                if (ckb_atrapsuperficie.Checked == true)
                {
                    inicial.inicial_atraSuperfiiesMec = "Si";
                }
                if (ckb_atrapobjetos.Checked == true)
                {
                    inicial.inicial_atraObjetosMec = "Si";
                }
                if (ckb_caidaobjetos.Checked == true)
                {
                    inicial.inicial_caidaObjetosMec = "Si";
                }
                if (ckb_caidamisnivel.Checked == true)
                {
                    inicial.inicial_caidaMisNivelMec = "Si";
                }
                if (ckb_caidadifnivel.Checked == true)
                {
                    inicial.inicial_caidaDifNivelMec = "Si";
                }
                if (ckb_contaelectrico.Checked == true)
                {
                    inicial.inicial_contactoElecMec = "Si";
                }
                if (ckb_contasuptrabajo.Checked == true)
                {
                    inicial.inicial_conSuperTrabaMec = "Si";
                }
                if (ckb_proyparticulas.Checked == true)
                {
                    inicial.inicial_proPartiFragMec = "Si";
                }
                if (ckb_proyefluidos.Checked == true)
                {
                    inicial.inicial_proFluidosMec = "Si";
                }
                if (ckb_pinchazos.Checked == true)
                {
                    inicial.inicial_pinchazosMec = "Si";
                }
                if (ckb_cortes.Checked == true)
                {
                    inicial.inicial_cortesMec = "Si";
                }
                if (ckb_atroporvehiculos.Checked == true)
                {
                    inicial.inicial_atropeVehiMec = "Si";
                }
                if (ckb_choques.Checked == true)
                {
                    inicial.inicial_coliVehiMec = "Si";
                }
                if (ckb_otrosMecanico.Checked == true)
                {
                    inicial.inicial_otrosMec = "Si";
                }
                if (ckb_solidos.Checked == true)
                {
                    inicial.inicial_solidosQui = "Si";
                }
                if (ckb_polvos.Checked == true)
                {
                    inicial.inicial_polvosQui = "Si";
                }
                if (ckb_humos.Checked == true)
                {
                    inicial.inicial_humosQui = "Si";
                }
                if (ckb_liquidos.Checked == true)
                {
                    inicial.inicial_liquidosQui = "Si";
                }
                if (ckb_vapores.Checked == true)
                {
                    inicial.inicial_vaporesQui = "Si";
                }
                if (ckb_aerosoles.Checked == true)
                {
                    inicial.inicial_aerosolesQui = "Si";
                }
                if (ckb_neblinas.Checked == true)
                {
                    inicial.inicial_neblinasQui = "Si";
                }
                if (ckb_gaseosos.Checked == true)
                {
                    inicial.inicial_gaseososQui = "Si";
                }
                if (ckb_otrosQuimico.Checked == true)
                {
                    inicial.inicial_otrosQui = "Si";
                }
                if (ckb_atrapmaquinas2.Checked == true)
                {
                    inicial.inicial_atraMaquinasMec2 = "Si";
                }
                if (ckb_atrapsuperficie2.Checked == true)
                {
                    inicial.inicial_atraSuperfiiesMec2 = "Si";
                }
                if (ckb_atrapobjetos2.Checked == true)
                {
                    inicial.inicial_atraObjetosMec2 = "Si";
                }
                if (ckb_caidaobjetos2.Checked == true)
                {
                    inicial.inicial_caidaObjetosMec2 = "Si";
                }
                if (ckb_caidamisnivel2.Checked == true)
                {
                    inicial.inicial_caidaMisNivelMec2 = "Si";
                }
                if (ckb_caidadifnivel2.Checked == true)
                {
                    inicial.inicial_caidaDifNivelMec2 = "Si";
                }
                if (ckb_contaelectrico2.Checked == true)
                {
                    inicial.inicial_contactoElecMec2 = "Si";
                }
                if (ckb_contasuptrabajo2.Checked == true)
                {
                    inicial.inicial_conSuperTrabaMec2 = "Si";
                }
                if (ckb_proyparticulas2.Checked == true)
                {
                    inicial.inicial_proPartiFragMec2 = "Si";
                }
                if (ckb_proyefluidos2.Checked == true)
                {
                    inicial.inicial_proFluidosMec2 = "Si";
                }
                if (ckb_pinchazos2.Checked == true)
                {
                    inicial.inicial_pinchazosMec2 = "Si";
                }
                if (ckb_cortes2.Checked == true)
                {
                    inicial.inicial_cortesMec2 = "Si";
                }
                if (ckb_atroporvehiculos2.Checked == true)
                {
                    inicial.inicial_atropeVehiMec2 = "Si";
                }
                if (ckb_choques2.Checked == true)
                {
                    inicial.inicial_coliVehiMec2 = "Si";
                }
                if (ckb_otrosMecanico2.Checked == true)
                {
                    inicial.inicial_otrosMec2 = "Si";
                }
                if (ckb_solidos2.Checked == true)
                {
                    inicial.inicial_solidosQui2 = "Si";
                }
                if (ckb_polvos2.Checked == true)
                {
                    inicial.inicial_polvosQui2 = "Si";
                }
                if (ckb_humos2.Checked == true)
                {
                    inicial.inicial_humosQui2 = "Si";
                }
                if (ckb_liquidos2.Checked == true)
                {
                    inicial.inicial_liquidosQui2 = "Si";
                }
                if (ckb_vapores2.Checked == true)
                {
                    inicial.inicial_vaporesQui2 = "Si";
                }
                if (ckb_aerosoles2.Checked == true)
                {
                    inicial.inicial_aerosolesQui2 = "Si";
                }
                if (ckb_neblinas2.Checked == true)
                {
                    inicial.inicial_neblinasQui2 = "Si";
                }
                if (ckb_gaseosos2.Checked == true)
                {
                    inicial.inicial_gaseososQui2 = "Si";
                }
                if (ckb_otrosQuimico2.Checked == true)
                {
                    inicial.inicial_otrosQui2 = "Si";
                }
                if (ckb_atrapmaquinas3.Checked == true)
                {
                    inicial.inicial_atraMaquinasMec3 = "Si";
                }
                if (ckb_atrapsuperficie3.Checked == true)
                {
                    inicial.inicial_atraSuperfiiesMec3 = "Si";
                }
                if (ckb_atrapobjetos3.Checked == true)
                {
                    inicial.inicial_atraObjetosMec3 = "Si";
                }
                if (ckb_caidaobjetos3.Checked == true)
                {
                    inicial.inicial_caidaObjetosMec3 = "Si";
                }
                if (ckb_caidamisnivel3.Checked == true)
                {
                    inicial.inicial_caidaMisNivelMec3 = "Si";
                }
                if (ckb_caidadifnivel3.Checked == true)
                {
                    inicial.inicial_caidaDifNivelMec3 = "Si";
                }
                if (ckb_contaelectrico3.Checked == true)
                {
                    inicial.inicial_contactoElecMec3 = "Si";
                }
                if (ckb_contasuptrabajo3.Checked == true)
                {
                    inicial.inicial_conSuperTrabaMec3 = "Si";
                }
                if (ckb_proyparticulas3.Checked == true)
                {
                    inicial.inicial_proPartiFragMec3 = "Si";
                }
                if (ckb_proyefluidos3.Checked == true)
                {
                    inicial.inicial_proFluidosMec3 = "Si";
                }
                if (ckb_pinchazos3.Checked == true)
                {
                    inicial.inicial_pinchazosMec3 = "Si";
                }
                if (ckb_cortes3.Checked == true)
                {
                    inicial.inicial_cortesMec3 = "Si";
                }
                if (ckb_atroporvehiculos3.Checked == true)
                {
                    inicial.inicial_atropeVehiMec3 = "Si";
                }
                if (ckb_choques3.Checked == true)
                {
                    inicial.inicial_coliVehiMec3 = "Si";
                }
                if (ckb_otrosMecanico3.Checked == true)
                {
                    inicial.inicial_otrosMec3 = "Si";
                }
                if (ckb_solidos3.Checked == true)
                {
                    inicial.inicial_solidosQui3 = "Si";
                }
                if (ckb_polvos3.Checked == true)
                {
                    inicial.inicial_polvosQui3 = "Si";
                }
                if (ckb_humos3.Checked == true)
                {
                    inicial.inicial_humosQui3 = "Si";
                }
                if (ckb_liquidos3.Checked == true)
                {
                    inicial.inicial_liquidosQui3 = "Si";
                }
                if (ckb_vapores3.Checked == true)
                {
                    inicial.inicial_vaporesQui3 = "Si";
                }
                if (ckb_aerosoles3.Checked == true)
                {
                    inicial.inicial_aerosolesQui3 = "Si";
                }
                if (ckb_neblinas3.Checked == true)
                {
                    inicial.inicial_neblinasQui3 = "Si";
                }
                if (ckb_gaseosos3.Checked == true)
                {
                    inicial.inicial_gaseososQui3 = "Si";
                }
                if (ckb_otrosQuimico3.Checked == true)
                {
                    inicial.inicial_otrosQui3 = "Si";
                }
                if (ckb_atrapmaquinas4.Checked == true)
                {
                    inicial.inicial_atraMaquinasMec4 = "Si";
                }
                if (ckb_atrapsuperficie4.Checked == true)
                {
                    inicial.inicial_atraSuperfiiesMec4 = "Si";
                }
                if (ckb_atrapobjetos4.Checked == true)
                {
                    inicial.inicial_atraObjetosMec4 = "Si";
                }
                if (ckb_caidaobjetos4.Checked == true)
                {
                    inicial.inicial_caidaObjetosMec4 = "Si";
                }
                if (ckb_caidamisnivel4.Checked == true)
                {
                    inicial.inicial_caidaMisNivelMec4 = "Si";
                }
                if (ckb_caidadifnivel4.Checked == true)
                {
                    inicial.inicial_caidaDifNivelMec4 = "Si";
                }
                if (ckb_contaelectrico4.Checked == true)
                {
                    inicial.inicial_contactoElecMec4 = "Si";
                }
                if (ckb_contasuptrabajo4.Checked == true)
                {
                    inicial.inicial_conSuperTrabaMec4 = "Si";
                }
                if (ckb_proyparticulas4.Checked == true)
                {
                    inicial.inicial_proPartiFragMec4 = "Si";
                }
                if (ckb_proyefluidos4.Checked == true)
                {
                    inicial.inicial_proFluidosMec4 = "Si";
                }
                if (ckb_pinchazos4.Checked == true)
                {
                    inicial.inicial_pinchazosMec4 = "Si";
                }
                if (ckb_cortes4.Checked == true)
                {
                    inicial.inicial_cortesMec4 = "Si";
                }
                if (ckb_atroporvehiculos4.Checked == true)
                {
                    inicial.inicial_atropeVehiMec4 = "Si";
                }
                if (ckb_choques4.Checked == true)
                {
                    inicial.inicial_coliVehiMec4 = "Si";
                }
                if (ckb_otrosMecanico4.Checked == true)
                {
                    inicial.inicial_otrosMec4 = "Si";
                }
                if (ckb_solidos4.Checked == true)
                {
                    inicial.inicial_solidosQui4 = "Si";
                }
                if (ckb_polvos4.Checked == true)
                {
                    inicial.inicial_polvosQui4 = "Si";
                }
                if (ckb_humos4.Checked == true)
                {
                    inicial.inicial_humosQui4 = "Si";
                }
                if (ckb_liquidos4.Checked == true)
                {
                    inicial.inicial_liquidosQui4 = "Si";
                }
                if (ckb_vapores4.Checked == true)
                {
                    inicial.inicial_vaporesQui4 = "Si";
                }
                if (ckb_aerosoles4.Checked == true)
                {
                    inicial.inicial_aerosolesQui4 = "Si";
                }
                if (ckb_neblinas4.Checked == true)
                {
                    inicial.inicial_neblinasQui4 = "Si";
                }
                if (ckb_gaseosos4.Checked == true)
                {
                    inicial.inicial_gaseososQui4 = "Si";
                }
                if (ckb_otrosQuimico4.Checked == true)
                {
                    inicial.inicial_otrosQui4 = "Si";
                }
                inicial.inicial_puestoTrabajo = txt_puestodetrabajo21.Text;
                inicial.inicial_actividades = txt_act21.Text;
                if (ckb_virus.Checked == true)
                {
                    inicial.inicial_virusBio = "Si";
                }
                if (ckb_hongos.Checked == true)
                {
                    inicial.inicial_hongosBio = "Si";
                }
                if (ckb_bacterias.Checked == true)
                {
                    inicial.inicial_bacteriasBio = "Si";
                }
                if (ckb_parasitos.Checked == true)
                {
                    inicial.inicial_parasitosBio = "Si";
                }
                if (ckb_expoavectores.Checked == true)
                {
                    inicial.inicial_expVectBio = "Si";
                }
                if (ckb_expoanimselvaticos.Checked == true)
                {
                    inicial.inicial_expAniSelvaBio = "Si";
                }
                if (ckb_otrosBiologico.Checked == true)
                {
                    inicial.inicial_otrosBio = "Si";
                }
                if (ckb_manmanualcargas.Checked == true)
                {
                    inicial.inicial_maneManCarErg = "Si";
                }
                if (ckb_movrepetitivo.Checked == true)
                {
                    inicial.inicial_movRepeErg = "Si";
                }
                if (ckb_postforzadas.Checked == true)
                {
                    inicial.inicial_posForzaErg = "Si";
                }
                if (ckb_trabajopvd.Checked == true)
                {
                    inicial.inicial_trabPvdErg = "Si";
                }
                if (ckb_otrosErgonomico.Checked == true)
                {
                    inicial.inicial_otrosErg = "Si";
                }
                inicial.inicial_puestoTrabajo2 = txt_puestodetrabajo22.Text;
                inicial.inicial_actividades2 = txt_act22.Text;
                if (ckb_virus2.Checked == true)
                {
                    inicial.inicial_virusBio2 = "Si";
                }
                if (ckb_hongos2.Checked == true)
                {
                    inicial.inicial_hongosBio2 = "Si";
                }
                if (ckb_bacterias2.Checked == true)
                {
                    inicial.inicial_bacteriasBio2 = "Si";
                }
                if (ckb_parasitos2.Checked == true)
                {
                    inicial.inicial_parasitosBio2 = "Si";
                }
                if (ckb_expoavectores2.Checked == true)
                {
                    inicial.inicial_expVectBio2 = "Si";
                }
                if (ckb_expoanimselvaticos2.Checked == true)
                {
                    inicial.inicial_expAniSelvaBio2 = "Si";
                }
                if (ckb_otrosBiologico2.Checked == true)
                {
                    inicial.inicial_otrosBio2 = "Si";
                }
                if (ckb_manmanualcargas2.Checked == true)
                {
                    inicial.inicial_maneManCarErg2 = "Si";
                }
                if (ckb_movrepetitivo2.Checked == true)
                {
                    inicial.inicial_movRepeErg2 = "Si";
                }
                if (ckb_postforzadas2.Checked == true)
                {
                    inicial.inicial_posForzaErg2 = "Si";
                }
                if (ckb_trabajopvd2.Checked == true)
                {
                    inicial.inicial_trabPvdErg2 = "Si";
                }
                if (ckb_otrosErgonomico2.Checked == true)
                {
                    inicial.inicial_otrosErg2 = "Si";
                }
                inicial.inicial_puestoTrabajo3 = txt_puestodetrabajo23.Text;
                inicial.inicial_actividades3 = txt_act23.Text;
                if (ckb_virus3.Checked == true)
                {
                    inicial.inicial_virusBio3 = "Si";
                }
                if (ckb_hongos3.Checked == true)
                {
                    inicial.inicial_hongosBio3 = "Si";
                }
                if (ckb_bacterias3.Checked == true)
                {
                    inicial.inicial_bacteriasBio3 = "Si";
                }
                if (ckb_parasitos3.Checked == true)
                {
                    inicial.inicial_parasitosBio3 = "Si";
                }
                if (ckb_expoavectores3.Checked == true)
                {
                    inicial.inicial_expVectBio3 = "Si";
                }
                if (ckb_expoanimselvaticos3.Checked == true)
                {
                    inicial.inicial_expAniSelvaBio3 = "Si";
                }
                if (ckb_otrosBiologico3.Checked == true)
                {
                    inicial.inicial_otrosBio3 = "Si";
                }
                if (ckb_manmanualcargas3.Checked == true)
                {
                    inicial.inicial_maneManCarErg3 = "Si";
                }
                if (ckb_movrepetitivo3.Checked == true)
                {
                    inicial.inicial_movRepeErg3 = "Si";
                }
                if (ckb_postforzadas3.Checked == true)
                {
                    inicial.inicial_posForzaErg3 = "Si";
                }
                if (ckb_trabajopvd3.Checked == true)
                {
                    inicial.inicial_trabPvdErg3 = "Si";
                }
                if (ckb_otrosErgonomico3.Checked == true)
                {
                    inicial.inicial_otrosErg3 = "Si";
                }
                inicial.inicial_puestoTrabajo4 = txt_puestodetrabajo24.Text;
                inicial.inicial_actividades4 = txt_act24.Text;
                if (ckb_virus4.Checked == true)
                {
                    inicial.inicial_virusBio4 = "Si";
                }
                if (ckb_hongos4.Checked == true)
                {
                    inicial.inicial_hongosBio4 = "Si";
                }
                if (ckb_bacterias4.Checked == true)
                {
                    inicial.inicial_bacteriasBio4 = "Si";
                }
                if (ckb_parasitos4.Checked == true)
                {
                    inicial.inicial_parasitosBio4 = "Si";
                }
                if (ckb_expoavectores4.Checked == true)
                {
                    inicial.inicial_expVectBio4 = "Si";
                }
                if (ckb_expoanimselvaticos4.Checked == true)
                {
                    inicial.inicial_expAniSelvaBio4 = "Si";
                }
                if (ckb_otrosBiologico4.Checked == true)
                {
                    inicial.inicial_otrosBio4 = "Si";
                }
                if (ckb_manmanualcargas4.Checked == true)
                {
                    inicial.inicial_maneManCarErg4 = "Si";
                }
                if (ckb_movrepetitivo4.Checked == true)
                {
                    inicial.inicial_movRepeErg4 = "Si";
                }
                if (ckb_postforzadas4.Checked == true)
                {
                    inicial.inicial_posForzaErg4 = "Si";
                }
                if (ckb_trabajopvd4.Checked == true)
                {
                    inicial.inicial_trabPvdErg4 = "Si";
                }
                if (ckb_otrosErgonomico4.Checked == true)
                {
                    inicial.inicial_otrosErg4 = "Si";
                }
                if (ckb_montrabajo.Checked == true)
                {
                    inicial.inicial_monoTrabPsi = "Si";
                }
                if (ckb_sobrecargalaboral.Checked == true)
                {
                    inicial.inicial_sobrecarLabPsi = "Si";
                }
                if (ckb_minustarea.Checked == true)
                {
                    inicial.inicial_minuTareaPsi = "Si";
                }
                if (ckb_altarespon.Checked == true)
                {
                    inicial.inicial_altaResponPsi = "Si";
                }
                if (ckb_automadesiciones.Checked == true)
                {
                    inicial.inicial_autoTomaDesiPsi = "Si";
                }
                if (ckb_supyestdireficiente.Checked == true)
                {
                    inicial.inicial_supEstDirecDefiPsi = "Si";
                }
                if (ckb_conflictorol.Checked == true)
                {
                    inicial.inicial_conflicRolPsi = "Si";
                }
                if (ckb_faltaclarfunciones.Checked == true)
                {
                    inicial.inicial_falClariFunPsi = "Si";
                }
                if (ckb_incorrdistrabajo.Checked == true)
                {
                    inicial.inicial_incoDistriTrabPsi = "Si";
                }
                if (ckb_turnorotat.Checked == true)
                {
                    inicial.inicial_turnosRotaPsi = "Si";
                }
                if (ckb_relacinterpersonales.Checked == true)
                {
                    inicial.inicial_relInterperPsi = "Si";
                }
                if (ckb_inestalaboral.Checked == true)
                {
                    inicial.inicial_inesLabPsi = "Si";
                }
                if (ckb_otrosPsicosocial.Checked == true)
                {
                    inicial.inicial_otrosPsi = "Si";
                }
                inicial.inicial_medPreventivas = txt_medpreventivas.Text;
                if (ckb_montrabajo2.Checked == true)
                {
                    inicial.inicial_monoTrabPsi2 = "Si";
                }
                if (ckb_sobrecargalaboral2.Checked == true)
                {
                    inicial.inicial_sobrecarLabPsi2 = "Si";
                }
                if (ckb_minustarea2.Checked == true)
                {
                    inicial.inicial_minuTareaPsi2 = "Si";
                }
                if (ckb_altarespon2.Checked == true)
                {
                    inicial.inicial_altaResponPsi2 = "Si";
                }
                if (ckb_automadesiciones2.Checked == true)
                {
                    inicial.inicial_autoTomaDesiPsi2 = "Si";
                }
                if (ckb_supyestdireficiente2.Checked == true)
                {
                    inicial.inicial_supEstDirecDefiPsi2 = "Si";
                }
                if (ckb_conflictorol2.Checked == true)
                {
                    inicial.inicial_conflicRolPsi2 = "Si";
                }
                if (ckb_faltaclarfunciones2.Checked == true)
                {
                    inicial.inicial_falClariFunPsi2 = "Si";
                }
                if (ckb_incorrdistrabajo2.Checked == true)
                {
                    inicial.inicial_incoDistriTrabPsi2 = "Si";
                }
                if (ckb_turnorotat2.Checked == true)
                {
                    inicial.inicial_turnosRotaPsi2 = "Si";
                }
                if (ckb_relacinterpersonales2.Checked == true)
                {
                    inicial.inicial_relInterperPsi2 = "Si";
                }
                if (ckb_inestalaboral2.Checked == true)
                {
                    inicial.inicial_inesLabPsi2 = "Si";
                }
                if (ckb_otrosPsicosocial2.Checked == true)
                {
                    inicial.inicial_otrosPsi2 = "Si";
                }
                inicial.inicial_medPreventivas2 = txt_medpreventivas2.Text;
                if (ckb_montrabajo3.Checked == true)
                {
                    inicial.inicial_monoTrabPsi3 = "Si";
                }
                if (ckb_sobrecargalaboral3.Checked == true)
                {
                    inicial.inicial_sobrecarLabPsi3 = "Si";
                }
                if (ckb_minustarea3.Checked == true)
                {
                    inicial.inicial_minuTareaPsi3 = "Si";
                }
                if (ckb_altarespon3.Checked == true)
                {
                    inicial.inicial_altaResponPsi3 = "Si";
                }
                if (ckb_automadesiciones3.Checked == true)
                {
                    inicial.inicial_autoTomaDesiPsi3 = "Si";
                }
                if (ckb_supyestdireficiente3.Checked == true)
                {
                    inicial.inicial_supEstDirecDefiPsi3 = "Si";
                }
                if (ckb_conflictorol3.Checked == true)
                {
                    inicial.inicial_conflicRolPsi3 = "Si";
                }
                if (ckb_faltaclarfunciones3.Checked == true)
                {
                    inicial.inicial_falClariFunPsi3 = "Si";
                }
                if (ckb_incorrdistrabajo3.Checked == true)
                {
                    inicial.inicial_incoDistriTrabPsi3 = "Si";
                }
                if (ckb_turnorotat3.Checked == true)
                {
                    inicial.inicial_turnosRotaPsi3 = "Si";
                }
                if (ckb_relacinterpersonales3.Checked == true)
                {
                    inicial.inicial_relInterperPsi3 = "Si";
                }
                if (ckb_inestalaboral3.Checked == true)
                {
                    inicial.inicial_inesLabPsi3 = "Si";
                }
                if (ckb_otrosPsicosocial3.Checked == true)
                {
                    inicial.inicial_otrosPsi3 = "Si";
                }
                inicial.inicial_medPreventivas3 = txt_medpreventivas3.Text;
                if (ckb_montrabajo4.Checked == true)
                {
                    inicial.inicial_monoTrabPsi4 = "Si";
                }
                if (ckb_sobrecargalaboral4.Checked == true)
                {
                    inicial.inicial_sobrecarLabPsi4 = "Si";
                }
                if (ckb_minustarea4.Checked == true)
                {
                    inicial.inicial_minuTareaPsi4 = "Si";
                }
                if (ckb_altarespon4.Checked == true)
                {
                    inicial.inicial_altaResponPsi4 = "Si";
                }
                if (ckb_automadesiciones4.Checked == true)
                {
                    inicial.inicial_autoTomaDesiPsi4 = "Si";
                }
                if (ckb_supyestdireficiente4.Checked == true)
                {
                    inicial.inicial_supEstDirecDefiPsi4 = "Si";
                }
                if (ckb_conflictorol4.Checked == true)
                {
                    inicial.inicial_conflicRolPsi4 = "Si";
                }
                if (ckb_faltaclarfunciones4.Checked == true)
                {
                    inicial.inicial_falClariFunPsi4 = "Si";
                }
                if (ckb_incorrdistrabajo4.Checked == true)
                {
                    inicial.inicial_incoDistriTrabPsi4 = "Si";
                }
                if (ckb_turnorotat4.Checked == true)
                {
                    inicial.inicial_turnosRotaPsi4 = "Si";
                }
                if (ckb_relacinterpersonales4.Checked == true)
                {
                    inicial.inicial_relInterperPsi4 = "Si";
                }
                if (ckb_inestalaboral4.Checked == true)
                {
                    inicial.inicial_inesLabPsi4 = "Si";
                }
                if (ckb_otrosPsicosocial4.Checked == true)
                {
                    inicial.inicial_otrosPsi4 = "Si";
                }
                inicial.inicial_medPreventivas4 = txt_medpreventivas4.Text;
                inicial.inicial_descripActExtLab = txt_descrextralaborales.Text;
                inicial.inicial_descripEnfActual = txt_enfermedadactualinicial.Text;
                if (ckb_pielanexos.Checked == true)
                {
                    inicial.inicial_pielAnexos = "Si";
                }
                if (ckb_respiratorio.Checked == true)
                {
                    inicial.inicial_respiratorio = "Si";
                }
                if (ckb_digestivo.Checked == true)
                {
                    inicial.inicial_digestivo = "Si";
                }
                if (ckb_musculosesqueleticos.Checked == true)
                {
                    inicial.inicial_muscEsqueletico = "Si";
                }
                if (ckb_hemolinfatico.Checked == true)
                {
                    inicial.inicial_hemoLimfa = "Si";
                }
                if (ckb_organossentidos.Checked == true)
                {
                    inicial.inicial_orgSentidos = "Si";
                }
                if (ckb_cardiovascular.Checked == true)
                {
                    inicial.inicial_cardVascular = "Si";
                }
                if (ckb_genitourinario.Checked == true)
                {
                    inicial.inicial_genUrinario = "Si";
                }
                if (ckb_endocrino.Checked == true)
                {
                    inicial.inicial_endocrino = "Si";
                }
                if (ckb_nervioso.Checked == true)
                {
                    inicial.inicial_nervioso = "Si";
                }
                inicial.inicial_descripRevActOrgSis = txt_descrorganosysistemas.Text;
                inicial.inicial_preArterial = txt_preArterial.Text;
                inicial.inicial_temperatura = Convert.ToInt32(txt_temperatura.Text);
                inicial.inicial_frecCardiacan = Convert.ToInt32(txt_freCardica.Text);
                inicial.inicial_satOxigenon = Convert.ToInt32(txt_satOxigeno.Text);
                inicial.inicial_frecRespiratorian = Convert.ToInt32(txt_freRespiratoria.Text);
                inicial.inicial_peson = Convert.ToInt32(txt_peso.Text);
                inicial.inicial_tallan = Convert.ToInt32(txt_talla.Text);
                inicial.inicial_indMasCorporaln = Convert.ToInt32(txt_imc.Text);
                inicial.inicial_perAbdominaln = Convert.ToInt32(txt_perAbdominal.Text);
                if (ckb_cicatrices.Checked == true)
                {
                    inicial.inicial_cicatricesPiel = "Si";
                }
                if (ckb_auditivoexterno.Checked == true)
                {
                    inicial.inicial_cAudiExtreOido = "Si";
                }
                if (ckb_tabique.Checked == true)
                {
                    inicial.inicial_tabiqueNariz = "Si";
                }
                if (ckb_pulmones.Checked == true)
                {
                    inicial.inicial_pulmonesTorax2 = "Si";
                }
                if (ckb_pelvis.Checked == true)
                {
                    inicial.inicial_pelvisPelvis = "Si";
                }
                if (ckb_tatuajes.Checked == true)
                {
                    inicial.inicial_tatuajesPiel = "Si";
                }
                if (ckb_pabellon.Checked == true)
                {
                    inicial.inicial_pabellonOido = "Si";
                }
                if (ckb_cornetes.Checked == true)
                {
                    inicial.inicial_cornetesNariz = "Si";
                }
                if (ckb_parrillacostal.Checked == true)
                {
                    inicial.inicial_parriCostalTorax2 = "Si";
                }
                if (ckb_genitales.Checked == true)
                {
                    inicial.inicial_genitalesPelvis = "Si";
                }
                if (ckb_pielyfaneras.Checked == true)
                {
                    inicial.inicial_pielFacerasPiel = "Si";
                }
                if (ckb_timpanos.Checked == true)
                {
                    inicial.inicial_timpanosOido = "Si";
                }
                if (ckb_mucosa.Checked == true)
                {
                    inicial.inicial_mucosasNariz = "Si";
                }
                if (ckb_visceras.Checked == true)
                {
                    inicial.inicial_viscerasAbdomen = "Si";
                }
                if (ckb_vascular.Checked == true)
                {
                    inicial.inicial_vascularExtre = "Si";
                }
                if (ckb_parpados.Checked == true)
                {
                    inicial.inicial_parpadosOjos = "Si";
                }
                if (ckb_labios.Checked == true)
                {
                    inicial.inicial_labiosOroFa = "Si";
                }
                if (ckb_senosparanasales.Checked == true)
                {
                    inicial.inicial_senosParanaNariz = "Si";
                }
                if (ckb_paredabdominal.Checked == true)
                {
                    inicial.inicial_paredAbdomiAbdomen = "Si";
                }
                if (ckb_miembrosuperiores.Checked == true)
                {
                    inicial.inicial_miemSupeExtre = "Si";
                }
                if (ckb_conjuntivas.Checked == true)
                {
                    inicial.inicial_conjuntuvasOjos = "Si";
                }
                if (ckb_lengua.Checked == true)
                {
                    inicial.inicial_lenguaOroFa = "Si";
                }
                if (ckb_tiroides.Checked == true)
                {
                    inicial.inicial_tiroiMasasCuello = "Si";
                }
                if (ckb_flexibilidad.Checked == true)
                {
                    inicial.inicial_flexibilidadColumna = "Si";
                }
                if (ckb_miembrosinferiores.Checked == true)
                {
                    inicial.inicial_miemInfeExtre = "Si";
                }
                if (ckb_pupilas.Checked == true)
                {
                    inicial.inicial_pupilasOjos = "Si";
                }
                if (ckb_faringe.Checked == true)
                {
                    inicial.inicial_faringeOroFa = "Si";
                }
                if (ckb_movilidad.Checked == true)
                {
                    inicial.inicial_movilidadCuello = "Si";
                }
                if (ckb_desviacion.Checked == true)
                {
                    inicial.inicial_desviacionColumna = "Si";
                }
                if (ckb_fuerza.Checked == true)
                {
                    inicial.inicial_fuerzaNeuro = "Si";
                }
                if (ckb_cornea.Checked == true)
                {
                    inicial.inicial_corneaOjos = "Si";
                }
                if (ckb_amigdalas.Checked == true)
                {
                    inicial.inicial_amigdalasOroFa = "Si";
                }
                if (ckb_mamas.Checked == true)
                {
                    inicial.inicial_mamasTorax = "Si";
                }
                if (ckb_sensibilidad.Checked == true)
                {
                    inicial.inicial_sensibiNeuro = "Si";
                }
                if (ckb_motilidad.Checked == true)
                {
                    inicial.inicial_motilidadOjos = "Si";
                }
                if (ckb_dentadura.Checked == true)
                {
                    inicial.inicial_dentaduraOroFa = "Si";
                }
                if (ckb_corazon.Checked == true)
                {
                    inicial.inicial_corazonTorax = "Si";
                }
                if (ckb_dolor.Checked == true)
                {
                    inicial.inicial_dolorColumna = "Si";
                }
                if (ckb_marcha.Checked == true)
                {
                    inicial.inicial_marchaNeuro = "Si";
                }
                if (ckb_reflejos.Checked == true)
                {
                    inicial.inicial_refleNeuro = "Si";
                }
                inicial.inicial_observaExaFisRegInicial = txt_obervexamenfisicoregional.Text;
                inicial.inicial_examen = txt_examen.Text;
                inicial.inicial_fecha = Convert.ToDateTime(txt_fechaexamen.Text);
                inicial.inicial_resultados = txt_resultadoexamen.Text;
                inicial.inicial_examen2 = txt_examen2.Text;
                inicial.inicial_fecha2 = Convert.ToDateTime(txt_fechaexamen2.Text);
                inicial.inicial_resultados2 = txt_resultadoexamen2.Text;
                inicial.inicial_examen3 = txt_examen3.Text;
                inicial.inicial_fecha3 = Convert.ToDateTime(txt_fechaexamen3.Text);
                inicial.inicial_resultados3 = txt_resultadoexamen3.Text;
                inicial.inicial_examen4 = txt_examen4.Text;
                inicial.inicial_fecha4 = Convert.ToDateTime(txt_fechaexamen4.Text);
                inicial.inicial_resultados4 = txt_resultadoexamen4.Text;
                inicial.inicial_observacionesResExaGenEspRiesTrabajo = txt_observacionexamen.Text;

                inicial.inicial_descripciondiagnostico = txt_descripdiagnostico.Text;
                inicial.inicial_cie = txt_cie.Text;
                if (ckb_pre.Checked == true)
                {
                    inicial.inicial_pre = "Si";
                }
                if (ckb_def.Checked == true)
                {
                    inicial.inicial_def = "Si";
                }
                inicial.inicial_descripcioninicialnostico2 = txt_descripdiagnostico2.Text;
                inicial.inicial_cie2 = txt_cie2.Text;
                if (ckb_pre2.Checked == true)
                {
                    inicial.inicial_pre2 = "Si";
                }
                if (ckb_def2.Checked == true)
                {
                    inicial.inicial_def2 = "Si";
                }
                inicial.inicial_descripcioninicialnostico3 = txt_descripdiagnostico3.Text;
                inicial.inicial_cie3 = txt_cie3.Text;
                if (ckb_pre3.Checked == true)
                {
                    inicial.inicial_pre3 = "Si";
                }
                if (ckb_def3.Checked == true)
                {
                    inicial.inicial_def3 = "Si";
                }
                if (ckb_apto.Checked == true)
                {
                    inicial.inicial_apto = "Si";
                }
                if (ckb_aptoobservacion.Checked == true)
                {
                    inicial.inicial_aptoObserva = "Si";
                }
                if (ckb_aptolimitacion.Checked == true)
                {
                    inicial.inicial_aptoLimi = "Si";
                }
                if (ckb_noapto.Checked == true)
                {
                    inicial.inicial_NoApto = "Si";
                }
                inicial.inicial_ObservAptMed = txt_observacionaptitud.Text;
                inicial.inicial_LimitAptMed = txt_limitacionaptitud.Text;
                inicial.inicial_descripcionRecTra = txt_descripciontratamiento.Text;
                inicial.inicial_fecha_hora = Convert.ToDateTime(txt_fechahora.Text);
                inicial.prof_id = Convert.ToInt32(ddl_profesional.SelectedValue);
                inicial.inicial_cod = txt_codigoDatProf.Text;
                inicial.Per_id = perso;

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
                if (ckb_catolica.Checked == true)
                {
                    inicial.inicial_catolicaRel = "Si";
                }
                if (ckb_evangelica.Checked == true)
                {
                    inicial.inicial_evangelicaRel = "Si";
                }
                if (cbk_testigo.Checked == true)
                {
                    inicial.inicial_testJehovaRel = "Si";
                }
                if (cbk_mormona.Checked == true)
                {
                    inicial.inicial_mormonaRel = "Si";
                }
                if (cbk_otrareligion.Checked == true)
                {
                    inicial.inicial_otrasRel = "Si";
                }
                inicial.inicial_groSanguineo = txt_gruposanguineo.Text;
                inicial.inicial_lateralidad = txt_lateralidad.Text;
                if (cbk_gay.Checked == true)
                {
                    inicial.inicial_gayOriSex = "Si";
                }
                if (cbk_lesbiana.Checked == true)
                {
                    inicial.inicial__lesbianaOriSex = "Si";
                }
                if (cbk_bisexual.Checked == true)
                {
                    inicial.inicial_bisexualOriSex = "Si";
                }
                if (cbk_heterosexual.Checked == true)
                {
                    inicial.inicial_heterosexualOriSex = "Si";
                }
                if (cbk_noRespondeOriSex.Checked == true)
                {
                    inicial.inicial_norespondeOriSex = "Si";
                }
                if (cbk_femenino.Checked == true)
                {
                    inicial.inicial_femeninoIdenGen = "Si";
                }
                if (cbk_masculino.Checked == true)
                {
                    inicial.inicial_masculinoIdenGen = "Si";
                }
                if (cbk_transfemenino.Checked == true)
                {
                    inicial.inicial_transFemeninoIdenGen = "Si";
                }
                if (cbk_transmasculino.Checked == true)
                {
                    inicial.inicial_transMasculinoIdenGen = "Si";
                }
                if (cbk_noRespondeIdeGen.Checked == true)
                {
                    inicial.inicial_norespondeIdenGen = "Si";
                }
                if (cbk_sidiscapacidad.Checked == true)
                {
                    inicial.inicial_siDis = "Si";
                }
                if (cbk_nodiscapacidad.Checked == true)
                {
                    inicial.inicial_noDis = "No";
                }
                inicial.inicial_tipoDis = txt_tipodiscapacidad.Text;
                inicial.inicial_porcentDis = Convert.ToInt32(txt_porcentajediscapacidad.Text);
                inicial.inicial_actRelePuesTrabajo = txt_actividadesrelevantes.Text;
                inicial.inicial_descripcionMotivoConsulta = txt_motivoconsultainicial.Text;
                inicial.inicial_descripcionAnteceCliniQuirur = txt_antCliQuiDescripcion.Text;
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
                if (ckb_siVidSexAntGinObste.Checked == true)
                {
                    inicial.inicial_siVidaSexActiva = "Si";
                }
                if (ckb_noVidSexAntGinObste.Checked == true)
                {
                    inicial.inicial_noVidaSexActiva = "No";
                }
                if (ckb_siMetPlaniAntGinObste.Checked == true)
                {
                    inicial.inicial_siMetPlanifiFamiliar = "Si";
                }
                if (ckb_noMetPlaniAntGinObste.Checked == true)
                {
                    inicial.inicial_noMetPlanifiFamiliar = "No";
                }
                inicial.inicial_tipoMetPlanifiFamiliar = txt_tipoMetPlaniAntGinObste.Text;
                if (ckb_siPapaniAntGinObste.Checked == true)
                {
                    inicial.inicial_siExaRealiPapanicolaou = "Si";
                }
                if (ckb_noPapaniAntGinObste.Checked == true)
                {
                    inicial.inicial_noExaRealiPapanicolaou = "No";
                }
                inicial.inicial_tiempoExaRealiPapanicolaou = Convert.ToInt32(txt_tiempoPapaniAntGinObste.Text);
                inicial.inicial_resultadoExaRealiPapanicolaou = txt_resultadoPapaniAntGinObste.Text;
                if (ckb_siEcoMamaAntGinObste.Checked == true)
                {
                    inicial.inicial_siExaRealiEcoMamario = "Si";
                }
                if (ckb_noEcoMamaAntGinObste.Checked == true)
                {
                    inicial.inicial_noExaRealiEcoMamario = "No";
                }
                inicial.inicial_tiempoExaRealiEcoMamario = Convert.ToInt32(txt_tiempoEcoMamaAntGinObste.Text);
                inicial.inicial_resultadoExaRealiEcoMamario = txt_resultadoEcoMamaAntGinObste.Text;
                if (ckb_siColposAntGinObste.Checked == true)
                {
                    inicial.inicial_siExaRealiColposcopia = "Si";
                }
                if (ckb_noColposAntGinObste.Checked == true)
                {
                    inicial.inicial_noExaRealiColposcopia = "No";
                }
                inicial.inicial_tiempoExaRealiColposcopia = Convert.ToInt32(txt_tiempoColposAntGinObste.Text);
                inicial.inicial_resultadoExaRealiColposcopia = txt_resultadoColposAntGinObste.Text;
                if (ckb_siMamograAntGinObste.Checked == true)
                {
                    inicial.inicial_siExaRealiMamografia = "Si";
                }
                if (ckb_noMamograAntGinObste.Checked == true)
                {
                    inicial.inicial_noExaRealiMamografia = "No";
                }
                inicial.inicial_tiempoExaRealiMamografia = Convert.ToInt32(txt_tiempoMamograAntGinObste.Text);
                inicial.inicial_resultadoExaRealiMamografia = txt_resultadoMamograAntGinObste.Text;
                if (ckb_siExaRealiAntProstaAntReproMascu.Checked == true)
                {
                    inicial.inicial_siExaRealiAntiProstatico = "Si";
                }
                if (ckb_noExaRealiAntProstaAntReproMascu.Checked == true)
                {
                    inicial.inicial_noExaRealiAntiProstatico = "No";
                }
                inicial.inicial_tiempoExaRealiAntiProstatico = Convert.ToInt32(txt_tiempoExaRealiAntProstaAntReproMascu.Text);
                inicial.inicial_resultadoExaRealiAntiProstatico = txt_resultadoExaRealiAntProstaAntReproMascu.Text;
                if (ckb_siMetPlaniAntReproMascu.Checked == true)
                {
                    inicial.inicial_siMetPlanifiFamiAntReproMascu = "Si";
                }
                if (ckb_noMetPlaniAntReproMascu.Checked == true)
                {
                    inicial.inicial_noMetPlanifiFamiAntReproMascu = "No";
                }
                inicial.inicial_tipo1MetPlanifiFamiAntReproMascu = txt_tipo1MetPlaniAntReproMascu.Text;
                inicial.inicial_vivosHijAntReproMascu = Convert.ToInt32(txt_vivosHijosAntReproMascu.Text);
                inicial.inicial_muertosHijAntReproMascu = Convert.ToInt32(txt_muertosHijosAntReproMascu.Text);
                if (ckb_siExaRealiEcoProstaAntReproMascu.Checked == true)
                {
                    inicial.inicial_siExaRealiEcoProstatico = "Si";
                }
                if (ckb_noExaRealiEcoProstaAntReproMascu.Checked == true)
                {
                    inicial.inicial_noExaRealiEcoProstatico = "No";
                }
                inicial.inicial_tiempoExaRealiEcoProstatico = Convert.ToInt32(txt_tiempoExaRealiEcoProstaAntReproMascu.Text);
                inicial.inicial_resultadoExaRealiEcoProstatico = txt_resultadoExaRealiEcoProstaAntReproMascu.Text;
                inicial.inicial_tipo2MetPlanifiFamiAntReproMascu = txt_tipo2MetPlaniAntReproMascu.Text;
                if (ckb_siConsuNociTabaHabToxi.Checked == true)
                {
                    inicial.inicial_siConsuNocivosTabaco = "Si";
                }
                if (ckb_noConsuNociTabaHabToxi.Checked == true)
                {
                    inicial.inicial_noConsuNocivosTabaco = "No";
                }
                inicial.inicial_tiempoConsuConsuNocivosTabaco = Convert.ToInt32(txt_tiemConConsuNociTabaHabToxi.Text);
                inicial.inicial_cantidadConsuNocivosTabaco = txt_cantiConsuNociTabaHabToxi.Text;
                inicial.inicial_exConsumiConsuNocivosTabaco = txt_exConsumiConsuNociTabaHabToxi.Text;
                inicial.inicial_tiempoAbstiConsuNocivosTabaco = Convert.ToInt32(txt_tiemAbstiConsuNociTabaHabToxi.Text);
                if (ckb_siConsuNociAlcoHabToxi.Checked == true)
                {
                    inicial.inicial_siConsuNocivosAlcohol = "Si";
                }
                if (ckb_noConsuNociAlcoHabToxi.Checked == true)
                {
                    inicial.inicial_noConsuNocivosAlcohol = "No";
                }
                inicial.inicial_tiempoConsuConsuNocivosAlcohol = Convert.ToInt32(txt_tiemConConsuNociAlcoHabToxi.Text);
                inicial.inicial_cantidadConsuNocivosAlcohol = txt_cantiConsuNociAlcoHabToxi.Text;
                inicial.inicial_exConsumiConsuNocivosAlcohol = txt_exConsumiConsuNociAlcoHabToxi.Text;
                inicial.inicial_tiempoAbstiConsuNocivosAlcohol = Convert.ToInt32(txt_tiemAbstiConsuNociAlcoHabToxi.Text);
                if (ckb_siConsuNociOtrasDroHabToxi.Checked == true)
                {
                    inicial.inicial_siConsuNocivosOtrasDrogas = "Si";
                }
                if (ckb_noConsuNociOtrasDroHabToxi.Checked == true)
                {
                    inicial.inicial_noConsuNocivosOtrasDrogas = "No";
                }
                inicial.inicial_tiempoConsu1ConsuNocivosOtrasDrogas = Convert.ToInt32(txt_tiemCon1ConsuNociOtrasDroHabToxi.Text);
                inicial.inicial_cantidad1ConsuNocivosOtrasDrogas = txt_canti1ConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_exConsumi1ConsuNocivosOtrasDrogas = txt_exConsumi1ConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_tiempoAbsti1ConsuNocivosOtrasDrogas = Convert.ToInt32(txt_tiemAbsti1ConsuNociOtrasDroHabToxi.Text);
                inicial.inicial_otrasConsuNocivos = txt_otrasConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_tiempoConsu2ConsuNocivosOtrasDrogas = Convert.ToInt32(txt_tiemCon2ConsuNociOtrasDroHabToxi.Text);
                inicial.inicial_cantidad2ConsuNocivosOtrasDrogas = txt_canti2ConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_exConsumi2ConsuNocivosOtrasDrogas = txt_exConsumi2ConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_tiempoAbsti2ConsuNocivosOtrasDrogas = Convert.ToInt32(txt_tiemAbsti2ConsuNociOtrasDroHabToxi.Text);
                if (ckb_siEstVidaActFisiEstVida.Checked == true)
                {
                    inicial.inicial_siEstiVidaActFisica = "Si";
                }
                if (ckb_noEstVidaActFisiEstVida.Checked == true)
                {
                    inicial.inicial_noEstiVidaActFisica = "No";
                }
                inicial.inicial_cualEstiVidaActFisica = txt_cualEstVidaActFisiEstVida.Text;
                inicial.inicial_tiem_cantEstiVidaActFisica = txt_tiemCanEstVidaActFisiEstVida.Text;
                if (ckb_siEstVidaMedHabiEstVida.Checked == true)
                {
                    inicial.inicial_siEstiVidaMediHabitual = "Si";
                }
                if (ckb_noEstVidaMedHabiEstVida.Checked == true)
                {
                    inicial.inicial_noEstiVidaMediHabitual = "No";
                }
                inicial.inicial_cual2EstiVidaMediHabitual = txt_cual1EstVidaMedHabiEstVida.Text;
                inicial.inicial_tiem_cant2EstiVidaMediHabitual = txt_tiemCan1EstVidaMedHabiEstVida.Text;
                inicial.inicial_cual3EstiVidaMediHabitual = txt_cual2EstVidaMedHabiEstVida.Text;
                inicial.inicial_tiem_cant3EstiVidaMediHabitual = txt_tiemCan2EstVidaMedHabiEstVida.Text;
                inicial.inicial_cual4EstiVidaMediHabitual = txt_cual3EstVidaMedHabiEstVida.Text;
                inicial.inicial_tiem_cant4EstiVidaMediHabitual = txt_tiemCan3EstVidaMedHabiEstVida.Text;
                inicial.inicial_nomEmpresa = txt_empresa.Text;
                inicial.inicial_puestoTrabajo = txt_puestotrabajo.Text;
                inicial.inicial_actDesemp = txt_actdesempeña.Text;
                inicial.inicial_tiemTrabajo = txt_tiempotrabajo.Text;
                if (ckb_fisico.Checked == true)
                {
                    inicial.inicial_fisicoRies = "Si";
                }
                if (ckb_mecanico.Checked == true)
                {
                    inicial.inicial_mecanicoRies = "Si";
                }
                if (ckb_quimico.Checked == true)
                {
                    inicial.inicial_quimicoRies = "Si";
                }
                if (ckb_biologico.Checked == true)
                {
                    inicial.inicial_biologicoRies = "Si";
                }
                if (ckb_ergonomico.Checked == true)
                {
                    inicial.inicial_ergonomicoRies = "Si";
                }
                if (ckb_psicosocial.Checked == true)
                {
                    inicial.inicial_psicosocial = "Si";
                }
                inicial.inicial_observacionesAnteEmpleAnteriores = txt_obseantempleanteriores.Text;
                if (ckb_fisico2.Checked == true)
                {
                    inicial.inicial_fisicoRies2 = "Si";
                }
                if (ckb_mecanico2.Checked == true)
                {
                    inicial.inicial_mecanicoRies2 = "Si";
                }
                if (ckb_quimico2.Checked == true)
                {
                    inicial.inicial_quimicoRies2 = "Si";
                }
                if (ckb_biologico2.Checked == true)
                {
                    inicial.inicial_biologicoRies2 = "Si";
                }
                if (ckb_ergonomico2.Checked == true)
                {
                    inicial.inicial_ergonomicoRies2 = "Si";
                }
                if (ckb_psicosocial2.Checked == true)
                {
                    inicial.inicial_psicosocial2 = "Si";
                }
                inicial.inicial_observacionesAnteEmpleAnteriores2 = txt_obseantempleanteriores.Text;
                if (ckb_fisico3.Checked == true)
                {
                    inicial.inicial_fisicoRies3 = "Si";
                }
                if (ckb_mecanico3.Checked == true)
                {
                    inicial.inicial_mecanicoRies3 = "Si";
                }
                if (ckb_quimico3.Checked == true)
                {
                    inicial.inicial_quimicoRies3 = "Si";
                }
                if (ckb_biologico3.Checked == true)
                {
                    inicial.inicial_biologicoRies3 = "Si";
                }
                if (ckb_ergonomico3.Checked == true)
                {
                    inicial.inicial_ergonomicoRies3 = "Si";
                }
                if (ckb_psicosocial3.Checked == true)
                {
                    inicial.inicial_psicosocial3 = "Si";
                }
                inicial.inicial_observacionesAnteEmpleAnteriores3 = txt_obseantempleanteriores.Text;
                if (ckb_fisico4.Checked == true)
                {
                    inicial.inicial_fisicoRies4 = "Si";
                }
                if (ckb_mecanico4.Checked == true)
                {
                    inicial.inicial_mecanicoRies4 = "Si";
                }
                if (ckb_quimico4.Checked == true)
                {
                    inicial.inicial_quimicoRies4 = "Si";
                }
                if (ckb_biologico4.Checked == true)
                {
                    inicial.inicial_biologicoRies4 = "Si";
                }
                if (ckb_ergonomico4.Checked == true)
                {
                    inicial.inicial_ergonomicoRies4 = "Si";
                }
                if (ckb_psicosocial4.Checked == true)
                {
                    inicial.inicial_psicosocial4 = "Si";
                }
                inicial.inicial_observacionesAnteEmpleAnteriores4 = txt_obseantempleanteriores.Text;
                if (ckb_siAccTrabDescrip.Checked == true)
                {
                    inicial.inicial_siCalificadoIESSAcciTrabajo = "Si";
                }
                inicial.inicial_especificarCalificadoIESSAcciTrabajo = txt_especificar.Text;
                if (ckb_noAccTrabDescrip.Checked == true)
                {
                    inicial.inicial_noCalificadoIESSAcciTrabajo = "No";
                }
                inicial.inicial_fechaCalificadoIESSAcciTrabajo = Convert.ToDateTime(txt_fecha.Text);
                inicial.inicial_obserAcciTrabajo = txt_observaciones2.Text;
                if (ckb_siprofesional.Checked == true)
                {
                    inicial.inicial_siCalificadoIESSEnfProfesionales = "Si";
                }
                inicial.inicial_especificarCalificadoIESSEnfProfesionales = txt_espeprofesional.Text;
                if (ckb_noprofesional.Checked == true)
                {
                    inicial.inicial_noCalificadoIESSEnfProfesionales = "No";
                }
                inicial.inicial_fechaCalificadoIESSEnfProfesionales = Convert.ToDateTime(txt_fechaprofesional.Text);
                inicial.inicial_obserEnfProfesionales = txt_observaciones3.Text;
                if (ckb_enfermedadcardiovascular.Checked == true)
                {
                    inicial.inicial_enfCarVasAnteFamiliares = "Si";
                }
                if (ckb_enfermedadmetabolica.Checked == true)
                {
                    inicial.inicial_enfMetaAnteFamiliares = "Si";
                }
                if (ckb_enfermedadneurologica.Checked == true)
                {
                    inicial.inicial_enfNeuroAnteFamiliares = "Si";
                }
                if (ckb_enfermedadoncologica.Checked == true)
                {
                    inicial.inicial_enfOncoAnteFamiliares = "Si";
                }
                if (ckb_enfermedadinfecciosa.Checked == true)
                {
                    inicial.inicial_enfInfeAnteFamiliares = "Si";
                }
                if (ckb_enfermedadhereditaria.Checked == true)
                {
                    inicial.inicial_enfHereCongeAnteFamiliares = "Si";
                }
                if (ckb_discapacidades.Checked == true)
                {
                    inicial.inicial_discapaAnteFamiliares = "Si";
                }
                if (ckb_otrosenfer.Checked == true)
                {
                    inicial.inicial_otrosAnteFamiliares = "Si";
                }
                inicial.inicial_descripcionAnteFamiliares = txt_descripcionantefamiliares.Text;
                inicial.inicial_area = txt_puestodetrabajo.Text;
                inicial.inicial_actividades = txt_act.Text;
                if (ckb_tempaltas.Checked == true)
                {
                    inicial.inicial_temAltasFis = "Si";
                }
                if (ckb_tempbajas.Checked == true)
                {
                    inicial.inicial_temBajasFis = "Si";
                }
                if (ckb_radiacion.Checked == true)
                {
                    inicial.inicial_radIonizanteFis = "Si";
                }
                if (ckb_noradiacion.Checked == true)
                {
                    inicial.inicial_radNoIonizanteFis = "Si";
                }
                if (ckb_ruido.Checked == true)
                {
                    inicial.inicial_ruidoFis = "Si";
                }
                if (ckb_vibracion.Checked == true)
                {
                    inicial.inicial_vibracionFis = "Si";
                }
                if (ckb_iluminacion.Checked == true)
                {
                    inicial.inicial_iluminacionFis = "Si";
                }
                if (ckb_ventilacion.Checked == true)
                {
                    inicial.inicial_ventilacionFis = "Si";
                }
                if (ckb_fluidoelectrico.Checked == true)
                {
                    inicial.inicial_fluElectricoFis = "Si";
                }
                if (ckb_otrosFisico.Checked == true)
                {
                    inicial.inicial_otrosFis = "Si";
                }
                inicial.inicial_area2 = txt_puestodetrabajo.Text;
                inicial.inicial_actividades2 = txt_act.Text;
                if (ckb_tempaltas2.Checked == true)
                {
                    inicial.inicial_temAltasFis2 = "Si";
                }
                if (ckb_tempbajas2.Checked == true)
                {
                    inicial.inicial_temBajasFis2 = "Si";
                }
                if (ckb_radiacion2.Checked == true)
                {
                    inicial.inicial_radIonizanteFis2 = "Si";
                }
                if (ckb_noradiacion2.Checked == true)
                {
                    inicial.inicial_radNoIonizanteFis2 = "Si";
                }
                if (ckb_ruido2.Checked == true)
                {
                    inicial.inicial_ruidoFis2 = "Si";
                }
                if (ckb_vibracion2.Checked == true)
                {
                    inicial.inicial_vibracionFis2 = "Si";
                }
                if (ckb_iluminacion2.Checked == true)
                {
                    inicial.inicial_iluminacionFis2 = "Si";
                }
                if (ckb_ventilacion2.Checked == true)
                {
                    inicial.inicial_ventilacionFis2 = "Si";
                }
                if (ckb_fluidoelectrico2.Checked == true)
                {
                    inicial.inicial_fluElectricoFis2 = "Si";
                }
                if (ckb_otrosFisico2.Checked == true)
                {
                    inicial.inicial_otrosFis2 = "Si";
                }
                inicial.inicial_area3 = txt_puestodetrabajo.Text;
                inicial.inicial_actividades3 = txt_act.Text;
                if (ckb_tempaltas3.Checked == true)
                {
                    inicial.inicial_temAltasFis3 = "Si";
                }
                if (ckb_tempbajas3.Checked == true)
                {
                    inicial.inicial_temBajasFis3 = "Si";
                }
                if (ckb_radiacion3.Checked == true)
                {
                    inicial.inicial_radIonizanteFis3 = "Si";
                }
                if (ckb_noradiacion3.Checked == true)
                {
                    inicial.inicial_radNoIonizanteFis3 = "Si";
                }
                if (ckb_ruido3.Checked == true)
                {
                    inicial.inicial_ruidoFis3 = "Si";
                }
                if (ckb_vibracion3.Checked == true)
                {
                    inicial.inicial_vibracionFis3 = "Si";
                }
                if (ckb_iluminacion3.Checked == true)
                {
                    inicial.inicial_iluminacionFis3 = "Si";
                }
                if (ckb_ventilacion3.Checked == true)
                {
                    inicial.inicial_ventilacionFis3 = "Si";
                }
                if (ckb_fluidoelectrico3.Checked == true)
                {
                    inicial.inicial_fluElectricoFis3 = "Si";
                }
                if (ckb_otrosFisico3.Checked == true)
                {
                    inicial.inicial_otrosFis3 = "Si";
                }
                inicial.inicial_area4 = txt_puestodetrabajo.Text;
                inicial.inicial_actividades4 = txt_act.Text;
                if (ckb_tempaltas4.Checked == true)
                {
                    inicial.inicial_temAltasFis4 = "Si";
                }
                if (ckb_tempbajas4.Checked == true)
                {
                    inicial.inicial_temBajasFis4 = "Si";
                }
                if (ckb_radiacion4.Checked == true)
                {
                    inicial.inicial_radIonizanteFis4 = "Si";
                }
                if (ckb_noradiacion4.Checked == true)
                {
                    inicial.inicial_radNoIonizanteFis4 = "Si";
                }
                if (ckb_ruido4.Checked == true)
                {
                    inicial.inicial_ruidoFis4 = "Si";
                }
                if (ckb_vibracion4.Checked == true)
                {
                    inicial.inicial_vibracionFis4 = "Si";
                }
                if (ckb_iluminacion4.Checked == true)
                {
                    inicial.inicial_iluminacionFis4 = "Si";
                }
                if (ckb_ventilacion4.Checked == true)
                {
                    inicial.inicial_ventilacionFis4 = "Si";
                }
                if (ckb_fluidoelectrico4.Checked == true)
                {
                    inicial.inicial_fluElectricoFis4 = "Si";
                }
                if (ckb_otrosFisico4.Checked == true)
                {
                    inicial.inicial_otrosFis4 = "Si";
                }
                if (ckb_atrapmaquinas.Checked == true)
                {
                    inicial.inicial_atraMaquinasMec = "Si";
                }
                if (ckb_atrapsuperficie.Checked == true)
                {
                    inicial.inicial_atraSuperfiiesMec = "Si";
                }
                if (ckb_atrapobjetos.Checked == true)
                {
                    inicial.inicial_atraObjetosMec = "Si";
                }
                if (ckb_caidaobjetos.Checked == true)
                {
                    inicial.inicial_caidaObjetosMec = "Si";
                }
                if (ckb_caidamisnivel.Checked == true)
                {
                    inicial.inicial_caidaMisNivelMec = "Si";
                }
                if (ckb_caidadifnivel.Checked == true)
                {
                    inicial.inicial_caidaDifNivelMec = "Si";
                }
                if (ckb_contaelectrico.Checked == true)
                {
                    inicial.inicial_contactoElecMec = "Si";
                }
                if (ckb_contasuptrabajo.Checked == true)
                {
                    inicial.inicial_conSuperTrabaMec = "Si";
                }
                if (ckb_proyparticulas.Checked == true)
                {
                    inicial.inicial_proPartiFragMec = "Si";
                }
                if (ckb_proyefluidos.Checked == true)
                {
                    inicial.inicial_proFluidosMec = "Si";
                }
                if (ckb_pinchazos.Checked == true)
                {
                    inicial.inicial_pinchazosMec = "Si";
                }
                if (ckb_cortes.Checked == true)
                {
                    inicial.inicial_cortesMec = "Si";
                }
                if (ckb_atroporvehiculos.Checked == true)
                {
                    inicial.inicial_atropeVehiMec = "Si";
                }
                if (ckb_choques.Checked == true)
                {
                    inicial.inicial_coliVehiMec = "Si";
                }
                if (ckb_otrosMecanico.Checked == true)
                {
                    inicial.inicial_otrosMec = "Si";
                }
                if (ckb_solidos.Checked == true)
                {
                    inicial.inicial_solidosQui = "Si";
                }
                if (ckb_polvos.Checked == true)
                {
                    inicial.inicial_polvosQui = "Si";
                }
                if (ckb_humos.Checked == true)
                {
                    inicial.inicial_humosQui = "Si";
                }
                if (ckb_liquidos.Checked == true)
                {
                    inicial.inicial_liquidosQui = "Si";
                }
                if (ckb_vapores.Checked == true)
                {
                    inicial.inicial_vaporesQui = "Si";
                }
                if (ckb_aerosoles.Checked == true)
                {
                    inicial.inicial_aerosolesQui = "Si";
                }
                if (ckb_neblinas.Checked == true)
                {
                    inicial.inicial_neblinasQui = "Si";
                }
                if (ckb_gaseosos.Checked == true)
                {
                    inicial.inicial_gaseososQui = "Si";
                }
                if (ckb_otrosQuimico.Checked == true)
                {
                    inicial.inicial_otrosQui = "Si";
                }
                if (ckb_atrapmaquinas2.Checked == true)
                {
                    inicial.inicial_atraMaquinasMec2 = "Si";
                }
                if (ckb_atrapsuperficie2.Checked == true)
                {
                    inicial.inicial_atraSuperfiiesMec2 = "Si";
                }
                if (ckb_atrapobjetos2.Checked == true)
                {
                    inicial.inicial_atraObjetosMec2 = "Si";
                }
                if (ckb_caidaobjetos2.Checked == true)
                {
                    inicial.inicial_caidaObjetosMec2 = "Si";
                }
                if (ckb_caidamisnivel2.Checked == true)
                {
                    inicial.inicial_caidaMisNivelMec2 = "Si";
                }
                if (ckb_caidadifnivel2.Checked == true)
                {
                    inicial.inicial_caidaDifNivelMec2 = "Si";
                }
                if (ckb_contaelectrico2.Checked == true)
                {
                    inicial.inicial_contactoElecMec2 = "Si";
                }
                if (ckb_contasuptrabajo2.Checked == true)
                {
                    inicial.inicial_conSuperTrabaMec2 = "Si";
                }
                if (ckb_proyparticulas2.Checked == true)
                {
                    inicial.inicial_proPartiFragMec2 = "Si";
                }
                if (ckb_proyefluidos2.Checked == true)
                {
                    inicial.inicial_proFluidosMec2 = "Si";
                }
                if (ckb_pinchazos2.Checked == true)
                {
                    inicial.inicial_pinchazosMec2 = "Si";
                }
                if (ckb_cortes2.Checked == true)
                {
                    inicial.inicial_cortesMec2 = "Si";
                }
                if (ckb_atroporvehiculos2.Checked == true)
                {
                    inicial.inicial_atropeVehiMec2 = "Si";
                }
                if (ckb_choques2.Checked == true)
                {
                    inicial.inicial_coliVehiMec2 = "Si";
                }
                if (ckb_otrosMecanico2.Checked == true)
                {
                    inicial.inicial_otrosMec2 = "Si";
                }
                if (ckb_solidos2.Checked == true)
                {
                    inicial.inicial_solidosQui2 = "Si";
                }
                if (ckb_polvos2.Checked == true)
                {
                    inicial.inicial_polvosQui2 = "Si";
                }
                if (ckb_humos2.Checked == true)
                {
                    inicial.inicial_humosQui2 = "Si";
                }
                if (ckb_liquidos2.Checked == true)
                {
                    inicial.inicial_liquidosQui2 = "Si";
                }
                if (ckb_vapores2.Checked == true)
                {
                    inicial.inicial_vaporesQui2 = "Si";
                }
                if (ckb_aerosoles2.Checked == true)
                {
                    inicial.inicial_aerosolesQui2 = "Si";
                }
                if (ckb_neblinas2.Checked == true)
                {
                    inicial.inicial_neblinasQui2 = "Si";
                }
                if (ckb_gaseosos2.Checked == true)
                {
                    inicial.inicial_gaseososQui2 = "Si";
                }
                if (ckb_otrosQuimico2.Checked == true)
                {
                    inicial.inicial_otrosQui2 = "Si";
                }
                if (ckb_atrapmaquinas3.Checked == true)
                {
                    inicial.inicial_atraMaquinasMec3 = "Si";
                }
                if (ckb_atrapsuperficie3.Checked == true)
                {
                    inicial.inicial_atraSuperfiiesMec3 = "Si";
                }
                if (ckb_atrapobjetos3.Checked == true)
                {
                    inicial.inicial_atraObjetosMec3 = "Si";
                }
                if (ckb_caidaobjetos3.Checked == true)
                {
                    inicial.inicial_caidaObjetosMec3 = "Si";
                }
                if (ckb_caidamisnivel3.Checked == true)
                {
                    inicial.inicial_caidaMisNivelMec3 = "Si";
                }
                if (ckb_caidadifnivel3.Checked == true)
                {
                    inicial.inicial_caidaDifNivelMec3 = "Si";
                }
                if (ckb_contaelectrico3.Checked == true)
                {
                    inicial.inicial_contactoElecMec3 = "Si";
                }
                if (ckb_contasuptrabajo3.Checked == true)
                {
                    inicial.inicial_conSuperTrabaMec3 = "Si";
                }
                if (ckb_proyparticulas3.Checked == true)
                {
                    inicial.inicial_proPartiFragMec3 = "Si";
                }
                if (ckb_proyefluidos3.Checked == true)
                {
                    inicial.inicial_proFluidosMec3 = "Si";
                }
                if (ckb_pinchazos3.Checked == true)
                {
                    inicial.inicial_pinchazosMec3 = "Si";
                }
                if (ckb_cortes3.Checked == true)
                {
                    inicial.inicial_cortesMec3 = "Si";
                }
                if (ckb_atroporvehiculos3.Checked == true)
                {
                    inicial.inicial_atropeVehiMec3 = "Si";
                }
                if (ckb_choques3.Checked == true)
                {
                    inicial.inicial_coliVehiMec3 = "Si";
                }
                if (ckb_otrosMecanico3.Checked == true)
                {
                    inicial.inicial_otrosMec3 = "Si";
                }
                if (ckb_solidos3.Checked == true)
                {
                    inicial.inicial_solidosQui3 = "Si";
                }
                if (ckb_polvos3.Checked == true)
                {
                    inicial.inicial_polvosQui3 = "Si";
                }
                if (ckb_humos3.Checked == true)
                {
                    inicial.inicial_humosQui3 = "Si";
                }
                if (ckb_liquidos3.Checked == true)
                {
                    inicial.inicial_liquidosQui3 = "Si";
                }
                if (ckb_vapores3.Checked == true)
                {
                    inicial.inicial_vaporesQui3 = "Si";
                }
                if (ckb_aerosoles3.Checked == true)
                {
                    inicial.inicial_aerosolesQui3 = "Si";
                }
                if (ckb_neblinas3.Checked == true)
                {
                    inicial.inicial_neblinasQui3 = "Si";
                }
                if (ckb_gaseosos3.Checked == true)
                {
                    inicial.inicial_gaseososQui3 = "Si";
                }
                if (ckb_otrosQuimico3.Checked == true)
                {
                    inicial.inicial_otrosQui3 = "Si";
                }
                if (ckb_atrapmaquinas4.Checked == true)
                {
                    inicial.inicial_atraMaquinasMec4 = "Si";
                }
                if (ckb_atrapsuperficie4.Checked == true)
                {
                    inicial.inicial_atraSuperfiiesMec4 = "Si";
                }
                if (ckb_atrapobjetos4.Checked == true)
                {
                    inicial.inicial_atraObjetosMec4 = "Si";
                }
                if (ckb_caidaobjetos4.Checked == true)
                {
                    inicial.inicial_caidaObjetosMec4 = "Si";
                }
                if (ckb_caidamisnivel4.Checked == true)
                {
                    inicial.inicial_caidaMisNivelMec4 = "Si";
                }
                if (ckb_caidadifnivel4.Checked == true)
                {
                    inicial.inicial_caidaDifNivelMec4 = "Si";
                }
                if (ckb_contaelectrico4.Checked == true)
                {
                    inicial.inicial_contactoElecMec4 = "Si";
                }
                if (ckb_contasuptrabajo4.Checked == true)
                {
                    inicial.inicial_conSuperTrabaMec4 = "Si";
                }
                if (ckb_proyparticulas4.Checked == true)
                {
                    inicial.inicial_proPartiFragMec4 = "Si";
                }
                if (ckb_proyefluidos4.Checked == true)
                {
                    inicial.inicial_proFluidosMec4 = "Si";
                }
                if (ckb_pinchazos4.Checked == true)
                {
                    inicial.inicial_pinchazosMec4 = "Si";
                }
                if (ckb_cortes4.Checked == true)
                {
                    inicial.inicial_cortesMec4 = "Si";
                }
                if (ckb_atroporvehiculos4.Checked == true)
                {
                    inicial.inicial_atropeVehiMec4 = "Si";
                }
                if (ckb_choques4.Checked == true)
                {
                    inicial.inicial_coliVehiMec4 = "Si";
                }
                if (ckb_otrosMecanico4.Checked == true)
                {
                    inicial.inicial_otrosMec4 = "Si";
                }
                if (ckb_solidos4.Checked == true)
                {
                    inicial.inicial_solidosQui4 = "Si";
                }
                if (ckb_polvos4.Checked == true)
                {
                    inicial.inicial_polvosQui4 = "Si";
                }
                if (ckb_humos4.Checked == true)
                {
                    inicial.inicial_humosQui4 = "Si";
                }
                if (ckb_liquidos4.Checked == true)
                {
                    inicial.inicial_liquidosQui4 = "Si";
                }
                if (ckb_vapores4.Checked == true)
                {
                    inicial.inicial_vaporesQui4 = "Si";
                }
                if (ckb_aerosoles4.Checked == true)
                {
                    inicial.inicial_aerosolesQui4 = "Si";
                }
                if (ckb_neblinas4.Checked == true)
                {
                    inicial.inicial_neblinasQui4 = "Si";
                }
                if (ckb_gaseosos4.Checked == true)
                {
                    inicial.inicial_gaseososQui4 = "Si";
                }
                if (ckb_otrosQuimico4.Checked == true)
                {
                    inicial.inicial_otrosQui4 = "Si";
                }
                inicial.inicial_puestoTrabajo = txt_puestodetrabajo21.Text;
                inicial.inicial_actividades = txt_act21.Text;
                if (ckb_virus.Checked == true)
                {
                    inicial.inicial_virusBio = "Si";
                }
                if (ckb_hongos.Checked == true)
                {
                    inicial.inicial_hongosBio = "Si";
                }
                if (ckb_bacterias.Checked == true)
                {
                    inicial.inicial_bacteriasBio = "Si";
                }
                if (ckb_parasitos.Checked == true)
                {
                    inicial.inicial_parasitosBio = "Si";
                }
                if (ckb_expoavectores.Checked == true)
                {
                    inicial.inicial_expVectBio = "Si";
                }
                if (ckb_expoanimselvaticos.Checked == true)
                {
                    inicial.inicial_expAniSelvaBio = "Si";
                }
                if (ckb_otrosBiologico.Checked == true)
                {
                    inicial.inicial_otrosBio = "Si";
                }
                if (ckb_manmanualcargas.Checked == true)
                {
                    inicial.inicial_maneManCarErg = "Si";
                }
                if (ckb_movrepetitivo.Checked == true)
                {
                    inicial.inicial_movRepeErg = "Si";
                }
                if (ckb_postforzadas.Checked == true)
                {
                    inicial.inicial_posForzaErg = "Si";
                }
                if (ckb_trabajopvd.Checked == true)
                {
                    inicial.inicial_trabPvdErg = "Si";
                }
                if (ckb_otrosErgonomico.Checked == true)
                {
                    inicial.inicial_otrosErg = "Si";
                }
                inicial.inicial_puestoTrabajo2 = txt_puestodetrabajo22.Text;
                inicial.inicial_actividades2 = txt_act22.Text;
                if (ckb_virus2.Checked == true)
                {
                    inicial.inicial_virusBio2 = "Si";
                }
                if (ckb_hongos2.Checked == true)
                {
                    inicial.inicial_hongosBio2 = "Si";
                }
                if (ckb_bacterias2.Checked == true)
                {
                    inicial.inicial_bacteriasBio2 = "Si";
                }
                if (ckb_parasitos2.Checked == true)
                {
                    inicial.inicial_parasitosBio2 = "Si";
                }
                if (ckb_expoavectores2.Checked == true)
                {
                    inicial.inicial_expVectBio2 = "Si";
                }
                if (ckb_expoanimselvaticos2.Checked == true)
                {
                    inicial.inicial_expAniSelvaBio2 = "Si";
                }
                if (ckb_otrosBiologico2.Checked == true)
                {
                    inicial.inicial_otrosBio2 = "Si";
                }
                if (ckb_manmanualcargas2.Checked == true)
                {
                    inicial.inicial_maneManCarErg2 = "Si";
                }
                if (ckb_movrepetitivo2.Checked == true)
                {
                    inicial.inicial_movRepeErg2 = "Si";
                }
                if (ckb_postforzadas2.Checked == true)
                {
                    inicial.inicial_posForzaErg2 = "Si";
                }
                if (ckb_trabajopvd2.Checked == true)
                {
                    inicial.inicial_trabPvdErg2 = "Si";
                }
                if (ckb_otrosErgonomico2.Checked == true)
                {
                    inicial.inicial_otrosErg2 = "Si";
                }
                inicial.inicial_puestoTrabajo3 = txt_puestodetrabajo23.Text;
                inicial.inicial_actividades3 = txt_act23.Text;
                if (ckb_virus3.Checked == true)
                {
                    inicial.inicial_virusBio3 = "Si";
                }
                if (ckb_hongos3.Checked == true)
                {
                    inicial.inicial_hongosBio3 = "Si";
                }
                if (ckb_bacterias3.Checked == true)
                {
                    inicial.inicial_bacteriasBio3 = "Si";
                }
                if (ckb_parasitos3.Checked == true)
                {
                    inicial.inicial_parasitosBio3 = "Si";
                }
                if (ckb_expoavectores3.Checked == true)
                {
                    inicial.inicial_expVectBio3 = "Si";
                }
                if (ckb_expoanimselvaticos3.Checked == true)
                {
                    inicial.inicial_expAniSelvaBio3 = "Si";
                }
                if (ckb_otrosBiologico3.Checked == true)
                {
                    inicial.inicial_otrosBio3 = "Si";
                }
                if (ckb_manmanualcargas3.Checked == true)
                {
                    inicial.inicial_maneManCarErg3 = "Si";
                }
                if (ckb_movrepetitivo3.Checked == true)
                {
                    inicial.inicial_movRepeErg3 = "Si";
                }
                if (ckb_postforzadas3.Checked == true)
                {
                    inicial.inicial_posForzaErg3 = "Si";
                }
                if (ckb_trabajopvd3.Checked == true)
                {
                    inicial.inicial_trabPvdErg3 = "Si";
                }
                if (ckb_otrosErgonomico3.Checked == true)
                {
                    inicial.inicial_otrosErg3 = "Si";
                }
                inicial.inicial_puestoTrabajo4 = txt_puestodetrabajo24.Text;
                inicial.inicial_actividades4 = txt_act24.Text;
                if (ckb_virus4.Checked == true)
                {
                    inicial.inicial_virusBio4 = "Si";
                }
                if (ckb_hongos4.Checked == true)
                {
                    inicial.inicial_hongosBio4 = "Si";
                }
                if (ckb_bacterias4.Checked == true)
                {
                    inicial.inicial_bacteriasBio4 = "Si";
                }
                if (ckb_parasitos4.Checked == true)
                {
                    inicial.inicial_parasitosBio4 = "Si";
                }
                if (ckb_expoavectores4.Checked == true)
                {
                    inicial.inicial_expVectBio4 = "Si";
                }
                if (ckb_expoanimselvaticos4.Checked == true)
                {
                    inicial.inicial_expAniSelvaBio4 = "Si";
                }
                if (ckb_otrosBiologico4.Checked == true)
                {
                    inicial.inicial_otrosBio4 = "Si";
                }
                if (ckb_manmanualcargas4.Checked == true)
                {
                    inicial.inicial_maneManCarErg4 = "Si";
                }
                if (ckb_movrepetitivo4.Checked == true)
                {
                    inicial.inicial_movRepeErg4 = "Si";
                }
                if (ckb_postforzadas4.Checked == true)
                {
                    inicial.inicial_posForzaErg4 = "Si";
                }
                if (ckb_trabajopvd4.Checked == true)
                {
                    inicial.inicial_trabPvdErg4 = "Si";
                }
                if (ckb_otrosErgonomico4.Checked == true)
                {
                    inicial.inicial_otrosErg4 = "Si";
                }
                if (ckb_montrabajo.Checked == true)
                {
                    inicial.inicial_monoTrabPsi = "Si";
                }
                if (ckb_sobrecargalaboral.Checked == true)
                {
                    inicial.inicial_sobrecarLabPsi = "Si";
                }
                if (ckb_minustarea.Checked == true)
                {
                    inicial.inicial_minuTareaPsi = "Si";
                }
                if (ckb_altarespon.Checked == true)
                {
                    inicial.inicial_altaResponPsi = "Si";
                }
                if (ckb_automadesiciones.Checked == true)
                {
                    inicial.inicial_autoTomaDesiPsi = "Si";
                }
                if (ckb_supyestdireficiente.Checked == true)
                {
                    inicial.inicial_supEstDirecDefiPsi = "Si";
                }
                if (ckb_conflictorol.Checked == true)
                {
                    inicial.inicial_conflicRolPsi = "Si";
                }
                if (ckb_faltaclarfunciones.Checked == true)
                {
                    inicial.inicial_falClariFunPsi = "Si";
                }
                if (ckb_incorrdistrabajo.Checked == true)
                {
                    inicial.inicial_incoDistriTrabPsi = "Si";
                }
                if (ckb_turnorotat.Checked == true)
                {
                    inicial.inicial_turnosRotaPsi = "Si";
                }
                if (ckb_relacinterpersonales.Checked == true)
                {
                    inicial.inicial_relInterperPsi = "Si";
                }
                if (ckb_inestalaboral.Checked == true)
                {
                    inicial.inicial_inesLabPsi = "Si";
                }
                if (ckb_otrosPsicosocial.Checked == true)
                {
                    inicial.inicial_otrosPsi = "Si";
                }
                inicial.inicial_medPreventivas = txt_medpreventivas.Text;
                if (ckb_montrabajo2.Checked == true)
                {
                    inicial.inicial_monoTrabPsi2 = "Si";
                }
                if (ckb_sobrecargalaboral2.Checked == true)
                {
                    inicial.inicial_sobrecarLabPsi2 = "Si";
                }
                if (ckb_minustarea2.Checked == true)
                {
                    inicial.inicial_minuTareaPsi2 = "Si";
                }
                if (ckb_altarespon2.Checked == true)
                {
                    inicial.inicial_altaResponPsi2 = "Si";
                }
                if (ckb_automadesiciones2.Checked == true)
                {
                    inicial.inicial_autoTomaDesiPsi2 = "Si";
                }
                if (ckb_supyestdireficiente2.Checked == true)
                {
                    inicial.inicial_supEstDirecDefiPsi2 = "Si";
                }
                if (ckb_conflictorol2.Checked == true)
                {
                    inicial.inicial_conflicRolPsi2 = "Si";
                }
                if (ckb_faltaclarfunciones2.Checked == true)
                {
                    inicial.inicial_falClariFunPsi2 = "Si";
                }
                if (ckb_incorrdistrabajo2.Checked == true)
                {
                    inicial.inicial_incoDistriTrabPsi2 = "Si";
                }
                if (ckb_turnorotat2.Checked == true)
                {
                    inicial.inicial_turnosRotaPsi2 = "Si";
                }
                if (ckb_relacinterpersonales2.Checked == true)
                {
                    inicial.inicial_relInterperPsi2 = "Si";
                }
                if (ckb_inestalaboral2.Checked == true)
                {
                    inicial.inicial_inesLabPsi2 = "Si";
                }
                if (ckb_otrosPsicosocial2.Checked == true)
                {
                    inicial.inicial_otrosPsi2 = "Si";
                }
                inicial.inicial_medPreventivas2 = txt_medpreventivas2.Text;
                if (ckb_montrabajo3.Checked == true)
                {
                    inicial.inicial_monoTrabPsi3 = "Si";
                }
                if (ckb_sobrecargalaboral3.Checked == true)
                {
                    inicial.inicial_sobrecarLabPsi3 = "Si";
                }
                if (ckb_minustarea3.Checked == true)
                {
                    inicial.inicial_minuTareaPsi3 = "Si";
                }
                if (ckb_altarespon3.Checked == true)
                {
                    inicial.inicial_altaResponPsi3 = "Si";
                }
                if (ckb_automadesiciones3.Checked == true)
                {
                    inicial.inicial_autoTomaDesiPsi3 = "Si";
                }
                if (ckb_supyestdireficiente3.Checked == true)
                {
                    inicial.inicial_supEstDirecDefiPsi3 = "Si";
                }
                if (ckb_conflictorol3.Checked == true)
                {
                    inicial.inicial_conflicRolPsi3 = "Si";
                }
                if (ckb_faltaclarfunciones3.Checked == true)
                {
                    inicial.inicial_falClariFunPsi3 = "Si";
                }
                if (ckb_incorrdistrabajo3.Checked == true)
                {
                    inicial.inicial_incoDistriTrabPsi3 = "Si";
                }
                if (ckb_turnorotat3.Checked == true)
                {
                    inicial.inicial_turnosRotaPsi3 = "Si";
                }
                if (ckb_relacinterpersonales3.Checked == true)
                {
                    inicial.inicial_relInterperPsi3 = "Si";
                }
                if (ckb_inestalaboral3.Checked == true)
                {
                    inicial.inicial_inesLabPsi3 = "Si";
                }
                if (ckb_otrosPsicosocial3.Checked == true)
                {
                    inicial.inicial_otrosPsi3 = "Si";
                }
                inicial.inicial_medPreventivas3 = txt_medpreventivas3.Text;
                if (ckb_montrabajo4.Checked == true)
                {
                    inicial.inicial_monoTrabPsi4 = "Si";
                }
                if (ckb_sobrecargalaboral4.Checked == true)
                {
                    inicial.inicial_sobrecarLabPsi4 = "Si";
                }
                if (ckb_minustarea4.Checked == true)
                {
                    inicial.inicial_minuTareaPsi4 = "Si";
                }
                if (ckb_altarespon4.Checked == true)
                {
                    inicial.inicial_altaResponPsi4 = "Si";
                }
                if (ckb_automadesiciones4.Checked == true)
                {
                    inicial.inicial_autoTomaDesiPsi4 = "Si";
                }
                if (ckb_supyestdireficiente4.Checked == true)
                {
                    inicial.inicial_supEstDirecDefiPsi4 = "Si";
                }
                if (ckb_conflictorol4.Checked == true)
                {
                    inicial.inicial_conflicRolPsi4 = "Si";
                }
                if (ckb_faltaclarfunciones4.Checked == true)
                {
                    inicial.inicial_falClariFunPsi4 = "Si";
                }
                if (ckb_incorrdistrabajo4.Checked == true)
                {
                    inicial.inicial_incoDistriTrabPsi4 = "Si";
                }
                if (ckb_turnorotat4.Checked == true)
                {
                    inicial.inicial_turnosRotaPsi4 = "Si";
                }
                if (ckb_relacinterpersonales4.Checked == true)
                {
                    inicial.inicial_relInterperPsi4 = "Si";
                }
                if (ckb_inestalaboral4.Checked == true)
                {
                    inicial.inicial_inesLabPsi4 = "Si";
                }
                if (ckb_otrosPsicosocial4.Checked == true)
                {
                    inicial.inicial_otrosPsi4 = "Si";
                }
                inicial.inicial_medPreventivas4 = txt_medpreventivas4.Text;
                inicial.inicial_descripActExtLab = txt_descrextralaborales.Text;
                inicial.inicial_descripEnfActual = txt_enfermedadactualinicial.Text;
                if (ckb_pielanexos.Checked == true)
                {
                    inicial.inicial_pielAnexos = "Si";
                }
                if (ckb_respiratorio.Checked == true)
                {
                    inicial.inicial_respiratorio = "Si";
                }
                if (ckb_digestivo.Checked == true)
                {
                    inicial.inicial_digestivo = "Si";
                }
                if (ckb_musculosesqueleticos.Checked == true)
                {
                    inicial.inicial_muscEsqueletico = "Si";
                }
                if (ckb_hemolinfatico.Checked == true)
                {
                    inicial.inicial_hemoLimfa = "Si";
                }
                if (ckb_organossentidos.Checked == true)
                {
                    inicial.inicial_orgSentidos = "Si";
                }
                if (ckb_cardiovascular.Checked == true)
                {
                    inicial.inicial_cardVascular = "Si";
                }
                if (ckb_genitourinario.Checked == true)
                {
                    inicial.inicial_genUrinario = "Si";
                }
                if (ckb_endocrino.Checked == true)
                {
                    inicial.inicial_endocrino = "Si";
                }
                if (ckb_nervioso.Checked == true)
                {
                    inicial.inicial_nervioso = "Si";
                }
                inicial.inicial_descripRevActOrgSis = txt_descrorganosysistemas.Text;
                inicial.inicial_preArterial = txt_preArterial.Text;
                inicial.inicial_temperatura = Convert.ToInt32(txt_temperatura.Text);
                inicial.inicial_frecCardiacan = Convert.ToInt32(txt_freCardica.Text);
                inicial.inicial_satOxigenon = Convert.ToInt32(txt_satOxigeno.Text);
                inicial.inicial_frecRespiratorian = Convert.ToInt32(txt_freRespiratoria.Text);
                inicial.inicial_peson = Convert.ToInt32(txt_peso.Text);
                inicial.inicial_tallan = Convert.ToInt32(txt_talla.Text);
                inicial.inicial_indMasCorporaln = Convert.ToInt32(txt_imc.Text);
                inicial.inicial_perAbdominaln = Convert.ToInt32(txt_perAbdominal.Text);
                if (ckb_cicatrices.Checked == true)
                {
                    inicial.inicial_cicatricesPiel = "Si";
                }
                if (ckb_auditivoexterno.Checked == true)
                {
                    inicial.inicial_cAudiExtreOido = "Si";
                }
                if (ckb_tabique.Checked == true)
                {
                    inicial.inicial_tabiqueNariz = "Si";
                }
                if (ckb_pulmones.Checked == true)
                {
                    inicial.inicial_pulmonesTorax2 = "Si";
                }
                if (ckb_pelvis.Checked == true)
                {
                    inicial.inicial_pelvisPelvis = "Si";
                }
                if (ckb_tatuajes.Checked == true)
                {
                    inicial.inicial_tatuajesPiel = "Si";
                }
                if (ckb_pabellon.Checked == true)
                {
                    inicial.inicial_pabellonOido = "Si";
                }
                if (ckb_cornetes.Checked == true)
                {
                    inicial.inicial_cornetesNariz = "Si";
                }
                if (ckb_parrillacostal.Checked == true)
                {
                    inicial.inicial_parriCostalTorax2 = "Si";
                }
                if (ckb_genitales.Checked == true)
                {
                    inicial.inicial_genitalesPelvis = "Si";
                }
                if (ckb_pielyfaneras.Checked == true)
                {
                    inicial.inicial_pielFacerasPiel = "Si";
                }
                if (ckb_timpanos.Checked == true)
                {
                    inicial.inicial_timpanosOido = "Si";
                }
                if (ckb_mucosa.Checked == true)
                {
                    inicial.inicial_mucosasNariz = "Si";
                }
                if (ckb_visceras.Checked == true)
                {
                    inicial.inicial_viscerasAbdomen = "Si";
                }
                if (ckb_vascular.Checked == true)
                {
                    inicial.inicial_vascularExtre = "Si";
                }
                if (ckb_parpados.Checked == true)
                {
                    inicial.inicial_parpadosOjos = "Si";
                }
                if (ckb_labios.Checked == true)
                {
                    inicial.inicial_labiosOroFa = "Si";
                }
                if (ckb_senosparanasales.Checked == true)
                {
                    inicial.inicial_senosParanaNariz = "Si";
                }
                if (ckb_paredabdominal.Checked == true)
                {
                    inicial.inicial_paredAbdomiAbdomen = "Si";
                }
                if (ckb_miembrosuperiores.Checked == true)
                {
                    inicial.inicial_miemSupeExtre = "Si";
                }
                if (ckb_conjuntivas.Checked == true)
                {
                    inicial.inicial_conjuntuvasOjos = "Si";
                }
                if (ckb_lengua.Checked == true)
                {
                    inicial.inicial_lenguaOroFa = "Si";
                }
                if (ckb_tiroides.Checked == true)
                {
                    inicial.inicial_tiroiMasasCuello = "Si";
                }
                if (ckb_flexibilidad.Checked == true)
                {
                    inicial.inicial_flexibilidadColumna = "Si";
                }
                if (ckb_miembrosinferiores.Checked == true)
                {
                    inicial.inicial_miemInfeExtre = "Si";
                }
                if (ckb_pupilas.Checked == true)
                {
                    inicial.inicial_pupilasOjos = "Si";
                }
                if (ckb_faringe.Checked == true)
                {
                    inicial.inicial_faringeOroFa = "Si";
                }
                if (ckb_movilidad.Checked == true)
                {
                    inicial.inicial_movilidadCuello = "Si";
                }
                if (ckb_desviacion.Checked == true)
                {
                    inicial.inicial_desviacionColumna = "Si";
                }
                if (ckb_fuerza.Checked == true)
                {
                    inicial.inicial_fuerzaNeuro = "Si";
                }
                if (ckb_cornea.Checked == true)
                {
                    inicial.inicial_corneaOjos = "Si";
                }
                if (ckb_amigdalas.Checked == true)
                {
                    inicial.inicial_amigdalasOroFa = "Si";
                }
                if (ckb_mamas.Checked == true)
                {
                    inicial.inicial_mamasTorax = "Si";
                }
                if (ckb_sensibilidad.Checked == true)
                {
                    inicial.inicial_sensibiNeuro = "Si";
                }
                if (ckb_motilidad.Checked == true)
                {
                    inicial.inicial_motilidadOjos = "Si";
                }
                if (ckb_dentadura.Checked == true)
                {
                    inicial.inicial_dentaduraOroFa = "Si";
                }
                if (ckb_corazon.Checked == true)
                {
                    inicial.inicial_corazonTorax = "Si";
                }
                if (ckb_dolor.Checked == true)
                {
                    inicial.inicial_dolorColumna = "Si";
                }
                if (ckb_marcha.Checked == true)
                {
                    inicial.inicial_marchaNeuro = "Si";
                }
                if (ckb_reflejos.Checked == true)
                {
                    inicial.inicial_refleNeuro = "Si";
                }
                inicial.inicial_observaExaFisRegInicial = txt_obervexamenfisicoregional.Text;
                inicial.inicial_examen = txt_examen.Text;
                inicial.inicial_fecha = Convert.ToDateTime(txt_fechaexamen.Text);
                inicial.inicial_resultados = txt_resultadoexamen.Text;
                inicial.inicial_examen2 = txt_examen2.Text;
                inicial.inicial_fecha2 = Convert.ToDateTime(txt_fechaexamen2.Text);
                inicial.inicial_resultados2 = txt_resultadoexamen2.Text;
                inicial.inicial_examen3 = txt_examen3.Text;
                inicial.inicial_fecha3 = Convert.ToDateTime(txt_fechaexamen3.Text);
                inicial.inicial_resultados3 = txt_resultadoexamen3.Text;
                inicial.inicial_examen4 = txt_examen4.Text;
                inicial.inicial_fecha4 = Convert.ToDateTime(txt_fechaexamen4.Text);
                inicial.inicial_resultados4 = txt_resultadoexamen4.Text;
                inicial.inicial_observacionesResExaGenEspRiesTrabajo = txt_observacionexamen.Text;

                inicial.inicial_descripciondiagnostico = txt_descripdiagnostico.Text;
                inicial.inicial_cie = txt_cie.Text;
                if (ckb_pre.Checked == true)
                {
                    inicial.inicial_pre = "Si";
                }
                if (ckb_def.Checked == true)
                {
                    inicial.inicial_def = "Si";
                }
                inicial.inicial_descripcioninicialnostico2 = txt_descripdiagnostico2.Text;
                inicial.inicial_cie2 = txt_cie2.Text;
                if (ckb_pre2.Checked == true)
                {
                    inicial.inicial_pre2 = "Si";
                }
                if (ckb_def2.Checked == true)
                {
                    inicial.inicial_def2 = "Si";
                }
                inicial.inicial_descripcioninicialnostico3 = txt_descripdiagnostico3.Text;
                inicial.inicial_cie3 = txt_cie3.Text;
                if (ckb_pre3.Checked == true)
                {
                    inicial.inicial_pre3 = "Si";
                }
                if (ckb_def3.Checked == true)
                {
                    inicial.inicial_def3 = "Si";
                }
                if (ckb_apto.Checked == true)
                {
                    inicial.inicial_apto = "Si";
                }
                if (ckb_aptoobservacion.Checked == true)
                {
                    inicial.inicial_aptoObserva = "Si";
                }
                if (ckb_aptolimitacion.Checked == true)
                {
                    inicial.inicial_aptoLimi = "Si";
                }
                if (ckb_noapto.Checked == true)
                {
                    inicial.inicial_NoApto = "Si";
                }
                inicial.inicial_ObservAptMed = txt_observacionaptitud.Text;
                inicial.inicial_LimitAptMed = txt_limitacionaptitud.Text;
                inicial.inicial_descripcionRecTra = txt_descripciontratamiento.Text;
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
    }
}