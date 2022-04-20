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
                        txt_numHClinica.Text = per.Per_Cedula.ToString();

                        if (reinte != null)
                        {
                            //A
                            txt_fechaUltiDiaLaboral.Text = reinte.rein__fechUltDiaLaboral.ToString();
                            txt_fechaReingreso.Text = reinte.rein_fechReingreso.ToString();
                            txt_total.Text = reinte.rein_total.ToString();
                            txt_causaSalida.Text = reinte.rein_causaSalida.ToString();

                            //B
                            txt_motivoconsultareintegro.Text = reinte.rein_descripmotCon.ToString();

                            //C
                            txt_enfermedadactualreintegro.Text = reinte.rein_descripenfActual.ToString();

                            //E
                            txt_cicatrices.Text = reinte.rein_cicatricesPiel.ToString();
                            txt_tatuajes.Text = reinte.rein_tatuajesPiel.ToString();
                            txt_pielyfaneras.Text = reinte.rein_pielFacerasPiel.ToString();
                            txt_parpados.Text = reinte.rein_parpadosOjos.ToString();
                            txt_conjuntivas.Text = reinte.rein_conjuntuvasOjos.ToString();
                            txt_pupilas.Text = reinte.rein_pupilasOjos.ToString();
                            txt_cornea.Text = reinte.rein_corneaOjos.ToString();
                            txt_motilidad.Text = reinte.rein_motilidadOjos.ToString();
                            txt_auditivoexterno.Text = reinte.rein_cAudiExtreOido.ToString();
                            txt_pabellon.Text = reinte.rein_pabellonOido.ToString();
                            txt_timpanos.Text = reinte.rein_timpanosOido.ToString();
                            txt_labios.Text = reinte.rein_labiosOroFa.ToString();
                            txt_lengua.Text = reinte.rein_lenguaOroFa.ToString();
                            txt_faringe.Text = reinte.rein_faringeOroFa.ToString();
                            txt_amigdalas.Text = reinte.rein_amigdalasOroFa.ToString();
                            txt_dentadura.Text = reinte.rein_dentaduraOroFa.ToString();
                            txt_tabique.Text = reinte.rein_tabiqueNariz.ToString();
                            txt_cornetes.Text = reinte.rein_cornetesNariz.ToString();
                            txt_mucosa.Text = reinte.rein_mucosasNariz.ToString();
                            txt_senosparanasales.Text = reinte.rein_senosParanaNariz.ToString();
                            txt_tiroides.Text = reinte.rein_tiroiMasasCuello.ToString();
                            txt_movilidad.Text = reinte.rein_movilidadCuello.ToString();
                            txt_mamas.Text = reinte.rein_mamasTorax.ToString();
                            txt_corazon.Text = reinte.rein_corazonTorax.ToString();
                            txt_pulmones.Text = reinte.rein_pulmonesTorax2.ToString();
                            txt_parrillacostal.Text = reinte.rein_parriCostalTorax2.ToString();
                            txt_visceras.Text = reinte.rein_viscerasAbdomen.ToString();
                            txt_paredabdominal.Text = reinte.rein_paredAbdomiAbdomen.ToString();
                            txt_flexibilidad.Text = reinte.rein_flexibilidadColumna.ToString();
                            txt_desviacion.Text = reinte.rein_desviacionColumna.ToString();
                            txt_dolor.Text = reinte.rein_dolorColumna.ToString();
                            txt_pelvis.Text = reinte.rein_pelvisPelvis.ToString();
                            txt_genitales.Text = reinte.rein_genitalesPelvis.ToString();
                            txt_vascular.Text = reinte.rein_vascularExtre.ToString();
                            txt_miembrosuperiores.Text = reinte.rein_miemSupeExtre.ToString();
                            txt_miembrosinferiores.Text = reinte.rein_miemInfeExtre.ToString();
                            txt_fuerza.Text = reinte.rein_fuerzaNeuro.ToString();
                            txt_sensibilidad.Text = reinte.rein_sensibiNeuro.ToString();
                            txt_marcha.Text = reinte.rein_marchaNeuro.ToString();
                            txt_reflejos.Text = reinte.rein_refleNeuro.ToString();
                            txt_obervexamenfisicoregional.Text = reinte.rein_observaexaFisRegional.ToString();

                            //F
                            txt_examen.Text = reinte.rein_examen.ToString();
                            txt_fechaexamen.Text = reinte.rein_fecha.ToString();
                            txt_resultadoexamen.Text = reinte.rein_resultados.ToString();
                            txt_observacionexamen.Text = reinte.rein_observacionesResExaGenEspRiesTrabajo.ToString();

                            //G
                            txt_descripdiagnostico.Text = reinte.rein_descripcionDiagnostico.ToString();
                            txt_cie.Text = reinte.rein_cie.ToString();
                            txt_pre.Text = reinte.rein_pre.ToString();
                            txt_def.Text = reinte.rein_def.ToString();

                            //H
                            txt_apto.Text = reinte.rein_apto.ToString();
                            txt_aptoobservacion.Text = reinte.rein_aptoObserva.ToString();
                            txt_aptolimitacion.Text = reinte.rein_aptoLimi.ToString();
                            txt_noapto.Text = reinte.rein_NoApto.ToString();
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

                string sexo = item.Per_genero;
                txt_sexo.Text = sexo;

                string edad = Convert.ToString(item.Per_fechNacimiento);
                txt_edad.Text = edad;
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

        private void GuardarReintegro()
        {
            try
            {
                per = CN_HistorialMedico.ObtenerIdPersonasxCedula(Convert.ToInt32(txt_numHClinica.Text));

                int perso = Convert.ToInt32(per.Per_id.ToString());

                reinte = new Tbl_Reintegro
                {
                    //A
                    rein__fechUltDiaLaboral = Convert.ToDateTime(txt_fechaUltiDiaLaboral.Text),
                    rein_fechReingreso = Convert.ToDateTime(txt_fechaReingreso.Text),
                    rein_total = Convert.ToInt32(txt_total.Text),
                    rein_causaSalida = txt_causaSalida.Text,

                    //B.
                    rein_descripmotCon = txt_motivoconsultareintegro.Text,

                    //C.
                    rein_descripenfActual = txt_enfermedadactualreintegro.Text,

                    //E.
                    rein_cicatricesPiel = txt_cicatrices.Text,
                    rein_tatuajesPiel = txt_tatuajes.Text,
                    rein_pielFacerasPiel = txt_pielyfaneras.Text,
                    rein_parpadosOjos = txt_parpados.Text,
                    rein_conjuntuvasOjos = txt_conjuntivas.Text,
                    rein_pupilasOjos = txt_pupilas.Text,
                    rein_corneaOjos = txt_cornea.Text,
                    rein_motilidadOjos = txt_motilidad.Text,
                    rein_cAudiExtreOido = txt_auditivoexterno.Text,
                    rein_pabellonOido = txt_pabellon.Text,
                    rein_timpanosOido = txt_timpanos.Text,
                    rein_labiosOroFa = txt_labios.Text,
                    rein_lenguaOroFa = txt_lengua.Text,
                    rein_faringeOroFa = txt_faringe.Text,
                    rein_amigdalasOroFa = txt_amigdalas.Text,
                    rein_dentaduraOroFa = txt_dentadura.Text,
                    rein_tabiqueNariz = txt_tabique.Text,
                    rein_cornetesNariz = txt_cornetes.Text,
                    rein_mucosasNariz = txt_mucosa.Text,
                    rein_senosParanaNariz = txt_senosparanasales.Text,
                    rein_tiroiMasasCuello = txt_tiroides.Text,
                    rein_movilidadCuello = txt_movilidad.Text,
                    rein_mamasTorax = txt_mamas.Text,
                    rein_corazonTorax = txt_corazon.Text,
                    rein_pulmonesTorax2 = txt_pulmones.Text,
                    rein_parriCostalTorax2 = txt_parrillacostal.Text,
                    rein_viscerasAbdomen = txt_visceras.Text,
                    rein_paredAbdomiAbdomen = txt_paredabdominal.Text,
                    rein_flexibilidadColumna = txt_flexibilidad.Text,
                    rein_desviacionColumna = txt_desviacion.Text,
                    rein_dolorColumna = txt_dolor.Text,
                    rein_pelvisPelvis = txt_pelvis.Text,
                    rein_genitalesPelvis = txt_genitales.Text,
                    rein_vascularExtre = txt_vascular.Text,
                    rein_miemSupeExtre = txt_miembrosuperiores.Text,
                    rein_miemInfeExtre = txt_miembrosinferiores.Text,
                    rein_fuerzaNeuro = txt_fuerza.Text,
                    rein_sensibiNeuro = txt_sensibilidad.Text,
                    rein_marchaNeuro = txt_marcha.Text,
                    rein_refleNeuro = txt_reflejos.Text,
                    rein_observaexaFisRegional = txt_obervexamenfisicoregional.Text,

                    //F.
                    rein_examen = txt_examen.Text,
                    rein_fecha = Convert.ToDateTime(txt_fechaexamen.Text),
                    rein_resultados = txt_resultadoexamen.Text,
                    rein_observacionesResExaGenEspRiesTrabajo = txt_observacionexamen.Text,

                    //G.
                    rein_descripcionDiagnostico = txt_descripdiagnostico.Text,
                    rein_cie = txt_cie.Text,
                    rein_pre = txt_pre.Text,
                    rein_def = txt_def.Text,

                    //H.
                    rein_apto = txt_apto.Text,
                    rein_aptoObserva = txt_aptoobservacion.Text,
                    rein_aptoLimi = txt_aptolimitacion.Text,
                    rein_NoApto = txt_noapto.Text,
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
                //A
                reinte.rein__fechUltDiaLaboral = Convert.ToDateTime(txt_fechaUltiDiaLaboral.Text);
                reinte.rein_fechReingreso = Convert.ToDateTime(txt_fechaReingreso.Text);
                reinte.rein_total = Convert.ToInt32(txt_total.Text);
                reinte.rein_causaSalida = txt_causaSalida.Text;

                //B.
                reinte.rein_descripmotCon = txt_motivoconsultareintegro.Text;

                //C.
                reinte.rein_descripenfActual = txt_enfermedadactualreintegro.Text;

                //E.
                reinte.rein_cicatricesPiel = txt_cicatrices.Text;
                reinte.rein_tatuajesPiel = txt_tatuajes.Text;
                reinte.rein_pielFacerasPiel = txt_pielyfaneras.Text;
                reinte.rein_parpadosOjos = txt_parpados.Text;
                reinte.rein_conjuntuvasOjos = txt_conjuntivas.Text;
                reinte.rein_pupilasOjos = txt_pupilas.Text;
                reinte.rein_corneaOjos = txt_cornea.Text;
                reinte.rein_motilidadOjos = txt_motilidad.Text;
                reinte.rein_cAudiExtreOido = txt_auditivoexterno.Text;
                reinte.rein_pabellonOido = txt_pabellon.Text;
                reinte.rein_timpanosOido = txt_timpanos.Text;
                reinte.rein_labiosOroFa = txt_labios.Text;
                reinte.rein_lenguaOroFa = txt_lengua.Text;
                reinte.rein_faringeOroFa = txt_faringe.Text;
                reinte.rein_amigdalasOroFa = txt_amigdalas.Text;
                reinte.rein_dentaduraOroFa = txt_dentadura.Text;
                reinte.rein_tabiqueNariz = txt_tabique.Text;
                reinte.rein_cornetesNariz = txt_cornetes.Text;
                reinte.rein_mucosasNariz = txt_mucosa.Text;
                reinte.rein_senosParanaNariz = txt_senosparanasales.Text;
                reinte.rein_tiroiMasasCuello = txt_tiroides.Text;
                reinte.rein_movilidadCuello = txt_movilidad.Text;
                reinte.rein_mamasTorax = txt_mamas.Text;
                reinte.rein_corazonTorax = txt_corazon.Text;
                reinte.rein_pulmonesTorax2 = txt_pulmones.Text;
                reinte.rein_parriCostalTorax2 = txt_parrillacostal.Text;
                reinte.rein_viscerasAbdomen = txt_visceras.Text;
                reinte.rein_paredAbdomiAbdomen = txt_paredabdominal.Text;
                reinte.rein_flexibilidadColumna = txt_flexibilidad.Text;
                reinte.rein_desviacionColumna = txt_desviacion.Text;
                reinte.rein_dolorColumna = txt_dolor.Text;
                reinte.rein_pelvisPelvis = txt_pelvis.Text;
                reinte.rein_genitalesPelvis = txt_genitales.Text;
                reinte.rein_vascularExtre = txt_vascular.Text;
                reinte.rein_miemSupeExtre = txt_miembrosuperiores.Text;
                reinte.rein_miemInfeExtre = txt_miembrosinferiores.Text;
                reinte.rein_fuerzaNeuro = txt_fuerza.Text;
                reinte.rein_sensibiNeuro = txt_sensibilidad.Text;
                reinte.rein_marchaNeuro = txt_marcha.Text;
                reinte.rein_refleNeuro = txt_reflejos.Text;
                reinte.rein_observaexaFisRegional = txt_obervexamenfisicoregional.Text;

                //F.
                reinte.rein_examen = txt_examen.Text;
                reinte.rein_fecha = Convert.ToDateTime(txt_fechaexamen.Text);
                reinte.rein_resultados = txt_resultadoexamen.Text;
                reinte.rein_observacionesResExaGenEspRiesTrabajo = txt_observacionexamen.Text;

                //G.
                reinte.rein_descripcionDiagnostico = txt_descripdiagnostico.Text;
                reinte.rein_cie = txt_cie.Text;
                reinte.rein_pre = txt_pre.Text;
                reinte.rein_def = txt_def.Text;

                //H.
                reinte.rein_apto = txt_apto.Text;
                reinte.rein_aptoObserva = txt_aptoobservacion.Text;
                reinte.rein_aptoLimi = txt_aptolimitacion.Text;
                reinte.rein_NoApto = txt_noapto.Text;
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