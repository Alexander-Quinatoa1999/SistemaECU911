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
    public partial class PedidoExamenes : System.Web.UI.Page
    {

        DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        //Objeto de la tabla personas
        private Tbl_Personas per = new Tbl_Personas();

        //Objeto de la tabla Pedido Examenes
        private Tbl_PedidoExamenes pedexa = new Tbl_PedidoExamenes();


        protected void Page_Load(object sender, EventArgs e)
        {

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
                txt_edad.Text = per.Per_fechNacimiento.ToString();
            }
        }

        private void guardar_modificar_datos(int perid, int pedexaid)
        {
            if (perid == 0 || pedexaid == 0)
            {
                GuardarPedidoExamenes();
            }
            else
            {
                //per = CN_HistorialMedico.obtenerPersonasxId(perid);
                //int perso = Convert.ToInt32(per.Per_id.ToString());

                //datgen = CN_Certificado.obtenerDatosGeneralesxPerCertificado(perso);
                //aptmed = CN_Certificado.obtenerAptiMedLaboralxPerCertificado(perso);
                //evamed = CN_Certificado.obtenerEvaMedRetiroxPerCertificado(perso);
                //reco = CN_Certificado.obtenerRecomendacionesxPerCertificado(perso);
                //datprof = CN_Certificado.obtenerDatosProfesionalxPerCertificado(perso);

                //if (per != null || datgen != null || aptmed != null || evamed != null ||
                //    reco != null || datprof != null)
                //{
                //    //ModificarHistorial(per, emplant, antper, acctrabajo, enferprof, facriesgotractual, actvextralaboral,
                //    //    exagenesperiespues, diagnostico, aptitudmedica);
                //}

            }
        }

        private void GuardarPedidoExamenes()
        {
            try
            {
                per = CN_HistorialMedico.ObtenerIdPersonasxCedula(Convert.ToInt32(txt_numHClinica.Text));

                int perso = Convert.ToInt32(per.Per_id.ToString());

                // A.1
                pedexa = new Tbl_PedidoExamenes();

                //Hematologia
                if (ckb_bioHematica.Checked == true)
                {
                    pedexa.PedExam_bioHematicaHema = "SI";
                }
                if (ckb_hematocrito.Checked == true)
                {
                    pedexa.PedExam_hematocritoHema = "SI";
                }
                if (ckb_hemoglobina.Checked == true)
                {
                    pedexa.PedExam_hemoglobinaHema = "SI";
                }
                if (ckb_vsg.Checked == true)
                {
                    pedexa.PedExam_vsgHema = "SI";
                }

                //Electrolitos
                if (ckb_Na.Checked == true)
                {
                    pedexa.PedExam_NakClElectro = "SI";
                }
                if (ckb_calIonico.Checked == true)
                {
                    pedexa.PedExam_calcioIonicoElectro = "SI";
                }
                if (ckb_calTotal.Checked == true)
                {
                    pedexa.PedExam_calcioTotalElectro = "SI";
                }
                if (ckb_magnesio.Checked == true)
                {
                    pedexa.PedExam_magnesioElectro = "SI";
                }
                if (ckb_fosforo.Checked == true)
                {
                    pedexa.PedExam_fosforoElectro = "SI";
                }

                //Marcadores Tumorales
                if (ckb_ca125.Checked == true)
                {
                    pedexa.PedExam_ca125MarcaTumo = "SI";
                }
                if (ckb_he4.Checked == true)
                {
                    pedexa.PedExam_he4MarcaTumo = "SI";
                }
                if (ckb_indRoma.Checked == true)
                {
                    pedexa.PedExam_indiceRomaMarcaTumo = "SI";
                }
                if (ckb_afp.Checked == true)
                {
                    pedexa.PedExam_afpMarcaTumo = "SI";
                }
                if (ckb_cea.Checked == true)
                {
                    pedexa.PedExam_ceaMarcaTurno = "SI";
                }
                if (ckb_ca153.Checked == true)
                {
                    pedexa.PedExam_ca156MarcaTumo = "SI";
                }
                if (ckb_ca199.Checked == true)
                {
                    pedexa.PedExam_ca159MarcaTumo = "SI";
                }
                if (ckb_tiroglobulina.Checked == true)
                {
                    pedexa.PedExam_tiroglobulinaMarcaTumo = "SI";
                }
                if (ckb_psa.Checked == true)
                {
                    pedexa.PedExam_psaTotalMarcaTumo = "SI";
                }

                //InmunoHematologia
                if (ckb_cooDirecto.Checked == true)
                {
                    pedexa.PedExam_coombsDirectoInmuHema = "SI";
                }
                if (ckb_cooIndirecto.Checked == true)
                {
                    pedexa.PedExam_coombsIndirectoInmuHema = "SI";
                }
                if (ckb_grSanguineo.Checked == true)
                {
                    pedexa.PedExam_grupoSanguiFacRhInmuHema = "SI";
                }
                if (ckb_celulasLE.Checked == true)
                {
                    pedexa.PedExam_celularLeInmuHema = "SI";
                }

                //Serologia
                if (ckb_pcrCuantitativo.Checked == true)
                {
                    pedexa.PedExam_pcrCuantitativoSero = "SI";
                }
                if (ckb_frLatex.Checked == true)
                {
                    pedexa.PedExam_frLatexSero = "SI";
                }
                if (ckb_asto.Checked == true)
                {
                    pedexa.PedExam_astoSero = "SI";
                }
                if (ckb_aglutinaciones.Checked == true)
                {
                    pedexa.PedExam_aglutinacionesFebrilesSero = "SI";
                }
                if (ckb_vdrl.Checked == true)
                {
                    pedexa.PedExam_vdrlSero = "SI";
                }

                //Coagulacion
                if (ckb_plaquetas.Checked == true)
                {
                    pedexa.PedExam_plaquetasCoagu = "SI";
                }
                if (ckb_fibrinogeno.Checked == true)
                {
                    pedexa.PedExam_fibrinogenoCoagu = "SI";
                }
                if (ckb_tp.Checked == true)
                {
                    pedexa.PedExam_TpCoagu = "SI";
                }
                if (ckb_ttp.Checked == true)
                {
                    pedexa.PedExam_TtpCoagu = "SI";
                }
                if (ckb_inr.Checked == true)
                {
                    pedexa.PedExam_InrCoagu = "SI";
                }
                if (ckb_tiempCoagulacion.Checked == true)
                {
                    pedexa.PedExam_tiemCoagulacionCoagu = "SI";
                }
                if (ckb_tiempSangria.Checked == true)
                {
                    pedexa.PedExam_tiemSangriaCoagu = "SI";
                }
                if (ckb_antiLupico.Checked == true)
                {
                    pedexa.PedExam_antiLupicoCoagu = "SI";
                }
                if (ckb_dimeroD.Checked == true)
                {
                    pedexa.PedExam_dimeroDCoagu = "SI";
                }

                //Hormonas
                if (ckb_lh.Checked == true)
                {
                    pedexa.PedExam_lhHormo = "SI";
                }
                if (ckb_fsh.Checked == true)
                {
                    pedexa.PedExam_fshHormo = "SI";
                }
                if (ckb_estradiol.Checked == true)
                {
                    pedexa.PedExam_estradiolHormo = "SI";
                }
                if (ckb_progesterona.Checked == true)
                {
                    pedexa.PedExam_progesteronaHormo = "SI";
                }
                if (ckb_prolactina.Checked == true)
                {
                    pedexa.PedExam_prolactinaHormo = "SI";
                }
                if (ckb_testosterona.Checked == true)
                {
                    pedexa.PedExam_testosteronaHormo = "SI";
                }
                if (ckb_dheas.Checked == true)
                {
                    pedexa.PedExam_dheasHormo = "SI";
                }
                if (ckb_cortisol.Checked == true)
                {
                    pedexa.PedExam_cortisolHormo = "SI";
                }
                if (ckb_insulina.Checked == true)
                {
                    pedexa.PedExam_insulinaHormo = "SI";
                }

                if (ckb_peptidoC.Checked == true)
                {
                    pedexa.PedExam_peptidoCHormo = "SI";
                }
                if (ckb_indHoma.Checked == true)
                {
                    pedexa.PedExam_indiceHomaHormo = "SI";
                }
                if (ckb_bhcg.Checked == true)
                {
                    pedexa.PedExam_bhcgHormo = "SI";
                }
                if (ckb_t3.Checked == true)
                {
                    pedexa.PedExam_t3Hormo = "SI";
                }
                if (ckb_fT4.Checked == true)
                {
                    pedexa.PedExam_ft4Hormo = "SI";
                }
                if (ckb_tsh.Checked == true)
                {
                    pedexa.PedExam_tshHormo = "SI";
                }
                if (ckb_17Progesterona.Checked == true)
                {
                    pedexa.PedExam_17OhProgesteronaHormo = "SI";
                }
                if (ckb_hgh.Checked == true)
                {
                    pedexa.PedExam_hghHormo = "SI";
                }

                //Microbiologia
                if (ckb_muestra.Checked == true)
                {
                    pedexa.PedExam_muestraDeMicro = "SI";
                    pedexa.PedExam_muestraDeMicroDescrip = txt_muestra.Text;
                }
                if (ckb_gram.Checked == true)
                {
                    pedexa.PedExam_gramMicro = "SI";
                }
                if (ckb_fresco.Checked == true)
                {
                    pedexa.PedExam_frescoMicro = "SI";
                }
                if (ckb_koh.Checked == true)
                {
                    pedexa.PedExam_kohMicro = "SI";
                }
                if (ckb_culAntibiograma.Checked == true)
                {
                    pedexa.PedExam_cultivoAntibiogramaMicro = "SI";
                }

                //Estudios Especiales
                if (ckb_esperCompleto.Checked == true)
                {
                    pedexa.PedExam_esperCompletoEstEspecia = "SI";
                }
                if (ckb_cristalografia.Checked == true)
                {
                    pedexa.PedExam_cristalografiaEstEspecia = "SI";
                }
                if (ckb_screenPrenatal.Checked == true)
                {
                    pedexa.PedExam_screeningPrenatalEstEspecia = "SI";
                }

                //Orina
                if (ckb_emo.Checked == true)
                {
                    pedexa.PedExam_emoOrina = "SI";
                }
                if (ckb_CultAntibiograma.Checked == true)
                {
                    pedexa.PedExam_cultivoAntibiogramaOrina = "SI";
                }
                if (ckb_gramGotaFres.Checked == true)
                {
                    pedexa.PedExam_gramGotaFrescaOrina = "SI";
                }
                if (ckb_microalbuminuria.Checked == true)
                {
                    pedexa.PedExam_microalbuminuriaOrina = "SI";
                }

                //Enzinas
                if (ckb_tgo.Checked == true)
                {
                    pedexa.PedExam_tgoEnzi = "SI";
                }
                if (ckb_tgp.Checked == true)
                {
                    pedexa.PedExam_tgpEnzi = "SI";
                }
                if (ckb_amilasa.Checked == true)
                {
                    pedexa.PedExam_amilasaEnzi = "SI";
                }
                if (ckb_lipasa.Checked == true)
                {
                    pedexa.PedExam_lipasaEnzi = "SI";
                }
                if (ckb_cpk.Checked == true)
                {
                    pedexa.PedExam_cpkEnzi = "SI";
                }
                if (ckb_cpkMb.Checked == true)
                {
                    pedexa.PedExam_cpkMbEnzi = "SI";
                }
                if (ckb_ldh.Checked == true)
                {
                    pedexa.PedExam_ldhEnzi = "SI";
                }
                if (ckb_fosfaAlcalina.Checked == true)
                {
                    pedexa.PedExam_fosfatasaAlcalinaEnzi = "SI";
                }
                if (ckb_fosfaAcidaTotal.Checked == true)
                {
                    pedexa.PedExam_fosfatasaAcidaTotalEnzi = "SI";
                }
                if (fosfaAcidaProstatica.Checked == true)
                {
                    pedexa.PedExam_fosfatasaAcidaProstaticaEnzi = "SI";
                }

                //Inmuno - Infecciosas
                if (ckb_torch.Checked == true)
                {
                    pedexa.PedExam_torchInmuInfecc = "SI";
                }
                if (ckb_toxoGondii.Checked == true)
                {
                    pedexa.PedExam_toxoGondiiInmuInfecc = "SI";
                }
                if (ckb_clamyTrachomatis.Checked == true)
                {
                    pedexa.PedExam_clamydiaTrachoInmuInfecc = "SI";
                }
                if (ckb_clamyTrachomatisIgG.Checked == true)
                {
                    //Falta en la base de datos
                    //pedexa. = "SI";
                }
                if (ckb_clamyTrachomatisIgM.Checked == true)
                {
                    pedexa.PedExam_lgMClamyTrachoInmuInfecc = "SI";
                }
                if (ckb_hav.Checked == true)
                {
                    pedexa.PedExam_havInmuInfecc = "SI";
                }
                if (ckb_havIiG.Checked == true)
                {
                    pedexa.PedExam_lgGHavInmuInfecc = "SI";
                }
                if (ckb_havIiM.Checked == true)
                {
                    pedexa.PedExam_lgMHavInmuInfecc = "SI";
                }
                if (ckb_vih.Checked == true)
                {
                    pedexa.PedExam_vihInmuInfecc = "SI";
                }
                if (ckb_hbsAg.Checked == true)
                {
                    pedexa.PedExam_hbsAgInmuInfecc = "SI";
                }
                if (ckb_hcv.Checked == true)
                {
                    pedexa.PedExam_hcvInmuInfecc = "SI";
                }
                if (ckb_ftaAbs.Checked == true)
                {
                    pedexa.PedExam_ftaAbsInmuInfecc = "SI";
                }

                //Drogas
                if (ckb_fenobarbital.Checked == true)
                {
                    pedexa.PedExam_fenobarbitalDrogas = "SI";
                }
                if (ckb_teofilina.Checked == true)
                {
                    pedexa.PedExam_teofilinaDrogas = "SI";
                }
                if (ckb_acValproico.Checked == true)
                {
                    pedexa.PedExam_acValproicoDrogas = "SI";
                }

                //Otros
                if (ckb_otros1.Checked == true)
                {
                    pedexa.PedExam_1Otros = "SI";
                    //Faltan las descripciones de otros1
                }
                if (ckb_otros2.Checked == true)
                {
                    pedexa.PedExam_2Otros = "SI";
                    //Faltan las descripciones de otros2
                }
                if (ckb_otros3.Checked == true)
                {
                    pedexa.PedExam_3Otro = "SI";
                    //Faltan las descripciones de otros3
                }

                pedexa.Per_id = perso;

                //if (ckb_bioHematica.Checked == true || ckb_hematocrito.Checked == true ||
                //    ckb_hemoglobina.Checked == true || ckb_vsg.Checked == true)
                //{
                //    pedexa.PedExam_bioHematicaHema = "SI";
                //    pedexa.PedExam_hematocritoHema = "SI";
                //    pedexa.PedExam_hemoglobinaHema = "SI";
                //    pedexa.PedExam_vsgHema = "SI";
                //    pedexa.Per_id = perso;
                //}
                //else if(ckb_bioHematica.Checked == false || ckb_hematocrito.Checked == false ||
                //    ckb_hemoglobina.Checked == false || ckb_vsg.Checked == false)
                //{
                //    CN_PedidoExamenes.guardarPedidoExamenesNO(pedexa);
                //}

                ////B.Captura de datos Datos Generales
                //pedexa.PedExam_bioHematicaHema = Convert.ToString(ckb_bioHematica.Checked);
                //pedexa.PedExam_hematocritoHema = Convert.ToString(ckb_hematocrito.Checked);
                //pedexa.PedExam_hemoglobinaHema = Convert.ToString(ckb_hemoglobina.Checked);
                //pedexa.PedExam_vsgHema = Convert.ToString(ckb_vsg.Checked);

                //datgen.datGen_fechEmision = Convert.ToDateTime(txt_fechaEmision.Text);
                //datgen.datGen_ingreso = txt_ingreso.Text;
                //datgen.datGen_periodico = txt_periodico.Text;
                //datgen.datGen_reintegro = txt_reintegro.Text;
                //datgen.datGen_retiro = txt_retiro.Text;
                //datgen.Per_id = perso;


                ////B.Método para guardar Datos Datos Generales
                CN_PedidoExamenes.guardarPedidoExamenes(pedexa);


                //Mensaje de confirmacion
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Guardados Exitosamente')", true);

                Response.Redirect("~/Template/Views/Inicio.aspx");
                limpiar();
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Guardados')", true);
            }
        }

        private void limpiar()
        {
            throw new NotImplementedException();
        }

        protected void btn_guarda_Click(object sender, EventArgs e)
        {
            guardar_modificar_datos(Convert.ToInt32(Request["cod"]), Convert.ToInt32(per.Per_id.ToString()));
        }

        protected void btn_modificar_Click(object sender, EventArgs e)
        {

        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/Views/Inicio.aspx");
        }
    }
}