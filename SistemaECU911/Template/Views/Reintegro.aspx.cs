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
    public partial class Reintegro : System.Web.UI.Page
    {
        DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        private Tbl_Personas per = new Tbl_Personas();

        private Tbl_Reintegro reinte = new Tbl_Reintegro();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["cod"] != null)
                {
                    int codigo = Convert.ToInt32(Request["cod"]);
                    reinte = CN_Reintegro.ObtenerReintegroPorId(codigo);
                    int personasid = Convert.ToInt32(reinte.Per_id.ToString());
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
                        txt_puestoTrabajo.Text = per.Per_puestoTrabajo.ToString();

                        if (reinte != null)
                        {

                            //Regiones
                            if (reinte.rein_cicatricesPiel == null)
                            {
                                ckb_cicatrices.Checked = false;
                            }
                            else
                            {
                                ckb_cicatrices.Checked = true;

                            }
                            if (reinte.rein_tatuajesPiel == null)
                            {
                                ckb_tatuajes.Checked = false;
                            }
                            else
                            {
                                ckb_tatuajes.Checked = true;

                            }
                            if (reinte.rein_pielFacerasPiel == null)
                            {
                                ckb_pielyfaneras.Checked = false;
                            }
                            else
                            {
                                ckb_pielyfaneras.Checked = true;

                            }
                            if (reinte.rein_parpadosOjos == null)
                            {
                                ckb_parpados.Checked = false;
                            }
                            else
                            {
                                ckb_parpados.Checked = true;

                            }
                            if (reinte.rein_conjuntuvasOjos == null)
                            {
                                ckb_conjuntivas.Checked = false;
                            }
                            else
                            {
                                ckb_conjuntivas.Checked = true;

                            }
                            if (reinte.rein_pupilasOjos == null)
                            {
                                ckb_pupilas.Checked = false;
                            }
                            else
                            {
                                ckb_pupilas.Checked = true;

                            }
                            if (reinte.rein_corneaOjos == null)
                            {
                                ckb_cornea.Checked = false;
                            }
                            else
                            {
                                ckb_cornea.Checked = true;

                            }
                            if (reinte.rein_motilidadOjos == null)
                            {
                                ckb_motilidad.Checked = false;
                            }
                            else
                            {
                                ckb_motilidad.Checked = true;

                            }
                            if (reinte.rein_cAudiExtreOido == null)
                            {
                                ckb_auditivoexterno.Checked = false;
                            }
                            else
                            {
                                ckb_auditivoexterno.Checked = true;

                            }
                            if (reinte.rein_pabellonOido == null)
                            {
                                ckb_pabellon.Checked = false;
                            }
                            else
                            {
                                ckb_pabellon.Checked = true;

                            }
                            if (reinte.rein_timpanosOido == null)
                            {
                                ckb_timpanos.Checked = false;
                            }
                            else
                            {
                                ckb_timpanos.Checked = true;

                            }
                            if (reinte.rein_labiosOroFa == null)
                            {
                                ckb_labios.Checked = false;
                            }
                            else
                            {
                                ckb_labios.Checked = true;

                            }
                            if (reinte.rein_lenguaOroFa == null)
                            {
                                ckb_lengua.Checked = false;
                            }
                            else
                            {
                                ckb_lengua.Checked = true;

                            }
                            if (reinte.rein_faringeOroFa == null)
                            {
                                ckb_faringe.Checked = false;
                            }
                            else
                            {
                                ckb_faringe.Checked = true;

                            }
                            if (reinte.rein_amigdalasOroFa == null)
                            {
                                ckb_amigdalas.Checked = false;
                            }
                            else
                            {
                                ckb_amigdalas.Checked = true;

                            }
                            if (reinte.rein_dentaduraOroFa == null)
                            {
                                ckb_dentadura.Checked = false;
                            }
                            else
                            {
                                ckb_dentadura.Checked = true;

                            }
                            if (reinte.rein_tabiqueNariz == null)
                            {
                                ckb_tabique.Checked = false;
                            }
                            else
                            {
                                ckb_tabique.Checked = true;

                            }
                            if (reinte.rein_cornetesNariz == null)
                            {
                                ckb_cornetes.Checked = false;
                            }
                            else
                            {
                                ckb_cornetes.Checked = true;

                            }
                            if (reinte.rein_mucosasNariz == null)
                            {
                                ckb_mucosa.Checked = false;
                            }
                            else
                            {
                                ckb_mucosa.Checked = true;

                            }
                            if (reinte.rein_senosParanaNariz == null)
                            {
                                ckb_senosparanasales.Checked = false;
                            }
                            else
                            {
                                ckb_senosparanasales.Checked = true;

                            }
                            if (reinte.rein_tiroiMasasCuello == null)
                            {
                                ckb_tiroides.Checked = false;
                            }
                            else
                            {
                                ckb_tiroides.Checked = true;

                            }
                            if (reinte.rein_movilidadCuello == null)
                            {
                                ckb_movilidad.Checked = false;
                            }
                            else
                            {
                                ckb_movilidad.Checked = true;

                            }
                            if (reinte.rein_mamasTorax == null)
                            {
                                ckb_mamas.Checked = false;
                            }
                            else
                            {
                                ckb_mamas.Checked = true;

                            }
                            if (reinte.rein_corazonTorax == null)
                            {
                                ckb_corazon.Checked = false;
                            }
                            else
                            {
                                ckb_corazon.Checked = true;

                            }
                            if (reinte.rein_pulmonesTorax2 == null)
                            {
                                ckb_pulmones.Checked = false;
                            }
                            else
                            {
                                ckb_pulmones.Checked = true;

                            }
                            if (reinte.rein_parriCostalTorax2 == null)
                            {
                                ckb_parrillacostal.Checked = false;
                            }
                            else
                            {
                                ckb_parrillacostal.Checked = true;

                            }
                            if (reinte.rein_viscerasAbdomen == null)
                            {
                                ckb_visceras.Checked = false;
                            }
                            else
                            {
                                ckb_visceras.Checked = true;

                            }
                            if (reinte.rein_paredAbdomiAbdomen == null)
                            {
                                ckb_paredabdominal.Checked = false;
                            }
                            else
                            {
                                ckb_paredabdominal.Checked = true;

                            }
                            if (reinte.rein_flexibilidadColumna == null)
                            {
                                ckb_flexibilidad.Checked = false;
                            }
                            else
                            {
                                ckb_flexibilidad.Checked = true;

                            }
                            if (reinte.rein_desviacionColumna == null)
                            {
                                ckb_desviacion.Checked = false;
                            }
                            else
                            {
                                ckb_desviacion.Checked = true;

                            }
                            if (reinte.rein_dolorColumna == null)
                            {
                                ckb_dolor.Checked = false;
                            }
                            else
                            {
                                ckb_dolor.Checked = true;

                            }
                            if (reinte.rein_pelvisPelvis == null)
                            {
                                ckb_pelvis.Checked = false;
                            }
                            else
                            {
                                ckb_pelvis.Checked = true;

                            }
                            if (reinte.rein_genitalesPelvis == null)
                            {
                                ckb_genitales.Checked = false;
                            }
                            else
                            {
                                ckb_genitales.Checked = true;

                            }
                            if (reinte.rein_vascularExtre == null)
                            {
                                ckb_vascular.Checked = false;
                            }
                            else
                            {
                                ckb_vascular.Checked = true;

                            }
                            if (reinte.rein_miemSupeExtre == null)
                            {
                                ckb_miembrosuperiores.Checked = false;
                            }
                            else
                            {
                                ckb_miembrosuperiores.Checked = true;

                            }
                            if (reinte.rein_miemInfeExtre == null)
                            {
                                ckb_miembrosinferiores.Checked = false;
                            }
                            else
                            {
                                ckb_miembrosinferiores.Checked = true;

                            }
                            if (reinte.rein_fuerzaNeuro == null)
                            {
                                ckb_fuerza.Checked = false;
                            }
                            else
                            {
                                ckb_fuerza.Checked = true;

                            }
                            if (reinte.rein_sensibiNeuro == null)
                            {
                                ckb_sensibilidad.Checked = false;
                            }
                            else
                            {
                                ckb_sensibilidad.Checked = true;

                            }
                            if (reinte.rein_marchaNeuro == null)
                            {
                                ckb_marcha.Checked = false;
                            }
                            else
                            {
                                ckb_marcha.Checked = true;

                            }
                            if (reinte.rein_refleNeuro == null)
                            {
                                ckb_reflejos.Checked = false;
                            }
                            else
                            {
                                ckb_reflejos.Checked = true;

                            }

                            //Diagnostco
                            if (reinte.rein_pre == null)
                            {
                                ckb_pre.Checked = false;
                            }
                            else
                            {
                                ckb_pre.Checked = true;

                            }
                            if (reinte.rein_pre2 == null)
                            {
                                ckb_pre2.Checked = false;
                            }
                            else
                            {
                                ckb_pre2.Checked = true;

                            }
                            if (reinte.rein_pre3 == null)
                            {
                                ckb_pre3.Checked = false;
                            }
                            else
                            {
                                ckb_pre3.Checked = true;

                            }
                            if (reinte.rein_def == null)
                            {
                                ckb_def.Checked = false;
                            }
                            else
                            {
                                ckb_def.Checked = true;

                            }
                            if (reinte.rein_def2 == null)
                            {
                                ckb_def2.Checked = false;
                            }
                            else
                            {
                                ckb_def2.Checked = true;

                            }
                            if (reinte.rein_def3 == null)
                            {
                                ckb_def3.Checked = false;
                            }
                            else
                            {
                                ckb_def3.Checked = true;

                            }

                            //Aptitud Medica para el trabajo
                            if (reinte.rein_apto == null)
                            {
                                ckb_apto.Checked = false;
                            }
                            else
                            {
                                ckb_apto.Checked = true;

                            }
                            if (reinte.rein_aptoObserva == null)
                            {
                                ckb_aptoobservacion.Checked = false;
                            }
                            else
                            {
                                ckb_aptoobservacion.Checked = true;

                            }
                            if (reinte.rein_aptoLimi == null)
                            {
                                ckb_aptolimitacion.Checked = false;
                            }
                            else
                            {
                                ckb_aptolimitacion.Checked = true;

                            }
                            if (reinte.rein_NoApto == null)
                            {
                                ckb_noapto.Checked = false;
                            }
                            else
                            {
                                ckb_noapto.Checked = true;

                            }

                            //A
                            txt_numArchivo.Text = reinte.rein_numArchivo.ToString();
                            txt_edad.Text = reinte.rein_edad.ToString();
                            txt_fechaUltiDiaLaboral.Text = reinte.rein__fechUltDiaLaboral.ToString();
                            txt_fechaReingreso.Text = reinte.rein_fechReingreso.ToString();
                            txt_total.Text = reinte.rein_total.ToString();
                            txt_causaSalida.Text = reinte.rein_causaSalida.ToString();

                            //B
                            txt_motivoconsultareintegro.Text = reinte.rein_descripmotCon.ToString();

                            //C
                            txt_enfermedadactualreintegro.Text = reinte.rein_descripenfActual.ToString();

                            ////E
                            //txt_cicatrices.Text = reinte.rein_cicatricesPiel.ToString();
                            //txt_tatuajes.Text = reinte.rein_tatuajesPiel.ToString();
                            //txt_pielyfaneras.Text = reinte.rein_pielFacerasPiel.ToString();
                            //txt_parpados.Text = reinte.rein_parpadosOjos.ToString();
                            //txt_conjuntivas.Text = reinte.rein_conjuntuvasOjos.ToString();
                            //txt_pupilas.Text = reinte.rein_pupilasOjos.ToString();
                            //txt_cornea.Text = reinte.rein_corneaOjos.ToString();
                            //txt_motilidad.Text = reinte.rein_motilidadOjos.ToString();
                            //txt_auditivoexterno.Text = reinte.rein_cAudiExtreOido.ToString();
                            //txt_pabellon.Text = reinte.rein_pabellonOido.ToString();
                            //txt_timpanos.Text = reinte.rein_timpanosOido.ToString();
                            //txt_labios.Text = reinte.rein_labiosOroFa.ToString();
                            //txt_lengua.Text = reinte.rein_lenguaOroFa.ToString();
                            //txt_faringe.Text = reinte.rein_faringeOroFa.ToString();
                            //txt_amigdalas.Text = reinte.rein_amigdalasOroFa.ToString();
                            //txt_dentadura.Text = reinte.rein_dentaduraOroFa.ToString();
                            //txt_tabique.Text = reinte.rein_tabiqueNariz.ToString();
                            //txt_cornetes.Text = reinte.rein_cornetesNariz.ToString();
                            //txt_mucosa.Text = reinte.rein_mucosasNariz.ToString();
                            //txt_senosparanasales.Text = reinte.rein_senosParanaNariz.ToString();
                            //txt_tiroides.Text = reinte.rein_tiroiMasasCuello.ToString();
                            //txt_movilidad.Text = reinte.rein_movilidadCuello.ToString();
                            //txt_mamas.Text = reinte.rein_mamasTorax.ToString();
                            //txt_corazon.Text = reinte.rein_corazonTorax.ToString();
                            //txt_pulmones.Text = reinte.rein_pulmonesTorax2.ToString();
                            //txt_parrillacostal.Text = reinte.rein_parriCostalTorax2.ToString();
                            //txt_visceras.Text = reinte.rein_viscerasAbdomen.ToString();
                            //txt_paredabdominal.Text = reinte.rein_paredAbdomiAbdomen.ToString();
                            //txt_flexibilidad.Text = reinte.rein_flexibilidadColumna.ToString();
                            //txt_desviacion.Text = reinte.rein_desviacionColumna.ToString();
                            //txt_dolor.Text = reinte.rein_dolorColumna.ToString();
                            //txt_pelvis.Text = reinte.rein_pelvisPelvis.ToString();
                            //txt_genitales.Text = reinte.rein_genitalesPelvis.ToString();
                            //txt_vascular.Text = reinte.rein_vascularExtre.ToString();
                            //txt_miembrosureinres.Text = reinte.rein_miemSupeExtre.ToString();
                            //txt_miembrosinferiores.Text = reinte.rein_miemInfeExtre.ToString();
                            //txt_fuerza.Text = reinte.rein_fuerzaNeuro.ToString();
                            //txt_sensibilidad.Text = reinte.rein_sensibiNeuro.ToString();
                            //txt_marcha.Text = reinte.rein_marchaNeuro.ToString();
                            //txt_reflejos.Text = reinte.rein_refleNeuro.ToString();
                            txt_observexamenfisicoregional.Text = reinte.rein_observaexaFisRegional.ToString();

                            //F
                            txt_examen.Text = reinte.rein_examen.ToString();
                            txt_fechaexamen.Text = reinte.rein_fecha.ToString();
                            txt_resultadoexamen.Text = reinte.rein_resultados.ToString();
                            txt_observacionexamen.Text = reinte.rein_observacionesResExaGenEspRiesTrabajo.ToString();

                            //G
                            txt_descripdiagnostico.Text = reinte.rein_descripcionDiagnostico.ToString();
                            txt_cie.Text = reinte.rein_cie.ToString();
                            //txt_pre.Text = reinte.rein_pre.ToString();
                            //txt_def.Text = reinte.rein_def.ToString();

                            //H
                            //txt_apto.Text = reinte.rein_apto.ToString();
                            //txt_aptoobservacion.Text = reinte.rein_aptoObserva.ToString();
                            //txt_aptolimitacion.Text = reinte.rein_aptoLimi.ToString();
                            //txt_noapto.Text = reinte.rein_NoApto.ToString();
                            txt_observacionaptitud.Text = reinte.rein_ObservAptMedica.ToString();
                            txt_limitacionaptitud.Text = reinte.rein_LimitAptMedica.ToString();
                            txt_reubicacionaptitud.Text = reinte.rein_ReubicaAptMedica.ToString();

                            //I
                            txt_descripciontratamientoreintegro.Text = reinte.rein_descripcionRecoTratamiento.ToString();

                            //J
                            txt_fechahora.Text = reinte.rein_fecha_hora.ToString();
                            ddl_profesional.SelectedValue = reinte.prof_id.ToString();
                            txt_codigoDatProf.Text = reinte.rein_cod.ToString();
                        }
                    }                    
                }

                txt_fechahora.Text = DateTime.Now.ToString(" dd/MM/yyyy " + " HH:mm ");
                cargarProfesional();
            }
        }

        //Metodo obtener cedula por numero de HC REINTEGRO
        [WebMethod]
        [ScriptMethod]
        public static List<string> ObtenerNumHClinica(string prefixText)
        {
            List<string> lista = new List<string>();
            try
            {
                string oConn = @"Data Source=ZOCAPO\SQLEXPRESS;Initial Catalog=SistemaECU911;Integrated Security=True";

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
                txt_puestoTrabajo.Text = puestoTrabajo;

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
                string oConn = @"Data Source=ZOCAPO\SQLEXPRESS;Initial Catalog=SistemaECU911;Integrated Security=True";

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

        private void GuardarReintegro()
        {
            try
            {
                per = CN_HistorialMedico.ObtenerIdPersonasxCedula(Convert.ToInt32(txt_numHClinica.Text));

                int perso = Convert.ToInt32(per.Per_id.ToString());

                //Regiones
                if (ckb_cicatrices.Checked == true)
                {
                    reinte.rein_cicatricesPiel = "SI";
                }
                if (ckb_tatuajes.Checked == true)
                {
                    reinte.rein_tatuajesPiel = "SI";
                }
                if (ckb_pielyfaneras.Checked == true)
                {
                    reinte.rein_pielFacerasPiel = "SI";
                }
                if (ckb_parpados.Checked == true)
                {
                    reinte.rein_parpadosOjos = "SI";
                }
                if (ckb_conjuntivas.Checked == true)
                {
                    reinte.rein_conjuntuvasOjos = "SI";
                }
                if (ckb_pupilas.Checked == true)
                {
                    reinte.rein_pupilasOjos = "SI";
                }
                if (ckb_cornea.Checked == true)
                {
                    reinte.rein_corneaOjos = "SI";
                }
                if (ckb_motilidad.Checked == true)
                {
                    reinte.rein_motilidadOjos = "SI";
                }
                if (ckb_auditivoexterno.Checked == true)
                {
                    reinte.rein_cAudiExtreOido = "SI";
                }
                if (ckb_pabellon.Checked == true)
                {
                    reinte.rein_pabellonOido = "SI";
                }
                if (ckb_timpanos.Checked == true)
                {
                    reinte.rein_timpanosOido = "SI";
                }
                if (ckb_labios.Checked == true)
                {
                    reinte.rein_labiosOroFa = "SI";
                }
                if (ckb_lengua.Checked == true)
                {
                    reinte.rein_lenguaOroFa = "SI";
                }
                if (ckb_faringe.Checked == true)
                {
                    reinte.rein_faringeOroFa = "SI";
                }
                if (ckb_amigdalas.Checked == true)
                {
                    reinte.rein_amigdalasOroFa = "SI";
                }
                if (ckb_dentadura.Checked == true)
                {
                    reinte.rein_dentaduraOroFa = "SI";
                }
                if (ckb_tabique.Checked == true)
                {
                    reinte.rein_tabiqueNariz = "SI";
                }
                if (ckb_cornetes.Checked == true)
                {
                    reinte.rein_cornetesNariz = "SI";
                }
                if (ckb_mucosa.Checked == true)
                {
                    reinte.rein_mucosasNariz = "SI";
                }
                if (ckb_senosparanasales.Checked == true)
                {
                    reinte.rein_senosParanaNariz = "SI";
                }
                if (ckb_tiroides.Checked == true)
                {
                    reinte.rein_tiroiMasasCuello = "SI";
                }
                if (ckb_movilidad.Checked == true)
                {
                    reinte.rein_movilidadCuello = "SI";
                }
                if (ckb_mamas.Checked == true)
                {
                    reinte.rein_mamasTorax = "SI";
                }
                if (ckb_corazon.Checked == true)
                {
                    reinte.rein_corazonTorax = "SI";
                }
                if (ckb_pulmones.Checked == true)
                {
                    reinte.rein_pulmonesTorax2 = "SI";
                }
                if (ckb_parrillacostal.Checked == true)
                {
                    reinte.rein_parriCostalTorax2 = "SI";
                }
                if (ckb_visceras.Checked == true)
                {
                    reinte.rein_viscerasAbdomen = "SI";
                }
                if (ckb_paredabdominal.Checked == true)
                {
                    reinte.rein_paredAbdomiAbdomen = "SI";
                }
                if (ckb_flexibilidad.Checked == true)
                {
                    reinte.rein_flexibilidadColumna = "SI";
                }
                if (ckb_desviacion.Checked == true)
                {
                    reinte.rein_desviacionColumna = "SI";
                }
                if (ckb_dolor.Checked == true)
                {
                    reinte.rein_dolorColumna = "SI";
                }
                if (ckb_pelvis.Checked == true)
                {
                    reinte.rein_pelvisPelvis = "SI";
                }
                if (ckb_genitales.Checked == true)
                {
                    reinte.rein_genitalesPelvis = "SI";
                }
                if (ckb_vascular.Checked == true)
                {
                    reinte.rein_vascularExtre = "SI";
                }
                if (ckb_miembrosuperiores.Checked == true)
                {
                    reinte.rein_miemSupeExtre = "SI";
                }
                if (ckb_miembrosinferiores.Checked == true)
                {
                    reinte.rein_miemInfeExtre = "SI";
                }
                if (ckb_fuerza.Checked == true)
                {
                    reinte.rein_fuerzaNeuro = "SI";
                }
                if (ckb_sensibilidad.Checked == true)
                {
                    reinte.rein_sensibiNeuro = "SI";
                }
                if (ckb_marcha.Checked == true)
                {
                    reinte.rein_marchaNeuro = "SI";
                }
                if (ckb_reflejos.Checked == true)
                {
                    reinte.rein_refleNeuro = "SI";
                }

                //Diagnostco
                if (ckb_pre.Checked == true)
                {
                    reinte.rein_pre = "SI";
                }
                if (ckb_pre2.Checked == true)
                {
                    reinte.rein_pre2 = "SI";
                }
                if (ckb_pre3.Checked == true)
                {
                    reinte.rein_pre3 = "SI";
                }
                if (ckb_def.Checked == true)
                {
                    reinte.rein_def = "SI";
                }
                if (ckb_def2.Checked == true)
                {
                    reinte.rein_def2 = "SI";
                }
                if (ckb_def3.Checked == true)
                {
                    reinte.rein_def3 = "SI";
                }

                //Aptitud Medica para el trabajo
                if (ckb_apto.Checked == true)
                {
                    reinte.rein_apto = "SI";
                }
                if (ckb_aptoobservacion.Checked == true)
                {
                    reinte.rein_aptoObserva = "SI";
                }
                if (ckb_aptolimitacion.Checked == true)
                {
                    reinte.rein_aptoLimi = "SI";
                }
                if (ckb_noapto.Checked == true)
                {
                    reinte.rein_NoApto = "SI";
                }

                reinte = new Tbl_Reintegro
                {
                    //A
                    rein_numArchivo = txt_numArchivo.Text,
                    rein_edad = Convert.ToInt32(txt_edad.Text),
                    rein__fechUltDiaLaboral = Convert.ToDateTime(txt_fechaUltiDiaLaboral.Text),
                    rein_fechReingreso = Convert.ToDateTime(txt_fechaReingreso.Text),
                    rein_total = Convert.ToInt32(txt_total.Text),
                    rein_causaSalida = txt_causaSalida.Text,

                    //B.
                    rein_descripmotCon = txt_motivoconsultareintegro.Text,

                    //C.
                    rein_descripenfActual = txt_enfermedadactualreintegro.Text,

                    ////E.
                    //rein_cicatricesPiel = txt_cicatrices.Text,
                    //rein_tatuajesPiel = txt_tatuajes.Text,
                    //rein_pielFacerasPiel = txt_pielyfaneras.Text,
                    //rein_parpadosOjos = txt_parpados.Text,
                    //rein_conjuntuvasOjos = txt_conjuntivas.Text,
                    //rein_pupilasOjos = txt_pupilas.Text,
                    //rein_corneaOjos = txt_cornea.Text,
                    //rein_motilidadOjos = txt_motilidad.Text,
                    //rein_cAudiExtreOido = txt_auditivoexterno.Text,
                    //rein_pabellonOido = txt_pabellon.Text,
                    //rein_timpanosOido = txt_timpanos.Text,
                    //rein_labiosOroFa = txt_labios.Text,
                    //rein_lenguaOroFa = txt_lengua.Text,
                    //rein_faringeOroFa = txt_faringe.Text,
                    //rein_amigdalasOroFa = txt_amigdalas.Text,
                    //rein_dentaduraOroFa = txt_dentadura.Text,
                    //rein_tabiqueNariz = txt_tabique.Text,
                    //rein_cornetesNariz = txt_cornetes.Text,
                    //rein_mucosasNariz = txt_mucosa.Text,
                    //rein_senosParanaNariz = txt_senosparanasales.Text,
                    //rein_tiroiMasasCuello = txt_tiroides.Text,
                    //rein_movilidadCuello = txt_movilidad.Text,
                    //rein_mamasTorax = txt_mamas.Text,
                    //rein_corazonTorax = txt_corazon.Text,
                    //rein_pulmonesTorax2 = txt_pulmones.Text,
                    //rein_parriCostalTorax2 = txt_parrillacostal.Text,
                    //rein_viscerasAbdomen = txt_visceras.Text,
                    //rein_paredAbdomiAbdomen = txt_paredabdominal.Text,
                    //rein_flexibilidadColumna = txt_flexibilidad.Text,
                    //rein_desviacionColumna = txt_desviacion.Text,
                    //rein_dolorColumna = txt_dolor.Text,
                    //rein_pelvisPelvis = txt_pelvis.Text,
                    //rein_genitalesPelvis = txt_genitales.Text,
                    //rein_vascularExtre = txt_vascular.Text,
                    //rein_miemSupeExtre = txt_miembrosureinres.Text,
                    //rein_miemInfeExtre = txt_miembrosinferiores.Text,
                    //rein_fuerzaNeuro = txt_fuerza.Text,
                    //rein_sensibiNeuro = txt_sensibilidad.Text,
                    //rein_marchaNeuro = txt_marcha.Text,
                    //rein_refleNeuro = txt_reflejos.Text,
                    rein_observaexaFisRegional = txt_observexamenfisicoregional.Text,

                    //F.
                    rein_examen = txt_examen.Text,
                    rein_fecha = Convert.ToDateTime(txt_fechaexamen.Text),
                    rein_resultados = txt_resultadoexamen.Text,
                    rein_observacionesResExaGenEspRiesTrabajo = txt_observacionexamen.Text,

                    //G.
                    rein_descripcionDiagnostico = txt_descripdiagnostico.Text,
                    rein_cie = txt_cie.Text,
                    //rein_pre = txt_pre.Text,
                    //rein_def = txt_def.Text,

                    //H.
                    //rein_apto = txt_apto.Text,
                    //rein_aptoObserva = txt_aptoobservacion.Text,
                    //rein_aptoLimi = txt_aptolimitacion.Text,
                    //rein_NoApto = txt_noapto.Text,
                    rein_ObservAptMedica = txt_observacionaptitud.Text,
                    rein_LimitAptMedica = txt_limitacionaptitud.Text,
                    rein_ReubicaAptMedica = txt_reubicacionaptitud.Text,

                    //I.
                    rein_descripcionRecoTratamiento = txt_descripciontratamientoreintegro.Text,

                    //J.
                    rein_fecha_hora = Convert.ToDateTime(txt_fechahora.Text),
                    prof_id = Convert.ToInt32(ddl_profesional.SelectedValue),
                    rein_cod = txt_codigoDatProf.Text,
                    Per_id = perso
                };

                CN_Reintegro.GuardarReintegro(reinte);

                //Mensaje de confirmacion
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Guardados Exitosamente')", true);

                Response.Redirect("~/Template/Views/PacientesReintegro.aspx");

            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Guardados')", true);
            }

        }

        private void ModificarReintegro(Tbl_Reintegro reinte)
        {
            try
            {
                //Regiones
                if (ckb_cicatrices.Checked == true)
                {
                    reinte.rein_cicatricesPiel = "SI";
                }
                else
                {
                    reinte.rein_cicatricesPiel = null;
                }
                if (ckb_tatuajes.Checked == true)
                {
                    reinte.rein_tatuajesPiel = "SI";
                }
                else
                {
                    reinte.rein_tatuajesPiel = null;
                }
                if (ckb_pielyfaneras.Checked == true)
                {
                    reinte.rein_pielFacerasPiel = "SI";
                }
                else
                {
                    reinte.rein_pielFacerasPiel = null;
                }
                if (ckb_parpados.Checked == true)
                {
                    reinte.rein_parpadosOjos = "SI";
                }
                else
                {
                    reinte.rein_parpadosOjos = null;
                }
                if (ckb_conjuntivas.Checked == true)
                {
                    reinte.rein_conjuntuvasOjos = "SI";
                }
                else
                {
                    reinte.rein_conjuntuvasOjos = null;
                }
                if (ckb_pupilas.Checked == true)
                {
                    reinte.rein_pupilasOjos = "SI";
                }
                else
                {
                    reinte.rein_pupilasOjos = null;
                }
                if (ckb_cornea.Checked == true)
                {
                    reinte.rein_corneaOjos = "SI";
                }
                else
                {
                    reinte.rein_corneaOjos = null;
                }
                if (ckb_motilidad.Checked == true)
                {
                    reinte.rein_motilidadOjos = "SI";
                }
                else
                {
                    reinte.rein_motilidadOjos = null;
                }
                if (ckb_auditivoexterno.Checked == true)
                {
                    reinte.rein_cAudiExtreOido = "SI";
                }
                else
                {
                    reinte.rein_cAudiExtreOido = null;
                }
                if (ckb_pabellon.Checked == true)
                {
                    reinte.rein_pabellonOido = "SI";
                }
                else
                {
                    reinte.rein_pabellonOido = null;
                }
                if (ckb_timpanos.Checked == true)
                {
                    reinte.rein_timpanosOido = "SI";
                }
                else
                {
                    reinte.rein_timpanosOido = null;
                }
                if (ckb_labios.Checked == true)
                {
                    reinte.rein_labiosOroFa = "SI";
                }
                else
                {
                    reinte.rein_labiosOroFa = null;
                }
                if (ckb_lengua.Checked == true)
                {
                    reinte.rein_lenguaOroFa = "SI";
                }
                else
                {
                    reinte.rein_lenguaOroFa = null;
                }
                if (ckb_faringe.Checked == true)
                {
                    reinte.rein_faringeOroFa = "SI";
                }
                else
                {
                    reinte.rein_faringeOroFa = null;
                }
                if (ckb_amigdalas.Checked == true)
                {
                    reinte.rein_amigdalasOroFa = "SI";
                }
                else
                {
                    reinte.rein_amigdalasOroFa = null;
                }
                if (ckb_dentadura.Checked == true)
                {
                    reinte.rein_dentaduraOroFa = "SI";
                }
                else
                {
                    reinte.rein_dentaduraOroFa = null;
                }
                if (ckb_tabique.Checked == true)
                {
                    reinte.rein_tabiqueNariz = "SI";
                }
                else
                {
                    reinte.rein_tabiqueNariz = null;
                }
                if (ckb_cornetes.Checked == true)
                {
                    reinte.rein_cornetesNariz = "SI";
                }
                else
                {
                    reinte.rein_cornetesNariz = null;
                }
                if (ckb_mucosa.Checked == true)
                {
                    reinte.rein_mucosasNariz = "SI";
                }
                else
                {
                    reinte.rein_mucosasNariz = null;
                }
                if (ckb_senosparanasales.Checked == true)
                {
                    reinte.rein_senosParanaNariz = "SI";
                }
                else
                {
                    reinte.rein_senosParanaNariz = null;
                }
                if (ckb_tiroides.Checked == true)
                {
                    reinte.rein_tiroiMasasCuello = "SI";
                }
                else
                {
                    reinte.rein_tiroiMasasCuello = null;
                }
                if (ckb_movilidad.Checked == true)
                {
                    reinte.rein_movilidadCuello = "SI";
                }
                else
                {
                    reinte.rein_movilidadCuello = null;
                }
                if (ckb_mamas.Checked == true)
                {
                    reinte.rein_mamasTorax = "SI";
                }
                else
                {
                    reinte.rein_mamasTorax = null;
                }
                if (ckb_corazon.Checked == true)
                {
                    reinte.rein_corazonTorax = "SI";
                }
                else
                {
                    reinte.rein_corazonTorax = null;
                }
                if (ckb_pulmones.Checked == true)
                {
                    reinte.rein_pulmonesTorax2 = "SI";
                }
                else
                {
                    reinte.rein_pulmonesTorax2 = null;
                }
                if (ckb_parrillacostal.Checked == true)
                {
                    reinte.rein_parriCostalTorax2 = "SI";
                }
                else
                {
                    reinte.rein_parriCostalTorax2 = null;
                }
                if (ckb_visceras.Checked == true)
                {
                    reinte.rein_viscerasAbdomen = "SI";
                }
                else
                {
                    reinte.rein_viscerasAbdomen = null;
                }
                if (ckb_paredabdominal.Checked == true)
                {
                    reinte.rein_paredAbdomiAbdomen = "SI";
                }
                else
                {
                    reinte.rein_paredAbdomiAbdomen = null;
                }
                if (ckb_flexibilidad.Checked == true)
                {
                    reinte.rein_flexibilidadColumna = "SI";
                }
                else
                {
                    reinte.rein_flexibilidadColumna = null;
                }
                if (ckb_desviacion.Checked == true)
                {
                    reinte.rein_desviacionColumna = "SI";
                }
                else
                {
                    reinte.rein_desviacionColumna = null;
                }
                if (ckb_dolor.Checked == true)
                {
                    reinte.rein_dolorColumna = "SI";
                }
                else
                {
                    reinte.rein_dolorColumna = null;
                }
                if (ckb_pelvis.Checked == true)
                {
                    reinte.rein_pelvisPelvis = "SI";
                }
                else
                {
                    reinte.rein_pelvisPelvis = null;
                }
                if (ckb_genitales.Checked == true)
                {
                    reinte.rein_genitalesPelvis = "SI";
                }
                else
                {
                    reinte.rein_genitalesPelvis = null;
                }
                if (ckb_vascular.Checked == true)
                {
                    reinte.rein_vascularExtre = "SI";
                }
                else
                {
                    reinte.rein_vascularExtre = null;
                }
                if (ckb_miembrosuperiores.Checked == true)
                {
                    reinte.rein_miemSupeExtre = "SI";
                }
                else
                {
                    reinte.rein_miemSupeExtre = null;
                }
                if (ckb_miembrosinferiores.Checked == true)
                {
                    reinte.rein_miemInfeExtre = "SI";
                }
                else
                {
                    reinte.rein_miemInfeExtre = null;
                }
                if (ckb_fuerza.Checked == true)
                {
                    reinte.rein_fuerzaNeuro = "SI";
                }
                else
                {
                    reinte.rein_fuerzaNeuro = null;
                }
                if (ckb_sensibilidad.Checked == true)
                {
                    reinte.rein_sensibiNeuro = "SI";
                }
                else
                {
                    reinte.rein_sensibiNeuro = null;
                }
                if (ckb_marcha.Checked == true)
                {
                    reinte.rein_marchaNeuro = "SI";
                }
                else
                {
                    reinte.rein_marchaNeuro = null;
                }
                if (ckb_reflejos.Checked == true)
                {
                    reinte.rein_refleNeuro = "SI";
                }
                else
                {
                    reinte.rein_refleNeuro = null;
                }

                //Diagnostco
                if (ckb_pre.Checked == true)
                {
                    reinte.rein_pre = "SI";
                }
                else
                {
                    reinte.rein_pre = null;
                }
                if (ckb_pre2.Checked == true)
                {
                    reinte.rein_pre2 = "SI";
                }
                else
                {
                    reinte.rein_pre2 = null;
                }
                if (ckb_pre3.Checked == true)
                {
                    reinte.rein_pre3 = "SI";
                }
                else
                {
                    reinte.rein_pre3 = null;
                }
                if (ckb_def.Checked == true)
                {
                    reinte.rein_def = "SI";
                }
                else
                {
                    reinte.rein_def = null;
                }
                if (ckb_def2.Checked == true)
                {
                    reinte.rein_def2 = "SI";
                }
                else
                {
                    reinte.rein_def2 = null;
                }
                if (ckb_def3.Checked == true)
                {
                    reinte.rein_def3 = "SI";
                }
                else
                {
                    reinte.rein_def3 = null;
                }

                //Aptitud Medica para el trabajo
                if (ckb_apto.Checked == true)
                {
                    reinte.rein_apto = "SI";
                }
                else
                {
                    reinte.rein_apto = null;
                }
                if (ckb_aptoobservacion.Checked == true)
                {
                    reinte.rein_aptoObserva = "SI";
                }
                else
                {
                    reinte.rein_aptoObserva = null;
                }
                if (ckb_aptolimitacion.Checked == true)
                {
                    reinte.rein_aptoLimi = "SI";
                }
                else
                {
                    reinte.rein_aptoLimi = null;
                }
                if (ckb_noapto.Checked == true)
                {
                    reinte.rein_NoApto = "SI";
                }
                else
                {
                    reinte.rein_NoApto = null;
                }

                //A
                reinte.rein_numArchivo = txt_numArchivo.Text;
                reinte.rein_edad = Convert.ToInt32(txt_edad.Text);
                reinte.rein__fechUltDiaLaboral = Convert.ToDateTime(txt_fechaUltiDiaLaboral.Text);
                reinte.rein_fechReingreso = Convert.ToDateTime(txt_fechaReingreso.Text);
                reinte.rein_total = Convert.ToInt32(txt_total.Text);
                reinte.rein_causaSalida = txt_causaSalida.Text;

                //B.
                reinte.rein_descripmotCon = txt_motivoconsultareintegro.Text;

                //C.
                reinte.rein_descripenfActual = txt_enfermedadactualreintegro.Text;

                ////E.
                //reinte.rein_cicatricesPiel = txt_cicatrices.Text;
                //reinte.rein_tatuajesPiel = txt_tatuajes.Text;
                //reinte.rein_pielFacerasPiel = txt_pielyfaneras.Text;
                //reinte.rein_parpadosOjos = txt_parpados.Text;
                //reinte.rein_conjuntuvasOjos = txt_conjuntivas.Text;
                //reinte.rein_pupilasOjos = txt_pupilas.Text;
                //reinte.rein_corneaOjos = txt_cornea.Text;
                //reinte.rein_motilidadOjos = txt_motilidad.Text;
                //reinte.rein_cAudiExtreOido = txt_auditivoexterno.Text;
                //reinte.rein_pabellonOido = txt_pabellon.Text;
                //reinte.rein_timpanosOido = txt_timpanos.Text;
                //reinte.rein_labiosOroFa = txt_labios.Text;
                //reinte.rein_lenguaOroFa = txt_lengua.Text;
                //reinte.rein_faringeOroFa = txt_faringe.Text;
                //reinte.rein_amigdalasOroFa = txt_amigdalas.Text;
                //reinte.rein_dentaduraOroFa = txt_dentadura.Text;
                //reinte.rein_tabiqueNariz = txt_tabique.Text;
                //reinte.rein_cornetesNariz = txt_cornetes.Text;
                //reinte.rein_mucosasNariz = txt_mucosa.Text;
                //reinte.rein_senosParanaNariz = txt_senosparanasales.Text;
                //reinte.rein_tiroiMasasCuello = txt_tiroides.Text;
                //reinte.rein_movilidadCuello = txt_movilidad.Text;
                //reinte.rein_mamasTorax = txt_mamas.Text;
                //reinte.rein_corazonTorax = txt_corazon.Text;
                //reinte.rein_pulmonesTorax2 = txt_pulmones.Text;
                //reinte.rein_parriCostalTorax2 = txt_parrillacostal.Text;
                //reinte.rein_viscerasAbdomen = txt_visceras.Text;
                //reinte.rein_paredAbdomiAbdomen = txt_paredabdominal.Text;
                //reinte.rein_flexibilidadColumna = txt_flexibilidad.Text;
                //reinte.rein_desviacionColumna = txt_desviacion.Text;
                //reinte.rein_dolorColumna = txt_dolor.Text;
                //reinte.rein_pelvisPelvis = txt_pelvis.Text;
                //reinte.rein_genitalesPelvis = txt_genitales.Text;
                //reinte.rein_vascularExtre = txt_vascular.Text;
                //reinte.rein_miemSupeExtre = txt_miembrosureinres.Text;
                //reinte.rein_miemInfeExtre = txt_miembrosinferiores.Text;
                //reinte.rein_fuerzaNeuro = txt_fuerza.Text;
                //reinte.rein_sensibiNeuro = txt_sensibilidad.Text;
                //reinte.rein_marchaNeuro = txt_marcha.Text;
                //reinte.rein_refleNeuro = txt_reflejos.Text;
                reinte.rein_observaexaFisRegional = txt_observexamenfisicoregional.Text;

                //F.
                reinte.rein_examen = txt_examen.Text;
                reinte.rein_fecha = Convert.ToDateTime(txt_fechaexamen.Text);
                reinte.rein_resultados = txt_resultadoexamen.Text;
                reinte.rein_observacionesResExaGenEspRiesTrabajo = txt_observacionexamen.Text;

                //G.
                reinte.rein_descripcionDiagnostico = txt_descripdiagnostico.Text;
                reinte.rein_cie = txt_cie.Text;
                //reinte.rein_pre = txt_pre.Text;
                //reinte.rein_def = txt_def.Text;

                //H.
                //reinte.rein_apto = txt_apto.Text;
                //reinte.rein_aptoObserva = txt_aptoobservacion.Text;
                //reinte.rein_aptoLimi = txt_aptolimitacion.Text;
                //reinte.rein_NoApto = txt_noapto.Text;
                reinte.rein_ObservAptMedica = txt_observacionaptitud.Text;
                reinte.rein_LimitAptMedica = txt_limitacionaptitud.Text;
                reinte.rein_ReubicaAptMedica = txt_reubicacionaptitud.Text;

                //I.
                reinte.rein_descripcionRecoTratamiento = txt_descripciontratamientoreintegro.Text;

                //J.
                reinte.rein_fecha_hora = Convert.ToDateTime(txt_fechahora.Text);
                reinte.prof_id = Convert.ToInt32(ddl_profesional.SelectedValue);
                reinte.rein_cod = txt_codigoDatProf.Text;

                CN_Reintegro.ModificarReintegro(reinte);

                //Mensaje de confirmacion
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Modificados Exitosamente')", true);

                Response.Redirect("~/Template/Views/PacientesReintegro.aspx");
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Modificados')", true);
            }
        }

        private void guardar_modificar_datos(int reintegro)
        {
            if (reintegro == 0)
            {
                GuardarReintegro();
            }
            else
            {
                reinte = CN_Reintegro.ObtenerReintegroPorId(reintegro);

                if (per != null)
                {
                    ModificarReintegro(reinte);
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