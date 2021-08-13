<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Views/Principal.Master" AutoEventWireup="true" CodeBehind="SocioEconomico.aspx.cs" Inherits="SistemaECU911.Template.Views.SocioEconomico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="container" style="background-color: white">
                <br />
                <div class="container">
                    <div class="card text-center">
                        <div class="card-header">
                            DIRECCIÓN DE ADMINISTRACIÓN DE RECURSOS HUMANOS                         
                                                GESTIÓN DE BIENESTAR LABORAL Y SALUD OCUPACIONAL
                                                FICHA SOCIOECONÓMICA
                        </div>
                    </div>
                </div>
                <br />
                <div class="list-group list-group-flush">
                    <asp:Table class="table table-bordered table-light" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="text-align: right;">Fecha de Registro:</asp:TableCell>
                            <asp:TableCell Style="width: 100px">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        DATOS GENERALES (MARQUE CON UNA X)
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-left table-responsive" runat="server">
                            <asp:TableRow>
                                <asp:TableCell>Cédula::</asp:TableCell>
                                <asp:TableCell ColumnSpan="10">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:500px;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Nombres y Apellidos:</asp:TableCell>
                                <asp:TableCell ColumnSpan="10">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:500px;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Departamento / Área en la que trabaja</asp:TableCell>
                                <asp:TableCell ColumnSpan="10">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:500px;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Carga Institucional:</asp:TableCell>
                                <asp:TableCell ColumnSpan="10">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:500px;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>

                            <asp:TableRow>
                                <asp:TableCell>Tipo de Contrato:</asp:TableCell>
                                <asp:TableCell>Nombramiento:</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Nombramiento Provisional:</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Contrato Ocasional:</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Código de Trabajo:</asp:TableCell>
                                <asp:TableCell ColumnSpan="3">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Modalidad de Contrato:</asp:TableCell>
                                <asp:TableCell ColumnSpan="3">Ley Orgánica del Sector Público (LOSEP):</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="3">Código de Trabajo:</asp:TableCell>
                                <asp:TableCell ColumnSpan="3">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Fecha de Ingreso al SIS ECU 911:</asp:TableCell>
                                <asp:TableCell>Día/Mes/Año:</asp:TableCell>
                                <asp:TableCell ColumnSpan="9">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Estado Civil:</asp:TableCell>
                                <asp:TableCell>Soltero:</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Casado:</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Viudo:</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Unión Libre:</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Divorciado:</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Género:</asp:TableCell>
                                <asp:TableCell ColumnSpan="3"> 
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="2">Tipo de Sangre:</asp:TableCell>
                                <asp:TableCell ColumnSpan="5">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Teléfono Convencional:</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Teléfono Celular::</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Email:</asp:TableCell>
                                <asp:TableCell ColumnSpan="7">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell RowSpan="2">Nivel Educativo:</asp:TableCell>
                                <asp:TableCell ColumnSpan="2">Primaria</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Secundaria</asp:TableCell>
                                <asp:TableCell ColumnSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; " ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Superior</asp:TableCell>
                                <asp:TableCell ColumnSpan="3">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">Especialización</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Diploma</asp:TableCell>
                                <asp:TableCell ColumnSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; " ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Maestría</asp:TableCell>
                                <asp:TableCell ColumnSpan="3">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell RowSpan="2">Autoidentificación Étnica:</asp:TableCell>
                                <asp:TableCell ColumnSpan="2">Blanco</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Mestizo</asp:TableCell>
                                <asp:TableCell ColumnSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; " ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Afrodescendiente</asp:TableCell>
                                <asp:TableCell ColumnSpan="3">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">Indígena</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="3">Montubio</asp:TableCell>
                                <asp:TableCell ColumnSpan="4">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; " ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Dirección del domicilio:</asp:TableCell>
                                <asp:TableCell>Provincia:</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Cantón:</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Parroquia:</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Barrio:</asp:TableCell>
                                <asp:TableCell ColumnSpan="3">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Calle de la vivienda y numeración:</asp:TableCell>
                                <asp:TableCell ColumnSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Calle Secundaria:</asp:TableCell>
                                <asp:TableCell ColumnSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Referencia para ubicar el domicilio:</asp:TableCell>
                                <asp:TableCell ColumnSpan="4">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Sector donde vive:</asp:TableCell>
                                <asp:TableCell>Norte</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Centro</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; " ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Sur</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Otro (Indique cuál)</asp:TableCell>
                                <asp:TableCell ColumnSpan="3">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Tipo de vivienda que recide:</asp:TableCell>
                                <asp:TableCell>Casa</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Departamento</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; " ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Otro (Indique cuál)</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>¿Cuenta con todos los servicios básicos?</asp:TableCell>
                                <asp:TableCell>SI/NO</asp:TableCell>
                                <asp:TableCell ColumnSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>¿Cuántas personas viven de forma permanente con usted?</asp:TableCell>
                                <asp:TableCell ColumnSpan="3"> 
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="2">¿Cuántas personas viven de forma eventual con usted?</asp:TableCell>
                                <asp:TableCell ColumnSpan="5">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Persona para contactarse en caso de emergencia:</asp:TableCell>
                                <asp:TableCell>Nombres y Apellidos</asp:TableCell>
                                <asp:TableCell ColumnSpan="2"> 
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Parentesco</asp:TableCell>
                                <asp:TableCell ColumnSpan="2"> 
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Teléfono</asp:TableCell>
                                <asp:TableCell ColumnSpan="4"> 
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell RowSpan="2">Dirección del familiar:</asp:TableCell>
                                <asp:TableCell>Calle principal</asp:TableCell>
                                <asp:TableCell ColumnSpan="5"> 
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Nº del domicilio/departamento</asp:TableCell>
                                <asp:TableCell ColumnSpan="5"> 
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Calle secundaria</asp:TableCell>
                                <asp:TableCell ColumnSpan="3"> 
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="2">Referencia para ubicar el domicilio</asp:TableCell>
                                <asp:TableCell ColumnSpan="5"> 
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="4" Style="text-align: center">¿Destina algún dinero para el ahorro?</asp:TableCell>
                                <asp:TableCell>SI</asp:TableCell>
                                <asp:TableCell ColumnSpan="2"> 
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>NO</asp:TableCell>
                                <asp:TableCell ColumnSpan="3"> 
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Vehículo Propio</asp:TableCell>
                                <asp:TableCell>SI/NO</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="2">Usa recorrido institucional</asp:TableCell>
                                <asp:TableCell>SI/NO</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>NO EXISTE</asp:TableCell>
                                <asp:TableCell ColumnSpan="3"> 
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="5">Distancia de su domicilio al trabajo (Indicar el tiempo en minutos)</asp:TableCell>
                                <asp:TableCell ColumnSpan="6">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        SALUD
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-left table-responsive" runat="server">
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="14">¿Posee alguna enfermedad antes de ingresar al SIS ECU 911? ¿Cuál? Detalle por favor:</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>¿Posee alguna discapacidad?</asp:TableCell>
                                <asp:TableCell>SI</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>NO</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="2">Tipo de discapacidad</asp:TableCell>
                                <asp:TableCell ColumnSpan="10">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>¿Cúal es su porcentaje de discapacidad?</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" placeholder="%" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="4">Nº de Carnet otorgado por el MSP o CONADIS :</asp:TableCell>
                                <asp:TableCell ColumnSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="3">Fecha de caducidad del carnét: (día/mes/año)</asp:TableCell>
                                <asp:TableCell ColumnSpan="3">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">¿Se encuentra usted o su cónyuge embarazada?  (adjuntar certificado médico)</asp:TableCell>
                                <asp:TableCell>NO</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="3">Sí, me encuentro embarazada</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="3">Sí, mi conyuge se encuentra embarazada</asp:TableCell>
                                <asp:TableCell ColumnSpan="3">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="8">Por favor indicar en qué mes de gestación se encuentra usted o su cónyuge:</asp:TableCell>
                                <asp:TableCell>Meses</asp:TableCell>
                                <asp:TableCell ColumnSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Días</asp:TableCell>
                                <asp:TableCell ColumnSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="3">Por favor indicar la fecha tentativa de parto :</asp:TableCell>
                                <asp:TableCell ColumnSpan="10">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">¿Se encuentra usted en periodo de lactancia?</asp:TableCell>
                                <asp:TableCell>SI</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>NO</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Fecha de Culminación (día/mes/año)</asp:TableCell>
                                <asp:TableCell ColumnSpan="7">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">¿Posee alguna enfermedad crónica y/o catastrófica diagnostica por el IESS? (adjuntar certificado médico)</asp:TableCell>
                                <asp:TableCell>SI</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>NO</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>¿Cuál?</asp:TableCell>
                                <asp:TableCell ColumnSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Otras enfermedades</asp:TableCell>
                                <asp:TableCell ColumnSpan="3">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="4">¿Posee alguna enfermedad rara? (adjuntar certificado médico)</asp:TableCell>
                                <asp:TableCell>SI</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>NO</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>¿Cuál?</asp:TableCell>
                                <asp:TableCell ColumnSpan="5">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>¿Consume alcohol?</asp:TableCell>
                                <asp:TableCell>SI/NO</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Tipo de licor que prefiere consumir</asp:TableCell>
                                <asp:TableCell>Cerveza</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Ron</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Whisky</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Otro especifíque</asp:TableCell>
                                <asp:TableCell ColumnSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Frecuencia de consumo</asp:TableCell>
                                <asp:TableCell ColumnSpan="6">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Tiempo de consumo</asp:TableCell>
                                <asp:TableCell ColumnSpan="8">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>¿Consume usted tabaco?</asp:TableCell>
                                <asp:TableCell>SI</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>NO</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Frecuencia</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Cantidad</asp:TableCell>
                                <asp:TableCell ColumnSpan="5">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Tiempo de consumo</asp:TableCell>
                                <asp:TableCell ColumnSpan="14">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>¿Consume usted alguna sustancia psicotrópica?</asp:TableCell>
                                <asp:TableCell>SI</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>NO</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Tipo de sustancia:</asp:TableCell>
                                <asp:TableCell>
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Frecuencia de consumo:</asp:TableCell>
                                <asp:TableCell ColumnSpan="5">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="4">Factores psicosociales relacionados con el consumo:</asp:TableCell>
                                <asp:TableCell ColumnSpan="10">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" ></asp:TextBox>
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
