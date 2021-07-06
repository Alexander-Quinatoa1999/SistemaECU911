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
                <div class="container">
                    <div class="card" style="width: auto;">                        
                        <div class="list-group list-group-flush" style="padding: 10px; text-align:center">
                            <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                                <asp:TableRow Style="text-align: center">
                                    <asp:TableCell Text="ESTABLECIMIENTO DE SALUD"></asp:TableCell>
                                    <asp:TableCell Text="NOMBRE"></asp:TableCell>
                                    <asp:TableCell Text="APELLIDO"></asp:TableCell>
                                    <asp:TableCell Text="SEXO"></asp:TableCell>
                                    <asp:TableCell Text="EDAD"></asp:TableCell>
                                    <asp:TableCell Text="N° HISTORIA CLÍNICA"></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center">    </asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
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
                </div>                
                <br />
                <div class="container">
                    <div class="card card-responsive" style="width: auto;">
                        <div class="card-header">
                            1. MOTIVO DE CONSULTA
                        </div>
                        <div class="list-group list-group-flush" style="padding: 10px; text-align:center">
                            <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                                <asp:TableRow Style="text-align: center">
                                    <asp:TableCell Text="MOTIVO DE CONSULTA"></asp:TableCell>
                                    <asp:TableCell Text="MOTIVO DE CONSULTA (según acompañante)"></asp:TableCell>
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
                </div>
                <br />
                <div class="container">
                    <div class="card card-responsive" style="width: auto;">
                        <div class="card-header">
                            2. ANTECEDENTES PERSONALES
                        </div>
                        <div class="list-group list-group-flush" style="padding: 10px; text-align:center">
                            <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                                <asp:TableRow Style="text-align: center">
                                    <asp:TableCell Text="TIPO DE ANTECEDENTE"></asp:TableCell>
                                    <asp:TableCell Text="ANTECEDENTE"></asp:TableCell>
                                    <asp:TableCell Text="DESCRIPCIÓN"></asp:TableCell>
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
                                </asp:TableRow>
                            </asp:Table>
                        </div>
                    </div>
                </div>
                <br />
                <div class="container">
                    <div class="card card-responsive" style="width: auto;">
                        <div class="card-header">
                            3. ANTECEDENTES FAMILIARES
                        </div>
                        <div class="list-group list-group-flush" style="padding: 10px; text-align:center">
                            <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                                <asp:TableRow Style="text-align: center">
                                    <asp:TableCell Text="TIPO DE ANTECEDENTE"></asp:TableCell>
                                    <asp:TableCell Text="ANTECEDENTE"></asp:TableCell>
                                    <asp:TableCell Text="DESCRIPCIÓN"></asp:TableCell>
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
                            <asp:Table class="table table-bordered table-light" runat="server">
                                <asp:TableRow Style="text-align: center; background-color: #DAFEF9">
                                    <asp:TableCell Text="ÓRGANOS  Y SISTEMAS"></asp:TableCell>
                                    <asp:TableCell Text="EVIDENCIA PATOLÓGICA"></asp:TableCell>
                                    <asp:TableCell Text="DESCRIPCIÓN"></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell Text="Órganos de los Sentidos"></asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell Text="Respiratorio"></asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell Text="Cardio Vascular"></asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" ></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell Text="Digestivo"></asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell Text="Genital"></asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell Text="Urinario"></asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell Text="Muscular"></asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell Text="Esquelético"></asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell Text="Nervioso"></asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell Text="Endocrino"></asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell Text="Hemo Linfático"></asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell Text="Tegumentario (Piel y Faneras)"></asp:TableCell>
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
                </div>
                <br />
                <div class="container-fluid">
                    <div class="card card-responsive" style="width: auto">
                        <div class="card-header">
                            6. SIGNOS VITALES Y ANTROPOMÉTRICOS 
                        </div>
                        <div class="list-group list-group-flush" style="padding: 10px; width: auto">
                            <div class="container">
                                <asp:Table CssClass="table table-bordered table-light" runat="server">
                                    <asp:TableRow>
                                        <asp:TableCell Style="width: 100px" Text="FECHA:"></asp:TableCell>
                                        <asp:TableCell>
                                            <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%" TextMode="Date"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell Style="background-color: #DAFEF9" Text="PROFESIONAL:"></asp:TableCell>
                                        <asp:TableCell>
                                            <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell Style="background-color: #DAFEF9" Text="ESPECIALIDAD:"></asp:TableCell>
                                        <asp:TableCell>
                                            <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                </asp:Table>
                            </div>
                            <div class="container" style="padding-top: 10px">
                                <asp:Table CssClass="table table-bordered" runat="server">
                                    <asp:TableRow>
                                        <asp:TableCell Style="width: auto" Text="FC"></asp:TableCell>
                                        <asp:TableCell style="width: 75px;">
                                            <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                        </asp:TableCell>
                                        <asp:TableCell Style="width: auto" Text="Pr. Sist."></asp:TableCell>
                                        <asp:TableCell style="width: 75px;">
                                            <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell Style="width: auto" Text="Pr. Med."></asp:TableCell>
                                        <asp:TableCell style="width: 75px;">
                                            <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                        </asp:TableCell>
                                        <asp:TableCell Style="width: auto" Text="Temp."></asp:TableCell>
                                        <asp:TableCell style="width: 75px;">
                                            <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell Style="width: auto" Text="Pr. Diast."></asp:TableCell>
                                        <asp:TableCell style="width: 75px;">
                                            <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                </asp:Table>
                                <br />
                                <asp:Table CssClass="table table-bordered" runat="server">
                                    <asp:TableRow>
                                        <asp:TableCell Style="width: auto" Text="FC"></asp:TableCell>
                                        <asp:TableCell style="width: 75px">
                                            <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                        </asp:TableCell>
                                        <asp:TableCell Style="width: auto" Text="Pr. Sist."></asp:TableCell>
                                        <asp:TableCell style="width: 75px">
                                            <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell Style="width: auto" Text="Pr. Med."></asp:TableCell>
                                        <asp:TableCell style="width: 75px">
                                            <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                        </asp:TableCell>
                                        <asp:TableCell Style="width: auto" Text="Temp."></asp:TableCell>
                                        <asp:TableCell style="width: 75px">
                                            <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell Style="width: auto" Text="Pr. Diast."></asp:TableCell>
                                        <asp:TableCell style="width: 75px; text-align:center">
                                            <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                </asp:Table>
                            </div>
                        </div>
                    </div>
                </div>
                <br />
                <div class="container">
                    <div class="card card-responsive" style="width: auto;">
                        <div class="card-header">
                            7. EXAMEN FÍSICO
                        </div>
                        <div class="list-group list-group-flush" style="padding: 10px; text-align:center">
                            <asp:Table class="table table-bordered table-light" style="text-align: center" runat="server">
                                <asp:TableRow>
                                    <asp:TableCell Text="EXAMEN/REGIÓN ANATÓMICA"></asp:TableCell>
                                    <asp:TableCell Text="EVIDENCIA PATOLÓGICA"></asp:TableCell>
                                    <asp:TableCell Text="DESCRIPCIÓN"></asp:TableCell>
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
                                </asp:TableRow>
                            </asp:Table>
                        </div>
                    </div>
                </div>
                <br />
                <div class="container-fluid">
                    <div class="card" style="width: auto;">
                        <div class="card-header">
                            8. DIAGNÓSTICOS
                        </div>
                        <div class="list-group list-group-flush" style="padding: 10px; text-align:center">
                            <asp:Table class="table table-bordered table-light" style="text-align: center" runat="server">
                                <asp:TableRow>
                                    <asp:TableCell Text="DIAGNÓSTICOS"></asp:TableCell>
                                    <asp:TableCell Text="CÓDIGO"></asp:TableCell>
                                    <asp:TableCell Text="TIPO"></asp:TableCell>
                                    <asp:TableCell Text="CONDICIÓN"></asp:TableCell>
                                    <asp:TableCell Text="CRONOLOGÍA"></asp:TableCell>
                                    <asp:TableCell Text="DESCRIPCIÓN"></asp:TableCell>
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
                </div>
                <br />
                <div class="container-fluid">
                    <div class="card" style="width: auto;">
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
                    <div class="card" style="width: auto;">
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
                    <div class="card" style="width: auto;">
                        <div class="card-header">
                            11. PRESCRIPCIONES
                        </div>
                        <div class="list-group list-group-flush">
                            <textarea id="" cols="20" rows="2" style="border: none"></textarea>
                        </div>
                    </div>
                </div>
                <br />
                <div class="container">
                    <div class="card" style="width: auto;">                        
                        <div class="list-group list-group-flush" style="padding: 10px;">
                            <asp:Table class="table table-bordered table-light table-responsive text-center" style="text-align: center" runat="server">
                                <asp:TableRow>
                                    <asp:TableCell Text="FECHA"></asp:TableCell>
                                    <asp:TableCell Text="HORA"></asp:TableCell>
                                    <asp:TableCell Text="ESPECIALIDAD"></asp:TableCell>
                                    <asp:TableCell Text="NOMBRE DEL PROFESIONAL"></asp:TableCell>
                                    <asp:TableCell Text="CÓDIGO"></asp:TableCell>
                                    <asp:TableCell Text="FIRMA" style="width:150px"></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Time"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell style="width:150px"></asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
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
