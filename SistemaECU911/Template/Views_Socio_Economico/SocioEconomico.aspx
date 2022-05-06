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

                <div class="container">
                    <div class="text-center" style="font-size: 15px; font-family: Arial">
                        <h6>DIRECCIÓN DE ADMINISTRACIÓN DE RECURSOS HUMANOS</h6>
                        <h6>GESTIÓN DE BIENESTAR LABORAL Y SALUD OCUPACIONAL</h6>
                        <h6>FICHA SOCIOECONÓMICA</h6>
                    </div>
                </div>
                <br />

                <%--Fecha de Registro--%>

                <div class="list-group list-group-flush">
                    <asp:Table class="table table-bordered table-light" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="text-align: right; background: #cdfecc; border: groove; font-family: Arial">Fecha de Registro:</asp:TableCell>
                            <asp:TableCell Style="width: 100px; border: groove">
                                <asp:TextBox runat="server" ID="txt_fecha" BorderStyle="None" Style="width: 100%;" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>

                <%--Datos Generales--%>

                <div class="card card-responsive" style="width: auto;">
                    <div class="card-header" style="background-color: #cccdfe; font-weight: bold; font-family: Arial">
                        DATOS GENERALES
                    </div>
                    <div class="list-group list-group-flush" style="padding: 10px; text-align: center">
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Cédula:</asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_cedula" OnTextChanged="txt_cedula_TextChanged" BorderStyle="None" Style="width: 100%; background-color: transparent" AutoPostBack="true"></asp:TextBox>
                                    <ajaxToolkit:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" CompletionInterval="10" DelimiterCharacters="" Enabled="True"
                                        MinimumPrefixLength="1" ServiceMethod="ObtenerNumHClinica"
                                        TargetControlID="txt_cedula" CompletionListCssClass="CompletionList"
                                        CompletionListHighlightedItemCssClass="CompletionListHighlightedItem"
                                        CompletionListItemCssClass="CompletionListItem">
                                    </ajaxToolkit:AutoCompleteExtender>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Apellidos y Nombres:</asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_priapellido" BorderStyle="None" Style="width: 75px;" ReadOnly="true" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_segapellido" BorderStyle="None" Style="width: 75px;" ReadOnly="true" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_prinombre" BorderStyle="None" Style="width: 75px;" ReadOnly="true" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_segnombre" BorderStyle="None" Style="width: 75px;" ReadOnly="true" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 300px">Departamento / Área en la que trabaja:</asp:TableCell>
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
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 200px">Modalidad de Contrato:</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 300px">Ley Orgánica del Sector Público (LOSEP)</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_modalidadlosep" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 200px">Código de Trabajo</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_modalidadcodigotrabajo" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
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
                                    <asp:CheckBox ID="cb_soltero" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial;">Casado</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_casado" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial;">Viudo</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_viudo" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial;">Unión Libre</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_unionlibre" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial;">Divorciado</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_divorciado" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 100px">Género:</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 100px">Masculino</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_genmasculino" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 100px">Femenino</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_genfemenino" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 150px">Tipo de Sangre</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 100px">
                                    <asp:TextBox runat="server" ID="txt_tipodesangre" BorderStyle="None" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 150px">¿Es donante?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_donantesi" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">No</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_donanteno" runat="server" />
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
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 100px">Títulos:</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial;">Primaria</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_primaria" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial;">Secundaria</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_secundaria" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial;">Superior</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_superior" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial;">Especialización</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_especializacion" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial;">Diplomado</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_diplomado" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial;">Maestría</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_maestria" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial;">Doctorado</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_doctorado" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 200px">Autoidentificación Étnica:</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial;">Blanco</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_blanco" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial;">Mestizo</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_mestizo" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial;">Afrodescendiente</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_afro" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial;">Indígena</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_indigena" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial;">Montubio</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_montubio" runat="server" />
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
                                    <asp:CheckBox ID="cb_norte" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Centro</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_centro" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Sur</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_sur" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Otro</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_otro_sector" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 100px; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_otrosector" BorderStyle="None" BackColor="white" Style="width: 100%" Placeholder="Indique cuál"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 90px">Tipo de vivienda en la que reside:</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 25px">Casa</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_casa" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Departamento</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_departamento" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 25px">Otro</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_otrovivienda" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 100px; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_tipoviviendaotro" BorderStyle="None" BackColor="white" Style="width: 100%" Placeholder="Indique cuál"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 70px">Riesgo Delincuencial:</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 25px">Alto</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_riesgoalto" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 25px">Medio</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_riesgomedio" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 25px">Bajo</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_riesgobajo" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 375px">¿Cuántas personas viven en forma permanente con usted?</asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_personanvivenusted" BorderStyle="None" BackColor="white" Style="width: 100%"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 350px">¿Cuántas personas viven en forma eventual con usted?</asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_personanviveneventualusted" BorderStyle="None" BackColor="white" Style="width: 100%"></asp:TextBox>
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
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 130px">¿Destina algún dinero para el ahorro?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_dineroahorrosi" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">No</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_dineroahorrono" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 75px">¿Tiene vehículo propio?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_vehiculosi" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">No</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_vehiculono" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">¿Usa recorrido institucional?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 20px">Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_recorridosi" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 20px">No</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_recorridono" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 20px">No existe</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_recorridonoexiste" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Distancia de su domicilio al trabajo</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 100px; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_distanciadomiciotrabajo" BorderStyle="None" BackColor="white" Style="width: 100%"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />

                <%--Salud--%>

                <div class="card card-responsive" style="width: auto;">
                    <div class="card-header" style="background-color: #cccdfe; font-weight: bold; font-family: Arial">
                        SALUD
                    </div>
                    <div class="list-group list-group-flush" style="padding: 10px; text-align: center">
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 500px">¿Posee alguna enfermedad antes de ingresar al SIS ECU 911? Detalle por favor:</asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_poseeenfermedadingresarEcu" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 200px">¿Posee alguna discapacidad?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_discapacidadsi" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">No</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_discapacidadno" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 200px">Tipo de discapacidad</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_tipodiscapacidad" BorderStyle="None" Style="width: 100%;" BackColor="white" Placeholder="Detalle la o las discapacidades en caso de poseer"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <asp:Table class="table table-bordered text-center" runat="server">
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
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 350px">¿Se encuentra usted o su cónyuge embarazada?  (adjuntar certificado médico)</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_embarazadasi" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">No</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_embarazadano" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 450px">Por favor indicar en qué mes de gestación se encuentra usted o su cónyuge de ser el caso</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_mesgestacion" BorderStyle="None" Style="width: 100%;" BackColor="white" Placeholder="Ej. 6 Meses y 7 Días"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 350px">Por favor indicar la fecha tentativa de parto</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_fechatentativaparto" BorderStyle="None" Style="width: 100%;" BackColor="white" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 400px">¿Se encuentra usted en periodo de lactancia de ser el caso?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_lactaciasi" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">No</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_lactaciano" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 200px">Fecha de culminación</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_fechaculmicacionlactancia" BorderStyle="None" Style="width: 100%;" BackColor="white" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 500px">¿Posee alguna enfermedad crónica y/o catastrófica? (adjuntar certificado médico)</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_catastroficasi" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">No</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_catastroficano" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">¿Cuál?</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_cualcatastrofica" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 100px">Otras enfermedades</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="6">
                                    <asp:TextBox runat="server" ID="txt_otrasenfermedades" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 450px">¿Posee alguna enfermedad rara? (adjuntar certificado médico)</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_enfermedadrarasi" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">No</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_enfermedadrarano" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">¿Cuál?</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_enfermedadraracual" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 200px">¿Consume usted alcohol?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_alcoholsi" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">No</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_alcoholno" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 170px">Frecuencia de consumo</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_frecuenciaconsumoalcohol" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 250px">¿Hace cuanto tiempo consume?</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_tiempoconsumoalcohol" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 200px">¿Consume usted tabaco?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_tabacosi" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">No</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_tabacono" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 170px">Frecuencia de consumo</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_frecuenciaconsumotabaco" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 250px">¿Hace cuanto tiempo consume?</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_tiempoconsumotabaco" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 200px">¿Consume usted alguna sustancia psicotrópica?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_sustanciapsicotropicasi" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">No</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_sustanciapsicotropicano" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 170px">Tipo de sustancia</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_sustanciapsicotropicatipo" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 250px">Frecuencia de consumo</asp:TableCell>
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

                <%--Situacion Económica del Servidor--%>

                <div class="card card-responsive" style="width: auto;">
                    <div class="card-header" style="background-color: #cccdfe; font-weight: bold; font-family: Arial">
                        SITUACIÓN ECONÓMICA DEL SERVIDOR/A
                    </div>
                    <div class="list-group list-group-flush" style="padding: 10px; text-align: center">
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="6">
                                    <tr>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial">NÚMERO DE MIEMBROS ECONOMICAMENTE</td>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial"></td>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial" colspan="3">SITUACIÓN LABORAL DEL CÓNYUGE</td>
                                    </tr>
                                    <tr>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial">Total ingresos mensuales proyectados</td>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial">Ayuda Padres/Familiares</td>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial">Otros ingresos</td>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial" colspan="2">Total egresos mensuales proyectados</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_totalingreso1" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_ayudafamiliares1" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_otrosingresos1" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial">Alimentación</td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_alimentacion" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td style="text-align: center" rowspan="9">
                                            <asp:TextBox runat="server" ID="txt_totalfinal" BorderStyle="None" Style="width: 100%; text-align: center" BackColor="white" Placeholder="0"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_totalingreso2" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_ayudafamiliares2" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_otrosingresos2" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial">Vivienda</td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_vivienda" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_totalingreso3" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_ayudafamiliares3" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_otrosingresos3" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial">Educación</td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_educacion" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_totalingreso4" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_ayudafamiliares4" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_otrosingresos4" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial">Servicios básicos</td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_serviciosbasicos" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_totalingreso5" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_ayudafamiliares5" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_otrosingresos5" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial">Salud</td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_Salud" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_totalingreso6" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_ayudafamiliares6" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_otrosingresos6" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial">Movilización</td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_movilizacion" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_totalingreso7" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_ayudafamiliares7" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_otrosingresos7" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial">Deudas</td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_deudas" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_totalingreso8" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_ayudafamiliares8" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_otrosingresos8" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial">Otros (Pensiones, varios)</td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_otropensionesvarios" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_totalingreso9" BorderStyle="None" Style="width: 100%; text-align: center" BackColor="white" Placeholder="0"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_ayudafamiliares9" BorderStyle="None" Style="width: 100%; text-align: center" BackColor="white" Placeholder="0"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_otrosingresos9" BorderStyle="None" Style="width: 100%; text-align: center" BackColor="white" Placeholder="0"></asp:TextBox></td>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial">Total</td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_totalegresosmensualesproyectados" BorderStyle="None" Style="width: 100%; text-align: center" BackColor="white" Placeholder="0"></asp:TextBox></td>
                                    </tr>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="4">
                                    <tr>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial; text-align: left" colspan="4">DESCRIPCIÓN DE BIENES MUEBLES E INMUEBLES</td>
                                    </tr>
                                    <tr>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial; width: 200px">BIEN</td>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial; width: 100px">VALOR</td>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial" colspan="2">DETALLE</td>
                                    </tr>
                                    <tr>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial">Casa</td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_valorcasa" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial; width: 100px">Dirección</td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_direccioncasa" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial">Departamento</td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_valordepartamento" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial">Dirección</td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_direcciondepartamento" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial">Vehículo/Carro</td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_valorvehiculo" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial">Detalle</td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_detallevehiculo" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial">Terreno</td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_valorterreno" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial">Sector</td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_sectorterreno" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial">Negocio</td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_valornegocio" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial">Detalle</td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_detallenegocio" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial">Muebles y Enseres</td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_valormueblesenseres" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial">Detalle</td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_detallemueblesenseres" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                    </tr>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

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
                                    <asp:CheckBox ID="cb_unifamiliar" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Multifamiliar</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_multifamiliar" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Otro especifique</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_otrodescrpcionfamilia" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial" RowSpan="2">Tenencia</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Propia sin deuda</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_propiasindeuda" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Arrendada</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_arrendada" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">De familia</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_defamilia" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial" RowSpan="2">Otro especifique</asp:TableCell>
                                <asp:TableCell Style="background-color: white" RowSpan="2">
                                    <asp:TextBox runat="server" ID="txt_otratenencia" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Hipotecada</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_hipotecada" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Prestada</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_prestada" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Antricreces</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_anticreces" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Tipo</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Casa</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_tipocasa" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Suit</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_tiposuit" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Mediagua</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_tipomediagua" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Departamento</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_tipodepartamento" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Pieza</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 50px">
                                    <asp:CheckBox ID="cb_tipopieza" runat="server" />
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

                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">¿Cómo se moviliza de su vivienda al lugar de trabajo?</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_movilizadecasaatrabajo" BorderStyle="None" Style="width: 100%;" BackColor="white" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />

                <%--Información Familiar--%>

                <div class="card card-responsive" style="width: auto;">
                    <div class="card-header" style="background-color: #cccdfe; font-weight: bold; font-family: Arial">
                        INFORMACIÓN FAMILIAR
                    </div>
                    <div class="list-group list-group-flush" style="padding: 10px; text-align: center">
                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Composición familiar del servidor/a o trabajador/a</asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <asp:Table class="table table-bordered" runat="server">
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="4">
                                    <tr>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial">Apellidos y Nombres</td>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial; width: 150px">Parentesco</td>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial; width: 150px">Fecha de Nacimiento</td>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial; width: 150px">Edad</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_nomapellidos1" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_parentesco1" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_fechanacimiento1" BorderStyle="None" Style="width: 100%; text-align: center" BackColor="white" TextMode="Date"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_edad1" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_nomapellidos2" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_parentesco2" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_fechanacimiento2" BorderStyle="None" Style="width: 100%; text-align: center" BackColor="white" TextMode="Date"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_edad2" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_nomapellidos3" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_parentesco3" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_fechanacimiento3" BorderStyle="None" Style="width: 100%; text-align: center" BackColor="white" TextMode="Date"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_edad3" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_nomapellidos4" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_parentesco4" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_fechanacimiento4" BorderStyle="None" Style="width: 100%; text-align: center" BackColor="white" TextMode="Date"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_edad4" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_nomapellidos5" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_parentesco5" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_fechanacimiento5" BorderStyle="None" Style="width: 100%; text-align: center" BackColor="white" TextMode="Date"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_edad5" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                    </tr>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 175px">¿Tiene en su núcleo familiar alguna persona con discapacidad?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_nucleodiscapacidadsi" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">No</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_nucleodiscapacidadno" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 200px">Si su respuesta es si, continúe a la siguiente pregunta</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 175px">¿Se encuentra usted a cargo de esta persona con discapacidad? Calificada por el MSP o CONADIS</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_acargofamiliardiacapacitadosi" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">No</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_acargofamiliardiacapacitadono" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 200px">Si su respuesta es si, sírvase en llenar el cuadro a continuación</asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <asp:Table class="table table-bordered" runat="server">
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="4">
                                    <tr>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial" colspan="6">Señale los nombres y apellidos del familiar con discapacidad a su cargo (Que posea carnét de discapacidad)</td>
                                    </tr>
                                    <tr>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial">Apellidos y Nombres</td>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial; width: 150px">Fecha de caducidad del carnét</td>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial; width: 150px">Tipo de discapacidad</td>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial; width: 100px">Porcentaje</td>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial; width: 100px">Parentesco</td>
                                        <td style="background-color: #cdfecc; color: black; font-family: Arial; width: 150px">Fecha de Nacimiento</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_familiardiscapacitadonomape1" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_familiardiscapacitadofechacaducidadcarnet1" BorderStyle="None" Style="width: 100%; text-align: center" BackColor="white" TextMode="Date"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_familiardiscapacitadotipodiscapacidad1" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_familiardiscapacitadoporcentajediscapacidad1" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_familiardiscapacitadoparentesco1" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_familiardiscapacitadofechanacimiento1" BorderStyle="None" Style="width: 100%; text-align: center" BackColor="white" TextMode="Date"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_familiardiscapacitadonomape2" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_familiardiscapacitadofechacaducidadcarnet2" BorderStyle="None" Style="width: 100%; text-align: center" BackColor="white" TextMode="Date"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_familiardiscapacitadotipodiscapacidad2" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_familiardiscapacitadoporcentajediscapacidad2" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_familiardiscapacitadoparentesco2" BorderStyle="None" Style="width: 100%;" BackColor="white"></asp:TextBox></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="txt_familiardiscapacitadofechanacimiento2" BorderStyle="None" Style="width: 100%; text-align: center" BackColor="white" TextMode="Date"></asp:TextBox></td>
                                    </tr>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 600px">¿Se encuentra registrada la dependencia del familiar en el Ministerio de Trabajo?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_dependenciaministeriotrabajosi" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">No</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_dependenciaministeriotrabajono" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Nº Carnét MSP</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_numcarnetMSP" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 600px">¿Tiene en su núcleo familiar alguna persona que tenga alguna enfermedad catastrófica o rara?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_familiarenfermedadrarasi" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">No</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_familiarenfermedadrarano" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Parentesco</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_familiarenfermedadraraparentesco" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 600px">¿Se encuentra usted a cargo de esta persona con enfermedad catastrófica o rara?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_acargofamiliarenfermedadrarasi" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 30px">No</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_acargofamiliarenfermedadrarano" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Tipo de enfermedad</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txtfamiliarenfermedadraratipo" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />

                <%--Actividades en tiempo libre--%>

                <div class="card card-responsive" style="width: auto;">
                    <div class="card-header" style="background-color: #cccdfe; font-weight: bold; font-family: Arial">
                        ACTIVIDADES QUE  REALIZA EN SU TIEMPO LIBRE
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
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_otraactividad" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_otraactividad" BorderStyle="None" Style="width: 100%; background-color: transparent" placeholder="Indique cual"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 300px">¿Realiza alguna actividad económica adicional?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_actividadeconomicasi" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">No</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_actividadeconomicano" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 300px">Detalle la actividad económica que realiza</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_actividadeconomicadetalle" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <asp:Table class="table table-bordered text-center" runat="server">
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
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_deportesi" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">No</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_deporteno" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Si su respuesta es sí, especifique la actividad que realiza</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_especifiquedeporte" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Frecuencia que realiza la actividad</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_frecuenciadeporte" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">¿Desde qué edad practica ese deporte?</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_edadpracticadeporte" BorderStyle="None" Style="width: 100%; background-color: transparent" TextMode="DateTime"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">¿Ha sufrido alguna lesión?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_lesionsi" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">No</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_lesionno" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Tipo de lesión</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_tipolesion" BorderStyle="None" Style="width: 100%; background-color: transparent"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Edad a la que sufrió la lesión</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_edadlesion" BorderStyle="None" Style="width: 100%; background-color: transparent" TextMode="DateTime"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">¿Recibió algún tratamiento o rehabilitación?</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_tratamientosi" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">No</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_tratamientono" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />

                <%--Información para uso de bienestar familiar--%>

                <div class="card card-responsive" style="width: auto;">
                    <div class="card-header" style="background-color: #cccdfe; font-weight: bold; font-family: Arial">
                        INFORMACIÓN PARA USO DE BIENESTAR FAMILIAR
                    </div>
                    <div class="list-group list-group-flush" style="padding: 10px; text-align: center">

                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Tipo de familia:</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Nuclear</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_nuclear" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Ampliada</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_ampliada" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Monoparental</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_monoparental" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Padre/Madre soltero</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_padremadresoltero" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Vive solo</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_vivesolo" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Vive con amigos</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_viveconamigos" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Familia sin hijos</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_familiasinhijos" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Evaluación del nivel de relación familiar:</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Muy buena</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_relacionfamiliarmuybuena" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Buena</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_relacionfamiliarbuena" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Regular</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_relacionfamiliarregular" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Mala</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_relacionfamiliarmala" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">¿Por qué?</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_relacionfamiliarporque" BorderStyle="None" Style="width: 100%; background-color: transparent" placeholder="Especifique"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Evaluación del nivel de relación de pareja:</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Muy buena</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_relacionparejamuybuena" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Buena</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_relacionparejabuena" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Regular</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_relacionparejaregular" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Mala</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_relacionparejamala" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">¿Por qué?</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_relacionparejaporque" BorderStyle="None" Style="width: 100%; background-color: transparent" placeholder="Especifique"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Evaluación del nivel de relación con los hijos:</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Muy buena</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_relacionconhijosmuybuena" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Buena</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_relacionconhijosbuena" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Regular</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_relacionconhijosregular" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Mala</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_relacionconhijosmala" runat="server" />
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
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Ant. penales</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_antpenales" runat="server" />
                                </asp:TableCell>
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
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_rolfamiliarsi" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 50px">No</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_rolfamiliarno" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Nivel de salud de la familia:</asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Muy buena</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_nivelsaludfamiliarmuybuena" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Buena</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_nivelsaludfamiliarbuena" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Regular</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_nivelsaludfamiliarregular" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial">Mala</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_nivelsaludfamiliarmala" runat="server" />
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
                                    <asp:CheckBox ID="cb_funcional" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial; width: 100px">Disfuncional</asp:TableCell>
                                <asp:TableCell Style="background-color: white; width: 20px">
                                    <asp:CheckBox ID="cb_disfuncional" runat="server" />
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
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial"><i> La anterior información es solicitada con el fin de actualizar nuestros registros de los 
                                    servidores y trabajadores del SIS ECU 911 y realizar la vigilancia y control de la seguridad y salud del personal</i> </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <asp:Table class="table table-bordered text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #cdfecc; color: black; font-family: Arial"> <strong> <i> Certifico que la información aquí suministrada es veraz, real, completa y podrá ser verificada 
                                        en el momento que el ECU crea necesario. En caso de encontrar alguna inconsistencia en la información proporcionada se procederá de acuerdo con lo establecido en el Código 
                                        del Trabajo o LOSEP según corresponda. </i> </strong> </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <div align="center">
                            <div style="width: 200px">
                                <asp:Table class="table table-bordered table-light text-center" runat="server">
                                    <asp:TableRow>
                                        <asp:TableCell Style="background-color: #cdfecc; color: black">Si</asp:TableCell>
                                        <asp:TableCell Style="background-color: white">
                                            <asp:CheckBox ID="cb_certificosi" runat="server" />
                                        </asp:TableCell>
                                        <asp:TableCell Style="background-color: #cdfecc; color: black">No</asp:TableCell>
                                        <asp:TableCell Style="background-color: white">
                                            <asp:CheckBox ID="cb_certificono" runat="server" />
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
                            <asp:Button CssClass="btn btn-success" ID="btn_guardar" runat="server" Text="Guardar" OnClick="btn_guardar_Click" UseSubmitBehavior="False" />
                            <asp:Button CssClass="btn btn-danger" ID="btn_cancelar" runat="server" Text="Cancelar" OnClick="btn_cancelar_Click" UseSubmitBehavior="False" />
                        </div>
                    </div>
                </div>

            </div>

        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
