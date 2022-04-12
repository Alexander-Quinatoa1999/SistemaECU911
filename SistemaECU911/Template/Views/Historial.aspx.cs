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
    public partial class Historial : System.Web.UI.Page
    {
        private readonly DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        private Tbl_Personas per = new Tbl_Personas();
        private Tbl_FichasMedicas fichasmedicas = new Tbl_FichasMedicas();
        private Tbl_TipoExaFisRegional tipreg = new Tbl_TipoExaFisRegional();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["cod"] != null)
                {
                    int codigo = Convert.ToInt32(Request["cod"]);
                    per = CN_HistorialMedico.ObtenerPersonasxId(codigo);
                    fichasmedicas = CN_HistorialMedico.ObtenerFichaMedicaPer(codigo);
                    btn_guardar.Text = "Actualizar";

                    if (per != null)
                    {
                        txt_priNombre.Text = per.Per_priNombre.ToString();
                        txt_segNombre.Text = per.Per_segNombre.ToString();
                        txt_priApellido.Text = per.Per_priApellido.ToString();
                        txt_segApellido.Text = per.Per_segApellido.ToString();
                        txt_edad.Text = per.Per_fechNacimiento.ToString();
                        txt_sexo.Text = per.Per_genero.ToString();
                        txt_numHClinica.Text = per.Per_Cedula.ToString();

                        if (fichasmedicas != null)
                        {
                            txt_moConsulta.Text = fichasmedicas.moConsulta.ToString();
                            txt_segAcompa.Text = fichasmedicas.seAcompañanteMc.ToString();
                            ddl_tipoAntPer.SelectedValue = fichasmedicas.idTipAntecedentePer.ToString();
                            txt_antePersonales.Text = fichasmedicas.antecedentePer.ToString();
                            txt_antePerDescripcion.Text = fichasmedicas.descripcionPer.ToString();
                            ddl_tipoAntFam.SelectedValue = fichasmedicas.idTipAntecedenteFam.ToString();
                            txt_anteFamiliares.Text = fichasmedicas.antecedenteFam.ToString();
                            txt_anteFamDescripcion.Text = fichasmedicas.descripcionFam.ToString();
                            txt_enfeActual.Text = fichasmedicas.descripcionEA.ToString();
                            ddl_orgSistemas.SelectedValue = fichasmedicas.orgSentido.ToString();
                            txt_descOrgSistemas.Text = fichasmedicas.descripcionOS.ToString();
                            ddl_respiratorio.SelectedValue = fichasmedicas.respiratorio.ToString();
                            txt_descRespiratorio.Text = fichasmedicas.descripcionRes.ToString();
                            ddl_carVascular.SelectedValue = fichasmedicas.cardioVascular.ToString();
                            txt_descCarVascular.Text = fichasmedicas.descripcionCV.ToString();
                            ddl_digestivo.SelectedValue = fichasmedicas.digestivo.ToString();
                            txt_descDigestivo.Text = fichasmedicas.descripcionDig.ToString();
                            ddl_genital.SelectedValue = fichasmedicas.genital.ToString();
                            txt_descGenital.Text = fichasmedicas.descripcionGen.ToString();
                            ddl_urinario.SelectedValue = fichasmedicas.urinario.ToString();
                            txt_descUrinario.Text = fichasmedicas.descripcionUri.ToString();
                            ddl_muscular.SelectedValue = fichasmedicas.muscular.ToString();
                            txt_descMuscular.Text = fichasmedicas.descripcionMus.ToString();
                            ddl_esqueletico.SelectedValue = fichasmedicas.esqueletico.ToString();
                            txt_descEsqueletico.Text = fichasmedicas.descripcionEsq.ToString();
                            ddl_nervioso.SelectedValue = fichasmedicas.nervioso.ToString();
                            txt_descNervioso.Text = fichasmedicas.descripcionNer.ToString();
                            ddl_endocrino.SelectedValue = fichasmedicas.endocrino.ToString();
                            txt_descEndocrino.Text = fichasmedicas.descripcionEnd.ToString();
                            ddl_hemoLinfatico.SelectedValue = fichasmedicas.hemoLinfatico.ToString();
                            txt_descHemoLinfatico.Text = fichasmedicas.descripcionHL.ToString();
                            ddl_tegumentario.SelectedValue = fichasmedicas.tegumentario.ToString();
                            txt_descTegumentario.Text = fichasmedicas.descripcionTeg.ToString();
                            txt_presArterial.Text = fichasmedicas.persionArterial.ToString();
                            txt_temperatura.Text = fichasmedicas.temperatura.ToString();
                            txt_frecCardiaca.Text = fichasmedicas.frecuenciaCardica.ToString();
                            txt_satOxigeno.Text = fichasmedicas.saturacionOxigeno.ToString();
                            txt_frecRespiratoria.Text = fichasmedicas.frecuenciaRespiratoria.ToString();
                            txt_peso.Text = fichasmedicas.peso.ToString();
                            txt_talla.Text = fichasmedicas.talla.ToString();
                            txt_indMasCorporal.Text = fichasmedicas.indMasaCorporal.ToString();
                            txt_perAbdominal.Text = fichasmedicas.perimetroAbdominal.ToString();
                            ddl_region.SelectedValue = fichasmedicas.Regiones_id.ToString();
                            ddl_tipoRegion.SelectedValue = fichasmedicas.tipoExa_id.ToString();
                            txt_exafisdescripcion.Text = fichasmedicas.descripcionEF.ToString();
                            txt_diagnosticosDiagnostico.Text = fichasmedicas.diagnostico.ToString();
                            txt_codigoDiagnostico.Text = fichasmedicas.codigoDiag.ToString();
                            txt_tipoDiagnostico.Text = fichasmedicas.tipoDiag.ToString();
                            txt_condicionDiagnostico.Text = fichasmedicas.condicionDiag.ToString();
                            txt_cronologiaDiagnostico.Text = fichasmedicas.cronologiaDiag.ToString();
                            txt_descripcionDiagnostico.Text = fichasmedicas.descripcionDiag.ToString();
                            txt_tratamiento.Text = fichasmedicas.planTratamiento.ToString();
                            txt_evolucion.Text = fichasmedicas.evolucion.ToString();
                            txt_prescipciones.Text = fichasmedicas.prescripciones.ToString();
                            txt_fechahora.Text = fichasmedicas.fechaHora.ToString();
                            ddl_especialidad.SelectedValue = fichasmedicas.especialidadPro.ToString();
                            ddl_profesional.SelectedValue = fichasmedicas.profesional.ToString();
                            txt_codigo.Text = fichasmedicas.codigoPro.ToString();
                        }
                    }
                }
                txt_fechahora.Text = DateTime.Now.ToString(" dd/MM/yyyy " + " HH:mm ");
                cargarRegion();
                cargarEspecialidad();
                cargarProfesional();
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

        protected void txt_diagnosticosDiagnostico_TextChanged(object sender, EventArgs e)
        {
            ObtenerCodigo();
        }

        private void ObtenerCodigo()
        {
            string descripcion = txt_diagnosticosDiagnostico.Text;

            var lista = from c in dc.cie10
                        where c.dec10 == descripcion
                        select c;

            foreach (var item in lista)
            {
                string codigo = item.id10;
                txt_codigoDiagnostico.Text = codigo;
            }
        }

        private void GuardarHistorial()
        {
            try
            {
                per = CN_HistorialMedico.ObtenerIdPersonasxCedula(Convert.ToInt32(txt_numHClinica.Text));

                int perso = Convert.ToInt32(per.Per_id.ToString());

                fichasmedicas = new Tbl_FichasMedicas
                {
                    moConsulta = txt_moConsulta.Text,
                    seAcompañanteMc = txt_segAcompa.Text,
                    idTipAntecedentePer = Convert.ToInt32(ddl_tipoAntPer.SelectedValue),
                    antecedentePer = txt_antePersonales.Text,
                    descripcionPer = txt_antePerDescripcion.Text,
                    idTipAntecedenteFam = Convert.ToInt32(ddl_tipoAntFam.SelectedValue),
                    antecedenteFam = txt_anteFamiliares.Text,
                    descripcionFam = txt_anteFamDescripcion.Text,
                    descripcionEA = txt_enfeActual.Text,
                    orgSentido = Convert.ToInt32(ddl_orgSistemas.SelectedValue),
                    descripcionOS = txt_descOrgSistemas.Text,
                    respiratorio = Convert.ToInt32(ddl_respiratorio.SelectedValue),
                    descripcionRes = txt_descRespiratorio.Text,
                    cardioVascular = Convert.ToInt32(ddl_carVascular.SelectedValue),
                    descripcionCV = txt_descCarVascular.Text,
                    digestivo = Convert.ToInt32(ddl_digestivo.SelectedValue),
                    descripcionDig = txt_descDigestivo.Text,
                    genital = Convert.ToInt32(ddl_genital.SelectedValue),
                    descripcionGen = txt_descGenital.Text,
                    urinario = Convert.ToInt32(ddl_urinario.SelectedValue),
                    descripcionUri = txt_descUrinario.Text,
                    muscular = Convert.ToInt32(ddl_muscular.SelectedValue),
                    descripcionMus = txt_descMuscular.Text,
                    esqueletico = Convert.ToInt32(ddl_esqueletico.SelectedValue),
                    descripcionEsq = txt_descEsqueletico.Text,
                    nervioso = Convert.ToInt32(ddl_nervioso.SelectedValue),
                    descripcionNer = txt_descNervioso.Text,
                    endocrino = Convert.ToInt32(ddl_endocrino.SelectedValue),
                    descripcionEnd = txt_descEndocrino.Text,
                    hemoLinfatico = Convert.ToInt32(ddl_hemoLinfatico.SelectedValue),
                    descripcionHL = txt_descHemoLinfatico.Text,
                    tegumentario = Convert.ToInt32(ddl_tegumentario.SelectedValue),
                    descripcionTeg = txt_descTegumentario.Text,
                    persionArterial = txt_presArterial.Text,
                    temperatura = Convert.ToDecimal(txt_temperatura.Text),
                    frecuenciaCardica = Convert.ToDecimal(txt_frecCardiaca.Text),
                    saturacionOxigeno = Convert.ToDecimal(txt_satOxigeno.Text),
                    frecuenciaRespiratoria = Convert.ToDecimal(txt_frecRespiratoria.Text),
                    peso = Convert.ToDecimal(txt_peso.Text),
                    talla = Convert.ToDecimal(txt_talla.Text),
                    indMasaCorporal = Convert.ToDecimal(txt_indMasCorporal.Text),
                    perimetroAbdominal = Convert.ToDecimal(txt_perAbdominal.Text),
                    Regiones_id = Convert.ToInt32(ddl_region.SelectedValue),
                    tipoExa_id = Convert.ToInt32(ddl_tipoRegion.SelectedValue),
                    descripcionEF = txt_exafisdescripcion.Text,
                    diagnostico = txt_diagnosticosDiagnostico.Text,
                    codigoDiag = txt_codigoDiagnostico.Text,
                    tipoDiag = txt_tipoDiagnostico.Text,
                    condicionDiag = txt_condicionDiagnostico.Text,
                    cronologiaDiag = txt_cronologiaDiagnostico.Text,
                    descripcionDiag = txt_descripcionDiagnostico.Text,
                    planTratamiento = txt_tratamiento.Text,
                    evolucion = txt_evolucion.Text,
                    prescripciones = txt_prescipciones.Text,
                    especialidadPro = Convert.ToInt32(ddl_especialidad.SelectedValue),
                    profesional = Convert.ToInt32(ddl_profesional.SelectedValue),
                    codigoPro = txt_codigo.Text,
                    Per_id = perso
                };

                CN_HistorialMedico.GuardarFichaMedica(fichasmedicas);

                //Mensaje de confirmacion
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Guardados Exitosamente')", true);

                Response.Redirect("~/Template/Views/Pacientes.aspx");

            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Guardados')", true);
            }            
        }

        private void ModificarHistorial(Tbl_FichasMedicas fichasmedicas)
        {
            try
            {
                fichasmedicas.moConsulta = txt_moConsulta.Text;
                fichasmedicas.seAcompañanteMc = txt_segAcompa.Text;
                fichasmedicas.idTipAntecedentePer = Convert.ToInt32(ddl_tipoAntPer.SelectedValue);
                fichasmedicas.antecedentePer = txt_antePersonales.Text; 
                fichasmedicas.descripcionPer = txt_antePerDescripcion.Text;
                fichasmedicas.idTipAntecedenteFam = Convert.ToInt32(ddl_tipoAntFam.SelectedValue);
                fichasmedicas.antecedenteFam = txt_anteFamiliares.Text;
                fichasmedicas.descripcionFam = txt_anteFamDescripcion.Text;
                fichasmedicas.descripcionEA = txt_enfeActual.Text;
                fichasmedicas.orgSentido = Convert.ToInt32(ddl_orgSistemas.SelectedValue);
                fichasmedicas.descripcionOS = txt_descOrgSistemas.Text;
                fichasmedicas.respiratorio = Convert.ToInt32(ddl_respiratorio.SelectedValue);
                fichasmedicas.descripcionRes = txt_descRespiratorio.Text;
                fichasmedicas.cardioVascular = Convert.ToInt32(ddl_carVascular.SelectedValue);
                fichasmedicas.descripcionCV = txt_descCarVascular.Text;
                fichasmedicas.digestivo = Convert.ToInt32(ddl_digestivo.SelectedValue);
                fichasmedicas.descripcionDig = txt_descDigestivo.Text;
                fichasmedicas.genital = Convert.ToInt32(ddl_genital.SelectedValue);
                fichasmedicas.descripcionGen = txt_descGenital.Text;
                fichasmedicas.urinario = Convert.ToInt32(ddl_urinario.SelectedValue);
                fichasmedicas.descripcionUri = txt_descUrinario.Text;
                fichasmedicas.muscular = Convert.ToInt32(ddl_muscular.SelectedValue);
                fichasmedicas.descripcionMus = txt_descMuscular.Text;
                fichasmedicas.esqueletico = Convert.ToInt32(ddl_esqueletico.SelectedValue);
                fichasmedicas.descripcionEsq = txt_descEsqueletico.Text;
                fichasmedicas.nervioso = Convert.ToInt32(ddl_nervioso.SelectedValue);
                fichasmedicas.descripcionNer = txt_descNervioso.Text;
                fichasmedicas.endocrino = Convert.ToInt32(ddl_endocrino.SelectedValue);
                fichasmedicas.descripcionEnd = txt_descEndocrino.Text;
                fichasmedicas.hemoLinfatico = Convert.ToInt32(ddl_hemoLinfatico.SelectedValue);
                fichasmedicas.descripcionHL = txt_descHemoLinfatico.Text;
                fichasmedicas.tegumentario = Convert.ToInt32(ddl_tegumentario.SelectedValue);
                fichasmedicas.descripcionTeg = txt_descTegumentario.Text;
                fichasmedicas.persionArterial = txt_presArterial.Text;
                fichasmedicas.temperatura = Convert.ToDecimal(txt_temperatura.Text);
                fichasmedicas.frecuenciaCardica = Convert.ToDecimal(txt_frecCardiaca.Text);
                fichasmedicas.saturacionOxigeno = Convert.ToDecimal(txt_satOxigeno.Text);
                fichasmedicas.frecuenciaRespiratoria = Convert.ToDecimal(txt_frecRespiratoria.Text);
                fichasmedicas.peso = Convert.ToDecimal(txt_peso.Text);
                fichasmedicas.talla = Convert.ToDecimal(txt_talla.Text);
                fichasmedicas.indMasaCorporal = Convert.ToDecimal(txt_indMasCorporal.Text);
                fichasmedicas.perimetroAbdominal = Convert.ToDecimal(txt_perAbdominal.Text);
                fichasmedicas.Regiones_id = Convert.ToInt32(ddl_region.SelectedValue);
                fichasmedicas.tipoExa_id = Convert.ToInt32(ddl_tipoRegion.SelectedValue);
                fichasmedicas.descripcionEF = txt_exafisdescripcion.Text;
                fichasmedicas.diagnostico = txt_diagnosticosDiagnostico.Text;
                fichasmedicas.codigoDiag = txt_codigoDiagnostico.Text;
                fichasmedicas.tipoDiag = txt_tipoDiagnostico.Text;
                fichasmedicas.condicionDiag = txt_condicionDiagnostico.Text;
                fichasmedicas.cronologiaDiag = txt_cronologiaDiagnostico.Text;
                fichasmedicas.descripcionDiag = txt_descripcionDiagnostico.Text;
                fichasmedicas.planTratamiento = txt_tratamiento.Text;
                fichasmedicas.evolucion = txt_evolucion.Text;
                fichasmedicas.prescripciones = txt_prescipciones.Text;
                fichasmedicas.especialidadPro = Convert.ToInt32(ddl_especialidad.SelectedValue);
                fichasmedicas.profesional = Convert.ToInt32(ddl_profesional.SelectedValue);
                fichasmedicas.codigoPro = txt_codigo.Text;

                CN_HistorialMedico.ModificarFichaMedica(fichasmedicas);

                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Modificados Exitosamente')", true);
                Response.Redirect("~/Template/Views/Pacientes.aspx");
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Modificados')", true);
            }
        }

        private void Guardar_modificar_datos(int fichamedica)
        {
            if (fichamedica == 0)
            {
                GuardarHistorial();
            }
            else
            {
                fichasmedicas = CN_HistorialMedico.ObtenerFichasMedicasPorId(fichamedica);

                if (fichasmedicas != null)
                {
                    ModificarHistorial(fichasmedicas);
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

        private void cargarRegion()
        {
            List<Tbl_Regiones> listaReg = new List<Tbl_Regiones>();
            listaReg = CN_HistorialMedico.ObtenerRegion();
            listaReg.Insert(0, new Tbl_Regiones() { Regiones_nombres = "Seleccione ........" });

            ddl_region.DataSource = listaReg;
            ddl_region.DataTextField = "Regiones_nombres";
            ddl_region.DataValueField = "Regiones_id";
            ddl_region.DataBind();
            ddl_tipoRegion.Items.Insert(0, new ListItem("Seleccione ........", "0"));

        }

        protected void ddl_region_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTipoRegion();
        }

        private void CargarTipoRegion()
        {
            int regionid = Convert.ToInt32(ddl_region.SelectedValue);

            var query = from tipreg in dc.Tbl_TipoExaFisRegional where tipreg.Regiones_id == regionid select tipreg;

            ddl_tipoRegion.DataSource = query.ToList();
            ddl_tipoRegion.DataTextField = "tipoExa_nombres";
            ddl_tipoRegion.DataValueField = "tipoExa_id";
            ddl_tipoRegion.DataBind();
            ddl_tipoRegion.Items.Insert(0, new ListItem("Seleccione ........", "0"));

            tipreg = CN_HistorialMedico.ObtenerTipoRegionxReg(regionid);
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

        private void cargarEspecialidad()
        {
            List<Tbl_Especialidad> listaEspec = new List<Tbl_Especialidad>();
            listaEspec = CN_HistorialMedico.ObtenerEspecialidad();
            listaEspec.Insert(0, new Tbl_Especialidad() { espec_nombre = "Seleccione ........" });

            ddl_especialidad.DataSource = listaEspec;
            ddl_especialidad.DataTextField = "espec_nombre";
            ddl_especialidad.DataValueField = "espec_id";
            ddl_especialidad.DataBind();
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

                throw;
            }
        }
    }

}

