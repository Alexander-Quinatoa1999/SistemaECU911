<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Views/Principal.Master" AutoEventWireup="true" CodeBehind="Personas.aspx.cs" Inherits="SistemaECU911.Template.Views.Personas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="container" style="background-color: white">
                <br />
                <div class="row">
                    <div class="col-md-6">
                        <label class="form-label">PRIMER NOMBRE</label>
                        <asp:TextBox class="form-control" runat="server" ID="txt_priNombre" Style="width: 100%; background-color: transparent; text-transform: uppercase"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfv_numHClinica" runat="server" ForeColor="Red" ControlToValidate="txt_priNombre" ErrorMessage="CAMPO OBLIGATORIO"></asp:RequiredFieldValidator>
                    </div>
                    <div class="col-md-6">
                        <label class="form-label">SEGUNDO NOMBRE</label>
                        <asp:TextBox class="form-control" runat="server" ID="txt_segNombre" Style="width: 100%; background-color: transparent; text-transform: uppercase"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ForeColor="Red" ControlToValidate="txt_segNombre" ErrorMessage="CAMPO OBLIGATORIO"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <label class="form-label">PRIMER APELLIDO</label>
                        <asp:TextBox class="form-control" runat="server" ID="txt_priApellido" Style="width: 100%; background-color: transparent; text-transform: uppercase"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ForeColor="Red" ControlToValidate="txt_priApellido" ErrorMessage="CAMPO OBLIGATORIO"></asp:RequiredFieldValidator>
                    </div>
                    <div class="col-md-6">
                        <label class="form-label">SEGUNDO APELLIDO</label>
                        <asp:TextBox class="form-control" runat="server" ID="txt_segApellido" Style="width: 100%; background-color: transparent; text-transform: uppercase"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ForeColor="Red" ControlToValidate="txt_segApellido" ErrorMessage="CAMPO OBLIGATORIO"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-2">
                        <label class="form-label">CEDULA</label>
                        <asp:TextBox class="form-control" runat="server" ID="txt_cedula" Style="width: 100%; background-color: transparent; text-transform: uppercase"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ForeColor="Red" ControlToValidate="txt_cedula" ErrorMessage="CAMPO OBLIGATORIO"></asp:RequiredFieldValidator>
                    </div>                    
                    <div class="col-md-4">
                        <label class="form-label">FECHA DE NACIMIENTO</label>
                        <asp:TextBox class="form-control" runat="server" ID="txt_fechaNacimiento" Style="width: 100%; background-color: transparent; text-transform: uppercase" TextMode="Date"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ForeColor="Red" ControlToValidate="txt_fechaNacimiento" ErrorMessage="CAMPO OBLIGATORIO"></asp:RequiredFieldValidator>
                    </div>
                    <div class="col-md-2">
                        <label class="form-label">GÉNERO</label>
                        <asp:DropDownList ID="ddl_genero" CssClass="form-control" Style="width: 100%; text-transform: uppercase; background-color: transparent; font-size: 14px" runat="server">
                            <asp:ListItem Value="0" Text="Seleccione...."></asp:ListItem>
                            <asp:ListItem Text="M"></asp:ListItem>
                            <asp:ListItem Text="F"></asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ForeColor="Red" InitialValue="0" ControlToValidate="ddl_genero" ErrorMessage="CAMPO OBLIGATORIO"></asp:RequiredFieldValidator>
                    </div>
                    <div class="col-md-4">
                        <label class="form-label">ZONAL</label>
                        <asp:DropDownList ID="ddl_zonal" CssClass="form-control" Style="width: 100%; text-transform: uppercase; background-color: transparent; font-size: 14px" runat="server"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ForeColor="Red" InitialValue="0" ControlToValidate="ddl_zonal" ErrorMessage="CAMPO OBLIGATORIO"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-3">
                        <label class="form-label">FECHA DE INGRESO AL TRABAJO</label>
                        <asp:TextBox class="form-control" runat="server" ID="txt_fechaIngresoTrabajo" Style="width: 100%; background-color: transparent; text-transform: uppercase" TextMode="Date"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ForeColor="Red" ControlToValidate="txt_fechaIngresoTrabajo" ErrorMessage="CAMPO OBLIGATORIO"></asp:RequiredFieldValidator>
                    </div>
                    <div class="col-md-9">
                        <label class="form-label">PUESTO DE TRABAJO</label>
                        <asp:TextBox class="form-control" runat="server" ID="txt_puestoTrabajo" Style="width: 100%; background-color: transparent; text-transform: uppercase" TextMode="MultiLine" Rows="2"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ForeColor="Red" ControlToValidate="txt_puestoTrabajo" ErrorMessage="CAMPO OBLIGATORIO"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-7">
                        <label class="form-label">CARGO OCUPACIONAL</label>
                        <asp:TextBox class="form-control" runat="server" ID="txt_cargo" Style="width: 100%; background-color: transparent; text-transform: uppercase" TextMode="MultiLine" Rows="2"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ForeColor="Red" ControlToValidate="txt_cargo" ErrorMessage="CAMPO OBLIGATORIO"></asp:RequiredFieldValidator>
                    </div>    
                    <div class="col-md-3">
                        <label class="form-label">AREA DE TRABAJO</label>
                        <asp:TextBox class="form-control" runat="server" ID="txt_area" Style="width: 100%; background-color: transparent; text-transform: uppercase" TextMode="MultiLine" Rows="2"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ForeColor="Red" ControlToValidate="txt_area" ErrorMessage="CAMPO OBLIGATORIO"></asp:RequiredFieldValidator>
                    </div>                    
                    <div class="col-md-2">
                        <label class="form-label">ESTADO</label>
                        <asp:DropDownList ID="ddl_estado" CssClass="form-control" Style="width: 100%; text-transform: uppercase; background-color: transparent; font-size: 14px" runat="server">
                            <asp:ListItem Value="0" Text="SELECCIONE ......"></asp:ListItem>
                            <asp:ListItem Value="A" Text="ACTIVO"></asp:ListItem>
                            <asp:ListItem Value="I" Text="INACTIVO"></asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ForeColor="Red" InitialValue="0" ControlToValidate="ddl_estado" ErrorMessage="CAMPO OBLIGATORIO"></asp:RequiredFieldValidator>
                    </div>
                </div>                <br />
                <div class="col-12" style="text-align: center">
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
