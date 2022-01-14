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
    public partial class Periodica : System.Web.UI.Page
    {
        DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        //Objeto de la tabla personas
        private Tbl_Personas per = new Tbl_Personas();

        //A. Objeto de la tabla DATOS DEL ESTABLECIMIENTO - EMPRESA Y USUARIO (DESDE RELIGION)
        private Tbl_DatEstableEmpUsu datempusuid = new Tbl_DatEstableEmpUsu();

        //B. Objeto de la tabla MOTIVO CONSULTA
        private Tbl_MotivoConsultaPeriodica motconper = new Tbl_MotivoConsultaPeriodica();

        //C. Objeto de la tabla ANTECEDENTES PERSONALES
        private Tbl_AntecedentesPersonalesPeriodica antpersperiodica = new Tbl_AntecedentesPersonalesPeriodica();

        //D. Objeto de la tabla ANTECEDENTES FAMILIARES
        private Tbl_AntecedentesFamiliaresDetParentescoPeriodica obtantfamparperiodica = new Tbl_AntecedentesFamiliaresDetParentescoPeriodica();

        //E. Objeto de la tabla RIESGO DEL PUESTO DE TRABAJO ACTUAL
        private Tbl_FacRiesTrabActPeriodica facriestrabperiodica = new Tbl_FacRiesTrabActPeriodica();

        //F. Objeto de la tabla ENFERMEDAD ACTUAL
        private Tbl_EnfermedadActualPeriodica enferactperiodica = new Tbl_EnfermedadActualPeriodica();

        //G. Objeto de la tabla REVISIÓN ACTUAL DE ÓRGANOS Y SISTEMAS
        private Tbl_RevisionActualOrganosSistemasPeriodica obtrevactorgsisperiodica = new Tbl_RevisionActualOrganosSistemasPeriodica();

        //I. Objeto de la tabla EXAMEN FÍSICO REGIONAL
        private Tbl_ExaFisRegionalPeriodica exafisregperiodica = new Tbl_ExaFisRegionalPeriodica();

        //J. Objeto de la tabla RESULTADO DE EXAMENES GENERALES Y ESPECIFICOS DE ACUERDO AL RIESGO Y PUESTO DE TRABAJO
        private Tbl_ResExaGenEspRiesTrabajoPeriodica resexagenperiodica = new Tbl_ResExaGenEspRiesTrabajoPeriodica();

        //K. Objeto de la tabla DIAGNÓSTICO
        private Tbl_DiagnosticoPeriodica diagperiodica = new Tbl_DiagnosticoPeriodica();

        //L. Objeto de la tabla APTITUD MÉDICA PARA EL TRABAJO
        private Tbl_AptitudMedicaPeriodica aptmedperiodica = new Tbl_AptitudMedicaPeriodica();

        //M. Objeto de la tabla RECOMENDACIONES Y/O TRATAMIENTO
        private Tbl_RecoTratamientoPeriodica tratamientoperiodica = new Tbl_RecoTratamientoPeriodica();

        //N. Objeto de la tabla DATOS DEL PROFESIONAL
        private Tbl_DatProfesionalPeriodica datosProfesionalPeriodica = new Tbl_DatProfesionalPeriodica();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //CargarDatosModificar();
                //cargarProfesional();
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
            }
        }

        private void guardar_modificar_datos(int perid, int datempusuperid, int motconperid, int antpersonalesperid, int antfamiliaresperid,
            int facrietrabperid, int enfactperid, int revactorgsisperid, int exafiregperid, int resexgenperid, int diagperid, 
            int aptmedperid, int traperid, int datproperid)
        {
            if (perid == 0 || datempusuperid == 0 || motconperid == 0 || antpersonalesperid == 0 || antfamiliaresperid == 0 ||
                facrietrabperid == 0 || enfactperid == 0 || revactorgsisperid == 0 || exafiregperid == 0 || resexgenperid == 0 ||
                diagperid == 0 || aptmedperid == 0 || traperid == 0 || datproperid == 0)
            {
                GuardarPeriodica();
            }
            else
            {

                //per = CN_HistorialMedico.obtenerPersonasxId(perid);
                //int perso = Convert.ToInt32(per.Per_id.ToString());              

            }
        }
        private void GuardarPeriodica()
        {
            try
            {
                per = CN_HistorialMedico.obtenerIdPersonasxCedula(Convert.ToInt32(txt_numHClinica.Text));

                int perso = Convert.ToInt32(per.Per_id.ToString());

                // A
                datempusuid = new Tbl_DatEstableEmpUsu();
                // B
                motconper = new Tbl_MotivoConsultaPeriodica();
                // C
                antpersperiodica = new Tbl_AntecedentesPersonalesPeriodica();
                // D
                obtantfamparperiodica = new Tbl_AntecedentesFamiliaresDetParentescoPeriodica();
                // E
                facriestrabperiodica = new Tbl_FacRiesTrabActPeriodica();
                // F
                enferactperiodica = new Tbl_EnfermedadActualPeriodica();
                // G
                obtrevactorgsisperiodica = new Tbl_RevisionActualOrganosSistemasPeriodica();
                // I
                exafisregperiodica = new Tbl_ExaFisRegionalPeriodica();
                // J
                resexagenperiodica = new Tbl_ResExaGenEspRiesTrabajoPeriodica();
                // K
                diagperiodica = new Tbl_DiagnosticoPeriodica();
                // L
                aptmedperiodica = new Tbl_AptitudMedicaPeriodica();
                // M
                tratamientoperiodica = new Tbl_RecoTratamientoPeriodica();
                // N
                datosProfesionalPeriodica = new Tbl_DatProfesionalPeriodica();

                //A. Captura de Datos Establecimiento Empresa Usuario

                //B. Captura de datos Motivo de Consulta
                motconper.motConPeriodica_descrip = txt_motivoconsultaperiodica.Text;
                motconper.Per_id = perso;

                //C. Captura de datos tbl_AntecedentesCliQuiru(
                antpersperiodica.antPerPeriodica_descripcion = txt_antCliQuiDescripcion.Text;

                antpersperiodica.antPerPeriodica_siConsuNocivosTabaco = txt_siConsuNociTabaHabToxi.Text;
                antpersperiodica.antPerPeriodica_noConsuNocivosTabaco = txt_noConsuNociTabaHabToxi.Text;
                antpersperiodica.antPerPeriodica_tiempoConsuConsuNocivosTabaco = Convert.ToInt32(txt_tiemConConsuNociTabaHabToxi.Text);
                antpersperiodica.antPerPeriodica_cantidadConsuNocivosTabaco = txt_cantiConsuNociTabaHabToxi.Text;
                antpersperiodica.antPerPeriodica_exConsumiConsuNocivosTabaco = txt_exConsumiConsuNociTabaHabToxi.Text;
                antpersperiodica.antPerPeriodica_tiempoAbstiConsuNocivosTabaco = Convert.ToInt32(txt_tiemAbstiConsuNociTabaHabToxi.Text);

                antpersperiodica.antPerPeriodica_siConsuNocivosAlcohol = txt_siConsuNociAlcoHabToxi.Text;
                antpersperiodica.antPerPeriodica_noConsuNocivosAlcohol = txt_noConsuNociAlcoHabToxi.Text;
                antpersperiodica.antPerPeriodica_tiempoConsuConsuNocivosAlcohol = Convert.ToInt32(txt_tiemConConsuNociAlcoHabToxi.Text);
                antpersperiodica.antPerPeriodica_cantidadConsuNocivosAlcohol = txt_cantiConsuNociAlcoHabToxi.Text;
                antpersperiodica.antPerPeriodica_exConsumiConsuNocivosAlcohol = txt_exConsumiConsuNociAlcoHabToxi.Text;
                antpersperiodica.antPerPeriodica_tiempoAbstiConsuNocivosAlcohol = Convert.ToInt32(txt_tiemAbstiConsuNociAlcoHabToxi.Text);

                antpersperiodica.antPerPeriodica_siConsuNocivosOtrasDrogas = txt_siConsuNociOtrasDroHabToxi.Text;
                antpersperiodica.antPerPeriodica_noConsuNocivosOtrasDrogas = txt_noConsuNociOtrasDroHabToxi.Text;
                antpersperiodica.antPerPeriodica_tiempoConsu1ConsuNocivosOtrasDrogas = Convert.ToInt32(txt_tiemCon1ConsuNociOtrasDroHabToxi.Text);
                antpersperiodica.antPerPeriodica_cantidad1ConsuNocivosOtrasDrogas = txt_canti1ConsuNociOtrasDroHabToxi.Text;
                antpersperiodica.antPerPeriodica_exConsumi1ConsuNocivosOtrasDrogas = txt_exConsumi1ConsuNociOtrasDroHabToxi.Text;
                antpersperiodica.antPerPeriodica_tiempoAbsti1ConsuNocivosOtrasDrogas = Convert.ToInt32(txt_tiemAbsti1ConsuNociOtrasDroHabToxi.Text);
                antpersperiodica.antPerPeriodica_otrasConsuNocivos = txt_otrasConsuNociOtrasDroHabToxi.Text;
                antpersperiodica.antPerPeriodica_tiempoConsu2ConsuNocivosOtrasDrogas = Convert.ToInt32(txt_tiemCon2ConsuNociOtrasDroHabToxi.Text);
                antpersperiodica.antPerPeriodica_cantidad2ConsuNocivosOtrasDrogas = txt_canti2ConsuNociOtrasDroHabToxi.Text;
                antpersperiodica.antPerPeriodica_exConsumi2ConsuNocivosOtrasDrogas = txt_exConsumi2ConsuNociOtrasDroHabToxi.Text;
                antpersperiodica.antPerPeriodica_tiempoAbsti2ConsuNocivosOtrasDrogas = Convert.ToInt32(txt_tiemAbsti2ConsuNociOtrasDroHabToxi.Text);

                antpersperiodica.antPerPeriodica_siEstiVidaActFisica = txt_siEstVidaActFisiEstVida.Text;
                antpersperiodica.antPerPeriodica_noEstiVidaActFisica = txt_noEstVidaActFisiEstVida.Text;
                antpersperiodica.antPerPeriodica_cualEstiVidaActFisica = txt_cualEstVidaActFisiEstVida.Text;
                antpersperiodica.antPerPeriodica_tiem_cantEstiVidaActFisica = txt_tiemCanEstVidaActFisiEstVida.Text;

                antpersperiodica.antPerPeriodica_siEstiVidaMediHabitual = txt_siEstVidaMedHabiEstVida.Text;
                antpersperiodica.antPerPeriodica_noEstiVidaMediHabitual = txt_noEstVidaMedHabiEstVida.Text;
                antpersperiodica.antPerPeriodica_cual1EstiVidaMediHabitual = txt_cual1EstVidaMedHabiEstVida.Text;
                antpersperiodica.antPerPeriodica_tiem_cant1EstiVidaMediHabitual = txt_tiemCan1EstVidaMedHabiEstVida.Text;
                antpersperiodica.antPerPeriodica_cual2EstiVidaMediHabitual = txt_cual2EstVidaMedHabiEstVida.Text;
                antpersperiodica.antPerPeriodica_tiem_cant2EstiVidaMediHabitual = txt_tiemCan2EstVidaMedHabiEstVida.Text;
                antpersperiodica.antPerPeriodica_cual3EstiVidaMediHabitual = txt_cual3EstVidaMedHabiEstVida.Text;
                antpersperiodica.antPerPeriodica_tiem_cant3EstiVidaMediHabitual = txt_tiemCan3EstVidaMedHabiEstVida.Text;

                antpersperiodica.antPerPeriodica_descripIncidentes = txt_incidentesperiodica.Text;

                antpersperiodica.antPerPeriodica_siCalificadoIESSAcciTrabajo = txt_sicalificadotrabajo.Text;
                antpersperiodica.antPerPeriodica_EspecifiCalificadoIESSAcciTrabajo = txt_especificarcalificadotrabajo.Text;
                antpersperiodica.antPerPeriodica_noCalificadoIESSAcciTrabajo = txt_nocalificadotrabajo.Text;
                antpersperiodica.antPerPeriodica_fechaCalificadoIESSAcciTrabajo = Convert.ToDateTime(txt_fechacalificadotrabajo.Text);
                antpersperiodica.antPerPeriodica_observacionesAcciTrabajo = txt_obsercalificadotrabajo.Text;

                antpersperiodica.antPerPeriodica_siCalificadoIESSEnferProfesionales = txt_sicalificadoprofesional.Text;
                antpersperiodica.antPerPeriodica_EspecifiCalificadoIESSEnferProfesionales = txt_especificarcalificadoprofesional.Text;
                antpersperiodica.antPerPeriodica_noCalificadoIESSEnferProfesionales = txt_nocalificadoprofesional.Text;
                antpersperiodica.antPerPeriodica_fechaCalificadoIESSEnferProfesionales = Convert.ToDateTime(txt_fechacalificadoprofesional.Text);
                antpersperiodica.antPerPeriodica_observacionesEnferProfesionales = txt_obsercalificadoprofesional.Text;

                antpersperiodica.Per_id = perso;

                //D. Captura de Datos ANTECEDENTES FAMILIARES (DETALLAR EL PARENTESCO)
                obtantfamparperiodica.AntFamDetParePeriodica_enfCarVas = txt_enfermedadcardiovascular.Text;
                obtantfamparperiodica.AntFamDetParePeriodica_enfMeta = txt_enfermedadmetabolica.Text;
                obtantfamparperiodica.AntFamDetParePeriodica_enfNeuro = txt_enfermedadneurologica.Text;
                obtantfamparperiodica.AntFamDetParePeriodica_enfOnco = txt_enfermedadoncologica.Text;
                obtantfamparperiodica.AntFamDetParePeriodica_enfInfe = txt_enfermedadinfecciosa.Text;
                obtantfamparperiodica.AntFamDetParePeriodica_enfHereConge = txt_enfermedadhereditaria.Text;
                obtantfamparperiodica.AntFamDetParePeriodica_discapa = txt_discapacidades.Text;
                obtantfamparperiodica.AntFamDetParePeriodica_otros = txt_otrosenfer.Text;
                obtantfamparperiodica.AntFamDetParePeriodica_descripcion = txt_descripcionantefamiliares.Text;
                obtantfamparperiodica.Per_id = perso;

                //E. Captura de Datos Tbl_FacRiesTrabAct
                facriestrabperiodica.FacRiesTrabActPeriodica_area = txt_puestotrabajoperiodica.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_actividades = txt_act.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_tiemTrabPeriodica = txt_tiempotrabajo.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_temAltasFis = txt_tempaltas.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_temBajasFis = txt_tempbajas.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_radIonizanteFis = txt_radiacion.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_radNoIonizanteFis = txt_noradiacion.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_ruidoFis = txt_ruido.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_vibracionFis = txt_vibracion.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_iluminacionFis = txt_iluminacion.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_ventilacionFis = txt_ventilacion.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_fluElectricoFis = txt_fluidoelectrico.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_otrosFis = txt_otros1.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_atraMaquinasMec = txt_atrapmaquinas.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_atraSuperfiiesMec = txt_atrapsuperficie.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_atraObjetosMec = txt_atrapobjetos.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_caidaObjetosMec = txt_caidaobjetos.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_caidaMisNivelMec = txt_caidamisnivel.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_caidaDifNivelMec = txt_caidadifnivel.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_contactoElecMec = txt_contaelectrico.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_conSuperTrabaMec = txt_contasuptrabajo.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_proPartiFragMec = txt_proyparticulas.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_proFluidosMec = txt_proyefluidos.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_pinchazosMec = txt_pinchazos.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_cortesMec = txt_cortes.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_atropeVehiMec = txt_atroporvehiculos.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_coliVehiMec = txt_choques.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_otrosMec = txt_otros2.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_solidosQui = txt_solidos.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_polvosQui = txt_polvos.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_humosQui = txt_humos.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_liquidosQui = txt_liquidos.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_vaporesQui = txt_vapores.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_aerosolesQui = txt_aerosoles.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_neblinasQui = txt_neblinas.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_gaseososQui = txt_gaseosos.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_otrosBio = txt_otros3.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_virusBio = txt_virus.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_hongosBio = txt_hongos.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_bacteriasBio = txt_bacterias.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_parasitosBio = txt_parasitos.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_expVectBio = txt_expoavectores.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_expAniSelvaBio = txt_expoanimselvaticos.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_otrosBio = txt_otros4.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_maneManCarErg = txt_manmanualcargas.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_movRepeErg = txt_movrepetitivo.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_posForzaErg = txt_postforzadas.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_trabPvdErg = txt_trabajopvd.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_otrosErg = txt_otros5.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_monoTrabPsi = txt_montrabajo.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_sobrecarLabPsi = txt_sobrecargalaboral.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_minuTareaPsi = txt_minustarea.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_altaResponPsi = txt_altarespon.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_autoTomaDesiPsi = txt_automadesiciones.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_supEstDirecDefiPsi = txt_supyestdireficiente.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_conflicRolPsi = txt_conflictorol.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_falClariFunPsi = txt_faltaclarfunciones.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_incoDistriTrabPsi = txt_incorrdistrabajo.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_turnosRotaPsi = txt_turnorotat.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_relInterperPsi = txt_relacinterpersonales.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_inesLabPsi = txt_inestalaboral.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_otrosPsi = txt_otros6.Text;
                facriestrabperiodica.FacRiesTrabActPeriodica_medPreventivas = txt_medpreventivas.Text;
                facriestrabperiodica.Per_id = perso;

                //F. Captura de Datos Enfermedad Actual
                enferactperiodica.enfActualPeriodica_descrip = txt_enfermedadactualperiodica.Text;
                enferactperiodica.Per_id = perso;

                //G. Captura de Datos REVISIÓN ACTUAL DE ÓRGANOS Y SISTEMAS
                obtrevactorgsisperiodica.RevActOrgSisPeriodica_pielAnexos = txt_pielanexos.Text;
                obtrevactorgsisperiodica.RevActOrgSisPeriodica_orgSentidos = txt_organossentidos.Text;
                obtrevactorgsisperiodica.RevActOrgSisPeriodica_respiratorio = txt_respiratorio.Text;
                obtrevactorgsisperiodica.RevActOrgSisPeriodica_cardVascular = txt_cardiovascular.Text;
                obtrevactorgsisperiodica.RevActOrgSisPeriodica_digestivo = txt_digestivo.Text;
                obtrevactorgsisperiodica.RevActOrgSisPeriodica_genUrinario = txt_genitourinario.Text;
                obtrevactorgsisperiodica.RevActOrgSisPeriodica_muscEsqueletico = txt_musculosesqueleticos.Text;
                obtrevactorgsisperiodica.RevActOrgSisPeriodica_endocrino = txt_endocrino.Text;
                obtrevactorgsisperiodica.RevActOrgSisPeriodica_hemoLimfa = txt_hemolinfatico.Text;
                obtrevactorgsisperiodica.RevActOrgSisPeriodica_nervioso = txt_nervioso.Text;
                obtrevactorgsisperiodica.RevActOrgSisPeriodica_descrip = txt_descrorganosysistemasperiodica.Text;
                obtrevactorgsisperiodica.Per_id = perso;

                //I. Captura de Datos Examen Fisico Regional
                exafisregperiodica.exaFisRegPeriodica_cicatricesPiel = txt_cicatrices.Text;
                exafisregperiodica.exaFisRegPeriodica_tatuajesPiel = txt_tatuajes.Text;
                exafisregperiodica.exaFisRegPeriodica_pielFacerasPiel = txt_pielyfaneras.Text;
                exafisregperiodica.exaFisRegPeriodica_parpadosOjos = txt_parpados.Text;
                exafisregperiodica.exaFisRegPeriodica_conjuntuvasOjos = txt_conjuntivas.Text;
                exafisregperiodica.exaFisRegPeriodica_pupilasOjos = txt_pupilas.Text;
                exafisregperiodica.exaFisRegPeriodica_corneaOjos = txt_cornea.Text;
                exafisregperiodica.exaFisRegPeriodica_motilidadOjos = txt_motilidad.Text;
                exafisregperiodica.exaFisRegPeriodica_cAudiExtreOido = txt_auditivoexterno.Text;
                exafisregperiodica.exaFisRegPeriodica_pabellonOido = txt_pabellon.Text;
                exafisregperiodica.exaFisRegPeriodica_timpanosOido = txt_timpanos.Text;
                exafisregperiodica.exaFisRegPeriodica_labiosOroFa = txt_labios.Text;
                exafisregperiodica.exaFisRegPeriodica_lenguaOroFa = txt_lengua.Text;
                exafisregperiodica.exaFisRegPeriodica_faringeOroFa = txt_faringe.Text;
                exafisregperiodica.exaFisRegPeriodica_amigdalasOroFa = txt_amigdalas.Text;
                exafisregperiodica.exaFisRegPeriodica_dentaduraOroFa = txt_dentadura.Text;
                exafisregperiodica.exaFisRegPeriodica_tabiqueNariz = txt_tabique.Text;
                exafisregperiodica.exaFisRegPeriodica_cornetesNariz = txt_cornetes.Text;
                exafisregperiodica.exaFisRegPeriodica_mucosasNariz = txt_mucosa.Text;
                exafisregperiodica.exaFisRegPeriodica_senosParanaNariz = txt_senosparanasales.Text;
                exafisregperiodica.exaFisRegPeriodica_tiroiMasasCuello = txt_tiroides.Text;
                exafisregperiodica.exaFisRegPeriodica_movilidadCuello = txt_movilidad.Text;
                exafisregperiodica.exaFisRegPeriodica_mamasTorax = txt_mamas.Text;
                exafisregperiodica.exaFisRegPeriodica_corazonTorax = txt_corazon.Text;
                exafisregperiodica.exaFisRegPeriodica_pulmonesTorax2 = txt_pulmones.Text;
                exafisregperiodica.exaFisRegPeriodica_parriCostalTorax2 = txt_parrillacostal.Text;
                exafisregperiodica.exaFisRegPeriodica_viscerasAbdomen = txt_visceras.Text;
                exafisregperiodica.exaFisRegPeriodica_paredAbdomiAbdomen = txt_paredabdominal.Text;
                exafisregperiodica.exaFisRegPeriodica_flexibilidadColumna = txt_flexibilidad.Text;
                exafisregperiodica.exaFisRegPeriodica_desviacionColumna = txt_desviacion.Text;
                exafisregperiodica.exaFisRegPeriodica_dolorColumna = txt_dolor.Text;
                exafisregperiodica.exaFisRegPeriodica_pelvisPelvis = txt_pelvis.Text;
                exafisregperiodica.exaFisRegPeriodica_genitalesPelvis = txt_genitales.Text;
                exafisregperiodica.exaFisRegPeriodica_vascularExtre = txt_vascular.Text;
                exafisregperiodica.exaFisRegPeriodica_miemSupeExtre = txt_miembrosuperiores.Text;
                exafisregperiodica.exaFisRegPeriodica_miemInfeExtre = txt_miembrosinferiores.Text;
                exafisregperiodica.exaFisRegPeriodica_fuerzaNeuro = txt_fuerza.Text;
                exafisregperiodica.exaFisRegPeriodica_sensibiNeuro = txt_sensibilidad.Text;
                exafisregperiodica.exaFisRegPeriodica_marchaNeuro = txt_marcha.Text;
                exafisregperiodica.exaFisRegPeriodica_refleNeuro = txt_reflejos.Text;
                exafisregperiodica.exaFisRegPeriodica_observa = txt_obervexamenfisicoregional.Text;
                exafisregperiodica.Per_id = perso;

                //J. Captura de Datos Tbl_ResExaGenEspRiesTrabajo
                resexagenperiodica.ResExaGenEspRiesTrabajoPeriodica_examen = txt_examen.Text;
                resexagenperiodica.ResExaGenEspRiesTrabajoPeriodica_fecha = Convert.ToDateTime(txt_fechaexamen.Text);
                resexagenperiodica.ResExaGenEspRiesTrabajoPeriodica_resultados = txt_resultadoexamen.Text;
                resexagenperiodica.ResExaGenEspRiesTrabajoPeriodica_observaciones = txt_observacionexamen.Text;
                resexagenperiodica.Per_id = perso;

                //K. Captura de Datos Tbl_Diagnostico
                diagperiodica.DiagPeriodica_descripcion = txt_descripdiagnostico.Text;
                diagperiodica.DiagPeriodica_cie = txt_cie.Text;
                diagperiodica.DiagPeriodica_pre = txt_pre.Text;
                diagperiodica.DiagPeriodica_def = txt_def.Text;
                diagperiodica.Per_id = perso;

                //L.Captura de Datos Tbl_AptitudMedica
                aptmedperiodica.AptMedPeriodica_apto = txt_apto.Text;
                aptmedperiodica.AptMedPeriodica_aptoObserva = txt_aptoobservacion.Text;
                aptmedperiodica.AptMedPeriodica_aptoLimi = txt_aptolimitacion.Text;
                aptmedperiodica.AptMedPeriodica_NoApto = txt_noapto.Text;
                aptmedperiodica.AptMedPeriodica_Observ = txt_observacionaptitud.Text;
                aptmedperiodica.AptMedPeriodica_Limit = txt_limitacionaptitud.Text;
                aptmedperiodica.Per_id = perso;

                //M. Captura de Datos Recomendaciones y/o Tratamiento
                tratamientoperiodica.RecTraPeriodica_descripcion = txt_descripciontratamientoperiodica.Text;
                tratamientoperiodica.Per_id = perso;

                //N. Captura de Datos RProfesional
                datosProfesionalPeriodica.DatProfePeriodica_fecha_hora = Convert.ToDateTime(txt_fechaDatProf.Text);
                datosProfesionalPeriodica.prof_id = Convert.ToInt32(ddl_profesional.SelectedValue);
                datosProfesionalPeriodica.DatProfePeriodica_cod = txt_codigoDatProf.Text;
                datosProfesionalPeriodica.Per_id = perso;

                //A . Método para guardar Datos Establecimeinto Empresa Usuarios
                CN_Periodica.guardarDatEstEmpreUsuarPeriodica(datempusuid);
                //B . Método para guardar Datos Motivo Consulta
                CN_Periodica.guardarMotivoConsultaPeriodica(motconper);
                //C . Método para guardar Datos Antecedentes Personales
                CN_Periodica.guardarAntPersonalesPeriodica(antpersperiodica);
                //D. Método de guardar Datos ANTECEDENTES FAMILIARES (DETALLAR EL PARENTESCO)
                CN_Periodica.guardarAntecedentesFamiliaresDetParentescoPeriodica(obtantfamparperiodica);
                //E. Método de guardar Datos Riesgo Puesto Trabajo Actual
                CN_Periodica.guardarRiesgoPuesTrabaActualPeriodica(facriestrabperiodica);
                //F. Método de guardar Datos Enfermedad Actual
                CN_Periodica.guardarEnfermedadActualPeriodica(enferactperiodica);
                //G. Método de guardar Datos REVISIÓN ACTUAL DE ÓRGANOS Y SISTEMAS
                CN_Periodica.guardarReviActualOrganSistemasPeriodica(obtrevactorgsisperiodica);
                //I. Método de guardar Datos Examen Fisico Regional
                CN_Periodica.guardarExamenFisicoRegionalPeriodica(exafisregperiodica);
                //J. Método de guardar Datos Resul. Exam. General y Espec de acuerdo al Riesgo y puesto de trabajo
                CN_Periodica.guardarExaGenEspeRiesyPuesPeriodica(resexagenperiodica);
                //K. Método de guardar Datos diagnostico
                CN_Periodica.guardarDiagnosticoPeriodica(diagperiodica);
                //L. Método de guardar Datos aptitud medica para el trabajo
                CN_Periodica.guardarAptiMediTrabajoPeriodica(aptmedperiodica);
                //M. Método de guardar Datos recomendaciones y tratamiento
                CN_Periodica.guardarRecomendacionesTratamientoPeriodica(tratamientoperiodica);
                //N. Método de guardar Datos del profesional
                CN_Periodica.guardarDatosProfesionalPeriodica(datosProfesionalPeriodica);


                //Mensaje de confirmacion
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Guardados Exitosamente')", true);

                Response.Redirect("~/Template/Views/PacientesInicial.aspx");
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
           
        }

        protected void btn_guardarperiodica_Click(object sender, EventArgs e)
        {
            guardar_modificar_datos(Convert.ToInt32(Request["cod"]), Convert.ToInt32(per.Per_id.ToString()),
                Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()),
                Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()),
                Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()),
                Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()));
        }

        protected void btn_modificarperiodica_Click(object sender, EventArgs e)
        {

        }

        protected void btn_cancelarperiodica_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/Views/Inicio.aspx");
        }
    }
}