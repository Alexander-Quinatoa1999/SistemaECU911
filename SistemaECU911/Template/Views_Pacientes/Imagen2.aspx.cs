using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaECU911.Template.Views_Pacientes
{
    public partial class Imagen2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_subir_Click(object sender, EventArgs e)
        {
            int Tamanio = fUploadImagen.PostedFile.ContentLength;
            byte[] ImageOriginal = new byte[Tamanio];

            fUploadImagen.PostedFile.InputStream.Read(ImageOriginal, 0, Tamanio);

            Bitmap ImagenOriginalBinaria = new Bitmap(fUploadImagen.PostedFile.InputStream);

            string ImagenDataURL64 = "data:image/jpg;base64," + Convert.ToBase64String(ImageOriginal);

            img_preview.ImageUrl = ImagenDataURL64;
        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/Views_Pacientes/Inicio.aspx");
        }
        
    }
}