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

                            ////Hematologia
                            //if (pedexa.pedExa_bioHematicaHema == "SI" ||
                            //    pedexa.pedExa_hematocritoHema == "SI" ||
                            //    pedexa.pedExa_hemoglobinaHema == "SI" ||
                            //    pedexa.pedExa_vsgHema == "SI")
                            //{
                            //    ckb_bioHematica.Checked = true;
                            //    ckb_hematocrito.Checked = true;
                            //    ckb_hemoglobina.Checked = true;
                            //    ckb_vsg.Checked = true;
                            //}
                            //else
                            //{
                            //    ckb_bioHematica.Checked = false;
                            //    ckb_hematocrito.Checked = false;
                            //    ckb_hemoglobina.Checked = false;
                            //    ckb_vsg.Checked = false;                                
                            //}

                            ////Electrolitos
                            //if (pedexa.pedExa_NakClElectro == "SI" ||
                            //    pedexa.pedExa_calcioIonicoElectro == "SI" ||
                            //    pedexa.pedExa_calcioTotalElectro == "SI" ||
                            //    pedexa.pedExa_magnesioElectro == "SI" ||
                            //    pedexa.pedExa_fosforoElectro == "SI")
                            //{
                            //    ckb_Na.Checked = true;
                            //    ckb_calIonico.Checked = true;
                            //    ckb_calTotal.Checked = true;
                            //    ckb_magnesio.Checked = true;
                            //    ckb_fosforo.Checked = true;
                            //}
                            //else
                            //{
                            //    ckb_Na.Checked = false;
                            //    ckb_calIonico.Checked = false;
                            //    ckb_calTotal.Checked = false;
                            //    ckb_magnesio.Checked = false;
                            //    ckb_fosforo.Checked = false;
                            //}

                            ////Marcadores Tumorales
                            //if (pedexa.pedExa_ca125MarcaTumo == "SI" ||
                            //    pedexa.pedExa_he4MarcaTumo == "SI" ||
                            //    pedexa.pedExa_indiceRomaMarcaTumo == "SI" ||
                            //    pedexa.pedExa_afpMarcaTumo == "SI" ||
                            //    pedexa.pedExa_ceaMarcaTurno == "SI" ||
                            //    pedexa.pedExa_ca156MarcaTumo == "SI" ||
                            //    pedexa.pedExa_ca159MarcaTumo == "SI" ||
                            //    pedexa.pedExa_tiroglobulinaMarcaTumo == "SI" ||
                            //    pedexa.pedExa_psaTotalMarcaTumo == "SI")
                            //{
                            //    ckb_ca125.Checked = true;
                            //    ckb_he4.Checked = true;
                            //    ckb_indRoma.Checked = true;
                            //    ckb_afp.Checked = true;
                            //    ckb_cea.Checked = true;
                            //    ckb_ca153.Checked = true;
                            //    ckb_ca199.Checked = true;
                            //    ckb_tiroglobulina.Checked = true;
                            //    ckb_psa.Checked = true;
                            //}
                            //else
                            //{
                            //    ckb_ca125.Checked = false;
                            //    ckb_he4.Checked = false;
                            //    ckb_indRoma.Checked = false;
                            //    ckb_afp.Checked = false;
                            //    ckb_cea.Checked = false;
                            //    ckb_ca153.Checked = false;
                            //    ckb_ca199.Checked = false;
                            //    ckb_tiroglobulina.Checked = false;
                            //    ckb_psa.Checked = false;
                            //}

                            ////InmunoHematologia
                            //if (pedexa.pedExa_coombsDirectoInmuHema == "SI" ||
                            //    pedexa.pedExa_coombsIndirectoInmuHema == "SI" ||
                            //    pedexa.pedExa_grupoSanguiFacRhInmuHema == "SI" ||
                            //    pedexa.pedExa_celularLeInmuHema == "SI")
                            //{
                            //    ckb_cooDirecto.Checked = true;
                            //    ckb_cooIndirecto.Checked = true;
                            //    ckb_grSanguineo.Checked = true;
                            //    ckb_celulasLE.Checked = true;
                            //}
                            //else
                            //{
                            //    ckb_cooDirecto.Checked = false;
                            //    ckb_cooIndirecto.Checked = false;
                            //    ckb_grSanguineo.Checked = false;
                            //    ckb_celulasLE.Checked = false;
                            //}

                            ////Serologia
                            //if (pedexa.pedExa_pcrCuantitativoSero == "SI" ||
                            //    pedexa.pedExa_frLatexSero == "SI" ||
                            //    pedexa.pedExa_astoSero == "SI" ||
                            //    pedexa.pedExa_aglutinacionesFebrilesSero == "SI" ||
                            //    pedexa.pedExa_vdrlSero == "SI")
                            //{
                            //    ckb_pcrCuantitativo.Checked = true;
                            //    ckb_frLatex.Checked = true;
                            //    ckb_asto.Checked = true;
                            //    ckb_aglutinaciones.Checked = true;
                            //    ckb_vdrl.Checked = true;
                            //}
                            //else
                            //{
                            //    ckb_pcrCuantitativo.Checked = false;
                            //    ckb_frLatex.Checked = false;
                            //    ckb_asto.Checked = false;
                            //    ckb_aglutinaciones.Checked = false;
                            //    ckb_vdrl.Checked = false;
                            //}

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

                            ////Hormonas
                            //if (pedexa.pedExa_lhHormo == "SI" ||
                            //    pedexa.pedExa_fshHormo == "SI" ||
                            //    pedexa.pedExa_estradiolHormo == "SI" ||
                            //    pedexa.pedExa_progesteronaHormo == "SI" ||
                            //    pedexa.pedExa_prolactinaHormo == "SI" ||
                            //    pedexa.pedExa_testosteronaHormo == "SI" ||
                            //    pedexa.pedExa_dheasHormo == "SI" ||
                            //    pedexa.pedExa_cortisolHormo == "SI" ||
                            //    pedexa.pedExa_insulinaHormo == "SI" ||
                            //    pedexa.pedExa_peptidoCHormo == "SI" ||
                            //    pedexa.pedExa_indiceHomaHormo == "SI" ||
                            //    pedexa.pedExa_bhcgHormo == "SI" ||
                            //    pedexa.pedExa_t3Hormo == "SI" ||
                            //    pedexa.pedExa_ft4Hormo == "SI" ||
                            //    pedexa.pedExa_tshHormo == "SI" ||
                            //    pedexa.pedExa_17OhProgesteronaHormo == "SI" ||
                            //    pedexa.pedExa_hghHormo == "SI")
                            //{
                            //    ckb_lh.Checked = true;
                            //    ckb_fsh.Checked = true;
                            //    ckb_estradiol.Checked = true;
                            //    ckb_progesterona.Checked = true;
                            //    ckb_prolactina.Checked = true;
                            //    ckb_testosterona.Checked = true;
                            //    ckb_dheas.Checked = true;
                            //    ckb_cortisol.Checked = true;
                            //    ckb_insulina.Checked = true;
                            //    ckb_peptidoC.Checked = true;
                            //    ckb_indHoma.Checked = true;
                            //    ckb_bhcg.Checked = true;
                            //    ckb_t3.Checked = true;
                            //    ckb_fT4.Checked = true;
                            //    ckb_tsh.Checked = true;
                            //    ckb_17Progesterona.Checked = true;
                            //    ckb_hgh.Checked = true;
                            //}
                            //else
                            //{
                            //    ckb_lh.Checked = false;
                            //    ckb_fsh.Checked = false;
                            //    ckb_estradiol.Checked = false;
                            //    ckb_progesterona.Checked = false;
                            //    ckb_prolactina.Checked = false;
                            //    ckb_testosterona.Checked = false;
                            //    ckb_dheas.Checked = false;
                            //    ckb_cortisol.Checked = false;
                            //    ckb_insulina.Checked = false;
                            //    ckb_peptidoC.Checked = false;
                            //    ckb_indHoma.Checked = false;
                            //    ckb_bhcg.Checked = false;
                            //    ckb_t3.Checked = false;
                            //    ckb_fT4.Checked = false;
                            //    ckb_tsh.Checked = false;
                            //    ckb_17Progesterona.Checked = false;
                            //    ckb_hgh.Checked = false;
                            //}

                            ////Microbiologia
                            //if (pedexa.pedExa_muestraDeMicro == "SI" ||
                            //    txt_muestra.Text == pedexa.pedExa_muestraDeMicroDescrip.ToString() ||
                            //    pedexa.pedExa_gramMicro == "SI" ||
                            //    pedexa.pedExa_frescoMicro == "SI" ||
                            //    pedexa.pedExa_kohMicro == "SI" ||
                            //    pedexa.pedExa_cultivoAntibiogramaMicro == "SI")
                            //{
                            //    ckb_muestra.Checked = true;
                            //    ckb_gram.Checked = true;
                            //    ckb_fresco.Checked = true;
                            //    ckb_koh.Checked = true;
                            //    ckb_culAntibiograma.Checked = true;
                            //}
                            //else
                            //{
                            //    ckb_muestra.Checked = false;
                            //    ckb_gram.Checked = false;
                            //    ckb_fresco.Checked = false;
                            //    ckb_koh.Checked = false;
                            //    ckb_culAntibiograma.Checked = false;
                            //}
                            
                            ////Estudios Especiales
                            //if (ckb_esperCompleto.Checked = true;)
                            //{
                            //    pedexa.pedExa_esperCompletoEstEspecia = "SI";
                            //}
                            //if (ckb_cristalografia.Checked = true;)
                            //{
                            //    pedexa.pedExa_cristalografiaEstEspecia = "SI";
                            //}
                            //if (ckb_screenPrenatal.Checked = true;)
                            //{
                            //    pedexa.pedExa_screeningPrenatalEstEspecia = "SI";
                            //}

                            ////Orina
                            //if (ckb_emo.Checked = true;)
                            //{
                            //    pedexa.pedExa_emoOrina = "SI";
                            //}
                            //if (ckb_CultAntibiograma.Checked = true;)
                            //{
                            //    pedexa.pedExa_cultivoAntibiogramaOrina = "SI";
                            //}
                            //if (ckb_gramGotaFres.Checked = true;)
                            //{
                            //    pedexa.pedExa_gramGotaFrescaOrina = "SI";
                            //}
                            //if (ckb_microalbuminuria.Checked = true;)
                            //{
                            //    pedexa.pedExa_microalbuminuriaOrina = "SI";
                            //}

                            ////Enzinas
                            //if (ckb_tgo.Checked = true;)
                            //{
                            //    pedexa.pedExa_tgoEnzi = "SI";
                            //}
                            //if (ckb_tgp.Checked = true;)
                            //{
                            //    pedexa.pedExa_tgpEnzi = "SI";
                            //}
                            //if (ckb_amilasa.Checked = true;)
                            //{
                            //    pedexa.pedExa_amilasaEnzi = "SI";
                            //}
                            //if (ckb_lipasa.Checked = true;)
                            //{
                            //    pedexa.pedExa_lipasaEnzi = "SI";
                            //}
                            //if (ckb_cpk.Checked = true;)
                            //{
                            //    pedexa.pedExa_cpkEnzi = "SI";
                            //}
                            //if (ckb_cpkMb.Checked = true;)
                            //{
                            //    pedexa.pedExa_cpkMbEnzi = "SI";
                            //}
                            //if (ckb_ldh.Checked = true;)
                            //{
                            //    pedexa.pedExa_ldhEnzi = "SI";
                            //}
                            //if (ckb_fosfaAlcalina.Checked = true;)
                            //{
                            //    pedexa.pedExa_fosfatasaAlcalinaEnzi = "SI";
                            //}
                            //if (ckb_fosfaAcidaTotal.Checked = true;)
                            //{
                            //    pedexa.pedExa_fosfatasaAcidaTotalEnzi = "SI";
                            //}
                            //if (fosfaAcidaProstatica.Checked = true;)
                            //{
                            //    pedexa.pedExa_fosfatasaAcidaProstaticaEnzi = "SI";
                            //}

                            ////Inmuno - Infecciosas
                            //if (ckb_torch.Checked = true;)
                            //{
                            //    pedexa.pedExa_torchInmuInfecc = "SI";
                            //}
                            //if (ckb_toxoGondii.Checked = true;)
                            //{
                            //    pedexa.pedExa_toxoGondiiInmuInfecc = "SI";
                            //}
                            //if (ckb_clamyTrachomatis.Checked = true;)
                            //{
                            //    pedexa.pedExa_clamydiaTrachoInmuInfecc = "SI";
                            //}
                            //if (ckb_clamyTrachomatisIgG.Checked = true;)
                            //{
                            //    pedexa.pedExa_lgGClamyTrachoInmuInfecc = "SI";
                            //}
                            //if (ckb_clamyTrachomatisIgM.Checked = true;)
                            //{
                            //    pedexa.pedExa_lgMClamyTrachoInmuInfecc = "SI";
                            //}
                            //if (ckb_hav.Checked = true;)
                            //{
                            //    pedexa.pedExa_havInmuInfecc = "SI";
                            //}
                            //if (ckb_havIiG.Checked = true;)
                            //{
                            //    pedexa.pedExa_lgGHavInmuInfecc = "SI";
                            //}
                            //if (ckb_havIiM.Checked = true;)
                            //{
                            //    pedexa.pedExa_lgMHavInmuInfecc = "SI";
                            //}
                            //if (ckb_vih.Checked = true;)
                            //{
                            //    pedexa.pedExa_vihInmuInfecc = "SI";
                            //}
                            //if (ckb_hbsAg.Checked = true;)
                            //{
                            //    pedexa.pedExa_hbsAgInmuInfecc = "SI";
                            //}
                            //if (ckb_hcv.Checked = true;)
                            //{
                            //    pedexa.pedExa_hcvInmuInfecc = "SI";
                            //}
                            //if (ckb_ftaAbs.Checked = true;)
                            //{
                            //    pedexa.pedExa_ftaAbsInmuInfecc = "SI";
                            //}

                            ////Drogas
                            //if (ckb_fenobarbital.Checked = true;)
                            //{
                            //    pedexa.pedExa_fenobarbitalDrogas = "SI";
                            //}
                            //if (ckb_teofilina.Checked = true;)
                            //{
                            //    pedexa.pedExa_teofilinaDrogas = "SI";
                            //}
                            //if (ckb_acValproico.Checked = true;)
                            //{
                            //    pedexa.pedExa_acValproicoDrogas = "SI";
                            //}

                            ////Otros
                            //if (ckb_otros1.Checked = true;)
                            //{
                            //    pedexa.pedExa_Otros1 = "SI";
                            //    pedexa.pedExa_descripOtros1 = txt_otros1.Text;
                            //}
                            //if (ckb_otros2.Checked = true;)
                            //{
                            //    pedexa.pedExa_Otros2 = "SI";
                            //    pedexa.pedExa_descripOtros2 = txt_otros2.Text;
                            //}
                            //if (ckb_otros3.Checked = true;)
                            //{
                            //    pedexa.pedExa_Otros3 = "SI";
                            //    pedexa.pedExa_descripOtros3 = txt_otros3.Text;
                            //}

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
            throw new NotImplementedException();
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