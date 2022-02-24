<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Views/Principal.Master" AutoEventWireup="true" CodeBehind="SocioEconomico.aspx.cs" Inherits="SistemaECU911.Template.Views.SocioEconomico1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="container" style="background-color: white; border: none">
                <br />
                <div class="card-header" style="text-align: center; background-color: aliceblue; border: groove">
                    <h6>DIRECCIÓN DE ADMINISTRACIÓN DE RECURSOS HUMANOS</h6>
                    <h6>GESTIÓN DE BIENESTAR LABORAL Y SALUD OCUPACIONAL</h6>
                    <h6>FICHA SOCIOECONÓMICA</h6>
                </div>
                <br />
                <div class="list-group list-group-flush">
                    <asp:Table class="table table-bordered table-light" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="text-align: right; background: aliceblue">Fecha de Registro:</asp:TableCell>
                            <asp:TableCell Style="width: 100px; background-color: white">
                                <asp:TextBox runat="server" ID="txt_fecha" BorderStyle="None" Style="width: 100%;" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
                <div class="card" style="width: auto; background-color: aliceblue">
                    <div class="card-header">
                        <b>DATOS GENERALES (MARQUE CON UNA X)</b>
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-center table-responsive" runat="server">
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">Cédula:</asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left" ColumnSpan="14">
                                    <asp:TextBox runat="server" ID="txt_cedula" OnTextChanged="txt_cedula_TextChanged" BorderStyle="None" Style="width: 500px;" AutoPostBack="true"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">Nombres y Apellidos:</asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_priapellido" BorderStyle="None" Style="width: 100px;" ReadOnly="true"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_segapellido" BorderStyle="None" Style="width: 100px;" ReadOnly="true"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left">
                                    <asp:TextBox runat="server" ID="txt_prinombre" BorderStyle="None" Style="width: 100px;" ReadOnly="true"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left" ColumnSpan="11">
                                    <asp:TextBox runat="server" ID="txt_segnombre" BorderStyle="None" Style="width: 100px;" ReadOnly="true"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">Departamento / Área en la que trabaja:</asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left" ColumnSpan="14">
                                    <asp:TextBox runat="server" ID="txt_areatrabajo" BorderStyle="None" Style="width: 500px;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">Carga Institucional:</asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left" ColumnSpan="14">
                                    <asp:TextBox runat="server" ID="txt_cargoinstitucional" BorderStyle="None" Style="width: 500px;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>

                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">Tipo de Contrato:</asp:TableCell>
                                <asp:TableCell>Nombramiento:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_nombramiento" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="2">Nombramiento Provisional:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_nombraprovisional" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Contrato Ocasional:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_contratoocasional" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="3">Código de Trabajo:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="4">
                                    <asp:TextBox runat="server" ID="txt_codigotrabajoContrato" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">Modalidad de Contrato:</asp:TableCell>
                                <asp:TableCell ColumnSpan="3">Ley Orgánica del Sector Público (LOSEP):</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_modalidadlosep" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="3">Código de Trabajo:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="7">
                                    <asp:TextBox runat="server" ID="txt_codigotrabajoModalidad" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">Fecha de Ingreso al SIS ECU 911:</asp:TableCell>
                                <asp:TableCell>Día/Mes/Año:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="13">
                                    <asp:TextBox runat="server" ID="txt_fechaingreso" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Estado Civil:</asp:TableCell>
                                <asp:TableCell>Soltero:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_soltero" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Casado:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_casado" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Viudo:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_viudo" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Unión Libre:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_unionlibre" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Divorciado:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="6">
                                    <asp:TextBox runat="server" ID="txt_divorciado" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Género:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="4">
                                    <asp:TextBox runat="server" ID="txt_genero" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="2">Tipo de Sangre:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="9">
                                    <asp:TextBox runat="server" ID="txt_tiposangre" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Teléfono Convencional:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_telfconvencional" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Teléfono Celular:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_telfcelular" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Email:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="9">
                                    <asp:TextBox runat="server" ID="txt_email" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Lugar de Nacimiento:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_lugarnacimiento" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Fecha de Nacimiento:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3">
                                    <asp:TextBox runat="server" ID="txt_fechanacimiento" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Edad:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="8">
                                    <asp:TextBox runat="server" ID="txt_edad" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell RowSpan="2">Nivel Educativo:</asp:TableCell>
                                <asp:TableCell ColumnSpan="2">Primaria</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_primaria" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Secundaria</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_secundaria" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Superior</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="8">
                                    <asp:TextBox runat="server" ID="txt_superior" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">Especialización</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_especializacion" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Diploma</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_diploma" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Maestría</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="8">
                                    <asp:TextBox runat="server" ID="txt_maestria" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell RowSpan="2">Autoidentificación Étnica:</asp:TableCell>
                                <asp:TableCell ColumnSpan="2">Blanco</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_blanco" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Mestizo</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_mestizo" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Afrodescendiente</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="8">
                                    <asp:TextBox runat="server" ID="txt_afrodescendiente" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">Indígena</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_indigena" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="3">Montubio</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="9">
                                    <asp:TextBox runat="server" ID="txt_montubio" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Dirección del domicilio:</asp:TableCell>
                                <asp:TableCell>Provincia:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_provincia" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Cantón:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_canton" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Parroquia:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_parroquia" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Barrio:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="7">
                                    <asp:TextBox runat="server" ID="txt_barrio" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Calle de la vivienda y numeración:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_callevivienda" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Calle Secundaria:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_callesecundaria" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="2">Referencia para ubicar el domicilio:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="8">
                                    <asp:TextBox runat="server" ID="txt_referenciadomicilio" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Sector donde vive:</asp:TableCell>
                                <asp:TableCell>Norte</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_norte" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Centro</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_centro" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Sur</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_sur" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Otro</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_otro" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Indique cuál</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="4">
                                    <asp:TextBox runat="server" ID="txt_otrosector" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Tipo de vivienda que recide:</asp:TableCell>
                                <asp:TableCell>Casa</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_casa" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Departamento</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_departamento" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Otro (Indique cuál)</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_otravivienda" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>¿Cuenta con todos los servicios básicos?</asp:TableCell>
                                <asp:TableCell>SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_siserviciobasico" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_noserviciobasico" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">¿Cuántas personas viven de forma permanente con usted?</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3">
                                    <asp:TextBox runat="server" ID="txt_personasvivenconusted" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="3">¿Cuántas personas viven de forma eventual con usted?</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="6">
                                    <asp:TextBox runat="server" ID="txt_personasviveneventualconusted" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Persona para contactarse en caso de emergencia:</asp:TableCell>
                                <asp:TableCell>Nombres y Apellidos</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_nomapeemergencia" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Parentesco</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_parentesco" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Teléfono</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="6">
                                    <asp:TextBox runat="server" ID="txt_telfemergencia" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell RowSpan="2">Dirección del familiar:</asp:TableCell>
                                <asp:TableCell>Calle principal</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="5">
                                    <asp:TextBox runat="server" ID="txt_calleprincipalfamiliar" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Nº del domicilio/departamento</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="6">
                                    <asp:TextBox runat="server" ID="txt_numdomiciliofamiliar" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Calle secundaria</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3">
                                    <asp:TextBox runat="server" ID="txt_callesecundariafamiliar" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="3">Referencia para ubicar el domicilio</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="6">
                                    <asp:TextBox runat="server" ID="txt_referenciadomiciliofamiliar" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="5" Style="text-align: center">¿Destina algún dinero para el ahorro?</asp:TableCell>
                                <asp:TableCell>SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_siahorro" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="5">
                                    <asp:TextBox runat="server" ID="txt_noahorro" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Vehículo Propio</asp:TableCell>
                                <asp:TableCell>SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_sivehiculo" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_novehiculo" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="2">Usa recorrido institucional</asp:TableCell>
                                <asp:TableCell>SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_sirecorrido" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_norecorrido" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>NO EXISTE</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="4">
                                    <asp:TextBox runat="server" ID="txt_noexisterecorrido" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="5">Distancia de su domicilio al trabajo (Indicar el tiempo en minutos)</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="10">
                                    <asp:TextBox runat="server" ID="txt_distanciadomicilio" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto; background-color: aliceblue">
                    <div class="card-header">
                        <b>SALUD</b>
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered text-center table-light table-responsive" runat="server">
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="7">¿Posee alguna enfermedad antes de ingresar al SIS ECU 911? ¿Cuál? Detalle por favor:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="7">
                                    <asp:TextBox runat="server" ID="txt_poseeenfermedad" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>¿Posee alguna discapacidad?</asp:TableCell>
                                <asp:TableCell>SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_sidiscapacidad" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_nodiscapacidad" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="2">Tipo de discapacidad</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="10">
                                    <asp:TextBox runat="server" ID="txt_tipodiscapacidad" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>¿Cúal es su porcentaje de discapacidad?</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_porcentajediscapacidad" BorderStyle="None" Style="width: 100%;" placeholder="%"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="4">Nº de Carnet otorgado por el MSP o CONADIS :</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_numcarnetconadis" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="3">Fecha de caducidad del carnét: (día/mes/año)</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3">
                                    <asp:TextBox runat="server" ID="txt_fechacaducidadcarnet" BorderStyle="None" Style="width: 100%;" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">¿Se encuentra usted o su cónyuge embarazada?  (adjuntar certificado médico)</asp:TableCell>
                                <asp:TableCell>NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_noconyugeembarazada" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="3">Sí, me encuentro embarazada</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_simeenceuntroembarazada" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="3">Sí, mi conyuge se encuentra embarazada</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3">
                                    <asp:TextBox runat="server" ID="txt_simiconyugeembarazada" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="8">Por favor indicar en qué mes de gestación se encuentra usted o su cónyuge:</asp:TableCell>
                                <asp:TableCell>Meses</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_mesgestacion" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Días</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_diasgestacion" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="3">Por favor indicar la fecha tentativa de parto :</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="11">
                                    <asp:TextBox runat="server" ID="txt_fechatentativaparto" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">¿Se encuentra usted en periodo de lactancia?</asp:TableCell>
                                <asp:TableCell>SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_siperiodolactancia" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_noperiodolactancia" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Fecha de Culminación (día/mes/año)</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="7">
                                    <asp:TextBox runat="server" ID="txt_fechaculminacionlactancia" BorderStyle="None" Style="width: 100%;" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="3">¿Posee alguna enfermedad crónica y/o catastrófica diagnostica por el IESS? (adjuntar certificado médico)</asp:TableCell>
                                <asp:TableCell>SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_sienfermedadcronica" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_noenfermedadcronica" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>¿Cuál?</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_cualenfermedadcronica" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Otras enfermedades</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3">
                                    <asp:TextBox runat="server" ID="txt_otrasenfermedades" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="4">¿Posee alguna enfermedad rara? (adjuntar certificado médico)</asp:TableCell>
                                <asp:TableCell>SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_sienfermedadrara" BorderStyle="None"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_noenfermedadrara" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>¿Cuál?</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="5">
                                    <asp:TextBox runat="server" ID="txt_cualenfermedadrara" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>¿Consume alcohol?</asp:TableCell>
                                <asp:TableCell>SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_sialcohol" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_noalcohol" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Tipo de licor que prefiere consumir</asp:TableCell>
                                <asp:TableCell>Cerveza</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_cerveza" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Ron</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_ron" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Whisky</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_whisky" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Otro especifíque</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_otroalcohol" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Frecuencia de consumo</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="6">
                                    <asp:TextBox runat="server" ID="txt_frecuenciaalcohol" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Tiempo de consumo</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="8">
                                    <asp:TextBox runat="server" ID="txt_tiempoconsumoalcohol" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>¿Consume usted tabaco?</asp:TableCell>
                                <asp:TableCell>SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_sitabaco" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_notabaco" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Frecuencia</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_frecuenciatabaco" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Cantidad</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="5">
                                    <asp:TextBox runat="server" ID="txt_cantidadtabaco" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Tiempo de consumo</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="14">
                                    <asp:TextBox runat="server" ID="txt_tiempoconsumotabaco" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>¿Consume usted alguna sustancia psicotrópica?</asp:TableCell>
                                <asp:TableCell>SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_sipsicotropica" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_nopsicotropica" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Tipo de sustancia:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_tipopsicotropica" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Frecuencia de consumo:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="5">
                                    <asp:TextBox runat="server" ID="txt_frecuenciapsicotropica" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="4">Factores psicosociales relacionados con el consumo:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="10">
                                    <asp:TextBox runat="server" ID="txt_factorespsicotropica" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto; background-color: aliceblue">
                    <div class="card-header">
                        <b>INFORMACIÓN FAMILIAR</b>
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-center table-responsive" runat="server">
                            <asp:TableRow>
                                <asp:TableCell>Nombres y Apellidos del cónyugue:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="11">
                                    <asp:TextBox runat="server" ID="txt_nomapeconyuge" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Número de hijos:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="5">
                                    <asp:TextBox runat="server" ID="txt_numhijos" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Número de dependientes:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="4">
                                    <asp:TextBox runat="server" ID="txt_numdependientes" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="6" Style="text-align: center">Apellidos y Nombres</asp:TableCell>
                                <asp:TableCell Style="text-align: center">Fecha de Nacimiento</asp:TableCell>
                                <asp:TableCell ColumnSpan="3" Style="text-align: center">Edad</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white" ColumnSpan="6">
                                    <asp:TextBox runat="server" ID="txt_nomapefam1" BorderStyle="None" Style="width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_fechanacfam1" BorderStyle="None" Style="width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3">
                                    <asp:TextBox runat="server" ID="txt_edadfam1" BorderStyle="None" Style="width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white" ColumnSpan="6">
                                    <asp:TextBox runat="server" ID="txt_nomapefam2" BorderStyle="None" Style="width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_fechanacfam2" BorderStyle="None" Style="width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3">
                                    <asp:TextBox runat="server" ID="txt_edadfam2" BorderStyle="None" Style="width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">¿Tiene en su núcleo familiar alguna persona con discapacidad?</asp:TableCell>
                                <asp:TableCell>Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_siperdis" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>No</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_noperdis" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="6">Si su respuesta es sí continúe con la siguiente pregunta</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow Style="text-align: center">
                                <asp:TableCell ColumnSpan="2">¿Se encuentra usted a cargo de esta persona con discapacidad? Calificada por el MSP o CONADIS</asp:TableCell>
                                <asp:TableCell>Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_sicargodis" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>No</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_nocargodis" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="6">Si su respuesta es sí sírvase llenar el cuadro a continuación</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="11">Señala el nombres y apellidos del familiar con discapacidad a su cargo (que posea carnet de discapacidad)</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="4">Apellidos y Nombres</asp:TableCell>
                                <asp:TableCell>Fecha de Caducidad</asp:TableCell>
                                <asp:TableCell>Tipo de discapacidad</asp:TableCell>
                                <asp:TableCell>Porcentaje</asp:TableCell>
                                <asp:TableCell>Indicar Parentesco</asp:TableCell>
                                <asp:TableCell>Fecha de Nacimiento</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white" ColumnSpan="4">
                                    <asp:TextBox runat="server" ID="txt_nomapefamdis" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_fechacadis" BorderStyle="None" Style="width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_tipodis" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_porcdis" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_parendis" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_fechanacdis" BorderStyle="None" Style="width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">¿Se encuentra registrada la dependencia del familiar en el Ministerio de Inclusión Económica y Social?</asp:TableCell>
                                <asp:TableCell>Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_siMies" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>No</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_noMies" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Nº Carnet MSP:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_carnetMies" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">¿Tiene en su núcleo familiar alguna persona que tenga alguna enfermedad catastrófica o rara?</asp:TableCell>
                                <asp:TableCell>Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_sifamcatas" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>No</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_nofamcatas" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Indicar Parentesco:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_indicarfamcatas" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">¿Se encuentra usted a cargo de esta persona con enfermedad catastrófica o rara?</asp:TableCell>
                                <asp:TableCell>Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_siacargofamcatas" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>No</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_noacargofamcatas" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Tipo de enfermedad:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_tipoacargofamcatas" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto; background-color: aliceblue">
                    <div class="card-header">
                        <b>ACTIVIDADES QUE  REALIZA EN SU TIEMPO LIBRE:</b>
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-center table-responsive" runat="server">
                            <asp:TableRow>
                                <asp:TableCell>Hogar</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_hogar" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Paseos familiares</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_paseosfam" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Estudios</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_estudios" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Actividades artísticas</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_actartisticas" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Otros</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="7">
                                    <asp:TextBox runat="server" ID="txt_otratc" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Trabajo complementario</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3">
                                    <asp:TextBox runat="server" ID="txt_trabajocomplementario" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Detalle de la actividad que realiza:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_detalleact" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Tiempo que destina a la actividad:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_tiempact" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>¿Hace cuánto tiempo realiza la actividad?</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="5">
                                    <asp:TextBox runat="server" ID="txt_hacecuantoact" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>¿Realiza alguna actividad deportiva?</asp:TableCell>
                                <asp:TableCell>Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_sideportiva" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>No</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_nodeportiva" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Si su respuesta es sí especifique la actividad que realiza:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_especificaract" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Frecuencia:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_frecuenciaact" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>¿Desde qué edad practica ese deporte?</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="4">
                                    <asp:TextBox runat="server" ID="txt_edadpractica" BorderStyle="None" Style="width: 100%; text-align: center" placeholder="en años"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>¿Ha sufrido alguna lesión?</asp:TableCell>
                                <asp:TableCell>Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_silesion" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>No</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_nolesion" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Tipo de lesión:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_tipolesion" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Edad a la que sufrió la lesión</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_edadlesion" BorderStyle="None" Style="width: 100%; text-align: center" placeholder=" en años"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>¿Recibió algún tratamiento o rehabilitación?</asp:TableCell>
                                <asp:TableCell>Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_sitratamiento" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>No</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_notratamiento" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto; background-color: aliceblue">
                    <div class="card-header">
                        <b>INFORMACIÓN ESTABILIDAD FAMILIAR</b>
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-center table-responsive" runat="server">
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="14" Style="text-align: left">Tipo de familia:</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Nuclear:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_nuclear" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Ampliada:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_ampliada" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Monoparental:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_monoparental" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Padre/Madre soltero:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_padremadresoltero" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Vive solo:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_vivesolo" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Vive con amigos:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_viveamigos" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Familia sin hijos:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_familiasinhijos" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">Evaluación del nivel de relación familiar:</asp:TableCell>
                                <asp:TableCell>Muy bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_familiarmuybueno" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_familiarbueno" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Regular</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_familiaregular" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Mala</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_familiarmala" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>¿Por qué?</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3">
                                    <asp:TextBox runat="server" ID="txt_familiarporque" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">Evaluación del nivel de relación de pareja:</asp:TableCell>
                                <asp:TableCell>Muy bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_parejamuybueno" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_parejabueno" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Regular</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_parejaregular" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Mala</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_parejamala" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>¿Por qué?</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3">
                                    <asp:TextBox runat="server" ID="txt_parejaporque" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">Evaluación del nivel de relación con los hijos:</asp:TableCell>
                                <asp:TableCell>Muy bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_hijosmuybueno" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_hijosbueno" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Regular</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_hijosregular" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Mala</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_hijosmala" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>¿Por qué?</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3">
                                    <asp:TextBox runat="server" ID="txt_hijosporque" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered table-light text-center table-responsive" runat="server">
                            <asp:TableRow>
                                <asp:TableCell RowSpan="2">Problemas Familiares:</asp:TableCell>
                                <asp:TableCell ColumnSpan="2">Ant. Penales</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_antpenales" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Económicos</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_economicos" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Comunicación</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_comunicacion" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Conyugales</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_conyugales" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Crianza de hijos</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_crianzahijos" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Adiciones</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_adicciones" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Violencia:</asp:TableCell>
                                <asp:TableCell>Física</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_fisica" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Psicológica</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_psicologica" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Verbal</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_verbal" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Sexual</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="5">
                                    <asp:TextBox runat="server" ID="txt_sexual" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered table-light text-center table-responsive" runat="server">
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2" Style="text-align: left">Observaciones:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="10">
                                    <asp:TextBox runat="server" ID="txt_observaciones" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>¿Cada miembro de la familia cumple su Rol?</asp:TableCell>
                                <asp:TableCell>SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_rolsi" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>No</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="8">
                                    <asp:TextBox runat="server" ID="txt_rolno" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Nivel de salud de la familia:</asp:TableCell>
                                <asp:TableCell>Muy bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_saludmuybuena" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_saludbuena" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Regular</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_saludregular" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Mala</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_saludmala" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>¿Por qué?</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                    <asp:TextBox runat="server" ID="txt_saludporque" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Por lo tanto la familia es:</asp:TableCell>
                                <asp:TableCell>Funcional</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_funcional" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Disfuncional</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="7">
                                    <asp:TextBox runat="server" ID="txt_disfuncional" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2" Style="text-align: left">Observaciones:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="10">
                                    <asp:TextBox runat="server" ID="txt_observacion" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="12">Alguna información adicional que la institución deba conocer : (Médica, Familiar , Legal , etc ):</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white" ColumnSpan="12">
                                    <asp:TextBox runat="server" ID="txt_adicional" BorderStyle="None" Style="width: 100%;"></asp:TextBox>
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
                    <div class="card" style="width: 75px">
                        <div class="card-header" style="background-color: aliceblue">
                            Si/No
                        </div>
                        <div class="list-group list-group-flush">
                            <asp:TextBox runat="server" ID="txt_sicertifico" BorderStyle="None" Style="width: 100%; text-align: center; height: 30px"></asp:TextBox>
                        </div>
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
                    <asp:Button CssClass="btn btn-primary" ID="btn_guardarsso" runat="server" Text="Guardar" OnClick="btn_guardarsso_Click" UseSubmitBehavior="False" />
                    <asp:Button CssClass="btn btn-primary" ID="btn_modificarsso" runat="server" Text="Modificar" OnClick="btn_modificarsso_Click" UseSubmitBehavior="False" />
                    <asp:Button CssClass="btn btn-secondary" ID="btn_cancelarsso" runat="server" Text="Cancelar" OnClick="btn_cancelarsso_Click" UseSubmitBehavior="False" />
                </div>
                <br />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
