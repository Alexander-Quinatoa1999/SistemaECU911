<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Views_Pacientes/PrincipalPaciente.Master" AutoEventWireup="true" CodeBehind="SSO.aspx.cs" Inherits="SistemaECU911.Template.Views_Pacientes.SSO" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://cdn.jsdelivr.net/npm/select2@4.1.0-rc.0/dist/css/select2.min.css" rel="stylesheet" />

    <style type="text/css">
        .CompletionList {
            padding: 5px 0;
            margin: 2px 0 0;
            height: 100px;
            overflow: auto;
            position: absolute;
            border: 1px solid #ccc;
            border: 1px solid rgba(0, 0, 0, 0.2);
            *border-right-width: 2px;
            *border-bottom-width: 2px;
            -webkit-border-radius: 6px;
            -moz-border-radius: 6px;
            border-radius: 6px;
            -webkit-box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
            -moz-box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
            box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
            -webkit-background-clip: padding-box;
            -moz-background-clip: padding;
            background-clip: padding-box;
            background-color: White;
            cursor: pointer;
        }

        .CompletionListItem {
            display: block;
            padding: 3px 20px;
            clear: both;
            font-weight: normal;
            line-height: 20px;
            color: #333333;
            white-space: nowrap;
        }


        .CompletionListHighlightedItem {
            color: #ffffff;
            padding: 3px 20px;
            text-decoration: none;
            background-color: #0081c2;
            background-repeat: repeat-x;
            outline: 0;
            background-image: linear-gradient(to bottom, #0088cc, #0077b3);
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="container" style="background-color: white">
                <br />

                <%--Título--%>

                <div class="container">
                    <div class="text-center" style="font-size: 15px; font-family: Arial">
                        <h6>DIRECCIÓN DE ADMINISTRACIÓN DE RECURSOS HUMANOS</h6>
                        <h6>GESTIÓN DE BIENESTAR LABORAL Y SALUD OCUPACIONAL</h6>
                        <h6>FICHA SOCIOECONÓMICA</h6>
                    </div>
                </div>
                <br />

                <div class="list-group list-group-flush">
                    <asp:Table class="table table-bordered table-light" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="text-align: center; border: groove; font-family: Arial">
                                <asp:Label Text="CÓDIGO" runat="server"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="text-align: center; border: groove; font-family: Arial">
                                <asp:Label Text="VERSIÓN" runat="server"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="text-align: center; border: groove; font-family: Arial">
                                <asp:TextBox runat="server" ID="TextBox3" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="text-align: center; border: groove; font-family: Arial">
                                <asp:TextBox runat="server" ID="TextBox4" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>

                <br />

                <div class="card card-responsive" style="width: auto;">
                    <div class="card-header" style="background-color: #cccdfe; font-weight: bold; font-family: Arial">
                        I. DATOS PERSONALES DEL SERVIDOR/A
                    </div>

                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="NOMBRES Y APELLIDOS" runat="server"></asp:Label> 
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="2" Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="GENERO" runat="server"></asp:Label> 
                                </asp:TableCell>
                                <asp:TableCell Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="ESTADO CIVIL" runat="server"></asp:Label> 
                                </asp:TableCell>
                                <asp:TableCell Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="CÉDULA" runat="server"></asp:Label>                                    
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell RowSpan="2">
                                    <asp:TextBox runat="server" ID="TextBox1" BorderStyle="None" Style="width: 100%;" ReadOnly="true" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="H" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="M" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2">
                                    <asp:TextBox runat="server" ID="TextBox2" BorderStyle="None" Style="width: 100%;" ReadOnly="true" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2">
                                    <asp:TextBox runat="server" ID="TextBox5" BorderStyle="None" Style="width: 100%;" ReadOnly="true" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox6" BorderStyle="None" Style="width: 100%;" ReadOnly="true" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox7" BorderStyle="None" Style="width: 100%;" ReadOnly="true" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>

                            <asp:TableRow>
                                <asp:TableCell Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="AUTOIDENTIFICACIÓN ETNICA" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="2" Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="LUGAR Y FECHA DE NACIMIENTO" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="2" Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="CONTACTOS DEL SERVIDOR/A" runat="server"></asp:Label>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell RowSpan="4"></asp:TableCell>
                                <asp:TableCell RowSpan="4" ColumnSpan="2"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:Label Text="CELULAR" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:Label Text="TELF" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:Label Text="MAIL" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell></asp:TableCell>
                            </asp:TableRow>

                            <asp:TableRow>
                                <asp:TableCell Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="INSTRUCCIÓN FORMAL" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="2" Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="DEPARTAMENTO /ÁREA" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="2" Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="CARGO INSTITUCIONAL" runat="server"></asp:Label>
                                </asp:TableCell>
                            </asp:TableRow>

                            <asp:TableRow>
                                <asp:TableCell Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:TextBox runat="server" ID="TextBox15" BorderStyle="None" Style="width: 100%;" ReadOnly="true" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="2" Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:TextBox runat="server" ID="TextBox14" BorderStyle="None" Style="width: 100%;" ReadOnly="true" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="2" Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:TextBox runat="server" ID="TextBox13" BorderStyle="None" Style="width: 100%;" ReadOnly="true" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>

                        </asp:Table>
                    </div>

                    <div class="card-header" style="background-color: #cccdfe; font-weight: bold; font-family: Arial">
                         II.      DATOS DE SALUD DEL SERVIDOR/A
                    </div>

                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="TIPO DE SANGRE" runat="server"></asp:Label> 
                                </asp:TableCell>
                                <asp:TableCell Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="ENFERMEDAD DE IMPORTANCIA O CATASTRÓFICA" runat="server"></asp:Label> 
                                </asp:TableCell>
                                <asp:TableCell Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="CIRUGIAS QUE HAYA PADECIDO" runat="server"></asp:Label> 
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="9" Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="DATOS DE DISCAPACIDAD" runat="server"></asp:Label>                                    
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox8" BorderStyle="None" Style="width: 100%;" ReadOnly="true" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2" Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:TextBox runat="server" ID="TextBox9" BorderStyle="None" Style="width: 100%;" ReadOnly="true" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2" Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:TextBox runat="server" ID="TextBox16" BorderStyle="None" Style="width: 100%;" ReadOnly="true" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label Text="SI" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox10" BorderStyle="None" Style="width: 100%;" ReadOnly="true" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label Text="TIPO" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell></asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label Text="OBSERVACIÓN:" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="4"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox11" BorderStyle="None" Style="width: 100%;" ReadOnly="true" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label Text="NO" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox18" BorderStyle="None" Style="width: 100%;" ReadOnly="true" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox19" BorderStyle="None" Style="width: 100%;" ReadOnly="true" BackColor="white" placeholder="%"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox20" BorderStyle="None" Style="width: 100%;" ReadOnly="true" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label Text="SUSTITUTO:" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label Text="SI" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell></asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label Text="NO" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell></asp:TableCell>
                            </asp:TableRow>

                            <asp:TableRow>
                                <asp:TableCell Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="OBSERVACIONES:" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="11" Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:TextBox runat="server" ID="TextBox12" BorderStyle="None" Style="width: 75px;" ReadOnly="true" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>

                        </asp:Table>
                    </div>                   

                </div>
                <br />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
