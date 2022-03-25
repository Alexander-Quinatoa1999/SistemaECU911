<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Views/Principal.Master" AutoEventWireup="true" CodeBehind="Certificado_Reporte.aspx.cs" Inherits="SistemaECU911.Template.Views.Certificado_Reporte" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="min-height-200px" style="background-color: white">
                <div class="invoice-wrap">
                    <div class="invoice-box">
                        <div class="invoice-header">
                            <div class="row pb-30">
                                <div class="col-md-12">
                                    <br />
                                    <br />
                                    <div class="logo text-left" style="margin-left: 200px; margin-right: 200px">
                                        <img src="../Template Principal/images/ImagenEncabezado.png" alt="">
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <br />
                                    <br />
                                    <br />
                                    <div class="text-right" style="margin-right: 315px;">
                                        <p class="font-14 mb-5">
                                            Quito, 
                                        <asp:Label ID="lblFecha" runat="server"></asp:Label>
                                        </p>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <br />
                        <br />
                        <h5 class="text-center mb-30 weight-600">CERTIFICADO MÉDICO</h5>
                        <br />
                        <div class="row pb-30" style="margin-left: 300px; margin-right: 300px">
                            <div class="col-md-12" style="font-family: Arial; font-size: 12px">
                                <p class="font-14 mb-5 mb-15" style="text-align: justify; font-family: Arial;">
                                    Por medio de la presente certifico haber atendido al señor
                                <asp:Label ID="Label16" runat="server" Text="Victor Daniel Añazco Salazar" Font-Bold="true"></asp:Label>
                                    con número de cédula
                                <asp:Label ID="Label17" runat="server" Text="172084771-2" Font-Bold="true"></asp:Label>, fue atendido en el dispensario médico 
                                    institucional por presentar edema en parpado de ojo izquierdo, presencia de secreción purulenta, el antes mencionado se desempeña como 
                                <asp:Label ID="Label18" runat="server" Text="Evaluador de Operaciones Zonal" Font-Bold="true"></asp:Label>
                                    en el 
                                <asp:Label ID="Label19" runat="server" Text="Servicio Integrado de Seguridad ECU 911." Font-Bold="true"></asp:Label>
                                </p>
                            </div>
                            <div class="col-md-12">
                                <p class="font-14 mb-5" style="text-align: justify; font-family: Arial">
                                    Tipo de contingencia: 
                                    <asp:Label ID="Label1" runat="server" Text="Enfermedad General." Font-Bold="true"></asp:Label>
                                </p>
                                <p class="font-14 mb-5" style="text-align: justify; font-family: Arial;">
                                    Diagnóstico: 
                                    <asp:Label ID="Label2" runat="server"
                                        Text="Orzuelo y otras inflamaciones profundas del parpado CIE10: H000" Font-Bold="true">
                                    </asp:Label>
                                </p>
                                <p class="font-14 mb-5" style="text-align: justify; font-family: Arial;">
                                    Por lo expuesto requiere:
                                    <br />
                                    <br />
                                    <asp:Label ID="Label3" runat="server"
                                        Text="•	Frío Local <br /> •	Analgésico, Antibiótico <br /> •	Reposo por 1 (uno) día desde el 
                                        Lunes 31 (treinta y uno) de enero de 2022 hasta el Lunes 31 (treinta y uno) de enero de 2022."
                                        Font-Bold="true">
                                    </asp:Label>
                                </p>
                                <p class="font-14 mb-5" style="text-align: justify; font-family: Arial;">Es todo cuanto puedo certificar en honor a la verdad.</p>
                                <p class="font-14 mb-5 text-center" style="text-align: justify; font-family: Arial;">Atentamente,</p>
                                <br />
                                <br />
                                <p class="font-14 mb-5 text-center" style="text-align: justify; font-family: Arial;">
                                    <asp:Label ID="Label4" runat="server" Text="Dra. Francy Helena Cobos Figueroa" Font-Bold="true"></asp:Label>
                                    <br />
                                    <asp:Label ID="Label5" runat="server" Text="Médico General" Font-Bold="true"></asp:Label>
                                    <br />
                                    <asp:Label ID="Label6" runat="server" Text="1711131415" Font-Bold="true"></asp:Label>
                                    <br />
                                    <asp:Label ID="Label7" runat="server" style="color:blue; text-decoration:underline" Text="cobitos2002.fc@gmail.com" Font-Bold="true"></asp:Label>
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
                <br />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
