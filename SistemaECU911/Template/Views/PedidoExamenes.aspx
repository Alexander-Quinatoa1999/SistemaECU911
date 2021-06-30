<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Views/Principal.Master" AutoEventWireup="true" CodeBehind="PedidoExamenes.aspx.cs" Inherits="SistemaECU911.Template.Views.PedidoExamenes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../Template Principal/css/Style_Prueba.css" rel="stylesheet"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="container">
            <div class="row align-items-start">
                <div class="card border-dark mb-3 table-responsive" style="margin-top: 25px">
                    <div class="card-header bg-primary border-dark" align="center">
                        <b>A. DATOS DEL ESTABLECIMIENTO - EMPRESA Y USUARIO</b>
                    </div>
                    <div class="card-body">
                        <table class="table table-hover table-bordered border-dark text-center table-responsive">
                            <thead>
                                <tr class="table-success table-bordered border-dark">
                                    <th scope="col">INSTITUCIÓN DEL SISTEMA O NOMBRE DE LA EMPRESA</th>
                                    <th scope="col">RUC</th>
                                    <th scope="col">CIIU</th>
                                    <th scope="col">ESTABLECIMIENTO DE SALUD</th>
                                    <th scope="col">NUMERO DE HISTORIA CLINICA</th>
                                    <th scope="col">NUMERO DE ARCHIVO</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>SERVICIO INTEGRADO DE SEGURIDAD ECU 911</td>
                                    <td>1768174880001</td>
                                    <td>
                                        <asp:TextBox ID="TextBox1" Style="border: none" runat="server"></asp:TextBox>
                                    </td>
                                    <td>CONSULTORIO MEDICO</td>
                                    <td>
                                        <asp:TextBox ID="TextBox2" Style="border: none" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox3" Style="border: none" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                        <table class="table table-hover table-bordered border-dark text-center table-responsive">
                            <thead>
                                <tr class="table-success table-bordered border-dark">
                                    <th scope="col">PRIMER APELLIDO</th>
                                    <th scope="col">SEGUNDO APELLIDO</th>
                                    <th scope="col">PRIMER NOMBRE</th>
                                    <th scope="col">SEGUNDO NOMBRE</th>
                                    <th scope="col">EDAD</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="TextBox4" Style="border: none" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox5" Style="border: none" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox6" Style="border: none" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox7" Style="border: none" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox8" Style="border: none" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <div class="row">
                <div id="HEMATOLOGIA" class="table-responsive">
                    <b>HEMATOLOGIA</b>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Hematica" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Hematica" runat="server" Text="Biometrica Hematica"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Hematocrito" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Hematocrito" runat="server" Text="Hematocrito"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Hemoglobina" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Hemoglobina" runat="server" Text="Hemoglobina"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="VSG" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="VSG" runat="server" Text="VSG"></asp:Label>
                    </div>
                </div>
                <div id="ELECTROLITOS" class="table-responsive">
                    <b>ELECTROLITOS</b>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Na" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Na" runat="server" Text="Na - K - Ci"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Ionico" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Ionico" runat="server" Text="Calcio Ionico"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Total" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Total" runat="server" Text="Calcio Total"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Magnesio" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Magnesio" runat="server" Text="Magnesio"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Fosforo" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Fosforo" runat="server" Text="Fosforo"></asp:Label>
                    </div>
                </div>
                <div id="TUMORALES" class="table-responsive">
                    <b>MARCADORES TUMORALES</b>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="CA125" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="CA125" runat="server" Text="CA 125"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="HE4" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="HE4" runat="server" Text="HE 4"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="ROMA" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="ROMA" runat="server" Text="Indice ROMA"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="AFP" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="AFP" runat="server" Text="AFP"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="CEA" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="CEA" runat="server" Text="CEA"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="CA15" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="CA15" runat="server" Text="CA 15-3"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="CA19" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="CA19" runat="server" Text="CA 19-9"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Tiroglobulina" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Tiroglobulina" runat="server" Text="Tiroglobulina"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="PSA" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="PSA" runat="server" Text="PSA"></asp:Label>
                    </div>
                </div>
                <div id="INMUNOHEMATOLOGIA" class="table-responsive">
                    <b>INMUNOHEMATOLOGIA</b>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Directo" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Directo" runat="server" Text="Coombs Directo"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Indirecto" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Indirecto" runat="server" Text="Coombs Indirecto"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="RH" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="RH" runat="server" Text="Grupo Sanguineo y Factor RH"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="LE" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="LE" runat="server" Text="Celulas L.E."></asp:Label>
                    </div>
                </div>
                <div id="SEROLOGIA" class="table-responsive">
                    <b>SEROLOGIA</b>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Cuantitativo" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Cuantitativo" runat="server" Text="PCR Cuantitativo"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Latex" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Latex" runat="server" Text="FR Latex"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="ASTO" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="ASTO" runat="server" Text="ASTO"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Aglutinaciones" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Aglutinaciones" runat="server" Text="Aglutinaciones"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="VDRL" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="VDRL" runat="server" Text="V.D.R.L."></asp:Label>
                    </div>
                </div>
                <div id="MICROBIOLOGIA" class="table-responsive">
                    <b>MICROBIOLOGIA</b>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Muestra" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Muestra" runat="server" Text="Muestra de:"></asp:Label>
                        <asp:TextBox ID="TextBox10" Style="border: none" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Gram" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Gram" runat="server" Text="Gram"></asp:Label>
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Fresco" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Fresco" runat="server" Text="Fresco"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="KOH" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="KOH" runat="server" Text="KOH"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Antibiograma" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Antibiograma" runat="server" Text="Cultivo y Antibiograma"></asp:Label>
                    </div>
                </div>
                <div id="COAGULACION" class="table-responsive">
                    <b>COAGULACION</b>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Plaquetas" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Plaquetas" runat="server" Text="Plaquetas"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Fibrinogeno" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Fibrinogeno" runat="server" Text="Fibrinogeno"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="TP" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="TP" runat="server" Text="T.P"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="TTP" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="TTP" runat="server" Text="T.T.P"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="INR" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="INR" runat="server" Text="I.N.R"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Coagulacion" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Coagulacion" runat="server" Text="Tiempo de Coagulacion"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Sangria" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Sangria" runat="server" Text="Tiempo de Sangria"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Lupico" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Lupico" runat="server" Text="Anticoagulante Lupico"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="DimeroD" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="DimeroD" runat="server" Text="Dimero D"></asp:Label>
                    </div>
                </div>
                <div id="HORMONAS" class="table-responsive">
                    <b>HORMONAS</b>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="LH" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="LH" runat="server" Text="LH"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="FSH" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="FSH" runat="server" Text="FSH"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Estradiol" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Estradiol" runat="server" Text="Estradiol (E2)"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Progesterona" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Progesterona" runat="server" Text="Progesterona (P4)"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Prolactina" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Prolactina" runat="server" Text="Prolactina"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Testosterona" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Testosterona" runat="server" Text="Testosterona"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="DHEAS" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="DHEAS" runat="server" Text="DHEAS"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Cortisol" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Cortisol" runat="server" Text="Cortisol"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Insulina" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Insulina" runat="server" Text="Insulina"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="PeptidoC" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="PeptidoC" runat="server" Text="Peptido C"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="HOMA" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="HOMA" runat="server" Text="Indice HOMA"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="BhCG" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="BhCG" runat="server" Text="BhCG"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="T3" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="T3" runat="server" Text="T3"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="fT4" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="fT4" runat="server" Text="fT4"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="TSH" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="TSH" runat="server" Text="TSH"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="OHProgesterona" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="OHProgesterona" runat="server" Text="17 OH Progesterona"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="HGH" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="HGH" runat="server" Text="HGH (H. de Crecimiento)"></asp:Label>
                    </div>
                </div>
                <div id="ESPECIALES" class="table-responsive">
                    <b>ESTUDIOS ESPECIALES</b>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Espermatograma" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Espermatograma" runat="server" Text="Espermatograma completo"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Cristalografia" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Cristalografia" runat="server" Text="Cristalografia"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Prenatal" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Prenatal" runat="server" Text="Screening Prenatal"></asp:Label>
                    </div>
                </div>
                <div id="SANGUINEA" class="table-responsive">
                    <b>QUIMICA SANGUINEA</b>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Basal" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Basal" runat="server" Text="Glucosa Basal"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Urea" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Urea" runat="server" Text="Urea"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="BUM" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="BUM" runat="server" Text="BUM"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Creatinina" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Creatinina" runat="server" Text="Creatinina"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Urico" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Urico" runat="server" Text="Ac.Urico"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Colesterol" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Colesterol" runat="server" Text="Colesterol Total"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="HDLc" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="HDLc" runat="server" Text="HDLc"></asp:Label>
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="LDLc" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="LDLc" runat="server" Text="LDLc"></asp:Label>
                    </div>
                    <div class="form-check">
                        <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Trigliceridos" runat="server"></asp:TextBox>
                        <asp:Label class="form-check-label" for="Trigliceridos" runat="server" Text="Trigliceridos"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js"></script>
</asp:Content>
