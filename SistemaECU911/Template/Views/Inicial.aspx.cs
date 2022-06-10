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
                        //Religion
                        if (inicial.inicial_catolicaRel == null)
                        {
                            ckb_catolica.Checked = false;
                            
                        }
                        else
                        {
                            ckb_catolica.Checked = true;
                        }
                        if (inicial.inicial_evangelicaRel == null)
                        {
                            ckb_evangelica.Checked = false;
                            
                        }
                        else
                        {
                            ckb_evangelica.Checked = true;
                        }
                        if (inicial.inicial_testJehovaRel == null)
                        {
                            cbk_testigo.Checked = false;
                            
                        }
                        else
                        {
                            cbk_testigo.Checked = true;
                        }
                        if (inicial.inicial_mormonaRel == null)
                        {
                            cbk_mormona.Checked = false;
                            
                        }
                        else
                        {
                            cbk_mormona.Checked = true;
                        }
                        if (inicial.inicial_otrasRel == null)
                        {
                            cbk_otrareligion.Checked = false;
                            
                        }
                        else
                        {
                            cbk_otrareligion.Checked = true;
                        }

                        //Orientacion Sexual
                        if (inicial.inicial_gayOriSex == null)
                        {
                            cbk_gay.Checked = false;
                            
                        }
                        else
                        {
                            cbk_gay.Checked = true;
                        }
                        if (inicial.inicial__lesbianaOriSex == null)
                        {
                            cbk_lesbiana.Checked = false;
                        }
                        else
                        {
                            cbk_lesbiana.Checked = true;
                        }
                        if (inicial.inicial_bisexualOriSex == null)
                        {
                            cbk_bisexual.Checked = false;
                            
                        }
                        else
                        {
                            cbk_bisexual.Checked = true;
                        }
                        if (inicial.inicial_heterosexualOriSex == null)
                        {
                            cbk_heterosexual.Checked = false;
                            
                        }
                        else
                        {
                            cbk_heterosexual.Checked = true;
                        }
                        if (inicial.inicial_norespondeOriSex == null)
                        {
                            cbk_noRespondeOriSex.Checked = false;
                            
                        }
                        else
                        {
                            cbk_noRespondeOriSex.Checked = true;
                        }

                        //Identidad de genero
                        if (inicial.inicial_femeninoIdenGen == null)
                        {
                            cbk_femenino.Checked = false;
                            
                        }
                        else
                        {
                            cbk_femenino.Checked = true;
                        }
                        if (inicial.inicial_masculinoIdenGen == null)
                        {
                            cbk_masculino.Checked = false;
                            
                        }
                        else
                        {
                            cbk_masculino.Checked = true;
                        }
                        if (inicial.inicial_transFemeninoIdenGen == null)
                        {
                            cbk_transfemenino.Checked = false;
                            
                        }
                        else
                        {
                            cbk_transfemenino.Checked = true;
                        }
                        if (inicial.inicial_transMasculinoIdenGen == null)
                        {
                            cbk_transmasculino.Checked = false;
                            
                        }
                        else
                        {
                            cbk_transmasculino.Checked = true;
                        }
                        if (inicial.inicial_norespondeIdenGen == null)
                        {
                            cbk_noRespondeIdeGen.Checked = false;
                            
                        }
                        else
                        {
                            cbk_noRespondeIdeGen.Checked = true;
                        }

                        //Discapacidad
                        if (inicial.inicial_siDis == null)
                        {
                            cbk_sidiscapacidad.Checked = false;
                            
                        }
                        else
                        {
                            cbk_sidiscapacidad.Checked = true;
                        }
                        if (inicial.inicial_noDis == null)
                        {
                            cbk_nodiscapacidad.Checked = false;
                            
                        }
                        else
                        {
                            cbk_nodiscapacidad.Checked = true;
                        }

                        //Vida sexual
                        if (inicial.inicial_siVidaSexActiva == null)
                        {
                            ckb_siVidSexAntGinObste.Checked = false;
                            
                        }
                        else
                        {
                            ckb_siVidSexAntGinObste.Checked = true;
                        }
                        if (inicial.inicial_noVidaSexActiva == null)
                        {
                            ckb_noVidSexAntGinObste.Checked = false;
                            
                        }
                        else
                        {
                            ckb_noVidSexAntGinObste.Checked = true;
                        }

                        //Metodo de planificacion familiar Antecedentes gineco obstetricos
                        if (inicial.inicial_siMetPlanifiFamiliar == null)
                        {
                            ckb_siMetPlaniAntGinObste.Checked = false;
                            
                        }
                        else
                        {
                            ckb_siMetPlaniAntGinObste.Checked = true;
                        }
                        if (inicial.inicial_noMetPlanifiFamiliar == null)
                        {
                            ckb_noMetPlaniAntGinObste.Checked = false;
                            
                        }
                        else
                        {
                            ckb_noMetPlaniAntGinObste.Checked = true;
                        }

                        //Papanicolaou
                        if (inicial.inicial_siExaRealiPapanicolaou == null)
                        {
                            ckb_siPapaniAntGinObste.Checked = false;
                            
                        }
                        else
                        {
                            ckb_siPapaniAntGinObste.Checked = true;
                        }
                        if (inicial.inicial_noExaRealiPapanicolaou == null)
                        {
                            ckb_noPapaniAntGinObste.Checked = false;
                            
                        }
                        else
                        {
                            ckb_noPapaniAntGinObste.Checked = true;
                        }

                        //Eco Mamario
                        if (inicial.inicial_siExaRealiEcoMamario == null)
                        {
                            ckb_siEcoMamaAntGinObste.Checked = false;
                            
                        }
                        else
                        {
                            ckb_siEcoMamaAntGinObste.Checked = true;
                        }
                        if (inicial.inicial_noExaRealiEcoMamario == null)
                        {
                            ckb_noEcoMamaAntGinObste.Checked = false;
                            
                        }
                        else
                        {
                            ckb_noEcoMamaAntGinObste.Checked = true;
                        }

                        //Colposcopia
                        if (inicial.inicial_siExaRealiColposcopia == null)
                        {
                            ckb_siColposAntGinObste.Checked = false;
                            
                        }
                        else
                        {
                            ckb_siColposAntGinObste.Checked = true;
                        }
                        if (inicial.inicial_noExaRealiColposcopia == null)
                        {
                            ckb_siMamograAntGinObste.Checked = false;
                            
                        }
                        else
                        {
                            ckb_siMamograAntGinObste.Checked = true;
                        }

                        //Mamografia
                        if (inicial.inicial_siExaRealiMamografia == null)
                        {
                            ckb_siMamograAntGinObste.Checked = false;
                        }
                        else
                        {
                            ckb_siMamograAntGinObste.Checked = true;
                        }
                        if (inicial.inicial_noExaRealiMamografia == null)
                        {
                            ckb_noMamograAntGinObste.Checked = false;
                            
                        }
                        else
                        {
                            ckb_noMamograAntGinObste.Checked = true;
                        }

                        //Antigeno Prostatico
                        if (inicial.inicial_siExaRealiAntiProstatico == null)
                        {
                            ckb_siExaRealiAntProstaAntReproMascu.Checked = false;
                            
                        }
                        else
                        {
                            ckb_siExaRealiAntProstaAntReproMascu.Checked = true;
                        }
                        if (inicial.inicial_noExaRealiAntiProstatico == null)
                        {
                            ckb_noExaRealiAntProstaAntReproMascu.Checked = false;
                            
                        }
                        else
                        {
                            ckb_noExaRealiAntProstaAntReproMascu.Checked = true;
                        }

                        //Metodo de planificacion familiar Antecedentes reproductivos masculinos
                        if (inicial.inicial_siMetPlanifiFamiAntReproMascu == null)
                        {
                            ckb_siMetPlaniAntReproMascu.Checked = false;
                            
                        }
                        else
                        {
                            ckb_siMetPlaniAntReproMascu.Checked = true;
                        }
                        if (inicial.inicial_noMetPlanifiFamiAntReproMascu == null)
                        {
                            ckb_noMetPlaniAntReproMascu.Checked = false;
                            
                        }
                        else
                        {
                            ckb_noMetPlaniAntReproMascu.Checked = true;
                        }

                        //Eco Prostatico
                        if (inicial.inicial_siExaRealiEcoProstatico == null)
                        {
                            ckb_siExaRealiEcoProstaAntReproMascu.Checked = false;
                            
                        }
                        else
                        {
                            ckb_siExaRealiEcoProstaAntReproMascu.Checked = true;
                        }
                        if (inicial.inicial_noExaRealiEcoProstatico == null)
                        {
                            ckb_noExaRealiEcoProstaAntReproMascu.Checked = false;
                            
                        }
                        else
                        {
                            ckb_noExaRealiEcoProstaAntReproMascu.Checked = true;
                        }

                        //Tabaco
                        if (inicial.inicial_siConsuNocivosTabaco == null)
                        {
                            ckb_siConsuNociTabaHabToxi.Checked = false;
                            
                        }
                        else
                        {
                            ckb_siConsuNociTabaHabToxi.Checked = true;
                        }
                        if (inicial.inicial_noConsuNocivosTabaco == null)
                        {
                            ckb_noConsuNociTabaHabToxi.Checked = false;
                            
                        }
                        else
                        {
                            ckb_noConsuNociTabaHabToxi.Checked = true;
                        }

                        //Alcohol
                        if (inicial.inicial_siConsuNocivosAlcohol == null)
                        {
                            ckb_siConsuNociAlcoHabToxi.Checked = false;
                            
                        }
                        else
                        {
                            ckb_siConsuNociAlcoHabToxi.Checked = true;
                        }
                        if (inicial.inicial_noConsuNocivosAlcohol == null)
                        {
                            ckb_noConsuNociAlcoHabToxi.Checked = false;
                            
                        }
                        else
                        {
                            ckb_noConsuNociAlcoHabToxi.Checked = true;
                        }

                        //Otras Drogas
                        if (inicial.inicial_siConsuNocivosOtrasDrogas == null)
                        {
                            ckb_siConsuNociOtrasDroHabToxi.Checked = false;
                            
                        }
                        else
                        {
                            ckb_siConsuNociOtrasDroHabToxi.Checked = true;
                        }
                        if (inicial.inicial_noConsuNocivosOtrasDrogas == null)
                        {
                            ckb_noConsuNociOtrasDroHabToxi.Checked = false;
                            
                        }
                        else
                        {
                            ckb_noConsuNociOtrasDroHabToxi.Checked = true;
                        }

                        //Actividad Fisica
                        if (inicial.inicial_siEstiVidaActFisica == null)
                        {
                            ckb_siEstVidaActFisiEstVida.Checked = false;
                            
                        }
                        else
                        {
                            ckb_siEstVidaActFisiEstVida.Checked = true;
                        }
                        if (inicial.inicial_noEstiVidaActFisica == null)
                        {
                            ckb_noEstVidaActFisiEstVida.Checked = false;
                            
                        }
                        else
                        {
                            ckb_noEstVidaActFisiEstVida.Checked = true;
                        }

                        //Medicacion Habitual
                        if (inicial.inicial_siEstiVidaMediHabitual == null)
                        {
                            ckb_siEstVidaMedHabiEstVida.Checked = false;
                            
                        }
                        else
                        {
                            ckb_siEstVidaMedHabiEstVida.Checked = true;
                        }
                        if (inicial.inicial_noEstiVidaMediHabitual == null)
                        {
                            ckb_noEstVidaMedHabiEstVida.Checked = false;
                            
                        }
                        else
                        {
                            ckb_noEstVidaMedHabiEstVida.Checked = true;
                        }

                        //Riesgo Antecedentes de empleos anteriores
                        if (inicial.inicial_fisicoRies == null)
                        {
                            ckb_fisico.Checked = false;
                            
                        }
                        else
                        {
                            ckb_fisico.Checked = true;
                        }
                        if (inicial.inicial_mecanicoRies == null)
                        {
                            ckb_mecanico.Checked = false;
                            
                        }
                        else
                        {
                            ckb_mecanico.Checked = true;
                        }
                        if (inicial.inicial_quimicoRies == null)
                        {
                            ckb_quimico.Checked = false;
                            
                        }
                        else
                        {
                            ckb_quimico.Checked = true;
                        }
                        if (inicial.inicial_biologicoRies == null)
                        {
                            ckb_biologico.Checked = false;
                            
                        }
                        else
                        {
                            ckb_biologico.Checked = true;
                        }
                        if (inicial.inicial_ergonomicoRies == null)
                        {
                            ckb_ergonomico.Checked = false;
                            
                        }
                        else
                        {
                            ckb_ergonomico.Checked = true;
                        }
                        if (inicial.inicial_psicosocial == null)
                        {
                            ckb_psicosocial.Checked = false;
                            
                        }
                        else
                        {
                            ckb_psicosocial.Checked = true;
                        }
                        if (inicial.inicial_fisicoRies2 == null)
                        {
                            ckb_fisico2.Checked = false;
                            
                        }
                        else
                        {
                            ckb_fisico2.Checked = true;
                        }
                        if (inicial.inicial_mecanicoRies2 == null)
                        {
                            ckb_mecanico2.Checked = false;
                            
                        }
                        else
                        {
                            ckb_mecanico2.Checked = true;
                        }
                        if (inicial.inicial_quimicoRies2 == null)
                        {
                            ckb_quimico2.Checked = false;
                            
                        }
                        else
                        {
                            ckb_quimico2.Checked = true;
                        }
                        if (inicial.inicial_biologicoRies2 == null)
                        {
                            ckb_biologico2.Checked = false;
                            
                        }
                        else
                        {
                            ckb_biologico2.Checked = true;
                        }
                        if (inicial.inicial_ergonomicoRies2 == null)
                        {
                            ckb_ergonomico2.Checked = false;
                            
                        }
                        else
                        {
                            ckb_ergonomico2.Checked = true;
                        }
                        if (inicial.inicial_psicosocial2 == null)
                        {
                            ckb_psicosocial2.Checked = false;
                            
                        }
                        else
                        {
                            ckb_psicosocial2.Checked = true;
                        }
                        if (inicial.inicial_fisicoRies3 == null)
                        {
                            ckb_fisico3.Checked = false;
                            
                        }
                        else
                        {
                            ckb_fisico3.Checked = true;
                        }
                        if (inicial.inicial_mecanicoRies3 == null)
                        {
                            ckb_mecanico3.Checked = false;
                            
                        }
                        else
                        {
                            ckb_mecanico3.Checked = true;
                        }
                        if (inicial.inicial_quimicoRies3 == null)
                        {
                            ckb_quimico3.Checked = false;
                            
                        }
                        else
                        {
                            ckb_quimico3.Checked = true;
                        }
                        if (inicial.inicial_biologicoRies3 == null)
                        {
                            ckb_biologico3.Checked = false;
                            
                        }
                        else
                        {
                            ckb_biologico3.Checked = true;
                        }
                        if (inicial.inicial_ergonomicoRies3 == null)
                        {
                            ckb_ergonomico3.Checked = false;
                            
                        }
                        else
                        {
                            ckb_ergonomico3.Checked = true;
                        }
                        if (inicial.inicial_psicosocial3 == null)
                        {
                            ckb_psicosocial3.Checked = false;
                            
                        }
                        else
                        {
                            ckb_psicosocial3.Checked = true;
                        }
                        if (inicial.inicial_fisicoRies4 == null)
                        {
                            ckb_fisico4.Checked = false;
                            
                        }
                        else
                        {
                            ckb_fisico4.Checked = true;
                        }
                        if (inicial.inicial_mecanicoRies4 == null)
                        {
                            ckb_mecanico4.Checked = false;
                            
                        }
                        else
                        {
                            ckb_mecanico4.Checked = true;
                        }
                        if (inicial.inicial_quimicoRies4 == null)
                        {
                            ckb_quimico4.Checked = false;
                            
                        }
                        else
                        {
                            ckb_quimico4.Checked = true;
                        }
                        if (inicial.inicial_biologicoRies4 == null)
                        {
                            ckb_biologico4.Checked = false;
                            
                        }
                        else
                        {
                            ckb_biologico4.Checked = true;
                        }
                        if (inicial.inicial_ergonomicoRies4 == null)
                        {
                            
                            ckb_ergonomico4.Checked = false;
                        }
                        else
                        {
                            ckb_ergonomico4.Checked = true;
                        }
                        if (inicial.inicial_psicosocial4 == null)
                        {
                            
                            ckb_psicosocial4.Checked = false;
                        }
                        else
                        {
                            ckb_psicosocial4.Checked = true;
                        }

                        //ANTECEDENTES PERSONALES
                        //----------- ACCIDENTES DE TRABAJO ( DESCRIPCIÓN) -----------
                        if (inicial.inicial_siCalificadoIESSAcciTrabajo == null)
                        {
                            ckb_siAccTrabDescrip.Checked = false;
                        }
                        else
                        {
                            ckb_siAccTrabDescrip.Checked = true;
                        }
                        if (inicial.inicial_noCalificadoIESSAcciTrabajo == null)
                        {
                            ckb_noAccTrabDescrip.Checked = false;
                        }
                        else
                        {
                            ckb_noAccTrabDescrip.Checked = true;
                        }
                        //----------- ENFERMEDADES PROFESIONALES -----------
                        if (inicial.inicial_siCalificadoIESSEnfProfesionales == null)
                        {
                            ckb_siprofesional.Checked = false;
                        }
                        else
                        {
                            ckb_siprofesional.Checked = true;
                        }
                        if (inicial.inicial_noCalificadoIESSEnfProfesionales == null)
                        {
                            ckb_noprofesional.Checked = false;
                        }
                        else
                        {
                            ckb_noprofesional.Checked = true;
                        }

                        //Antecedentes Familiares (Detallar el Parentesco)
                        if (inicial.inicial_enfCarVasAnteFamiliares == null)
                        {
                            ckb_enfermedadcardiovascular.Checked = false;
                        }
                        else
                        {
                            ckb_enfermedadcardiovascular.Checked = true;

                        }
                        if (inicial.inicial_enfMetaAnteFamiliares == null)
                        {
                            ckb_enfermedadmetabolica.Checked = false;
                        }
                        else
                        {
                            ckb_enfermedadmetabolica.Checked = true;

                        }
                        if (inicial.inicial_enfNeuroAnteFamiliares == null)
                        {
                            ckb_enfermedadneurologica.Checked = false; ;
                        }
                        else
                        {
                            ckb_enfermedadneurologica.Checked = true;

                        }
                        if (inicial.inicial_enfOncoAnteFamiliares == null)
                        {
                            ckb_enfermedadoncologica.Checked = false;
                        }
                        else
                        {
                            ckb_enfermedadoncologica.Checked = true;

                        }
                        if (inicial.inicial_enfInfeAnteFamiliares == null)
                        {
                            ckb_enfermedadinfecciosa.Checked = false;
                        }
                        else
                        {
                            ckb_enfermedadinfecciosa.Checked = true;

                        }
                        if (inicial.inicial_enfHereCongeAnteFamiliares == null)
                        {
                            ckb_enfermedadhereditaria.Checked = false;
                        }
                        else
                        {
                            ckb_enfermedadhereditaria.Checked = true;

                        }
                        if (inicial.inicial_discapaAnteFamiliares == null)
                        {
                            ckb_discapacidades.Checked = false;
                        }
                        else
                        {
                            ckb_discapacidades.Checked = true;

                        }
                        if (inicial.inicial_otrosAnteFamiliares == null)
                        {
                            ckb_otrosenfer.Checked = false;
                        }
                        else
                        {
                            ckb_otrosenfer.Checked = true;

                        }

                        //Factores de riesgo del puesto de trabajo
                        //----------- Fisico -----------
                        if (inicial.inicial_temAltasFis == null)
                        {
                            ckb_tempaltas.Checked = false;
                        }
                        else
                        {
                            ckb_tempaltas.Checked = true;

                        }
                        if (inicial.inicial_temBajasFis2 == null)
                        {
                            ckb_tempbajas2.Checked = false;
                        }
                        else
                        {
                            ckb_tempbajas2.Checked = true;

                        }
                        if (inicial.inicial_temBajasFis3 == null)
                        {
                            ckb_tempbajas3.Checked = false;
                        }
                        else
                        {
                            ckb_tempbajas3.Checked = true;

                        }
                        if (inicial.inicial_temBajasFis4 == null)
                        {
                            ckb_tempbajas4.Checked = false;
                        }
                        else
                        {
                            ckb_tempbajas4.Checked = true;

                        }
                        if (inicial.inicial_radIonizanteFis == null)
                        {
                            ckb_radiacion.Checked = false;
                        }
                        else
                        {
                            ckb_radiacion.Checked = true;

                        }
                        if (inicial.inicial_radIonizanteFis2 == null)
                        {
                            ckb_radiacion2.Checked = false;
                        }
                        else
                        {
                            ckb_radiacion2.Checked = true;

                        }
                        if (inicial.inicial_radIonizanteFis3 == null)
                        {
                            ckb_radiacion3.Checked = false;
                        }
                        else
                        {
                            ckb_radiacion3.Checked = true;

                        }
                        if (inicial.inicial_radIonizanteFis4 == null)
                        {
                            ckb_radiacion4.Checked = false;
                        }
                        else
                        {
                            ckb_radiacion4.Checked = true;

                        }
                        if (inicial.inicial_radNoIonizanteFis == null)
                        {
                            ckb_noradiacion.Checked = false;
                        }
                        else
                        {
                            ckb_noradiacion.Checked = true;

                        }
                        if (inicial.inicial_radNoIonizanteFis2 == null)
                        {
                            ckb_noradiacion2.Checked = false;
                        }
                        else
                        {
                            ckb_noradiacion2.Checked = true;

                        }
                        if (inicial.inicial_radNoIonizanteFis3 == null)
                        {
                            ckb_noradiacion3.Checked = false;
                        }
                        else
                        {
                            ckb_noradiacion3.Checked = true;

                        }
                        if (inicial.inicial_radNoIonizanteFis4 == null)
                        {
                            ckb_noradiacion4.Checked = false;
                        }
                        else
                        {
                            ckb_noradiacion4.Checked = true;

                        }
                        if (inicial.inicial_ruidoFis == null)
                        {
                            ckb_ruido.Checked = false;
                        }
                        else
                        {
                            ckb_ruido.Checked = true;

                        }
                        if (inicial.inicial_ruidoFis2 == null)
                        {
                            ckb_ruido2.Checked = false;
                        }
                        else
                        {
                            ckb_ruido2.Checked = true;

                        }
                        if (inicial.inicial_ruidoFis3 == null)
                        {
                            ckb_ruido3.Checked = false;
                        }
                        else
                        {
                            ckb_ruido3.Checked = true;

                        }
                        if (inicial.inicial_ruidoFis4 == null)
                        {
                            ckb_ruido4.Checked = false;
                        }
                        else
                        {
                            ckb_ruido4.Checked = true;

                        }
                        if (inicial.inicial_vibracionFis == null)
                        {
                            ckb_vibracion.Checked = false;
                        }
                        else
                        {
                            ckb_vibracion.Checked = true;

                        }
                        if (inicial.inicial_vibracionFis2 == null)
                        {
                            ckb_vibracion2.Checked = false;
                        }
                        else
                        {
                            ckb_vibracion2.Checked = true;

                        }
                        if (inicial.inicial_vibracionFis3 == null)
                        {
                            ckb_vibracion3.Checked = false;
                        }
                        else
                        {
                            ckb_vibracion3.Checked = true;

                        }
                        if (inicial.inicial_vibracionFis4 == null)
                        {
                            ckb_vibracion4.Checked = false;
                        }
                        else
                        {
                            ckb_vibracion4.Checked = true;

                        }
                        if (inicial.inicial_iluminacionFis == null)
                        {
                            ckb_iluminacion.Checked = false;
                        }
                        else
                        {
                            ckb_iluminacion.Checked = true;

                        }
                        if (inicial.inicial_iluminacionFis2 == null)
                        {
                            ckb_iluminacion2.Checked = false;
                        }
                        else
                        {
                            ckb_iluminacion2.Checked = true;

                        }
                        if (inicial.inicial_iluminacionFis3 == null)
                        {
                            ckb_iluminacion3.Checked = false;
                        }
                        else
                        {
                            ckb_iluminacion3.Checked = true;

                        }
                        if (inicial.inicial_iluminacionFis4 == null)
                        {
                            ckb_iluminacion4.Checked = false;
                        }
                        else
                        {
                            ckb_iluminacion4.Checked = true;

                        }
                        if (inicial.inicial_ventilacionFis == null)
                        {
                            ckb_ventilacion.Checked = false;
                        }
                        else
                        {
                            ckb_ventilacion.Checked = true;

                        }
                        if (inicial.inicial_ventilacionFis2 == null)
                        {
                            ckb_ventilacion2.Checked = false;
                        }
                        else
                        {
                            ckb_ventilacion2.Checked = true;

                        }
                        if (inicial.inicial_ventilacionFis3 == null)
                        {
                            ckb_ventilacion3.Checked = false;
                        }
                        else
                        {
                            ckb_ventilacion3.Checked = true;

                        }
                        if (inicial.inicial_ventilacionFis4 == null)
                        {
                            ckb_ventilacion4.Checked = false;
                        }
                        else
                        {
                            ckb_ventilacion4.Checked = true;

                        }
                        if (inicial.inicial_fluElectricoFis == null)
                        {
                            ckb_fluidoelectrico.Checked = false;
                        }
                        else
                        {
                            ckb_fluidoelectrico.Checked = true;

                        }
                        if (inicial.inicial_fluElectricoFis2 == null)
                        {
                            ckb_fluidoelectrico2.Checked = false;
                        }
                        else
                        {
                            ckb_fluidoelectrico2.Checked = true;

                        }
                        if (inicial.inicial_fluElectricoFis3 == null)
                        {
                            ckb_fluidoelectrico3.Checked = false;
                        }
                        else
                        {
                            ckb_fluidoelectrico3.Checked = true;

                        }
                        if (inicial.inicial_fluElectricoFis4 == null)
                        {
                            ckb_fluidoelectrico4.Checked = false;
                        }
                        else
                        {
                            ckb_fluidoelectrico4.Checked = true;

                        }
                        if (inicial.inicial_otrosFis == null)
                        {
                            ckb_otrosFisico.Checked = false;
                        }
                        else
                        {
                            ckb_otrosFisico.Checked = true;

                        }
                        if (inicial.inicial_otrosFis2 == null)
                        {
                            ckb_otrosFisico2.Checked = false;
                        }
                        else
                        {
                            ckb_otrosFisico2.Checked = true;

                        }
                        if (inicial.inicial_otrosFis3 == null)
                        {
                            ckb_otrosFisico3.Checked = false;
                        }
                        else
                        {
                            ckb_otrosFisico3.Checked = true;

                        }if (inicial.inicial_otrosFis4 == null)
                        {
                            ckb_otrosFisico4.Checked = false;
                        }
                        else
                        {
                            ckb_otrosFisico4.Checked = true;

                        }
                        //----------- Mecanico -----------
                        if (inicial.inicial_atraMaquinasMec == null)
                        {
                            ckb_atrapmaquinas.Checked = false;
                        }
                        else
                        {
                            ckb_atrapmaquinas.Checked = true;

                        }
                        if (inicial.inicial_atraMaquinasMec2 == null)
                        {
                            ckb_atrapmaquinas2.Checked = false;
                        }
                        else
                        {
                            ckb_atrapmaquinas2.Checked = true;

                        }
                        if (inicial.inicial_atraMaquinasMec3 == null)
                        {
                            ckb_atrapmaquinas3.Checked = false;
                        }
                        else
                        {
                            ckb_atrapmaquinas3.Checked = true;

                        }
                        if (inicial.inicial_atraMaquinasMec4 == null)
                        {
                            ckb_atrapmaquinas4.Checked = false;
                        }
                        else
                        {
                            ckb_atrapmaquinas4.Checked = true;

                        }
                        if (inicial.inicial_atraSuperfiiesMec == null)
                        {
                            ckb_atrapsuperficie.Checked = false;
                        }
                        else
                        {
                            ckb_atrapsuperficie.Checked = true;

                        }
                        if (inicial.inicial_atraSuperfiiesMec2 == null)
                        {
                            ckb_atrapsuperficie2.Checked = false;
                        }
                        else
                        {
                            ckb_atrapsuperficie2.Checked = true;

                        }
                        if (inicial.inicial_atraSuperfiiesMec3 == null)
                        {
                            ckb_atrapsuperficie3.Checked = false;
                        }
                        else
                        {
                            ckb_atrapsuperficie3.Checked = true;

                        }
                        if (inicial.inicial_atraSuperfiiesMec4 == null)
                        {
                            ckb_atrapsuperficie4.Checked = false;
                        }
                        else
                        {
                            ckb_atrapsuperficie4.Checked = true;

                        }
                        if (inicial.inicial_atraObjetosMec == null)
                        {
                            ckb_atrapobjetos.Checked = false;
                        }
                        else
                        {
                            ckb_atrapobjetos.Checked = true;

                        }
                        if (inicial.inicial_atraObjetosMec2 == null)
                        {
                            ckb_atrapobjetos2.Checked = false;
                        }
                        else
                        {
                            ckb_atrapobjetos2.Checked = true;

                        }
                        if (inicial.inicial_atraObjetosMec3 == null)
                        {
                            ckb_atrapobjetos3.Checked = false;
                        }
                        else
                        {
                            ckb_atrapobjetos3.Checked = true;

                        }
                        if (inicial.inicial_atraObjetosMec4 == null)
                        {
                            ckb_atrapobjetos4.Checked = false;
                        }
                        else
                        {
                            ckb_atrapobjetos4.Checked = true;

                        }
                        if (inicial.inicial_caidaObjetosMec == null)
                        {
                            ckb_caidaobjetos.Checked = false;
                        }
                        else
                        {
                            ckb_caidaobjetos.Checked = true;

                        }
                        if (inicial.inicial_caidaObjetosMec2 == null)
                        {
                            ckb_caidaobjetos2.Checked = false;
                        }
                        else
                        {
                            ckb_caidaobjetos2.Checked = true;

                        }
                        if (inicial.inicial_caidaObjetosMec3 == null)
                        {
                            ckb_caidaobjetos3.Checked = false;
                        }
                        else
                        {
                            ckb_caidaobjetos3.Checked = true;

                        }
                        if (inicial.inicial_caidaObjetosMec4 == null)
                        {
                            ckb_caidaobjetos4.Checked = false;
                        }
                        else
                        {
                            ckb_caidaobjetos4.Checked = true;

                        }
                        if (inicial.inicial_caidaMisNivelMec == null)
                        {
                            ckb_caidamisnivel.Checked = false;
                        }
                        else
                        {
                            ckb_caidamisnivel.Checked = true;

                        }
                        if (inicial.inicial_caidaMisNivelMec2 == null)
                        {
                            ckb_caidamisnivel2.Checked = false;
                        }
                        else
                        {
                            ckb_caidamisnivel2.Checked = true;

                        }
                        if (inicial.inicial_caidaMisNivelMec3 == null)
                        {
                            ckb_caidamisnivel3.Checked = false;
                        }
                        else
                        {
                            ckb_caidamisnivel3.Checked = true;

                        }
                        if (inicial.inicial_caidaMisNivelMec4 == null)
                        {
                            ckb_caidamisnivel4.Checked = false;
                        }
                        else
                        {
                            ckb_caidamisnivel4.Checked = true;

                        }
                        if (inicial.inicial_caidaDifNivelMec == null)
                        {
                            ckb_caidadifnivel.Checked = false;
                        }
                        else
                        {
                            ckb_caidadifnivel.Checked = true;

                        }
                        if (inicial.inicial_caidaDifNivelMec2 == null)
                        {
                            ckb_caidadifnivel2.Checked = false;
                        }
                        else
                        {
                            ckb_caidadifnivel2.Checked = true;

                        }
                        if (inicial.inicial_caidaDifNivelMec3 == null)
                        {
                            ckb_caidadifnivel3.Checked = false;
                        }
                        else
                        {
                            ckb_caidadifnivel3.Checked = true;

                        }
                        if (inicial.inicial_caidaDifNivelMec4 == null)
                        {
                            ckb_caidadifnivel4.Checked = false;
                        }
                        else
                        {
                            ckb_caidadifnivel4.Checked = true;

                        }
                        if (inicial.inicial_contactoElecMec == null)
                        {
                            ckb_contaelectrico.Checked = false;
                        }
                        else
                        {
                            ckb_contaelectrico.Checked = true;

                        }
                        if (inicial.inicial_contactoElecMec2 == null)
                        {
                            ckb_contaelectrico2.Checked = false;
                        }
                        else
                        {
                            ckb_contaelectrico2.Checked = true;

                        }
                        if (inicial.inicial_contactoElecMec3 == null)
                        {
                            ckb_contaelectrico3.Checked = false;
                        }
                        else
                        {
                            ckb_contaelectrico3.Checked = true;

                        }
                        if (inicial.inicial_contactoElecMec4 == null)
                        {
                            ckb_contaelectrico4.Checked = false;
                        }
                        else
                        {
                            ckb_contaelectrico4.Checked = true;

                        }
                        if (inicial.inicial_conSuperTrabaMec == null)
                        {
                            ckb_contasuptrabajo.Checked = false;
                        }
                        else
                        {
                            ckb_contasuptrabajo.Checked = true;

                        }
                        if (inicial.inicial_conSuperTrabaMec2 == null)
                        {
                            ckb_contasuptrabajo2.Checked = false;
                        }
                        else
                        {
                            ckb_contasuptrabajo2.Checked = true;

                        }
                        if (inicial.inicial_conSuperTrabaMec3 == null)
                        {
                            ckb_contasuptrabajo3.Checked = false;
                        }
                        else
                        {
                            ckb_contasuptrabajo3.Checked = true;

                        }
                        if (inicial.inicial_conSuperTrabaMec4 == null)
                        {
                            ckb_contasuptrabajo4.Checked = false;
                        }
                        else
                        {
                            ckb_contasuptrabajo4.Checked = true;

                        }
                        if (inicial.inicial_proPartiFragMec == null)
                        {
                            ckb_proyparticulas.Checked = false;
                        }
                        else
                        {
                            ckb_proyparticulas.Checked = true;

                        }
                        if (inicial.inicial_proPartiFragMec2 == null)
                        {
                            ckb_proyparticulas2.Checked = false;
                        }
                        else
                        {
                            ckb_proyparticulas2.Checked = true;

                        }
                        if (inicial.inicial_proPartiFragMec3 == null)
                        {
                            ckb_proyparticulas3.Checked = false;
                        }
                        else
                        {
                            ckb_proyparticulas3.Checked = true;

                        }
                        if (inicial.inicial_proPartiFragMec4== null)
                        {
                            ckb_proyparticulas4.Checked = false;
                        }
                        else
                        {
                            ckb_proyparticulas4.Checked = true;

                        }
                        if (inicial.inicial_proFluidosMec == null)
                        {
                            ckb_proyefluidos.Checked = false;
                        }
                        else
                        {
                            ckb_proyefluidos.Checked = true;

                        }
                        if (inicial.inicial_proFluidosMec2 == null)
                        {
                            ckb_proyefluidos2.Checked = false;
                        }
                        else
                        {
                            ckb_proyefluidos2.Checked = true;

                        }
                        if (inicial.inicial_proFluidosMec3 == null)
                        {
                            ckb_proyefluidos3.Checked = false;
                        }
                        else
                        {
                            ckb_proyefluidos3.Checked = true;

                        }
                        if (inicial.inicial_proFluidosMec4 == null)
                        {
                            ckb_proyefluidos4.Checked = false;
                        }
                        else
                        {
                            ckb_proyefluidos4.Checked = true;

                        }
                        if (inicial.inicial_pinchazosMec == null)
                        {
                            ckb_pinchazos.Checked = false;
                        }
                        else
                        {
                            ckb_pinchazos.Checked = true;

                        }
                        if (inicial.inicial_pinchazosMec2 == null)
                        {
                            ckb_pinchazos2.Checked = false;
                        }
                        else
                        {
                            ckb_pinchazos2.Checked = true;

                        }
                        if (inicial.inicial_pinchazosMec3 == null)
                        {
                            ckb_pinchazos3.Checked = false;
                        }
                        else
                        {
                            ckb_pinchazos3.Checked = true;

                        }
                        if (inicial.inicial_pinchazosMec4 == null)
                        {
                            ckb_pinchazos4.Checked = false;
                        }
                        else
                        {
                            ckb_pinchazos4.Checked = true;

                        }
                        if (inicial.inicial_cortesMec == null)
                        {
                            ckb_cortes.Checked = false;
                        }
                        else
                        {
                            ckb_cortes.Checked = true;

                        }
                        if (inicial.inicial_cortesMec2 == null)
                        {
                            ckb_cortes2.Checked = false;
                        }
                        else
                        {
                            ckb_cortes2.Checked = true;

                        }
                        if (inicial.inicial_cortesMec3 == null)
                        {
                            ckb_cortes3.Checked = false;
                        }
                        else
                        {
                            ckb_cortes3.Checked = true;

                        }
                        if (inicial.inicial_cortesMec4 == null)
                        {
                            ckb_cortes4.Checked = false;
                        }
                        else
                        {
                            ckb_cortes4.Checked = true;

                        }
                        if (inicial.inicial_atropeVehiMec == null)
                        {
                            ckb_atroporvehiculos.Checked = false;
                        }
                        else
                        {
                            ckb_atroporvehiculos.Checked = true;

                        }
                        if (inicial.inicial_atropeVehiMec2 == null)
                        {
                            ckb_atroporvehiculos2.Checked = false;
                        }
                        else
                        {
                            ckb_atroporvehiculos2.Checked = true;

                        }
                        if (inicial.inicial_atropeVehiMec3 == null)
                        {
                            ckb_atroporvehiculos3.Checked = false;
                        }
                        else
                        {
                            ckb_atroporvehiculos3.Checked = true;

                        }
                        if (inicial.inicial_atropeVehiMec4 == null)
                        {
                            ckb_atroporvehiculos4.Checked = false;
                        }
                        else
                        {
                            ckb_atroporvehiculos4.Checked = true;

                        }
                        if (inicial.inicial_coliVehiMec == null)
                        {
                            ckb_choques.Checked = false;
                        }
                        else
                        {
                            ckb_choques.Checked = true;

                        }
                        if (inicial.inicial_coliVehiMec2 == null)
                        {
                            ckb_choques2.Checked = false;
                        }
                        else
                        {
                            ckb_choques2.Checked = true;

                        }
                        if (inicial.inicial_coliVehiMec3 == null)
                        {
                            ckb_choques3.Checked = false;
                        }
                        else
                        {
                            ckb_choques3.Checked = true;

                        }
                        if (inicial.inicial_coliVehiMec4 == null)
                        {
                            ckb_choques4.Checked = false;
                        }
                        else
                        {
                            ckb_choques4.Checked = true;

                        }
                        if (inicial.inicial_otrosMec == null)
                        {
                            ckb_otrosMecanico.Checked = false;
                        }
                        else
                        {
                            ckb_otrosMecanico.Checked = true;

                        }
                        if (inicial.inicial_otrosMec2 == null)
                        {
                            ckb_otrosMecanico2.Checked = false;
                        }
                        else
                        {
                            ckb_otrosMecanico2.Checked = true;

                        }
                        if (inicial.inicial_otrosMec3 == null)
                        {
                            ckb_otrosMecanico3.Checked = false;
                        }
                        else
                        {
                            ckb_otrosMecanico3.Checked = true;

                        }
                        if (inicial.inicial_otrosMec4 == null)
                        {
                            ckb_otrosMecanico4.Checked = false;
                        }
                        else
                        {
                            ckb_otrosMecanico4.Checked = true;

                        }
                        //----------- Quimico -----------
                        if (inicial.inicial_solidosQui == null)
                        {
                            ckb_solidos.Checked = false;
                        }
                        else
                        {
                            ckb_solidos.Checked = true;

                        }
                        if (inicial.inicial_solidosQui2 == null)
                        {
                            ckb_solidos2.Checked = false;
                        }
                        else
                        {
                            ckb_solidos2.Checked = true;

                        }
                        if (inicial.inicial_solidosQui3 == null)
                        {
                            ckb_solidos3.Checked = false;
                        }
                        else
                        {
                            ckb_solidos3.Checked = true;

                        }
                        if (inicial.inicial_solidosQui4 == null)
                        {
                            ckb_solidos4.Checked = false;
                        }
                        else
                        {
                            ckb_solidos4.Checked = true;

                        }
                        if (inicial.inicial_polvosQui == null)
                        {
                            ckb_polvos.Checked = false;
                        }
                        else
                        {
                            ckb_polvos.Checked = true;

                        }
                        if (inicial.inicial_polvosQui2 == null)
                        {
                            ckb_polvos2.Checked = false;
                        }
                        else
                        {
                            ckb_polvos2.Checked = true;

                        }
                        if (inicial.inicial_polvosQui3 == null)
                        {
                            ckb_polvos3.Checked = false;
                        }
                        else
                        {
                            ckb_polvos3.Checked = true;

                        }
                        if (inicial.inicial_polvosQui4 == null)
                        {
                            ckb_polvos4.Checked = false;
                        }
                        else
                        {
                            ckb_polvos4.Checked = true;

                        }
                        if (inicial.inicial_humosQui == null)
                        {
                            ckb_humos.Checked = false;
                        }
                        else
                        {
                            ckb_humos.Checked = true;

                        }
                        if (inicial.inicial_humosQui2 == null)
                        {
                            ckb_humos2.Checked = false;
                        }
                        else
                        {
                            ckb_humos2.Checked = true;

                        }
                        if (inicial.inicial_humosQui3 == null)
                        {
                            ckb_humos3.Checked = false;
                        }
                        else
                        {
                            ckb_humos3.Checked = true;

                        }
                        if (inicial.inicial_humosQui4 == null)
                        {
                            ckb_humos4.Checked = false;
                        }
                        else
                        {
                            ckb_humos4.Checked = true;

                        }
                        if (inicial.inicial_liquidosQui == null)
                        {
                            ckb_liquidos.Checked = false;
                        }
                        else
                        {
                            ckb_liquidos.Checked = true;

                        }
                        if (inicial.inicial_liquidosQui2 == null)
                        {
                            ckb_liquidos2.Checked = false;
                        }
                        else
                        {
                            ckb_liquidos2.Checked = true;

                        }
                        if (inicial.inicial_liquidosQui3 == null)
                        {
                            ckb_liquidos3.Checked = false;
                        }
                        else
                        {
                            ckb_liquidos3.Checked = true;

                        }
                        if (inicial.inicial_liquidosQui4 == null)
                        {
                            ckb_liquidos4.Checked = false;
                        }
                        else
                        {
                            ckb_liquidos4.Checked = true;

                        }
                        if (inicial.inicial_vaporesQui == null)
                        {
                            ckb_vapores.Checked = false;
                        }
                        else
                        {
                            ckb_vapores.Checked = true;

                        }
                        if (inicial.inicial_vaporesQui2 == null)
                        {
                            ckb_vapores2.Checked = false;
                        }
                        else
                        {
                            ckb_vapores2.Checked = true;

                        }
                        if (inicial.inicial_vaporesQui3 == null)
                        {
                            ckb_vapores3.Checked = false;
                        }
                        else
                        {
                            ckb_vapores3.Checked = true;

                        }
                        if (inicial.inicial_vaporesQui4== null)
                        {
                            ckb_vapores4.Checked = false;
                        }
                        else
                        {
                            ckb_vapores4.Checked = true;

                        }
                        if (inicial.inicial_aerosolesQui == null)
                        {
                            ckb_aerosoles.Checked = false;
                        }
                        else
                        {
                            ckb_aerosoles.Checked = true;

                        }
                        if (inicial.inicial_aerosolesQui2 == null)
                        {
                            ckb_aerosoles2.Checked = false;
                        }
                        else
                        {
                            ckb_aerosoles2.Checked = true;

                        }
                        if (inicial.inicial_aerosolesQui3 == null)
                        {
                            ckb_aerosoles3.Checked = false;
                        }
                        else
                        {
                            ckb_aerosoles3.Checked = true;

                        }
                        if (inicial.inicial_aerosolesQui4 == null)
                        {
                            ckb_aerosoles4.Checked = false;
                        }
                        else
                        {
                            ckb_aerosoles4.Checked = true;

                        }
                        if (inicial.inicial_neblinasQui == null)
                        {
                            ckb_neblinas.Checked = false;
                        }
                        else
                        {
                            ckb_neblinas.Checked = true;

                        }
                        if (inicial.inicial_neblinasQui2 == null)
                        {
                            ckb_neblinas2.Checked = false;
                        }
                        else
                        {
                            ckb_neblinas2.Checked = true;

                        }
                        if (inicial.inicial_neblinasQui3 == null)
                        {
                            ckb_neblinas3.Checked = false;
                        }
                        else
                        {
                            ckb_neblinas3.Checked = true;

                        }
                        if (inicial.inicial_neblinasQui4 == null)
                        {
                            ckb_neblinas4.Checked = false;
                        }
                        else
                        {
                            ckb_neblinas4.Checked = true;

                        }
                        if (inicial.inicial_gaseososQui == null)
                        {
                            ckb_gaseosos.Checked = false;
                        }
                        else
                        {
                            ckb_gaseosos.Checked = true;

                        }
                        if (inicial.inicial_gaseososQui2 == null)
                        {
                            ckb_gaseosos2.Checked = false;
                        }
                        else
                        {
                            ckb_gaseosos2.Checked = true;

                        }
                        if (inicial.inicial_gaseososQui3 == null)
                        {
                            ckb_gaseosos3.Checked = false;
                        }
                        else
                        {
                            ckb_gaseosos3.Checked = true;

                        }
                        if (inicial.inicial_gaseososQui4 == null)
                        {
                            ckb_gaseosos4.Checked = false;
                        }
                        else
                        {
                            ckb_gaseosos4.Checked = true;

                        }
                        if (inicial.inicial_otrosQui == null)
                        {
                            ckb_otrosQuimico.Checked = false;
                        }
                        else
                        {
                            ckb_otrosQuimico.Checked = true;

                        }
                        if (inicial.inicial_otrosQui2 == null)
                        {
                            ckb_otrosQuimico2.Checked = false;
                        }
                        else
                        {
                            ckb_otrosQuimico2.Checked = true;

                        }
                        if (inicial.inicial_otrosQui3 == null)
                        {
                            ckb_otrosQuimico3.Checked = false;
                        }
                        else
                        {
                            ckb_otrosQuimico3.Checked = true;

                        }
                        if (inicial.inicial_otrosQui4 == null)
                        {
                            ckb_otrosQuimico4.Checked = false;
                        }
                        else
                        {
                            ckb_otrosQuimico4.Checked = true;

                        }
                        //----------- Biologico -----------
                        if (inicial.inicial_virusBio == null)
                        {
                            ckb_virus.Checked = false;
                        }
                        else
                        {
                            ckb_virus.Checked = true;

                        }
                        if (inicial.inicial_virusBio2 == null)
                        {
                            ckb_virus2.Checked = false;
                        }
                        else
                        {
                            ckb_virus2.Checked = true;

                        }
                        if (inicial.inicial_virusBio3 == null)
                        {
                            ckb_virus3.Checked = false;
                        }
                        else
                        {
                            ckb_virus3.Checked = true;

                        }
                        if (inicial.inicial_virusBio4 == null)
                        {
                            ckb_virus4.Checked = false;
                        }
                        else
                        {
                            ckb_virus4.Checked = true;

                        }
                        if (inicial.inicial_hongosBio == null)
                        {
                            ckb_hongos.Checked = false;
                        }
                        else
                        {
                            ckb_hongos.Checked = true;

                        }
                        if (inicial.inicial_hongosBio2 == null)
                        {
                            ckb_hongos2.Checked = false;
                        }
                        else
                        {
                            ckb_hongos2.Checked = true;

                        }
                        if (inicial.inicial_hongosBio3 == null)
                        {
                            ckb_hongos3.Checked = false;
                        }
                        else
                        {
                            ckb_hongos3.Checked = true;

                        }
                        if (inicial.inicial_hongosBio4 == null)
                        {
                            ckb_hongos4.Checked = false;
                        }
                        else
                        {
                            ckb_hongos4.Checked = true;

                        }
                        if (inicial.inicial_bacteriasBio == null)
                        {
                            ckb_bacterias.Checked = false;
                        }
                        else
                        {
                            ckb_bacterias.Checked = true;

                        }
                        if (inicial.inicial_bacteriasBio2 == null)
                        {
                            ckb_bacterias2.Checked = false;
                        }
                        else
                        {
                            ckb_bacterias2.Checked = true;

                        }
                        if (inicial.inicial_bacteriasBio3 == null)
                        {
                            ckb_bacterias3.Checked = false;
                        }
                        else
                        {
                            ckb_bacterias3.Checked = true;

                        }
                        if (inicial.inicial_bacteriasBio4 == null)
                        {
                            ckb_bacterias4.Checked = false;
                        }
                        else
                        {
                            ckb_bacterias4.Checked = true;

                        }
                        if (inicial.inicial_parasitosBio == null)
                        {
                            ckb_parasitos.Checked = false;
                        }
                        else
                        {
                            ckb_parasitos.Checked = true;

                        }
                        if (inicial.inicial_parasitosBio2 == null)
                        {
                            ckb_parasitos2.Checked = false;
                        }
                        else
                        {
                            ckb_parasitos2.Checked = true;

                        }
                        if (inicial.inicial_parasitosBio3 == null)
                        {
                            ckb_parasitos3.Checked = false;
                        }
                        else
                        {
                            ckb_parasitos3.Checked = true;

                        }
                        if (inicial.inicial_parasitosBio4 == null)
                        {
                            ckb_parasitos4.Checked = false;
                        }
                        else
                        {
                            ckb_parasitos4.Checked = true;

                        }
                        if (inicial.inicial_expVectBio == null)
                        {
                            ckb_expoavectores.Checked = false;
                        }
                        else
                        {
                            ckb_expoavectores.Checked = true;

                        }
                        if (inicial.inicial_expVectBio2 == null)
                        {
                            ckb_expoavectores2.Checked = false;
                        }
                        else
                        {
                            ckb_expoavectores2.Checked = true;

                        }
                        if (inicial.inicial_expVectBio3 == null)
                        {
                            ckb_expoavectores3.Checked = false;
                        }
                        else
                        {
                            ckb_expoavectores3.Checked = true;

                        }
                        if (inicial.inicial_expVectBio4 == null)
                        {
                            ckb_expoavectores4.Checked = false;
                        }
                        else
                        {
                            ckb_expoavectores4.Checked = true;

                        }
                        if (inicial.inicial_expAniSelvaBio == null)
                        {
                            ckb_expoanimselvaticos.Checked = false;
                        }
                        else
                        {
                            ckb_expoanimselvaticos.Checked = true;

                        }
                        if (inicial.inicial_expAniSelvaBio2 == null)
                        {
                            ckb_expoanimselvaticos2.Checked = false;
                        }
                        else
                        {
                            ckb_expoanimselvaticos2.Checked = true;

                        }
                        if (inicial.inicial_expAniSelvaBio3 == null)
                        {
                            ckb_expoanimselvaticos3.Checked = false;
                        }
                        else
                        {
                            ckb_expoanimselvaticos3.Checked = true;

                        }
                        if (inicial.inicial_expAniSelvaBio4 == null)
                        {
                            ckb_expoanimselvaticos4.Checked = false;
                        }
                        else
                        {
                            ckb_expoanimselvaticos4.Checked = true;

                        }
                        if (inicial.inicial_otrosBio == null)
                        {
                            ckb_otrosBiologico.Checked = false;
                        }
                        else
                        {
                            ckb_otrosBiologico.Checked = true;

                        }
                        if (inicial.inicial_otrosBio2 == null)
                        {
                            ckb_otrosBiologico2.Checked = false;
                        }
                        else
                        {
                            ckb_otrosBiologico2.Checked = true;

                        }
                        if (inicial.inicial_otrosBio3 == null)
                        {
                            ckb_otrosBiologico3.Checked = false;
                        }
                        else
                        {
                            ckb_otrosBiologico3.Checked = true;

                        }
                        if (inicial.inicial_otrosBio4 == null)
                        {
                            ckb_otrosBiologico4.Checked = false;
                        }
                        else
                        {
                            ckb_otrosBiologico4.Checked = true;

                        }
                        //----------- Ergonomico -----------
                        if (inicial.inicial_maneManCarErg == null)
                        {
                            ckb_manmanualcargas.Checked = false;
                        }
                        else
                        {
                            ckb_manmanualcargas.Checked = true;

                        }
                        if (inicial.inicial_maneManCarErg2 == null)
                        {
                            ckb_manmanualcargas2.Checked = false;
                        }
                        else
                        {
                            ckb_manmanualcargas2.Checked = true;

                        }
                        if (inicial.inicial_maneManCarErg3 == null)
                        {
                            ckb_manmanualcargas3.Checked = false;
                        }
                        else
                        {
                            ckb_manmanualcargas3.Checked = true;

                        }
                        if (inicial.inicial_maneManCarErg4 == null)
                        {
                            ckb_manmanualcargas4.Checked = false;
                        }
                        else
                        {
                            ckb_manmanualcargas4.Checked = true;

                        }
                        if (inicial.inicial_movRepeErg == null)
                        {
                            ckb_movrepetitivo.Checked = false;
                        }
                        else
                        {
                            ckb_movrepetitivo.Checked = true;

                        }
                        if (inicial.inicial_movRepeErg == null)
                        {
                            ckb_movrepetitivo.Checked = false;
                        }
                        else
                        {
                            ckb_movrepetitivo.Checked = true;

                        }
                        if (inicial.inicial_movRepeErg2 == null)
                        {
                            ckb_movrepetitivo2.Checked = false;
                        }
                        else
                        {
                            ckb_movrepetitivo2.Checked = true;

                        }
                        if (inicial.inicial_posForzaErg3 == null)
                        {
                            ckb_postforzadas3.Checked = false;
                        }
                        else
                        {
                            ckb_postforzadas3.Checked = true;

                        }
                        if (inicial.inicial_posForzaErg4 == null)
                        {
                            ckb_postforzadas4.Checked = false;
                        }
                        else
                        {
                            ckb_postforzadas4.Checked = true;

                        }
                        if (inicial.inicial_trabPvdErg == null)
                        {
                            ckb_trabajopvd.Checked = false;
                        }
                        else
                        {
                            ckb_trabajopvd.Checked = true;

                        }
                        if (inicial.inicial_trabPvdErg2 == null)
                        {
                            ckb_trabajopvd2.Checked = false;
                        }
                        else
                        {
                            ckb_trabajopvd2.Checked = true;

                        }
                        if (inicial.inicial_trabPvdErg3 == null)
                        {
                            ckb_trabajopvd3.Checked = false;
                        }
                        else
                        {
                            ckb_trabajopvd3.Checked = true;

                        }
                        if (inicial.inicial_trabPvdErg4 == null)
                        {
                            ckb_trabajopvd4.Checked = false;
                        }
                        else
                        {
                            ckb_trabajopvd4.Checked = true;

                        }
                        if (inicial.inicial_otrosErg == null)
                        {
                            ckb_otrosErgonomico.Checked = false;
                        }
                        else
                        {
                            ckb_otrosErgonomico.Checked = true;

                        }
                        if (inicial.inicial_otrosErg2 == null)
                        {
                            ckb_otrosErgonomico2.Checked = false;
                        }
                        else
                        {
                            ckb_otrosErgonomico2.Checked = true;

                        }
                        if (inicial.inicial_otrosErg3 == null)
                        {
                            ckb_otrosErgonomico3.Checked = false;
                        }
                        else
                        {
                            ckb_otrosErgonomico3.Checked = true;

                        }
                        if (inicial.inicial_otrosErg4 == null)
                        {
                            ckb_otrosErgonomico4.Checked = false;
                        }
                        else
                        {
                            ckb_otrosErgonomico4.Checked = true;

                        }
                        //----------- Psicosocial -----------
                        if (inicial.inicial_monoTrabPsi == null)
                        {
                            ckb_montrabajo.Checked = false;
                        }
                        else
                        {
                            ckb_montrabajo.Checked = true;

                        }
                        if (inicial.inicial_monoTrabPsi2 == null)
                        {
                            ckb_montrabajo2.Checked = false;
                        }
                        else
                        {
                            ckb_montrabajo2.Checked = true;

                        }
                        if (inicial.inicial_monoTrabPsi3 == null)
                        {
                            ckb_montrabajo3.Checked = false;
                        }
                        else
                        {
                            ckb_montrabajo3.Checked = true;

                        }
                        if (inicial.inicial_monoTrabPsi4 == null)
                        {
                            ckb_montrabajo4.Checked = false;
                        }
                        else
                        {
                            ckb_montrabajo4.Checked = true;

                        }
                        if (inicial.inicial_sobrecarLabPsi == null)
                        {
                            ckb_sobrecargalaboral.Checked = false;
                        }
                        else
                        {
                            ckb_sobrecargalaboral.Checked = true;

                        }
                        if (inicial.inicial_sobrecarLabPsi2 == null)
                        {
                            ckb_sobrecargalaboral2.Checked = false;
                        }
                        else
                        {
                            ckb_sobrecargalaboral2.Checked = true;

                        }
                        if (inicial.inicial_sobrecarLabPsi3 == null)
                        {
                            ckb_sobrecargalaboral3.Checked = false;
                        }
                        else
                        {
                            ckb_sobrecargalaboral3.Checked = true;

                        }
                        if (inicial.inicial_sobrecarLabPsi4 == null)
                        {
                            ckb_sobrecargalaboral4.Checked = false;
                        }
                        else
                        {
                            ckb_sobrecargalaboral4.Checked = true;

                        }
                        if (inicial.inicial_minuTareaPsi == null)
                        {
                            ckb_minustarea.Checked = false;
                        }
                        else
                        {
                            ckb_minustarea.Checked = true;

                        }
                        if (inicial.inicial_minuTareaPsi2 == null)
                        {
                            ckb_minustarea2.Checked = false;
                        }
                        else
                        {
                            ckb_minustarea2.Checked = true;

                        }
                        if (inicial.inicial_minuTareaPsi3 == null)
                        {
                            ckb_minustarea3.Checked = false;
                        }
                        else
                        {
                            ckb_minustarea3.Checked = true;

                        }
                        if (inicial.inicial_minuTareaPsi4 == null)
                        {
                            ckb_minustarea4.Checked = false;
                        }
                        else
                        {
                            ckb_minustarea4.Checked = true;

                        }
                        if (inicial.inicial_altaResponPsi == null)
                        {
                            ckb_altarespon.Checked = false;
                        }
                        else
                        {
                            ckb_altarespon.Checked = true;

                        }
                        if (inicial.inicial_altaResponPsi2 == null)
                        {
                            ckb_altarespon2.Checked = false;
                        }
                        else
                        {
                            ckb_altarespon2.Checked = true;

                        }
                        if (inicial.inicial_altaResponPsi3 == null)
                        {
                            ckb_altarespon3.Checked = false;
                        }
                        else
                        {
                            ckb_altarespon3.Checked = true;

                        }
                        if (inicial.inicial_altaResponPsi4 == null)
                        {
                            ckb_altarespon4.Checked = false;
                        }
                        else
                        {
                            ckb_altarespon4.Checked = true;

                        }
                        if (inicial.inicial_autoTomaDesiPsi == null)
                        {
                            ckb_automadesiciones.Checked = false;
                        }
                        else
                        {
                            ckb_automadesiciones.Checked = true;

                        }
                        if (inicial.inicial_autoTomaDesiPsi2 == null)
                        {
                            ckb_automadesiciones2.Checked = false;
                        }
                        else
                        {
                            ckb_automadesiciones2.Checked = true;

                        }
                        if (inicial.inicial_autoTomaDesiPsi3 == null)
                        {
                            ckb_automadesiciones3.Checked = false;
                        }
                        else
                        {
                            ckb_automadesiciones3.Checked = true;

                        }
                        if (inicial.inicial_autoTomaDesiPsi4 == null)
                        {
                            ckb_automadesiciones4.Checked = false;
                        }
                        else
                        {
                            ckb_automadesiciones4.Checked = true;

                        }
                        if (inicial.inicial_supEstDirecDefiPsi == null)
                        {
                            ckb_supyestdireficiente.Checked = false;
                        }
                        else
                        {
                            ckb_supyestdireficiente.Checked = true;

                        }
                        if (inicial.inicial_supEstDirecDefiPsi2 == null)
                        {
                            ckb_supyestdireficiente2.Checked = false; ;
                        }
                        else
                        {
                            ckb_supyestdireficiente2.Checked = true;

                        }
                        if (inicial.inicial_supEstDirecDefiPsi3 == null)
                        {
                            ckb_supyestdireficiente3.Checked = false;
                        }
                        else
                        {
                            ckb_supyestdireficiente3.Checked = true;

                        }
                        if (inicial.inicial_supEstDirecDefiPsi4 == null)
                        {
                            ckb_supyestdireficiente4.Checked = false;
                        }
                        else
                        {
                            ckb_supyestdireficiente4.Checked = true;

                        }
                        if (inicial.inicial_conflicRolPsi == null)
                        {
                            ckb_conflictorol.Checked = false;
                        }
                        else
                        {
                            ckb_conflictorol.Checked = true;

                        }
                        if (inicial.inicial_conflicRolPsi2 == null)
                        {
                            ckb_conflictorol2.Checked = false;
                        }
                        else
                        {
                            ckb_conflictorol2.Checked = true;

                        }
                        if (inicial.inicial_conflicRolPsi3 == null)
                        {
                            ckb_conflictorol3.Checked = false;
                        }
                        else
                        {
                            ckb_conflictorol3.Checked = true;

                        }
                        if (inicial.inicial_conflicRolPsi4 == null)
                        {
                            ckb_conflictorol4.Checked = false;
                        }
                        else
                        {
                            ckb_conflictorol4.Checked = true;

                        }
                        if (inicial.inicial_falClariFunPsi == null)
                        {
                            ckb_faltaclarfunciones.Checked = false;
                        }
                        else
                        {
                            ckb_faltaclarfunciones.Checked = true;

                        }
                        if (inicial.inicial_falClariFunPsi2 == null)
                        {
                            ckb_faltaclarfunciones2.Checked = false;
                        }
                        else
                        {
                            ckb_faltaclarfunciones2.Checked = true;

                        }
                        if (inicial.inicial_falClariFunPsi3 == null)
                        {
                            ckb_faltaclarfunciones3.Checked = false;
                        }
                        else
                        {
                            ckb_faltaclarfunciones3.Checked = true;

                        }
                        if (inicial.inicial_falClariFunPsi4 == null)
                        {
                            ckb_faltaclarfunciones4.Checked = false;
                        }
                        else
                        {
                            ckb_faltaclarfunciones4.Checked = true;

                        }
                        if (inicial.inicial_incoDistriTrabPsi == null)
                        {
                            ckb_incorrdistrabajo.Checked = false;
                        }
                        else
                        {
                            ckb_incorrdistrabajo.Checked = true;

                        }
                        if (inicial.inicial_incoDistriTrabPsi2 == null)
                        {
                            ckb_incorrdistrabajo2.Checked = false;
                        }
                        else
                        {
                            ckb_incorrdistrabajo2.Checked = true;

                        }
                        if (inicial.inicial_incoDistriTrabPsi3 == null)
                        {
                            ckb_incorrdistrabajo3.Checked = false;
                        }
                        else
                        {
                            ckb_incorrdistrabajo3.Checked = true;

                        }
                        if (inicial.inicial_incoDistriTrabPsi4 == null)
                        {
                            ckb_incorrdistrabajo4.Checked = false;
                        }
                        else
                        {
                            ckb_incorrdistrabajo4.Checked = true;

                        }
                        if (inicial.inicial_turnosRotaPsi == null)
                        {
                            ckb_turnorotat.Checked = false;
                        }
                        else
                        {
                            ckb_turnorotat.Checked = true;

                        }
                        if (inicial.inicial_turnosRotaPsi2 == null)
                        {
                            ckb_turnorotat2.Checked = false;
                        }
                        else
                        {
                            ckb_turnorotat2.Checked = true;

                        }
                        if (inicial.inicial_turnosRotaPsi3 == null)
                        {
                            ckb_turnorotat3.Checked = false;
                        }
                        else
                        {
                            ckb_turnorotat3.Checked = true;

                        }
                        if (inicial.inicial_turnosRotaPsi4 == null)
                        {
                            ckb_turnorotat4.Checked = false;
                        }
                        else
                        {
                            ckb_turnorotat4.Checked = true;

                        }
                        if (inicial.inicial_relInterperPsi == null)
                        {
                            ckb_relacinterpersonales.Checked = false;
                        }
                        else
                        {
                            ckb_relacinterpersonales.Checked = true;

                        }
                        if (inicial.inicial_relInterperPsi2 == null)
                        {
                            ckb_relacinterpersonales2.Checked = false;
                        }
                        else
                        {
                            ckb_relacinterpersonales2.Checked = true;

                        }
                        if (inicial.inicial_relInterperPsi3 == null)
                        {
                            ckb_relacinterpersonales3.Checked = false;
                        }
                        else
                        {
                            ckb_relacinterpersonales3.Checked = true;

                        }
                        if (inicial.inicial_relInterperPsi4 == null)
                        {
                            ckb_relacinterpersonales4.Checked = false;
                        }
                        else
                        {
                            ckb_relacinterpersonales4.Checked = true;

                        }
                        if (inicial.inicial_inesLabPsi == null)
                        {
                            ckb_inestalaboral.Checked = false;
                        }
                        else
                        {
                            ckb_inestalaboral.Checked = true;

                        }
                        if (inicial.inicial_inesLabPsi2 == null)
                        {
                            ckb_inestalaboral2.Checked = false;
                        }
                        else
                        {
                            ckb_inestalaboral2.Checked = true;

                        }
                        if (inicial.inicial_inesLabPsi3 == null)
                        {
                            ckb_inestalaboral3.Checked = false;
                        }
                        else
                        {
                            ckb_inestalaboral3.Checked = true;

                        }
                        if (inicial.inicial_inesLabPsi4 == null)
                        {
                            ckb_inestalaboral4.Checked = false;
                        }
                        else
                        {
                            ckb_inestalaboral4.Checked = true;

                        }
                        if (inicial.inicial_otrosPsi == null)
                        {
                            ckb_otrosPsicosocial.Checked = false;
                        }
                        else
                        {
                            ckb_otrosPsicosocial.Checked = true;

                        }
                        if (inicial.inicial_otrosPsi2 == null)
                        {
                            ckb_otrosPsicosocial2.Checked = false;
                        }
                        else
                        {
                            ckb_otrosPsicosocial2.Checked = true;

                        }
                        if (inicial.inicial_otrosPsi3 == null)
                        {
                            ckb_otrosPsicosocial3.Checked = false;
                        }
                        else
                        {
                            ckb_otrosPsicosocial3.Checked = true;

                        }
                        if (inicial.inicial_otrosPsi4 == null)
                        {
                            ckb_otrosPsicosocial4.Checked = false;
                        }
                        else
                        {
                            ckb_otrosPsicosocial4.Checked = true;

                        }

                        //Revision de Organos y Sistemas
                        if (inicial.inicial_pielAnexos == null)
                        {
                            ckb_pielanexos.Checked = false;
                        }
                        else
                        {
                            ckb_pielanexos.Checked = true;

                        }
                        if (inicial.inicial_orgSentidos == null)
                        {
                            ckb_organossentidos.Checked = false;
                        }
                        else
                        {
                            ckb_organossentidos.Checked = true;

                        }
                        if (inicial.inicial_respiratorio == null)
                        {
                            ckb_respiratorio.Checked = false;
                        }
                        else
                        {
                            ckb_respiratorio.Checked = true;

                        }
                        if (inicial.inicial_cardVascular == null)
                        {
                            ckb_cardiovascular.Checked = false;
                        }
                        else
                        {
                            ckb_cardiovascular.Checked = true;

                        }
                        if (inicial.inicial_digestivo == null)
                        {
                            ckb_digestivo.Checked = false;
                        }
                        else
                        {
                            ckb_digestivo.Checked = true;

                        }
                        if (inicial.inicial_genUrinario == null)
                        {
                            ckb_genitourinario.Checked = false;
                        }
                        else
                        {
                            ckb_genitourinario.Checked = true;

                        }
                        if (inicial.inicial_muscEsqueletico == null)
                        {
                            ckb_musculosesqueleticos.Checked = false;
                        }
                        else
                        {
                            ckb_musculosesqueleticos.Checked = true;

                        }
                        if (inicial.inicial_endocrino == null)
                        {
                            ckb_endocrino.Checked = false;
                        }
                        else
                        {
                            ckb_endocrino.Checked = true;

                        }
                        if (inicial.inicial_hemoLimfa == null)
                        {
                            ckb_hemolinfatico.Checked = false;
                        }
                        else
                        {
                            ckb_hemolinfatico.Checked = true;

                        }
                        if (inicial.inicial_nervioso == null)
                        {
                            ckb_nervioso.Checked = false;
                        }
                        else
                        {
                            ckb_nervioso.Checked = true;

                        }

                        //Regiones
                        if (inicial.inicial_cicatricesPiel == null)
                        {
                            ckb_cicatrices.Checked = false;
                        }
                        else
                        {
                            ckb_cicatrices.Checked = true;

                        }
                        if (inicial.inicial_tatuajesPiel == null)
                        {
                            ckb_tatuajes.Checked = false;
                        }
                        else
                        {
                            ckb_tatuajes.Checked = true;

                        }
                        if (inicial.inicial_pielFacerasPiel == null)
                        {
                            ckb_pielyfaneras.Checked = false;
                        }
                        else
                        {
                            ckb_pielyfaneras.Checked = true;

                        }
                        if (inicial.inicial_parpadosOjos == null)
                        {
                            ckb_parpados.Checked = false;
                        }
                        else
                        {
                            ckb_parpados.Checked = true;

                        }
                        if (inicial.inicial_conjuntuvasOjos == null)
                        {
                            ckb_conjuntivas.Checked = false;
                        }
                        else
                        {
                            ckb_conjuntivas.Checked = true;

                        }
                        if (inicial.inicial_pupilasOjos == null)
                        {
                            ckb_pupilas.Checked = false;
                        }
                        else
                        {
                            ckb_pupilas.Checked = true;

                        }
                        if (inicial.inicial_corneaOjos == null)
                        {
                            ckb_cornea.Checked = false;
                        }
                        else
                        {
                            ckb_cornea.Checked = true;

                        }
                        if (inicial.inicial_motilidadOjos == null)
                        {
                            ckb_motilidad.Checked = false;
                        }
                        else
                        {
                            ckb_motilidad.Checked = true;

                        }
                        if (inicial.inicial_cAudiExtreOido == null)
                        {
                            ckb_auditivoexterno.Checked = false;
                        }
                        else
                        {
                            ckb_auditivoexterno.Checked = true;

                        }
                        if (inicial.inicial_pabellonOido == null)
                        {
                            ckb_pabellon.Checked = false;
                        }
                        else
                        {
                            ckb_pabellon.Checked = true;

                        }
                        if (inicial.inicial_timpanosOido == null)
                        {
                            ckb_timpanos.Checked = false;
                        }
                        else
                        {
                            ckb_timpanos.Checked = true;

                        }
                        if (inicial.inicial_labiosOroFa == null)
                        {
                            ckb_labios.Checked = false;
                        }
                        else
                        {
                            ckb_labios.Checked = true;

                        }
                        if (inicial.inicial_lenguaOroFa == null)
                        {
                            ckb_lengua.Checked = false;
                        }
                        else
                        {
                            ckb_lengua.Checked = true;

                        }
                        if (inicial.inicial_faringeOroFa == null)
                        {
                            ckb_faringe.Checked = false;
                        }
                        else
                        {
                            ckb_faringe.Checked = true;

                        }
                        if (inicial.inicial_amigdalasOroFa == null)
                        {
                            ckb_amigdalas.Checked = false;
                        }
                        else
                        {
                            ckb_amigdalas.Checked = true;

                        }
                        if (inicial.inicial_dentaduraOroFa == null)
                        {
                            ckb_dentadura.Checked = false;
                        }
                        else
                        {
                            ckb_dentadura.Checked = true;

                        }
                        if (inicial.inicial_tabiqueNariz == null)
                        {
                            ckb_tabique.Checked = false;
                        }
                        else
                        {
                            ckb_tabique.Checked = true;

                        }
                        if (inicial.inicial_cornetesNariz == null)
                        {
                            ckb_cornetes.Checked = false;
                        }
                        else
                        {
                            ckb_cornetes.Checked = true;

                        }
                        if (inicial.inicial_mucosasNariz == null)
                        {
                            ckb_mucosa.Checked = false;
                        }
                        else
                        {
                            ckb_mucosa.Checked = true;

                        }
                        if (inicial.inicial_senosParanaNariz == null)
                        {
                            ckb_senosparanasales.Checked = false;
                        }
                        else
                        {
                            ckb_senosparanasales.Checked = true;

                        }
                        if (inicial.inicial_tiroiMasasCuello == null)
                        {
                            ckb_tiroides.Checked = false;
                        }
                        else
                        {
                            ckb_tiroides.Checked = true;

                        }
                        if (inicial.inicial_movilidadCuello == null)
                        {
                            ckb_movilidad.Checked = false;
                        }
                        else
                        {
                            ckb_movilidad.Checked = true;

                        }
                        if (inicial.inicial_mamasTorax == null)
                        {
                            ckb_mamas.Checked = false;
                        }
                        else
                        {
                            ckb_mamas.Checked = true;

                        }
                        if (inicial.inicial_corazonTorax == null)
                        {
                            ckb_corazon.Checked = false;
                        }
                        else
                        {
                            ckb_corazon.Checked = true;

                        }
                        if (inicial.inicial_pulmonesTorax2 == null)
                        {
                            ckb_pulmones.Checked = false;
                        }
                        else
                        {
                            ckb_pulmones.Checked = true;

                        }
                        if (inicial.inicial_parriCostalTorax2 == null)
                        {
                            ckb_parrillacostal.Checked = false;
                        }
                        else
                        {
                            ckb_parrillacostal.Checked = true;

                        }
                        if (inicial.inicial_viscerasAbdomen == null)
                        {
                            ckb_visceras.Checked = false;
                        }
                        else
                        {
                            ckb_visceras.Checked = true;

                        }
                        if (inicial.inicial_paredAbdomiAbdomen == null)
                        {
                            ckb_paredabdominal.Checked = false;
                        }
                        else
                        {
                            ckb_paredabdominal.Checked = true;

                        }
                        if (inicial.inicial_flexibilidadColumna == null)
                        {
                            ckb_flexibilidad.Checked = false;
                        }
                        else
                        {
                            ckb_flexibilidad.Checked = true;

                        }
                        if (inicial.inicial_desviacionColumna == null)
                        {
                            ckb_desviacion.Checked = false;
                        }
                        else
                        {
                            ckb_desviacion.Checked = true;

                        }
                        if (inicial.inicial_dolorColumna == null)
                        {
                            ckb_dolor.Checked = false;
                        }
                        else
                        {
                            ckb_dolor.Checked = true;

                        }
                        if (inicial.inicial_pelvisPelvis == null)
                        {
                            ckb_pelvis.Checked = false;
                        }
                        else
                        {
                            ckb_pelvis.Checked = true;

                        }
                        if (inicial.inicial_genitalesPelvis == null)
                        {
                            ckb_genitales.Checked = false;
                        }
                        else
                        {
                            ckb_genitales.Checked = true;

                        }
                        if (inicial.inicial_vascularExtre == null)
                        {
                            ckb_vascular.Checked = false;
                        }
                        else
                        {
                            ckb_vascular.Checked = true;

                        }
                        if (inicial.inicial_miemSupeExtre == null)
                        {
                            ckb_miembrosuperiores.Checked = false;
                        }
                        else
                        {
                            ckb_miembrosuperiores.Checked = true;

                        }
                        if (inicial.inicial_miemInfeExtre == null)
                        {
                            ckb_miembrosinferiores.Checked = false;
                        }
                        else
                        {
                            ckb_miembrosinferiores.Checked = true;

                        }
                        if (inicial.inicial_fuerzaNeuro == null)
                        {
                            ckb_fuerza.Checked = false;
                        }
                        else
                        {
                            ckb_fuerza.Checked = true;

                        }
                        if (inicial.inicial_sensibiNeuro == null)
                        {
                            ckb_sensibilidad.Checked = false;
                        }
                        else
                        {
                            ckb_sensibilidad.Checked = true;

                        }
                        if (inicial.inicial_marchaNeuro == null)
                        {
                            ckb_marcha.Checked = false;
                        }
                        else
                        {
                            ckb_marcha.Checked = true;

                        }
                        if (inicial.inicial_refleNeuro == null)
                        {
                            ckb_reflejos.Checked = false;
                        }
                        else
                        {
                            ckb_reflejos.Checked = true;

                        }

                        //Diagnostco
                        if (inicial.inicial_pre == null)
                        {
                            ckb_pre.Checked = false;
                        }
                        else
                        {
                            ckb_pre.Checked = true;

                        }
                        if (inicial.inicial_pre2 == null)
                        {
                            ckb_pre2.Checked = false;
                        }
                        else
                        {
                            ckb_pre2.Checked = true;

                        }
                        if (inicial.inicial_pre3 == null)
                        {
                            ckb_pre3.Checked = false;
                        }
                        else
                        {
                            ckb_pre3.Checked = true;

                        }
                        if (inicial.inicial_def == null)
                        {
                            ckb_def.Checked = false;
                        }
                        else
                        {
                            ckb_def.Checked = true;

                        }
                        if (inicial.inicial_def2 == null)
                        {
                            ckb_def2.Checked = false;
                        }
                        else
                        {
                            ckb_def2.Checked = true;

                        }
                        if (inicial.inicial_def3 == null)
                        {
                            ckb_def3.Checked = false;
                        }
                        else
                        {
                            ckb_def3.Checked = true;

                        }

                        //Aptitud Medica para el trabajo
                        if (inicial.inicial_apto == null)
                        {
                            ckb_apto.Checked = false;
                        }
                        else
                        {
                            ckb_apto.Checked = true;

                        }
                        if (inicial.inicial_aptoObserva == null)
                        {
                            ckb_aptoobservacion.Checked = false;
                        }
                        else
                        {
                            ckb_aptoobservacion.Checked = true;

                        }
                        if (inicial.inicial_aptoLimi == null)
                        {
                            ckb_aptolimitacion.Checked = false;
                        }
                        else
                        {
                            ckb_aptolimitacion.Checked = true;

                        }
                        if (inicial.inicial_NoApto == null)
                        {
                            ckb_noapto.Checked = false;
                        }
                        else
                        {
                            ckb_noapto.Checked = true;

                        }

                        txt_numHClinica.Text = per.Per_cedula.ToString();
                        txt_priNombre.Text = per.Per_priNombre.ToString();
                        txt_segNombre.Text = per.Per_segNombre.ToString();
                        txt_priApellido.Text = per.Per_priApellido.ToString();
                        txt_segApellido.Text = per.Per_segApellido.ToString();
                        txt_sexo.Text = per.Per_genero.ToString();
                        DateTime edad = Convert.ToDateTime(per.Per_fechaNacimiento);
                        DateTime naci = Convert.ToDateTime(edad);
                        DateTime actual = DateTime.Now;
                        Calculo(naci, actual);                        
                        txt_fechaingresotrabajo.Text = Convert.ToDateTime(per.Per_fechInicioTrabajo).ToString("yyyy-MM-dd");
                        txt_puestodetrabajociuo.Text = per.Per_puestoTrabajo.ToString();
                        txt_areadetrabajo.Text = per.Per_areaTrabajo.ToString();

                        if (inicial != null)
                        {
                            //A
                            txt_numArchivo.Text = inicial.inicial_numArchivo.ToString();
                            txt_gruposanguineo.Text = inicial.inicial_groSanguineo.ToString();
                            txt_lateralidad.Text = inicial.inicial_lateralidad.ToString();
                            txt_tipodiscapacidad.Text = inicial.inicial_tipoDis.ToString();
                            txt_porcentajediscapacidad.Text = inicial.inicial_porcentDis.ToString();
                            txt_actividadesrelevantes.Text = inicial.inicial_actRelePuesTrabajo.ToString();

                            //B
                            txt_motivoconsultainicial.Text = inicial.inicial_descripcionMotivoConsulta.ToString();

                            //C
                            txt_antCliQuiDescripcion.Text = inicial.inicial_descripcionAnteceCliniQuirur.ToString();
                            txt_menarquiaAntGinObste.Text = inicial.inicial_menarquia.ToString();
                            txt_ciclosAntGinObste.Text = inicial.inicial_ciclos.ToString();

                            if (inicial.inicial_fechUltiMenstrua == "")
                            {
                                txt_fechUltiMensAntGinObste.Text = inicial.inicial_fechUltiMenstrua.ToString();
                            }
                            else
                            {
                                txt_fechUltiMensAntGinObste.Text = Convert.ToDateTime(inicial.inicial_fechUltiMenstrua).ToString("yyyy-MM-dd");
                            }
                                                       
                            txt_gestasAntGinObste.Text = inicial.inicial_gestas.ToString();
                            txt_partosAntGinObste.Text = inicial.inicial_partos.ToString();
                            txt_cesareasAntGinObste.Text = inicial.inicial_cesareas.ToString();
                            txt_abortosAntGinObste.Text = inicial.inicial_abortos.ToString();
                            txt_vivosAntGinObste.Text = inicial.inicial_vivosHij.ToString();
                            txt_muertosAntGinObste.Text = inicial.inicial_muertosHij.ToString();
                            txt_tipoMetPlaniAntGinObste.Text = inicial.inicial_tipoMetPlanifiFamiliar.ToString();

                            txt_tiempoPapaniAntGinObste.Text = inicial.inicial_tiempoExaRealiPapanicolaou.ToString();
                            txt_resultadoPapaniAntGinObste.Text = inicial.inicial_resultadoExaRealiPapanicolaou.ToString();
                            txt_tiempoEcoMamaAntGinObste.Text = inicial.inicial_tiempoExaRealiEcoMamario.ToString();
                            txt_resultadoEcoMamaAntGinObste.Text = inicial.inicial_resultadoExaRealiEcoMamario.ToString();
                            txt_tiempoColposAntGinObste.Text = inicial.inicial_tiempoExaRealiColposcopia.ToString();
                            txt_resultadoColposAntGinObste.Text = inicial.inicial_resultadoExaRealiColposcopia.ToString();
                            txt_tiempoMamograAntGinObste.Text = inicial.inicial_tiempoExaRealiMamografia.ToString();
                            txt_resultadoMamograAntGinObste.Text = inicial.inicial_resultadoExaRealiMamografia.ToString();

                            txt_tiempoExaRealiAntProstaAntReproMascu.Text = inicial.inicial_tiempoExaRealiAntiProstatico.ToString();
                            txt_resultadoExaRealiAntProstaAntReproMascu.Text = inicial.inicial_resultadoExaRealiAntiProstatico.ToString();
                            txt_tipo1MetPlaniAntReproMascu.Text = inicial.inicial_tipo1MetPlanifiFamiAntReproMascu.ToString();
                            txt_vivosHijosAntReproMascu.Text = inicial.inicial_vivosHijAntReproMascu.ToString();
                            txt_muertosHijosAntReproMascu.Text = inicial.inicial_muertosHijAntReproMascu.ToString();
                            txt_tiempoExaRealiEcoProstaAntReproMascu.Text = inicial.inicial_tiempoExaRealiEcoProstatico.ToString();
                            txt_resultadoExaRealiEcoProstaAntReproMascu.Text = inicial.inicial_resultadoExaRealiEcoProstatico.ToString();
                            txt_tipo2MetPlaniAntReproMascu.Text = inicial.inicial_tipo2MetPlanifiFamiAntReproMascu.ToString();

                            txt_tiemConConsuNociTabaHabToxi.Text = inicial.inicial_tiempoConsuConsuNocivosTabaco.ToString();
                            txt_cantiConsuNociTabaHabToxi.Text = inicial.inicial_cantidadConsuNocivosTabaco.ToString();
                            txt_exConsumiConsuNociTabaHabToxi.Text = inicial.inicial_exConsumiConsuNocivosTabaco.ToString();
                            txt_tiemAbstiConsuNociTabaHabToxi.Text = inicial.inicial_tiempoAbstiConsuNocivosTabaco.ToString();
                            txt_tiemConConsuNociAlcoHabToxi.Text = inicial.inicial_tiempoConsuConsuNocivosAlcohol.ToString();
                            txt_cantiConsuNociAlcoHabToxi.Text = inicial.inicial_cantidadConsuNocivosAlcohol.ToString();
                            txt_exConsumiConsuNociAlcoHabToxi.Text = inicial.inicial_exConsumiConsuNocivosAlcohol.ToString();
                            txt_tiemAbstiConsuNociAlcoHabToxi.Text = inicial.inicial_tiempoAbstiConsuNocivosAlcohol.ToString();
                            txt_tiemCon1ConsuNociOtrasDroHabToxi.Text = inicial.inicial_tiempoConsu1ConsuNocivosOtrasDrogas.ToString();
                            txt_canti1ConsuNociOtrasDroHabToxi.Text = inicial.inicial_cantidad1ConsuNocivosOtrasDrogas.ToString();
                            txt_exConsumi1ConsuNociOtrasDroHabToxi.Text = inicial.inicial_exConsumi1ConsuNocivosOtrasDrogas.ToString();
                            txt_tiemAbsti1ConsuNociOtrasDroHabToxi.Text = inicial.inicial_tiempoAbsti1ConsuNocivosOtrasDrogas.ToString();
                            txt_otrasConsuNociOtrasDroHabToxi.Text = inicial.inicial_otrasConsuNocivos.ToString();
                            txt_tiemCon2ConsuNociOtrasDroHabToxi.Text = inicial.inicial_tiempoConsu2ConsuNocivosOtrasDrogas.ToString();
                            txt_canti2ConsuNociOtrasDroHabToxi.Text = inicial.inicial_cantidad2ConsuNocivosOtrasDrogas.ToString();
                            txt_exConsumi2ConsuNociOtrasDroHabToxi.Text = inicial.inicial_exConsumi2ConsuNocivosOtrasDrogas.ToString();
                            txt_tiemAbsti2ConsuNociOtrasDroHabToxi.Text = inicial.inicial_tiempoAbsti2ConsuNocivosOtrasDrogas.ToString();

                            txt_cualEstVidaActFisiEstVida.Text = inicial.inicial_cualEstiVidaActFisica.ToString();
                            txt_tiemCanEstVidaActFisiEstVida.Text = inicial.inicial_tiem_cantEstiVidaActFisica.ToString();
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
                            txt_obseantempleanteriores.Text = inicial.inicial_observacionesAnteEmpleAnteriores.ToString();
                            txt_empresa2.Text = inicial.inicial_nomEmpresa2.ToString();
                            txt_puestotrabajo2.Text = inicial.inicial_puestoTrabajo2.ToString();
                            txt_actdesempeña2.Text = inicial.inicial_actDesemp2.ToString();
                            txt_tiempotrabajo2.Text = inicial.inicial_tiemTrabajo2.ToString();
                            txt_obseantempleanteriores2.Text = inicial.inicial_observacionesAnteEmpleAnteriores2.ToString();
                            txt_empresa3.Text = inicial.inicial_nomEmpresa3.ToString();
                            txt_puestotrabajo3.Text = inicial.inicial_puestoTrabajo3.ToString();
                            txt_actdesempeña3.Text = inicial.inicial_actDesemp3.ToString();
                            txt_tiempotrabajo3.Text = inicial.inicial_tiemTrabajo3.ToString();
                            txt_obseantempleanteriores3.Text = inicial.inicial_observacionesAnteEmpleAnteriores3.ToString();
                            txt_empresa4.Text = inicial.inicial_nomEmpresa4.ToString();
                            txt_puestotrabajo4.Text = inicial.inicial_puestoTrabajo4.ToString();
                            txt_actdesempeña4.Text = inicial.inicial_actDesemp4.ToString();
                            txt_tiempotrabajo4.Text = inicial.inicial_tiemTrabajo4.ToString();
                            txt_obseantempleanteriores4.Text = inicial.inicial_observacionesAnteEmpleAnteriores4.ToString();

                            txt_especificar.Text = inicial.inicial_especificarCalificadoIESSAcciTrabajo.ToString();
                            if (inicial.inicial_fechaCalificadoIESSAcciTrabajo == "")
                            {
                                txt_fecha.Text = inicial.inicial_fechaCalificadoIESSAcciTrabajo.ToString();
                            }
                            else
                            {
                                txt_fecha.Text = Convert.ToDateTime(inicial.inicial_fechaCalificadoIESSAcciTrabajo).ToString("yyyy-MM-dd");
                            }
                            txt_observaciones2.Text = inicial.inicial_obserAcciTrabajo.ToString();

                            txt_espeprofesional.Text = inicial.inicial_especificarCalificadoIESSEnfProfesionales.ToString();
                            if (inicial.inicial_fechaCalificadoIESSEnfProfesionales == "")
                            {
                                txt_fechaprofesional.Text = inicial.inicial_fechaCalificadoIESSEnfProfesionales.ToString();
                            }
                            else
                            {
                                txt_fechaprofesional.Text = Convert.ToDateTime(inicial.inicial_fechaCalificadoIESSEnfProfesionales).ToString("yyyy-MM-dd");
                            }
                            txt_observaciones3.Text = inicial.inicial_obserEnfProfesionales.ToString();

                            //E
                            txt_descripcionantefamiliares.Text = inicial.inicial_descripcionAnteFamiliares.ToString();

                            //F
                            txt_puestodetrabajo.Text = inicial.inicial_area.ToString();
                            txt_act.Text = inicial.inicial_actividades.ToString();
                            txt_puestodetrabajo2.Text = inicial.inicial_area2.ToString();
                            txt_act2.Text = inicial.inicial_actividades2.ToString();
                            txt_puestodetrabajo3.Text = inicial.inicial_area3.ToString();
                            txt_act3.Text = inicial.inicial_actividades3.ToString();
                            txt_puestodetrabajo4.Text = inicial.inicial_area4.ToString();   
                            txt_act4.Text = inicial.inicial_actividades4.ToString();
                            
                            txt_medpreventivas.Text = inicial.inicial_medPreventivas.ToString();
                            txt_medpreventivas2.Text = inicial.inicial_medPreventivas.ToString();
                            txt_medpreventivas3.Text = inicial.inicial_medPreventivas.ToString();
                            txt_medpreventivas4.Text = inicial.inicial_medPreventivas.ToString();

                            //G
                            txt_descrextralaborales.Text = inicial.inicial_descripActExtLab.ToString();

                            //H
                            txt_enfermedadactualinicial.Text = inicial.inicial_descripEnfActual.ToString();

                            //I
                            txt_descrorganosysistemas.Text = inicial.inicial_descripRevActOrgSis.ToString();

                            //J
                            txt_preArterial.Text = inicial.inicial_preArterial.ToString();
                            txt_temperatura.Text = inicial.inicial_temperatura.ToString();
                            txt_freCardica.Text = inicial.inicial_frecCardiacan.ToString();
                            txt_satOxigeno.Text = inicial.inicial_satOxigenon.ToString();
                            txt_freRespiratoria.Text = inicial.inicial_frecRespiratorian.ToString();
                            txt_peso.Text = inicial.inicial_peson.ToString();
                            txt_talla.Text = inicial.inicial_tallan.ToString();
                            txt_indMasCorporal.Text = inicial.inicial_indMasCorporaln.ToString();
                            txt_perAbdominal.Text = inicial.inicial_perAbdominaln.ToString();

                            //K                            
                            txt_obervexamenfisicoregional.Text = inicial.inicial_observaExaFisRegInicial.ToString();

                            //L
                            txt_examen.Text = inicial.inicial_examen.ToString();
                            if (inicial.inicial_fecha == "")
                            {
                                txt_fechaexamen.Text = inicial.inicial_fecha.ToString();
                            }
                            else
                            {
                                txt_fechaexamen.Text = Convert.ToDateTime(inicial.inicial_fecha).ToString("yyyy-MM-dd");
                            }
                            txt_resultadoexamen.Text = inicial.inicial_resultados.ToString();

                            txt_examen2.Text = inicial.inicial_examen2.ToString();
                            if (inicial.inicial_fecha2 == "")
                            {
                                txt_fechaexamen2.Text = inicial.inicial_fecha2.ToString();
                            }
                            else
                            {
                                txt_fechaexamen2.Text = Convert.ToDateTime(inicial.inicial_fecha2).ToString("yyyy-MM-dd");
                            }
                            txt_resultadoexamen2.Text = inicial.inicial_resultados2.ToString();

                            txt_examen3.Text = inicial.inicial_examen3.ToString();
                            if (inicial.inicial_fecha3 == "")
                            {
                                txt_fechaexamen3.Text = inicial.inicial_fecha3.ToString();
                            }
                            else
                            {
                                txt_fechaexamen3.Text = Convert.ToDateTime(inicial.inicial_fecha3).ToString("yyyy-MM-dd");
                            }
                            txt_resultadoexamen3.Text = inicial.inicial_resultados3.ToString();

                            txt_examen4.Text = inicial.inicial_examen4.ToString();

                            if (inicial.inicial_fecha4 == "")
                            {
                                txt_fechaexamen4.Text = inicial.inicial_fecha4.ToString();
                            }
                            else
                            {
                                txt_fechaexamen4.Text = Convert.ToDateTime(inicial.inicial_fecha4).ToString("yyyy-MM-dd");
                            }
                            txt_resultadoexamen4.Text = inicial.inicial_resultados4.ToString();

                            txt_observacionexamen.Text = inicial.inicial_observacionesResExaGenEspRiesTrabajo.ToString();

                            //M
                            txt_descripdiagnostico.Text = inicial.inicial_descripciondiagnostico.ToString();
                            txt_cie.Text = inicial.inicial_cie.ToString();
                            txt_descripdiagnostico2.Text = inicial.inicial_descripcioninicialnostico2.ToString();
                            txt_cie2.Text = inicial.inicial_cie2.ToString();
                            txt_descripdiagnostico3.Text = inicial.inicial_descripcioninicialnostico3.ToString();
                            txt_cie3.Text = inicial.inicial_cie3.ToString();

                            //N
                            txt_observacionaptitud.Text = inicial.inicial_ObservAptMed.ToString();
                            txt_limitacionaptitud.Text = inicial.inicial_LimitAptMed.ToString();

                            //O
                            txt_descripciontratamiento.Text = inicial.inicial_descripcionRecTra.ToString();

                            //P
                            if (inicial.inicial_fecha_hora == "")
                            {
                                txt_fechahora.Text = inicial.inicial_fecha_hora.ToString();
                            }
                            else
                            {
                                txt_fechahora.Text = Convert.ToDateTime(inicial.inicial_fecha_hora).ToString("yyyy-MM-ddTHH:mm");
                            }
                            ddl_profesional.SelectedValue = inicial.prof_id.ToString();
                            txt_codigoDatProf.Text = inicial.inicial_cod.ToString();
                        }
                    }
                }

                if (inicial.inicial_fecha_hora == null)
                {
                    txt_fechahora.Text = DateTime.Now.ToLocalTime().ToString("yyyy-MM-ddTHH:mm");
                }
                
                cargarProfesional();
            }
		}

        public void Calculo(DateTime nac, DateTime actual)
        {
            int año = nac.Year;
            int mes = nac.Month;
            int dia = nac.Day;

            int añoBisiesto = 0;

            for (int i = año; i < actual.Year; i++)
            {
                if (DateTime.IsLeapYear(i))
                {
                    ++añoBisiesto;
                }
            }

            TimeSpan ts = actual.Subtract(nac);
            dia = ts.Days - añoBisiesto;
            int r = 0;

            año = Math.DivRem(dia, 365, out r);
            mes = Math.DivRem(r, 30, out r);
            dia = r;

            txt_edad.Text = año + "A, " + mes + "M, " + dia + "D";
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

                DateTime edad = Convert.ToDateTime(item.Per_fechaNacimiento);
                DateTime naci = Convert.ToDateTime(edad);

                DateTime actual = DateTime.Now;
                Calculo(naci, actual);

                DateTime fechaIngresoTrabajo = Convert.ToDateTime(item.Per_fechInicioTrabajo);
                txt_fechaingresotrabajo.Text = Convert.ToDateTime(fechaIngresoTrabajo).ToString("yyyy-MM-dd");

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

        protected void txt_descripdiagnostico2_TextChanged(object sender, EventArgs e)
        {
            ObtenerCodigo2();
        }

        protected void txt_descripdiagnostico3_TextChanged(object sender, EventArgs e)
        {
            ObtenerCodigo3();
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
        private void ObtenerCodigo2()
        {
            string descripcion2 = txt_descripdiagnostico2.Text;


            var lista = from c in dc.cie10
                        where c.dec10 == descripcion2
                        select c;

            foreach (var item in lista)
            {
                string codigo2 = item.id10;
                txt_cie2.Text = codigo2;
            }
        }
        private void ObtenerCodigo3()
        {
            string descripcion3 = txt_descripdiagnostico3.Text;

            var lista = from c in dc.cie10
                        where c.dec10 == descripcion3
                        select c;

            foreach (var item in lista)
            {
                string codigo3 = item.id10;
                txt_cie3.Text = codigo3;
            }
        }

        private void GuardarHistorial()
        {
            try
            {
                per = CN_HistorialMedico.ObtenerIdPersonasxCedula(Convert.ToInt32(txt_numHClinica.Text));

                int perso = Convert.ToInt32(per.Per_id.ToString());

                inicial = new Tbl_Inicial();

                //A
                inicial.inicial_numArchivo = txt_numArchivo.Text;

                if (ckb_catolica.Checked == true)
                {
                    inicial.inicial_catolicaRel = "SI";
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

                //-----------------------------------

                inicial.inicial_groSanguineo = txt_gruposanguineo.Text;

                inicial.inicial_lateralidad = txt_lateralidad.Text;

                //-----------------------------------

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

                //-----------------------------------

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

                //-----------------------------------

                if (cbk_sidiscapacidad.Checked == true)
                {
                    inicial.inicial_siDis = "Si";
                }
                if (cbk_nodiscapacidad.Checked == true)
                {
                    inicial.inicial_noDis = "Si";
                }
                inicial.inicial_tipoDis = txt_tipodiscapacidad.Text;
                inicial.inicial_porcentDis = txt_porcentajediscapacidad.Text;

                //-----------------------------------

                inicial.inicial_actRelePuesTrabajo = txt_actividadesrelevantes.Text;

                //B
                inicial.inicial_descripcionMotivoConsulta = txt_motivoconsultainicial.Text;

                //C
                inicial.inicial_descripcionAnteceCliniQuirur = txt_antCliQuiDescripcion.Text;

                //-----------------------------------

                inicial.inicial_menarquia = txt_menarquiaAntGinObste.Text;
                inicial.inicial_ciclos = txt_ciclosAntGinObste.Text;
                inicial.inicial_fechUltiMenstrua = txt_fechUltiMensAntGinObste.Text;
                inicial.inicial_gestas = txt_gestasAntGinObste.Text;
                inicial.inicial_partos = txt_partosAntGinObste.Text;
                inicial.inicial_cesareas = txt_cesareasAntGinObste.Text;
                inicial.inicial_abortos = txt_abortosAntGinObste.Text;
                inicial.inicial_vivosHij = txt_vivosAntGinObste.Text;
                inicial.inicial_muertosHij = txt_muertosAntGinObste.Text;

                if (ckb_siVidSexAntGinObste.Checked == true)
                {
                    inicial.inicial_siVidaSexActiva = "Si";
                }
                if (ckb_noVidSexAntGinObste.Checked == true)
                {
                    inicial.inicial_noVidaSexActiva = "Si";
                }
                if (ckb_siMetPlaniAntGinObste.Checked == true)
                {
                    inicial.inicial_siMetPlanifiFamiliar = "Si";
                }
                if (ckb_noMetPlaniAntGinObste.Checked == true)
                {
                    inicial.inicial_noMetPlanifiFamiliar = "Si";
                }
                inicial.inicial_tipoMetPlanifiFamiliar = txt_tipoMetPlaniAntGinObste.Text;

                //-----------------------------------

                if (ckb_siPapaniAntGinObste.Checked == true)
                {
                    inicial.inicial_siExaRealiPapanicolaou = "Si";
                }
                if (ckb_noPapaniAntGinObste.Checked == true)
                {
                    inicial.inicial_noExaRealiPapanicolaou = "Si";
                }
                inicial.inicial_tiempoExaRealiPapanicolaou = txt_tiempoPapaniAntGinObste.Text;
                inicial.inicial_resultadoExaRealiPapanicolaou = txt_resultadoPapaniAntGinObste.Text;

                if (ckb_siEcoMamaAntGinObste.Checked == true)
                {
                    inicial.inicial_siExaRealiEcoMamario = "Si";
                }
                if (ckb_noEcoMamaAntGinObste.Checked == true)
                {
                    inicial.inicial_noExaRealiEcoMamario = "Si";
                }
                inicial.inicial_tiempoExaRealiEcoMamario = txt_tiempoEcoMamaAntGinObste.Text;
                inicial.inicial_resultadoExaRealiEcoMamario = txt_resultadoEcoMamaAntGinObste.Text;

                if (ckb_siColposAntGinObste.Checked == true)
                {
                    inicial.inicial_siExaRealiColposcopia = "Si";
                }
                if (ckb_noColposAntGinObste.Checked == true)
                {
                    inicial.inicial_noExaRealiColposcopia = "Si";
                }
                inicial.inicial_tiempoExaRealiColposcopia = txt_tiempoColposAntGinObste.Text;
                inicial.inicial_resultadoExaRealiColposcopia = txt_resultadoColposAntGinObste.Text;

                if (ckb_siMamograAntGinObste.Checked == true)
                {
                    inicial.inicial_siExaRealiMamografia = "Si";
                }
                if (ckb_noMamograAntGinObste.Checked == true)
                {
                    inicial.inicial_noExaRealiMamografia = "Si";
                }
                inicial.inicial_tiempoExaRealiMamografia = txt_tiempoMamograAntGinObste.Text;
                inicial.inicial_resultadoExaRealiMamografia = txt_resultadoMamograAntGinObste.Text;

                //-----------------------------------

                if (ckb_siExaRealiAntProstaAntReproMascu.Checked == true)
                {
                    inicial.inicial_siExaRealiAntiProstatico = "Si";
                }
                if (ckb_noExaRealiAntProstaAntReproMascu.Checked == true)
                {
                    inicial.inicial_noExaRealiAntiProstatico = "Si";
                }
                inicial.inicial_tiempoExaRealiAntiProstatico = txt_tiempoExaRealiAntProstaAntReproMascu.Text;
                inicial.inicial_resultadoExaRealiAntiProstatico = txt_resultadoExaRealiAntProstaAntReproMascu.Text;

                if (ckb_siMetPlaniAntReproMascu.Checked == true)
                {
                    inicial.inicial_siMetPlanifiFamiAntReproMascu = "Si";
                }
                if (ckb_noMetPlaniAntReproMascu.Checked == true)
                {
                    inicial.inicial_noMetPlanifiFamiAntReproMascu = "Si";
                }
                inicial.inicial_tipo1MetPlanifiFamiAntReproMascu = txt_tipo1MetPlaniAntReproMascu.Text;

                inicial.inicial_vivosHijAntReproMascu = txt_vivosHijosAntReproMascu.Text;
                inicial.inicial_muertosHijAntReproMascu = txt_muertosHijosAntReproMascu.Text;

                if (ckb_siExaRealiEcoProstaAntReproMascu.Checked == true)
                {
                    inicial.inicial_siExaRealiEcoProstatico = "Si";
                }
                if (ckb_noExaRealiEcoProstaAntReproMascu.Checked == true)
                {
                    inicial.inicial_noExaRealiEcoProstatico = "Si";
                }
                inicial.inicial_tiempoExaRealiEcoProstatico = txt_tiempoExaRealiEcoProstaAntReproMascu.Text;
                inicial.inicial_resultadoExaRealiEcoProstatico = txt_resultadoExaRealiEcoProstaAntReproMascu.Text;
                inicial.inicial_tipo2MetPlanifiFamiAntReproMascu = txt_tipo2MetPlaniAntReproMascu.Text;

                //-----------------------------------

                if (ckb_siConsuNociTabaHabToxi.Checked == true)
                {
                    inicial.inicial_siConsuNocivosTabaco = "Si";
                }
                if (ckb_noConsuNociTabaHabToxi.Checked == true)
                {
                    inicial.inicial_noConsuNocivosTabaco = "Si";
                }
                inicial.inicial_tiempoConsuConsuNocivosTabaco = txt_tiemConConsuNociTabaHabToxi.Text;
                inicial.inicial_cantidadConsuNocivosTabaco = txt_cantiConsuNociTabaHabToxi.Text;
                inicial.inicial_exConsumiConsuNocivosTabaco = txt_exConsumiConsuNociTabaHabToxi.Text;
                inicial.inicial_tiempoAbstiConsuNocivosTabaco = txt_tiemAbstiConsuNociTabaHabToxi.Text;
                if (ckb_siConsuNociAlcoHabToxi.Checked == true)
                {
                    inicial.inicial_siConsuNocivosAlcohol = "Si";
                }
                if (ckb_noConsuNociAlcoHabToxi.Checked == true)
                {
                    inicial.inicial_noConsuNocivosAlcohol = "Si";
                }
                inicial.inicial_tiempoConsuConsuNocivosAlcohol = txt_tiemConConsuNociAlcoHabToxi.Text;
                inicial.inicial_cantidadConsuNocivosAlcohol = txt_cantiConsuNociAlcoHabToxi.Text;
                inicial.inicial_exConsumiConsuNocivosAlcohol = txt_exConsumiConsuNociAlcoHabToxi.Text;
                inicial.inicial_tiempoAbstiConsuNocivosAlcohol = txt_tiemAbstiConsuNociAlcoHabToxi.Text;
                if (ckb_siConsuNociOtrasDroHabToxi.Checked == true)
                {
                    inicial.inicial_siConsuNocivosOtrasDrogas = "Si";
                }
                if (ckb_noConsuNociOtrasDroHabToxi.Checked == true)
                {
                    inicial.inicial_noConsuNocivosOtrasDrogas = "Si";
                }
                inicial.inicial_tiempoConsu1ConsuNocivosOtrasDrogas = txt_tiemCon1ConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_cantidad1ConsuNocivosOtrasDrogas = txt_canti1ConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_exConsumi1ConsuNocivosOtrasDrogas = txt_exConsumi1ConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_tiempoAbsti1ConsuNocivosOtrasDrogas = txt_tiemAbsti1ConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_otrasConsuNocivos = txt_otrasConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_tiempoConsu2ConsuNocivosOtrasDrogas = txt_tiemCon2ConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_cantidad2ConsuNocivosOtrasDrogas = txt_canti2ConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_exConsumi2ConsuNocivosOtrasDrogas = txt_exConsumi2ConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_tiempoAbsti2ConsuNocivosOtrasDrogas = txt_tiemAbsti2ConsuNociOtrasDroHabToxi.Text;
                if (ckb_siEstVidaActFisiEstVida.Checked == true)
                {
                    inicial.inicial_siEstiVidaActFisica = "Si";
                }
                if (ckb_noEstVidaActFisiEstVida.Checked == true)
                {
                    inicial.inicial_noEstiVidaActFisica = "Si";
                }
                inicial.inicial_cualEstiVidaActFisica = txt_cualEstVidaActFisiEstVida.Text;
                inicial.inicial_tiem_cantEstiVidaActFisica = txt_tiemCanEstVidaActFisiEstVida.Text;
                if (ckb_siEstVidaMedHabiEstVida.Checked == true)
                {
                    inicial.inicial_siEstiVidaMediHabitual = "Si";
                }
                if (ckb_noEstVidaMedHabiEstVida.Checked == true)
                {
                    inicial.inicial_noEstiVidaMediHabitual = "Si";
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

                inicial.inicial_nomEmpresa2 = txt_empresa2.Text;
                inicial.inicial_puestoTrabajo2 = txt_puestotrabajo2.Text;
                inicial.inicial_actDesemp2 = txt_actdesempeña2.Text;
                inicial.inicial_tiemTrabajo2 = txt_tiempotrabajo2.Text;
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
                inicial.inicial_observacionesAnteEmpleAnteriores2 = txt_obseantempleanteriores2.Text;


                inicial.inicial_nomEmpresa3 = txt_empresa3.Text;
                inicial.inicial_puestoTrabajo3 = txt_puestotrabajo3.Text;
                inicial.inicial_actDesemp3 = txt_actdesempeña3.Text;
                inicial.inicial_tiemTrabajo3 = txt_tiempotrabajo3.Text;
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
                inicial.inicial_observacionesAnteEmpleAnteriores3 = txt_obseantempleanteriores3.Text;


                inicial.inicial_nomEmpresa4 = txt_empresa4.Text;
                inicial.inicial_puestoTrabajo4 = txt_puestotrabajo4.Text;
                inicial.inicial_actDesemp4 = txt_actdesempeña4.Text;
                inicial.inicial_tiemTrabajo4 = txt_tiempotrabajo4.Text;
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
                inicial.inicial_observacionesAnteEmpleAnteriores4 = txt_obseantempleanteriores4.Text;



                if (ckb_siAccTrabDescrip.Checked == true)
                {
                    inicial.inicial_siCalificadoIESSAcciTrabajo = "Si";
                }
                inicial.inicial_especificarCalificadoIESSAcciTrabajo = txt_especificar.Text;
                if (ckb_noAccTrabDescrip.Checked == true)
                {
                    inicial.inicial_noCalificadoIESSAcciTrabajo = "Si";
                }
                inicial.inicial_fechaCalificadoIESSAcciTrabajo = txt_fecha.Text;

                inicial.inicial_obserAcciTrabajo = txt_observaciones2.Text;
                if (ckb_siprofesional.Checked == true)
                {
                    inicial.inicial_siCalificadoIESSEnfProfesionales = "Si";
                }
                inicial.inicial_especificarCalificadoIESSEnfProfesionales = txt_espeprofesional.Text;
                if (ckb_noprofesional.Checked == true)
                {
                    inicial.inicial_noCalificadoIESSEnfProfesionales = "Si";
                }
                inicial.inicial_fechaCalificadoIESSEnfProfesionales = txt_fechaprofesional.Text;
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
                inicial.inicial_area2 = txt_puestodetrabajo2.Text;
                inicial.inicial_actividades2 = txt_act2.Text;
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
                inicial.inicial_area3 = txt_puestodetrabajo3.Text;
                inicial.inicial_actividades3 = txt_act3.Text;
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
                inicial.inicial_area4 = txt_puestodetrabajo4.Text;
                inicial.inicial_actividades4 = txt_act4.Text;
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
                //inicial.area = txt_puestodetrabajo21.Text;
                //inicial.inicial_actividades = txt_act21.Text;
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
                
                //inicial.inicial_puestoTrabajo2 = txt_puestodetrabajo22.Text;
                //inicial.inicial_actividades2 = txt_act22.Text;
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
                
                //inicial.inicial_puestoTrabajo3 = txt_puestodetrabajo23.Text;
                //inicial.inicial_actividades3 = txt_act23.Text;
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
                
                //inicial.inicial_puestoTrabajo4 = txt_puestodetrabajo24.Text;
                //inicial.inicial_actividades4 = txt_act24.Text;
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
                inicial.inicial_temperatura = txt_temperatura.Text;
                inicial.inicial_frecCardiacan = txt_freCardica.Text;
                inicial.inicial_satOxigenon = txt_satOxigeno.Text;
                inicial.inicial_frecRespiratorian = txt_freRespiratoria.Text;
                inicial.inicial_peson = txt_peso.Text;
                inicial.inicial_tallan = txt_talla.Text;
                inicial.inicial_indMasCorporaln = txt_indMasCorporal.Text;
                inicial.inicial_perAbdominaln = txt_perAbdominal.Text;



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
                inicial.inicial_fecha = txt_fechaexamen.Text;
                inicial.inicial_resultados = txt_resultadoexamen.Text;
                inicial.inicial_examen2 = txt_examen2.Text;
                inicial.inicial_fecha2 = txt_fechaexamen2.Text;
                inicial.inicial_resultados2 = txt_resultadoexamen2.Text;
                inicial.inicial_examen3 = txt_examen3.Text;
                inicial.inicial_fecha3 = txt_fechaexamen3.Text;
                inicial.inicial_resultados3 = txt_resultadoexamen3.Text;
                inicial.inicial_examen4 = txt_examen4.Text;
                inicial.inicial_fecha4 = txt_fechaexamen4.Text;
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
                inicial.inicial_fecha_hora = txt_fechahora.Text;
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

        private void ModificarInicial(Tbl_Inicial inicial)
        {
            try
            {
                if (ckb_catolica.Checked == true)
                {
                    inicial.inicial_catolicaRel = "Si";
                }
                else
                {
                    inicial.inicial_catolicaRel = null;
                }
                if (ckb_evangelica.Checked == true)
                {
                    inicial.inicial_evangelicaRel = "Si";
                }
                else
                {
                    inicial.inicial_evangelicaRel = null;
                }
                if (cbk_testigo.Checked == true)
                {
                    inicial.inicial_testJehovaRel = "Si";
                }
                else
                {
                    inicial.inicial_testJehovaRel = null;
                }
                if (cbk_mormona.Checked == true)
                {
                    inicial.inicial_mormonaRel = "Si";
                }
                else
                {
                    inicial.inicial_mormonaRel = null;
                }
                if (cbk_otrareligion.Checked == true)
                {
                    inicial.inicial_otrasRel = "Si";
                }
                else
                {
                    inicial.inicial_otrasRel = null;
                }
                inicial.inicial_groSanguineo = txt_gruposanguineo.Text;
                inicial.inicial_lateralidad = txt_lateralidad.Text;
                if (cbk_gay.Checked == true)
                {
                    inicial.inicial_gayOriSex = "Si";
                }
                else
                {
                    inicial.inicial_gayOriSex = null;
                }
                if (cbk_lesbiana.Checked == true)
                {
                    inicial.inicial__lesbianaOriSex = "Si";
                }
                else
                {
                    inicial.inicial__lesbianaOriSex = null;
                }
                if (cbk_bisexual.Checked == true)
                {
                    inicial.inicial_bisexualOriSex = "Si";
                }
                else
                {
                    inicial.inicial_bisexualOriSex = null;
                }
                if (cbk_heterosexual.Checked == true)
                {
                    inicial.inicial_heterosexualOriSex = "Si";
                }
                else
                {
                    inicial.inicial_heterosexualOriSex = null;
                }
                if (cbk_noRespondeOriSex.Checked == true)
                {
                    inicial.inicial_norespondeOriSex = "Si";
                }
                else
                {
                    inicial.inicial_norespondeOriSex = null;
                }
                if (cbk_femenino.Checked == true)
                {
                    inicial.inicial_femeninoIdenGen = "Si";
                }
                else
                {
                    inicial.inicial_femeninoIdenGen = null;
                }
                if (cbk_masculino.Checked == true)
                {
                    inicial.inicial_masculinoIdenGen = "Si";
                }
                else
                {
                    inicial.inicial_masculinoIdenGen = null;
                }
                if (cbk_transfemenino.Checked == true)
                {
                    inicial.inicial_transFemeninoIdenGen = "Si";
                }
                else
                {
                    inicial.inicial_transFemeninoIdenGen = null;
                }
                if (cbk_transmasculino.Checked == true)
                {
                    inicial.inicial_transMasculinoIdenGen = "Si";
                }
                else
                {
                    inicial.inicial_transMasculinoIdenGen = null;
                }
                if (cbk_noRespondeIdeGen.Checked == true)
                {
                    inicial.inicial_norespondeIdenGen = "Si";
                }
                else
                {
                    inicial.inicial_norespondeIdenGen = null;
                }
                if (cbk_sidiscapacidad.Checked == true)
                {
                    inicial.inicial_siDis = "Si";
                }
                else
                {
                    inicial.inicial_norespondeIdenGen = null;
                }
                if (cbk_nodiscapacidad.Checked == true)
                {
                    inicial.inicial_noDis = "Si";
                }
                else
                {
                    inicial.inicial_noDis = null;
                }
                inicial.inicial_tipoDis = txt_tipodiscapacidad.Text;
                inicial.inicial_porcentDis = txt_porcentajediscapacidad.Text;
                inicial.inicial_actRelePuesTrabajo = txt_actividadesrelevantes.Text;
                inicial.inicial_descripcionMotivoConsulta = txt_motivoconsultainicial.Text;
                inicial.inicial_descripcionAnteceCliniQuirur = txt_antCliQuiDescripcion.Text;
                inicial.inicial_descripcionAnteceCliniQuirur = txt_antCliQuiDescripcion.Text;
                inicial.inicial_menarquia = txt_menarquiaAntGinObste.Text;
                inicial.inicial_ciclos = txt_ciclosAntGinObste.Text;
                inicial.inicial_fechUltiMenstrua = txt_fechUltiMensAntGinObste.Text;
                inicial.inicial_gestas = txt_gestasAntGinObste.Text;
                inicial.inicial_partos = txt_partosAntGinObste.Text;
                inicial.inicial_cesareas = txt_cesareasAntGinObste.Text;
                inicial.inicial_abortos = txt_abortosAntGinObste.Text;
                inicial.inicial_vivosHij = txt_vivosAntGinObste.Text;
                inicial.inicial_muertosHij = txt_muertosAntGinObste.Text;
                if (ckb_siVidSexAntGinObste.Checked == true)
                {
                    inicial.inicial_siVidaSexActiva = "Si";
                }
                else
                {
                    inicial.inicial_siVidaSexActiva = null;
                }
                if (ckb_noVidSexAntGinObste.Checked == true)
                {
                    inicial.inicial_noVidaSexActiva = "Si";
                }
                else
                {
                    inicial.inicial_noVidaSexActiva = null;
                }
                if (ckb_siMetPlaniAntGinObste.Checked == true)
                {
                    inicial.inicial_siMetPlanifiFamiliar = "Si";
                }
                else
                {
                    inicial.inicial_siMetPlanifiFamiliar = null;
                }
                if (ckb_noMetPlaniAntGinObste.Checked == true)
                {
                    inicial.inicial_noMetPlanifiFamiliar = "Si";
                }
                else
                {
                    inicial.inicial_noMetPlanifiFamiliar = null;
                }
                inicial.inicial_tipoMetPlanifiFamiliar = txt_tipoMetPlaniAntGinObste.Text;
                if (ckb_siPapaniAntGinObste.Checked == true)
                {
                    inicial.inicial_siExaRealiPapanicolaou = "Si";
                }
                else
                {
                    inicial.inicial_siExaRealiPapanicolaou = null;
                }
                if (ckb_noPapaniAntGinObste.Checked == true)
                {
                    inicial.inicial_noExaRealiPapanicolaou = "Si";
                }
                else
                {
                    inicial.inicial_noExaRealiPapanicolaou = null;
                }
                inicial.inicial_tiempoExaRealiPapanicolaou = txt_tiempoPapaniAntGinObste.Text;
                inicial.inicial_resultadoExaRealiPapanicolaou = txt_resultadoPapaniAntGinObste.Text;
                if (ckb_siEcoMamaAntGinObste.Checked == true)
                {
                    inicial.inicial_siExaRealiEcoMamario = "Si";
                }
                else
                {
                    inicial.inicial_siExaRealiEcoMamario = null;
                }
                if (ckb_noEcoMamaAntGinObste.Checked == true)
                {
                    inicial.inicial_noExaRealiEcoMamario = "Si";
                }
                else
                {
                    inicial.inicial_noExaRealiEcoMamario = null;
                }
                inicial.inicial_tiempoExaRealiEcoMamario = txt_tiempoEcoMamaAntGinObste.Text;
                inicial.inicial_resultadoExaRealiEcoMamario = txt_resultadoEcoMamaAntGinObste.Text;
                if (ckb_siColposAntGinObste.Checked == true)
                {
                    inicial.inicial_siExaRealiColposcopia = "Si";
                }
                else
                {
                    inicial.inicial_siExaRealiColposcopia = null;
                }
                if (ckb_noColposAntGinObste.Checked == true)
                {
                    inicial.inicial_noExaRealiColposcopia = "Si";
                }
                else
                {
                    inicial.inicial_noExaRealiColposcopia = null;
                }
                inicial.inicial_tiempoExaRealiColposcopia = txt_tiempoColposAntGinObste.Text;
                inicial.inicial_resultadoExaRealiColposcopia = txt_resultadoColposAntGinObste.Text;
                if (ckb_siMamograAntGinObste.Checked == true)
                {
                    inicial.inicial_siExaRealiMamografia = "Si";
                }
                else
                {
                    inicial.inicial_siExaRealiMamografia = null;
                }
                if (ckb_noMamograAntGinObste.Checked == true)
                {
                    inicial.inicial_noExaRealiMamografia = "Si";
                }
                else
                {
                    inicial.inicial_noExaRealiMamografia = null;
                }
                inicial.inicial_tiempoExaRealiMamografia = txt_tiempoMamograAntGinObste.Text;
                inicial.inicial_resultadoExaRealiMamografia = txt_resultadoMamograAntGinObste.Text;
                if (ckb_siExaRealiAntProstaAntReproMascu.Checked == true)
                {
                    inicial.inicial_siExaRealiAntiProstatico = "Si";
                }
                else
                {
                    inicial.inicial_siExaRealiAntiProstatico = null;
                }
                if (ckb_noExaRealiAntProstaAntReproMascu.Checked == true)
                {
                    inicial.inicial_noExaRealiAntiProstatico = "Si";
                }
                else
                {
                    inicial.inicial_noExaRealiAntiProstatico = null;
                }
                inicial.inicial_tiempoExaRealiAntiProstatico = txt_tiempoExaRealiAntProstaAntReproMascu.Text;
                inicial.inicial_resultadoExaRealiAntiProstatico = txt_resultadoExaRealiAntProstaAntReproMascu.Text;
                if (ckb_siMetPlaniAntReproMascu.Checked == true)
                {
                    inicial.inicial_siMetPlanifiFamiAntReproMascu = "Si";
                }
                else
                {
                    inicial.inicial_siMetPlanifiFamiAntReproMascu = null;
                }
                if (ckb_noMetPlaniAntReproMascu.Checked == true)
                {
                    inicial.inicial_noMetPlanifiFamiAntReproMascu = "Si";
                }
                else
                {
                    inicial.inicial_noMetPlanifiFamiAntReproMascu = null;
                }
                inicial.inicial_tipo1MetPlanifiFamiAntReproMascu = txt_tipo1MetPlaniAntReproMascu.Text;
                inicial.inicial_vivosHijAntReproMascu = txt_vivosHijosAntReproMascu.Text;
                inicial.inicial_muertosHijAntReproMascu = txt_muertosHijosAntReproMascu.Text;
                if (ckb_siExaRealiEcoProstaAntReproMascu.Checked == true)
                {
                    inicial.inicial_siExaRealiEcoProstatico = "Si";
                }
                else
                {
                    inicial.inicial_siExaRealiEcoProstatico = null;
                }
                if (ckb_noExaRealiEcoProstaAntReproMascu.Checked == true)
                {
                    inicial.inicial_noExaRealiEcoProstatico = "Si";
                }
                else
                {
                    inicial.inicial_noExaRealiEcoProstatico = null;
                }
                inicial.inicial_tiempoExaRealiEcoProstatico = txt_tiempoExaRealiEcoProstaAntReproMascu.Text;
                inicial.inicial_resultadoExaRealiEcoProstatico = txt_resultadoExaRealiEcoProstaAntReproMascu.Text;
                inicial.inicial_tipo2MetPlanifiFamiAntReproMascu = txt_tipo2MetPlaniAntReproMascu.Text;
                if (ckb_siConsuNociTabaHabToxi.Checked == true)
                {
                    inicial.inicial_siConsuNocivosTabaco = "Si";
                }
                else
                {
                    inicial.inicial_siConsuNocivosTabaco = null;
                }
                if (ckb_noConsuNociTabaHabToxi.Checked == true)
                {
                    inicial.inicial_noConsuNocivosTabaco = "Si";
                }
                else
                {
                    inicial.inicial_noConsuNocivosTabaco = null;
                }
                inicial.inicial_tiempoConsuConsuNocivosTabaco = txt_tiemConConsuNociTabaHabToxi.Text;
                inicial.inicial_cantidadConsuNocivosTabaco = txt_cantiConsuNociTabaHabToxi.Text;
                inicial.inicial_exConsumiConsuNocivosTabaco = txt_exConsumiConsuNociTabaHabToxi.Text;
                inicial.inicial_tiempoAbstiConsuNocivosTabaco = txt_tiemAbstiConsuNociTabaHabToxi.Text;
                if (ckb_siConsuNociAlcoHabToxi.Checked == true)
                {
                    inicial.inicial_siConsuNocivosAlcohol = "Si";
                }
                else
                {
                    inicial.inicial_siConsuNocivosAlcohol = null;
                }
                if (ckb_noConsuNociAlcoHabToxi.Checked == true)
                {
                    inicial.inicial_noConsuNocivosAlcohol = "Si";
                }
                else
                {
                    inicial.inicial_noConsuNocivosAlcohol = null;
                }
                inicial.inicial_tiempoConsuConsuNocivosAlcohol = txt_tiemConConsuNociAlcoHabToxi.Text;
                inicial.inicial_cantidadConsuNocivosAlcohol = txt_cantiConsuNociAlcoHabToxi.Text;
                inicial.inicial_exConsumiConsuNocivosAlcohol = txt_exConsumiConsuNociAlcoHabToxi.Text;
                inicial.inicial_tiempoAbstiConsuNocivosAlcohol = txt_tiemAbstiConsuNociAlcoHabToxi.Text;
                if (ckb_siConsuNociOtrasDroHabToxi.Checked == true)
                {
                    inicial.inicial_siConsuNocivosOtrasDrogas = "Si";
                }
                else
                {
                    inicial.inicial_siConsuNocivosOtrasDrogas = null;
                }
                if (ckb_noConsuNociOtrasDroHabToxi.Checked == true)
                {
                    inicial.inicial_noConsuNocivosOtrasDrogas = "Si";
                }
                else
                {
                    inicial.inicial_noConsuNocivosOtrasDrogas = null;
                }
                inicial.inicial_tiempoConsu1ConsuNocivosOtrasDrogas = txt_tiemCon1ConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_cantidad1ConsuNocivosOtrasDrogas = txt_canti1ConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_exConsumi1ConsuNocivosOtrasDrogas = txt_exConsumi1ConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_tiempoAbsti1ConsuNocivosOtrasDrogas = txt_tiemAbsti1ConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_otrasConsuNocivos = txt_otrasConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_tiempoConsu2ConsuNocivosOtrasDrogas = txt_tiemCon2ConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_cantidad2ConsuNocivosOtrasDrogas = txt_canti2ConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_exConsumi2ConsuNocivosOtrasDrogas = txt_exConsumi2ConsuNociOtrasDroHabToxi.Text;
                inicial.inicial_tiempoAbsti2ConsuNocivosOtrasDrogas = txt_tiemAbsti2ConsuNociOtrasDroHabToxi.Text;
                if (ckb_siEstVidaActFisiEstVida.Checked == true)
                {
                    inicial.inicial_siEstiVidaActFisica = "Si";
                }
                else
                {
                    inicial.inicial_siEstiVidaActFisica = null;
                }
                if (ckb_noEstVidaActFisiEstVida.Checked == true)
                {
                    inicial.inicial_noEstiVidaActFisica = "Si";
                }
                else
                {
                    inicial.inicial_noEstiVidaActFisica = null;
                }
                inicial.inicial_cualEstiVidaActFisica = txt_cualEstVidaActFisiEstVida.Text;
                inicial.inicial_tiem_cantEstiVidaActFisica = txt_tiemCanEstVidaActFisiEstVida.Text;
                if (ckb_siEstVidaMedHabiEstVida.Checked == true)
                {
                    inicial.inicial_siEstiVidaMediHabitual = "Si";
                }
                else
                {
                    inicial.inicial_siEstiVidaMediHabitual = null;
                }
                if (ckb_noEstVidaMedHabiEstVida.Checked == true)
                {
                    inicial.inicial_noEstiVidaMediHabitual = "Si";
                }
                else
                {
                    inicial.inicial_noEstiVidaMediHabitual = null;
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
                else
                {
                    inicial.inicial_fisicoRies = null;
                }
                if (ckb_mecanico.Checked == true)
                {
                    inicial.inicial_mecanicoRies = "Si";
                }
                else
                {
                    inicial.inicial_mecanicoRies = null;
                }
                if (ckb_quimico.Checked == true)
                {
                    inicial.inicial_quimicoRies = "Si";
                }
                else
                {
                    inicial.inicial_quimicoRies = null;
                }
                if (ckb_biologico.Checked == true)
                {
                    inicial.inicial_biologicoRies = "Si";
                }
                else
                {
                    inicial.inicial_biologicoRies = null;
                }
                if (ckb_ergonomico.Checked == true)
                {
                    inicial.inicial_ergonomicoRies = "Si";
                }
                else
                {
                    inicial.inicial_ergonomicoRies = null;
                }
                if (ckb_psicosocial.Checked == true)
                {
                    inicial.inicial_psicosocial = "Si";
                }
                else
                {
                    inicial.inicial_psicosocial = null;
                }
                inicial.inicial_observacionesAnteEmpleAnteriores = txt_obseantempleanteriores.Text;

                inicial.inicial_nomEmpresa2 = txt_empresa2.Text;
                inicial.inicial_puestoTrabajo2 = txt_puestotrabajo2.Text;
                inicial.inicial_actDesemp2 = txt_actdesempeña2.Text;
                inicial.inicial_tiemTrabajo2 = txt_tiempotrabajo2.Text;
                if (ckb_fisico2.Checked == true)
                {
                    inicial.inicial_fisicoRies2 = "Si";
                }
                else
                {
                    inicial.inicial_fisicoRies2 = null;
                }
                if (ckb_mecanico2.Checked == true)
                {
                    inicial.inicial_mecanicoRies2 = "Si";
                }
                else
                {
                    inicial.inicial_mecanicoRies2 = null;
                }
                if (ckb_quimico2.Checked == true)
                {
                    inicial.inicial_quimicoRies2 = "Si";
                }
                else
                {
                    inicial.inicial_quimicoRies2 = null;
                }
                if (ckb_biologico2.Checked == true)
                {
                    inicial.inicial_biologicoRies2 = "Si";
                }
                else
                {
                    inicial.inicial_biologicoRies2 = null;
                }
                if (ckb_ergonomico2.Checked == true)
                {
                    inicial.inicial_ergonomicoRies2 = "Si";
                }
                else
                {
                    inicial.inicial_ergonomicoRies2 = null;
                }
                if (ckb_psicosocial2.Checked == true)
                {
                    inicial.inicial_psicosocial2 = "Si";
                }
                else
                {
                    inicial.inicial_psicosocial2 = null;
                }
                inicial.inicial_observacionesAnteEmpleAnteriores2 = txt_obseantempleanteriores2.Text;

                inicial.inicial_nomEmpresa3 = txt_empresa3.Text;
                inicial.inicial_puestoTrabajo3 = txt_puestotrabajo3.Text;
                inicial.inicial_actDesemp3 = txt_actdesempeña3.Text;
                inicial.inicial_tiemTrabajo3 = txt_tiempotrabajo3.Text;
                if (ckb_fisico3.Checked == true)
                {
                    inicial.inicial_fisicoRies3 = "Si";
                }
                else
                {
                    inicial.inicial_fisicoRies3 = null;
                }
                if (ckb_mecanico3.Checked == true)
                {
                    inicial.inicial_mecanicoRies3 = "Si";
                }
                else
                {
                    inicial.inicial_mecanicoRies3 = null;
                }
                if (ckb_quimico3.Checked == true)
                {
                    inicial.inicial_quimicoRies3 = "Si";
                }
                else
                {
                    inicial.inicial_quimicoRies3 = null;
                }
                if (ckb_biologico3.Checked == true)
                {
                    inicial.inicial_biologicoRies3 = "Si";
                }
                else
                {
                    inicial.inicial_biologicoRies3 = null;
                }
                if (ckb_ergonomico3.Checked == true)
                {
                    inicial.inicial_ergonomicoRies3 = "Si";
                }
                else
                {
                    inicial.inicial_ergonomicoRies3 = null;
                }
                if (ckb_psicosocial3.Checked == true)
                {
                    inicial.inicial_psicosocial3 = "Si";
                }
                else
                {
                    inicial.inicial_psicosocial3 = null;
                }
                inicial.inicial_observacionesAnteEmpleAnteriores3 = txt_obseantempleanteriores3.Text;

                inicial.inicial_nomEmpresa4 = txt_empresa4.Text;
                inicial.inicial_puestoTrabajo4 = txt_puestotrabajo4.Text;
                inicial.inicial_actDesemp4 = txt_actdesempeña4.Text;
                inicial.inicial_tiemTrabajo4 = txt_tiempotrabajo4.Text;
                if (ckb_fisico4.Checked == true)
                {
                    inicial.inicial_fisicoRies4 = "Si";
                }
                else
                {
                    inicial.inicial_fisicoRies4 = null;
                }
                if (ckb_mecanico4.Checked == true)
                {
                    inicial.inicial_mecanicoRies4 = "Si";
                }
                else
                {
                    inicial.inicial_mecanicoRies4 = null;
                }
                if (ckb_quimico4.Checked == true)
                {
                    inicial.inicial_quimicoRies4 = "Si";
                }
                else
                {
                    inicial.inicial_quimicoRies4 = null;
                }
                if (ckb_biologico4.Checked == true)
                {
                    inicial.inicial_biologicoRies4 = "Si";
                }
                else
                {
                    inicial.inicial_biologicoRies4 = null;
                }
                if (ckb_ergonomico4.Checked == true)
                {
                    inicial.inicial_ergonomicoRies4 = "Si";
                }
                else
                {
                    inicial.inicial_ergonomicoRies4 = null;
                }
                if (ckb_psicosocial4.Checked == true)
                {
                    inicial.inicial_psicosocial4 = "Si";
                }
                else
                {
                    inicial.inicial_psicosocial4 = null;
                }
                inicial.inicial_observacionesAnteEmpleAnteriores4 = txt_obseantempleanteriores4.Text;


                if (ckb_siAccTrabDescrip.Checked == true)
                {
                    inicial.inicial_siCalificadoIESSAcciTrabajo = "Si";
                }
                else
                {
                    inicial.inicial_siCalificadoIESSAcciTrabajo = null;
                }
                inicial.inicial_especificarCalificadoIESSAcciTrabajo = txt_especificar.Text;
                if (ckb_noAccTrabDescrip.Checked == true)
                {
                    inicial.inicial_noCalificadoIESSAcciTrabajo = "Si";
                }
                else
                {
                    inicial.inicial_noCalificadoIESSAcciTrabajo = null;
                }
                inicial.inicial_fechaCalificadoIESSAcciTrabajo = txt_fecha.Text;
                inicial.inicial_obserAcciTrabajo = txt_observaciones2.Text;


                if (ckb_siprofesional.Checked == true)
                {
                    inicial.inicial_siCalificadoIESSEnfProfesionales = "Si";
                }
                else
                {
                    inicial.inicial_siCalificadoIESSEnfProfesionales = null;
                }
                inicial.inicial_especificarCalificadoIESSEnfProfesionales = txt_espeprofesional.Text;
                if (ckb_noprofesional.Checked == true)
                {
                    inicial.inicial_noCalificadoIESSEnfProfesionales = "Si";
                }
                else
                {
                    inicial.inicial_noCalificadoIESSEnfProfesionales = null;
                }
                inicial.inicial_fechaCalificadoIESSEnfProfesionales = txt_fechaprofesional.Text;
                inicial.inicial_obserEnfProfesionales = txt_observaciones3.Text;


                if (ckb_enfermedadcardiovascular.Checked == true)
                {
                    inicial.inicial_enfCarVasAnteFamiliares = "Si";
                }
                else
                {
                    inicial.inicial_enfCarVasAnteFamiliares = null;
                }
                if (ckb_enfermedadmetabolica.Checked == true)
                {
                    inicial.inicial_enfMetaAnteFamiliares = "Si";
                }
                else
                {
                    inicial.inicial_enfMetaAnteFamiliares = null;
                }
                if (ckb_enfermedadneurologica.Checked == true)
                {
                    inicial.inicial_enfNeuroAnteFamiliares = "Si";
                }
                else
                {
                    inicial.inicial_enfNeuroAnteFamiliares = null;
                }
                if (ckb_enfermedadoncologica.Checked == true)
                {
                    inicial.inicial_enfOncoAnteFamiliares = "Si";
                }
                else
                {
                    inicial.inicial_enfOncoAnteFamiliares = null;
                }
                if (ckb_enfermedadinfecciosa.Checked == true)
                {
                    inicial.inicial_enfInfeAnteFamiliares = "Si";
                }
                else
                {
                    inicial.inicial_enfInfeAnteFamiliares = null;
                }
                if (ckb_enfermedadhereditaria.Checked == true)
                {
                    inicial.inicial_enfHereCongeAnteFamiliares = "Si";
                }
                else
                {
                    inicial.inicial_enfHereCongeAnteFamiliares = null;
                }
                if (ckb_discapacidades.Checked == true)
                {
                    inicial.inicial_discapaAnteFamiliares = "Si";
                }
                else
                {
                    inicial.inicial_discapaAnteFamiliares = null;
                }
                if (ckb_otrosenfer.Checked == true)
                {
                    inicial.inicial_otrosAnteFamiliares = "Si";
                }
                else
                {
                    inicial.inicial_otrosAnteFamiliares = null;
                }
                inicial.inicial_descripcionAnteFamiliares = txt_descripcionantefamiliares.Text;


                inicial.inicial_area = txt_puestodetrabajo.Text;
                inicial.inicial_actividades = txt_act.Text;
                if (ckb_tempaltas.Checked == true)
                {
                    inicial.inicial_temAltasFis = "Si";
                }
                else
                {
                    inicial.inicial_temAltasFis = null;
                }
                if (ckb_tempbajas.Checked == true)
                {
                    inicial.inicial_temBajasFis = "Si";
                }
                else
                {
                    inicial.inicial_temBajasFis = null;
                }
                if (ckb_radiacion.Checked == true)
                {
                    inicial.inicial_radIonizanteFis = "Si";
                }
                else
                {
                    inicial.inicial_radIonizanteFis = null;
                }
                if (ckb_noradiacion.Checked == true)
                {
                    inicial.inicial_radNoIonizanteFis = "Si";
                }
                else
                {
                    inicial.inicial_radNoIonizanteFis = null;
                }
                if (ckb_ruido.Checked == true)
                {
                    inicial.inicial_ruidoFis = "Si";
                }
                else
                {
                    inicial.inicial_ruidoFis = null;
                }
                if (ckb_vibracion.Checked == true)
                {
                    inicial.inicial_vibracionFis = "Si";
                }
                else
                {
                    inicial.inicial_vibracionFis = null;
                }
                if (ckb_iluminacion.Checked == true)
                {
                    inicial.inicial_iluminacionFis = "Si";
                }
                else
                {
                    inicial.inicial_iluminacionFis = null;
                }
                if (ckb_ventilacion.Checked == true)
                {
                    inicial.inicial_ventilacionFis = "Si";
                }
                else
                {
                    inicial.inicial_ventilacionFis = null;
                }
                if (ckb_fluidoelectrico.Checked == true)
                {
                    inicial.inicial_fluElectricoFis = "Si";
                }
                else
                {
                    inicial.inicial_fluElectricoFis = null;
                }
                if (ckb_otrosFisico.Checked == true)
                {
                    inicial.inicial_otrosFis = "Si";
                }
                else
                {
                    inicial.inicial_otrosFis = null;
                }

                inicial.inicial_area2 = txt_puestodetrabajo2.Text;
                inicial.inicial_actividades2 = txt_act2.Text;
                if (ckb_tempaltas2.Checked == true)
                {
                    inicial.inicial_temAltasFis2 = "Si";
                }
                else
                {
                    inicial.inicial_temAltasFis2 = null;
                }
                if (ckb_tempbajas2.Checked == true)
                {
                    inicial.inicial_temBajasFis2 = "Si";
                }
                else
                {
                    inicial.inicial_temBajasFis2 = null;
                }
                if (ckb_radiacion2.Checked == true)
                {
                    inicial.inicial_radIonizanteFis2 = "Si";
                }
                else
                {
                    inicial.inicial_radIonizanteFis2 = null;
                }
                if (ckb_noradiacion2.Checked == true)
                {
                    inicial.inicial_radNoIonizanteFis2 = "Si";
                }
                else
                {
                    inicial.inicial_radNoIonizanteFis2 = null;
                }
                if (ckb_ruido2.Checked == true)
                {
                    inicial.inicial_ruidoFis2 = "Si";
                }
                else
                {
                    inicial.inicial_ruidoFis2 = null;
                }
                if (ckb_vibracion2.Checked == true)
                {
                    inicial.inicial_vibracionFis2 = "Si";
                }
                else
                {
                    inicial.inicial_vibracionFis2 = null;
                }
                if (ckb_iluminacion2.Checked == true)
                {
                    inicial.inicial_iluminacionFis2 = "Si";
                }
                else
                {
                    inicial.inicial_iluminacionFis2 = null;
                }
                if (ckb_ventilacion2.Checked == true)
                {
                    inicial.inicial_ventilacionFis2 = "Si";
                }
                else
                {
                    inicial.inicial_ventilacionFis2 = null;
                }
                if (ckb_fluidoelectrico2.Checked == true)
                {
                    inicial.inicial_fluElectricoFis2 = "Si";
                }
                else
                {
                    inicial.inicial_fluElectricoFis2 = null;
                }
                if (ckb_otrosFisico2.Checked == true)
                {
                    inicial.inicial_otrosFis2 = "Si";
                }
                else
                {
                    inicial.inicial_otrosFis2 = null;
                }

                inicial.inicial_area3 = txt_puestodetrabajo3.Text;
                inicial.inicial_actividades3 = txt_act3.Text;
                if (ckb_tempaltas3.Checked == true)
                {
                    inicial.inicial_temAltasFis3 = "Si";
                }
                else
                {
                    inicial.inicial_temAltasFis3 = null;
                }
                if (ckb_tempbajas3.Checked == true)
                {
                    inicial.inicial_temBajasFis3 = "Si";
                }
                else
                {
                    inicial.inicial_temBajasFis3 = null;
                }
                if (ckb_radiacion3.Checked == true)
                {
                    inicial.inicial_radIonizanteFis3 = "Si";
                }
                else
                {
                    inicial.inicial_radIonizanteFis3 = null;
                }
                if (ckb_noradiacion3.Checked == true)
                {
                    inicial.inicial_radNoIonizanteFis3 = "Si";
                }
                else
                {
                    inicial.inicial_radNoIonizanteFis3 = null;
                }
                if (ckb_ruido3.Checked == true)
                {
                    inicial.inicial_ruidoFis3 = "Si";
                }
                else
                {
                    inicial.inicial_ruidoFis3 = null;
                }
                if (ckb_vibracion3.Checked == true)
                {
                    inicial.inicial_vibracionFis3 = "Si";
                }
                else
                {
                    inicial.inicial_vibracionFis3 = null;
                }
                if (ckb_iluminacion3.Checked == true)
                {
                    inicial.inicial_iluminacionFis3 = "Si";
                }
                else
                {
                    inicial.inicial_iluminacionFis3 = null;
                }
                if (ckb_ventilacion3.Checked == true)
                {
                    inicial.inicial_ventilacionFis3 = "Si";
                }
                else
                {
                    inicial.inicial_ventilacionFis3 = null;
                }
                if (ckb_fluidoelectrico3.Checked == true)
                {
                    inicial.inicial_fluElectricoFis3 = "Si";
                }
                else
                {
                    inicial.inicial_fluElectricoFis3 = null;
                }
                if (ckb_otrosFisico3.Checked == true)
                {
                    inicial.inicial_otrosFis3 = "Si";
                }
                else
                {
                    inicial.inicial_otrosFis3 = null;
                }

                inicial.inicial_area4 = txt_puestodetrabajo4.Text;
                inicial.inicial_actividades4 = txt_act4.Text;   
                if (ckb_tempaltas4.Checked == true)
                {
                    inicial.inicial_temAltasFis4 = "Si";
                }
                else
                {
                    inicial.inicial_temAltasFis4 = null;
                }
                if (ckb_tempbajas4.Checked == true)
                {
                    inicial.inicial_temBajasFis4 = "Si";
                }
                else
                {
                    inicial.inicial_temBajasFis4 = null;
                }
                if (ckb_radiacion4.Checked == true)
                {
                    inicial.inicial_radIonizanteFis4 = "Si";
                }
                else
                {
                    inicial.inicial_radIonizanteFis4 = null;
                }
                if (ckb_noradiacion4.Checked == true)
                {
                    inicial.inicial_radNoIonizanteFis4 = "Si";
                }
                else
                {
                    inicial.inicial_radNoIonizanteFis4 = null;
                }
                if (ckb_ruido4.Checked == true)
                {
                    inicial.inicial_ruidoFis4 = "Si";
                }
                else
                {
                    inicial.inicial_ruidoFis4 = null;
                }
                if (ckb_vibracion4.Checked == true)
                {
                    inicial.inicial_vibracionFis4 = "Si";
                }
                else
                {
                    inicial.inicial_vibracionFis4 = null;
                }
                if (ckb_iluminacion4.Checked == true)
                {
                    inicial.inicial_iluminacionFis4 = "Si";
                }
                else
                {
                    inicial.inicial_iluminacionFis4 = null;
                }
                if (ckb_ventilacion4.Checked == true)
                {
                    inicial.inicial_ventilacionFis4 = "Si";
                }
                else
                {
                    inicial.inicial_ventilacionFis4 = null;
                }
                if (ckb_fluidoelectrico4.Checked == true)
                {
                    inicial.inicial_fluElectricoFis4 = "Si";
                }
                else
                {
                    inicial.inicial_fluElectricoFis4 = null;
                }
                if (ckb_otrosFisico4.Checked == true)
                {
                    inicial.inicial_otrosFis4 = "Si";
                }
                else
                {
                    inicial.inicial_otrosFis4 = null;

                }
                if (ckb_atrapmaquinas.Checked == true)
                {
                    inicial.inicial_atraMaquinasMec = "Si";
                }
                else
                {
                    inicial.inicial_atraMaquinasMec = null;
                }
                if (ckb_atrapsuperficie.Checked == true)
                {
                    inicial.inicial_atraSuperfiiesMec = "Si";
                }
                else
                {
                    inicial.inicial_atraSuperfiiesMec = null;
                }
                if (ckb_atrapobjetos.Checked == true)
                {
                    inicial.inicial_atraObjetosMec = "Si";
                }
                else
                {
                    inicial.inicial_atraObjetosMec = null;
                }
                if (ckb_caidaobjetos.Checked == true)
                {
                    inicial.inicial_caidaObjetosMec = "Si";
                }
                else
                {
                    inicial.inicial_caidaObjetosMec = null;
                }
                if (ckb_caidamisnivel.Checked == true)
                {
                    inicial.inicial_caidaMisNivelMec = "Si";
                }
                else
                {
                    inicial.inicial_caidaMisNivelMec = null;
                }
                if (ckb_caidadifnivel.Checked == true)
                {
                    inicial.inicial_caidaDifNivelMec = "Si";
                }
                else
                {
                    inicial.inicial_caidaDifNivelMec = null;
                }
                if (ckb_contaelectrico.Checked == true)
                {
                    inicial.inicial_contactoElecMec = "Si";
                }
                else
                {
                    inicial.inicial_contactoElecMec = null;
                }
                if (ckb_contasuptrabajo.Checked == true)
                {
                    inicial.inicial_conSuperTrabaMec = "Si";
                }
                else
                {
                    inicial.inicial_conSuperTrabaMec = null;
                }
                if (ckb_proyparticulas.Checked == true)
                {
                    inicial.inicial_proPartiFragMec = "Si";
                }
                else
                {
                    inicial.inicial_proPartiFragMec = null;
                }
                if (ckb_proyefluidos.Checked == true)
                {
                    inicial.inicial_proFluidosMec = "Si";
                }
                else
                {
                    inicial.inicial_proFluidosMec = null;
                }
                if (ckb_pinchazos.Checked == true)
                {
                    inicial.inicial_pinchazosMec = "Si";
                }
                else
                {
                    inicial.inicial_pinchazosMec = null;
                }
                if (ckb_cortes.Checked == true)
                {
                    inicial.inicial_cortesMec = "Si";
                }
                else
                {
                    inicial.inicial_cortesMec = null;
                }
                if (ckb_atroporvehiculos.Checked == true)
                {
                    inicial.inicial_atropeVehiMec = "Si";
                }
                else
                {
                    inicial.inicial_atropeVehiMec = null;
                }
                if (ckb_choques.Checked == true)
                {
                    inicial.inicial_coliVehiMec = "Si";
                }
                else
                {
                    inicial.inicial_coliVehiMec = null;
                }
                if (ckb_otrosMecanico.Checked == true)
                {
                    inicial.inicial_otrosMec = "Si";
                }
                else
                {
                    inicial.inicial_otrosMec = null;
                }
                if (ckb_solidos.Checked == true)
                {
                    inicial.inicial_solidosQui = "Si";
                }
                else
                {
                    inicial.inicial_solidosQui = null;
                }
                if (ckb_polvos.Checked == true)
                {
                    inicial.inicial_polvosQui = "Si";
                }
                else
                {
                    inicial.inicial_polvosQui = null;
                }
                if (ckb_humos.Checked == true)
                {
                    inicial.inicial_humosQui = "Si";
                }
                else
                {
                    inicial.inicial_humosQui = null;
                }
                if (ckb_liquidos.Checked == true)
                {
                    inicial.inicial_liquidosQui = "Si";
                }
                else
                {
                    inicial.inicial_liquidosQui = null;
                }
                if (ckb_vapores.Checked == true)
                {
                    inicial.inicial_vaporesQui = "Si";
                }
                else
                {
                    inicial.inicial_vaporesQui = null;
                }
                if (ckb_aerosoles.Checked == true)
                {
                    inicial.inicial_aerosolesQui = "Si";
                }
                else
                {
                    inicial.inicial_aerosolesQui = null;
                }
                if (ckb_neblinas.Checked == true)
                {
                    inicial.inicial_neblinasQui = "Si";
                }
                else
                {
                    inicial.inicial_neblinasQui = null;
                }
                if (ckb_gaseosos.Checked == true)
                {
                    inicial.inicial_gaseososQui = "Si";
                }
                else
                {
                    inicial.inicial_gaseososQui = null;
                }
                if (ckb_otrosQuimico.Checked == true)
                {
                    inicial.inicial_otrosQui = "Si";
                }
                else
                {
                    inicial.inicial_otrosQui = null;
                }
                if (ckb_atrapmaquinas2.Checked == true)
                {
                    inicial.inicial_atraMaquinasMec2 = "Si";
                }
                else
                {
                    inicial.inicial_atraMaquinasMec2 = null;
                }
                if (ckb_atrapsuperficie2.Checked == true)
                {
                    inicial.inicial_atraSuperfiiesMec2 = "Si";
                }
                else
                {
                    inicial.inicial_atraSuperfiiesMec2 = null;
                }
                if (ckb_atrapobjetos2.Checked == true)
                {
                    inicial.inicial_atraObjetosMec2 = "Si";
                }
                else
                {
                    inicial.inicial_atraObjetosMec2 = null;
                }
                if (ckb_caidaobjetos2.Checked == true)
                {
                    inicial.inicial_caidaObjetosMec2 = "Si";
                }
                else
                {
                    inicial.inicial_caidaObjetosMec2 = null;
                }
                if (ckb_caidamisnivel2.Checked == true)
                {
                    inicial.inicial_caidaMisNivelMec2 = "Si";
                }
                else
                {
                    inicial.inicial_caidaMisNivelMec2 = null;

                }
                if (ckb_caidadifnivel2.Checked == true)
                {
                    inicial.inicial_caidaDifNivelMec2 = "Si";
                }
                else
                {
                    inicial.inicial_caidaDifNivelMec2 = null;
                }
                if (ckb_contaelectrico2.Checked == true)
                {
                    inicial.inicial_contactoElecMec2 = "Si";
                }
                else
                {
                    inicial.inicial_contactoElecMec2 = null;
                }
                if (ckb_contasuptrabajo2.Checked == true)
                {
                    inicial.inicial_conSuperTrabaMec2 = "Si";
                }
                else
                {
                    inicial.inicial_conSuperTrabaMec2 = null;
                }
                if (ckb_proyparticulas2.Checked == true)
                {
                    inicial.inicial_proPartiFragMec2 = "Si";
                }
                else
                {
                    inicial.inicial_proPartiFragMec2 = null;
                }
                if (ckb_proyefluidos2.Checked == true)
                {
                    inicial.inicial_proFluidosMec2 = "Si";
                }
                else
                {
                    inicial.inicial_proFluidosMec2 = null;
                }
                if (ckb_pinchazos2.Checked == true)
                {
                    inicial.inicial_pinchazosMec2 = "Si";
                }
                else
                {
                    inicial.inicial_pinchazosMec2 = null;
                }
                if (ckb_cortes2.Checked == true)
                {
                    inicial.inicial_cortesMec2 = "Si";
                }
                else
                {
                    inicial.inicial_cortesMec2 = null;
                }
                if (ckb_atroporvehiculos2.Checked == true)
                {
                    inicial.inicial_atropeVehiMec2 = "Si";
                }
                else
                {
                    inicial.inicial_atropeVehiMec2 = null;
                }
                if (ckb_choques2.Checked == true)
                {
                    inicial.inicial_coliVehiMec2 = "Si";
                }
                else
                {
                    inicial.inicial_coliVehiMec2 = null;
                }
                if (ckb_otrosMecanico2.Checked == true)
                {
                    inicial.inicial_otrosMec2 = "Si";
                }
                else
                {
                    inicial.inicial_otrosMec2 = null;
                }
                if (ckb_solidos2.Checked == true)
                {
                    inicial.inicial_solidosQui2 = "Si";
                }
                else
                {
                    inicial.inicial_solidosQui2 = null;
                }
                if (ckb_polvos2.Checked == true)
                {
                    inicial.inicial_polvosQui2 = "Si";
                }
                else
                {
                    inicial.inicial_polvosQui2 = null;
                }
                if (ckb_humos2.Checked == true)
                {
                    inicial.inicial_humosQui2 = "Si";
                }
                else
                {
                    inicial.inicial_humosQui2 = null;
                }
                if (ckb_liquidos2.Checked == true)
                {
                    inicial.inicial_liquidosQui2 = "Si";
                }
                else
                {
                    inicial.inicial_liquidosQui2 = null;
                }
                if (ckb_vapores2.Checked == true)
                {
                    inicial.inicial_vaporesQui2 = "Si";
                }
                else
                {
                    inicial.inicial_vaporesQui2 = null;
                }
                if (ckb_aerosoles2.Checked == true)
                {
                    inicial.inicial_aerosolesQui2 = "Si";
                }
                else
                {
                    inicial.inicial_aerosolesQui2 = null;
                }
                if (ckb_neblinas2.Checked == true)
                {
                    inicial.inicial_neblinasQui2 = "Si";
                }
                else
                {
                    inicial.inicial_neblinasQui2 = null;
                }
                if (ckb_gaseosos2.Checked == true)
                {
                    inicial.inicial_gaseososQui2 = "Si";
                }
                else
                {
                    inicial.inicial_gaseososQui2 = null;
                }
                if (ckb_otrosQuimico2.Checked == true)
                {
                    inicial.inicial_otrosQui2 = "Si";
                }
                else
                {
                    inicial.inicial_otrosQui2 = null;
                }
                if (ckb_atrapmaquinas3.Checked == true)
                {
                    inicial.inicial_atraMaquinasMec3 = "Si";
                }
                else
                {
                    inicial.inicial_atraMaquinasMec3 = null;
                }
                if (ckb_atrapsuperficie3.Checked == true)
                {
                    inicial.inicial_atraSuperfiiesMec3 = "Si";
                }
                else
                {
                    inicial.inicial_atraSuperfiiesMec3 = null;
                }
                if (ckb_atrapobjetos3.Checked == true)
                {
                    inicial.inicial_atraObjetosMec3 = "Si";
                }
                else
                {
                    inicial.inicial_atraObjetosMec3 = null;
                }
                if (ckb_caidaobjetos3.Checked == true)
                {
                    inicial.inicial_caidaObjetosMec3 = "Si";
                }
                else
                {
                    inicial.inicial_caidaObjetosMec3 = null;
                }
                if (ckb_caidamisnivel3.Checked == true)
                {
                    inicial.inicial_caidaMisNivelMec3 = "Si";
                }
                else
                {
                    inicial.inicial_caidaMisNivelMec3 = null;
                }
                if (ckb_caidadifnivel3.Checked == true)
                {
                    inicial.inicial_caidaDifNivelMec3 = "Si";
                }
                else
                {
                    inicial.inicial_caidaDifNivelMec3 = null;
                }
                if (ckb_contaelectrico3.Checked == true)
                {
                    inicial.inicial_contactoElecMec3 = "Si";
                }
                else
                {
                    inicial.inicial_contactoElecMec3 = null;
                }
                if (ckb_contasuptrabajo3.Checked == true)
                {
                    inicial.inicial_conSuperTrabaMec3 = "Si";
                }
                else
                {
                    inicial.inicial_conSuperTrabaMec3 = null;
                }
                if (ckb_proyparticulas3.Checked == true)
                {
                    inicial.inicial_proPartiFragMec3 = "Si";
                }
                else
                {
                    inicial.inicial_proPartiFragMec3 = null;
                }
                if (ckb_proyefluidos3.Checked == true)
                {
                    inicial.inicial_proFluidosMec3 = "Si";
                }
                else
                {
                    inicial.inicial_proFluidosMec3 = null;
                }
                if (ckb_pinchazos3.Checked == true)
                {
                    inicial.inicial_pinchazosMec3 = "Si";
                }
                else
                {
                    inicial.inicial_pinchazosMec3 = null;
                }
                if (ckb_cortes3.Checked == true)
                {
                    inicial.inicial_cortesMec3 = "Si";
                }
                else
                {
                    inicial.inicial_cortesMec3 = null;
                }
                if (ckb_atroporvehiculos3.Checked == true)
                {
                    inicial.inicial_atropeVehiMec3 = "Si";
                }
                else
                {
                    inicial.inicial_atropeVehiMec3 = null;
                }
                if (ckb_choques3.Checked == true)
                {
                    inicial.inicial_coliVehiMec3 = "Si";
                }
                else
                {
                    inicial.inicial_coliVehiMec3 = null;
                }
                if (ckb_otrosMecanico3.Checked == true)
                {
                    inicial.inicial_otrosMec3 = "Si";
                }
                else
                {
                    inicial.inicial_otrosMec3 = null;
                }
                if (ckb_solidos3.Checked == true)
                {
                    inicial.inicial_solidosQui3 = "Si";
                }
                else
                {
                    inicial.inicial_solidosQui3 = null;
                }
                if (ckb_polvos3.Checked == true)
                {
                    inicial.inicial_polvosQui3 = "Si";
                }
                else
                {
                    inicial.inicial_polvosQui3 = null;
                }
                if (ckb_humos3.Checked == true)
                {
                    inicial.inicial_humosQui3 = "Si";
                }
                else
                {
                    inicial.inicial_humosQui3 = null;
                }
                if (ckb_liquidos3.Checked == true)
                {
                    inicial.inicial_liquidosQui3 = "Si";
                }
                else
                {
                    inicial.inicial_liquidosQui3 = null;
                }
                if (ckb_vapores3.Checked == true)
                {
                    inicial.inicial_vaporesQui3 = "Si";
                }
                else
                {
                    inicial.inicial_vaporesQui3 = null;
                }
                if (ckb_aerosoles3.Checked == true)
                {
                    inicial.inicial_aerosolesQui3 = "Si";
                }
                else
                {
                    inicial.inicial_aerosolesQui3 = null;
                }
                if (ckb_neblinas3.Checked == true)
                {
                    inicial.inicial_neblinasQui3 = "Si";
                }
                else
                {
                    inicial.inicial_neblinasQui3 = null;
                }
                if (ckb_gaseosos3.Checked == true)
                {
                    inicial.inicial_gaseososQui3 = "Si";
                }
                else
                {
                    inicial.inicial_gaseososQui3 = null;
                }
                if (ckb_otrosQuimico3.Checked == true)
                {
                    inicial.inicial_otrosQui3 = "Si";
                }
                else
                {
                    inicial.inicial_otrosQui3 = null;
                }
                if (ckb_atrapmaquinas4.Checked == true)
                {
                    inicial.inicial_atraMaquinasMec4 = "Si";
                }
                else
                {
                    inicial.inicial_atraMaquinasMec4 = null;
                }
                if (ckb_atrapsuperficie4.Checked == true)
                {
                    inicial.inicial_atraSuperfiiesMec4 = "Si";
                }
                else
                {
                    inicial.inicial_atraSuperfiiesMec4 = null;
                }
                if (ckb_atrapobjetos4.Checked == true)
                {
                    inicial.inicial_atraObjetosMec4 = "Si";
                }
                else
                {
                    inicial.inicial_atraObjetosMec4 = null;
                }
                if (ckb_caidaobjetos4.Checked == true)
                {
                    inicial.inicial_caidaObjetosMec4 = "Si";
                }
                else
                {
                    inicial.inicial_caidaObjetosMec4 = null;
                }
                if (ckb_caidamisnivel4.Checked == true)
                {
                    inicial.inicial_caidaMisNivelMec4 = "Si";
                }
                else
                {
                    inicial.inicial_caidaMisNivelMec4 = null;
                }
                if (ckb_caidadifnivel4.Checked == true)
                {
                    inicial.inicial_caidaDifNivelMec4 = "Si";
                }
                else
                {
                    inicial.inicial_caidaDifNivelMec4 = null;
                }
                if (ckb_contaelectrico4.Checked == true)
                {
                    inicial.inicial_contactoElecMec4 = "Si";
                }
                else
                {
                    inicial.inicial_contactoElecMec4 = null;
                }
                if (ckb_contasuptrabajo4.Checked == true)
                {
                    inicial.inicial_conSuperTrabaMec4 = "Si";
                }
                else
                {
                    inicial.inicial_conSuperTrabaMec4 = null;
                }
                if (ckb_proyparticulas4.Checked == true)
                {
                    inicial.inicial_proPartiFragMec4 = "Si";
                }
                else
                {
                    inicial.inicial_proPartiFragMec4 = null;
                }
                if (ckb_proyefluidos4.Checked == true)
                {
                    inicial.inicial_proFluidosMec4 = "Si";
                }
                else
                {
                    inicial.inicial_proFluidosMec4 = null;
                }
                if (ckb_pinchazos4.Checked == true)
                {
                    inicial.inicial_pinchazosMec4 = "Si";
                }
                else
                {
                    inicial.inicial_pinchazosMec4 = null;
                }
                if (ckb_cortes4.Checked == true)
                {
                    inicial.inicial_cortesMec4 = "Si";
                }
                else
                {
                    inicial.inicial_cortesMec4 = null;
                }
                if (ckb_atroporvehiculos4.Checked == true)
                {
                    inicial.inicial_atropeVehiMec4 = "Si";
                }
                else
                {
                    inicial.inicial_atropeVehiMec4 = null;
                }
                if (ckb_choques4.Checked == true)
                {
                    inicial.inicial_coliVehiMec4 = "Si";
                }
                else
                {
                    inicial.inicial_coliVehiMec4 = null;
                }
                if (ckb_otrosMecanico4.Checked == true)
                {
                    inicial.inicial_otrosMec4 = "Si";
                }
                else
                {
                    inicial.inicial_otrosMec4 = null;
                }
                if (ckb_solidos4.Checked == true)
                {
                    inicial.inicial_solidosQui4 = "Si";
                }
                else
                {
                    inicial.inicial_solidosQui4 = null;
                }
                if (ckb_polvos4.Checked == true)
                {
                    inicial.inicial_polvosQui4 = "Si";
                }
                else
                {
                    inicial.inicial_polvosQui4 = null;
                }
                if (ckb_humos4.Checked == true)
                {
                    inicial.inicial_humosQui4 = "Si";
                }
                else
                {
                    inicial.inicial_humosQui4 = null;
                }
                if (ckb_liquidos4.Checked == true)
                {
                    inicial.inicial_liquidosQui4 = "Si";
                }
                else
                {
                    inicial.inicial_liquidosQui4 = null;
                }
                if (ckb_vapores4.Checked == true)
                {
                    inicial.inicial_vaporesQui4 = "Si";
                }
                else
                {
                    inicial.inicial_vaporesQui4 = null;
                }
                if (ckb_aerosoles4.Checked == true)
                {
                    inicial.inicial_aerosolesQui4 = "Si";
                }
                else
                {
                    inicial.inicial_aerosolesQui4 = null;
                }
                if (ckb_neblinas4.Checked == true)
                {
                    inicial.inicial_neblinasQui4 = "Si";
                }
                else
                {
                    inicial.inicial_neblinasQui4 = null;
                }
                if (ckb_gaseosos4.Checked == true)
                {
                    inicial.inicial_gaseososQui4 = "Si";
                }
                else
                {
                    inicial.inicial_gaseososQui4 = null;
                }
                if (ckb_otrosQuimico4.Checked == true)
                {
                    inicial.inicial_otrosQui4 = "Si";
                }
                else
                {
                    inicial.inicial_otrosQui4 = null;
                }
                inicial.inicial_puestoTrabajo = txt_puestodetrabajo21.Text;
                inicial.inicial_actividades = txt_act21.Text;
                if (ckb_virus.Checked == true)
                {
                    inicial.inicial_virusBio = "Si";
                }
                else
                {
                    inicial.inicial_virusBio = null;
                }
                if (ckb_hongos.Checked == true)
                {
                    inicial.inicial_hongosBio = "Si";
                }
                else
                {
                    inicial.inicial_hongosBio = null;
                }
                if (ckb_bacterias.Checked == true)
                {
                    inicial.inicial_bacteriasBio = "Si";
                }
                else
                {
                    inicial.inicial_bacteriasBio = null;
                }
                if (ckb_parasitos.Checked == true)
                {
                    inicial.inicial_parasitosBio = "Si";
                }
                else
                {
                    inicial.inicial_parasitosBio = null;
                }
                if (ckb_expoavectores.Checked == true)
                {
                    inicial.inicial_expVectBio = "Si";
                }
                else
                {
                    inicial.inicial_expVectBio = null;
                }
                if (ckb_expoanimselvaticos.Checked == true)
                {
                    inicial.inicial_expAniSelvaBio = "Si";
                }
                else
                {
                    inicial.inicial_expAniSelvaBio = null;
                }
                if (ckb_otrosBiologico.Checked == true)
                {
                    inicial.inicial_otrosBio = "Si";
                }
                else
                {
                    inicial.inicial_otrosBio = null;
                }
                if (ckb_manmanualcargas.Checked == true)
                {
                    inicial.inicial_maneManCarErg = "Si";
                }
                else
                {
                    inicial.inicial_maneManCarErg = null;
                }
                if (ckb_movrepetitivo.Checked == true)
                {
                    inicial.inicial_movRepeErg = "Si";
                }
                else
                {
                    inicial.inicial_movRepeErg = null;
                }
                if (ckb_postforzadas.Checked == true)
                {
                    inicial.inicial_posForzaErg = "Si";
                }
                else
                {
                    inicial.inicial_posForzaErg = null;
                }
                if (ckb_trabajopvd.Checked == true)
                {
                    inicial.inicial_trabPvdErg = "Si";
                }
                else
                {
                    inicial.inicial_trabPvdErg = null;
                }
                if (ckb_otrosErgonomico.Checked == true)
                {
                    inicial.inicial_otrosErg = "Si";
                }
                else
                {
                    inicial.inicial_otrosErg = null;
                }
                inicial.inicial_puestoTrabajo2 = txt_puestodetrabajo22.Text;
                inicial.inicial_actividades2 = txt_act22.Text;
                if (ckb_virus2.Checked == true)
                {
                    inicial.inicial_virusBio2 = "Si";
                }
                else
                {
                    inicial.inicial_virusBio2 = null;
                }
                if (ckb_hongos2.Checked == true)
                {
                    inicial.inicial_hongosBio2 = "Si";
                }
                else
                {
                    inicial.inicial_hongosBio2 = null;
                }
                if (ckb_bacterias2.Checked == true)
                {
                    inicial.inicial_bacteriasBio2 = "Si";
                }
                else
                {
                    inicial.inicial_bacteriasBio2 = null;
                }
                if (ckb_parasitos2.Checked == true)
                {
                    inicial.inicial_parasitosBio2 = "Si";
                }
                else
                {
                    inicial.inicial_parasitosBio2 = null;
                }
                if (ckb_expoavectores2.Checked == true)
                {
                    inicial.inicial_expVectBio2 = "Si";
                }
                else
                {
                    inicial.inicial_expVectBio2 = null;
                }
                if (ckb_expoanimselvaticos2.Checked == true)
                {
                    inicial.inicial_expAniSelvaBio2 = "Si";
                }
                else
                {
                    inicial.inicial_expAniSelvaBio2 = null;
                }
                if (ckb_otrosBiologico2.Checked == true)
                {
                    inicial.inicial_otrosBio2 = "Si";
                }
                else
                {
                    inicial.inicial_otrosBio2 = null;
                }
                if (ckb_manmanualcargas2.Checked == true)
                {
                    inicial.inicial_maneManCarErg2 = "Si";
                }
                else
                {
                    inicial.inicial_maneManCarErg2 = null;
                }
                if (ckb_movrepetitivo2.Checked == true)
                {
                    inicial.inicial_movRepeErg2 = "Si";
                }
                else
                {
                    inicial.inicial_movRepeErg2 = null;
                }
                if (ckb_postforzadas2.Checked == true)
                {
                    inicial.inicial_posForzaErg2 = "Si";
                }
                else
                {
                    inicial.inicial_posForzaErg2 = null;
                }
                if (ckb_trabajopvd2.Checked == true)
                {
                    inicial.inicial_trabPvdErg2 = "Si";
                }
                else
                {
                    inicial.inicial_trabPvdErg2 = null;
                }
                if (ckb_otrosErgonomico2.Checked == true)
                {
                    inicial.inicial_otrosErg2 = "Si";
                }
                else
                {
                    inicial.inicial_otrosErg2 = null;
                }
                inicial.inicial_puestoTrabajo3 = txt_puestodetrabajo23.Text;
                inicial.inicial_actividades3 = txt_act23.Text;
                if (ckb_virus3.Checked == true)
                {
                    inicial.inicial_virusBio3 = "Si";
                }
                else
                {
                    inicial.inicial_virusBio3 = null;
                }
                if (ckb_hongos3.Checked == true)
                {
                    inicial.inicial_hongosBio3 = "Si";
                }
                else
                {
                    inicial.inicial_hongosBio3 = null;
                }
                if (ckb_bacterias3.Checked == true)
                {
                    inicial.inicial_bacteriasBio3 = "Si";
                }
                else
                {
                    inicial.inicial_bacteriasBio3 = null;
                }
                if (ckb_parasitos3.Checked == true)
                {
                    inicial.inicial_parasitosBio3 = "Si";
                }
                else
                {
                    inicial.inicial_parasitosBio3 = null;
                }
                if (ckb_expoavectores3.Checked == true)
                {
                    inicial.inicial_expVectBio3 = "Si";
                }
                else
                {
                    inicial.inicial_expVectBio3 = null;
                }
                if (ckb_expoanimselvaticos3.Checked == true)
                {
                    inicial.inicial_expAniSelvaBio3 = "Si";
                }
                else
                {
                    inicial.inicial_expAniSelvaBio3 = null;
                }
                if (ckb_otrosBiologico3.Checked == true)
                {
                    inicial.inicial_otrosBio3 = "Si";
                }
                else
                {
                    inicial.inicial_otrosBio3 = null;
                }
                if (ckb_manmanualcargas3.Checked == true)
                {
                    inicial.inicial_maneManCarErg3 = "Si";
                }
                else
                {
                    inicial.inicial_maneManCarErg3 = null;
                }
                if (ckb_movrepetitivo3.Checked == true)
                {
                    inicial.inicial_movRepeErg3 = "Si";
                }
                else
                {
                    inicial.inicial_movRepeErg3 = null;
                }
                if (ckb_postforzadas3.Checked == true)
                {
                    inicial.inicial_posForzaErg3 = "Si";
                }
                else
                {
                    inicial.inicial_posForzaErg3 = null;
                }
                if (ckb_trabajopvd3.Checked == true)
                {
                    inicial.inicial_trabPvdErg3 = "Si";
                }
                else
                {
                    inicial.inicial_trabPvdErg3 = null;
                }
                if (ckb_otrosErgonomico3.Checked == true)
                {
                    inicial.inicial_otrosErg3 = "Si";
                }
                else
                {
                    inicial.inicial_otrosErg3 = null;
                }
                inicial.inicial_puestoTrabajo4 = txt_puestodetrabajo24.Text;
                inicial.inicial_actividades4 = txt_act24.Text;
                if (ckb_virus4.Checked == true)
                {
                    inicial.inicial_virusBio4 = "Si";
                }
                else
                {
                    inicial.inicial_virusBio4 = null;
                }
                if (ckb_hongos4.Checked == true)
                {
                    inicial.inicial_hongosBio4 = "Si";
                }
                else
                {
                    inicial.inicial_hongosBio4 = null;
                }
                if (ckb_bacterias4.Checked == true)
                {
                    inicial.inicial_bacteriasBio4 = "Si";
                }
                else
                {
                    inicial.inicial_bacteriasBio4 = null;
                }
                if (ckb_parasitos4.Checked == true)
                {
                    inicial.inicial_parasitosBio4 = "Si";
                }
                else
                {
                    inicial.inicial_parasitosBio4 = null;
                }
                if (ckb_expoavectores4.Checked == true)
                {
                    inicial.inicial_expVectBio4 = "Si";
                }
                else
                {
                    inicial.inicial_expVectBio4 = null;
                }
                if (ckb_expoanimselvaticos4.Checked == true)
                {
                    inicial.inicial_expAniSelvaBio4 = "Si";
                }
                else
                {
                    inicial.inicial_expAniSelvaBio4 = null;
                }
                if (ckb_otrosBiologico4.Checked == true)
                {
                    inicial.inicial_otrosBio4 = "Si";
                }
                else
                {
                    inicial.inicial_otrosBio4 = null;
                }
                if (ckb_manmanualcargas4.Checked == true)
                {
                    inicial.inicial_maneManCarErg4 = "Si";
                }
                else
                {
                    inicial.inicial_maneManCarErg4 = null;
                }
                if (ckb_movrepetitivo4.Checked == true)
                {
                    inicial.inicial_movRepeErg4 = "Si";
                }
                else
                {
                    inicial.inicial_movRepeErg4 = null;
                }
                if (ckb_postforzadas4.Checked == true)
                {
                    inicial.inicial_posForzaErg4 = "Si";
                }
                else
                {
                    inicial.inicial_posForzaErg4 = null;
                }
                if (ckb_trabajopvd4.Checked == true)
                {
                    inicial.inicial_trabPvdErg4 = "Si";
                }
                else
                {
                    inicial.inicial_trabPvdErg4 = null;
                }
                if (ckb_otrosErgonomico4.Checked == true)
                {
                    inicial.inicial_otrosErg4 = "Si";
                }
                else
                {
                    inicial.inicial_otrosErg4 = null;
                }
                if (ckb_montrabajo.Checked == true)
                {
                    inicial.inicial_monoTrabPsi = "Si";
                }
                else
                {
                    inicial.inicial_monoTrabPsi = null;
                }
                if (ckb_sobrecargalaboral.Checked == true)
                {
                    inicial.inicial_sobrecarLabPsi = "Si";
                }
                else
                {
                    inicial.inicial_sobrecarLabPsi = null;
                }
                if (ckb_minustarea.Checked == true)
                {
                    inicial.inicial_minuTareaPsi = "Si";
                }
                else
                {
                    inicial.inicial_minuTareaPsi = null;
                }
                if (ckb_altarespon.Checked == true)
                {
                    inicial.inicial_altaResponPsi = "Si";
                }
                else
                {
                    inicial.inicial_altaResponPsi = null;
                }
                if (ckb_automadesiciones.Checked == true)
                {
                    inicial.inicial_autoTomaDesiPsi = "Si";
                }
                else
                {
                    inicial.inicial_autoTomaDesiPsi = null;
                }
                if (ckb_supyestdireficiente.Checked == true)
                {
                    inicial.inicial_supEstDirecDefiPsi = "Si";
                }
                else
                {
                    inicial.inicial_supEstDirecDefiPsi = null;
                }
                if (ckb_conflictorol.Checked == true)
                {
                    inicial.inicial_conflicRolPsi = "Si";
                }
                else
                {
                    inicial.inicial_conflicRolPsi = null;
                }
                if (ckb_faltaclarfunciones.Checked == true)
                {
                    inicial.inicial_falClariFunPsi = "Si";
                }
                else
                {
                    inicial.inicial_falClariFunPsi = null;
                }
                if (ckb_incorrdistrabajo.Checked == true)
                {
                    inicial.inicial_incoDistriTrabPsi = "Si";
                }
                else
                {
                    inicial.inicial_incoDistriTrabPsi = null;
                }
                if (ckb_turnorotat.Checked == true)
                {
                    inicial.inicial_turnosRotaPsi = "Si";
                }
                else
                {
                    inicial.inicial_turnosRotaPsi = null;
                }
                if (ckb_relacinterpersonales.Checked == true)
                {
                    inicial.inicial_relInterperPsi = "Si";
                }
                else
                {
                    inicial.inicial_relInterperPsi = null;
                }
                if (ckb_inestalaboral.Checked == true)
                {
                    inicial.inicial_inesLabPsi = "Si";
                }
                else
                {
                    inicial.inicial_inesLabPsi = null;
                }
                if (ckb_otrosPsicosocial.Checked == true)
                {
                    inicial.inicial_otrosPsi = "Si";
                }
                else
                {
                    inicial.inicial_otrosPsi = null;
                }
                inicial.inicial_medPreventivas = txt_medpreventivas.Text;
                if (ckb_montrabajo2.Checked == true)
                {
                    inicial.inicial_monoTrabPsi2 = "Si";
                }
                else
                {
                    inicial.inicial_monoTrabPsi2 = null;
                }
                if (ckb_sobrecargalaboral2.Checked == true)
                {
                    inicial.inicial_sobrecarLabPsi2 = "Si";
                }
                else
                {
                    inicial.inicial_sobrecarLabPsi2 = null;
                }
                if (ckb_minustarea2.Checked == true)
                {
                    inicial.inicial_minuTareaPsi2 = "Si";
                }
                else
                {
                    inicial.inicial_minuTareaPsi2 = null;
                }
                if (ckb_altarespon2.Checked == true)
                {
                    inicial.inicial_altaResponPsi2 = "Si";
                }
                else
                {
                    inicial.inicial_altaResponPsi2 = null;
                }
                if (ckb_automadesiciones2.Checked == true)
                {
                    inicial.inicial_autoTomaDesiPsi2 = "Si";
                }
                else
                {
                    inicial.inicial_autoTomaDesiPsi2 = null;
                }
                if (ckb_supyestdireficiente2.Checked == true)
                {
                    inicial.inicial_supEstDirecDefiPsi2 = "Si";
                }
                else
                {
                    inicial.inicial_supEstDirecDefiPsi2 = null;
                }
                if (ckb_conflictorol2.Checked == true)
                {
                    inicial.inicial_conflicRolPsi2 = "Si";
                }
                else
                {
                    inicial.inicial_conflicRolPsi2 = null;
                }
                if (ckb_faltaclarfunciones2.Checked == true)
                {
                    inicial.inicial_falClariFunPsi2 = "Si";
                }
                else
                {
                    inicial.inicial_falClariFunPsi2 = null;
                }
                if (ckb_incorrdistrabajo2.Checked == true)
                {
                    inicial.inicial_incoDistriTrabPsi2 = "Si";
                }
                else
                {
                    inicial.inicial_incoDistriTrabPsi2 = null;
                }
                if (ckb_turnorotat2.Checked == true)
                {
                    inicial.inicial_turnosRotaPsi2 = "Si";
                }
                else
                {
                    inicial.inicial_turnosRotaPsi2 = null;
                }
                if (ckb_relacinterpersonales2.Checked == true)
                {
                    inicial.inicial_relInterperPsi2 = "Si";
                }
                else
                {
                    inicial.inicial_relInterperPsi2 = null;
                }
                if (ckb_inestalaboral2.Checked == true)
                {
                    inicial.inicial_inesLabPsi2 = "Si";
                }
                else
                {
                    inicial.inicial_inesLabPsi2 = null;
                }
                if (ckb_otrosPsicosocial2.Checked == true)
                {
                    inicial.inicial_otrosPsi2 = "Si";
                }
                else
                {
                    inicial.inicial_otrosPsi2 = null;
                }
                inicial.inicial_medPreventivas2 = txt_medpreventivas2.Text;
                if (ckb_montrabajo3.Checked == true)
                {
                    inicial.inicial_monoTrabPsi3 = "Si";
                }
                else
                {
                    inicial.inicial_monoTrabPsi3 = null;
                }
                if (ckb_sobrecargalaboral3.Checked == true)
                {
                    inicial.inicial_sobrecarLabPsi3 = "Si";
                }
                else
                {
                    inicial.inicial_sobrecarLabPsi3 = null;
                }
                if (ckb_minustarea3.Checked == true)
                {
                    inicial.inicial_minuTareaPsi3 = "Si";
                }
                else
                {
                    inicial.inicial_minuTareaPsi3 = null;
                }
                if (ckb_altarespon3.Checked == true)
                {
                    inicial.inicial_altaResponPsi3 = "Si";
                }
                else
                {
                    inicial.inicial_altaResponPsi3 = null;
                }
                if (ckb_automadesiciones3.Checked == true)
                {
                    inicial.inicial_autoTomaDesiPsi3 = "Si";
                }
                else
                {
                    inicial.inicial_autoTomaDesiPsi3 = null;
                }
                if (ckb_supyestdireficiente3.Checked == true)
                {
                    inicial.inicial_supEstDirecDefiPsi3 = "Si";
                }
                else
                {
                    inicial.inicial_supEstDirecDefiPsi3 = null;
                }
                if (ckb_conflictorol3.Checked == true)
                {
                    inicial.inicial_conflicRolPsi3 = "Si";
                }
                else
                {
                    inicial.inicial_conflicRolPsi3 = null;
                }
                if (ckb_faltaclarfunciones3.Checked == true)
                {
                    inicial.inicial_falClariFunPsi3 = "Si";
                }
                else
                {
                    inicial.inicial_falClariFunPsi3 = null;
                }
                if (ckb_incorrdistrabajo3.Checked == true)
                {
                    inicial.inicial_incoDistriTrabPsi3 = "Si";
                }
                else
                {
                    inicial.inicial_incoDistriTrabPsi3 = null;
                }
                if (ckb_turnorotat3.Checked == true)
                {
                    inicial.inicial_turnosRotaPsi3 = "Si";
                }
                else
                {
                    inicial.inicial_turnosRotaPsi3 = null;
                }
                if (ckb_relacinterpersonales3.Checked == true)
                {
                    inicial.inicial_relInterperPsi3 = "Si";
                }
                else
                {
                    inicial.inicial_relInterperPsi3 = null;
                }
                if (ckb_inestalaboral3.Checked == true)
                {
                    inicial.inicial_inesLabPsi3 = "Si";
                }
                else
                {
                    inicial.inicial_inesLabPsi3 = null;
                }
                if (ckb_otrosPsicosocial3.Checked == true)
                {
                    inicial.inicial_otrosPsi3 = "Si";
                }
                else
                {
                    inicial.inicial_otrosPsi3 = null;
                }
                inicial.inicial_medPreventivas3 = txt_medpreventivas3.Text;
                if (ckb_montrabajo4.Checked == true)
                {
                    inicial.inicial_monoTrabPsi4 = "Si";
                }
                else
                {
                    inicial.inicial_monoTrabPsi4 = null;
                }
                if (ckb_sobrecargalaboral4.Checked == true)
                {
                    inicial.inicial_sobrecarLabPsi4 = "Si";
                }
                else
                {
                    inicial.inicial_sobrecarLabPsi4 = null;
                }
                if (ckb_minustarea4.Checked == true)
                {
                    inicial.inicial_minuTareaPsi4 = "Si";
                }
                else
                {
                    inicial.inicial_minuTareaPsi4 = null;
                }
                if (ckb_altarespon4.Checked == true)
                {
                    inicial.inicial_altaResponPsi4 = "Si";
                }
                else
                {
                    inicial.inicial_altaResponPsi4 = null;
                }
                if (ckb_automadesiciones4.Checked == true)
                {
                    inicial.inicial_autoTomaDesiPsi4 = "Si";
                }
                else
                {
                    inicial.inicial_autoTomaDesiPsi4 = null;
                }
                if (ckb_supyestdireficiente4.Checked == true)
                {
                    inicial.inicial_supEstDirecDefiPsi4 = "Si";
                }
                else
                {
                    inicial.inicial_supEstDirecDefiPsi4 = null;
                }
                if (ckb_conflictorol4.Checked == true)
                {
                    inicial.inicial_conflicRolPsi4 = "Si";
                }
                else
                {
                    inicial.inicial_conflicRolPsi4 = null;
                }
                if (ckb_faltaclarfunciones4.Checked == true)
                {
                    inicial.inicial_falClariFunPsi4 = "Si";
                }
                else
                {
                    inicial.inicial_falClariFunPsi4 = null;
                }
                if (ckb_incorrdistrabajo4.Checked == true)
                {
                    inicial.inicial_incoDistriTrabPsi4 = "Si";
                }
                else
                {
                    inicial.inicial_incoDistriTrabPsi4 = null;
                }
                if (ckb_turnorotat4.Checked == true)
                {
                    inicial.inicial_turnosRotaPsi4 = "Si";
                }
                else
                {
                    inicial.inicial_turnosRotaPsi4 = null;
                }
                if (ckb_relacinterpersonales4.Checked == true)
                {
                    inicial.inicial_relInterperPsi4 = "Si";
                }
                else
                {
                    inicial.inicial_relInterperPsi4 = null;
                }
                if (ckb_inestalaboral4.Checked == true)
                {
                    inicial.inicial_inesLabPsi4 = "Si";
                }
                else
                {
                    inicial.inicial_inesLabPsi4 = null;
                }
                if (ckb_otrosPsicosocial4.Checked == true)
                {
                    inicial.inicial_otrosPsi4 = "Si";
                }
                else
                {
                    inicial.inicial_otrosPsi4 = null;
                }
                inicial.inicial_medPreventivas4 = txt_medpreventivas4.Text;
                inicial.inicial_descripActExtLab = txt_descrextralaborales.Text;
                inicial.inicial_descripEnfActual = txt_enfermedadactualinicial.Text;
                if (ckb_pielanexos.Checked == true)
                {
                    inicial.inicial_pielAnexos = "Si";
                }
                else
                {
                    inicial.inicial_pielAnexos = null;
                }
                if (ckb_respiratorio.Checked == true)
                {
                    inicial.inicial_respiratorio = "Si";
                }
                else
                {
                    inicial.inicial_respiratorio = null;
                }
                if (ckb_digestivo.Checked == true)
                {
                    inicial.inicial_digestivo = "Si";
                }
                else
                {
                    inicial.inicial_digestivo = null;
                }
                if (ckb_musculosesqueleticos.Checked == true)
                {
                    inicial.inicial_muscEsqueletico = "Si";
                }
                else
                {
                    inicial.inicial_muscEsqueletico = null;
                }
                if (ckb_hemolinfatico.Checked == true)
                {
                    inicial.inicial_hemoLimfa = "Si";
                }
                else
                {
                    inicial.inicial_hemoLimfa = null;
                }
                if (ckb_organossentidos.Checked == true)
                {
                    inicial.inicial_orgSentidos = "Si";
                }
                else
                {
                    inicial.inicial_orgSentidos = null;
                }
                if (ckb_cardiovascular.Checked == true)
                {
                    inicial.inicial_cardVascular = "Si";
                }
                else
                {
                    inicial.inicial_cardVascular = null;
                }
                if (ckb_genitourinario.Checked == true)
                {
                    inicial.inicial_genUrinario = "Si";
                }
                else
                {
                    inicial.inicial_genUrinario = null;
                }
                if (ckb_endocrino.Checked == true)
                {
                    inicial.inicial_endocrino = "Si";
                }
                else
                {
                    inicial.inicial_endocrino = null;
                }
                if (ckb_nervioso.Checked == true)
                {
                    inicial.inicial_nervioso = "Si";
                }
                else
                {
                    inicial.inicial_nervioso = null;
                }
                inicial.inicial_descripRevActOrgSis = txt_descrorganosysistemas.Text;

                inicial.inicial_preArterial = txt_preArterial.Text;
                inicial.inicial_temperatura = txt_temperatura.Text;
                inicial.inicial_frecCardiacan = txt_freCardica.Text;
                inicial.inicial_satOxigenon = txt_satOxigeno.Text;
                inicial.inicial_frecRespiratorian = txt_freRespiratoria.Text;
                inicial.inicial_peson = txt_peso.Text;
                inicial.inicial_tallan = txt_talla.Text;
                inicial.inicial_indMasCorporaln = txt_indMasCorporal.Text;
                inicial.inicial_perAbdominaln = txt_perAbdominal.Text;

                if (ckb_cicatrices.Checked == true)
                {
                    inicial.inicial_cicatricesPiel = "Si";
                }
                else
                {
                    inicial.inicial_cicatricesPiel = null;
                }
                if (ckb_auditivoexterno.Checked == true)
                {
                    inicial.inicial_cAudiExtreOido = "Si";
                }
                else
                {
                    inicial.inicial_cAudiExtreOido = null;
                }
                if (ckb_tabique.Checked == true)
                {
                    inicial.inicial_tabiqueNariz = "Si";
                }
                else
                {
                    inicial.inicial_tabiqueNariz = null;
                }
                if (ckb_pulmones.Checked == true)
                {
                    inicial.inicial_pulmonesTorax2 = "Si";
                }
                else
                {
                    inicial.inicial_pulmonesTorax2 = null;
                }
                if (ckb_pelvis.Checked == true)
                {
                    inicial.inicial_pelvisPelvis = "Si";
                }
                else
                {
                    inicial.inicial_pelvisPelvis = null;
                }
                if (ckb_tatuajes.Checked == true)
                {
                    inicial.inicial_tatuajesPiel = "Si";
                }
                else
                {
                    inicial.inicial_tatuajesPiel = null;
                }
                if (ckb_pabellon.Checked == true)
                {
                    inicial.inicial_pabellonOido = "Si";
                }
                else
                {
                    inicial.inicial_pabellonOido = null;
                }
                if (ckb_cornetes.Checked == true)
                {
                    inicial.inicial_cornetesNariz = "Si";
                }
                else
                {
                    inicial.inicial_cornetesNariz = null;
                }
                if (ckb_parrillacostal.Checked == true)
                {
                    inicial.inicial_parriCostalTorax2 = "Si";
                }
                else
                {
                    inicial.inicial_parriCostalTorax2 = null;
                }
                if (ckb_genitales.Checked == true)
                {
                    inicial.inicial_genitalesPelvis = "Si";
                }
                else
                {
                    inicial.inicial_genitalesPelvis = null;
                }
                if (ckb_pielyfaneras.Checked == true)
                {
                    inicial.inicial_pielFacerasPiel = "Si";
                }
                else
                {
                    inicial.inicial_pielFacerasPiel = null;
                }
                if (ckb_timpanos.Checked == true)
                {
                    inicial.inicial_timpanosOido = "Si";
                }
                else
                {
                    inicial.inicial_timpanosOido = null;
                }
                if (ckb_mucosa.Checked == true)
                {
                    inicial.inicial_mucosasNariz = "Si";
                }
                else
                {
                    inicial.inicial_mucosasNariz = null;
                }
                if (ckb_visceras.Checked == true)
                {
                    inicial.inicial_viscerasAbdomen = "Si";
                }
                else
                {
                    inicial.inicial_viscerasAbdomen = null;
                }
                if (ckb_vascular.Checked == true)
                {
                    inicial.inicial_vascularExtre = "Si";
                }
                else
                {
                    inicial.inicial_vascularExtre = null;
                }
                if (ckb_parpados.Checked == true)
                {
                    inicial.inicial_parpadosOjos = "Si";
                }
                else
                {
                    inicial.inicial_parpadosOjos = null;
                }
                if (ckb_labios.Checked == true)
                {
                    inicial.inicial_labiosOroFa = "Si";
                }
                else
                {
                    inicial.inicial_labiosOroFa = null;
                }
                if (ckb_senosparanasales.Checked == true)
                {
                    inicial.inicial_senosParanaNariz = "Si";
                }
                else
                {
                    inicial.inicial_senosParanaNariz = null;
                }
                if (ckb_paredabdominal.Checked == true)
                {
                    inicial.inicial_paredAbdomiAbdomen = "Si";
                }
                else
                {
                    inicial.inicial_paredAbdomiAbdomen = null;
                }
                if (ckb_miembrosuperiores.Checked == true)
                {
                    inicial.inicial_miemSupeExtre = "Si";
                }
                else
                {
                    inicial.inicial_miemSupeExtre = null;
                }
                if (ckb_conjuntivas.Checked == true)
                {
                    inicial.inicial_conjuntuvasOjos = "Si";
                }
                else
                {
                    inicial.inicial_conjuntuvasOjos = null;
                }
                if (ckb_lengua.Checked == true)
                {
                    inicial.inicial_lenguaOroFa = "Si";
                }
                else
                {
                    inicial.inicial_lenguaOroFa = null;
                }
                if (ckb_tiroides.Checked == true)
                {
                    inicial.inicial_tiroiMasasCuello = "Si";
                }
                else
                {
                    inicial.inicial_tiroiMasasCuello = null;
                }
                if (ckb_flexibilidad.Checked == true)
                {
                    inicial.inicial_flexibilidadColumna = "Si";
                }
                else
                {
                    inicial.inicial_flexibilidadColumna = null;
                }
                if (ckb_miembrosinferiores.Checked == true)
                {
                    inicial.inicial_miemInfeExtre = "Si";
                }
                else
                {
                    inicial.inicial_miemInfeExtre = null;
                }
                if (ckb_pupilas.Checked == true)
                {
                    inicial.inicial_pupilasOjos = "Si";
                }
                else
                {
                    inicial.inicial_pupilasOjos = null;
                }
                if (ckb_faringe.Checked == true)
                {
                    inicial.inicial_faringeOroFa = "Si";
                }
                else
                {
                    inicial.inicial_faringeOroFa = null;
                }
                if (ckb_movilidad.Checked == true)
                {
                    inicial.inicial_movilidadCuello = "Si";
                }
                else
                {
                    inicial.inicial_movilidadCuello = null;
                }
                if (ckb_desviacion.Checked == true)
                {
                    inicial.inicial_desviacionColumna = "Si";
                }
                else
                {
                    inicial.inicial_desviacionColumna = null;
                }
                if (ckb_fuerza.Checked == true)
                {
                    inicial.inicial_fuerzaNeuro = "Si";
                }
                else
                {
                    inicial.inicial_fuerzaNeuro = null;
                }
                if (ckb_cornea.Checked == true)
                {
                    inicial.inicial_corneaOjos = "Si";
                }
                else
                {
                    inicial.inicial_corneaOjos = null;
                }
                if (ckb_amigdalas.Checked == true)
                {
                    inicial.inicial_amigdalasOroFa = "Si";
                }
                else
                {
                    inicial.inicial_amigdalasOroFa = null;
                }
                if (ckb_mamas.Checked == true)
                {
                    inicial.inicial_mamasTorax = "Si";
                }
                else
                {
                    inicial.inicial_mamasTorax = null;
                }
                if (ckb_sensibilidad.Checked == true)
                {
                    inicial.inicial_sensibiNeuro = "Si";
                }
                else
                {
                    inicial.inicial_sensibiNeuro = null;
                }
                if (ckb_motilidad.Checked == true)
                {
                    inicial.inicial_motilidadOjos = "Si";
                }
                else
                {
                    inicial.inicial_motilidadOjos = null;
                }
                if (ckb_dentadura.Checked == true)
                {
                    inicial.inicial_dentaduraOroFa = "Si";
                }
                else
                {
                    inicial.inicial_dentaduraOroFa = null;
                }
                if (ckb_corazon.Checked == true)
                {
                    inicial.inicial_corazonTorax = "Si";
                }
                else
                {
                    inicial.inicial_corazonTorax = null;
                }
                if (ckb_dolor.Checked == true)
                {
                    inicial.inicial_dolorColumna = "Si";
                }
                else
                {
                    inicial.inicial_dolorColumna = null;
                }
                if (ckb_marcha.Checked == true)
                {
                    inicial.inicial_marchaNeuro = "Si";
                }
                else
                {
                    inicial.inicial_marchaNeuro = null;
                }
                if (ckb_reflejos.Checked == true)
                {
                    inicial.inicial_refleNeuro = "Si";
                }
                else
                {
                    inicial.inicial_refleNeuro = null;
                }
                inicial.inicial_observaExaFisRegInicial = txt_obervexamenfisicoregional.Text;
                inicial.inicial_examen = txt_examen.Text;
                inicial.inicial_fecha = txt_fechaexamen.Text;
                inicial.inicial_resultados = txt_resultadoexamen.Text;
                inicial.inicial_examen2 = txt_examen2.Text;
                inicial.inicial_fecha2 = txt_fechaexamen2.Text;
                inicial.inicial_resultados2 = txt_resultadoexamen2.Text;
                inicial.inicial_examen3 = txt_examen3.Text;
                inicial.inicial_fecha3 = txt_fechaexamen3.Text;
                inicial.inicial_resultados3 = txt_resultadoexamen3.Text;
                inicial.inicial_examen4 = txt_examen4.Text;
                inicial.inicial_fecha4 = txt_fechaexamen4.Text;
                inicial.inicial_resultados4 = txt_resultadoexamen4.Text;
                inicial.inicial_observacionesResExaGenEspRiesTrabajo = txt_observacionexamen.Text;

                inicial.inicial_descripciondiagnostico = txt_descripdiagnostico.Text;
                inicial.inicial_cie = txt_cie.Text;
                if (ckb_pre.Checked == true)
                {
                    inicial.inicial_pre = "Si";
                }
                else
                {
                    inicial.inicial_pre = null;
                }
                if (ckb_def.Checked == true)
                {
                    inicial.inicial_def = "Si";
                }
                else
                {
                    inicial.inicial_def = null;
                }
                inicial.inicial_descripcioninicialnostico2 = txt_descripdiagnostico2.Text;
                inicial.inicial_cie2 = txt_cie2.Text;
                if (ckb_pre2.Checked == true)
                {
                    inicial.inicial_pre2 = "Si";
                }
                else
                {
                    inicial.inicial_pre2 = null;
                }
                if (ckb_def2.Checked == true)
                {
                    inicial.inicial_def2 = "Si";
                }
                else
                {
                    inicial.inicial_def2 = null;
                }
                inicial.inicial_descripcioninicialnostico3 = txt_descripdiagnostico3.Text;
                inicial.inicial_cie3 = txt_cie3.Text;
                if (ckb_pre3.Checked == true)
                {
                    inicial.inicial_pre3 = "Si";
                }
                else
                {
                    inicial.inicial_pre3 = null;
                }
                if (ckb_def3.Checked == true)
                {
                    inicial.inicial_def3 = "Si";
                }
                else
                {
                    inicial.inicial_def3 = null;
                }
                if (ckb_apto.Checked == true)
                {
                    inicial.inicial_apto = "Si";
                }
                else
                {
                    inicial.inicial_apto = null;
                }
                if (ckb_aptoobservacion.Checked == true)
                {
                    inicial.inicial_aptoObserva = "Si";
                }
                else
                {
                    inicial.inicial_aptoObserva = null;
                }
                if (ckb_aptolimitacion.Checked == true)
                {
                    inicial.inicial_NoApto = "Si";
                }
                else
                {
                    inicial.inicial_NoApto = null;
                }
                if (ckb_noapto.Checked == true)
                {
                    inicial.inicial_NoApto = "Si";
                }
                else
                {
                    inicial.inicial_NoApto = null;
                }
                inicial.inicial_ObservAptMed = txt_observacionaptitud.Text;
                inicial.inicial_LimitAptMed = txt_limitacionaptitud.Text;
                inicial.inicial_descripcionRecTra = txt_descripciontratamiento.Text;
                inicial.inicial_fecha_hora = txt_fechahora.Text;
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
                    ModificarInicial(inicial);
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

        protected void txt_talla_TextChanged(object sender, EventArgs e)
        {
            if (txt_talla.Text != "")
            {
                txt_peso.Enabled = true;
            }
        }

        protected void txt_peso_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int peso = Convert.ToInt32(txt_peso.Text);
                decimal talla = Convert.ToDecimal(txt_talla.Text);
                decimal toTalla = (talla * talla) / 10000;
                decimal calculo = peso / toTalla;
                calculo = decimal.Round(calculo, 2, MidpointRounding.AwayFromZero);

                txt_indMasCorporal.Text = calculo.ToString();

            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Llenar primero la talla')", true);
                txt_peso.Text = "";
                txt_talla.Focus();
            }
        }   
    }
}