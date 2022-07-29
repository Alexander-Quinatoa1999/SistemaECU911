<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Imagen2.aspx.cs" Inherits="SistemaECU911.Template.Views_Pacientes.Imagen2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-4 col-md-offset-4">
                    <h3>IMAGEN AGREGADA:</h3>
                    <br />
                    <asp:Image ID="img_preview" Width="200" Height="200" ImageUrl="~/Template/Template Principal/images/ecu911.jpg" runat="server" />
                    <br />
                    <br />
                    <h3>ARCHIVO:</h3>
                    <asp:FileUpload ID="fUploadImagen" accept=".jpg" runat="server" CssClass="form-control"  />
                    <br />
                    <br />
                    <h3>TITULO DE IMAGEN:</h3>
                    <asp:TextBox ID="txt_titulo" runat="server" CssClass="form-control"></asp:TextBox>
                    <br />
                    <asp:Button ID="btn_subir" runat="server" Text="Subir" OnClick="btn_subir_Click" CssClass="btn btn-success" />
                    <asp:Button ID="btn_cancelar" runat="server" Text="Cancelar" OnClick="btn_cancelar_Click" CssClass="btn btn-success" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
