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
        DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        SqlConnection con = new SqlConnection(@"Data Source=ANDRES-SOSA;Initial Catalog=SistemaECU911;Integrated Security=True");

        //Objeto de la tabla personas
        private Tbl_Personas per = new Tbl_Personas();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_priNombre.Text) || string.IsNullOrEmpty(txt_priApellido.Text) ||
            string.IsNullOrEmpty(txt_sexo.Text) || string.IsNullOrEmpty(txt_edad.Text) || string.IsNullOrEmpty(txt_numHClinica.Text))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Complete los campos')", true);
            }
            else
            {
                try
                {
                    per = new Tbl_Personas();

                    per.Per_priNombre = txt_priNombre.Text;
                    per.Per_priApellido = txt_priApellido.Text;
                    per.Per_sexo = Convert.ToChar(txt_sexo.Text);
                    per.Per_edad = Convert.ToInt32(txt_edad.Text);
                    per.Per_CedulaHisCli = Convert.ToInt32(txt_numHClinica.Text);

                    CN_HistorialMedico.guardarPersona(per);

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Guardados Exitosamente')", true);

                    limpiar();

                }
                catch (Exception)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Guardados')", true);
                }
            }
        }

        private void limpiar()
        {
            txt_priNombre.Text = txt_priApellido.Text = txt_sexo.Text = txt_edad.Text = txt_numHClinica.Text = "";
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