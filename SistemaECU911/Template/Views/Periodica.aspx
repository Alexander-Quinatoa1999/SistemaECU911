<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Views/Principal.Master" AutoEventWireup="true" CodeBehind="Periodica.aspx.cs" Inherits="SistemaECU911.Template.Views.Periodica" %>

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
                            GESTIÓN DE SEGURIDAD Y SALUD OCUPACIONAL
                        </div>
                        <div>
                            HISTORIA CLÍNICA OCUPACIONAL - PERIÓDICA
                        </div>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        A. DATOS DEL ESTABLECIMIENTO - EMPRESA Y USUARIO
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="INSTITUCIÓN DEL SISTEMA O NOMBRE DE LA EMPRESA"></asp:TableCell>
                                <asp:TableCell Text="RUC"></asp:TableCell>
                                <asp:TableCell Text="CIIU"></asp:TableCell>
                                <asp:TableCell Text="ESTABLECIMIENTO DE SALUD"></asp:TableCell>
                                <asp:TableCell Text="NÚMERO DE HISTORIA CLÍNICA"></asp:TableCell>
                                <asp:TableCell Text="NÚMERO DE ARCHIVO"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center;" Text="Servicio Integrado de Seguridad" ReadOnly="true"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" Text="1768174880001" ReadOnly="true"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" Text="Consultorio Médico" ReadOnly="true"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="txt_numHClinica" OnTextChanged="txt_numHClinica_TextChanged" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" AutoPostBack="true"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered table-light text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="PRIMER APELLIDO" Style="width: 225px"></asp:TableCell>
                                <asp:TableCell Text="SEGUNDO APELLIDO" Style="width: 225px"></asp:TableCell>
                                <asp:TableCell Text="PRIMER NOMBRE" Style="width: 225px"></asp:TableCell>
                                <asp:TableCell Text="SEGUNDO NOMBRE" Style="width: 225px"></asp:TableCell>
                                <asp:TableCell Text="SEXO" Style="width: 100px"></asp:TableCell>
                                <asp:TableCell Text="PUESTO DE TRABAJO (CIUO)" Style="width: 150px"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:TextBox ID="txt_priApellido" runat="server" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox ID="txt_segNombre" runat="server" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox ID="txt_priNombre" runat="server" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox ID="txt_segApellido" runat="server" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox ID="txt_sexo" runat="server" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox ID="txt_puestodetrabajoperiodica" runat="server" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        B. MOTIVO DE CONSULTA 
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:TextBox ID="txt_motivoconsultaperiodica" runat="server" BorderStyle="None" Style="background-color: transparent; width: 100%;" placeholder="Descripción: " TextMode="MultiLine" Rows="3"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        C. ANTECEDENTES PERSONALES
                    </div>
                    <div class="card-header" style="font-size: 14px">
                        ANTECEDENTES CLÍNICOS Y QUIRÚRGICOS
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:TextBox runat="server" ID="txt_antCliQuiDescripcion" BorderStyle="None" Style="width: 100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                    </div>
                    <div class="card" style="width: auto;">
                        <div class="card-header col" style="font-size: 14px">
                            HÁBITOS TÓXICOS 
                        </div>
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell>CONSUMOS NOCIVOS</asp:TableCell>
                            <asp:TableCell Style="width: 5%">SI</asp:TableCell>
                            <asp:TableCell Style="width: 5%">NO</asp:TableCell>
                            <asp:TableCell Style="width: 20%">TIEMPO DE CONSUMO</asp:TableCell>
                            <asp:TableCell>CANTIDAD</asp:TableCell>
                            <asp:TableCell>EX CONSUMIDOR</asp:TableCell>
                            <asp:TableCell Style="width: 20%">TIEMPO DE ABSTINENCIA</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>TABACO</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_siConsuNociTabaHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_noConsuNociTabaHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_tiemConConsuNociTabaHabToxi" TextMode="Number" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_cantiConsuNociTabaHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_exConsumiConsuNociTabaHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_tiemAbstiConsuNociTabaHabToxi" TextMode="Number" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>ALCOHOL</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_siConsuNociAlcoHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_noConsuNociAlcoHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_tiemConConsuNociAlcoHabToxi" TextMode="Number" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_cantiConsuNociAlcoHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_exConsumiConsuNociAlcoHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_tiemAbstiConsuNociAlcoHabToxi" TextMode="Number" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>OTRAS DROGAS</asp:TableCell>
                            <asp:TableCell RowSpan="2">
                                <asp:TextBox runat="server" ID="txt_siConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell RowSpan="2">
                                <asp:TextBox runat="server" ID="txt_noConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_tiemCon1ConsuNociOtrasDroHabToxi" TextMode="Number" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_canti1ConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_exConsumi1ConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_tiemAbsti1ConsuNociOtrasDroHabToxi" TextMode="Number" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_otrasConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_tiemCon2ConsuNociOtrasDroHabToxi" TextMode="Number" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_canti2ConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_exConsumi2ConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_tiemAbsti2ConsuNociOtrasDroHabToxi" TextMode="Number" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <div class="card" style="width: auto;">
                        <div class="card-header" style="font-size: 14px">
                            ESTILO DE VIDA
                        </div>
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell>ESTILO</asp:TableCell>
                            <asp:TableCell Style="width: 5%">SI</asp:TableCell>
                            <asp:TableCell Style="width: 5%">NO</asp:TableCell>
                            <asp:TableCell Style="width: 30%">¿CUÁL?</asp:TableCell>
                            <asp:TableCell Style="width: 20%">TIEMPO/CANTIDAD</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>ACTIVIDAD FÍSICA</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_siEstVidaActFisiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_noEstVidaActFisiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_cualEstVidaActFisiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_tiemCanEstVidaActFisiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell RowSpan="3">MEDICACIÓN HABITUAL</asp:TableCell>
                            <asp:TableCell RowSpan="3">
                                <asp:TextBox runat="server" ID="txt_siEstVidaMedHabiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell RowSpan="3">
                                <asp:TextBox runat="server" ID="txt_noEstVidaMedHabiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_cual1EstVidaMedHabiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_tiemCan1EstVidaMedHabiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_cual2EstVidaMedHabiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_tiemCan2EstVidaMedHabiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_cual3EstVidaMedHabiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_tiemCan3EstVidaMedHabiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <div class="card" style="width: auto;">
                        <div class="card-header" style="font-size: 14px">
                            INCIDENTES
                        </div>
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:TextBox runat="server" ID="txt_incidentesperiodica" BorderStyle="None" Style="width: 100%" TextMode="MultiLine" Rows="3" placeholder="Describir los principales incidentes suscitados"></asp:TextBox>
                    </div>
                    </br>
                    <div class="card" style="width: auto;">
                        <div class="card-header" style="font-size: 14px">
                            ACCIDENTES DE TRABAJO (DESCRIPCIÓN)
                        </div>
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="width: 40%">FUE CALIFICADO POR EL INSTITUTO DE SEGURIDAD SOCIAL CORRESPONDIENTE: </asp:TableCell>
                            <asp:TableCell>SI</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_sicalificadotrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>ESPECIFICAR</asp:TableCell>
                            <asp:TableCell Style="width: 15%">
                                <asp:TextBox runat="server" ID="txt_especificarcalificadotrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>NO</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_nocalificadotrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>FECHA:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_fechacalificadotrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="9">
                                <asp:TextBox ID="txt_obsercalificadotrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%;" placeholder="Observaciones: " runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <div class="card" style="width: auto;">
                        <div class="card-header" style="font-size: 14px">
                            ENFERMEDADES PROFESIONALES 
                        </div>
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="width: 40%">FUE CALIFICADO POR EL INSTITUTO DE SEGURIDAD SOCIAL CORRESPONDIENTE: </asp:TableCell>
                            <asp:TableCell>SI</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_sicalificadoprofesional" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>ESPECIFICAR</asp:TableCell>
                            <asp:TableCell Style="width: 15%">
                                <asp:TextBox runat="server" ID="txt_especificarcalificadoprofesional" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>NO</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_nocalificadoprofesional" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>FECHA:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_fechacalificadoprofesional" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="9">
                                <asp:TextBox ID="txt_obsercalificadoprofesional" BorderStyle="None" Style="background-color: transparent; width: 100%;" placeholder="Observaciones: " runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="row">
                        <div class="card-header col" style="margin-left: 0.8rem">
                            D. ANTECEDENTES FAMILIARES (DETALLAR EL PARENTESCO)                                          
                        </div>
                        <div class="card-header col" style="text-align: right; font-size: 13px; margin-right: 0.8rem">
                            DESCRIBIR ABAJO ANOTANDO EL NÚMERO                                        
                        </div>
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="width: 20%">1. ENFERMEDAD CARDIO-VASCULAR</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_enfermedadcardiovascular" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 20%">2. ENFERMEDAD METABÓLICA</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_enfermedadmetabolica" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 20%">3. ENFERMEDAD NEUROLÓGICA</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_enfermedadneurologica" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 20%">4. ENFERMEDAD ONCOLÓGICA</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_enfermedadoncologica" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="width: 20%">5. ENFERMEDAD INFECCIOSA</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_enfermedadinfecciosa" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 20%">6. ENFERMEDAD HEREDITARIA/CONGÉNITA</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_enfermedadhereditaria" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 20%">7. DISCAPACIDADES</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_discapacidades" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 20%">8. OTROS</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_otrosenfer" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="8">
                                <asp:TextBox ID="txt_descripcionantefamiliares" BorderStyle="None" Style="background-color: transparent; width: 100%;" runat="server" placeholder="Descripción: "></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        E.  FACTORES DE RIESGOS DEL PUESTO DE TRABAJO                                         
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="width: 20%" RowSpan="2" ColumnSpan="2">PUESTO DE TRABAJO / ÁREA</asp:TableCell>
                            <asp:TableCell Style="width: 20%" RowSpan="2">ACTIVIDADES</asp:TableCell>
                            <asp:TableCell Style="width: 20%" RowSpan="2">TIEMPO DE TRABAJO (MESES)</asp:TableCell>
                            <asp:TableCell Style="width: 15%" ColumnSpan="10">FÍSICO</asp:TableCell>
                            <asp:TableCell Style="width: 15%" ColumnSpan="15">MECÁNICO</asp:TableCell>
                            <asp:TableCell Style="width: 15%" ColumnSpan="9">QUÍMICO</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label9" runat="server" Text="Temperaturas altas"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label10" runat="server" Text="Temperaturas bajas"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label25" runat="server" Text="Radiación Ionizante"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label26" runat="server" Text="Radiación No Ionizante"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label27" runat="server" Text="Ruido"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label28" runat="server" Text="Vibración"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label29" runat="server" Text="Iluminación"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label30" runat="server" Text="Ventilación"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label31" runat="server" Text="Fluido eléctrico"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label32" runat="server" Text="Otros __________"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label33" runat="server" Text="Atrapamiento entre máquinas"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label34" runat="server" Text="Atrapamiento entre superficies"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label35" runat="server" Text="Atrapamiento entre objetos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label36" runat="server" Text="Caída de objetos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label37" runat="server" Text="Caídas al mismo nivel"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label38" runat="server" Text="Caídas a diferente nivel"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label39" runat="server" Text="Contacto eléctrico"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label40" runat="server" Text="Contacto con superficies de trabajos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label41" runat="server" Text="Proyección de partículas – fragmentos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label42" runat="server" Text="Proyección de fluidos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label43" runat="server" Text="Pinchazos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label44" runat="server" Text="Cortes"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label45" runat="server" Text="Atropellamientos por vehículos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label46" runat="server" Text="Choques /colisión vehicular"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label47" runat="server" Text="Otros __________"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label48" runat="server" Text="Sólidos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label49" runat="server" Text="Polvos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label50" runat="server" Text="Humos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label51" runat="server" Text="Líquidos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label52" runat="server" Text="Vapores"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label53" runat="server" Text="Aerosoles"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label54" runat="server" Text="Neblinas"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label55" runat="server" Text="Gaseosos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label56" runat="server" Text="Otros __________"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>1. </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_puestotrabajoperiodica" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_act" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_tiempotrabajo" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_tempaltas" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_tempbajas" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_radiacion" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_noradiacion" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_ruido" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_vibracion" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_iluminacion" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_ventilacion" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_fluidoelectrico" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_otros1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_atrapmaquinas" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_atrapsuperficie" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_atrapobjetos" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_caidaobjetos" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_caidamisnivel" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_caidadifnivel" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_contaelectrico" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_contasuptrabajo" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_proyparticulas" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_proyefluidos" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_pinchazos" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_cortes" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_atroporvehiculos" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_choques" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_otros2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_solidos" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_polvos" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_humos" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_liquidos" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_vapores" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_aerosoles" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_neblinas" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_gaseosos" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_otros3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="width: 20%" RowSpan="2" ColumnSpan="2">PUESTO DE TRABAJO / ÁREA</asp:TableCell>
                            <asp:TableCell Style="width: 20%" RowSpan="2">ACTIVIDADES</asp:TableCell>
                            <asp:TableCell Style="width: 20%" RowSpan="2">TIEMPO DE TRABAJO (MESES)</asp:TableCell>
                            <asp:TableCell Style="width: 15%" ColumnSpan="7">BIÓLOGO</asp:TableCell>
                            <asp:TableCell Style="width: 15%" ColumnSpan="5">ERGONÓMICO</asp:TableCell>
                            <asp:TableCell Style="width: 15%" ColumnSpan="13">PSICOSOCIAL</asp:TableCell>
                            <asp:TableCell Style="width: 25%" RowSpan="2">MEDIDAS PREVENTIVAS</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label57" runat="server" Text="Virus"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label58" runat="server" Text="Hongos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label59" runat="server" Text="Bacterias "></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label60" runat="server" Text="Parásitos "></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label61" runat="server" Text="Exposición a vectores"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label62" runat="server" Text="Exposición a animales selváticos "></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label63" runat="server" Text="Otros __________"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label64" runat="server" Text="Manejo manual de cargas"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label65" runat="server" Text="Movimiento repetitivos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label66" runat="server" Text="Posturas forzadas"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label67" runat="server" Text="Trabajos con PVD"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label68" runat="server" Text="Otros __________"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label69" runat="server" Text="Monotonía del trabajo "></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label70" runat="server" Text="Sobrecarga laboral"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label71" runat="server" Text="Minuciosidad de la tarea "></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label72" runat="server" Text="Alta responsabilidad"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label73" runat="server" Text="Autonomía  en la toma de decisiones"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label74" runat="server" Text="Supervisión y estilos de dirección deficiente"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label75" runat="server" Text="Conflicto de rol"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label76" runat="server" Text="Falta de Claridad en las funciones"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label77" runat="server" Text="Incorrecta distribución del trabajo"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label78" runat="server" Text="Turnos rotativos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label79" runat="server" Text="Relaciones interpersonales"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label80" runat="server" Text="Inestabilidad laboral"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label81" runat="server" Text="Otros __________"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>1. </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="TextBox1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="TextBox2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="TextBox3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_virus" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_hongos" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_bacterias" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_parasitos" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_expoavectores" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_expoanimselvaticos" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_otros4" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_manmanualcargas" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_movrepetitivo" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_postforzadas" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_trabajopvd" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_otros5" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_montrabajo" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_sobrecargalaboral" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_minustarea" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_altarespon" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_automadesiciones" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_supyestdireficiente" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_conflictorol" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_faltaclarfunciones" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_incorrdistrabajo" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_turnorotat" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_relacinterpersonales" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_inestalaboral" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_otros6" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_medpreventivas" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        F. ENFERMEDAD ACTUAL 
                    </div>
                    <div class="list-group list-group-flush">
                       <asp:TextBox ID="txt_enfermedadactualperiodica" runat="server" BorderStyle="None" Style="background-color: transparent; width: 100%;" placeholder="Descripción: " TextMode="MultiLine" Rows="3"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="row">
                        <div class="card-header col" style="margin-left: 0.8rem">
                            G. REVISIÓN DE ÓRGANOS Y SISTEMAS                                          
                        </div>
                        <div class="card-header col" style="text-align: right; font-size: 11px; margin-right: 0.8rem">
                            EN CASO DE EXISTIR PATOLOGÍA  MARCAR CON "X"  Y DESCRIBIR ABAJO COLOCANDO EL NUMERAL                                         
                        </div>
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="width: 15%">1. PIEL - ANEXOS</asp:TableCell>
                            <asp:TableCell>
                                 <asp:TextBox runat="server" ID="txt_pielanexos" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 15%">3. RESPIRATORIO</asp:TableCell>
                            <asp:TableCell>
                                 <asp:TextBox runat="server" ID="txt_respiratorio" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 15%">5. DIGESTIVO</asp:TableCell>
                            <asp:TableCell>
                                 <asp:TextBox runat="server" ID="txt_digestivo" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 15%">7. MÚSCULO ESQUELÉTICO</asp:TableCell>
                            <asp:TableCell>
                                 <asp:TextBox runat="server" ID="txt_musculosesqueleticos" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 15%">9. HEMO LINFÁTICO</asp:TableCell>
                            <asp:TableCell>
                                 <asp:TextBox runat="server" ID="txt_hemolinfatico" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="width: 15%">2. ÓRGANOS DE LOS SENTIDOS</asp:TableCell>
                            <asp:TableCell>
                                 <asp:TextBox runat="server" ID="txt_organossentidos" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 15%">4. CARDIO-VASCULAR</asp:TableCell>
                            <asp:TableCell>
                                 <asp:TextBox runat="server" ID="txt_cardiovascular" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 15%">6. GENITO - URINARIO</asp:TableCell>
                            <asp:TableCell>
                                 <asp:TextBox runat="server" ID="txt_genitourinario" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 15%">8. ENDOCRINO</asp:TableCell>
                            <asp:TableCell>
                                 <asp:TextBox runat="server" ID="txt_endocrino" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 15%">10. NERVIOSO</asp:TableCell>
                            <asp:TableCell>
                                 <asp:TextBox runat="server" ID="txt_nervioso" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="10">
                                <asp:TextBox ID="txt_descrorganosysistemasperiodica" BorderStyle="None" Style="background-color: transparent; width: 100%;" runat="server" placeholder="Descripción: "></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        H. CONSTANTES VITALES Y ANTROPOMETRÍA 
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="PRESIÓN ARTERIAL (mmHg)"></asp:TableCell>
                                <asp:TableCell Text="TEMPERATURA (°C)"></asp:TableCell>
                                <asp:TableCell Text="FRECUENCIA CARDIACA (Lat/min)"></asp:TableCell>
                                <asp:TableCell Text="SATURACIÓN DE OXÍGENO (O2%)"></asp:TableCell>
                                <asp:TableCell Text="FRECUENCIA RESPIRATORIA (fr/min)"></asp:TableCell>
                                <asp:TableCell Text="PESO (Kg)"></asp:TableCell>
                                <asp:TableCell Text="TALLA (cm)"></asp:TableCell>
                                <asp:TableCell Text="ÍNDICE DE MASA CORPORAL (kg/m2)"></asp:TableCell>
                                <asp:TableCell Text="PERÍMETRO ABDOMINAL(cm)"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        I. EXAMEN FÍSICO REGIONAL
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="REGIONES" Style="width: 100%; text-align: left" ColumnSpan="15"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell RowSpan="3">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label11" runat="server" Text="1. Piel"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. Cicatrices</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_cicatrices" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="3">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label12" runat="server" Text="3. Oído"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. C. auditivo externo</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_auditivoexterno" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="4">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label13" runat="server" Text="5. Nariz"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. Tabique</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_tabique" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label14" runat="server" Text="8. Tórax"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. Pulmones</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_pulmones" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label15" runat="server" Text="11. Pelvis"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. Pelvis</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_pelvis" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT">b. Tatuajes</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                      <asp:TextBox runat="server" ID="txt_tatuajes" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">b. Pabellón</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_pabellon" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">b. Cornetes</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX"> 
                                     <asp:TextBox runat="server" ID="txt_cornetes" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">b. Parrilla Costal</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_parrillacostal" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">b. Genitales</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_genitales" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT">c. Piel  y Faneras</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_pielyfaneras" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">c. Tímpanos</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_timpanos" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">c. Mucosas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_mucosa" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label16" runat="server" Text="9. Abdomen"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. Vísceras</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_visceras" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="3">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label17" runat="server" Text="12. Extremidades"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. Vascular</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_vascular" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell RowSpan="5">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label18" runat="server" Text="2. Ojos"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. Párpados</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_parpados" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="5">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label19" runat="server" Text="4. Oro faringe"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. Labios</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_labios" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">d. Senos paranasales</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_senosparanasales" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">b. Pared abdominal</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_paredabdominal" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">b. Miembros superiores</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_miembrosuperiores" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT">b. Conjuntivas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_conjuntivas" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">b. Lengua</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_lengua" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label20" runat="server" Text="6. Cuello"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. Tiroides / masas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_tiroides" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="4">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label21" runat="server" Text="10. Columna"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. Flexibilidad</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_flexibilidad" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">c. Miembros inferiores</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_miembrosinferiores" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT">c. Pupilas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_pupilas" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">c. Faringe</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_faringe" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">b. Movilidad</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_movilidad" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" RowSpan="2">b. Desviación</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" RowSpan="2">
                                     <asp:TextBox runat="server" ID="txt_desviacion" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="4">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label22" runat="server" Text="13. Neurológico"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. Fuerza</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_fuerza" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT">d. Córnea</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_cornea" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">d. Amígdalas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_amigdalas" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label23" runat="server" Text="7. Tórax"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. Mamas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_mamas" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">b. Sensibilidad</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_sensibilidad" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT">e. Motilidad</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_motilidad" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">e. Dentadura</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_dentadura" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">b. Corazón</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_corazon" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">c. Dolor</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_dolor" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">c. Marcha</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_marcha" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="text-align: left" ColumnSpan="12">SI EXISTE EVIDENCIA DE PATOLOGÍA MARCAR CON "X" Y DESCRIBIR EN LA SIGUIENTE SECCIÓN COLOCANDO EL NUMERAL</asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">d. Reflejos</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_reflejos" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="15">
                                    <asp:TextBox ID="txt_obervexamenfisicoregional" BorderStyle="None" Style="background-color: transparent; width: 100%;" runat="server" placeholder="Observaciones: "></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        J. RESULTADOS DE EXÁMENES GENERALES Y ESPECÍFICOS DE ACUERDO AL RIESGO Y PUESTO DE TRABAJO (IMAGEN, LABORATORIO Y OTROS)
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="width: 400px">EXAMEN </asp:TableCell>
                                <asp:TableCell Style="width: 150px">FECHA</asp:TableCell>
                                <asp:TableCell Style="width: 800px">RESULTADO</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" Id="txt_examen" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" Id="txt_fechaexamen" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_resultadoexamen" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="3">
                                        <asp:TextBox runat="server" ID="txt_observacionexamen" BorderStyle="None" style="background-color:transparent; width:100%;" placeholder="Observaciones:"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        K. DIAGNÓSTICO  
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="width: 800px; text-align: end" ColumnSpan="2">PRE= PRESUNTIVO          DEF= DEFINITIVO</asp:TableCell>
                                <asp:TableCell Style="width: 200px">CIE</asp:TableCell>
                                <asp:TableCell Style="width: 75px">PRE</asp:TableCell>
                                <asp:TableCell Style="width: 75px">DEF</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="width: 30px" Text="1"></asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_descripdiagnostico" BorderStyle="None" style="background-color:transparent; width:100%;" placeholder="Descripción"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_cie" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_pre" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_def" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        L. APTITUD MÉDICA PARA EL TRABAJO  
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="width: 250px">APTO</asp:TableCell>
                                <asp:TableCell Style="width: 50px">
                                     <asp:TextBox runat="server" ID="txt_apto" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 175px">APTO EN OBSERVACIÓN</asp:TableCell>
                                <asp:TableCell Style="width: 75px">
                                     <asp:TextBox runat="server" ID="txt_aptoobservacion" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 175px">APTO CON LIMITACIONES</asp:TableCell>
                                <asp:TableCell Style="width: 60px">
                                     <asp:TextBox runat="server" ID="txt_aptolimitacion" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 175px">NO APTO</asp:TableCell>
                                <asp:TableCell Style="width: 75px">
                                     <asp:TextBox runat="server" ID="txt_noapto" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Observación</asp:TableCell>
                                <asp:TableCell ColumnSpan="7">
                                     <asp:TextBox runat="server" ID="txt_observacionaptitud" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Limitación</asp:TableCell>
                                <asp:TableCell ColumnSpan="7">
                                     <asp:TextBox runat="server" ID="txt_limitacionaptitud" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        M. RECOMENDACIONES Y/O TRATAMIENTO
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:TextBox ID="txt_descripciontratamientoperiodica" BorderStyle="None" Style="background-color: transparent; width: 100%;" runat="server" placeholder="Descripción:" TextMode="MultiLine" Rows="3"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="container">
                    <p align="center">
                        <strong>"CERTIFICO QUE LO ANTERIORMENTE EXPRESADO EN RELACIÓN A MI ESTADO DE SALUD ES VERDAD. SE ME HA INFORMADO LAS MEDIDAS PREVENTIVAS 
                                           A TOMAR PARA DISMINUIR O MITIGAR LOS RIESGOS RELACIONADOS CON MI ACTIVIDAD LABORAL."</strong>
                    </p>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        N. DATOS DEL PROFESIONAL DE SALUD
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="width: 60px">FECHA Y HORA</asp:TableCell>
                                <asp:TableCell Style="width: 150px">
                                    <asp:TextBox runat="server" BorderStyle="None" ID="txt_fechaDatProf" TextMode="DateTimeLocal" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 100px">NOMBRES Y APELLIDOS</asp:TableCell>
                                <asp:TableCell Style="width: 300px">
                                    <asp:DropDownList ID="ddl_profesional" CssClass="form-check" Style="width: 100%; border: none; background-color:transparent" runat="server"></asp:DropDownList>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 75px">CÓDIGO</asp:TableCell>
                                <asp:TableCell Style="width: 125px">
                                    <asp:TextBox runat="server" BorderStyle="None" ID="txt_codigoDatProf" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 100px">FIRMA Y SELLO</asp:TableCell>
                                <asp:TableCell Style="width: 175px">
                                     <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div align="center">
                    <div class="card" style="width: 400px">

                        <div class="card-header">
                            O. FIRMA DEL USUARIO    
                        </div>
                        <div class="list-group list-group-flush">
                            <asp:Label ID="Label24" runat="server" Text="" Style="height: 80px"></asp:Label>
                        </div>
                    </div>
                </div>
                <br />
                <div class="container" align="center">
                    <asp:Button CssClass="btn btn-primary" ID="btn_guardarperiodica" runat="server" Text="Guardar" OnClick="btn_guardarperiodica_Click" UseSubmitBehavior="False" />
                    <asp:Button CssClass="btn btn-primary" ID="btn_modificarperiodica" runat="server" Text="Modificar" OnClick="btn_modificarperiodica_Click" UseSubmitBehavior="False" />
                    <asp:Button CssClass="btn btn-secondary" ID="btn_cancelarperiodica" runat="server" Text="Cancelar" OnClick="btn_cancelarperiodica_Click" UseSubmitBehavior="False" />
                </div>
                <br />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
