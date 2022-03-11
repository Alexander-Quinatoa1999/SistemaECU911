<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Views/Principal.Master" AutoEventWireup="true" CodeBehind="Retiro.aspx.cs" Inherits="SistemaECU911.Template.Views.Retiro" %>

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
                        <div class="card-header" style="font-size: 25px; background-color: #34495E; color: white">
                            GESTIÓN DE SEGURIDAD Y SALUD OCUPACIONAL
                        </div>
                        <div style="font-size: 25px; background-color: #34495E; color: white">
                            HISTORIA CLÍNICA OCUPACIONAL - RETIRO
                        </div>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" style="background-color: #34495E; color: white; font-size:16px">
                        A. DATOS DEL ESTABLECIMIENTO - EMPRESA Y USUARIO
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="INSTITUCIÓN DEL SISTEMA O NOMBRE DE LA EMPRESA" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                                <asp:TableCell Text="RUC" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                                <asp:TableCell Text="CIIU" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                                <asp:TableCell Text="ESTABLECIMIENTO DE SALUD" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                                <asp:TableCell Text="NÚMERO DE HISTORIA CLÍNICA" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                                <asp:TableCell Text="NÚMERO DE ARCHIVO" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" Text="Sistema Integrado de Seguridad Sis Ecu 911" ReadOnly="true"></asp:TextBox>
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
                                        <asp:TextBox runat="server" ID="txt_numHClinica" OnTextChanged="txt_numHClinica_TextChanged" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" AutoPostBack="true"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="PRIMER APELLIDO" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                                <asp:TableCell Text="SEGUNDO APELLIDO" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                                <asp:TableCell Text="PRIMER NOMBRE" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                                <asp:TableCell Text="SEGUNDO NOMBRE" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                                <asp:TableCell Text="SEXO" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                                <asp:TableCell Text="FECHA DE INICIO DE LABORES" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                                <asp:TableCell Text="FECHA DE SALIDA" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                                <asp:TableCell Text="TIEMPO (meses)" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                                <asp:TableCell Text="PUESTO DE TRABAJO (CIUO)" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_priApellido" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_segApellido" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_priNombre" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_segNombre" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_sexo" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_fechaIniLabores" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_fechaSalida" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_tiempo" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_puestoTrabajo" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="ACTIVIDADES" Style="width: 600px; background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                                <asp:TableCell Text="FACTORES DE RIESGO" Style="width: 700px; background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_actividades1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_facRiesgo1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                        <asp:TextBox runat="server"  BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
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
                    <div class="card-header" style="background-color: #34495E; color: white; font-size:16px">
                        B. ANTECEDENTES PERSONALES
                    </div>
                    <div class="card-header" style="background-color: #34495E; color: white; font-size:16px">
                        ANTECEDENTES CLÍNICOS Y QUIRÚRGICOS
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:TextBox runat="server" ID="txt_descripcionantiqui" BorderStyle="None" Style="width: 100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                    </div>
                    <div class="card" style="width: auto;">
                        <div class="card-header" style="background-color: #34495E; color: white; font-size:16px">
                            ACCIDENTES DE TRABAJO (DESCRIPCIÓN)
                        </div>
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="width: 45%; background-color: #34495E; color: white; font-size:16px">FUE CALIFICADO POR EL INSTITUTO DE SEGURIDAD SOCIAL CORRESPONDIENTE: </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">SI</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_siCalificadoIESSAcciTrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">ESPECIFICAR</asp:TableCell>
                            <asp:TableCell Style="width: 15%">
                                <asp:TextBox runat="server" ID="txt_EspecifiCalificadoIESSAcciTrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">NO</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_noCalificadoIESSAcciTrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">FECHA:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_fechaCalificadoIESSAcciTrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="9">
                                <asp:TextBox ID="txt_observacionesAcciTrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%;" placeholder="Observaciones: " runat="server" TextMode="MultiLine" Rows="3"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="9" Style="text-align: left">Detallar aquí en caso se presuma de algún accidente de trabajo que no haya sido reportado o calificado:</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="9">
                                <asp:TextBox ID="txt_detalleAcciTrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%;" runat="server" TextMode="MultiLine" Rows="2"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <div class="card" style="width: auto;">
                        <div class="card-header" style="background-color: #34495E; color: white; font-size:16px">
                            ENFERMEDADES PROFESIONALES 
                        </div>
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="width: 45%; background-color: #34495E; color: white; font-size:16px">FUE CALIFICADO POR EL INSTITUTO DE SEGURIDAD SOCIAL CORRESPONDIENTE: </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">SI</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_siCalificadoIESSEnferProfesionales" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">ESPECIFICAR</asp:TableCell>
                            <asp:TableCell Style="width: 15%">
                                <asp:TextBox runat="server" ID="txt_EspecifiCalificadoIESSEnferProfesionales" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">NO</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_noCalificadoIESSEnferProfesionales" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">FECHA:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" ID="txt_fechaCalificadoIESSEnferProfesionales" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="9">
                                <asp:TextBox ID="txt_observacionesEnferProfesionales" BorderStyle="None" Style="background-color: transparent; width: 100%;" placeholder="Observaciones: " runat="server" TextMode="MultiLine" Rows="3"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="9" Style="text-align: left">Detallar aquí en caso de que se presuma de alguna enfermedad relacionada con el trabajo que no haya sido reportada o calificada: </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="9">
                                <asp:TextBox ID="txt_detalleEnferProfesionales" BorderStyle="None" Style="background-color: transparent; width: 100%;" runat="server" TextMode="MultiLine" Rows="2"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" style="background-color: #34495E; color: white; font-size:16px">
                        C. CONSTANTES VITALES Y ANTROPOMETRÍA
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="PRESIÓN ARTERIAL (mmHg)" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                                <asp:TableCell Text="TEMPERATURA (°C)" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                                <asp:TableCell Text="FRECUENCIA CARDIACA (l/min)" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                                <asp:TableCell Text="SATURACIÓN DE OXÍGENO (%)" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                                <asp:TableCell Text="FRECUENCIA RESPIRATORIA (fr/min)" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                                <asp:TableCell Text="PESO (Kg)" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                                <asp:TableCell Text="TALLA (cm)" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                                <asp:TableCell Text="ÍNDICE DE MASA CORPORAL (kg/m2)" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                                <asp:TableCell Text="PERÍMETRO ABDOMINAL (cm)" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
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
                    <div class="card-header" style="background-color: #34495E; color: white; font-size:16px">
                        D. EXAMEN FÍSICO REGIONAL
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="REGIONES" Style="width: 100%; text-align: left; background-color: #34495E; color: white; font-size:16px" ColumnSpan="15"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell RowSpan="3" style="background-color: #34495E; color: white; font-size:16px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label11" runat="server" Text="1. Piel"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">a. Cicatrices</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_cicatrices" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="3" style="background-color: #34495E; color: white; font-size:16px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label12" runat="server" Text="3. Oído"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">a. C. auditivo externo</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_auditivoexterno" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="4" style="background-color: #34495E; color: white; font-size:16px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label13" runat="server" Text="5. Nariz"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">a. Tabique</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_tabique" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2" style="background-color: #34495E; color: white; font-size:16px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label14" runat="server" Text="8. Tórax"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">a. Pulmones</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_pulmones" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2" style="background-color: #34495E; color: white; font-size:16px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label15" runat="server" Text="11. Pelvis"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">a. Pelvis</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_pelvis" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">b. Tatuajes</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                      <asp:TextBox runat="server" ID="txt_tatuajes" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">b. Pabellón</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_pabellon" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">b. Cornetes</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX"> 
                                     <asp:TextBox runat="server" ID="txt_cornetes" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">b. Parrilla Costal</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_parrillacostal" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">b. Genitales</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_genitales" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">c. Piel  y Faneras</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_pielyfaneras" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">c. Tímpanos</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_timpanos" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">c. Mucosas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_mucosa" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2" style="background-color: #34495E; color: white; font-size:16px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label16" runat="server" Text="9. Abdomen"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">a. Vísceras</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_visceras" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="3" style="background-color: #34495E; color: white; font-size:16px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label17" runat="server" Text="12. Extremidades"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">a. Vascular</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_vascular" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell RowSpan="5" style="background-color: #34495E; color: white; font-size:16px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label18" runat="server" Text="2. Ojos"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">a. Párpados</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_parpados" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="5" style="background-color: #34495E; color: white; font-size:16px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label19" runat="server" Text="4. Oro faringe"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">a. Labios</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_labios" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">d. Senos paranasales</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_senosparanasales" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">b. Pared abdominal</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_paredabdominal" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">b. Miembros superiores</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_miembrosuperiores" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">b. Conjuntivas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_conjuntivas" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">b. Lengua</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_lengua" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2" style="background-color: #34495E; color: white; font-size:16px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label20" runat="server" Text="6. Cuello"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">a. Tiroides / masas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_tiroides" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="4" style="background-color: #34495E; color: white; font-size:16px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label21" runat="server" Text="10. Columna"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">a. Flexibilidad</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_flexibilidad" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">c. Miembros inferiores</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_miembrosinferiores" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">c. Pupilas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_pupilas" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">c. Faringe</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_faringe" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">b. Movilidad</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_movilidad" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" RowSpan="2" style="background-color: #34495E; color: white; font-size:16px">b. Desviación</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" RowSpan="2">
                                     <asp:TextBox runat="server" ID="txt_desviacion" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="4">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label22" runat="server" Text="13. Neurológico"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">a. Fuerza</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_fuerza" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">d. Córnea</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_cornea" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">d. Amígdalas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_amigdalas" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2" style="background-color: #34495E; color: white; font-size:16px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label23" runat="server" Text="7. Tórax"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">a. Mamas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_mamas" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">b. Sensibilidad</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_sensibilidad" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">e. Motilidad</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_motilidad" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">e. Dentadura</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_dentadura" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">b. Corazón</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_corazon" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">c. Dolor</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_dolor" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">c. Marcha</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                     <asp:TextBox runat="server" ID="txt_marcha" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="text-align: left" ColumnSpan="12">CON EVIDENCIA DE PATOLOGÍA MARCAR CON "X" Y DESCRIBIR EN LA SIGUIENTE SECCIÓN ANOTANDO EL NUMERAL</asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">d. Reflejos</asp:TableCell>
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
                        E. RESULTADOS DE EXÁMENES GENERALES Y ESPECÍFICOS DE ACUERDO AL RIESGO Y PUESTO DE TRABAJO (IMAGEN, LABORATORIO Y OTROS)
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="width: 400px; background-color: #34495E; color: white; font-size:16px">EXAMEN </asp:TableCell>
                                <asp:TableCell Style="width: 150px; background-color: #34495E; color: white; font-size:16px">FECHA</asp:TableCell>
                                <asp:TableCell Style="width: 800px; background-color: #34495E; color: white; font-size:16px">RESULTADO</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" Id="txt_examen" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" Id="txt_fechaexamen" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" Id="txt_resultadoexamen" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="3">
                                     <asp:TextBox runat="server" Id="txt_observacionexamen" BorderStyle="None" style="background-color:transparent; width:100%;" placeholder="Observaciones:"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" style="background-color: #34495E; color: white; font-size:16px">
                        F. DIAGNÓSTICO
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="width: 30px; background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                                <asp:TableCell Style="width: 800px; text-align: end; background-color: #34495E; color: white; font-size:16px">PRE= PRESUNTIVO          DEF= DEFINITIVO</asp:TableCell>
                                <asp:TableCell Style="width: 200px; background-color: #34495E; color: white; font-size:16px">CIE</asp:TableCell>
                                <asp:TableCell Style="width: 75px; background-color: #34495E; color: white; font-size:16px">PRE</asp:TableCell>
                                <asp:TableCell Style="width: 75px; background-color: #34495E; color: white; font-size:16px">DEF</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="width: 30px" Text="1"></asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_descripdiagnostico" BorderStyle="None" style="background-color:transparent; width:100%;" placeholder="Descrpción"></asp:TextBox>
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
                    <div class="card-header" style="background-color: #34495E; color: white; font-size:16px">
                        G. EVALUACIÓN MÉDICA DE RETIRO
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="width: 800px; text-align: left; background-color: #34495E; color: white; font-size:16px">SE REALIZÓ LA EVALUACIÓN</asp:TableCell>
                                <asp:TableCell Style="width: 100px; text-align: center; background-color: #34495E; color: white; font-size:16px">SI</asp:TableCell>
                                <asp:TableCell Style="width: 100px">
                                    <asp:TextBox runat="server" ID="txt_sievamed" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 100px; background-color: #34495E; color: white; font-size:16px">NO</asp:TableCell>
                                <asp:TableCell Style="width: 100px">
                                    <asp:TextBox runat="server" ID="txt_noevamed" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="5">
                                     <asp:TextBox runat="server" Id="txt_obserevamed" BorderStyle="None" style="background-color:transparent; width:100%;" placeholder="Observaciones:"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" style="background-color: #34495E; color: white; font-size:16px">
                        H. RECOMENDACIONES Y/O TRATAMIENTO
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:TextBox ID="txt_descripciontratamientoretiro" BorderStyle="None" Style="background-color: transparent; width: 100%;" runat="server" placeholder="Descripción:" TextMode="MultiLine" Rows="3"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="container">
                    <p align="center">
                        <strong>"CERTIFICO QUE LO ANTERIORMENTE EXPRESADO EN RELACIÓN A MI ESTADO DE SALUD ES VERDAD. SE ME HA INFORMADO MI ESTADO ACTUAL DE 
                                                SALUD Y LAS RECOMENDACIONES PERTINENTES."</strong>
                    </p>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" style="background-color: #34495E; color: white; font-size:16px">
                        I. DATOS DEL PROFESIONAL
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="width: 60px; background-color: #34495E; color: white; font-size:16px">FECHA Y HORA</asp:TableCell>
                                <asp:TableCell Style="width: 150px">
                                    <asp:TextBox runat="server" BorderStyle="None" ID="txt_fechaDatProf" TextMode="DateTimeLocal" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 100px; background-color: #34495E; color: white; font-size:16px">NOMBRES Y APELLIDOS</asp:TableCell>
                                <asp:TableCell Style="width: 300px">
                                    <asp:DropDownList ID="ddl_profesional" CssClass="form-check" Style="width: 100%; border: none; background-color:transparent" runat="server"></asp:DropDownList>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 75px; background-color: #34495E; color: white; font-size:16px">CÓDIGO</asp:TableCell>
                                <asp:TableCell Style="width: 125px">
                                    <asp:TextBox runat="server" BorderStyle="None" ID="txt_codigoDatProf" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 100px; background-color: #34495E; color: white; font-size:16px">FIRMA Y SELLO</asp:TableCell>
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
                        <div class="card-header" align="center" style="background-color: #34495E; color: white; font-size:16px">
                            J. FIRMA DEL USUARIO
                        </div>
                        <div class="list-group list-group-flush">
                            <asp:Label ID="Label24" runat="server" Text="" Style="height: 80px"></asp:Label>
                        </div>
                    </div>
                </div>
                <br />
                <div class="container" align="center">
                    <asp:Button CssClass="btn btn-warning" ID="btn_guardarretiro" runat="server" Text="Guardar" OnClick="btn_guardarretiro_Click" UseSubmitBehavior="False" />
                    <asp:Button CssClass="btn btn-success" ID="btn_modificaretiro" runat="server" Text="Modificar" OnClick="btn_modificaretiro_Click" UseSubmitBehavior="False" />
                    <asp:Button CssClass="btn btn-danger" ID="btn_cancelaretiro" runat="server" Text="Cancelar" OnClick="btn_cancelaretiro_Click" UseSubmitBehavior="False" />
                </div>
                <br />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
