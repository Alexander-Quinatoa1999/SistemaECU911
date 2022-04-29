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
    public partial class Periodica : System.Web.UI.Page
    {
        DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        private Tbl_Personas per = new Tbl_Personas();

        private Tbl_Periodica perio = new Tbl_Periodica();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["cod"] != null)
                {
                    int codigo = Convert.ToInt32(Request["cod"]);
                    perio = CN_Periodica.ObtenerPeriodicaPorId(codigo);
                    int personasid = Convert.ToInt32(perio.Per_id.ToString());
                    per = CN_HistorialMedico.ObtenerPersonasxId(personasid);
                    
                    btn_guardar.Text = "Actualizar";

                    if (per != null)
                    {
                        //A
                        txt_priNombre.Text = per.Per_priNombre.ToString();
                        txt_segNombre.Text = per.Per_segNombre.ToString();
                        txt_priApellido.Text = per.Per_priApellido.ToString();
                        txt_segApellido.Text = per.Per_segApellido.ToString();
                        txt_sexo.Text = per.Per_genero.ToString();
                        txt_numHClinica.Text = per.Per_cedula.ToString();
                        txt_puestodetrabajoperiodica.Text = per.Per_puestoTrabajo.ToString();

                        if (perio != null)
                        {
                            //A
                            txt_numArchivo.Text = perio.perio_numArchivo.ToString();
                
                            //B
                            txt_motivoconsultaperiodica.Text = perio.perio_descripMotiConsulta.ToString();

                            //C
                            txt_antCliQuiDescripcion.Text = perio.perio_descripcionAntCliQuirurgicos.ToString();

                            //txt_siConsuNociTabaHabToxi.Text = perio.perio_siConsuNocivosTabaco.ToString();
                            //txt_noConsuNociTabaHabToxi.Text = perio.perio_noConsuNocivosTabaco.ToString();
                            txt_tiemConConsuNociTabaHabToxi.Text = perio.perio_tiempoConsuConsuNocivosTabaco.ToString();
                            txt_cantiConsuNociTabaHabToxi.Text = perio.perio_cantidadConsuNocivosTabaco.ToString();
                            txt_exConsumiConsuNociTabaHabToxi.Text = perio.perio_exConsumiConsuNocivosTabaco.ToString();
                            txt_tiemAbstiConsuNociTabaHabToxi.Text = perio.perio_tiempoAbstiConsuNocivosTabaco.ToString();

                            //txt_siConsuNociAlcoHabToxi.Text = perio.perio_siConsuNocivosAlcohol.ToString();
                            //txt_noConsuNociAlcoHabToxi.Text = perio.perio_noConsuNocivosAlcohol.ToString();
                            txt_tiemConConsuNociAlcoHabToxi.Text = perio.perio_tiempoConsuConsuNocivosAlcohol.ToString();
                            txt_cantiConsuNociAlcoHabToxi.Text = perio.perio_cantidadConsuNocivosAlcohol.ToString();
                            txt_exConsumiConsuNociAlcoHabToxi.Text = perio.perio_exConsumiConsuNocivosAlcohol.ToString();
                            txt_tiemAbstiConsuNociAlcoHabToxi.Text = perio.perio_tiempoAbstiConsuNocivosAlcohol.ToString();

                            //txt_siConsuNociOtrasDroHabToxi.Text = perio.perio_siConsuNocivosOtrasDrogas.ToString();
                            //txt_noConsuNociOtrasDroHabToxi.Text = perio.perio_noConsuNocivosOtrasDrogas.ToString();
                            txt_tiemCon1ConsuNociOtrasDroHabToxi.Text = perio.perio_tiempoConsu1ConsuNocivosOtrasDrogas.ToString();
                            txt_canti1ConsuNociOtrasDroHabToxi.Text = perio.perio_cantidad1ConsuNocivosOtrasDrogas.ToString();
                            txt_exConsumi1ConsuNociOtrasDroHabToxi.Text = perio.perio_exConsumi1ConsuNocivosOtrasDrogas.ToString();
                            txt_tiemAbsti1ConsuNociOtrasDroHabToxi.Text = perio.perio_tiempoAbsti1ConsuNocivosOtrasDrogas.ToString();
                            txt_otrasConsuNociOtrasDroHabToxi.Text = perio.perio_otrasConsuNocivos.ToString();
                            txt_tiemCon2ConsuNociOtrasDroHabToxi.Text = perio.perio_tiempoConsu2ConsuNocivosOtrasDrogas.ToString();
                            txt_canti2ConsuNociOtrasDroHabToxi.Text = perio.perio_cantidad2ConsuNocivosOtrasDrogas.ToString();
                            txt_exConsumi2ConsuNociOtrasDroHabToxi.Text = perio.perio_exConsumi2ConsuNocivosOtrasDrogas.ToString();
                            txt_tiemAbsti2ConsuNociOtrasDroHabToxi.Text = perio.perio_tiempoAbsti2ConsuNocivosOtrasDrogas.ToString();

                            //txt_siEstVidaActFisiEstVida.Text = perio.perio_siEstiVidaActFisica.ToString();
                            //txt_noEstVidaActFisiEstVida.Text = perio.perio_noEstiVidaActFisica.ToString();
                            txt_cualEstVidaActFisiEstVida.Text = perio.perio_cualEstiVidaActFisica.ToString();
                            txt_tiemCanEstVidaActFisiEstVida.Text = perio.perio_tiem_cantEstiVidaActFisica.ToString();

                            //txt_siEstVidaMedHabiEstVida.Text = perio.perio_siEstiVidaMediHabitual.ToString();
                            //txt_noEstVidaMedHabiEstVida.Text = perio.perio_noEstiVidaMediHabitual.ToString();
                            txt_cual1EstVidaMedHabiEstVida.Text = perio.perio_cual1EstiVidaMediHabitual.ToString();
                            txt_tiemCan1EstVidaMedHabiEstVida.Text = perio.perio_tiem_cant1EstiVidaMediHabitual.ToString();
                            txt_cual2EstVidaMedHabiEstVida.Text = perio.perio_cual2EstiVidaMediHabitual.ToString();
                            txt_tiemCan2EstVidaMedHabiEstVida.Text = perio.perio_tiem_cant2EstiVidaMediHabitual.ToString();
                            txt_cual3EstVidaMedHabiEstVida.Text = perio.perio_cual3EstiVidaMediHabitual.ToString();
                            txt_tiemCan3EstVidaMedHabiEstVida.Text = perio.perio_tiem_cant3EstiVidaMediHabitual.ToString();

                            txt_incidentesperiodica.Text = perio.perio_descripIncidentes.ToString();

                            //txt_sicalificadotrabajo.Text = perio.perio_siCalificadoIESSAcciTrabajo.ToString();
                            txt_especificarcalificadotrabajo.Text = perio.perio_EspecifiCalificadoIESSAcciTrabajo.ToString();
                            //txt_nocalificadotrabajo.Text = perio.perio_noCalificadoIESSAcciTrabajo.ToString();
                            txt_fechacalificadotrabajo.Text = perio.perio_fechaCalificadoIESSAcciTrabajo.ToString();
                            txt_obsercalificadotrabajo.Text = perio.perio_observacionesAcciTrabajo.ToString();

                            //txt_sicalificadoprofesional.Text = perio.perio_siCalificadoIESSEnferProfesionales.ToString();
                            txt_especificarcalificadoprofesional.Text = perio.perio_EspecifiCalificadoIESSEnferProfesionales.ToString();
                            //txt_nocalificadoprofesional.Text = perio.perio_noCalificadoIESSEnferProfesionales.ToString();
                            txt_fechacalificadoprofesional.Text = perio.perio_fechaCalificadoIESSEnferProfesionales.ToString();
                            txt_obsercalificadoprofesional.Text = perio.perio_observacionesEnferProfesionales.ToString();

                            //D
                            //txt_enfermedadcardiovascular.Text = perio.perio_enfCarVas.ToString();
                            //txt_enfermedadmetabolica.Text = perio.perio_enfMeta.ToString();
                            //txt_enfermedadneurologica.Text = perio.perio_enfNeuro.ToString();
                            //txt_enfermedadoncologica.Text = perio.perio_enfOnco.ToString();
                            //txt_enfermedadinfecciosa.Text = perio.perio_enfInfe.ToString();
                            //txt_enfermedadhereditaria.Text = perio.perio_enfHereConge.ToString();
                            //txt_discapacidades.Text = perio.perio_discapa.ToString();
                            //txt_otrosenfer.Text = perio.perio_otros.ToString();
                            txt_descripcionantefamiliares.Text = perio.perio_descripcionAntFamiliares.ToString();

                            //E
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_area = txt_puestotrabajoperio.periodica.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_actividades = txt_act.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_tiemTrabperio.periodica = txt_tiempotrabajo.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_temAltasFis = txt_tempaltas.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_temBajasFis = txt_tempbajas.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_radIonizanteFis = txt_radiacion.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_radNoIonizanteFis = txt_noradiacion.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_ruidoFis = txt_ruido.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_vibracionFis = txt_vibracion.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_iluminacionFis = txt_iluminacion.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_ventilacionFis = txt_ventilacion.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_fluElectricoFis = txt_fluidoelectrico.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_otrosFis = txt_otros1.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_atraMaquinasMec = txt_atrapmaquinas.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_atraSuperfiiesMec = txt_atrapsuperficie.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_atraObjetosMec = txt_atrapobjetos.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_caidaObjetosMec = txt_caidaobjetos.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_caidaMisNivelMec = txt_caidamisnivel.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_caidaDifNivelMec = txt_caidadifnivel.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_contactoElecMec = txt_contaelectrico.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_conSuperTrabaMec = txt_contasuptrabajo.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_proPartiFragMec = txt_proyparticulas.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_proFluidosMec = txt_proyefluidos.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_pinchazosMec = txt_pinchazos.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_cortesMec = txt_cortes.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_atropeVehiMec = txt_atroporvehiculos.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_coliVehiMec = txt_choques.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_otrosMec = txt_otros2.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_solidosQui = txt_solidos.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_polvosQui = txt_polvos.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_humosQui = txt_humos.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_liquidosQui = txt_liquidos.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_vaporesQui = txt_vapores.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_aerosolesQui = txt_aerosoles.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_neblinasQui = txt_neblinas.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_gaseososQui = txt_gaseosos.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_otrosBio = txt_otros3.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_virusBio = txt_virus.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_hongosBio = txt_hongos.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_bacteriasBio = txt_bacterias.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_parasitosBio = txt_parasitos.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_expVectBio = txt_expoavectores.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_expAniSelvaBio = txt_expoanimselvaticos.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_otrosBio = txt_otros4.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_maneManCarErg = txt_manmanualcargas.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_movRepeErg = txt_movrepetitivo.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_posForzaErg = txt_postforzadas.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_trabPvdErg = txt_trabajopvd.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_otrosErg = txt_otros5.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_monoTrabPsi = txt_montrabajo.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_sobrecarLabPsi = txt_sobrecargalaboral.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_minuTareaPsi = txt_minustarea.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_altaResponPsi = txt_altarespon.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_autoTomaDesiPsi = txt_automadesiciones.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_supEstDirecDefiPsi = txt_supyestdireficiente.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_conflicRolPsi = txt_conflictorol.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_falClariFunPsi = txt_faltaclarfunciones.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_incoDistriTrabPsi = txt_incorrdistrabajo.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_turnosRotaPsi = txt_turnorotat.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_relInterperPsi = txt_relacinterpersonales.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_inesLabPsi = txt_inestalaboral.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_otrosPsi = txt_otros6.Text;
                            //facriestrabperio.periodica.FacRiesTrabActperio.periodica_medPreventivas = txt_medpreventivas.Text;
                            //facriestrabperio.periodica.Per_id = perso;

                            //F
                            txt_enfermedadactualperiodica.Text = perio.perio_descripEnfActual.ToString();

                            //G
                            txt_pielanexos.Text = perio.perio_pielAnexos.ToString();
                            txt_organossentidos.Text = perio.perio_orgSentidos.ToString();
                            txt_respiratorio.Text = perio.perio_respiratorio.ToString();
                            txt_cardiovascular.Text = perio.perio_cardVascular.ToString();
                            txt_digestivo.Text = perio.perio_digestivo.ToString();
                            txt_genitourinario.Text = perio.perio_genUrinario.ToString();
                            txt_musculosesqueleticos.Text = perio.perio_muscEsqueletico.ToString();
                            txt_endocrino.Text = perio.perio_endocrino.ToString();
                            txt_hemolinfatico.Text = perio.perio_hemoLimfa.ToString();
                            txt_nervioso.Text = perio.perio_nervioso.ToString();
                            txt_descrorganosysistemasperiodica.Text = perio.perio_descripRevOrgaSistemas.ToString();

                            //I
                            txt_cicatrices.Text = perio.perio_cicatricesPiel.ToString();
                            txt_tatuajes.Text = perio.perio_tatuajesPiel.ToString();
                            txt_pielyfaneras.Text = perio.perio_pielFacerasPiel.ToString();
                            txt_parpados.Text = perio.perio_parpadosOjos.ToString();
                            txt_conjuntivas.Text = perio.perio_conjuntuvasOjos.ToString();
                            txt_pupilas.Text = perio.perio_pupilasOjos.ToString();
                            txt_cornea.Text = perio.perio_corneaOjos.ToString();
                            txt_motilidad.Text = perio.perio_motilidadOjos.ToString();
                            txt_auditivoexterno.Text = perio.perio_cAudiExtreOido.ToString();
                            txt_pabellon.Text = perio.perio_pabellonOido.ToString();
                            txt_timpanos.Text = perio.perio_timpanosOido.ToString();
                            txt_labios.Text = perio.perio_labiosOroFa.ToString();
                            txt_lengua.Text = perio.perio_lenguaOroFa.ToString();
                            txt_faringe.Text = perio.perio_faringeOroFa.ToString();
                            txt_amigdalas.Text = perio.perio_amigdalasOroFa.ToString();
                            txt_dentadura.Text = perio.perio_dentaduraOroFa.ToString();
                            txt_tabique.Text = perio.perio_tabiqueNariz.ToString();
                            txt_cornetes.Text = perio.perio_cornetesNariz.ToString();
                            txt_mucosa.Text = perio.perio_mucosasNariz.ToString();
                            txt_senosparanasales.Text = perio.perio_senosParanaNariz.ToString();
                            txt_tiroides.Text = perio.perio_tiroiMasasCuello.ToString();
                            txt_movilidad.Text = perio.perio_movilidadCuello.ToString();
                            txt_mamas.Text = perio.perio_mamasTorax.ToString();
                            txt_corazon.Text = perio.perio_corazonTorax.ToString();
                            txt_pulmones.Text = perio.perio_pulmonesTorax2.ToString();
                            txt_parrillacostal.Text = perio.perio_parriCostalTorax2.ToString();
                            txt_visceras.Text = perio.perio_viscerasAbdomen.ToString();
                            txt_paredabdominal.Text = perio.perio_paredAbdomiAbdomen.ToString();
                            txt_flexibilidad.Text = perio.perio_flexibilidadColumna.ToString();
                            txt_desviacion.Text = perio.perio_desviacionColumna.ToString();
                            txt_dolor.Text = perio.perio_dolorColumna.ToString();
                            txt_pelvis.Text = perio.perio_pelvisPelvis.ToString();
                            txt_genitales.Text = perio.perio_genitalesPelvis.ToString();
                            txt_vascular.Text = perio.perio_vascularExtre.ToString();
                            txt_miembrosuperiores.Text = perio.perio_miemSupeExtre.ToString();
                            txt_miembrosinferiores.Text = perio.perio_miemInfeExtre.ToString();
                            txt_fuerza.Text = perio.perio_fuerzaNeuro.ToString();
                            txt_sensibilidad.Text = perio.perio_sensibiNeuro.ToString();
                            txt_marcha.Text = perio.perio_marchaNeuro.ToString();
                            txt_reflejos.Text = perio.perio_refleNeuro.ToString();
                            txt_obervexamenfisicoregional.Text = perio.perio_observaExaFisRegional.ToString();

                            //J
                            txt_examen.Text = perio.perio_examen.ToString();
                            txt_fechaexamen.Text = perio.perio_fecha.ToString();
                            txt_resultadoexamen.Text = perio.perio_resultado.ToString();
                            txt_observacionexamen.Text = perio.perio_observacionesResExaGenEspPuesTrabajo.ToString();

                            //K
                            txt_descripdiagnostico.Text = perio.perio_descripcionDiagnostico.ToString();
                            txt_cie.Text = perio.perio_cie.ToString();
                            txt_pre.Text = perio.perio_pre.ToString();
                            txt_def.Text = perio.perio_def.ToString();

                            //L
                            txt_apto.Text = perio.perio_apto.ToString();
                            txt_aptoobservacion.Text = perio.perio_aptoObserva.ToString();
                            txt_aptolimitacion.Text = perio.perio_aptoLimi.ToString();
                            txt_noapto.Text = perio.perio_NoApto.ToString();
                            txt_observacionaptitud.Text = perio.perio_ObservAptMedTrabajo.ToString();
                            txt_limitacionaptitud.Text = perio.perio_LimitAptMedTrabajo.ToString();

                            //M
                            txt_descripciontratamientoperiodica.Text = perio.perio_descripcionRecoTratamiento.ToString();

                            //N
                            txt_fechahora.Text = perio.perio_fecha_hora.ToString();
                            ddl_profesional.SelectedValue = perio.prof_id.ToString();
                            txt_codigoDatProf.Text = perio.perio_cod.ToString();
                        }
                    }
                }

                txt_fechahora.Text = DateTime.Now.ToString(" dd/MM/yyyy " + " HH:mm ");
                cargarProfesional();
            }
        }

        //Metodo obtener cedula por numero de HC PERIODICA
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

                string puestoTrabajo = item.Per_puestoTrabajo;
                txt_puestodetrabajoperiodica.Text = puestoTrabajo;
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

        private void GuardarPeriodica()
        {
            try
            {
                per = CN_HistorialMedico.ObtenerIdPersonasxCedula(Convert.ToInt32(txt_numHClinica.Text));

                int perso = Convert.ToInt32(per.Per_id.ToString());

                perio = new Tbl_Periodica
                {
                    //A
                    perio_numArchivo = txt_numArchivo.Text,

                    //B.
                    perio_descripMotiConsulta = txt_motivoconsultaperiodica.Text,

                    //C.
                    perio_descripcionAntCliQuirurgicos = txt_antCliQuiDescripcion.Text,

                    //perio_siConsuNocivosTabaco = txt_siConsuNociTabaHabToxi.Text,
                    //perio_noConsuNocivosTabaco = txt_noConsuNociTabaHabToxi.Text,
                    perio_tiempoConsuConsuNocivosTabaco = txt_tiemConConsuNociTabaHabToxi.Text,
                    perio_cantidadConsuNocivosTabaco = txt_cantiConsuNociTabaHabToxi.Text,
                    perio_exConsumiConsuNocivosTabaco = txt_exConsumiConsuNociTabaHabToxi.Text,
                    perio_tiempoAbstiConsuNocivosTabaco = txt_tiemAbstiConsuNociTabaHabToxi.Text,

                    //perio_siConsuNocivosAlcohol = txt_siConsuNociAlcoHabToxi.Text,
                    //perio_noConsuNocivosAlcohol = txt_noConsuNociAlcoHabToxi.Text,
                    perio_tiempoConsuConsuNocivosAlcohol = txt_tiemConConsuNociAlcoHabToxi.Text,
                    perio_cantidadConsuNocivosAlcohol = txt_cantiConsuNociAlcoHabToxi.Text,
                    perio_exConsumiConsuNocivosAlcohol = txt_exConsumiConsuNociAlcoHabToxi.Text,
                    perio_tiempoAbstiConsuNocivosAlcohol = txt_tiemAbstiConsuNociAlcoHabToxi.Text,

                    //perio_siConsuNocivosOtrasDrogas = txt_siConsuNociOtrasDroHabToxi.Text,
                    //perio_noConsuNocivosOtrasDrogas = txt_noConsuNociOtrasDroHabToxi.Text,
                    perio_tiempoConsu1ConsuNocivosOtrasDrogas = txt_tiemCon1ConsuNociOtrasDroHabToxi.Text,
                    perio_cantidad1ConsuNocivosOtrasDrogas = txt_canti1ConsuNociOtrasDroHabToxi.Text,
                    perio_exConsumi1ConsuNocivosOtrasDrogas = txt_exConsumi1ConsuNociOtrasDroHabToxi.Text,
                    perio_tiempoAbsti1ConsuNocivosOtrasDrogas = txt_tiemAbsti1ConsuNociOtrasDroHabToxi.Text,
                    perio_otrasConsuNocivos = txt_otrasConsuNociOtrasDroHabToxi.Text,
                    perio_tiempoConsu2ConsuNocivosOtrasDrogas = txt_tiemCon2ConsuNociOtrasDroHabToxi.Text,
                    perio_cantidad2ConsuNocivosOtrasDrogas = txt_canti2ConsuNociOtrasDroHabToxi.Text,
                    perio_exConsumi2ConsuNocivosOtrasDrogas = txt_exConsumi2ConsuNociOtrasDroHabToxi.Text,
                    perio_tiempoAbsti2ConsuNocivosOtrasDrogas = txt_tiemAbsti2ConsuNociOtrasDroHabToxi.Text,

                    //perio_siEstiVidaActFisica = txt_siEstVidaActFisiEstVida.Text,
                    //perio_noEstiVidaActFisica = txt_noEstVidaActFisiEstVida.Text,
                    perio_cualEstiVidaActFisica = txt_cualEstVidaActFisiEstVida.Text,
                    perio_tiem_cantEstiVidaActFisica = txt_tiemCanEstVidaActFisiEstVida.Text,

                    //perio_siEstiVidaMediHabitual = txt_siEstVidaMedHabiEstVida.Text,
                    //perio_noEstiVidaMediHabitual = txt_noEstVidaMedHabiEstVida.Text,
                    perio_cual1EstiVidaMediHabitual = txt_cual1EstVidaMedHabiEstVida.Text,
                    perio_tiem_cant1EstiVidaMediHabitual = txt_tiemCan1EstVidaMedHabiEstVida.Text,
                    perio_cual2EstiVidaMediHabitual = txt_cual2EstVidaMedHabiEstVida.Text,
                    perio_tiem_cant2EstiVidaMediHabitual = txt_tiemCan2EstVidaMedHabiEstVida.Text,
                    perio_cual3EstiVidaMediHabitual = txt_cual3EstVidaMedHabiEstVida.Text,
                    perio_tiem_cant3EstiVidaMediHabitual = txt_tiemCan3EstVidaMedHabiEstVida.Text,

                    perio_descripIncidentes = txt_incidentesperiodica.Text,

                    //perio_siCalificadoIESSAcciTrabajo = txt_sicalificadotrabajo.Text,
                    perio_EspecifiCalificadoIESSAcciTrabajo = txt_especificarcalificadotrabajo.Text,
                    //perio_noCalificadoIESSAcciTrabajo = txt_nocalificadotrabajo.Text,
                    perio_fechaCalificadoIESSAcciTrabajo = Convert.ToDateTime(txt_fechacalificadotrabajo.Text),
                    perio_observacionesAcciTrabajo = txt_obsercalificadotrabajo.Text,

                    //perio_siCalificadoIESSEnferProfesionales = txt_sicalificadoprofesional.Text,
                    perio_EspecifiCalificadoIESSEnferProfesionales = txt_especificarcalificadoprofesional.Text,
                    //perio_noCalificadoIESSEnferProfesionales = txt_nocalificadoprofesional.Text,
                    perio_fechaCalificadoIESSEnferProfesionales = Convert.ToDateTime(txt_fechacalificadoprofesional.Text),
                    perio_observacionesEnferProfesionales = txt_obsercalificadoprofesional.Text,

                    //D.
                    //perio_enfCarVas = txt_enfermedadcardiovascular.Text,
                    //perio_enfMeta = txt_enfermedadmetabolica.Text,
                    //perio_enfNeuro = txt_enfermedadneurologica.Text,
                    //perio_enfOnco = txt_enfermedadoncologica.Text,
                    //perio_enfInfe = txt_enfermedadinfecciosa.Text,
                    //perio_enfHereConge = txt_enfermedadhereditaria.Text,
                    //perio_discapa = txt_discapacidades.Text,
                    //perio_otros = txt_otrosenfer.Text,
                    perio_descripcionAntFamiliares = txt_descripcionantefamiliares.Text,

                    //E.
                    //facriestrabperiodica.FacRiesTrabActPeriodica_area = txt_puestotrabajoperiodica.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_actividades = txt_act.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_tiemTrabPeriodica = txt_tiempotrabajo.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_temAltasFis = txt_tempaltas.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_temBajasFis = txt_tempbajas.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_radIonizanteFis = txt_radiacion.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_radNoIonizanteFis = txt_noradiacion.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_ruidoFis = txt_ruido.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_vibracionFis = txt_vibracion.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_iluminacionFis = txt_iluminacion.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_ventilacionFis = txt_ventilacion.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_fluElectricoFis = txt_fluidoelectrico.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_otrosFis = txt_otros1.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_atraMaquinasMec = txt_atrapmaquinas.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_atraSuperfiiesMec = txt_atrapsuperficie.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_atraObjetosMec = txt_atrapobjetos.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_caidaObjetosMec = txt_caidaobjetos.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_caidaMisNivelMec = txt_caidamisnivel.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_caidaDifNivelMec = txt_caidadifnivel.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_contactoElecMec = txt_contaelectrico.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_conSuperTrabaMec = txt_contasuptrabajo.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_proPartiFragMec = txt_proyparticulas.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_proFluidosMec = txt_proyefluidos.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_pinchazosMec = txt_pinchazos.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_cortesMec = txt_cortes.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_atropeVehiMec = txt_atroporvehiculos.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_coliVehiMec = txt_choques.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_otrosMec = txt_otros2.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_solidosQui = txt_solidos.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_polvosQui = txt_polvos.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_humosQui = txt_humos.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_liquidosQui = txt_liquidos.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_vaporesQui = txt_vapores.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_aerosolesQui = txt_aerosoles.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_neblinasQui = txt_neblinas.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_gaseososQui = txt_gaseosos.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_otrosBio = txt_otros3.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_virusBio = txt_virus.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_hongosBio = txt_hongos.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_bacteriasBio = txt_bacterias.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_parasitosBio = txt_parasitos.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_expVectBio = txt_expoavectores.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_expAniSelvaBio = txt_expoanimselvaticos.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_otrosBio = txt_otros4.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_maneManCarErg = txt_manmanualcargas.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_movRepeErg = txt_movrepetitivo.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_posForzaErg = txt_postforzadas.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_trabPvdErg = txt_trabajopvd.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_otrosErg = txt_otros5.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_monoTrabPsi = txt_montrabajo.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_sobrecarLabPsi = txt_sobrecargalaboral.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_minuTareaPsi = txt_minustarea.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_altaResponPsi = txt_altarespon.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_autoTomaDesiPsi = txt_automadesiciones.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_supEstDirecDefiPsi = txt_supyestdireficiente.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_conflicRolPsi = txt_conflictorol.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_falClariFunPsi = txt_faltaclarfunciones.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_incoDistriTrabPsi = txt_incorrdistrabajo.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_turnosRotaPsi = txt_turnorotat.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_relInterperPsi = txt_relacinterpersonales.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_inesLabPsi = txt_inestalaboral.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_otrosPsi = txt_otros6.Text;
                    //facriestrabperiodica.FacRiesTrabActPeriodica_medPreventivas = txt_medpreventivas.Text;

                    //F.
                    perio_descripEnfActual = txt_enfermedadactualperiodica.Text,

                    //G.
                    perio_pielAnexos = txt_pielanexos.Text,
                    perio_orgSentidos = txt_organossentidos.Text,
                    perio_respiratorio = txt_respiratorio.Text,
                    perio_cardVascular = txt_cardiovascular.Text,
                    perio_digestivo = txt_digestivo.Text,
                    perio_genUrinario = txt_genitourinario.Text,
                    perio_muscEsqueletico = txt_musculosesqueleticos.Text,
                    perio_endocrino = txt_endocrino.Text,
                    perio_hemoLimfa = txt_hemolinfatico.Text,
                    perio_nervioso = txt_nervioso.Text,
                    perio_descripRevOrgaSistemas = txt_descrorganosysistemasperiodica.Text,

                    //I.
                    perio_cicatricesPiel = txt_cicatrices.Text,
                    perio_tatuajesPiel = txt_tatuajes.Text,
                    perio_pielFacerasPiel = txt_pielyfaneras.Text,
                    perio_parpadosOjos = txt_parpados.Text,
                    perio_conjuntuvasOjos = txt_conjuntivas.Text,
                    perio_pupilasOjos = txt_pupilas.Text,
                    perio_corneaOjos = txt_cornea.Text,
                    perio_motilidadOjos = txt_motilidad.Text,
                    perio_cAudiExtreOido = txt_auditivoexterno.Text,
                    perio_pabellonOido = txt_pabellon.Text,
                    perio_timpanosOido = txt_timpanos.Text,
                    perio_labiosOroFa = txt_labios.Text,
                    perio_lenguaOroFa = txt_lengua.Text,
                    perio_faringeOroFa = txt_faringe.Text,
                    perio_amigdalasOroFa = txt_amigdalas.Text,
                    perio_dentaduraOroFa = txt_dentadura.Text,
                    perio_tabiqueNariz = txt_tabique.Text,
                    perio_cornetesNariz = txt_cornetes.Text,
                    perio_mucosasNariz = txt_mucosa.Text,
                    perio_senosParanaNariz = txt_senosparanasales.Text,
                    perio_tiroiMasasCuello = txt_tiroides.Text,
                    perio_movilidadCuello = txt_movilidad.Text,
                    perio_mamasTorax = txt_mamas.Text,
                    perio_corazonTorax = txt_corazon.Text,
                    perio_pulmonesTorax2 = txt_pulmones.Text,
                    perio_parriCostalTorax2 = txt_parrillacostal.Text,
                    perio_viscerasAbdomen = txt_visceras.Text,
                    perio_paredAbdomiAbdomen = txt_paredabdominal.Text,
                    perio_flexibilidadColumna = txt_flexibilidad.Text,
                    perio_desviacionColumna = txt_desviacion.Text,
                    perio_dolorColumna = txt_dolor.Text,
                    perio_pelvisPelvis = txt_pelvis.Text,
                    perio_genitalesPelvis = txt_genitales.Text,
                    perio_vascularExtre = txt_vascular.Text,
                    perio_miemSupeExtre = txt_miembrosuperiores.Text,
                    perio_miemInfeExtre = txt_miembrosinferiores.Text,
                    perio_fuerzaNeuro = txt_fuerza.Text,
                    perio_sensibiNeuro = txt_sensibilidad.Text,
                    perio_marchaNeuro = txt_marcha.Text,
                    perio_refleNeuro = txt_reflejos.Text,
                    perio_observaExaFisRegional = txt_obervexamenfisicoregional.Text,

                    //J.
                    perio_examen = txt_examen.Text,
                    perio_fecha = Convert.ToDateTime(txt_fechaexamen.Text),
                    perio_resultado = txt_resultadoexamen.Text,
                    perio_observacionesResExaGenEspPuesTrabajo = txt_observacionexamen.Text,

                    //K.
                    perio_descripcionDiagnostico = txt_descripdiagnostico.Text,
                    perio_cie = txt_cie.Text,
                    perio_pre = txt_pre.Text,
                    perio_def = txt_def.Text,

                    //L.
                    perio_apto = txt_apto.Text,
                    perio_aptoObserva = txt_aptoobservacion.Text,
                    perio_aptoLimi = txt_aptolimitacion.Text,
                    perio_NoApto = txt_noapto.Text,
                    perio_ObservAptMedTrabajo = txt_observacionaptitud.Text,
                    perio_LimitAptMedTrabajo = txt_limitacionaptitud.Text,

                    //M.
                    perio_descripcionRecoTratamiento = txt_descripciontratamientoperiodica.Text,

                    //N.
                    perio_fecha_hora = Convert.ToDateTime(txt_fechahora.Text),
                    prof_id = Convert.ToInt32(ddl_profesional.SelectedValue),
                    perio_cod = txt_codigoDatProf.Text,
                    Per_id = perso
                };
                           
                CN_Periodica.GuardarPeriodica(perio);

                //Mensaje de confirmacion
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Guardados Exitosamente')", true);
            
                Response.Redirect("~/Template/Views/PacientesPeriodica.aspx");

            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Guardados')", true);
            }

        }

        private void ModificarPeriodica(Tbl_Periodica perio)
        {
            try
            {
                //A
                perio.perio_numArchivo = txt_numArchivo.Text;

                //B.
                perio.perio_descripMotiConsulta = txt_motivoconsultaperiodica.Text;

                //C.
                perio.perio_descripcionAntCliQuirurgicos = txt_antCliQuiDescripcion.Text;

                //perio.perio_siConsuNocivosTabaco = txt_siConsuNociTabaHabToxi.Text;
                //perio.perio_noConsuNocivosTabaco = txt_noConsuNociTabaHabToxi.Text;
                perio.perio_tiempoConsuConsuNocivosTabaco = txt_tiemConConsuNociTabaHabToxi.Text;
                perio.perio_cantidadConsuNocivosTabaco = txt_cantiConsuNociTabaHabToxi.Text;
                perio.perio_exConsumiConsuNocivosTabaco = txt_exConsumiConsuNociTabaHabToxi.Text;
                perio.perio_tiempoAbstiConsuNocivosTabaco = txt_tiemAbstiConsuNociTabaHabToxi.Text;

                //perio.perio_siConsuNocivosAlcohol = txt_siConsuNociAlcoHabToxi.Text;
                //perio.perio_noConsuNocivosAlcohol = txt_noConsuNociAlcoHabToxi.Text;
                perio.perio_tiempoConsuConsuNocivosAlcohol = txt_tiemConConsuNociAlcoHabToxi.Text;
                perio.perio_cantidadConsuNocivosAlcohol = txt_cantiConsuNociAlcoHabToxi.Text;
                perio.perio_exConsumiConsuNocivosAlcohol = txt_exConsumiConsuNociAlcoHabToxi.Text;
                perio.perio_tiempoAbstiConsuNocivosAlcohol = txt_tiemAbstiConsuNociAlcoHabToxi.Text;

                //perio.perio_siConsuNocivosOtrasDrogas = txt_siConsuNociOtrasDroHabToxi.Text;
                //perio.perio_noConsuNocivosOtrasDrogas = txt_noConsuNociOtrasDroHabToxi.Text;
                perio.perio_tiempoConsu1ConsuNocivosOtrasDrogas = txt_tiemCon1ConsuNociOtrasDroHabToxi.Text;
                perio.perio_cantidad1ConsuNocivosOtrasDrogas = txt_canti1ConsuNociOtrasDroHabToxi.Text;
                perio.perio_exConsumi1ConsuNocivosOtrasDrogas = txt_exConsumi1ConsuNociOtrasDroHabToxi.Text;
                perio.perio_tiempoAbsti1ConsuNocivosOtrasDrogas = txt_tiemAbsti1ConsuNociOtrasDroHabToxi.Text;
                perio.perio_otrasConsuNocivos = txt_otrasConsuNociOtrasDroHabToxi.Text;
                perio.perio_tiempoConsu2ConsuNocivosOtrasDrogas = txt_tiemCon2ConsuNociOtrasDroHabToxi.Text;
                perio.perio_cantidad2ConsuNocivosOtrasDrogas = txt_canti2ConsuNociOtrasDroHabToxi.Text;
                perio.perio_exConsumi2ConsuNocivosOtrasDrogas = txt_exConsumi2ConsuNociOtrasDroHabToxi.Text;
                perio.perio_tiempoAbsti2ConsuNocivosOtrasDrogas = txt_tiemAbsti2ConsuNociOtrasDroHabToxi.Text;

                //perio.perio_siEstiVidaActFisica = txt_siEstVidaActFisiEstVida.Text;
                //perio.perio_noEstiVidaActFisica = txt_noEstVidaActFisiEstVida.Text;
                perio.perio_cualEstiVidaActFisica = txt_cualEstVidaActFisiEstVida.Text;
                perio.perio_tiem_cantEstiVidaActFisica = txt_tiemCanEstVidaActFisiEstVida.Text;

                //perio.perio_siEstiVidaMediHabitual = txt_siEstVidaMedHabiEstVida.Text;
                //perio.perio_noEstiVidaMediHabitual = txt_noEstVidaMedHabiEstVida.Text;
                perio.perio_cual1EstiVidaMediHabitual = txt_cual1EstVidaMedHabiEstVida.Text;
                perio.perio_tiem_cant1EstiVidaMediHabitual = txt_tiemCan1EstVidaMedHabiEstVida.Text;
                perio.perio_cual2EstiVidaMediHabitual = txt_cual2EstVidaMedHabiEstVida.Text;
                perio.perio_tiem_cant2EstiVidaMediHabitual = txt_tiemCan2EstVidaMedHabiEstVida.Text;
                perio.perio_cual3EstiVidaMediHabitual = txt_cual3EstVidaMedHabiEstVida.Text;
                perio.perio_tiem_cant3EstiVidaMediHabitual = txt_tiemCan3EstVidaMedHabiEstVida.Text;

                perio.perio_descripIncidentes = txt_incidentesperiodica.Text;

                //perio.perio_siCalificadoIESSAcciTrabajo = txt_sicalificadotrabajo.Text;
                perio.perio_EspecifiCalificadoIESSAcciTrabajo = txt_especificarcalificadotrabajo.Text;
                //perio.perio_noCalificadoIESSAcciTrabajo = txt_nocalificadotrabajo.Text;
                perio.perio_fechaCalificadoIESSAcciTrabajo = Convert.ToDateTime(txt_fechacalificadotrabajo.Text);
                perio.perio_observacionesAcciTrabajo = txt_obsercalificadotrabajo.Text;

                //perio.perio_siCalificadoIESSEnferProfesionales = txt_sicalificadoprofesional.Text;
                perio.perio_EspecifiCalificadoIESSEnferProfesionales = txt_especificarcalificadoprofesional.Text;
                //perio.perio_noCalificadoIESSEnferProfesionales = txt_nocalificadoprofesional.Text;
                perio.perio_fechaCalificadoIESSEnferProfesionales = Convert.ToDateTime(txt_fechacalificadoprofesional.Text);
                perio.perio_observacionesEnferProfesionales = txt_obsercalificadoprofesional.Text;

                //D.
                //perio.perio_enfCarVas = txt_enfermedadcardiovascular.Text;
                //perio.perio_enfMeta = txt_enfermedadmetabolica.Text;
                //perio.perio_enfNeuro = txt_enfermedadneurologica.Text;
                //perio.perio_enfOnco = txt_enfermedadoncologica.Text;
                //perio.perio_enfInfe = txt_enfermedadinfecciosa.Text;
                //perio.perio_enfHereConge = txt_enfermedadhereditaria.Text;
                //perio.perio_discapa = txt_discapacidades.Text;
                //perio.perio_otros = txt_otrosenfer.Text;
                perio.perio_descripcionAntFamiliares = txt_descripcionantefamiliares.Text;

                //E.
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_area = txt_puestotrabajoperio.periodica.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_actividades = txt_act.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_tiemTrabperio.periodica = txt_tiempotrabajo.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_temAltasFis = txt_tempaltas.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_temBajasFis = txt_tempbajas.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_radIonizanteFis = txt_radiacion.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_radNoIonizanteFis = txt_noradiacion.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_ruidoFis = txt_ruido.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_vibracionFis = txt_vibracion.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_iluminacionFis = txt_iluminacion.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_ventilacionFis = txt_ventilacion.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_fluElectricoFis = txt_fluidoelectrico.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_otrosFis = txt_otros1.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_atraMaquinasMec = txt_atrapmaquinas.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_atraSuperfiiesMec = txt_atrapsuperficie.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_atraObjetosMec = txt_atrapobjetos.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_caidaObjetosMec = txt_caidaobjetos.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_caidaMisNivelMec = txt_caidamisnivel.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_caidaDifNivelMec = txt_caidadifnivel.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_contactoElecMec = txt_contaelectrico.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_conSuperTrabaMec = txt_contasuptrabajo.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_proPartiFragMec = txt_proyparticulas.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_proFluidosMec = txt_proyefluidos.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_pinchazosMec = txt_pinchazos.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_cortesMec = txt_cortes.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_atropeVehiMec = txt_atroporvehiculos.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_coliVehiMec = txt_choques.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_otrosMec = txt_otros2.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_solidosQui = txt_solidos.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_polvosQui = txt_polvos.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_humosQui = txt_humos.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_liquidosQui = txt_liquidos.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_vaporesQui = txt_vapores.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_aerosolesQui = txt_aerosoles.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_neblinasQui = txt_neblinas.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_gaseososQui = txt_gaseosos.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_otrosBio = txt_otros3.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_virusBio = txt_virus.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_hongosBio = txt_hongos.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_bacteriasBio = txt_bacterias.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_parasitosBio = txt_parasitos.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_expVectBio = txt_expoavectores.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_expAniSelvaBio = txt_expoanimselvaticos.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_otrosBio = txt_otros4.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_maneManCarErg = txt_manmanualcargas.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_movRepeErg = txt_movrepetitivo.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_posForzaErg = txt_postforzadas.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_trabPvdErg = txt_trabajopvd.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_otrosErg = txt_otros5.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_monoTrabPsi = txt_montrabajo.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_sobrecarLabPsi = txt_sobrecargalaboral.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_minuTareaPsi = txt_minustarea.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_altaResponPsi = txt_altarespon.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_autoTomaDesiPsi = txt_automadesiciones.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_supEstDirecDefiPsi = txt_supyestdireficiente.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_conflicRolPsi = txt_conflictorol.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_falClariFunPsi = txt_faltaclarfunciones.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_incoDistriTrabPsi = txt_incorrdistrabajo.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_turnosRotaPsi = txt_turnorotat.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_relInterperPsi = txt_relacinterpersonales.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_inesLabPsi = txt_inestalaboral.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_otrosPsi = txt_otros6.Text;
                //facriestrabperio.periodica.FacRiesTrabActperio.periodica_medPreventivas = txt_medpreventivas.Text;

                //F.
                perio.perio_descripEnfActual = txt_enfermedadactualperiodica.Text;

                //G.
                perio.perio_pielAnexos = txt_pielanexos.Text;
                perio.perio_orgSentidos = txt_organossentidos.Text;
                perio.perio_respiratorio = txt_respiratorio.Text;
                perio.perio_cardVascular = txt_cardiovascular.Text;
                perio.perio_digestivo = txt_digestivo.Text;
                perio.perio_genUrinario = txt_genitourinario.Text;
                perio.perio_muscEsqueletico = txt_musculosesqueleticos.Text;
                perio.perio_endocrino = txt_endocrino.Text;
                perio.perio_hemoLimfa = txt_hemolinfatico.Text;
                perio.perio_nervioso = txt_nervioso.Text;
                perio.perio_descripRevOrgaSistemas = txt_descrorganosysistemasperiodica.Text;

                //I.
                perio.perio_cicatricesPiel = txt_cicatrices.Text;
                perio.perio_tatuajesPiel = txt_tatuajes.Text;
                perio.perio_pielFacerasPiel = txt_pielyfaneras.Text;
                perio.perio_parpadosOjos = txt_parpados.Text;
                perio.perio_conjuntuvasOjos = txt_conjuntivas.Text;
                perio.perio_pupilasOjos = txt_pupilas.Text;
                perio.perio_corneaOjos = txt_cornea.Text;
                perio.perio_motilidadOjos = txt_motilidad.Text;
                perio.perio_cAudiExtreOido = txt_auditivoexterno.Text;
                perio.perio_pabellonOido = txt_pabellon.Text;
                perio.perio_timpanosOido = txt_timpanos.Text;
                perio.perio_labiosOroFa = txt_labios.Text;
                perio.perio_lenguaOroFa = txt_lengua.Text;
                perio.perio_faringeOroFa = txt_faringe.Text;
                perio.perio_amigdalasOroFa = txt_amigdalas.Text;
                perio.perio_dentaduraOroFa = txt_dentadura.Text;
                perio.perio_tabiqueNariz = txt_tabique.Text;
                perio.perio_cornetesNariz = txt_cornetes.Text;
                perio.perio_mucosasNariz = txt_mucosa.Text;
                perio.perio_senosParanaNariz = txt_senosparanasales.Text;
                perio.perio_tiroiMasasCuello = txt_tiroides.Text;
                perio.perio_movilidadCuello = txt_movilidad.Text;
                perio.perio_mamasTorax = txt_mamas.Text;
                perio.perio_corazonTorax = txt_corazon.Text;
                perio.perio_pulmonesTorax2 = txt_pulmones.Text;
                perio.perio_parriCostalTorax2 = txt_parrillacostal.Text;
                perio.perio_viscerasAbdomen = txt_visceras.Text;
                perio.perio_paredAbdomiAbdomen = txt_paredabdominal.Text;
                perio.perio_flexibilidadColumna = txt_flexibilidad.Text;
                perio.perio_desviacionColumna = txt_desviacion.Text;
                perio.perio_dolorColumna = txt_dolor.Text;
                perio.perio_pelvisPelvis = txt_pelvis.Text;
                perio.perio_genitalesPelvis = txt_genitales.Text;
                perio.perio_vascularExtre = txt_vascular.Text;
                perio.perio_miemSupeExtre = txt_miembrosuperiores.Text;
                perio.perio_miemInfeExtre = txt_miembrosinferiores.Text;
                perio.perio_fuerzaNeuro = txt_fuerza.Text;
                perio.perio_sensibiNeuro = txt_sensibilidad.Text;
                perio.perio_marchaNeuro = txt_marcha.Text;
                perio.perio_refleNeuro = txt_reflejos.Text;
                perio.perio_observaExaFisRegional = txt_obervexamenfisicoregional.Text;

                //J.
                perio.perio_examen = txt_examen.Text;
                perio.perio_fecha = Convert.ToDateTime(txt_fechaexamen.Text);
                perio.perio_resultado = txt_resultadoexamen.Text;
                perio.perio_observacionesResExaGenEspPuesTrabajo = txt_observacionexamen.Text;

                //K.
                perio.perio_descripcionDiagnostico = txt_descripdiagnostico.Text;
                perio.perio_cie = txt_cie.Text;
                perio.perio_pre = txt_pre.Text;
                perio.perio_def = txt_def.Text;

                //L.
                perio.perio_apto = txt_apto.Text;
                perio.perio_aptoObserva = txt_aptoobservacion.Text;
                perio.perio_aptoLimi = txt_aptolimitacion.Text;
                perio.perio_NoApto = txt_noapto.Text;
                perio.perio_ObservAptMedTrabajo = txt_observacionaptitud.Text;
                perio.perio_LimitAptMedTrabajo = txt_limitacionaptitud.Text;

                //M.
                perio.perio_descripcionRecoTratamiento = txt_descripciontratamientoperiodica.Text;

                //N.
                perio.perio_fecha_hora = Convert.ToDateTime(txt_fechahora.Text);
                perio.prof_id = Convert.ToInt32(ddl_profesional.SelectedValue);
                perio.perio_cod = txt_codigoDatProf.Text;

                CN_Periodica.ModificarPeriodica(perio);

                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Modificados Exitosamente')", true);
                Response.Redirect("~/Template/Views/PacientesPeriodica.aspx");
            }   
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Modificados')", true);
            }
        }

        private void guardar_modificar_datos(int periodica)
        {
            if (periodica == 0)
            {
                GuardarPeriodica();
            }
            else
            {
                perio = CN_Periodica.ObtenerPeriodicaPorId(periodica);

                if (perio != null)
                {
                    ModificarPeriodica(perio);
                }
            }
        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            guardar_modificar_datos(Convert.ToInt32(Request["cod"]));
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