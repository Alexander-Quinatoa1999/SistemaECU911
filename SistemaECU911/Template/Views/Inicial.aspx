<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Views/Principal.Master" AutoEventWireup="true" CodeBehind="Inicial.aspx.cs" Inherits="SistemaECU911.Template.Views.Inicial" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 1000px;
        }
        .auto-style4 {
            width: 1049px;
        }
        .auto-style7 {
            width: 311px;
        }
        .auto-style8 {
            width: 188px;
        }
        .auto-style9 {
            width: 236px;
        }
        .auto-style10 {
            width: 448px;
        }
        .auto-style11 {
            width: 235px;
        }
        .auto-style12 {
            width: 163px;
        }
        .auto-style13 {
            width: 169px;
        }
        .auto-style15 {
            width: 94px;
        }
        .auto-style18 {
            width: 160px;
        }
        .auto-style19 {
            width: 164px;
        }
        .auto-style22 {
            width: 214px;
        }
        .auto-style25 {
            width: 198px;
        }
        .auto-style27 {
            width: 180px;
        }
        .auto-style31 {
            width: 49px;
        }
        .auto-style32 {
            width: 51px;
        }
        .auto-style33 {
            width: 48px;
        }
        .auto-style34 {
            width: 62px;
        }
        .auto-style35 {
            width: 61px;
        }
        .auto-style40 {
            width: 135px;
        }
        .auto-style41 {
            width: 134px;
        }
        .auto-style42 {
            width: 120px;
        }
        .auto-style43 {
            width: 287px;
        }
        .auto-style44 {
            width: 281px;
        }
        .auto-style49 {
            width: 200px;
        }
        .auto-style51 {
            width: 109px;
        }
        .auto-style53 {
            width: 280px;
        }
        .auto-style54 {
            width: 474px;
        }
        .auto-style59 {
            width: 80px;
        }
        .auto-style60 {
            width: 39px;
        }
        .auto-style61 {
            width: 69px;
        }
        .auto-style63 {
            width: 203px;
        }
        .auto-style64 {
            width: 131px;
        }
        .auto-style68 {
            width: 284px;
        }
        .auto-style75 {
            width: 93px;
        }
        .auto-style78 {
            width: 361px;
        }
        .auto-style79 {
            width: 398px;
        }
        .auto-style81 {
            width: 149px;
        }
        .auto-style83 {
            width: 66px;
        }
        .auto-style84 {
            width: 161px;
        }
        .auto-style87 {
            width: 256px;
        }
        .auto-style91 {
            width: 513px;
        }
        .auto-style92 {
            width: 45px;
        }
        .auto-style93 {
            width: 103px;
        }
        .auto-style99 {
            width: 763px;
        }
        .auto-style100 {
            width: 908px;
        }
        .auto-style102 {
            width: 1053px;
        }
        .auto-style103 {
            width: 2px;
        }
        .auto-style104 {
            width: 35px;
        }
        .auto-style106 {
            width: 301px;
        }
        .auto-style107 {
            width: 150px;
        }
        .auto-style108 {
            width: 258px;
        }
        .auto-style109 {
            width: 152px;
        }
        .auto-style110 {
            width: 268px;
        }
        .auto-style111 {
            width: 244px;
        }
        .auto-style112 {
            width: 331px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="main-panel" style="width:auto">
                <div class="content-wrapper">
                    <div style="text-align: center">
                        <h4>GESTIÓN DE SEGURIDAD Y SALUD OCUPACIONAL</h4>
                    </div>
                    <div style="text-align: center">
                        <h5>HISTORIA CLÍNICA OCUPACIONAL - INICIAL</h5>
                    </div>
                    <br />
                    <div>
                        <!--Datos de las empresa  y usuario-->
                        <div class="card bg-transparent">
                            <div class="card-body">
                                <h5 class="card text-dark bg-light mb-3">A. DATOS DEL ESTABLECIMIENTO - EMPRESA Y USUARIO
                                </h5>
                                <div class="table-responsive" style="width:auto">
                                    <table>
                                        <thead>
                                            <tr>
                                                <td style="width:auto" class="auto-style15">Nombre de la empresa</td>
                                                <td style="width:auto" class="auto-style10">Ruc</td>
                                                <td style="width:auto" class="auto-style10">CIIU</td>
                                                <td style="width:auto" class="auto-style12">Establecimiento de salud</td>
                                                <td style="width:auto" class="auto-style10">Nº historia clínica</td>
                                                <td style="width:auto" class="auto-style10">Nº de Archivo</td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td class="auto-style15">
                                                    <asp:TextBox ID="txt_empresa" runat="server" Width="287px">Servicio Integrado de Seguridad</asp:TextBox></td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_ruc" Text="1768174880001" runat="server" Width="150px">1768174880001</asp:TextBox></td>
                                                <td class="auto-style13">
                                                    <asp:TextBox ID="txt_ciiu" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style12">
                                                    <asp:TextBox ID="txt_establecimiento" Text="CONSULTORIO MÉDICO" runat="server" Width="200px">Consultorio Médico</asp:TextBox></td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_hclinica" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_narchivo" runat="server" Width="150px"></asp:TextBox></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                    <br />
                                    <table>
                                        <thead>
                                            <tr>
                                                <td class="auto-style78">Cédula</td>
                                                <td class="auto-style79">Primer Apellido</td>
                                                <td class="auto-style10">Segundo Apellido</td>
                                                <td class="auto-style10">Primer Nombre</td>
                                                <td class="auto-style10">Segundo Nombre</td>
                                                <td class="auto-style10">Sexo</td>
                                                <td class="auto-style10">Edad</td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td class="auto-style78">
                                                    <asp:TextBox ID="txt_ced" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style79">
                                                    <asp:TextBox ID="txt_priapellido" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_secapellido" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_prinombre" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_secnombre" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_sexo" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_edad" runat="server" Width="150px"></asp:TextBox></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                    <br />
                                    <table>
                                        <thead>
                                            <tr>
                                                <td class="auto-style10">Religión</td>
                                                <td class="auto-style10">Grupo Sanguíneo</td>
                                                <td class="auto-style10">Lateralidad</td>
                                                <td class="auto-style10">Orientación Sexual</td>
                                                <td class="auto-style32">Identidad de Género</td>
                                                <td class="auto-style33">Discapacidad</td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_religion" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style19">
                                                    <asp:TextBox ID="txt_gruposanguineo" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_lateralidad" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style18">
                                                    <asp:TextBox ID="txt_orsexual" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style32">
                                                    <asp:TextBox ID="txt_idengenero" runat="server" Width="180px"></asp:TextBox></td>
                                                <td class="auto-style33">
                                                    <asp:TextBox ID="txt_discap" runat="server" Width="290px"></asp:TextBox></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                    <br />
                                    <table>
                                        <thead>
                                            <tr>
                                                <td class="auto-style35">Fecha de ingreso al trabajo</td>
                                                <td class="auto-style35">Puesto de trabajo (CIUO)</td>
                                                <td class="auto-style34">Área de trabajo</td>
                                                <td class="auto-style31">Actividades relevantes al puesto de trabajo a ocupar</td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td class="auto-style35">
                                                    <asp:TextBox ID="txt_fecha" runat="server" Width="200px"></asp:TextBox></td>
                                                <td class="auto-style35">
                                                    <asp:TextBox ID="txt_puesto" runat="server" Width="200px"></asp:TextBox></td>
                                                <td class="auto-style34">
                                                    <asp:TextBox ID="txt_area" runat="server" Width="226px"></asp:TextBox></td>
                                                <td class="auto-style31">
                                                    <asp:TextBox ID="txt_actividad" runat="server" Width="465px"></asp:TextBox></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <!--Motivo de Consulta-->
                        <div class="card bg-transparent">
                            <div class="card-body">
                                <h5 class="card text-dark bg-light mb-3">B. MOTIVO DE CONSULTA
                                </h5>
                                <div class="table-responsive">
                                    <table class="auto-style3" >
                                        <thead>
                                            <tr>
                                                <td class="auto-style15">Descripción</td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td>
                                                    <textarea id="txt_descrip" rows="3" class="auto-style4"></textarea>
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <!--Antecedentes personales-->
                        <div class="card bg-transparent">
                            <div class="card-body">
                                <h5 class="card text-dark bg-light mb-3">C. ANTECEDENTES PERSONALES
                                </h5>
                                <div class="table-responsive">
                                    <h5>ANTECEDENTES CLÍNICOS Y QUIRÚRGICOS</h5>
                                    <table>
                                        <thead>
                                            <tr>
                                                <td class="auto-style15">Descripción</td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td>
                                                    <textarea id="txt_desant" rows="3" class="auto-style4"></textarea>
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                    <br />
                                    <h5>ANTECEDENTES GINECO OBSTÉTRICOS</h5>
                                    <table>
                                        <thead>
                                            <tr>
                                                <td class="auto-style10">Menarquía</td>
                                                <td class="auto-style10">Ciclos</td>
                                                <td class="auto-style10">Fecha de ultima menstruación</td>
                                                <td class="auto-style10">Gestas</td>
                                                <td class="auto-style10">Partos</td>
                                                <td class="auto-style10">Cesáreas</td>
                                                <td class="auto-style10">Abortos</td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_menaquia" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_ciclos" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_fechamenst" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_gestas" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_partos" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_cesareas" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_abortos" runat="server" Width="150px"></asp:TextBox></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                    <table>
                                        <thead>
                                            <tr>
                                                <td class="auto-style22">Hijos</td>
                                                <td class="auto-style49">Vida Sexual Activa</td>
                                                <td class="auto-style53">Método de planificación familiar</td>
                                                <td></td>
                                            </tr>
                                        </thead>
                                    </table>
                                    <table>
                                        <thead>
                                            <tr>
                                                <td class="auto-style60">Vivos</td>
                                                <td class="auto-style61">Muertos</td>
                                                <td class="auto-style64">Seleccione</td>
                                                <td class="auto-style59">Seleccione</td>
                                                <td class="auto-style54">Tipo</td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td class="auto-style60">
                                                    <asp:TextBox ID="txt_vivo" runat="server" Width="50px"></asp:TextBox></td>
                                                <td class="auto-style61">
                                                    <asp:TextBox ID="txt_muerto" runat="server" Width="65px"></asp:TextBox></td>
                                                <td class="auto-style64">
                                                    <select id="sl_option1" class="auto-style51">
                                                        <option>Si</option>
                                                        <option>No</option>
                                                    </select>
                                                </td>
                                                <td class="auto-style59">
                                                    <select id="sl_optin2" class="auto-style68">
                                                        <option>Si</option>
                                                        <option>No</option>
                                                    </select></td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_metodo" runat="server" Width="404px"></asp:TextBox></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                    <br />
                                    <h5>Exámenes Realizados</h5>
                                    <table>
                                        <thead>
                                            <tr>
                                                <td class="auto-style40">Papanicolaou</td>
                                                <td class="auto-style27">Tiempo</td>
                                                <td class="auto-style41">Colposcopia</td>
                                                <td class="auto-style27">Tiempo</td>
                                                <td class="auto-style42">Eco Mamario</td>
                                                <td class="auto-style27">Tiempo</td>
                                                <td class="auto-style63">Mamografía</td>
                                                <td class="auto-style35">Tiempo</td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td class="auto-style40">
                                                    <select id="sl_papa" class="auto-style81">
                                                        <option>Si</option>
                                                        <option>No</option>
                                                    </select>
                                                </td>
                                                <td class="auto-style27">
                                                    <asp:TextBox ID="txt_tiempopapa" runat="server" Width="105px"></asp:TextBox></td>
                                                <td class="auto-style41">
                                                    <select id="sl_colp" class="auto-style81">
                                                        <option>Si</option>
                                                        <option>No</option>
                                                    </select>
                                                </td>
                                                <td class="auto-style27">
                                                    <asp:TextBox ID="txt_tiempocolp" runat="server" Width="105px"></asp:TextBox></td>
                                                <td class="auto-style42">
                                                    <select id="sl_eco" class="auto-style81">
                                                        <option>Si</option>
                                                        <option>No</option>
                                                    </select>
                                                </td>
                                                <td class="auto-style27">
                                                    <asp:TextBox ID="txt_tiempoeco" runat="server" Width="105px"></asp:TextBox></td>
                                                <td class="auto-style63">
                                                    <select id="sl_mamo" class="auto-style34">
                                                        <option>Si</option>
                                                        <option>No</option>
                                                    </select>
                                                </td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_tiempomamo" runat="server" Width="105px"></asp:TextBox></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                    <table>
                                        <thead>
                                            <tr>
                                                <td class="auto-style112">Resultados</td>
                                                <td class="auto-style43">Resultados</td>
                                                <td class="auto-style44">Resultados</td>
                                                <td class="auto-style75">Resultados</td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td class="auto-style112">
                                                    <textarea id="txt_res1" rows="2" class="auto-style106"></textarea></td>
                                                <td class="auto-style43">
                                                    <textarea id="txt_res2" rows="2" class="auto-style87"></textarea></td>
                                                <td class="auto-style44">
                                                    <textarea id="txt_res3" rows="2" class="auto-style87"></textarea></td>
                                                <td class="auto-style75">
                                                    <textarea id="txt_res4" rows="2" class="auto-style87"></textarea></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                    <br />
                                    <h5>ANTECEDENTES REPRODUCTIVOS MASCULINOS</h5>
                                    <h5>Exámenes Realizados</h5>
                                    <table>
                                        <thead>
                                            <tr>
                                                <td class="auto-style104">Ant. Prostático</td>
                                                <td class="auto-style93">Tiempo</td>
                                                <td class="auto-style92">Eco Prostático</td>
                                                <td class="auto-style103">Tiempo</td>
                                                <td class="auto-style25">Método de planificacion familiar</td>                                               
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td class="auto-style104">
                                                    <select id="sl_antigeno" class="auto-style84">
                                                        <option>Si</option>
                                                        <option>No</option>
                                                    </select>
                                                </td>
                                                <td class="auto-style93">
                                                    <asp:TextBox ID="TextBox1" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style41">
                                                    <select id="sl_ecopro" class="auto-style84">
                                                        <option>Si</option>
                                                        <option>No</option>
                                                    </select>
                                                </td>
                                                <td class="auto-style103">
                                                    <asp:TextBox ID="TextBox4" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style41">
                                                    <select id="sl_metoplan" class="auto-style84">
                                                        <option>Si</option>
                                                        <option>No</option>
                                                    </select>
                                                </td>                                               
                                            </tr>
                                        </tbody>
                                    </table>
                                    <table>
                                        <thead>
                                            <tr>
                                                <td class="auto-style102">Resultados</td>
                                                <td class="auto-style100">Resultados</td>
                                                <td class="auto-style91">Tipo</td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td class="auto-style102">
                                                    <textarea id="txt_resantigeno" rows="3" class="auto-style7"></textarea></td>
                                                <td class="auto-style100">
                                                    <textarea id="txt_resecopro" rows="3" class="auto-style7"></textarea></td>
                                                <td class="auto-style10">
                                                    <textarea id="txt_metoplan" rows="3" class="auto-style7"></textarea></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                    <br />
                                    <h5>Hábitos Tóxicos</h5>
                                    <table>
                                        <thead>
                                            <tr>
                                                <td class="auto-style118">Consumos Nocivos</td>
                                                <td></td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td class="auto-style118">Tabaco</td>
                                                <td class="auto-style115">Tiempo de consumo</td>
                                                <td class="auto-style116">Cantidad</td>
                                                <td class="auto-style117">Exconsumidor</td>
                                                <td class="auto-style106">Tiempo de abstinencia</td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style118">
                                                    <select id="sl_tabaco" class="auto-style119">
                                                        <option>Si</option>
                                                        <option>No</option>
                                                    </select>
                                                </td>
                                                <td class="auto-style115">
                                                    <asp:TextBox ID="txt_tiempoconsumo" runat="server" Width="208px"></asp:TextBox></td>
                                                <td class="auto-style116">
                                                    <asp:TextBox ID="txt_cantconsumo" runat="server" Width="208px"></asp:TextBox></td>
                                                <td class="auto-style117">
                                                    <asp:TextBox ID="txt_exconsumidor" runat="server" Width="208px"></asp:TextBox></td>
                                                <td class="auto-style99">
                                                    <asp:TextBox ID="txt_tiempoabstinencia" runat="server" Width="208px"></asp:TextBox></td>
                                            </tr>
                                        </tbody>
                                        <tbody>
                                            <tr>
                                                <td class="auto-style118">Alcohol</td>
                                                <td class="auto-style115">Tiempo de consumo</td>
                                                <td class="auto-style116">Cantidad</td>
                                                <td class="auto-style117">Exconsumidor</td>
                                                <td class="auto-style106">Tiempo de abstinencia</td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style118">
                                                    <select id="sl_alcohol" class="auto-style119">
                                                        <option>Si</option>
                                                        <option>No</option>
                                                    </select>
                                                </td>
                                                <td class="auto-style115">
                                                    <asp:TextBox ID="txt_tiempoalcohol" runat="server" Width="208px"></asp:TextBox></td>
                                                <td class="auto-style116">
                                                    <asp:TextBox ID="txt_cantidadalcohol" runat="server" Width="208px"></asp:TextBox></td>
                                                <td class="auto-style117">
                                                    <asp:TextBox ID="txt_exconsalcohol" runat="server" Width="208px"></asp:TextBox></td>
                                                <td class="auto-style99">
                                                    <asp:TextBox ID="txt_tieabtalcohol" runat="server" Width="208px"></asp:TextBox></td>
                                            </tr>
                                        </tbody>
                                        <tbody>
                                            <tr>
                                                <td class="auto-style118">Otra droga</td>
                                                <td class="auto-style115">Tiempo de consumo</td>
                                                <td class="auto-style116">Cantidad</td>
                                                <td class="auto-style117">Exconsumidor</td>
                                                <td class="auto-style106">Tiempo de abstinencia</td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style115">
                                                    <asp:TextBox ID="txt_otra" runat="server" Width="208px"></asp:TextBox></td>
                                                <td class="auto-style115">
                                                    <asp:TextBox ID="txt_tempootra" runat="server" Width="208px"></asp:TextBox></td>
                                                <td class="auto-style116">
                                                    <asp:TextBox ID="txt_cantidaotra" runat="server" Width="208px"></asp:TextBox></td>
                                                <td class="auto-style117">
                                                    <asp:TextBox ID="txt_exconotra" runat="server" Width="208px"></asp:TextBox></td>
                                                <td class="auto-style99">
                                                    <asp:TextBox ID="txt_tiempootra" runat="server" Width="208px"></asp:TextBox></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                    <br />
                                    <h5>Estilo de Vida</h5>
                                    <table>
                                        <thead>
                                            <tr>
                                                <td class="auto-style8">Estilo</td>
                                                <td class="auto-style9"></td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td class="auto-style8">Actividad Física</td>
                                                <td class="auto-style9">¿Cuál?</td>
                                                <td class="auto-style11">Tiempo</td>
                                                <td class="auto-style117">Cantidad</td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style8">
                                                    <select id="sl_actividadfisica" class="auto-style119">
                                                        <option>Si</option>
                                                        <option>No</option>
                                                    </select>
                                                </td>
                                                <td class="auto-style9">
                                                    <asp:TextBox ID="txt_cualact" runat="server" Width="208px"></asp:TextBox></td>
                                                <td class="auto-style11">
                                                    <asp:TextBox ID="txt_tiempoact" runat="server" Width="208px"></asp:TextBox></td>
                                                <td class="auto-style117">
                                                    <asp:TextBox ID="txt_cantidadact" runat="server" Width="208px"></asp:TextBox></td>
                                            </tr>
                                        </tbody>
                                        <tbody>
                                            <tr>
                                                <td class="auto-style8">Medicación Habitual</td>
                                                <td class="auto-style9">¿Cuál?</td>
                                                <td class="auto-style11">Tiempo</td>
                                                <td class="auto-style117">Cantidad</td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style8">
                                                    <select id="sl_medicahab" class="auto-style119">
                                                        <option>Si</option>
                                                        <option>No</option>
                                                    </select>
                                                </td>
                                                <td class="auto-style9">
                                                    <asp:TextBox ID="txt_cualmed" runat="server" Width="208px"></asp:TextBox></td>
                                                <td class="auto-style11">
                                                    <asp:TextBox ID="txt_tiempomed" runat="server" Width="208px"></asp:TextBox></td>
                                                <td class="auto-style117">
                                                    <asp:TextBox ID="txt_cantidadmed" runat="server" Width="208px"></asp:TextBox></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <!--Antecedentes de trabajo-->
                        <div class="card bg-transparent">
                            <div class="card-body">
                                <h5 class="card text-dark bg-light mb-3">D. ANTECEDENTES DE TRABAJO
                                </h5>
                                <div class="table-responsive">
                                    <h5>ANTECEDENTES DE EMPLEOS ANTERIORES</h5>
                                    <table>
                                        <thead>
                                            <tr>
                                                <td class="auto-style10">Empresa</td>
                                                <td class="auto-style10">Puesto de Trabajo</td>
                                                <td class="auto-style10">Act. que desempeña</td>
                                                <td class="auto-style10">Tiempo de Trabajo</td>
                                                <td class="auto-style10">Riesgo</td>
                                                <td class="auto-style10">Observaciones</td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_nomempresa" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_puesttra" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_actvdes" runat="server" Width="157px"></asp:TextBox></td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_tiempotra" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style118">
                                                    <select id="sl_riesgotra" class="auto-style119">
                                                        <option>Físico</option>
                                                        <option>Mecánico</option>
                                                        <option>Químico</option>
                                                        <option>Biólogo</option>
                                                        <option>Ergonómico</option>
                                                        <option>Psicosocial</option>
                                                    </select>
                                                </td>
                                                <td class="auto-style31">
                                                    <asp:TextBox ID="txt_obervtra" runat="server" Width="345px"></asp:TextBox></td>
                                            </tr>
                                        </tbody>
                                        <tbody>
                                            <tr>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_nomempresa2" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_puesttra2" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_actvdes2" runat="server" Width="157px"></asp:TextBox></td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_tiempotra2" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style118">
                                                    <select id="sl_riesgotra2" class="auto-style119">
                                                        <option>Físico</option>
                                                        <option>Mecánico</option>
                                                        <option>Químico</option>
                                                        <option>Biólogo</option>
                                                        <option>Ergonómico</option>
                                                        <option>Psicosocial</option>
                                                    </select>
                                                </td>
                                                <td class="auto-style31">
                                                    <asp:TextBox ID="TextBox7" runat="server" Width="345px"></asp:TextBox></td>
                                            </tr>
                                        </tbody>
                                        <tbody>
                                            <tr>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_nomempresa3" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_puesttra3" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_actvdes3" runat="server" Width="157px"></asp:TextBox></td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_tiempotra3" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style118">
                                                    <select id="sl_riesgotra3" class="auto-style119">
                                                        <option>Físico</option>
                                                        <option>Mecánico</option>
                                                        <option>Químico</option>
                                                        <option>Biólogo</option>
                                                        <option>Ergonómico</option>
                                                        <option>Psicosocial</option>
                                                    </select>
                                                </td>
                                                <td class="auto-style31">
                                                    <asp:TextBox ID="TextBox12" runat="server" Width="345px"></asp:TextBox></td>
                                            </tr>
                                        </tbody>
                                        <tbody>
                                            <tr>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_nomempresa4" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_puesttra4" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_actvdes4" runat="server" Width="157px"></asp:TextBox></td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_tiempotra4" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style118">
                                                    <select id="sl_riesgotra4" class="auto-style119">
                                                        <option>Físico</option>
                                                        <option>Mecánico</option>
                                                        <option>Químico</option>
                                                        <option>Biólogo</option>
                                                        <option>Ergonómico</option>
                                                        <option>Psicosocial</option>
                                                    </select>
                                                </td>
                                                <td class="auto-style31">
                                                    <asp:TextBox ID="TextBox17" runat="server" Width="345px"></asp:TextBox></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                                <br />
                                <h5>ACCIDENTES DE TRABAJO (DESCRIPCIÓN)</h5>
                                <h6>FUE CALIFICADO POR EL INSTITUTO DE SEGURIDAD SOCIAL CORRESPONDIENTE:</h6>
                                <table>
                                    <thead>
                                        <tr>
                                            <td class="auto-style83"></td>
                                            <td class="auto-style83">Especificar (en caso de seleccionar si)</td>
                                            <td class="auto-style58">Fecha</td>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td class="auto-style83">
                                                <select id="sl_acctra" class="auto-style119">
                                                    <option>Si</option>
                                                    <option>No</option>
                                                </select>
                                            </td>
                                            <td class="auto-style31">
                                                <asp:TextBox ID="txt_especif" runat="server" Width="345px"></asp:TextBox></td>
                                            <td class="auto-style31">
                                                <asp:TextBox ID="txt_fechatraba" runat="server" Width="241px"></asp:TextBox></td>
                                        </tr>
                                    </tbody>
                                </table>
                                <table>
                                    <thead>
                                        <tr>
                                            <td class="auto-style15">Observaciones</td>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td>
                                                <textarea id="txt_obsaccidente" rows="3" class="auto-style4"></textarea>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                                <h5>ENFERMEDADES PROFESIONALES</h5>
                                <h6>FUE CALIFICADO POR EL INSTITUTO DE SEGURIDAD SOCIAL CORRESPONDIENTE:</h6>
                                <table>
                                    <thead>
                                        <tr>
                                            <td class="auto-style83"></td>
                                            <td class="auto-style83">Especificar (en caso de seleccionar si)</td>
                                            <td class="auto-style58">Fecha</td>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td class="auto-style118">
                                                <select id="sl_enfpro" class="auto-style119">
                                                    <option>Si</option>
                                                    <option>No</option>
                                                </select>
                                            </td>
                                            <td class="auto-style31">
                                                <asp:TextBox ID="txt_espprof" runat="server" Width="345px"></asp:TextBox></td>
                                            <td class="auto-style31">
                                                <asp:TextBox ID="txt_fechaprof" runat="server" Width="241px"></asp:TextBox></td>
                                        </tr>
                                    </tbody>
                                </table>
                                <table>
                                    <thead>
                                        <tr>
                                            <td class="auto-style15">Observaciones</td>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td>
                                                <textarea id="txt_obsprof" rows="3" class="auto-style4"></textarea>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
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
