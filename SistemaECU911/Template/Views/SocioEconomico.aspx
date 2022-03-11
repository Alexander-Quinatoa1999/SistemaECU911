<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Views/Principal.Master" AutoEventWireup="true" CodeBehind="SocioEconomico.aspx.cs" Inherits="SistemaECU911.Template.Views.SocioEconomico1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="container" style="background-color: white">
                <br />
                <div class="container">
                    <div class="card-header" style="text-align: center; background-color: beige; color: black; border: groove">
                        <h6>DIRECCIÓN DE ADMINISTRACIÓN DE RECURSOS HUMANOS</h6>
                        <h6>GESTIÓN DE BIENESTAR LABORAL Y SALUD OCUPACIONAL</h6>
                        <h6>FICHA SOCIOECONÓMICA</h6>
                    </div>
                </div>
                <br />
                <div class="list-group list-group-flush">
                    <asp:Table class="table table-bordered table-light" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="text-align: right; background: beige; color: black; border: groove">Fecha de Registro:</asp:TableCell>
                            <asp:TableCell Style="width: 100px; background-color: whitesmoke; border: groove">
                                <asp:TextBox runat="server" ID="txt_fecha" BorderStyle="None" Style="width: 100%;" TextMode="Date" BackColor="whitesmoke"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
                <div class="card" style="width: auto; background-color: aliceblue; border: groove">
                    <div class="card-header">
                        <b>DATOS GENERALES</b>
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-center table-responsive" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="2">Cédula:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke; text-align: left" ColumnSpan="9">
                                    <asp:TextBox runat="server" ID="txt_cedula" OnTextChanged="txt_cedula_TextChanged" BorderStyle="None" Style="width: 500px;" AutoPostBack="true" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2" Style="background-color: beige; color: black">Nombres y Apellidos:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_priapellido" BorderStyle="None" Style="width: 100px;" ReadOnly="true" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_segapellido" BorderStyle="None" Style="width: 100px;" ReadOnly="true" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_prinombre" BorderStyle="None" Style="width: 100px;" ReadOnly="true" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_segnombre" BorderStyle="None" Style="width: 100px;" ReadOnly="true" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2" Style="background-color: beige; color: black">Departamento / Área en la que trabaja:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke; text-align: left" ColumnSpan="9">
                                    <asp:TextBox runat="server" ID="txt_areatrabajo" BorderStyle="None" Style="width: 500px;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2" Style="background-color: beige; color: black">Carga Institucional:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke; text-align: left" ColumnSpan="9">
                                    <asp:TextBox runat="server" ID="txt_cargoinstitucional" BorderStyle="None" Style="width: 500px;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>

                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2" Style="background-color: beige; color: black">Tipo de Contrato:</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Nombramiento:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_nombramiento" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Nombramiento Provisional:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_nombraprovisional" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Contrato Ocasional:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_contratoocasional" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="2" Style="background-color: beige; color: black">Código de Trabajo:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_codigotrabajoContrato" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2" Style="background-color: beige; color: black">Modalidad de Contrato:</asp:TableCell>
                                <asp:TableCell ColumnSpan="3" Style="background-color: beige; color: black">Ley Orgánica del Sector Público (LOSEP):</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_modalidadlosep" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="2" Style="background-color: beige; color: black">Código de Trabajo:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_codigotrabajoModalidad" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2" Style="background-color: beige; color: black">Fecha de Ingreso al SIS ECU 911:</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">dd/mm/aa:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="3">
                                    <asp:TextBox runat="server" ID="txt_fechaingreso" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black">Estado Civil:</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Soltero:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_soltero" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Casado:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_casado" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Viudo:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_viudo" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Unión Libre:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_unionlibre" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Divorciado:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_divorciado" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black">Género:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_genero" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Tipo de Sangre:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_tiposangre" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="2">Teléfono Convencional:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_telfconvencional" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Teléfono Celular:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_telfcelular" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Email:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="4">
                                    <asp:TextBox runat="server" ID="txt_email" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="2">Lugar de Nacimiento:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_lugarnacimiento" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Fecha de Nacimiento:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_fechanacimiento" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Edad:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_edad" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" RowSpan="2">Nivel Educativo:</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Primaria</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_primaria" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Secundaria</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_secundaria" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Superior</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_superior" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="2">Especialización</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_especializacion" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black">Diploma</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_diploma" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Maestría</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_maestria" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black">Autoidentificación Étnica:</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Blanco</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_blanco" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Mestizo</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_mestizo" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Afrodescendiente</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_afrodescendiente" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Indígena</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_indigena" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Montubio</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_montubio" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black">Dirección del domicilio:</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Provincia:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_provincia" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Cantón:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_canton" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Parroquia:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_parroquia" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Barrio:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_barrio" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black">Calle de la vivienda y numeración:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_callevivienda" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Calle Secundaria:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_callesecundaria" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="2">Referencia para ubicar el domicilio:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="3">
                                    <asp:TextBox runat="server" ID="txt_referenciadomicilio" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black">Sector donde vive:</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Norte</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_norte" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Centro</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_centro" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Sur</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_sur" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Otro</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_otrosector" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Indique cuál</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_otrosector" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="2" RowSpan="2">Tipo de vivienda que recide:</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Casa</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_casa" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Departamento</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_departamento" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="2">Otro (Indique cuál)</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_otravivienda" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="3">¿Cuenta con todos los servicios básicos?</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_siserviciobasico" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_noserviciobasico" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="3">¿Cuántas personas viven de forma permanente con usted?</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_personasvivenconusted" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="3">¿Cuántas personas viven de forma eventual con usted?</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="3">
                                    <asp:TextBox runat="server" ID="txt_personasviveneventualconusted" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="2">Persona para contactarse en caso de emergencia:</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Nombres y Apellidos</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_nomapeemergencia" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Parentesco</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_parentesco" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Teléfono</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_telfemergencia" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" RowSpan="2">Dirección del familiar:</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Calle principal</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_calleprincipalfamiliar" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Nº del domicilio</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="3">
                                    <asp:TextBox runat="server" ID="txt_numdomiciliofamiliar" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black">Calle secundaria</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_callesecundariafamiliar" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="2">Referencia para ubicar el domicilio</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="5">
                                    <asp:TextBox runat="server" ID="txt_referenciadomiciliofamiliar" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="text-align: center; background-color: beige; color: black" ColumnSpan="2">¿Destina algún dinero para el ahorro?</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_siahorro" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_noahorro" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Vehículo Propio</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_sivehiculo" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_novehiculo" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="2">Usa recorrido institucional</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_sirecorrido" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_norecorrido" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">No Existe</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_noexisterecorrido" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="3">Distancia de su domicilio al trabajo (Indicar el tiempo en minutos)</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="8">
                                    <asp:TextBox runat="server" ID="txt_distanciadomicilio" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto; background-color: aliceblue; border: groove">
                    <div class="card-header">
                        <b>SALUD</b>
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered text-center table-light table-responsive" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="6">¿Posee alguna enfermedad antes de ingresar al SIS ECU 911? ¿Cuál? Detalle por favor:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke; text-align: left" ColumnSpan="5">
                                    <asp:TextBox runat="server" ID="txt_poseeenfermedad" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="3">¿Posee alguna discapacidad?</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_sidiscapacidad" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_nodiscapacidad" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="2">Tipo de discapacidad</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_tipodiscapacidad" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="4">¿Cúal es su porcentaje de discapacidad?</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_porcentajediscapacidad" BorderStyle="None" Style="width: 100%; text-align: center" placeholder="%" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="3">Nº de Carnet otorgado por el MSP o CONADIS</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_numcarnetconadis" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Fecha de caducidad del carnét</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_fechacaducidadcarnet" BorderStyle="None" TextMode="Date" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="5">¿Se encuentra usted o su cónyuge embarazada?  (adjuntar certificado médico)</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_noconyugeembarazada" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Sí, me encuentro embarazada</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_simeenceuntroembarazada" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Sí, mi conyuge se encuentra embarazada</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_simiconyugeembarazada" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="5">Por favor indicar en qué mes de gestación se encuentra usted o su cónyuge:</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Meses</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_mesgestacion" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Días</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_diasgestacion" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="5">Por favor indicar la fecha tentativa de parto :</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="4">
                                    <asp:TextBox runat="server" ID="txt_fechatentativaparto" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="5">¿Se encuentra usted en periodo de lactancia?</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_siperiodolactancia" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_noperiodolactancia" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Fecha de Culminación</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_fechaculminacionlactancia" BorderStyle="None" Style="width: 100%;" TextMode="Date" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="5" RowSpan="2">¿Posee alguna enfermedad crónica y/o catastrófica diagnostica por el IESS? (adjuntar certificado médico)</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_sienfermedadcronica" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_noenfermedadcronica" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black">¿Cuál?</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_cualenfermedadcronica" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Otras enfermedades</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_otrasenfermedades" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="5" RowSpan="2">¿Posee alguna enfermedad rara? (adjuntar certificado médico)</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_sienfermedadrara" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_noenfermedadrara" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black">¿Cuál?</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="3">
                                    <asp:TextBox runat="server" ID="txt_cualenfermedadrara" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="3" RowSpan="2">¿Consume alcohol?</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_sialcohol" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_noalcohol" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="2">Frecuencia de consumo</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_frecuenciaalcohol" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Tiempo de consumo</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_tiempoconsumoalcohol" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="3" RowSpan="2">Tipo de licor que prefiere consumir</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Cerveza</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_cerveza" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Ron</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_ron" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Whisky</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_whisky" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="2">Otro especifíque</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="3">
                                    <asp:TextBox runat="server" ID="txt_otroalcohol" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="3" RowSpan="2">¿Consume usted tabaco?</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_sitabaco" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_notabaco" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Frecuencia</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_frecuenciatabaco" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Cantidad</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_cantidadtabaco" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="2">Tiempo de consumo</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="3">
                                    <asp:TextBox runat="server" ID="txt_tiempoconsumotabaco" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="3">¿Consume usted alguna sustancia psicotrópica?</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_sipsicotropica" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">NO</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_nopsicotropica" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Tipo de sustancia:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_tipopsicotropica" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Frecuencia de consumo:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_frecuenciapsicotropica" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="6">Factores psicosociales relacionados con el consumo:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="5">
                                    <asp:TextBox runat="server" ID="txt_factorespsicotropica" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto; background-color: aliceblue; border: groove">
                    <div class="card-header">
                        <b>INFORMACIÓN FAMILIAR</b>
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-center table-responsive" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="2">Nombres y Apellidos del cónyugue:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_nomapeconyuge" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black">Número de hijos:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_numhijos" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Número de dependientes:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_numdependientes" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="text-align: center; background-color: beige; color: black" ColumnSpan="2">Apellidos y Nombres</asp:TableCell>
                                <asp:TableCell Style="text-align: center; background-color: beige; color: black">Fecha de Nacimiento</asp:TableCell>
                                <asp:TableCell Style="text-align: center; background-color: beige; color: black">Edad</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_nomapefam1" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_fechanacfam1" BorderStyle="None" Style="width: 100%; text-align: center" TextMode="Date" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_edadfam1" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_nomapefam2" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_fechanacfam2" BorderStyle="None" Style="width: 100%; text-align: center" TextMode="Date" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_edadfam2" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="3">¿Tiene en su núcleo familiar alguna persona con discapacidad?</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Si</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_siperdis" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">No</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_noperdis" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="2">Si su respuesta es sí continúe con la siguiente pregunta</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow Style="text-align: center">
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="3">¿Se encuentra usted a cargo de esta persona con discapacidad? Calificada por el MSP o CONADIS</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Si</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_sicargodis" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">No</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_nocargodis" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="2">Si su respuesta es sí sírvase llenar el cuadro a continuación</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="9">Señala el nombres y apellidos del familiar con discapacidad a su cargo (que posea carnet de discapacidad)</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="2">Apellidos y Nombres</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Fecha de Caducidad</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="2">Tipo de discapacidad</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Porcentaje</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="2">Indicar Parentesco</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Fecha de Nacimiento</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_nomapefamdis" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_fechacadis" BorderStyle="None" Style="width: 100%; text-align: center" TextMode="Date" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_tipodis" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_porcdis" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_parendis" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_fechanacdis" BorderStyle="None" Style="width: 100%; text-align: center" TextMode="Date" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="3">¿Se encuentra registrada la dependencia del familiar en el Ministerio de Inclusión Económica y Social?</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Si</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_siMies" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">No</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_noMies" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Nº Carnet MSP:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_carnetMies" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="3">¿Tiene en su núcleo familiar alguna persona que tenga alguna enfermedad catastrófica o rara?</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Si</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_sifamcatas" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">No</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_nofamcatas" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Indicar Parentesco:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_indicarfamcatas" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="3">¿Se encuentra usted a cargo de esta persona con enfermedad catastrófica o rara?</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Si</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_siacargofamcatas" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">No</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_noacargofamcatas" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Tipo de enfermedad:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_tipoacargofamcatas" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto; background-color: aliceblue; border: groove">
                    <div class="card-header">
                        <b>ACTIVIDADES QUE  REALIZA EN SU TIEMPO LIBRE:</b>
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black">Hogar</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_hogar" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="3">Paseos familiares</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_paseosfam" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Estudios</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_estudios" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Actividades artísticas</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_actartisticas" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Otros</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_otratc" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="3">Trabajo complementario</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="4">
                                    <asp:TextBox runat="server" ID="txt_trabajocomplementario" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="2">Detalle de la actividad que realiza:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="3">
                                    <asp:TextBox runat="server" ID="txt_detalleact" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="3">Tiempo que destina a la actividad:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="4">
                                    <asp:TextBox runat="server" ID="txt_tiempact" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="2">¿Hace cuánto tiempo realiza la actividad?</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="3">
                                    <asp:TextBox runat="server" ID="txt_hacecuantoact" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="3" RowSpan="2">¿Realiza alguna actividad deportiva?</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Si</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_sideportiva" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">No</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_nodeportiva" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="2">Si su respuesta es sí especifique la actividad que realiza:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="3">
                                    <asp:TextBox runat="server" ID="txt_especificaract" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black">Frecuencia:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="4">
                                    <asp:TextBox runat="server" ID="txt_frecuenciaact" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="2">¿Desde qué edad practica ese deporte?</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_edadpractica" BorderStyle="None" Style="width: 100%; text-align: center" placeholder="en años" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="3" RowSpan="2">¿Ha sufrido alguna lesión?</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Si</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_silesion" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">No</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_nolesion" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Tipo de lesión:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_tipolesion" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="2">Edad a la que sufrió la lesión</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:TextBox runat="server" ID="txt_edadlesion" BorderStyle="None" Style="width: 100%; text-align: center" placeholder=" en años" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="5">¿Recibió algún tratamiento o rehabilitación?</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Si</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_sitratamiento" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">No</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_notratamiento" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto; background-color: aliceblue; border: groove">
                    <div class="card-header">
                        <b>INFORMACIÓN ESTABILIDAD FAMILIAR</b>
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" RowSpan="2">Tipo de familia:</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Nuclear:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_nuclear" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Ampliada:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_ampliada" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Monoparental:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_monoparental" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Padre/Madre soltero:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_padremadresoltero" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="2">Vive solo:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_vivesolo" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="2">Vive con amigos:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_viveamigos" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="2">Familia sin hijos:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_familiasinhijos" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black">Evaluación del nivel de relación familiar:</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Muy bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_familiarmuybueno" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_familiarbueno" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Regular</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_familiaregular" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Mala</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_familiarmala" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">¿Por qué?</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="4">
                                    <asp:TextBox runat="server" ID="txt_familiarporque" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black">Evaluación del nivel de relación de pareja:</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Muy bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_parejamuybueno" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_parejabueno" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Regular</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_parejaregular" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Mala</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_parejamala" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">¿Por qué?</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="4">
                                    <asp:TextBox runat="server" ID="txt_parejaporque" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black">Evaluación del nivel de relación con los hijos:</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Muy bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_hijosmuybueno" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_hijosbueno" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Regular</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_hijosregular" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Mala</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_hijosmala" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">¿Por qué?</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="4">
                                    <asp:TextBox runat="server" ID="txt_hijosporque" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" RowSpan="2">Problemas Familiares:</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="2">Ant. Penales</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_antpenales" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Económicos</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_economicos" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Comunicación</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_comunicacion" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Conyugales</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_conyugales" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Crianza de hijos</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_crianzahijos" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Adicciones</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_adicciones" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black">Violencia:</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Física</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_fisica" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Psicológica</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_psicologica" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Verbal</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_verbal" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Sexual</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_sexual" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black">Observaciones:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="9">
                                    <asp:TextBox runat="server" ID="txt_observaciones" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black">¿Cada miembro de la familia cumple su Rol?</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">SI</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_rolsi" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">No</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_rolno" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black">Nivel de salud de la familia:</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Muy bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_saludmuybuena" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_saludbuena" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Regular</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_saludregular" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Mala</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_saludmala" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">¿Por qué?</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="4">
                                    <asp:TextBox runat="server" ID="txt_saludporque" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black">Por lo tanto la familia es</asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Funcional</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_funcional" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">Disfuncional</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_disfuncional" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black">Observaciones:</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="9">
                                    <asp:TextBox runat="server" ID="txt_observacion" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black" ColumnSpan="14">Alguna información adicional que la institución deba conocer : (Médica, Familiar , Legal , etc ):</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: whitesmoke" ColumnSpan="14">
                                    <asp:TextBox runat="server" ID="txt_adicional" BorderStyle="None" Style="width: 100%;" BackColor="whitesmoke"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="container" style="text-align: center">
                    <p>
                        <strong>La anterior información es solicitada con el fin de actualizar nuestros registros de los 
                        servidores y trabajadores del SIS ECU 911 y realizar la vigilancia y control de la seguridad y salud 
                        del personal</strong>
                    </p>
                </div>
                <div class="container" style="text-align: center">
                    <p>
                        <strong>Certifico que la información aquí suministrada es veraz, real, completa y podrá ser verificada 
                        en el momento que el ECU crea necesario. En caso de encontrar alguna inconsistencia en la información 
                        proporcionada se procederá de acuerdo con lo establecido en el Código del Trabajo o LOSEP según 
                        corresponda.</strong>
                    </p>
                </div>
                <div align="center">
                    <div style="width: 200px">
                        <asp:Table class="table table-bordered table-light text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: beige; color: black">Si</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_sicertifico" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: beige; color: black">No</asp:TableCell>
                                <asp:TableCell Style="background-color: whitesmoke">
                                    <asp:CheckBox ID="cb_nocertificado" runat="server" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="container" style="text-align: center">
                    <p>
                        <strong>MUCHAS GRACIAS POR SU COLABORACIÓN</strong>
                    </p>
                </div>
                <div align="center">
                    <div class="card" style="width: 200px">
                        <div class="card-header" style="background-color: aliceblue">
                            Firma del Servidor/a
                        </div>
                        <div class="list-group list-group-flush">
                            <asp:Label ID="Label93" runat="server" Style="height: 60px"></asp:Label>
                        </div>
                    </div>
                </div>
                <br />
                <div class="container" align="center">
                    <asp:Button CssClass="btn btn-success" ID="btn_guardarsso" runat="server" Text="Guardar" OnClick="btn_guardarsso_Click" UseSubmitBehavior="False" />
                    <asp:Button CssClass="btn btn-info" ID="btn_modificarsso" runat="server" Text="Modificar" OnClick="btn_modificarsso_Click" UseSubmitBehavior="False" />
                    <asp:Button CssClass="btn btn-danger" ID="btn_cancelarsso" runat="server" Text="Cancelar" OnClick="btn_cancelarsso_Click" UseSubmitBehavior="False" />
                </div>
                <br />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
