<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Views/Principal.Master" AutoEventWireup="true" CodeBehind="PedidoExamenes.aspx.cs" Inherits="SistemaECU911.Template.Views.PedidoExamenes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="background-color: white">
        <br />
        <div class="container">
            <div class="card text-center" style="margin-left:-0.7rem; margin-right:-0.7rem">
                <div class="card-header">
                    HISTORIA CLÍNICA OCUPACIONAL - PEDIDO EXAMENES
                </div>
            </div>
        </div>
        <br />
        <div class="card" style="width: auto;">
            <div class="card-header">
                A. DATOS DEL ESTABLECIMIENTO - EMPRESA Y USUARIO
            </div>
            <div class="list-group list-group-flush">
                <asp:Table class="table table-bordered table-light text-center" runat="server">
                    <asp:TableRow>
                        <asp:TableCell Text="INSTITUCIÓN DEL SISTEMA O NOMBRE DE LA EMPRESA"></asp:TableCell>
                        <asp:TableCell Text="RUC"></asp:TableCell>
                        <asp:TableCell Text="CIIU"></asp:TableCell>
                        <asp:TableCell Text="ESTABLECIMIENTO DE SALUD"></asp:TableCell>
                        <asp:TableCell Text="NÚMERO DE HISTORIA CLÍNICA"></asp:TableCell>
                        <asp:TableCell Text="NÚMERO DE ARCHIVO"></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:TextBox runat="server" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center;"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
                <asp:Table class="table table-bordered table-light text-center" runat="server">
                    <asp:TableRow>
                        <asp:TableCell Text="PRIMER APELLIDO"></asp:TableCell>
                        <asp:TableCell Text="SEGUNDO APELLIDO"></asp:TableCell>
                        <asp:TableCell Text="PRIMER NOMBRE"></asp:TableCell>
                        <asp:TableCell Text="SEGUNDO NOMBRE"></asp:TableCell>
                        <asp:TableCell Text="SEXO"></asp:TableCell>
                        <asp:TableCell Text="EDAD"></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:TextBox runat="server" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" BorderStyle="None" style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </div>
        </div>
        <div class="card border-1">
            <div class="card-body">
                <div class="row">
                    <div class="col table-responsive" id="HEMATOLOGIA">
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
                    <div class="col table-responsive" id="ELECTROLITOS">
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
                    <div class="col table-responsive" id="TUMORALES">
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
                </div>
                <div class="row">
                    <div class="col table-responsive" id="INMUNOHEMATOLOGIA" style="margin-top: -8rem;">
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
                    <div class="col table-responsive" id="SEROLOGIA" style="margin-top: -6.5rem;">
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
                    <div class="col table-responsive" id="MICROBIOLOGIA">
                        <b>MICROBIOLOGIA</b>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Muestra" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="Muestra" runat="server" Text="Muestra de:"></asp:Label>
                            <asp:TextBox ID="TextBox10" CssClass="border-bottom border-dark" Style="border: none" runat="server"></asp:TextBox>
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
                </div>
                <div class="row">
                    <div class="col table-responsive" id="COAGULACION" style="margin-top: -10rem;">
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
                    <div class="col table-responsive" id="HORMONAS" style="margin-top: -7rem;">
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
                    <div class="col table-responsive" id="ESPECIALES" style="margin-top: 0rem;">
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
                </div>
                <div class="row">
                    <div class="col table-responsive" id="SANGUINEA" style="margin-top: -16rem;">
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
                        <div class="row">
                            <div class="form-check col-md" style="margin-left: 0.75rem;">
                                <asp:TextBox class="form-check-input" type="checkbox" value="" ID="HDLc" runat="server"></asp:TextBox>
                                <asp:Label class="form-check-label" for="HDLc" runat="server" Text="HDLc"></asp:Label>
                            </div>
                            <div class="form-check col col" style="margin-right: 0.75rem;">
                                <asp:TextBox class="form-check-input" type="checkbox" value="" ID="LDLc" runat="server"></asp:TextBox>
                                <asp:Label class="form-check-label" for="LDLc" runat="server" Text="LDLc"></asp:Label>
                            </div>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Trigliceridos" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="Trigliceridos" runat="server" Text="Trigliceridos"></asp:Label>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="BilirrubinaT" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="BilirrubinaT" runat="server" Text="Bilirrubina Total"></asp:Label>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="BilirrubinaD" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="BilirrubinaD" runat="server" Text="Bilirrubina Directa"></asp:Label>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="BilirrubinaI" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="BilirrubinaI" runat="server" Text="Bilirrubina Indirecta"></asp:Label>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="ProteinasT" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="ProteinasT" runat="server" Text="Proteinas Totales"></asp:Label>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Albumina" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="Albumina" runat="server" Text="Albumina"></asp:Label>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Globulina" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="Globulina" runat="server" Text="Globulina"></asp:Label>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Osullivan" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="Osullivan" runat="server" Text="Test de Osullivan"></asp:Label>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Glucosa2h" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="Glucosa2h" runat="server" Text="Glucosa 2h pp"></asp:Label>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Tolerancia" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="Tolerancia" runat="server" Text="Curva de Tolerancia"></asp:Label>
                            <asp:Label class="form-check-label" for="glu" runat="server" Text="Glucosa:" Style="margin-left: -1.40rem;"></asp:Label>
                            <asp:TextBox ID="TextBox5" CssClass="border-bottom border-dark" BorderStyle="None" Style="background-color: transparent; width: 50%; text-align: center" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="horas" runat="server" Text="Horas"></asp:Label>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Glicosilada" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="Glicosilada" runat="server" Text="Hemoglobina Glicosilada"></asp:Label>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Sérico" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="Sérico" runat="server" Text="Hierro Sérico"></asp:Label>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Ferritina" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="Ferritina" runat="server" Text="Ferritina"></asp:Label>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Transferrina" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="Transferrina" runat="server" Text="Transferrina"></asp:Label>
                        </div>
                    </div>
                    <div class="col table-responsive" id="INMUNOLOGIA">
                        <b>INMUNOLOGIA</b>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="IProlactina" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="IProlactina" runat="server" Text="Prolactina"></asp:Label>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="ANA" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="ANA" runat="server" Text="Anti Nucleares (ANA)"></asp:Label>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="DNA" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="DNA" runat="server" Text="Anti DNA"></asp:Label>
                        </div>
                        <div class="row">
                            <div class="col form-check" style="margin-left: 0.75rem;">
                                <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Fosfolípidos" runat="server"></asp:TextBox>
                                <asp:Label class="form-check-label" for="Fosfolípidos" runat="server" Text="Anti Fosfolípido"></asp:Label>
                            </div>
                            <%--<div class="col form-check" style="margin-left:0rem">
                                <asp:TextBox class="form-check-input" type="checkbox" value="" ID="IgG" runat="server"></asp:TextBox>
                                <asp:Label class="form-check-label" for="IgG" runat="server" Text="IgG"></asp:Label>
                            </div>
                            <div class="col form-check" style="margin-left:0rem">
                                <asp:TextBox class="form-check-input" type="checkbox" value="" ID="IgM" runat="server"></asp:TextBox>
                                <asp:Label class="form-check-label" for="IgM" runat="server" Text="IgM"></asp:Label>
                            </div>
                            <div class="col form-check" style="margin-left:-3rem">
                                <asp:TextBox class="form-check-input" type="checkbox" value="" ID="IgA" runat="server"></asp:TextBox>
                                <asp:Label class="form-check-label" for="IgA" runat="server" Text="IgA"></asp:Label>
                            </div>--%>
                        </div>
                        <div class="row">
                            <div class="form-check col" style="margin-left: 0.75rem; margin-right: 2rem;">
                                <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Cardiolipinas" runat="server"></asp:TextBox>
                                <asp:Label class="form-check-label" for="Cardiolipinas" runat="server" Text="Anti Cardiolipinas"></asp:Label>
                            </div>
                            <%--<div class="form-check col">
                                <asp:TextBox class="form-check-input" type="checkbox" value="" ID="TextBox7" runat="server"></asp:TextBox>
                                <asp:Label class="form-check-label" for="IgG" runat="server" Text="IgG"></asp:Label>
                            </div>
                            <div class="form-check col" style="margin-left: -1rem;">
                                <asp:TextBox class="form-check-input" type="checkbox" value="" ID="TextBox8" runat="server"></asp:TextBox>
                                <asp:Label class="form-check-label" for="IgM" runat="server" Text="IgM"></asp:Label>
                            </div>
                            <div class="form-check col">
                                <asp:TextBox class="form-check-input" type="checkbox" value="" ID="TextBox9" runat="server"></asp:TextBox>
                                <asp:Label class="form-check-label" for="IgA" runat="server" Text="IgA"></asp:Label>
                            </div>--%>
                        </div>
                        <div class="row">
                            <div class="form-check col" style="margin-left: 0.75rem; margin-right: 1.3rem;">
                                <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Glicoproteína" runat="server"></asp:TextBox>
                                <asp:Label class="form-check-label" for="Glicoproteína" runat="server" Text="B2 Glicoproteína"></asp:Label>
                            </div>
                            <%--<div class="form-check col">
                                <asp:TextBox class="form-check-input" type="checkbox" value="" ID="TextBox1" runat="server"></asp:TextBox>
                                <asp:Label class="form-check-label" for="IgG" runat="server" Text="IgG"></asp:Label>
                            </div>
                            <div class="form-check col">
                                <asp:TextBox class="form-check-input" type="checkbox" value="" ID="TextBox11" runat="server"></asp:TextBox>
                                <asp:Label class="form-check-label" for="IgM" runat="server" Text="IgM"></asp:Label>
                            </div>--%>
                        </div>
                        <div class="row">
                            <div class="form-check col" style="margin-left: 0.75rem; margin-right: 3rem;">
                                <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Gliadina" runat="server"></asp:TextBox>
                                <asp:Label class="form-check-label" for="Gliadina" runat="server" Text="Anti Gliadina"></asp:Label>
                            </div>
                            <%--<div class="form-check col">
                                <asp:TextBox class="form-check-input" type="checkbox" value="" ID="TextBox12" runat="server"></asp:TextBox>
                                <asp:Label class="form-check-label" for="IgG" runat="server" Text="IgG"></asp:Label>
                            </div>
                            <div class="form-check col">
                                <asp:TextBox class="form-check-input" type="checkbox" value="" ID="TextBox13" runat="server"></asp:TextBox>
                                <asp:Label class="form-check-label" for="IgA" runat="server" Text="IgA"></asp:Label>
                            </div>--%>
                        </div>
                        <div class="row">
                            <div class="form-check col" style="margin-left: 0.75rem; margin-right: 1.3rem;">
                                <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Anexina" runat="server"></asp:TextBox>
                                <asp:Label class="form-check-label" for="Anexina" runat="server" Text="Anti Anexina V"></asp:Label>
                            </div>
                            <%--<div class="form-check col" style="margin-left: 5rem;">
                                <asp:TextBox class="form-check-input" type="checkbox" value="" ID="TextBox14" runat="server"></asp:TextBox>
                                <asp:Label class="form-check-label" for="IgG" runat="server" Text="IgG"></asp:Label>
                            </div>
                            <div class="form-check col">
                                <asp:TextBox class="form-check-input" type="checkbox" value="" ID="TextBox15" runat="server"></asp:TextBox>
                                <asp:Label class="form-check-label" for="IgM" runat="server" Text="IgM"></asp:Label>
                            </div>--%>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="TPO" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="TPO" runat="server" Text="Anti TPO (microsomales)"></asp:Label>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="ATiroglobulina" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="ATiroglobulina" runat="server" Text="Anti Tiroglobulina"></asp:Label>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="CCP" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="CCP" runat="server" Text="Anti CCP"></asp:Label>
                        </div>
                    </div>
                    <div class="col table-responsive" id="ORINA" style="margin-top: -16rem;">
                        <b>ORINA</b>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="EMO" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="EMO" runat="server" Text="EMO"></asp:Label>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="CulAntibiograma" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="CulAntibiograma" runat="server" Text="Cultivo y Antibiograma"></asp:Label>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="GramGotaF" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="GramGotaF" runat="server" Text="Gram gota fresca"></asp:Label>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Microalbuminuria" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="Microalbuminuria" runat="server" Text="Microalbuminuria"></asp:Label>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col table-responsive" id="ENZIMAS" style="margin-top: 0rem;">
                        <b>ENZIMAS</b>
                        <div class="row">
                            <div class="form-check col" style="margin-left: 0.75rem;">
                                <asp:TextBox class="form-check-input" type="checkbox" value="" ID="TGO" runat="server"></asp:TextBox>
                                <asp:Label class="form-check-label" for="TGO" runat="server" Text="TGO"></asp:Label>
                            </div>
                            <div class="form-check col">
                                <asp:TextBox class="form-check-input" type="checkbox" value="" ID="TGP" runat="server"></asp:TextBox>
                                <asp:Label class="form-check-label" for="TGP" runat="server" Text="TGP"></asp:Label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="form-check col" style="margin-left: 0.75rem;">
                                <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Amilasa" runat="server"></asp:TextBox>
                                <asp:Label class="form-check-label" for="Amilasa" runat="server" Text="Amilasa"></asp:Label>
                            </div>
                            <div class="form-check col">
                                <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Lipasa" runat="server"></asp:TextBox>
                                <asp:Label class="form-check-label" for="Lipasa" runat="server" Text="Lipasa"></asp:Label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="form-check col" style="margin-left: 0.75rem;">
                                <asp:TextBox class="form-check-input" type="checkbox" value="" ID="CPK" runat="server"></asp:TextBox>
                                <asp:Label class="form-check-label" for="CPK" runat="server" Text="CPK"></asp:Label>
                            </div>
                            <div class="form-check col">
                                <asp:TextBox class="form-check-input" type="checkbox" value="" ID="CPKMB" runat="server"></asp:TextBox>
                                <asp:Label class="form-check-label" for="CPKMB" runat="server" Text="CPK-MB"></asp:Label>
                            </div>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="LDH" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="LDH" runat="server" Text="LDH"></asp:Label>
                        </div>
                        <div class="form-check col">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Alcalina" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="Alcalina" runat="server" Text="Fosfatasa Alcalina"></asp:Label>
                        </div>
                        <div class="form-check col">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="ÁcidaTot" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="ÁcidaTot" runat="server" Text="Fosfatasa Ácida Total"></asp:Label>
                        </div>
                        <div class="form-check col">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="ÁcidaPros" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="ÁcidaPros" runat="server" Text="Fosfatasa Ácida Prostática"></asp:Label>
                        </div>
                    </div>
                    <div class="col table-responsive" id="INFECCIOSAS" style="margin-top: -4rem;">
                        <b>INMUNO - INFECCIOSAS</b>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="TORCH" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="TORCH" runat="server" Text="TORCH"></asp:Label>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Toxoplasma" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="Toxoplasma" runat="server" Text="Toxoplasma gondii - Test de Avidez IgG"></asp:Label>
                        </div>
                        <div class="row">
                            <div class="form-check col" style="margin-left: 0.75rem;">
                                <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Clamydia" runat="server"></asp:TextBox>
                                <asp:Label class="form-check-label" for="Clamydia" runat="server" Text="Clamydia Trachomatis IgG"></asp:Label>
                            </div>
                            <div class="form-check col" style="margin-left: 7rem;">
                                <asp:TextBox class="form-check-input" type="checkbox" value="" ID="txt_IgM" runat="server"></asp:TextBox>
                                <asp:Label class="form-check-label" for="IgM" runat="server" Text="IgM"></asp:Label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="form-check col" style="margin-left: 0.75rem;">
                                <asp:TextBox class="form-check-input" type="checkbox" value="" ID="HAV" runat="server"></asp:TextBox>
                                <asp:Label class="form-check-label" for="HAV" runat="server" Text="HAV"></asp:Label>
                            </div>
                            <div class="form-check col">
                                <asp:TextBox class="form-check-input" type="checkbox" value="" ID="TextBox6" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-check col">
                                <asp:TextBox class="form-check-input" type="checkbox" value="" ID="TextBox16" runat="server"></asp:TextBox>
                                <asp:Label class="form-check-label" for="IgM" runat="server" Text="IgM"></asp:Label>
                            </div>
                        </div>
                        <div class="form-check col">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="VIH" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="VIH" runat="server" Text="VIH"></asp:Label>
                        </div>
                        <div class="form-check col">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="HbsAg" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="HbsAg" runat="server" Text="HbsAg"></asp:Label>
                        </div>
                        <div class="form-check col">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="HCV" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="HCV" runat="server" Text="HCV"></asp:Label>
                        </div>
                        <div class="form-check col">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="FTA" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="FTA" runat="server" Text="FTA - ABS"></asp:Label>
                        </div>
                    </div>
                    <div class="col table-responsive" id="HECES" style="margin-top: -31.5rem;">
                        <b>HECES</b>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Coproparasitario" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="Coproparasitario" runat="server" Text="Coproparasitario"></asp:Label>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="seriado" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="seriado" runat="server" Text="Coproparasitario seriado #"></asp:Label>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Sangre" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="Sangre" runat="server" Text="Sangre Oculta"></asp:Label>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="PMN" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="Sangre" runat="server" Text="PMN"></asp:Label>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Rotavirus" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="Rotavirus" runat="server" Text="Rotavirus"></asp:Label>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Helicobacter" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="Helicobacter" runat="server" Text="Helicobacter pylori (Antigeno)"></asp:Label>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col table-responsive" id="DROGAS" style="margin-top: 0rem;">
                        <b>DROGAS</b>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Fenobarbital" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="Fenobarbital" runat="server" Text="Fenobarbital"></asp:Label>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Teofilina" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="Teofilina" runat="server" Text="Teofilina"></asp:Label>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="Valproico" runat="server"></asp:TextBox>
                            <asp:Label class="form-check-label" for="Valproico" runat="server" Text="Ac.Valproico"></asp:Label>
                        </div>
                    </div>
                    <div class="col table-responsive" id="OTROS" style="margin-top: 0rem;">
                        <b>OTROS</b>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="TextBox2" runat="server"></asp:TextBox>
                            <asp:TextBox ID="TextBox4" CssClass="border-bottom border-dark" BorderStyle="None" Style="background-color: transparent; text-align: center" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="TextBox3" runat="server"></asp:TextBox>
                            <asp:TextBox ID="TextBox17" CssClass="border-bottom border-dark" BorderStyle="None" Style="background-color: transparent; text-align: center" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-check">
                            <asp:TextBox class="form-check-input" type="checkbox" value="" ID="TextBox18" runat="server"></asp:TextBox>
                            <asp:TextBox ID="TextBox19" CssClass="border-bottom border-dark" BorderStyle="None" Style="background-color: transparent; text-align: center" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col table-responsive" id="FIRMA" style="margin-top: -32rem;">
                        <div class="card" style="width: 300px">
                            <div class="card-header" align="center">
                                FIRMA DEL MEDICO    
                            </div>
                            <div class="list-group list-group-flush">
                                <asp:Label ID="Label24" runat="server" Text="" Style="height: 80px"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <br />
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
