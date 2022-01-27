<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Views/Principal.Master" AutoEventWireup="true" CodeBehind="Certificado.aspx.cs" Inherits="SistemaECU911.Template.Views.Certificado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <contenttemplate>
            <div class="container" style="background-color: white">
                <br />
                <div class="container">
                    <div class="card text-center">
                        <div class="card-header">
                            GESTIÓN DE SEGURIDAD Y SALUD OCUPACIONAL
                        </div>
                        <div>
                            HISTORIA CLÍNICA OCUPACIONAL - CERTIFICADO
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
                                    <asp:TextBox runat="server" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center;" Text="Servicio Integrado de Seguridad Sis Ecu 911" ReadOnly="true"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center" Text="1768174880001" ReadOnly="true"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center" Text="Consultorio Médico" ReadOnly="true"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="txt_numHClinica" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center" OnTextChanged="txt_numHistoCli_TextChanged" AutoPostBack="true"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="txt_numArchivo" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
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
                                    <asp:TextBox runat="server" ID="txt_priApellido" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="txt_segApellido" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="txt_priNombre" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="txt_segNombre" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="txt_sexo" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="txt_puestoTrabajo" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        B. DATOS GENERALES 
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="FECHA DE EMISIÓN:" Style="width: 350px"></asp:TableCell>
                                <asp:TableCell ColumnSpan="8" Style="width: 1000px">
                                    <asp:TextBox runat="server" ID="txt_fechaEmision" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="EVALUACIÓN:" Style="width: 350px"></asp:TableCell>
                                <asp:TableCell Text="INGRESO" Style="width: 250px"></asp:TableCell>
                                <asp:TableCell Style="width: 75px">
                                    <asp:TextBox runat="server" ID="txt_ingreso" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Text="PERIÓDICO" Style="width: 150px"></asp:TableCell>
                                <asp:TableCell Style="width: 75px">
                                    <asp:TextBox runat="server" ID="txt_periodico" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Text="REINTEGRO" Style="width: 150px"></asp:TableCell>
                                <asp:TableCell Style="width: 75px">
                                    <asp:TextBox runat="server" ID="txt_reintegro" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Text="RETIRO" Style="width: 150px"></asp:TableCell>
                                <asp:TableCell Style="width: 75px">
                                    <asp:TextBox runat="server" ID="txt_retiro" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        C. APTITUD MÉDICA LABORAL
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="Después de la valoración médica ocupacional se certifica que la persona en mención, es calificada como:" Style="width: 1160px; text-align: left" ColumnSpan="8"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="width: 250px">APTO</asp:TableCell>
                                <asp:TableCell Style="width: 50px">
                                    <asp:TextBox runat="server" ID="txt_apto" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 175px">APTO EN OBSERVACIÓN</asp:TableCell>
                                <asp:TableCell Style="width: 75px">
                                    <asp:TextBox runat="server" ID="txt_aptoObservacion" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 175px">APTO CON LIMITACIONES</asp:TableCell>
                                <asp:TableCell Style="width: 60px">
                                    <asp:TextBox runat="server" ID="txt_aptoLimitaciones" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 175px">NO APTO</asp:TableCell>
                                <asp:TableCell Style="width: 75px">
                                    <asp:TextBox runat="server" ID="txt_noApto" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="8">
                                    <asp:TextBox runat="server" ID="txt_detaObservaAptiMedLaboral" BorderStyle="None" Style="background-color: transparent; width: 100%" TextMode="MultiLine" Rows="3" placeholder="Detalle de Observaciones:"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        D.  EVALUACIÓN MÉDICA DE RETIRO
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="El usuario se realizó la evaluación médica de retiro" Style="width: 705px; text-align: left"></asp:TableCell>
                                <asp:TableCell Text="SI" Style="width: 100px"></asp:TableCell>
                                <asp:TableCell Style="width: 100px">
                                    <asp:TextBox runat="server" ID="txt_siEvaMedRetiro" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Text="NO" Style="width: 100px"></asp:TableCell>
                                <asp:TableCell Style="width: 50px">
                                    <asp:TextBox runat="server" ID="txt_noEvaMedRetiro" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="Condición del diagnóstico" Style="width: 705px; text-align: left"></asp:TableCell>
                                <asp:TableCell Text="Presuntiva" Style="width: 50px"></asp:TableCell>
                                <asp:TableCell Style="width: 50px">
                                    <asp:TextBox runat="server" ID="txt_presuntivaEvaMedRetiro" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Text="Definitiva" Style="width: 100px"></asp:TableCell>
                                <asp:TableCell Style="width: 50px">
                                    <asp:TextBox runat="server" ID="txt_definitivaEvaMedRetiro" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Text="No aplica" Style="width: 100px"></asp:TableCell>
                                <asp:TableCell Style="width: 50px">
                                    <asp:TextBox runat="server" ID="txt_noAplicaEvaMedRetiro" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="La condición de salud esta relacionada con el trabajo" Style="width: 705px; text-align: left"></asp:TableCell>
                                <asp:TableCell Text="SI" Style="width: 100px"></asp:TableCell>
                                <asp:TableCell Style="width: 50px">
                                    <asp:TextBox runat="server" ID="txt_si2EvaMedRetiro" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Text="NO" Style="width: 100px"></asp:TableCell>
                                <asp:TableCell Style="width: 50px">
                                    <asp:TextBox runat="server" ID="txt_no2EvaMedRetiro" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Text="No aplica" Style="width: 100px"></asp:TableCell>
                                <asp:TableCell Style="width: 50px">
                                    <asp:TextBox runat="server" ID="txt_noAplica2EvaMedRetiro" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        E. RECOMENDACIONES 
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:TextBox runat="server" ID="txt_descripRecomendaciones" BorderStyle="None" Style="width: 100%" TextMode="MultiLine" Rows="3" placeholder="Descripción"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="container" style="text-align: center">
                    <p align="center">
                        <strong>"Con este documento certifico que el trabajador se ha sometido a la evaluación médica requerida para 
                            (el ingreso /la ejecución/ el reintegro y retiro) al puesto laboral y se ha informado sobre los riesgos relacionados 
                            con el trabajo emitiendo recomendaciones relacionadas con su estado de salud."</strong>
                    </p>
                </div>
                <div>
                    <p align="left">
                        <strong>La presente certificación se expide con base en la historia ocupacional del usuario (a), la cual tiene carácter 
                            de confidencial.</strong>
                    </p>
                </div>
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        F. DATOS DEL PROFESIONAL DE SALUD
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="width: 100px">NOMBRES Y APELLIDOS</asp:TableCell>
                                <asp:TableCell Style="width: 300px">
                                    <asp:DropDownList ID="ddl_profesional" CssClass="form-check" Style="width: 100%; border: none; background-color: transparent" runat="server"></asp:DropDownList>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 75px">CÓDIGO</asp:TableCell>
                                <asp:TableCell Style="width: 125px">
                                    <asp:TextBox runat="server" ID="txt_codigo" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 100px">FIRMA Y SELLO</asp:TableCell>
                                <asp:TableCell Style="width: 175px">
                                    <asp:TextBox runat="server" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div align="center">
                    <div class="card" style="width: 400px">
                        <div class="card-header">
                            G. FIRMA DEL USUARIO    
                        </div>
                        <div class="list-group list-group-flush">
                            <asp:Label ID="Label24" runat="server" Text="" Style="height: 80px"></asp:Label>
                        </div>
                    </div>
                </div>
                <br />
                <div class="container" align="center">
                    <asp:Button CssClass="btn btn-primary" ID="btn_guardacertificado" runat="server" Text="Guardar" OnClick="btn_guardacertificado_Click" UseSubmitBehavior="False" />
                    <asp:Button CssClass="btn btn-primary" ID="btn_modificacertificado" runat="server" Text="Modificar" OnClick="btn_modificacertificado_Click" UseSubmitBehavior="False" />
                    <asp:Button CssClass="btn btn-secondary" ID="btn_cancelacertificado" runat="server" Text="Cancelar" OnClick="btn_cancelacertificado_Click" UseSubmitBehavior="False" />
                </div>
                <br />
            </div>
        </contenttemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
