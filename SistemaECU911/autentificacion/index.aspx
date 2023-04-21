<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="SistemaECU911.autentificacion.index" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <title>Login| Sistema Médico</title>
    <link rel="shortcut icon" href="../resources/assets/images/favicon.ico" />
    <link rel="stylesheet" href="../resources/assets/css/backend-plugin.min.css">
    <link rel="stylesheet" href="../resources/assets/css/backend.css?v=1.0.0">
    <link rel="stylesheet" href="../resources/assets/vendor/line-awesome/dist/line-awesome/css/line-awesome.min.css">
    <link rel="stylesheet" href="../resources/assets/vendor/remixicon/fonts/remixicon.css">
    <link rel="stylesheet" href="../resources/assets/vendor/tui-calendar/tui-calendar/dist/tui-calendar.css">
    <link rel="stylesheet" href="../resources/assets/vendor/tui-calendar/tui-date-picker/dist/tui-date-picker.css">
    <link rel="stylesheet" href="../resources/assets/vendor/tui-calendar/tui-time-picker/dist/tui-time-picker.css">
</head>
<body class=" ">

    <div id="loading">
        <div id="loading-center">
        </div>
    </div>

    <div class="wrapper">
        <section class="login-content">
            <div class="container">
                <div class="row align-items-center justify-content-center height-self-center">
                    <div class="col-lg-8">
                        <div class="card auth-card">
                            <div class="card-body p-0">
                                <div class="d-flex align-items-center auth-content">
                                    <div class="col-lg-6 bg-primary content-left">
                                        <div class="p-3">
                                            <h2 class="mb-2 text-white">Bienvenido al Sistema</h2>
                                            <p>Un gusto verte de nuevo</p>
                                            <form runat="server">
                                                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                                                <asp:Timer ID="Timer1" runat="server" Interval="2000" OnTick="Timer1_Tick"></asp:Timer>
                                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                                    <ContentTemplate>
                                                        <div class="row">
                                                            <div class="col-lg-12">
                                                                <div class="floating-label form-group">
                                                                    <asp:TextBox class="floating-input form-control" ID="txt_user" placeholder="Usuario" runat="server"></asp:TextBox>
                                                                </div>
                                                            </div>
                                                            <div class="col-lg-12">
                                                                <div class="floating-label form-group">
                                                                    <asp:TextBox class="floating-input form-control" ID="txt_pass" placeholder="Contraseña" runat="server"></asp:TextBox>
                                                                </div>
                                                            </div>
                                                            <div class="col">
                                                                <a href="recuperarcontra.aspx" class="text-white float-right">Olvidaste tu contraseña?</a>
                                                            </div>
                                                        </div>
                                                        <br />
                                                        <div class="text-center">
                                                            <asp:Button class="btn btn-white" ID="btn_ingresar" OnClick="btn_ingresar_Click" runat="server" Text="Iniciar Sesión" />
                                                        </div>
                                                    </ContentTemplate>
                                                </asp:UpdatePanel>
                                            </form>
                                        </div>
                                    </div>
                                    <div class="col-lg-6 content-right">
                                        <asp:Image CssClass="img-fluid image-right" ImageUrl="../resources/assets/auth/Login.png" ID="Image1" runat="server" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </div>

    <script src="../resources/assets/js/backend-bundle.min.js"></script>
    <script src="../resources/assets/js/table-treeview.js"></script>
    <script src="../resources/assets/js/customizer.js"></script>
    <script async src="../resources/assets/js/chart-custom.js"></script>
    <script async src="../resources/assets/js/slider.js"></script>
    <script src="../resources/assets/js/app.js"></script>
    <script src="../resources/assets/vendor/moment.min.js"></script>
</body>
</html>
