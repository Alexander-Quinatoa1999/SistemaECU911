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
            <div class="row">
                <div class="col-12 grid-margin">
                    <div class="card">
                        <div class="card-body">
                            <h4 class="card-title">Ficha Medica</h4>
                            <div id="example-vertical-wizard">
                                <div>
                                    <h3>Motivo de Consulta</h3>
                                    <section>
                                        <div class="form-group">
                                            <label>Motivo de Consulta</label>
                                            <asp:TextBox CssClass="required form-control" ID="txt_motconsulta" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <label>Motivo de Consulta (segun acompañante)</label>
                                            <asp:TextBox CssClass="required form-control" ID="txt_motconsultaAcom" runat="server"></asp:TextBox>
                                        </div>
                                    </section>
                                    <h3>Antecedentes Personales</h3>
                                    <section>
                                        <div class="form-group">
                                            <label>Tipo de Antecedente</label>
                                            <asp:DropDownList CssClass="required form-control" ID="ddl_tipoAntePer" runat="server"></asp:DropDownList>
                                        </div>
                                        <div class="form-group">
                                            <label>Antecedente</label>
                                            <asp:TextBox CssClass="required form-control" ID="txt_antePersonales" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <label>Descripción</label>
                                            <asp:TextBox CssClass="required form-control" ID="txt_antePersonalesDescrip" runat="server"></asp:TextBox>
                                        </div>
                                    </section>
                                    <h3>Antecedentes Familiares</h3>
                                    <section>
                                        <div class="form-group">
                                            <label>Tipo de Antecedente</label>
                                            <asp:DropDownList CssClass="required form-control" ID="ddl_tipoAnteFami" runat="server"></asp:DropDownList>
                                        </div>
                                        <div class="form-group">
                                            <label>Antecedente</label>
                                            <asp:TextBox CssClass="required form-control" ID="txt_anteFamiliares" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <label>Descripción</label>
                                            <asp:TextBox CssClass="required form-control" ID="txt_anteFamiliaresDescrip" runat="server"></asp:TextBox>
                                        </div>
                                    </section>
                                    <h3>Enfermedad Actual</h3>
                                    <section>
                                        <div class="form-group">
                                            <label>Descripción</label>
                                            <asp:TextBox CssClass="required form-control" ID="txt_enferActual" Rows="3" TextMode="MultiLine" runat="server"></asp:TextBox>
                                        </div>
                                    </section>
                                    <h3>Revisión de organos y sistemas</h3>
                                    <section>
                                        <div class="form-group">
                                            <label>Organos y Sistemas</label>
                                            <asp:DropDownList CssClass="required form-control" ID="ddl_organosSistemas" runat="server"></asp:DropDownList>
                                        </div>
                                        <div class="form-group">
                                            <label>Evidencia Patológica</label>
                                            <asp:DropDownList CssClass="required form-control" ID="ddl_eviPatoligica" runat="server"></asp:DropDownList>
                                        </div>
                                        <div class="form-group">
                                            <label>Descripción</label>
                                            <asp:TextBox CssClass="required form-control" ID="txt_reviOrgSisteDescrip" runat="server"></asp:TextBox>
                                        </div>
                                    </section>
                                    <h3>Signos vitales y antropométricos</h3>
                                    <section class="auto-style1">
                                        <div class="form-group">
                                            <table class="table-bordered table-responsive" style="width:100%">
                                                <tr>
                                                    <td style="width: 1100px">Presión Arterial</td>
                                                    <td style="width: 100px; text-align:center">
                                                        <asp:CheckBox ID="cb_presArterial" runat="server" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Temperatura</td>
                                                    <td style="text-align:center">
                                                        <asp:CheckBox ID="cb_temperatura" runat="server" />                                                        
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Frecuencia Cardiaca</td>
                                                    <td style="text-align:center">
                                                        <asp:CheckBox ID="cb_frecCardiaca" runat="server" />                                                        
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Saturación de Oxígeno</td>
                                                    <td style="text-align:center">
                                                        <asp:CheckBox ID="cb_satOxigeno" runat="server" />                                                        
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Frecuencia Respiratoria</td>
                                                    <td style="text-align:center">
                                                        <asp:CheckBox ID="cb_frecRespiratoria" runat="server" />                                                        
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Peso</td>
                                                    <td style="text-align:center">
                                                        <asp:CheckBox ID="cb_peso" runat="server" />                                                        
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Talla</td>
                                                    <td style="text-align:center">
                                                        <asp:CheckBox ID="cb_talla" runat="server" />                                                        
                                                </tr>
                                                <tr>
                                                    <td>Indice de Masa Corporal</td>
                                                    <td style="text-align:center">
                                                        <asp:CheckBox ID="cb_indMasCorporal" runat="server" />                                                                                                                
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Perímetro Abdominal</td>
                                                    <td style="text-align:center">
                                                        <asp:CheckBox ID="cb_perAbdominal" runat="server" />                                                        
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                    </section>
                                    <h3>Examen Físico</h3>
                                    <section>
                                        <div class="form-group">
                                            <label>Examen / Región Anatómica</label>
                                            <asp:DropDownList CssClass="required form-control" ID="ddl_region" runat="server"></asp:DropDownList>
                                        </div>
                                        <div class="form-group">
                                            <label>Examen / Región Anatómica</label>
                                            <asp:DropDownList CssClass="required form-control" ID="ddl_tipoRegion" runat="server"></asp:DropDownList>
                                        </div> 
                                        <div class="form-group">
                                            <label>Descripción</label>
                                            <asp:TextBox CssClass="required form-control" ID="txt_exafisdescripcion" runat="server"></asp:TextBox>
                                        </div>                                       
                                    </section>
                                    <h3>Diagnóstico</h3>
                                    <section>
                                        <div class="form-group">
                                            <label>Diagnósticos</label>
                                            <asp:TextBox CssClass="required form-control" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <label>Código</label>
                                            <asp:TextBox CssClass="required form-control" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <label>Tipo</label>
                                            <asp:TextBox CssClass="required form-control" runat="server"></asp:TextBox>
                                        </div> 
                                        <div class="form-group">
                                            <label>Condición</label>
                                            <asp:TextBox CssClass="required form-control" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <label>Cronolodia</label>
                                            <asp:TextBox CssClass="required form-control" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <label>Descripción</label>
                                            <asp:TextBox CssClass="required form-control" runat="server"></asp:TextBox>
                                        </div>                                        
                                    </section>
                                    <h3>Plan de Tratamiento</h3>
                                    <section>                                        
                                        <div class="form-group">
                                            <label>Descripción</label>
                                            <asp:TextBox CssClass="required form-control" ID="txt_tratamiento" Rows="3" TextMode="MultiLine" runat="server"></asp:TextBox>
                                        </div>
                                    </section>
                                    <h3>Evolución</h3>
                                    <section>                                        
                                        <div class="form-group">
                                            <label>Descripción</label>
                                            <asp:TextBox CssClass="required form-control" ID="txt_evolucion" Rows="3" TextMode="MultiLine" runat="server"></asp:TextBox>
                                        </div>
                                    </section>
                                    <h3>Prescripciones</h3>
                                    <section>                                        
                                        <div class="form-group">
                                            <label>Descripción</label>
                                            <asp:TextBox CssClass="required form-control" ID="txt_prescipciones" Rows="3" TextMode="MultiLine" runat="server"></asp:TextBox>
                                        </div>
                                    </section>
                                    <h3>Datos del Profesional</h3>
                                    <section>                                        
                                        <div class="form-group">
                                            <label>Fecha y Hora</label>
                                            <asp:TextBox CssClass="required form-control" ID="txt_fecha" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <label>Especialidad</label>
                                            <asp:DropDownList CssClass="required form-control" ID="ddl_especialidad" runat="server"></asp:DropDownList>
                                        </div>
                                        <div class="form-group">
                                            <label>Nombre del Profesional</label>
                                            <asp:DropDownList CssClass="required form-control" ID="ddl_profesional" runat="server"></asp:DropDownList>
                                        </div>
                                        <div class="form-group">
                                            <label>Código</label>
                                            <asp:TextBox CssClass="required form-control" ID="txt_codigo" runat="server"></asp:TextBox>
                                        </div>
                                    </section>                                    
                                </div>                                                             
                            </div>
                            <div style="text-align:center">
                                    <asp:Button CssClass="btn btn-primary" ID="Button1" runat="server" Text="Enviar" />
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
