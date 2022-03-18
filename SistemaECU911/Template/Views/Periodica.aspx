<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Views/Principal.Master" AutoEventWireup="true" CodeBehind="Periodica.aspx.cs" Inherits="SistemaECU911.Template.Views.Periodica" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="container" style="background-color: white; font-family:Arial">
                <br />
                <div class="container">
                    <div class="text-center" style="font-size: 25px">
                        GESTIÓN DE SEGURIDAD Y SALUD OCUPACIONAL<br />
                            HISTORIA CLÍNICA OCUPACIONAL - PERIÓDICA                        
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" style="background-color: #cccdfe; font-size: 15px; font-weight:bold">
                        A. DATOS DEL ESTABLECIMIENTO - EMPRESA Y USUARIO
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="INSTITUCIÓN DEL SISTEMA O NOMBRE DE LA EMPRESA" Style="width: 350px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="RUC" Style="width: 120px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="CIIU" Style="width: 120px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="ESTABLECIMIENTO DE SALUD" Style="width: 250px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="NÚMERO DE HISTORIA CLÍNICA" Style="width: 200px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="NÚMERO DE ARCHIVO" Style="width: 200px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
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
                                <asp:TableCell Text="PRIMER APELLIDO" Style="width: 250px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="SEGUNDO APELLIDO" Style="width: 250px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="PRIMER NOMBRE" Style="width: 250px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="SEGUNDO NOMBRE" Style="width: 250px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="SEXO" Style="width: 50px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="PUESTO DE TRABAJO (CIUO)" Style="width: 250px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
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
                    <div class="card-header" style="background-color: #cccdfe; font-size: 15px; font-weight:bold">
                        B. MOTIVO DE CONSULTA 
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:TextBox ID="txt_motivoconsultaperiodica" runat="server" BorderStyle="None" Style="background-color: transparent; width: 100%;" placeholder="Descripción: " TextMode="MultiLine" Rows="3"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" style="background-color: #cccdfe; font-size: 15px; font-weight:bold">
                        C. ANTECEDENTES PERSONALES
                    </div>
                    <div class="card-header" style="background-color: #cdfecc; font-size: 15px">
                        ANTECEDENTES CLÍNICOS Y QUIRÚRGICOS
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:TextBox runat="server" ID="txt_antCliQuiDescripcion" BorderStyle="None" Style="width: 100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                    </div>
                    <div class="card" style="width: auto;">
                        <div class="card-header col" style="background-color: #cdfecc; font-size: 15px">
                            HÁBITOS TÓXICOS 
                        </div>
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="width: 300px; background-color: #ccffff; font-size: 15px">CONSUMOS NOCIVOS</asp:TableCell>
                            <asp:TableCell Style="width: 75px; background-color: #ccffff; font-size: 15px">SI</asp:TableCell>
                            <asp:TableCell Style="width: 75px; background-color: #ccffff; font-size: 15px">NO</asp:TableCell>
                            <asp:TableCell Style="width: 200px; background-color: #ccffff; font-size: 15px">TIEMPO DE CONSUMO</asp:TableCell>
                            <asp:TableCell Style="width: 250px; background-color: #ccffff; font-size: 15px">CANTIDAD</asp:TableCell>
                            <asp:TableCell Style="width: 200px; background-color: #ccffff; font-size: 15px">EX CONSUMIDOR</asp:TableCell>
                            <asp:TableCell Style="width: 200px; background-color: #ccffff; font-size: 15px">TIEMPO DE ABSTINENCIA</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: white; font-size: 15px">TABACO</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_siConsuNociTabaHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_noConsuNociTabaHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_tiemConConsuNociTabaHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_cantiConsuNociTabaHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_exConsumiConsuNociTabaHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_tiemAbstiConsuNociTabaHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: white; font-size: 15px">ALCOHOL</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_siConsuNociAlcoHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_noConsuNociAlcoHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_tiemConConsuNociAlcoHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_cantiConsuNociAlcoHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_exConsumiConsuNociAlcoHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_tiemAbstiConsuNociAlcoHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: white; font-size: 15px">OTRAS DROGAS</asp:TableCell>
                            <asp:TableCell RowSpan="2">
                                <asp:TextBox runat="server" ID="txt_siConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell RowSpan="2">
                                <asp:TextBox runat="server" ID="txt_noConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_tiemCon1ConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_canti1ConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_exConsumi1ConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_tiemAbsti1ConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_otrasConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_tiemCon2ConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_canti2ConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_exConsumi2ConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_tiemAbsti2ConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <div class="card" style="width: auto;">
                        <div class="card-header" style="background-color: #cdfecc; font-size: 15px">
                            ESTILO DE VIDA
                        </div>
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="width: 300px; background-color: #ccffff; font-size: 15px">ESTILO</asp:TableCell>
                            <asp:TableCell Style="width: 75px; background-color: #ccffff; font-size: 15px">SI</asp:TableCell>
                            <asp:TableCell Style="width: 75px; background-color: #ccffff; font-size: 15px">NO</asp:TableCell>
                            <asp:TableCell Style="width: 550px; background-color: #ccffff; font-size: 15px">¿CUÁL?</asp:TableCell>
                            <asp:TableCell Style="width: 300px; background-color: #ccffff; font-size: 15px">TIEMPO/CANTIDAD</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: white; font-size: 15px">ACTIVIDAD FÍSICA</asp:TableCell>
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
                            <asp:TableCell RowSpan="3" Style="background-color: white; font-size: 15px">MEDICACIÓN HABITUAL</asp:TableCell>
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
                        <div class="card-header" style="background-color: #cdfecc; font-size: 15px">
                            INCIDENTES
                        </div>
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:TextBox runat="server" ID="txt_incidentesperiodica" BorderStyle="None" Style="width: 100%" TextMode="MultiLine" Rows="3" placeholder="Describir los principales incidentes suscitados"></asp:TextBox>
                    </div>
                    </br>
                    <div class="card" style="width: auto;">
                        <div class="card-header" style="background-color: #cdfecc; font-size: 15px">
                            ACCIDENTES DE TRABAJO (DESCRIPCIÓN)
                        </div>
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="width: 600px; background-color: white; font-size: 15px">FUE CALIFICADO POR EL INSTITUTO DE SEGURIDAD SOCIAL CORRESPONDIENTE: </asp:TableCell>
                            <asp:TableCell Style="width: 50px; background-color: white; font-size: 15px">SI</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_sicalificadotrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 100px; background-color: white; font-size: 15px">ESPECIFICAR</asp:TableCell>
                            <asp:TableCell Style="width: 15%">
                                <asp:TextBox runat="server" ID="txt_especificarcalificadotrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 50px; background-color: white; font-size: 15px">NO</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_nocalificadotrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 75px; background-color: white; font-size: 15px">FECHA:</asp:TableCell>
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
                        <div class="card-header" style="background-color: #cdfecc; font-size: 15px">
                            ENFERMEDADES PROFESIONALES 
                        </div>
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="width: 600px; background-color: white; font-size: 15px">FUE CALIFICADO POR EL INSTITUTO DE SEGURIDAD SOCIAL CORRESPONDIENTE: </asp:TableCell>
                            <asp:TableCell Style="width: 50px; background-color: white; font-size: 15px">SI</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_sicalificadoprofesional" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 100px; background-color: white; font-size: 15px">ESPECIFICAR</asp:TableCell>
                            <asp:TableCell Style="width: 15%">
                                <asp:TextBox runat="server" ID="txt_especificarcalificadoprofesional" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 50px; background-color: white; font-size: 15px">NO</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_nocalificadoprofesional" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 75px; background-color: white; font-size: 15px">FECHA:</asp:TableCell>
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
                        <div class="card-header col" style="margin-left: 0.8rem; background-color: #cccdfe; font-size: 15px; font-weight:bold">
                            D. ANTECEDENTES FAMILIARES (DETALLAR EL PARENTESCO)                                          
                        </div>
                        <div class="card-header col" style="text-align: right; margin-right: 0.8rem; background-color: #cccdfe; font-size: 13px">
                            DESCRIBIR ABAJO ANOTANDO EL NÚMERO                                        
                        </div>
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="width: 250px; background-color: #cdfecc; font-size: 15px">1. ENFERMEDAD CARDIO-VASCULAR</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_enfermedadcardiovascular" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 250px; background-color: #cdfecc; font-size: 15px">2. ENFERMEDAD METABÓLICA</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_enfermedadmetabolica" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 250px; background-color: #cdfecc; font-size: 15px">3. ENFERMEDAD NEUROLÓGICA</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_enfermedadneurologica" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 250px; background-color: #cdfecc; font-size: 15px">4. ENFERMEDAD ONCOLÓGICA</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_enfermedadoncologica" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="width: 250px; background-color: #cdfecc; font-size: 15px">5. ENFERMEDAD INFECCIOSA</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_enfermedadinfecciosa" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 250px; background-color: #cdfecc; font-size: 15px">6. ENFERMEDAD HEREDITARIA/CONGÉNITA</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_enfermedadhereditaria" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 250px; background-color: #cdfecc; font-size: 15px">7. DISCAPACIDADES</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_discapacidades" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 250px; background-color: #cdfecc; font-size: 15px">8. OTROS</asp:TableCell>
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
                    <div class="card-header" style="background-color: #cccdfe; font-size: 15px; font-weight:bold">
                        E.  FACTORES DE RIESGOS DEL PUESTO DE TRABAJO                                         
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="width: 200px; background-color: #cdfecc; font-size: 15px" RowSpan="2" ColumnSpan="2">PUESTO DE TRABAJO / ÁREA</asp:TableCell>
                            <asp:TableCell Style="width: 200px; background-color: #cdfecc; font-size: 15px" RowSpan="2">ACTIVIDADES</asp:TableCell>
                            <asp:TableCell Style="width: 200px; background-color: #cdfecc; font-size: 15px" RowSpan="2">TIEMPO DE TRABAJO (MESES)</asp:TableCell>
                            <asp:TableCell Style="width: 250px; background-color: #cdfecc; font-size: 15px" ColumnSpan="10">FÍSICO</asp:TableCell>
                            <asp:TableCell Style="width: 400px; background-color: #cdfecc; font-size: 15px" ColumnSpan="15">MECÁNICO</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label9" runat="server" Text="Temperaturas altas"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label10" runat="server" Text="Temperaturas bajas"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label25" runat="server" Text="Radiación Ionizante"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label26" runat="server" Text="Radiación No Ionizante"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label27" runat="server" Text="Ruido"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label28" runat="server" Text="Vibración"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label29" runat="server" Text="Iluminación"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label30" runat="server" Text="Ventilación"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label31" runat="server" Text="Fluido eléctrico"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label32" runat="server" Text="Otros __________"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label33" runat="server" Text="Atrapamiento entre máquinas"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label34" runat="server" Text="Atrapamiento entre superficies"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label35" runat="server" Text="Atrapamiento entre objetos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label36" runat="server" Text="Caída de objetos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label37" runat="server" Text="Caídas al mismo nivel"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label38" runat="server" Text="Caídas a diferente nivel"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label39" runat="server" Text="Contacto eléctrico"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label40" runat="server" Text="Contacto con superficies de trabajos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label41" runat="server" Text="Proyección de partículas – fragmentos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label42" runat="server" Text="Proyección de fluidos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label43" runat="server" Text="Pinchazos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label44" runat="server" Text="Cortes"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label45" runat="server" Text="Atropellamientos por vehículos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label46" runat="server" Text="Choques /colisión vehicular"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label47" runat="server" Text="Otros __________"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>1. </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_puestotrabajoperiodica" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_act" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_tiempotrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_tempaltas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_tempbajas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_radiacion" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_noradiacion" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_ruido" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_vibracion" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_iluminacion" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_ventilacion" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_fluidoelectrico" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_otros1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_atrapmaquinas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_atrapsuperficie" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_atrapobjetos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_caidaobjetos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_caidamisnivel" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_caidadifnivel" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_contaelectrico" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_contasuptrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_proyparticulas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_proyefluidos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_pinchazos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_cortes" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_atroporvehiculos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_choques" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_otros2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>

                        </asp:TableRow>
                    </asp:Table>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="width: 200px; background-color: #cdfecc; font-size: 15px" RowSpan="2" ColumnSpan="2">PUESTO DE TRABAJO / ÁREA</asp:TableCell>
                            <asp:TableCell Style="width: 200px; background-color: #cdfecc; font-size: 15px" RowSpan="2">ACTIVIDADES</asp:TableCell>
                            <asp:TableCell Style="width: 200px; background-color: #cdfecc; font-size: 15px" RowSpan="2">TIEMPO DE TRABAJO (MESES)</asp:TableCell>
                            <asp:TableCell Style="width: 250px; background-color: #cdfecc; font-size: 15px" ColumnSpan="9">QUÍMICO</asp:TableCell>
                            <asp:TableCell Style="width: 200px; background-color: #cdfecc; font-size: 15px" ColumnSpan="7">BIÓLOGO</asp:TableCell>
                            <asp:TableCell Style="width: 250px; background-color: #cdfecc;  font-size: 15px" ColumnSpan="5">ERGONÓMICO</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label48" runat="server" Text="Sólidos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label49" runat="server" Text="Polvos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label50" runat="server" Text="Humos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label51" runat="server" Text="Líquidos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label52" runat="server" Text="Vapores"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label53" runat="server" Text="Aerosoles"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label54" runat="server" Text="Neblinas"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label55" runat="server" Text="Gaseosos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label56" runat="server" Text="Otros __________"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label57" runat="server" Text="Virus"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label58" runat="server" Text="Hongos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label59" runat="server" Text="Bacterias "></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label60" runat="server" Text="Parásitos "></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label61" runat="server" Text="Exposición a vectores"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label62" runat="server" Text="Exposición a animales selváticos "></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label63" runat="server" Text="Otros __________"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label64" runat="server" Text="Manejo manual de cargas"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label65" runat="server" Text="Movimiento repetitivos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label66" runat="server" Text="Posturas forzadas"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label67" runat="server" Text="Trabajos con PVD"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label68" runat="server" Text="Otros __________"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>1. </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="TextBox1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="TextBox2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="TextBox3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_solidos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_polvos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_humos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_liquidos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_vapores" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_aerosoles" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_neblinas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_gaseosos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_otros3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_virus" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_hongos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_bacterias" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_parasitos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_expoavectores" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_expoanimselvaticos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_otros4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_manmanualcargas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_movrepetitivo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_postforzadas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_trabajopvd" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_otros5" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>

                        </asp:TableRow>
                    </asp:Table>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="width: 150px; background-color: #cdfecc; font-size: 15px" ColumnSpan="13">PSICOSOCIAL</asp:TableCell>
                            <asp:TableCell Style="width: 500px; background-color: #cdfecc; font-size: 15px" RowSpan="2">MEDIDAS PREVENTIVAS</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label69" runat="server" Text="Monotonía del trabajo "></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label70" runat="server" Text="Sobrecarga laboral"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label71" runat="server" Text="Minuciosidad de la tarea "></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label72" runat="server" Text="Alta responsabilidad"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label73" runat="server" Text="Autonomía  en la toma de decisiones"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label74" runat="server" Text="Supervisión y estilos de dirección deficiente"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label75" runat="server" Text="Conflicto de rol"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label76" runat="server" Text="Falta de Claridad en las funciones"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label77" runat="server" Text="Incorrecta distribución del trabajo"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label78" runat="server" Text="Turnos rotativos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label79" runat="server" Text="Relaciones interpersonales"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label80" runat="server" Text="Inestabilidad laboral"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label81" runat="server" Text="Otros __________"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_montrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_sobrecargalaboral" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_minustarea" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_altarespon" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_automadesiciones" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_supyestdireficiente" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_conflictorol" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_faltaclarfunciones" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_incorrdistrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_turnorotat" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_relacinterpersonales" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_inestalaboral" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_otros6" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_medpreventivas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" Style="background-color: #cccdfe; font-size: 15px; font-weight:bold">
                        F. ENFERMEDAD ACTUAL 
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:TextBox ID="txt_enfermedadactualperiodica" runat="server" BorderStyle="None" Style="background-color: transparent; width: 100%;" placeholder="Descripción: " TextMode="MultiLine" Rows="3"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="row">
                        <div class="card-header col" style="margin-left: 0.8rem; background-color: #cccdfe; font-size: 15px; font-weight:bold">
                            G. REVISIÓN DE ÓRGANOS Y SISTEMAS                                          
                        </div>
                        <div class="card-header col text-center" style="text-align: right; margin-right: 0.8rem; background-color: #cccdfe; font-size: 13px">
                            EN CASO DE EXISTIR PATOLOGÍA  MARCAR CON "X"  Y DESCRIBIR ABAJO COLOCANDO EL NUMERAL                                         
                        </div>
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="width: 200px; background-color: #ccffff; font-size: 15px">1. PIEL - ANEXOS</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_pielanexos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 200px; background-color: #ccffff; font-size: 15px">3. RESPIRATORIO</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_respiratorio" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 200px; background-color: #ccffff; font-size: 15px">5. DIGESTIVO</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_digestivo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 200px; background-color: #ccffff; font-size: 15px">7. MÚSCULO ESQUELÉTICO</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_musculosesqueleticos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 200px; background-color: #ccffff; font-size: 15px">9. HEMO LINFÁTICO</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_hemolinfatico" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="width: 200px; background-color: #ccffff; font-size: 15px">2. ÓRGANOS DE LOS SENTIDOS</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_organossentidos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 200px; background-color: #ccffff; font-size: 15px">4. CARDIO-VASCULAR</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_cardiovascular" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 200px; background-color: #ccffff; font-size: 15px">6. GENITO - URINARIO</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_genitourinario" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 200px; background-color: #ccffff; font-size: 15px">8. ENDOCRINO</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_endocrino" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 200px; background-color: #ccffff; font-size: 15px">10. NERVIOSO</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_nervioso" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
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
                    <div class="card-header" Style="background-color: #cccdfe; font-size: 15px; font-weight:bold">
                        H. CONSTANTES VITALES Y ANTROPOMETRÍA 
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="PRESIÓN ARTERIAL (mmHg)" Style="width: 175px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="TEMPERATURA (°C)" Style="width: 175px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="FRECUENCIA CARDIACA (Lat/min)" Style="width: 175px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="SATURACIÓN DE OXÍGENO (O2%)" Style="width: 175px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="FRECUENCIA RESPIRATORIA (fr/min)" Style="width: 175px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="PESO (Kg)" Style="width: 175px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="TALLA (cm)" Style="width: 175px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="ÍNDICE DE MASA CORPORAL (kg/m2)" Style="width: 175px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="PERÍMETRO ABDOMINAL(cm)" Style="width: 175px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
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
                    <div class="card-header" Style="background-color: #cccdfe; font-size: 15px; font-weight:bold">
                        I. EXAMEN FÍSICO REGIONAL
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="REGIONES" Style="width: 100%; background-color: #cdfecc; font-size: 15px; text-align: left" ColumnSpan="15"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell RowSpan="3" Style="background-color: #ccffff; font-size: 15px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label11" runat="server" Text="1. Piel"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">a. Cicatrices</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_cicatrices" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="3" Style="background-color: #ccffff; font-size: 15px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label12" runat="server" Text="3. Oído"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">a. C. auditivo externo</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_auditivoexterno" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="4" Style="background-color: #ccffff; font-size: 15px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label13" runat="server" Text="5. Nariz"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">a. Tabique</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_tabique" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2" Style="background-color: #ccffff; font-size: 15px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label14" runat="server" Text="8. Tórax"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">a. Pulmones</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_pulmones" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2" Style="background-color: #ccffff; font-size: 15px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label15" runat="server" Text="11. Pelvis"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">a. Pelvis</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_pelvis" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">b. Tatuajes</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_tatuajes" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">b. Pabellón</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_pabellon" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">b. Cornetes</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_cornetes" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">b. Parrilla Costal</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_parrillacostal" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">b. Genitales</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_genitales" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff;  font-size: 15px">c. Piel  y Faneras</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_pielyfaneras" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">c. Tímpanos</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_timpanos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">c. Mucosas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_mucosa" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2" Style="background-color: #ccffff; font-size: 15px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label16" runat="server" Text="9. Abdomen"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">a. Vísceras</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_visceras" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="3" Style="background-color: #ccffff; font-size: 15px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label17" runat="server" Text="12. Extremidades"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">a. Vascular</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_vascular" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell RowSpan="5" Style="background-color: #ccffff; font-size: 15px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label18" runat="server" Text="2. Ojos"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">a. Párpados</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_parpados" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="5" Style="background-color: #ccffff; font-size: 15px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label19" runat="server" Text="4. Oro faringe"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">a. Labios</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_labios" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">d. Senos paranasales</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_senosparanasales" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">b. Pared abdominal</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_paredabdominal" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">b. Miembros superiores</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_miembrosuperiores" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">b. Conjuntivas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_conjuntivas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">b. Lengua</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_lengua" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2" Style="background-color: #ccffff; font-size: 15px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label20" runat="server" Text="6. Cuello"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">a. Tiroides / masas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_tiroides" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="4" Style="background-color: #ccffff; font-size: 15px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label21" runat="server" Text="10. Columna"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">a. Flexibilidad</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_flexibilidad" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">c. Miembros inferiores</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_miembrosinferiores" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">c. Pupilas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_pupilas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">c. Faringe</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_faringe" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">b. Movilidad</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_movilidad" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" RowSpan="2" Style="background-color: #ccffff; font-size: 15px">b. Desviación</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" RowSpan="2">
                                    <asp:TextBox runat="server" ID="txt_desviacion" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="4" Style="background-color: #ccffff; font-size: 15px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label22" runat="server" Text="13. Neurológico"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">a. Fuerza</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_fuerza" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">d. Córnea</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_cornea" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">d. Amígdalas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_amigdalas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2" Style="background-color: #ccffff; font-size: 15px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label23" runat="server" Text="7. Tórax"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">a. Mamas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_mamas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">b. Sensibilidad</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_sensibilidad" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">e. Motilidad</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_motilidad" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">e. Dentadura</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_dentadura" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">b. Corazón</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_corazon" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">c. Dolor</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_dolor" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">c. Marcha</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_marcha" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="12" Style="text-align: left; background-color: white; font-size: 15px">SI EXISTE EVIDENCIA DE PATOLOGÍA MARCAR CON "X" Y DESCRIBIR EN LA SIGUIENTE SECCIÓN COLOCANDO EL NUMERAL</asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" Style="background-color: #ccffff; font-size: 15px">d. Reflejos</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_reflejos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
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
                    <div class="card-header" Style="background-color: #cccdfe; font-size: 15px; font-weight:bold">
                        J. RESULTADOS DE EXÁMENES GENERALES Y ESPECÍFICOS DE ACUERDO AL RIESGO Y PUESTO DE TRABAJO (IMAGEN, LABORATORIO Y OTROS)
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="width: 400px; background-color: #cdfecc; font-size: 15px">EXAMEN </asp:TableCell>
                                <asp:TableCell Style="width: 150px; background-color: #cdfecc; font-size: 15px">FECHA</asp:TableCell>
                                <asp:TableCell Style="width: 800px; background-color: #cdfecc; font-size: 15px">RESULTADO</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="txt_examen" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="txt_fechaexamen" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="txt_resultadoexamen" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="3">
                                    <asp:TextBox runat="server" ID="txt_observacionexamen" BorderStyle="None" Style="background-color: transparent; width: 100%;" placeholder="Observaciones:"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" Style="background-color: #cccdfe; font-size: 15px; font-weight:bold">
                        K. DIAGNÓSTICO  
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="width: 950px; text-align: end; background-color: #cccdfe; font-size: 15px" ColumnSpan="2">PRE= PRESUNTIVO          DEF= DEFINITIVO</asp:TableCell>
                                <asp:TableCell Style="width: 200px; background-color: #cccdfe; font-size: 15px">CIE</asp:TableCell>
                                <asp:TableCell Style="width: 75px; background-color: #cccdfe; font-size: 15px">PRE</asp:TableCell>
                                <asp:TableCell Style="width: 75px; background-color: #cccdfe; font-size: 15px">DEF</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="width: 50px; background-color: #cdfecc; font-size: 15px" Text="1"></asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="txt_descripdiagnostico" BorderStyle="None" Style="background-color: transparent; width: 100%;" placeholder="Descripción"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="txt_cie" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="txt_pre" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="txt_def" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" Style="background-color: #cccdfe; font-size: 15px; font-weight:bold">
                        L. APTITUD MÉDICA PARA EL TRABAJO  
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="width: 250px; background-color: #cdfecc; font-size: 15px">APTO</asp:TableCell>
                                <asp:TableCell Style="width: 50px">
                                    <asp:TextBox runat="server" ID="txt_apto" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 175px; background-color: #cdfecc; font-size: 15px">APTO EN OBSERVACIÓN</asp:TableCell>
                                <asp:TableCell Style="width: 75px">
                                    <asp:TextBox runat="server" ID="txt_aptoobservacion" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 175px; background-color: #cdfecc; font-size: 15px">APTO CON LIMITACIONES</asp:TableCell>
                                <asp:TableCell Style="width: 60px">
                                    <asp:TextBox runat="server" ID="txt_aptolimitacion" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 175px; background-color: #cdfecc; font-size: 15px">NO APTO</asp:TableCell>
                                <asp:TableCell Style="width: 75px">
                                    <asp:TextBox runat="server" ID="txt_noapto" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #ccffff; font-size: 15px">Observación</asp:TableCell>
                                <asp:TableCell ColumnSpan="7">
                                    <asp:TextBox runat="server" ID="txt_observacionaptitud" BorderStyle="None" Style="background-color: transparent; width: 100%"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #ccffff; font-size: 15px">Limitación</asp:TableCell>
                                <asp:TableCell ColumnSpan="7">
                                    <asp:TextBox runat="server" ID="txt_limitacionaptitud" BorderStyle="None" Style="background-color: transparent; width: 100%"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" Style="background-color: #cccdfe; font-size: 15px; font-weight:bold">
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
                    <div class="card-header" Style="background-color: #cccdfe; font-size: 15px; font-weight:bold">
                        N. DATOS DEL PROFESIONAL DE SALUD
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="width: 60px; background-color: #cdfecc; font-size: 15px">FECHA Y HORA</asp:TableCell>
                                <asp:TableCell Style="width: 150px">
                                    <asp:TextBox runat="server" BorderStyle="None" ID="txt_fechaDatProf" TextMode="DateTimeLocal" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 100px; background-color: #cdfecc; font-size: 15px">NOMBRES Y APELLIDOS</asp:TableCell>
                                <asp:TableCell Style="width: 300px">
                                    <asp:DropDownList ID="ddl_profesional" CssClass="form-check" Style="width: 100%; border: none; background-color: transparent" runat="server"></asp:DropDownList>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 75px; background-color: #cdfecc; font-size: 15px">CÓDIGO</asp:TableCell>
                                <asp:TableCell Style="width: 125px">
                                    <asp:TextBox runat="server" BorderStyle="None" ID="txt_codigoDatProf" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 100px; background-color: #cdfecc; font-size: 15px">FIRMA Y SELLO</asp:TableCell>
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
                        <div class="card-header" style="background-color: #cccdfe; font-size: 15px; font-weight:bold">
                            O. FIRMA DEL USUARIO    
                        </div>
                        <div class="list-group list-group-flush">
                            <asp:Label ID="Label24" runat="server" Text="" Style="height: 80px"></asp:Label>
                        </div>
                    </div>
                </div>
                <br />
                <div class="container" align="center">
                    <asp:Button CssClass="btn btn-warning" ID="btn_guardarperiodica" runat="server" Text="Guardar" OnClick="btn_guardarperiodica_Click" UseSubmitBehavior="False" />
                    <asp:Button CssClass="btn btn-success" ID="btn_modificarperiodica" runat="server" Text="Modificar" OnClick="btn_modificarperiodica_Click" UseSubmitBehavior="False" />
                    <asp:Button CssClass="btn btn-danger" ID="btn_cancelarperiodica" runat="server" Text="Cancelar" OnClick="btn_cancelarperiodica_Click" UseSubmitBehavior="False" />
                </div>
                <br />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
