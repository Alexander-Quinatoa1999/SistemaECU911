<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Views/Principal.Master" AutoEventWireup="true" CodeBehind="Inicial.aspx.cs" Inherits="SistemaECU911.Template.Views.Inicial" %>

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
                            HISTORIA CLÍNICA OCUPACIONAL - INICIAL
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
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center; "  ></asp:TextBox>
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
                                <asp:TableCell RowSpan="2" Text="PRIMER APELLIDO"></asp:TableCell>
                                <asp:TableCell RowSpan="2" Text="SEGUNDO APELLIDO"></asp:TableCell>
                                <asp:TableCell RowSpan="2" Text="PRIMER NOMBRE"></asp:TableCell>
                                <asp:TableCell RowSpan="2" Text="SEGUNDO NOMBRE"></asp:TableCell>
                                <asp:TableCell RowSpan="2" Text="SEXO"></asp:TableCell>
                                <asp:TableCell RowSpan="2" Text="EDAD (AÑOS)"></asp:TableCell>
                                <asp:TableCell Style="width: 15%" ColumnSpan="5" Text="RELIGIÓN"></asp:TableCell>
                                <asp:TableCell RowSpan="2" Text="GRUPO SANGUÍNEO"></asp:TableCell>
                                <asp:TableCell RowSpan="2" Text="LATERALIDAD"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:Label CssClass="in-column" ID="lbl_catolica" runat="server" Text="Católica"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label CssClass="in-column" ID="Label1" runat="server" Text="Evangélica"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label CssClass="in-column" ID="Label2" runat="server" Text="Testigos de Jehová"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label CssClass="in-column" ID="Label3" runat="server" Text="Mormona"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label CssClass="in-column" ID="Label4" runat="server" Text="Otras"></asp:Label>
                                </asp:TableCell>
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
                                <asp:TableCell Style="width: 15%" ColumnSpan="5" Text="ORIENTACION SEXUAL"></asp:TableCell>
                                <asp:TableCell Style="width: 15%" ColumnSpan="5" Text="IDENTIDAD DE GENERO"></asp:TableCell>
                                <asp:TableCell Style="width: 15%" ColumnSpan="4" Text=" DISCAPACIDAD"></asp:TableCell>
                                <asp:TableCell RowSpan="2" Text="FECHA DE INGRESO AL TRABAJO"></asp:TableCell>
                                <asp:TableCell RowSpan="2" Text="PUESTO DE TRABAJO (CIUO)"></asp:TableCell>
                                <asp:TableCell RowSpan="2" Text="ÁREA DE TRABAJO"></asp:TableCell>
                                <asp:TableCell RowSpan="2" Text="ACTIVIDADES RELEVANTES AL PUESTO DE TRABAJO A OCUPAR"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:Label CssClass="in-column" ID="Label5" runat="server" Text="Lesbiana"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label CssClass="in-column" ID="Label6" runat="server" Text="Gay"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label CssClass="in-column" ID="Label7" runat="server" Text="Bisexual"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label CssClass="in-column" ID="Label8" runat="server" Text="Heterosexual"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label CssClass="in-column" ID="Label9" runat="server" Text="No sabe/No responde"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label CssClass="in-column" ID="Label10" runat="server" Text="Femenino"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label CssClass="in-column" ID="Label11" runat="server" Text="Masculino"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label CssClass="in-column" ID="Label12" runat="server" Text="Trans-femenino"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label CssClass="in-column" ID="Label13" runat="server" Text="Trans-masculino"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label CssClass="in-column" ID="Label14" runat="server" Text="No sabe/No responde"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>SI</asp:TableCell>
                                <asp:TableCell>NO</asp:TableCell>
                                <asp:TableCell Style="width: 10%">TIPO</asp:TableCell>
                                <asp:TableCell Style="width: 4%">%</asp:TableCell>
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
                    <div class="row">
                        <div class="card-header col" style="margin-left: 0.8rem">
                            B. MOTIVO DE CONSULTA                                           
                        </div>
                        <div class="card-header col" style="text-align: right; font-size: 13px; margin-right: 0.8rem">
                            ANOTAR LA CAUSA DEL PROBLEMA EN LA VERSIÓN DEL INFORMANTE                                          
                        </div>
                    </div>
                    <div class="list-group list-group-flush">
                        <textarea id="TextArea2" rows="3" cols="20" style="background-color: transparent; width: 100%; text-align: left; border: none" placeholder="Descripción:"></textarea>
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
                        <div class="card-header" style="font-size: 14px">
                            ANTECEDENTES GINECO OBSTÉTRICOS
                        </div>
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="width: 15%" RowSpan="2">MENARQUÍA</asp:TableCell>
                            <asp:TableCell RowSpan="2">CICLOS</asp:TableCell>
                            <asp:TableCell RowSpan="2">FECHA DE ULTIMA MENSTRUACIÓN</asp:TableCell>
                            <asp:TableCell RowSpan="2">GESTAS</asp:TableCell>
                            <asp:TableCell RowSpan="2">PARTOS</asp:TableCell>
                            <asp:TableCell RowSpan="2">CESÁREAS</asp:TableCell>
                            <asp:TableCell RowSpan="2">ABORTOS</asp:TableCell>
                            <asp:TableCell Style="width: 10%" ColumnSpan="2">HIJOS</asp:TableCell>
                            <asp:TableCell Style="width: 10%" ColumnSpan="2">VIDA SEXUAL ACTIVA</asp:TableCell>
                            <asp:TableCell Style="width: 10%" ColumnSpan="3">METODO DE PLANIFICACIÓN FAMILIAR</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>VIVOS</asp:TableCell>
                            <asp:TableCell>MUERTOS</asp:TableCell>
                            <asp:TableCell>SI</asp:TableCell>
                            <asp:TableCell>NO</asp:TableCell>
                            <asp:TableCell>SI</asp:TableCell>
                            <asp:TableCell>NO</asp:TableCell>
                            <asp:TableCell Style="width: 10%">TIPO</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" ></asp:TextBox>
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
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell>EXAMENES REALIZADOS</asp:TableCell>
                            <asp:TableCell>SI</asp:TableCell>
                            <asp:TableCell>NO</asp:TableCell>
                            <asp:TableCell Style="width: 10%">TIEMPO</asp:TableCell>
                            <asp:TableCell Style="width: 20%">RESULTADO</asp:TableCell>
                            <asp:TableCell>EXAMENES REALIZADOS</asp:TableCell>
                            <asp:TableCell>SI</asp:TableCell>
                            <asp:TableCell>NO</asp:TableCell>
                            <asp:TableCell Style="width: 10%">TIEMPO</asp:TableCell>
                            <asp:TableCell Style="width: 20%">RESULTADO</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>PAPANICOLAOU</asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" ></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" ></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>ECO MAMARIO</asp:TableCell>
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
                        <asp:TableRow>
                            <asp:TableCell>COLPOSCOPIA</asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" ></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" ></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>MAMOGRAFÍA</asp:TableCell>
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
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" ></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>ALCOHOL</asp:TableCell>
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
                        <asp:TableRow>
                            <asp:TableCell>OTRAS DROGAS</asp:TableCell>
                            <asp:TableCell RowSpan="2">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell RowSpan="2">
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
                        <asp:TableRow>
                            <asp:TableCell>MEDICACIÓN HABITUAL</asp:TableCell>
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
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" ></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        D. ANTECEDENTES DE TRABAJO
                    </div>
                    <div class="card-header" style="font-size: 14px">
                        ANTECEDENTES DE EMPLEOS ANTERIORES
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell RowSpan="2">EMPRESA</asp:TableCell>
                            <asp:TableCell RowSpan="2">PUESTO DE TRABAJO</asp:TableCell>
                            <asp:TableCell RowSpan="2">ACTVIDADES QUE DESEMPEÑA</asp:TableCell>
                            <asp:TableCell RowSpan="2">TIEMPO DE TRABAJO</asp:TableCell>
                            <asp:TableCell Style="width: 15%" ColumnSpan="6">RIESGO</asp:TableCell>
                            <asp:TableCell RowSpan="2">OBSERVACIONES</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label15" runat="server" Text="Físico"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label16" runat="server" Text="Mecánico"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label17" runat="server" Text="Químico"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label18" runat="server" Text="Biólogo"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label19" runat="server" Text="Ergonómico"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label20" runat="server" Text="Psicosocial"></asp:Label>
                            </asp:TableCell>
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
                    <div class="card" style="width: auto;">
                        <div class="card-header" style="font-size: 14px">
                            ACCIDENTES DE TRABAJO (DESCRIPCIÓN)
                        </div>
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="width: 45%">FUE CALIFICADO POR EL INSTITUTO DE SEGURIDAD SOCIAL CORRESPONDIENTE: </asp:TableCell>
                            <asp:TableCell>SI</asp:TableCell>
                            <asp:TableCell>
                                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>ESPECIFICAR</asp:TableCell>
                            <asp:TableCell Style="width: 15%">
                                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>NO</asp:TableCell>
                            <asp:TableCell>
                                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>FECHA:</asp:TableCell>
                            <asp:TableCell>
                                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="9">
                                                 <textarea id="TextArea4" rows="3" cols="20" style="background-color:transparent; width:100%; text-align:left; border:none" placeholder="Observaciones:"></textarea>
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
                            <asp:TableCell Style="width: 45%">FUE CALIFICADO POR EL INSTITUTO DE SEGURIDAD SOCIAL CORRESPONDIENTE: </asp:TableCell>
                            <asp:TableCell>SI</asp:TableCell>
                            <asp:TableCell>
                                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>ESPECIFICAR</asp:TableCell>
                            <asp:TableCell Style="width: 15%">
                                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>NO</asp:TableCell>
                            <asp:TableCell>
                                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>FECHA:</asp:TableCell>
                            <asp:TableCell>
                                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="9">
                                                 <textarea id="TextArea3" rows="3" cols="20" style="background-color:transparent; width:100%; text-align:left; border:none" placeholder="Observaciones:"></textarea>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="row">
                        <div class="card-header col" style="margin-left: 0.8rem">
                            E. ANTECEDENTES FAMILIARES (DETALLAR EL PARENTESCO)                                          
                        </div>
                        <div class="card-header col" style="text-align: right; font-size: 13px; margin-right: 0.8rem">
                            MARCAR Y DESCRIBIR ABAJO ANOTANDO EL NÚMERO                                          
                        </div>
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="width: 20%">1. ENFERMEDAD CARDIO-VASCULAR</asp:TableCell>
                            <asp:TableCell>
                                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 20%">2. ENFERMEDAD METABÓLICA</asp:TableCell>
                            <asp:TableCell>
                                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 20%">3. ENFERMEDAD NEUROLÓGICA</asp:TableCell>
                            <asp:TableCell>
                                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 20%">4. ENFERMEDAD ONCOLÓGICA</asp:TableCell>
                            <asp:TableCell>
                                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="width: 20%">5. ENFERMEDAD INFECCIOSA</asp:TableCell>
                            <asp:TableCell>
                                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 20%">6. ENFERMEDAD HEREDITARIA/CONGÉNITA</asp:TableCell>
                            <asp:TableCell>
                                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 20%">7. DISCAPACIDADES</asp:TableCell>
                            <asp:TableCell>
                                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 20%">8. OTROS</asp:TableCell>
                            <asp:TableCell>
                                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="8">
                                                 <textarea id="TextA" rows="6" cols="20" style="background-color:transparent; width:100%; text-align:left; border:none" placeholder="Descripción:"></textarea>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        F.  FACTORES DE RIESGOS DEL PUESTO DE TRABAJO ACTUAL                                          
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="width: 20%" RowSpan="2" ColumnSpan="2">PUESTO DE TRABAJO / ÁREA</asp:TableCell>
                            <asp:TableCell Style="width: 20%" RowSpan="2">ACTIVIDADES</asp:TableCell>
                            <asp:TableCell Style="width: 15%" ColumnSpan="10">FÍSICO</asp:TableCell>
                            <asp:TableCell Style="width: 15%" ColumnSpan="15">MECÁNICO</asp:TableCell>
                            <asp:TableCell Style="width: 15%" ColumnSpan="9">QUÍMICO</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label21" runat="server" Text="Temperaturas altas"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label22" runat="server" Text="Temperaturas bajas"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label23" runat="server" Text="Radiación Ionizante"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label24" runat="server" Text="Radiación No Ionizante"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label25" runat="server" Text="Ruido"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label26" runat="server" Text="Vibración"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label27" runat="server" Text="Iluminación"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label28" runat="server" Text="Ventilación"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label29" runat="server" Text="Fluido eléctrico"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label30" runat="server" Text="Otros __________"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label31" runat="server" Text="Atrapamiento entre máquinas"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label32" runat="server" Text="Atrapamiento entre superficies"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label33" runat="server" Text="Atrapamiento entre objetos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label34" runat="server" Text="Caída de objetos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label35" runat="server" Text="Caídas al mismo nivel"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label36" runat="server" Text="Caídas a diferente nivel"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label37" runat="server" Text="Contacto eléctrico"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label38" runat="server" Text="Contacto con superficies de trabajos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label39" runat="server" Text="Proyección de partículas – fragmentos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label40" runat="server" Text="Proyección de fluidos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label41" runat="server" Text="Pinchazos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label42" runat="server" Text="Cortes"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label43" runat="server" Text="Atropellamientos por vehículos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label44" runat="server" Text="Choques /colisión vehicular"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label45" runat="server" Text="Otros __________"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label46" runat="server" Text="Sólidos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label47" runat="server" Text="Polvos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label48" runat="server" Text="Humos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label49" runat="server" Text="Líquidos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label50" runat="server" Text="Vapores"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label51" runat="server" Text="Aerosoles"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label52" runat="server" Text="Neblinas"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label53" runat="server" Text="Gaseosos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label54" runat="server" Text="Otros __________"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>1. </asp:TableCell>
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
                        <asp:TableRow>
                            <asp:TableCell>2. </asp:TableCell>
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
                        <asp:TableRow>
                            <asp:TableCell>3. </asp:TableCell>
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
                        <asp:TableRow>
                            <asp:TableCell>4. </asp:TableCell>
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
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="width: 20%" RowSpan="2" ColumnSpan="2">PUESTO DE TRABAJO / ÁREA</asp:TableCell>
                            <asp:TableCell Style="width: 20%" RowSpan="2">ACTIVIDADES</asp:TableCell>
                            <asp:TableCell Style="width: 15%" ColumnSpan="7">BIÓLOGO</asp:TableCell>
                            <asp:TableCell Style="width: 15%" ColumnSpan="5">ERGONÓMICO</asp:TableCell>
                            <asp:TableCell Style="width: 15%" ColumnSpan="13">PSICOSOCIAL</asp:TableCell>
                            <asp:TableCell Style="width: 25%" RowSpan="2">MEDIDAS PREVENTIVAS</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label55" runat="server" Text="Virus"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label56" runat="server" Text="Hongos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label57" runat="server" Text="Bacterias "></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label58" runat="server" Text="Parásitos "></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label59" runat="server" Text="Exposición a vectores"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label60" runat="server" Text="Exposición a animales selváticos "></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label61" runat="server" Text="Otros __________"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label62" runat="server" Text="Manejo manual de cargas"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label63" runat="server" Text="Movimiento repetitivos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label64" runat="server" Text="Posturas forzadas"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label65" runat="server" Text="Trabajos con PVD"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label66" runat="server" Text="Otros __________"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label67" runat="server" Text="Monotonía del trabajo "></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label68" runat="server" Text="Sobrecarga laboral"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label69" runat="server" Text="Minuciosidad de la tarea "></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label70" runat="server" Text="Alta responsabilidad"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label71" runat="server" Text="Autonomía  en la toma de decisiones"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label72" runat="server" Text="Supervisión y estilos de dirección deficiente"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label73" runat="server" Text="Conflicto de rol"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label74" runat="server" Text="Falta de Claridad en las funciones"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label75" runat="server" Text="Incorrecta distribución del trabajo"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label76" runat="server" Text="Turnos rotativos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label77" runat="server" Text="Relaciones interpersonales"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label78" runat="server" Text="Inestabilidad laboral"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label CssClass="in-column" ID="Label79" runat="server" Text="Otros __________"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>1. </asp:TableCell>
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
                            <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>2. </asp:TableCell>
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
                            <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>3. </asp:TableCell>
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
                            <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>4. </asp:TableCell>
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
                            <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        G. ACTIVIDADES EXTRA LABORALES                                            
                    </div>
                    <div class="list-group list-group-flush">
                        <textarea id="TextAB" rows="3" cols="20" style="background-color: transparent; width: 100%; text-align: left; border: none" placeholder="Descripción:"></textarea>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        H. ENFERMEDAD ACTUAL                                           
                    </div>
                    <div class="list-group list-group-flush">
                        <textarea id="TextABC" rows="3" cols="20" style="background-color: transparent; width: 100%; text-align: left; border: none" placeholder="Descripción:"></textarea>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="row">
                        <div class="card-header col" style="margin-left: 0.8rem">
                            I. REVISIÓN ACTUAL DE ÓRGANOS Y SISTEMAS                                          
                        </div>
                        <div class="card-header col" style="text-align: right; font-size: 11px; margin-right: 0.8rem">
                            EN CASO DE EXISTIR PATOLOGÍA  MARCAR CON "X"  Y DESCRIBIR ABAJO COLOCANDO EL NUMERAL                                         
                        </div>
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="width: 15%">1. PIEL - ANEXOS</asp:TableCell>
                            <asp:TableCell>
                                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 15%">3. RESPIRATORIO</asp:TableCell>
                            <asp:TableCell>
                                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 15%">5. DIGESTIVO</asp:TableCell>
                            <asp:TableCell>
                                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 15%">7. MÚSCULO ESQUELÉTICO</asp:TableCell>
                            <asp:TableCell>
                                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 15%">9. HEMO LINFÁTICO</asp:TableCell>
                            <asp:TableCell>
                                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="width: 15%">2. ÓRGANOS DE LOS SENTIDOS</asp:TableCell>
                            <asp:TableCell>
                                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 15%">4. CARDIO-VASCULAR</asp:TableCell>
                            <asp:TableCell>
                                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 15%">6. GENITO - URINARIO</asp:TableCell>
                            <asp:TableCell>
                                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 15%">8. ENDOCRINO</asp:TableCell>
                            <asp:TableCell>
                                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 15%">10. NERVIOSO</asp:TableCell>
                            <asp:TableCell>
                                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="10">
                                                 <textarea id="T1" rows="6" cols="20" style="background-color:transparent; width:100%; text-align:left; border:none" placeholder="Descripción:"></textarea>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        J. CONSTANTES VITALES Y ANTROPOMETRÍA 
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
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        K. EXAMEN FÍSICO REGIONAL
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="REGIONES" Style="width: 100%; text-align: left" ColumnSpan="15"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell RowSpan="3">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label80" runat="server" Text="1. Piel"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. Cicatrices</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="3">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label81" runat="server" Text="3. Oído"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. C. auditivo externo</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="4">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label82" runat="server" Text="5. Nariz"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. Tabique</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label83" runat="server" Text="8. Tórax"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. Pulmones</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label84" runat="server" Text="11. Pelvis"></asp:Label>
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
                                    <asp:Label CssClass="REI-COLUMN" ID="Label85" runat="server" Text="9. Abdomen"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. Vísceras</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="3">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label86" runat="server" Text="12. Extremidades"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. Vascular</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell RowSpan="5">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label87" runat="server" Text="2. Ojos"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. Párpados</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="5">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label88" runat="server" Text="4. Oro faringe"></asp:Label>
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
                                    <asp:Label CssClass="REI-COLUMN" ID="Label89" runat="server" Text="6. Cuello"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT">a. Tiroides / masas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="4">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label90" runat="server" Text="10. Columna"></asp:Label>
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
                                    <asp:Label CssClass="REI-COLUMN" ID="Label91" runat="server" Text="13. Neurológico"></asp:Label>
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
                                    <asp:Label CssClass="REI-COLUMN" ID="Label92" runat="server" Text="7. Tórax"></asp:Label>
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
                                <asp:TableCell Style="text-align: left" ColumnSpan="12">SI EXISTE EVIDENCIA DE PATOLOGÍA MARCAR CON "X" Y DESCRIBIR EN LA SIGUIENTE SECCIÓN COLOCANDO EL NUMERAL</asp:TableCell>
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
                        L. RESULTADOS DE EXÁMENES GENERALES Y ESPECÍFICOS DE ACUERDO AL RIESGO Y PUESTO DE TRABAJO (IMAGEN, LABORATORIO Y OTROS)
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="width: 400px">EXAMEN </asp:TableCell>
                                <asp:TableCell Style="width: 150px">FECHA</asp:TableCell>
                                <asp:TableCell Style="width: 800px">RESULTADOS</asp:TableCell>
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
                        M. DIAGNÓSTICO
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
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" placeholder="Descripción"></asp:TextBox>
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
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" placeholder="Descripción"></asp:TextBox>
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
                                <asp:TableCell Style="width: 30px" Text="3"></asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%;" placeholder="Descripción"></asp:TextBox>
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
                        N. APTITUD MÉDICA PARA EL TRABAJO  
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="width: 250px">APTO</asp:TableCell>
                                <asp:TableCell Style="width: 50px">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 175px">APTO EN OBSERVACIÓN</asp:TableCell>
                                <asp:TableCell Style="width: 75px">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 175px">APTO CON LIMITACIONES</asp:TableCell>
                                <asp:TableCell Style="width: 60px">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 175px">NO APTO</asp:TableCell>
                                <asp:TableCell Style="width: 75px">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Observación</asp:TableCell>
                                <asp:TableCell ColumnSpan="7">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>Limitación</asp:TableCell>
                                <asp:TableCell ColumnSpan="7">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        O. RECOMENDACIONES Y/O TRATAMIENTO
                    </div>
                    <div class="list-group list-group-flush">
                        <textarea id="" cols="20" rows="3" style="border: none" placeholder="Descripción"></textarea>
                    </div>
                </div>
                <br />
                <div class="container" style="text-align: center">
                    <p>
                        <strong>"CERTIFICO QUE LO ANTERIORMENTE EXPRESADO EN RELACIÓN A MI ESTADO DE SALUD ES VERDAD. SE ME HA INFORMADO LAS MEDIDAS PREVENTIVAS 
                                           A TOMAR PARA DISMINUIR O MITIGAR LOS RIESGOS RELACIONADOS CON MI ACTIVIDAD LABORAL."</strong>
                    </p>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        P. DATOS DEL PROFESIONAL 
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
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Time"></asp:TextBox>
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
                        <div class="card-header">
                            Q. FIRMA DEL USUARIO
                        </div>
                        <div class="list-group list-group-flush">
                            <asp:Label ID="Label93" runat="server" Text="" Style="height: 80px"></asp:Label>
                        </div>
                    </div>
                </div>
                <br />
                <div class="container" align="center">
                    <asp:Button CssClass="btn btn-primary" ID="btn_guardar" runat="server" Text="Guardar" OnClick="btn_guardar_Click" />
                    <asp:Button CssClass="btn btn-primary" ID="btn_modificar" runat="server" Text="Modificar" OnClick=""  />
                    <asp:Button CssClass="btn btn-secondary" ID="btn_cancelar" runat="server" Text="Cancelar" OnClick="btn_cancelar_Click" />
                </div>
                <br />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
