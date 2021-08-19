using System;
using System.Collections.Generic;
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

        SqlConnection con = new SqlConnection(@"Data Source=ANDRES-SOSA;Initial Catalog=SistemaECU911;Integrated Security=True");

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
        //Objeto de la tabla examen fisico
        private Tbl_ExaFisRegional exafis = new Tbl_ExaFisRegional();
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
                txt_fecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
                txt_fecha2.Text = DateTime.Now.ToString("yyyy-MM-dd");
                txt_hora.Text = DateTime.Now.ToString("HH:mm");
            }            
        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            GuardarHistorial();                          
        }

        private void GuardarHistorial()
        {            
            try
            {
                //Guardar Persona
                if (string.IsNullOrEmpty(txt_priNombre.Text) || string.IsNullOrEmpty(txt_priApellido.Text) ||
                    string.IsNullOrEmpty(txt_sexo.Text) || string.IsNullOrEmpty(txt_edad.Text) || string.IsNullOrEmpty(txt_numHClinica.Text) ||
                    string.IsNullOrEmpty(txt_moConsulta.Text) || string.IsNullOrEmpty(txt_antePersonales.Text) || string.IsNullOrEmpty(txt_anteFamiliares.Text))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Complete los campos')", true);
                }
                else
                {
                    per = new Tbl_Personas();
                    motcons = new Tbl_MotivoConsulta();
                    antper = new Tbl_AntePersonales();
                    antfam = new Tbl_AnteFamiliares();
                    enfact = new Tbl_EnfermedadActual();
                    exafis = new Tbl_ExaFisRegional();
                    rectra = new Tbl_RecoTratamiento();
                    evo = new Tbl_Evolucion();
                    pres = new Tbl_Prescipciones();
                    prof = new Tbl_DatProfesional();

                    //captura de datos tbl_personas
                    per.Per_priNombre = txt_priNombre.Text;
                    per.Per_priApellido = txt_priApellido.Text;
                    per.Per_sexo = txt_sexo.Text;
                    per.Per_edad = Convert.ToInt32(txt_edad.Text);
                    per.Per_CedulaHisCli = Convert.ToInt32(txt_numHClinica.Text);
                    //captura de datos tbl_motivoconsulta
                    motcons.Mcon_descripcion = txt_moConsulta.Text;
                    //captura de datos tbl_antepersonales
                    antper.AntPer_descripcion = txt_antePersonales.Text;
                    //captura de datos tbl_antefamiliares
                    antfam.AntFami_descripcion = txt_anteFamiliares.Text;
                    //captura de datos Tbl_EnfermedadActual
                    enfact.EnfActu_descrip = txt_enfeActual.Text;
                    //captura de datos Tbl_ExaFisRegional
                    exafis.ExaFisRegional_observaciones = txt_exafisdescripcion.Text;
                    //captura de datos Tbl_RecoTratamiento
                    rectra.RecTra_descripcion = txt_tratamiento.Text;
                    //captura de datos Tbl_Evolucion
                    evo.Evolucion_notas = txt_evolucion.Text;
                    //captura de datos Tbl_Prescipciones
                    pres.Press_descripcion = txt_prescipciones.Text;
                    //captura de datos Tbl_Prescipciones
                    prof.Profe_fecha = Convert.ToDateTime(txt_fecha2.Text);
                    prof.Profe_hora = Convert.ToDateTime(txt_hora.Text);

                    //metodo de guardar personas
                    CN_HistorialMedico.guardarPersona(per);
                    //metodo de guardar motivo de consulta
                    CN_HistorialMedico.guardarMotiConsulta(motcons);
                    //metodo de guardar antecedentes personales
                    CN_HistorialMedico.guardarAntecedentesPersonales(antper);
                    //metodo de guardar antecedentes familiares
                    CN_HistorialMedico.guardarAntecedentesFamiliares(antfam);
                    //metodo de guardar enfermedad actual
                    CN_HistorialMedico.guardarEnfermedadActual(enfact);
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


                    //Mensaje de confirmacion
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Guardados Exitosamente')", true);

                    limpiar();

                }

            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Guardados')", true);
            }
                        
        }       

        private void limpiar()
        {
            txt_priNombre.Text = txt_priApellido.Text = txt_sexo.Text = txt_edad.Text = txt_numHClinica.Text = txt_moConsulta.Text = 
                txt_antePersonales.Text = txt_anteFamiliares.Text = txt_enfeActual.Text = txt_exafisdescripcion.Text = txt_tratamiento.Text =
                txt_evolucion.Text = txt_prescipciones.Text = "";
        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/Views/Inicio.aspx");
        }

    }

}


//if (string.IsNullOrEmpty(txt_priNombre.Text) || string.IsNullOrEmpty(txt_priApellido.Text) || string.IsNullOrEmpty(txt_sexo.Text)
//                || string.IsNullOrEmpty(txt_edad.Text) || string.IsNullOrEmpty(txt_numHClinica.Text))
//{
//    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Complete los campos')", true);
//}
//else
//{
//    try
//    {
//        con.Open();
//        string sql = "insert into Tbl_Usuario values(@priNom,@priApe,@sexo,@edad,@hCli)";
//        SqlCommand cmd = new SqlCommand(sql, con);
//        cmd.Parameters.AddWithValue("@priNom", txt_priNombre.Text.Trim());
//        cmd.Parameters.AddWithValue("@priApe", txt_priApellido.Text.Trim());
//        cmd.Parameters.AddWithValue("@sexo", txt_sexo.Text.Trim());
//        cmd.Parameters.AddWithValue("@edad", Convert.ToInt32(txt_edad.Text.Trim()));
//        cmd.Parameters.AddWithValue("@hCli", Convert.ToInt32(txt_numHClinica.Text.Trim()));
//        cmd.ExecuteNonQuery();

//        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Guardados Exitosamente')", true);
//        limpiar();
//    }
//    catch (Exception)
//    {
//        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Guardados')", true);
//    }


//}