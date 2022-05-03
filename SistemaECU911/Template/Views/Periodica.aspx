﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Views/Principal.Master" AutoEventWireup="true" CodeBehind="Periodica.aspx.cs" Inherits="SistemaECU911.Template.Views.Periodica" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://cdn.jsdelivr.net/npm/select2@4.1.0-rc.0/dist/css/select2.min.css" rel="stylesheet" />

    <style type="text/css">
        .CompletionList
        {             
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
        
        .CompletionListItem
        {
	          display: block;
              padding: 3px 20px;
              clear: both;
              font-weight: normal;
              line-height: 20px;
              color: #333333;
              white-space: nowrap;
        }
        

        .CompletionListHighlightedItem
        {
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
            <div class="container" style="background-color: white; font-family:Arial">
                <br />
                <div class="container">
                    <div class="text-center" style="font-size: 25px">
                        GESTIÓN DE SEGURIDAD Y SALUD OCUPACIONAL<br />
                            HISTORIA CLÍNICA OCUPACIONAL - PERIÓDICA                        
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" style="background-color: #cccdfe; font-size: 15px; font-weight:bold">
                        A. DATOS DEL ESTABLECIMIENTO - EMPRESA Y USUARIO
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="INSTITUCIÓN DEL SISTEMA O NOMBRE DE LA EMPRESA" Style="width: 350px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="RUC" Style="width: 125px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="CIIU" Style="width: 125px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="ESTABLECIMIENTO DE SALUD" Style="width: 250px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="NÚMERO DE HISTORIA CLÍNICA" Style="width: 200px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="NÚMERO DE ARCHIVO" Style="width: 200px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center;" Text="Servicio Integrado de Seguridad" ReadOnly="true"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" Text="1768174880001" ReadOnly="true"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center" Text="Consultorio Médico" ReadOnly="true"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_numHClinica" OnTextChanged="txt_numHClinica_TextChanged" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" AutoPostBack="true"></asp:TextBox>
                                    <ajaxToolkit:AutoCompleteExtender ID="AutoCompleteExtender2" runat="server" CompletionInterval="10" DelimiterCharacters="" Enabled="True"
                                        MinimumPrefixLength="1" ServiceMethod="ObtenerNumHClinica"
                                        TargetControlID="txt_numHClinica" CompletionListCssClass="CompletionList"
                                        CompletionListHighlightedItemCssClass="CompletionListHighlightedItem"
                                        CompletionListItemCssClass="CompletionListItem">
                                        </ajaxToolkit:AutoCompleteExtender>
                                </asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" ID="txt_numArchivo" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="PRIMER APELLIDO" Style="width: 250px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="SEGUNDO APELLIDO" Style="width: 250px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="PRIMER NOMBRE" Style="width: 250px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="SEGUNDO NOMBRE" Style="width: 250px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="SEXO" Style="width: 50px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="PUESTO DE TRABAJO (CIUO)" Style="width: 250px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white; font-size: 14px">
                                    <asp:TextBox ID="txt_priApellido" runat="server" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                    <asp:TextBox ID="txt_segNombre" runat="server" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                    <asp:TextBox ID="txt_priNombre" runat="server" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                    <asp:TextBox ID="txt_segApellido" runat="server" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                    <asp:TextBox ID="txt_sexo" runat="server" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                    <asp:TextBox ID="txt_puestodetrabajoperiodica" runat="server" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="MultiLine" Rows="4"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" style="background-color: #cccdfe; font-size: 15px; font-weight:bold">
                        B. MOTIVO DE CONSULTA 
                    </div>
                    <div class="list-group list-group-flush" Style="background-color: white">
                        <asp:TextBox ID="txt_motivoconsultaperiodica" runat="server" BorderStyle="None" Style="background-color: transparent; width: 100%;" placeholder="Descripción" TextMode="MultiLine" Rows="3"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" style="background-color: #cccdfe; font-size: 15px; font-weight:bold">
                        C. ANTECEDENTES PERSONALES
                    </div>
                    <div class="card-header" style="background-color: #cdfecc; font-size: 15px">
                        ANTECEDENTES CLÍNICOS Y QUIRÚRGICOS
                    </div>
                    <div class="list-group list-group-flush" Style="background-color: white">
                        <asp:TextBox runat="server" ID="txt_antCliQuiDescripcion" BorderStyle="None" Style="width: 100%" TextMode="MultiLine" Rows="3" placeholder="Descripción" ></asp:TextBox>
                    </div>
                    <div class="card" style="width: auto;">
                        <div class="card-header col" style="background-color: #cdfecc; font-size: 15px">
                            HÁBITOS TÓXICOS 
                        </div>
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="width: 300px; background-color: #ccffff; font-size: 15px">CONSUMOS NOCIVOS</asp:TableCell>
                            <asp:TableCell Style="width: 75px; background-color: #ccffff; font-size: 15px">SI</asp:TableCell>
                            <asp:TableCell Style="width: 75px; background-color: #ccffff; font-size: 15px">NO</asp:TableCell>
                            <asp:TableCell Style="width: 200px; background-color: #ccffff; font-size: 15px">TIEMPO DE CONSUMO<br />(meses)</asp:TableCell>
                            <asp:TableCell Style="width: 250px; background-color: #ccffff; font-size: 15px">CANTIDAD</asp:TableCell>
                            <asp:TableCell Style="width: 200px; background-color: #ccffff; font-size: 15px">EX CONSUMIDOR</asp:TableCell>
                            <asp:TableCell Style="width: 200px; background-color: #ccffff; font-size: 15px">TIEMPO DE ABSTINENCIA<br />(meses)</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: white; font-size: 15px">TABACO</asp:TableCell>
                            <asp:TableCell Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_siConsuNociTabaHabToxi" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="txt_siConsuNociTabaHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_noConsuNociTabaHabToxi" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="txt_noConsuNociTabaHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiemConConsuNociTabaHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_cantiConsuNociTabaHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_exConsumiConsuNociTabaHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiemAbstiConsuNociTabaHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: white; font-size: 15px">ALCOHOL</asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_siConsuNociAlcoHabToxi" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_siConsuNociAlcoHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_noConsuNociAlcoHabToxi" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_noConsuNociAlcoHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiemConConsuNociAlcoHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_cantiConsuNociAlcoHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_exConsumiConsuNociAlcoHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiemAbstiConsuNociAlcoHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: white; font-size: 15px">OTRAS DROGAS</asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px" RowSpan="2">
                                <asp:CheckBox ID="ckb_siConsuNociOtrasDroHabToxi" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_siConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px" RowSpan="2">
                                <asp:CheckBox ID="ckb_noConsuNociOtrasDroHabToxi" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_noConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiemCon1ConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_canti1ConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_exConsumi1ConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiemAbsti1ConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_otrasConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiemCon2ConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_canti2ConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_exConsumi2ConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiemAbsti2ConsuNociOtrasDroHabToxi" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <div class="card" style="width: auto;">
                        <div class="card-header" style="background-color: #cdfecc; font-size: 15px">
                            ESTILO DE VIDA
                        </div>
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="width: 300px; background-color: #ccffff; font-size: 15px">ESTILO</asp:TableCell>
                            <asp:TableCell Style="width: 75px; background-color: #ccffff; font-size: 15px">SI</asp:TableCell>
                            <asp:TableCell Style="width: 75px; background-color: #ccffff; font-size: 15px">NO</asp:TableCell>
                            <asp:TableCell Style="width: 550px; background-color: #ccffff; font-size: 15px">¿CUÁL?</asp:TableCell>
                            <asp:TableCell Style="width: 300px; background-color: #ccffff; font-size: 15px">TIEMPO/CANTIDAD</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: white; font-size: 15px">ACTIVIDAD FÍSICA</asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_siEstVidaActFisiEstVida" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_siEstVidaActFisiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_noEstVidaActFisiEstVida" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_noEstVidaActFisiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_cualEstVidaActFisiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiemCanEstVidaActFisiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="Tiempo (dia)"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell RowSpan="3" Style="background-color: white; font-size: 15px">MEDICACIÓN HABITUAL</asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px" RowSpan="3">
                                <asp:CheckBox ID="ckb_siEstVidaMedHabiEstVida" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_siEstVidaMedHabiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px" RowSpan="3">
                                <asp:CheckBox ID="ckb_noEstVidaMedHabiEstVida" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_noEstVidaMedHabiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_cual1EstVidaMedHabiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiemCan1EstVidaMedHabiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" placeholder="Cantidad (unidad)"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_cual2EstVidaMedHabiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiemCan2EstVidaMedHabiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_cual3EstVidaMedHabiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiemCan3EstVidaMedHabiEstVida" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <div class="card" style="width: auto;">
                        <div class="card-header" style="background-color: #cdfecc; font-size: 15px">
                            INCIDENTES
                        </div>
                    </div>
                    <div class="list-group list-group-flush" Style="background-color: white">
                        <asp:TextBox runat="server" ID="txt_incidentesperiodica" BorderStyle="None" Style="width: 100%" TextMode="MultiLine" Rows="3" placeholder="Describir los principales incidentes suscitados"></asp:TextBox>
                    </div>
                    </br>
                    <div class="card" style="width: auto;">
                        <div class="card-header" style="background-color: #cdfecc; font-size: 15px">
                            ACCIDENTES DE TRABAJO (DESCRIPCIÓN)
                        </div>
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="width: 600px; background-color: white; font-size: 15px">FUE CALIFICADO POR EL INSTITUTO DE SEGURIDAD SOCIAL CORRESPONDIENTE: </asp:TableCell>
                            <asp:TableCell Style="width: 50px; background-color: white; font-size: 15px">SI</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_sicalificadotrabajo" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_sicalificadotrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 100px; background-color: white; font-size: 15px">ESPECIFICAR</asp:TableCell>
                            <asp:TableCell style="width:150px; background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_especificarcalificadotrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 50px; background-color: white; font-size: 15px">NO</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_nocalificadotrabajo" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_nocalificadotrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 75px; background-color: white; font-size: 15px">FECHA:</asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_fechacalificadotrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="9" Style="background-color: white">
                                <asp:TextBox ID="txt_obsercalificadotrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%;" placeholder="Observaciones:" TextMode="MultiLine" Rows="3" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <div class="card" style="width: auto;">
                        <div class="card-header" style="background-color: #cdfecc; font-size: 15px">
                            ENFERMEDADES PROFESIONALES 
                        </div>
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="width: 600px; background-color: white; font-size: 15px">FUE CALIFICADO POR EL INSTITUTO DE SEGURIDAD SOCIAL CORRESPONDIENTE: </asp:TableCell>
                            <asp:TableCell Style="width: 50px; background-color: white; font-size: 15px">SI</asp:TableCell>
                            <asp:TableCell Style="width: 50px; background-color: white; font-size: 15px">
                                <asp:CheckBox ID="ckb_sicalificadoprofesional" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_sicalificadoprofesional" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 100px; background-color: white; font-size: 15px">ESPECIFICAR</asp:TableCell>
                            <asp:TableCell Style="width: 150px; background-color: white; font-size: 15px">
                                <asp:TextBox runat="server" ID="txt_especificarcalificadoprofesional" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 50px; background-color: white; font-size: 15px">NO</asp:TableCell>
                            <asp:TableCell Style="width: 50px; background-color: white; font-size: 15px">
                                <asp:CheckBox ID="ckb_nocalificadoprofesional" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_nocalificadoprofesional" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 75px; background-color: white; font-size: 15px">FECHA:</asp:TableCell>
                            <asp:TableCell style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_fechacalificadoprofesional" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="9" Style="background-color: white; font-size: 14px">
                                <asp:TextBox ID="txt_obsercalificadoprofesional" BorderStyle="None" Style="background-color: transparent; width: 100%;" placeholder="Observaciones:" TextMode="MultiLine" Rows="3" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="row">
                        <div class="card-header col" style="margin-left: 0.8rem; background-color: #cccdfe; font-size: 15px; font-weight:bold">
                            D. ANTECEDENTES FAMILIARES (DETALLAR EL PARENTESCO)                                          
                        </div>
                        <div class="card-header col" style="text-align: right; margin-right: 0.8rem; background-color: #cccdfe; font-size: 13px">
                            DESCRIBIR ABAJO ANOTANDO EL NÚMERO                                        
                        </div>
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="width: 275px; background-color: #cdfecc; font-size: 15px">1. ENFERMEDAD CARDIO-VASCULAR</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_enfermedadcardiovascular" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="txt_enfermedadcardiovascular" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 275px; background-color: #cdfecc; font-size: 15px">2. ENFERMEDAD METABÓLICA</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_enfermedadmetabolica" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="txt_enfermedadmetabolica" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 275px; background-color: #cdfecc; font-size: 15px">3. ENFERMEDAD NEUROLÓGICA</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_enfermedadneurologica" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="txt_enfermedadneurologica" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 275px; background-color: #cdfecc; font-size: 15px">4. ENFERMEDAD ONCOLÓGICA</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_enfermedadoncologica" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="txt_enfermedadoncologica" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="width: 275px; background-color: #cdfecc; font-size: 15px">5. ENFERMEDAD INFECCIOSA</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_enfermedadinfecciosa" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="txt_enfermedadinfecciosa" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 275px; background-color: #cdfecc; font-size: 15px">6. ENFERMEDAD HEREDITARIA/CONGÉNITA</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_enfermedadhereditaria" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="txt_enfermedadhereditaria" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 275px; background-color: #cdfecc; font-size: 15px">7. DISCAPACIDADES</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">
                                v<asp:CheckBox ID="ckb_discapacidades" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="txt_discapacidades" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 275px; background-color: #cdfecc; font-size: 15px">8. OTROS</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_otrosenfer" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="txt_otrosenfer" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="8" Style="background-color: white; font-size: 14px">
                                <asp:TextBox ID="txt_descripcionantefamiliares" BorderStyle="None" Style="background-color: transparent; width: 100%;" runat="server" placeholder="Descripción" TextMode="MultiLine" Rows="6"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" style="background-color: #cccdfe; font-size: 15px; font-weight:bold">
                        E.  FACTORES DE RIESGOS DEL PUESTO DE TRABAJO                                         
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px" RowSpan="2" ColumnSpan="2">PUESTO DE TRABAJO / ÁREA</asp:TableCell>
                            <asp:TableCell Style="width: 400px; background-color: #cdfecc; font-size: 15px" RowSpan="2">ACTIVIDADES</asp:TableCell>
                            <asp:TableCell Style="width: 75px; background-color: #cdfecc; font-size: 15px" RowSpan="2">TIEMPO DE TRABAJO (MESES)</asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px" ColumnSpan="10">FÍSICO</asp:TableCell>                            
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label9" runat="server" Text="Temperaturas altas"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label10" runat="server" Text="Temperaturas bajas"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label25" runat="server" Text="Radiación Ionizante"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label26" runat="server" Text="Radiación No Ionizante"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label27" runat="server" Text="Ruido"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label28" runat="server" Text="Vibración"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label29" runat="server" Text="Iluminación"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label30" runat="server" Text="Ventilación"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label31" runat="server" Text="Fluido eléctrico"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label32" runat="server" Text="Otros __________"></asp:Label>
                            </asp:TableCell>                            
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 15px">1. </asp:TableCell>
                            <asp:TableCell style="width:400px; background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_puestotrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_act" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiempotrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_tempaltas" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="txt_tempaltas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_tempbajas" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_tempbajas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_radiacion" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_radiacion" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_noradiacion" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_noradiacion" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_ruido" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_ruido" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_vibracion" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_vibracion" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_iluminacion" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_iluminacion" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_ventilacion" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_ventilacion" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_fluidoelectrico" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_fluidoelectrico" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_otrosFisico" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_otrosFisico" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>                           
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 15px">2. </asp:TableCell>
                            <asp:TableCell style="width:400px; background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_puestotrabajo2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_act2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiempotrabajo2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_tempaltas2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_tempaltas2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_tempbajas2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_tempbajas2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_radiacion2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_radiacion2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_noradiacion2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_noradiacion2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_ruido2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_ruido2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_vibracion2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_vibracion2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_iluminacion2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_iluminacion2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_ventilacion2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_ventilacion2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_fluidoelectrico2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_fluidoelectrico2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_otrosFisico2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_otrosFisico2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>                           
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 15px">3. </asp:TableCell>
                            <asp:TableCell style="width:400px; background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_puestotrabajo3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_act3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiempotrabajo3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_tempaltas3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_tempaltas3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_tempbajas3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_tempbajas3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_radiacion3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_radiacion3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_noradiacion3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_noradiacion3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_ruido3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_ruido3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_vibracion3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_vibracion3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_iluminacion3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_iluminacion3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_ventilacion3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_ventilacion3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_fluidoelectrico3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_fluidoelectrico3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_otrosFisico3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_otrosFisico3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>                           
                        </asp:TableRow>
                    </asp:Table>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="width: 400px; background-color: #cdfecc; font-size: 15px" ColumnSpan="15">MECÁNICO</asp:TableCell>
                            <asp:TableCell Style="width: 250px; background-color: #cdfecc; font-size: 15px" ColumnSpan="9">QUÍMICO</asp:TableCell>
                            <asp:TableCell Style="width: 200px; background-color: #cdfecc; font-size: 15px" ColumnSpan="7">BIÓLOGO</asp:TableCell>
                            <asp:TableCell Style="width: 250px; background-color: #cdfecc;  font-size: 15px" ColumnSpan="5">ERGONÓMICO</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label33" runat="server" Text="Atrapamiento entre máquinas"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label34" runat="server" Text="Atrapamiento entre superficies"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label35" runat="server" Text="Atrapamiento entre objetos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label36" runat="server" Text="Caída de objetos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label37" runat="server" Text="Caídas al mismo nivel"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label38" runat="server" Text="Caídas a diferente nivel"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label39" runat="server" Text="Contacto eléctrico"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label40" runat="server" Text="Contacto con superficies de trabajos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label41" runat="server" Text="Proyección de partículas – fragmentos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label42" runat="server" Text="Proyección de fluidos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label43" runat="server" Text="Pinchazos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label44" runat="server" Text="Cortes"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label45" runat="server" Text="Atropellamientos por vehículos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label46" runat="server" Text="Choques /colisión vehicular"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label47" runat="server" Text="Otros __________"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label48" runat="server" Text="Sólidos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label49" runat="server" Text="Polvos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label50" runat="server" Text="Humos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label51" runat="server" Text="Líquidos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label52" runat="server" Text="Vapores"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label53" runat="server" Text="Aerosoles"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label54" runat="server" Text="Neblinas"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label55" runat="server" Text="Gaseosos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label56" runat="server" Text="Otros __________"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label57" runat="server" Text="Virus"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label58" runat="server" Text="Hongos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label59" runat="server" Text="Bacterias "></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label60" runat="server" Text="Parásitos "></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label61" runat="server" Text="Exposición a vectores"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label62" runat="server" Text="Exposición a animales selváticos "></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label63" runat="server" Text="Otros __________"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label64" runat="server" Text="Manejo manual de cargas"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label65" runat="server" Text="Movimiento repetitivos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label66" runat="server" Text="Posturas forzadas"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label67" runat="server" Text="Trabajos con PVD"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label68" runat="server" Text="Otros __________"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_atrapmaquinas" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_atrapmaquinas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_atrapsuperficie" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_atrapsuperficie" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_atrapobjetos" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_atrapobjetos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_caidaobjetos" Checked="false" runat="server" /> 
                                <%--<asp:TextBox runat="server" ID="ckb_caidaobjetos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_caidamisnivel" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_caidamisnivel" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_caidadifnivel" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_caidadifnivel" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_contaelectrico" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_contaelectrico" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_contasuptrabajo" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_contasuptrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_proyparticulas" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_proyparticulas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_proyefluidos" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_proyefluidos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_pinchazos" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_pinchazos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_cortes" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_cortes" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_atroporvehiculos" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_atroporvehiculos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_choques" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_choques" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_otrosMecanico" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_otrosMecanico" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_solidos" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_solidos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_polvos" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_polvos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_humos" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_humos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_liquidos" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_liquidos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_vapores" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_vapores" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_aerosoles" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_aerosoles" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_neblinas" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_neblinas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_gaseosos" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_gaseosos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_otrosQuimico" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_otrosQuimico" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_virus" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_virus" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_hongos" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_hongos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_bacterias" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_bacterias" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_parasitos" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_parasitos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_expoavectores" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_expoavectores" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_expoanimselvaticos" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_expoanimselvaticos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_otrosBiologico" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_otrosBiologico" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_manmanualcargas" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_manmanualcargas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_movrepetitivo" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_movrepetitivo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_postforzadas" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_postforzadas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_trabajopvd" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_trabajopvd" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_otrosErgonomico" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_otrosErgonomico" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_atrapmaquinas2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_atrapmaquinas2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_atrapsuperficie2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_atrapsuperficie2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_atrapobjetos2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_atrapobjetos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_caidaobjetos2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_caidaobjetos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_caidamisnivel2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_caidamisnivel2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_caidadifnivel2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_caidadifnivel2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_contaelectrico2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_contaelectrico2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_contasuptrabajo2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_contasuptrabajo2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_proyparticulas2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_proyparticulas2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_proyefluidos2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_proyefluidos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_pinchazos2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_pinchazos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_cortes2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_cortes2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_atroporvehiculos2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_atroporvehiculos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_choques2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_choques2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_otrosMecanico2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_otrosMecanico2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_solidos2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_solidos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_polvos2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_polvos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_humos2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_humos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_liquidos2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_liquidos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_vapores2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_vapores2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_aerosoles2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_aerosoles2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_neblinas2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_neblinas2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_gaseosos2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_gaseosos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_otrosQuimico2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_otrosQuimico2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_virus2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_virus2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_hongos2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_hongos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_bacterias2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_bacterias2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_parasitos2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_parasitos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_expoavectores2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_expoavectores2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_expoanimselvaticos2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_expoanimselvaticos2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_otrosBiologico2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_otrosBiologico2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_manmanualcargas2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_manmanualcargas2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_movrepetitivo2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_movrepetitivo2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_postforzadas2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_postforzadas2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_trabajopvd2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_trabajopvd2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_otrosErgonomico2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_otrosErgonomico2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_atrapmaquinas3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_atrapmaquinas3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_atrapsuperficie3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_atrapsuperficie3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_atrapobjetos3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_atrapobjetos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_caidaobjetos3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_caidaobjetos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_caidamisnivel3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_caidamisnivel3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_caidadifnivel3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_caidadifnivel3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_contaelectrico3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_contaelectrico3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_contasuptrabajo3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_contasuptrabajo3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_proyparticulas3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_proyparticulas3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_proyefluidos3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_proyefluidos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_pinchazos3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_pinchazos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_cortes3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_cortes3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_atroporvehiculos3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_atroporvehiculos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_choques3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_choques3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_otrosMecanico3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_otrosMecanico3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_solidos3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_solidos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_polvos3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_polvos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_humos3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_humos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_liquidos3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_liquidos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_vapores3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_vapores3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_aerosoles3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_aerosoles3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_neblinas3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_neblinas3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_gaseosos3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_gaseosos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_otrosQuimico3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_otrosQuimico3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_virus3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_virus3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_hongos3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_hongos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_bacterias3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_bacterias3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_parasitos3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_parasitos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_expoavectores3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_expoavectores3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_expoanimselvaticos3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_expoanimselvaticos3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_otrosBiologico3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_otrosBiologico3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_manmanualcargas3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_manmanualcargas3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_movrepetitivo3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_movrepetitivo3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_postforzadas3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_postforzadas3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_trabajopvd3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_trabajopvd3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_otrosErgonomico3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_otrosErgonomico3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px" RowSpan="2" ColumnSpan="2">PUESTO DE TRABAJO / ÁREA</asp:TableCell>
                            <asp:TableCell Style="width: 400px; background-color: #cdfecc; font-size: 15px" RowSpan="2">ACTIVIDADES</asp:TableCell>
                            <asp:TableCell Style="width: 75px; background-color: #cdfecc; font-size: 15px" RowSpan="2">TIEMPO DE TRABAJO (MESES)</asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px" ColumnSpan="13">PSICOSOCIAL</asp:TableCell>                            
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label69" runat="server" Text="Monotonía del trabajo "></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label70" runat="server" Text="Sobrecarga laboral"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label71" runat="server" Text="Minuciosidad de la tarea "></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label72" runat="server" Text="Alta responsabilidad"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label73" runat="server" Text="Autonomía  en la toma de decisiones"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label74" runat="server" Text="Supervisión y estilos de dirección deficiente"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label75" runat="server" Text="Conflicto de rol"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label76" runat="server" Text="Falta de Claridad en las funciones"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label77" runat="server" Text="Incorrecta distribución del trabajo"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label78" runat="server" Text="Turnos rotativos"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label79" runat="server" Text="Relaciones interpersonales"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label80" runat="server" Text="Inestabilidad laboral"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell Style="background-color: #cdfecc; font-size: 15px">
                                <asp:Label CssClass="in-column" ID="Label81" runat="server" Text="Otros __________"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 15px">1. </asp:TableCell>
                            <asp:TableCell style="width:400px; background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_puestotrabajo21" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_act21" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiempotrabajo21" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_montrabajo" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_montrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_sobrecargalaboral" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_sobrecargalaboral" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_minustarea" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_minustarea" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_altarespon" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_altarespon" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_automadesiciones" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_automadesiciones" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_supyestdireficiente" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_supyestdireficiente" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_conflictorol" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_conflictorol" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_faltaclarfunciones" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_faltaclarfunciones" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_incorrdistrabajo" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_incorrdistrabajo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_turnorotat" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_turnorotat" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_relacinterpersonales" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_relacinterpersonales" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_inestalaboral" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_inestalaboral" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_otrosPsisocial" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_otrosPsisocial" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>                            
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 15px">2. </asp:TableCell>
                            <asp:TableCell style="width:400px; background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_puestotrabajo22" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_act22" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiempotrabajo22" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_montrabajo2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_montrabajo2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_sobrecargalaboral2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_sobrecargalaboral2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_minustarea2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_minustarea2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_altarespon2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_altarespon2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_automadesiciones2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_automadesiciones2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_supyestdireficiente2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_supyestdireficiente2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_conflictorol2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_conflictorol2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_faltaclarfunciones2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_faltaclarfunciones2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_incorrdistrabajo2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_incorrdistrabajo2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_turnorotat2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_turnorotat2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_relacinterpersonales2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_relacinterpersonales2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_inestalaboral2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_inestalaboral2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_otrosPsisocial2" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_otrosPsisocial2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>                            
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 15px">3. </asp:TableCell>
                            <asp:TableCell style="width:400px; background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_puestotrabajo23" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_act23" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_tiempotrabajo23" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_montrabajo3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_montrabajo3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_sobrecargalaboral3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_sobrecargalaboral3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_minustarea3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_minustarea3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_altarespon3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_altarespon3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_automadesiciones3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_automadesiciones3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_supyestdireficiente3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_supyestdireficiente3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_conflictorol3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_conflictorol3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_faltaclarfunciones3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_faltaclarfunciones3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_incorrdistrabajo3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_incorrdistrabajo3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_turnorotat3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_turnorotat3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_relacinterpersonales3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_relacinterpersonales3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_inestalaboral3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_inestalaboral3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_otrosPsisocial3" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_otrosPsisocial3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>                            
                        </asp:TableRow>
                    </asp:Table>

                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="width: 1400px; background-color: #cdfecc; font-size: 15px">MEDIDAS PREVENTIVAS</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_medpreventivas" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_medpreventivas2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell  Style="background-color: white; font-size: 14px">
                                <asp:TextBox runat="server" ID="txt_medpreventivas3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" Style="background-color: #cccdfe; font-size: 15px; font-weight:bold">
                        F. ENFERMEDAD ACTUAL 
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:TextBox ID="txt_enfermedadactualperiodica" runat="server" BorderStyle="None" Style="background-color: transparent; width: 100%;" placeholder="Descripción: " TextMode="MultiLine" Rows="3"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="row">
                        <div class="card-header col" style="margin-left: 0.8rem; background-color: #cccdfe; font-size: 15px; font-weight:bold">
                            G. REVISIÓN DE ÓRGANOS Y SISTEMAS                                          
                        </div>
                        <div class="card-header col text-center" style="text-align: right; margin-right: 0.8rem; background-color: #cccdfe; font-size: 13px">
                            EN CASO DE EXISTIR PATOLOGÍA  MARCAR CON "X"  Y DESCRIBIR ABAJO COLOCANDO EL NUMERAL                                         
                        </div>
                    </div>
                    <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Style="width: 275px; background-color: #ccffff; font-size: 15px">1. PIEL - ANEXOS</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_pielanexos" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_pielanexos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 275px; background-color: #ccffff; font-size: 15px">3. RESPIRATORIO</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_respiratorio" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_respiratorio" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 275px; background-color: #ccffff; font-size: 15px">5. DIGESTIVO</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_digestivo" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_digestivo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 275px; background-color: #ccffff; font-size: 15px">7. MÚSCULO ESQUELÉTICO</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_musculosesqueleticos" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_musculosesqueleticos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 275px; background-color: #ccffff; font-size: 15px">9. HEMO LINFÁTICO</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_hemolinfatico" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_hemolinfatico" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Style="width: 275px; background-color: #ccffff; font-size: 15px">2. ÓRGANOS DE LOS SENTIDOS</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_organossentidos" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_organossentidos" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 275px; background-color: #ccffff; font-size: 15px">4. CARDIO-VASCULAR</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_cardiovascular" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_cardiovascular" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 275px; background-color: #ccffff; font-size: 15px">6. GENITO - URINARIO</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_genitourinario" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_genitourinario" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 275px; background-color: #ccffff; font-size: 15px">8. ENDOCRINO</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_endocrino" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_endocrino" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                            <asp:TableCell Style="width: 275px; background-color: #ccffff; font-size: 15px">10. NERVIOSO</asp:TableCell>
                            <asp:TableCell style="width:50px; background-color: white; font-size: 14px">
                                <asp:CheckBox ID="ckb_nervioso" Checked="false" runat="server" />
                                <%--<asp:TextBox runat="server" ID="ckb_nervioso" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="10" Style="background-color: white; font-size: 14px">
                                <asp:TextBox ID="txt_descrorganosysistemasperiodica" BorderStyle="None" Style="background-color: transparent; width: 100%;" runat="server" placeholder="Descripción" TextMode="MultiLine" Rows="6"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" Style="background-color: #cccdfe; font-size: 15px; font-weight:bold">
                        H. CONSTANTES VITALES Y ANTROPOMETRÍA 
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="PRESIÓN ARTERIAL (mmHg)" Style="width: 175px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="TEMPERATURA (°C)" Style="width: 175px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="FRECUENCIA CARDIACA (Lat/min)" Style="width: 175px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="SATURACIÓN DE OXÍGENO (O2%)" Style="width: 175px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="FRECUENCIA RESPIRATORIA (fr/min)" Style="width: 175px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="PESO (Kg)" Style="width: 175px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="TALLA (cm)" Style="width: 175px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="ÍNDICE DE MASA CORPORAL (kg/m2)" Style="width: 175px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                                <asp:TableCell Text="PERÍMETRO ABDOMINAL(cm)" Style="width: 175px; background-color: #cdfecc; font-size: 15px"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" Style="background-color: #cccdfe; font-size: 15px; font-weight:bold">
                        I. EXAMEN FÍSICO REGIONAL
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="REGIONES" Style="width: 1400px; text-align: left; background-color: #cdfecc; font-size:15px" ColumnSpan="15"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell RowSpan="3" style="width: 65px; background-color: #ccffff; font-size:15px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label1" runat="server" Text="1. Piel"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="width: 120px; background-color: #ccffff; font-size:15px">a. Cicatrices</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="width: 60px; background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_cicatrices" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_cicatrices" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="3" style="width: 65px; background-color: #ccffff; font-size:15px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label2" runat="server" Text="3. Oído"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="width: 120px; background-color: #ccffff; font-size:15px">a. C. auditivo externo</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="width: 60px; background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_auditivoexterno" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_auditivoexterno" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="4" style="width: 65px ;background-color: #ccffff; font-size:15px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label82" runat="server" Text="5. Nariz"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="width: 120px; background-color: #ccffff; font-size:15px">a. Tabique</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="width: 60px; background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_tabique" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_tabique" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2" style="width: 65px; background-color: #ccffff; font-size:15px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label83" runat="server" Text="8. Tórax"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="width: 120px; background-color: #ccffff; font-size:15px">a. Pulmones</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="width: 60px; background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_pulmones" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_pulmones" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2" style="width: 65px; background-color: #ccffff; font-size:15px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label84" runat="server" Text="11. Pelvis"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="width: 120px; background-color: #ccffff; font-size:15px">a. Pelvis</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="width: 60px; background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_pelvis" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_pelvis" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">b. Tatuajes</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_tatuajes" Checked="false" runat="server" />
                                      <%--<asp:TextBox runat="server" ID="ckb_tatuajes" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">b. Pabellón</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_pabellon" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_pabellon" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">b. Cornetes</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_cornetes" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_cornetes" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">b. Parrilla Costal</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_parrillacostal" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_parrillacostal" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">b. Genitales</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_genitales" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_genitales" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">c. Piel  y Faneras</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_pielyfaneras" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_pielyfaneras" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">c. Tímpanos</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_timpanos" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_timpanos" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">c. Mucosas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_mucosa" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_mucosa" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2" style="background-color: #ccffff; font-size:15px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label85" runat="server" Text="9. Abdomen"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">a. Vísceras</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_visceras" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_visceras" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="3" style="background-color: #ccffff; font-size:15px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label86" runat="server" Text="12. Extremidades"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">a. Vascular</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_vascular" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_vascular" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell RowSpan="5" style="background-color: #ccffff; font-size:15px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label87" runat="server" Text="2. Ojos"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">a. Párpados</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_parpados" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_parpados" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="5" style="background-color: #ccffff; font-size:15px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label88" runat="server" Text="4. Oro faringe"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">a. Labios</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_labios" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_labios" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">d. Senos paranasales</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_senosparanasales" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_senosparanasales" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">b. Pared abdominal</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_paredabdominal" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_paredabdominal" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">b. Miembros superiores</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_miembrosuperiores" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_miembrosuperiores" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">b. Conjuntivas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_conjuntivas" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_conjuntivas" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">b. Lengua</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_lengua" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_lengua" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2" style="background-color: #ccffff; font-size:15px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label89" runat="server" Text="6. Cuello"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">a. Tiroides / masas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_tiroides" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_tiroides" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="4" style="background-color: #ccffff; font-size:15px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label90" runat="server" Text="10. Columna"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">a. Flexibilidad</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_flexibilidad" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_flexibilidad" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">c. Miembros inferiores</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_miembrosinferiores" Checked="false" runat="server" /> 
                                     <%--<asp:TextBox runat="server" ID="ckb_miembrosinferiores" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">c. Pupilas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_pupilas" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_pupilas" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">c. Faringe</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_faringe" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_faringe" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">b. Movilidad</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_movilidad" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_movilidad" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" RowSpan="2" style="background-color: #ccffff; font-size:15px">b. Desviación</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" RowSpan="2" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_desviacion" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_desviacion" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="4" style="background-color: #ccffff; font-size:15px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label91" runat="server" Text="13. Neurológico"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">a. Fuerza</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_fuerza" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_fuerza" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">d. Córnea</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_cornea" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_cornea" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">d. Amígdalas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_amigdalas" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_amigdalas" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell RowSpan="2" style="background-color: #ccffff; font-size:15px">
                                    <asp:Label CssClass="REI-COLUMN" ID="Label92" runat="server" Text="7. Tórax"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">a. Mamas</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_mamas" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_mamas" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">b. Sensibilidad</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_sensibilidad" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_sensibilidad" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">e. Motilidad</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_motilidad" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_motilidad" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">e. Dentadura</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_dentadura" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_dentadura" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">b. Corazón</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_corazon" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_corazon" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">c. Dolor</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_dolor" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_dolor" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">c. Marcha</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_marcha" Checked="false" runat="server" />
                                     <%--<asp:TextBox runat="server" ID="ckb_marcha" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="text-align: left; background-color: white; font-size:12px" ColumnSpan="12">SI EXISTE EVIDENCIA DE PATOLOGÍA MARCAR CON "X" Y DESCRIBIR EN LA SIGUIENTE SECCIÓN COLOCANDO EL NUMERAL</asp:TableCell>
                                <asp:TableCell CssClass="REI-CONTENT" style="background-color: #ccffff; font-size:15px">d. Reflejos</asp:TableCell>
                                <asp:TableCell CssClass="REI-BOX" style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_reflejos" Checked="false" runat="server" />
                                    <%--<asp:TextBox runat="server" ID="ckb_reflejos" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>--%>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="15" style="background-color: white">
                                    <asp:TextBox ID="txt_obervexamenfisicoregional" BorderStyle="None" Style="background-color: transparent; width: 100%;" runat="server" placeholder="Observaciones:" TextMode="MultiLine" Rows="5"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" Style="background-color: #cccdfe; font-size: 15px; font-weight:bold">
                        J. RESULTADOS DE EXÁMENES GENERALES Y ESPECÍFICOS DE ACUERDO AL RIESGO Y PUESTO DE TRABAJO (IMAGEN, LABORATORIO Y OTROS)
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="width: 400px; background-color: #cdfecc; font-size: 15px">EXAMEN </asp:TableCell>
                                <asp:TableCell Style="width: 150px; background-color: #cdfecc; font-size: 15px">FECHA</asp:TableCell>
                                <asp:TableCell Style="width: 800px; background-color: #cdfecc; font-size: 15px">RESULTADO</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_examen" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_fechaexamen" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_resultadoexamen" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_examen2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_fechaexamen2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_resultadoexamen2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="3" Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_observacionexamen" BorderStyle="None" Style="background-color: transparent; width: 100%;" placeholder="Observaciones:" TextMode="MultiLine" Rows="2"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" Style="background-color: #cccdfe; font-size: 15px; font-weight:bold">
                        K. DIAGNÓSTICO  
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="width: 950px; text-align: end; background-color: #cccdfe; font-size: 15px" ColumnSpan="2">PRE= PRESUNTIVO          DEF= DEFINITIVO</asp:TableCell>
                                <asp:TableCell Style="width: 200px; background-color: #cccdfe; font-size: 15px">CIE</asp:TableCell>
                                <asp:TableCell Style="width: 75px; background-color: #cccdfe; font-size: 15px">PRE</asp:TableCell>
                                <asp:TableCell Style="width: 75px; background-color: #cccdfe; font-size: 15px">DEF</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="width: 50px; background-color: #cdfecc; font-size: 15px" Text="1"></asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_descripdiagnostico" BorderStyle="None" Style="background-color: transparent; width: 100%;" placeholder="Descripción" OnTextChanged="txt_descripdiagnostico_TextChanged" AutoPostBack="true"></asp:TextBox>
                                    <ajaxToolkit:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" CompletionInterval="10" DelimiterCharacters="" Enabled="True"
                                        MinimumPrefixLength="1" ServiceMethod="ObtenerCie10"
                                        TargetControlID="txt_descripdiagnostico" CompletionListCssClass="CompletionList"
                                        CompletionListHighlightedItemCssClass="CompletionListHighlightedItem"
                                        CompletionListItemCssClass="CompletionListItem">                                        
                                    </ajaxToolkit:AutoCompleteExtender>
                                </asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_cie" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_pre" Checked="false" runat="server" />
                                    <%--<asp:TextBox runat="server" ID="ckb_pre" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_def" Checked="false" runat="server" />
                                    <%--<asp:TextBox runat="server" ID="ckb_def" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="width: 50px; background-color: #cdfecc; font-size: 15px" Text="2"></asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_descripdiagnostico2" BorderStyle="None" Style="background-color: transparent; width: 100%;" placeholder="Descripción"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_cie2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_pre2" Checked="false" runat="server" />
                                    <%--<asp:TextBox runat="server" ID="ckb_pre2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_def2" Checked="false" runat="server" />
                                    <%--<asp:TextBox runat="server" ID="ckb_def2" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="width: 50px; background-color: #cdfecc; font-size: 15px" Text="3"></asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_descripdiagnostico3" BorderStyle="None" Style="background-color: transparent; width: 100%;" placeholder="Descripción"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_cie3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_pre3" Checked="false" runat="server" />
                                    <%--<asp:TextBox runat="server" ID="ckb_pre3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell  Style="background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_def3" Checked="false" runat="server" />
                                    <%--<asp:TextBox runat="server" ID="ckb_def3" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" Style="background-color: #cccdfe; font-size: 15px; font-weight:bold">
                        L. APTITUD MÉDICA PARA EL TRABAJO  
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="width: 250px; background-color: #cdfecc; font-size: 15px">APTO</asp:TableCell>
                                <asp:TableCell Style="width: 50px; background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_apto" Checked="false" runat="server" />
                                    <%--<asp:TextBox runat="server" ID="ckb_apto" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 250px; background-color: #cdfecc; font-size: 15px">APTO EN OBSERVACIÓN</asp:TableCell>
                                <asp:TableCell Style="width: 50px; background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_aptoobservacion" Checked="false" runat="server" />
                                    <%--<asp:TextBox runat="server" ID="ckb_aptoobservacion" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 250px; background-color: #cdfecc; font-size: 15px">APTO CON LIMITACIONES</asp:TableCell>
                                <asp:TableCell Style="width: 50px; background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_aptolimitacion" Checked="false" runat="server" />
                                    <%--<asp:TextBox runat="server" ID="ckb_aptolimitacion" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 250px; background-color: #cdfecc; font-size: 15px">NO APTO</asp:TableCell>
                                <asp:TableCell Style="width: 50px; background-color: white; font-size: 14px">
                                    <asp:CheckBox ID="ckb_noapto" Checked="false" runat="server" />
                                    <%--<asp:TextBox runat="server" ID="ckb_noapto" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>--%>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #ccffff; font-size: 15px">Observación</asp:TableCell>
                                <asp:TableCell ColumnSpan="7" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_observacionaptitud" BorderStyle="None" Style="background-color: transparent; width: 100%"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: #ccffff; font-size: 15px">Limitación</asp:TableCell>
                                <asp:TableCell ColumnSpan="7" style="background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" ID="txt_limitacionaptitud" BorderStyle="None" Style="background-color: transparent; width: 100%"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" Style="background-color: #cccdfe; font-size: 15px; font-weight:bold">
                        M. RECOMENDACIONES Y/O TRATAMIENTO
                    </div>
                    <div class="list-group list-group-flush" Style="background-color: white; font-size: 14px">
                        <asp:TextBox ID="txt_descripciontratamientoperiodica" BorderStyle="None" Style="background-color: transparent; width: 100%;" runat="server" placeholder="Descripción" TextMode="MultiLine" Rows="3"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="container">
                    <p align="center">
                        <strong>"CERTIFICO QUE LO ANTERIORMENTE EXPRESADO EN RELACIÓN A MI ESTADO DE SALUD ES VERDAD. SE ME HA INFORMADO LAS MEDIDAS PREVENTIVAS 
                                           A TOMAR PARA DISMINUIR O MITIGAR LOS RIESGOS RELACIONADOS CON MI ACTIVIDAD LABORAL."</strong>
                    </p>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header" Style="background-color: #cccdfe; font-size: 15px; font-weight:bold">
                        N. DATOS DEL PROFESIONAL DE SALUD
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:Table class="table table-bordered table-light table-responsive text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Style="width: 100px; background-color: #cdfecc; font-size: 15px">FECHA Y HORA</asp:TableCell>
                                <asp:TableCell Style="width: 150px; background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" BorderStyle="None" ID="txt_fechahora" TextMode="DateTimeLocal" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 100px; background-color: #cdfecc; font-size: 15px">NOMBRES Y APELLIDOS</asp:TableCell>
                                <asp:TableCell Style="width: 300px; background-color: white; font-size: 14px">
                                    <asp:DropDownList ID="ddl_profesional" CssClass="form-check" Style="width: 100%; border: none; background-color: transparent" runat="server"></asp:DropDownList>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 75px; background-color: #cdfecc; font-size: 15px">CÓDIGO</asp:TableCell>
                                <asp:TableCell Style="width: 125px; background-color: white; font-size: 14px">
                                    <asp:TextBox runat="server" BorderStyle="None" ID="txt_codigoDatProf" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 100px; background-color: #cdfecc; font-size: 15px">FIRMA Y SELLO</asp:TableCell>
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
                        <div class="card-header" style="background-color: #cccdfe; font-size: 15px; font-weight:bold">
                            O. FIRMA DEL USUARIO    
                        </div>
                        <div class="list-group list-group-flush">
                            <asp:Label ID="Label24" runat="server" Text="" Style="height: 80px"></asp:Label>
                        </div>
                    </div>
                </div>
                <br />
                <div class="container" align="center">
                    <asp:Button CssClass="btn btn-warning" ID="btn_guardar" runat="server" Text="Guardar" OnClick="btn_guardar_Click" UseSubmitBehavior="False" />
                    <asp:Button CssClass="btn btn-danger" ID="btn_cancelar" runat="server" Text="Cancelar" OnClick="btn_cancelar_Click" UseSubmitBehavior="False" />
                </div>
                <br />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
