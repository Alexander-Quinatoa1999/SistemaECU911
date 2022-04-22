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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="row" style="font-family:Arial">
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
                                                <asp:TextBox CssClass="required form-control" ID="txt_cedula" runat="server"></asp:TextBox>
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
                                            <div class="col-md-10">
                                                <label>Cargo</label>
                                                <asp:TextBox CssClass="required form-control" ID="TextBox1" runat="server"></asp:TextBox>
                                            </div>
                                            <div class="col-md-10">
                                                <label>Institución</label>
                                                <asp:TextBox CssClass="required form-control" ID="TextBox2" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                    </section>
                                    <h3>Datos Medicos</h3>
                                    <section>
                                        <div class="form-group">
                                            <label>Tipo de Contingencia</label>
                                            <asp:DropDownList CssClass="required form-control" ID="ddl_tipoContingencia" runat="server"></asp:DropDownList>
                                        </div>
                                        <div class="form-group">
                                            <label>Diagnóstico</label>
                                            <asp:TextBox CssClass="required form-control" ID="txt_diagnostico" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <label>Recomendaciones</label>
                                            <asp:TextBox CssClass="required form-control" ID="txt_recomendacion" TextMode="MultiLine" Rows="5" runat="server"></asp:TextBox>
                                    </section>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
