<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Views/Principal.Master" AutoEventWireup="true" CodeBehind="Historial.aspx.cs" Inherits="SistemaECU911.Template.Views.Historial" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="container" style="background-color: white">
                <img src="../Template Principal/images/ic1.png" alt="logo" />
                <hr size="3px" color="black" />
                <div class="container-fluid">
                    <div class="card" style="width: auto;">
                        <div class="list-group list-group-flush" style="text-align: center; padding: 10px">
                            <asp:Table ID="Table1" runat="server">
                                <asp:TableRow>
                                    <asp:TableHeaderCell>
                                        <div class="card card-responsive" style="width: auto;">
                                          <div class="card-header">
                                            ESTABLECIMIENTO DE SALUD
                                          </div>
                                          <ul class="list-group list-group-flush">
                                              <asp:TextBox runat="server" BorderStyle="None"></asp:TextBox>
                                          </ul>
                                        </div>
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                        <div class="card card-responsive" style="width: auto;">
                                          <div class="card-header">
                                            NOMBRE
                                          </div>
                                          <ul class="list-group list-group-flush">
                                              <asp:TextBox runat="server" BorderStyle="None"></asp:TextBox>
                                          </ul>
                                        </div>
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                        <div class="card card-responsive" style="width: auto;">
                                          <div class="card-header">
                                            APELLIDO
                                          </div>
                                          <ul class="list-group list-group-flush">
                                              <asp:TextBox runat="server" BorderStyle="None"></asp:TextBox>
                                          </ul>
                                        </div>
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                        <div class="card card-responsive" style="width: auto;">
                                          <div class="card-header">
                                            SEXO
                                          </div>
                                          <ul class="list-group list-group-flush">
                                              <asp:TextBox runat="server" BorderStyle="None"></asp:TextBox>
                                          </ul>
                                        </div>
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                        <div class="card card-responsive" style="width: auto;">
                                          <div class="card-header">
                                            EDAD
                                          </div>
                                          <ul class="list-group list-group-flush">
                                              <asp:TextBox runat="server" BorderStyle="None"></asp:TextBox>
                                          </ul>
                                        </div>
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                        <div class="card card-responsive" style="width: auto;">
                                          <div class="card-header">
                                            N° HISTORIA CLÍNICA
                                          </div>
                                          <ul class="list-group list-group-flush">
                                              <asp:TextBox runat="server" BorderStyle="None"></asp:TextBox>
                                          </ul>
                                        </div>
                                    </asp:TableHeaderCell>
                                </asp:TableRow>
                            </asp:Table>
                        </div>
                    </div>
                </div>
                <br />
                <div class="container-fluid">
                    <div class="card card-responsive" style="width: auto;">
                        <div class="card-header">
                            1. MOTIVO DE CONSULTA
                        </div>
                        <div class="list-group list-group-flush" style="padding: 10px; text-align: center">
                            <asp:Table runat="server">
                                <asp:TableRow>
                                    <asp:TableHeaderCell>
                                        <div class="card card-responsive" style="width: auto">
                                            <div class="card-header">
                                                MOTIVO DE CONSULTA
                                            </div>
                                            <ul class="list-group list-group-flush">
                                                <asp:TextBox runat="server" BorderStyle="None"></asp:TextBox>
                                            </ul>
                                        </div>
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                        <div class="card card-responsive" style="width: auto;">
                                            <div class="card-header">                                        
                                                MOTIVO DE CONSULTA (según acompañante)
                                            </div>
                                            <ul class="list-group list-group-flush">
                                                <asp:TextBox runat="server" BorderStyle="None"></asp:TextBox>
                                            </ul>
                                        </div>
                                    </asp:TableHeaderCell>
                                </asp:TableRow>
                            </asp:Table>
                        </div>
                    </div>
                </div>
                <br />
                <div class="container-fluid">
                    <div class="card card-responsive" style="width: auto;">
                        <div class="card-header">
                            2. ANTECEDENTES PERSONALES
                        </div>
                        <div class="list-group list-group-flush" style="padding: 10px; text-align: center">
                            <asp:Table runat="server">
                                <asp:TableRow>
                                    <asp:TableHeaderCell>
                                        <div class="card card-responsive" style="width: auto">
                                            <div class="card-header">
                                                TIPO DE ANTECEDENTE
                                            </div>
                                            <ul class="list-group list-group-flush">
                                                <asp:TextBox runat="server" BorderStyle="None"></asp:TextBox>
                                            </ul>
                                        </div>
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                        <div class="card card-responsive" style="width: auto">
                                            <div class="card-header">
                                                ANTECEDENTE
                                            </div>
                                            <ul class="list-group list-group-flush">
                                                <asp:TextBox runat="server" BorderStyle="None"></asp:TextBox>
                                            </ul>
                                        </div>
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                        <div class="card card-responsive" style="width: auto">
                                            <div class="card-header">
                                                DESCRIPCIÓN
                                            </div>
                                            <ul class="list-group list-group-flush">
                                                <asp:TextBox runat="server" BorderStyle="None"></asp:TextBox>
                                            </ul>
                                        </div>
                                    </asp:TableHeaderCell>
                                </asp:TableRow>
                            </asp:Table>
                        </div>
                    </div>
                </div>
                <br />
                <div class="container-fluid">
                    <div class="card card-responsive" style="width: auto;">
                        <div class="card-header">
                            3. ANTECEDENTES FAMILIARES
                        </div>
                        <div class="list-group list-group-flush" style="padding: 10px; text-align: center">
                            <asp:Table runat="server">
                                <asp:TableRow>
                                    <asp:TableHeaderCell>
                                        <div class="card card-responsive" style="width: auto">
                                            <div class="card-header">
                                                TIPO DE ANTECEDENTE
                                            </div>
                                            <ul class="list-group list-group-flush">
                                                <asp:TextBox runat="server" BorderStyle="None"></asp:TextBox>
                                            </ul>
                                        </div>
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                        <div class="card card-responsive" style="width: auto">
                                            <div class="card-header">
                                                ANTECEDENTE
                                            </div>
                                            <ul class="list-group list-group-flush">
                                                <asp:TextBox runat="server" BorderStyle="None"></asp:TextBox>
                                            </ul>
                                        </div>
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                        <div class="card card-responsive" style="width: auto">
                                            <div class="card-header">
                                                DESCRIPCIÓN
                                            </div>
                                            <ul class="list-group list-group-flush">
                                                <asp:TextBox runat="server" BorderStyle="None"></asp:TextBox>
                                            </ul>
                                        </div>
                                    </asp:TableHeaderCell>
                                </asp:TableRow>
                            </asp:Table>
                        </div>
                    </div>
                </div>
                <br />
                <div class="container-fluid">
                    <div class="card card-responsive" style="width: auto;">
                        <div class="card-header">
                            4. ENFERMEDAD ACTUAL
                        </div>
                        <div class="list-group list-group-flush" style="height: auto; width: auto;">
                            <textarea id="TextArea1" cols="20" rows="3" style="border: none"></textarea>
                        </div>
                    </div>
                </div>
                <br />
                <div class="container-fluid">
                    <div class="card card-responsive" style="width: auto;">
                        <div class="card-header">
                            5. REVISIÓN DE ÓRGANOS Y SISTEMAS
                        </div>
                        <div class="list-group list-group-flush" style="padding: 10px">
                            <asp:Table class="table table-bordered table-responsive" runat="server">
                                <asp:TableRow Style="text-align: center; background-color: #DAFEF9">
                                    <asp:TableHeaderCell Text="ÓRGANOS  Y SISTEMAS"></asp:TableHeaderCell>
                                    <asp:TableHeaderCell Text="EVIDENCIA PATOLÓGICA"></asp:TableHeaderCell>
                                    <asp:TableHeaderCell Text="DESCRIPCIÓN"></asp:TableHeaderCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableHeaderCell Text="Órganos de los Sentidos"></asp:TableHeaderCell>
                                    <asp:TableCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"/>
                                    </asp:TableHeaderCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableHeaderCell Text="Respiratorio"></asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                    </asp:TableHeaderCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableHeaderCell Text="Cardio Vascular"></asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%" ></asp:TextBox>
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                    </asp:TableHeaderCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableHeaderCell Text="Digestivo"></asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                    </asp:TableHeaderCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableHeaderCell Text="Genital"></asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                    </asp:TableHeaderCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableHeaderCell Text="Urinario"></asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                    </asp:TableHeaderCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableHeaderCell Text="Muscular"></asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                    </asp:TableHeaderCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableHeaderCell Text="Esquelético"></asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                    </asp:TableHeaderCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableHeaderCell Text="Nervioso"></asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                    </asp:TableHeaderCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableHeaderCell Text="Endocrino"></asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                    </asp:TableHeaderCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableHeaderCell Text="Hemo Linfático"></asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                    </asp:TableHeaderCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableHeaderCell Text="Tegumentario (Piel y Faneras)"></asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                    </asp:TableHeaderCell>
                                </asp:TableRow>
                            </asp:Table>
                        </div>
                    </div>
                </div>
                <br />
                <div class="container-fluid">
                    <div class="card card-responsive" style="width: auto">
                        <div class="card-header">
                            6. SIGNOS VITALES Y ANTROPOMÉTRICOS 
                        </div>
                        <div class="list-group list-group-flush" style="padding: 10px; width: auto">
                            <div class="container">
                                <asp:Table CssClass="table table-bordered table-responsive" runat="server">
                                    <asp:TableRow>
                                        <asp:TableCell Style="background-color: #DAFEF9; width: 100px" Text="FECHA:"></asp:TableCell>
                                        <asp:TableCell>
                                    <asp:TextBox runat="server" BorderStyle="None" style="width:100%"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell Style="background-color: #DAFEF9" Text="PROFESIONAL:"></asp:TableCell>
                                        <asp:TableCell>
                                    <asp:TextBox runat="server" BorderStyle="None" style="width:100%"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell Style="background-color: #DAFEF9" Text="ESPECIALIDAD:"></asp:TableCell>
                                        <asp:TableCell>
                                    <asp:TextBox runat="server" BorderStyle="None" style="width:100%"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                </asp:Table>
                            </div>
                            <div class="container" style="padding-top: 10px">
                                <asp:Table CssClass="table table-bordered table-responsive" runat="server">
                                    <asp:TableRow>
                                        <asp:TableCell Style="width: auto" Text="FC"></asp:TableCell>
                                        <asp:TableCell Style="width: auto" Text="84"></asp:TableCell>
                                        <asp:TableCell Style="width: auto" Text="Pr. Sist."></asp:TableCell>
                                        <asp:TableCell Style="width: auto" Text="110"></asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell Style="width: auto" Text="Pr. Med."></asp:TableCell>
                                        <asp:TableCell Style="width: auto" Text="90"></asp:TableCell>
                                        <asp:TableCell Style="width: auto" Text="Temp."></asp:TableCell>
                                        <asp:TableCell Style="width: auto" Text="37"></asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell Style="width: auto" Text="Pr. Diast."></asp:TableCell>
                                        <asp:TableCell Style="width: auto" Text="80"></asp:TableCell>
                                    </asp:TableRow>
                                </asp:Table>
                                <br />
                                <asp:Table CssClass="table table-bordered table-responsive" runat="server">
                                    <asp:TableRow>
                                        <asp:TableCell Style="width: auto" Text="FC"></asp:TableCell>
                                        <asp:TableCell Style="width: auto" Text="76"></asp:TableCell>
                                        <asp:TableCell Style="width: auto" Text="Pr. Sist."></asp:TableCell>
                                        <asp:TableCell Style="width: auto" Text="126"></asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell Style="width: auto" Text="Pr. Med."></asp:TableCell>
                                        <asp:TableCell Style="width: auto" Text="99"></asp:TableCell>
                                        <asp:TableCell Style="width: auto" Text="Temp."></asp:TableCell>
                                        <asp:TableCell Style="width: auto" Text="36"></asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell Style="width: auto" Text="Pr. Diast."></asp:TableCell>
                                        <asp:TableCell Style="width: auto" Text="86"></asp:TableCell>
                                    </asp:TableRow>
                                </asp:Table>
                            </div>
                        </div>
                    </div>
                </div>
                <br />
                <div class="container-fluid">
                    <div class="card card-responsive" style="width: auto;">
                        <div class="card-header">
                            7. EXAMEN FÍSICO
                        </div>
                        <div class="list-group list-group-flush" style="padding: 10px">
                            <asp:Table class="table table-light table-responsive" runat="server">
                                <asp:TableRow Style="text-align: center">
                                    <asp:TableHeaderCell Text="EXAMEN/REGIÓN ANATÓMICA"></asp:TableHeaderCell>
                                    <asp:TableHeaderCell Text="EVIDENCIA PATOLÓGICA"></asp:TableHeaderCell>
                                    <asp:TableHeaderCell Text="DESCRIPCIÓN"></asp:TableHeaderCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableHeaderCell Text="Examen neurológico"></asp:TableHeaderCell>
                                    <asp:TableCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                    </asp:TableHeaderCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableHeaderCell Text="Examen general"></asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                    </asp:TableHeaderCell>
                                </asp:TableRow>
                            </asp:Table>
                        </div>
                    </div>
                </div>
                <br />
                <div class="container-fluid">
                    <div class="card card-responsive" style="width: auto;">
                        <div class="card-header">
                            8. DIAGNÓSTICOS
                        </div>
                        <div class="list-group list-group-flush" style="padding: 10px">
                            <asp:Table class="table table-light table-responsive" runat="server">
                                <asp:TableRow Style="text-align: center">
                                    <asp:TableHeaderCell Text="DIAGNÓSTICOS"></asp:TableHeaderCell>
                                    <asp:TableHeaderCell Text="CÓDIGO"></asp:TableHeaderCell>
                                    <asp:TableHeaderCell Text="TIPO"></asp:TableHeaderCell>
                                    <asp:TableHeaderCell Text="CONDICIÓN"></asp:TableHeaderCell>
                                    <asp:TableHeaderCell Text="CRONOLOGÍA"></asp:TableHeaderCell>
                                    <asp:TableHeaderCell Text="DESCRIPCIÓN"></asp:TableHeaderCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%">    </asp:TextBox>
                                    </asp:TableHeaderCell>
                                    <asp:TableCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                    </asp:TableHeaderCell>
                                    <asp:TableCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                    </asp:TableHeaderCell>
                                </asp:TableRow>
                            </asp:Table>
                        </div>
                    </div>
                </div>
                <br />
                <div class="container-fluid">
                    <div class="card card-responsive" style="width: auto;">
                        <div class="card-header">
                            9. PLAN DE TRATAMIENTO
                        </div>
                        <div class="list-group list-group-flush">
                            <textarea id="" cols="20" rows="2" style="border: none"></textarea>
                        </div>
                    </div>
                </div>
                <br />
                <div class="container-fluid">
                    <div class="card card-responsive" style="width: auto;">
                        <div class="card-header">
                            10. EVOLUCIÓN
                        </div>
                        <div class="list-group list-group-flush">
                            <textarea id="" cols="20" rows="2" style="border: none"></textarea>
                        </div>
                    </div>
                </div>
                <br />
                <div class="container-fluid">
                    <div class="card card-responsive" style="width: auto;">
                        <div class="card-header">
                            11. PRESCRIPCIONES
                        </div>
                        <div class="list-group list-group-flush">
                            <textarea id="" cols="20" rows="2" style="border: none"></textarea>
                        </div>
                    </div>
                </div>
                <br />
                <div class="card card-responsive" style="width: auto">
                    <div class="list-group list-group-flush" style="padding: 10px">
                        <asp:Table class="table table-light table-responsive" runat="server">
                            <asp:TableRow Style="text-align: center">
                                <asp:TableHeaderCell Text="FECHA"></asp:TableHeaderCell>
                                <asp:TableHeaderCell Text="HORA"></asp:TableHeaderCell>
                                <asp:TableHeaderCell Text="ESPECIALIDAD"></asp:TableHeaderCell>
                                <asp:TableHeaderCell Text="NOMBRE DEL PROFESIONAL"></asp:TableHeaderCell>
                                <asp:TableHeaderCell Text="CÓDIGO"></asp:TableHeaderCell>
                                <asp:TableHeaderCell Text="FIRMA"></asp:TableHeaderCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                </asp:TableHeaderCell>
                                <asp:TableCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                </asp:TableHeaderCell>
                                <asp:TableHeaderCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                </asp:TableHeaderCell>
                                <asp:TableCell>
                                <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableHeaderCell></asp:TableHeaderCell>
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
