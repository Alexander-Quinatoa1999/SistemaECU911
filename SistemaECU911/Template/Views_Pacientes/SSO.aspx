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
                        <h6>GESTIÓN DE TALENTO HUMANO</h6>
                        <h6>GESTIÓN DE BIENESTAR LABORAL Y SALUD OCUPACIONAL</h6>
                        <h6>FICHA SOCIOECONÓMICA</h6>
                    </div>
                </div>
                <br />

                <%--Código y Versión--%>

                <div class="list-group list-group-flush">
                    <asp:Table class="table table-bordered table-light" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="text-align: center; border: ridge; font-family: Arial">
                                <div class="card-header" style="background-color: #cccdfe; font-weight: bold; font-family: Arial">
                                    CÓDIGO
                                </div>
                            </asp:TableCell>
                            <asp:TableCell Style="text-align: center; border: ridge; font-family: Arial">
                                <div class="card-header" style="background-color: #cccdfe; font-weight: bold; font-family: Arial">
                                    VERSIÓN
                                </div>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: white; border: ridge; font-family: Arial">
                                <asp:TextBox runat="server" ID="txt_codigoinicio" BorderStyle="None" Style="width: 100%; text-align: center" placeholder="GTH_FOR_21"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; border: ridge; font-family: Arial">
                                <asp:TextBox runat="server" ID="txt_version" BorderStyle="None" Style="width: 100%; text-align: center" placeholder="1"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
                <br />

                <%--I. DATOS PERSONALES DEL SERVIDOR/A--%>
                <div class="card card-responsive" style="width: auto;">
                    <div class="card-header" style="background-color: #cccdfe; font-weight: bold; font-family: Arial">
                        I. DATOS PERSONALES DEL SERVIDOR/A
                    </div>
                    <div class="list-group list-group-flush" style="padding: 10px; text-align: center">
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial" ColumnSpan="4" RowSpan="2">NOMBRES Y APELLIDOS</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial" ColumnSpan="2">GENERO</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial" RowSpan="2">ESTADO CIVIL</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial" RowSpan="2">CÉDULA</asp:TableCell>                                
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">H</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">M</asp:TableCell>                              
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white; text-align: center">
                                    <asp:TextBox runat="server" ID="TextBox1" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center">
                                    <asp:TextBox runat="server" ID="TextBox3" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center">
                                    <asp:TextBox runat="server" ID="TextBox4" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center">
                                    <asp:TextBox runat="server" ID="TextBox5" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center">
                                    <asp:CheckBox ID="CheckBox1" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center">
                                    <asp:CheckBox ID="CheckBox2" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center">
                                    <asp:TextBox runat="server" ID="TextBox2" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center">
                                    <asp:TextBox runat="server" ID="txt_cedula" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                    <%--<ajaxToolkit:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" CompletionInterval="10" DelimiterCharacters="" Enabled="True"
                                        MinimumPrefixLength="1" ServiceMethod="ObtenerNumHClinica"
                                        TargetControlID="txt_cedula" CompletionListCssClass="CompletionList"
                                        CompletionListHighlightedItemCssClass="CompletionListHighlightedItem"
                                        CompletionListItemCssClass="CompletionListItem">
                                    </ajaxToolkit:AutoCompleteExtender>--%>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">AUTOIDENTIFICACIÓN ÉTNICA</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">LUGAR Y FECHA DE NACIMIENTO</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial" ColumnSpan="2">CONTACTOS DEL SERVIDOR/A</asp:TableCell>                               
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white; text-align: center" RowSpan="3">
                                    <asp:TextBox runat="server" ID="TextBox6" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center" RowSpan="3">
                                    <asp:TextBox runat="server" ID="TextBox7" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">CELULAR</asp:TableCell> 
                                <asp:TableCell Style="background-color: white; text-align: center">
                                    <asp:TextBox runat="server" ID="TextBox8" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">TELÉFONO</asp:TableCell> 
                                <asp:TableCell Style="background-color: white; text-align: center">
                                    <asp:TextBox runat="server" ID="TextBox11" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">MAIL</asp:TableCell> 
                                <asp:TableCell Style="background-color: white; text-align: center">
                                    <asp:TextBox runat="server" ID="TextBox14" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial"  ColumnSpan="2">INSTRUCCIÓN FORMAL</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">DEPARTAMENTO /ÁREA</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">CARGO INSTITUCIONAL </asp:TableCell>                               
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">PROFESIÓN</asp:TableCell> 
                                <asp:TableCell Style="background-color: white; text-align: center">
                                    <asp:TextBox runat="server" ID="TextBox22" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center" RowSpan="3">
                                    <asp:TextBox runat="server" ID="TextBox25" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center" RowSpan="3">
                                    <asp:TextBox runat="server" ID="TextBox17" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">OCASIÓN</asp:TableCell> 
                                <asp:TableCell Style="background-color: white; text-align: center">
                                    <asp:TextBox runat="server" ID="TextBox23" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />

                <%--II. DATOS DE SALUD DEL SERVIDOR/A--%>
                <div class="card card-responsive" style="width: auto;">
                    <div class="card-header" style="background-color: #cccdfe; font-weight: bold; font-family: Arial">
                        II. DATOS DE SALUD DEL SERVIDOR/A
                    </div>
                    <div class="list-group list-group-flush" style="padding: 10px; text-align: center">
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">TIPO DE SANGRE</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">ENFERMEDAD DE IMPORTANCIA O CATASTRÓFICA</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">CIRUGIAS QUE HAYA PADECIDO</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial" ColumnSpan="9">DATOS DE DISCAPACIDAD </asp:TableCell>                                
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white; text-align: center">
                                    <asp:TextBox runat="server" ID="TextBox21" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center" RowSpan="2">
                                    <asp:TextBox runat="server" ID="TextBox24" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center" RowSpan="2">
                                    <asp:TextBox runat="server" ID="TextBox26" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">SI</asp:TableCell> 
                                <asp:TableCell Style="background-color: white; text-align: center">
                                    <asp:CheckBox ID="CheckBox5" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">TIPO</asp:TableCell> 
                                <asp:TableCell Style="background-color: white; text-align: center">
                                    <asp:TextBox runat="server" ID="TextBox27" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">OBSERVACION</asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center" ColumnSpan="4">
                                    <asp:TextBox runat="server" ID="TextBox28" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">¿DONANTE?</asp:TableCell> 
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">NO</asp:TableCell> 
                                <asp:TableCell Style="background-color: white; text-align: center">
                                    <asp:CheckBox ID="CheckBox3" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">%</asp:TableCell> 
                                <asp:TableCell Style="background-color: white; text-align: center">
                                    <asp:TextBox runat="server" ID="TextBox41" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">SUSTITUTO</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">SI</asp:TableCell> 
                                <asp:TableCell Style="background-color: white; text-align: center">
                                    <asp:CheckBox ID="CheckBox6" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">NO</asp:TableCell> 
                                <asp:TableCell Style="background-color: white; text-align: center">
                                    <asp:CheckBox ID="CheckBox4" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width:300px">EN CASO DE EMERGENCIA CON QUIEN PUEDO COMUNICARME</asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center">
                                    <asp:TextBox runat="server" ID="TextBox29" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">PARENTESCO</asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center; width:150px">
                                    <asp:TextBox runat="server" ID="TextBox39" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial" ColumnSpan="2">TELÉFONO</asp:TableCell> 
                                <asp:TableCell Style="background-color: white; text-align: center; width:150px">
                                    <asp:TextBox runat="server" ID="TextBox40" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width:150px">OBSERVACIONES</asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center">
                                    <asp:TextBox runat="server" ID="TextBox30" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />

                <%--III. COMPOSICIÓN FAMILIAR DEL SERVIDOR/A--%>
                <div class="card card-responsive" style="width: auto;">
                    <div class="card-header" style="background-color: #cccdfe; font-weight: bold; font-family: Arial">
                        III. COMPOSICIÓN FAMILIAR DEL SERVIDOR/A
                    </div>
                    <div class="list-group list-group-flush" style="padding: 10px; text-align: center">
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Nº</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">NOMBRE Y APELLIDO</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">PARENTESCO</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">SEXO</asp:TableCell>  
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">FECHA N</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">ESTADO CIVIL</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">INSTRUCCION</asp:TableCell> 
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">OCUPACIÓN </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">DISCAPACIDAD</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white; text-align: center; width:40px">
                                    <asp:TableCell>1</asp:TableCell>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center">
                                    <asp:TextBox runat="server" ID="TextBox32" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center; width:100px">
                                    <asp:TextBox runat="server" ID="TextBox33" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center; width:100px">
                                    <asp:TextBox runat="server" ID="TextBox34" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center; width:100px">
                                    <asp:TextBox runat="server" ID="TextBox35" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center; width:100px">
                                    <asp:TextBox runat="server" ID="TextBox36" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center; width:100px">
                                    <asp:TextBox runat="server" ID="TextBox44" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center; width:100px">
                                    <asp:TextBox runat="server" ID="TextBox45" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center; width:100px">
                                    <asp:TextBox runat="server" ID="TextBox46" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow> 
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white; text-align: center; width:40px">
                                    <asp:TableCell>2</asp:TableCell>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center">
                                    <asp:TextBox runat="server" ID="TextBox31" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center; width:100px">
                                    <asp:TextBox runat="server" ID="TextBox37" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center; width:100px">
                                    <asp:TextBox runat="server" ID="TextBox38" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center; width:100px">
                                    <asp:TextBox runat="server" ID="TextBox42" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center; width:100px">
                                    <asp:TextBox runat="server" ID="TextBox43" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center; width:100px">
                                    <asp:TextBox runat="server" ID="TextBox47" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center; width:100px">
                                    <asp:TextBox runat="server" ID="TextBox48" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center; width:100px">
                                    <asp:TextBox runat="server" ID="TextBox49" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow> 
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white; text-align: center; width:40px">
                                    <asp:TableCell>3</asp:TableCell>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center">
                                    <asp:TextBox runat="server" ID="TextBox50" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center; width:100px">
                                    <asp:TextBox runat="server" ID="TextBox51" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center; width:100px">
                                    <asp:TextBox runat="server" ID="TextBox52" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center; width:100px">
                                    <asp:TextBox runat="server" ID="TextBox53" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center; width:100px">
                                    <asp:TextBox runat="server" ID="TextBox54" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center; width:100px">
                                    <asp:TextBox runat="server" ID="TextBox55" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center; width:100px">
                                    <asp:TextBox runat="server" ID="TextBox56" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center; width:100px">
                                    <asp:TextBox runat="server" ID="TextBox57" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow> 
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width:150px">OBSERVACIONES</asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: center">
                                    <asp:TextBox runat="server" ID="TextBox58" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />

                <div class="card-header" style="background-color: #cccdfe; font-weight: bold; font-family: Arial">
                        IV.     SITUACIÓN SOCIOFAMILIAR SERVIDOR/A
                    </div>

                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light" runat="server">
                            <asp:TableRow>
                                <asp:TableCell RowSpan="4" Style="width: 65px; font-size: 15px">
                                    <asp:Label Text="FAMILIAR" runat="server"></asp:Label> 
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="3" Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="¿COMO ES SU RELACIÓN INTRAFAMILIAR?" runat="server"></asp:Label> 
                                </asp:TableCell>
                                <asp:TableCell></asp:TableCell>
                                <asp:TableCell Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="MUY BUENA" runat="server"></asp:Label> 
                                </asp:TableCell>
                                <asp:TableCell></asp:TableCell>
                                <asp:TableCell Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="BUENA" runat="server"></asp:Label>                                    
                                </asp:TableCell>
                                <asp:TableCell></asp:TableCell>
                                <asp:TableCell Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="REGULAR" runat="server"></asp:Label>                                    
                                </asp:TableCell>
                                <asp:TableCell></asp:TableCell>
                                <asp:TableCell ColumnSpan="2" Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="MALA" runat="server"></asp:Label>                                    
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="3" Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="¿COMO ES LA RELACIÓN CON SU PAREJA?" runat="server"></asp:Label> 
                                </asp:TableCell>
                                <asp:TableCell></asp:TableCell>
                                <asp:TableCell Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="MUY BUENA" runat="server"></asp:Label> 
                                </asp:TableCell>
                                <asp:TableCell></asp:TableCell>
                                <asp:TableCell Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="BUENA" runat="server"></asp:Label>                                    
                                </asp:TableCell>
                                <asp:TableCell></asp:TableCell>
                                <asp:TableCell Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="REGULAR" runat="server"></asp:Label>                                    
                                </asp:TableCell>
                                <asp:TableCell></asp:TableCell>
                                <asp:TableCell ColumnSpan="2" Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="MALA" runat="server"></asp:Label>                                    
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:Label Text="¿POR QUÉ?" runat="server"></asp:Label>  
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="11">
                                    <asp:TextBox runat="server" ID="TextBox61" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="TIPO  DE FAMILIA" runat="server"></asp:Label> 
                                </asp:TableCell>
                                <asp:TableCell></asp:TableCell>
                                <asp:TableCell Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="FAMILIA" runat="server"></asp:Label> 
                                </asp:TableCell>
                                <asp:TableCell></asp:TableCell>
                                <asp:TableCell Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="NUCLEAR" runat="server"></asp:Label>                                    
                                </asp:TableCell>
                                <asp:TableCell></asp:TableCell>
                                <asp:TableCell Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="INCOMPLETO" runat="server"></asp:Label>                                    
                                </asp:TableCell>
                                <asp:TableCell></asp:TableCell>
                                <asp:TableCell Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="REORGANIZADO" runat="server"></asp:Label>                                    
                                </asp:TableCell>
                                <asp:TableCell></asp:TableCell>
                                <asp:TableCell Style="text-align: center; border: groove; font-family: Arial">
                                    <asp:Label Text="CIRCUSTANCIAL" runat="server"></asp:Label>                                    
                                </asp:TableCell>
                                <asp:TableCell></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">OBSERVACIONES</asp:TableCell>
                                <asp:TableCell ColumnSpan="11">
                                    <asp:TextBox runat="server" ID="TextBox71" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>

                        </asp:Table>
                    </div>

                    <div class="card-header" style="background-color: #cccdfe; font-weight: bold; font-family: Arial">
                        V.     SITUACIÓN ECONÓMICA DEL SERVIDOR/A
                    </div>

                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light" runat="server">
                            <asp:TableRow>
                                <asp:TableCell RowSpan="11">
                                    <asp:Label Text="INGRESOS Y EGRESOS" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label Text="NÚMERO DE MIEMBROS ECONOMICACAMENTE ACTIVOS:" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox62" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="4">
                                    <asp:Label Text="SITUACIÓN LABORAL DEL CONYUGUE:" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox63" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">
                                    <asp:Label Text="TOTAL INGRESOS MENSUALES PROYECTADOS" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label Text="AYUDA PADRES/FAMILIARES" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label Text="OTROS INGRESOS" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="2">
                                    <asp:Label Text="TOTAL EGRESOS MENSUALES PROYECTADOS" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox66" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="TextBox69" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox72" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox73" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label Text="Alimentación " runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox75" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="9">
                                    <asp:TextBox runat="server" ID="TextBox121" BorderStyle="None" Style="width: 100%;" BackColor="white" Placeholder="$"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="TextBox76" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox77" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox78" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label Text="Vivienda " runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox80" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="TextBox81" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox82" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox83" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label Text="Educación " runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox85" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="TextBox86" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox87" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox88" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label Text="Servicios Básicos" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox90" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="TextBox91" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox92" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox93" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label Text="Salud " runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox95" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="TextBox96" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox97" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox98" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label Text="Movilización " runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox100" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="TextBox101" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox102" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox103" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label Text="Deudas " runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox105" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="TextBox106" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox107" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox108" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label Text="Otros (Pensiones, Varios)" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox110" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="TextBox111" BorderStyle="None" Style="width: 100%;" BackColor="white" Placeholder="$"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="TextBox112" BorderStyle="None" Style="width: 100%;" BackColor="white" Placeholder="$"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label Text="Total  " runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox115" BorderStyle="None" Style="width: 100%;" BackColor="white" Placeholder="$"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>

                            <asp:TableRow>
                                <asp:TableCell RowSpan="7">
                                    <asp:Label Text="DESCRIPCION DE BIENES MUEBLE E INMUEBLES" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label Text="BIEN" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label Text="VALOR" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="5">
                                    <asp:Label Text="DETALLE" runat="server"></asp:Label>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:Label Text="CASA" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox64" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label Text="DIRECCIÓN" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="4">
                                    <asp:TextBox runat="server" ID="TextBox65" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:Label Text="DEPARATAMENTO" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox67" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label Text="DIRECCIÓN" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="4">
                                    <asp:TextBox runat="server" ID="TextBox68" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:Label Text="VEHICULO/CARRO" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox74" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label Text="DETALLE" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="4">
                                    <asp:TextBox runat="server" ID="TextBox79" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:Label Text="TERRENO" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox84" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label Text="SECTOR" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="4">
                                    <asp:TextBox runat="server" ID="TextBox89" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:Label Text="NEGOCIO" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox94" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label Text="DETALLE" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="4">
                                    <asp:TextBox runat="server" ID="TextBox99" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:Label Text="MUEBLES Y ENSERES" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox104" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label Text="DETALLE" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="4">
                                    <asp:TextBox runat="server" ID="TextBox109" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>

                            <asp:TableRow>
                                <asp:TableCell RowSpan="5">
                                    <asp:Label Text="CARACTERISTICAS DE LA VIVIENDA" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label Text="DESCRIPCION" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label Text="UNIFAMILIAR" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="5">
                                    <asp:TextBox runat="server" ID="TextBox113" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="7">
                                    <asp:Label Text="MULTIFAMILIAR" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="TextBox114" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label Text="OTRO ESPECIFIQUE" runat="server"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="5">
                                    <asp:TextBox runat="server" ID="TextBox116" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>






                <%--Información para uso de bienestar familiar--%>
                <div class="card card-responsive" style="width: auto;">
                    <div class="card-header" style="background-color: #cccdfe; font-weight: bold; font-family: Arial">
                        VI. POSIBLES PROBLEMAS EN LA FAMILIA O EN UNO DE SUS MIEMBROS
                    </div>
                    <div class="list-group list-group-flush" style="padding: 10px; text-align: center">
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">DESINTEGRACIÓN FAMILIAR</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="TextBox122" BorderStyle="None" Style="width: 100%" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">HACINAMIENTO</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="TextBox123" BorderStyle="None" Style="width: 100%" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">ENFERMEDADES</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="TextBox124" BorderStyle="None" Style="width: 100%" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">VIOLENCIA INTRA FAMILIAR</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="TextBox120" BorderStyle="None" Style="width: 100%" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">DIVORCIO</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="TextBox125" BorderStyle="None" Style="width: 100%" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">OTRO ESPECIFIQUE</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="TextBox126" BorderStyle="None" Style="width: 100%" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">DESEMPLEO</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="TextBox127" BorderStyle="None" Style="width: 100%" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">DISCAPACIDAD</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3">
                                    <asp:TextBox runat="server" ID="TextBox128" BorderStyle="None" Style="width: 100%" BackColor="white" placeholder="Especifique el %"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">ADICCIONES</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="TextBox129" BorderStyle="None" Style="width: 100%" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">RECONSTRUCIÓN FAMILIAR </asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3">
                                    <asp:TextBox runat="server" ID="TextBox130" BorderStyle="None" Style="width: 100%" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <asp:Table class="table table-bordered text-left" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Observaciones y Recomendaciones</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_informacionadicional" BorderStyle="None" Style="width: 100%;" BackColor="white" TextMode="MultiLine" Rows="4"></asp:TextBox>
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
