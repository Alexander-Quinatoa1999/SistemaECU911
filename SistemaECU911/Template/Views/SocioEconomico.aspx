<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Views/Principal.Master" AutoEventWireup="true" CodeBehind="SocioEconomico.aspx.cs" Inherits="SistemaECU911.Template.Views.SocioEconomico" %>

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
                                <asp:TextBox runat="server" ID="txt_fecha" BorderStyle="None" style="width:100%;" TextMode="Date"></asp:TextBox>
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
                                <asp:TableCell>Cédula:</asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left" ColumnSpan="10">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:500px;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Nombres y Apellidos:</asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left" ColumnSpan="10">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:500px;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Departamento / Área en la que trabaja:</asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left" ColumnSpan="10">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:500px;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Carga Institucional:</asp:TableCell>
                                <asp:TableCell Style="background-color: white; text-align: left" ColumnSpan="10">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:500px;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>

                            <asp:TableRow>
                                <asp:TableCell>Tipo de Contrato:</asp:TableCell>
                                <asp:TableCell>Nombramiento:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Nombramiento Provisional:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Contrato Ocasional:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Código de Trabajo:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Modalidad de Contrato:</asp:TableCell>
                                <asp:TableCell ColumnSpan="3">Ley Orgánica del Sector Público (LOSEP):</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="3">Código de Trabajo:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Fecha de Ingreso al SIS ECU 911:</asp:TableCell>
                                <asp:TableCell>Día/Mes/Año:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="9">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Estado Civil:</asp:TableCell>
                                <asp:TableCell>Soltero:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Casado:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Viudo:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Unión Libre:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Divorciado:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Género:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3"> 
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="2">Tipo de Sangre:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="5">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Teléfono Convencional:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Teléfono Celular::</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Email:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="7">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell RowSpan="2">Nivel Educativo:</asp:TableCell>
                                <asp:TableCell ColumnSpan="2">Primaria</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Secundaria</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Superior</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">Especialización</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Diploma</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Maestría</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell RowSpan="2">Autoidentificación Étnica:</asp:TableCell>
                                <asp:TableCell ColumnSpan="2">Blanco</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Mestizo</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Afrodescendiente</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">Indígena</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="3">Montubio</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="4">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Dirección del domicilio:</asp:TableCell>
                                <asp:TableCell>Provincia:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Cantón:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Parroquia:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Barrio:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Calle de la vivienda y numeración:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Calle Secundaria:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Referencia para ubicar el domicilio:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="4">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Sector donde vive:</asp:TableCell>
                                <asp:TableCell>Norte</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Centro</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%; " ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Sur</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Otro (Indique cuál)</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Tipo de vivienda que recide:</asp:TableCell>
                                <asp:TableCell>Casa</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Departamento</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%; " ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Otro (Indique cuál)</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>¿Cuenta con todos los servicios básicos?</asp:TableCell>
                                <asp:TableCell>SI/NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>¿Cuántas personas viven de forma permanente con usted?</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3"> 
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="2">¿Cuántas personas viven de forma eventual con usted?</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="5">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Persona para contactarse en caso de emergencia:</asp:TableCell>
                                <asp:TableCell>Nombres y Apellidos</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2"> 
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Parentesco</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2"> 
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Teléfono</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="4"> 
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell RowSpan="2">Dirección del familiar:</asp:TableCell>
                                <asp:TableCell>Calle principal</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="5"> 
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Nº del domicilio/departamento</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="5"> 
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Calle secundaria</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3"> 
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="2">Referencia para ubicar el domicilio</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="5"> 
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="4" Style="text-align: center">¿Destina algún dinero para el ahorro?</asp:TableCell>
                                <asp:TableCell>SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2"> 
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3"> 
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Vehículo Propio</asp:TableCell>
                                <asp:TableCell>SI/NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="2">Usa recorrido institucional</asp:TableCell>
                                <asp:TableCell>SI/NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>NO EXISTE</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3"> 
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="5">Distancia de su domicilio al trabajo (Indicar el tiempo en minutos)</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="6">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
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
                        <asp:Table class="table table-bordered table-light text-center table-responsive" runat="server">
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="14">¿Posee alguna enfermedad antes de ingresar al SIS ECU 911? ¿Cuál? Detalle por favor:</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>¿Posee alguna discapacidad?</asp:TableCell>
                                <asp:TableCell>SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="2">Tipo de discapacidad</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="10">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>¿Cúal es su porcentaje de discapacidad?</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" placeholder="%" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="4">Nº de Carnet otorgado por el MSP o CONADIS :</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="3">Fecha de caducidad del carnét: (día/mes/año)</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">¿Se encuentra usted o su cónyuge embarazada?  (adjuntar certificado médico)</asp:TableCell>
                                <asp:TableCell>NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="3">Sí, me encuentro embarazada</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="3">Sí, mi conyuge se encuentra embarazada</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="8">Por favor indicar en qué mes de gestación se encuentra usted o su cónyuge:</asp:TableCell>
                                <asp:TableCell>Meses</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Días</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="3">Por favor indicar la fecha tentativa de parto :</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="10">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">¿Se encuentra usted en periodo de lactancia?</asp:TableCell>
                                <asp:TableCell>SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Fecha de Culminación (día/mes/año)</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="7">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">¿Posee alguna enfermedad crónica y/o catastrófica diagnostica por el IESS? (adjuntar certificado médico)</asp:TableCell>
                                <asp:TableCell>SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>¿Cuál?</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Otras enfermedades</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="4">¿Posee alguna enfermedad rara? (adjuntar certificado médico)</asp:TableCell>
                                <asp:TableCell>SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>¿Cuál?</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="5">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>¿Consume alcohol?</asp:TableCell>
                                <asp:TableCell>SI/NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Tipo de licor que prefiere consumir</asp:TableCell>
                                <asp:TableCell>Cerveza</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Ron</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Whisky</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Otro especifíque</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Frecuencia de consumo</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="6">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Tiempo de consumo</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="8">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>¿Consume usted tabaco?</asp:TableCell>
                                <asp:TableCell>SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Frecuencia</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Cantidad</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="5">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Tiempo de consumo</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="14">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>¿Consume usted alguna sustancia psicotrópica?</asp:TableCell>
                                <asp:TableCell>SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>NO</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Tipo de sustancia:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Frecuencia de consumo:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="5">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="4">Factores psicosociales relacionados con el consumo:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="10">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
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
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Número de hijos:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="5">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Número de dependientes:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="4">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="6" Style="text-align: center">Apellidos y Nombres</asp:TableCell>
                                <asp:TableCell Style="text-align: center">Fecha de Nacimiento</asp:TableCell>
                                <asp:TableCell ColumnSpan="3" Style="text-align: center">Edad</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white" ColumnSpan="6">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%; text-align:center" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%; text-align:center" placeholder="dd/mm/aa" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%; text-align:center" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">¿Tiene en su núcleo familiar alguna persona con discapacidad?</asp:TableCell>
                                <asp:TableCell>Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>No</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="6">Si su respuesta es sí continúe con la siguiente pregunta</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow Style="text-align: center">
                                <asp:TableCell ColumnSpan="2">¿Se encuentra usted a cargo de esta persona con discapacidad? Calificada por el MSP o CONADIS</asp:TableCell>
                                <asp:TableCell>Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>No</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
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
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%; text-align:center" placeholder="dd/mm/aa" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%; text-align:center" placeholder="dd/mm/aa"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">¿Se encuentra registrada la dependencia del familiar en el Ministerio de Inclusión Económica y Social?</asp:TableCell>
                                <asp:TableCell>Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>No</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Nº Carnet MSP:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">¿Tiene en su núcleo familiar alguna persona que tenga alguna enfermedad catastrófica o rara?</asp:TableCell>
                                <asp:TableCell>Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>No</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Indicar Parentesco:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">¿Se encuentra usted a cargo de esta persona con enfermedad catastrófica o rara?</asp:TableCell>
                                <asp:TableCell>Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>No</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Tipo de enfermedad:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
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
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Paseos familiares</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Actividades artísticas</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Estudios</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Otros</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="7">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Trabajo complementario</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Detalle de la actividad que realiza:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Tiempo que destina a la actividad:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>¿Hace cuánto tiempo realiza la actividad?</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="4">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>¿Realiza alguna actividad deportiva?</asp:TableCell>
                                <asp:TableCell>Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>No</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Si su respuesta es sí especifique la actividad que realiza:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Frecuencia:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>¿Desde qué edad practica ese deporte?</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="4">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%; text-align:center" placeholder="en años"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>¿Ha sufrido alguna lesión?</asp:TableCell>
                                <asp:TableCell>Si</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>No</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Tipo de lesión:</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Edad a la que sufrió la lesión</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%; text-align:center" placeholder=" en años"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>¿Recibió algún tratamiento o rehabilitación?</asp:TableCell>
                                <asp:TableCell>Si/No</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
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
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Ampliada:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Monoparental:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Padre/Madre soltero:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Vive solo:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Vive con amigos:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Familia sin hijos:</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">Evaluación del nivel de relación familiar:</asp:TableCell>
                                <asp:TableCell>Muy bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Regular</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Mala</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>¿Por qué?</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">Evaluación del nivel de relación de pareja:</asp:TableCell>
                                <asp:TableCell>Muy bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Regular</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Mala</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>¿Por qué?</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2">Evaluación del nivel de relación con los hijos:</asp:TableCell>
                                <asp:TableCell>Muy bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Regular</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Mala</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>¿Por qué?</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="3">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered table-light text-center table-responsive" runat="server">
                            <asp:TableRow>
                                <asp:TableCell RowSpan="2">Problemas Familiares:</asp:TableCell>
                                <asp:TableCell ColumnSpan="2">Ant. Penales</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Económicos</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Comunicación</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Conyugales</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Crianza de hijos</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Adiciones</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Violencia:</asp:TableCell>
                                <asp:TableCell>Física</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Psicológica</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Verbal</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Sexual</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="5">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;" ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered table-light text-center table-responsive" runat="server">
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="11" Style="text-align: left">Observaciones:</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>¿Cada miembro de la familia cumple su Rol?</asp:TableCell>
                                <asp:TableCell>SI</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>No</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="7">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Nivel de salud de la familia:</asp:TableCell>
                                <asp:TableCell>Muy bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Bueno</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Regular</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Mala</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>¿Por qué?</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Por lo tanto la familia es:</asp:TableCell>
                                <asp:TableCell>Funcional</asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>Disfuncional</asp:TableCell>
                                <asp:TableCell Style="background-color: white" ColumnSpan="7">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="11" Style="text-align: left">Observaciones:</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="11">Alguna información adicional que la institución deba conocer : (Médica, Familiar , Legal , etc ):</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white" ColumnSpan="11">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%;"  ></asp:TextBox>
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
                            <asp:TextBox runat="server" BorderStyle="None" Style="width: 100%; text-align: center; height: 30px"></asp:TextBox>
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
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
