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
                        <div class="card-header" style="font-size: 25px; background-color: #34495E; color: white">
                            GESTIÓN DE SEGURIDAD Y SALUD OCUPACIONAL                           
                        </div>
                        <div style="font-size: 25px; background-color: #34495E; color: white">
                            HISTORIA CLÍNICA OCUPACIONAL - INICIAL
                        </div>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" style="background-color: #34495E; color: white">
                        A. DATOS DEL ESTABLECIMIENTO - EMPRESA Y USUARIO
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="INSTITUCIÓN DEL SISTEMA O NOMBRE DE LA EMPRESA" Style="width: 350px; background-color: #34495E; color: white; font-size: 16px"></asp:TableCell>
                                <asp:TableCell Text="RUC" Style="width: 120px; background-color: #34495E; color: white; font-size: 16px"></asp:TableCell>
                                <asp:TableCell Text="CIIU" Style="width: 120px; background-color: #34495E; color: white; font-size: 16px"></asp:TableCell>
                                <asp:TableCell Text="ESTABLECIMIENTO DE SALUD" Style="width: 250px; background-color: #34495E; color: white; font-size: 16px"></asp:TableCell>
                                <asp:TableCell Text="NÚMERO DE HISTORIA CLÍNICA" Style="width: 200px; background-color: #34495E; color: white; font-size: 16px"></asp:TableCell>
                                <asp:TableCell Text="NÚMERO DE ARCHIVO" Style="width: 200px; background-color: #34495E; color: white; font-size: 16px"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_nomEmpresa" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center;" Text="Servicio Integrado de Seguridad"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_rucEmp" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" Text="1768174880001"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_estableSalud" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" Text="Consultorio Médico"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_numHClinica" BorderStyle="None" OnTextChanged="txt_numHClinica_TextChanged" AutoPostBack="true" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_numArchivo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell RowSpan="2" Text="PRIMER APELLIDO" Style="width: 165px; background-color: #34495E; color: white; font-size: 16px"></asp:TableCell>
                                <asp:TableCell RowSpan="2" Text="SEGUNDO APELLIDO" Style="width: 175px; background-color: #34495E; color: white; font-size: 16px"></asp:TableCell>
                                <asp:TableCell RowSpan="2" Text="PRIMER NOMBRE" Style="width: 165px; background-color: #34495E; color: white; font-size: 16px"></asp:TableCell>
                                <asp:TableCell RowSpan="2" Text="SEGUNDO NOMBRE" Style="width: 175px; background-color: #34495E; color: white; font-size: 16px"></asp:TableCell>
                                <asp:TableCell RowSpan="2" Text="SEXO" Style="width: 50px; background-color: #34495E; color: white; font-size: 16px"></asp:TableCell>
                                <asp:TableCell RowSpan="2" Text="EDAD (AÑOS)" Style="width: 75px; background-color: #34495E; color: white; font-size: 16px"></asp:TableCell>
                                <asp:TableCell ColumnSpan="5" Text="RELIGIÓN" Style="width: 175px; background-color: #34495E; color: white; font-size: 16px"></asp:TableCell>
                                <asp:TableCell RowSpan="2" Text="GRUPO SANGUÍNEO" Style="width: 125px; background-color: #34495E; color: white; font-size: 16px"></asp:TableCell>
                                <asp:TableCell RowSpan="2" Text="LATERALIDAD" Style="width: 200px; background-color: #34495E; color: white; font-size: 16px"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="width: 20px; background-color: #34495E; color: white; font-size: 16px">
                                    <asp:Label CssClass="in-column" ID="lbl_catolica" runat="server" Text="Católica"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 20px; background-color: #34495E; color: white; font-size: 16px">
                                    <asp:Label CssClass="in-column" ID="Label1" runat="server" Text="Evangélica"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 20px; background-color: #34495E; color: white; font-size: 16px">
                                    <asp:Label CssClass="in-column" ID="Label2" runat="server" Text="Testigos de Jehová"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 20px; background-color: #34495E; color: white; font-size: 16px">
                                    <asp:Label CssClass="in-column" ID="Label3" runat="server" Text="Mormona"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 20px; background-color: #34495E; color: white; font-size: 16px">
                                    <asp:Label CssClass="in-column" ID="Label4" runat="server" Text="Otras"></asp:Label>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_priApellido" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_segApellido" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_priNombre" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_segNombre" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_sexo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_edadinicial" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_catolica" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_evangelica" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_testigo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_mormona" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_otrareligion" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_gruposanguineo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_lateralidad" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="5" Text="ORIENTACION SEXUAL" Style="width: 175px; background-color: #34495E; color: white; font-size: 16px"></asp:TableCell>
                                <asp:TableCell ColumnSpan="5" Text="IDENTIDAD DE GENERO" Style="width: 175px; background-color: #34495E; color: white; font-size: 16px"></asp:TableCell>
                                <asp:TableCell ColumnSpan="4" Text=" DISCAPACIDAD" Style="width: 250px; background-color: #34495E; color: white; font-size: 16px"></asp:TableCell>
                                <asp:TableCell RowSpan="2" Text="FECHA DE INGRESO AL TRABAJO <br /> (dd/mm/aaaa)" Style="width: 125px; background-color: #34495E; color: white; font-size: 16px"></asp:TableCell>
                                <asp:TableCell RowSpan="2" Text="PUESTO DE TRABAJO (CIUO)" Style="width: 250px; background-color: #34495E; color: white; font-size: 16px"></asp:TableCell>
                                <asp:TableCell RowSpan="2" Text="ÁREA DE TRABAJO" Style="width: 300px; background-color: #34495E; color: white; font-size: 16px"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="width: 15px; background-color: #34495E; color: white; font-size: 16px">
                                    <asp:Label CssClass="in-column" ID="Label5" runat="server" Text="Lesbiana"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 15px; background-color: #34495E; color: white; font-size: 16px">
                                    <asp:Label CssClass="in-column" ID="Label6" runat="server" Text="Gay"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 15px; background-color: #34495E; color: white; font-size: 16px">
                                    <asp:Label CssClass="in-column" ID="Label7" runat="server" Text="Bisexual"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 15px; background-color: #34495E; color: white; font-size: 16px">
                                    <asp:Label CssClass="in-column" ID="Label8" runat="server" Text="Heterosexual"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 15px; background-color: #34495E; color: white; font-size: 16px">
                                    <asp:Label CssClass="in-column" ID="Label9" runat="server" Text="No sabe/No responde"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 15px; background-color: #34495E; color: white; font-size: 16px">
                                    <asp:Label CssClass="in-column" ID="Label10" runat="server" Text="Femenino"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 15px; background-color: #34495E; color: white; font-size: 16px">
                                    <asp:Label CssClass="in-column" ID="Label11" runat="server" Text="Masculino"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 15px; background-color: #34495E; color: white; font-size: 16px">
                                    <asp:Label CssClass="in-column" ID="Label12" runat="server" Text="Trans-femenino"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 15px; background-color: #34495E; color: white; font-size: 16px">
                                    <asp:Label CssClass="in-column" ID="Label13" runat="server" Text="Trans-masculino"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 15px; background-color: #34495E; color: white; font-size: 16px">
                                    <asp:Label CssClass="in-column" ID="Label14" runat="server" Text="No sabe/No responde"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 20px; background-color: #34495E; color: white; font-size: 14px">SI</asp:TableCell>
                                <asp:TableCell Style="width: 20px; background-color: #34495E; color: white; font-size: 14px">NO</asp:TableCell>
                                <asp:TableCell Style="width: 125px; background-color: #34495E; color: white; font-size: 14px">TIPO</asp:TableCell>
                                <asp:TableCell Style="width: 71px; background-color: #34495E; color: white; font-size: 14px">%</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_lesbiana" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_gay" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_bisexual" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_heterosexual" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_noRespondeOriSex" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_femenino" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_masculino" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_transfemenino" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_transmasculino" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_noRespondeIdeGen" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_sidiscapacidad" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_nodiscapacidad" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_tipodiscapacidad" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_porcentajediscapacidad" TextMode="Number" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_fechaingresotrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_puestodetrabajociuo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_areadetrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="ACTIVIDADES RELEVANTES AL PUESTO DE TRABAJO A OCUPAR" Style="width: 1400px; background-color: #34495E; color: white; font-size: 16px"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_actividadesrelevantes" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="row">
                        <div class="card-header col" style="margin-left: 0.8rem; background-color: #34495E; color: white; font-size:16px">
                            B. MOTIVO DE CONSULTA                                           
                        </div>
                        <div class="card-header col" style="text-align: right; font-size: 13px; margin-right: 0.8rem; background-color: #34495E; color: white">
                            ANOTAR LA CAUSA DEL PROBLEMA EN LA VERSIÓN DEL INFORMANTE                                          
                        </div>
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:TextBox ID="txt_motivoconsultainicial" runat="server" BorderStyle="None" Style="background-color: transparent; width: 100%;" placeholder="Descripción:" TextMode="MultiLine" Rows="3"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" style="background-color: #34495E; color: white; font-size:16px">
                        C. ANTECEDENTES PERSONALES
                    </div>
                    <div class="card-header" style="background-color:#34495E; color: white; font-size: 16px">
                        ANTECEDENTES CLÍNICOS Y QUIRÚRGICOS
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:TextBox runat="server" ID="txt_antCliQuiDescripcion" BorderStyle="None" Style="width: 100%" TextMode="MultiLine" Rows="3" placeholder="Descripción:"></asp:TextBox>
                    </div>
                    <div class="card" style="width: auto;">
                        <div class="card-header" style="background-color:#34495E; color: white; font-size: 16px">
                            ANTECEDENTES GINECO OBSTÉTRICOS
                        </div>
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell RowSpan="2" style="width:125px; background-color: #34495E; color: white; font-size:16px">MENARQUÍA</asp:TableCell>
                            <asp:TableCell RowSpan="2" style="width:75px; background-color: #34495E; color: white; font-size:16px">CICLOS</asp:TableCell>
                            <asp:TableCell RowSpan="2" style="width:125px; background-color: #34495E; color: white; font-size:16px">FECHA DE ULTIMA MENSTRUACIÓN <br /> dd/mm/aaaa </asp:TableCell>
                            <asp:TableCell RowSpan="2" style="width:75px; background-color: #34495E; color: white; font-size:16px">GESTAS</asp:TableCell>
                            <asp:TableCell RowSpan="2" style="width:75px; background-color: #34495E; color: white; font-size:16px">PARTOS</asp:TableCell>
                            <asp:TableCell RowSpan="2" style="width:75px; background-color: #34495E; color: white; font-size:16px">CESÁREAS</asp:TableCell>
                            <asp:TableCell RowSpan="2" style="width:75px; background-color: #34495E; color: white; font-size:16px">ABORTOS</asp:TableCell>
                            <asp:TableCell ColumnSpan="2" style="width:175px; background-color: #34495E; color: white; font-size:16px">HIJOS</asp:TableCell>
                            <asp:TableCell ColumnSpan="2" style="width:150px; background-color: #34495E; color: white; font-size:16px">VIDA SEXUAL ACTIVA</asp:TableCell>
                            <asp:TableCell ColumnSpan="3" style="width:300px; background-color: #34495E; color: white; font-size:16px">METODO DE PLANIFICACIÓN FAMILIAR</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="width:50px; background-color: #34495E; color: white; font-size:16px">VIVOS</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: #34495E; color: white; font-size:16px">MUERTOS</asp:TableCell>
                            <asp:TableCell style="width:25px; background-color: #34495E; color: white; font-size:16px">SI</asp:TableCell>
                            <asp:TableCell style="width:25px; background-color: #34495E; color: white; font-size:16px">NO</asp:TableCell>
                            <asp:TableCell style="width:30px; background-color: #34495E; color: white; font-size:16px">SI</asp:TableCell>
                            <asp:TableCell style="width:30px; background-color: #34495E; color: white; font-size:16px">NO</asp:TableCell>
                            <asp:TableCell style="width:100px; background-color: #34495E; color: white; font-size:16px">TIPO</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_menarquiaAntGinObste" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_ciclosAntGinObste" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_fechUltiMensAntGinObste" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_gestasAntGinObste" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_partosAntGinObste" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_cesareasAntGinObste" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_abortosAntGinObste" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px"> 
                                <asp:TextBox runat="server" ID="txt_vivosAntGinObste" BorderStyle="None" TextMode="Number" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_muertosAntGinObste" BorderStyle="None" TextMode="Number" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_siVidSexAntGinObste" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_noVidSexAntGinObste" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_siMetPlaniAntGinObste" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_noMetPlaniAntGinObste" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tipoMetPlaniAntGinObste" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell style="width:200px; background-color: #34495E; color: white; font-size:16px">EXAMENES REALIZADOS</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: #34495E; color: white; font-size:16px">SI</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: #34495E; color: white; font-size:16px">NO</asp:TableCell>
                            <asp:TableCell style="width:125px; background-color: #34495E; color: white; font-size:16px">TIEMPO <br />(años)</asp:TableCell>
                            <asp:TableCell style="width:250px; background-color: #34495E; color: white; font-size:16px">RESULTADO</asp:TableCell>
                            <asp:TableCell style="width:200px; background-color: #34495E; color: white; font-size:16px">EXAMENES REALIZADOS</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: #34495E; color: white; font-size:16px">SI</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: #34495E; color: white; font-size:16px">NO</asp:TableCell>
                            <asp:TableCell style="width:125px; background-color: #34495E; color: white; font-size:16px">TIEMPO <br />(años)</asp:TableCell>
                            <asp:TableCell style="width:250px; background-color: #34495E; color: white; font-size:16px">RESULTADO</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">PAPANICOLAOU</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_siPapaniAntGinObste" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_noPapaniAntGinObste" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiempoPapaniAntGinObste" TextMode="Number" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_resultadoPapaniAntGinObste" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">ECO MAMARIO</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_siEcoMamaAntGinObste" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_noEcoMamaAntGinObste" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiempoEcoMamaAntGinObste" TextMode="Number" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_resultadoEcoMamaAntGinObste" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">COLPOSCOPIA</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_siColposAntGinObste" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_noColposAntGinObste" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiempoColposAntGinObste" TextMode="Number" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_resultadoColposAntGinObste" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">MAMOGRAFÍA</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_siMamograAntGinObste" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_noMamograAntGinObste" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiempoMamograAntGinObste" TextMode="Number" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_resultadoMamograAntGinObste" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <div class="card" style="width: auto;">
                        <div class="card-header col" style="background-color: #34495E; color: white; font-size:16px">
                            ANTECEDENTES REPRODUCTIVOS MASCULINOS
                        </div>
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell RowSpan="2" style="width:200px; background-color: #34495E; color: white; font-size:16px">EXAMENES REALIZADOS</asp:TableCell>
                            <asp:TableCell RowSpan="2" style="width:50px; background-color: #34495E; color: white; font-size:16px">SI</asp:TableCell>
                            <asp:TableCell RowSpan="2" style="width:50px; background-color: #34495E; color: white; font-size:16px">NO</asp:TableCell>
                            <asp:TableCell RowSpan="2" style="width:125px; background-color: #34495E; color: white; font-size:16px">TIEMPO <br />(años)</asp:TableCell>
                            <asp:TableCell RowSpan="2" style="width:250px; background-color: #34495E; color: white; font-size:16px">RESULTADO</asp:TableCell>
                            <asp:TableCell ColumnSpan="3" style="width:450px; background-color: #34495E; color: white; font-size:16px">MÉTODO DE PLANIFICACIÓN FAMILIAR</asp:TableCell>
                            <asp:TableCell ColumnSpan="2" style="width:150px; background-color: #34495E; color: white; font-size:16px">HIJOS</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="width:50px; background-color: #34495E; color: white; font-size:16px">SI</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: #34495E; color: white; font-size:16px">NO</asp:TableCell>
                            <asp:TableCell style="width:350px; background-color: #34495E; color: white; font-size:16px">TIPO</asp:TableCell>
                            <asp:TableCell style="width:75px; background-color: #34495E; color: white; font-size:16px">VIVOS</asp:TableCell>
                            <asp:TableCell style="width:75px; background-color: #34495E; color: white; font-size:16px">MUERTOS</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">ANTÍGENO PROSTÁTICO</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_siExaRealiAntProstaAntReproMascu" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_noExaRealiAntProstaAntReproMascu" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiempoExaRealiAntProstaAntReproMascu" TextMode="Number" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_resultadoExaRealiAntProstaAntReproMascu" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell RowSpan="2" Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_siMetPlaniAntReproMascu" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell RowSpan="2" Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_noMetPlaniAntReproMascu" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tipo1MetPlaniAntReproMascu" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell RowSpan="2" Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_vivosHijosAntReproMascu" TextMode="Number" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell RowSpan="2" Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_muertosHijosAntReproMascu" TextMode="Number" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">ECO PROSTÁTICO</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_siExaRealiEcoProstaAntReproMascu" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_noExaRealiEcoProstaAntReproMascu" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiempoExaRealiEcoProstaAntReproMascu" TextMode="Number" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_resultadoExaRealiEcoProstaAntReproMascu" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tipo2MetPlaniAntReproMascu" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <div class="card" style="width: auto;">
                        <div class="card-header col" style="background-color: #34495E; color: white; font-size:16px">
                            HÁBITOS TÓXICOS 
                        </div>
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell style="width:250px; background-color: #34495E; color: white; font-size:16px">CONSUMOS NOCIVOS</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: #34495E; color: white; font-size:16px">SI</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: #34495E; color: white; font-size:16px">NO</asp:TableCell>
                            <asp:TableCell style="width:250px; background-color: #34495E; color: white; font-size:16px">TIEMPO DE CONSUMO <br />(meses)</asp:TableCell>
                            <asp:TableCell style="width:250px; background-color: #34495E; color: white; font-size:16px">CANTIDAD</asp:TableCell>
                            <asp:TableCell style="width:250px; background-color: #34495E; color: white; font-size:16px">EX CONSUMIDOR</asp:TableCell>
                            <asp:TableCell style="width:250px; background-color: #34495E; color: white; font-size:16px">TIEMPO DE ABSTINENCIA <br /> (meses)</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">TABACO</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_siConsuNociTabaHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_noConsuNociTabaHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiemConConsuNociTabaHabToxi" TextMode="Number" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_cantiConsuNociTabaHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_exConsumiConsuNociTabaHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiemAbstiConsuNociTabaHabToxi" TextMode="Number" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">ALCOHOL</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_siConsuNociAlcoHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_noConsuNociAlcoHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiemConConsuNociAlcoHabToxi" TextMode="Number" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_cantiConsuNociAlcoHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_exConsumiConsuNociAlcoHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiemAbstiConsuNociAlcoHabToxi" TextMode="Number" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">OTRAS DROGAS</asp:TableCell>
                            <asp:TableCell RowSpan="2" Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_siConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell RowSpan="2" Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_noConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiemCon1ConsuNociOtrasDroHabToxi" TextMode="Number" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_canti1ConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_exConsumi1ConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiemAbsti1ConsuNociOtrasDroHabToxi" TextMode="Number" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_otrasConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="_________________________"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiemCon2ConsuNociOtrasDroHabToxi" TextMode="Number" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_canti2ConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_exConsumi2ConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiemAbsti2ConsuNociOtrasDroHabToxi" TextMode="Number" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <div class="card" style="width: auto;">
                        <div class="card-header" style="background-color: #34495E; color: white; font-size:16px">
                            ESTILO DE VIDA
                        </div>
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell style="width:400px; background-color: #34495E; color: white; font-size:16px">ESTILO</asp:TableCell>
                            <asp:TableCell style="width:75px; background-color: #34495E; color: white; font-size:16px">SI</asp:TableCell>
                            <asp:TableCell style="width:75px; background-color: #34495E; color: white; font-size:16px">NO</asp:TableCell>
                            <asp:TableCell style="width:400px; background-color: #34495E; color: white; font-size:16px">¿CUÁL?</asp:TableCell>
                            <asp:TableCell style="width:375px; background-color: #34495E; color: white; font-size:16px">TIEMPO/CANTIDAD</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">ACTIVIDAD FÍSICA</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_siEstVidaActFisiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_noEstVidaActFisiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_cualEstVidaActFisiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiemCanEstVidaActFisiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell RowSpan="3" style="background-color: #34495E; color: white; font-size:16px">MEDICACIÓN HABITUAL</asp:TableCell>
                            <asp:TableCell RowSpan="3" Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_siEstVidaMedHabiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell RowSpan="3" Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_noEstVidaMedHabiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_cual1EstVidaMedHabiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiemCan1EstVidaMedHabiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_cual2EstVidaMedHabiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiemCan2EstVidaMedHabiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_cual3EstVidaMedHabiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiemCan3EstVidaMedHabiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" style="background-color: #34495E; color: white; font-size:16px">
                        D. ANTECEDENTES DE TRABAJO
                    </div>
                    <div class="card-header" style="background-color: #34495E; color: white; font-size:16px">
                        ANTECEDENTES DE EMPLEOS ANTERIORES
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell RowSpan="2" style="width:300px; background-color: #34495E; color: white; font-size:16px">EMPRESA</asp:TableCell>
                            <asp:TableCell RowSpan="2" style="width:200px; background-color: #34495E; color: white; font-size:16px">PUESTO DE TRABAJO</asp:TableCell>
                            <asp:TableCell RowSpan="2" style="width:350px; background-color: #34495E; color: white; font-size:16px">ACTVIDADES QUE DESEMPEÑA</asp:TableCell>
                            <asp:TableCell RowSpan="2" style="width:100px; background-color: #34495E; color: white; font-size:16px">TIEMPO DE TRABAJO <br />(meses)</asp:TableCell>
                            <asp:TableCell ColumnSpan="6" style="width:150px; background-color: #34495E; color: white; font-size:16px">RIESGO</asp:TableCell>
                            <asp:TableCell RowSpan="2" style="width:400px; background-color: #34495E; color: white; font-size:16px">OBSERVACIONES</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="width:20px; background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label15" runat="server" Text="Físico"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="width:20px; background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label16" runat="server" Text="Mecánico"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="width:20px; background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label17" runat="server" Text="Químico"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="width:20px; background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label18" runat="server" Text="Biólogo"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="width:20px; background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label19" runat="server" Text="Ergonómico"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="width:20px; background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label20" runat="server" Text="Psicosocial"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_empresa" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_puestotrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_actdesempeña" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiempotrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_fisico" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_mecanico" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_quimico" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_biologico" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_ergonomico" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_psicosocial" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_obseantempleanteriores" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_empresa2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_puestotrabajo2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_actdesempeña2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiempotrabajo2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_fisico2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_mecanico2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_quimico2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_biologico2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_ergonomico2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_psicosocial2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_obseantempleanteriores2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_empresa3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_puestotrabajo3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_actdesempeña3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiempotrabajo3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_fisico3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_mecanico3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_quimico3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_biologico3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_ergonomico3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_psicosocial3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_obseantempleanteriores3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_empresa4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_puestotrabajo4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_actdesempeña4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiempotrabajo4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_fisico4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_mecanico4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_quimico4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_biologico4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_ergonomico4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_psicosocial4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_obseantempleanteriores4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow> 
                    </asp:Table>
                    <div class="card" style="width: auto;">
                        <div class="card-header" style="background-color: #34495E; color: white; font-size:16px">
                            ACCIDENTES DE TRABAJO (DESCRIPCIÓN)
                        </div>
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell style="width:600px; background-color: #34495E; color: white; font-size:16px">FUE CALIFICADO POR EL INSTITUTO DE SEGURIDAD SOCIAL CORRESPONDIENTE: </asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: #34495E; color: white; font-size:16px">SI</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_si" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="width:100px; background-color: #34495E; color: white; font-size:16px">ESPECIFICAR</asp:TableCell>
                            <asp:TableCell style="width:150px; background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_especificar" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="_________________"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: #34495E; color: white; font-size:16px">NO</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_no" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="width:75px; background-color: #34495E; color: white; font-size:16px">FECHA:</asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_fecha" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="9" style="background-color: white; font-size: 14px">
                                <asp:TextBox ID="txt_observaciones2" BorderStyle="None" Style="background-color: transparent; width: 100%;" placeholder="Observaciones:" TextMode="MultiLine" Rows="3" runat="server"></asp:TextBox>
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
                            <asp:TableCell style="width:600px; background-color: #34495E; color: white; font-size:16px">FUE CALIFICADO POR EL INSTITUTO DE SEGURIDAD SOCIAL CORRESPONDIENTE: </asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: #34495E; color: white; font-size:16px">SI</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_siprofesional" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="width:100px; background-color: #34495E; color: white; font-size:16px">ESPECIFICAR</asp:TableCell>
                            <asp:TableCell style="width:150px; background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_espeprofesional" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="_________________"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: #34495E; color: white; font-size:16px">NO</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_noprofesional" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="width:75px; background-color: #34495E; color: white; font-size:16px">FECHA:</asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_fechaprofesional" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="9" style="background-color: white; font-size: 14px">
                                <asp:TextBox ID="txt_observaciones3" BorderStyle="None" Style="background-color: transparent; width: 100%;" placeholder="Observaciones:" TextMode="MultiLine" Rows="3" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="row">
                        <div class="card-header col" style="margin-left: 0.8rem; background-color: #34495E; color: white; font-size:16px" >
                            E. ANTECEDENTES FAMILIARES (DETALLAR EL PARENTESCO)                                          
                        </div>
                        <div class="card-header col" style="text-align: right; font-size: 13px; margin-right: 0.8rem; background-color: #34495E; color: white">
                            MARCAR Y DESCRIBIR ABAJO ANOTANDO EL NÚMERO                                          
                        </div>
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell style="width:250px; background-color: #34495E; color: white; font-size:16px">1. ENFERMEDAD CARDIO-VASCULAR</asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_enfermedadcardiovascular" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="width:250px; background-color: #34495E; color: white; font-size:16px">2. ENFERMEDAD METABÓLICA</asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_enfermedadmetabolica" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="width:250px; background-color: #34495E; color: white; font-size:16px">3. ENFERMEDAD NEUROLÓGICA</asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_enfermedadneurologica" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="width:250px; background-color: #34495E; color: white; font-size:16px">4. ENFERMEDAD ONCOLÓGICA</asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_enfermedadoncologica" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="width:250px; background-color: #34495E; color: white; font-size:16px">5. ENFERMEDAD INFECCIOSA</asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_enfermedadinfecciosa" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="width:250px; background-color: #34495E; color: white; font-size:16px">6. ENFERMEDAD HEREDITARIA/CONGÉNITA</asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_enfermedadhereditaria" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="width:250px; background-color: #34495E; color: white; font-size:16px">7. DISCAPACIDADES</asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_discapacidades" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="width:250px; background-color: #34495E; color: white; font-size:16px">8. OTROS</asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_otrosenfer" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="8" style="background-color: white; font-size: 14px">
                                <asp:TextBox ID="txt_descripcionantefamiliares" BorderStyle="None" Style="background-color: transparent; width: 100%;" runat="server" placeholder="Descripción:" TextMode="MultiLine" Rows="6"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" style="background-color: #34495E; color: white; font-size:16px">
                        F.  FACTORES DE RIESGOS DEL PUESTO DE TRABAJO ACTUAL                                          
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell RowSpan="2" ColumnSpan="2" style="background-color: #34495E; color: white; font-size:16px">PUESTO DE TRABAJO / ÁREA</asp:TableCell>
                            <asp:TableCell style="width:400px; background-color: #34495E; color: white; font-size:16px" RowSpan="2">ACTIVIDADES</asp:TableCell>
                            <asp:TableCell style="width:400px; background-color: #34495E; color: white; font-size:16px" ColumnSpan="10">FÍSICO</asp:TableCell>                            
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label21" runat="server" Text="Temperaturas altas"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label22" runat="server" Text="Temperaturas bajas"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label23" runat="server" Text="Radiación Ionizante"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label24" runat="server" Text="Radiación No Ionizante"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label25" runat="server" Text="Ruido"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label26" runat="server" Text="Vibración"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label27" runat="server" Text="Iluminación"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label28" runat="server" Text="Ventilación"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label29" runat="server" Text="Fluido eléctrico"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label30" runat="server" Text="Otros __________"></asp:Label>
                            </asp:TableCell>                            
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">1. </asp:TableCell>
                            <asp:TableCell style="width:400px; background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_puestodetrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_act" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tempaltas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tempbajas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_radiacion" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_noradiacion" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_ruido" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_vibracion" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_iluminacion" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_ventilacion" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_fluidoelectrico" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px"> 
                                <asp:TextBox runat="server" ID="txt_otrosFisico" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>                            
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">2. </asp:TableCell>
                            <asp:TableCell style="width:400px; background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_puestodetrabajo2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_act2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tempaltas2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tempbajas2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_radiacion2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_noradiacion2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_ruido2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_vibracion2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_iluminacion2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_ventilacion2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_fluidoelectrico2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px"> 
                                <asp:TextBox runat="server" ID="txt_otrosFisico2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>                            
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">3. </asp:TableCell>
                            <asp:TableCell style="width:400px; background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_puestodetrabajo3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_act3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tempaltas3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tempbajas3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_radiacion3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_noradiacion3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_ruido3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_vibracion3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_iluminacion3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_ventilacion3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_fluidoelectrico3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px"> 
                                <asp:TextBox runat="server" ID="txt_otrosFisico3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>                            
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">4. </asp:TableCell>
                            <asp:TableCell style="width:400px; background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_puestodetrabajo4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_act4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tempaltas4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tempbajas4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_radiacion4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_noradiacion4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_ruido4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_vibracion4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_iluminacion4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_ventilacion4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_fluidoelectrico4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px"> 
                                <asp:TextBox runat="server" ID="txt_otrosFisico4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>                            
                        </asp:TableRow>
                    </asp:Table>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="15" style="width:750px; background-color: #34495E; color: white; font-size:16px">MECÁNICO</asp:TableCell>
                            <asp:TableCell ColumnSpan="9" style="width:700px; background-color: #34495E; color: white; font-size:16px">QUÍMICO</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label31" runat="server" Text="Atrapamiento entre máquinas"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label32" runat="server" Text="Atrapamiento entre superficies"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label33" runat="server" Text="Atrapamiento entre objetos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label34" runat="server" Text="Caída de objetos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label35" runat="server" Text="Caídas al mismo nivel"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label36" runat="server" Text="Caídas a diferente nivel"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label37" runat="server" Text="Contacto eléctrico"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label38" runat="server" Text="Contacto con superficies de trabajos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label39" runat="server" Text="Proyección de partículas – fragmentos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label40" runat="server" Text="Proyección de fluidos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label41" runat="server" Text="Pinchazos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label42" runat="server" Text="Cortes"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label43" runat="server" Text="Atropellamientos por vehículos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label44" runat="server" Text="Choques /colisión vehicular"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label45" runat="server" Text="Otros __________"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label46" runat="server" Text="Sólidos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label47" runat="server" Text="Polvos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label48" runat="server" Text="Humos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label49" runat="server" Text="Líquidos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label50" runat="server" Text="Vapores"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label51" runat="server" Text="Aerosoles"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label52" runat="server" Text="Neblinas"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label53" runat="server" Text="Gaseosos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label54" runat="server" Text="Otros __________"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_atrapmaquinas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_atrapsuperficie" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_atrapobjetos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_caidaobjetos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_caidamisnivel" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_caidadifnivel" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_contaelectrico" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_contasuptrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_proyparticulas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_proyefluidos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_pinchazos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_cortes" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_atroporvehiculos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_choques" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_otrosMecanico" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_solidos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_polvos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_humos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_liquidos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_vapores" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_aerosoles" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_neblinas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_gaseosos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_otrosQuimico" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_atrapmaquinas2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_atrapsuperficie2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_atrapobjetos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_caidaobjetos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_caidamisnivel2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_caidadifnivel2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_contaelectrico2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_contasuptrabajo2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_proyparticulas2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_proyefluidos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_pinchazos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_cortes2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_atroporvehiculos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_choques2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_otrosMecanico2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_solidos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_polvos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_humos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_liquidos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_vapores2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_aerosoles2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_neblinas2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_gaseosos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_otrosQuimico2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_atrapmaquinas3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_atrapsuperficie3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_atrapobjetos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_caidaobjetos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_caidamisnivel3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_caidadifnivel3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_contaelectrico3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_contasuptrabajo3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_proyparticulas3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_proyefluidos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_pinchazos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_cortes3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_atroporvehiculos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_choques3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_otrosMecanico3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_solidos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_polvos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_humos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_liquidos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_vapores3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_aerosoles3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_neblinas3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_gaseosos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_otrosQuimico3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_atrapmaquinas4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_atrapsuperficie4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_atrapobjetos4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_caidaobjetos4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_caidamisnivel4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_caidadifnivel4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_contaelectrico4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_contasuptrabajo4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_proyparticulas4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_proyefluidos4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_pinchazos4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_cortes4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_atroporvehiculos4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_choques4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_otrosMecanico4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_solidos34" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_polvos4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_humos4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_liquidos4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_vapores4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_aerosoles4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_neblinas4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_gaseosos4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_otrosQuimico4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell RowSpan="2" ColumnSpan="2" style="background-color: #34495E; color: white; font-size:16px">PUESTO DE TRABAJO / ÁREA</asp:TableCell>
                            <asp:TableCell RowSpan="2" style="width:350px; background-color: #34495E; color: white; font-size:16px">ACTIVIDADES</asp:TableCell>
                            <asp:TableCell ColumnSpan="7" style="width:350px; background-color: #34495E; color: white; font-size:16px">BIÓLOGO</asp:TableCell>
                            <asp:TableCell ColumnSpan="5" style="width:350px; background-color: #34495E; color: white; font-size:16px">ERGONÓMICO</asp:TableCell>                            
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label55" runat="server" Text="Virus"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label56" runat="server" Text="Hongos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label57" runat="server" Text="Bacterias "></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label58" runat="server" Text="Parásitos "></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label59" runat="server" Text="Exposición a vectores"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label60" runat="server" Text="Exposición a animales selváticos "></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label61" runat="server" Text="Otros __________"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label62" runat="server" Text="Manejo manual de cargas"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label63" runat="server" Text="Movimiento repetitivos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label64" runat="server" Text="Posturas forzadas"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label65" runat="server" Text="Trabajos con PVD"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label66" runat="server" Text="Otros __________"></asp:Label>
                            </asp:TableCell>                            
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">1. </asp:TableCell>
                            <asp:TableCell style="width:350px; background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_puestodetrabajo21" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_act21" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_virus" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder=""></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_hongos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_bacterias" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_parasitos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_expoavectores" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_expoanimselvaticos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_otrosBiologico" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_manmanualcargas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_movrepetitivo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_postforzadas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_trabajopvd" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_otrosErgonomico" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>                            
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">2. </asp:TableCell>
                            <asp:TableCell style="width:350px; background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_puestodetrabajo22" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_act22" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_virus2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder=""></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_hongos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_bacterias2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_parasitos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_expoavectores2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_expoanimselvaticos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_otrosBiologico2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_manmanualcargas2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_movrepetitivo2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_postforzadas2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_trabajopvd2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_otrosErgonomico2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>                            
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">3. </asp:TableCell>
                            <asp:TableCell style="width:350px; background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_puestodetrabajo23" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_act23" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_virus3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder=""></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_hongos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_bacterias3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_parasitos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_expoavectores3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_expoanimselvaticos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_otrosBiologico3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_manmanualcargas3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_movrepetitivo3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_postforzadas3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_trabajopvd3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_otrosErgonomico3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>                            
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">4. </asp:TableCell>
                            <asp:TableCell style="width:350px; background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_puestodetrabajo24" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_act24" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_virus4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder=""></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_hongos4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_bacterias4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_parasitos4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_expoavectores4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_expoanimselvaticos4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_otrosBiologico4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_manmanualcargas4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_movrepetitivo4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_postforzadas4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_trabajopvd4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_otrosErgonomico4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>                            
                        </asp:TableRow>
                    </asp:Table>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="13" style="width:800px; background-color: #34495E; color: white; font-size:16px">PSICOSOCIAL</asp:TableCell>
                            <asp:TableCell RowSpan="2" style="width:650px; background-color: #34495E; color: white; font-size:16px">MEDIDAS PREVENTIVAS</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label67" runat="server" Text="Monotonía del trabajo "></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label68" runat="server" Text="Sobrecarga laboral"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label69" runat="server" Text="Minuciosidad de la tarea "></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label70" runat="server" Text="Alta responsabilidad"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label71" runat="server" Text="Autonomía  en la toma de decisiones"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label72" runat="server" Text="Supervisión y estilos de dirección deficiente"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label73" runat="server" Text="Conflicto de rol"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label74" runat="server" Text="Falta de Claridad en las funciones"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label75" runat="server" Text="Incorrecta distribución del trabajo"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label76" runat="server" Text="Turnos rotativos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label77" runat="server" Text="Relaciones interpersonales"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label78" runat="server" Text="Inestabilidad laboral"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">
                                <asp:Label CssClass="in-column" ID="Label79" runat="server" Text="Otros __________"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_montrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_sobrecargalaboral" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_minustarea" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_altarespon" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_automadesiciones" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_supyestdireficiente" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_conflictorol" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_faltaclarfunciones" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_incorrdistrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_turnorotat" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_relacinterpersonales" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_inestalaboral" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_otrosPsicosocial" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_medpreventivas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_montrabajo2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_sobrecargalaboral2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_minustarea2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_altarespon2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_automadesiciones2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_supyestdireficiente2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_conflictorol2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_faltaclarfunciones2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_incorrdistrabajo2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_turnorotat2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_relacinterpersonales2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_inestalaboral2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_otrosPsicosocial2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_medpreventivas2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_montrabajo3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_sobrecargalaboral3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_minustarea3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_altarespon3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_automadesiciones3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_supyestdireficiente3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_conflictorol3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_faltaclarfunciones3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_incorrdistrabajo3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_turnorotat3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_relacinterpersonales3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_inestalaboral3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_otrosPsicosocial3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_medpreventivas3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_montrabajo4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_sobrecargalaboral4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_minustarea4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_altarespon4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_automadesiciones4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_supyestdireficiente4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_conflictorol4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_faltaclarfunciones4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_incorrdistrabajo4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_turnorotat4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_relacinterpersonales4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_inestalaboral4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_otrosPsicosocial4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_medpreventivas4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" style="background-color: #34495E; color: white; font-size:16px">
                        G. ACTIVIDADES EXTRA LABORALES                                            
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:TextBox ID="txt_descrextralaborales" BorderStyle="None" Style="background-color: transparent; width: 100%;" runat="server" placeholder="Descripción: " TextMode="MultiLine" Rows="3"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" style="background-color: #34495E; color: white; font-size:16px">
                        H. ENFERMEDAD ACTUAL                                           
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:TextBox ID="txt_enfermedadactualinicial" runat="server" BorderStyle="None" Style="background-color: transparent; width: 100%;" placeholder="Descripción: " TextMode="MultiLine" Rows="3"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="row">
                        <div class="card-header col" style="margin-left: 0.8rem; background-color: #34495E; color: white; font-size:16px">
                            I. REVISIÓN ACTUAL DE ÓRGANOS Y SISTEMAS                                          
                        </div>
                        <div class="card-header col" style="text-align: right; font-size: 11px; margin-right: 0.8rem; background-color: #34495E; color: white">
                            EN CASO DE EXISTIR PATOLOGÍA  MARCAR CON "X"  Y DESCRIBIR ABAJO COLOCANDO EL NUMERAL                                         
                        </div>
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell style="width:200px; background-color: #34495E; color: white; font-size:16px">1. PIEL - ANEXOS</asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_pielanexos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="width:200px; background-color: #34495E; color: white; font-size:16px">3. RESPIRATORIO</asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_respiratorio" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="width:200px; background-color: #34495E; color: white; font-size:16px">5. DIGESTIVO</asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_digestivo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="width:200px; background-color: #34495E; color: white; font-size:16px">7. MÚSCULO ESQUELÉTICO</asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_musculosesqueleticos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="width:200px; background-color: #34495E; color: white; font-size:16px">9. HEMO LINFÁTICO</asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_hemolinfatico" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="width:200px; background-color: #34495E; color: white; font-size:16px">2. ÓRGANOS DE LOS SENTIDOS</asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_organossentidos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="width:200px; background-color: #34495E; color: white; font-size:16px">4. CARDIO-VASCULAR</asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_cardiovascular" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="width:200px; background-color: #34495E; color: white; font-size:16px">6. GENITO - URINARIO</asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_genitourinario" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="width:200px; background-color: #34495E; color: white; font-size:16px">8. ENDOCRINO</asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_endocrino" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell style="width:200px; background-color: #34495E; color: white; font-size:16px">10. NERVIOSO</asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_nervioso" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="10" style="background-color: white; font-size: 14px">
                                <asp:TextBox ID="txt_descrorganosysistemas" BorderStyle="None" Style="background-color: transparent; width: 100%;" runat="server" placeholder="Descripción:" TextMode="MultiLine" Rows="6"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" style="background-color: #34495E; color: white; font-size:16px">
                        J. CONSTANTES VITALES Y ANTROPOMETRÍA 
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="PRESIÓN ARTERIAL (mmHg)" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                                <asp:TableCell Text="TEMPERATURA (°C)" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                                <asp:TableCell Text="FRECUENCIA CARDIACA (Lat/min)" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                                <asp:TableCell Text="SATURACIÓN DE OXÍGENO (O2%)" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                                <asp:TableCell Text="FRECUENCIA RESPIRATORIA (fr/min)" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                                <asp:TableCell Text="PESO (Kg)" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                                <asp:TableCell Text="TALLA (cm)" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                                <asp:TableCell Text="ÍNDICE DE MASA CORPORAL (kg/m2)" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                                <asp:TableCell Text="PERÍMETRO ABDOMINAL(cm)" style="background-color: #34495E; color: white; font-size:16px"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" style="background-color: #34495E; color: white; font-size:16px">
                        K. EXAMEN FÍSICO REGIONAL
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="REGIONES" Style="text-align: left; width:100%; background-color: #34495E; color: white; font-size:16px" ColumnSpan="15"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell RowSpan="3" style="background-color: #34495E; color: white; font-size:16px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label80" runat="server" Text="1. Piel"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">a. Cicatrices</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_cicatrices" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="3" style="background-color: #34495E; color: white; font-size:16px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label81" runat="server" Text="3. Oído"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">a. C. auditivo externo</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_auditivoexterno" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="4" style="background-color: #34495E; color: white; font-size:16px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label82" runat="server" Text="5. Nariz"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">a. Tabique</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_tabique" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2" style="background-color: #34495E; color: white; font-size:16px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label83" runat="server" Text="8. Tórax"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">a. Pulmones</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_pulmones" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2" style="background-color: #34495E; color: white; font-size:16px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label84" runat="server" Text="11. Pelvis"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">a. Pelvis</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_pelvis" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">b. Tatuajes</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_tatuajes" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">b. Pabellón</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_pabellon" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">b. Cornetes</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_cornetes" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">b. Parrilla Costal</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX">
                                    <asp:TextBox runat="server" ID="txt_parrillacostal" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">b. Genitales</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_genitales" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">c. Piel  y Faneras</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_pielyfaneras" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">c. Tímpanos</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_timpanos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">c. Mucosas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_mucosa" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2" style="background-color: #34495E; color: white; font-size:16px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label85" runat="server" Text="9. Abdomen"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">a. Vísceras</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_visceras" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="3" style="background-color: #34495E; color: white; font-size:16px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label86" runat="server" Text="12. Extremidades"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">a. Vascular</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_vascular" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell RowSpan="5" style="background-color: #34495E; color: white; font-size:16px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label87" runat="server" Text="2. Ojos"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">a. Párpados</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_parpados" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="5" style="background-color: #34495E; color: white; font-size:16px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label88" runat="server" Text="4. Oro faringe"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">a. Labios</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_labios" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">d. Senos paranasales</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_senosparanasales" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">b. Pared abdominal</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_paredabdominal" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">b. Miembros superiores</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_miembrosuperiores" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">b. Conjuntivas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_conjuntivas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">b. Lengua</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_lengua" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2" style="background-color: #34495E; color: white; font-size:16px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label89" runat="server" Text="6. Cuello"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">a. Tiroides / masas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_tiroides" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="4" style="background-color: #34495E; color: white; font-size:16px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label90" runat="server" Text="10. Columna"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">a. Flexibilidad</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_flexibilidad" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">c. Miembros inferiores</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_miembrosinferiores" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">c. Pupilas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_pupilas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">c. Faringe</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_faringe" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">b. Movilidad</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_movilidad" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" RowSpan="2" style="background-color: #34495E; color: white; font-size:16px">b. Desviación</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" RowSpan="2" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_desviacion" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="4" style="background-color: #34495E; color: white; font-size:16px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label91" runat="server" Text="13. Neurológico"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">a. Fuerza</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_fuerza" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">d. Córnea</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_cornea" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">d. Amígdalas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_amigdalas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2" style="background-color: #34495E; color: white; font-size:16px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label92" runat="server" Text="7. Tórax"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">a. Mamas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_mamas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">b. Sensibilidad</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_sensibilidad" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">e. Motilidad</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_motilidad" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">e. Dentadura</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_dentadura" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">b. Corazón</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_corazon" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">c. Dolor</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_dolor" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">c. Marcha</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_marcha" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="text-align: left; background-color: #34495E; color: white; font-size:16px" ColumnSpan="12">SI EXISTE EVIDENCIA DE PATOLOGÍA MARCAR CON "X" Y DESCRIBIR EN LA SIGUIENTE SECCIÓN COLOCANDO EL NUMERAL</asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #34495E; color: white; font-size:16px">d. Reflejos</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_reflejos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="15" style="background-color: white; font-size: 14px">
                                    <asp:TextBox ID="txt_obervexamenfisicoregional" BorderStyle="None" Style="background-color: transparent; width: 100%;" runat="server" placeholder="Observaciones:" TextMode="MultiLine" Rows="4"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" style="background-color: #34495E; color: white; font-size:16px">
                        L. RESULTADOS DE EXÁMENES GENERALES Y ESPECÍFICOS DE ACUERDO AL RIESGO Y PUESTO DE TRABAJO (IMAGEN, LABORATORIO Y OTROS)
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="width: 400px; background-color: #34495E; color: white; font-size:16px">EXAMEN </asp:TableCell>
                                <asp:TableCell Style="width: 150px; background-color: #34495E; color: white; font-size:16px">FECHA <br /> dd/mm/aaaa</asp:TableCell>
                                <asp:TableCell Style="width: 800px; background-color: #34495E; color: white; font-size:16px">RESULTADOS</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_examen" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_fechaexamen" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_resultadoexamen" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>

                            <asp:TableRow>
                                <asp:TableCell style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_examen2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_fechaexamen2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_resultadoexamen2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>

                            <asp:TableRow>
                                <asp:TableCell style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_examen3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_fechaexamen3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_resultadoexamen3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>

                            <asp:TableRow>
                                <asp:TableCell style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_examen4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_fechaexamen4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_resultadoexamen4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>

                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="15" style="background-color: white; font-size: 14px">
                                    <asp:TextBox ID="txt_observacionexamen" BorderStyle="None" Style="background-color: transparent; width: 100%;" runat="server" placeholder="Observaciones:" TextMode="MultiLine" Rows="2"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" style="background-color: #34495E; color: white; font-size:16px">
                        M. DIAGNÓSTICO
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="2" Style="text-align: end; background-color: #34495E; color: white; font-size:16px">PRE= PRESUNTIVO          DEF= DEFINITIVO</asp:TableCell>
                                <asp:TableCell style="width: 200px; background-color: #34495E; color: white; font-size:16px">CIE</asp:TableCell>
                                <asp:TableCell style="width: 75px; background-color: #34495E; color: white; font-size:16px">PRE</asp:TableCell>
                                <asp:TableCell style="width: 75px; background-color: #34495E; color: white; font-size:16px">DEF</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell style="width: 50px; background-color: #34495E; color: white; font-size:16px" Text="1"></asp:TableCell>
                                <asp:TableCell style="width: 1000px; background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_descripdiagnostico" BorderStyle="None" Style="background-color: transparent; width: 100%;" placeholder="Descripción"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_cie" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_pre" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_def" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell style="width: 50px; background-color: #34495E; color: white; font-size:16px" Text="2"></asp:TableCell>
                                <asp:TableCell style="width: 1000px; background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_descripdiagnostico2" BorderStyle="None" Style="background-color: transparent; width: 100%;" placeholder="Descripción"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_cie2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_pre2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_def2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell style="width: 50px; background-color: #34495E; color: white; font-size:16px" Text="3"></asp:TableCell>
                                <asp:TableCell style="width: 1000px; background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_descripdiagnostico3" BorderStyle="None" Style="background-color: transparent; width: 100%;" placeholder="Descripción"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_cie3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_pre3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_def3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" style="background-color: #34495E; color: white; font-size:16px">
                        N. APTITUD MÉDICA PARA EL TRABAJO  
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="width: 250px; background-color: #34495E; color: white; font-size:16px">APTO</asp:TableCell>
                                <asp:TableCell Style="width: 50px; background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_apto" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 250px; background-color: #34495E; color: white; font-size:16px">APTO EN OBSERVACIÓN</asp:TableCell>
                                <asp:TableCell Style="width: 50px; background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_aptoobservacion" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 250px; background-color: #34495E; color: white; font-size:16px">APTO CON LIMITACIONES</asp:TableCell>
                                <asp:TableCell Style="width: 50px; background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_aptolimitacion" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 250px; background-color: #34495E; color: white; font-size:16px">NO APTO</asp:TableCell>
                                <asp:TableCell Style="width: 50px; background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_noapto" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">Observación</asp:TableCell>
                                <asp:TableCell ColumnSpan="7" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_observacionaptitud" BorderStyle="None" Style="background-color: transparent; width: 100%" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell style="background-color: #34495E; color: white; font-size:16px">Limitación</asp:TableCell>
                                <asp:TableCell ColumnSpan="7" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_limitacionaptitud" BorderStyle="None" Style="background-color: transparent; width: 100%" placeholder="-"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" style="background-color: #34495E; color: white; font-size:16px">
                        O. RECOMENDACIONES Y/O TRATAMIENTO
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:TextBox ID="txt_descripciontratamiento" BorderStyle="None" Style="background-color: transparent; width: 100%;" runat="server" placeholder="Descripción:" TextMode="MultiLine" Rows="3"></asp:TextBox>
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
                    <div class="card-header" style="background-color: #34495E; color: white; font-size:16px">
                        P. DATOS DEL PROFESIONAL 
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="width: 100px; background-color: #34495E; color: white; font-size:16px">FECHA Y HORA</asp:TableCell>
                                <asp:TableCell Style="width: 150px; background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" BorderStyle="None" ID="txt_fechaDatProf" TextMode="DateTimeLocal" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 150px; background-color: #34495E; color: white; font-size:16px">NOMBRES Y APELLIDOS</asp:TableCell>
                                <asp:TableCell Style="width: 300px; background-color: white; font-size: 14px">
                                    <asp:DropDownList ID="ddl_profesional" CssClass="form-check" Style="width: 100%; border: none; background-color: transparent" runat="server"></asp:DropDownList>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 75px; background-color: #34495E; color: white; font-size:16px">CÓDIGO</asp:TableCell>
                                <asp:TableCell Style="width: 125px; background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" BorderStyle="None" ID="txt_codigoDatProf" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 100px; background-color: #34495E; color: white; font-size:16px">FIRMA Y SELLO</asp:TableCell>
                                <asp:TableCell Style="width: 175px; background-color: white; font-size: 14px">
                                     <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div align="center">
                    <div class="card" style="width: 400px">
                        <div class="card-header" style="background-color: #34495E; color: white; font-size:16px">
                            Q. FIRMA DEL USUARIO
                        </div>
                        <div class="list-group list-group-flush">
                            <asp:Label ID="Label93" runat="server" Text="" Style="height: 80px"></asp:Label>
                        </div>
                    </div>
                </div>
                <br />
                <div class="container" align="center">
                    <asp:Button CssClass="btn btn-warning" ID="btn_guardar" runat="server" Text="Guardar" OnClick="btn_guardar_Click" UseSubmitBehavior="False" />
                    <asp:Button CssClass="btn btn-success" ID="btn_modificar" runat="server" Text="Modificar" OnClick="btn_modificar_Click" UseSubmitBehavior="False" />
                    <asp:Button CssClass="btn btn-danger" ID="btn_cancelar" runat="server" Text="Cancelar" OnClick="btn_cancelar_Click" UseSubmitBehavior="False" />
                </div>
                <br />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
