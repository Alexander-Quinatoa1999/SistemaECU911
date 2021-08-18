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
        //Objeto de la tabla motivo de consulta
        //private Tbl_AntePersonales antper = new Tbl_AntePersonales();

        protected void Page_Load(object sender, EventArgs e)
        {
            txt_fecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txt_fecha2.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txt_hora.Text = DateTime.Now.ToString("HH:mm");
        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_priNombre.Text) || string.IsNullOrEmpty(txt_priApellido.Text) ||
                    string.IsNullOrEmpty(txt_sexo.Text) || string.IsNullOrEmpty(txt_edad.Text) || string.IsNullOrEmpty(txt_numHClinica.Text) || 
                    string.IsNullOrEmpty(txt_moConsulta.Text))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Complete los campos')", true);
                }
                else
                {
                    per = new Tbl_Personas();
                    motcons = new Tbl_MotivoConsulta();
                    //antper = new Tbl_AntePersonales();

                    //captura de datos tbl_personas
                    per.Per_priNombre = txt_priNombre.Text;
                    per.Per_priApellido = txt_priApellido.Text;
                    per.Per_sexo = txt_sexo.Text;
                    per.Per_edad = Convert.ToInt32(txt_edad.Text);
                    per.Per_CedulaHisCli = Convert.ToInt32(txt_numHClinica.Text);
                    //captura de datos tbl_motivoconsulta
                    motcons.Mcon_descripcion = txt_moConsulta.Text;

                    //Metodo de guardar personas
                    CN_HistorialMedico.guardarPersona(per);
                    //metodo de guardar motivo de consulta
                    CN_HistorialMedico.guardarMotiConsulta(motcons);
                    //metodo de guardar antecedentes personales
                    //CN_HistorialMedico.guardarAntecedentesPersonales(antper);

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
            txt_priNombre.Text = txt_priApellido.Text = txt_sexo.Text = txt_edad.Text = txt_numHClinica.Text = txt_moConsulta.Text = "";
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