<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Views/Principal.Master" AutoEventWireup="true" CodeBehind="Personas.aspx.cs" Inherits="SistemaECU911.Template.Views.Personas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="container" style="background-color: white">
                <br />
                <div class="col-12">
                    <label class="form-label">Primer Nombre</label>
                    <input type="text" class="form-control">
                </div>
                <div class="col-12">
                    <label class="form-label">Segundo Nombre</label>
                    <input type="text" class="form-control">
                </div>
                <div class="col-12">
                    <label class="form-label">Primer Apellido</label>
                    <input type="text" class="form-control">
                </div>
                <div class="col-12">
                    <label class="form-label">Segundo Apellido</label>
                    <input type="text" class="form-control">
                </div>
                <div class="col-12">
                    <label class="form-label">Género</label>
                    <input type="text" class="form-control">
                </div>
                <div class="col-12">
                    <label class="form-label">Puesto de Trabajo</label>
                    <input type="text" class="form-control">
                </div>
                <div class="col-12">
                    <label class="form-label">Fecha de Ingreso al Trabajo</label>
                    <input type="text" class="form-control">
                </div>
                <div class="col-12">
                    <label class="form-label">Cargo Ocupacional</label>
                    <input type="text" class="form-control">
                </div>
                <br />
                <div class="col-12">
                    <asp:Button CssClass="btn btn-warning" ID="btn_guardar" runat="server" Text="Guardar" UseSubmitBehavior="False" />
                    <asp:Button CssClass="btn btn-danger" ID="btn_cancelar" runat="server" Text="Cancelar" UseSubmitBehavior="False" />
                </div>
                <br />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
