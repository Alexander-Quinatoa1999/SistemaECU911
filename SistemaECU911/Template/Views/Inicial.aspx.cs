using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaNegocio;

namespace SistemaECU911.Template.Views
{
	public partial class Inicial : System.Web.UI.Page
	{

		DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        //Objeto de la tabla motivo de consulta
        private Tbl_AntecedentesCliQuiru antcliqui = new Tbl_AntecedentesCliQuiru();
        //Objeto de la tabla ANTECEDENTES DE EMPLEOS ANTERIORES
        private Tbl_AntecedentesEmplAnteriores emplant = new Tbl_AntecedentesEmplAnteriores();
        //Objeto de la tabla ACCIDENTES DE TRABAJO (DESCRIPCIÓN)
        private Tbl_AccidentesTrabajoDesc acctrabajo = new Tbl_AccidentesTrabajoDesc();
        //Objeto de la tabla ENFERMEDADES PROFESIONALES 
        private Tbl_EnfermedadesProfesionales enferprof = new Tbl_EnfermedadesProfesionales();
        //Objeto de la tabla RIESGO DEL PUESTO DE TRABAJO ACTUAL
        private Tbl_FacRiesTrabAct facriesgotractual = new Tbl_FacRiesTrabAct();
        //Objeto de la tabla ACTIVIDADES EXTRA LABORALES
        private Tbl_ActividadesExtraLaborales actvextralaboral = new Tbl_ActividadesExtraLaborales();
        //Objeto de la tabla RESULTADO DE EXAMENES GENERALES Y ESPECIFICOS DE ACUERDO AL RIESGO Y PUESTO DE TRABAJO
        private Tbl_ResExaGenEspRiesTrabajo exagenesperiespues = new Tbl_ResExaGenEspRiesTrabajo();
        //Objeto de la tabla DIAGNÓSTICO
        private Tbl_Diagnostico diagnostico = new Tbl_Diagnostico();
        //Objeto de la tabla APTITUD MÉDICA PARA EL TRABAJO
        private Tbl_AptitudMedica aptitudmedica = new Tbl_AptitudMedica();

        protected void Page_Load(object sender, EventArgs e)
		{
            
		}

        private void GuardarHistorial()
        {
            try
            {
                //Guardar Persona D - F - G - L - M - N
                if (string.IsNullOrEmpty(txt_empresa.Text) || string.IsNullOrEmpty(txt_puestotrabajo.Text) || string.IsNullOrEmpty(txt_actdesempeña.Text) ||
                    string.IsNullOrEmpty(txt_tiempotrabajo.Text) || string.IsNullOrEmpty(txt_fisico.Text) || string.IsNullOrEmpty(txt_mecanico.Text) || 
                    string.IsNullOrEmpty(txt_quimico.Text) || string.IsNullOrEmpty(txt_biologico.Text) || string.IsNullOrEmpty(txt_ergonomico.Text) ||
                    string.IsNullOrEmpty(txt_psicosocial.Text) || string.IsNullOrEmpty(txt_observaciones1.Text) || 

                    /*string.IsNullOrEmpty(txt_si.Text) || string.IsNullOrEmpty(txt_especificar.Text) || string.IsNullOrEmpty(txt_no.Text) || 
                    string.IsNullOrEmpty(txt_fecha.Text) || string.IsNullOrEmpty(txt_observaciones2.Text) || 

                    string.IsNullOrEmpty(txt_siprofesional.Text) || string.IsNullOrEmpty(txt_espeprofesional.Text) || string.IsNullOrEmpty(txt_noprofesional.Text) || 
                    string.IsNullOrEmpty(txt_fechaprofesional.Text) || string.IsNullOrEmpty(txt_observaciones3.Text) ||*/

                    string.IsNullOrEmpty(txt_puestodetrabajo.Text) || string.IsNullOrEmpty(txt_act.Text) || string.IsNullOrEmpty(txt_tempaltas.Text) ||
                    string.IsNullOrEmpty(txt_atrapmaquinas.Text) || string.IsNullOrEmpty(txt_solidos.Text) ||

                    string.IsNullOrEmpty(txt_puestodetrabajo2.Text) || string.IsNullOrEmpty(txt_act2.Text) || string.IsNullOrEmpty(txt_virus.Text) ||
                    string.IsNullOrEmpty(txt_manmanualcargas.Text) || string.IsNullOrEmpty(txt_montrabajo.Text) || string.IsNullOrEmpty(txt_medpreventivas.Text) ||

                    string.IsNullOrEmpty(txt_descrextralaborales.Text) ||

                    string.IsNullOrEmpty(txt_examen.Text) || string.IsNullOrEmpty(txt_fechaexamen.Text) || string.IsNullOrEmpty(txt_resultadoexamen.Text) ||
                    string.IsNullOrEmpty(txt_observacionexamen.Text) ||

                    string.IsNullOrEmpty(txt_descripdiagnostico.Text) ||  string.IsNullOrEmpty(txt_pre.Text) || string.IsNullOrEmpty(txt_def.Text) ||

                    string.IsNullOrEmpty(txt_apto.Text) || string.IsNullOrEmpty(txt_observacionaptitud.Text) || string.IsNullOrEmpty(txt_limitacionaptitud.Text))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Complete los campos')", true);
                }
                else
                {
                    //antcliqui = new Tbl_AntecedentesCliQuiru();
                    emplant = new Tbl_AntecedentesEmplAnteriores();
                    acctrabajo = new Tbl_AccidentesTrabajoDesc();
                    enferprof = new Tbl_EnfermedadesProfesionales();
                    facriesgotractual = new Tbl_FacRiesTrabAct();
                    actvextralaboral = new Tbl_ActividadesExtraLaborales();
                    exagenesperiespues = new Tbl_ResExaGenEspRiesTrabajo();
                    diagnostico = new Tbl_Diagnostico();
                    aptitudmedica = new Tbl_AptitudMedica();

                    //captura de datos tbl_motivoconsulta
                    //antcliqui.AntCliQuiru_descripcion = txt_antCliQuiDescripcion.Text;

                    //captura de datos Tbl_AntecedentesEmplAnteriores 
                    emplant.AntEmpAnte_nomEmpresa = txt_empresa.Text;
                    emplant.AntEmpAnte_puestoTrabajo = txt_puestotrabajo.Text;
                    emplant.AntEmpAnte_actDesemp = txt_actdesempeña.Text;
                    emplant.AntEmpAnte_tiemTrabajo = Convert.ToInt32(txt_tiempotrabajo.Text);
                    emplant.AntEmpAnte_nomEmpresa = txt_fisico.Text;
                    emplant.AntEmpAnte_nomEmpresa = txt_mecanico.Text;
                    emplant.AntEmpAnte_nomEmpresa = txt_quimico.Text;
                    emplant.AntEmpAnte_nomEmpresa = txt_biologico.Text;
                    emplant.AntEmpAnte_nomEmpresa = txt_ergonomico.Text;
                    emplant.AntEmpAnte_nomEmpresa = txt_psicosocial.Text;
                    emplant.AntEmpAnte_nomEmpresa = txt_observaciones1.Text;

                    //captura de datos Tbl_AccidentesTrabajoDesc

                    //captura de datos Tbl_EnfermedadesProfesionales

                    //captura de datos Tbl_FacRiesTrabAct
                    facriesgotractual.FacRiesTrabAct_area = txt_puestodetrabajo.Text;
                    facriesgotractual.FacRiesTrabAct_actividades = txt_act.Text;
                    facriesgotractual.FacRiesTrabAct_temAltasFis = txt_tempaltas.Text;
                    facriesgotractual.FacRiesTrabAct_atraMaquinasMec = txt_atrapmaquinas.Text;
                    facriesgotractual.FacRiesTrabAct_solidosQui = txt_solidos.Text;
                    facriesgotractual.FacRiesTrabAct_virusBio = txt_virus.Text;
                    facriesgotractual.FacRiesTrabAct_maneManCarErg = txt_manmanualcargas.Text;
                    facriesgotractual.FacRiesTrabAct_monoTrabPsi = txt_montrabajo.Text;
                    facriesgotractual.FacRiesTrabAct_medPreventivas = txt_medpreventivas.Text;

                    //captura de datos Tbl_ActividadesExtraLaborales
                    actvextralaboral.ActExtLab_descrip = txt_descrextralaborales.Text;

                    //captura de datos Tbl_ResExaGenEspRiesTrabajo
                    exagenesperiespues.ResExaGenEspRiesTrabajo_examen = txt_examen.Text;
                    exagenesperiespues.ResExaGenEspRiesTrabajo_fecha = Convert.ToDateTime(txt_fechaexamen.Text);
                    exagenesperiespues.ResExaGenEspRiesTrabajo_resultados = txt_resultadoexamen.Text;
                    exagenesperiespues.ResExaGenEspRiesTrabajo_observaciones = txt_observacionexamen.Text;

                    //captura de datos Tbl_Diagnostico
                    diagnostico.Diag_descripcion = txt_descripdiagnostico.Text;
                    diagnostico.Diag_pre = txt_pre.Text;
                    diagnostico.Diag_def = txt_def.Text;

                    //captura de datos Tbl_AptitudMedica
                    aptitudmedica.AptMed_apto = txt_apto.Text;
                    aptitudmedica.AptMed_aptoObserva = txt_observacionaptitud.Text;
                    aptitudmedica.AptMed_aptoLimi = txt_limitacionaptitud.Text;

                    //metodo de guardar Antec. Empleados Anteriores
                    CN_Inicial.guardarEmpleAnteriores(emplant);

                    //metodo de guardar Accid. de trabajo
                    //metodo de guardar Enfer. Profesionales

                    //metodo de guardar Riesgo Puesto Trabajo Actual
                    CN_Inicial.guardarRiesgoPuesTrabaActual(facriesgotractual);

                    //metodo de guardar Actividad Extra Laboral
                    CN_Inicial.guardarActivextralaboral(actvextralaboral);

                    //metodo de guardar Resul. Exam. General y Espec de acuerdo al Riesgo y puesto de trabajo
                    CN_Inicial.guardarExaGenEspeRiesyPues(exagenesperiespues);

                    //metodo de guardar Diagnostico
                    CN_Inicial.guardarDiagnostico(diagnostico);

                    //metodo de guardar Aptitud Medica
                    CN_Inicial.guardarAptiMediTrabajo(aptitudmedica);

                    //metodo de guardar motivo de consulta
                    //CN_Inicial.guardarAntCliniQuirur(antcliqui);                    

                    //Mensaje de confirmacion
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Guardados Exitosamente')", true);

                    Response.Redirect("~/Template/Views/Pacientes.aspx");
                    limpiar();

                }

            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Guardados')", true);
            }

        }

        private void limpiar()
        {
            txt_antCliQuiDescripcion.Text = "";
            txt_empresa.Text = txt_puestotrabajo.Text = txt_actdesempeña.Text = txt_tiempotrabajo.Text = txt_fisico.Text = txt_mecanico.Text=
            txt_quimico.Text = txt_biologico.Text = txt_ergonomico.Text = txt_psicosocial.Text = txt_observaciones1.Text = txt_si.Text =
            txt_especificar.Text = txt_no.Text = txt_fecha.Text = txt_observaciones2.Text = txt_siprofesional.Text = txt_espeprofesional.Text =
            txt_noprofesional.Text = txt_fechaprofesional.Text = txt_observaciones3.Text = txt_puestodetrabajo.Text = txt_act.Text = 
            txt_tempaltas.Text = txt_atrapmaquinas.Text = txt_solidos.Text = txt_puestodetrabajo2.Text = txt_act2.Text = txt_virus.Text = 
            txt_manmanualcargas.Text = txt_montrabajo.Text = txt_medpreventivas.Text = txt_descrextralaborales.Text = txt_examen.Text = 
            txt_fechaexamen.Text = txt_resultadoexamen.Text = txt_observacionexamen.Text = txt_descripdiagnostico.Text = txt_pre.Text = 
            txt_def.Text = txt_apto.Text = txt_observacionaptitud.Text = txt_limitacionaptitud.Text = "";

        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            GuardarHistorial();
        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/Views/Inicio.aspx");
        }
    }
}