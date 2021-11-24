using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaNegocio;

namespace SistemaECU911.Template.Views
{
	public partial class Inicial : System.Web.UI.Page
	{

		DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

		protected void Page_Load(object sender, EventArgs e)
		{
            GuardarHistorial();
		}

        private void GuardarHistorial()
        {
            try
            {
                //Guardar Persona
                if (string.IsNullOrEmpty(txt_numHClinica.Text) || string.IsNullOrEmpty(txt_moConsulta.Text) 
                    string.IsNullOrEmpty(txt_codigo.Text))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Complete los campos')", true);
                }
                else
                {
                    per = CN_HistorialMedico.obtenerIdPersonasxCedula(Convert.ToInt32(txt_numHClinica.Text));

                    int perso = Convert.ToInt32(per.Per_id.ToString());

                    motcons = new Tbl_MotivoConsulta();
                    antper = new Tbl_AntePersonales();
                    antfam = new Tbl_AnteFamiliares();
                    enfact = new Tbl_EnfermedadActual();
                    consvit = new Tbl_ConsVitAntro();
                    exafis = new Tbl_ExaFisRegional();
                    reg = new Tbl_Regiones();
                    tipreg = new Tbl_TipoExaFisRegional();
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
                    //captura de datos Tbl_ConsVitAntro
                    consvit.ConsVitAntro_preArterial = txt_presArterial.Text;
                    consvit.ConsVitAntro_temperatura = txt_temperatura.Text;
                    consvit.ConsVitAntro_frecCardiacan = txt_frecCardiaca.Text;
                    consvit.ConsVitAntro_satOxigenon = txt_satOxigeno.Text;
                    consvit.ConsVitAntro_frecRespiratorian = txt_frecRespiratoria.Text;
                    consvit.ConsVitAntro_peson = txt_peso.Text;
                    consvit.ConsVitAntro_tallan = txt_talla.Text;
                    consvit.ConsVitAntro_indMasCorporaln = txt_indMasCorporal.Text;
                    consvit.ConsVitAntro_perAbdominaln = txt_perAbdominal.Text;
                    consvit.Per_id = perso;
                    //captura de datos Tbl_ExaFisRegional
                    exafis.Regiones_id = Convert.ToInt32(ddl_region.SelectedValue);
                    exafis.ExaFisRegional_observaciones = txt_exafisdescripcion.Text;
                    exafis.Per_id = perso;
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
                    //metodo de guardar enfermedad actual
                    CN_HistorialMedico.guardarSisgnosVitalesAntropometricos2(consvit);
                    //metodo de guardar examen fisico
                    CN_HistorialMedico.guardarExamenFisico(exafis);
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

            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Guardados')", true);
            }

        }
    }
}