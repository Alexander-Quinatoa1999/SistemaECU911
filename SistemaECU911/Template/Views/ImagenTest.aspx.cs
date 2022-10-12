using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;
using HtmlAgilityPack;
using iTextSharp.text;
using iTextSharp.text.pdf;
using SistemaECU911.Template.Views_Pacientes;

namespace SistemaECU911.Template.Views
{
    public partial class ImagenTest : System.Web.UI.Page
    {

        private readonly DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        private readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        private Tbl_Image img = new Tbl_Image();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        private void GuardarImagen()
        {
            try
            {
                img = new Tbl_Image();

                con.Open();

                int tamanioimagen = int.Parse(fuImagen.FileContent.Length.ToString());
                byte[] imagen = fuImagen.FileBytes;

                using (SqlCommand cmd = new SqlCommand("RegistrarImagen", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Cedula", SqlDbType.VarChar).Value = txt_cedula.Text;
                    cmd.Parameters.Add("@Imagen", SqlDbType.Image).Value = imagen;
                    cmd.ExecuteNonQuery();

                }
                con.Close();

                //img.img_cedula = txt_cedula.Text.ToUpper();             
                //img.img_foto = imagen;

                //CN_Personas.GuardarImagen(img);

                //Mensaje de confirmacion
                ScriptManager.RegisterStartupScript(this, this.GetType(), "mensaje", "swal('Exito!', 'Datos Guardados Exitosamente', 'success')", true);
                Response.Redirect("~/Template/Views/Inicio.aspx");

            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "mensaje", "swal('Error!', 'Datos No Guardados', 'error')", true);
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarImagen();
        }
    }
}