<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Views/Principal.Master" AutoEventWireup="true" CodeBehind="Inicial.aspx.cs" Inherits="SistemaECU911.Template.Views.Inicial" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 1256px;
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
                        <div class="card">
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
                        <div class="card">
                            <div class="card-body">
                                <h5 class="card text-dark bg-light mb-3">B. MOTIVO DE CONSULTA
                                </h5>
                                <div class="table-responsive">
                                    <table>
                                        <thead>
                                            <tr>
                                                <td class="auto-style15">Descripción</td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td>
                                                    <textarea id="txt_descrip" rows="3" class="auto-style1"></textarea>
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <!--Antecedentes personales-->
                        <div class="card">
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
                                                    <textarea id="txt_desant" rows="3" class="auto-style1"></textarea>
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
                                                <td class="auto-style93">Hijos</td>
                                                <td class="auto-style92">Vida Sexual Activa</td>
                                                <td class="auto-style35">Método de planificación familiar</td>
                                            </tr>
                                        </thead>
                                    </table>
                                    <table>
                                        <thead>
                                            <tr>
                                                <td class="auto-style53">Vivos</td>
                                                <td class="auto-style55">Muertos</td>
                                                <td class="auto-style64">Seleccione</td>
                                                <td class="auto-style66">Seleccione</td>
                                                <td class="auto-style54">Tipo</td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td class="auto-style52">
                                                    <asp:TextBox ID="txt_vivo" runat="server" Width="50px"></asp:TextBox></td>
                                                <td class="auto-style63">
                                                    <asp:TextBox ID="txt_muerto" runat="server" Width="65px"></asp:TextBox></td>
                                                <td class="auto-style65">
                                                    <select id="sl_option1" class="auto-style68">
                                                        <option>Si</option>
                                                        <option>No</option>
                                                    </select>
                                                </td>
                                                <td class="auto-style67">
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
                                                <td class="auto-style83">Papanicolaou</td>
                                                <td class="auto-style84">Tiempo</td>
                                                <td class="auto-style63">Colposcopia</td>
                                                <td class="auto-style84">Tiempo</td>
                                                <td class="auto-style63">Eco Mamario</td>
                                                <td class="auto-style84">Tiempo</td>
                                                <td class="auto-style63">Mamografía</td>
                                                <td class="auto-style35">Tiempo</td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td class="auto-style83">
                                                    <select id="sl_papa" class="auto-style81">
                                                        <option>Si</option>
                                                        <option>No</option>
                                                    </select>
                                                </td>
                                                <td class="auto-style84">
                                                    <asp:TextBox ID="txt_tiempopapa" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style63">
                                                    <select id="sl_colp" class="auto-style81">
                                                        <option>Si</option>
                                                        <option>No</option>
                                                    </select>
                                                </td>
                                                <td class="auto-style84">
                                                    <asp:TextBox ID="txt_tiempocolp" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style63">
                                                    <select id="sl_eco" class="auto-style81">
                                                        <option>Si</option>
                                                        <option>No</option>
                                                    </select>
                                                </td>
                                                <td class="auto-style84">
                                                    <asp:TextBox ID="txt_tiempoeco" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style63">
                                                    <select id="sl_mamo" class="auto-style81">
                                                        <option>Si</option>
                                                        <option>No</option>
                                                    </select>
                                                </td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_tiempomamo" runat="server" Width="150px"></asp:TextBox></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                    <table>
                                        <thead>
                                            <tr>
                                                <td class="auto-style94">Resultados</td>
                                                <td class="auto-style99">Resultados</td>
                                                <td class="auto-style100">Resultados</td>
                                                <td class="auto-style75">Resultados</td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td class="auto-style94">
                                                    <textarea id="txt_res1" rows="2" class="auto-style87"></textarea></td>
                                                <td class="auto-style99">
                                                    <textarea id="txt_res2" rows="2" class="auto-style95"></textarea></td>
                                                <td class="auto-style100">
                                                    <textarea id="txt_res3" rows="2" class="auto-style97"></textarea></td>
                                                <td class="auto-style75">
                                                    <textarea id="txt_res4" rows="2" class="auto-style88"></textarea></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                    <br />
                                    <h5>ANTECEDENTES REPRODUCTIVOS MASCULINOS</h5>
                                    <h5>Exámenes Realizados</h5>
                                    <table>
                                        <thead>
                                            <tr>
                                                <td class="auto-style120">Ant. Prostático</td>
                                                <td class="auto-style110">Tiempo</td>
                                                <td class="auto-style106">Eco Prostático</td>
                                                <td class="auto-style84">Tiempo</td>
                                                <td class="auto-style84">Método de planificacion familiar</td>
                                                <td class="auto-style84">Tipo</td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td class="auto-style120">
                                                    <select id="sl_antigeno" class="auto-style81">
                                                        <option>Si</option>
                                                        <option>No</option>
                                                    </select>
                                                </td>
                                                <td class="auto-style110">
                                                    <asp:TextBox ID="TextBox1" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style106">
                                                    <select id="sl_ecopro" class="auto-style81">
                                                        <option>Si</option>
                                                        <option>No</option>
                                                    </select>
                                                </td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="TextBox4" runat="server" Width="150px"></asp:TextBox></td>
                                                <td class="auto-style106">
                                                    <select id="sl_metoplan" class="auto-style81">
                                                        <option>Si</option>
                                                        <option>No</option>
                                                    </select>
                                                </td>
                                                <td class="auto-style10">
                                                    <asp:TextBox ID="txt_metoplan" runat="server" Width="150px"></asp:TextBox></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                    <table>
                                        <thead>
                                            <tr>
                                                <td class="auto-style99">Resultados</td>
                                                <td class="auto-style99">Resultados</td>
                                                <td></td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td class="auto-style99">
                                                    <textarea id="txt_resantigeno" rows="2" class="auto-style105"></textarea></td>
                                                <td class="auto-style99">
                                                    <textarea id="txt_resecopro" rows="2" class="auto-style114"></textarea></td>
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
                                                <td class="auto-style118">Estilo</td>
                                                <td></td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td class="auto-style118">Actividad Física</td>
                                                <td class="auto-style115">¿Cuál?</td>
                                                <td class="auto-style116">Tiempo</td>
                                                <td class="auto-style117">Cantidad</td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style118">
                                                    <select id="sl_actividadfisica" class="auto-style119">
                                                        <option>Si</option>
                                                        <option>No</option>
                                                    </select>
                                                </td>
                                                <td class="auto-style115">
                                                    <asp:TextBox ID="txt_cualact" runat="server" Width="208px"></asp:TextBox></td>
                                                <td class="auto-style116">
                                                    <asp:TextBox ID="txt_tiempoact" runat="server" Width="208px"></asp:TextBox></td>
                                                <td class="auto-style117">
                                                    <asp:TextBox ID="txt_cantidadact" runat="server" Width="208px"></asp:TextBox></td>
                                            </tr>
                                        </tbody>
                                        <tbody>
                                            <tr>
                                                <td class="auto-style118">Medicación Habitual</td>
                                                <td class="auto-style115">¿Cuál?</td>
                                                <td class="auto-style116">Tiempo</td>
                                                <td class="auto-style117">Cantidad</td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style118">
                                                    <select id="sl_medicahab" class="auto-style119">
                                                        <option>Si</option>
                                                        <option>No</option>
                                                    </select>
                                                </td>
                                                <td class="auto-style115">
                                                    <asp:TextBox ID="txt_cualmed" runat="server" Width="208px"></asp:TextBox></td>
                                                <td class="auto-style116">
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
                        <div class="card">
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
                                            <td></td>
                                            <td class="auto-style118">Especificar (en caso de seleccionar si)</td>
                                            <td class="auto-style118">Fecha</td>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td class="auto-style118">
                                                <select id="sl_acctra" class="auto-style119">
                                                    <option>Si</option>
                                                    <option>No</option>
                                                </select>
                                            </td>
                                            <td class="auto-style31">
                                                <asp:TextBox ID="txt_especif" runat="server" Width="345px"></asp:TextBox></td>
                                            <td class="auto-style31">
                                                <asp:TextBox ID="txt_fechatraba" runat="server" Width="345px"></asp:TextBox></td>
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
                                                <textarea id="txt_obsaccidente" rows="3" class="auto-style1"></textarea>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                                <h5>ENFERMEDADES PROFESIONALES</h5>
                                <h6>FUE CALIFICADO POR EL INSTITUTO DE SEGURIDAD SOCIAL CORRESPONDIENTE:</h6>
                                <table>
                                    <thead>
                                        <tr>
                                            <td></td>
                                            <td class="auto-style118">Especificar (en caso de seleccionar si)</td>
                                            <td class="auto-style118">Fecha</td>
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
                                                <asp:TextBox ID="txt_fechaprof" runat="server" Width="345px"></asp:TextBox></td>
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
                                                <textarea id="txt_obsprof" rows="3" class="auto-style1"></textarea>
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
