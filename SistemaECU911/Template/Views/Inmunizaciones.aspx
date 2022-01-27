<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Views/Principal.Master" AutoEventWireup="true" CodeBehind="Inmunizaciones.aspx.cs" Inherits="SistemaECU911.Template.Views.Inmunizaciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="background-color: white">
        <br />
        <div class="container">
            <div class="card text-center">
                <div class="card-header">
                    GESTIÓN DE SEGURIDAD Y SALUD OCUPACIONAL
                </div>
                <div>
                    HISTORIA CLÍNICA OCUPACIONAL - INMUNIZACIONES
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
                                        <asp:TextBox runat="server" ID="txt_numHClinica" OnTextChanged="txt_numHClinica_TextChanged" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" AutoPostBack="true"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell>
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
                <asp:Table class="table table-bordered table-light text-center" runat="server">
                    <asp:TableRow>
                        <asp:TableCell Text="PRIMER APELLIDO"></asp:TableCell>
                        <asp:TableCell Text="SEGUNDO APELLIDO"></asp:TableCell>
                        <asp:TableCell Text="PRIMER NOMBRE"></asp:TableCell>
                        <asp:TableCell Text="SEGUNDO NOMBRE"></asp:TableCell>
                        <asp:TableCell Text="SEXO"></asp:TableCell>
                        <asp:TableCell Text="CARGO / OCUPACIÓN"></asp:TableCell>
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
                                        <asp:TextBox runat="server" ID="txt_cargo" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </div>
        </div>
        <div class="card" style="width: auto;">
            <div class="card-header">
                B. INMUNIZACIONES
            </div>
            <asp:Table class="table table-bordered table-light text-center" runat="server">
                <asp:TableRow>
                    <asp:TableCell Text="VACUNAS"></asp:TableCell>
                    <asp:TableCell Text="DOSIS"></asp:TableCell>
                    <asp:TableCell Text="FECHA"></asp:TableCell>
                    <asp:TableCell Text="LOTE"></asp:TableCell>
                    <asp:TableCell Text="ESQUEMA COMPLETO (marcar X)"></asp:TableCell>
                    <asp:TableCell Text="NOMBRES COMPLETOS DEL RESPONSABLE DE LA VACUNACIÓN"></asp:TableCell>
                    <asp:TableCell Text="ESTABLACIMIENTO DE SALUD DONDE SE COLOCÓ LA VACUNA."></asp:TableCell>
                    <asp:TableCell Text="OBSERVACIONES"></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell RowSpan="5" Text="Tétanos - Difeteria"></asp:TableCell>
                    <asp:TableCell>1º</asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server"  ID="txt_fechatetanos1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_loteTetanos1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_esqueCompleTetanos1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_nomCompleResponVacuTetanos1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_estaSaludColocoVacuTetanos1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_observaTetanos1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>2º</asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server"  ID="txt_fechatetanos2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_loteTetanos2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_esqueCompleTetanos2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_nomCompleResponVacuTetanos2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_estaSaludColocoVacuTetanos2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_observaTetanos2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>3º</asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server"  ID="txt_fechatetanos3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_loteTetanos3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_esqueCompleTetanos3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_nomCompleResponVacuTetanos3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_estaSaludColocoVacuTetanos3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_observaTetanos3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>4º</asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server"  ID="txt_fechatetanos4" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_loteTetanos4" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_esqueCompleTetanos4" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_nomCompleResponVacuTetanos4" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_estaSaludColocoVacuTetanos4" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_observaTetanos4" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>5º</asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server"  ID="txt_fechatetanos5" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_loteTetanos5" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_esqueCompleTetanos5" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_nomCompleResponVacuTetanos5" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_estaSaludColocoVacuTetanos5" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_observaTetanos5" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell RowSpan="3" Text="Hepatitis A"></asp:TableCell>
                    <asp:TableCell>1º</asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_fechaHepatitisA1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_loteHepatitisA1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_esqueCompleHepatitisA1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_nomCompleResponVacuHepatitisA1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_estaSaludColocoVaciHepatitisA1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_observaHepatitisA1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>2º</asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_fechaHepatitisA2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_loteHepatitisA2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_esqueCompleHepatitisA2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_nomCompleResponVacuHepatitisA2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_estaSaludColocoVaciHepatitisA2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_observaHepatitisA2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>3º</asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_fechaHepatitisA3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_loteHepatitisA3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_esqueCompleHepatitisA3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_nomCompleResponVacuHepatitisA3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_estaSaludColocoVaciHepatitisA3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_observaHepatitisA3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell RowSpan="3" Text="Hepatitis B"></asp:TableCell>
                    <asp:TableCell>1º</asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_fechaHepatitisB1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_loteHepatitisB1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_esqueCompleHepatitisB1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_nomCompleResponVacuHepatitisB1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_estaSaludColocoVaciHepatitisB1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_observaHepatitisB1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>2º</asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_fechaHepatitisB2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_loteHepatitisB2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_esqueCompleHepatitisB2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_nomCompleResponVacuHepatitisB2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_estaSaludColocoVaciHepatitisB2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_observaHepatitisB2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>3º</asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_fechaHepatitisB3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_loteHepatitisB3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_esqueCompleHepatitisB3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_nomCompleResponVacuHepatitisB3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_estaSaludColocoVaciHepatitisB3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_observaHepatitisB3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell RowSpan="1" Text="Influenza estacionaria"></asp:TableCell>
                    <asp:TableCell>Dosis única</asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_fechaInfluenza" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_loteInfluenza" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_esqueCompleInfluenza" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_nomCompleResponVacuInfluenza" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_estaSaludColocoVacuInfluenza" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_observaInfluenza" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell RowSpan="1" Text="Fiebre Amarilla"></asp:TableCell>
                    <asp:TableCell>Dosis única</asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_fechaFiebreAmarilla" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_loteFiebreAmarilla" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_esqueCompleFiebreAmarilla" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_nomCompleResponVacuFiebreAmarilla" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_estaSaludColocoVacuFiebreAmarilla" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_observaFiebreAmarilla" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell RowSpan="2" Text="Sarampión - Rubéola"></asp:TableCell>
                    <asp:TableCell>1º</asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_fechaSarampion1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_loteSarampion1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_esqueCompleSarampion1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_nomCompleResponVacuSarampion1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_estaSaludColocoVacuSarampion1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_observaSarampion1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>2º</asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_fechaSarampion2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_loteSarampion2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_esqueCompleSarampion2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_nomCompleResponVacuSarampion2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_estaSaludColocoVacuSarampion2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_observaSarampion2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell ColumnSpan="8">
                    <asp:Label  runat="server" Text="INMUNIZACIONES DE ACUERDO AL TIPO DE EMPRESA Y RIESGO" style="text-align:left"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell RowSpan="5" >
                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>1º</asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_1fechaInmuAcuerTipoEmpRies1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_1loteInmuAcuerTipoEmpRies1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_1esqueCompleInmuAcuerTipoEmpRies1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_1nomCompleResponVacuInmuAcuerTipoEmpRies1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_1observaInmuAcuerTipoEmpRies1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>2º</asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_1fechaInmuAcuerTipoEmpRies2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_1loteInmuAcuerTipoEmpRies2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_1esqueCompleInmuAcuerTipoEmpRies2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_1nomCompleResponVacuInmuAcuerTipoEmpRies2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_1observaInmuAcuerTipoEmpRies2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>3º</asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_1fechaInmuAcuerTipoEmpRies3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_1loteInmuAcuerTipoEmpRies3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_1esqueCompleInmuAcuerTipoEmpRies3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_1nomCompleResponVacuInmuAcuerTipoEmpRies3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_1observaInmuAcuerTipoEmpRies3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>4º</asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_1fechaInmuAcuerTipoEmpRies4" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_1loteInmuAcuerTipoEmpRies4" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_1esqueCompleInmuAcuerTipoEmpRies4" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_1nomCompleResponVacuInmuAcuerTipoEmpRies4" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies4" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_1observaInmuAcuerTipoEmpRies4" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>5º</asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_1fechaInmuAcuerTipoEmpRies5" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_1loteInmuAcuerTipoEmpRies5" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_1esqueCompleInmuAcuerTipoEmpRies5" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_1nomCompleResponVacuInmuAcuerTipoEmpRies5" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies5" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_1observaInmuAcuerTipoEmpRies5" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell RowSpan="5">
                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>1º</asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_2fechaInmuAcuerTipoEmpRies1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_2loteInmuAcuerTipoEmpRies1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_2esqueCompleInmuAcuerTipoEmpRies1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_2nomCompleResponVacuInmuAcuerTipoEmpRies1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_2observaInmuAcuerTipoEmpRies1" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>2º</asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_2fechaInmuAcuerTipoEmpRies2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_2loteInmuAcuerTipoEmpRies2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_2esqueCompleInmuAcuerTipoEmpRies2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_2nomCompleResponVacuInmuAcuerTipoEmpRies2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_2observaInmuAcuerTipoEmpRies2" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>3º</asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_2fechaInmuAcuerTipoEmpRies3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_2loteInmuAcuerTipoEmpRies3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_2esqueCompleInmuAcuerTipoEmpRies3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_2nomCompleResponVacuInmuAcuerTipoEmpRies3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_2observaInmuAcuerTipoEmpRies3" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>4º</asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_2fechaInmuAcuerTipoEmpRies4" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_2loteInmuAcuerTipoEmpRies4" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_2esqueCompleInmuAcuerTipoEmpRies4" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_2nomCompleResponVacuInmuAcuerTipoEmpRies4" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies4" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_2observaInmuAcuerTipoEmpRies4" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>5º</asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_2fechaInmuAcuerTipoEmpRies5" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_2loteInmuAcuerTipoEmpRies5" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_2esqueCompleInmuAcuerTipoEmpRies5" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_2nomCompleResponVacuInmuAcuerTipoEmpRies5" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies5" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                                        <asp:TextBox runat="server" ID="txt_2observaInmuAcuerTipoEmpRies5" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell RowSpan="5">
                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>1º</asp:TableCell>
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
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>2º</asp:TableCell>
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
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>3º</asp:TableCell>
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
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>4º</asp:TableCell>
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
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>5º</asp:TableCell>
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
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell RowSpan="5">
                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>1º</asp:TableCell>
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
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>2º</asp:TableCell>
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
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>3º</asp:TableCell>
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
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>4º</asp:TableCell>
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
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>5º</asp:TableCell>
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
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell ColumnSpan="8">
                    <asp:Label  runat="server" Text="La vacuna de la Fiebre Amarilla es obligatoria para quien viva o se desplace en la Región Amazónica, su aplicación es hasta los 59 años de edad" style="text-align:left"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
        <br />
        <div class="container" align="center">
            <asp:Button CssClass="btn btn-primary" ID="btn_guardarinmunizaciones" runat="server" OnClick="btn_guardarinmunizaciones_Click" Text="Guardar" UseSubmitBehavior="False" />
            <asp:Button CssClass="btn btn-primary" ID="btn_modificarinmunizaciones" runat="server" OnClick="btn_modificarinmunizaciones_Click" Text="Modificar" UseSubmitBehavior="False" />
            <asp:Button CssClass="btn btn-secondary" ID="btn_cancelarinmunizaciones" runat="server" OnClick="btn_cancelarinmunizaciones_Click" Text="Cancelar" UseSubmitBehavior="False" />
        </div>
        <br />
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
