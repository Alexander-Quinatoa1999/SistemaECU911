<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Views/Principal.Master" AutoEventWireup="true" CodeBehind="Historial.aspx.cs" Inherits="SistemaECU911.Template.Views.Historial" %>

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
                            FICHA MÉDICA
                        </div>
                    </div>
                </div>
                <hr />
                <div align="center">
                    <img src="../Template Principal/images/Foto_Perfil.png" alt="logo" style="width: 80px; height: 80px" />
                </div>
                <hr />
                <div class="card" style="width: auto;">
                    <div class="list-group list-group-flush" style="padding: 10px; text-align: center">
                        <div class="container">
                            <asp:Table class="table table-bordered table-light text-center" runat="server" align="left">
                                <asp:TableRow Style="text-align: center">
                                    <asp:TableCell Text="ESTABLECIMIENTO DE SALUD" Style="width: 250px"></asp:TableCell>
                                    <asp:TableCell Text="PRIMER NOMBRE" Style="width: 125px"></asp:TableCell>
                                    <asp:TableCell Text="SEGUNDO NOMBRE" Style="width: 125px"></asp:TableCell>
                                    <asp:TableCell Text="PRIMER APELLIDO" Style="width: 125px"></asp:TableCell>
                                    <asp:TableCell Text="SEGUNDO APELLIDO" Style="width: 125px"></asp:TableCell>
                                    <asp:TableCell Text="SEXO" Style="width: 50px"></asp:TableCell>
                                    <asp:TableCell Text="EDAD" Style="width: 50px"></asp:TableCell>
                                    <asp:TableCell Text="N° HISTORIA CLÍNICA" Style="width: 125px"></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell Style="background-color: white">
                                        <asp:TextBox runat="server" ID="txt_nomEmpresa" BorderStyle="None" Style="width: 100%; text-align: center" Text="Servicio integrado de seguridad" ReadOnly="True"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell Style="background-color: white">
                                        <asp:TextBox runat="server" ID="txt_priNombre" BorderStyle="None" Style="width: 100%; text-align: center" ReadOnly="True"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell Style="background-color: white">
                                        <asp:TextBox runat="server" ID="txt_segNombre" BorderStyle="None" Style="width: 100%; text-align: center" ReadOnly="True"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell Style="background-color: white">
                                        <asp:TextBox runat="server" ID="txt_priApellido" BorderStyle="None" Style="width: 100%; text-align: center" ReadOnly="True"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell Style="background-color: white">
                                        <asp:TextBox runat="server" ID="txt_segApellido" BorderStyle="None" Style="width: 100%; text-align: center" ReadOnly="True"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell Style="background-color: white">
                                        <asp:TextBox runat="server" ID="txt_sexo" BorderStyle="None" Style="width: 100%; text-align: center" ReadOnly="True"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell Style="background-color: white">
                                        <asp:TextBox runat="server" ID="txt_edad" BorderStyle="None" Style="width: 100%; text-align: center" ReadOnly="True"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell Style="background-color: white">
                                        <asp:TextBox runat="server" ID="txt_numHClinica" OnTextChanged="txt_numHClinica_TextChanged" BorderStyle="None" Style="width: 100%; text-align: center" required="true" AutoPostBack="true"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </div>
                    </div>
                </div>
                <br />
                <div class="card card-responsive" style="width: auto;">
                    <div class="card-header">
                        1. MOTIVO DE CONSULTA
                    </div>
                    <div class="list-group list-group-flush" style="padding: 10px; text-align: center">
                        <asp:Table class="table table-bordered table-light text-center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="MOTIVO DE CONSULTA" Style="width: 1100px"></asp:TableCell>
                                <asp:TableCell Text="MOTIVO DE CONSULTA (según acompañante)" Style="width: 200px"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_moConsulta" BorderStyle="None" Style="width: 100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" BorderStyle="None" style="width:100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card card-responsive" style="width: auto;">
                    <div class="card-header">
                        2. ANTECEDENTES PERSONALES
                    </div>
                    <div class="list-group list-group-flush" style="padding: 10px; text-align: center">
                        <asp:Table class="table table-bordered table-light text-center" runat="server">
                            <asp:TableRow Style="text-align: center">
                                <asp:TableCell Text="TIPO DE ANTECEDENTE" Style="width: 400px"></asp:TableCell>
                                <asp:TableCell Text="ANTECEDENTE" Style="width: 700px"></asp:TableCell>
                                <asp:TableCell Text="DESCRIPCIÓN" Style="width: 200px"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white">
                                    <asp:DropDownList ID="ddl_tipoAntPer" CssClass="form-check" Style="width: 100%; border: none" runat="server"></asp:DropDownList>
                                    <%--<asp:RequiredFieldValidator ErrorMessage="Required" ControlToValidate="ddl_tipoAntPer" InitialValue="0" runat="server"/>--%>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_antePersonales" BorderStyle="None" Style="width: 100%" TextMode="MultiLine" Rows="4"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_antePerDescripcion" BorderStyle="None" Style="width: 100%" TextMode="MultiLine" Rows="4"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card card-responsive" style="width: auto;">
                    <div class="card-header">
                        3. ANTECEDENTES FAMILIARES
                    </div>
                    <div class="list-group list-group-flush" style="padding: 10px; text-align: center">
                        <asp:Table class="table table-bordered table-light text-center" runat="server">
                            <asp:TableRow Style="text-align: center">
                                <asp:TableCell Text="TIPO DE ANTECEDENTE" Style="width: 400px"></asp:TableCell>
                                <asp:TableCell Text="ANTECEDENTE" Style="width: 700px"></asp:TableCell>
                                <asp:TableCell Text="DESCRIPCIÓN" Style="width: 200px"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white">
                                    <asp:DropDownList ID="ddl_tipoAntFam" CssClass="form-check" Style="width: 100%; border: none" runat="server"></asp:DropDownList>
                                    <%--<asp:RequiredFieldValidator ErrorMessage="Required" ControlToValidate="ddl_tipoAntPer" InitialValue="0" runat="server" ForeColor="Red" />--%>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_anteFamiliares" BorderStyle="None" Style="width: 100%" TextMode="MultiLine" Rows="4"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_anteFamDescripcion" BorderStyle="None" Style="width: 100%" TextMode="MultiLine" Rows="4"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card card-responsive" style="width: auto;">
                    <div class="card-header">
                        4. ENFERMEDAD ACTUAL
                    </div>
                    <div class="list-group list-group-flush" style="height: auto; width: auto;">
                        <asp:TextBox runat="server" ID="txt_enfeActual" BorderStyle="None" Style="width: 100%" TextMode="MultiLine" Rows="4"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="card card-responsive" style="width: auto;">
                    <div class="card-header">
                        5. REVISIÓN DE ÓRGANOS Y SISTEMAS
                    </div>
                    <div class="list-group list-group-flush" style="padding: 10px">
                        <asp:Table class="table table-bordered table-light" runat="server">
                            <asp:TableRow Style="text-align: center; background-color: #DAFEF9">
                                <asp:TableCell Text="ÓRGANOS  Y SISTEMAS" Style="width: 350px"></asp:TableCell>
                                <asp:TableCell Text="EVIDENCIA PATOLÓGICA" Style="width: 350px"></asp:TableCell>
                                <asp:TableCell Text="DESCRIPCIÓN" Style="width: 600px"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="Órganos de los Sentidos"></asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:DropDownList ID="ddl_orgSistemas" CssClass="form-check" Style="width: 100%; border: none" runat="server"></asp:DropDownList>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_descOrgSistemas" placeholder="O. Sentidos" BorderStyle="None" Style="width: 100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="Respiratorio"></asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:DropDownList ID="ddl_respiratorio" CssClass="form-check" Style="width: 100%; border: none" runat="server"></asp:DropDownList>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_descRespiratorio" placeholder="Respiratorio" BorderStyle="None" Style="width: 100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="Cardio Vascular"></asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:DropDownList ID="ddl_carVascular" CssClass="form-check" Style="width: 100%; border: none" runat="server"></asp:DropDownList>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_descCarVascular" placeholder="C. Vascular" BorderStyle="None" Style="width: 100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="Digestivo"></asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:DropDownList ID="ddl_digestivo" CssClass="form-check" Style="width: 100%; border: none" runat="server"></asp:DropDownList>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_descDigestivo" placeholder="Digestivo" BorderStyle="None" Style="width: 100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="Genital"></asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:DropDownList ID="ddl_genital" CssClass="form-check" Style="width: 100%; border: none" runat="server"></asp:DropDownList>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_descGenital" placeholder="Genital" BorderStyle="None" Style="width: 100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="Urinario"></asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:DropDownList ID="ddl_urinario" CssClass="form-check" Style="width: 100%; border: none" runat="server"></asp:DropDownList>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_descUrinario" placeholder="Urinario" BorderStyle="None" Style="width: 100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="Muscular"></asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:DropDownList ID="ddl_muscular" CssClass="form-check" Style="width: 100%; border: none" runat="server"></asp:DropDownList>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_descMuscular" placeholder="Muscular" BorderStyle="None" Style="width: 100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="Esquelético"></asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:DropDownList ID="ddl_esqueletico" CssClass="form-check" Style="width: 100%; border: none" runat="server"></asp:DropDownList>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_descEsqueletico" placeholder="Esqueletico" BorderStyle="None" Style="width: 100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="Nervioso"></asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:DropDownList ID="ddl_nervioso" CssClass="form-check" Style="width: 100%; border: none" runat="server"></asp:DropDownList>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_descNervioso" placeholder="Nervioso" BorderStyle="None" Style="width: 100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="Endocrino"></asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:DropDownList ID="ddl_endocrino" CssClass="form-check" Style="width: 100%; border: none" runat="server"></asp:DropDownList>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_descEndocrino" placeholder="Endocrino" BorderStyle="None" Style="width: 100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="Hemo Linfático"></asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:DropDownList ID="ddl_hemoLinfatico" CssClass="form-check" Style="width: 100%; border: none" runat="server"></asp:DropDownList>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_descHemoLinfatico" placeholder="Hemo Linfatico" BorderStyle="None" Style="width: 100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="Tegumentario (Piel y Faneras)"></asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:DropDownList ID="ddl_tegumentario" CssClass="form-check" Style="width: 100%; border: none" runat="server"></asp:DropDownList>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_descTegumentario" placeholder="Tegumentario" BorderStyle="None" Style="width: 100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card card-responsive" style="width: auto">
                    <div class="card-header">
                        6. SIGNOS VITALES Y ANTROPOMÉTRICOS 
                    </div>
                    <div class="list-group list-group-flush" style="padding: 10px; width: auto">
                        <div class="container" style="padding-top: 10px">
                            <asp:Table CssClass="table table-bordered" runat="server">
                                <asp:TableRow>
                                    <asp:TableCell Style="width: auto" Text="Presión Arterial (mmHg)"></asp:TableCell>
                                    <asp:TableCell Style="width: 75px;">
                                        <asp:TextBox ID="txt_presArterial" runat="server" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell Style="width: auto" Text="Temperatura (°C)"></asp:TableCell>
                                    <asp:TableCell Style="width: 75px;">
                                        <asp:TextBox ID="txt_temperatura" runat="server" TextMode="Number" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell Style="width: auto" Text="Frecuencia Cardiaca (Lat/min)"></asp:TableCell>
                                    <asp:TableCell Style="width: 75px;">
                                        <asp:TextBox ID="txt_frecCardiaca" runat="server" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell Style="width: auto" Text="Saturación de Oxígeno (O2%)"></asp:TableCell>
                                    <asp:TableCell Style="width: 75px;">
                                        <asp:TextBox ID="txt_satOxigeno" runat="server" TextMode="Number" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell Style="width: auto" Text="Frecuencia Respiratoria (fr/min)"></asp:TableCell>
                                    <asp:TableCell Style="width: 75px;">
                                        <asp:TextBox ID="txt_frecRespiratoria" runat="server" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell Style="width: auto" Text="Peso (Kg)"></asp:TableCell>
                                    <asp:TableCell Style="width: 75px;">
                                        <asp:TextBox ID="txt_peso" runat="server" BorderStyle="None" TextMode="Number" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell Style="width: auto" Text="Talla (cm)"></asp:TableCell>
                                    <asp:TableCell Style="width: 75px;">
                                        <asp:TextBox ID="txt_talla" runat="server" BorderStyle="None" TextMode="Number" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell Style="width: auto" Text="Indice de Masa Corporal (kg/m2)"></asp:TableCell>
                                    <asp:TableCell Style="width: 75px;">
                                        <asp:TextBox ID="txt_indMasCorporal" runat="server" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell Style="width: auto" Text="Perímetro Abdominal (cm)"></asp:TableCell>
                                    <asp:TableCell Style="width: 75px;">
                                        <asp:TextBox ID="txt_perAbdominal" runat="server" BorderStyle="None" TextMode="Number" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </div>
                    </div>
                </div>
                <br />
                <div class="card card-responsive" style="width: auto;">
                    <div class="card-header">
                        7. EXAMEN FÍSICO
                    </div>
                    <div class="list-group list-group-flush" style="padding: 10px; text-align: center">
                        <asp:Table class="table table-bordered table-light" Style="text-align: center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="EXAMEN/REGIÓN ANATÓMICA" Style="width: 300px"></asp:TableCell>
                                <asp:TableCell Text="EVIDENCIA PATOLÓGICA" Style="width: 300px"></asp:TableCell>
                                <asp:TableCell Text="DESCRIPCIÓN" Style="width: 700px"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="background-color: white">
                                    <asp:DropDownList ID="ddl_region" CssClass="form-check" Style="width: 100%; border: none" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddl_region_SelectedIndexChanged"></asp:DropDownList>
                                    <%--<asp:RequiredFieldValidator ErrorMessage="Required" ControlToValidate="ddl_tipoAntPer" InitialValue="0" runat="server" ForeColor="Red" />--%>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:DropDownList ID="ddl_tipoRegion" CssClass="form-check" Style="width: 100%; border: none" runat="server"></asp:DropDownList>
                                    <%--<asp:RequiredFieldValidator ErrorMessage="Required" ControlToValidate="ddl_tipoAntPer" InitialValue="0" runat="server" ForeColor="Red" />--%>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_exafisdescripcion" BorderStyle="None" Style="width: 100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        8. DIAGNÓSTICOS
                    </div>
                    <div class="list-group list-group-flush" style="padding: 10px; text-align: center">
                        <asp:Table class="table table-bordered table-light" Style="text-align: center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="DIAGNÓSTICOS"></asp:TableCell>
                                <asp:TableCell Text="CÓDIGO"></asp:TableCell>
                                <asp:TableCell Text="TIPO"></asp:TableCell>
                                <asp:TableCell Text="CONDICIÓN"></asp:TableCell>
                                <asp:TableCell Text="CRONOLOGÍA"></asp:TableCell>
                                <asp:TableCell Text="DESCRIPCIÓN"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="width: 250px; background-color: white">
                                    <asp:TextBox runat="server" ID="txt_diagnosticosDiagnostico" BorderStyle="None" Style="width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 75px; background-color: white">
                                    <asp:TextBox runat="server" ID="txt_codigoDiagnostico" BorderStyle="None" Style="width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 100px; background-color: white">
                                    <asp:TextBox runat="server" ID="txt_tipoDiagnostico" BorderStyle="None" Style="width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_condicionDiagnostico" BorderStyle="None" Style="width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_cronologiaDiagnostico" BorderStyle="None" Style="width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_descripcionDiagnostico" BorderStyle="None" Style="width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        9. PLAN DE TRATAMIENTO
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:TextBox runat="server" ID="txt_tratamiento" BorderStyle="None" Style="background-color: transparent; width: 100%" TextMode="MultiLine" Rows="4"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        10. EVOLUCIÓN
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:TextBox runat="server" ID="txt_evolucion" BorderStyle="None" Style="background-color: transparent; width: 100%" TextMode="MultiLine" Rows="4"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        11. PRESCRIPCIONES
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:TextBox runat="server" ID="txt_prescipciones" BorderStyle="None" Style="background-color: transparent; width: 100%" TextMode="MultiLine" Rows="4"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="list-group list-group-flush" style="padding: 10px;">
                        <asp:Table class="table table-bordered table-light text-center" Style="text-align: center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="FECHA y HORA"></asp:TableCell>
                                <asp:TableCell Text="ESPECIALIDAD"></asp:TableCell>
                                <asp:TableCell Text="NOMBRE DEL PROFESIONAL"></asp:TableCell>
                                <asp:TableCell Text="CÓDIGO"></asp:TableCell>
                                <asp:TableCell Text="FIRMA" Style="width: 150px"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Style="width: 200px; background-color: white">
                                    <asp:TextBox runat="server" ID="txt_fechahora" BorderStyle="None" Style="width: 100%; text-align: center" TextMode="DateTime"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 250px; background-color: white">
                                    <asp:DropDownList ID="ddl_especialidad" CssClass="form-check" Style="width: 100%; border: none" runat="server"></asp:DropDownList>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 300px; background-color: white">
                                    <asp:DropDownList ID="ddl_profesional" CssClass="form-check" Style="width: 100%; border: none" runat="server"></asp:DropDownList>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 150px; background-color: white">
                                    <asp:TextBox ID="txt_codigo" runat="server" BorderStyle="None" Style="width: 100%; text-align: center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 150px; background-color: white"></asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="container" align="center">
                    <asp:Button CssClass="btn btn-primary" ID="btn_guardar" runat="server" Text="Guardar" OnClick="btn_guardar_Click" UseSubmitBehavior="False" />
                    <asp:Button CssClass="btn btn-primary" ID="btn_modificar" runat="server" Text="Modificar" OnClick="btn_modificar_Click" UseSubmitBehavior="False" />
                    <asp:Button CssClass="btn btn-secondary" ID="btn_cancelar" runat="server" Text="Cancelar" OnClick="btn_cancelar_Click" UseSubmitBehavior="False" />
                </div>
                <br />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
