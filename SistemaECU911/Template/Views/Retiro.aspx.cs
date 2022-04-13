using CapaDatos;
using CapaNegocio;
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

namespace SistemaECU911.Template.Views
{
    public partial class Retiro : System.Web.UI.Page
    {
        DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        private Tbl_Personas per = new Tbl_Personas();

        private Tbl_Retiro reti = new Tbl_Retiro();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["cod"] != null)
                {
                    int codigo = Convert.ToInt32(Request["cod"]);

                    per = CN_HistorialMedico.ObtenerPersonasxId(codigo);
                    int perso = Convert.ToInt32(per.Per_id.ToString());
                    reti = CN_Retiro.ObtenerRetiroPer(codigo);
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

                        if (reti != null)
                        {
                            //A
                            txt_fechaIniLabores.Text = reti.ret__fechIniLabores.ToString();
                            txt_fechaSalida.Text = reti.ret_fechSalida.ToString();
                            txt_tiempo.Text = reti.ret_tiempo.ToString();
                            txt_actividades1.Text = reti.ret_actividades.ToString();
                            txt_facRiesgo1.Text = reti.ret_facRiesgo.ToString();

                            //B
                            txt_descripcionantiqui.Text = reti.ret_descripAntCliQuiru.ToString();

                            txt_siCalificadoIESSAcciTrabajo.Text = reti.ret_siCalificadoIESSAcciTrabajo.ToString();
                            txt_EspecifiCalificadoIESSAcciTrabajo.Text = reti.ret_EspecifiCalificadoIESSAcciTrabajo.ToString();
                            txt_noCalificadoIESSAcciTrabajo.Text = reti.ret_noCalificadoIESSAcciTrabajo.ToString();
                            txt_fechaCalificadoIESSAcciTrabajo.Text = reti.ret_fechaCalificadoIESSAcciTrabajo.ToString();
                            txt_observacionesAcciTrabajo.Text = reti.ret_observacionesAcciTrabajo.ToString();
                            txt_detalleAcciTrabajo.Text = reti.ret_detalleAcciTrabajo.ToString();

                            txt_siCalificadoIESSEnferProfesionales.Text = reti.ret_siCalificadoIESSEnferProfesionales.ToString();
                            txt_EspecifiCalificadoIESSEnferProfesionales.Text = reti.ret_EspecifiCalificadoIESSEnferProfesionales.ToString();
                            txt_noCalificadoIESSEnferProfesionales.Text = reti.ret_noCalificadoIESSEnferProfesionales.ToString();
                            txt_fechaCalificadoIESSEnferProfesionales.Text = reti.ret_fechaCalificadoIESSEnferProfesionales.ToString();
                            txt_observacionesEnferProfesionales.Text = reti.ret_observacionesEnferProfesionales.ToString();
                            txt_detalleEnferProfesionales.Text = reti.ret_detalleEnferProfesionales.ToString();

                            //D
                            txt_cicatrices.Text = reti.ret_cicatricesPiel.ToString();
                            txt_tatuajes.Text = reti.ret_tatuajesPiel.ToString();
                            txt_pielyfaneras.Text = reti.ret_pielFacerasPiel.ToString();
                            txt_parpados.Text = reti.ret_parpadosOjos.ToString();
                            txt_conjuntivas.Text = reti.ret_conjuntuvasOjos.ToString();
                            txt_pupilas.Text = reti.ret_pupilasOjos.ToString();
                            txt_cornea.Text = reti.ret_corneaOjos.ToString();
                            txt_motilidad.Text = reti.ret_motilidadOjos.ToString();
                            txt_auditivoexterno.Text = reti.ret_cAudiExtreOido.ToString();
                            txt_pabellon.Text = reti.ret_pabellonOido.ToString();
                            txt_timpanos.Text = reti.ret_timpanosOido.ToString();
                            txt_labios.Text = reti.ret_labiosOroFa.ToString();
                            txt_lengua.Text = reti.ret_lenguaOroFa.ToString();
                            txt_faringe.Text = reti.ret_faringeOroFa.ToString();
                            txt_amigdalas.Text = reti.ret_amigdalasOroFa.ToString();
                            txt_dentadura.Text = reti.ret_dentaduraOroFa.ToString();
                            txt_tabique.Text = reti.ret_tabiqueNariz.ToString();
                            txt_cornetes.Text = reti.ret_cornetesNariz.ToString();
                            txt_mucosa.Text = reti.ret_mucosasNariz.ToString();
                            txt_senosparanasales.Text = reti.ret_senosParanaNariz.ToString();
                            txt_tiroides.Text = reti.ret_tiroiMasasCuello.ToString();
                            txt_movilidad.Text = reti.ret_movilidadCuello.ToString();
                            txt_mamas.Text = reti.ret_mamasTorax.ToString();
                            txt_corazon.Text = reti.ret_corazonTorax.ToString();
                            txt_pulmones.Text = reti.ret_pulmonesTorax2.ToString();
                            txt_parrillacostal.Text = reti.ret_parriCostalTorax2.ToString();
                            txt_visceras.Text = reti.ret_viscerasAbdomen.ToString();
                            txt_paredabdominal.Text = reti.ret_paredAbdomiAbdomen.ToString();
                            txt_flexibilidad.Text = reti.ret_flexibilidadColumna.ToString();
                            txt_desviacion.Text = reti.ret_desviacionColumna.ToString();
                            txt_dolor.Text = reti.ret_dolorColumna.ToString();
                            txt_pelvis.Text = reti.ret_pelvisPelvis.ToString();
                            txt_genitales.Text = reti.ret_genitalesPelvis.ToString();
                            txt_vascular.Text = reti.ret_vascularExtre.ToString();
                            txt_miembrosuperiores.Text = reti.ret_miemSupeExtre.ToString();
                            txt_miembrosinferiores.Text = reti.ret_miemInfeExtre.ToString();
                            txt_fuerza.Text = reti.ret_fuerzaNeuro.ToString();
                            txt_sensibilidad.Text = reti.ret_sensibiNeuro.ToString();
                            txt_marcha.Text = reti.ret_marchaNeuro.ToString();
                            txt_reflejos.Text = reti.ret_refleNeuro.ToString();
                            txt_obervexamenfisicoregional.Text = reti.ret_observaExaFisRegional.ToString();

                            //E
                            txt_examen.Text = reti.ret_examen.ToString();
                            txt_fechaexamen.Text = reti.ret_fecha.ToString();
                            txt_resultadoexamen.Text = reti.ret_resultados.ToString();
                            txt_observacionexamen.Text = reti.ret_observacionesResExaGenEspRiesTrabajo.ToString();

                            //F
                            txt_descripdiagnostico.Text = reti.ret_descripcionDiagnostico.ToString();
                            txt_cie.Text = reti.ret_cie.ToString();
                            txt_pre.Text = reti.ret_pre.ToString();
                            txt_def.Text = reti.ret_def.ToString();

                            //G
                            txt_sievamed.Text = reti.ret_si.ToString();
                            txt_noevamed.Text = reti.ret_no.ToString();
                            txt_obserevamed.Text = reti.ret_observacionesEvaMedRetiro.ToString();

                            //H
                            txt_descripciontratamientoretiro.Text = reti.ret_descripcionRecoTratamiento.ToString();

                            //I
                            txt_fechahora.Text = reti.ret_fecha_hora.ToString();
                            ddl_profesional.SelectedValue = reti.prof_id.ToString();
                            txt_codigoDatProf.Text = reti.ret_cod.ToString();
                        }
                    }
                }

                txt_fechahora.Text = DateTime.Now.ToString(" dd/MM/yyyy " + " HH:mm ");
                cargarProfesional();
            }
        }

        //Metodo obtener cedula por numero de HC RETIRO
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

        private void GuardarRetiro()
        {
            try
            {
                per = CN_HistorialMedico.ObtenerIdPersonasxCedula(Convert.ToInt32(txt_numHClinica.Text));

                int perso = Convert.ToInt32(per.Per_id.ToString());

                reti = new Tbl_Retiro 
                {
                    //A.
                    ret__fechIniLabores = Convert.ToDateTime(txt_fechaIniLabores.Text),
                    ret_fechSalida = Convert.ToDateTime(txt_fechaSalida.Text),
                    ret_tiempo = Convert.ToInt32(txt_tiempo.Text),
                    ret_actividades = txt_actividades1.Text,
                    ret_facRiesgo = txt_facRiesgo1.Text,

                    //B.
                    ret_descripAntCliQuiru = txt_descripcionantiqui.Text,

                    ret_siCalificadoIESSAcciTrabajo = txt_siCalificadoIESSAcciTrabajo.Text,
                    ret_EspecifiCalificadoIESSAcciTrabajo = txt_EspecifiCalificadoIESSAcciTrabajo.Text,
                    ret_noCalificadoIESSAcciTrabajo = txt_noCalificadoIESSAcciTrabajo.Text,
                    ret_fechaCalificadoIESSAcciTrabajo = Convert.ToDateTime(txt_fechaCalificadoIESSAcciTrabajo.Text),
                    ret_observacionesAcciTrabajo = txt_observacionesAcciTrabajo.Text,
                    ret_detalleAcciTrabajo = txt_detalleAcciTrabajo.Text,

                    ret_siCalificadoIESSEnferProfesionales = txt_siCalificadoIESSEnferProfesionales.Text,
                    ret_EspecifiCalificadoIESSEnferProfesionales = txt_EspecifiCalificadoIESSEnferProfesionales.Text,
                    ret_noCalificadoIESSEnferProfesionales = txt_noCalificadoIESSEnferProfesionales.Text,
                    ret_fechaCalificadoIESSEnferProfesionales = Convert.ToDateTime(txt_fechaCalificadoIESSEnferProfesionales.Text),
                    ret_observacionesEnferProfesionales = txt_observacionesEnferProfesionales.Text,
                    ret_detalleEnferProfesionales = txt_detalleEnferProfesionales.Text,

                    //D.
                    ret_cicatricesPiel = txt_cicatrices.Text,
                    ret_tatuajesPiel = txt_tatuajes.Text,
                    ret_pielFacerasPiel = txt_pielyfaneras.Text,
                    ret_parpadosOjos = txt_parpados.Text,
                    ret_conjuntuvasOjos = txt_conjuntivas.Text,
                    ret_pupilasOjos = txt_pupilas.Text,
                    ret_corneaOjos = txt_cornea.Text,
                    ret_motilidadOjos = txt_motilidad.Text,
                    ret_cAudiExtreOido = txt_auditivoexterno.Text,
                    ret_pabellonOido = txt_pabellon.Text,
                    ret_timpanosOido = txt_timpanos.Text,
                    ret_labiosOroFa = txt_labios.Text,
                    ret_lenguaOroFa = txt_lengua.Text,
                    ret_faringeOroFa = txt_faringe.Text,
                    ret_amigdalasOroFa = txt_amigdalas.Text,
                    ret_dentaduraOroFa = txt_dentadura.Text,
                    ret_tabiqueNariz = txt_tabique.Text,
                    ret_cornetesNariz = txt_cornetes.Text,
                    ret_mucosasNariz = txt_mucosa.Text,
                    ret_senosParanaNariz = txt_senosparanasales.Text,
                    ret_tiroiMasasCuello = txt_tiroides.Text,
                    ret_movilidadCuello = txt_movilidad.Text,
                    ret_mamasTorax = txt_mamas.Text,
                    ret_corazonTorax = txt_corazon.Text,
                    ret_pulmonesTorax2 = txt_pulmones.Text,
                    ret_parriCostalTorax2 = txt_parrillacostal.Text,
                    ret_viscerasAbdomen = txt_visceras.Text,
                    ret_paredAbdomiAbdomen = txt_paredabdominal.Text,
                    ret_flexibilidadColumna = txt_flexibilidad.Text,
                    ret_desviacionColumna = txt_desviacion.Text,
                    ret_dolorColumna = txt_dolor.Text,
                    ret_pelvisPelvis = txt_pelvis.Text,
                    ret_genitalesPelvis = txt_genitales.Text,
                    ret_vascularExtre = txt_vascular.Text,
                    ret_miemSupeExtre = txt_miembrosuperiores.Text,
                    ret_miemInfeExtre = txt_miembrosinferiores.Text,
                    ret_fuerzaNeuro = txt_fuerza.Text,
                    ret_sensibiNeuro = txt_sensibilidad.Text,
                    ret_marchaNeuro = txt_marcha.Text,
                    ret_refleNeuro = txt_reflejos.Text,
                    ret_observaExaFisRegional = txt_obervexamenfisicoregional.Text,

                    //E.
                    ret_examen = txt_examen.Text,
                    ret_fecha = Convert.ToDateTime(txt_fechaexamen.Text),
                    ret_resultados = txt_resultadoexamen.Text,
                    ret_observacionesResExaGenEspRiesTrabajo = txt_observacionexamen.Text,

                    //F
                    ret_descripcionDiagnostico = txt_descripdiagnostico.Text,
                    ret_cie = txt_cie.Text,
                    ret_pre = txt_pre.Text,
                    ret_def = txt_def.Text,

                    //G
                    ret_si = txt_sievamed.Text,
                    ret_no = txt_noevamed.Text,
                    ret_observacionesEvaMedRetiro = txt_obserevamed.Text,

                    //H.
                    ret_descripcionRecoTratamiento = txt_descripciontratamientoretiro.Text,

                    //I.
                    ret_fecha_hora = Convert.ToDateTime(txt_fechahora.Text),
                    prof_id = Convert.ToInt32(ddl_profesional.SelectedValue),
                    ret_cod = txt_codigoDatProf.Text,
                    Per_id = perso
                };

                CN_Retiro.GuardarrRetiro(reti);

                //Mensaje de confirmacion
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Guardados Exitosamente')", true);

                Response.Redirect("~/Template/Views/PacientesRetiro.aspx");

            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Guardados')", true);
            }

        }

        private void ModificarRetiro(Tbl_Retiro reti)
        {
            try
            {
                //A.
                reti.ret__fechIniLabores = Convert.ToDateTime(txt_fechaIniLabores.Text);
                reti.ret_fechSalida = Convert.ToDateTime(txt_fechaSalida.Text);
                reti.ret_tiempo = Convert.ToInt32(txt_tiempo.Text);
                reti.ret_actividades = txt_actividades1.Text;
                reti.ret_facRiesgo = txt_facRiesgo1.Text;

                //B.
                reti.ret_descripAntCliQuiru = txt_descripcionantiqui.Text;

                reti.ret_siCalificadoIESSAcciTrabajo = txt_siCalificadoIESSAcciTrabajo.Text;
                reti.ret_EspecifiCalificadoIESSAcciTrabajo = txt_EspecifiCalificadoIESSAcciTrabajo.Text;
                reti.ret_noCalificadoIESSAcciTrabajo = txt_noCalificadoIESSAcciTrabajo.Text;
                reti.ret_fechaCalificadoIESSAcciTrabajo = Convert.ToDateTime(txt_fechaCalificadoIESSAcciTrabajo.Text);
                reti.ret_observacionesAcciTrabajo = txt_observacionesAcciTrabajo.Text;
                reti.ret_detalleAcciTrabajo = txt_detalleAcciTrabajo.Text;

                reti.ret_siCalificadoIESSEnferProfesionales = txt_siCalificadoIESSEnferProfesionales.Text;
                reti.ret_EspecifiCalificadoIESSEnferProfesionales = txt_EspecifiCalificadoIESSEnferProfesionales.Text;
                reti.ret_noCalificadoIESSEnferProfesionales = txt_noCalificadoIESSEnferProfesionales.Text;
                reti.ret_fechaCalificadoIESSEnferProfesionales = Convert.ToDateTime(txt_fechaCalificadoIESSEnferProfesionales.Text);
                reti.ret_observacionesEnferProfesionales = txt_observacionesEnferProfesionales.Text;
                reti.ret_detalleEnferProfesionales = txt_detalleEnferProfesionales.Text;

                //D.
                reti.ret_cicatricesPiel = txt_cicatrices.Text;
                reti.ret_tatuajesPiel = txt_tatuajes.Text;
                reti.ret_pielFacerasPiel = txt_pielyfaneras.Text;
                reti.ret_parpadosOjos = txt_parpados.Text;
                reti.ret_conjuntuvasOjos = txt_conjuntivas.Text;
                reti.ret_pupilasOjos = txt_pupilas.Text;
                reti.ret_corneaOjos = txt_cornea.Text;
                reti.ret_motilidadOjos = txt_motilidad.Text;
                reti.ret_cAudiExtreOido = txt_auditivoexterno.Text;
                reti.ret_pabellonOido = txt_pabellon.Text;
                reti.ret_timpanosOido = txt_timpanos.Text;
                reti.ret_labiosOroFa = txt_labios.Text;
                reti.ret_lenguaOroFa = txt_lengua.Text;
                reti.ret_faringeOroFa = txt_faringe.Text;
                reti.ret_amigdalasOroFa = txt_amigdalas.Text;
                reti.ret_dentaduraOroFa = txt_dentadura.Text;
                reti.ret_tabiqueNariz = txt_tabique.Text;
                reti.ret_cornetesNariz = txt_cornetes.Text;
                reti.ret_mucosasNariz = txt_mucosa.Text;
                reti.ret_senosParanaNariz = txt_senosparanasales.Text;
                reti.ret_tiroiMasasCuello = txt_tiroides.Text;
                reti.ret_movilidadCuello = txt_movilidad.Text;
                reti.ret_mamasTorax = txt_mamas.Text;
                reti.ret_corazonTorax = txt_corazon.Text;
                reti.ret_pulmonesTorax2 = txt_pulmones.Text;
                reti.ret_parriCostalTorax2 = txt_parrillacostal.Text;
                reti.ret_viscerasAbdomen = txt_visceras.Text;
                reti.ret_paredAbdomiAbdomen = txt_paredabdominal.Text;
                reti.ret_flexibilidadColumna = txt_flexibilidad.Text;
                reti.ret_desviacionColumna = txt_desviacion.Text;
                reti.ret_dolorColumna = txt_dolor.Text;
                reti.ret_pelvisPelvis = txt_pelvis.Text;
                reti.ret_genitalesPelvis = txt_genitales.Text;
                reti.ret_vascularExtre = txt_vascular.Text;
                reti.ret_miemSupeExtre = txt_miembrosuperiores.Text;
                reti.ret_miemInfeExtre = txt_miembrosinferiores.Text;
                reti.ret_fuerzaNeuro = txt_fuerza.Text;
                reti.ret_sensibiNeuro = txt_sensibilidad.Text;
                reti.ret_marchaNeuro = txt_marcha.Text;
                reti.ret_refleNeuro = txt_reflejos.Text;
                reti.ret_observaExaFisRegional = txt_obervexamenfisicoregional.Text;

                //E.
                reti.ret_examen = txt_examen.Text;
                reti.ret_fecha = Convert.ToDateTime(txt_fechaexamen.Text);
                reti.ret_resultados = txt_resultadoexamen.Text;
                reti.ret_observacionesResExaGenEspRiesTrabajo = txt_observacionexamen.Text;

                //F.
                reti.ret_descripcionDiagnostico = txt_descripdiagnostico.Text;
                reti.ret_cie = txt_cie.Text;
                reti.ret_pre = txt_pre.Text;
                reti.ret_def = txt_def.Text;

                //G.
                reti.ret_si = txt_sievamed.Text;
                reti.ret_no = txt_noevamed.Text;
                reti.ret_observacionesEvaMedRetiro = txt_obserevamed.Text;

                //H.
                reti.ret_descripcionRecoTratamiento = txt_descripciontratamientoretiro.Text;

                //I.
                reti.ret_fecha_hora = Convert.ToDateTime(txt_fechahora.Text);
                reti.prof_id = Convert.ToInt32(ddl_profesional.SelectedValue);
                reti.ret_cod = txt_codigoDatProf.Text;

                CN_Retiro.ModificarRetiro(reti);

                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Modificados Exitosamente')", true);
                Response.Redirect("~/Template/Views/PacientesRetiro.aspx");

            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Modificados')", true);
            }
        }

        private void guardar_modificar_datos(int retiro)
        {
            if (retiro == 0)
            {
                GuardarRetiro();
            }
            else
            {
                reti = CN_Retiro.ObtenerRetiroPorId(retiro);

                if (per != null)
                {
                    ModificarRetiro(reti);
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