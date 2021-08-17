<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Views/Principal.Master" AutoEventWireup="true" CodeBehind="Pacientes.aspx.cs" Inherits="SistemaECU911.Template.Views.Pacientes" %>

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
                        <div class="card-header">
                            LISTADO DE PACIENTES
                        </div>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="list-group list-group-flush" style="padding: 10px; text-align: center">
                        <div class="container">
                            <div class="row">
                                <div class="col">
                                    <asp:GridView ID="grvPacientes" AutoGenerateColumns="false" Width="100%" CssClass="table table-bordered table-light text-center" GridLines="None" runat="server">
                                        <Columns>
                                            <asp:TemplateField HeaderText="Codigo">
                                                <ItemTemplate>
                                                    <asp:Label ID="Per_id" runat="server" Text='<%#Eval("Per_id")%>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Primer Nombre">
                                                <ItemTemplate>
                                                    <asp:Label ID="Per_priNombre" runat="server" Text='<%#Eval("Per_priNombre")%>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Segundo Nombre">
                                                <ItemTemplate>
                                                    <asp:Label ID="Per_segNombre" runat="server" Text='<%#Eval("Per_segNombre")%>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Sexo">
                                                <ItemTemplate>
                                                    <asp:Label ID="Per_sexo" runat="server" Text='<%#Eval("Per_sexo")%>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Edad">
                                                <ItemTemplate>
                                                    <asp:Label ID="Per_edad" runat="server" Text='<%#Eval("Per_edad")%>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Grupo Sanguineo">
                                                <ItemTemplate>
                                                    <asp:Label ID="Per_groSanguineo" runat="server" Text='<%#Eval("Per_groSanguineo")%>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Cargo">
                                                <ItemTemplate>
                                                    <asp:Label ID="Per_Cargo" runat="server" Text='<%#Eval("Per_Cargo")%>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Numero de Archivo">
                                                <ItemTemplate>
                                                    <asp:Label ID="Per_NumArchivo" runat="server" Text='<%#Eval("Per_NumArchivo")%>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Historia Clinica / Cedula">
                                                <ItemTemplate>
                                                    <asp:Label ID="Per_CedulaHisCli" runat="server" Text='<%#Eval("Per_CedulaHisCli")%>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Estado">
                                                <ItemTemplate>
                                                    <asp:Label ID="Per_estado" runat="server" Text='<%#Eval("Per_estado")%>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <br />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
