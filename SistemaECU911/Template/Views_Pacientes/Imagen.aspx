<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Views_Pacientes/PrincipalPaciente.Master" AutoEventWireup="true" CodeBehind="Imagen.aspx.cs" Inherits="SistemaECU911.Template.Views_Pacientes.Imagen" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="container">
        <div class="row">
            <div class="col-md-4 col-md-offset-4">
                <h2>IMAGEN AGREGADA:</h2>
                <br />
                <asp:Image ID="img_preview" Width="200" Height="200" ImageUrl="~/Template/Template Principal/images/ecu911.jpg" runat="server" />
                <br />
                <br />
                <h2>ARCHIVO:</h2>
                <asp:FileUpload ID="fUploadImagen" accept=".jpg" runat="server" CssClass="form-control" />
                <br />
                <br />
                <h2>TITULO DE IMAGEN:</h2>
                <asp:TextBox ID="txt_titulo" runat="server" CssClass="form-control"></asp:TextBox>
                <br />
                <asp:Button ID="btn_subir" runat="server" Text="Subir" OnClick="btn_subir_Click" CssClass="btn btn-success" />
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
