<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Views/Principal.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="SistemaECU911.Template.Views.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 1474px;
        }

        .auto-style2 {
            width: 101%;
        }
    </style>
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
    <%--<asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>--%>
            <div class="row" style="font-family: Arial">
                <div class="col-12 grid-margin">
                    <div class="card">
                        <div class="card-body">
                            <h4 class="card-title">Certificado Médico</h4>
                            <div id="example-vertical-wizard">
                                <div>
                                    <h3>Datos Paciente</h3>
                                    <section>
                                        <div class="row">
                                            <div class="col-md-4">
                                                <label>Numero de Cedula</label>
                                                <asp:TextBox CssClass="required form-control" ID="txt_cedula" OnTextChanged="txt_cedula_TextChanged" AutoPostBack="true" runat="server"></asp:TextBox>
                                                <ajaxToolkit:AutoCompleteExtender ID="AutoCompleteExtender" runat="server" CompletionInterval="10" DelimiterCharacters="" Enabled="True"
                                                    MinimumPrefixLength="1" ServiceMethod="ObtenerNumHClinica"
                                                    TargetControlID="txt_cedula" CompletionListCssClass="CompletionList"
                                                    CompletionListHighlightedItemCssClass="CompletionListHighlightedItem"
                                                    CompletionListItemCssClass="CompletionListItem">
                                                </ajaxToolkit:AutoCompleteExtender>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6">
                                                <label>Primer Nombre</label>
                                                <asp:TextBox CssClass="required form-control" ID="txt_priNombre" runat="server"></asp:TextBox>
                                            </div>
                                            <div class="col-md-6">
                                                <label>Segundo Nombre</label>
                                                <asp:TextBox CssClass="required form-control" ID="txt_segNombre" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6">
                                                <label>Primer Apellido</label>
                                                <asp:TextBox CssClass="required form-control" ID="txt_priApellido" runat="server"></asp:TextBox>
                                            </div>
                                            <div class="col-md-6">
                                                <label>Segundo Apellido</label>
                                                <asp:TextBox CssClass="required form-control" ID="txt_segApellido" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6">
                                                <label>Cargo</label>
                                                <asp:TextBox CssClass="required form-control" ID="txt_Cargo" runat="server"></asp:TextBox>
                                            </div>
                                            <div class="col-md-6">
                                                <label>Institución</label>
                                                <asp:TextBox CssClass="required form-control" ID="txt_Institución" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6">
                                                <label>Domicilio</label>
                                                <asp:TextBox CssClass="required form-control" ID="txt_Domicilio" runat="server"></asp:TextBox>
                                            </div>
                                            <div class="col-md-6">
                                                <label>Telefono</label>
                                                <asp:TextBox CssClass="required form-control" ID="txt_Telefono" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                    </section>
                                    <h3>Datos Medicos</h3>
                                    <section>
                                        <div class="form-group">
                                            <label>Razon de la antencion</label>
                                            <asp:TextBox CssClass="required form-control" ID="txt_Atencion" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <label>Tipo de Contingencia</label>
                                            <asp:DropDownList CssClass="required form-control" ID="ddl_tipoContingencia" runat="server">
                                                <asp:ListItem Value="1">Enfermedad General</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        <div class="form-group">
                                            <label>Diagnóstico</label>
                                            <asp:TextBox CssClass="required form-control" ID="txt_diagnostico" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <label>Recomendaciones</label>
                                            <asp:TextBox CssClass="required form-control" ID="txt_recomendacion" TextMode="MultiLine" Rows="5" runat="server"></asp:TextBox>
                                        </div>
                                    </section>
                                </div>
                            </div>
                            <asp:Button ID="btnCertificado" OnClick="btnCertificado_Click" CssClass="btn btn-info" runat="server" Text="Generar Certificado" />
                        </div>
                    </div>
                </div>
            </div>
        <%--</ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="btnCertificado"/>
        </Triggers>
    </asp:UpdatePanel>--%>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
