<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Views/Principal.Master" AutoEventWireup="true" CodeBehind="Certificado.aspx.cs" Inherits="SistemaECU911.Template.Views.Certificado" %>

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
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
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
                        B. DATOS GENERALES 
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="FECHA DE EMISIÓN:" Style="width: 350px"></asp:TableCell>
                                <asp:TableCell ColumnSpan="8" Style="width: 1000px">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="EVALUACIÓN:" Style="width: 350px"></asp:TableCell>
                                <asp:TableCell Text="INGRESO" Style="width: 250px"></asp:TableCell>
                                <asp:TableCell Style="width: 75px">
                                    <asp:CheckBox ID="CheckBox1" runat="server" BorderStyle="None" />
                                </asp:TableCell>
                                <asp:TableCell Text="PERIÓDICO" Style="width: 150px"></asp:TableCell>
                                <asp:TableCell Style="width: 75px">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Text="REINTEGRO" Style="width: 150px"></asp:TableCell>
                                <asp:TableCell Style="width: 75px">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Text="RETIRO" Style="width: 150px"></asp:TableCell>
                                <asp:TableCell Style="width: 75px">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
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
                                <asp:TableCell ColumnSpan="8">
                                                            <textarea id="" cols="20" rows="3" style="border: none; width:100%; background-color:transparent" placeholder="Observaciones:"></textarea>
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
                                <asp:TableCell Style="width: 50px">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Text="NO" Style="width: 100px"></asp:TableCell>
                                <asp:TableCell Style="width: 50px">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="Condición del diagnóstico" Style="width: 705px; text-align: left"></asp:TableCell>
                                <asp:TableCell Text="Presuntiva" Style="width: 100px"></asp:TableCell>
                                <asp:TableCell Style="width: 50px">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Text="Definitiva" Style="width: 100px"></asp:TableCell>
                                <asp:TableCell Style="width: 50px">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Text="No aplica" Style="width: 100px"></asp:TableCell>
                                <asp:TableCell Style="width: 50px">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="La condición de salud esta relacionada con el trabajo" Style="width: 705px; text-align: left"></asp:TableCell>
                                <asp:TableCell Text="SI" Style="width: 100px"></asp:TableCell>
                                <asp:TableCell Style="width: 50px">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Text="NO" Style="width: 100px"></asp:TableCell>
                                <asp:TableCell Style="width: 50px">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Text="No aplica" Style="width: 100px"></asp:TableCell>
                                <asp:TableCell Style="width: 50px">
                                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
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
                        <textarea id="" cols="20" rows="3" style="border: none" placeholder="Descripción"></textarea>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        F. DATOS DEL PROFESIONAL DE SALUD
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
                        <div class="card-header">
                            G. FIRMA DEL USUARIO    
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
