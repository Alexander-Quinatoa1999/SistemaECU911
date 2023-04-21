﻿<%@ Page Title="" Language="C#" MasterPageFile="~/views/Doctores/Medico.Master" AutoEventWireup="true" CodeBehind="RegistrosFichaMedica.aspx.cs" Inherits="SistemaECU911.views.Doctores.RegistrosFichaMedica" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
    Pacientes Ficha Médica | Sistema Médico
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Message" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Content" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <br />
            <div class="container">
                <div class="card text-center">
                    <div class="card-header">
                        LISTADO DE PACIENTES FICHA MEDICA
                    </div>
                </div>
            </div>
            <hr />
            <div class="card" style="width: auto;">
                <div class="list-group list-group-flush" style="padding: 10px; text-align: center">
                    <div class="container">
                        <div class="row justify-content-center">
                            <div class="col-auto">

                                <asp:GridView ID="grvPacientes" OnRowCommand="grvPacientes_RowCommand" AutoGenerateColumns="false" Width="100%" CssClass="table table-hover text-center table-responsive" GridLines="None" runat="server" Style="margin-right: 0px">
                                    <Columns>
                                        <asp:TemplateField HeaderText="HISTORIA CLINICA">
                                            <ItemTemplate>
                                                <asp:Label ID="Per_CedulaHisCli" runat="server" Text='<%#Eval("Per_Cedula")%>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="NOMBRE">
                                            <ItemTemplate>
                                                <asp:Label ID="Per_Nombre" runat="server" Text='<%#Eval("Per_priNombre")%>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="APELLIDO">
                                            <ItemTemplate>
                                                <asp:Label ID="Per_priApellido" runat="server" Text='<%#Eval("Per_priApellido")%>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="PROFESIONAL">
                                            <ItemTemplate>
                                                <asp:Label ID="prof_NomApe" runat="server" Text='<%#Eval("prof_NomApe")%>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="FECHA GUARDADO">
                                            <ItemTemplate>
                                                <asp:Label ID="fechaHoraGuardado" runat="server" Text='<%#Eval("fechaHoraGuardado")%>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="FECHA MODIFICACION">
                                            <ItemTemplate>
                                                <asp:Label ID="fechaHoraModificacion" runat="server" Text='<%#Eval("fechaHoraModificacion")%>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField ItemStyle-Width="17" HeaderStyle-Width="17" HeaderText="">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lnbEditar" Width="16" Height="16" CommandArgument='<%#Eval("idFichaMedica")%>' CommandName="Editar" runat="server"><i class="fas fa-pen"></i></asp:LinkButton>
                                            </ItemTemplate>
                                            <HeaderStyle Width="17px" />
                                            <ItemStyle Width="17px" />
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <br>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="Footer" runat="server">
    <script>
        $('document').ready(function () {
            $('#<%=grvPacientes.ClientID%>').prepend($("<thead></thead>").append($(this).find("tr:first"))).DataTable({
                //scrollCollapse: true,
                //autoWidth: false,
                //responsive: true,
                //columnDefs: [{
                //targets: "datatable-nosort",
                //orderable: false,
                //}],
                //"lengthMenu": [[10, 25, 50, -1], [10, 25, 50, "Todos"]],
                //"language": {
                //"info": "Mostrando _START_-_END_ de _TOTAL_ Registros",
                //"zeroRecords": "No se encontró nada - lo siento",
                //"lengthMenu": "Mostrar _MENU_ Registros por página",
                //"emptyTable": "No hay datos disponibles en la tabla",
                //"search": "Buscar:",
                //searchPlaceholder: "Buscar",
                //paginate: {
                //next: '<i class="ion-chevron-right"></i>',
                //previous: '<i class="ion-chevron-left"></i>'
                //}
                //},
            });
        });
    </script>
</asp:Content>
