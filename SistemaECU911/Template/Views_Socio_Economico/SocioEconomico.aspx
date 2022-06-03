<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Views_Socio_Economico/PrincipalSSO.Master" AutoEventWireup="true" CodeBehind="SocioEconomico.aspx.cs" Inherits="SistemaECU911.Template.Views_Socio_Economico.SocioEconomico" %>

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

                <div class="card" style="background-color: #cccdfe">
                    <div class="card-body">
                        <div class="text-center" style="font-display: auto; font-family: Arial; font-size: 30px; background-color: #cccdfe">
                            <h6>GESTIÓN DEL TALENTO HUMANO</h6>
                            <h6>GESTIÓN DE BIENESTAR LABORAL Y SALUD OCUPACIONAL</h6>
                            <h6>FICHA SOCIOECONÓMICA</h6>
                        </div>
                    </div>
                </div>
                <br />

                <%--Código y Versión--%>

                <div class="list-group list-group-flush">
                    <asp:Table class="table table-bordered table-light" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="text-align: center; border: medium; font-family: Arial">
                                <div class="card-header" style="background-color: #cccdfe; font-weight: bold; font-family: Arial">
                                    CÓDIGO
                                </div>
                            </asp:TableCell>
                            <asp:TableCell Style="text-align: center; border: medium; font-family: Arial">
                                <div class="card-header" style="background-color: #cccdfe; font-weight: bold; font-family: Arial">
                                    VERSIÓN
                                </div>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: white; border: medium; font-family: Arial">
                                <asp:TextBox runat="server" ID="txt_codigoinicio" BorderStyle="None" Style="width: 100%; text-align: center" placeholder="GTH_FOR_21"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; border: medium; font-family: Arial">
                                <asp:TextBox runat="server" ID="txt_version" BorderStyle="None" Style="width: 100%; text-align: center" placeholder="1"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>

                <%--Fecha de Registro--%>

                <div class="list-group list-group-flush">
                    <asp:Table class="table table-bordered table-light" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="text-align: right; background: #cdfecc; border: medium; font-family: Arial">Fecha de Registro:</asp:TableCell>
                            <asp:TableCell Style="width: 100px; border: medium">
                                <asp:TextBox runat="server" ID="txt_fecharegistro" BorderStyle="None" Style="width: 100%;" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>

                <%--I. DATOS PERSONALES DEL SERVIDOR/A--%>

                <div class="card card-responsive" style="width: auto;">
                    <div class="card-header" style="background-color: #cccdfe; font-weight: bold; font-family: Arial">
                        I. DATOS PERSONALES DEL SERVIDOR/A
                    </div>
                    <div class="list-group list-group-flush" style="padding: 10px; text-align: center">
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Nombres y Apellidos:</asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_prinombre" BorderStyle="None" Style="width: 75px;" ReadOnly="true" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_segnombre" BorderStyle="None" Style="width: 75px;" ReadOnly="true" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_priapellido" BorderStyle="None" Style="width: 75px;" ReadOnly="true" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_segapellido" BorderStyle="None" Style="width: 75px;" ReadOnly="true" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Cédula Ciudadanía:</asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_cedula" OnTextChanged="txt_cedula_TextChanged" BorderStyle="None" Style="width: 100%; background-color: transparent" AutoPostBack="true"></asp:TextBox>
                                    <ajaxToolkit:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" CompletionInterval="10" DelimiterCharacters="" Enabled="True"
                                        MinimumPrefixLength="1" ServiceMethod="ObtenerNumHClinica"
                                        TargetControlID="txt_cedula" CompletionListCssClass="CompletionList"
                                        CompletionListHighlightedItemCssClass="CompletionListHighlightedItem"
                                        CompletionListItemCssClass="CompletionListItem">
                                    </ajaxToolkit:AutoCompleteExtender>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 300px">Departamento o Área en la que trabaja:</asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_areatrabajo" BorderStyle="None" BackColor="white" Style="width: 100%"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 300px">Cargo Institucional:</asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_cargoinstitucional" BorderStyle="None" BackColor="white" Style="width: 100%"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 200px">Modalidad de Vinculación:</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 300px">Ley Orgánica del Sector Público (LOSEP)</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_modalidadvinculacionlosep" OnCheckedChanged="cb_modalidadvinculacionlosep_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 200px">Código de Trabajo</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_modalidadvinculacioncodigotrabajo" OnCheckedChanged="cb_modalidadvinculacioncodigotrabajo_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 300px">Fecha de ingreso al Sistema Ecu 911:</asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_fechaingresoalsisecu" BorderStyle="None" BackColor="white" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 100px">Estado Civil:</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial;">Soltero</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_soltero" OnCheckedChanged="cb_soltero_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial;">Casado</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_casado" OnCheckedChanged="cb_casado_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial;">Viudo</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_viudo" OnCheckedChanged="cb_viudo_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial;">Unión Libre</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_unionlibre" OnCheckedChanged="cb_unionlibre_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial;">Divorciado</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_divorciado" OnCheckedChanged="cb_divorciado_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 100px">Género:</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 100px">Masculino</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_genmasculino" OnCheckedChanged="cb_genmasculino_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 100px">Femenino</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_genfemenino" OnCheckedChanged="cb_genfemenino_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 150px">Tipo de Sangre:</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 100px">
                                    <asp:TextBox runat="server" ID="txt_tipodesangre" BorderStyle="None" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 150px">¿Es donante?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_donantesi" OnCheckedChanged="cb_donantesi_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_donanteno" OnCheckedChanged="cb_donanteno_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Teléfono Convencional:</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_telconvecional" BorderStyle="None" BackColor="white" Style="width: 100%"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Teléfono Celular:</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_telcelular" BorderStyle="None" BackColor="white" Style="width: 100%"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Email:</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 100px; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_email" BorderStyle="None" BackColor="white" Style="width: 100%"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Lugar de Nacimiento:</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 100px; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_lugarnacimiento" BorderStyle="None" BackColor="white" Style="width: 100%"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Fecha de Nacimiento:</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_fechanacimiento" BorderStyle="None" BackColor="white" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Edad:</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 100px; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_edad" BorderStyle="None" BackColor="white" Style="width: 100%"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 150px">Nivel de Educación:</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Primaria</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_primaria" OnCheckedChanged="cb_primaria_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 100px">Secundaria</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_secundaria" OnCheckedChanged="cb_secundaria_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 100px">Superior</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_superior" OnCheckedChanged="cb_superior_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 100px">Especialización</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_especializacion" OnCheckedChanged="cb_especializacion_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 100px">Diplomado</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_diplomado" OnCheckedChanged="cb_diplomado_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Maestría</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_maestria" OnCheckedChanged="cb_maestria_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 200px">Autoidentificación Étnica:</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial;">Blanco</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_blanco" OnCheckedChanged="cb_blanco_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial;">Mestizo</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_mestizo" OnCheckedChanged="cb_mestizo_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial;">Afrodescendiente</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_afro" OnCheckedChanged="cb_afro_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial;">Indígena</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_indigena" OnCheckedChanged="cb_indigena_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial;">Montubio</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_montubio" OnCheckedChanged="cb_montubio_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 150px">Dirección del domicilio:</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Provincia</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 100px; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_provincia" BorderStyle="None" BackColor="white" Style="width: 100%"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Cantón</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 100px; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_canton" BorderStyle="None" BackColor="white" Style="width: 100%"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Parroquia</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 100px; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_parroquia" BorderStyle="None" BackColor="white" Style="width: 100%"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Barrio</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 100px; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_barrio" BorderStyle="None" BackColor="white" Style="width: 100%"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 75px">Calle donde está ubicada la vivienda y numeración:</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 100px; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_calleubicada" BorderStyle="None" BackColor="white" Style="width: 100%"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Calle secundaria:</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 100px; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_callesecundaria" BorderStyle="None" BackColor="white" Style="width: 100%"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Referencia para ubicar el domicilio:</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 100px; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_refubicardomicilio" BorderStyle="None" BackColor="white" Style="width: 100%"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 75px">Sector donde vive:</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Norte</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_norte" OnCheckedChanged="cb_norte_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Centro</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_centro" OnCheckedChanged="cb_centro_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Sur</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_sur" OnCheckedChanged="cb_sur_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Valle</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_valle" OnCheckedChanged="cb_valle_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Valle de los Chillos</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_valledeloschillos" OnCheckedChanged="cb_valledeloschillos_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 90px">Tipo de vivienda en la que reside:</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 25px">Casa</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_casa" OnCheckedChanged="cb_casa_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Departamento</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_departamento" OnCheckedChanged="cb_departamento_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell ID="tbc_otro" Style="background-color: #cdfecc; color: black; font-family: Arial; width: 25px">Otro</asp:TableCell>
                                <asp:TableCell ID="tbc_otravivienda" Style="background-color: white; width: 100px; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_tipoviviendaotro" BorderStyle="None" BackColor="white" Style="width: 100%" Placeholder="Indique cuál"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 70px">Riesgo Delincuencial:</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 25px">Alto</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_riesgoalto" OnCheckedChanged="cb_riesgoalto_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 25px">Medio</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_riesgomedio" OnCheckedChanged="cb_riesgomedio_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 25px">Bajo</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_riesgobajo" OnCheckedChanged="cb_riesgobajo_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 250px">Persona para contacto de emergencia:</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 150px">Nombres y Apellidos</asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left; width: 300px">
                                    <asp:TextBox runat="server" ID="txt_emernomyape" BorderStyle="None" BackColor="white" Style="width: 100%"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Parentesco</asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_emeparentesco" BorderStyle="None" BackColor="white" Style="width: 100%"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Teléfono</asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_emetelefono" BorderStyle="None" BackColor="white" Style="width: 100%"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px" RowSpan="2">Dirección del familiar:</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Calle Principal</asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left; width: 100px">
                                    <asp:TextBox runat="server" ID="txt_emecalleprincipal" BorderStyle="None" BackColor="white" Style="width: 100%"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Nº del domicilio</asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_emenumdomicilio" BorderStyle="None" BackColor="white" Style="width: 100%"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Calle secundaria</asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left; width: 100px">
                                    <asp:TextBox runat="server" ID="txt_emecallesecun" BorderStyle="None" BackColor="white" Style="width: 100%"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Referencia para ubicar el domicilio</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 100px; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_emerefubicardomicilio" BorderStyle="None" BackColor="white" Style="width: 100%"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 350px">¿Destina algún dinero para el ahorro?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_dineroahorrosi" OnCheckedChanged="cb_dineroahorrosi_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_dineroahorrono" OnCheckedChanged="cb_dineroahorrono_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 130px">¿Vehículo propio?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_vehiculosi" OnCheckedChanged="cb_vehiculosi_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_vehiculono" OnCheckedChanged="cb_vehiculono_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 200px">¿Usa recorrido institucional?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 20px">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_recorridosi" OnCheckedChanged="cb_recorridosi_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 20px">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_recorridono" OnCheckedChanged="cb_recorridono_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 300px">¿Cómo se moviliza hacia el trabajo o vivienda?</asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_movilizatrabajoovivienda" BorderStyle="None" BackColor="white" Style="width: 100%"></asp:TextBox>
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
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 300px">¿Posee alguna enfermedad pre-existente?</asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_poseeenfermedadprexistente" BorderStyle="None" Style="width: 100%; background-color: transparent" placeholder="Indique la enfermedad que padece"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 200px">¿Posee alguna discapacidad?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_discapacidadsi" OnCheckedChanged="cb_discapacidadsi_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_discapacidadno" OnCheckedChanged="cb_discapacidadno_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell ID="tbc_tipodiscapacidad" Style="background-color: #cdfecc; color: black; font-family: Arial; width: 200px">Tipo de discapacidad</asp:TableCell>
                                <asp:TableCell ID="tbc_txtdiscapacidad" Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_tipodiscapacidad" BorderStyle="None" Style="width: 100%;" BackColor="white" Placeholder="Detalle la o las discapacidades en caso de poseer"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table ID="tabladatosdiscapacidad" class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 250px">¿Cuál es su porcentaje discapacidad?</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 60px">
                                    <asp:TextBox runat="server" ID="txt_porcentajediscapacidad" BorderStyle="None" Style="width: 100%;" BackColor="white" Placeholder="%"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 300px">Nº de Carnet otorgado por el MSP o CONADIS</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_numcarnetconadis" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 200px">Fecha de caducidad</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_fechacaducidadcarnet" BorderStyle="None" Style="width: 100%;" BackColor="white" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 500px">¿Se encuentra en estado de gestación?  (Adjuntar certificado médico)    </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_gestaciónsi" OnCheckedChanged="cb_gestaciónsi_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_gestaciónno" OnCheckedChanged="cb_gestaciónno_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table ID="tbl_estadogestacion" class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 200px">Tiempo de gestación</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_gestacióntiempo" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 250px">Fecha tentativa de parto</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_fechatentativaparto" BorderStyle="None" Style="width: 100%;" BackColor="white" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 400px">¿Se encuentra usted en periodo de lactancia de ser el caso?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_lactaciasi" OnCheckedChanged="cb_lactaciasi_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_lactaciano" OnCheckedChanged="cb_lactaciano_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell ID="txt_fechaculminacion" Style="background-color: #cdfecc; color: black; font-family: Arial; width: 200px">Fecha de culminación</asp:TableCell>
                                <asp:TableCell ID="fechacumlimnacion" Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_fechaculmicacionlactancia" BorderStyle="None" Style="width: 100%;" BackColor="white" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 500px">¿Posee alguna enfermedad crónica y/o catastrófica? (adjuntar certificado médico)</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_catastroficasi" OnCheckedChanged="cb_catastroficasi_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_catastroficano" OnCheckedChanged="cb_catastroficano_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">¿Cuál?</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_cualcatastrofica" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 100px">Otras enfermedades</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="6">
                                    <asp:TextBox runat="server" ID="txt_otrasenfermedadescat" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 550px">¿Posee alguna enfermedad rara o húerfana según el Ente Rector que lo determina? (adjuntar certificado médico)</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_enfermedadrarasi" OnCheckedChanged="cb_enfermedadrarasi_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_enfermedadrarano" OnCheckedChanged="cb_enfermedadrarano_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">¿Cuál?</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_enfermedadraracual" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 200px">¿Consume alcohol?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_alcoholsi" OnCheckedChanged="cb_alcoholsi_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_alcoholno" OnCheckedChanged="cb_alcoholno_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell ID="tbc_causa" Style="background-color: #cdfecc; color: black; font-family: Arial; width: 170px">Causa:</asp:TableCell>
                                <asp:TableCell ID="txt_causa" Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_causaconsumoalcohol" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table ID="tablafrecuenciaalcohol" class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 170px">Frecuencia de consumo:</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Diario</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_consumoalcoholdiario" OnCheckedChanged="cb_consumoalcoholdiario_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Semanal</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_consumoalcoholsemanal" OnCheckedChanged="cb_consumoalcoholsemanal_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Quincenal</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_consumoalcoholquincenal" OnCheckedChanged="cb_consumoalcoholquincenal_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Mensual</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_consumoalcoholmensual" OnCheckedChanged="cb_consumoalcoholmensual_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">En reuniones</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_consumoalcoholreuniones" OnCheckedChanged="cb_consumoalcoholreuniones_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 230px">¿Hace cuanto tiempo consume?</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_tiempoconsumoalcohol" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 200px">¿Consume tabaco?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_tabacosi" OnCheckedChanged="cb_tabacosi_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_tabacono" OnCheckedChanged="cb_tabacono_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell ID="tbc_frecuenciatabaco" Style="background-color: #cdfecc; color: black; font-family: Arial; width: 100px">Frecuencia:</asp:TableCell>
                                <asp:TableCell ID="txt_frecuenciatabaco" Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_frecuenciaconsumotabaco" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ID="tbc_tiempotabaco" Style="background-color: #cdfecc; color: black; font-family: Arial; width: 230px">¿Hace cuanto tiempo consume?</asp:TableCell>
                                <asp:TableCell ID="txt_tiempotabaco" Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_tiempoconsumotabaco" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 300px">¿Consume usted alguna sustancia psicotrópica?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_sustanciapsicotropicasi" OnCheckedChanged="cb_sustanciapsicotropicasi_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_sustanciapsicotropicano" OnCheckedChanged="cb_sustanciapsicotropicano_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 125px">Tipo de sustancia:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_sustanciapsicotropicatipo" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 160px">Frecuencia de consumo:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_sustanciapsicotropicafrecuencia" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 200px">Problemas relacionados con el consumo</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Familiares</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_familiares" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Laborales</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_laborales" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Económicos</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_economicos" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Salud</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_salud" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Legales</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_legales" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />

                <%--III. SITUACIÓN ECONÓMICA DEL SERVIDOR/A--%>

                <div class="card card-responsive" style="width: auto;">
                    <div class="card-header" style="background-color: #cccdfe; font-weight: bold; font-family: Arial">
                        III. SITUACIÓN ECONÓMICA DEL SERVIDOR/A
                    </div>
                    <div class="list-group list-group-flush" style="padding: 10px; text-align: center">
                        <div class="row">
                            <div class="col-sm-9">
                                <asp:Table class="table table-bordered table-light" runat="server">
                                    <asp:TableRow>
                                        <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 550px" ColumnSpan="2">NÚMERO DE MIEMBROS ECONOMICAMENTE ACTIVOS:</asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_miembroactivoseconomicamente" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                        <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial" ColumnSpan="3">SITUACIÓN LABORAL DEL CONYUGUE</asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial" ColumnSpan="2">TOTAL INGRESOS MENSUALES PROYECTADOS</asp:TableCell>
                                        <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">AYUDA</asp:TableCell>
                                        <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">OTROS</asp:TableCell>
                                        <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial" ColumnSpan="3">TOTAL EGRESOS</asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell Style="background-color: white; text-align: center" ColumnSpan="2">
                                            <asp:TextBox runat="server" ID="txt_totalingresos1" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_ayuda1" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_otros1" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                        <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Alimentación</asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_alimentación" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell Style="background-color: white; text-align: center" ColumnSpan="2">
                                            <asp:TextBox runat="server" ID="txt_totalingresos2" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_ayuda2" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_otros2" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                        <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Vivienda</asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_vivienda" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell Style="background-color: white; text-align: center" ColumnSpan="2">
                                            <asp:TextBox runat="server" ID="txt_totalingresos3" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_ayuda3" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_otros3" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                        <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Educación</asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_educación" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell Style="background-color: white; text-align: center" ColumnSpan="2">
                                            <asp:TextBox runat="server" ID="txt_totalingresos4" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_ayuda4" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_otros4" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                        <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Servicios Básicos</asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_serviciosbasicos" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell Style="background-color: white; text-align: center" ColumnSpan="2">
                                            <asp:TextBox runat="server" ID="txt_totalingresos5" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_ayuda5" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_otros5" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                        <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Salud</asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_salud" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell Style="background-color: white; text-align: center" ColumnSpan="2">
                                            <asp:TextBox runat="server" ID="txt_totalingresos6" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_ayuda6" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_otros6" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                        <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Movilización</asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_movilización" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell Style="background-color: white; text-align: center" ColumnSpan="2">
                                            <asp:TextBox runat="server" ID="txt_totalingresos7" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_ayuda7" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_otros7" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                        <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Deudas</asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_deudas" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell Style="background-color: white; text-align: center" ColumnSpan="2">
                                            <asp:TextBox runat="server" ID="txt_totalingresos8" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_ayuda8" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_otros8" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                        <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Otros (Pensiones, Varios)</asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_otrospensiones" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell Style="background-color: white; text-align: center" ColumnSpan="2">
                                            <asp:TextBox runat="server" ID="txt_totalingresos9" BorderStyle="None" Style="width: 100%; background-color: transparent" placeholder="Total: $"></asp:TextBox>
                                        </asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center" ColumnSpan="2">
                                            <asp:TextBox runat="server" ID="txt_totalayudayotros9" BorderStyle="None" Style="width: 100%; background-color: transparent" placeholder="Total: $"></asp:TextBox>
                                        </asp:TableCell>
                                        <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Total</asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_totalegresos" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                </asp:Table>
                            </div>
                            <div class="col-sm-3">
                                <asp:Table class="table table-bordered table-light" runat="server">
                                    <asp:TableRow>
                                        <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial" ColumnSpan="2">DESCRIPCIÓN DE LOS BIENES</asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">BIEN</asp:TableCell>
                                        <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">VALOR</asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Casa</asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_biencasa" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Departamento</asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_biendepartamento" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Vehiculo</asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_bienvehiculo" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Terreno</asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_bienterreno" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Negocio</asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_bienegocio" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Muebles y Enseres</asp:TableCell>
                                        <asp:TableCell Style="background-color: white; text-align: center">
                                            <asp:TextBox runat="server" ID="txt_bienmueblesyenseres" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                </asp:Table>
                            </div>
                        </div>
                        <br />
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; text-align: left">CARACTERÍSTICAS DE LA VIVIENDA</asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Descripción</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Unifamiliar</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_unifamiliar" OnCheckedChanged="cb_unifamiliar_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Multifamiliar</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_multifamiliar" OnCheckedChanged="cb_multifamiliar_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Otro especifique</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_otrodescripcionviviendafamilia" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial" RowSpan="2">Tenencia</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Propia sin deuda</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_propiasindeuda" OnCheckedChanged="cb_propiasindeuda_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Arrendada</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_arrendada" OnCheckedChanged="cb_arrendada_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">De familia</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_defamilia" OnCheckedChanged="cb_defamilia_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial" RowSpan="2">Otro especifique</asp:TableCell>
                                <asp:TableCell Style="background-color: white" RowSpan="2">
                                    <asp:TextBox runat="server" ID="txt_otratenencia" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Hipotecada</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_hipotecada" OnCheckedChanged="cb_hipotecada_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Prestada</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_prestada" OnCheckedChanged="cb_prestada_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Antricreces</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_anticreces" OnCheckedChanged="cb_anticreces_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Tipo</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Casa</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_tipocasa" OnCheckedChanged="cb_tipocasa_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Suit</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_tiposuit" OnCheckedChanged="cb_tiposuit_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Mediagua</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_tipomediagua" OnCheckedChanged="cb_tipomediagua_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Departamento</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_tipodepartamento" OnCheckedChanged="cb_tipodepartamento_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Pieza</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_tipopieza" OnCheckedChanged="cb_tipopieza_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Otro especifique</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_otrotipodecasa" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial" RowSpan="2">Distrubución</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Habitación</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_habitacion" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Sala</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_sala" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Baño</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_baño" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Garage</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_garage" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial" RowSpan="2">Otro especifique</asp:TableCell>
                                <asp:TableCell Style="background-color: white" RowSpan="2">
                                    <asp:TextBox runat="server" ID="txt_otradistribucioncasa" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Comedor</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_comedor" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Cocina</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_cocina" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Patio</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_patio" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Bodega</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_bodega" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Otro especifique</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_otrainformacioncasa" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />

                <%--IV. INFORMACIÓN GENERAL DEL SERVIDOR/A--%>

                <div class="card card-responsive" style="width: auto;">
                    <div class="card-header" style="background-color: #cccdfe; font-weight: bold; font-family: Arial">
                        IV. INFORMACIÓN GENERAL DEL SERVIDOR/A
                    </div>
                    <div class="list-group list-group-flush" style="padding: 10px; text-align: center">
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">COMPOSICIÓN FAMILIAR DEL SERVIDOR/A, TRABAJADOR/A QUE VIVAN CON USTED EN FORMA PERMANENTE</asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Apellidos y Nombres</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 200px">Parentesco</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 150px">Fecha de Nacimiento</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 150px">Edad</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_nomapellidos1" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_parentesco1" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_fechanacimiento1" BorderStyle="None" Style="width: 100%; text-align: center" BackColor="white" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_edad1" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_nomapellidos2" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_parentesco2" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_fechanacimiento2" BorderStyle="None" Style="width: 100%; text-align: center" BackColor="white" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_edad2" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_nomapellidos3" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_parentesco3" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_fechanacimiento3" BorderStyle="None" Style="width: 100%; text-align: center" BackColor="white" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_edad3" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_nomapellidos4" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_parentesco4" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_fechanacimiento4" BorderStyle="None" Style="width: 100%; text-align: center" BackColor="white" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_edad4" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_nomapellidos5" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_parentesco5" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_fechanacimiento5" BorderStyle="None" Style="width: 100%; text-align: center" BackColor="white" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_edad5" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 175px">¿Tiene en su núcleo familiar alguna persona con discapacidad?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_nucleodiscapacidadsi" OnCheckedChanged="cb_nucleodiscapacidadsi_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_nucleodiscapacidadno" OnCheckedChanged="cb_nucleodiscapacidadno_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 200px">Si su respuesta es si, continúe a la siguiente pregunta</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 175px">¿Se encuentra usted a cargo de esta persona con discapacidad? Calificada por el MSP o CONADIS</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_acargofamiliardiacapacitadosi" OnCheckedChanged="cb_acargofamiliardiacapacitadosi_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_acargofamiliardiacapacitadono" OnCheckedChanged="cb_acargofamiliardiacapacitadono_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 200px">Si su respuesta es si, sírvase en llenar el cuadro a continuación</asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table ID="tabladiscapacidad" class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial" ColumnSpan="6">Señale los nombres y apellidos del familiar con discapacidad a su cargo (Que posea carnét de discapacidad)</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Apellidos y Nombres</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 150px">Fecha de caducidad del carnét</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 150px">Tipo de discapacidad</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 100px">Porcentaje</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 100px">Parentesco</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 150px">Fecha de Nacimiento</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_familiardiscapacitadonomape1" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_familiardiscapacitadofechacaducidadcarnet1" BorderStyle="None" Style="width: 100%; text-align: center" BackColor="white" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_familiardiscapacitadotipodiscapacidad1" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_familiardiscapacitadoporcentajediscapacidad1" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_familiardiscapacitadoparentesco1" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_familiardiscapacitadofechanacimiento1" BorderStyle="None" Style="width: 100%; text-align: center" BackColor="white" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_familiardiscapacitadonomape2" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_familiardiscapacitadofechacaducidadcarnet2" BorderStyle="None" Style="width: 100%; text-align: center" BackColor="white" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_familiardiscapacitadotipodiscapacidad2" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_familiardiscapacitadoporcentajediscapacidad2" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_familiardiscapacitadoparentesco2" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; color: black; font-family: Arial">
                                    <asp:TextBox runat="server" ID="txt_familiardiscapacitadofechanacimiento2" BorderStyle="None" Style="width: 100%; text-align: center" BackColor="white" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table ID="tabladependencia" class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 550px">¿Se encuentra registrada la dependencia del familiar en el Ministerio de Trabajo?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_dependenciaministeriotrabajosi" OnCheckedChanged="cb_dependenciaministeriotrabajosi_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_dependenciaministeriotrabajono" OnCheckedChanged="cb_dependenciaministeriotrabajono_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Tiempo</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_dependenciaministeriotrabajotiempo" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Nº Carnét MSP</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_numcarnetMSP" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table ID="tablaacargofamiliar" class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 550px">¿Se encuentra usted a cargo de esta persona con enfermedad catastrófica o rara? Registrada en el MSP</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_acargofamiliarenfermedadrarasi" OnCheckedChanged="cb_acargofamiliarenfermedadrarasi_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_acargofamiliarenfermedadrarano" OnCheckedChanged="cb_acargofamiliarenfermedadrarano_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Tiempo</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_acargofamiliarenfermedadraratiempo" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Tipo de enfermedad</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_familiarenfermedadraratipo" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />

                <%--V. ACTIVIDADES QUE  REALIZA EN TIEMPO LIBRE EL SERVIDOR/A--%>

                <div class="card card-responsive" style="width: auto;">
                    <div class="card-header" style="background-color: #cccdfe; font-weight: bold; font-family: Arial">
                        V. ACTIVIDADES QUE REALIZA EN TIEMPO LIBRE EL SERVIDOR/A
                    </div>
                    <div class="list-group list-group-flush" style="padding: 10px; text-align: center">
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Hogar</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_hogar" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Paseos familiares</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_paseosfamiliares" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Estudios</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_estudios" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Actividades artísticas</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_actividadesartisticas" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Otros</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_otraactividad" BorderStyle="None" Style="width: 100%; background-color: transparent" placeholder="Indique cual"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 300px">¿Realiza alguna actividad económica adicional?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_actividadeconomicasi" OnCheckedChanged="cb_actividadeconomicasi_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_actividadeconomicano" OnCheckedChanged="cb_actividadeconomicano_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 300px">Detalle la actividad económica que realiza</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_actividadeconomicadetalle" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table ID="tabla_actividadeconomica" class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 250px">Tiempo que destina a la actividad</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_actividadeconomicatiempodestina" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 300px">¿Hace cuánto tiempo realiza la actividad?</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_actividadeconomicatiemporealiza" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">¿Realiza alguna actividad deportiva?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_deportesi" OnCheckedChanged="cb_deportesi_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_deporteno" OnCheckedChanged="cb_deporteno_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Si su respuesta es sí, especifique la actividad que realiza</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_especifiquedeporte" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Frecuencia</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_frecuenciadeporte" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">¿Desde qué edad practica ese deporte?</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_edadpracticadeporte" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">¿Ha sufrido alguna lesión?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_lesionsi" OnCheckedChanged="cb_lesionsi_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_lesionno" OnCheckedChanged="cb_lesionno_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Tipo de lesión</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_tipolesion" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Edad a la que sufrió la lesión</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_edadlesion" BorderStyle="None" Style="width: 100%; background-color: transparent" placeholder="en años"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">¿Recibió algún tratamiento o rehabilitación?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_tratamientosi" OnCheckedChanged="cb_tratamientosi_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_tratamientono" OnCheckedChanged="cb_tratamientono_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />

                <%--VI. INFORMACIÓN UNICAMENTE PARA USO DE BIENESTAR LABORAL DEL SERVIDOR/A--%>

                <div class="card card-responsive" style="width: auto;">
                    <div class="card-header" style="background-color: #cccdfe; font-weight: bold; font-family: Arial">
                        VI. INFORMACIÓN UNICAMENTE PARA USO DE BIENESTAR LABORAL DEL SERVIDOR/A
                    </div>
                    <div class="list-group list-group-flush" style="padding: 10px; text-align: center">
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Tipo de familia:</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Nuclear</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_nuclear" OnCheckedChanged="cb_nuclear_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Ampliada</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_ampliada" OnCheckedChanged="cb_ampliada_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Monoparental</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_monoparental" OnCheckedChanged="cb_monoparental_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Vive solo</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_vivesolo" OnCheckedChanged="cb_vivesolo_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Vive con amigos</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_viveconamigos" OnCheckedChanged="cb_viveconamigos_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Familia sin hijos</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_familiasinhijos" OnCheckedChanged="cb_familiasinhijos_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Evaluación del nivel de relación familiar:</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Muy bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_relacionfamiliarmuybuena" OnCheckedChanged="cb_relacionfamiliarmuybuena_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_relacionfamiliarbuena" OnCheckedChanged="cb_relacionfamiliarbuena_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Regular</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_relacionfamiliarregular" OnCheckedChanged="cb_relacionfamiliarregular_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Malo</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_relacionfamiliarmala" OnCheckedChanged="cb_relacionfamiliarmala_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">¿Por qué?</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_relacionfamiliarporque" BorderStyle="None" Style="width: 100%; background-color: transparent" placeholder="Especifique"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Evaluación del nivel de relación de pareja:</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Muy bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_relacionparejamuybuena" OnCheckedChanged="cb_relacionparejamuybuena_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_relacionparejabuena" OnCheckedChanged="cb_relacionparejabuena_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Regular</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_relacionparejaregular" OnCheckedChanged="cb_relacionparejaregular_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Malo</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_relacionparejamala" OnCheckedChanged="cb_relacionparejamala_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">¿Por qué?</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_relacionparejaporque" BorderStyle="None" Style="width: 100%; background-color: transparent" placeholder="Especifique"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Evaluación del nivel de relación con los hijos:</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Muy bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_relacionconhijosmuybuena" OnCheckedChanged="cb_relacionconhijosmuybuena_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_relacionconhijosbuena" OnCheckedChanged="cb_relacionconhijosbuena_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Regular</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_relacionconhijosregular" OnCheckedChanged="cb_relacionconhijosregular_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Malo</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_relacionconhijosmala" OnCheckedChanged="cb_relacionconhijosmala_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">¿Por qué?</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_relacionconhijosporque" BorderStyle="None" Style="width: 100%; background-color: transparent" placeholder="Especifique"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Problemas familiares:</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Económicos</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_economico" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Comunicación</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_comunicacion" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Conyugales</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_conyugales" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Crianza de hijos</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_crianzadehijos" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Adicciones</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_adicciones" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Violencia:</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Física</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_fisica" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Psicológica</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_psicologica" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Verbal</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_verbal" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Sexual</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_sexual" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Observaciones</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_observacionesfamiliares" BorderStyle="None" Style="width: 100%;" BackColor="white" TextMode="MultiLine" Rows="2"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 300px">¿Cada miembro de la familia cumple su Rol?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_rolfamiliarsi" OnCheckedChanged="cb_rolfamiliarsi_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_rolfamiliarno" OnCheckedChanged="cb_rolfamiliarno_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Nivel de salud de la familia:</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Muy bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_nivelsaludfamiliarmuybuena" OnCheckedChanged="cb_nivelsaludfamiliarmuybuena_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_nivelsaludfamiliarbuena" OnCheckedChanged="cb_nivelsaludfamiliarbuena_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Regular</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_nivelsaludfamiliarregular" OnCheckedChanged="cb_nivelsaludfamiliarregular_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Malo</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_nivelsaludfamiliarmala" OnCheckedChanged="cb_nivelsaludfamiliarmala_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">¿Por qué?</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_nivelsaludfamiliarporque" BorderStyle="None" Style="width: 100%; background-color: transparent" placeholder="Especifique"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 200px">Por lo tanto: ¿La familia es?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 100px">Funcional</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_funcional" OnCheckedChanged="cb_funcional_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 100px">Disfuncional</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_disfuncional" OnCheckedChanged="cb_disfuncional_CheckedChanged" AutoPostBack="true" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Observaciones</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_observacionesgenerales" BorderStyle="None" Style="width: 100%;" BackColor="white" TextMode="MultiLine" Rows="2"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Alguna información adicional que la institución deba conocer : (Médica, Familiar , Legal , etc )</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_informacionadicional" BorderStyle="None" Style="width: 100%;" BackColor="white" TextMode="MultiLine" Rows="2"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">
                                    <i>La información es solicitada con el fin de actualizar nuestros registros Socio Económicos y 
                                        Bienestar Laboral de los servidores SIS ECU 911.</i> </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">
                                    <strong> 
                                        <i> Certifico que la información aquí suministrada es veraz, real, completa y podrá ser verificada 
                                        en el momento que el ECU crea necesario.
                                        </i> 
                                    </strong> 
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <div align="center">
                            <div style="width: 200px">
                                <asp:Table class="table table-bordered table-light text-center" runat="server">
                                    <asp:TableRow>
                                        <asp:TableCell Style="background-color: #cdfecc; color: black">SI</asp:TableCell>
                                        <asp:TableCell Style="background-color: white">
                                            <asp:CheckBox ID="cb_certificosi" OnCheckedChanged="cb_certificosi_CheckedChanged" AutoPostBack="true" runat="server" />
                                        </asp:TableCell>
                                        <asp:TableCell Style="background-color: #cdfecc; color: black">NO</asp:TableCell>
                                        <asp:TableCell Style="background-color: white">
                                            <asp:CheckBox ID="cb_certificono" OnCheckedChanged="cb_certificono_CheckedChanged" AutoPostBack="true" runat="server" />
                                        </asp:TableCell>
                                    </asp:TableRow>
                                </asp:Table>
                            </div>
                        </div>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial"> <strong>MUCHAS GRACIAS POR SU COLABORACIÓN</strong> </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial"> <strong>Firma del Servidor/a, Trabajador/a</strong> </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_firmadelservidor" BorderStyle="None" Style="width: 100%;" BackColor="white" TextMode="MultiLine" Rows="3" ReadOnly="true"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <div class="container" align="center">
                            <asp:Button CssClass="btn btn-success" ID="btn_guardar" OnClick="btn_guardar_Click" runat="server" Text="Guardar" UseSubmitBehavior="False" />
                            <asp:Button CssClass="btn btn-danger" ID="btn_cancelar" OnClick="btn_cancelar_Click" runat="server" Text="Cancelar" UseSubmitBehavior="False" />
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
