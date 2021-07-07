<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Views/Principal.Master" AutoEventWireup="true" CodeBehind="Retiro.aspx.cs" Inherits="SistemaECU911.Template.Views.Retiro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="container" style="background-color: white">
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
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="PRIMER APELLIDO"></asp:TableCell>
                                <asp:TableCell Text="SEGUNDO APELLIDO"></asp:TableCell>
                                <asp:TableCell Text="PRIMER NOMBRE"></asp:TableCell>
                                <asp:TableCell Text="SEGUNDO NOMBRE"></asp:TableCell>
                                <asp:TableCell Text="SEXO"></asp:TableCell>
                                <asp:TableCell Text="FECHA DE INICIO DE LABORES "></asp:TableCell>
                                <asp:TableCell Text="FECHA DE SALIDA"></asp:TableCell>
                                <asp:TableCell Text="TIEMPO (meses)"></asp:TableCell>
                                <asp:TableCell Text="PUESTO DE TRABAJO (CIUO)"></asp:TableCell>
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
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="ACTIVIDADES" Style="width: 600px"></asp:TableCell>
                                <asp:TableCell Text="FACTORES DE RIESGO" Style="width: 700px"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
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
                        B. ANTECEDENTES PERSONALES
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="ANTECEDENTES CLÍNICOS Y QUIRÚRGICOS" Style="width: 1150px; text-align: left" ColumnSpan="5"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="5">
                                                            <textarea id="" cols="20" rows="3" style="border: none; width:100%; background-color:transparent"></textarea>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="ACCIDENTES DE TRABAJO ( DESCRIPCIÓN)" Style="width: 1150px; text-align: left" ColumnSpan="5"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="FUE CALIFICADO POR EL INSTITUTO DE SEGURIDAD SOCIAL CORRESPONDIENTE:" Style="width: 500px"></asp:TableCell>
                                <asp:TableCell Style="width: 50px">
                                    <asp:Label ID="Label2" runat="server" Text="SI" Style="background-color: transparent"></asp:Label>
                                    <asp:CheckBox ID="CheckBox1" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="width: 250px">
                                    <asp:Label ID="Label1" runat="server" Text="ESPECIFICAR:" Style="background-color: transparent"></asp:Label>
                                    <asp:TextBox runat="server" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="_____________________________"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 50px">
                                    <asp:Label ID="Label3" runat="server" Text="NO" Style="background-color: transparent"></asp:Label>
                                    <asp:CheckBox ID="CheckBox3" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="width: 150px">
                                    <asp:Label ID="Label4" runat="server" Text="FECHA:" Style="background-color: transparent"></asp:Label>
                                    <asp:TextBox runat="server" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="5">
                                                            <textarea id="" cols="20" rows="3" style="border: none; width:100%; background-color:transparent" placeholder="Observaciones:"></textarea>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Detallar aquí en caso de que se presuma de alguna enfermedad relacionada con el trabajo que no haya 
                                                            sido reportada o calificada:
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="4">
                                                            <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:left"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>

                            <asp:TableRow>
                                <asp:TableCell Text="ENFERMEDADES PROFESIONALES" Style="width: auto; text-align: left" ColumnSpan="5"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="FUE CALIFICADO POR EL INSTITUTO DE SEGURIDAD SOCIAL CORRESPONDIENTE:" Style="width: 400px"></asp:TableCell>
                                <asp:TableCell Style="width: 50px">
                                    <asp:Label ID="Label5" runat="server" Text="SI" Style="background-color: transparent; width: 100%; text-align: center"></asp:Label>
                                    <asp:CheckBox ID="CheckBox2" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="width: 250px">
                                    <asp:Label ID="Label6" runat="server" Text="ESPECIFICAR:" Style="background-color: transparent"></asp:Label>
                                    <asp:TextBox runat="server" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="_____________________________"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 50px">
                                    <asp:Label ID="Label7" runat="server" Text="NO" Style="background-color: transparent; width: 100%; text-align: center"></asp:Label>
                                    <asp:CheckBox ID="CheckBox4" runat="server" />
                                </asp:TableCell>
                                <asp:TableCell Style="width: 150px">
                                    <asp:Label ID="Label8" runat="server" Text="FECHA:" Style="background-color: transparent; width: 100%; text-align: center"></asp:Label>
                                    <asp:TextBox runat="server" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="5">
                                                            <textarea id="" cols="20" rows="3" style="border: none; width:100%; background-color:transparent" placeholder="Observaciones:"></textarea>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Detallar aquí en caso de que se presuma de alguna enfermedad relacionada con el trabajo que no haya 
                                                            sido reportada o calificada: 
                                </asp:TableCell>
                                <asp:TableCell ColumnSpan="4">
                                                            <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:left"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        C. CONSTANTES VITALES Y ANTROPOMETRÍA
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="PRESIÓN ARTERIAL (mmHg)"></asp:TableCell>
                                <asp:TableCell Text="TEMPERATURA (°C)"></asp:TableCell>
                                <asp:TableCell Text="FRECUENCIA CARDIACA (l/min)"></asp:TableCell>
                                <asp:TableCell Text="SATURACIÓN DE OXÍGENO (%)"></asp:TableCell>
                                <asp:TableCell Text="FRECUENCIA RESPIRATORIA (fr/min)"></asp:TableCell>
                                <asp:TableCell Text="PESO (Kg)"></asp:TableCell>
                                <asp:TableCell Text="TALLA (cm)"></asp:TableCell>
                                <asp:TableCell Text="ÍNDICE DE MASA CORPORAL (kg/m2)"></asp:TableCell>
                                <asp:TableCell Text="PERÍMETRO ABDOMINAL (cm)"></asp:TableCell>
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
                        D. EXAMEN FÍSICO REGIONAL
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="ACCIDENTES DE TRABAJO ( DESCRIPCIÓN)" Style="width: 100%; text-align: left" ColumnSpan="15"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell RowSpan="3">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label9" runat="server" Text="1. Piel"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. Cicatrices</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="3">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label10" runat="server" Text="3. Oído"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. C. auditivo externo</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="4">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label11" runat="server" Text="5. Nariz"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. Tabique</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label12" runat="server" Text="8. Tórax"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. Pulmones</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label13" runat="server" Text="11. Pelvis"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. Pelvis</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT">b. Tatuajes</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">b. Pabellón</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">b. Cornetes</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX"> 
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">b. Parrilla Costal</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">b. Genitales</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT">c. Piel  y Faneras</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">c. Tímpanos</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">c. Mucosas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label14" runat="server" Text="9. Abdomen"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. Vísceras</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="3">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label15" runat="server" Text="12. Extremidades"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. Vascular</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell RowSpan="5">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label16" runat="server" Text="2. Ojos"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. Párpados</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="5">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label17" runat="server" Text="4. Oro faringe"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. Labios</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">d. Senos paranasales</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">b. Pared abdominal</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">b. Miembros superiores</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT">b. Conjuntivas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">b. Lengua</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label18" runat="server" Text="6. Cuello"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. Tiroides / masas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="4">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label19" runat="server" Text="10. Columna"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. Flexibilidad</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">c. Miembros inferiores</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT">c. Pupilas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">c. Faringe</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">b. Movilidad</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" RowSpan="2">b. Desviación</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" RowSpan="2">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="4">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label20" runat="server" Text="13. Neurológico"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. Fuerza</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT">d. Córnea</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">d. Amígdalas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label21" runat="server" Text="7. Tórax"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. Mamas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">b. Sensibilidad</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT">e. Motilidad</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">e. Dentadura</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">b. Corazón</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">c. Dolor</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">c. Marcha</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="text-align: left" ColumnSpan="12">CON EVIDENCIA DE PATOLOGÍA MARCAR CON "X" Y DESCRIBIR EN LA SIGUIENTE SECCIÓN ANOTANDO EL NUMERAL</asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">d. Reflejos</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="15">
                                                            <textarea id="" cols="20" rows="4" style="border: none; width:100%; background-color:transparent" placeholder="Observaciones:"></textarea>
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
                                <asp:TableCell Style="width: 400px">EXAMEN </asp:TableCell>
                                <asp:TableCell Style="width: 150px">FECHA</asp:TableCell>
                                <asp:TableCell Style="width: 800px">RESULTADO</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="3">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" placeholder="Observaciones:"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        F. DIAGNÓSTICO
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="width: 30px"></asp:TableCell>
                                <asp:TableCell Style="width: 800px; text-align: end">PRE= PRESUNTIVO          DEF= DEFINITIVO</asp:TableCell>
                                <asp:TableCell Style="width: 200px">CIE</asp:TableCell>
                                <asp:TableCell Style="width: 75px">PRE</asp:TableCell>
                                <asp:TableCell Style="width: 75px">DEF</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="width: 30px" Text="1"></asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" placeholder="Descrpción"></asp:TextBox>
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
                            <asp:TableRow>
                                <asp:TableCell Style="width: 30px" Text="2"></asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" placeholder="Descrpción"></asp:TextBox>
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
                        G. EVALUACIÓN MÉDICA DE RETIRO
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="width: 800px; text-align: left">SE REALIZÓ LA EVALUACIÓN</asp:TableCell>
                                <asp:TableCell Style="width: 100px; text-align: center">SI</asp:TableCell>
                                <asp:TableCell Style="width: 100px">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 100px">NO</asp:TableCell>
                                <asp:TableCell Style="width: 100px">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="5">
                                                            <textarea id="" cols="20" rows="3" style="border: none; width:100%; background-color:transparent" placeholder="Observaciones:"></textarea>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        H. RECOMENDACIONES Y/O TRATAMIENTO
                    </div>
                    <div class="list-group list-group-flush">
                        <textarea id="" cols="20" rows="3" style="border: none" placeholder="Descripción"></textarea>
                    </div>
                </div>
                <br />
                <div class="container">
                    <p>
                        <strong>"CERTIFICO QUE LO ANTERIORMENTE EXPRESADO EN RELACIÓN A MI ESTADO DE SALUD ES VERDAD. SE ME HA INFORMADO MI ESTADO ACTUAL DE 
                                                SALUD Y LAS RECOMENDACIONES PERTINENTES."</strong>
                    </p>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        I. DATOS DEL PROFESIONAL
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="width: 60px">FECHA</asp:TableCell>
                                <asp:TableCell Style="width: 75px">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 60px">HORA</asp:TableCell>
                                <asp:TableCell Style="width: 75px">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 100px">NOMBRES Y APELLIDOS</asp:TableCell>
                                <asp:TableCell Style="width: 300px">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 75px">CÓDIGO</asp:TableCell>
                                <asp:TableCell Style="width: 125px">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
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
                        <div class="card-header" align="center">
                            J. FIRMA DEL USUARIO
                        </div>
                        <div class="list-group list-group-flush">
                            <asp:TextBox runat="server" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" Rows="2"></asp:TextBox>
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
