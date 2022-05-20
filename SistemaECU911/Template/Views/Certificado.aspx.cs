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
    public partial class Certificado : System.Web.UI.Page
    {

        private readonly DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        private Tbl_Personas per = new Tbl_Personas();
        private Tbl_Certificado certi = new Tbl_Certificado();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["cod"] != null)
                {
                    int codigo = Convert.ToInt32(Request["cod"]);
                    certi = CN_Certificado.ObtenerCertificadoPorId(codigo);
                    int personasid = Convert.ToInt32(certi.Per_id.ToString());
                    per = CN_HistorialMedico.ObtenerPersonasxId(personasid);
                    
                    btn_guardar.Text = "Actualizar";

                    if (per != null)
                    {
                        txt_priNombre.Text = per.Per_priNombre.ToString();
                        txt_segNombre.Text = per.Per_segNombre.ToString();
                        txt_priApellido.Text = per.Per_priApellido.ToString();
                        txt_segApellido.Text = per.Per_segApellido.ToString();
                        txt_sexo.Text = per.Per_genero.ToString();
                        txt_numHClinica.Text = per.Per_cedula.ToString();
                        txt_puestoTrabajo.Text = per.Per_puestoTrabajo.ToString();

                        if (certi != null)
                        {

                            //Datos Generales
                            if (certi.certi_ingreso == null)
                            {
                                ckb_ingreso.Checked = false;
                            }
                            else
                            {
                                ckb_ingreso.Checked = true;
                            }
                            if (certi.certi_periodico == null)
                            {
                                ckb_periodico.Checked = false;
                            }
                            else
                            {
                                ckb_periodico.Checked = true;
                            }
                            if (certi.certi_reintegro == null)
                            {
                                ckb_reintegro.Checked = false;
                            }
                            else
                            {
                                ckb_reintegro.Checked = true;
                            }
                            if (certi.certi_retiro == null)
                            {
                                ckb_retiro.Checked = false;
                            }
                            else
                            {
                                ckb_retiro.Checked = true;
                            }

                            //Aptitud Medica para el trabajo
                            if (certi.certi_apto == null)
                            {
                                ckb_apto.Checked = false;
                            }
                            else
                            {
                                ckb_apto.Checked = true;

                            }
                            if (certi.certi_aptoObserva == null)
                            {
                                ckb_aptoObservacion.Checked = false;
                            }
                            else
                            {
                                ckb_aptoObservacion.Checked = true;

                            }
                            if (certi.certi_aptoLimi == null)
                            {
                                ckb_aptoLimitaciones.Checked = false;
                            }
                            else
                            {
                                ckb_aptoLimitaciones.Checked = true;

                            }
                            if (certi.certi_NoApto == null)
                            {
                                ckb_noApto.Checked = false;
                            }
                            else
                            {
                                ckb_noApto.Checked = true;

                            }

                            // Evaluación Médica de retiro
                            if (certi.certi_siUsuEvaMed == null)
                            {
                                ckb_siEvaMedRetiro.Checked = false;
                            }
                            else
                            {
                                ckb_siEvaMedRetiro.Checked = true;

                            }
                            if (certi.certi_noUsuEvaMed == null)
                            {
                                ckb_noEvaMedRetiro.Checked = false;
                            }
                            else
                            {
                                ckb_noEvaMedRetiro.Checked = true;

                            }
                            if (certi.certi_presunCondiDiag == null)
                            {
                                ckb_presuntivaCondiDiag.Checked = false;
                            }
                            else
                            {
                                ckb_presuntivaCondiDiag.Checked = true;

                            }
                            if (certi.certi_defiCondiDiag == null)
                            {
                                ckb_definitivaCondiDiag.Checked = false;
                            }
                            else
                            {
                                ckb_definitivaCondiDiag.Checked = true;

                            }
                            if (certi.certi_noAplicaCondiDiag == null)
                            {
                                ckb_noAplicaCondiDiag.Checked = false;
                            }
                            else
                            {
                                ckb_noAplicaCondiDiag.Checked = true;

                            }
                            if (certi.certi_siCondiSalud == null)
                            {
                                ckb_siCondiSalud.Checked = false;
                            }
                            else
                            {
                                ckb_siCondiSalud.Checked = true;

                            }
                            if (certi.certi_noCondiSalud == null)
                            {
                                ckb_noCondiSalud.Checked = false;
                            }
                            else
                            {
                                ckb_noCondiSalud.Checked = true;

                            }
                            if (certi.certi_noAplicaCondiSalud == null)
                            {
                                ckb_noAplicaCondiSalud.Checked = false;
                            }
                            else
                            {
                                ckb_noAplicaCondiSalud.Checked = true;
                            }


                            //A
                            txt_numArchivo.Text = certi.certi_numArchivo.ToString();

                            //B
                            txt_fechaEmision.Text = certi.certi_fechEmision.ToString();
                            //txt_ingreso.Text = certi.certi_ingreso.ToString();
                            //txt_certidico.Text = certi.certi_certidico.ToString();
                            //txt_reintegro.Text = certi.certi_reintegro.ToString();
                            //txt_retiro.Text = certi.certi_retiro.ToString();

                            ////C
                            //txt_apto.Text = certi.certi_apto.ToString();
                            //txt_aptoObservacion.Text = certi.certi_aptoObserva.ToString();
                            //txt_aptoLimitaciones.Text = certi.certi_aptoLimi.ToString();
                            //txt_noApto.Text = certi.certi_NoApto.ToString();
                            txt_detaObservaAptiMedLaboral.Text = certi.certi_ObservAptiMedLaboral.ToString();

                            ////D
                            //txt_siEvaMedRetiro.Text = certi.certi_siUsuEvaMed.ToString();
                            //txt_noEvaMedRetiro.Text = certi.certi_noUsuEvaMed.ToString();
                            //txt_presuntivaEvaMedRetiro.Text = certi.certi_presunCondiDiag.ToString();
                            //txt_definitivaEvaMedRetiro.Text = certi.certi_defiCondiDiag.ToString();
                            //txt_noAplicaEvaMedRetiro.Text = certi.certi_noAplicaCondiDiag.ToString();
                            //txt_si2EvaMedRetiro.Text = certi.certi_siCondiSalud.ToString();
                            //txt_no2EvaMedRetiro.Text = certi.certi_noAplicaCondiSalud.ToString();
                            //txt_noAplica2EvaMedRetiro.Text = certi.certi_noAplicaCondiSalud.ToString();

                            //E
                            txt_descripRecomendaciones.Text = certi.certi_descripcionRecomendaciones.ToString();

                            //F
                            ddl_profesional.SelectedValue = certi.prof_id.ToString();
                            txt_codigo.Text = certi.certi_cod.ToString();
                        }
                    }
                }
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

        protected void txt_numHistoCli_TextChanged(object sender, EventArgs e)
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

        private void GuardarCertificado()
        {
            try
            {
                per = CN_HistorialMedico.ObtenerIdPersonasxCedula(Convert.ToInt32(txt_numHClinica.Text));

                int perso = Convert.ToInt32(per.Per_id.ToString());

                //Datos Generales
                if (ckb_ingreso.Checked == true)
                {
                    certi.certi_ingreso = "SI";                    
                }
                if (ckb_periodico.Checked == true)
                {
                    certi.certi_periodico = "SI";                    
                }
                if (ckb_reintegro.Checked == true)
                {
                    certi.certi_reintegro = "SI";                    
                }
                if (ckb_retiro.Checked == true)
                {
                    certi.certi_retiro = "SI";                    
                }

                //Aptitud Medica para el trabajo
                if (ckb_apto.Checked == true)
                {
                    certi.certi_apto = "SI";                    
                }

                if (ckb_aptoObservacion.Checked == true)
                {
                    certi.certi_aptoObserva = "SI";                    
                }

                if (ckb_aptoLimitaciones.Checked == true)
                {
                    certi.certi_aptoLimi = "SI";                    
                }

                if (ckb_noApto.Checked == true)
                {
                    certi.certi_NoApto = "SI";                    
                }


                // Evaluación Médica de retiro
                if (ckb_siEvaMedRetiro.Checked == true)
                {
                    certi.certi_siUsuEvaMed = "SI";                    
                }
                if (ckb_noEvaMedRetiro.Checked == true)
                {
                    certi.certi_noUsuEvaMed = "SI";                    
                }
                if (ckb_presuntivaCondiDiag.Checked == true)
                {
                    certi.certi_presunCondiDiag = "SI";                    
                }
                if (ckb_definitivaCondiDiag.Checked == true)
                {
                    certi.certi_defiCondiDiag = "SI";                    
                }
                if (ckb_noAplicaCondiDiag.Checked == true)
                {
                    certi.certi_noAplicaCondiDiag = "SI";                    
                }
                if (ckb_siCondiSalud.Checked == true)
                {
                    certi.certi_siCondiSalud = "SI";                    
                }
                if (ckb_noCondiSalud.Checked == true)
                {
                    certi.certi_noCondiSalud = "SI";                    ;
                }
                if (ckb_noAplicaCondiSalud.Checked == true)
                {
                    certi.certi_noAplicaCondiSalud = "SI";                    
                }

                certi = new Tbl_Certificado
                {
                    //A
                    certi_numArchivo = txt_numArchivo.Text,

                    //B.
                    certi_fechEmision = Convert.ToDateTime(txt_fechaEmision.Text),
                    //certi_ingreso = txt_ingreso.Text,
                    //certi_certidico = txt_certidico.Text,
                    //certi_reintegro = txt_reintegro.Text,
                    //certi_retiro = txt_retiro.Text,

                    //C.
                    //certi_apto = txt_apto.Text,
                    //certi_aptoObserva = txt_aptoObservacion.Text,
                    //certi_aptoLimi = txt_aptoLimitaciones.Text,
                    //certi_NoApto = txt_noApto.Text,
                    certi_ObservAptiMedLaboral = txt_detaObservaAptiMedLaboral.Text,

                    //D.
                    //certi_siUsuEvaMed = txt_siEvaMedRetiro.Text,
                    //certi_noUsuEvaMed = txt_noEvaMedRetiro.Text,
                    //certi_presunCondiDiag = txt_presuntivaEvaMedRetiro.Text,
                    //certi_defiCondiDiag = txt_definitivaEvaMedRetiro.Text,
                    //certi_noAplicaCondiDiag = txt_noAplicaEvaMedRetiro.Text,
                    //certi_siCondiSalud = txt_si2EvaMedRetiro.Text,
                    //certi_noCondiSalud = txt_no2EvaMedRetiro.Text,
                    //certi_noAplicaCondiSalud = txt_noAplica2EvaMedRetiro.Text,

                    //E.
                    certi_descripcionRecomendaciones = txt_descripRecomendaciones.Text,

                    //F.
                    prof_id = Convert.ToInt32(ddl_profesional.SelectedValue),
                    certi_cod = txt_codigo.Text,
                    Per_id = perso
                };

                CN_Certificado.GuardarCertificado(certi);

                //Mensaje de confirmacion
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Guardados Exitosamente')", true);

                Response.Redirect("~/Template/Views/PacientesCertificado.aspx");
            }
            catch(Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Guardados')", true);
            }
        }

        private void ModificarHistorial(Tbl_Certificado certi)
        {
            try
            {

                //Datos Generales
                if (ckb_ingreso.Checked == true)
                {
                    certi.certi_ingreso = "SI";
                }
                else
                {
                    certi.certi_ingreso = null;
                }
                if (ckb_periodico.Checked == true)
                {
                    certi.certi_periodico = "SI";
                }
                else
                {
                    certi.certi_periodico = null;
                }
                if (ckb_reintegro.Checked == true)
                {
                    certi.certi_reintegro = "SI";
                }
                else
                {
                    certi.certi_reintegro = null;
                }
                if (ckb_retiro.Checked == true)
                {
                    certi.certi_retiro = "SI";
                }
                else
                {
                    certi.certi_retiro = null;
                }

                //Aptitud Medica para el trabajo
                if (ckb_apto.Checked == true)
                {
                    certi.certi_apto = "SI";
                }
                else
                {
                    certi.certi_apto = null;
                }
                if (ckb_aptoObservacion.Checked == true)
                {
                    certi.certi_aptoObserva = "SI";
                }
                else
                {
                    certi.certi_aptoObserva = null;
                }
                if (ckb_aptoLimitaciones.Checked == true)
                {
                    certi.certi_aptoLimi = "SI";
                }
                else
                {
                    certi.certi_aptoLimi = null;
                }
                if (ckb_noApto.Checked == true)
                {
                    certi.certi_NoApto = "SI";
                }
                else
                {
                    certi.certi_NoApto = null;
                }


                // Evaluación Médica de retiro
                if (ckb_siEvaMedRetiro.Checked == true)
                {
                    certi.certi_siUsuEvaMed = "SI";
                }
                else
                {
                    certi.certi_siUsuEvaMed = null;
                }
                if (ckb_noEvaMedRetiro.Checked == true)
                {
                    certi.certi_noUsuEvaMed = "SI";
                }
                else
                {
                    certi.certi_noUsuEvaMed = null;
                }
                if (ckb_presuntivaCondiDiag.Checked == true)
                {
                    certi.certi_presunCondiDiag = "SI";
                }
                else
                {
                    certi.certi_presunCondiDiag = null;
                }
                if (ckb_definitivaCondiDiag.Checked == true)
                {
                    certi.certi_defiCondiDiag = "SI";
                }
                else
                {
                    certi.certi_defiCondiDiag = null;
                }
                if (ckb_noAplicaCondiDiag.Checked == true)
                {
                    certi.certi_noAplicaCondiDiag = "SI";
                }
                else
                {
                    certi.certi_noAplicaCondiDiag = null;
                }
                if (ckb_siCondiSalud.Checked == true)
                {
                    certi.certi_siCondiSalud = "SI";
                }
                else
                {
                    certi.certi_siCondiSalud = null;
                }
                if (ckb_noCondiSalud.Checked == true)
                {
                    certi.certi_noCondiSalud = "SI";
                }
                else
                {
                    certi.certi_noCondiSalud = null;
                }
                if (ckb_noAplicaCondiSalud.Checked == true)
                {
                    certi.certi_noAplicaCondiSalud = "SI";
                }
                else
                {
                    certi.certi_noAplicaCondiSalud = null;
                }

                //A
                certi.certi_numArchivo = txt_numArchivo.Text;

                //B.
                certi.certi_fechEmision = Convert.ToDateTime(txt_fechaEmision.Text);
                //certi.certi_ingreso = txt_ingreso.Text;
                //certi.certi_certidico = txt_certidico.Text;
                //certi.certi_reintegro = txt_reintegro.Text;
                //certi.certi_retiro = txt_retiro.Text;

                //C.
                //certi.certi_apto = txt_apto.Text;
                //certi.certi_aptoObserva = txt_aptoObservacion.Text;
                //certi.certi_aptoLimi = txt_aptoLimitaciones.Text;
                //certi.certi_NoApto = txt_noApto.Text;
                certi.certi_ObservAptiMedLaboral = txt_detaObservaAptiMedLaboral.Text;

                //D.
                //certi.certi_siUsuEvaMed = txt_siEvaMedRetiro.Text;
                //certi.certi_noUsuEvaMed = txt_noEvaMedRetiro.Text;
                //certi.certi_presunCondiDiag = txt_presuntivaEvaMedRetiro.Text;
                //certi.certi_defiCondiDiag = txt_definitivaEvaMedRetiro.Text;
                //certi.certi_noAplicaCondiDiag = txt_noAplicaEvaMedRetiro.Text;
                //certi.certi_siCondiSalud = txt_si2EvaMedRetiro.Text;
                //certi.certi_noAplicaCondiSalud = txt_no2EvaMedRetiro.Text;
                //certi.certi_noAplicaCondiSalud = txt_noAplica2EvaMedRetiro.Text;

                //E.
                certi.certi_descripcionRecomendaciones = txt_descripRecomendaciones.Text;

                //F.
                certi.prof_id = Convert.ToInt32(ddl_profesional.SelectedValue);
                certi.certi_cod = txt_codigo.Text;

                CN_Certificado.ModificarCertificado(certi);

                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Modificados Exitosamente')", true);
                Response.Redirect("~/Template/Views/PacientesCertificado.aspx");
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Modificados')", true);
            }
        }


        private void Guardar_modificar_datos(int certifi)
        {
            if (certifi == 0)
            {
                GuardarCertificado();
            }
            else
            {
                certi = CN_Certificado.ObtenerCertificadoPorId(certifi);

                if (certi != null)
                {
                    ModificarHistorial(certi);
                }

            }
        }

        

        protected void btn_guardacertificado_Click(object sender, EventArgs e)
        {
            Guardar_modificar_datos(Convert.ToInt32(Request["cod"]));
        }

        protected void btn_cancelacertificado_Click(object sender, EventArgs e)
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