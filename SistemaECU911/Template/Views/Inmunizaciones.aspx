<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Views/Principal.Master" AutoEventWireup="true" CodeBehind="Inmunizaciones.aspx.cs" Inherits="SistemaECU911.Template.Views.Inmunizaciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://cdn.jsdelivr.net/npm/select2@4.1.0-rc.0/dist/css/select2.min.css" rel="stylesheet" />

    <style type="text/css">
        .CompletionList {
            padding: 5px 0;
            margin: 2px 0 0;
            height: 100px;
            overflow: auto;
            position: absolute;
            border: 1px solid #ccc;
            border: 1px solid rgba(0, 0, 0, 0.2);
            *border-right-width: 2px;
            *border-bottom-width: 2px;
            -webkit-border-radius: 6px;
            -moz-border-radius: 6px;
            border-radius: 6px;
            -webkit-box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
            -moz-box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
            box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
            -webkit-background-clip: padding-box;
            -moz-background-clip: padding;
            background-clip: padding-box;
            background-color: White;
            cursor: pointer;
        }

        .CompletionListItem {
            display: block;
            padding: 3px 20px;
            clear: both;
            font-weight: normal;
            line-height: 20px;
            color: #333333;
            white-space: nowrap;
        }


        .CompletionListHighlightedItem {
            color: #ffffff;
            padding: 3px 20px;
            text-decoration: none;
            background-color: #0081c2;
            background-repeat: repeat-x;
            outline: 0;
            background-image: linear-gradient(to bottom, #0088cc, #0077b3);
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="container" style="background-color: white; font-family: Arial">
                <br />
                <div class="container">
                    <div class="text-center" style="font-size: 25px">
                        GESTIÓN DE SEGURIDAD Y SALUD OCUPACIONAL<br />
                        HISTORIA CLÍNICA OCUPACIONAL - INMUNIZACIONES
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" style="background-color: #cccdfe; font-weight: bold">
                        A. DATOS DEL ESTABLECIMIENTO - EMPRESA Y USUARIO
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="INSTITUCIÓN DEL SISTEMA O NOMBRE DE LA EMPRESA" Style="width: 375px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="RUC" Style="width: 150px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="CIIU" Style="width: 150px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="ESTABLECIMIENTO DE SALUD" Style="width: 250px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="NÚMERO DE HISTORIA CLÍNICA" Style="width: 200px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="NÚMERO DE ARCHIVO" Style="width: 200px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center; "  ></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_numHClinica" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" OnTextChanged="txt_numHClinica_TextChanged" AutoPostBack="true"></asp:TextBox>
                                    <ajaxToolkit:AutoCompleteExtender ID="AutoCompleteExtender2" runat="server" CompletionInterval="10" DelimiterCharacters="" Enabled="True"
                                        MinimumPrefixLength="1" ServiceMethod="ObtenerNumHClinica"
                                        TargetControlID="txt_numHClinica" CompletionListCssClass="CompletionList"
                                        CompletionListHighlightedItemCssClass="CompletionListHighlightedItem"
                                        CompletionListItemCssClass="CompletionListItem">
                                    </ajaxToolkit:AutoCompleteExtender>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" ID="txt_numArchivo" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="PRIMER APELLIDO" Style="width: 225px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="SEGUNDO APELLIDO" Style="width: 225px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="PRIMER NOMBRE" Style="width: 225px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="SEGUNDO NOMBRE" Style="width: 225px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="SEXO" Style="width: 100px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="CARGO / OCUPACIÓN" Style="width: 350px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
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
                                    <asp:TextBox runat="server" ID="txt_cargo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <div class="card" style="width: auto;">
                    <div class="card-header" style="background-color: #cccdfe; font-weight: bold; font-weight: bold">
                        B. INMUNIZACIONES
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Text="VACUNAS" Style="width: 150px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                            <asp:TableCell Text="DOSIS" Style="width: 50px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                            <asp:TableCell Text="FECHA" Style="width: 100px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                            <asp:TableCell Text="LOTE" Style="width: 100px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                            <asp:TableCell Text="ESQUEMA COMPLETO (marcar X)" Style="width: 100px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                            <asp:TableCell Text="NOMBRES COMPLETOS DEL RESPONSABLE DE LA VACUNACIÓN" Style="width: 175px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                            <asp:TableCell Text="ESTABLACIMIENTO DE SALUD DONDE SE COLOCÓ LA VACUNA" Style="width: 175px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                            <asp:TableCell Text="OBSERVACIONES" Style="width: 375px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell RowSpan="5" Text="Tétanos - Difeteria" Style="background-color: #ccffff; font-size: 15px"></asp:TableCell>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">1º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_fechatetanos1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_loteTetanos1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_esqueCompleTetanos1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_nomCompleResponVacuTetanos1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_estaSaludColocoVacuTetanos1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_observaTetanos1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">2º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_fechatetanos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_loteTetanos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_esqueCompleTetanos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_nomCompleResponVacuTetanos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_estaSaludColocoVacuTetanos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_observaTetanos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">3º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_fechatetanos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_loteTetanos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_esqueCompleTetanos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_nomCompleResponVacuTetanos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_estaSaludColocoVacuTetanos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_observaTetanos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">4º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_fechatetanos4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_loteTetanos4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_esqueCompleTetanos4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_nomCompleResponVacuTetanos4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_estaSaludColocoVacuTetanos4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_observaTetanos4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">5º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_fechatetanos5" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_loteTetanos5" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_esqueCompleTetanos5" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_nomCompleResponVacuTetanos5" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_estaSaludColocoVacuTetanos5" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_observaTetanos5" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell RowSpan="3" Text="Hepatitis A" Style="background-color: #ccffff; font-size: 15px"></asp:TableCell>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">1º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_fechaHepatitisA1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_loteHepatitisA1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_esqueCompleHepatitisA1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_nomCompleResponVacuHepatitisA1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_estaSaludColocoVaciHepatitisA1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_observaHepatitisA1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">2º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_fechaHepatitisA2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_loteHepatitisA2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_esqueCompleHepatitisA2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_nomCompleResponVacuHepatitisA2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_estaSaludColocoVaciHepatitisA2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_observaHepatitisA2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">3º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_fechaHepatitisA3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_loteHepatitisA3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_esqueCompleHepatitisA3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_nomCompleResponVacuHepatitisA3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_estaSaludColocoVaciHepatitisA3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_observaHepatitisA3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell RowSpan="3" Text="Hepatitis B" Style="background-color: #ccffff; font-size: 15px"></asp:TableCell>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">1º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_fechaHepatitisB1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_loteHepatitisB1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_esqueCompleHepatitisB1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_nomCompleResponVacuHepatitisB1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_estaSaludColocoVaciHepatitisB1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_observaHepatitisB1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">2º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_fechaHepatitisB2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_loteHepatitisB2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_esqueCompleHepatitisB2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_nomCompleResponVacuHepatitisB2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_estaSaludColocoVaciHepatitisB2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_observaHepatitisB2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">3º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_fechaHepatitisB3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_loteHepatitisB3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_esqueCompleHepatitisB3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_nomCompleResponVacuHepatitisB3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_estaSaludColocoVaciHepatitisB3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_observaHepatitisB3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell RowSpan="1" Text="Influenza estacionaria" Style="background-color: #ccffff; font-size: 15px"></asp:TableCell>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">Dosis única</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_fechaInfluenza" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_loteInfluenza" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_esqueCompleInfluenza" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_nomCompleResponVacuInfluenza" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_estaSaludColocoVacuInfluenza" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_observaInfluenza" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell RowSpan="1" Text="Fiebre Amarilla" Style="background-color: #ccffff; font-size: 15px"></asp:TableCell>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">Dosis única</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_fechaFiebreAmarilla" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_loteFiebreAmarilla" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_esqueCompleFiebreAmarilla" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_nomCompleResponVacuFiebreAmarilla" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_estaSaludColocoVacuFiebreAmarilla" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_observaFiebreAmarilla" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell RowSpan="2" Text="Sarampión - Rubéola" Style="background-color: #ccffff; font-size: 15px"></asp:TableCell>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">1º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_fechaSarampion1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_loteSarampion1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_esqueCompleSarampion1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_nomCompleResponVacuSarampion1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_estaSaludColocoVacuSarampion1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_observaSarampion1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">2º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_fechaSarampion2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_loteSarampion2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_esqueCompleSarampion2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_nomCompleResponVacuSarampion2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_estaSaludColocoVacuSarampion2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_observaSarampion2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="8" Style="background-color: white; font-size: 13px; text-align: left">
                    <asp:Label  runat="server" Text="INMUNIZACIONES DE ACUERDO AL TIPO DE EMPRESA Y RIESGO" style="text-align:left"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell RowSpan="5" Style="background-color: #ccffff; font-size: 15px">
                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">1º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_1fechaInmuAcuerTipoEmpRies1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_1loteInmuAcuerTipoEmpRies1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_1esqueCompleInmuAcuerTipoEmpRies1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_1nomCompleResponVacuInmuAcuerTipoEmpRies1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_1observaInmuAcuerTipoEmpRies1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">2º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_1fechaInmuAcuerTipoEmpRies2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_1loteInmuAcuerTipoEmpRies2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_1esqueCompleInmuAcuerTipoEmpRies2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_1nomCompleResponVacuInmuAcuerTipoEmpRies2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_1observaInmuAcuerTipoEmpRies2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">3º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_1fechaInmuAcuerTipoEmpRies3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_1loteInmuAcuerTipoEmpRies3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_1esqueCompleInmuAcuerTipoEmpRies3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_1nomCompleResponVacuInmuAcuerTipoEmpRies3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_1observaInmuAcuerTipoEmpRies3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">4º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_1fechaInmuAcuerTipoEmpRies4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_1loteInmuAcuerTipoEmpRies4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_1esqueCompleInmuAcuerTipoEmpRies4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_1nomCompleResponVacuInmuAcuerTipoEmpRies4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_1observaInmuAcuerTipoEmpRies4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">5º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_1fechaInmuAcuerTipoEmpRies5" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_1loteInmuAcuerTipoEmpRies5" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_1esqueCompleInmuAcuerTipoEmpRies5" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_1nomCompleResponVacuInmuAcuerTipoEmpRies5" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies5" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_1observaInmuAcuerTipoEmpRies5" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell RowSpan="5" Style="background-color: #ccffff; font-size: 15px">
                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">1º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_2fechaInmuAcuerTipoEmpRies1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_2loteInmuAcuerTipoEmpRies1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_2esqueCompleInmuAcuerTipoEmpRies1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_2nomCompleResponVacuInmuAcuerTipoEmpRies1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_2observaInmuAcuerTipoEmpRies1" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">2º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_2fechaInmuAcuerTipoEmpRies2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_2loteInmuAcuerTipoEmpRies2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_2esqueCompleInmuAcuerTipoEmpRies2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_2nomCompleResponVacuInmuAcuerTipoEmpRies2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_2observaInmuAcuerTipoEmpRies2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">3º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_2fechaInmuAcuerTipoEmpRies3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_2loteInmuAcuerTipoEmpRies3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_2esqueCompleInmuAcuerTipoEmpRies3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_2nomCompleResponVacuInmuAcuerTipoEmpRies3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_2observaInmuAcuerTipoEmpRies3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">4º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_2fechaInmuAcuerTipoEmpRies4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_2loteInmuAcuerTipoEmpRies4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_2esqueCompleInmuAcuerTipoEmpRies4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_2nomCompleResponVacuInmuAcuerTipoEmpRies4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_2observaInmuAcuerTipoEmpRies4" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">5º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_2fechaInmuAcuerTipoEmpRies5" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_2loteInmuAcuerTipoEmpRies5" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_2esqueCompleInmuAcuerTipoEmpRies5" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_2nomCompleResponVacuInmuAcuerTipoEmpRies5" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies5" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_2observaInmuAcuerTipoEmpRies5" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell RowSpan="5" Style="background-color: #ccffff; font-size: 15px">
                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">1º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">2º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">3º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">4º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">5º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell RowSpan="5" Style="background-color: #ccffff; font-size: 15px">
                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">1º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">2º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">3º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">4º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #ccffff; font-size: 15px">5º</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="8" Style="background-color: white; font-size: 13px; text-align: left">
                    <asp:Label  runat="server" Text="La vacuna de la Fiebre Amarilla es obligatoria para quien viva o se desplace en la Región Amazónica, su aplicación es hasta los 59 años de edad" style="text-align:left"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
                <br />
                <div class="container" align="center">
                    <asp:Button CssClass="btn btn-warning" ID="btn_guardar" runat="server" OnClick="btn_guardar_Click" Text="Guardar" UseSubmitBehavior="False" />
                    <asp:Button CssClass="btn btn-danger" ID="btn_cancelar" runat="server" OnClick="btn_cancelar_Click" Text="Cancelar" UseSubmitBehavior="False" />
                </div>
                <br />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
