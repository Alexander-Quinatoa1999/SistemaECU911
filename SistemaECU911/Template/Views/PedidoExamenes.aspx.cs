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
    public partial class PedidoExamenes : System.Web.UI.Page
    {

        DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        private Tbl_Personas per = new Tbl_Personas();

        private Tbl_PedidoExamenes pedexa = new Tbl_PedidoExamenes();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["cod"] != null)
                {
                    int codigo = Convert.ToInt32(Request["cod"]);
                    pedexa = CN_PedidoExamenes.ObtenerPedidoExamenesPorId(codigo);
                    int personasid = Convert.ToInt32(pedexa.Per_id.ToString());
                    per = CN_HistorialMedico.ObtenerPersonasxId(personasid);

                    btn_guardar.Text = "Actualizar";

                    if (per != null)
                    {
                        //A
                        txt_priNombre.Text = per.Per_priNombre.ToString();
                        txt_segNombre.Text = per.Per_segNombre.ToString();
                        txt_priApellido.Text = per.Per_priApellido.ToString();
                        txt_segApellido.Text = per.Per_segApellido.ToString();
                        txt_edad.Text = per.Per_fechNacimiento.ToString();
                        txt_numHClinica.Text = per.Per_Cedula.ToString();

                        if (pedexa != null)
                        {

                            //Hematologia
                            if (pedexa.pedExa_bioHematicaHema == null)
                            {
                                ckb_bioHematica.Checked = false;                                
                            }
                            else
                            {
                                ckb_bioHematica.Checked = true;                                
                            }
                            if (pedexa.pedExa_hematocritoHema == null)
                            {
                                ckb_hematocrito.Checked = false;
                            }
                            else
                            {
                                ckb_hematocrito.Checked = true;                                
                            }
                            if (pedexa.pedExa_hemoglobinaHema == null)
                            {
                                ckb_hemoglobina.Checked = false;
                            }
                            else
                            {
                                ckb_hemoglobina.Checked = true;                                
                            }
                            if (pedexa.pedExa_vsgHema == null)
                            {
                                ckb_vsg.Checked = false;
                            }
                            else
                            {
                                ckb_vsg.Checked = true;
                            }

                            //Electrolitos
                            if (pedexa.pedExa_NakClElectro == null)
                            {                                
                                ckb_Na.Checked = false;
                            }
                            else
                            {
                                ckb_Na.Checked = true;
                                
                            }
                            if (pedexa.pedExa_calcioIonicoElectro == null)
                            {
                                ckb_calIonico.Checked = false;                                
                            }
                            else
                            {
                                ckb_calIonico.Checked = true;                                
                            }
                            if (pedexa.pedExa_calcioTotalElectro == null)
                            {
                                ckb_calTotal.Checked = false;                                
                            }
                            else
                            {
                                ckb_calTotal.Checked = true;                                
                            }
                            if (pedexa.pedExa_magnesioElectro == null)
                            {
                                ckb_magnesio.Checked = false;                                
                            }
                            else
                            {
                                ckb_magnesio.Checked = true;                                
                            }
                            if (pedexa.pedExa_fosforoElectro == null)
                            {
                                ckb_fosforo.Checked = false;
                            }
                            else
                            {
                                ckb_fosforo.Checked = true;
                            }

                            //Marcadores Tumorales
                            if (pedexa.pedExa_ca125MarcaTumo == null)
                            {
                                ckb_ca125.Checked = true;                              
                            }
                            else
                            {
                                ckb_ca125.Checked = false;                                                             
                            }
                            if (pedexa.pedExa_he4MarcaTumo == null)
                            {
                                ckb_he4.Checked = false;
                            }
                            else
                            {
                                ckb_he4.Checked = true;                            
                            }
                            if (pedexa.pedExa_indiceRomaMarcaTumo == null)
                            {
                                ckb_indRoma.Checked = false;                                
                            }
                            else
                            {
                                ckb_indRoma.Checked = true;                                
                            }
                            if (pedexa.pedExa_afpMarcaTumo == null)
                            {
                                ckb_afp.Checked = false;                                
                            }
                            else
                            {
                                ckb_afp.Checked = true;                                
                            }
                            if (pedexa.pedExa_ceaMarcaTurno == null)
                            {
                                ckb_cea.Checked = false;                                
                            }
                            else
                            {
                                ckb_cea.Checked = true;                                
                            }
                            if (pedexa.pedExa_ca156MarcaTumo == null)
                            {
                                ckb_ca153.Checked = false;                                
                            }
                            else
                            {
                                ckb_ca153.Checked = true;                                
                            }
                            if (pedexa.pedExa_ca159MarcaTumo == null)
                            {
                                ckb_ca199.Checked = false;                                
                            }
                            else
                            {
                                ckb_ca199.Checked = true;                                
                            }
                            if (pedexa.pedExa_tiroglobulinaMarcaTumo == null)
                            {
                                ckb_tiroglobulina.Checked = false;                                
                            }
                            else
                            {
                                ckb_tiroglobulina.Checked = true;                                
                            }
                            if (pedexa.pedExa_psaTotalMarcaTumo == null)
                            {
                                ckb_psa.Checked = false;
                            }
                            else
                            {
                                ckb_psa.Checked = true;
                            }

                            //InmunoHematologia
                            if (pedexa.pedExa_coombsDirectoInmuHema == null)
                            {
                                ckb_cooDirecto.Checked = false;
                            }
                            else
                            {
                                ckb_cooDirecto.Checked = true;
                            }
                            if (pedexa.pedExa_coombsIndirectoInmuHema == null)
                            {
                                ckb_cooIndirecto.Checked = false;
                            }
                            else
                            {
                                ckb_cooIndirecto.Checked = true;
                            }
                            if (pedexa.pedExa_grupoSanguiFacRhInmuHema == null)
                            {
                                ckb_grSanguineo.Checked = false;
                            }
                            else
                            {
                                ckb_grSanguineo.Checked = true;
                            }
                            if (pedexa.pedExa_celularLeInmuHema == null)
                            {
                                ckb_celulasLE.Checked = false;
                            }
                            else
                            {
                                ckb_celulasLE.Checked = true;
                            }

                            //Serologia
                            if (pedexa.pedExa_pcrCuantitativoSero == null)
                            {
                                ckb_pcrCuantitativo.Checked = false;
                            }else
                            {
                                ckb_pcrCuantitativo.Checked = true;
                            }
                            if (pedexa.pedExa_frLatexSero == null)
                            {
                                ckb_frLatex.Checked = false;
                            }else
                            {
                                ckb_frLatex.Checked = true;
                            }
                            if (pedexa.pedExa_astoSero == null)
                            {
                                ckb_asto.Checked = false;
                            }else
                            {
                                ckb_asto.Checked = true;
                            }
                            if (pedexa.pedExa_aglutinacionesFebrilesSero == null)
                            {
                                ckb_aglutinaciones.Checked = false;
                            }else
                            {
                                ckb_aglutinaciones.Checked = true;
                            }
                            if (pedexa.pedExa_vdrlSero == null)
                            {
                                ckb_vdrl.Checked = false;
                            }else
                            {
                                ckb_vdrl.Checked = true;
                            }

                            //Coagulacion
                            if (pedexa.pedExa_plaquetasCoagu == null)
                            {
                                ckb_plaquetas.Checked = false;                                
                            }
                            else
                            {
                                ckb_plaquetas.Checked = true;                                                               
                            }
                            if (pedexa.pedExa_fibrinogenoCoagu == null)
                            {
                                ckb_fibrinogeno.Checked = false;
                            }
                            else
                            {
                                ckb_fibrinogeno.Checked = true;                                
                            }
                            if (pedexa.pedExa_TpCoagu == null)
                            {
                                ckb_tp.Checked = false;
                            }
                            else
                            {
                                ckb_tp.Checked = true;                                
                            }
                            if (pedexa.pedExa_TtpCoagu == null)
                            {
                                ckb_ttp.Checked = false;
                            }
                            else
                            {
                                ckb_ttp.Checked = true;                                
                            }
                            if (pedexa.pedExa_InrCoagu == null)
                            {
                                ckb_inr.Checked = false;
                            }
                            else
                            {
                                ckb_inr.Checked = true;                                
                            }
                            if (pedexa.pedExa_tiemCoagulacionCoagu == null)
                            {
                                ckb_tiempCoagulacion.Checked = false;
                            }
                            else
                            {
                                ckb_tiempCoagulacion.Checked = true;                                
                            }
                            if (pedexa.pedExa_tiemSangriaCoagu == null)
                            {
                                ckb_tiempSangria.Checked = false;
                            }
                            else
                            {
                                ckb_tiempSangria.Checked = true;                                
                            }
                            if (pedexa.pedExa_antiLupicoCoagu == null)
                            {
                                ckb_antiLupico.Checked = false;
                            }
                            else
                            {
                                ckb_antiLupico.Checked = true;                                
                            }
                            if (pedexa.pedExa_dimeroDCoagu == null)
                            {
                                ckb_dimeroD.Checked = false;
                            }
                            else
                            {
                                ckb_dimeroD.Checked = true;
                            }

                            //Hormonas
                            if (pedexa.pedExa_lhHormo == null)
                            {
                                ckb_lh.Checked = false;
                            }
                            else
                            {
                                ckb_lh.Checked = true;
                            }
                            if (pedexa.pedExa_fshHormo == null)
                            {
                                ckb_fsh.Checked = false;
                            }
                            else
                            {
                                ckb_fsh.Checked = true;
                            }
                            if (pedexa.pedExa_estradiolHormo == null)
                            {
                                ckb_estradiol.Checked = false;
                            }
                            else
                            {
                                ckb_estradiol.Checked = true;
                            }
                            if (pedexa.pedExa_progesteronaHormo == null)
                            {
                                ckb_progesterona.Checked = false;
                            }
                            else
                            {
                                ckb_progesterona.Checked = true;
                            }
                            if (pedexa.pedExa_prolactinaHormo == null)
                            {
                                ckb_prolactina.Checked = false;
                            }
                            else
                            {
                                ckb_prolactina.Checked = true;
                            }
                            if (pedexa.pedExa_testosteronaHormo == null)
                            {
                                ckb_testosterona.Checked = false;
                            }
                            else
                            {
                                ckb_testosterona.Checked = true;
                            }
                            if (pedexa.pedExa_dheasHormo == null)
                            {
                                ckb_dheas.Checked = false;
                            }
                            else
                            {
                                ckb_dheas.Checked = true;
                            }
                            if (pedexa.pedExa_cortisolHormo == null)
                            {
                                ckb_cortisol.Checked = false;
                            }
                            else
                            {
                                ckb_cortisol.Checked = true;
                            }
                            if (pedexa.pedExa_insulinaHormo == null)
                            {
                                ckb_insulina.Checked = false;
                            }
                            else
                            {
                                ckb_insulina.Checked = true;
                            }
                            if (pedexa.pedExa_peptidoCHormo == null)
                            {
                                ckb_peptidoC.Checked = false;
                            }
                            else
                            {
                                ckb_peptidoC.Checked = true;
                            }
                            if (pedexa.pedExa_indiceHomaHormo == null)
                            {
                                ckb_indHoma.Checked = false;
                            }
                            else
                            {
                                ckb_indHoma.Checked = true;
                            }
                            if (pedexa.pedExa_bhcgHormo == null)
                            {
                                ckb_bhcg.Checked = false;
                            }
                            else
                            {
                                ckb_bhcg.Checked = true;
                            }
                            if (pedexa.pedExa_t3Hormo == null)
                            {
                                ckb_t3.Checked = false;
                            }
                            else
                            {
                                ckb_t3.Checked = true;
                            }
                            if (pedexa.pedExa_ft4Hormo == null)
                            {
                                ckb_fT4.Checked = false;
                            }
                            else
                            {
                                ckb_fT4.Checked = true;
                            }
                            if (pedexa.pedExa_tshHormo == null)
                            {
                                ckb_tsh.Checked = false;
                            }
                            else
                            {
                                ckb_tsh.Checked = true;
                            }
                            if (pedexa.pedExa_17OhProgesteronaHormo == null)
                            {
                                ckb_17Progesterona.Checked = false;
                            }
                            else
                            {
                                ckb_17Progesterona.Checked = true;
                            }
                            if (pedexa.pedExa_hghHormo == null)
                            {
                                ckb_hgh.Checked = false;
                            }
                            else
                            {
                                ckb_hgh.Checked = true;
                            }

                            //Microbiologia
                            if (pedexa.pedExa_muestraDeMicro == null)
                            {
                                ckb_muestra.Checked = false;
                            }
                            else
                            {
                                ckb_muestra.Checked = true;
                                txt_muestra.Text = pedexa.pedExa_muestraDeMicroDescrip.ToString();
                            }
                            if (pedexa.pedExa_gramMicro == null)
                            {
                                ckb_gram.Checked = false;
                            }
                            else
                            {
                                ckb_gram.Checked = true;
                            }
                            if (pedexa.pedExa_frescoMicro == null)
                            {
                                ckb_fresco.Checked = false;
                            }
                            else
                            {
                                ckb_fresco.Checked = true;
                            }
                            if (pedexa.pedExa_kohMicro == null)
                            {
                                ckb_koh.Checked = false;
                            }
                            else
                            {
                                ckb_koh.Checked = true;
                            }
                            if (pedexa.pedExa_cultivoAntibiogramaMicro == null)
                            {
                                ckb_culAntibiograma.Checked = false;
                            }
                            else
                            {
                                ckb_culAntibiograma.Checked = true;
                            }

                            //Estudios Especiales
                            if (pedexa.pedExa_esperCompletoEstEspecia == null)
                            {
                                ckb_esperCompleto.Checked = false;
                            }
                            else
                            {
                                ckb_esperCompleto.Checked = true;
                            }
                            if (pedexa.pedExa_cristalografiaEstEspecia == null)
                            {
                                ckb_cristalografia.Checked = false;
                            }
                            else
                            {
                                ckb_cristalografia.Checked = true;
                            }
                            if (pedexa.pedExa_screeningPrenatalEstEspecia == null)
                            {
                                ckb_screenPrenatal.Checked = false;
                            }
                            else
                            {
                                ckb_screenPrenatal.Checked = true;
                            }

                            //Orina
                            if (pedexa.pedExa_emoOrina == null)
                            {
                                ckb_emo.Checked = false;
                            }
                            else
                            {
                                ckb_emo.Checked = true;
                            }
                            if (pedexa.pedExa_cultivoAntibiogramaOrina == null)
                            {
                                ckb_CultAntibiograma.Checked = false;
                            }
                            else
                            {
                                ckb_CultAntibiograma.Checked = true;
                            }
                            if (pedexa.pedExa_gramGotaFrescaOrina == null)
                            {
                                ckb_gramGotaFres.Checked = false;
                            }
                            else
                            {
                                ckb_gramGotaFres.Checked = true;
                            }
                            if (pedexa.pedExa_microalbuminuriaOrina == null)
                            {
                                ckb_microalbuminuria.Checked = false;
                            }
                            else
                            {
                                ckb_microalbuminuria.Checked = true;
                            }

                            //Enzinas
                            if (pedexa.pedExa_tgoEnzi == null)
                            {
                                ckb_tgo.Checked = false;
                            }
                            else
                            {
                                ckb_tgo.Checked = true;
                            }
                            if (pedexa.pedExa_tgpEnzi == null)
                            {
                                ckb_tgp.Checked = false;
                            }
                            else
                            {
                                ckb_tgp.Checked = true;
                            }
                            if (pedexa.pedExa_amilasaEnzi == null)
                            {
                                ckb_amilasa.Checked = false;
                            }
                            else
                            {
                                ckb_amilasa.Checked = true;
                            }
                            if (pedexa.pedExa_lipasaEnzi == null)
                            {
                                ckb_lipasa.Checked = false;
                            }
                            else
                            {
                                ckb_lipasa.Checked = true;
                            }
                            if (pedexa.pedExa_cpkEnzi == null)
                            {
                                ckb_cpk.Checked = false;
                            }
                            else
                            {
                                ckb_cpk.Checked = true;
                            }
                            if (pedexa.pedExa_cpkMbEnzi == null)
                            {
                                ckb_cpkMb.Checked = false;
                            }
                            else
                            {
                                ckb_cpkMb.Checked = true;
                            }
                            if (pedexa.pedExa_ldhEnzi == null)
                            {
                                ckb_ldh.Checked = false;
                            }
                            else
                            {
                                ckb_ldh.Checked = true;
                            }
                            if (pedexa.pedExa_fosfatasaAlcalinaEnzi == null)
                            {
                                ckb_fosfaAlcalina.Checked = false;
                            }
                            else
                            {
                                ckb_fosfaAlcalina.Checked = true;
                            }
                            if (pedexa.pedExa_fosfatasaAcidaTotalEnzi == null)
                            {
                                ckb_fosfaAcidaTotal.Checked = false;
                            }
                            else
                            {
                                ckb_fosfaAcidaTotal.Checked = true;
                            }
                            if (pedexa.pedExa_fosfatasaAcidaProstaticaEnzi == null)
                            {
                                fosfaAcidaProstatica.Checked = false;
                            }
                            else
                            {
                                fosfaAcidaProstatica.Checked = true;
                            }

                            //Inmuno - Infecciosas
                            if (pedexa.pedExa_torchInmuInfecc == null)
                            {
                                ckb_torch.Checked = false;
                            }
                            else
                            {
                                ckb_torch.Checked = true;
                            }
                            if (pedexa.pedExa_toxoGondiiInmuInfecc == null)
                            {
                                ckb_toxoGondii.Checked = false;
                            }
                            else
                            {
                                ckb_toxoGondii.Checked = true;
                            }
                            if (pedexa.pedExa_clamydiaTrachoInmuInfecc == null)
                            {
                                ckb_clamyTrachomatis.Checked = false;
                            }
                            else
                            {
                                ckb_clamyTrachomatis.Checked = true;
                            }
                            if (pedexa.pedExa_lgGClamyTrachoInmuInfecc == null)
                            {
                                ckb_clamyTrachomatisIgG.Checked = false;
                            }
                            else
                            {
                                ckb_clamyTrachomatisIgG.Checked = true;
                            }
                            if (pedexa.pedExa_lgMClamyTrachoInmuInfecc == null)
                            {
                                ckb_clamyTrachomatisIgM.Checked = false;
                            }
                            else
                            {
                                ckb_clamyTrachomatisIgM.Checked = true;
                            }
                            if (pedexa.pedExa_havInmuInfecc == null)
                            {
                                ckb_hav.Checked = false;
                            }
                            else
                            {
                                ckb_hav.Checked = true;
                            }
                            if (pedexa.pedExa_lgGHavInmuInfecc == null)
                            {
                                ckb_havIiG.Checked = false;
                            }
                            else
                            {
                                ckb_havIiG.Checked = true;
                            }
                            if (pedexa.pedExa_lgMHavInmuInfecc == null)
                            {
                                ckb_havIiM.Checked = false;
                            }
                            else
                            {
                                ckb_havIiM.Checked = true;
                            }
                            if (pedexa.pedExa_vihInmuInfecc == null)
                            {
                                ckb_vih.Checked = false;
                            }
                            else
                            {
                                ckb_vih.Checked = true;
                            }
                            if (pedexa.pedExa_hbsAgInmuInfecc == null)
                            {
                                ckb_hbsAg.Checked = false;
                            }
                            else
                            {
                                ckb_hbsAg.Checked = true;
                            }
                            if (pedexa.pedExa_hcvInmuInfecc == null)
                            {
                                ckb_hcv.Checked = false;
                            }
                            else
                            {
                                ckb_hcv.Checked = true;
                            }
                            if (pedexa.pedExa_ftaAbsInmuInfecc == null)
                            {
                                ckb_ftaAbs.Checked = false;
                            }
                            else
                            {
                                ckb_ftaAbs.Checked = true;
                            }

                            //Drogas
                            if (pedexa.pedExa_fenobarbitalDrogas == null)
                            {
                                ckb_fenobarbital.Checked = false;
                            }
                            else
                            {
                                ckb_fenobarbital.Checked = true;
                            }
                            if (pedexa.pedExa_teofilinaDrogas == null)
                            {
                                ckb_teofilina.Checked = false;
                            }
                            else
                            {
                                ckb_teofilina.Checked = true;
                            }
                            if (pedexa.pedExa_acValproicoDrogas == null)
                            {
                                ckb_acValproico.Checked = false;
                            }
                            else
                            {
                                ckb_acValproico.Checked = true;
                            }

                            //Otros
                            if (pedexa.pedExa_Otros1 == null)
                            {
                                ckb_otros1.Checked = false;
                            }
                            else
                            {
                                ckb_otros1.Checked = true;
                                txt_otros1.Text = pedexa.pedExa_descripOtros1.ToString();
                            }
                            if (pedexa.pedExa_Otros2 == null)
                            {
                                ckb_otros2.Checked = false;
                            }
                            else
                            {
                                ckb_otros2.Checked = true;
                                txt_otros2.Text = pedexa.pedExa_descripOtros2.ToString();
                            }
                            if (pedexa.pedExa_Otros3 == null)
                            {
                                ckb_otros3.Checked = false;
                            }
                            else
                            {
                                ckb_otros3.Checked = true;
                                txt_otros3.Text = pedexa.pedExa_descripOtros3.ToString();
                            }

                            //Heces
                            if (pedexa.pedExa_coproparasitarioHeces == null)
                            {
                                ckb_coproparasitario.Checked = false;
                            }
                            else
                            {
                                ckb_coproparasitario.Checked = true;
                            }
                            if (pedexa.pedExa_coproparasitarioSeriadoHeces == null)
                            {
                                ckb_coproSeriado.Checked = false;
                            }
                            else
                            {
                                ckb_coproSeriado.Checked = true;
                            }
                            if (pedexa.pedExa_sangreOcultaHeces == null)
                            {
                                ckb_sangreOculta.Checked = false;
                            }
                            else
                            {
                                ckb_sangreOculta.Checked = true;
                            }
                            if (pedexa.pedExa_pmnHeces == null)
                            {
                                ckb_pmn.Checked = false;
                            }
                            else
                            {
                                ckb_pmn.Checked = true;
                            }
                            if (pedexa.pedExa_rotavirusHeces == null)
                            {
                                ckb_rotavirus.Checked = false;
                            }
                            else
                            {
                                ckb_rotavirus.Checked = true;
                            }
                            if (pedexa.pedExa_helicobacterPylotiHeces == null)
                            {
                                ckb_helicoPylori.Checked = false;
                            }
                            else
                            {
                                ckb_helicoPylori.Checked = true;
                            }
                        }
                    }
                }
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
                        where c.Per_Cedula == cedula
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

                string edad = Convert.ToString(item.Per_fechNacimiento);
                txt_edad.Text = edad;
            }
        }

        private void guardar_modificar_datos(int pedidoexamen)
        {
            if (pedidoexamen == 0)
            {
                GuardarPedidoExamenes();
            }
            else
            {
                pedexa = CN_PedidoExamenes.ObtenerPedidoExamenesPorId(pedidoexamen);

                if (pedexa != null)
                {
                    ModificarPedidoExamenes(pedexa);
                }
            }
        }

        private void GuardarPedidoExamenes()
        {
            try
            {
                per = CN_HistorialMedico.ObtenerIdPersonasxCedula(Convert.ToInt32(txt_numHClinica.Text));

                int perso = Convert.ToInt32(per.Per_id.ToString());

                pedexa = new Tbl_PedidoExamenes();

                //Hematologia
                if (ckb_bioHematica.Checked == true)
                {
                    pedexa.pedExa_bioHematicaHema = "SI";
                }
                if (ckb_hematocrito.Checked == true)
                {
                    pedexa.pedExa_hematocritoHema = "SI";
                }
                if (ckb_hemoglobina.Checked == true)
                {
                    pedexa.pedExa_hemoglobinaHema = "SI";
                }
                if (ckb_vsg.Checked == true)
                {
                    pedexa.pedExa_vsgHema = "SI";
                }

                //Electrolitos
                if (ckb_Na.Checked == true)
                {
                    pedexa.pedExa_NakClElectro = "SI";
                }
                if (ckb_calIonico.Checked == true)
                {
                    pedexa.pedExa_calcioIonicoElectro = "SI";
                }
                if (ckb_calTotal.Checked == true)
                {
                    pedexa.pedExa_calcioTotalElectro = "SI";
                }
                if (ckb_magnesio.Checked == true)
                {
                    pedexa.pedExa_magnesioElectro = "SI";
                }
                if (ckb_fosforo.Checked == true)
                {
                    pedexa.pedExa_fosforoElectro = "SI";
                }

                //Marcadores Tumorales
                if (ckb_ca125.Checked == true)
                {
                    pedexa.pedExa_ca125MarcaTumo = "SI";
                }
                if (ckb_he4.Checked == true)
                {
                    pedexa.pedExa_he4MarcaTumo = "SI";
                }
                if (ckb_indRoma.Checked == true)
                {
                    pedexa.pedExa_indiceRomaMarcaTumo = "SI";
                }
                if (ckb_afp.Checked == true)
                {
                    pedexa.pedExa_afpMarcaTumo = "SI";
                }
                if (ckb_cea.Checked == true)
                {
                    pedexa.pedExa_ceaMarcaTurno = "SI";
                }
                if (ckb_ca153.Checked == true)
                {
                    pedexa.pedExa_ca156MarcaTumo = "SI";
                }
                if (ckb_ca199.Checked == true)
                {
                    pedexa.pedExa_ca159MarcaTumo = "SI";
                }
                if (ckb_tiroglobulina.Checked == true)
                {
                    pedexa.pedExa_tiroglobulinaMarcaTumo = "SI";
                }
                if (ckb_psa.Checked == true)
                {
                    pedexa.pedExa_psaTotalMarcaTumo = "SI";
                }

                //InmunoHematologia
                if (ckb_cooDirecto.Checked == true)
                {
                    pedexa.pedExa_coombsDirectoInmuHema = "SI";
                }
                if (ckb_cooIndirecto.Checked == true)
                {
                    pedexa.pedExa_coombsIndirectoInmuHema = "SI";
                }
                if (ckb_grSanguineo.Checked == true)
                {
                    pedexa.pedExa_grupoSanguiFacRhInmuHema = "SI";
                }
                if (ckb_celulasLE.Checked == true)
                {
                    pedexa.pedExa_celularLeInmuHema = "SI";
                }

                //Serologia
                if (ckb_pcrCuantitativo.Checked == true)
                {
                    pedexa.pedExa_pcrCuantitativoSero = "SI";
                }
                if (ckb_frLatex.Checked == true)
                {
                    pedexa.pedExa_frLatexSero = "SI";
                }
                if (ckb_asto.Checked == true)
                {
                    pedexa.pedExa_astoSero = "SI";
                }
                if (ckb_aglutinaciones.Checked == true)
                {
                    pedexa.pedExa_aglutinacionesFebrilesSero = "SI";
                }
                if (ckb_vdrl.Checked == true)
                {
                    pedexa.pedExa_vdrlSero = "SI";
                }

                //Coagulacion
                if (ckb_plaquetas.Checked == true)
                {
                    pedexa.pedExa_plaquetasCoagu = "SI";
                }
                if (ckb_fibrinogeno.Checked == true)
                {
                    pedexa.pedExa_fibrinogenoCoagu = "SI";
                }
                if (ckb_tp.Checked == true)
                {
                    pedexa.pedExa_TpCoagu = "SI";
                }
                if (ckb_ttp.Checked == true)
                {
                    pedexa.pedExa_TtpCoagu = "SI";
                }
                if (ckb_inr.Checked == true)
                {
                    pedexa.pedExa_InrCoagu = "SI";
                }
                if (ckb_tiempCoagulacion.Checked == true)
                {
                    pedexa.pedExa_tiemCoagulacionCoagu = "SI";
                }
                if (ckb_tiempSangria.Checked == true)
                {
                    pedexa.pedExa_tiemSangriaCoagu = "SI";
                }
                if (ckb_antiLupico.Checked == true)
                {
                    pedexa.pedExa_antiLupicoCoagu = "SI";
                }
                if (ckb_dimeroD.Checked == true)
                {
                    pedexa.pedExa_dimeroDCoagu = "SI";
                }

                //Hormonas
                if (ckb_lh.Checked == true)
                {
                    pedexa.pedExa_lhHormo = "SI";
                }
                if (ckb_fsh.Checked == true)
                {
                    pedexa.pedExa_fshHormo = "SI";
                }
                if (ckb_estradiol.Checked == true)
                {
                    pedexa.pedExa_estradiolHormo = "SI";
                }
                if (ckb_progesterona.Checked == true)
                {
                    pedexa.pedExa_progesteronaHormo = "SI";
                }
                if (ckb_prolactina.Checked == true)
                {
                    pedexa.pedExa_prolactinaHormo = "SI";
                }
                if (ckb_testosterona.Checked == true)
                {
                    pedexa.pedExa_testosteronaHormo = "SI";
                }
                if (ckb_dheas.Checked == true)
                {
                    pedexa.pedExa_dheasHormo = "SI";
                }
                if (ckb_cortisol.Checked == true)
                {
                    pedexa.pedExa_cortisolHormo = "SI";
                }
                if (ckb_insulina.Checked == true)
                {
                    pedexa.pedExa_insulinaHormo = "SI";
                }

                if (ckb_peptidoC.Checked == true)
                {
                    pedexa.pedExa_peptidoCHormo = "SI";
                }
                if (ckb_indHoma.Checked == true)
                {
                    pedexa.pedExa_indiceHomaHormo = "SI";
                }
                if (ckb_bhcg.Checked == true)
                {
                    pedexa.pedExa_bhcgHormo = "SI";
                }
                if (ckb_t3.Checked == true)
                {
                    pedexa.pedExa_t3Hormo = "SI";
                }
                if (ckb_fT4.Checked == true)
                {
                    pedexa.pedExa_ft4Hormo = "SI";
                }
                if (ckb_tsh.Checked == true)
                {
                    pedexa.pedExa_tshHormo = "SI";
                }
                if (ckb_17Progesterona.Checked == true)
                {
                    pedexa.pedExa_17OhProgesteronaHormo = "SI";
                }
                if (ckb_hgh.Checked == true)
                {
                    pedexa.pedExa_hghHormo = "SI";
                }

                //Microbiologia
                if (ckb_muestra.Checked == true)
                {
                    pedexa.pedExa_muestraDeMicro = "SI";
                    pedexa.pedExa_muestraDeMicroDescrip = txt_muestra.Text;
                }
                if (ckb_gram.Checked == true)
                {
                    pedexa.pedExa_gramMicro = "SI";
                }
                if (ckb_fresco.Checked == true)
                {
                    pedexa.pedExa_frescoMicro = "SI";
                }
                if (ckb_koh.Checked == true)
                {
                    pedexa.pedExa_kohMicro = "SI";
                }
                if (ckb_culAntibiograma.Checked == true)
                {
                    pedexa.pedExa_cultivoAntibiogramaMicro = "SI";
                }

                //Estudios Especiales
                if (ckb_esperCompleto.Checked == true)
                {
                    pedexa.pedExa_esperCompletoEstEspecia = "SI";
                }
                if (ckb_cristalografia.Checked == true)
                {
                    pedexa.pedExa_cristalografiaEstEspecia = "SI";
                }
                if (ckb_screenPrenatal.Checked == true)
                {
                    pedexa.pedExa_screeningPrenatalEstEspecia = "SI";
                }

                //Orina
                if (ckb_emo.Checked == true)
                {
                    pedexa.pedExa_emoOrina = "SI";
                }
                if (ckb_CultAntibiograma.Checked == true)
                {
                    pedexa.pedExa_cultivoAntibiogramaOrina = "SI";
                }
                if (ckb_gramGotaFres.Checked == true)
                {
                    pedexa.pedExa_gramGotaFrescaOrina = "SI";
                }
                if (ckb_microalbuminuria.Checked == true)
                {
                    pedexa.pedExa_microalbuminuriaOrina = "SI";
                }

                //Enzinas
                if (ckb_tgo.Checked == true)
                {
                    pedexa.pedExa_tgoEnzi = "SI";
                }
                if (ckb_tgp.Checked == true)
                {
                    pedexa.pedExa_tgpEnzi = "SI";
                }
                if (ckb_amilasa.Checked == true)
                {
                    pedexa.pedExa_amilasaEnzi = "SI";
                }
                if (ckb_lipasa.Checked == true)
                {
                    pedexa.pedExa_lipasaEnzi = "SI";
                }
                if (ckb_cpk.Checked == true)
                {
                    pedexa.pedExa_cpkEnzi = "SI";
                }
                if (ckb_cpkMb.Checked == true)
                {
                    pedexa.pedExa_cpkMbEnzi = "SI";
                }
                if (ckb_ldh.Checked == true)
                {
                    pedexa.pedExa_ldhEnzi = "SI";
                }
                if (ckb_fosfaAlcalina.Checked == true)
                {
                    pedexa.pedExa_fosfatasaAlcalinaEnzi = "SI";
                }
                if (ckb_fosfaAcidaTotal.Checked == true)
                {
                    pedexa.pedExa_fosfatasaAcidaTotalEnzi = "SI";
                }
                if (fosfaAcidaProstatica.Checked == true)
                {
                    pedexa.pedExa_fosfatasaAcidaProstaticaEnzi = "SI";
                }

                //Inmuno - Infecciosas
                if (ckb_torch.Checked == true)
                {
                    pedexa.pedExa_torchInmuInfecc = "SI";
                }
                if (ckb_toxoGondii.Checked == true)
                {
                    pedexa.pedExa_toxoGondiiInmuInfecc = "SI";
                }
                if (ckb_clamyTrachomatis.Checked == true)
                {
                    pedexa.pedExa_clamydiaTrachoInmuInfecc = "SI";
                }
                if (ckb_clamyTrachomatisIgG.Checked == true)
                {
                    pedexa.pedExa_lgGClamyTrachoInmuInfecc = "SI";
                }
                if (ckb_clamyTrachomatisIgM.Checked == true)
                {
                    pedexa.pedExa_lgMClamyTrachoInmuInfecc = "SI";
                }
                if (ckb_hav.Checked == true)
                {
                    pedexa.pedExa_havInmuInfecc = "SI";
                }
                if (ckb_havIiG.Checked == true)
                {
                    pedexa.pedExa_lgGHavInmuInfecc = "SI";
                }
                if (ckb_havIiM.Checked == true)
                {
                    pedexa.pedExa_lgMHavInmuInfecc = "SI";
                }
                if (ckb_vih.Checked == true)
                {
                    pedexa.pedExa_vihInmuInfecc = "SI";
                }
                if (ckb_hbsAg.Checked == true)
                {
                    pedexa.pedExa_hbsAgInmuInfecc = "SI";
                }
                if (ckb_hcv.Checked == true)
                {
                    pedexa.pedExa_hcvInmuInfecc = "SI";
                }
                if (ckb_ftaAbs.Checked == true)
                {
                    pedexa.pedExa_ftaAbsInmuInfecc = "SI";
                }

                //Drogas
                if (ckb_fenobarbital.Checked == true)
                {
                    pedexa.pedExa_fenobarbitalDrogas = "SI";
                }
                if (ckb_teofilina.Checked == true)
                {
                    pedexa.pedExa_teofilinaDrogas = "SI";
                }
                if (ckb_acValproico.Checked == true)
                {
                    pedexa.pedExa_acValproicoDrogas = "SI";
                }

                //Otros
                if (ckb_otros1.Checked == true)
                {
                    pedexa.pedExa_Otros1 = "SI";
                    pedexa.pedExa_descripOtros1 = txt_otros1.Text;
                }
                if (ckb_otros2.Checked == true)
                {
                    pedexa.pedExa_Otros2 = "SI";
                    pedexa.pedExa_descripOtros2 = txt_otros2.Text;
                }
                if (ckb_otros3.Checked == true)
                {
                    pedexa.pedExa_Otros3 = "SI";
                    pedexa.pedExa_descripOtros3 = txt_otros3.Text;
                }

                //Heces
                if (ckb_coproparasitario.Checked == true)
                {
                    pedexa.pedExa_coproparasitarioHeces = "SI";
                }
                if (ckb_coproSeriado.Checked == true)
                {
                    pedexa.pedExa_coproparasitarioSeriadoHeces = "SI";
                }
                if (ckb_sangreOculta.Checked == true)
                {
                    pedexa.pedExa_sangreOcultaHeces = "SI";
                }
                if (ckb_pmn.Checked == true)
                {
                    pedexa.pedExa_pmnHeces = "SI";
                }
                if (ckb_rotavirus.Checked == true)
                {
                    pedexa.pedExa_rotavirusHeces = "SI";
                }
                if (ckb_helicoPylori.Checked == true)
                {
                    pedexa.pedExa_helicobacterPylotiHeces = "SI";
                }

                pedexa.Per_id = perso;

                CN_PedidoExamenes.GuardarPedidoExamenes(pedexa);


                //Mensaje de confirmacion
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Guardados Exitosamente')", true);

                Response.Redirect("~/Template/Views/Inicio.aspx");
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Guardados')", true);
            }
        }

        private void ModificarPedidoExamenes(Tbl_PedidoExamenes pedexa)
        {
            try
            {
                //Hematologia
                if (ckb_bioHematica.Checked == true)
                {
                    pedexa.pedExa_bioHematicaHema = "SI";
                }
                if (ckb_hematocrito.Checked == true)
                {
                    pedexa.pedExa_hematocritoHema = "SI";
                }
                if (ckb_hemoglobina.Checked == true)
                {
                    pedexa.pedExa_hemoglobinaHema = "SI";
                }
                if (ckb_vsg.Checked == true)
                {
                    pedexa.pedExa_vsgHema = "SI";
                }

                //Electrolitos
                if (ckb_Na.Checked == true)
                {
                    pedexa.pedExa_NakClElectro = "SI";
                }
                if (ckb_calIonico.Checked == true)
                {
                    pedexa.pedExa_calcioIonicoElectro = "SI";
                }
                if (ckb_calTotal.Checked == true)
                {
                    pedexa.pedExa_calcioTotalElectro = "SI";
                }
                if (ckb_magnesio.Checked == true)
                {
                    pedexa.pedExa_magnesioElectro = "SI";
                }
                if (ckb_fosforo.Checked == true)
                {
                    pedexa.pedExa_fosforoElectro = "SI";
                }

                //Marcadores Tumorales
                if (ckb_ca125.Checked == true)
                {
                    pedexa.pedExa_ca125MarcaTumo = "SI";
                }
                if (ckb_he4.Checked == true)
                {
                    pedexa.pedExa_he4MarcaTumo = "SI";
                }
                if (ckb_indRoma.Checked == true)
                {
                    pedexa.pedExa_indiceRomaMarcaTumo = "SI";
                }
                if (ckb_afp.Checked == true)
                {
                    pedexa.pedExa_afpMarcaTumo = "SI";
                }
                if (ckb_cea.Checked == true)
                {
                    pedexa.pedExa_ceaMarcaTurno = "SI";
                }
                if (ckb_ca153.Checked == true)
                {
                    pedexa.pedExa_ca156MarcaTumo = "SI";
                }
                if (ckb_ca199.Checked == true)
                {
                    pedexa.pedExa_ca159MarcaTumo = "SI";
                }
                if (ckb_tiroglobulina.Checked == true)
                {
                    pedexa.pedExa_tiroglobulinaMarcaTumo = "SI";
                }
                if (ckb_psa.Checked == true)
                {
                    pedexa.pedExa_psaTotalMarcaTumo = "SI";
                }

                //InmunoHematologia
                if (ckb_cooDirecto.Checked == true)
                {
                    pedexa.pedExa_coombsDirectoInmuHema = "SI";
                }
                if (ckb_cooIndirecto.Checked == true)
                {
                    pedexa.pedExa_coombsIndirectoInmuHema = "SI";
                }
                if (ckb_grSanguineo.Checked == true)
                {
                    pedexa.pedExa_grupoSanguiFacRhInmuHema = "SI";
                }
                if (ckb_celulasLE.Checked == true)
                {
                    pedexa.pedExa_celularLeInmuHema = "SI";
                }

                //Serologia
                if (ckb_pcrCuantitativo.Checked == true)
                {
                    pedexa.pedExa_pcrCuantitativoSero = "SI";
                }
                if (ckb_frLatex.Checked == true)
                {
                    pedexa.pedExa_frLatexSero = "SI";
                }
                if (ckb_asto.Checked == true)
                {
                    pedexa.pedExa_astoSero = "SI";
                }
                if (ckb_aglutinaciones.Checked == true)
                {
                    pedexa.pedExa_aglutinacionesFebrilesSero = "SI";
                }
                if (ckb_vdrl.Checked == true)
                {
                    pedexa.pedExa_vdrlSero = "SI";
                }

                //Coagulacion
                if (ckb_plaquetas.Checked == true)
                {
                    pedexa.pedExa_plaquetasCoagu = "SI";
                }
                if (ckb_fibrinogeno.Checked == true)
                {
                    pedexa.pedExa_fibrinogenoCoagu = "SI";
                }
                if (ckb_tp.Checked == true)
                {
                    pedexa.pedExa_TpCoagu = "SI";
                }
                if (ckb_ttp.Checked == true)
                {
                    pedexa.pedExa_TtpCoagu = "SI";
                }
                if (ckb_inr.Checked == true)
                {
                    pedexa.pedExa_InrCoagu = "SI";
                }
                if (ckb_tiempCoagulacion.Checked == true)
                {
                    pedexa.pedExa_tiemCoagulacionCoagu = "SI";
                }
                if (ckb_tiempSangria.Checked == true)
                {
                    pedexa.pedExa_tiemSangriaCoagu = "SI";
                }
                if (ckb_antiLupico.Checked == true)
                {
                    pedexa.pedExa_antiLupicoCoagu = "SI";
                }
                if (ckb_dimeroD.Checked == true)
                {
                    pedexa.pedExa_dimeroDCoagu = "SI";
                }

                //Hormonas
                if (ckb_lh.Checked == true)
                {
                    pedexa.pedExa_lhHormo = "SI";
                }
                if (ckb_fsh.Checked == true)
                {
                    pedexa.pedExa_fshHormo = "SI";
                }
                if (ckb_estradiol.Checked == true)
                {
                    pedexa.pedExa_estradiolHormo = "SI";
                }
                if (ckb_progesterona.Checked == true)
                {
                    pedexa.pedExa_progesteronaHormo = "SI";
                }
                if (ckb_prolactina.Checked == true)
                {
                    pedexa.pedExa_prolactinaHormo = "SI";
                }
                if (ckb_testosterona.Checked == true)
                {
                    pedexa.pedExa_testosteronaHormo = "SI";
                }
                if (ckb_dheas.Checked == true)
                {
                    pedexa.pedExa_dheasHormo = "SI";
                }
                if (ckb_cortisol.Checked == true)
                {
                    pedexa.pedExa_cortisolHormo = "SI";
                }
                if (ckb_insulina.Checked == true)
                {
                    pedexa.pedExa_insulinaHormo = "SI";
                }

                if (ckb_peptidoC.Checked == true)
                {
                    pedexa.pedExa_peptidoCHormo = "SI";
                }
                if (ckb_indHoma.Checked == true)
                {
                    pedexa.pedExa_indiceHomaHormo = "SI";
                }
                if (ckb_bhcg.Checked == true)
                {
                    pedexa.pedExa_bhcgHormo = "SI";
                }
                if (ckb_t3.Checked == true)
                {
                    pedexa.pedExa_t3Hormo = "SI";
                }
                if (ckb_fT4.Checked == true)
                {
                    pedexa.pedExa_ft4Hormo = "SI";
                }
                if (ckb_tsh.Checked == true)
                {
                    pedexa.pedExa_tshHormo = "SI";
                }
                if (ckb_17Progesterona.Checked == true)
                {
                    pedexa.pedExa_17OhProgesteronaHormo = "SI";
                }
                if (ckb_hgh.Checked == true)
                {
                    pedexa.pedExa_hghHormo = "SI";
                }

                //Microbiologia
                if (ckb_muestra.Checked == true)
                {
                    pedexa.pedExa_muestraDeMicro = "SI";
                    pedexa.pedExa_muestraDeMicroDescrip = txt_muestra.Text;
                }
                if (ckb_gram.Checked == true)
                {
                    pedexa.pedExa_gramMicro = "SI";
                }
                if (ckb_fresco.Checked == true)
                {
                    pedexa.pedExa_frescoMicro = "SI";
                }
                if (ckb_koh.Checked == true)
                {
                    pedexa.pedExa_kohMicro = "SI";
                }
                if (ckb_culAntibiograma.Checked == true)
                {
                    pedexa.pedExa_cultivoAntibiogramaMicro = "SI";
                }

                //Estudios Especiales
                if (ckb_esperCompleto.Checked == true)
                {
                    pedexa.pedExa_esperCompletoEstEspecia = "SI";
                }
                if (ckb_cristalografia.Checked == true)
                {
                    pedexa.pedExa_cristalografiaEstEspecia = "SI";
                }
                if (ckb_screenPrenatal.Checked == true)
                {
                    pedexa.pedExa_screeningPrenatalEstEspecia = "SI";
                }

                //Orina
                if (ckb_emo.Checked == true)
                {
                    pedexa.pedExa_emoOrina = "SI";
                }
                if (ckb_CultAntibiograma.Checked == true)
                {
                    pedexa.pedExa_cultivoAntibiogramaOrina = "SI";
                }
                if (ckb_gramGotaFres.Checked == true)
                {
                    pedexa.pedExa_gramGotaFrescaOrina = "SI";
                }
                if (ckb_microalbuminuria.Checked == true)
                {
                    pedexa.pedExa_microalbuminuriaOrina = "SI";
                }

                //Enzinas
                if (ckb_tgo.Checked == true)
                {
                    pedexa.pedExa_tgoEnzi = "SI";
                }
                if (ckb_tgp.Checked == true)
                {
                    pedexa.pedExa_tgpEnzi = "SI";
                }
                if (ckb_amilasa.Checked == true)
                {
                    pedexa.pedExa_amilasaEnzi = "SI";
                }
                if (ckb_lipasa.Checked == true)
                {
                    pedexa.pedExa_lipasaEnzi = "SI";
                }
                if (ckb_cpk.Checked == true)
                {
                    pedexa.pedExa_cpkEnzi = "SI";
                }
                if (ckb_cpkMb.Checked == true)
                {
                    pedexa.pedExa_cpkMbEnzi = "SI";
                }
                if (ckb_ldh.Checked == true)
                {
                    pedexa.pedExa_ldhEnzi = "SI";
                }
                if (ckb_fosfaAlcalina.Checked == true)
                {
                    pedexa.pedExa_fosfatasaAlcalinaEnzi = "SI";
                }
                if (ckb_fosfaAcidaTotal.Checked == true)
                {
                    pedexa.pedExa_fosfatasaAcidaTotalEnzi = "SI";
                }
                if (fosfaAcidaProstatica.Checked == true)
                {
                    pedexa.pedExa_fosfatasaAcidaProstaticaEnzi = "SI";
                }

                //Inmuno - Infecciosas
                if (ckb_torch.Checked == true)
                {
                    pedexa.pedExa_torchInmuInfecc = "SI";
                }
                if (ckb_toxoGondii.Checked == true)
                {
                    pedexa.pedExa_toxoGondiiInmuInfecc = "SI";
                }
                if (ckb_clamyTrachomatis.Checked == true)
                {
                    pedexa.pedExa_clamydiaTrachoInmuInfecc = "SI";
                }
                if (ckb_clamyTrachomatisIgG.Checked == true)
                {
                    pedexa.pedExa_lgGClamyTrachoInmuInfecc = "SI";
                }
                if (ckb_clamyTrachomatisIgM.Checked == true)
                {
                    pedexa.pedExa_lgMClamyTrachoInmuInfecc = "SI";
                }
                if (ckb_hav.Checked == true)
                {
                    pedexa.pedExa_havInmuInfecc = "SI";
                }
                if (ckb_havIiG.Checked == true)
                {
                    pedexa.pedExa_lgGHavInmuInfecc = "SI";
                }
                if (ckb_havIiM.Checked == true)
                {
                    pedexa.pedExa_lgMHavInmuInfecc = "SI";
                }
                if (ckb_vih.Checked == true)
                {
                    pedexa.pedExa_vihInmuInfecc = "SI";
                }
                if (ckb_hbsAg.Checked == true)
                {
                    pedexa.pedExa_hbsAgInmuInfecc = "SI";
                }
                if (ckb_hcv.Checked == true)
                {
                    pedexa.pedExa_hcvInmuInfecc = "SI";
                }
                if (ckb_ftaAbs.Checked == true)
                {
                    pedexa.pedExa_ftaAbsInmuInfecc = "SI";
                }

                //Drogas
                if (ckb_fenobarbital.Checked == true)
                {
                    pedexa.pedExa_fenobarbitalDrogas = "SI";
                }
                if (ckb_teofilina.Checked == true)
                {
                    pedexa.pedExa_teofilinaDrogas = "SI";
                }
                if (ckb_acValproico.Checked == true)
                {
                    pedexa.pedExa_acValproicoDrogas = "SI";
                }

                //Otros
                if (ckb_otros1.Checked == true)
                {
                    pedexa.pedExa_Otros1 = "SI";
                    pedexa.pedExa_descripOtros1 = txt_otros1.Text;
                }
                if (ckb_otros2.Checked == true)
                {
                    pedexa.pedExa_Otros2 = "SI";
                    pedexa.pedExa_descripOtros2 = txt_otros2.Text;
                }
                if (ckb_otros3.Checked == true)
                {
                    pedexa.pedExa_Otros3 = "SI";
                    pedexa.pedExa_descripOtros3 = txt_otros3.Text;
                }

                //Heces
                if (ckb_coproparasitario.Checked == true)
                {
                    pedexa.pedExa_coproparasitarioHeces = "SI";
                }
                if (ckb_coproSeriado.Checked == true)
                {
                    pedexa.pedExa_coproparasitarioSeriadoHeces = "SI";
                }
                if (ckb_sangreOculta.Checked == true)
                {
                    pedexa.pedExa_sangreOcultaHeces = "SI";
                }
                if (ckb_pmn.Checked == true)
                {
                    pedexa.pedExa_pmnHeces = "SI";
                }
                if (ckb_rotavirus.Checked == true)
                {
                    pedexa.pedExa_rotavirusHeces = "SI";
                }
                if (ckb_helicoPylori.Checked == true)
                {
                    pedexa.pedExa_helicobacterPylotiHeces = "SI";
                }

                CN_PedidoExamenes.ModificarPedidoExamenes(pedexa);

                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Modificados Exitosamente')", true);
                Response.Redirect("~/Template/Views/PacientesPedidoExamenes.aspx");

            }
            catch
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Modificados')", true);
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
    }
}