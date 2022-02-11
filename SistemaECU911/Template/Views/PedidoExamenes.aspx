﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Views/Principal.Master" AutoEventWireup="true" CodeBehind="PedidoExamenes.aspx.cs" Inherits="SistemaECU911.Template.Views.PedidoExamenes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="background-color: white">
        <br />
        <div class="container">
            <div class="card text-center" style="margin-left: -0.7rem; margin-right: -0.7rem">
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
                            <asp:TextBox runat="server" BorderStyle="None" ID="txt_numHClinica" Style="background-color: transparent; width: 100%; text-align: center" OnTextChanged="txt_numHClinica_TextChanged" AutoPostBack="true"></asp:TextBox>
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
                            <asp:TextBox runat="server" ID="txt_priApellido" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" ID="txt_segApellido" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" ID="txt_priNombre" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" ID="txt_segNombre" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" ID="txt_sexo" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" ID="txt_edad" BorderStyle="None" Style="background-color: transparent; width: 100%; text-align: center"></asp:TextBox>
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
                            <asp:CheckBox ID="ckb_bioHematica" Text="&nbsp; &nbsp; Biometrica Hematica" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_hematocrito" Text="&nbsp; &nbsp; Hematocrito" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_hemoglobina" Text="&nbsp; &nbsp; Hemoglobina" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_vsg" Text="&nbsp; &nbsp; VSG" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                    </div>
                    <div class="col table-responsive" id="ELECTROLITOS" style="height: 100%">
                        <b>ELECTROLITOS</b>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_Na" Text="&nbsp; &nbsp; Na - K - Ci" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_calIonico" Text="&nbsp; &nbsp; Calcio Ionico" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_calTotal" Text="&nbsp; &nbsp; Calcio Total" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_magnesio" Text="&nbsp; &nbsp; Magnesio" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_fosforo" Text="&nbsp; &nbsp; Fosforo" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                    </div>
                    <div class="col table-responsive" id="TUMORALES">
                        <b>MARCADORES TUMORALES</b>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_ca125" Text="&nbsp; &nbsp; CA 125" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_he4" Text="&nbsp; &nbsp; HE 4" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_indRoma" Text="&nbsp; &nbsp; Indice Roma" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_afp" Text="&nbsp; &nbsp; AFP" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_cea" Text="&nbsp; &nbsp; CEA" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_ca153" Text="&nbsp; &nbsp; CA 15-3" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_ca199" Text="&nbsp; &nbsp; CA 19-9" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_tiroglobulina" Text="&nbsp; &nbsp; Tiroglobulina" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_psa" Text="&nbsp; &nbsp; PSA" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col table-responsive" id="INMUNOHEMATOLOGIA" style="margin-top: -11rem;">
                        <b>INMUNOHEMATOLOGIA</b>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_cooDirecto" Text="&nbsp; &nbsp; Coombs Directo" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_cooIndirecto" Text="&nbsp; &nbsp; Coombs Indirecto" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_grSanguineo" Text="&nbsp; &nbsp; Grupo Sanguineo y Factor RH" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_celulasLE" Text="&nbsp; &nbsp; Celulas L.E." TextAlign="Right" Checked="false" runat="server" />
                        </div>
                    </div>
                    <div class="col table-responsive" id="SEROLOGIA" style="margin-top: -9rem;">
                        <b>SEROLOGIA</b>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_pcrCuantitativo" Text="&nbsp; &nbsp; PCR Cuantitativo" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_frLatex" Text="&nbsp; &nbsp; FR Latex" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_asto" Text="&nbsp; &nbsp; ASTO" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_aglutinaciones" Text="&nbsp; &nbsp; Aglutinaciones" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_vdrl" Text="&nbsp; &nbsp; V.D.R.L" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                    </div>
                    <div class="col table-responsive" id="MICROBIOLOGIA">
                        <b>MICROBIOLOGIA</b>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_muestra" Text="&nbsp; &nbsp; Muestra de:" TextAlign="Right" Checked="false" runat="server" />
                            <asp:TextBox ID="txt_muestra" CssClass="border-bottom border-dark" Style="border: none" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_gram" Text="&nbsp; &nbsp; Gram" TextAlign="Right" Checked="false" runat="server" />
                            <asp:CheckBox ID="ckb_fresco" Text="&nbsp; &nbsp; Fresco" TextAlign="Right" Checked="false" runat="server" Style="margin-left: 2rem;" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_koh" Text="&nbsp; &nbsp; KOH" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_culAntibiograma" Text="&nbsp; &nbsp; Cultivo y Antibiograma" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col table-responsive" id="COAGULACION" style="margin-top: -11rem;">
                        <b>COAGULACION</b>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_plaquetas" Text="&nbsp; &nbsp; Plaquetas" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_fibrinogeno" Text="&nbsp; &nbsp; Fibrinogeno" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_tp" Text="&nbsp; &nbsp; T.P" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_ttp" Text="&nbsp; &nbsp; T.T.P" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_inr" Text="&nbsp; &nbsp; I.N.R" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_tiempCoagulacion" Text="&nbsp; &nbsp; Tiempo de Coagulacion" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_tiempSangria" Text="&nbsp; &nbsp; Tiempo de Sangria" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_antiLupico" Text="&nbsp; &nbsp; Anticoagulante Lupico" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_dimeroD" Text="&nbsp; &nbsp; Dimero D" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                    </div>
                    <div class="col table-responsive" id="HORMONAS" style="margin-top: -7rem;">
                        <b>HORMONAS</b>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_lh" Text="&nbsp; &nbsp; LH" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_fsh" Text="&nbsp; &nbsp; FSH" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_estradiol" Text="&nbsp; &nbsp; Estradiol (E2)" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_progesterona" Text="&nbsp; &nbsp; Progesterona (P4)" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_prolactina" Text="&nbsp; &nbsp; Prolactina" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_testosterona" Text="&nbsp; &nbsp; Testosterona" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_dheas" Text="&nbsp; &nbsp; DHEAS" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_cortisol" Text="&nbsp; &nbsp; Cortisol" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_insulina" Text="&nbsp; &nbsp; Insulina" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_peptidoC" Text="&nbsp; &nbsp; Peptido C" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_indHoma" Text="&nbsp; &nbsp; Indice HOMA" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_bhcg" Text="&nbsp; &nbsp; BhCG" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_t3" Text="&nbsp; &nbsp; T3" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_fT4" Text="&nbsp; &nbsp; fT4" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_tsh" Text="&nbsp; &nbsp; TSH" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_17Progesterona" Text="&nbsp; &nbsp; 17 OH Progesterona" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_hgh" Text="&nbsp; &nbsp; HGH (H. de Crecimiento)" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                    </div>
                    <div class="col table-responsive" id="ESPECIALES" style="margin-top: 0rem;">
                        <b>ESTUDIOS ESPECIALES</b>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_esperCompleto" Text="&nbsp; &nbsp; Espermatograma completo" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_cristalografia" Text="&nbsp; &nbsp; Cristalografia" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_screenPrenatal" Text="&nbsp; &nbsp; Screening Prenatal" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col table-responsive" id="SANGUINEA" style="margin-top: -21rem;">
                        <b>QUIMICA SANGUINEA</b>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_gluBasal" Text="&nbsp; &nbsp; Glucosa Basal" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_urea" Text="&nbsp; &nbsp; Urea" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_bum" Text="&nbsp; &nbsp; BUM" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_creatinina" Text="&nbsp; &nbsp; Creatinina" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_acUrico" Text="&nbsp; &nbsp; Ac.Urico" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_colesTotal" Text="&nbsp; &nbsp; Colesterol Total" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="row">
                            <div class="form-check">
                                <asp:CheckBox ID="ckb_hdlc" Text="&nbsp; &nbsp; HDLc" TextAlign="Right" Checked="false" runat="server" Style="margin-left: 0.75rem;" />
                                <asp:CheckBox ID="ckb_ldlc" Text="&nbsp; &nbsp; LDLc" TextAlign="Right" Checked="false" runat="server" Style="margin-left: 2rem;" />
                            </div>
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_triglicerido" Text="&nbsp; &nbsp; Triglicerido" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_biliTotal" Text="&nbsp; &nbsp; Bilirrubina Total" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_biliDirecta" Text="&nbsp; &nbsp; Bilirrubina Directa" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_biliindirecta" Text="&nbsp; &nbsp; Bilirrubina Indirecta" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_proTotales" Text="&nbsp; &nbsp; Proteinas Totales" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_albumina" Text="&nbsp; &nbsp; Albumina" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_globulina" Text="&nbsp; &nbsp; Globulina" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_testOsullivan" Text="&nbsp; &nbsp; Test de Osullivan" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_glucosa2h" Text="&nbsp; &nbsp; Glucosa 2h pp" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_curvaTolerancia" Text="&nbsp; &nbsp; Curva de Tolerancia" TextAlign="Right" Checked="false" runat="server" />
                            <div class="form-check" style="display: flex">
                                <asp:Label class="form-check-label" for="glu" runat="server" Text="Glucosa:" Style="margin-left: 0.03rem;"></asp:Label>
                                <asp:TextBox ID="txt_glucosa" CssClass="border-bottom border-dark" BorderStyle="None" Style="background-color: transparent; width: 50%;" runat="server"></asp:TextBox>
                                <asp:Label class="form-check-label" for="horas" runat="server" Text="Horas" Style="margin-left: -0.03rem;"></asp:Label>
                            </div>
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_hemoGlicosilada" Text="&nbsp; &nbsp; Hemoglobina Glicosilada" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_hierroSerico" Text="&nbsp; &nbsp; Hierro Sérico" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_ferritina" Text="&nbsp; &nbsp; Ferritina" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_transferrina" Text="&nbsp; &nbsp; Transferrina" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                    </div>
                    <div class="col table-responsive" id="INMUNOLOGIA">
                        <b>INMUNOLOGIA</b>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_iProlactina" Text="&nbsp; &nbsp; Prolactina" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_antiNucleares" Text="&nbsp; &nbsp; Anti Nucleares (ANA)" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_antiDna" Text="&nbsp; &nbsp; Anti DNA" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="col form-check">
                            <asp:CheckBox ID="ckb_antiFosfolípidos" Text="&nbsp; &nbsp; Anti Fosfolípidos" TextAlign="Right" Checked="false" runat="server" />
                            <asp:CheckBox ID="ckb_igg" Text="&nbsp;IgG" TextAlign="Right" Checked="false" runat="server" Style="margin-left: 0.9rem;" />
                            <asp:CheckBox ID="ckb_igm" Text="&nbsp;IgM" TextAlign="Right" Checked="false" runat="server" Style="margin-left: 0.5rem;" />
                            <asp:CheckBox ID="ckb_iga" Text="&nbsp;IgA" TextAlign="Right" Checked="false" runat="server" Style="margin-left: 0.5rem;" />
                        </div>
                        <div class="form-check col">
                            <asp:CheckBox ID="ckb_cardiolipinas" Text="&nbsp; &nbsp; Anti Cardiolipinas" TextAlign="Right" Checked="false" runat="server" />
                            <asp:CheckBox ID="CheckBox1" Text="&nbsp;IgG" TextAlign="Right" Checked="false" runat="server" Style="margin-left: 0.5rem;" />
                            <asp:CheckBox ID="CheckBox2" Text="&nbsp;IgM" TextAlign="Right" Checked="false" runat="server" Style="margin-left: 0.5rem;" />
                            <asp:CheckBox ID="CheckBox3" Text="&nbsp;IgA" TextAlign="Right" Checked="false" runat="server" Style="margin-left: 0.5rem;" />
                        </div>
                        <div class="form-check col">
                            <asp:CheckBox ID="ckb_b2Glicoproteína" Text="&nbsp; &nbsp; B2 Glicoproteína" TextAlign="Right" Checked="false" runat="server" />
                            <asp:CheckBox ID="CheckBox4" Text="&nbsp;IgG" TextAlign="Right" Checked="false" runat="server" Style="margin-left: 0.97rem;" />
                            <asp:CheckBox ID="CheckBox5" Text="&nbsp;IgM" TextAlign="Right" Checked="false" runat="server" Style="margin-left: 0.5rem;" />
                        </div>
                        <div class="form-check col">
                            <asp:CheckBox ID="ckb_antiGliadina" Text="&nbsp; &nbsp; Anti Gliadina" TextAlign="Right" Checked="false" runat="server" />
                            <asp:CheckBox ID="CheckBox6" Text="&nbsp;IgG" TextAlign="Right" Checked="false" runat="server" Style="margin-left: 2.6rem;" />
                            <asp:CheckBox ID="CheckBox7" Text="&nbsp;IgA" TextAlign="Right" Checked="false" runat="server" Style="margin-left: 4.1rem;" />
                        </div>
                        <div class="form-check col">
                            <asp:CheckBox ID="ckb_antiAnexiaV" Text="&nbsp; &nbsp; Anti Anexina V" TextAlign="Right" Checked="false" runat="server" />
                            <asp:CheckBox ID="CheckBox8" Text="&nbsp;IgG" TextAlign="Right" Checked="false" runat="server" Style="margin-left: 1.8rem;" />
                            <asp:CheckBox ID="CheckBox9" Text="&nbsp;IgM" TextAlign="Right" Checked="false" runat="server" Style="margin-left: 0.5rem;" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_antiTPO" Text="&nbsp; &nbsp; Anti TPO (microsomales)" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_antiTiroglobulina" Text="&nbsp; &nbsp; Anti Tiroglobulina" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_antiCCP" Text="&nbsp; &nbsp; Anti CCP" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                    </div>
                    <div class="col table-responsive" id="ORINA" style="margin-top: -23rem;">
                        <b>ORINA</b>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_emo" Text="&nbsp; &nbsp; EMO" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_CultAntibiograma" Text="&nbsp; &nbsp; Cultivo y Antibiograma" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_gramGotaFres" Text="&nbsp; &nbsp; Gram gota fresca" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_microalbuminuria" Text="&nbsp; &nbsp; Microalbuminuria" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col table-responsive" id="ENZIMAS" style="margin-top: 0rem;">
                        <b>ENZIMAS</b>
                        <div class="row">
                            <div class="form-check col" style="margin-left: 0.75rem;">
                                <asp:CheckBox ID="ckb_tgo" Text="&nbsp; &nbsp; TGO" TextAlign="Right" Checked="false" runat="server" />
                            </div>
                            <div class="form-check col">
                                <asp:CheckBox ID="ckb_tgp" Text="&nbsp; &nbsp; TGP" TextAlign="Right" Checked="false" runat="server" />
                            </div>
                        </div>
                        <div class="row">
                            <div class="form-check col" style="margin-left: 0.75rem;">
                                <asp:CheckBox ID="ckb_amilasa" Text="&nbsp; &nbsp; Amilasa" TextAlign="Right" Checked="false" runat="server" />
                            </div>
                            <div class="form-check col">
                                <asp:CheckBox ID="ckb_lipasa" Text="&nbsp; &nbsp; Lipasa" TextAlign="Right" Checked="false" runat="server" />
                            </div>
                        </div>
                        <div class="row">
                            <div class="form-check col" style="margin-left: 0.75rem;">
                                <asp:CheckBox ID="ckb_ckp" Text="&nbsp; &nbsp; CPK" TextAlign="Right" Checked="false" runat="server" />
                            </div>
                            <div class="form-check col">
                                <asp:CheckBox ID="ckb_ckpMb" Text="&nbsp; &nbsp; CPK-MB" TextAlign="Right" Checked="false" runat="server" />
                            </div>
                        </div>
                        <div class="form-check">
                            <asp:CheckBox ID="ckb_ldh" Text="&nbsp; &nbsp; LDH" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check col">
                            <asp:CheckBox ID="ckb_fosfaAlcalina" Text="&nbsp; &nbsp; Fosfatasa Alcalina" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check col">
                            <asp:CheckBox ID="ckb_fosfaAcidaTotal" Text="&nbsp; &nbsp; Fosfatasa Ácida Total" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                        <div class="form-check col">
                            <asp:CheckBox ID="fosfaAcidaProstatica" Text="&nbsp; &nbsp; Fosfatasa Ácida Prostática" TextAlign="Right" Checked="false" runat="server" />
                        </div>
                    </div>
                    <div class="col table-responsive" id="INFECCIOSAS" style="margin-top: -2rem;">
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
        <div class="container" align="center">
            <asp:Button CssClass="btn btn-primary" ID="btn_guarda" runat="server" Text="Guardar" OnClick="btn_guarda_Click" UseSubmitBehavior="False" />
            <asp:Button CssClass="btn btn-primary" ID="btn_modificar" runat="server" Text="Modificar" OnClick="btn_modificar_Click" UseSubmitBehavior="False" />
            <asp:Button CssClass="btn btn-secondary" ID="btn_cancelar" runat="server" Text="Cancelar" OnClick="btn_cancelar_Click" UseSubmitBehavior="False" />
        </div>
        <br />
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
