using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaNegocio;

namespace SistemaECU911.Template.Views
{
    public partial class Historial : System.Web.UI.Page
    {

        DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        //Objeto de la tabla personas
        private Tbl_Personas per = new Tbl_Personas();
        //Objeto de la tabla motivo de consulta
        private Tbl_MotivoConsulta motcons = new Tbl_MotivoConsulta();
        //Objeto de la tabla antecedentes personales
        private Tbl_AntePersonales antper = new Tbl_AntePersonales();
        //Objeto de la tabla antecedentes familiares
        private Tbl_AnteFamiliares antfam = new Tbl_AnteFamiliares();
        //Objeto de la tabla enfermedad actual
        private Tbl_EnfermedadActual enfact = new Tbl_EnfermedadActual();
        //Objeto de la tabla revision organos y sistemas
        private Tbl_ReviOrgaSistemasFichMed revOrSis = new Tbl_ReviOrgaSistemasFichMed();
        //Objeto de la tabla signos vitales y antropometricos
        private Tbl_ConsVitAntro consvit = new Tbl_ConsVitAntro();
        //Objeto de la tabla examen fisico
        private Tbl_ExaFisRegional exafis = new Tbl_ExaFisRegional();
        //Objeto de la tabla regiones
        private Tbl_Regiones reg = new Tbl_Regiones();
        //Objeto de la tabla tipo de examen
        private Tbl_TipoExaFisRegional tipreg = new Tbl_TipoExaFisRegional();
        //Objeto de la tabla tipo de examen
        private Tbl_DiagnosticoFichMed diag = new Tbl_DiagnosticoFichMed();
        //Objeto de la tabla plan de tratamiento
        private Tbl_RecoTratamiento rectra = new Tbl_RecoTratamiento();
        //Objeto de la tabla evolucion
        private Tbl_Evolucion evo = new Tbl_Evolucion();
        //Objeto de la tabla prescipciones
        private Tbl_Prescipciones pres = new Tbl_Prescipciones();
        //Objeto de la tabla profesionales
        private Tbl_DatProfesional prof = new Tbl_DatProfesional();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {                              
                txt_fechahora.Text = DateTime.Now.ToString(" dd/MM/yyyy " + " HH:mm ");

                CargarDatosModificar();
                cargarTipoAntecedentePersonal();
                cargarTipoAntecedenteFamiliar(); 
                cargarRegion();
                cargarEvidenciaPatologica1();
                cargarEvidenciaPatologica2();
                cargarEvidenciaPatologica3();
                cargarEvidenciaPatologica4();
                cargarEvidenciaPatologica5();
                cargarEvidenciaPatologica6();
                cargarEvidenciaPatologica7();
                cargarEvidenciaPatologica8();
                cargarEvidenciaPatologica9();
                cargarEvidenciaPatologica10();
                cargarEvidenciaPatologica11();
                cargarEvidenciaPatologica12();
                cargarEspecialidad();
                cargarProfesional();
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
                txt_edad.Text = per.Per_fechNacimiento.ToString();
            }
        }

        private void CargarDatosModificar()
        {
            if (Request["cod"] != null)
            {
                int codigo = Convert.ToInt32(Request["cod"]);

                per = CN_HistorialMedico.obtenerPersonasxId(codigo);
                int perso = Convert.ToInt32(per.Per_id.ToString());

                DateTime fechahora = Convert.ToDateTime(motcons.Mcon_fecha_hora);

                motcons = CN_HistorialMedico.obtenerMotivoxPer(perso);
                antper = CN_HistorialMedico.obtenerAntePersonalxPer(perso);
                antfam = CN_HistorialMedico.obtenerAnteFamiliarxPer(perso);
                enfact = CN_HistorialMedico.obtenerEnferActualxPer(perso);
                revOrSis = CN_HistorialMedico.obtenerRevOrganosSistemasxPer(perso);
                consvit = CN_HistorialMedico.obtenerConsVitAntroxPer(perso);
                exafis = CN_HistorialMedico.obtenerExamenFisxPer(perso);

                int region = Convert.ToInt32(exafis.Regiones_id);
                reg = CN_HistorialMedico.obtenerRegionesxid(region);

                //int regionid = Convert.ToInt32(ddl_region.SelectedValue);
                //tipreg = CN_HistorialMedico.obtenerTipoRegionxReg(regionid);

                //int tiporegionid = Convert.ToInt32(tipreg.tipoExa_id);
                //tipid = CN_HistorialMedico.obtenerTipoRegionxid(tiporegionid);

                diag = CN_HistorialMedico.obtenerDiagnosticoxPer(perso);
                rectra = CN_HistorialMedico.obtenerPlanTratamientoxPer(perso);
                evo = CN_HistorialMedico.obtenerEvolucionxPer(perso);
                pres = CN_HistorialMedico.obtenerPrescripcionxPer(perso);
                prof = CN_HistorialMedico.obtenerProfesionalesxPer(perso);

                btn_guardar.Visible = true;

                if (per != null || motcons != null || antper != null || antfam != null || enfact != null || revOrSis != null || consvit != null || 
                    exafis != null || diag != null || rectra != null || evo != null || pres != null || prof != null)
                {
                    txt_priNombre.Text = per.Per_priNombre.ToString();
                    txt_segNombre.Text = per.Per_segNombre.ToString();
                    txt_priApellido.Text = per.Per_priApellido.ToString();
                    txt_segApellido.Text = per.Per_segApellido.ToString();
                    txt_numHClinica.Text = per.Per_Cedula.ToString();
                    txt_sexo.Text = per.Per_genero.ToString();
                    txt_edad.Text = per.Per_fechNacimiento.ToString();

                    txt_moConsulta.Text = motcons.Mcon_descripcion.ToString();

                    ddl_tipoAntPer.Text = antper.TiEnf_id.ToString();
                    txt_antePersonales.Text = antper.AntPer_antecedente.ToString();
                    txt_antePerDescripcion.Text = antper.AntPer_descripcion.ToString();

                    ddl_tipoAntFam.Text = antfam.TiEnf_id.ToString();
                    txt_anteFamiliares.Text = antfam.AntFami_antecendente.ToString();
                    txt_anteFamDescripcion.Text = antfam.AntFami_descripcion.ToString();

                    txt_enfeActual.Text = enfact.EnfActu_descrip.ToString();

                    ddl_orgSistemas.Text = revOrSis.eviPat1_id.ToString();
                    txt_descOrgSistemas.Text = revOrSis.revorgsisFM_descOS.ToString();
                    ddl_respiratorio.Text = revOrSis.eviPat2_id.ToString();
                    txt_descRespiratorio.Text = revOrSis.revorgsisFM_descR.ToString();
                    ddl_carVascular.Text = revOrSis.eviPat3_id.ToString();
                    txt_descCarVascular.Text = revOrSis.revorgsisFM_descCV.ToString();
                    ddl_digestivo.Text = revOrSis.eviPat4_id.ToString();
                    txt_descDigestivo.Text = revOrSis.revorgsisFM_descD.ToString();
                    ddl_genital.Text = revOrSis.eviPat5_id.ToString();
                    txt_descGenital.Text = revOrSis.revorgsisFM_descG.ToString();
                    ddl_urinario.Text = revOrSis.eviPat6_id.ToString();
                    txt_descUrinario.Text = revOrSis.revorgsisFM_descU.ToString();
                    ddl_muscular.Text = revOrSis.eviPat7_id.ToString();
                    txt_descMuscular.Text = revOrSis.revorgsisFM_descM.ToString();
                    ddl_esqueletico.Text = revOrSis.eviPat8_id.ToString();
                    txt_descEsqueletico.Text = revOrSis.revorgsisFM_descE.ToString();
                    ddl_nervioso.Text = revOrSis.eviPat9_id.ToString();
                    txt_descNervioso.Text = revOrSis.revorgsisFM_descN.ToString();
                    ddl_endocrino.Text = revOrSis.eviPat10_id.ToString();
                    txt_descEndocrino.Text = revOrSis.revorgsisFM_descEND.ToString();
                    ddl_hemoLinfatico.Text = revOrSis.eviPat11_id.ToString();
                    txt_descHemoLinfatico.Text = revOrSis.revorgsisFM_descHL.ToString();
                    ddl_tegumentario.Text = revOrSis.eviPat12_id.ToString();
                    txt_descTegumentario.Text = revOrSis.revorgsisFM_descT.ToString();

                    txt_presArterial.Text = consvit.ConsVitAntro_preArterial.ToString();
                    txt_temperatura.Text = consvit.ConsVitAntro_temperatura.ToString();
                    txt_frecCardiaca.Text = consvit.ConsVitAntro_frecCardiacan.ToString();
                    txt_satOxigeno.Text = consvit.ConsVitAntro_satOxigenon.ToString();
                    txt_frecRespiratoria.Text = consvit.ConsVitAntro_frecRespiratorian.ToString();
                    txt_peso.Text = consvit.ConsVitAntro_peson.ToString();
                    txt_talla.Text = consvit.ConsVitAntro_tallan.ToString();
                    txt_indMasCorporal.Text = consvit.ConsVitAntro_indMasCorporaln.ToString();
                    txt_perAbdominal.Text = consvit.ConsVitAntro_perAbdominaln.ToString();

                    ddl_region.Text = reg.Regiones_id.ToString();
                    ddl_tipoRegion.Text = tipreg.tipoExa_id.ToString();
                    txt_exafisdescripcion.Text = exafis.ExaFisRegional_observaciones.ToString();

                    txt_diagnosticosDiagnostico.Text = diag.diag_diagnosticos.ToString();
                    txt_codigoDiagnostico.Text = diag.diag_codigo.ToString();
                    txt_tipoDiagnostico.Text = diag.diag_tipo.ToString();
                    txt_condicionDiagnostico.Text = diag.diag_condicion.ToString();
                    txt_cronologiaDiagnostico.Text = diag.diag_cronologian.ToString();
                    txt_descripcionDiagnostico.Text = diag.diag_descripcion.ToString();

                    txt_tratamiento.Text = rectra.RecTra_descripcion.ToString();

                    txt_evolucion.Text = evo.Evolucion_notas.ToString();

                    txt_prescipciones.Text = pres.Press_descripcion.ToString();

                    txt_fechahora.Text = prof.DatProfe_fecha_hora.ToString();
                    ddl_profesional.SelectedValue = prof.prof_id.ToString();
                    ddl_especialidad.SelectedValue = prof.espec_id.ToString();
                    txt_codigo.Text = prof.DatProfe_cod.ToString();

                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Error')", true);
                }
            }
        }

        private void guardar_modificar_datos(int perid, int motivoconsid, int antperid, int antfamid, int enfactid, int revOrSisid, 
            int consvitid, int exafisid, int diagid, int rectraid, int evoid, int presid, int profid)
        {
            if (perid == 0 || motivoconsid == 0 || antperid == 0 || antfamid == 0 || enfactid == 0 || revOrSisid == 0 || consvitid == 0 || 
                exafisid == 0 || diagid == 0 || rectraid == 0 || evoid == 0 || presid == 0 || profid == 0)
            {
                GuardarHistorial();
            }
            else
            {
                per = CN_HistorialMedico.obtenerPersonasxId(perid);
                int perso = Convert.ToInt32(per.Per_id.ToString());

                DateTime fechahora = Convert.ToDateTime(motcons.Mcon_fecha_hora);

                motcons = CN_HistorialMedico.obtenerMotivoxPer(perso);
                antper = CN_HistorialMedico.obtenerAntePersonalxPer(perso);
                antfam = CN_HistorialMedico.obtenerAnteFamiliarxPer(perso);
                enfact = CN_HistorialMedico.obtenerEnferActualxPer(perso);
                revOrSis = CN_HistorialMedico.obtenerRevOrganosSistemasxPer(perso);
                consvit = CN_HistorialMedico.obtenerConsVitAntroxPer(perso);
                exafis = CN_HistorialMedico.obtenerExamenFisxPer(perso);

                int region = Convert.ToInt32(exafis.Regiones_id);
                reg = CN_HistorialMedico.obtenerRegionesxid(region);

                //int regionid = Convert.ToInt32(ddl_region.SelectedValue);
                //tipreg = CN_HistorialMedico.obtenerTipoRegionxReg(regionid);

                //int tiporegionid = Convert.ToInt32(tipreg.tipoExa_id);
                //tipid = CN_HistorialMedico.obtenerTipoRegionxid(tiporegionid);

                diag = CN_HistorialMedico.obtenerDiagnosticoxPer(perso);
                rectra = CN_HistorialMedico.obtenerPlanTratamientoxPer(perso);
                evo = CN_HistorialMedico.obtenerEvolucionxPer(perso);
                pres = CN_HistorialMedico.obtenerPrescripcionxPer(perso);
                prof = CN_HistorialMedico.obtenerProfesionalesxPer(perso);

                if (per != null || motcons != null || antper != null || antfam != null || enfact != null || consvit != null || exafis != null || reg != null 
                    || tipreg != null || rectra != null || evo != null || pres != null || prof != null)
                {
                    ModificarHistorial(per, motcons, antper, antfam, enfact, consvit, exafis, rectra, evo, pres, prof);
                }
            }
        }

        private void GuardarHistorial()
        {
            try
            {
                per = CN_HistorialMedico.obtenerIdPersonasxCedula(Convert.ToInt32(txt_numHClinica.Text));

                int perso = Convert.ToInt32(per.Per_id.ToString());

                motcons = new Tbl_MotivoConsulta();
                antper = new Tbl_AntePersonales();
                antfam = new Tbl_AnteFamiliares();
                enfact = new Tbl_EnfermedadActual();
                revOrSis = new Tbl_ReviOrgaSistemasFichMed();
                consvit = new Tbl_ConsVitAntro();
                exafis = new Tbl_ExaFisRegional();
                reg = new Tbl_Regiones();
                tipreg = new Tbl_TipoExaFisRegional();
                diag = new Tbl_DiagnosticoFichMed();
                rectra = new Tbl_RecoTratamiento();
                evo = new Tbl_Evolucion();
                pres = new Tbl_Prescipciones();
                prof = new Tbl_DatProfesional();

                //captura de datos tbl_motivoconsulta
                motcons.Mcon_descripcion = txt_moConsulta.Text;
                motcons.Per_id = perso;

                //captura de datos tbl_antepersonales
                antper.TiEnf_id = Convert.ToInt32(ddl_tipoAntPer.SelectedValue);
                antper.AntPer_antecedente = txt_antePersonales.Text;
                antper.AntPer_descripcion = txt_antePerDescripcion.Text;
                antper.Per_id = perso;

                //captura de datos tbl_antefamiliares
                antfam.TiEnf_id = Convert.ToInt32(ddl_tipoAntFam.SelectedValue);
                antfam.AntFami_antecendente = txt_anteFamiliares.Text;
                antfam.AntFami_descripcion = txt_anteFamDescripcion.Text;
                antfam.Per_id = perso;

                //captura de datos Tbl_EnfermedadActual
                enfact.EnfActu_descrip = txt_enfeActual.Text;
                enfact.Per_id = perso;

                //captura de datos Tbl_ReviOrgaSistemasFichMed
                revOrSis.eviPat1_id = Convert.ToInt32(ddl_orgSistemas.SelectedValue);
                revOrSis.revorgsisFM_descOS = txt_descOrgSistemas.Text;
                revOrSis.eviPat2_id = Convert.ToInt32(ddl_respiratorio.SelectedValue);
                revOrSis.revorgsisFM_descR = txt_descRespiratorio.Text;
                revOrSis.eviPat3_id = Convert.ToInt32(ddl_carVascular.SelectedValue);
                revOrSis.revorgsisFM_descCV = txt_descCarVascular.Text;
                revOrSis.eviPat4_id = Convert.ToInt32(ddl_digestivo.SelectedValue);
                revOrSis.revorgsisFM_descD = txt_descDigestivo.Text;
                revOrSis.eviPat5_id = Convert.ToInt32(ddl_genital.SelectedValue);
                revOrSis.revorgsisFM_descG = txt_descGenital.Text;
                revOrSis.eviPat6_id = Convert.ToInt32(ddl_urinario.SelectedValue);
                revOrSis.revorgsisFM_descU = txt_descUrinario.Text;
                revOrSis.eviPat7_id = Convert.ToInt32(ddl_muscular.SelectedValue);
                revOrSis.revorgsisFM_descM = txt_descMuscular.Text;
                revOrSis.eviPat8_id = Convert.ToInt32(ddl_esqueletico.SelectedValue);
                revOrSis.revorgsisFM_descE = txt_descEsqueletico.Text;
                revOrSis.eviPat9_id = Convert.ToInt32(ddl_nervioso.SelectedValue);
                revOrSis.revorgsisFM_descN = txt_descNervioso.Text;
                revOrSis.eviPat10_id = Convert.ToInt32(ddl_endocrino.SelectedValue);
                revOrSis.revorgsisFM_descEND = txt_descEndocrino.Text;
                revOrSis.eviPat11_id = Convert.ToInt32(ddl_hemoLinfatico.SelectedValue);
                revOrSis.revorgsisFM_descHL = txt_descHemoLinfatico.Text;
                revOrSis.eviPat12_id = Convert.ToInt32(ddl_tegumentario.SelectedValue);
                revOrSis.revorgsisFM_descT = txt_descTegumentario.Text;
                revOrSis.Per_id = perso;

                //captura de datos Tbl_ConsVitAntro
                consvit.ConsVitAntro_preArterial = Convert.ToString(txt_presArterial.Text);
                consvit.ConsVitAntro_temperatura = Convert.ToInt32(txt_temperatura.Text);
                consvit.ConsVitAntro_frecCardiacan = Convert.ToInt32(txt_frecCardiaca.Text);
                consvit.ConsVitAntro_satOxigenon = Convert.ToInt32(txt_satOxigeno.Text);
                consvit.ConsVitAntro_frecRespiratorian = Convert.ToInt32(txt_frecRespiratoria.Text);
                consvit.ConsVitAntro_peson = Convert.ToInt32(txt_peso.Text);
                consvit.ConsVitAntro_tallan = Convert.ToInt32(txt_talla.Text);
                consvit.ConsVitAntro_indMasCorporaln = Convert.ToInt32(txt_indMasCorporal.Text);
                consvit.ConsVitAntro_perAbdominaln = Convert.ToInt32(txt_perAbdominal.Text);
                consvit.Per_id = perso;

                //captura de datos Tbl_ExaFisRegional
                exafis.Regiones_id = Convert.ToInt32(ddl_region.SelectedValue);
                exafis.ExaFisRegional_observaciones = txt_exafisdescripcion.Text;
                exafis.Per_id = perso;

                //captura de datos Tbl_DiagnosticoFichMed
                diag.diag_diagnosticos = txt_diagnosticosDiagnostico.Text;
                diag.diag_codigo = txt_codigoDiagnostico.Text;
                diag.diag_tipo = txt_tipoDiagnostico.Text;
                diag.diag_condicion = txt_condicionDiagnostico.Text;
                diag.diag_cronologian = txt_cronologiaDiagnostico.Text;
                diag.diag_descripcion = txt_descripcionDiagnostico.Text;
                diag.Per_id = perso;

                //captura de datos Tbl_RecoTratamiento
                rectra.RecTra_descripcion = txt_tratamiento.Text;
                rectra.Per_id = perso;

                //captura de datos Tbl_Evolucion
                evo.Evolucion_notas = txt_evolucion.Text;
                evo.Per_id = perso;

                //captura de datos Tbl_Prescipciones
                pres.Press_descripcion = txt_prescipciones.Text;
                pres.Per_id = perso;

                //captura de datos Tbl_Profesional
                prof.DatProfe_fecha_hora = Convert.ToDateTime(txt_fechahora.Text);
                prof.prof_id = Convert.ToInt32(ddl_profesional.SelectedValue);
                prof.espec_id = Convert.ToInt32(ddl_especialidad.SelectedValue);
                prof.DatProfe_cod = txt_codigo.Text;
                prof.Per_id = perso;

                //metodo de guardar motivo de consulta
                CN_HistorialMedico.guardarMotiConsulta(motcons);
                //metodo de guardar antecedentes personales
                CN_HistorialMedico.guardarAntecedentesPersonales(antper);
                //metodo de guardar antecedentes familiares
                CN_HistorialMedico.guardarAntecedentesFamiliares(antfam);
                //metodo de guardar enfermedad actual
                CN_HistorialMedico.guardarEnfermedadActual(enfact);
                //metodo de guardar revision organos sistemas
                CN_HistorialMedico.guardarRevisionOrganosSistemas(revOrSis);
                //metodo de guardar signos vitales
                CN_HistorialMedico.guardarSisgnosVitalesAntropometricos2(consvit);
                //metodo de guardar examen fisico
                CN_HistorialMedico.guardarExamenFisico(exafis);
                //metodo de guardar diagnostico
                CN_HistorialMedico.guardarDiagnostico(diag);
                //metodo de guardar tratamiento
                CN_HistorialMedico.guardarPlanTratamiento(rectra);
                //metodo de guardar evolucion
                CN_HistorialMedico.guardarEvolucion(evo);
                //metodo de guardar prescripciones
                CN_HistorialMedico.guardarPrescripcion(pres);
                //metodo de guardar profesional
                CN_HistorialMedico.guardarProfesional(prof);

                btn_modificar.Visible = false;                  

                //Mensaje de confirmacion
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Guardados Exitosamente')", true);

                Response.Redirect("~/Template/Views/Pacientes.aspx");
                limpiar();

            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Guardados')", true);
            }            
        }

        private void ModificarHistorial(Tbl_Personas per, Tbl_MotivoConsulta motcons, Tbl_AntePersonales antper, Tbl_AnteFamiliares antfam, 
            Tbl_EnfermedadActual enfact, Tbl_ConsVitAntro consvit, Tbl_ExaFisRegional exafis, Tbl_RecoTratamiento rectra, Tbl_Evolucion evo, 
            Tbl_Prescipciones pres, Tbl_DatProfesional prof)
        {
            try
            {
                per = new Tbl_Personas();
                motcons = new Tbl_MotivoConsulta();
                //antper = new Tbl_AntePersonales();
                //antfam = new Tbl_AnteFamiliares();
                //enfact = new Tbl_EnfermedadActual();
                //consvit = new Tbl_ConsVitAntro();
                //exafis = new Tbl_ExaFisRegional();
                //rectra = new Tbl_RecoTratamiento();
                //evo = new Tbl_Evolucion();
                //pres = new Tbl_Prescipciones();
                //prof = new Tbl_DatProfesional();


                per.Per_priNombre = txt_priNombre.Text;
                per.Per_priApellido = txt_priApellido.Text;
                per.Per_Cedula =Convert.ToInt32(txt_numHClinica.Text);
                per.Per_genero = txt_sexo.Text;
                //captura de datos tbl_motivoconsulta
                motcons.Mcon_descripcion = txt_moConsulta.Text;
                ////captura de datos tbl_antepersonales
                //antper.TiEnf_id = Convert.ToInt32(ddl_tipoAntPer.SelectedValue);
                //antper.AntPer_antecedente = txt_antePersonales.Text;
                //antper.AntPer_descripcion = txt_antePerDescripcion.Text;
                ////captura de datos tbl_antefamiliares
                //antfam.TiEnf_id = Convert.ToInt32(ddl_tipoAntFam.SelectedValue);
                //antfam.AntFami_antecendente = txt_anteFamiliares.Text;
                //antfam.AntFami_descripcion = txt_anteFamDescripcion.Text;
                ////captura de datos Tbl_EnfermedadActual
                //enfact.EnfActu_descrip = txt_enfeActual.Text;
                ////captura de datos Tbl_ConsVitAntro
                //consvit.ConsVitAntro_preArterial = txt_presArterial.Text;
                //consvit.ConsVitAntro_temperatura = txt_temperatura.Text;
                //consvit.ConsVitAntro_frecCardiacan = txt_frecCardiaca.Text;
                //consvit.ConsVitAntro_satOxigenon = txt_satOxigeno.Text;
                //consvit.ConsVitAntro_frecRespiratorian = txt_frecRespiratoria.Text;
                //consvit.ConsVitAntro_peson = txt_peso.Text;
                //consvit.ConsVitAntro_tallan = txt_talla.Text;
                //consvit.ConsVitAntro_indMasCorporaln = txt_indMasCorporal.Text;
                //consvit.ConsVitAntro_perAbdominaln = txt_perAbdominal.Text;
                ////captura de datos Tbl_ExaFisRegional
                //exafis.ExaFisRegional_observaciones = txt_exafisdescripcion.Text;
                ////captura de datos Tbl_RecoTratamiento
                //rectra.RecTra_descripcion = txt_tratamiento.Text;
                ////captura de datos Tbl_Evolucion
                //evo.Evolucion_notas = txt_evolucion.Text;
                ////captura de datos Tbl_Prescipciones
                //pres.Press_descripcion = txt_prescipciones.Text;
                ////captura de datos Tbl_Profesional
                //prof.DatProfe_fecha_hora = Convert.ToDateTime(txt_fechahora.Text);
                //prof.prof_id = Convert.ToInt32(ddl_profesional.SelectedValue);
                //prof.espec_id = Convert.ToInt32(ddl_especialidad.SelectedValue);
                //prof.DatProfe_cod = txt_codigo.Text;

                //metodo de guardar motivo de consulta
                CN_HistorialMedico.modificarMotiConsulta(motcons);
                ////metodo de guardar antecedentes personales
                //CN_HistorialMedico.modificarAntecedentesPersonales(antper);
                ////metodo de guardar antecedentes familiares
                //CN_HistorialMedico.modificarAntecedentesFamiliares(antfam);
                ////metodo de guardar enfermedad actual
                //CN_HistorialMedico.modificarEnfermedadActual(enfact);
                ////metodo de guardar signos vitales
                //CN_HistorialMedico.modificarSisgnosVitalesAntropometricos2(consvit);
                ////metodo de guardar examen fisico
                //CN_HistorialMedico.modificarExamenFisico(exafis);
                ////metodo de guardar tratamiento
                //CN_HistorialMedico.modificarPlanTratamiento(rectra);
                ////metodo de guardar evolucion
                //CN_HistorialMedico.modificarEvolucion(evo);
                ////metodo de guardar prescripciones
                //CN_HistorialMedico.modificarPrescripcion(pres);
                ////metodo de guardar profesional
                //CN_HistorialMedico.modificarProfesional(prof);


                //Mensaje de confirmacion
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Modificados Exitosamente')", true);
                Response.Redirect("~/Template/Views/Pacientes.aspx");

                limpiar();

            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Modificados')", true);
            }
        }                

        private void cargarTipoAntecedentePersonal()
        {
            List<Tbl_Tipos_de_Enfermedades> listaTipoAnte = new List<Tbl_Tipos_de_Enfermedades>();
            listaTipoAnte = CN_HistorialMedico.obtenerTipoAntecedente();
            listaTipoAnte.Insert(0, new Tbl_Tipos_de_Enfermedades() { TiEnf_nombre = "Seleccione ........" });

            ddl_tipoAntPer.DataSource = listaTipoAnte;
            ddl_tipoAntPer.DataTextField = "TiEnf_nombre";
            ddl_tipoAntPer.DataValueField = "TiEnf_id";
            ddl_tipoAntPer.DataBind();
        }

        private void cargarTipoAntecedenteFamiliar()
        {
            List<Tbl_Tipos_de_Enfermedades> listaTipoAnte = new List<Tbl_Tipos_de_Enfermedades>();
            listaTipoAnte = CN_HistorialMedico.obtenerTipoAntecedente();
            listaTipoAnte.Insert(0, new Tbl_Tipos_de_Enfermedades() { TiEnf_nombre = "Seleccione ........" });

            ddl_tipoAntFam.DataSource = listaTipoAnte;
            ddl_tipoAntFam.DataTextField = "TiEnf_nombre";
            ddl_tipoAntFam.DataValueField = "TiEnf_id";
            ddl_tipoAntFam.DataBind();
        }

        private void cargarRegion()
        {
            List<Tbl_Regiones> listaReg = new List<Tbl_Regiones>();
            listaReg = CN_HistorialMedico.obtenerRegion();
            listaReg.Insert(0, new Tbl_Regiones() { Regiones_nombres = "Seleccione ........" });

            ddl_region.DataSource = listaReg;
            ddl_region.DataTextField = "Regiones_nombres";
            ddl_region.DataValueField = "Regiones_id";
            ddl_region.DataBind();
            ddl_tipoRegion.Items.Insert(0, new ListItem("Seleccione ........", "0"));

        }

        protected void ddl_region_SelectedIndexChanged(object sender, EventArgs e)
        {
            int regionid = Convert.ToInt32(ddl_region.SelectedValue);

            var query = from tipreg in dc.Tbl_TipoExaFisRegional where tipreg.Regiones_id == regionid select tipreg;

            ddl_tipoRegion.DataSource = query.ToList();
            ddl_tipoRegion.DataTextField = "tipoExa_nombres";
            ddl_tipoRegion.DataValueField = "tipoExa_id";
            ddl_tipoRegion.DataBind();
            ddl_tipoRegion.Items.Insert(0, new ListItem("Seleccione ........", "0"));

            tipreg = CN_HistorialMedico.obtenerTipoRegionxReg(regionid);
        }

        private void cargarEvidenciaPatologica1()
        {
            List<Tbl_EviPatologica1> listaEviPat = new List<Tbl_EviPatologica1>();
            listaEviPat = CN_HistorialMedico.obtenerEviPatologica1();
            listaEviPat.Insert(0, new Tbl_EviPatologica1() { eviPat1_nomOpcion = "Seleccione ........" });

            ddl_orgSistemas.DataSource = listaEviPat;
            ddl_orgSistemas.DataTextField = "eviPat1_nomOpcion";
            ddl_orgSistemas.DataValueField = "eviPat1_id";
            ddl_orgSistemas.DataBind();

        }
        private void cargarEvidenciaPatologica2()
        {
            List<Tbl_EviPatologica2> listaEviPat = new List<Tbl_EviPatologica2>();
            listaEviPat = CN_HistorialMedico.obtenerEviPatologica2();
            listaEviPat.Insert(0, new Tbl_EviPatologica2() { eviPat2_nomOpcion = "Seleccione ........" });

            ddl_respiratorio.DataSource = listaEviPat;
            ddl_respiratorio.DataTextField = "eviPat2_nomOpcion";
            ddl_respiratorio.DataValueField = "eviPat2_id";
            ddl_respiratorio.DataBind();
        }
        private void cargarEvidenciaPatologica3()
        {
            List<Tbl_EviPatologica3> listaEviPat = new List<Tbl_EviPatologica3>();
            listaEviPat = CN_HistorialMedico.obtenerEviPatologica3();
            listaEviPat.Insert(0, new Tbl_EviPatologica3() { eviPat3_nomOpcion = "Seleccione ........" });

            ddl_carVascular.DataSource = listaEviPat;
            ddl_carVascular.DataTextField = "eviPat3_nomOpcion";
            ddl_carVascular.DataValueField = "eviPat3_id";
            ddl_carVascular.DataBind();
        }
        private void cargarEvidenciaPatologica4()
        {
            List<Tbl_EviPatologica4> listaEviPat = new List<Tbl_EviPatologica4>();
            listaEviPat = CN_HistorialMedico.obtenerEviPatologica4();
            listaEviPat.Insert(0, new Tbl_EviPatologica4() { eviPat4_nomOpcion = "Seleccione ........" });

            ddl_digestivo.DataSource = listaEviPat;
            ddl_digestivo.DataTextField = "eviPat4_nomOpcion";
            ddl_digestivo.DataValueField = "eviPat4_id";
            ddl_digestivo.DataBind();
        }
        private void cargarEvidenciaPatologica5()
        {
            List<Tbl_EviPatologica5> listaEviPat = new List<Tbl_EviPatologica5>();
            listaEviPat = CN_HistorialMedico.obtenerEviPatologica5();
            listaEviPat.Insert(0, new Tbl_EviPatologica5() { eviPat5_nomOpcion = "Seleccione ........" });

            ddl_genital.DataSource = listaEviPat;
            ddl_genital.DataTextField = "eviPat5_nomOpcion";
            ddl_genital.DataValueField = "eviPat5_id";
            ddl_genital.DataBind();
        }
        private void cargarEvidenciaPatologica6()
        {
            List<Tbl_EviPatologica6> listaEviPat = new List<Tbl_EviPatologica6>();
            listaEviPat = CN_HistorialMedico.obtenerEviPatologica6();
            listaEviPat.Insert(0, new Tbl_EviPatologica6() { eviPat6_nomOpcion = "Seleccione ........" });

            ddl_urinario.DataSource = listaEviPat;
            ddl_urinario.DataTextField = "eviPat6_nomOpcion";
            ddl_urinario.DataValueField = "eviPat6_id";
            ddl_urinario.DataBind();
        }
        private void cargarEvidenciaPatologica7()
        {
            List<Tbl_EviPatologica7> listaEviPat = new List<Tbl_EviPatologica7>();
            listaEviPat = CN_HistorialMedico.obtenerEviPatologica7();
            listaEviPat.Insert(0, new Tbl_EviPatologica7() { eviPat7_nomOpcion = "Seleccione ........" });

            ddl_muscular.DataSource = listaEviPat;
            ddl_muscular.DataTextField = "eviPat7_nomOpcion";
            ddl_muscular.DataValueField = "eviPat7_id";
            ddl_muscular.DataBind();
        }
        private void cargarEvidenciaPatologica8()
        {
            List<Tbl_EviPatologica8> listaEviPat = new List<Tbl_EviPatologica8>();
            listaEviPat = CN_HistorialMedico.obtenerEviPatologica8();
            listaEviPat.Insert(0, new Tbl_EviPatologica8() { eviPat8_nomOpcion = "Seleccione ........" });

            ddl_esqueletico.DataSource = listaEviPat;
            ddl_esqueletico.DataTextField = "eviPat8_nomOpcion";
            ddl_esqueletico.DataValueField = "eviPat8_id";
            ddl_esqueletico.DataBind();
        }
        private void cargarEvidenciaPatologica9()
        {
            List<Tbl_EviPatologica9> listaEviPat = new List<Tbl_EviPatologica9>();
            listaEviPat = CN_HistorialMedico.obtenerEviPatologica9();
            listaEviPat.Insert(0, new Tbl_EviPatologica9() { eviPat9_nomOpcion = "Seleccione ........" });

            ddl_nervioso.DataSource = listaEviPat;
            ddl_nervioso.DataTextField = "eviPat9_nomOpcion";
            ddl_nervioso.DataValueField = "eviPat9_id";
            ddl_nervioso.DataBind();
        }
        private void cargarEvidenciaPatologica10()
        {
            List<Tbl_EviPatologica10> listaEviPat = new List<Tbl_EviPatologica10>();
            listaEviPat = CN_HistorialMedico.obtenerEviPatologica10();
            listaEviPat.Insert(0, new Tbl_EviPatologica10() { eviPat10_nomOpcion = "Seleccione ........" });

            ddl_endocrino.DataSource = listaEviPat;
            ddl_endocrino.DataTextField = "eviPat10_nomOpcion";
            ddl_endocrino.DataValueField = "eviPat10_id";
            ddl_endocrino.DataBind();            
        }
        private void cargarEvidenciaPatologica11()
        {
            List<Tbl_EviPatologica11> listaEviPat = new List<Tbl_EviPatologica11>();
            listaEviPat = CN_HistorialMedico.obtenerEviPatologica11();
            listaEviPat.Insert(0, new Tbl_EviPatologica11() { eviPat11_nomOpcion = "Seleccione ........" });

            ddl_hemoLinfatico.DataSource = listaEviPat;
            ddl_hemoLinfatico.DataTextField = "eviPat11_nomOpcion";
            ddl_hemoLinfatico.DataValueField = "eviPat11_id";
            ddl_hemoLinfatico.DataBind();            
        }
        private void cargarEvidenciaPatologica12()
        {
            List<Tbl_EviPatologica12> listaEviPat = new List<Tbl_EviPatologica12>();
            listaEviPat = CN_HistorialMedico.obtenerEviPatologica12();
            listaEviPat.Insert(0, new Tbl_EviPatologica12() { eviPat12_nomOpcion = "Seleccione ........" });

            ddl_tegumentario.DataSource = listaEviPat;
            ddl_tegumentario.DataTextField = "eviPat12_nomOpcion";
            ddl_tegumentario.DataValueField = "eviPat12_id";
            ddl_tegumentario.DataBind();
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

        private void cargarEspecialidad()
        {
            List<Tbl_Especialidad> listaEspec = new List<Tbl_Especialidad>();
            listaEspec = CN_HistorialMedico.obtenerEspecialidad();
            listaEspec.Insert(0, new Tbl_Especialidad() { espec_nombre = "Seleccione ........" });

            ddl_especialidad.DataSource = listaEspec;
            ddl_especialidad.DataTextField = "espec_nombre";
            ddl_especialidad.DataValueField = "espec_id";
            ddl_especialidad.DataBind();
        }

        private void limpiar()
        {
            txt_priNombre.Text = txt_priApellido.Text = txt_sexo.Text = txt_edad.Text = txt_numHClinica.Text = txt_moConsulta.Text =
                txt_antePersonales.Text = txt_anteFamiliares.Text = txt_enfeActual.Text = txt_exafisdescripcion.Text = txt_tratamiento.Text =
                txt_evolucion.Text = txt_prescipciones.Text = txt_presArterial.Text = txt_temperatura.Text = txt_frecCardiaca.Text =
                txt_satOxigeno.Text = txt_frecRespiratoria.Text = txt_peso.Text = txt_talla.Text = txt_indMasCorporal.Text =
                txt_perAbdominal.Text = "";

            ddl_especialidad.ClearSelection();
            ddl_profesional.ClearSelection();
            ddl_region.ClearSelection();
            ddl_tipoAntFam.ClearSelection();
            ddl_tipoAntPer.ClearSelection();
            ddl_tipoRegion.ClearSelection();
        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            guardar_modificar_datos(Convert.ToInt32(Request["cod"]), Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), 
                Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), 
                Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), 
                Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), 
                Convert.ToInt32(per.Per_id.ToString()));
        }

        protected void btn_modificar_Click(object sender, EventArgs e)
        {
            guardar_modificar_datos(Convert.ToInt32(Request["cod"]), Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), 
                Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), 
                Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), 
                Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), Convert.ToInt32(per.Per_id.ToString()), 
                Convert.ToInt32(per.Per_id.ToString()));
        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/Views/Inicio.aspx");
        }

        //public DataSet Consultar(string consultaSQL)
        //{
        //    SqlConnection con = new SqlConnection(@"Data Source=ANDRES-SOSA;Initial Catalog=SistemaECU911;Integrated Security=True");
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand(consultaSQL, con);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds);
        //    con.Close();

        //    return ds;
        //}

        //private void cargarDatosDefecto()
        //{

        //    SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SistemaECU911;Integrated Security=True");
        //    SqlDataReader dr = null;
        //    SqlCommand cmd = null;

        //    if (txt_numHClinica.Text != "")
        //    {
        //        cmd = new SqlCommand("SELECT Per_Cedula, Per_priNombre, Per_priApellido FROM Tbl_Personas WHERE Per_Cedula = '" + txt_numHClinica + "'", con);
        //        con.Open();

        //        try
        //        {
        //            dr = cmd.ExecuteReader();

        //            if (dr.Read() == true)
        //            {
        //                txt_priNombre.Enabled = true;
        //                txt_priApellido.Enabled = true;
        //                txt_numHClinica.Enabled = true;

        //                txt_priNombre.Text = dr["Per_priNombre"].ToString();
        //                txt_priApellido.Text = dr["Per_priApellido"].ToString();
        //                txt_numHClinica.Text = dr["Per_Cedula"].ToString();

        //            }
        //            else
        //            {
        //                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Cedula Invalida')", true);
        //            }
        //        }
        //        catch (Exception)
        //        {

        //            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Error')", true);
        //        }
        //        finally
        //        {
        //            con.Close();
        //        }
        //    }
        //    else
        //    {
        //        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Numero de Historia Requerida')", true);
        //    }

        //    //con.Open();

        //    //SqlCommand cmd = new SqlCommand("SELECT Emp_nombre FROM Tbl_Empresa WHERE Emp_estado = 'A' ", con);
        //    //SqlDataReader consulta = cmd.ExecuteReader();

        //    //if (consulta.Read())
        //    //{
        //    //    txt_nomEmpresa.Text = consulta.ToString();
        //    //}

        //    //consulta.Close();
        //    //con.Close();

        //}

    }

}

