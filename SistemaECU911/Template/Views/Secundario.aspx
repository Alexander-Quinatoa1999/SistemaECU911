<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Secundario.aspx.cs" Inherits="SistemaECU911.Template.Views.Secundario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Formulario</h1>
            <br />
            <asp:Label ID="lbl_nombre" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="btn_cerrarsesion" runat="server" Text="Cerrar Sesion" OnClick="btn_cerrarsesion_Click" />

        </div>
    </form>
</body>
</html>
