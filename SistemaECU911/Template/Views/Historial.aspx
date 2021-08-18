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
                <br />
                <div class="card" style="width: auto;">
                    <div class="list-group list-group-flush" style="padding: 10px; text-align: center">
                        <div class="container">
                            <div class="row">                                
                                <div class="col">
                                    <asp:Table class="table table-bordered table-light text-center" runat="server" align="left">
                                        <asp:TableRow Style="text-align: center">
                                            <asp:TableCell Text="ESTABLECIMIENTO DE SALUD"></asp:TableCell>
                                            <asp:TableCell Text="NOMBRE"></asp:TableCell>
                                            <asp:TableCell Text="APELLIDO"></asp:TableCell>
                                            <asp:TableCell Text="SEXO"></asp:TableCell>
                                            <asp:TableCell Text="EDAD"></asp:TableCell>
                                            <asp:TableCell Text="N° HISTORIA CLÍNICA"></asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow>
                                            <asp:TableCell style="background-color: white">
                                        <asp:TextBox runat="server" ID="txt_nomEmpresa" BorderStyle="None" style="width:100%; text-align:center"></asp:TextBox>
                                            </asp:TableCell>
                                            <asp:TableCell style="background-color: white">
                                        <asp:TextBox runat="server" ID="txt_priNombre" BorderStyle="None" style="width:100%; text-align:center"></asp:TextBox>
                                            </asp:TableCell>
                                            <asp:TableCell style="background-color: white">
                                        <asp:TextBox runat="server" ID="txt_priApellido" BorderStyle="None" style="width:100%; text-align:center"></asp:TextBox>
                                            </asp:TableCell>
                                            <asp:TableCell style="background-color: white">
                                        <asp:TextBox runat="server" ID="txt_sexo" BorderStyle="None" style="width:100%; text-align:center"></asp:TextBox>
                                            </asp:TableCell>
                                            <asp:TableCell style="background-color: white">
                                        <asp:TextBox runat="server" ID="txt_edad" BorderStyle="None" style="width:100%; text-align:center"></asp:TextBox>
                                            </asp:TableCell>
                                            <asp:TableCell style="background-color: white">
                                        <asp:TextBox runat="server" ID="txt_numHClinica" BorderStyle="None" style="width:100%; text-align:center"></asp:TextBox>
                                            </asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>
                                </div>
                                <div class="col col-lg-2">
                                    <img src="../Template Principal/images/Foto_Perfil.png" alt="logo" style="width: 80px; height: 80px" />
                                </div>
                            </div>
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
                                <asp:TableCell style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_moConsulta" BorderStyle="None" style="width:100%" TextMode="MultiLine" Rows="3"></asp:TextBox>       
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white">
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
                                <asp:TableCell style="background-color: white">
                                        <select class="form-control" id="cb" style="width:100%; text-align:center; border:none">
                                            <option selected>Seleccione...</option>
                                            <option>ENFERMEDAD CARDIO-VASCULAR</option>
                                            <option>ENFERMEDAD METABÓLICA</option>
                                            <option>ENFERMEDAD NEUROLÓGICA</option>
                                            <option>ENFERMEDAD ONCOLÓGICA</option>
                                            <option>ENFERMEDAD INFECCIOSA</option>
                                            <option>ENFERMEDAD HEREDITARIA / CONGÉNITA</option>
                                            <option>DISCAPACIDADES</option>
                                            <option>OTROS</option>
                                        </select>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_antePersonales" BorderStyle="None" style="width:100%" TextMode="MultiLine" Rows="4"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_antePersonalesDes" BorderStyle="None" style="width:100%" TextMode="MultiLine" Rows="4"></asp:TextBox>                                    
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
                                <asp:TableCell style="background-color: white">
                                        <select class="form-control" id="exampleFormControlSelect1" style="width:100%; text-align:center; border:none">
                                            <option selected>Seleccione...</option>
                                            <option>ENFERMEDAD CARDIO-VASCULAR</option>
                                            <option>ENFERMEDAD METABÓLICA</option>
                                            <option>ENFERMEDAD NEUROLÓGICA</option>
                                            <option>ENFERMEDAD ONCOLÓGICA</option>
                                            <option>ENFERMEDAD INFECCIOSA</option>
                                            <option>ENFERMEDAD HEREDITARIA / CONGÉNITA</option>
                                            <option>DISCAPACIDADES</option>
                                            <option>OTROS</option>
                                        </select>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_anteFamiliares" BorderStyle="None" style="width:100%" TextMode="MultiLine" Rows="4"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                    <asp:TextBox runat="server" ID="txt_anteFamiliaresDes" BorderStyle="None" style="width:100%" TextMode="MultiLine" Rows="4"></asp:TextBox>
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
                        <asp:TextBox runat="server" ID="txt_enfeActual" BorderStyle="None" style="width:100%" TextMode="MultiLine" Rows="4"></asp:TextBox>
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
                                <asp:TableCell Text="ÓRGANOS  Y SISTEMAS" style="width: 350px"></asp:TableCell>
                                <asp:TableCell Text="EVIDENCIA PATOLÓGICA" style="width: 350px"></asp:TableCell>
                                <asp:TableCell Text="DESCRIPCIÓN" style="width: 600px"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="Órganos de los Sentidos"></asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <select class="form-control" id="exampleFormControlSelect2" style="width:100%; text-align:center; border:none">
                                            <option selected>Seleccione...</option>
                                            <option>Sin Patología</option>
                                            <option>Con Patología</option>
                                        </select>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="Respiratorio"></asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <select class="form-control" id="exampleFormControlSelect3" style="width:100%; text-align:center; border:none">
                                            <option selected>Seleccione...</option>
                                            <option>Sin Patología</option>
                                            <option>Con Patología</option>
                                        </select>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="Cardio Vascular"></asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <select class="form-control" id="exampleFormControlSelect4" style="width:100%; text-align:center; border:none">
                                            <option selected>Seleccione...</option>
                                            <option>Sin Patología</option>
                                            <option>Con Patología</option>
                                        </select>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="Digestivo"></asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <select class="form-control" id="exampleFormControlSelect5" style="width:100%; text-align:center; border:none">
                                            <option selected>Seleccione...</option>
                                            <option>Sin Patología</option>
                                            <option>Con Patología</option>
                                        </select>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="Genital"></asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <select class="form-control" id="exampleFormControlSelect6" style="width:100%; text-align:center; border:none">
                                            <option selected>Seleccione...</option>
                                            <option>Sin Patología</option>
                                            <option>Con Patología</option>
                                        </select>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="Urinario"></asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <select class="form-control" id="exampleFormControlSelect7" style="width:100%; text-align:center; border:none">
                                            <option selected>Seleccione...</option>
                                            <option>Sin Patología</option>
                                            <option>Con Patología</option>
                                        </select>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="Muscular"></asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <select class="form-control" id="exampleFormControlSelect8" style="width:100%; text-align:center; border:none">
                                            <option selected>Seleccione...</option>
                                            <option>Sin Patología</option>
                                            <option>Con Patología</option>
                                        </select>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="Esquelético"></asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <select class="form-control" id="exampleFormControlSelect9" style="width:100%; text-align:center; border:none">
                                            <option selected>Seleccione...</option>
                                            <option>Sin Patología</option>
                                            <option>Con Patología</option>
                                        </select>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="Nervioso"></asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <select class="form-control" id="exampleFormControlSelect10" style="width:100%; text-align:center; border:none">
                                            <option selected>Seleccione...</option>
                                            <option>Sin Patología</option>
                                            <option>Con Patología</option>
                                        </select>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="Endocrino"></asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <select class="form-control" id="exampleFormControlSelect11" style="width:100%; text-align:center; border:none">
                                            <option selected>Seleccione...</option>
                                            <option>Sin Patología</option>
                                            <option>Con Patología</option>
                                        </select>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="Hemo Linfático"></asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <select class="form-control" id="exampleFormControlSelect12" style="width:100%; text-align:center; border:none">
                                            <option selected>Seleccione...</option>
                                            <option>Sin Patología</option>
                                            <option>Con Patología</option>
                                        </select>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Text="Tegumentario (Piel y Faneras)"></asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <select class="form-control" id="exampleFormControlSelect13" style="width:100%; text-align:center; border:none">
                                            <option selected>Seleccione...</option>
                                            <option>Sin Patología</option>
                                            <option>Con Patología</option>
                                        </select>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
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
                        <div class="container">
                            <asp:Table CssClass="table table-bordered table-light" runat="server">
                                <asp:TableRow>
                                    <asp:TableCell Style="width: 100px" Text="FECHA:"></asp:TableCell>
                                    <asp:TableCell style="background-color: white">
                                            <asp:TextBox runat="server" ID="txt_fecha" BorderStyle="None" style="width:100%" TextMode="Date"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell Text="PROFESIONAL:"></asp:TableCell>
                                    <asp:TableCell style="background-color: white">
                                            <asp:TextBox runat="server" ID="txt_profesional" BorderStyle="None" style="width:100%"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell Text="ESPECIALIDAD:"></asp:TableCell>
                                    <asp:TableCell style="background-color: white">
                                            <asp:TextBox runat="server" ID="txt_especialidad" BorderStyle="None" style="width:100%"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </div>
                        <div class="container" style="padding-top: 10px">
                            <asp:Table CssClass="table table-bordered" runat="server">
                                <asp:TableRow>
                                    <asp:TableCell Style="width: auto" Text="FC"></asp:TableCell>
                                    <asp:TableCell Style="width: 75px;">
                                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell Style="width: auto" Text="Pr. Sist."></asp:TableCell>
                                    <asp:TableCell Style="width: 75px;">
                                            <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell Style="width: auto" Text="Pr. Med."></asp:TableCell>
                                    <asp:TableCell Style="width: 75px;">
                                           <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell Style="width: auto" Text="Temp."></asp:TableCell>
                                    <asp:TableCell Style="width: 75px;">
                                           <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell Style="width: auto" Text="Pr. Diast."></asp:TableCell>
                                    <asp:TableCell Style="width: 75px;">
                                            <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                            <br />
                            <asp:Table CssClass="table table-bordered" runat="server">
                                <asp:TableRow>
                                    <asp:TableCell Style="width: auto" Text="FC"></asp:TableCell>
                                    <asp:TableCell Style="width: 75px">
                                            <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell Style="width: auto" Text="Pr. Sist."></asp:TableCell>
                                    <asp:TableCell Style="width: 75px">
                                            <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell Style="width: auto" Text="Pr. Med."></asp:TableCell>
                                    <asp:TableCell Style="width: 75px">
                                           <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell Style="width: auto" Text="Temp."></asp:TableCell>
                                    <asp:TableCell Style="width: 75px">
                                           <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell Style="width: auto" Text="Pr. Diast."></asp:TableCell>
                                    <asp:TableCell Style="width: 75px; text-align: center">
                                           <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%; text-align:center"></asp:TextBox>
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
                                <asp:TableCell Text="EXAMEN/REGIÓN ANATÓMICA" style="width: 300px"></asp:TableCell>
                                <asp:TableCell Text="EVIDENCIA PATOLÓGICA" style="width: 300px"></asp:TableCell>
                                <asp:TableCell Text="DESCRIPCIÓN" style="width: 700px"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell style="background-color: white">
                                    <select class="form-control" id="exampleFormControlSelect14" style="width:100%; text-align:center; border:none">
                                        <option selected>Seleccione...</option>
                                        <option>Piel</option>
                                        <option>Ojos</option>
                                        <option>Oido</option>
                                        <option>Oro faringe</option>
                                        <option>Nariz</option>
                                        <option>Cuello</option>
                                        <option>Tórax</option>
                                        <option>Tórax 2</option>
                                        <option>Abdomen</option>
                                        <option>Columna</option>
                                        <option>Pelvis</option>
                                        <option>Extremidades</option>
                                        <option>Neurológico</option>
                                    </select>                                        
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell style="background-color: white">
                                    <select class="form-control" id="exampleFormControlSelect15" style="width:100%; text-align:center; border:none">
                                        <option selected>Seleccione...</option>
                                        <option>Piel</option>
                                        <option>Ojos</option>
                                        <option>Oido</option>
                                        <option>Oro faringe</option>
                                        <option>Nariz</option>
                                        <option>Cuello</option>
                                        <option>Tórax</option>
                                        <option>Tórax 2</option>
                                        <option>Abdomen</option>
                                        <option>Columna</option>
                                        <option>Pelvis</option>
                                        <option>Extremidades</option>
                                        <option>Neurológico</option>
                                    </select>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%" TextMode="MultiLine" Rows="3"></asp:TextBox>
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
                                <asp:TableCell style="background-color: white">
                                <asp:TextBox runat="server" BorderStyle="None" style="width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                <asp:TextBox runat="server" BorderStyle="None" style="width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                <asp:TextBox runat="server" BorderStyle="None" style="width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                <asp:TextBox runat="server" BorderStyle="None" style="width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                <asp:TextBox runat="server" BorderStyle="None" style="width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                <asp:TextBox runat="server" BorderStyle="None" style="width:100%; text-align:center"></asp:TextBox>
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
                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%" TextMode="MultiLine" Rows="4"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        10. EVOLUCIÓN
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%" TextMode="MultiLine" Rows="4"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="card-header">
                        11. PRESCRIPCIONES
                    </div>
                    <div class="list-group list-group-flush">
                        <asp:TextBox runat="server" BorderStyle="None" style="background-color:transparent; width:100%" TextMode="MultiLine" Rows="4"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="card" style="width: auto;">
                    <div class="list-group list-group-flush" style="padding: 10px;">
                        <asp:Table class="table table-bordered table-light text-center" Style="text-align: center" runat="server">
                            <asp:TableRow>
                                <asp:TableCell Text="FECHA"></asp:TableCell>
                                <asp:TableCell Text="HORA"></asp:TableCell>
                                <asp:TableCell Text="ESPECIALIDAD"></asp:TableCell>
                                <asp:TableCell Text="NOMBRE DEL PROFESIONAL"></asp:TableCell>
                                <asp:TableCell Text="CÓDIGO"></asp:TableCell>
                                <asp:TableCell Text="FIRMA" Style="width: 150px"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell style="background-color: white">
                                        <asp:TextBox runat="server" ID="txt_fecha2" BorderStyle="None" style="width:100%; text-align:center" TextMode="Date"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <asp:TextBox runat="server" ID="txt_hora" BorderStyle="None" style="width:100%; text-align:center" TextMode="Time"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell style="background-color: white">
                                        <asp:TextBox runat="server" BorderStyle="None" style="width:100%; text-align:center"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell Style="width: 150px; background-color: white"></asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
                <br />
                <div class="container" align="center">
                    <asp:Button CssClass="btn btn-primary" ID="btn_guardar" runat="server" Text="Guardar" OnClick="btn_guardar_Click"/>
                    <asp:Button CssClass="btn btn-secondary" ID="btn_cancelar" runat="server" Text="Cancelar" OnClick="btn_cancelar_Click"/>
                </div>
                <br />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
