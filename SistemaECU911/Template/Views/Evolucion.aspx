﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Views/Principal.Master" AutoEventWireup="true" CodeBehind="Evolucion.aspx.cs" Inherits="SistemaECU911.Template.Views.Evolucion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="background-color: white">
        <br />
        <div class="container">
            <div class="text-center" style="font-size: 25px">
                GESTIÓN DE SEGURIDAD Y SALUD OCUPACIONAL<br />
                HOJA DE EVOLUCIÓN
            </div>
        </div>
        <br />
        <div class="card" style="width: auto;">
            <div class="card-header" style="background-color: #cccdfe;  font-weight:bold">
                A. DATOS DEL ESTABLECIMIENTO - EMPRESA Y USUARIO
            </div>
            <div class="list-group list-group-flush">
                <asp:Table class="table table-bordered table-light text-center" runat="server">
                    <asp:TableRow>
                        <asp:TableCell Text="INSTITUCIÓN DEL SISTEMA O NOMBRE DE LA EMPRESA" style="background-color: #cdfecc; font-size:15px"></asp:TableCell>
                        <asp:TableCell Text="RUC" style="background-color: #cdfecc; font-size:15px"></asp:TableCell>
                        <asp:TableCell Text="CIIU" style="background-color: #cdfecc; font-size:15px"></asp:TableCell>
                        <asp:TableCell Text="ESTABLECIMIENTO DE SALUD" style="background-color: #cdfecc; font-size:15px"></asp:TableCell>
                        <asp:TableCell Text="NÚMERO DE HISTORIA CLÍNICA" style="background-color: #cdfecc; font-size:15px"></asp:TableCell>
                        <asp:TableCell Text="NÚMERO DE ARCHIVO" style="background-color: #cdfecc; font-size:15px"></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center;" Text="Servicio Integrado de Seguridad Sis ECU 911" ReadOnly="true"></asp:TextBox>
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
                            <asp:TextBox runat="server" ID="txt_numHClinica" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" OnTextChanged="txt_numHClinica_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
                <asp:Table class="table table-bordered table-light text-center" runat="server">
                    <asp:TableRow>
                        <asp:TableCell Text="PRIMER APELLIDO" style="background-color: #cdfecc; font-size:15px"></asp:TableCell>
                        <asp:TableCell Text="SEGUNDO APELLIDO" style="background-color: #cdfecc; font-size:15px"></asp:TableCell>
                        <asp:TableCell Text="PRIMER NOMBRE" style="background-color: #cdfecc; font-size:15px"></asp:TableCell>
                        <asp:TableCell Text="SEGUNDO NOMBRE" style="background-color: #cdfecc; font-size:15px"></asp:TableCell>
                        <asp:TableCell Text="SEXO" style="background-color: #cdfecc; font-size:15px"></asp:TableCell>
                        <asp:TableCell Text="PUESTO DE TRABAJO (CIUO)" style="background-color: #cdfecc; font-size:15px"></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:TextBox runat="server" ID="txt_priApellido" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" ID="txt_segApellido" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" ID="txt_priNombre" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" ID="txt_segNombre" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" ID="txt_sexo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </div>
        </div>
        <br />
        <div class="card" style="width: 100%;">
            <div class="row">
                <div class="card-header col" style="text-align: center; margin-left: 0.8rem; background-color: #cccdfe; font-weight:bold">
                    B. EVOLUCIÓN                                          
                </div>
                <div class="card-header col" style="text-align: center; margin-right: 0.8rem; background-color: #cccdfe; font-weight:bold">
                    C. PRESCRIPCIONES                                         
                </div>
            </div>
            <asp:Table class="table table-bordered table-light text-center" runat="server">
                <asp:TableRow>
                    <asp:TableCell Text="FECHA" style="background-color: #cdfecc; font-size:15px"></asp:TableCell>
                    <asp:TableCell Text="HORA" style="background-color: #cdfecc; font-size:15px"></asp:TableCell>
                    <asp:TableCell Text="NOTAS DE EVOLUCION" style="background-color: #cdfecc; font-size:15px"></asp:TableCell>
                    <asp:TableCell Text="FARMACOTERAPIA INDICACIONES PARA ENFERMERIA Y OTRAS PERSONAS" style="background-color: #cdfecc; font-size:15px"></asp:TableCell>
                    <asp:TableCell Text="ADMINISTRACIÓN FARMACOS Y OTROS" style="background-color: #cdfecc; font-size:15px"></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_fecha1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_hora1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Time"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_notas1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_farmacoterapia1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_administracion1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_fecha2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_hora2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Time"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_notas2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_farmacoterapia2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_administracion2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_fecha3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_hora3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Time"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_notas3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_farmacoterapia3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_administracion3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_fecha4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_hora4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Time"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_notas4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_farmacoterapia4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_administracion4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_fecha5" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_hora5" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Time"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_notas5" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_farmacoterapia5" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_administracion5" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_fecha6" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_hora6" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Time"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_notas6" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_farmacoterapia6" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_administracion6" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_fecha7" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_hora7" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Time"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_notas7" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_farmacoterapia7" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_administracion7" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_fecha8" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_hora8" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Time"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_notas8" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_farmacoterapia8" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_administracion8" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_fecha9" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_hora9" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Time"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_notas9" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_farmacoterapia9" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_administracion9" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_fecha10" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_hora10" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Time"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_notas10" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_farmacoterapia10" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_administracion10" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_fecha11" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_hora11" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Time"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_notas11" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_farmacoterapia11" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_administracion11" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_fecha12" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_hora12" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Time"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_notas12" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_farmacoterapia12" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_administracion12" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_fecha13" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_hora13" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Time"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_notas13" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_farmacoterapia13" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_administracion13" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_fecha14" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_hora14" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Time"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_notas14" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_farmacoterapia14" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_administracion14" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_fecha15" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_hora15" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Time"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_notas15" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_farmacoterapia15" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txt_administracion15" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
        <br />
        <div class="container" align="center">
            <asp:Button CssClass="btn btn-warning" ID="btn_guardar" runat="server" Text="Guardar" OnClick="btn_guardar_Click" UseSubmitBehavior="False" />
            <asp:Button CssClass="btn btn-success" ID="btn_modificar" runat="server" Text="Modificar" OnClick="btn_modificar_Click" UseSubmitBehavior="False" />
            <asp:Button CssClass="btn btn-danger" ID="btn_cancelar" runat="server" Text="Cancelar" OnClick="btn_cancelar_Click" UseSubmitBehavior="False" />
        </div>
        <br />
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
