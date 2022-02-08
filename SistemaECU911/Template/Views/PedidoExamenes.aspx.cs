using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaECU911.Template.Views
{
    public partial class PedidoExamenes : System.Web.UI.Page
    {

        DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        //Objeto de la tabla personas
        private Tbl_Personas per = new Tbl_Personas();

        //Objeto de la tabla Pedido Examenes
        private Tbl_PedidoExamenes pedexa = new Tbl_PedidoExamenes();


        protected void Page_Load(object sender, EventArgs e)
        {

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

        private void guardar_modificar_datos(int perid, int pedexaid)
        {
            if (perid == 0 || pedexaid == 0)
            {
                GuardarPedidoExamenes();
            }
            else
            {
                //per = CN_HistorialMedico.obtenerPersonasxId(perid);
                //int perso = Convert.ToInt32(per.Per_id.ToString());

                //datgen = CN_Certificado.obtenerDatosGeneralesxPerCertificado(perso);
                //aptmed = CN_Certificado.obtenerAptiMedLaboralxPerCertificado(perso);
                //evamed = CN_Certificado.obtenerEvaMedRetiroxPerCertificado(perso);
                //reco = CN_Certificado.obtenerRecomendacionesxPerCertificado(perso);
                //datprof = CN_Certificado.obtenerDatosProfesionalxPerCertificado(perso);

                //if (per != null || datgen != null || aptmed != null || evamed != null ||
                //    reco != null || datprof != null)
                //{
                //    //ModificarHistorial(per, emplant, antper, acctrabajo, enferprof, facriesgotractual, actvextralaboral,
                //    //    exagenesperiespues, diagnostico, aptitudmedica);
                //}

            }
        }

        private void GuardarPedidoExamenes()
        {
            try
            {
                per = CN_HistorialMedico.obtenerIdPersonasxCedula(Convert.ToInt32(txt_numHClinica.Text));

                int perso = Convert.ToInt32(per.Per_id.ToString());

                // A.1
                pedexa = new Tbl_PedidoExamenes();

                if (ckb_bioHematica.Checked == true || ckb_hematocrito.Checked == true ||
                    ckb_hemoglobina.Checked == true || ckb_vsg.Checked == true)
                {
                    pedexa.PedExam_bioHematicaHema = "SI";
                    pedexa.PedExam_hematocritoHema = "SI";
                    pedexa.PedExam_hemoglobinaHema = "SI";
                    pedexa.PedExam_vsgHema = "SI";
                    pedexa.Per_id = perso;
                }
                else if(ckb_bioHematica.Checked == false || ckb_hematocrito.Checked == false ||
                    ckb_hemoglobina.Checked == false || ckb_vsg.Checked == false)
                {
                    CN_PedidoExamenes.guardarPedidoExamenesNO(pedexa);
                }

                ////B.Captura de datos Datos Generales
                //pedexa.PedExam_bioHematicaHema = Convert.ToString(ckb_bioHematica.Checked);
                //pedexa.PedExam_hematocritoHema = Convert.ToString(ckb_hematocrito.Checked);
                //pedexa.PedExam_hemoglobinaHema = Convert.ToString(ckb_hemoglobina.Checked);
                //pedexa.PedExam_vsgHema = Convert.ToString(ckb_vsg.Checked);

                //datgen.datGen_fechEmision = Convert.ToDateTime(txt_fechaEmision.Text);
                //datgen.datGen_ingreso = txt_ingreso.Text;
                //datgen.datGen_periodico = txt_periodico.Text;
                //datgen.datGen_reintegro = txt_reintegro.Text;
                //datgen.datGen_retiro = txt_retiro.Text;
                //datgen.Per_id = perso;


                ////B.Método para guardar Datos Datos Generales
                //CN_PedidoExamenes.guardarPedidoExamenes(pedexa);


                //Mensaje de confirmacion
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Guardados Exitosamente')", true);

                Response.Redirect("~/Template/Views/PacientesCertificado.aspx");
                limpiar();
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Guardados')", true);
            }
        }

        private void limpiar()
        {
            throw new NotImplementedException();
        }

        protected void btn_guarda_Click(object sender, EventArgs e)
        {
            guardar_modificar_datos(Convert.ToInt32(Request["cod"]), Convert.ToInt32(per.Per_id.ToString()));
        }

        protected void btn_modificar_Click(object sender, EventArgs e)
        {

        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/Views/Inicio.aspx");
        }
    }
}