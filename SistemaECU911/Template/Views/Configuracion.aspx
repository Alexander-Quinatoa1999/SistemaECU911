﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Views/Principal.Master" AutoEventWireup="true" CodeBehind="Configuracion.aspx.cs" Inherits="SistemaECU911.Template.Views.Configuracion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
    Configuración Usuario | Sistema Médico
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Message" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:Timer ID="Timer1" runat="server" Interval="2000" OnTick="Timer1_Tick"></asp:Timer>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Content" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="container" style="background-color: white; font-family: Arial; padding: 30px">
                <br />
                <h3 class="text-center cm-strong">INFORMACIÓN DEL USUARIO</h3>
                <br />
                <div class="row">
                    <div align="center">
                        <img src="../Template Principal/images/User.png" alt="logo" style="width: 150px; height: 150px" />
                    </div>
                </div>
                <br />
                <div class="row">
                    <div align="center">
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </div>
                </div>
                <br />
                <br />
                <div class="row">
                    <div class="col-md-3">
                        <label for="txt_priNombre" class="form-label">Primer Nombre</label>
                        <asp:TextBox class="form-control" ID="txt_priNombre" runat="server" ReadOnly="true"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <label for="txt_segNombre" class="form-label">Segundo Nombre</label>
                        <asp:TextBox class="form-control" ID="txt_segNombre" runat="server" ReadOnly="true"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <label for="txt_priApellido" class="form-label">Primer Apellido</label>
                        <asp:TextBox class="form-control" ID="txt_priApellido" runat="server" ReadOnly="true"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <label for="txt_segApellido" class="form-label">Segundo Apellido</label>
                        <asp:TextBox class="form-control" ID="txt_segApellido" runat="server" ReadOnly="true"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-md-5">
                        <label for="txt_correo" class="form-label">Correo</label>
                        <asp:TextBox class="form-control" ID="txt_correo" Style="font-family: Arial; font-size: 15px; text-align: center" TextMode="Email" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <label for="txt_telefono" class="form-label">Telefono</label>
                        <asp:TextBox class="form-control" ID="txt_telefono" Style="font-family: Arial; font-size: 15px; text-align: center" TextMode="Phone" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-4">
                        <label for="txt_direccion" class="form-label">Dirección</label>
                        <asp:TextBox class="form-control" ID="txt_direccion" Style="font-family: Arial; font-size: 15px; text-align: center; text-transform: uppercase" TextMode="MultiLine" Rows="2" runat="server"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row align-items-center">
                    <center>
                        <div class="col-md-5">
                            <div class="mb-0 text-center">
                                <asp:Button ID="btn_actualizar" OnClick="btn_actualizar_Click" CssClass="btn btn-primary btn-lg btn-block" ValidationGroup="Actualizar" runat="server" Text="Actualizar" UseSubmitBehavior="False" />
                            </div>
                        </div>
                    </center>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
