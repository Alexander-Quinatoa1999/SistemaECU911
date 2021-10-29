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

        private Tbl_HistorialMed histoid = new Tbl_HistorialMed();
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
        //Objeto de la tabla signos vitales y antropometricos
        private Tbl_ConsVitAntro consvit = new Tbl_ConsVitAntro();
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
                if (Request["cod"] != null /*|| Request["cod2"] != null*/)
                {
                    int codigo = Convert.ToInt32(Request["cod"]);

                    var query = from hm in dc.Tbl_HistorialMed
                                join p in dc.Tbl_Personas on hm.per_id equals p.Per_id
                                join m in dc.Tbl_MotivoConsulta on hm.Mcon_id equals m.Mcon_id
                                where hm.histo_id == codigo
                                select new 
                                {
                                    hm.histo_id,
                                    p.Per_priNombre,
                                    p.Per_priApellido,
                                    p.Per_genero,
                                    p.Per_Cedula,
                                    m.Mcon_descripcion
                                };

                    //int codigo2 = Convert.ToInt32(Request["cod2"]);
                    histoid = CN_HistorialMedico.obtenerHistorialMedxId(codigo);
                    //motcons = CN_HistorialMedico.obtenerMotivoConsultaxid(codigo2);
                    btn_guardar.Visible = true;

                    if (histoid != null /*|| motcons != null*/)
                    {
                        txt_priNombre.Text = 
                        txt_priApellido.Text = per.Per_priApellido.ToString();
                        txt_numHClinica.Text = per.Per_Cedula.ToString();
                        txt_sexo.Text = per.Per_genero.ToString();

                        txt_moConsulta.Text = motcons.Mcon_descripcion.ToString();

                        btn_guardar.Visible = false;
                    }
                }

                txt_fecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
                txt_fecha2.Text = DateTime.Now.ToString(" dd/MM/yyyy " + " HH:mm ");

                //cargarDatosDefecto();

                cargarTipoAntecedentePersonal();
                cargarTipoAntecedenteFamiliar();
                cargarProfesional();
                cargarEspecialidad();
                cargarProf();
                cargarEspe();
                cargarRegion();
            }            
        }

        private void guardar_modificar_datos(int hismedid/*int personaid/*, int motivoconsid*/)
        {
            if (hismedid == 0 /*|| motivoconsid == 0*/)
            {
                GuardarHistorial();
            }
            else
            {
                histoid = CN_HistorialMedico.obtenerHistorialMedxId(hismedid);
                //motcons = CN_HistorialMedico.obtenerMotivoConsultaxid(motivoconsid);
                if (histoid != null /*|| motcons != null*/)
                {
                    Modificar(histoid/*, motcons*/);
                }
            }
        }

        private void GuardarHistorial()
        {
            try
            {
                //Guardar Persona
                if (string.IsNullOrEmpty(txt_moConsulta.Text) || string.IsNullOrEmpty(txt_antePersonales.Text) ||
                    string.IsNullOrEmpty(txt_anteFamiliares.Text) || ddl_tipoAntPer.SelectedValue == "0" || ddl_tipoAntFam.SelectedValue == "0"
                    || ddl_espe.SelectedValue == "0" || ddl_prof.SelectedValue == "0" || ddl_region.SelectedValue == "0" ||
                    ddl_especialidad.SelectedValue == "0" || ddl_profesional.SelectedValue == "0" || string.IsNullOrEmpty(txt_presArterial.Text)
                    || string.IsNullOrEmpty(txt_temperatura.Text) || string.IsNullOrEmpty(txt_frecCardiaca.Text) ||
                    string.IsNullOrEmpty(txt_satOxigeno.Text) || string.IsNullOrEmpty(txt_frecRespiratoria.Text) ||
                    string.IsNullOrEmpty(txt_peso.Text) || string.IsNullOrEmpty(txt_talla.Text) || string.IsNullOrEmpty(txt_indMasCorporal.Text)
                    || string.IsNullOrEmpty(txt_perAbdominal.Text))
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
                    consvit = new Tbl_ConsVitAntro();
                    exafis = new Tbl_ExaFisRegional();
                    rectra = new Tbl_RecoTratamiento();
                    evo = new Tbl_Evolucion();
                    pres = new Tbl_Prescipciones();
                    prof = new Tbl_DatProfesional();

                    per.Per_priNombre = txt_priNombre.Text;
                    per.Per_priApellido = txt_priApellido.Text;
                    per.Per_Cedula = Convert.ToInt32(txt_numHClinica.Text);
                    per.Per_genero = txt_sexo.Text;
                    //captura de datos tbl_motivoconsulta
                    motcons.Mcon_descripcion = txt_moConsulta.Text;
                    //captura de datos tbl_antepersonales
                    antper.TiEnf_id = Convert.ToInt32(ddl_tipoAntPer.SelectedValue);
                    antper.AntPer_descripcion = txt_antePersonales.Text;
                    //captura de datos tbl_antefamiliares
                    antfam.TiEnf_id = Convert.ToInt32(ddl_tipoAntFam.SelectedValue);
                    antfam.AntFami_descripcion = txt_anteFamiliares.Text;
                    //captura de datos Tbl_EnfermedadActual
                    enfact.EnfActu_descrip = txt_enfeActual.Text;
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
                    //captura de datos Tbl_ExaFisRegional
                    exafis.ExaFisRegional_observaciones = txt_exafisdescripcion.Text;
                    //captura de datos Tbl_RecoTratamiento
                    rectra.RecTra_descripcion = txt_tratamiento.Text;
                    //captura de datos Tbl_Evolucion
                    evo.Evolucion_notas = txt_evolucion.Text;
                    //captura de datos Tbl_Prescipciones
                    pres.Press_descripcion = txt_prescipciones.Text;
                    //captura de datos Tbl_Profesional
                    prof.DatProfe_fecha_hora = Convert.ToDateTime(txt_fecha2.Text);
                    prof.prof_id = Convert.ToInt32(ddl_profesional.SelectedValue);
                    prof.espec_id = Convert.ToInt32(ddl_especialidad.SelectedValue);
                    prof.DatProfe_cod = txt_codigo.Text;


                    CN_HistorialMedico.guardarPersona(per);
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

        private void Modificar(Tbl_HistorialMed histoid/*, Tbl_MotivoConsulta motcons*/)
        {
            try
            {
                histoid = new Tbl_HistorialMed();
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
                //antper.AntPer_descripcion = txt_antePersonales.Text;
                ////captura de datos tbl_antefamiliares
                //antfam.TiEnf_id = Convert.ToInt32(ddl_tipoAntFam.SelectedValue);
                //antfam.AntFami_descripcion = txt_anteFamiliares.Text;
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
                //prof.DatProfe_fecha_hora = Convert.ToDateTime(txt_fecha2.Text);
                //prof.prof_id = Convert.ToInt32(ddl_profesional.SelectedValue);
                //prof.espec_id = Convert.ToInt32(ddl_especialidad.SelectedValue);
                //prof.DatProfe_cod = txt_codigo.Text;


                CN_HistorialMedico.modificarPersona(per);
                //metodo de guardar motivo de consulta
                CN_HistorialMedico.modificarMotiConsulta(motcons);
                ////metodo de guardar antecedentes personales
                //CN_HistorialMedico.guardarAntecedentesPersonales(antper);
                ////metodo de guardar antecedentes familiares
                //CN_HistorialMedico.guardarAntecedentesFamiliares(antfam);
                ////metodo de guardar enfermedad actual
                //CN_HistorialMedico.guardarEnfermedadActual(enfact);
                ////metodo de guardar enfermedad actual
                //CN_HistorialMedico.guardarSisgnosVitalesAntropometricos2(consvit);
                ////metodo de guardar examen fisico
                //CN_HistorialMedico.guardarExamenFisico(exafis);
                ////metodo de guardar tratamiento
                //CN_HistorialMedico.guardarPlanTratamiento(rectra);
                ////metodo de guardar evolucion
                //CN_HistorialMedico.guardarEvolucion(evo);s
                ////metodo de guardar prescripciones
                //CN_HistorialMedico.guardarPrescripcion(pres);
                ////metodo de guardar profesional
                //CN_HistorialMedico.guardarProfesional(prof);


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
        }


        private void cargarProf()
        {
            List<Tbl_Profesional> listaProf = new List<Tbl_Profesional>();
            listaProf = CN_HistorialMedico.obtenerProfesional();
            listaProf.Insert(0, new Tbl_Profesional() { prof_NomApe = "Seleccione ........" });

            ddl_prof.DataSource = listaProf;
            ddl_prof.DataTextField = "prof_NomApe";
            ddl_prof.DataValueField = "prof_id";
            ddl_prof.DataBind();
        }

        private void cargarEspe()
        {
            List<Tbl_Especialidad> listaEspec = new List<Tbl_Especialidad>();
            listaEspec = CN_HistorialMedico.obtenerEspecialidad();
            listaEspec.Insert(0, new Tbl_Especialidad() { espec_nombre = "Seleccione ........" });

            ddl_espe.DataSource = listaEspec;
            ddl_espe.DataTextField = "espec_nombre";
            ddl_espe.DataValueField = "espec_id";
            ddl_espe.DataBind();
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

            ddl_espe.ClearSelection();
            ddl_especialidad.ClearSelection();
            ddl_prof.ClearSelection();
            ddl_profesional.ClearSelection();
            ddl_region.ClearSelection();
            ddl_tipoAntFam.ClearSelection();
            ddl_tipoAntPer.ClearSelection();
            ddl_tipoRegion.ClearSelection();
        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            guardar_modificar_datos(Convert.ToInt32(Request["cod"])/*, Convert.ToInt32(Request["cod2"])*/);
        }

        protected void btn_modificar_Click(object sender, EventArgs e)
        {
            guardar_modificar_datos(Convert.ToInt32(Request["cod"])/*, Convert.ToInt32(Request["cod2"])*/);
        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/Views/Inicio.aspx");
        }

        public DataSet Consultar(string consultaSQL)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ANDRES-SOSA;Initial Catalog=SistemaECU911;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(consultaSQL, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();

            return ds;
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