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
                        txt_priNombre.Text = per.Per_priNombre.ToString();
                        txt_segNombre.Text = per.Per_segNombre.ToString();
                        txt_priApellido.Text = per.Per_priApellido.ToString();
                        txt_segApellido.Text = per.Per_segApellido.ToString();
                        txt_sexo.Text = per.Per_genero.ToString();
                        DateTime edad = Convert.ToDateTime(per.Per_fechaNacimiento);
                        DateTime naci = Convert.ToDateTime(edad);
                        DateTime actual = DateTime.Now;
                        Calculo(naci, actual);
                        txt_numHClinica.Text = per.Per_cedula.ToString();
                        txt_puestoTrabajo.Text = per.Per_puestoTrabajo.ToString();

                        if (reinte != null)
                        {
                            //A
                            txt_numArchivo.Text = reinte.rein_numArchivo.ToString();
                            if (reinte.rein__fechUltDiaLaboral == "")
                            {
                                txt_fechaUltiDiaLaboral.Text = reinte.rein__fechUltDiaLaboral.ToString();
                            }
                            else
                            {
                                txt_fechaUltiDiaLaboral.Text = Convert.ToDateTime(reinte.rein__fechUltDiaLaboral).ToString("yyyy-MM-dd");
                            }
                            if (reinte.rein_fechReingreso == "")
                            {
                                txt_fechaReingreso.Text = reinte.rein_fechReingreso.ToString();
                            }
                            else
                            {
                                txt_fechaReingreso.Text = Convert.ToDateTime(reinte.rein_fechReingreso).ToString("yyyy-MM-dd");
                            }                            
                            txt_total.Text = reinte.rein_total.ToString();
                            txt_causaSalida.Text = reinte.rein_causaSalida.ToString();

                            //B
                            txt_motivoconsultareintegro.Text = reinte.rein_descripmotCon.ToString();

                            //C
                            txt_enfermedadactualreintegro.Text = reinte.rein_descripenfActual.ToString();

                            //D
                            txt_preArterial.Text = reinte.rein_preArterial.ToString();
                            txt_temperatura.Text = reinte.rein_temperatura.ToString();
                            txt_freCardica.Text = reinte.rein_frecCardiacan.ToString();
                            txt_satOxigeno.Text = reinte.rein_satOxigenon.ToString();
                            txt_freRespiratoria.Text = reinte.rein_frecRespiratorian.ToString();
                            txt_peso.Text = reinte.rein_peson.ToString();
                            txt_talla.Text = reinte.rein_tallan.ToString();
                            txt_indMasCorporal.Text = reinte.rein_indMasCorporaln.ToString();
                            txt_perAbdominal.Text = reinte.rein_perAbdominaln.ToString();

                            //E                            
                            txt_observexamenfisicoregional.Text = reinte.rein_observaexaFisRegional.ToString();

                            //F
                            txt_examen.Text = reinte.rein_examen.ToString();
                            if (reinte.rein_fecha == "")
                            {
                                txt_fechaexamen.Text = reinte.rein_fecha.ToString();
                            }
                            else
                            {
                                txt_fechaexamen.Text = Convert.ToDateTime(reinte.rein_fecha).ToString("yyyy-MM-dd");
                            }                            
                            txt_resultadoexamen.Text = reinte.rein_resultados.ToString();
                            txt_examen2.Text = reinte.rein_examen2.ToString();
                            if (reinte.rein_fecha2 == "")
                            {
                                txt_fechaexamen2.Text = reinte.rein_fecha2.ToString();
                            }
                            else
                            {
                                txt_fechaexamen2.Text = Convert.ToDateTime(reinte.rein_fecha2).ToString("yyyy-MM-dd");
                            }                            
                            txt_resultadoexamen2.Text = reinte.rein_resultados2.ToString();
                            txt_examen3.Text = reinte.rein_examen3.ToString();
                            if (reinte.rein_fecha3 == "")
                            {
                                txt_fechaexamen3.Text = reinte.rein_fecha3.ToString();
                            }
                            else
                            {
                                txt_fechaexamen3.Text = Convert.ToDateTime(reinte.rein_fecha3).ToString("yyyy-MM-dd");
                            }                            
                            txt_resultadoexamen3.Text = reinte.rein_resultados3.ToString();
                            txt_observacionexamen.Text = reinte.rein_observacionesResExaGenEspRiesTrabajo.ToString();

                            //G
                            txt_descripdiagnostico.Text = reinte.rein_descripcionDiagnostico.ToString();
                            txt_cie.Text = reinte.rein_cie.ToString();
                            txt_descripdiagnostico2.Text = reinte.rein_descripcionDiagnostico2.ToString();
                            txt_cie2.Text = reinte.rein_cie2.ToString();
                            txt_descripdiagnostico3.Text = reinte.rein_descripcionDiagnostico3.ToString();
                            txt_cie3.Text = reinte.rein_cie3.ToString();
                            
                            //H
                            txt_observacionaptitud.Text = reinte.rein_ObservAptMedica.ToString();
                            txt_limitacionaptitud.Text = reinte.rein_LimitAptMedica.ToString();
                            txt_reubicacionaptitud.Text = reinte.rein_ReubicaAptMedica.ToString();

                            //I
                            txt_descripciontratamientoreintegro.Text = reinte.rein_descripcionRecoTratamiento.ToString();

                            //J
                            if (reinte.rein_fecha_hora == "")
                            {
                                txt_fechahora.Text = reinte.rein_fecha_hora.ToString(); 
                            }
                            else
                            {
                                txt_fechahora.Text = Convert.ToDateTime(reinte.rein_fecha_hora).ToString("yyyy-MM-ddTHH:mm");
                            }                            
                            ddl_profesional.SelectedValue = reinte.prof_id.ToString();
                            txt_codigoDatProf.Text = reinte.rein_cod.ToString();
                        }
                    }                    
                }

                if (reinte.rein_fecha_hora == null)
                {
                    txt_fechahora.Text = DateTime.Now.ToLocalTime().ToString("yyyy-MM-ddTHH:mm");
                }

                cargarProfesional();
                //defaultValidaciones();
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

        //Metodo obtener numero de cedula
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

        protected void txt_descripdiagnostico2_TextChanged(object sender, EventArgs e)
        {
            ObtenerCodigo2();
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

        protected void txt_descripdiagnostico3_TextChanged(object sender, EventArgs e)
        {
            ObtenerCodigo3();
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

        private void GuardarReintegro()
        {
            try
            {
                per = CN_HistorialMedico.ObtenerIdPersonasxCedula(Convert.ToInt32(txt_numHClinica.Text));

                int perso = Convert.ToInt32(per.Per_id.ToString());

                reinte = new Tbl_Reintegro();

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

                //A
                reinte.rein_numArchivo = txt_numArchivo.Text;
                reinte.rein__fechUltDiaLaboral = txt_fechaUltiDiaLaboral.Text;
                reinte.rein_fechReingreso = txt_fechaReingreso.Text;
                reinte.rein_total = txt_total.Text;
                reinte.rein_causaSalida = txt_causaSalida.Text;

                //B.
                reinte.rein_descripmotCon = txt_motivoconsultareintegro.Text;

                //C.
                reinte.rein_descripenfActual = txt_enfermedadactualreintegro.Text;

                //D
                reinte.rein_preArterial = txt_preArterial.Text;
                reinte.rein_temperatura = txt_temperatura.Text;
                reinte.rein_frecCardiacan = txt_freCardica.Text;
                reinte.rein_satOxigenon = txt_satOxigeno.Text;
                reinte.rein_frecRespiratorian = txt_freRespiratoria.Text;
                reinte.rein_peson = txt_peso.Text;
                reinte.rein_tallan = txt_talla.Text;
                reinte.rein_indMasCorporaln = txt_indMasCorporal.Text;
                reinte.rein_perAbdominaln = txt_perAbdominal.Text;

                //E.                    
                reinte.rein_observaexaFisRegional = txt_observexamenfisicoregional.Text;

                //F.
                reinte.rein_examen = txt_examen.Text;
                reinte.rein_fecha = txt_fechaexamen.Text;
                reinte.rein_resultados = txt_resultadoexamen.Text;
                reinte.rein_examen2 = txt_examen2.Text;
                reinte.rein_fecha2 = txt_fechaexamen2.Text;
                reinte.rein_resultados2 = txt_resultadoexamen2.Text;
                reinte.rein_examen3 = txt_examen3.Text;
                reinte.rein_fecha3 = txt_fechaexamen3.Text;
                reinte.rein_resultados3 = txt_resultadoexamen3.Text;
                reinte.rein_observacionesResExaGenEspRiesTrabajo = txt_observacionexamen.Text;

                //G.
                reinte.rein_descripcionDiagnostico = txt_descripdiagnostico.Text;
                reinte.rein_cie = txt_cie.Text;
                reinte.rein_descripcionDiagnostico2 = txt_descripdiagnostico2.Text;
                reinte.rein_cie2 = txt_cie2.Text;
                reinte.rein_descripcionDiagnostico3 = txt_descripdiagnostico3.Text;
                reinte.rein_cie3 = txt_cie3.Text;

                //H.
                reinte.rein_ObservAptMedica = txt_observacionaptitud.Text;
                reinte.rein_LimitAptMedica = txt_limitacionaptitud.Text;
                reinte.rein_ReubicaAptMedica = txt_reubicacionaptitud.Text;

                //I.
                reinte.rein_descripcionRecoTratamiento = txt_descripciontratamientoreintegro.Text;

                //J.
                reinte.rein_fecha_hora = txt_fechahora.Text;
                reinte.prof_id = Convert.ToInt32(ddl_profesional.SelectedValue);
                reinte.rein_cod = txt_codigoDatProf.Text;
                reinte.Per_id = perso;

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
                reinte.rein__fechUltDiaLaboral = txt_fechaUltiDiaLaboral.Text;
                reinte.rein_fechReingreso = txt_fechaReingreso.Text;
                reinte.rein_total = txt_total.Text;
                reinte.rein_causaSalida = txt_causaSalida.Text;

                //B.
                reinte.rein_descripmotCon = txt_motivoconsultareintegro.Text;

                //C.
                reinte.rein_descripenfActual = txt_enfermedadactualreintegro.Text;

                //D
                reinte.rein_preArterial = txt_preArterial.Text;
                reinte.rein_temperatura = txt_temperatura.Text;
                reinte.rein_frecCardiacan = txt_freCardica.Text;
                reinte.rein_satOxigenon = txt_satOxigeno.Text;
                reinte.rein_frecRespiratorian = txt_freRespiratoria.Text;
                reinte.rein_peson = txt_peso.Text;
                reinte.rein_tallan = txt_talla.Text;
                reinte.rein_indMasCorporaln = txt_indMasCorporal.Text;
                reinte.rein_perAbdominaln = txt_perAbdominal.Text;

                //E.                    
                reinte.rein_observaexaFisRegional = txt_observexamenfisicoregional.Text;

                //F.
                reinte.rein_examen = txt_examen.Text;
                reinte.rein_fecha = txt_fechaexamen.Text;
                reinte.rein_resultados = txt_resultadoexamen.Text;
                reinte.rein_examen2 = txt_examen2.Text;
                reinte.rein_fecha2 = txt_fechaexamen2.Text;
                reinte.rein_resultados2 = txt_resultadoexamen2.Text;
                reinte.rein_examen3 = txt_examen3.Text;
                reinte.rein_fecha3 = txt_fechaexamen3.Text;
                reinte.rein_resultados3 = txt_resultadoexamen3.Text;
                reinte.rein_observacionesResExaGenEspRiesTrabajo = txt_observacionexamen.Text;

                //G.
                reinte.rein_descripcionDiagnostico = txt_descripdiagnostico.Text;
                reinte.rein_cie = txt_cie.Text;
                reinte.rein_descripcionDiagnostico2 = txt_descripdiagnostico2.Text;
                reinte.rein_cie2 = txt_cie2.Text;
                reinte.rein_descripcionDiagnostico3 = txt_descripdiagnostico3.Text;
                reinte.rein_cie3 = txt_cie3.Text;

                //H.
                reinte.rein_ObservAptMedica = txt_observacionaptitud.Text;
                reinte.rein_LimitAptMedica = txt_limitacionaptitud.Text;
                reinte.rein_ReubicaAptMedica = txt_reubicacionaptitud.Text;

                //I.
                reinte.rein_descripcionRecoTratamiento = txt_descripciontratamientoreintegro.Text;

                //J.
                reinte.rein_fecha_hora = txt_fechahora.Text;
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

        protected void ckb_pre_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_pre.Checked == true)
            {
                ckb_def.Checked = false;
            }
        }

        protected void ckb_def_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_def.Checked == true)
            {
                ckb_pre.Checked = false;
            }
        }

        protected void ckb_pre2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_pre2.Checked == true)
            {
                ckb_def2.Checked = false;
            }
        }

        protected void ckb_def2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_def2.Checked == true)
            {
                ckb_pre2.Checked = false;
            }
        }

        protected void ckb_def3_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_def3.Checked == true)
            {
                ckb_pre3.Checked = false;
            }
        }

        protected void ckb_pre3_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_pre3.Checked == true)
            {
                ckb_def3.Checked = false;
            }
        }

        
    }
}