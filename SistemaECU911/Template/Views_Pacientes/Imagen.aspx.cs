using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaECU911.Template.Views_Pacientes
{
    public partial class Imagen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_subir_Click(object sender, EventArgs e)
        {
            int Tamaño = fUploadImagen.PostedFile.ContentLength;
            byte[] ImageOriginal = new byte[Tamaño];

            fUploadImagen.PostedFile.InputStream.Read(ImageOriginal, 0, Tamaño);

            Bitmap ImagenOriginalBinaria = new Bitmap(fUploadImagen.PostedFile.InputStream);

            String ImagenDataURL64 = "data:image/jpg;base64," + Convert.ToBase64String(ImageOriginal);

            img_preview.ImageUrl = ImagenDataURL64;
        }
    }
}