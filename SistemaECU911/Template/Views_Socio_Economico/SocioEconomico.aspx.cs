using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaNegocio;
using HtmlAgilityPack;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace SistemaECU911.Template.Views_Socio_Economico
{
    public partial class SocioEconomico : System.Web.UI.Page
    {

        DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        private Tbl_Personas per = new Tbl_Personas();

        private Tbl_SocioEconomico sso = new Tbl_SocioEconomico();

        protected void Page_Load(object sender, EventArgs e)
        {
            tabladiscapacidad.Visible = false;
            tabladependencia.Visible = false;
            tablaacargofamiliar.Visible = false;
            tabladatosdiscapacidad.Visible = false;
            tbc_tipodiscapacidad.Visible = false;
            tbc_txtdiscapacidad.Visible = false;
            tbl_estadogestacion.Visible = false;

            if (!IsPostBack)
            {
                if (Request["cod"] != null)
                {
                    int codigo = Convert.ToInt32(Request["cod"]);
                    sso = CN_SocioEconomico.ObtenerSocioEconomicoPorId(codigo);
                    int idsso = Convert.ToInt32(sso.Per_id.ToString());
                    per = CN_HistorialMedico.ObtenerPersonasxId(idsso);

                    btn_guardar.Text = "Actualizar";

                    if (per != null)
                    {
                        txt_cedula.Text = per.Per_cedula.ToString();
                        txt_priapellido.Text = per.Per_priApellido.ToString();
                        txt_segapellido.Text = per.Per_segApellido.ToString();
                        txt_prinombre.Text = per.Per_priNombre.ToString();
                        txt_segnombre.Text = per.Per_segNombre.ToString();
                        txt_areatrabajo.Text = per.Per_areaTrabajo.ToString();
                        txt_cargoinstitucional.Text = per.Per_cargoOcupacion.ToString();
                        txt_fechaingresoalsisecu.Text = Convert.ToDateTime(per.Per_fechInicioTrabajo).ToString("yyyy-MM-dd");
                        txt_fechanacimiento.Text = Convert.ToDateTime(per.Per_fechaNacimiento).ToString("yyyy-MM-dd");
                        DateTime edad = Convert.ToDateTime(per.Per_fechaNacimiento);
                        DateTime naci = Convert.ToDateTime(edad);
                        DateTime actual = DateTime.Now;
                        Calculo(naci, actual);

                        if (sso != null)
                        {
                            txt_fecharegistro.Text = sso.Socio_economico_fechaHora.ToString();

                            //Datos código y versión
                            txt_codigoinicio.Text = sso.Socio_economico_codigo_inicial.ToString();
                            txt_version.Text = sso.Socio_economico_version.ToString();

                            //Datos Generales
                            txt_tipodesangre.Text = sso.Socio_economico_tipo_de_sangre.ToString();

                            txt_telconvecional.Text = sso.Socio_economico_telefono_convencional.ToString();
                            txt_telcelular.Text = sso.Socio_economico_telefono_celular.ToString();
                            txt_email.Text = sso.Socio_economico_email.ToString();

                            txt_lugarnacimiento.Text = sso.Socio_economico_lugar_nacimiento.ToString();

                            txt_provincia.Text = sso.Socio_economico_direcciondomicilio_provincia.ToString();
                            txt_canton.Text = sso.Socio_economico_direcciondomicilio_canton.ToString();
                            txt_parroquia.Text = sso.Socio_economico_direcciondomicilio_parroquia.ToString();
                            txt_barrio.Text = sso.Socio_economico_direcciondomicilio_barrio.ToString();

                            txt_calleubicada.Text = sso.Socio_economico_calle_vivienda_numeracion.ToString();
                            txt_callesecundaria.Text = sso.Socio_economico_calle_secundaria.ToString();
                            txt_refubicardomicilio.Text = sso.Socio_economico_referencia_ubicar_domicilio.ToString();

                            txt_tipoviviendaotro.Text = sso.Socio_economico_tipovivienda_otro_indique.ToString();

                            txt_emernomyape.Text = sso.Socio_economico_contacto_emergencia_nombres_apellidos.ToString();
                            txt_emeparentesco.Text = sso.Socio_economico_contacto_emergencia_parentesco.ToString();
                            txt_emetelefono.Text = sso.Socio_economico_contacto_emergencia_telefono.ToString();
                            txt_emecalleprincipal.Text = sso.Socio_economico_contacto_emergencia_calle_principal.ToString();
                            txt_emenumdomicilio.Text = sso.Socio_economico_contacto_emergencia_numero_domicilio.ToString();
                            txt_emecallesecun.Text = sso.Socio_economico_contacto_emergencia_calle_secundaria.ToString();
                            txt_emerefubicardomicilio.Text = sso.Socio_economico_contacto_emergencia_referencia_domicilio.ToString();

                            txt_movilizatrabajoovivienda.Text = sso.Socio_economico_moviliza_trabajo_vivienda.ToString();

                            //Salud
                            txt_poseeenfermedadprexistente.Text = sso.Socio_economico_posee_enfermedad.ToString();
                            txt_tipodiscapacidad.Text = sso.Socio_economico_discapacidad_tipo.ToString();
                            txt_porcentajediscapacidad.Text = sso.Socio_economico_discapacidad_porcentaje.ToString();
                            txt_numcarnetconadis.Text = sso.Socio_economico_discapacidad_carnet_conadis.ToString();
                            //txt_fechacaducidadcarnet.Text = sso.Socio_economico_discapacidad_fecha_caducidad_carnet.ToString();
                            if (sso.Socio_economico_discapacidad_fecha_caducidad_carnet == "")
                            {
                                txt_fechacaducidadcarnet.Text = sso.Socio_economico_discapacidad_fecha_caducidad_carnet.ToString();
                            }
                            else
                            {
                                txt_fechacaducidadcarnet.Text = Convert.ToDateTime(sso.Socio_economico_discapacidad_fecha_caducidad_carnet).ToString("yyyy-MM-dd");
                            }

                            txt_gestacióntiempo.Text = sso.Socio_economico_estado_gestacion_tiempo.ToString();
                            //txt_fechatentativaparto.Text = sso.Socio_economico_fecha_tentativa_parto.ToString();
                            if (sso.Socio_economico_fecha_tentativa_parto == "")
                            {
                                txt_fechatentativaparto.Text = sso.Socio_economico_fecha_tentativa_parto.ToString();
                            }
                            else
                            {
                                txt_fechatentativaparto.Text = Convert.ToDateTime(sso.Socio_economico_fecha_tentativa_parto).ToString("yyyy-MM-dd");
                            }
                            //txt_fechaculmicacionlactancia.Text = sso.Socio_economico_periodo_lactancia_fecha_culminacion.ToString();
                            if (sso.Socio_economico_periodo_lactancia_fecha_culminacion == "")
                            {
                                txt_fechaculmicacionlactancia.Text = sso.Socio_economico_periodo_lactancia_fecha_culminacion.ToString();
                            }
                            else
                            {
                                txt_fechaculmicacionlactancia.Text = Convert.ToDateTime(sso.Socio_economico_periodo_lactancia_fecha_culminacion).ToString("yyyy-MM-dd");
                            }

                            txt_cualcatastrofica.Text = sso.Socio_economico_enfermedad_cronica_cual.ToString();
                            txt_otrasenfermedadescat.Text = sso.Socio_economico_enfermedad_cronica_otras_enfermedades.ToString();
                            txt_enfermedadraracual.Text = sso.Socio_economico_enfermedad_rara_cual.ToString();

                            txt_causaconsumoalcohol.Text = sso.Socio_economico_consume_alcohol_causa.ToString();
                            txt_tiempoconsumoalcohol.Text = sso.Socio_economico_consume_alcohol_tiempo_consumo.ToString();
                            txt_frecuenciaconsumotabaco.Text = sso.Socio_economico_consume_tabaco_frecuencia_consumo.ToString();
                            txt_tiempoconsumotabaco.Text = sso.Socio_economico_consume_tabaco_tiempo_consumo.ToString();
                            txt_sustanciapsicotropicatipo.Text = sso.Socio_economico_consume_sustancia_psicotropica_tipo.ToString();
                            txt_sustanciapsicotropicafrecuencia.Text = sso.Socio_economico_consume_sustancia_psicotropica_frecuencia_consumo.ToString();

                            //Situacion económica del servidor
                            txt_miembroactivoseconomicamente.Text = sso.Socio_economico_numero_miembro_economicamente_activos.ToString();

                            txt_totalingresos1.Text = sso.Socio_economico_total_ingresos_mensuales_proyectados_1.ToString();
                            txt_ayuda1.Text = sso.Socio_economico_ayuda1.ToString();
                            txt_otros1.Text = sso.Socio_economico_otros1.ToString();
                            txt_alimentación.Text = sso.Socio_economico_total_egresos_alimentacion.ToString();

                            txt_totalingresos2.Text = sso.Socio_economico_total_ingresos_mensuales_proyectados_2.ToString();
                            txt_ayuda2.Text = sso.Socio_economico_ayuda2.ToString();
                            txt_otros2.Text = sso.Socio_economico_otros2.ToString();
                            txt_vivienda.Text = sso.Socio_economico_total_egresos_vivienda.ToString();

                            txt_totalingresos3.Text = sso.Socio_economico_total_ingresos_mensuales_proyectados_3.ToString();
                            txt_ayuda3.Text = sso.Socio_economico_ayuda3.ToString();
                            txt_otros3.Text = sso.Socio_economico_otros3.ToString();
                            txt_educación.Text = sso.Socio_economico_total_egresos_educacion.ToString();

                            txt_totalingresos4.Text = sso.Socio_economico_total_ingresos_mensuales_proyectados_4.ToString();
                            txt_ayuda4.Text = sso.Socio_economico_ayuda4.ToString();
                            txt_otros4.Text = sso.Socio_economico_otros4.ToString();
                            txt_serviciosbasicos.Text = sso.Socio_economico_total_egresos_servicios_basicos.ToString();

                            txt_totalingresos5.Text = sso.Socio_economico_total_ingresos_mensuales_proyectados_5.ToString();
                            txt_ayuda5.Text = sso.Socio_economico_ayuda5.ToString();
                            txt_otros5.Text = sso.Socio_economico_otros5.ToString();
                            txt_salud.Text = sso.Socio_economico_total_egresos_salud.ToString();

                            txt_totalingresos6.Text = sso.Socio_economico_total_ingresos_mensuales_proyectados_6.ToString();
                            txt_ayuda6.Text = sso.Socio_economico_ayuda6.ToString();
                            txt_otros6.Text = sso.Socio_economico_otros6.ToString();
                            txt_movilización.Text = sso.Socio_economico_total_egresos_movilizacion.ToString();

                            txt_totalingresos7.Text = sso.Socio_economico_total_ingresos_mensuales_proyectados_7.ToString();
                            txt_ayuda7.Text = sso.Socio_economico_ayuda7.ToString();
                            txt_otros7.Text = sso.Socio_economico_otros7.ToString();
                            txt_deudas.Text = sso.Socio_economico_total_egresos_deudas.ToString();

                            txt_totalingresos8.Text = sso.Socio_economico_total_ingresos_mensuales_proyectados_8.ToString();
                            txt_ayuda8.Text = sso.Socio_economico_ayuda8.ToString();
                            txt_otros8.Text = sso.Socio_economico_otros8.ToString();
                            txt_otrospensiones.Text = sso.Socio_economico_total_egresos_pensiones_otros.ToString();

                            txt_totalingresos9.Text = sso.Socio_economico_total_ingresos_mensuales_proyectados_total_9.ToString();
                            txt_totalayudayotros9.Text = sso.Socio_economico_ayuda_y_otros_total_9.ToString();
                            txt_totalegresos.Text = sso.Socio_economico_total_egresos_total_9.ToString();

                            txt_biencasa.Text = sso.Socio_economico_descripcion_mueble_valor_casa.ToString();
                            txt_biendepartamento.Text = sso.Socio_economico_descripcion_mueble_valor_departamento.ToString();
                            txt_bienvehiculo.Text = sso.Socio_economico_descripcion_mueble_valor_vehiculo.ToString();
                            txt_bienterreno.Text = sso.Socio_economico_descripcion_mueble_valor_terreno.ToString();
                            txt_bienegocio.Text = sso.Socio_economico_descripcion_mueble_valor_negocio.ToString();
                            txt_bienmueblesyenseres.Text = sso.Socio_economico_descripcion_mueble_valor_muebles_enseres.ToString();

                            txt_otrodescripcionviviendafamilia.Text = sso.Socio_economico_caracteristica_vivienda_descripcion_otra_especifique.ToString();
                            txt_otratenencia.Text = sso.Socio_economico_caracteristica_vivienda_tenencia_otra_especifique.ToString();
                            txt_otrotipodecasa.Text = sso.Socio_economico_caracteristica_vivienda_tipo_otro_especifique.ToString();
                            txt_otradistribucioncasa.Text = sso.Socio_economico_caracteristica_vivienda_distribucion_otro_especifique.ToString();
                            txt_otrainformacioncasa.Text = sso.Socio_economico_caracteristica_vivienda_otro_especifique.ToString();

                            //Información Familiar
                            txt_nomapellidos1.Text = sso.Socio_economico_nombres_apellidos_familiar1.ToString();
                            txt_parentesco1.Text = sso.Socio_economico_parentesco_familiar1.ToString();
                            //txt_fechanacimiento1.Text = sso.Socio_economico_fecha_nacimiento_familiar1.ToString();
                            if (sso.Socio_economico_fecha_nacimiento_familiar1 == "")
                            {
                                txt_fechanacimiento1.Text = sso.Socio_economico_fecha_nacimiento_familiar1.ToString();
                            }
                            else
                            {
                                txt_fechanacimiento1.Text = Convert.ToDateTime(sso.Socio_economico_fecha_nacimiento_familiar1).ToString("yyyy-MM-dd");
                            }
                            txt_edad1.Text = sso.Socio_economico_edad_familiar1.ToString();

                            txt_nomapellidos2.Text = sso.Socio_economico_nombres_apellidos_familiar2.ToString();
                            txt_parentesco2.Text = sso.Socio_economico_parentesco_familiar2.ToString();
                            //txt_fechanacimiento2.Text = sso.Socio_economico_fecha_nacimiento_familiar2.ToString();
                            if (sso.Socio_economico_fecha_nacimiento_familiar2 == "")
                            {
                                txt_fechanacimiento2.Text = sso.Socio_economico_fecha_nacimiento_familiar2.ToString();
                            }
                            else
                            {
                                txt_fechanacimiento2.Text = Convert.ToDateTime(sso.Socio_economico_fecha_nacimiento_familiar2).ToString("yyyy-MM-dd");
                            }
                            txt_edad2.Text = sso.Socio_economico_edad_familiar2.ToString();

                            txt_nomapellidos3.Text = sso.Socio_economico_nombres_apellidos_familiar3.ToString();
                            txt_parentesco3.Text = sso.Socio_economico_parentesco_familiar3.ToString();
                            //txt_fechanacimiento3.Text = sso.Socio_economico_fecha_nacimiento_familiar3.ToString();
                            if (sso.Socio_economico_fecha_nacimiento_familiar3 == "")
                            {
                                txt_fechanacimiento3.Text = sso.Socio_economico_fecha_nacimiento_familiar3.ToString();
                            }
                            else
                            {
                                txt_fechanacimiento3.Text = Convert.ToDateTime(sso.Socio_economico_fecha_nacimiento_familiar3).ToString("yyyy-MM-dd");
                            }
                            txt_edad3.Text = sso.Socio_economico_edad_familiar3.ToString();

                            txt_nomapellidos4.Text = sso.Socio_economico_nombres_apellidos_familiar4.ToString();
                            txt_parentesco4.Text = sso.Socio_economico_parentesco_familiar4.ToString();
                            //txt_fechanacimiento4.Text = sso.Socio_economico_fecha_nacimiento_familiar4.ToString();
                            if (sso.Socio_economico_fecha_nacimiento_familiar4 == "")
                            {
                                txt_fechanacimiento4.Text = sso.Socio_economico_fecha_nacimiento_familiar4.ToString();
                            }
                            else
                            {
                                txt_fechanacimiento4.Text = Convert.ToDateTime(sso.Socio_economico_fecha_nacimiento_familiar4).ToString("yyyy-MM-dd");
                            }
                            txt_edad4.Text = sso.Socio_economico_edad_familiar4.ToString();

                            txt_nomapellidos5.Text = sso.Socio_economico_nombres_apellidos_familiar5.ToString();
                            txt_parentesco5.Text = sso.Socio_economico_parentesco_familiar5.ToString();
                            //txt_fechanacimiento5.Text = sso.Socio_economico_fecha_nacimiento_familiar5.ToString();
                            if (sso.Socio_economico_fecha_nacimiento_familiar5 == "")
                            {
                                txt_fechanacimiento5.Text = sso.Socio_economico_fecha_nacimiento_familiar5.ToString();
                            }
                            else
                            {
                                txt_fechanacimiento5.Text = Convert.ToDateTime(sso.Socio_economico_fecha_nacimiento_familiar5).ToString("yyyy-MM-dd");
                            }
                            txt_edad5.Text = sso.Socio_economico_edad_familiar5.ToString();

                            txt_familiardiscapacitadonomape1.Text = sso.Socio_economico_nombres_apellidos_familiar_discapacidad1.ToString();
                            //txt_familiardiscapacitadofechacaducidadcarnet1.Text = sso.Socio_economico_fecha_caducidad_carnet_familiar_discapacidad1.ToString();
                            if (sso.Socio_economico_fecha_caducidad_carnet_familiar_discapacidad1 == "")
                            {
                                txt_familiardiscapacitadofechacaducidadcarnet1.Text = sso.Socio_economico_fecha_caducidad_carnet_familiar_discapacidad1.ToString();
                            }
                            else
                            {
                                txt_familiardiscapacitadofechacaducidadcarnet1.Text = Convert.ToDateTime(sso.Socio_economico_fecha_caducidad_carnet_familiar_discapacidad1).ToString("yyyy-MM-dd");
                            }
                            txt_familiardiscapacitadotipodiscapacidad1.Text = sso.Socio_economico_familiar_discapacidad_tipo1.ToString();
                            txt_familiardiscapacitadoporcentajediscapacidad1.Text = sso.Socio_economico_familiar_discapacidad_porcentaje1.ToString();
                            txt_familiardiscapacitadoparentesco1.Text = sso.Socio_economico_familiar_discapacidad_parentesco1.ToString();
                            //txt_familiardiscapacitadofechanacimiento1.Text = sso.Socio_economico_familiar_discapacidad_fecha_nacimiento1.ToString();
                            if (sso.Socio_economico_familiar_discapacidad_fecha_nacimiento1 == "")
                            {
                                txt_familiardiscapacitadofechanacimiento1.Text = sso.Socio_economico_familiar_discapacidad_fecha_nacimiento1.ToString();
                            }
                            else
                            {
                                txt_familiardiscapacitadofechanacimiento1.Text = Convert.ToDateTime(sso.Socio_economico_familiar_discapacidad_fecha_nacimiento1).ToString("yyyy-MM-dd");
                            }

                            txt_familiardiscapacitadonomape2.Text = sso.Socio_economico_nombres_apellidos_familiar_discapacidad2.ToString();
                            //txt_familiardiscapacitadofechacaducidadcarnet2.Text = sso.Socio_economico_fecha_caducidad_carnet_familiar_discapacidad2.ToString();
                            if (sso.Socio_economico_fecha_caducidad_carnet_familiar_discapacidad2 == "")
                            {
                                txt_familiardiscapacitadofechacaducidadcarnet2.Text = sso.Socio_economico_fecha_caducidad_carnet_familiar_discapacidad2.ToString();
                            }
                            else
                            {
                                txt_familiardiscapacitadofechacaducidadcarnet2.Text = Convert.ToDateTime(sso.Socio_economico_fecha_caducidad_carnet_familiar_discapacidad2).ToString("yyyy-MM-dd");
                            }
                            txt_familiardiscapacitadotipodiscapacidad2.Text = sso.Socio_economico_familiar_discapacidad_tipo2.ToString();
                            txt_familiardiscapacitadoporcentajediscapacidad2.Text = sso.Socio_economico_familiar_discapacidad_porcentaje2.ToString();
                            txt_familiardiscapacitadoparentesco2.Text = sso.Socio_economico_familiar_discapacidad_parentesco2.ToString();
                            //txt_familiardiscapacitadofechanacimiento2.Text = sso.Socio_economico_familiar_discapacidad_fecha_nacimiento2.ToString();
                            if (sso.Socio_economico_familiar_discapacidad_fecha_nacimiento2 == "")
                            {
                                txt_familiardiscapacitadofechanacimiento2.Text = sso.Socio_economico_familiar_discapacidad_fecha_nacimiento2.ToString();
                            }
                            else
                            {
                                txt_familiardiscapacitadofechanacimiento2.Text = Convert.ToDateTime(sso.Socio_economico_familiar_discapacidad_fecha_nacimiento2).ToString("yyyy-MM-dd");
                            }

                            txt_dependenciaministeriotrabajotiempo.Text = sso.Socio_economico_registrar_dependencia_familiar_MT_tiempo.ToString();
                            txt_numcarnetMSP.Text = sso.Socio_economico_registrar_dependencia_familiar_MT_numero_carnetMSP.ToString();
                            txt_acargofamiliarenfermedadraratiempo.Text = sso.Socio_economico_a_cargo_familiar_enfermedad_catastrofica_rara_tiempo.ToString();
                            txt_familiarenfermedadraratipo.Text = sso.Socio_economico_a_cargo_familiar_enfermedad_catastrofica_rara_tipoenfermedad.ToString();

                            //Actividad tiempo libre
                            txt_otraactividad.Text = sso.Socio_economico_otro_especifique.ToString();
                            txt_actividadeconomicadetalle.Text = sso.Socio_economico_actividad_economica_adicional_detalle.ToString();
                            txt_actividadeconomicatiempodestina.Text = sso.Socio_economico_actividad_economica_adicional_tiempo_destina.ToString();
                            txt_actividadeconomicatiemporealiza.Text = sso.Socio_economico_actividad_economica_adicional_hace_tiempo.ToString();
                            txt_especifiquedeporte.Text = sso.Socio_economico_actividad_deportiva_especificar.ToString();
                            txt_frecuenciadeporte.Text = sso.Socio_economico_actividad_deportiva_frecuencia.ToString();
                            txt_edadpracticadeporte.Text = sso.Socio_economico_actividad_deportiva_edad.ToString();
                            txt_tipolesion.Text = sso.Socio_economico_lesion_tipo.ToString();
                            txt_edadlesion.Text = sso.Socio_economico_lesion_edad.ToString();

                            //Informacion para uso de bienestar familiar
                            txt_relacionfamiliarporque.Text = sso.Socio_economico_evaluacion_relacion_familiar_porque.ToString();
                            txt_relacionparejaporque.Text = sso.Socio_economico_evaluacion_relacion_pareja_porque.ToString();
                            txt_relacionconhijosporque.Text = sso.Socio_economico_evaluacion_relacion_hijos_porque.ToString();
                            txt_observacionesfamiliares.Text = sso.Socio_economico_problemas_familiares_observaciones.ToString();
                            txt_nivelsaludfamiliarporque.Text = sso.Socio_economico_nivel_salud_familia_porque.ToString();
                            txt_observacionesgenerales.Text = sso.Socio_economico_familia_observaciones.ToString();
                            txt_informacionadicional.Text = sso.Socio_economico_informacion_adicional.ToString();

                            //DATOS GENERALES
                            //Modalidad de Trabajo
                            if (sso.Socio_economico_modalidadvinculacion_leyorgserpublico == null)
                            {
                                cb_modalidadvinculacionlosep.Checked = false;
                            }
                            else
                            {
                                cb_modalidadvinculacionlosep.Checked = true;
                            }
                            if (sso.Socio_economico_modalidadvinculacion_codigotrabajo == null)
                            {
                                cb_modalidadvinculacioncodigotrabajo.Checked = false;
                            }
                            else
                            {
                                cb_modalidadvinculacioncodigotrabajo.Checked = true;
                            }
                            //Estado Civil
                            if (sso.Socio_economico_estadocivil_soltero == null)
                            {
                                cb_soltero.Checked = false;
                            }
                            else
                            {
                                cb_soltero.Checked = true;
                            }
                            if (sso.Socio_economico_estadocivil_casado == null)
                            {
                                cb_casado.Checked = false;
                            }
                            else
                            {
                                cb_casado.Checked = true;
                            }
                            if (sso.Socio_economico_estadocivil_viudo == null)
                            {
                                cb_viudo.Checked = false;
                            }
                            else
                            {
                                cb_viudo.Checked = true;
                            }
                            if (sso.Socio_economico_estadocivil_unionlibre == null)
                            {
                                cb_unionlibre.Checked = false;
                            }
                            else
                            {
                                cb_unionlibre.Checked = true;
                            }
                            if (sso.Socio_economico_estadocivil_divorciado == null)
                            {
                                cb_divorciado.Checked = false;
                            }
                            else
                            {
                                cb_divorciado.Checked = true;
                            }
                            //Genero
                            if (sso.Socio_economico_genero_masculino == null)
                            {
                                cb_genmasculino.Checked = false;
                            }
                            else
                            {
                                cb_genmasculino.Checked = true;
                            }
                            if (sso.Socio_economico_genero_femenino == null)
                            {
                                cb_genfemenino.Checked = false;
                            }
                            else
                            {
                                cb_genfemenino.Checked = true;
                            }
                            //Donante
                            if (sso.Socio_economico_es_donante_si == null)
                            {
                                cb_donantesi.Checked = false;
                            }
                            else
                            {
                                cb_donantesi.Checked = true;
                            }
                            if (sso.Socio_economico_es_donante_no == null)
                            {
                                cb_donanteno.Checked = false;
                            }
                            else
                            {
                                cb_donanteno.Checked = true;
                            }
                            //Nivel de Educación
                            if (sso.Socio_economico_titulo_primaria == null)
                            {
                                cb_primaria.Checked = false;
                            }
                            else
                            {
                                cb_primaria.Checked = true;
                            }
                            if (sso.Socio_economico_titulo_secundaria == null)
                            {
                                cb_secundaria.Checked = false;
                            }
                            else
                            {
                                cb_secundaria.Checked = true;
                            }
                            if (sso.Socio_economico_titulo_superior == null)
                            {
                                cb_superior.Checked = false;
                            }
                            else
                            {
                                cb_superior.Checked = true;
                            }
                            if (sso.Socio_economico_titulo_especializacion == null)
                            {
                                cb_especializacion.Checked = false;
                            }
                            else
                            {
                                cb_especializacion.Checked = true;
                            }
                            if (sso.Socio_economico_titulo_diplomado == null)
                            {
                                cb_diplomado.Checked = false;
                            }
                            else
                            {
                                cb_diplomado.Checked = true;
                            }
                            if (sso.Socio_economico_titulo_maestria == null)
                            {
                                cb_maestria.Checked = false;
                            }
                            else
                            {
                                cb_maestria.Checked = true;
                            }
                            //Autoidentificacion Étnica
                            if (sso.Socio_economico_autoidentificacionetnica_blanco == null)
                            {
                                cb_blanco.Checked = false;
                            }
                            else
                            {
                                cb_blanco.Checked = true;
                            }
                            if (sso.Socio_economico_autoidentificacionetnica_mestizo == null)
                            {
                                cb_mestizo.Checked = false;
                            }
                            else
                            {
                                cb_mestizo.Checked = true;
                            }
                            if (sso.Socio_economico_autoidentificacionetnica_afrodescendiente == null)
                            {
                                cb_afro.Checked = false;
                            }
                            else
                            {
                                cb_afro.Checked = true;
                            }
                            if (sso.Socio_economico_autoidentificacionetnica_indigena == null)
                            {
                                cb_indigena.Checked = false;
                            }
                            else
                            {
                                cb_indigena.Checked = true;
                            }
                            if (sso.Socio_economico_autoidentificacionetnica_montubio == null)
                            {
                                cb_montubio.Checked = false;
                            }
                            else
                            {
                                cb_montubio.Checked = true;
                            }
                            //Sector donde vive
                            if (sso.Socio_economico_sectorvive_norte == null)
                            {
                                cb_norte.Checked = false;
                            }
                            else
                            {
                                cb_norte.Checked = true;
                            }
                            if (sso.Socio_economico_sectorvive_centro == null)
                            {
                                cb_centro.Checked = false;
                            }
                            else
                            {
                                cb_centro.Checked = true;
                            }
                            if (sso.Socio_economico_sectorvive_sur == null)
                            {
                                cb_sur.Checked = false;
                            }
                            else
                            {
                                cb_sur.Checked = true;
                            }

                            if (sso.Socio_economico_sectorvive_valle == null)
                            {
                                cb_valle.Checked = false;
                            }
                            else
                            {
                                cb_valle.Checked = true;
                            }
                            if (sso.Socio_economico_sectorvive_valledeloschillos == null)
                            {
                                cb_valledeloschillos.Checked = false;
                            }
                            else
                            {
                                cb_valledeloschillos.Checked = true;
                            }
                            //Tipo de vivienda
                            if (sso.Socio_economico_tipovivienda_casa == null)
                            {
                                cb_casa.Checked = false;
                            }
                            else
                            {
                                cb_casa.Checked = true;
                            }
                            if (sso.Socio_economico_tipovivienda_departamento == null)
                            {
                                cb_departamento.Checked = false;
                            }
                            else
                            {
                                cb_departamento.Checked = true;
                            }
                            //Riesgo Delincuencial
                            if (sso.Socio_economico_riesgo_delincuencial_alto == null)
                            {
                                cb_riesgoalto.Checked = false;
                            }
                            else
                            {
                                cb_riesgoalto.Checked = true;
                            }
                            if (sso.Socio_economico_riesgo_delincuencial_medio == null)
                            {
                                cb_riesgomedio.Checked = false;
                            }
                            else
                            {
                                cb_riesgomedio.Checked = true;
                            }
                            if (sso.Socio_economico_riesgo_delincuencial_bajo == null)
                            {
                                cb_riesgobajo.Checked = false;
                            }
                            else
                            {
                                cb_riesgobajo.Checked = true;
                            }
                            //Dinero ahorro
                            if (sso.Socio_economico_dinero_ahorro_si == null)
                            {
                                cb_dineroahorrosi.Checked = false;
                            }
                            else
                            {
                                cb_dineroahorrosi.Checked = true;
                            }
                            if (sso.Socio_economico_dinero_ahorro_no == null)
                            {
                                cb_dineroahorrono.Checked = false;
                            }
                            else
                            {
                                cb_dineroahorrono.Checked = true;
                            }
                            //Vehiculo propio
                            if (sso.Socio_economico_vehiculo_propio_si == null)
                            {
                                cb_vehiculosi.Checked = false;
                            }
                            else
                            {
                                cb_vehiculosi.Checked = true;
                            }
                            if (sso.Socio_economico_vehiculo_propio_no == null)
                            {
                                cb_vehiculono.Checked = false;
                            }
                            else
                            {
                                cb_vehiculono.Checked = true;
                            }
                            //Recorrido Institucional
                            if (sso.Socio_economico_recorrido_institucional_si == null)
                            {
                                cb_recorridosi.Checked = false;
                            }
                            else
                            {
                                cb_recorridosi.Checked = true;
                            }
                            if (sso.Socio_economico_recorrido_institucional_no == null)
                            {
                                cb_recorridono.Checked = false;
                            }
                            else
                            {
                                cb_recorridono.Checked = true;
                            }
                            //SALUD
                            //Posee Discapacidad
                            if (sso.Socio_economico_discapacidad_si == null)
                            {
                                cb_discapacidadsi.Checked = false;
                            }
                            else
                            {
                                cb_discapacidadsi.Checked = true;
                            }
                            if (sso.Socio_economico_discapacidad_no == null)
                            {
                                cb_discapacidadno.Checked = false;
                            }
                            else
                            {
                                cb_discapacidadno.Checked = true;
                            }
                            //Gestacion 
                            if (sso.Socio_economico_estado_gestacion_si == null)
                            {
                                cb_gestaciónsi.Checked = false;
                            }
                            else
                            {
                                cb_gestaciónsi.Checked = true;
                            }
                            if (sso.Socio_economico_estado_gestacion_no == null)
                            {
                                cb_gestaciónno.Checked = false;
                            }
                            else
                            {
                                cb_gestaciónno.Checked = true;
                            }
                            //Periodo Lactancia
                            if (sso.Socio_economico_periodo_lactancia_si == null)
                            {
                                cb_lactaciasi.Checked = false;
                            }
                            else
                            {
                                cb_lactaciasi.Checked = true;
                            }
                            if (sso.Socio_economico_periodo_lactancia_no == null)
                            {
                                cb_lactaciano.Checked = false;
                            }
                            else
                            {
                                cb_lactaciano.Checked = true;
                            }
                            //Enfermedad catastrófica
                            if (sso.Socio_economico_enfermedad_cronica_si == null)
                            {
                                cb_catastroficasi.Checked = false;
                            }
                            else
                            {
                                cb_catastroficasi.Checked = true;
                            }
                            if (sso.Socio_economico_enfermedad_cronica_no == null)
                            {
                                cb_catastroficano.Checked = false;
                            }
                            else
                            {
                                cb_catastroficano.Checked = true;
                            }
                            //Enfermedad rara
                            if (sso.Socio_economico_enfermedad_rara_si == null)
                            {
                                cb_enfermedadrarasi.Checked = false;
                            }
                            else
                            {
                                cb_enfermedadrarasi.Checked = true;
                            }
                            if (sso.Socio_economico_enfermedad_rara_no == null)
                            {
                                cb_enfermedadrarano.Checked = false;
                            }
                            else
                            {
                                cb_enfermedadrarano.Checked = true;
                            }
                            //Consumo alcohol
                            if (sso.Socio_economico_consume_alcohol_si == null)
                            {
                                cb_alcoholsi.Checked = false;
                            }
                            else
                            {
                                cb_alcoholsi.Checked = true;
                            }
                            if (sso.Socio_economico_consume_alcohol_no == null)
                            {
                                cb_alcoholno.Checked = false;
                            }
                            else
                            {
                                cb_alcoholno.Checked = true;
                            }
                            //Frecuencia consumo alcohol
                            if (sso.Socio_economico_consume_alcohol_frecuencia_diaria == null)
                            {
                                cb_consumoalcoholdiario.Checked = false;
                            }
                            else
                            {
                                cb_consumoalcoholdiario.Checked = true;
                            }
                            if (sso.Socio_economico_consume_alcohol_frecuencia_semanal == null)
                            {
                                cb_consumoalcoholsemanal.Checked = false;
                            }
                            else
                            {
                                cb_consumoalcoholsemanal.Checked = true;
                            }
                            if (sso.Socio_economico_consume_alcohol_frecuencia_quincenal == null)
                            {
                                cb_consumoalcoholquincenal.Checked = false;
                            }
                            else
                            {
                                cb_consumoalcoholquincenal.Checked = true;
                            }
                            if (sso.Socio_economico_consume_alcohol_frecuencia_mensual == null)
                            {
                                cb_consumoalcoholmensual.Checked = false;
                            }
                            else
                            {
                                cb_consumoalcoholmensual.Checked = true;
                            }
                            if (sso.Socio_economico_consume_alcohol_frecuencia_reuniones == null)
                            {
                                cb_consumoalcoholreuniones.Checked = false;
                            }
                            else
                            {
                                cb_consumoalcoholreuniones.Checked = true;
                            }
                            //Consumo tabaco
                            if (sso.Socio_economico_consume_tabaco_si == null)
                            {
                                cb_tabacosi.Checked = false;
                            }
                            else
                            {
                                cb_tabacosi.Checked = true;
                            }
                            if (sso.Socio_economico_consume_tabaco_no == null)
                            {
                                cb_tabacono.Checked = false;
                            }
                            else
                            {
                                cb_tabacono.Checked = true;
                            }
                            //Consumo sustancia psicotrópica
                            if (sso.Socio_economico_consume_sustancia_psicotropica_si == null)
                            {
                                cb_sustanciapsicotropicasi.Checked = false;
                            }
                            else
                            {
                                cb_sustanciapsicotropicasi.Checked = true;
                            }
                            if (sso.Socio_economico_consume_sustancia_psicotropica_no == null)
                            {
                                cb_sustanciapsicotropicano.Checked = false;
                            }
                            else
                            {
                                cb_sustanciapsicotropicano.Checked = true;
                            }
                            //Problemas relacionados al consumo
                            if (sso.Socio_economico_problemas_consumo_familiares == null)
                            {
                                cb_familiares.Checked = false;
                            }
                            else
                            {
                                cb_familiares.Checked = true;
                            }
                            if (sso.Socio_economico_problemas_consumo_laborales == null)
                            {
                                cb_laborales.Checked = false;
                            }
                            else
                            {
                                cb_laborales.Checked = true;
                            }
                            if (sso.Socio_economico_problemas_consumo_economicos == null)
                            {
                                cb_economicos.Checked = false;
                            }
                            else
                            {
                                cb_economicos.Checked = true;
                            }
                            if (sso.Socio_economico_problemas_consumo_salud == null)
                            {
                                cb_salud.Checked = false;
                            }
                            else
                            {
                                cb_salud.Checked = true;
                            }
                            if (sso.Socio_economico_problemas_consumo_legales == null)
                            {
                                cb_legales.Checked = false;
                            }
                            else
                            {
                                cb_legales.Checked = true;
                            }

                            //CARACTERISTICA DE LA VIVIENDA
                            //Descripcion
                            if (sso.Socio_economico_caracteristica_vivienda_descripcion_unifamiliar == null)
                            {
                                cb_unifamiliar.Checked = false;
                            }
                            else
                            {
                                cb_unifamiliar.Checked = true;
                            }
                            if (sso.Socio_economico_caracteristica_vivienda_descripcion_multifamiliar == null)
                            {
                                cb_multifamiliar.Checked = false;
                            }
                            else
                            {
                                cb_multifamiliar.Checked = true;
                            }
                            //Tenencia
                            if (sso.Socio_economico_caracteristica_vivienda_tenencia_propia_sin_deuda == null)
                            {
                                cb_propiasindeuda.Checked = false;
                            }
                            else
                            {
                                cb_propiasindeuda.Checked = true;
                            }
                            if (sso.Socio_economico_caracteristica_vivienda_tenencia_arrendada == null)
                            {
                                cb_arrendada.Checked = false;
                            }
                            else
                            {
                                cb_arrendada.Checked = true;
                            }
                            if (sso.Socio_economico_caracteristica_vivienda_tenencia_de_familia == null)
                            {
                                cb_defamilia.Checked = false;
                            }
                            else
                            {
                                cb_defamilia.Checked = true;
                            }
                            if (sso.Socio_economico_caracteristica_vivienda_tenencia_hipotecada == null)
                            {
                                cb_hipotecada.Checked = false;
                            }
                            else
                            {
                                cb_hipotecada.Checked = true;
                            }
                            if (sso.Socio_economico_caracteristica_vivienda_tenencia_prestada == null)
                            {
                                cb_prestada.Checked = false;
                            }
                            else
                            {
                                cb_prestada.Checked = true;
                            }
                            if (sso.Socio_economico_caracteristica_vivienda_tenencia_anticreces == null)
                            {
                                cb_anticreces.Checked = false;
                            }
                            else
                            {
                                cb_anticreces.Checked = true;
                            }
                            //Tipo
                            if (sso.Socio_economico_caracteristica_vivienda_tipo_casa == null)
                            {
                                cb_tipocasa.Checked = false;
                            }
                            else
                            {
                                cb_tipocasa.Checked = true;
                            }
                            if (sso.Socio_economico_caracteristica_vivienda_tipo_suit == null)
                            {
                                cb_tiposuit.Checked = false;
                            }
                            else
                            {
                                cb_tiposuit.Checked = true;
                            }
                            if (sso.Socio_economico_caracteristica_vivienda_tipo_mediagua == null)
                            {
                                cb_tipomediagua.Checked = false;
                            }
                            else
                            {
                                cb_tipomediagua.Checked = true;
                            }
                            if (sso.Socio_economico_caracteristica_vivienda_tipo_departamento == null)
                            {
                                cb_tipodepartamento.Checked = false;
                            }
                            else
                            {
                                cb_tipodepartamento.Checked = true;
                            }
                            if (sso.Socio_economico_caracteristica_vivienda_tipo_pieza == null)
                            {
                                cb_tipopieza.Checked = false;
                            }
                            else
                            {
                                cb_tipopieza.Checked = true;
                            }
                            //Distribucion
                            if (sso.Socio_economico_caracteristica_vivienda_distribucion_habitacion == null)
                            {
                                cb_habitacion.Checked = false;
                            }
                            else
                            {
                                cb_habitacion.Checked = true;
                            }
                            if (sso.Socio_economico_caracteristica_vivienda_distribucion_sala == null)
                            {
                                cb_sala.Checked = false;
                            }
                            else
                            {
                                cb_sala.Checked = true;
                            }
                            if (sso.Socio_economico_caracteristica_vivienda_distribucion_baño == null)
                            {
                                cb_baño.Checked = false;
                            }
                            else
                            {
                                cb_baño.Checked = true;
                            }
                            if (sso.Socio_economico_caracteristica_vivienda_distribucion_garage == null)
                            {
                                cb_garage.Checked = false;
                            }
                            else
                            {
                                cb_garage.Checked = true;
                            }
                            if (sso.Socio_economico_caracteristica_vivienda_distribucion_comedor == null)
                            {
                                cb_comedor.Checked = false;
                            }
                            else
                            {
                                cb_comedor.Checked = true;
                            }
                            if (sso.Socio_economico_caracteristica_vivienda_distribucion_cocina == null)
                            {
                                cb_cocina.Checked = false;
                            }
                            else
                            {
                                cb_cocina.Checked = true;
                            }
                            if (sso.Socio_economico_caracteristica_vivienda_distribucion_patio == null)
                            {
                                cb_patio.Checked = false;
                            }
                            else
                            {
                                cb_patio.Checked = true;
                            }
                            if (sso.Socio_economico_caracteristica_vivienda_distribucion_bodega == null)
                            {
                                cb_bodega.Checked = false;
                            }
                            else
                            {
                                cb_bodega.Checked = true;
                            }

                            //INFORMACION FAMILIAR
                            //Persona discapacidad
                            if (sso.Socio_economico_nucleofamiliar_persona_discapacidad_si == null)
                            {
                                cb_nucleodiscapacidadsi.Checked = false;
                            }
                            else
                            {
                                cb_nucleodiscapacidadsi.Checked = true;
                            }
                            if (sso.Socio_economico_nucleofamiliar_persona_discapacidad_no == null)
                            {
                                cb_nucleodiscapacidadno.Checked = false;
                            }
                            else
                            {
                                cb_nucleodiscapacidadno.Checked = true;
                            }
                            if (sso.Socio_economico_acargo_de_persona_discapacidad_si == null)
                            {
                                cb_acargofamiliardiacapacitadosi.Checked = false;
                            }
                            else
                            {
                                cb_acargofamiliardiacapacitadosi.Checked = true;
                            }
                            if (sso.Socio_economico_acargo_de_persona_discapacidad_no == null)
                            {
                                cb_acargofamiliardiacapacitadono.Checked = false;
                            }
                            else
                            {
                                cb_acargofamiliardiacapacitadono.Checked = true;
                            }
                            //Dependencia ministerio de trabajo
                            if (sso.Socio_economico_registrar_dependencia_familiar_MT_si == null)
                            {
                                cb_dependenciaministeriotrabajosi.Checked = false;
                            }
                            else
                            {
                                cb_dependenciaministeriotrabajosi.Checked = true;
                            }
                            if (sso.Socio_economico_registrar_dependencia_familiar_MT_no == null)
                            {
                                cb_dependenciaministeriotrabajono.Checked = false;
                            }
                            else
                            {
                                cb_dependenciaministeriotrabajono.Checked = true;
                            }
                            //A cargo de persona con enfermedad catastrófica
                            if (sso.Socio_economico_a_cargo_familiar_enfermedad_catastrofica_rara_si == null)
                            {
                                cb_acargofamiliarenfermedadrarasi.Checked = false;
                            }
                            else
                            {
                                cb_acargofamiliarenfermedadrarasi.Checked = true;
                            }
                            if (sso.Socio_economico_a_cargo_familiar_enfermedad_catastrofica_rara_no == null)
                            {
                                cb_acargofamiliarenfermedadrarano.Checked = false;
                            }
                            else
                            {
                                cb_acargofamiliarenfermedadrarano.Checked = true;
                            }

                            //ACTIVIDAD EN TIEMPO LIBRE
                            //Actividad inicial
                            if (sso.Socio_economico_hogar == null)
                            {
                                cb_hogar.Checked = false;
                            }
                            else
                            {
                                cb_hogar.Checked = true;
                            }
                            if (sso.Socio_economico_paseos_familiares == null)
                            {
                                cb_paseosfamiliares.Checked = false;
                            }
                            else
                            {
                                cb_paseosfamiliares.Checked = true;
                            }
                            if (sso.Socio_economico_estudios == null)
                            {
                                cb_estudios.Checked = false;
                            }
                            else
                            {
                                cb_estudios.Checked = true;
                            }
                            if (sso.Socio_economico_actividades_artisticas == null)
                            {
                                cb_actividadesartisticas.Checked = false;
                            }
                            else
                            {
                                cb_actividadesartisticas.Checked = true;
                            }
                            //Actividad economica adicional
                            if (sso.Socio_economico_actividad_economica_adicional_si == null)
                            {
                                cb_actividadeconomicasi.Checked = false;
                            }
                            else
                            {
                                cb_actividadeconomicasi.Checked = true;
                            }
                            if (sso.Socio_economico_actividad_economica_adicional_no == null)
                            {
                                cb_actividadeconomicano.Checked = false;
                            }
                            else
                            {
                                cb_actividadeconomicano.Checked = true;
                            }
                            //Actividad deportiva
                            if (sso.Socio_economico_actividad_deportiva_si == null)
                            {
                                cb_deportesi.Checked = false;
                            }
                            else
                            {
                                cb_deportesi.Checked = true;
                            }
                            if (sso.Socio_economico_actividad_deportiva_no == null)
                            {
                                cb_deporteno.Checked = false;
                            }
                            else
                            {
                                cb_deporteno.Checked = true;
                            }
                            //Lesión
                            if (sso.Socio_economico_lesion_si == null)
                            {
                                cb_lesionsi.Checked = false;
                            }
                            else
                            {
                                cb_lesionsi.Checked = true;
                            }
                            if (sso.Socio_economico_lesion_no == null)
                            {
                                cb_lesionno.Checked = false;
                            }
                            else
                            {
                                cb_lesionno.Checked = true;
                            }
                            //Tratamiento
                            if (sso.Socio_economico_lesion_tratamiento_si == null)
                            {
                                cb_tratamientosi.Checked = false;
                            }
                            else
                            {
                                cb_tratamientosi.Checked = true;
                            }
                            if (sso.Socio_economico_lesion_tratamiento_no == null)
                            {
                                cb_tratamientono.Checked = false;
                            }
                            else
                            {
                                cb_tratamientono.Checked = true;
                            }

                            //INFORMACION BIENESTAR FAMILIAR
                            //Tipo familia
                            if (sso.Socio_economico_tipo_familia_nuclear == null)
                            {
                                cb_nuclear.Checked = false;
                            }
                            else
                            {
                                cb_nuclear.Checked = true;
                            }
                            if (sso.Socio_economico_tipo_familia_ampliada == null)
                            {
                                cb_ampliada.Checked = false;
                            }
                            else
                            {
                                cb_ampliada.Checked = true;
                            }
                            if (sso.Socio_economico_tipo_familia_monoparental == null)
                            {
                                cb_monoparental.Checked = false;
                            }
                            else
                            {
                                cb_monoparental.Checked = true;
                            }
                            if (sso.Socio_economico_tipo_familia_vive_solo == null)
                            {
                                cb_vivesolo.Checked = false;
                            }
                            else
                            {
                                cb_vivesolo.Checked = true;
                            }
                            if (sso.Socio_economico_tipo_familia_vive_amigos == null)
                            {
                                cb_viveconamigos.Checked = false;
                            }
                            else
                            {
                                cb_viveconamigos.Checked = true;
                            }
                            if (sso.Socio_economico_tipo_familia_sin_hijos == null)
                            {
                                cb_familiasinhijos.Checked = false;
                            }
                            else
                            {
                                cb_familiasinhijos.Checked = true;
                            }
                            //Relacion familiar
                            if (sso.Socio_economico_evaluacion_relacion_familiar_muybueno == null)
                            {
                                cb_relacionfamiliarmuybuena.Checked = false;
                            }
                            else
                            {
                                cb_relacionfamiliarmuybuena.Checked = true;
                            }
                            if (sso.Socio_economico_evaluacion_relacion_familiar_bueno == null)
                            {
                                cb_relacionfamiliarbuena.Checked = false;
                            }
                            else
                            {
                                cb_relacionfamiliarbuena.Checked = true;
                            }
                            if (sso.Socio_economico_evaluacion_relacion_familiar_regular == null)
                            {
                                cb_relacionfamiliarregular.Checked = false;
                            }
                            else
                            {
                                cb_relacionfamiliarregular.Checked = true;
                            }
                            if (sso.Socio_economico_evaluacion_relacion_familiar_mala == null)
                            {
                                cb_relacionfamiliarmala.Checked = false;
                            }
                            else
                            {
                                cb_relacionfamiliarmala.Checked = true;
                            }
                            //Relacion pareja
                            if (sso.Socio_economico_evaluacion_relacion_pareja_muybueno == null)
                            {
                                cb_relacionparejamuybuena.Checked = false;
                            }
                            else
                            {
                                cb_relacionparejamuybuena.Checked = true;
                            }
                            if (sso.Socio_economico_evaluacion_relacion_pareja_bueno == null)
                            {
                                cb_relacionparejabuena.Checked = false;
                            }
                            else
                            {
                                cb_relacionparejabuena.Checked = true;
                            }
                            if (sso.Socio_economico_evaluacion_relacion_pareja_regular == null)
                            {
                                cb_relacionparejaregular.Checked = false;
                            }
                            else
                            {
                                cb_relacionparejaregular.Checked = true;
                            }
                            if (sso.Socio_economico_evaluacion_relacion_pareja_mala == null)
                            {
                                cb_relacionparejamala.Checked = false;
                            }
                            else
                            {
                                cb_relacionparejamala.Checked = true;
                            }
                            //Relacion con hijos
                            if (sso.Socio_economico_evaluacion_relacion_hijos_muybueno == null)
                            {
                                cb_relacionconhijosmuybuena.Checked = false;
                            }
                            else
                            {
                                cb_relacionconhijosmuybuena.Checked = true;
                            }
                            if (sso.Socio_economico_evaluacion_relacion_hijos_bueno == null)
                            {
                                cb_relacionconhijosbuena.Checked = false;
                            }
                            else
                            {
                                cb_relacionconhijosbuena.Checked = true;
                            }
                            if (sso.Socio_economico_evaluacion_relacion_hijos_regular == null)
                            {
                                cb_relacionconhijosregular.Checked = false;
                            }
                            else
                            {
                                cb_relacionconhijosregular.Checked = true;
                            }
                            if (sso.Socio_economico_evaluacion_relacion_hijos_mala == null)
                            {
                                cb_relacionconhijosmala.Checked = false;
                            }
                            else
                            {
                                cb_relacionconhijosmala.Checked = true;
                            }
                            //Problemas familiares
                            if (sso.Socio_economico_problemas_familiares_economicos == null)
                            {
                                cb_economico.Checked = false;
                            }
                            else
                            {
                                cb_economico.Checked = true;
                            }
                            if (sso.Socio_economico_problemas_familiares_comunicacion == null)
                            {
                                cb_comunicacion.Checked = false;
                            }
                            else
                            {
                                cb_comunicacion.Checked = true;
                            }
                            if (sso.Socio_economico_problemas_familiares_conyugales == null)
                            {
                                cb_conyugales.Checked = false;
                            }
                            else
                            {
                                cb_conyugales.Checked = true;
                            }
                            if (sso.Socio_economico_problemas_familiares_crianza_hijos == null)
                            {
                                cb_crianzadehijos.Checked = false;
                            }
                            else
                            {
                                cb_crianzadehijos.Checked = true;
                            }
                            if (sso.Socio_economico_problemas_familiares_adicciones == null)
                            {
                                cb_adicciones.Checked = false;
                            }
                            else
                            {
                                cb_adicciones.Checked = true;
                            }
                            //Violencia
                            if (sso.Socio_economico_problemas_familiares_violencia_fisica == null)
                            {
                                cb_fisica.Checked = false;
                            }
                            else
                            {
                                cb_fisica.Checked = true;
                            }
                            if (sso.Socio_economico_problemas_familiares_violencia_psicologica == null)
                            {
                                cb_psicologica.Checked = false;
                            }
                            else
                            {
                                cb_psicologica.Checked = true;
                            }
                            if (sso.Socio_economico_problemas_familiares_violencia_verbal == null)
                            {
                                cb_verbal.Checked = false;
                            }
                            else
                            {
                                cb_verbal.Checked = true;
                            }
                            if (sso.Socio_economico_problemas_familiares_violencia_sexual == null)
                            {
                                cb_sexual.Checked = false;
                            }
                            else
                            {
                                cb_sexual.Checked = true;
                            }
                            //Rol
                            if (sso.Socio_economico_miembro_familiar_rol_si == null)
                            {
                                cb_rolfamiliarsi.Checked = false;
                            }
                            else
                            {
                                cb_rolfamiliarsi.Checked = true;
                            }
                            if (sso.Socio_economico_miembro_familiar_rol_no == null)
                            {
                                cb_rolfamiliarno.Checked = false;
                            }
                            else
                            {
                                cb_rolfamiliarno.Checked = true;
                            }
                            //Nivel de salud de la familia
                            if (sso.Socio_economico_nivel_salud_familia_muybueno == null)
                            {
                                cb_nivelsaludfamiliarmuybuena.Checked = false;
                            }
                            else
                            {
                                cb_nivelsaludfamiliarmuybuena.Checked = true;
                            }
                            if (sso.Socio_economico_nivel_salud_familia_bueno == null)
                            {
                                cb_nivelsaludfamiliarbuena.Checked = false;
                            }
                            else
                            {
                                cb_nivelsaludfamiliarbuena.Checked = true;
                            }
                            if (sso.Socio_economico_nivel_salud_familia_regular == null)
                            {
                                cb_nivelsaludfamiliarregular.Checked = false;
                            }
                            else
                            {
                                cb_nivelsaludfamiliarregular.Checked = true;
                            }
                            if (sso.Socio_economico_nivel_salud_familia_mala == null)
                            {
                                cb_nivelsaludfamiliarmala.Checked = false;
                            }
                            else
                            {
                                cb_nivelsaludfamiliarmala.Checked = true;
                            }
                            //La familia es
                            if (sso.Socio_economico_familia_funcional == null)
                            {
                                cb_funcional.Checked = false;
                            }
                            else
                            {
                                cb_funcional.Checked = true;
                            }
                            if (sso.Socio_economico_familia_disfuncional == null)
                            {
                                cb_disfuncional.Checked = false;
                            }
                            else
                            {
                                cb_disfuncional.Checked = true;
                            }
                            //Certifico
                            if (sso.Socio_economico_informacion_general_real_si == null)
                            {
                                cb_certificosi.Checked = false;
                            }
                            else
                            {
                                cb_certificosi.Checked = true;
                            }
                            if (sso.Socio_economico_informacion_general_real_no == null)
                            {
                                cb_certificono.Checked = false;
                            }
                            else
                            {
                                cb_certificono.Checked = true;
                            }
                        }
                    }
                }
                txt_fecharegistro.Text = DateTime.Now.ToString("yyyy-MM-dd");
            }
        }

        public void Calculo(DateTime nac, DateTime actual)
        {
            int año = nac.Year;
            int mes = nac.Month;
            int dia = nac.Day;

            int añoBisiesto = 0;

            for (int i = año; i < actual.Year; i++)
            {
                if (DateTime.IsLeapYear(i))
                {
                    ++añoBisiesto;
                }
            }

            TimeSpan ts = actual.Subtract(nac);
            dia = ts.Days - añoBisiesto;
            int r = 0;

            año = Math.DivRem(dia, 365, out r);
            mes = Math.DivRem(r, 30, out r);
            dia = r;

            txt_edad.Text = año + " Años, " + mes + " Meses, " + dia + " Días";
        }

        //Metodo obtener cedula por numero de Socio Economico
        [WebMethod]
        [ScriptMethod]
        public static List<string> ObtenerNumHClinica(string prefixText)
        {
            List<string> lista = new List<string>();
            try
            {
                string oConn = @"Data Source=ZOCAPO\SQLEXPRESS;Initial Catalog=SistemaECU911;Integrated Security=True";

                SqlConnection con = new SqlConnection(oConn);
                con.Open();
                SqlCommand cmd = new SqlCommand("select top(10) Per_Cedula from Tbl_Personas where Per_Cedula LIKE + @Cedula + '%'", con);
                cmd.Parameters.AddWithValue("@Cedula", prefixText);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                IDataReader lector = cmd.ExecuteReader();

                while (lector.Read())
                {
                    lista.Add(lector.GetString(0));
                }

                lector.Close();
                return lista;
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                return null;
            }
        }

        protected void txt_cedula_TextChanged(object sender, EventArgs e)
        {
            ObtenerCedula();
        }

        private void ObtenerCedula()
        {
            string cedula = txt_cedula.Text;

            var lista = from c in dc.Tbl_Personas
                        where c.Per_cedula == cedula
                        select c;

            foreach (var item in lista)
            {
                string priNombre = item.Per_priNombre;
                txt_prinombre.Text = priNombre;

                string segNombre = item.Per_segNombre;
                txt_segnombre.Text = segNombre;

                string priApellido = item.Per_priApellido;
                txt_priapellido.Text = priApellido;

                string segApellido = item.Per_segApellido;
                txt_segapellido.Text = segApellido;

                string areaTrabajo = item.Per_areaTrabajo;
                txt_areatrabajo.Text = areaTrabajo;

                string cargo = item.Per_cargoOcupacion;
                txt_cargoinstitucional.Text = cargo;

                DateTime fechaIngresoEcu = Convert.ToDateTime(item.Per_fechInicioTrabajo);
                txt_fechaingresoalsisecu.Text = Convert.ToDateTime(fechaIngresoEcu).ToString("yyyy-MM-dd");

                DateTime fechaNacimiento = Convert.ToDateTime(item.Per_fechaNacimiento);
                txt_fechanacimiento.Text = Convert.ToDateTime(fechaNacimiento).ToString("yyyy-MM-dd");

                DateTime edad = Convert.ToDateTime(item.Per_fechaNacimiento);
                DateTime naci = Convert.ToDateTime(edad);

                DateTime actual = DateTime.Now;
                Calculo(naci, actual);
            }
        }

        private void Guardar_modificar_datos(int socioEconomico)
        {
            if (socioEconomico == 0)
            {
                GuardarSocioEconomico();
            }
            else
            {
                sso = CN_SocioEconomico.ObtenerSocioEconomicoPorId(socioEconomico);

                if (sso != null)
                {
                    ModificarSocioEconomico(sso);
                }
            }
        }

        private void GuardarSocioEconomico()
        {
            try
            {
                per = CN_HistorialMedico.ObtenerIdPersonasxCedula(Convert.ToInt32(txt_cedula.Text));

                int perso = Convert.ToInt32(per.Per_id.ToString());

                sso = new Tbl_SocioEconomico
                {
                    Socio_economico_fechaHora = txt_fecharegistro.Text,

                    //Datos código y versión
                    Socio_economico_codigo_inicial = txt_codigoinicio.Text,
                    Socio_economico_version = txt_version.Text,

                    //Datos Generales
                    Socio_economico_tipo_de_sangre = txt_tipodesangre.Text,

                    Socio_economico_telefono_convencional = txt_telconvecional.Text,
                    Socio_economico_telefono_celular = txt_telcelular.Text,
                    Socio_economico_email = txt_email.Text,

                    Socio_economico_lugar_nacimiento = txt_lugarnacimiento.Text,

                    Socio_economico_direcciondomicilio_provincia = txt_provincia.Text,
                    Socio_economico_direcciondomicilio_canton = txt_canton.Text,
                    Socio_economico_direcciondomicilio_parroquia = txt_parroquia.Text,
                    Socio_economico_direcciondomicilio_barrio = txt_barrio.Text,

                    Socio_economico_calle_vivienda_numeracion = txt_calleubicada.Text,
                    Socio_economico_calle_secundaria = txt_callesecundaria.Text,
                    Socio_economico_referencia_ubicar_domicilio = txt_refubicardomicilio.Text,

                    Socio_economico_tipovivienda_otro_indique = txt_tipoviviendaotro.Text,

                    Socio_economico_contacto_emergencia_nombres_apellidos = txt_emernomyape.Text,
                    Socio_economico_contacto_emergencia_parentesco = txt_emeparentesco.Text,
                    Socio_economico_contacto_emergencia_telefono = txt_emetelefono.Text,
                    Socio_economico_contacto_emergencia_calle_principal = txt_emecalleprincipal.Text,
                    Socio_economico_contacto_emergencia_numero_domicilio = txt_emenumdomicilio.Text,
                    Socio_economico_contacto_emergencia_calle_secundaria = txt_emecallesecun.Text,
                    Socio_economico_contacto_emergencia_referencia_domicilio = txt_emerefubicardomicilio.Text,

                    Socio_economico_moviliza_trabajo_vivienda = txt_movilizatrabajoovivienda.Text,

                    //Salud
                    Socio_economico_posee_enfermedad = txt_poseeenfermedadprexistente.Text,
                    Socio_economico_discapacidad_tipo = txt_tipodiscapacidad.Text,
                    Socio_economico_discapacidad_porcentaje = txt_porcentajediscapacidad.Text,
                    Socio_economico_discapacidad_carnet_conadis = txt_numcarnetconadis.Text,
                    Socio_economico_discapacidad_fecha_caducidad_carnet = txt_fechacaducidadcarnet.Text,

                    Socio_economico_estado_gestacion_tiempo = txt_gestacióntiempo.Text,
                    Socio_economico_fecha_tentativa_parto = txt_fechatentativaparto.Text,
                    Socio_economico_periodo_lactancia_fecha_culminacion = txt_fechaculmicacionlactancia.Text,

                    Socio_economico_enfermedad_cronica_cual = txt_cualcatastrofica.Text,
                    Socio_economico_enfermedad_cronica_otras_enfermedades = txt_otrasenfermedadescat.Text,
                    Socio_economico_enfermedad_rara_cual = txt_enfermedadraracual.Text,

                    Socio_economico_consume_alcohol_causa = txt_causaconsumoalcohol.Text,
                    Socio_economico_consume_alcohol_tiempo_consumo = txt_tiempoconsumoalcohol.Text,
                    Socio_economico_consume_tabaco_frecuencia_consumo = txt_frecuenciaconsumotabaco.Text,
                    Socio_economico_consume_tabaco_tiempo_consumo = txt_tiempoconsumotabaco.Text,
                    Socio_economico_consume_sustancia_psicotropica_tipo = txt_sustanciapsicotropicatipo.Text,
                    Socio_economico_consume_sustancia_psicotropica_frecuencia_consumo = txt_sustanciapsicotropicafrecuencia.Text,

                    //Situacion económica del servidor
                    Socio_economico_numero_miembro_economicamente_activos = Convert.ToInt32(txt_miembroactivoseconomicamente.Text),

                    Socio_economico_total_ingresos_mensuales_proyectados_1 = Convert.ToInt32(txt_totalingresos1.Text),
                    Socio_economico_ayuda1 = Convert.ToInt32(txt_ayuda1.Text),
                    Socio_economico_otros1 = Convert.ToInt32(txt_otros1.Text),
                    Socio_economico_total_egresos_alimentacion = Convert.ToInt32(txt_alimentación.Text),

                    Socio_economico_total_ingresos_mensuales_proyectados_2 = Convert.ToInt32(txt_totalingresos2.Text),
                    Socio_economico_ayuda2 = Convert.ToInt32(txt_ayuda2.Text),
                    Socio_economico_otros2 = Convert.ToInt32(txt_otros2.Text),
                    Socio_economico_total_egresos_vivienda = Convert.ToInt32(txt_vivienda.Text),

                    Socio_economico_total_ingresos_mensuales_proyectados_3 = Convert.ToInt32(txt_totalingresos3.Text),
                    Socio_economico_ayuda3 = Convert.ToInt32(txt_ayuda3.Text),
                    Socio_economico_otros3 = Convert.ToInt32(txt_otros3.Text),
                    Socio_economico_total_egresos_educacion = Convert.ToInt32(txt_educación.Text),

                    Socio_economico_total_ingresos_mensuales_proyectados_4 = Convert.ToInt32(txt_totalingresos4.Text),
                    Socio_economico_ayuda4 = Convert.ToInt32(txt_ayuda4.Text),
                    Socio_economico_otros4 = Convert.ToInt32(txt_otros4.Text),
                    Socio_economico_total_egresos_servicios_basicos = Convert.ToInt32(txt_serviciosbasicos.Text),

                    Socio_economico_total_ingresos_mensuales_proyectados_5 = Convert.ToInt32(txt_totalingresos5.Text),
                    Socio_economico_ayuda5 = Convert.ToInt32(txt_ayuda5.Text),
                    Socio_economico_otros5 = Convert.ToInt32(txt_otros5.Text),
                    Socio_economico_total_egresos_salud = Convert.ToInt32(txt_salud.Text),

                    Socio_economico_total_ingresos_mensuales_proyectados_6 = Convert.ToInt32(txt_totalingresos6.Text),
                    Socio_economico_ayuda6 = Convert.ToInt32(txt_ayuda6.Text),
                    Socio_economico_otros6 = Convert.ToInt32(txt_otros6.Text),
                    Socio_economico_total_egresos_movilizacion = Convert.ToInt32(txt_movilización.Text),

                    Socio_economico_total_ingresos_mensuales_proyectados_7 = Convert.ToInt32(txt_totalingresos7.Text),
                    Socio_economico_ayuda7 = Convert.ToInt32(txt_ayuda7.Text),
                    Socio_economico_otros7 = Convert.ToInt32(txt_otros7.Text),
                    Socio_economico_total_egresos_deudas = Convert.ToInt32(txt_deudas.Text),

                    Socio_economico_total_ingresos_mensuales_proyectados_8 = Convert.ToInt32(txt_totalingresos8.Text),
                    Socio_economico_ayuda8 = Convert.ToInt32(txt_ayuda8.Text),
                    Socio_economico_otros8 = Convert.ToInt32(txt_otros8.Text),
                    Socio_economico_total_egresos_pensiones_otros = Convert.ToInt32(txt_otrospensiones.Text),

                    Socio_economico_total_ingresos_mensuales_proyectados_total_9 = Convert.ToInt32(txt_totalingresos9.Text),
                    Socio_economico_ayuda_y_otros_total_9 = Convert.ToInt32(txt_totalayudayotros9.Text),
                    Socio_economico_total_egresos_total_9 = Convert.ToInt32(txt_totalegresos.Text),

                    Socio_economico_descripcion_mueble_valor_casa = Convert.ToInt32(txt_biencasa.Text),
                    Socio_economico_descripcion_mueble_valor_departamento = Convert.ToInt32(txt_biendepartamento.Text),
                    Socio_economico_descripcion_mueble_valor_vehiculo = Convert.ToInt32(txt_bienvehiculo.Text),
                    Socio_economico_descripcion_mueble_valor_terreno = Convert.ToInt32(txt_bienterreno.Text),
                    Socio_economico_descripcion_mueble_valor_negocio = Convert.ToInt32(txt_bienegocio.Text),
                    Socio_economico_descripcion_mueble_valor_muebles_enseres = Convert.ToInt32(txt_bienmueblesyenseres.Text),

                    Socio_economico_caracteristica_vivienda_descripcion_otra_especifique = txt_otrodescripcionviviendafamilia.Text,
                    Socio_economico_caracteristica_vivienda_tenencia_otra_especifique = txt_otratenencia.Text,
                    Socio_economico_caracteristica_vivienda_tipo_otro_especifique = txt_otrotipodecasa.Text,
                    Socio_economico_caracteristica_vivienda_distribucion_otro_especifique = txt_otradistribucioncasa.Text,
                    Socio_economico_caracteristica_vivienda_otro_especifique = txt_otrainformacioncasa.Text,

                    //Información Familiar
                    Socio_economico_nombres_apellidos_familiar1 = txt_nomapellidos1.Text,
                    Socio_economico_parentesco_familiar1 = txt_parentesco1.Text,
                    Socio_economico_fecha_nacimiento_familiar1 = txt_fechanacimiento1.Text,
                    Socio_economico_edad_familiar1 = txt_edad1.Text,

                    Socio_economico_nombres_apellidos_familiar2 = txt_nomapellidos2.Text,
                    Socio_economico_parentesco_familiar2 = txt_parentesco2.Text,
                    Socio_economico_fecha_nacimiento_familiar2 = txt_fechanacimiento2.Text,
                    Socio_economico_edad_familiar2 = txt_edad2.Text,

                    Socio_economico_nombres_apellidos_familiar3 = txt_nomapellidos3.Text,
                    Socio_economico_parentesco_familiar3 = txt_parentesco3.Text,
                    Socio_economico_fecha_nacimiento_familiar3 = txt_fechanacimiento3.Text,
                    Socio_economico_edad_familiar3 = txt_edad3.Text,

                    Socio_economico_nombres_apellidos_familiar4 = txt_nomapellidos4.Text,
                    Socio_economico_parentesco_familiar4 = txt_parentesco4.Text,
                    Socio_economico_fecha_nacimiento_familiar4 = txt_fechanacimiento4.Text,
                    Socio_economico_edad_familiar4 = txt_edad4.Text,

                    Socio_economico_nombres_apellidos_familiar5 = txt_nomapellidos5.Text,
                    Socio_economico_parentesco_familiar5 = txt_parentesco5.Text,
                    Socio_economico_fecha_nacimiento_familiar5 = txt_fechanacimiento5.Text,
                    Socio_economico_edad_familiar5 = txt_edad5.Text,

                    Socio_economico_nombres_apellidos_familiar_discapacidad1 = txt_familiardiscapacitadonomape1.Text,
                    Socio_economico_fecha_caducidad_carnet_familiar_discapacidad1 = txt_familiardiscapacitadofechacaducidadcarnet1.Text,
                    Socio_economico_familiar_discapacidad_tipo1 = txt_familiardiscapacitadotipodiscapacidad1.Text,
                    Socio_economico_familiar_discapacidad_porcentaje1 = txt_familiardiscapacitadoporcentajediscapacidad1.Text,
                    Socio_economico_familiar_discapacidad_parentesco1 = txt_familiardiscapacitadoparentesco1.Text,
                    Socio_economico_familiar_discapacidad_fecha_nacimiento1 = txt_familiardiscapacitadofechanacimiento1.Text,

                    Socio_economico_nombres_apellidos_familiar_discapacidad2 = txt_familiardiscapacitadonomape2.Text,
                    Socio_economico_fecha_caducidad_carnet_familiar_discapacidad2 = txt_familiardiscapacitadofechacaducidadcarnet2.Text,
                    Socio_economico_familiar_discapacidad_tipo2 = txt_familiardiscapacitadotipodiscapacidad2.Text,
                    Socio_economico_familiar_discapacidad_porcentaje2 = txt_familiardiscapacitadoporcentajediscapacidad2.Text,
                    Socio_economico_familiar_discapacidad_parentesco2 = txt_familiardiscapacitadoparentesco2.Text,
                    Socio_economico_familiar_discapacidad_fecha_nacimiento2 = txt_familiardiscapacitadofechanacimiento2.Text,

                    Socio_economico_registrar_dependencia_familiar_MT_tiempo = txt_dependenciaministeriotrabajotiempo.Text,
                    Socio_economico_registrar_dependencia_familiar_MT_numero_carnetMSP = txt_numcarnetMSP.Text,
                    Socio_economico_a_cargo_familiar_enfermedad_catastrofica_rara_tiempo = txt_acargofamiliarenfermedadraratiempo.Text,
                    Socio_economico_a_cargo_familiar_enfermedad_catastrofica_rara_tipoenfermedad = txt_familiarenfermedadraratipo.Text,

                    //Actividad tiempo libre
                    Socio_economico_otro_especifique = txt_otraactividad.Text,
                    Socio_economico_actividad_economica_adicional_detalle = txt_actividadeconomicadetalle.Text,
                    Socio_economico_actividad_economica_adicional_tiempo_destina = txt_actividadeconomicatiempodestina.Text,
                    Socio_economico_actividad_economica_adicional_hace_tiempo = txt_actividadeconomicatiemporealiza.Text,
                    Socio_economico_actividad_deportiva_especificar = txt_especifiquedeporte.Text,
                    Socio_economico_actividad_deportiva_frecuencia = txt_frecuenciadeporte.Text,
                    Socio_economico_actividad_deportiva_edad = txt_edadpracticadeporte.Text,
                    Socio_economico_lesion_tipo = txt_tipolesion.Text,
                    Socio_economico_lesion_edad = txt_edadlesion.Text,

                    //Informacion para uso de bienestar familiar
                    Socio_economico_evaluacion_relacion_familiar_porque = txt_relacionfamiliarporque.Text,
                    Socio_economico_evaluacion_relacion_pareja_porque = txt_relacionparejaporque.Text,
                    Socio_economico_evaluacion_relacion_hijos_porque = txt_relacionconhijosporque.Text,
                    Socio_economico_problemas_familiares_observaciones = txt_observacionesfamiliares.Text,
                    Socio_economico_nivel_salud_familia_porque = txt_nivelsaludfamiliarporque.Text,
                    Socio_economico_familia_observaciones = txt_observacionesgenerales.Text,
                    Socio_economico_informacion_adicional = txt_informacionadicional.Text,

                    Per_id = perso
                };

                //DATOS GENERALES
                //Modalidad de Trabajo
                if (cb_modalidadvinculacionlosep.Checked == true)
                {
                    sso.Socio_economico_modalidadvinculacion_leyorgserpublico = "SI";
                }
                if (cb_modalidadvinculacioncodigotrabajo.Checked == true)
                {
                    sso.Socio_economico_modalidadvinculacion_codigotrabajo = "SI";
                }
                //Estado Civil
                if (cb_soltero.Checked == true)
                {
                    sso.Socio_economico_estadocivil_soltero = "SI";
                }
                if (cb_casado.Checked == true)
                {
                    sso.Socio_economico_estadocivil_casado = "SI";
                }
                if (cb_viudo.Checked == true)
                {
                    sso.Socio_economico_estadocivil_viudo = "SI";
                }
                if (cb_unionlibre.Checked == true)
                {
                    sso.Socio_economico_estadocivil_unionlibre = "SI";
                }
                if (cb_divorciado.Checked == true)
                {
                    sso.Socio_economico_estadocivil_divorciado = "SI";
                }
                //Genero
                if (cb_genmasculino.Checked == true)
                {
                    sso.Socio_economico_genero_masculino = "SI";
                }
                if (cb_genfemenino.Checked == true)
                {
                    sso.Socio_economico_genero_femenino = "SI";
                }
                //Donante
                if (cb_donantesi.Checked == true)
                {
                    sso.Socio_economico_es_donante_si = "SI";
                }
                if (cb_donanteno.Checked == true)
                {
                    sso.Socio_economico_es_donante_no = "SI";
                }
                //Nivel de Educación
                if (cb_primaria.Checked == true)
                {
                    sso.Socio_economico_titulo_primaria = "SI";
                }
                if (cb_secundaria.Checked == true)
                {
                    sso.Socio_economico_titulo_secundaria = "SI";
                }
                if (cb_superior.Checked == true)
                {
                    sso.Socio_economico_titulo_superior = "SI";
                }
                if (cb_especializacion.Checked == true)
                {
                    sso.Socio_economico_titulo_especializacion = "SI";
                }
                if (cb_diplomado.Checked == true)
                {
                    sso.Socio_economico_titulo_diplomado = "SI";
                }
                if (cb_maestria.Checked == true)
                {
                    sso.Socio_economico_titulo_maestria = "SI";
                }
                //Autoidentificacion Étnica
                if (cb_blanco.Checked == true)
                {
                    sso.Socio_economico_autoidentificacionetnica_blanco = "SI";
                }
                if (cb_mestizo.Checked == true)
                {
                    sso.Socio_economico_autoidentificacionetnica_mestizo = "SI";
                }
                if (cb_afro.Checked == true)
                {
                    sso.Socio_economico_autoidentificacionetnica_afrodescendiente = "SI";
                }
                if (cb_indigena.Checked == true)
                {
                    sso.Socio_economico_autoidentificacionetnica_indigena = "SI";
                }
                if (cb_montubio.Checked == true)
                {
                    sso.Socio_economico_autoidentificacionetnica_montubio = "SI";
                }
                //Sector donde vive
                if (cb_norte.Checked == true)
                {
                    sso.Socio_economico_sectorvive_norte = "SI";
                }
                if (cb_centro.Checked == true)
                {
                    sso.Socio_economico_sectorvive_centro = "SI";
                }
                if (cb_sur.Checked == true)
                {
                    sso.Socio_economico_sectorvive_sur = "SI";
                }
                if (cb_valle.Checked == true)
                {
                    sso.Socio_economico_sectorvive_valle = "SI";
                }
                if (cb_valledeloschillos.Checked == true)
                {
                    sso.Socio_economico_sectorvive_valledeloschillos = "SI";
                }
                //Tipo de vivienda
                if (cb_casa.Checked == true)
                {
                    sso.Socio_economico_tipovivienda_casa = "SI";
                }
                if (cb_departamento.Checked == true)
                {
                    sso.Socio_economico_tipovivienda_departamento = "SI";
                }
                //Riesgo Delincuencial
                if (cb_riesgoalto.Checked == true)
                {
                    sso.Socio_economico_riesgo_delincuencial_alto = "SI";
                }
                if (cb_riesgomedio.Checked == true)
                {
                    sso.Socio_economico_riesgo_delincuencial_medio = "SI";
                }
                if (cb_riesgobajo.Checked == true)
                {
                    sso.Socio_economico_riesgo_delincuencial_bajo = "SI";
                }
                //Dinero ahorro
                if (cb_dineroahorrosi.Checked == true)
                {
                    sso.Socio_economico_dinero_ahorro_si = "SI";
                }
                if (cb_dineroahorrono.Checked == true)
                {
                    sso.Socio_economico_dinero_ahorro_no = "SI";
                }
                //Vehiculo propio
                if (cb_vehiculosi.Checked == true)
                {
                    sso.Socio_economico_vehiculo_propio_si = "SI";
                }
                if (cb_vehiculono.Checked == true)
                {
                    sso.Socio_economico_vehiculo_propio_no = "SI";
                }
                //Recorrido Institucional
                if (cb_recorridosi.Checked == true)
                {
                    sso.Socio_economico_recorrido_institucional_si = "SI";
                }
                if (cb_recorridono.Checked == true)
                {
                    sso.Socio_economico_recorrido_institucional_no = "SI";
                }

                //SALUD
                //Posee Discapacidad
                if (cb_discapacidadsi.Checked == true)
                {
                    sso.Socio_economico_discapacidad_si = "SI";
                }
                if (cb_discapacidadno.Checked == true)
                {
                    sso.Socio_economico_discapacidad_no = "SI";
                }
                //Gestacion 
                if (cb_gestaciónsi.Checked == true)
                {
                    sso.Socio_economico_estado_gestacion_si = "SI";
                }
                if (cb_gestaciónno.Checked == true)
                {
                    sso.Socio_economico_estado_gestacion_no = "SI";
                }
                //Periodo Lactancia
                if (cb_lactaciasi.Checked == true)
                {
                    sso.Socio_economico_periodo_lactancia_si = "SI";
                }
                if (cb_lactaciano.Checked == true)
                {
                    sso.Socio_economico_periodo_lactancia_no = "SI";
                }
                //Enfermedad catastrófica
                if (cb_catastroficasi.Checked == true)
                {
                    sso.Socio_economico_enfermedad_cronica_si = "SI";
                }
                if (cb_catastroficano.Checked == true)
                {
                    sso.Socio_economico_enfermedad_cronica_no = "SI";
                }
                //Enfermedad rara
                if (cb_enfermedadrarasi.Checked == true)
                {
                    sso.Socio_economico_enfermedad_rara_si = "SI";
                }
                if (cb_enfermedadrarano.Checked == true)
                {
                    sso.Socio_economico_enfermedad_rara_no = "SI";
                }
                //Consumo alcohol
                if (cb_alcoholsi.Checked == true)
                {
                    sso.Socio_economico_consume_alcohol_si = "SI";
                }
                if (cb_alcoholno.Checked == true)
                {
                    sso.Socio_economico_consume_alcohol_no = "SI";
                }
                //Frecuencia consumo alcohol
                if (cb_consumoalcoholdiario.Checked == true)
                {
                    sso.Socio_economico_consume_alcohol_frecuencia_diaria = "SI";
                }
                if (cb_consumoalcoholsemanal.Checked == true)
                {
                    sso.Socio_economico_consume_alcohol_frecuencia_semanal = "SI";
                }
                if (cb_consumoalcoholquincenal.Checked == true)
                {
                    sso.Socio_economico_consume_alcohol_frecuencia_quincenal = "SI";
                }
                if (cb_consumoalcoholmensual.Checked == true)
                {
                    sso.Socio_economico_consume_alcohol_frecuencia_mensual = "SI";
                }
                if (cb_consumoalcoholreuniones.Checked == true)
                {
                    sso.Socio_economico_consume_alcohol_frecuencia_reuniones = "SI";
                }
                //Consumo tabaco
                if (cb_tabacosi.Checked == true)
                {
                    sso.Socio_economico_consume_tabaco_si = "SI";
                }
                if (cb_tabacono.Checked == true)
                {
                    sso.Socio_economico_consume_tabaco_no = "SI";
                }
                //Consumo sustancia psicotrópica
                if (cb_sustanciapsicotropicasi.Checked == true)
                {
                    sso.Socio_economico_consume_sustancia_psicotropica_si = "SI";
                }
                if (cb_sustanciapsicotropicano.Checked == true)
                {
                    sso.Socio_economico_consume_sustancia_psicotropica_no = "SI";
                }
                //Consumo sustancia psicotrópica
                if (cb_familiares.Checked == true)
                {
                    sso.Socio_economico_problemas_consumo_familiares = "SI";
                }
                if (cb_laborales.Checked == true)
                {
                    sso.Socio_economico_problemas_consumo_laborales = "SI";
                }
                if (cb_economicos.Checked == true)
                {
                    sso.Socio_economico_problemas_consumo_economicos = "SI";
                }
                if (cb_salud.Checked == true)
                {
                    sso.Socio_economico_problemas_consumo_salud = "SI";
                }
                if (cb_legales.Checked == true)
                {
                    sso.Socio_economico_problemas_consumo_legales = "SI";
                }

                //CARACTERISTICA DE LA VIVIENDA
                //Descripcion
                if (cb_unifamiliar.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_descripcion_unifamiliar = "SI";
                }
                if (cb_multifamiliar.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_descripcion_multifamiliar = "SI";
                }
                //Tenencia
                if (cb_propiasindeuda.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_tenencia_propia_sin_deuda = "SI";
                }
                if (cb_arrendada.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_tenencia_arrendada = "SI";
                }
                if (cb_defamilia.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_tenencia_de_familia = "SI";
                }
                if (cb_hipotecada.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_tenencia_hipotecada = "SI";
                }
                if (cb_prestada.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_tenencia_prestada = "SI";
                }
                if (cb_anticreces.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_tenencia_anticreces = "SI";
                }
                //Tipo
                if (cb_tipocasa.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_tipo_casa = "SI";
                }
                if (cb_tiposuit.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_tipo_suit = "SI";
                }
                if (cb_tipomediagua.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_tipo_mediagua = "SI";
                }
                if (cb_tipodepartamento.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_tipo_departamento = "SI";
                }
                if (cb_tipopieza.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_tipo_pieza = "SI";
                }
                //Distribucion
                if (cb_habitacion.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_distribucion_habitacion = "SI";
                }
                if (cb_sala.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_distribucion_sala = "SI";
                }
                if (cb_baño.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_distribucion_baño = "SI";
                }
                if (cb_garage.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_distribucion_garage = "SI";
                }
                if (cb_comedor.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_distribucion_comedor = "SI";
                }
                if (cb_cocina.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_distribucion_cocina = "SI";
                }
                if (cb_patio.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_distribucion_patio = "SI";
                }
                if (cb_bodega.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_distribucion_bodega = "SI";
                }

                //INFORMACION GENERAL
                //Persona discapacidad
                if (cb_nucleodiscapacidadsi.Checked == true)
                {
                    sso.Socio_economico_nucleofamiliar_persona_discapacidad_si = "SI";
                }
                if (cb_nucleodiscapacidadno.Checked == true)
                {
                    sso.Socio_economico_nucleofamiliar_persona_discapacidad_no = "SI";
                }
                if (cb_acargofamiliardiacapacitadosi.Checked == true)
                {
                    sso.Socio_economico_acargo_de_persona_discapacidad_si = "SI";
                }
                if (cb_acargofamiliardiacapacitadono.Checked == true)
                {
                    sso.Socio_economico_acargo_de_persona_discapacidad_no = "SI";
                }
                //Dependencia ministerio de trabajo
                if (cb_dependenciaministeriotrabajosi.Checked == true)
                {
                    sso.Socio_economico_registrar_dependencia_familiar_MT_si = "SI";
                }
                if (cb_dependenciaministeriotrabajono.Checked == true)
                {
                    sso.Socio_economico_registrar_dependencia_familiar_MT_no = "SI";
                }
                //A cargo de persona con enfermedad catastrófica
                if (cb_acargofamiliarenfermedadrarasi.Checked == true)
                {
                    sso.Socio_economico_a_cargo_familiar_enfermedad_catastrofica_rara_si = "SI";
                }
                if (cb_acargofamiliarenfermedadrarano.Checked == true)
                {
                    sso.Socio_economico_a_cargo_familiar_enfermedad_catastrofica_rara_no = "SI";
                }

                //ACTIVIDAD EN TIEMPO LIBRE
                //Actividad inicial
                if (cb_hogar.Checked == true)
                {
                    sso.Socio_economico_hogar = "SI";
                }
                if (cb_paseosfamiliares.Checked == true)
                {
                    sso.Socio_economico_paseos_familiares = "SI";
                }
                if (cb_estudios.Checked == true)
                {
                    sso.Socio_economico_estudios = "SI";
                }
                if (cb_actividadesartisticas.Checked == true)
                {
                    sso.Socio_economico_actividades_artisticas = "SI";
                }
                //Actividad economica adicional
                if (cb_actividadeconomicasi.Checked == true)
                {
                    sso.Socio_economico_actividad_economica_adicional_si = "SI";
                }
                if (cb_actividadeconomicano.Checked == true)
                {
                    sso.Socio_economico_actividad_economica_adicional_no = "SI";
                }
                //Actividad deportiva
                if (cb_deportesi.Checked == true)
                {
                    sso.Socio_economico_actividad_deportiva_si = "SI";
                }
                if (cb_deporteno.Checked == true)
                {
                    sso.Socio_economico_actividad_deportiva_no = "SI";
                }
                //Lesión
                if (cb_lesionsi.Checked == true)
                {
                    sso.Socio_economico_lesion_si = "SI";
                }
                if (cb_lesionno.Checked == true)
                {
                    sso.Socio_economico_lesion_no = "SI";
                }
                //Tratamiento
                if (cb_tratamientosi.Checked == true)
                {
                    sso.Socio_economico_lesion_tratamiento_si = "SI";
                }
                if (cb_tratamientono.Checked == true)
                {
                    sso.Socio_economico_lesion_tratamiento_no = "SI";
                }

                //INFORMACION BIENESTAR FAMILIAR
                //Tipo familia
                if (cb_nuclear.Checked == true)
                {
                    sso.Socio_economico_tipo_familia_nuclear = "SI";
                }
                if (cb_ampliada.Checked == true)
                {
                    sso.Socio_economico_tipo_familia_ampliada = "SI";
                }
                if (cb_monoparental.Checked == true)
                {
                    sso.Socio_economico_tipo_familia_monoparental = "SI";
                }
                if (cb_vivesolo.Checked == true)
                {
                    sso.Socio_economico_tipo_familia_vive_solo = "SI";
                }
                if (cb_viveconamigos.Checked == true)
                {
                    sso.Socio_economico_tipo_familia_vive_amigos = "SI";
                }
                if (cb_familiasinhijos.Checked == true)
                {
                    sso.Socio_economico_tipo_familia_sin_hijos = "SI";
                }
                //Relacion familiar
                if (cb_relacionfamiliarmuybuena.Checked == true)
                {
                    sso.Socio_economico_evaluacion_relacion_familiar_muybueno = "SI";
                }
                if (cb_relacionfamiliarbuena.Checked == true)
                {
                    sso.Socio_economico_evaluacion_relacion_familiar_bueno = "SI";
                }
                if (cb_relacionfamiliarregular.Checked == true)
                {
                    sso.Socio_economico_evaluacion_relacion_familiar_regular = "SI";
                }
                if (cb_relacionfamiliarmala.Checked == true)
                {
                    sso.Socio_economico_evaluacion_relacion_familiar_mala = "SI";
                }
                //Relacion pareja
                if (cb_relacionparejamuybuena.Checked == true)
                {
                    sso.Socio_economico_evaluacion_relacion_pareja_muybueno = "SI";
                }
                if (cb_relacionparejabuena.Checked == true)
                {
                    sso.Socio_economico_evaluacion_relacion_pareja_bueno = "SI";
                }
                if (cb_relacionparejaregular.Checked == true)
                {
                    sso.Socio_economico_evaluacion_relacion_pareja_regular = "SI";
                }
                if (cb_relacionparejamala.Checked == true)
                {
                    sso.Socio_economico_evaluacion_relacion_pareja_mala = "SI";
                }
                //Relacion con hijos
                if (cb_relacionconhijosmuybuena.Checked == true)
                {
                    sso.Socio_economico_evaluacion_relacion_hijos_muybueno = "SI";
                }
                if (cb_relacionconhijosbuena.Checked == true)
                {
                    sso.Socio_economico_evaluacion_relacion_hijos_bueno = "SI";
                }
                if (cb_relacionconhijosregular.Checked == true)
                {
                    sso.Socio_economico_evaluacion_relacion_hijos_regular = "SI";
                }
                if (cb_relacionconhijosmala.Checked == true)
                {
                    sso.Socio_economico_evaluacion_relacion_hijos_mala = "SI";
                }
                //Problemas familiares
                if (cb_economico.Checked == true)
                {
                    sso.Socio_economico_problemas_familiares_economicos = "SI";
                }
                if (cb_comunicacion.Checked == true)
                {
                    sso.Socio_economico_problemas_familiares_comunicacion = "SI";
                }
                if (cb_conyugales.Checked == true)
                {
                    sso.Socio_economico_problemas_familiares_conyugales = "SI";
                }
                if (cb_crianzadehijos.Checked == true)
                {
                    sso.Socio_economico_problemas_familiares_crianza_hijos = "SI";
                }
                if (cb_adicciones.Checked == true)
                {
                    sso.Socio_economico_problemas_familiares_adicciones = "SI";
                }
                //Violencia
                if (cb_fisica.Checked == true)
                {
                    sso.Socio_economico_problemas_familiares_violencia_fisica = "SI";
                }
                if (cb_psicologica.Checked == true)
                {
                    sso.Socio_economico_problemas_familiares_violencia_psicologica = "SI";
                }
                if (cb_verbal.Checked == true)
                {
                    sso.Socio_economico_problemas_familiares_violencia_verbal = "SI";
                }
                if (cb_sexual.Checked == true)
                {
                    sso.Socio_economico_problemas_familiares_violencia_sexual = "SI";
                }
                //Rol
                if (cb_rolfamiliarsi.Checked == true)
                {
                    sso.Socio_economico_miembro_familiar_rol_si = "SI";
                }
                if (cb_rolfamiliarno.Checked == true)
                {
                    sso.Socio_economico_miembro_familiar_rol_no = "SI";
                }
                //Nivel de salud de la familia
                if (cb_nivelsaludfamiliarmuybuena.Checked == true)
                {
                    sso.Socio_economico_nivel_salud_familia_muybueno = "SI";
                }
                if (cb_nivelsaludfamiliarbuena.Checked == true)
                {
                    sso.Socio_economico_nivel_salud_familia_bueno = "SI";
                }
                if (cb_nivelsaludfamiliarregular.Checked == true)
                {
                    sso.Socio_economico_nivel_salud_familia_regular = "SI";
                }
                if (cb_nivelsaludfamiliarmala.Checked == true)
                {
                    sso.Socio_economico_nivel_salud_familia_mala = "SI";
                }
                //La familia es
                if (cb_funcional.Checked == true)
                {
                    sso.Socio_economico_familia_funcional = "SI";
                }
                if (cb_disfuncional.Checked == true)
                {
                    sso.Socio_economico_familia_disfuncional = "SI";
                }
                //Certifico
                if (cb_certificosi.Checked == true)
                {
                    sso.Socio_economico_informacion_general_real_si = "SI";
                }
                if (cb_certificono.Checked == true)
                {
                    sso.Socio_economico_informacion_general_real_no = "SI";
                }

                sso.Per_id = perso;

                CN_SocioEconomico.GuardarSocioEconomico(sso);

                //Mensaje de confirmacion
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Guardados Exitosamente')", true);

                Response.Redirect("~/Template/Views_Socio_Economico/PacientesSocioEconomico.aspx");

            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Guardados')", true);
            }
        }

        private void ModificarSocioEconomico(Tbl_SocioEconomico sso)
        {
            try
            {
                sso.Socio_economico_fechaHora = txt_fecharegistro.Text;

                //Datos código y versión
                sso.Socio_economico_codigo_inicial = txt_codigoinicio.Text;
                sso.Socio_economico_version = txt_version.Text;

                //Datos Generales
                sso.Socio_economico_tipo_de_sangre = txt_tipodesangre.Text;

                sso.Socio_economico_telefono_convencional = txt_telconvecional.Text;
                sso.Socio_economico_telefono_celular = txt_telcelular.Text;
                sso.Socio_economico_email = txt_email.Text;

                sso.Socio_economico_lugar_nacimiento = txt_lugarnacimiento.Text;

                sso.Socio_economico_direcciondomicilio_provincia = txt_provincia.Text;
                sso.Socio_economico_direcciondomicilio_canton = txt_canton.Text;
                sso.Socio_economico_direcciondomicilio_parroquia = txt_parroquia.Text;
                sso.Socio_economico_direcciondomicilio_barrio = txt_barrio.Text;

                sso.Socio_economico_calle_vivienda_numeracion = txt_calleubicada.Text;
                sso.Socio_economico_calle_secundaria = txt_callesecundaria.Text;
                sso.Socio_economico_referencia_ubicar_domicilio = txt_refubicardomicilio.Text;

                sso.Socio_economico_tipovivienda_otro_indique = txt_tipoviviendaotro.Text;

                sso.Socio_economico_contacto_emergencia_nombres_apellidos = txt_emernomyape.Text;
                sso.Socio_economico_contacto_emergencia_parentesco = txt_emeparentesco.Text;
                sso.Socio_economico_contacto_emergencia_telefono = txt_emetelefono.Text;
                sso.Socio_economico_contacto_emergencia_calle_principal = txt_emecalleprincipal.Text;
                sso.Socio_economico_contacto_emergencia_numero_domicilio = txt_emenumdomicilio.Text;
                sso.Socio_economico_contacto_emergencia_calle_secundaria = txt_emecallesecun.Text;
                sso.Socio_economico_contacto_emergencia_referencia_domicilio = txt_emerefubicardomicilio.Text;

                sso.Socio_economico_moviliza_trabajo_vivienda = txt_movilizatrabajoovivienda.Text;

                //Salud
                sso.Socio_economico_posee_enfermedad = txt_poseeenfermedadprexistente.Text;
                sso.Socio_economico_discapacidad_tipo = txt_tipodiscapacidad.Text;
                sso.Socio_economico_discapacidad_porcentaje = txt_porcentajediscapacidad.Text;
                sso.Socio_economico_discapacidad_carnet_conadis = txt_numcarnetconadis.Text;
                sso.Socio_economico_discapacidad_fecha_caducidad_carnet = txt_fechacaducidadcarnet.Text;

                sso.Socio_economico_estado_gestacion_tiempo = txt_gestacióntiempo.Text;
                sso.Socio_economico_fecha_tentativa_parto = txt_fechatentativaparto.Text;
                sso.Socio_economico_periodo_lactancia_fecha_culminacion = txt_fechaculmicacionlactancia.Text;

                sso.Socio_economico_enfermedad_cronica_cual = txt_cualcatastrofica.Text;
                sso.Socio_economico_enfermedad_cronica_otras_enfermedades = txt_otrasenfermedadescat.Text;
                sso.Socio_economico_enfermedad_rara_cual = txt_enfermedadraracual.Text;

                sso.Socio_economico_consume_alcohol_causa = txt_causaconsumoalcohol.Text;
                sso.Socio_economico_consume_alcohol_tiempo_consumo = txt_tiempoconsumoalcohol.Text;
                sso.Socio_economico_consume_tabaco_frecuencia_consumo = txt_frecuenciaconsumotabaco.Text;
                sso.Socio_economico_consume_tabaco_tiempo_consumo = txt_tiempoconsumotabaco.Text;
                sso.Socio_economico_consume_sustancia_psicotropica_tipo = txt_sustanciapsicotropicatipo.Text;
                sso.Socio_economico_consume_sustancia_psicotropica_frecuencia_consumo = txt_sustanciapsicotropicafrecuencia.Text;

                //Situacion económica del servidor
                sso.Socio_economico_numero_miembro_economicamente_activos = Convert.ToInt32(txt_miembroactivoseconomicamente.Text);

                sso.Socio_economico_total_ingresos_mensuales_proyectados_1 = Convert.ToInt32(txt_totalingresos1.Text);
                sso.Socio_economico_ayuda1 = Convert.ToInt32(txt_ayuda1.Text);
                sso.Socio_economico_otros1 = Convert.ToInt32(txt_otros1.Text);
                sso.Socio_economico_total_egresos_alimentacion = Convert.ToInt32(txt_alimentación.Text);

                sso.Socio_economico_total_ingresos_mensuales_proyectados_2 = Convert.ToInt32(txt_totalingresos2.Text);
                sso.Socio_economico_ayuda2 = Convert.ToInt32(txt_ayuda2.Text);
                sso.Socio_economico_otros2 = Convert.ToInt32(txt_otros2.Text);
                sso.Socio_economico_total_egresos_vivienda = Convert.ToInt32(txt_vivienda.Text);

                sso.Socio_economico_total_ingresos_mensuales_proyectados_3 = Convert.ToInt32(txt_totalingresos3.Text);
                sso.Socio_economico_ayuda3 = Convert.ToInt32(txt_ayuda3.Text);
                sso.Socio_economico_otros3 = Convert.ToInt32(txt_otros3.Text);
                sso.Socio_economico_total_egresos_educacion = Convert.ToInt32(txt_educación.Text);

                sso.Socio_economico_total_ingresos_mensuales_proyectados_4 = Convert.ToInt32(txt_totalingresos4.Text);
                sso.Socio_economico_ayuda4 = Convert.ToInt32(txt_ayuda4.Text);
                sso.Socio_economico_otros4 = Convert.ToInt32(txt_otros4.Text);
                sso.Socio_economico_total_egresos_servicios_basicos = Convert.ToInt32(txt_serviciosbasicos.Text);

                sso.Socio_economico_total_ingresos_mensuales_proyectados_5 = Convert.ToInt32(txt_totalingresos5.Text);
                sso.Socio_economico_ayuda5 = Convert.ToInt32(txt_ayuda5.Text);
                sso.Socio_economico_otros5 = Convert.ToInt32(txt_otros5.Text);
                sso.Socio_economico_total_egresos_salud = Convert.ToInt32(txt_salud.Text);

                sso.Socio_economico_total_ingresos_mensuales_proyectados_6 = Convert.ToInt32(txt_totalingresos6.Text);
                sso.Socio_economico_ayuda6 = Convert.ToInt32(txt_ayuda6.Text);
                sso.Socio_economico_otros6 = Convert.ToInt32(txt_otros6.Text);
                sso.Socio_economico_total_egresos_movilizacion = Convert.ToInt32(txt_movilización.Text);

                sso.Socio_economico_total_ingresos_mensuales_proyectados_7 = Convert.ToInt32(txt_totalingresos7.Text);
                sso.Socio_economico_ayuda7 = Convert.ToInt32(txt_ayuda7.Text);
                sso.Socio_economico_otros7 = Convert.ToInt32(txt_otros7.Text);
                sso.Socio_economico_total_egresos_deudas = Convert.ToInt32(txt_deudas.Text);

                sso.Socio_economico_total_ingresos_mensuales_proyectados_8 = Convert.ToInt32(txt_totalingresos8.Text);
                sso.Socio_economico_ayuda8 = Convert.ToInt32(txt_ayuda8.Text);
                sso.Socio_economico_otros8 = Convert.ToInt32(txt_otros8.Text);
                sso.Socio_economico_total_egresos_pensiones_otros = Convert.ToInt32(txt_otrospensiones.Text);

                sso.Socio_economico_total_ingresos_mensuales_proyectados_total_9 = Convert.ToInt32(txt_totalingresos9.Text);
                sso.Socio_economico_ayuda_y_otros_total_9 = Convert.ToInt32(txt_totalayudayotros9.Text);
                sso.Socio_economico_total_egresos_total_9 = Convert.ToInt32(txt_totalegresos.Text);

                sso.Socio_economico_descripcion_mueble_valor_casa = Convert.ToInt32(txt_biencasa.Text);
                sso.Socio_economico_descripcion_mueble_valor_departamento = Convert.ToInt32(txt_biendepartamento.Text);
                sso.Socio_economico_descripcion_mueble_valor_vehiculo = Convert.ToInt32(txt_bienvehiculo.Text);
                sso.Socio_economico_descripcion_mueble_valor_terreno = Convert.ToInt32(txt_bienterreno.Text);
                sso.Socio_economico_descripcion_mueble_valor_negocio = Convert.ToInt32(txt_bienegocio.Text);
                sso.Socio_economico_descripcion_mueble_valor_muebles_enseres = Convert.ToInt32(txt_bienmueblesyenseres.Text);

                sso.Socio_economico_caracteristica_vivienda_descripcion_otra_especifique = txt_otrodescripcionviviendafamilia.Text;
                sso.Socio_economico_caracteristica_vivienda_tenencia_otra_especifique = txt_otratenencia.Text;
                sso.Socio_economico_caracteristica_vivienda_tipo_otro_especifique = txt_otrotipodecasa.Text;
                sso.Socio_economico_caracteristica_vivienda_distribucion_otro_especifique = txt_otradistribucioncasa.Text;
                sso.Socio_economico_caracteristica_vivienda_otro_especifique = txt_otrainformacioncasa.Text;

                //Información Familiar
                sso.Socio_economico_nombres_apellidos_familiar1 = txt_nomapellidos1.Text;
                sso.Socio_economico_parentesco_familiar1 = txt_parentesco1.Text;
                sso.Socio_economico_fecha_nacimiento_familiar1 = txt_fechanacimiento1.Text;
                sso.Socio_economico_edad_familiar1 = txt_edad1.Text;

                sso.Socio_economico_nombres_apellidos_familiar2 = txt_nomapellidos2.Text;
                sso.Socio_economico_parentesco_familiar2 = txt_parentesco2.Text;
                sso.Socio_economico_fecha_nacimiento_familiar2 = txt_fechanacimiento2.Text;
                sso.Socio_economico_edad_familiar2 = txt_edad2.Text;

                sso.Socio_economico_nombres_apellidos_familiar3 = txt_nomapellidos3.Text;
                sso.Socio_economico_parentesco_familiar3 = txt_parentesco3.Text;
                sso.Socio_economico_fecha_nacimiento_familiar3 = txt_fechanacimiento3.Text;
                sso.Socio_economico_edad_familiar3 = txt_edad3.Text;

                sso.Socio_economico_nombres_apellidos_familiar4 = txt_nomapellidos4.Text;
                sso.Socio_economico_parentesco_familiar4 = txt_parentesco4.Text;
                sso.Socio_economico_fecha_nacimiento_familiar4 = txt_fechanacimiento4.Text;
                sso.Socio_economico_edad_familiar4 = txt_edad4.Text;

                sso.Socio_economico_nombres_apellidos_familiar5 = txt_nomapellidos5.Text;
                sso.Socio_economico_parentesco_familiar5 = txt_parentesco5.Text;
                sso.Socio_economico_fecha_nacimiento_familiar5 = txt_fechanacimiento5.Text;
                sso.Socio_economico_edad_familiar5 = txt_edad5.Text;

                sso.Socio_economico_nombres_apellidos_familiar_discapacidad1 = txt_familiardiscapacitadonomape1.Text;
                sso.Socio_economico_fecha_caducidad_carnet_familiar_discapacidad1 = txt_familiardiscapacitadofechacaducidadcarnet1.Text;
                sso.Socio_economico_familiar_discapacidad_tipo1 = txt_familiardiscapacitadotipodiscapacidad1.Text;
                sso.Socio_economico_familiar_discapacidad_porcentaje1 = txt_familiardiscapacitadoporcentajediscapacidad1.Text;
                sso.Socio_economico_familiar_discapacidad_parentesco1 = txt_familiardiscapacitadoparentesco1.Text;
                sso.Socio_economico_familiar_discapacidad_fecha_nacimiento1 = txt_familiardiscapacitadofechanacimiento1.Text;

                sso.Socio_economico_nombres_apellidos_familiar_discapacidad2 = txt_familiardiscapacitadonomape2.Text;
                sso.Socio_economico_fecha_caducidad_carnet_familiar_discapacidad2 = txt_familiardiscapacitadofechacaducidadcarnet2.Text;
                sso.Socio_economico_familiar_discapacidad_tipo2 = txt_familiardiscapacitadotipodiscapacidad2.Text;
                sso.Socio_economico_familiar_discapacidad_porcentaje2 = txt_familiardiscapacitadoporcentajediscapacidad2.Text;
                sso.Socio_economico_familiar_discapacidad_parentesco2 = txt_familiardiscapacitadoparentesco2.Text;
                sso.Socio_economico_familiar_discapacidad_fecha_nacimiento2 = txt_familiardiscapacitadofechanacimiento2.Text;

                sso.Socio_economico_registrar_dependencia_familiar_MT_tiempo = txt_dependenciaministeriotrabajotiempo.Text;
                sso.Socio_economico_registrar_dependencia_familiar_MT_numero_carnetMSP = txt_numcarnetMSP.Text;
                sso.Socio_economico_a_cargo_familiar_enfermedad_catastrofica_rara_tiempo = txt_acargofamiliarenfermedadraratiempo.Text;
                sso.Socio_economico_a_cargo_familiar_enfermedad_catastrofica_rara_tipoenfermedad = txt_familiarenfermedadraratipo.Text;

                //Actividad tiempo libre
                sso.Socio_economico_otro_especifique = txt_otraactividad.Text;
                sso.Socio_economico_actividad_economica_adicional_detalle = txt_actividadeconomicadetalle.Text;
                sso.Socio_economico_actividad_economica_adicional_tiempo_destina = txt_actividadeconomicatiempodestina.Text;
                sso.Socio_economico_actividad_economica_adicional_hace_tiempo = txt_actividadeconomicatiemporealiza.Text;
                sso.Socio_economico_actividad_deportiva_especificar = txt_especifiquedeporte.Text;
                sso.Socio_economico_actividad_deportiva_frecuencia = txt_frecuenciadeporte.Text;
                sso.Socio_economico_actividad_deportiva_edad = txt_edadpracticadeporte.Text;
                sso.Socio_economico_lesion_tipo = txt_tipolesion.Text;
                sso.Socio_economico_lesion_edad = txt_edadlesion.Text;

                //Informacion para uso de bienestar familiar
                sso.Socio_economico_evaluacion_relacion_familiar_porque = txt_relacionfamiliarporque.Text;
                sso.Socio_economico_evaluacion_relacion_pareja_porque = txt_relacionparejaporque.Text;
                sso.Socio_economico_evaluacion_relacion_hijos_porque = txt_relacionconhijosporque.Text;
                sso.Socio_economico_problemas_familiares_observaciones = txt_observacionesfamiliares.Text;
                sso.Socio_economico_nivel_salud_familia_porque = txt_nivelsaludfamiliarporque.Text;
                sso.Socio_economico_familia_observaciones = txt_observacionesgenerales.Text;
                sso.Socio_economico_informacion_adicional = txt_informacionadicional.Text;

                //DATOS GENERALES
                //Modalidad de Trabajo
                if (cb_modalidadvinculacionlosep.Checked == true)
                {
                    sso.Socio_economico_modalidadvinculacion_leyorgserpublico = "SI";
                }
                else
                {
                    sso.Socio_economico_modalidadvinculacion_leyorgserpublico = null;
                }
                if (cb_modalidadvinculacioncodigotrabajo.Checked == true)
                {
                    sso.Socio_economico_modalidadvinculacion_codigotrabajo = "SI";
                }
                else
                {
                    sso.Socio_economico_modalidadvinculacion_codigotrabajo = null;
                }
                //Estado Civil
                if (cb_soltero.Checked == true)
                {
                    sso.Socio_economico_estadocivil_soltero = "SI";
                }
                else
                {
                    sso.Socio_economico_estadocivil_soltero = null;
                }
                if (cb_casado.Checked == true)
                {
                    sso.Socio_economico_estadocivil_casado = "SI";
                }
                else
                {
                    sso.Socio_economico_estadocivil_casado = null;
                }
                if (cb_viudo.Checked == true)
                {
                    sso.Socio_economico_estadocivil_viudo = "SI";
                }
                else
                {
                    sso.Socio_economico_estadocivil_viudo = null;
                }
                if (cb_unionlibre.Checked == true)
                {
                    sso.Socio_economico_estadocivil_unionlibre = "SI";
                }
                else
                {
                    sso.Socio_economico_estadocivil_unionlibre = null;
                }
                if (cb_divorciado.Checked == true)
                {
                    sso.Socio_economico_estadocivil_divorciado = "SI";
                }
                else
                {
                    sso.Socio_economico_estadocivil_divorciado = null;
                }
                //Genero
                if (cb_genmasculino.Checked == true)
                {
                    sso.Socio_economico_genero_masculino = "SI";
                }
                else
                {
                    sso.Socio_economico_genero_masculino = null;
                }
                if (cb_genfemenino.Checked == true)
                {
                    sso.Socio_economico_genero_femenino = "SI";
                }
                else
                {
                    sso.Socio_economico_genero_femenino = null;
                }
                //Donante
                if (cb_donantesi.Checked == true)
                {
                    sso.Socio_economico_es_donante_si = "SI";
                }
                else
                {
                    sso.Socio_economico_es_donante_si = null;
                }
                if (cb_donanteno.Checked == true)
                {
                    sso.Socio_economico_es_donante_no = "SI";
                }
                else
                {
                    sso.Socio_economico_es_donante_no = null;
                }
                //Nivel de educación
                if (cb_primaria.Checked == true)
                {
                    sso.Socio_economico_titulo_primaria = "SI";
                }
                else
                {
                    sso.Socio_economico_titulo_primaria = null;
                }
                if (cb_secundaria.Checked == true)
                {
                    sso.Socio_economico_titulo_secundaria = "SI";
                }
                else
                {
                    sso.Socio_economico_titulo_secundaria = null;
                }
                if (cb_superior.Checked == true)
                {
                    sso.Socio_economico_titulo_superior = "SI";
                }
                else
                {
                    sso.Socio_economico_titulo_superior = null;
                }
                if (cb_especializacion.Checked == true)
                {
                    sso.Socio_economico_titulo_especializacion = "SI";
                }
                else
                {
                    sso.Socio_economico_titulo_especializacion = null;
                }
                if (cb_diplomado.Checked == true)
                {
                    sso.Socio_economico_titulo_diplomado = "SI";
                }
                else
                {
                    sso.Socio_economico_titulo_diplomado = null;
                }
                if (cb_maestria.Checked == true)
                {
                    sso.Socio_economico_titulo_maestria = "SI";
                }
                else
                {
                    sso.Socio_economico_titulo_maestria = null;
                }
                //Autoidentificacion Étnica
                if (cb_blanco.Checked == true)
                {
                    sso.Socio_economico_autoidentificacionetnica_blanco = "SI";
                }
                else
                {
                    sso.Socio_economico_autoidentificacionetnica_blanco = null;
                }
                if (cb_mestizo.Checked == true)
                {
                    sso.Socio_economico_autoidentificacionetnica_mestizo = "SI";
                }
                else
                {
                    sso.Socio_economico_autoidentificacionetnica_mestizo = null;
                }
                if (cb_afro.Checked == true)
                {
                    sso.Socio_economico_autoidentificacionetnica_afrodescendiente = "SI";
                }
                else
                {
                    sso.Socio_economico_autoidentificacionetnica_afrodescendiente = null;
                }
                if (cb_indigena.Checked == true)
                {
                    sso.Socio_economico_autoidentificacionetnica_indigena = "SI";
                }
                else
                {
                    sso.Socio_economico_autoidentificacionetnica_indigena = null;
                }
                if (cb_montubio.Checked == true)
                {
                    sso.Socio_economico_autoidentificacionetnica_montubio = "SI";
                }
                else
                {
                    sso.Socio_economico_autoidentificacionetnica_montubio = null;
                }
                //Sector donde vive
                if (cb_norte.Checked == true)
                {
                    sso.Socio_economico_sectorvive_norte = "SI";
                }
                else
                {
                    sso.Socio_economico_sectorvive_norte = null;
                }
                if (cb_centro.Checked == true)
                {
                    sso.Socio_economico_sectorvive_centro = "SI";
                }
                else
                {
                    sso.Socio_economico_sectorvive_centro = null;
                }
                if (cb_sur.Checked == true)
                {
                    sso.Socio_economico_sectorvive_sur = "SI";
                }
                else
                {
                    sso.Socio_economico_sectorvive_sur = null;
                }
                if (cb_valle.Checked == true)
                {
                    sso.Socio_economico_sectorvive_valle = "SI";
                }
                else
                {
                    sso.Socio_economico_sectorvive_valle = null;
                }
                if (cb_valledeloschillos.Checked == true)
                {
                    sso.Socio_economico_sectorvive_valledeloschillos = "SI";
                }
                else
                {
                    sso.Socio_economico_sectorvive_valledeloschillos = null;
                }
                //Tipo de vivienda
                if (cb_casa.Checked == true)
                {
                    sso.Socio_economico_tipovivienda_casa = "SI";
                }
                else
                {
                    sso.Socio_economico_tipovivienda_casa = null;
                }
                if (cb_departamento.Checked == true)
                {
                    sso.Socio_economico_tipovivienda_departamento = "SI";
                }
                else
                {
                    sso.Socio_economico_tipovivienda_departamento = null;
                }
                //Riesgo Delincuencial
                if (cb_riesgoalto.Checked == true)
                {
                    sso.Socio_economico_riesgo_delincuencial_alto = "SI";
                }
                else
                {
                    sso.Socio_economico_riesgo_delincuencial_alto = null;
                }
                if (cb_riesgomedio.Checked == true)
                {
                    sso.Socio_economico_riesgo_delincuencial_medio = "SI";
                }
                else
                {
                    sso.Socio_economico_riesgo_delincuencial_medio = null;
                }
                if (cb_riesgobajo.Checked == true)
                {
                    sso.Socio_economico_riesgo_delincuencial_bajo = "SI";
                }
                else
                {
                    sso.Socio_economico_riesgo_delincuencial_bajo = null;
                }
                //Dinero ahorro
                if (cb_dineroahorrosi.Checked == true)
                {
                    sso.Socio_economico_dinero_ahorro_si = "SI";
                }
                else
                {
                    sso.Socio_economico_dinero_ahorro_si = null;
                }
                if (cb_dineroahorrono.Checked == true)
                {
                    sso.Socio_economico_dinero_ahorro_no = "SI";
                }
                else
                {
                    sso.Socio_economico_dinero_ahorro_no = null;
                }
                //Vehiculo propio
                if (cb_vehiculosi.Checked == true)
                {
                    sso.Socio_economico_vehiculo_propio_si = "SI";
                }
                else
                {
                    sso.Socio_economico_vehiculo_propio_si = null;
                }
                if (cb_vehiculono.Checked == true)
                {
                    sso.Socio_economico_vehiculo_propio_no = "SI";
                }
                else
                {
                    sso.Socio_economico_vehiculo_propio_no = null;
                }
                //Recorrido Institucional
                if (cb_recorridosi.Checked == true)
                {
                    sso.Socio_economico_recorrido_institucional_si = "SI";
                }
                else
                {
                    sso.Socio_economico_recorrido_institucional_si = null;
                }
                if (cb_recorridono.Checked == true)
                {
                    sso.Socio_economico_recorrido_institucional_no = "SI";
                }
                else
                {
                    sso.Socio_economico_recorrido_institucional_no = null;
                }

                //SALUD
                //Posee Discapacidad
                if (cb_discapacidadsi.Checked == true)
                {
                    sso.Socio_economico_discapacidad_si = "SI";
                }
                else
                {
                    sso.Socio_economico_discapacidad_si = null;
                }
                if (cb_discapacidadno.Checked == true)
                {
                    sso.Socio_economico_discapacidad_no = "SI";
                }
                else
                {
                    sso.Socio_economico_discapacidad_no = null;
                }
                //Gestacion 
                if (cb_gestaciónsi.Checked == true)
                {
                    sso.Socio_economico_estado_gestacion_si = "SI";
                }
                else
                {
                    sso.Socio_economico_estado_gestacion_si = null;
                }
                if (cb_gestaciónno.Checked == true)
                {
                    sso.Socio_economico_estado_gestacion_no = "SI";
                }
                else
                {
                    sso.Socio_economico_estado_gestacion_no = null;
                }
                //Periodo Lactancia
                if (cb_lactaciasi.Checked == true)
                {
                    sso.Socio_economico_periodo_lactancia_si = "SI";
                }
                else
                {
                    sso.Socio_economico_periodo_lactancia_si = null;
                }
                if (cb_lactaciano.Checked == true)
                {
                    sso.Socio_economico_periodo_lactancia_no = "SI";
                }
                else
                {
                    sso.Socio_economico_periodo_lactancia_no = null;
                }
                //Enfermedad catastrófica
                if (cb_catastroficasi.Checked == true)
                {
                    sso.Socio_economico_enfermedad_cronica_si = "SI";
                }
                else
                {
                    sso.Socio_economico_enfermedad_cronica_si = null;
                }
                if (cb_catastroficano.Checked == true)
                {
                    sso.Socio_economico_enfermedad_cronica_no = "SI";
                }
                else
                {
                    sso.Socio_economico_enfermedad_cronica_no = null;
                }
                //Enfermedad rara
                if (cb_enfermedadrarasi.Checked == true)
                {
                    sso.Socio_economico_enfermedad_rara_si = "SI";
                }
                else
                {
                    sso.Socio_economico_enfermedad_rara_si = null;
                }
                if (cb_enfermedadrarano.Checked == true)
                {
                    sso.Socio_economico_enfermedad_rara_no = "SI";
                }
                else
                {
                    sso.Socio_economico_enfermedad_rara_no = null;
                }
                //Consumo alcohol
                if (cb_alcoholsi.Checked == true)
                {
                    sso.Socio_economico_consume_alcohol_si = "SI";
                }
                else
                {
                    sso.Socio_economico_consume_alcohol_si = null;
                }
                if (cb_alcoholno.Checked == true)
                {
                    sso.Socio_economico_consume_alcohol_no = "SI";
                }
                else
                {
                    sso.Socio_economico_consume_alcohol_no = null;
                }
                //Frecuencia consumo alcohol
                if (cb_consumoalcoholdiario.Checked == true)
                {
                    sso.Socio_economico_consume_alcohol_frecuencia_diaria = "SI";
                }
                else
                {
                    sso.Socio_economico_consume_alcohol_frecuencia_diaria = null;
                }
                if (cb_consumoalcoholsemanal.Checked == true)
                {
                    sso.Socio_economico_consume_alcohol_frecuencia_semanal = "SI";
                }
                else
                {
                    sso.Socio_economico_consume_alcohol_frecuencia_semanal = null;
                }
                if (cb_consumoalcoholquincenal.Checked == true)
                {
                    sso.Socio_economico_consume_alcohol_frecuencia_quincenal = "SI";
                }
                else
                {
                    sso.Socio_economico_consume_alcohol_frecuencia_quincenal = null;
                }
                if (cb_consumoalcoholmensual.Checked == true)
                {
                    sso.Socio_economico_consume_alcohol_frecuencia_mensual = "SI";
                }
                else
                {
                    sso.Socio_economico_consume_alcohol_frecuencia_mensual = null;
                }
                if (cb_consumoalcoholreuniones.Checked == true)
                {
                    sso.Socio_economico_consume_alcohol_frecuencia_reuniones = "SI";
                }
                else
                {
                    sso.Socio_economico_consume_alcohol_frecuencia_reuniones = null;
                }
                //Consumo tabaco
                if (cb_tabacosi.Checked == true)
                {
                    sso.Socio_economico_consume_tabaco_si = "SI";
                }
                else
                {
                    sso.Socio_economico_consume_tabaco_si = null;
                }
                if (cb_tabacono.Checked == true)
                {
                    sso.Socio_economico_consume_tabaco_no = "SI";
                }
                else
                {
                    sso.Socio_economico_consume_tabaco_no = null;
                }
                //Consumo sustancia psicotrópica
                if (cb_sustanciapsicotropicasi.Checked == true)
                {
                    sso.Socio_economico_consume_sustancia_psicotropica_si = "SI";
                }
                else
                {
                    sso.Socio_economico_consume_sustancia_psicotropica_si = null;
                }
                if (cb_sustanciapsicotropicano.Checked == true)
                {
                    sso.Socio_economico_consume_sustancia_psicotropica_no = "SI";
                }
                else
                {
                    sso.Socio_economico_consume_sustancia_psicotropica_no = null;
                }
                //Consumo sustancia psicotrópica
                if (cb_familiares.Checked == true)
                {
                    sso.Socio_economico_problemas_consumo_familiares = "SI";
                }
                else
                {
                    sso.Socio_economico_problemas_consumo_familiares = null;
                }
                if (cb_laborales.Checked == true)
                {
                    sso.Socio_economico_problemas_consumo_familiares = "SI";
                }
                else
                {
                    sso.Socio_economico_problemas_consumo_familiares = null;
                }
                if (cb_economicos.Checked == true)
                {
                    sso.Socio_economico_problemas_consumo_economicos = "SI";
                }
                else
                {
                    sso.Socio_economico_problemas_consumo_economicos = null;
                }
                if (cb_salud.Checked == true)
                {
                    sso.Socio_economico_problemas_consumo_salud = "SI";
                }
                else
                {
                    sso.Socio_economico_problemas_consumo_salud = null;
                }
                if (cb_legales.Checked == true)
                {
                    sso.Socio_economico_problemas_consumo_legales = "SI";
                }
                else
                {
                    sso.Socio_economico_problemas_consumo_legales = null;
                }

                //CARACTERISTICA DE LA VIVIENDA
                //Descripcion
                if (cb_unifamiliar.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_descripcion_unifamiliar = "SI";
                }
                else
                {
                    sso.Socio_economico_caracteristica_vivienda_descripcion_unifamiliar = null;
                }
                if (cb_multifamiliar.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_descripcion_multifamiliar = "SI";
                }
                else
                {
                    sso.Socio_economico_caracteristica_vivienda_descripcion_multifamiliar = null;
                }
                //Tenencia
                if (cb_propiasindeuda.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_tenencia_propia_sin_deuda = "SI";
                }
                else
                {
                    sso.Socio_economico_caracteristica_vivienda_tenencia_propia_sin_deuda = null;
                }
                if (cb_arrendada.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_tenencia_arrendada = "SI";
                }
                else
                {
                    sso.Socio_economico_caracteristica_vivienda_tenencia_arrendada = null;
                }
                if (cb_defamilia.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_tenencia_de_familia = "SI";
                }
                else
                {
                    sso.Socio_economico_caracteristica_vivienda_tenencia_de_familia = null;
                }
                if (cb_hipotecada.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_tenencia_hipotecada = "SI";
                }
                else
                {
                    sso.Socio_economico_caracteristica_vivienda_tenencia_hipotecada = null;
                }
                if (cb_prestada.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_tenencia_prestada = "SI";
                }
                else
                {
                    sso.Socio_economico_caracteristica_vivienda_tenencia_prestada = null;
                }
                if (cb_anticreces.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_tenencia_anticreces = "SI";
                }
                else
                {
                    sso.Socio_economico_caracteristica_vivienda_tenencia_anticreces = null;
                }
                //Tipo
                if (cb_tipocasa.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_tipo_casa = "SI";
                }
                else
                {
                    sso.Socio_economico_caracteristica_vivienda_tipo_casa = null;
                }
                if (cb_tiposuit.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_tipo_suit = "SI";
                }
                else
                {
                    sso.Socio_economico_caracteristica_vivienda_tipo_suit = null;
                }
                if (cb_tipomediagua.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_tipo_mediagua = "SI";
                }
                else
                {
                    sso.Socio_economico_caracteristica_vivienda_tipo_mediagua = null;
                }
                if (cb_tipodepartamento.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_tipo_departamento = "SI";
                }
                else
                {
                    sso.Socio_economico_caracteristica_vivienda_tipo_departamento = null;
                }
                if (cb_tipopieza.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_tipo_pieza = "SI";
                }
                else
                {
                    sso.Socio_economico_caracteristica_vivienda_tipo_pieza = null;
                }
                //Distribucion
                if (cb_habitacion.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_distribucion_habitacion = "SI";
                }
                else
                {
                    sso.Socio_economico_caracteristica_vivienda_distribucion_habitacion = null;
                }
                if (cb_sala.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_distribucion_sala = "SI";
                }
                else
                {
                    sso.Socio_economico_caracteristica_vivienda_distribucion_sala = null;
                }
                if (cb_baño.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_distribucion_baño = "SI";
                }
                else
                {
                    sso.Socio_economico_caracteristica_vivienda_distribucion_baño = null;
                }
                if (cb_garage.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_distribucion_garage = "SI";
                }
                else
                {
                    sso.Socio_economico_caracteristica_vivienda_distribucion_garage = null;
                }
                if (cb_comedor.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_distribucion_comedor = "SI";
                }
                else
                {
                    sso.Socio_economico_caracteristica_vivienda_distribucion_comedor = null;
                }
                if (cb_cocina.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_distribucion_cocina = "SI";
                }
                else
                {
                    sso.Socio_economico_caracteristica_vivienda_distribucion_cocina = null;
                }
                if (cb_patio.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_distribucion_patio = "SI";
                }
                else
                {
                    sso.Socio_economico_caracteristica_vivienda_distribucion_patio = null;
                }
                if (cb_bodega.Checked == true)
                {
                    sso.Socio_economico_caracteristica_vivienda_distribucion_bodega = "SI";
                }
                else
                {
                    sso.Socio_economico_caracteristica_vivienda_distribucion_bodega = null;
                }

                //INFORMACION FAMILIAR
                //Persona discapacidad
                if (cb_nucleodiscapacidadsi.Checked == true)
                {
                    sso.Socio_economico_nucleofamiliar_persona_discapacidad_si = "SI";
                }
                else
                {
                    sso.Socio_economico_nucleofamiliar_persona_discapacidad_si = null;
                }
                if (cb_nucleodiscapacidadno.Checked == true)
                {
                    sso.Socio_economico_nucleofamiliar_persona_discapacidad_no = "SI";
                }
                else
                {
                    sso.Socio_economico_nucleofamiliar_persona_discapacidad_no = null;
                }
                if (cb_acargofamiliardiacapacitadosi.Checked == true)
                {
                    sso.Socio_economico_acargo_de_persona_discapacidad_si = "SI";
                }
                else
                {
                    sso.Socio_economico_acargo_de_persona_discapacidad_si = null;
                }
                if (cb_acargofamiliardiacapacitadono.Checked == true)
                {
                    sso.Socio_economico_acargo_de_persona_discapacidad_no = "SI";
                }
                else
                {
                    sso.Socio_economico_acargo_de_persona_discapacidad_no = null;
                }
                //Dependencia ministerio de trabajo
                if (cb_dependenciaministeriotrabajosi.Checked == true)
                {
                    sso.Socio_economico_registrar_dependencia_familiar_MT_si = "SI";
                }
                else
                {
                    sso.Socio_economico_registrar_dependencia_familiar_MT_si = null;
                }
                if (cb_dependenciaministeriotrabajono.Checked == true)
                {
                    sso.Socio_economico_registrar_dependencia_familiar_MT_no = "SI";
                }
                else
                {
                    sso.Socio_economico_registrar_dependencia_familiar_MT_no = null;
                }
                //A cargo de persona con enfermedad catastrófica
                if (cb_acargofamiliarenfermedadrarasi.Checked == true)
                {
                    sso.Socio_economico_a_cargo_familiar_enfermedad_catastrofica_rara_si = "SI";
                }
                else
                {
                    sso.Socio_economico_a_cargo_familiar_enfermedad_catastrofica_rara_si = null;
                }
                if (cb_acargofamiliarenfermedadrarano.Checked == true)
                {
                    sso.Socio_economico_a_cargo_familiar_enfermedad_catastrofica_rara_no = "SI";
                }
                else
                {
                    sso.Socio_economico_a_cargo_familiar_enfermedad_catastrofica_rara_no = null;
                }

                //ACTIVIDAD EN TIEMPO LIBRE
                //Actividad inicial
                if (cb_hogar.Checked == true)
                {
                    sso.Socio_economico_hogar = "SI";
                }
                else
                {
                    sso.Socio_economico_hogar = null;
                }
                if (cb_paseosfamiliares.Checked == true)
                {
                    sso.Socio_economico_paseos_familiares = "SI";
                }
                else
                {
                    sso.Socio_economico_paseos_familiares = null;
                }
                if (cb_estudios.Checked == true)
                {
                    sso.Socio_economico_estudios = "SI";
                }
                else
                {
                    sso.Socio_economico_estudios = null;
                }
                if (cb_actividadesartisticas.Checked == true)
                {
                    sso.Socio_economico_actividades_artisticas = "SI";
                }
                else
                {
                    sso.Socio_economico_actividades_artisticas = null;
                }
                //Actividad economica adicional
                if (cb_actividadeconomicasi.Checked == true)
                {
                    sso.Socio_economico_actividad_economica_adicional_si = "SI";
                }
                else
                {
                    sso.Socio_economico_actividad_economica_adicional_si = null;
                }
                if (cb_actividadeconomicano.Checked == true)
                {
                    sso.Socio_economico_actividad_economica_adicional_no = "SI";
                }
                else
                {
                    sso.Socio_economico_actividad_economica_adicional_no = null;
                }
                //Actividad deportiva
                if (cb_deportesi.Checked == true)
                {
                    sso.Socio_economico_actividad_deportiva_si = "SI";
                }
                else
                {
                    sso.Socio_economico_actividad_deportiva_si = null;
                }
                if (cb_deporteno.Checked == true)
                {
                    sso.Socio_economico_actividad_deportiva_no = "SI";
                }
                else
                {
                    sso.Socio_economico_actividad_deportiva_no = null;
                }
                //Lesión
                if (cb_lesionsi.Checked == true)
                {
                    sso.Socio_economico_lesion_si = "SI";
                }
                else
                {
                    sso.Socio_economico_lesion_si = null;
                }
                if (cb_lesionno.Checked == true)
                {
                    sso.Socio_economico_lesion_no = "SI";
                }
                else
                {
                    sso.Socio_economico_lesion_no = null;
                }
                //Tratamiento
                if (cb_tratamientosi.Checked == true)
                {
                    sso.Socio_economico_lesion_tratamiento_si = "SI";
                }
                else
                {
                    sso.Socio_economico_lesion_tratamiento_si = null;
                }
                if (cb_tratamientono.Checked == true)
                {
                    sso.Socio_economico_lesion_tratamiento_no = "SI";
                }
                else
                {
                    sso.Socio_economico_lesion_tratamiento_no = null;
                }

                //INFORMACION BIENESTAR FAMILIAR
                //Tipo familia
                if (cb_nuclear.Checked == true)
                {
                    sso.Socio_economico_tipo_familia_nuclear = "SI";
                }
                else
                {
                    sso.Socio_economico_tipo_familia_nuclear = null;
                }
                if (cb_ampliada.Checked == true)
                {
                    sso.Socio_economico_tipo_familia_ampliada = "SI";
                }
                else
                {
                    sso.Socio_economico_tipo_familia_ampliada = null;
                }
                if (cb_monoparental.Checked == true)
                {
                    sso.Socio_economico_tipo_familia_monoparental = "SI";
                }
                else
                {
                    sso.Socio_economico_tipo_familia_monoparental = null;
                }
                if (cb_vivesolo.Checked == true)
                {
                    sso.Socio_economico_tipo_familia_vive_solo = "SI";
                }
                else
                {
                    sso.Socio_economico_tipo_familia_vive_solo = null;
                }
                if (cb_viveconamigos.Checked == true)
                {
                    sso.Socio_economico_tipo_familia_vive_amigos = "SI";
                }
                else
                {
                    sso.Socio_economico_tipo_familia_vive_amigos = null;
                }
                if (cb_familiasinhijos.Checked == true)
                {
                    sso.Socio_economico_tipo_familia_sin_hijos = "SI";
                }
                else
                {
                    sso.Socio_economico_tipo_familia_sin_hijos = null;
                }
                //Relacion familiar
                if (cb_relacionfamiliarmuybuena.Checked == true)
                {
                    sso.Socio_economico_evaluacion_relacion_familiar_muybueno = "SI";
                }
                else
                {
                    sso.Socio_economico_evaluacion_relacion_familiar_muybueno = null;
                }
                if (cb_relacionfamiliarbuena.Checked == true)
                {
                    sso.Socio_economico_evaluacion_relacion_familiar_bueno = "SI";
                }
                else
                {
                    sso.Socio_economico_evaluacion_relacion_familiar_bueno = null;
                }
                if (cb_relacionfamiliarregular.Checked == true)
                {
                    sso.Socio_economico_evaluacion_relacion_familiar_regular = "SI";
                }
                else
                {
                    sso.Socio_economico_evaluacion_relacion_familiar_regular = null;
                }
                if (cb_relacionfamiliarmala.Checked == true)
                {
                    sso.Socio_economico_evaluacion_relacion_familiar_mala = "SI";
                }
                else
                {
                    sso.Socio_economico_evaluacion_relacion_familiar_mala = null;
                }
                //Relacion pareja
                if (cb_relacionparejamuybuena.Checked == true)
                {
                    sso.Socio_economico_evaluacion_relacion_pareja_muybueno = "SI";
                }
                else
                {
                    sso.Socio_economico_evaluacion_relacion_pareja_muybueno = null;
                }
                if (cb_relacionparejabuena.Checked == true)
                {
                    sso.Socio_economico_evaluacion_relacion_pareja_bueno = "SI";
                }
                else
                {
                    sso.Socio_economico_evaluacion_relacion_pareja_bueno = null;
                }
                if (cb_relacionparejaregular.Checked == true)
                {
                    sso.Socio_economico_evaluacion_relacion_pareja_regular = "SI";
                }
                else
                {
                    sso.Socio_economico_evaluacion_relacion_pareja_regular = null;
                }
                if (cb_relacionparejamala.Checked == true)
                {
                    sso.Socio_economico_evaluacion_relacion_pareja_mala = "SI";
                }
                else
                {
                    sso.Socio_economico_evaluacion_relacion_pareja_mala = null;
                }
                //Relacion con hijos
                if (cb_relacionconhijosmuybuena.Checked == true)
                {
                    sso.Socio_economico_evaluacion_relacion_hijos_muybueno = "SI";
                }
                else
                {
                    sso.Socio_economico_evaluacion_relacion_hijos_muybueno = null;
                }
                if (cb_relacionconhijosbuena.Checked == true)
                {
                    sso.Socio_economico_evaluacion_relacion_hijos_bueno = "SI";
                }
                else
                {
                    sso.Socio_economico_evaluacion_relacion_hijos_bueno = null;
                }
                if (cb_relacionconhijosregular.Checked == true)
                {
                    sso.Socio_economico_evaluacion_relacion_hijos_regular = "SI";
                }
                else
                {
                    sso.Socio_economico_evaluacion_relacion_hijos_regular = null;
                }
                if (cb_relacionconhijosmala.Checked == true)
                {
                    sso.Socio_economico_evaluacion_relacion_hijos_mala = "SI";
                }
                else
                {
                    sso.Socio_economico_evaluacion_relacion_hijos_mala = null;
                }
                //Problemas familiares
                if (cb_economico.Checked == true)
                {
                    sso.Socio_economico_problemas_familiares_economicos = "SI";
                }
                else
                {
                    sso.Socio_economico_problemas_familiares_economicos = null;
                }
                if (cb_comunicacion.Checked == true)
                {
                    sso.Socio_economico_problemas_familiares_comunicacion = "SI";
                }
                else
                {
                    sso.Socio_economico_problemas_familiares_comunicacion = null;
                }
                if (cb_conyugales.Checked == true)
                {
                    sso.Socio_economico_problemas_familiares_conyugales = "SI";
                }
                else
                {
                    sso.Socio_economico_problemas_familiares_conyugales = null;
                }
                if (cb_crianzadehijos.Checked == true)
                {
                    sso.Socio_economico_problemas_familiares_crianza_hijos = "SI";
                }
                else
                {
                    sso.Socio_economico_problemas_familiares_crianza_hijos = null;
                }
                if (cb_adicciones.Checked == true)
                {
                    sso.Socio_economico_problemas_familiares_adicciones = "SI";
                }
                else
                {
                    sso.Socio_economico_problemas_familiares_adicciones = null;
                }
                //Violencia
                if (cb_fisica.Checked == true)
                {
                    sso.Socio_economico_problemas_familiares_violencia_fisica = "SI";
                }
                else
                {
                    sso.Socio_economico_problemas_familiares_violencia_fisica = null;
                }
                if (cb_psicologica.Checked == true)
                {
                    sso.Socio_economico_problemas_familiares_violencia_psicologica = "SI";
                }
                else
                {
                    sso.Socio_economico_problemas_familiares_violencia_psicologica = null;
                }
                if (cb_verbal.Checked == true)
                {
                    sso.Socio_economico_problemas_familiares_violencia_verbal = "SI";
                }
                else
                {
                    sso.Socio_economico_problemas_familiares_violencia_verbal = null;
                }
                if (cb_sexual.Checked == true)
                {
                    sso.Socio_economico_problemas_familiares_violencia_sexual = "SI";
                }
                else
                {
                    sso.Socio_economico_problemas_familiares_violencia_sexual = null;
                }
                //Rol
                if (cb_rolfamiliarsi.Checked == true)
                {
                    sso.Socio_economico_miembro_familiar_rol_si = "SI";
                }
                else
                {
                    sso.Socio_economico_miembro_familiar_rol_si = null;
                }
                if (cb_rolfamiliarno.Checked == true)
                {
                    sso.Socio_economico_miembro_familiar_rol_no = "SI";
                }
                else
                {
                    sso.Socio_economico_miembro_familiar_rol_no = null;
                }
                //Nivel de salud de la familia
                if (cb_nivelsaludfamiliarmuybuena.Checked == true)
                {
                    sso.Socio_economico_nivel_salud_familia_muybueno = "SI";
                }
                else
                {
                    sso.Socio_economico_nivel_salud_familia_muybueno = null;
                }
                if (cb_nivelsaludfamiliarbuena.Checked == true)
                {
                    sso.Socio_economico_nivel_salud_familia_bueno = "SI";
                }
                else
                {
                    sso.Socio_economico_nivel_salud_familia_bueno = null;
                }
                if (cb_nivelsaludfamiliarregular.Checked == true)
                {
                    sso.Socio_economico_nivel_salud_familia_regular = "SI";
                }
                else
                {
                    sso.Socio_economico_nivel_salud_familia_regular = null;
                }
                if (cb_nivelsaludfamiliarmala.Checked == true)
                {
                    sso.Socio_economico_nivel_salud_familia_mala = "SI";
                }
                else
                {
                    sso.Socio_economico_nivel_salud_familia_mala = null;
                }
                //La familia es
                if (cb_funcional.Checked == true)
                {
                    sso.Socio_economico_familia_funcional = "SI";
                }
                else
                {
                    sso.Socio_economico_familia_funcional = null;
                }
                if (cb_disfuncional.Checked == true)
                {
                    sso.Socio_economico_familia_disfuncional = "SI";
                }
                else
                {
                    sso.Socio_economico_familia_disfuncional = null;
                }
                //Certifico
                if (cb_certificosi.Checked == true)
                {
                    sso.Socio_economico_informacion_general_real_si = "SI";
                }
                else
                {
                    sso.Socio_economico_informacion_general_real_si = null;
                }
                if (cb_certificono.Checked == true)
                {
                    sso.Socio_economico_informacion_general_real_no = "SI";
                }
                else
                {
                    sso.Socio_economico_informacion_general_real_no = null;
                }

                CN_SocioEconomico.ModificarSocioEconomico(sso);

                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Modificados Exitosamente')", true);
                Response.Redirect("~/Template/Views_Socio_Economico/PacientesSocioEconomico.aspx");
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Modificados')", true);
            }
        }


        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_biencasa.Text.Equals("") || txt_biendepartamento.Text.Equals("") || txt_bienvehiculo.Text.Equals("") ||
                txt_bienvehiculo.Text.Equals("") || txt_bienegocio.Text.Equals("") || txt_bienmueblesyenseres.Text.Equals(""))
            {
                lbl_bienes.Text = "Complete todos estos campos";
            }
            else
            {
                if (cb_certificosi.Checked == true)
                {
                    Guardar_modificar_datos(Convert.ToInt32(Request["cod"]));
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Por favor, marque la casilla SI, para validar que la información suministrada es real')", true);
                }
            }                     
        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/Views_Socio_Economico/Inicio.aspx");
        }



        //VALIDACIONES CHECKBOX Y TEXTBOX

        //I.DATOS PERSONALES DEL SERVIDOR/A
        protected void cb_modalidadvinculacionlosep_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_modalidadvinculacionlosep.Checked == true)
            {
                cb_modalidadvinculacioncodigotrabajo.Enabled = false;
            }
            else
            {
                cb_modalidadvinculacionlosep.Enabled = true;
                cb_modalidadvinculacioncodigotrabajo.Enabled = true;
            }
        }

        protected void cb_modalidadvinculacioncodigotrabajo_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_modalidadvinculacioncodigotrabajo.Checked == true)
            {
                cb_modalidadvinculacionlosep.Enabled = false;
            }
            else
            {
                cb_modalidadvinculacionlosep.Enabled = true;
                cb_modalidadvinculacioncodigotrabajo.Enabled = true;
            }
        }

        protected void cb_soltero_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_soltero.Checked == true)
            {
                cb_casado.Enabled = false;
                cb_viudo.Enabled = false;
                cb_unionlibre.Enabled = false;
                cb_divorciado.Enabled = false;
            }
            else
            {
                cb_soltero.Enabled = true;
                cb_casado.Enabled = true;
                cb_viudo.Enabled = true;
                cb_unionlibre.Enabled = true;
                cb_divorciado.Enabled = true;
            }
        }

        protected void cb_casado_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_casado.Checked == true)
            {
                cb_soltero.Enabled = false;
                cb_viudo.Enabled = false;
                cb_unionlibre.Enabled = false;
                cb_divorciado.Enabled = false;
            }
            else
            {
                cb_soltero.Enabled = true;
                cb_casado.Enabled = true;
                cb_viudo.Enabled = true;
                cb_unionlibre.Enabled = true;
                cb_divorciado.Enabled = true;
            }
        }

        protected void cb_viudo_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_viudo.Checked == true)
            {
                cb_soltero.Enabled = false;
                cb_casado.Enabled = false;
                cb_unionlibre.Enabled = false;
                cb_divorciado.Enabled = false;
            }
            else
            {
                cb_soltero.Enabled = true;
                cb_casado.Enabled = true;
                cb_viudo.Enabled = true;
                cb_unionlibre.Enabled = true;
                cb_divorciado.Enabled = true;
            }
        }

        protected void cb_unionlibre_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_unionlibre.Checked == true)
            {
                cb_soltero.Enabled = false;
                cb_casado.Enabled = false;
                cb_viudo.Enabled = false;
                cb_divorciado.Enabled = false;
            }
            else
            {
                cb_soltero.Enabled = true;
                cb_casado.Enabled = true;
                cb_viudo.Enabled = true;
                cb_unionlibre.Enabled = true;
                cb_divorciado.Enabled = true;
            }
        }

        protected void cb_divorciado_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_divorciado.Checked == true)
            {
                cb_soltero.Enabled = false;
                cb_casado.Enabled = false;
                cb_viudo.Enabled = false;
                cb_unionlibre.Enabled = false;
            }
            else
            {
                cb_soltero.Enabled = true;
                cb_casado.Enabled = true;
                cb_viudo.Enabled = true;
                cb_unionlibre.Enabled = true;
                cb_divorciado.Enabled = true;
            }
        }

        protected void cb_genmasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_genmasculino.Checked == true)
            {
                cb_genfemenino.Enabled = false;
            }
            else
            {
                cb_genmasculino.Enabled = true;
                cb_genfemenino.Enabled = true;
            }
        }

        protected void cb_genfemenino_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_genfemenino.Checked == true)
            {
                cb_genmasculino.Enabled = false;
            }
            else
            {
                cb_genmasculino.Enabled = true;
                cb_genfemenino.Enabled = true;
            }
        }

        protected void cb_donantesi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_donantesi.Checked == true)
            {
                cb_donanteno.Enabled = false;
            }
            else
            {
                cb_donantesi.Enabled = true;
                cb_donanteno.Enabled = true;
            }
        }

        protected void cb_donanteno_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_donanteno.Checked == true)
            {
                cb_donantesi.Enabled = false;
            }
            else
            {
                cb_donantesi.Enabled = true;
                cb_donanteno.Enabled = true;
            }
        }

        protected void cb_primaria_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_primaria.Checked == true)
            {
                cb_secundaria.Enabled = false;
                cb_superior.Enabled = false;
                cb_especializacion.Enabled = false;
                cb_diplomado.Enabled = false;
                cb_maestria.Enabled = false;
            }
            else
            {
                cb_primaria.Enabled = true;
                cb_secundaria.Enabled = true;
                cb_superior.Enabled = true;
                cb_especializacion.Enabled = true;
                cb_diplomado.Enabled = true;
                cb_maestria.Enabled = true;
            }
        }

        protected void cb_secundaria_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_secundaria.Checked == true)
            {
                cb_primaria.Checked = true;
                cb_superior.Enabled = false;
                cb_especializacion.Enabled = false;
                cb_diplomado.Enabled = false;
                cb_maestria.Enabled = false;
            }
            else
            {
                cb_primaria.Checked = false;
                cb_secundaria.Enabled = true;
                cb_superior.Enabled = true;
                cb_especializacion.Enabled = true;
                cb_diplomado.Enabled = true;
                cb_maestria.Enabled = true;
            }
        }

        protected void cb_superior_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_superior.Checked == true)
            {
                cb_primaria.Checked = true;
                cb_secundaria.Checked = true;
                cb_especializacion.Enabled = false;
                cb_diplomado.Enabled = false;
                cb_maestria.Enabled = false;
            }
            else
            {
                cb_primaria.Checked = false;
                cb_secundaria.Checked = false;
                cb_superior.Enabled = true;
                cb_especializacion.Enabled = true;
                cb_diplomado.Enabled = true;
                cb_maestria.Enabled = true;
            }
        }

        protected void cb_especializacion_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_especializacion.Checked == true)
            {
                cb_primaria.Checked = true;
                cb_secundaria.Checked = true;
                cb_superior.Checked = true;
                cb_diplomado.Enabled = false;
                cb_maestria.Enabled = false;
            }
            else
            {
                cb_primaria.Checked = false;
                cb_secundaria.Checked = false;
                cb_superior.Checked = false;
                cb_especializacion.Enabled = true;
                cb_diplomado.Enabled = true;
                cb_maestria.Enabled = true;
            }
        }

        protected void cb_diplomado_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_diplomado.Checked == true)
            {
                cb_primaria.Checked = true;
                cb_secundaria.Checked = true;
                cb_superior.Checked = true;
                cb_especializacion.Checked = true;
                cb_maestria.Enabled = false;
            }
            else
            {
                cb_primaria.Checked = false;
                cb_secundaria.Checked = false;
                cb_superior.Checked = false;
                cb_especializacion.Checked = false;
                cb_diplomado.Enabled = true;
                cb_maestria.Enabled = true;
            }
        }

        protected void cb_maestria_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_maestria.Checked == true)
            {
                cb_primaria.Checked = true;
                cb_secundaria.Checked = true;
                cb_superior.Checked = true;
                cb_especializacion.Checked = true;
                cb_diplomado.Checked = true;
            }
            else
            {
                cb_primaria.Checked = false;
                cb_secundaria.Checked = false;
                cb_superior.Checked = false;
                cb_especializacion.Checked = false;
                cb_diplomado.Checked = false;
                cb_maestria.Enabled = true;
            }
        }

        protected void cb_blanco_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_blanco.Checked == true)
            {
                cb_mestizo.Enabled = false;
                cb_afro.Enabled = false;
                cb_indigena.Enabled = false;
                cb_montubio.Enabled = false;
            }
            else
            {
                cb_blanco.Enabled = true;
                cb_mestizo.Enabled = true;
                cb_afro.Enabled = true;
                cb_indigena.Enabled = true;
                cb_montubio.Enabled = true;
            }
        }

        protected void cb_mestizo_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_mestizo.Checked == true)
            {
                cb_blanco.Enabled = false;
                cb_afro.Enabled = false;
                cb_indigena.Enabled = false;
                cb_montubio.Enabled = false;
            }
            else
            {
                cb_blanco.Enabled = true;
                cb_mestizo.Enabled = true;
                cb_afro.Enabled = true;
                cb_indigena.Enabled = true;
                cb_montubio.Enabled = true;
            }
        }

        protected void cb_afro_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_afro.Checked == true)
            {
                cb_blanco.Enabled = false;
                cb_mestizo.Enabled = false;
                cb_indigena.Enabled = false;
                cb_montubio.Enabled = false;
            }
            else
            {
                cb_blanco.Enabled = true;
                cb_mestizo.Enabled = true;
                cb_afro.Enabled = true;
                cb_indigena.Enabled = true;
                cb_montubio.Enabled = true;
            }
        }

        protected void cb_indigena_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_indigena.Checked == true)
            {
                cb_blanco.Enabled = false;
                cb_mestizo.Enabled = false;
                cb_afro.Enabled = false;
                cb_montubio.Enabled = false;
            }
            else
            {
                cb_blanco.Enabled = true;
                cb_mestizo.Enabled = true;
                cb_afro.Enabled = true;
                cb_indigena.Enabled = true;
                cb_montubio.Enabled = true;
            }
        }

        protected void cb_montubio_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_montubio.Checked == true)
            {
                cb_blanco.Enabled = false;
                cb_mestizo.Enabled = false;
                cb_afro.Enabled = false;
                cb_indigena.Enabled = false;
            }
            else
            {
                cb_blanco.Enabled = true;
                cb_mestizo.Enabled = true;
                cb_afro.Enabled = true;
                cb_indigena.Enabled = true;
                cb_montubio.Enabled = true;
            }
        }

        protected void cb_norte_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_norte.Checked == true)
            {
                cb_centro.Enabled = false;
                cb_sur.Enabled = false;
                cb_valle.Enabled = false;
                cb_valledeloschillos.Enabled = false;
            }
            else
            {
                cb_norte.Enabled = true;
                cb_centro.Enabled = true;
                cb_sur.Enabled = true;
                cb_valle.Enabled = true;
                cb_valledeloschillos.Enabled = true;
            }
        }

        protected void cb_centro_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_centro.Checked == true)
            {
                cb_norte.Enabled = false;
                cb_sur.Enabled = false;
                cb_valle.Enabled = false;
                cb_valledeloschillos.Enabled = false;
            }
            else
            {
                cb_norte.Enabled = true;
                cb_centro.Enabled = true;
                cb_sur.Enabled = true;
                cb_valle.Enabled = true;
                cb_valledeloschillos.Enabled = true;
            }
        }

        protected void cb_sur_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_sur.Checked == true)
            {
                cb_norte.Enabled = false;
                cb_centro.Enabled = false;
                cb_valle.Enabled = false;
                cb_valledeloschillos.Enabled = false;
            }
            else
            {
                cb_norte.Enabled = true;
                cb_centro.Enabled = true;
                cb_sur.Enabled = true;
                cb_valle.Enabled = true;
                cb_valledeloschillos.Enabled = true;
            }
        }

        protected void cb_valle_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_valle.Checked == true)
            {
                cb_norte.Enabled = false;
                cb_centro.Enabled = false;
                cb_sur.Enabled = false;
                cb_valledeloschillos.Enabled = false;
            }
            else
            {
                cb_norte.Enabled = true;
                cb_centro.Enabled = true;
                cb_sur.Enabled = true;
                cb_valle.Enabled = true;
                cb_valledeloschillos.Enabled = true;
            }
        }

        protected void cb_valledeloschillos_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_valledeloschillos.Checked == true)
            {
                cb_norte.Enabled = false;
                cb_centro.Enabled = false;
                cb_sur.Enabled = false;
                cb_valle.Enabled = false;
            }
            else
            {
                cb_norte.Enabled = true;
                cb_centro.Enabled = true;
                cb_sur.Enabled = true;
                cb_valle.Enabled = true;
                cb_valledeloschillos.Enabled = true;
            }
        }

        protected void cb_casa_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_casa.Checked == true)
            {
                cb_departamento.Enabled = false;
                txt_tipoviviendaotro.Enabled = false;
                tbc_otro.Visible = false;
                tbc_otravivienda.Visible = false;
                tbc_otravivienda.Text = "";
            }
            else
            {
                cb_casa.Enabled = true;
                cb_departamento.Enabled = true;
                txt_tipoviviendaotro.Enabled = true;
                tbc_otro.Visible = true;
                tbc_otravivienda.Visible = true;
            }
        }

        protected void cb_departamento_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_departamento.Checked == true)
            {
                cb_casa.Enabled = false;
                txt_tipoviviendaotro.Enabled = false;
                txt_tipoviviendaotro.Visible = false;
                tbc_otro.Visible = false;
                tbc_otravivienda.Visible = false;
                tbc_otravivienda.Text = "";
            }
            else
            {
                cb_casa.Enabled = true;
                cb_departamento.Enabled = true;
                txt_tipoviviendaotro.Enabled = true;
                txt_tipoviviendaotro.Visible = true;
                tbc_otro.Visible = true;
                tbc_otravivienda.Visible = true;
            }
        }

        protected void cb_riesgoalto_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_riesgoalto.Checked == true)
            {
                cb_riesgomedio.Enabled = false;
                cb_riesgobajo.Enabled = false;
            }
            else
            {
                cb_riesgoalto.Enabled = true;
                cb_riesgomedio.Enabled = true;
                cb_riesgobajo.Enabled = true;
            }
        }

        protected void cb_riesgomedio_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_riesgomedio.Checked == true)
            {
                cb_riesgoalto.Enabled = false;
                cb_riesgobajo.Enabled = false;
            }
            else
            {
                cb_riesgoalto.Enabled = true;
                cb_riesgomedio.Enabled = true;
                cb_riesgobajo.Enabled = true;
            }
        }

        protected void cb_riesgobajo_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_riesgobajo.Checked == true)
            {
                cb_riesgoalto.Enabled = false;
                cb_riesgomedio.Enabled = false;
            }
            else
            {
                cb_riesgoalto.Enabled = true;
                cb_riesgomedio.Enabled = true;
                cb_riesgobajo.Enabled = true;
            }
        }

        protected void cb_dineroahorrosi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_dineroahorrosi.Checked == true)
            {
                cb_dineroahorrono.Enabled = false;
            }
            else
            {
                cb_dineroahorrosi.Enabled = true;
                cb_dineroahorrono.Enabled = true;
            }
        }

        protected void cb_dineroahorrono_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_dineroahorrono.Checked == true)
            {
                cb_dineroahorrosi.Enabled = false;
            }
            else
            {
                cb_dineroahorrosi.Enabled = true;
                cb_dineroahorrono.Enabled = true;
            }
        }

        protected void cb_vehiculosi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_vehiculosi.Checked == true)
            {
                cb_vehiculono.Enabled = false;
            }
            else
            {
                cb_vehiculosi.Enabled = true;
                cb_vehiculono.Enabled = true;
            }
        }

        protected void cb_vehiculono_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_vehiculono.Checked == true)
            {
                cb_vehiculosi.Enabled = false;
            }
            else
            {
                cb_vehiculosi.Enabled = true;
                cb_vehiculono.Enabled = true;
            }
        }

        protected void cb_recorridosi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_recorridosi.Checked == true)
            {
                cb_recorridono.Enabled = false;
            }
            else
            {
                cb_recorridosi.Enabled = true;
                cb_recorridono.Enabled = true;
            }
        }

        protected void cb_recorridono_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_recorridono.Checked == true)
            {
                cb_recorridosi.Enabled = false;
            }
            else
            {
                cb_recorridosi.Enabled = true;
                cb_recorridono.Enabled = true;
            }
        }

        //II.DATOS DE SALUD DEL SERVIDOR/A
        protected void cb_discapacidadsi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_discapacidadsi.Checked == true)
            {
                cb_discapacidadno.Enabled = false;
                tabladatosdiscapacidad.Visible = true;
                tbc_tipodiscapacidad.Visible = true;
                tbc_txtdiscapacidad.Visible = true;
            }
            else
            {
                cb_discapacidadsi.Enabled = true;
                cb_discapacidadno.Enabled = true;
                tabladatosdiscapacidad.Visible = false;
                tbc_tipodiscapacidad.Visible = false;
                tbc_txtdiscapacidad.Visible = false;
            }
        }

        protected void cb_discapacidadno_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_discapacidadno.Checked == true)
            {
                cb_discapacidadsi.Enabled = false;
            }
            else
            {
                cb_discapacidadsi.Enabled = true;
                cb_discapacidadno.Enabled = true;
            }
        }

        protected void cb_gestaciónsi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_gestaciónsi.Checked == true)
            {
                cb_gestaciónno.Enabled = false;
                tbl_estadogestacion.Visible = true;
            }
            else
            {
                cb_gestaciónsi.Enabled = true;
                cb_gestaciónno.Enabled = true;
                tbl_estadogestacion.Visible = false;
            }
        }

        protected void cb_gestaciónno_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_gestaciónno.Checked == true)
            {
                cb_gestaciónsi.Enabled = false;
            }
            else
            {
                cb_gestaciónsi.Enabled = true;
                cb_gestaciónno.Enabled = true;
            }
        }

        protected void cb_lactaciasi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_lactaciasi.Checked == true)
            {
                cb_lactaciano.Enabled = false;
            }
            else
            {
                cb_lactaciasi.Enabled = true;
                cb_lactaciano.Enabled = true;
                txt_fechaculmicacionlactancia.Enabled = true;
            }
        }

        protected void cb_lactaciano_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_lactaciano.Checked == true)
            {
                cb_lactaciasi.Enabled = false;
                txt_fechaculmicacionlactancia.Enabled = false;
            }
            else
            {
                cb_lactaciasi.Enabled = true;
                cb_lactaciano.Enabled = true;
                txt_fechaculmicacionlactancia.Enabled = true;
            }
        }

        protected void cb_catastroficasi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_catastroficasi.Checked == true)
            {
                cb_catastroficano.Enabled = false;
            }
            else
            {
                cb_catastroficasi.Enabled = true;
                cb_catastroficano.Enabled = true;
                txt_cualcatastrofica.Enabled = true;
                txt_otrasenfermedadescat.Enabled = true;
            }
        }

        protected void cb_catastroficano_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_catastroficano.Checked == true)
            {
                cb_catastroficasi.Enabled = false;
                txt_cualcatastrofica.Enabled = false;
                txt_otrasenfermedadescat.Enabled = false;
            }
            else
            {
                cb_catastroficasi.Enabled = true;
                cb_catastroficano.Enabled = true;
                txt_cualcatastrofica.Enabled = true;
                txt_otrasenfermedadescat.Enabled = true;
            }
        }

        protected void cb_enfermedadrarasi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_enfermedadrarasi.Checked == true)
            {
                cb_enfermedadrarano.Enabled = false;
            }
            else
            {
                cb_enfermedadrarasi.Enabled = true;
                cb_enfermedadrarano.Enabled = true;
                txt_enfermedadraracual.Enabled = true;
            }
        }

        protected void cb_enfermedadrarano_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_enfermedadrarano.Checked == true)
            {
                cb_enfermedadrarasi.Enabled = false;
                txt_enfermedadraracual.Enabled = false;
            }
            else
            {
                cb_enfermedadrarasi.Enabled = true;
                cb_enfermedadrarano.Enabled = true;
                txt_enfermedadraracual.Enabled = true;
            }
        }

        protected void cb_alcoholsi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_alcoholsi.Checked == true)
            {
                cb_alcoholno.Enabled = false;
            }
            else
            {
                cb_alcoholsi.Enabled = true;
                cb_alcoholno.Enabled = true;
                txt_causaconsumoalcohol.Enabled = true;
                cb_consumoalcoholdiario.Enabled = true;
                cb_consumoalcoholsemanal.Enabled = true;
                cb_consumoalcoholquincenal.Enabled = true;
                cb_consumoalcoholmensual.Enabled = true;
                cb_consumoalcoholreuniones.Enabled = true;
                txt_tiempoconsumoalcohol.Enabled = true;
            }
        }

        protected void cb_alcoholno_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_alcoholno.Checked == true)
            {
                cb_alcoholsi.Enabled = false;
                txt_causaconsumoalcohol.Enabled = false;
                cb_consumoalcoholdiario.Enabled = false;
                cb_consumoalcoholsemanal.Enabled = false;
                cb_consumoalcoholquincenal.Enabled = false;
                cb_consumoalcoholmensual.Enabled = false;
                cb_consumoalcoholreuniones.Enabled = false;
                txt_tiempoconsumoalcohol.Enabled = false;
                tablafrecuenciaalcohol.Visible = false;
            }
            else
            {
                cb_alcoholsi.Enabled = true;
                cb_alcoholno.Enabled = true;
                txt_causaconsumoalcohol.Enabled = true;
                cb_consumoalcoholdiario.Enabled = true;
                cb_consumoalcoholsemanal.Enabled = true;
                cb_consumoalcoholquincenal.Enabled = true;
                cb_consumoalcoholmensual.Enabled = true;
                cb_consumoalcoholreuniones.Enabled = true;
                txt_tiempoconsumoalcohol.Enabled = true;
                tablafrecuenciaalcohol.Visible = true;
            }
        }

        protected void cb_consumoalcoholdiario_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_consumoalcoholdiario.Checked == true)
            {
                cb_consumoalcoholsemanal.Enabled = false;
                cb_consumoalcoholquincenal.Enabled = false;
                cb_consumoalcoholmensual.Enabled = false;
                cb_consumoalcoholreuniones.Enabled = false;
            }
            else
            {
                cb_consumoalcoholdiario.Enabled = true;
                cb_consumoalcoholsemanal.Enabled = true;
                cb_consumoalcoholquincenal.Enabled = true;
                cb_consumoalcoholmensual.Enabled = true;
                cb_consumoalcoholreuniones.Enabled = true;
            }
        }

        protected void cb_consumoalcoholsemanal_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_consumoalcoholsemanal.Checked == true)
            {
                cb_consumoalcoholdiario.Enabled = false;
                cb_consumoalcoholquincenal.Enabled = false;
                cb_consumoalcoholmensual.Enabled = false;
                cb_consumoalcoholreuniones.Enabled = false;
            }
            else
            {
                cb_consumoalcoholdiario.Enabled = true;
                cb_consumoalcoholsemanal.Enabled = true;
                cb_consumoalcoholquincenal.Enabled = true;
                cb_consumoalcoholmensual.Enabled = true;
                cb_consumoalcoholreuniones.Enabled = true;
            }
        }

        protected void cb_consumoalcoholquincenal_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_consumoalcoholquincenal.Checked == true)
            {
                cb_consumoalcoholdiario.Enabled = false;
                cb_consumoalcoholsemanal.Enabled = false;
                cb_consumoalcoholmensual.Enabled = false;
                cb_consumoalcoholreuniones.Enabled = false;
            }
            else
            {
                cb_consumoalcoholdiario.Enabled = true;
                cb_consumoalcoholsemanal.Enabled = true;
                cb_consumoalcoholquincenal.Enabled = true;
                cb_consumoalcoholmensual.Enabled = true;
                cb_consumoalcoholreuniones.Enabled = true;
            }
        }

        protected void cb_consumoalcoholmensual_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_consumoalcoholmensual.Checked == true)
            {
                cb_consumoalcoholdiario.Enabled = false;
                cb_consumoalcoholsemanal.Enabled = false;
                cb_consumoalcoholquincenal.Enabled = false;
                cb_consumoalcoholreuniones.Enabled = false;
            }
            else
            {
                cb_consumoalcoholdiario.Enabled = true;
                cb_consumoalcoholsemanal.Enabled = true;
                cb_consumoalcoholquincenal.Enabled = true;
                cb_consumoalcoholmensual.Enabled = true;
                cb_consumoalcoholreuniones.Enabled = true;
            }
        }

        protected void cb_consumoalcoholreuniones_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_consumoalcoholreuniones.Checked == true)
            {
                cb_consumoalcoholdiario.Enabled = false;
                cb_consumoalcoholsemanal.Enabled = false;
                cb_consumoalcoholquincenal.Enabled = false;
                cb_consumoalcoholmensual.Enabled = false;
            }
            else
            {
                cb_consumoalcoholdiario.Enabled = true;
                cb_consumoalcoholsemanal.Enabled = true;
                cb_consumoalcoholquincenal.Enabled = true;
                cb_consumoalcoholmensual.Enabled = true;
                cb_consumoalcoholreuniones.Enabled = true;
            }
        }

        protected void cb_tabacosi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_tabacosi.Checked == true)
            {
                cb_tabacono.Enabled = false;
            }
            else
            {
                cb_tabacosi.Enabled = true;
                cb_tabacono.Enabled = true;
                txt_frecuenciaconsumotabaco.Enabled = true;
                txt_tiempoconsumotabaco.Enabled = true;
            }
        }

        protected void cb_tabacono_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_tabacono.Checked == true)
            {
                cb_tabacosi.Enabled = false;
                txt_frecuenciaconsumotabaco.Enabled = false;
                txt_tiempoconsumotabaco.Enabled = false;
            }
            else
            {
                cb_tabacosi.Enabled = true;
                cb_tabacono.Enabled = true;
                txt_frecuenciaconsumotabaco.Enabled = true;
                txt_tiempoconsumotabaco.Enabled = true;
            }
        }

        protected void cb_sustanciapsicotropicasi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_sustanciapsicotropicasi.Checked == true)
            {
                cb_sustanciapsicotropicano.Enabled = false;
            }
            else
            {
                cb_sustanciapsicotropicasi.Enabled = true;
                cb_sustanciapsicotropicano.Enabled = true;
                txt_sustanciapsicotropicatipo.Enabled = true;
                txt_sustanciapsicotropicafrecuencia.Enabled = true;
            }
        }

        protected void cb_sustanciapsicotropicano_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_sustanciapsicotropicano.Checked == true)
            {
                cb_sustanciapsicotropicasi.Enabled = false;
                txt_sustanciapsicotropicatipo.Enabled = false;
                txt_sustanciapsicotropicafrecuencia.Enabled = false;
            }
            else
            {
                cb_sustanciapsicotropicasi.Enabled = true;
                cb_sustanciapsicotropicano.Enabled = true;
                txt_sustanciapsicotropicatipo.Enabled = true;
                txt_sustanciapsicotropicafrecuencia.Enabled = true;
            }
        }

        //III.SITUACIÓN ECONÓMICA DEL SERVIDOR/A
        protected void cb_unifamiliar_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_unifamiliar.Checked == true)
            {
                cb_multifamiliar.Enabled = false;
                txt_otrodescripcionviviendafamilia.Enabled = false;
            }
            else
            {
                cb_unifamiliar.Enabled = true;
                cb_multifamiliar.Enabled = true;
                txt_otrodescripcionviviendafamilia.Enabled = true;
            }
        }

        protected void cb_multifamiliar_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_multifamiliar.Checked == true)
            {
                cb_unifamiliar.Enabled = false;
                txt_otrodescripcionviviendafamilia.Enabled = false;
            }
            else
            {
                cb_unifamiliar.Enabled = true;
                cb_multifamiliar.Enabled = true;
                txt_otrodescripcionviviendafamilia.Enabled = true;
            }
        }

        protected void cb_propiasindeuda_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_propiasindeuda.Checked == true)
            {
                cb_arrendada.Enabled = false;
                cb_defamilia.Enabled = false;
                cb_hipotecada.Enabled = false;
                cb_prestada.Enabled = false;
                cb_anticreces.Enabled = false;
                txt_otratenencia.Enabled = false;
            }
            else
            {
                cb_propiasindeuda.Enabled = true;
                cb_arrendada.Enabled = true;
                cb_defamilia.Enabled = true;
                cb_hipotecada.Enabled = true;
                cb_prestada.Enabled = true;
                cb_anticreces.Enabled = true;
                txt_otratenencia.Enabled = true;
            }
        }

        protected void cb_arrendada_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_arrendada.Checked == true)
            {
                cb_propiasindeuda.Enabled = false;
                cb_defamilia.Enabled = false;
                cb_hipotecada.Enabled = false;
                cb_prestada.Enabled = false;
                cb_anticreces.Enabled = false;
                txt_otratenencia.Enabled = false;
            }
            else
            {
                cb_propiasindeuda.Enabled = true;
                cb_arrendada.Enabled = true;
                cb_defamilia.Enabled = true;
                cb_hipotecada.Enabled = true;
                cb_prestada.Enabled = true;
                cb_anticreces.Enabled = true;
                txt_otratenencia.Enabled = true;
            }
        }

        protected void cb_defamilia_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_defamilia.Checked == true)
            {
                cb_propiasindeuda.Enabled = false;
                cb_arrendada.Enabled = false;
                cb_hipotecada.Enabled = false;
                cb_prestada.Enabled = false;
                cb_anticreces.Enabled = false;
                txt_otratenencia.Enabled = false;
            }
            else
            {
                cb_propiasindeuda.Enabled = true;
                cb_arrendada.Enabled = true;
                cb_defamilia.Enabled = true;
                cb_hipotecada.Enabled = true;
                cb_prestada.Enabled = true;
                cb_anticreces.Enabled = true;
                txt_otratenencia.Enabled = true;
            }
        }

        protected void cb_hipotecada_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_hipotecada.Checked == true)
            {
                cb_propiasindeuda.Enabled = false;
                cb_arrendada.Enabled = false;
                cb_defamilia.Enabled = false;
                cb_prestada.Enabled = false;
                cb_anticreces.Enabled = false;
                txt_otratenencia.Enabled = false;
            }
            else
            {
                cb_propiasindeuda.Enabled = true;
                cb_arrendada.Enabled = true;
                cb_defamilia.Enabled = true;
                cb_hipotecada.Enabled = true;
                cb_prestada.Enabled = true;
                cb_anticreces.Enabled = true;
                txt_otratenencia.Enabled = true;
            }
        }

        protected void cb_prestada_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_prestada.Checked == true)
            {
                cb_propiasindeuda.Enabled = false;
                cb_arrendada.Enabled = false;
                cb_defamilia.Enabled = false;
                cb_hipotecada.Enabled = false;
                cb_anticreces.Enabled = false;
                txt_otratenencia.Enabled = false;
            }
            else
            {
                cb_propiasindeuda.Enabled = true;
                cb_arrendada.Enabled = true;
                cb_defamilia.Enabled = true;
                cb_hipotecada.Enabled = true;
                cb_prestada.Enabled = true;
                cb_anticreces.Enabled = true;
                txt_otratenencia.Enabled = true;
            }
        }

        protected void cb_anticreces_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_anticreces.Checked == true)
            {
                cb_propiasindeuda.Enabled = false;
                cb_arrendada.Enabled = false;
                cb_defamilia.Enabled = false;
                cb_hipotecada.Enabled = false;
                cb_prestada.Enabled = false;
                txt_otratenencia.Enabled = false;
            }
            else
            {
                cb_propiasindeuda.Enabled = true;
                cb_arrendada.Enabled = true;
                cb_defamilia.Enabled = true;
                cb_hipotecada.Enabled = true;
                cb_prestada.Enabled = true;
                cb_anticreces.Enabled = true;
                txt_otratenencia.Enabled = true;
            }
        }

        protected void cb_tipocasa_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_tipocasa.Checked == true)
            {
                cb_tiposuit.Enabled = false;
                cb_tipomediagua.Enabled = false;
                cb_tipodepartamento.Enabled = false;
                cb_tipopieza.Enabled = false;
                txt_otrotipodecasa.Enabled = false;
            }
            else
            {
                cb_tipocasa.Enabled = true;
                cb_tiposuit.Enabled = true;
                cb_tipomediagua.Enabled = true;
                cb_tipodepartamento.Enabled = true;
                cb_tipopieza.Enabled = true;
                txt_otrotipodecasa.Enabled = true;
            }
        }

        protected void cb_tiposuit_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_tiposuit.Checked == true)
            {
                cb_tipocasa.Enabled = false;
                cb_tipomediagua.Enabled = false;
                cb_tipodepartamento.Enabled = false;
                cb_tipopieza.Enabled = false;
                txt_otrotipodecasa.Enabled = false;
            }
            else
            {
                cb_tipocasa.Enabled = true;
                cb_tiposuit.Enabled = true;
                cb_tipomediagua.Enabled = true;
                cb_tipodepartamento.Enabled = true;
                cb_tipopieza.Enabled = true;
                txt_otrotipodecasa.Enabled = true;
            }
        }

        protected void cb_tipomediagua_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_tipomediagua.Checked == true)
            {
                cb_tipocasa.Enabled = false;
                cb_tiposuit.Enabled = false;
                cb_tipodepartamento.Enabled = false;
                cb_tipopieza.Enabled = false;
                txt_otrotipodecasa.Enabled = false;
            }
            else
            {
                cb_tipocasa.Enabled = true;
                cb_tiposuit.Enabled = true;
                cb_tipomediagua.Enabled = true;
                cb_tipodepartamento.Enabled = true;
                cb_tipopieza.Enabled = true;
                txt_otrotipodecasa.Enabled = true;
            }
        }

        protected void cb_tipodepartamento_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_tipodepartamento.Checked == true)
            {
                cb_tipocasa.Enabled = false;
                cb_tiposuit.Enabled = false;
                cb_tipomediagua.Enabled = false;
                cb_tipopieza.Enabled = false;
                txt_otrotipodecasa.Enabled = false;
            }
            else
            {
                cb_tipocasa.Enabled = true;
                cb_tiposuit.Enabled = true;
                cb_tipomediagua.Enabled = true;
                cb_tipodepartamento.Enabled = true;
                cb_tipopieza.Enabled = true;
                txt_otrotipodecasa.Enabled = true;
            }
        }

        protected void cb_tipopieza_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_tipopieza.Checked == true)
            {
                cb_tipocasa.Enabled = false;
                cb_tiposuit.Enabled = false;
                cb_tipomediagua.Enabled = false;
                cb_tipodepartamento.Enabled = false;
                txt_otrotipodecasa.Enabled = false;
            }
            else
            {
                cb_tipocasa.Enabled = true;
                cb_tiposuit.Enabled = true;
                cb_tipomediagua.Enabled = true;
                cb_tipodepartamento.Enabled = true;
                cb_tipopieza.Enabled = true;
                txt_otrotipodecasa.Enabled = true;
            }
        }

        //IV.INFORMACIÓN GENERAL DEL SERVIDOR/A
        protected void cb_nucleodiscapacidadsi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_nucleodiscapacidadsi.Checked == true)
            {
                cb_nucleodiscapacidadno.Enabled = false;
            }
            else
            {
                cb_nucleodiscapacidadsi.Enabled = true;
                cb_nucleodiscapacidadno.Enabled = true;
            }
        }

        protected void cb_nucleodiscapacidadno_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_nucleodiscapacidadno.Checked == true)
            {
                cb_nucleodiscapacidadsi.Enabled = false;
                cb_acargofamiliardiacapacitadosi.Enabled = false;
                cb_acargofamiliardiacapacitadono.Enabled = false;
                txt_familiardiscapacitadonomape1.Enabled = false;
                txt_familiardiscapacitadofechacaducidadcarnet1.Enabled = false;
                txt_familiardiscapacitadotipodiscapacidad1.Enabled = false;
                txt_familiardiscapacitadoporcentajediscapacidad1.Enabled = false;
                txt_familiardiscapacitadoparentesco1.Enabled = false;
                txt_familiardiscapacitadofechanacimiento1.Enabled = false;
                txt_familiardiscapacitadonomape2.Enabled = false;
                txt_familiardiscapacitadofechacaducidadcarnet2.Enabled = false;
                txt_familiardiscapacitadotipodiscapacidad2.Enabled = false;
                txt_familiardiscapacitadoporcentajediscapacidad2.Enabled = false;
                txt_familiardiscapacitadoparentesco2.Enabled = false;
                txt_familiardiscapacitadofechanacimiento2.Enabled = false;
                cb_dependenciaministeriotrabajosi.Enabled = false;
                cb_dependenciaministeriotrabajono.Enabled = false;
                txt_dependenciaministeriotrabajotiempo.Enabled = false;
                txt_numcarnetMSP.Enabled = false;
                cb_acargofamiliarenfermedadrarasi.Enabled = false;
                cb_acargofamiliarenfermedadrarano.Enabled = false;
                txt_acargofamiliarenfermedadraratiempo.Enabled = false;
                txt_familiarenfermedadraratipo.Enabled = false;
            }
            else
            {
                cb_nucleodiscapacidadsi.Enabled = true;
                cb_nucleodiscapacidadno.Enabled = true;
                cb_acargofamiliardiacapacitadosi.Enabled = true;
                cb_acargofamiliardiacapacitadono.Enabled = true;
                txt_familiardiscapacitadonomape1.Enabled = true;
                txt_familiardiscapacitadofechacaducidadcarnet1.Enabled = true;
                txt_familiardiscapacitadotipodiscapacidad1.Enabled = true;
                txt_familiardiscapacitadoporcentajediscapacidad1.Enabled = true;
                txt_familiardiscapacitadoparentesco1.Enabled = true;
                txt_familiardiscapacitadofechanacimiento1.Enabled = true;
                txt_familiardiscapacitadonomape2.Enabled = true;
                txt_familiardiscapacitadofechacaducidadcarnet2.Enabled = true;
                txt_familiardiscapacitadotipodiscapacidad2.Enabled = true;
                txt_familiardiscapacitadoporcentajediscapacidad2.Enabled = true;
                txt_familiardiscapacitadoparentesco2.Enabled = true;
                txt_familiardiscapacitadofechanacimiento2.Enabled = true;
                cb_dependenciaministeriotrabajosi.Enabled = true;
                cb_dependenciaministeriotrabajono.Enabled = true;
                txt_dependenciaministeriotrabajotiempo.Enabled = true;
                txt_numcarnetMSP.Enabled = true;
                cb_acargofamiliarenfermedadrarasi.Enabled = true;
                cb_acargofamiliarenfermedadrarano.Enabled = true;
                txt_acargofamiliarenfermedadraratiempo.Enabled = true;
                txt_familiarenfermedadraratipo.Enabled = true;
            }
        }

        protected void cb_acargofamiliardiacapacitadosi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_acargofamiliardiacapacitadosi.Checked == true)
            {
                tabladiscapacidad.Visible = true;
                tabladependencia.Visible = true;
                tablaacargofamiliar.Visible = true;
                cb_acargofamiliardiacapacitadono.Enabled = false;
            }
            else
            {
                tabladiscapacidad.Visible = false;
                tabladependencia.Visible = false;
                tablaacargofamiliar.Visible = false;
                cb_acargofamiliardiacapacitadosi.Enabled = true;
                cb_acargofamiliardiacapacitadono.Enabled = true;
            }
        }

        protected void cb_acargofamiliardiacapacitadono_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_acargofamiliardiacapacitadono.Checked == true)
            {
                cb_acargofamiliardiacapacitadosi.Enabled = false;
                tabladiscapacidad.Visible = false;
                tabladependencia.Visible = false;
                tablaacargofamiliar.Visible = false;
            }
            else
            {
                cb_acargofamiliardiacapacitadosi.Enabled = true;
                cb_acargofamiliardiacapacitadono.Enabled = true;
            }
        }

        protected void cb_dependenciaministeriotrabajosi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_dependenciaministeriotrabajosi.Checked == true)
            {
                cb_dependenciaministeriotrabajono.Enabled = false;
                tabladiscapacidad.Visible = true;
                tabladependencia.Visible = true;
                tablaacargofamiliar.Visible = true;
            }
            else
            {
                cb_dependenciaministeriotrabajosi.Enabled = true;
                cb_dependenciaministeriotrabajono.Enabled = true;
                tabladiscapacidad.Visible = true;
                tabladependencia.Visible = true;
                tablaacargofamiliar.Visible = true;
            }
        }

        protected void cb_dependenciaministeriotrabajono_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_dependenciaministeriotrabajono.Checked == true)
            {
                cb_dependenciaministeriotrabajosi.Enabled = false;
                txt_dependenciaministeriotrabajotiempo.Enabled = false;
                txt_numcarnetMSP.Enabled = false;
                tabladiscapacidad.Visible = true;
                tabladependencia.Visible = true;
                tablaacargofamiliar.Visible = true;
            }
            else
            {
                cb_dependenciaministeriotrabajosi.Enabled = true;
                cb_dependenciaministeriotrabajono.Enabled = true;
                txt_dependenciaministeriotrabajotiempo.Enabled = true;
                txt_numcarnetMSP.Enabled = true;
                tabladiscapacidad.Visible = true;
                tabladependencia.Visible = true;
                tablaacargofamiliar.Visible = true;
            }
        }

        protected void cb_acargofamiliarenfermedadrarasi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_acargofamiliarenfermedadrarasi.Checked == true)
            {
                cb_acargofamiliarenfermedadrarano.Enabled = false;
                tabladiscapacidad.Visible = true;
                tabladependencia.Visible = true;
                tablaacargofamiliar.Visible = true;
            }
            else
            {
                cb_acargofamiliarenfermedadrarasi.Enabled = true;
                cb_acargofamiliarenfermedadrarano.Enabled = true;
                tabladiscapacidad.Visible = true;
                tabladependencia.Visible = true;
                tablaacargofamiliar.Visible = true;
            }
        }

        protected void cb_acargofamiliarenfermedadrarano_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_acargofamiliarenfermedadrarano.Checked == true)
            {
                cb_acargofamiliarenfermedadrarasi.Enabled = false;
                txt_acargofamiliarenfermedadraratiempo.Enabled = false;
                txt_familiarenfermedadraratipo.Enabled = false;
                tabladiscapacidad.Visible = true;
                tabladependencia.Visible = true;
                tablaacargofamiliar.Visible = true;
            }
            else
            {
                cb_acargofamiliarenfermedadrarasi.Enabled = true;
                cb_acargofamiliarenfermedadrarano.Enabled = true;
                txt_acargofamiliarenfermedadraratiempo.Enabled = true;
                txt_familiarenfermedadraratipo.Enabled = true;
                tabladiscapacidad.Visible = true;
                tabladependencia.Visible = true;
                tablaacargofamiliar.Visible = true;
            }
        }

        //V.ACTIVIDADES QUE  REALIZA EN TIEMPO LIBRE EL SERVIDOR/A
        protected void cb_actividadeconomicasi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_actividadeconomicasi.Checked == true)
            {
                cb_actividadeconomicano.Enabled = false;
            }
            else
            {
                cb_actividadeconomicasi.Enabled = true;
                cb_actividadeconomicano.Enabled = true;
            }
        }

        protected void cb_actividadeconomicano_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_actividadeconomicano.Checked == true)
            {
                cb_actividadeconomicasi.Enabled = false;
                txt_actividadeconomicadetalle.Enabled = false;
                tabla_actividadeconomica.Visible = false;
            }
            else
            {
                cb_actividadeconomicasi.Enabled = true;
                cb_actividadeconomicano.Enabled = true;
                txt_actividadeconomicadetalle.Enabled = true;
                tabla_actividadeconomica.Visible = true;
            }
        }

        protected void cb_deportesi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_deportesi.Checked == true)
            {
                cb_deporteno.Enabled = false;
            }
            else
            {
                cb_deportesi.Enabled = true;
                cb_deporteno.Enabled = true;
            }
        }

        protected void cb_deporteno_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_deporteno.Checked == true)
            {
                cb_deportesi.Enabled = false;
                txt_especifiquedeporte.Enabled = false;
                txt_frecuenciadeporte.Enabled = false;
                txt_edadpracticadeporte.Enabled = false;
            }
            else
            {
                cb_deportesi.Enabled = true;
                cb_deporteno.Enabled = true;
                txt_especifiquedeporte.Enabled = true;
                txt_frecuenciadeporte.Enabled = true;
                txt_edadpracticadeporte.Enabled = true;
            }
        }

        protected void cb_lesionsi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_lesionsi.Checked == true)
            {
                cb_lesionno.Enabled = false;
            }
            else
            {
                cb_lesionsi.Enabled = true;
                cb_lesionno.Enabled = true;
            }
        }

        protected void cb_lesionno_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_lesionno.Checked == true)
            {
                cb_lesionsi.Enabled = false;
                txt_tipolesion.Enabled = false;
                txt_edadlesion.Enabled = false;
            }
            else
            {
                cb_lesionsi.Enabled = true;
                cb_lesionno.Enabled = true;
                txt_tipolesion.Enabled = true;
                txt_edadlesion.Enabled = true;
            }
        }

        protected void cb_tratamientosi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_tratamientosi.Checked == true)
            {
                cb_tratamientono.Enabled = false;
            }
            else
            {
                cb_tratamientosi.Enabled = true;
                cb_tratamientono.Enabled = true;
            }
        }

        protected void cb_tratamientono_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_tratamientono.Checked == true)
            {
                cb_tratamientosi.Enabled = false;
            }
            else
            {
                cb_tratamientosi.Enabled = true;
                cb_tratamientono.Enabled = true;
            }
        }

        //VI. INFORMACIÓN UNICAMENTE PARA USO DE BIENESTAR LABORAL DEL SERVIDOR/A
        protected void cb_nuclear_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_nuclear.Checked == true)
            {
                cb_ampliada.Enabled = false;
                cb_monoparental.Enabled = false;
                cb_vivesolo.Enabled = false;
                cb_viveconamigos.Enabled = false;
                cb_familiasinhijos.Enabled = false;
            }
            else
            {
                cb_nuclear.Enabled = true;
                cb_ampliada.Enabled = true;
                cb_monoparental.Enabled = true;
                cb_vivesolo.Enabled = true;
                cb_viveconamigos.Enabled = true;
                cb_familiasinhijos.Enabled = true;
            }
        }

        protected void cb_ampliada_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ampliada.Checked == true)
            {
                cb_nuclear.Enabled = false;
                cb_monoparental.Enabled = false;
                cb_vivesolo.Enabled = false;
                cb_viveconamigos.Enabled = false;
                cb_familiasinhijos.Enabled = false;
            }
            else
            {
                cb_nuclear.Enabled = true;
                cb_ampliada.Enabled = true;
                cb_monoparental.Enabled = true;
                cb_vivesolo.Enabled = true;
                cb_viveconamigos.Enabled = true;
                cb_familiasinhijos.Enabled = true;
            }
        }

        protected void cb_monoparental_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_monoparental.Checked == true)
            {
                cb_nuclear.Enabled = false;
                cb_ampliada.Enabled = false;
                cb_vivesolo.Enabled = false;
                cb_viveconamigos.Enabled = false;
                cb_familiasinhijos.Enabled = false;
            }
            else
            {
                cb_nuclear.Enabled = true;
                cb_ampliada.Enabled = true;
                cb_monoparental.Enabled = true;
                cb_vivesolo.Enabled = true;
                cb_viveconamigos.Enabled = true;
                cb_familiasinhijos.Enabled = true;
            }
        }

        protected void cb_vivesolo_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_vivesolo.Checked == true)
            {
                cb_nuclear.Enabled = false;
                cb_ampliada.Enabled = false;
                cb_monoparental.Enabled = false;
                cb_viveconamigos.Enabled = false;
                cb_familiasinhijos.Enabled = false;
            }
            else
            {
                cb_nuclear.Enabled = true;
                cb_ampliada.Enabled = true;
                cb_monoparental.Enabled = true;
                cb_vivesolo.Enabled = true;
                cb_viveconamigos.Enabled = true;
                cb_familiasinhijos.Enabled = true;
            }
        }

        protected void cb_viveconamigos_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_viveconamigos.Checked == true)
            {
                cb_nuclear.Enabled = false;
                cb_ampliada.Enabled = false;
                cb_monoparental.Enabled = false;
                cb_vivesolo.Enabled = false;
                cb_familiasinhijos.Enabled = false;
            }
            else
            {
                cb_nuclear.Enabled = true;
                cb_ampliada.Enabled = true;
                cb_monoparental.Enabled = true;
                cb_vivesolo.Enabled = true;
                cb_viveconamigos.Enabled = true;
                cb_familiasinhijos.Enabled = true;
            }
        }

        protected void cb_familiasinhijos_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_familiasinhijos.Checked == true)
            {
                cb_nuclear.Enabled = false;
                cb_ampliada.Enabled = false;
                cb_monoparental.Enabled = false;
                cb_vivesolo.Enabled = false;
                cb_viveconamigos.Enabled = false;
            }
            else
            {
                cb_nuclear.Enabled = true;
                cb_ampliada.Enabled = true;
                cb_monoparental.Enabled = true;
                cb_vivesolo.Enabled = true;
                cb_viveconamigos.Enabled = true;
                cb_familiasinhijos.Enabled = true;
            }
        }

        protected void cb_relacionfamiliarmuybuena_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_relacionfamiliarmuybuena.Checked == true)
            {
                cb_relacionfamiliarbuena.Enabled = false;
                cb_relacionfamiliarregular.Enabled = false;
                cb_relacionfamiliarmala.Enabled = false;
            }
            else
            {
                cb_relacionfamiliarmuybuena.Enabled = true;
                cb_relacionfamiliarbuena.Enabled = true;
                cb_relacionfamiliarregular.Enabled = true;
                cb_relacionfamiliarmala.Enabled = true;
            }
        }

        protected void cb_relacionfamiliarbuena_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_relacionfamiliarbuena.Checked == true)
            {
                cb_relacionfamiliarmuybuena.Enabled = false;
                cb_relacionfamiliarregular.Enabled = false;
                cb_relacionfamiliarmala.Enabled = false;
            }
            else
            {
                cb_relacionfamiliarmuybuena.Enabled = true;
                cb_relacionfamiliarbuena.Enabled = true;
                cb_relacionfamiliarregular.Enabled = true;
                cb_relacionfamiliarmala.Enabled = true;
            }
        }

        protected void cb_relacionfamiliarregular_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_relacionfamiliarregular.Checked == true)
            {
                cb_relacionfamiliarmuybuena.Enabled = false;
                cb_relacionfamiliarbuena.Enabled = false;
                cb_relacionfamiliarmala.Enabled = false;
            }
            else
            {
                cb_relacionfamiliarmuybuena.Enabled = true;
                cb_relacionfamiliarbuena.Enabled = true;
                cb_relacionfamiliarregular.Enabled = true;
                cb_relacionfamiliarmala.Enabled = true;
            }
        }

        protected void cb_relacionfamiliarmala_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_relacionfamiliarmala.Checked == true)
            {
                cb_relacionfamiliarmuybuena.Enabled = false;
                cb_relacionfamiliarbuena.Enabled = false;
                cb_relacionfamiliarregular.Enabled = false;
            }
            else
            {
                cb_relacionfamiliarmuybuena.Enabled = true;
                cb_relacionfamiliarbuena.Enabled = true;
                cb_relacionfamiliarregular.Enabled = true;
                cb_relacionfamiliarmala.Enabled = true;
            }
        }

        protected void cb_relacionparejamuybuena_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_relacionparejamuybuena.Checked == true)
            {
                cb_relacionparejabuena.Enabled = false;
                cb_relacionparejaregular.Enabled = false;
                cb_relacionparejamala.Enabled = false;
            }
            else
            {
                cb_relacionparejamuybuena.Enabled = true;
                cb_relacionparejabuena.Enabled = true;
                cb_relacionparejaregular.Enabled = true;
                cb_relacionparejamala.Enabled = true;
            }
        }

        protected void cb_relacionparejabuena_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_relacionparejabuena.Checked == true)
            {
                cb_relacionparejamuybuena.Enabled = false;
                cb_relacionparejaregular.Enabled = false;
                cb_relacionparejamala.Enabled = false;
            }
            else
            {
                cb_relacionparejamuybuena.Enabled = true;
                cb_relacionparejabuena.Enabled = true;
                cb_relacionparejaregular.Enabled = true;
                cb_relacionparejamala.Enabled = true;
            }
        }

        protected void cb_relacionparejaregular_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_relacionparejaregular.Checked == true)
            {
                cb_relacionparejamuybuena.Enabled = false;
                cb_relacionparejabuena.Enabled = false;
                cb_relacionparejamala.Enabled = false;
            }
            else
            {
                cb_relacionparejamuybuena.Enabled = true;
                cb_relacionparejabuena.Enabled = true;
                cb_relacionparejaregular.Enabled = true;
                cb_relacionparejamala.Enabled = true;
            }
        }

        protected void cb_relacionparejamala_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_relacionparejamala.Checked == true)
            {
                cb_relacionparejamuybuena.Enabled = false;
                cb_relacionparejabuena.Enabled = false;
                cb_relacionparejaregular.Enabled = false;
            }
            else
            {
                cb_relacionparejamuybuena.Enabled = true;
                cb_relacionparejabuena.Enabled = true;
                cb_relacionparejaregular.Enabled = true;
                cb_relacionparejamala.Enabled = true;
            }
        }

        protected void cb_relacionconhijosmuybuena_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_relacionconhijosmuybuena.Checked == true)
            {
                cb_relacionconhijosbuena.Enabled = false;
                cb_relacionconhijosregular.Enabled = false;
                cb_relacionconhijosmala.Enabled = false;
            }
            else
            {
                cb_relacionconhijosmuybuena.Enabled = true;
                cb_relacionconhijosbuena.Enabled = true;
                cb_relacionconhijosregular.Enabled = true;
                cb_relacionconhijosmala.Enabled = true;
            }
        }

        protected void cb_relacionconhijosbuena_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_relacionconhijosbuena.Checked == true)
            {
                cb_relacionconhijosmuybuena.Enabled = false;
                cb_relacionconhijosregular.Enabled = false;
                cb_relacionconhijosmala.Enabled = false;
            }
            else
            {
                cb_relacionconhijosmuybuena.Enabled = true;
                cb_relacionconhijosbuena.Enabled = true;
                cb_relacionconhijosregular.Enabled = true;
                cb_relacionconhijosmala.Enabled = true;
            }
        }

        protected void cb_relacionconhijosregular_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_relacionconhijosregular.Checked == true)
            {
                cb_relacionconhijosmuybuena.Enabled = false;
                cb_relacionconhijosbuena.Enabled = false;
                cb_relacionconhijosmala.Enabled = false;
            }
            else
            {
                cb_relacionconhijosmuybuena.Enabled = true;
                cb_relacionconhijosbuena.Enabled = true;
                cb_relacionconhijosregular.Enabled = true;
                cb_relacionconhijosmala.Enabled = true;
            }
        }

        protected void cb_relacionconhijosmala_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_relacionconhijosmala.Checked == true)
            {
                cb_relacionconhijosmuybuena.Enabled = false;
                cb_relacionconhijosbuena.Enabled = false;
                cb_relacionconhijosregular.Enabled = false;
            }
            else
            {
                cb_relacionconhijosmuybuena.Enabled = true;
                cb_relacionconhijosbuena.Enabled = true;
                cb_relacionconhijosregular.Enabled = true;
                cb_relacionconhijosmala.Enabled = true;
            }
        }

        protected void cb_rolfamiliarsi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_rolfamiliarsi.Checked == true)
            {
                cb_rolfamiliarno.Enabled = false;
            }
            else
            {
                cb_rolfamiliarsi.Enabled = true;
                cb_rolfamiliarno.Enabled = true;
            }
        }

        protected void cb_rolfamiliarno_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_rolfamiliarno.Checked == true)
            {
                cb_rolfamiliarsi.Enabled = false;
            }
            else
            {
                cb_rolfamiliarsi.Enabled = true;
                cb_rolfamiliarno.Enabled = true;
            }
        }

        protected void cb_nivelsaludfamiliarmuybuena_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_nivelsaludfamiliarmuybuena.Checked == true)
            {
                cb_nivelsaludfamiliarbuena.Enabled = false;
                cb_nivelsaludfamiliarregular.Enabled = false;
                cb_nivelsaludfamiliarmala.Enabled = false;
            }
            else
            {
                cb_nivelsaludfamiliarmuybuena.Enabled = true;
                cb_nivelsaludfamiliarbuena.Enabled = true;
                cb_nivelsaludfamiliarregular.Enabled = true;
                cb_nivelsaludfamiliarmala.Enabled = true;
            }
        }

        protected void cb_nivelsaludfamiliarbuena_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_nivelsaludfamiliarbuena.Checked == true)
            {
                cb_nivelsaludfamiliarmuybuena.Enabled = false;
                cb_nivelsaludfamiliarregular.Enabled = false;
                cb_nivelsaludfamiliarmala.Enabled = false;
            }
            else
            {
                cb_nivelsaludfamiliarmuybuena.Enabled = true;
                cb_nivelsaludfamiliarbuena.Enabled = true;
                cb_nivelsaludfamiliarregular.Enabled = true;
                cb_nivelsaludfamiliarmala.Enabled = true;
            }
        }

        protected void cb_nivelsaludfamiliarregular_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_nivelsaludfamiliarregular.Checked == true)
            {
                cb_nivelsaludfamiliarmuybuena.Enabled = false;
                cb_nivelsaludfamiliarbuena.Enabled = false;
                cb_nivelsaludfamiliarmala.Enabled = false;
            }
            else
            {
                cb_nivelsaludfamiliarmuybuena.Enabled = true;
                cb_nivelsaludfamiliarbuena.Enabled = true;
                cb_nivelsaludfamiliarregular.Enabled = true;
                cb_nivelsaludfamiliarmala.Enabled = true;
            }
        }

        protected void cb_nivelsaludfamiliarmala_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_nivelsaludfamiliarmala.Checked == true)
            {
                cb_nivelsaludfamiliarmuybuena.Enabled = false;
                cb_nivelsaludfamiliarbuena.Enabled = false;
                cb_nivelsaludfamiliarregular.Enabled = false;
            }
            else
            {
                cb_nivelsaludfamiliarmuybuena.Enabled = true;
                cb_nivelsaludfamiliarbuena.Enabled = true;
                cb_nivelsaludfamiliarregular.Enabled = true;
                cb_nivelsaludfamiliarmala.Enabled = true;
            }
        }

        protected void cb_funcional_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_funcional.Checked == true)
            {
                cb_disfuncional.Enabled = false;
            }
            else
            {
                cb_funcional.Enabled = true;
                cb_disfuncional.Enabled = true;
            }
        }

        protected void cb_disfuncional_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_disfuncional.Checked == true)
            {
                cb_funcional.Enabled = false;
            }
            else
            {
                cb_funcional.Enabled = true;
                cb_disfuncional.Enabled = true;
            }
        }

        protected void cb_certificosi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_certificosi.Checked == true)
            {
                cb_certificono.Enabled = false;
            }
            else
            {
                cb_certificosi.Enabled = true;
                cb_certificono.Enabled = true;
            }
        }

        protected void cb_certificono_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_certificono.Checked == true)
            {
                cb_certificosi.Enabled = false;
            }
            else
            {
                cb_certificosi.Enabled = true;
                cb_certificono.Enabled = true;
            }
        }

        protected void btn_totalingresos_Click(object sender, EventArgs e)
        {
            if (txt_totalingresos1.Text.Equals("") || txt_totalingresos2.Text.Equals("") || txt_totalingresos3.Text.Equals("") || txt_totalingresos4.Text.Equals("") ||
                txt_totalingresos5.Text.Equals("") || txt_totalingresos6.Text.Equals("") || txt_totalingresos7.Text.Equals("") || txt_totalingresos8.Text.Equals(""))
            {
                lbl_total_ingresos.Text = "!Complete los campos!";
            }
            else
            {
                int valor1 = Convert.ToInt32(txt_totalingresos1.Text.ToString().Trim());
                int valor2 = Convert.ToInt32(txt_totalingresos2.Text.ToString().Trim());
                int valor3 = Convert.ToInt32(txt_totalingresos3.Text.ToString().Trim());
                int valor4 = Convert.ToInt32(txt_totalingresos4.Text.ToString().Trim());
                int valor5 = Convert.ToInt32(txt_totalingresos5.Text.ToString().Trim());
                int valor6 = Convert.ToInt32(txt_totalingresos6.Text.ToString().Trim());
                int valor7 = Convert.ToInt32(txt_totalingresos7.Text.ToString().Trim());
                int valor8 = Convert.ToInt32(txt_totalingresos8.Text.ToString().Trim());

                int total = valor1 + valor2 + valor3 + valor4 + valor5 + valor6 + valor7 + valor8;

                txt_totalingresos9.Text = total.ToString();

                lbl_total_ingresos.Visible = false;                
            }
        }

        protected void btn_total_ayuda_otros_Click(object sender, EventArgs e)
        {
            if (txt_ayuda1.Text.Equals("") || txt_ayuda2.Text.Equals("") || txt_ayuda3.Text.Equals("") || txt_ayuda4.Text.Equals("") ||
                txt_ayuda5.Text.Equals("") || txt_ayuda6.Text.Equals("") || txt_ayuda7.Text.Equals("") || txt_ayuda8.Text.Equals("") ||
                txt_otros1.Text.Equals("") || txt_otros2.Text.Equals("") || txt_otros3.Text.Equals("") || txt_otros4.Text.Equals("") ||
                txt_otros5.Text.Equals("") || txt_otros6.Text.Equals("") || txt_otros7.Text.Equals("") || txt_otros8.Text.Equals(""))
            {
                lbl_total_ayuda_otros.Text = "!Complete los campos!";
            }
            else
            {
                int ayuda1 = Convert.ToInt32(txt_ayuda1.Text.ToString().Trim());
                int ayuda2 = Convert.ToInt32(txt_ayuda2.Text.ToString().Trim());
                int ayuda3 = Convert.ToInt32(txt_ayuda3.Text.ToString().Trim());
                int ayuda4 = Convert.ToInt32(txt_ayuda4.Text.ToString().Trim());
                int ayuda5 = Convert.ToInt32(txt_ayuda5.Text.ToString().Trim());
                int ayuda6 = Convert.ToInt32(txt_ayuda6.Text.ToString().Trim());
                int ayuda7 = Convert.ToInt32(txt_ayuda7.Text.ToString().Trim());
                int ayuda8 = Convert.ToInt32(txt_ayuda8.Text.ToString().Trim());

                int otros1 = Convert.ToInt32(txt_otros1.Text.ToString().Trim());
                int otros2 = Convert.ToInt32(txt_otros2.Text.ToString().Trim());
                int otros3 = Convert.ToInt32(txt_otros3.Text.ToString().Trim());
                int otros4 = Convert.ToInt32(txt_otros4.Text.ToString().Trim());
                int otros5 = Convert.ToInt32(txt_otros5.Text.ToString().Trim());
                int otros6 = Convert.ToInt32(txt_otros6.Text.ToString().Trim());
                int otros7 = Convert.ToInt32(txt_otros7.Text.ToString().Trim());
                int otros8 = Convert.ToInt32(txt_otros8.Text.ToString().Trim());

                int total = ayuda1 + ayuda2 + ayuda3 + ayuda4 + ayuda5 + ayuda6 + ayuda7 + ayuda8 +
                            otros1 + otros2 + otros3 + otros4 + otros5 + otros6 + otros7 + otros8;

                txt_totalayudayotros9.Text = total.ToString();

                lbl_total_ayuda_otros.Visible = false;
            }

        }

        protected void btn_totalegresos_Click(object sender, EventArgs e)
        {
            if (txt_alimentación.Text.Equals("") || txt_vivienda.Text.Equals("") || txt_educación.Text.Equals("") || txt_serviciosbasicos.Text.Equals("") ||
                txt_salud.Text.Equals("") || txt_movilización.Text.Equals("") || txt_deudas.Text.Equals("") || txt_otrospensiones.Text.Equals(""))
            {
                lbl_total_egresos.Text = "!Complete los campos!";
            }
            else
            {
                int egreso1 = Convert.ToInt32(txt_alimentación.Text.ToString().Trim());
                int egreso2 = Convert.ToInt32(txt_vivienda.Text.ToString().Trim());
                int egreso3 = Convert.ToInt32(txt_educación.Text.ToString().Trim());
                int egreso4 = Convert.ToInt32(txt_serviciosbasicos.Text.ToString().Trim());
                int egreso5 = Convert.ToInt32(txt_salud.Text.ToString().Trim());
                int egreso6 = Convert.ToInt32(txt_movilización.Text.ToString().Trim());
                int egreso7 = Convert.ToInt32(txt_deudas.Text.ToString().Trim());
                int egreso8 = Convert.ToInt32(txt_otrospensiones.Text.ToString().Trim());

                int total = egreso1 + egreso2 + egreso3 + egreso4 + egreso5 + egreso6 + egreso7 + egreso8;

                txt_totalegresos.Text = total.ToString();

                lbl_total_egresos.Visible = false;
            }

        }
        protected void btn_imprimir_Click(object sender, EventArgs e)
        {
            HtmlNode.ElementsFlags["img"] = HtmlElementFlag.Closed;
            HtmlNode.ElementsFlags["br"] = HtmlElementFlag.Closed;
            Document pdfDoc = new Document(PageSize.A4, 15f, 15f, 15f, 15f);
            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            BaseFont fuente = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, true);
            Font titulo = new Font(fuente, 10f, Font.NORMAL, new BaseColor(0, 0, 0));
            BaseFont fuente2 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, true);
            Font parrafo = new Font(fuente2, 12f, Font.NORMAL, new BaseColor(0, 0, 0));
            BaseFont fuente3 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, true);
            Font cuadro = new Font(fuente3, 10f, Font.NORMAL, new BaseColor(0, 0, 0));

            pdfDoc.Open();
            pdfDoc.Add(new Paragraph("GESTIÓN DEL TALENTO HUMANO", titulo) { Alignment = Element.ALIGN_CENTER });
            pdfDoc.Add(new Paragraph("GESTIÓN DE BIENESTAR LABORAL Y SALUD OCUPACIONAL", titulo) { Alignment = Element.ALIGN_CENTER });
            pdfDoc.Add(new Paragraph("FICHA SOCIOECONÓMICA", titulo) { Alignment = Element.ALIGN_CENTER });
            pdfDoc.Add(new Paragraph(" "));

            var tblcvTitulo = new PdfPTable(new float[] { 200f, 200f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tblcvTitulo.AddCell(new PdfPCell(new Paragraph("Código", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblcvTitulo.AddCell(new PdfPCell(new Paragraph("Versión", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            pdfDoc.Add(tblcvTitulo);
            var tblcvDatos = new PdfPTable(new float[] { 70f, 50f, 50f, 50f, 50f, 30f, 50f, 50f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tblcvDatos.AddCell(new PdfPCell(new Paragraph(txt_codigoinicio.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblcvDatos.AddCell(new PdfPCell(new Paragraph(txt_version.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            pdfDoc.Add(tblcvDatos);
            pdfDoc.Add(new Paragraph(" "));
            pdfDoc.Add(new Paragraph(" "));

            var tbldatospersonales = new PdfPTable(new float[] { 70f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tbldatospersonales.AddCell(new PdfPCell(new Paragraph("I. DATOS PERSONALES DEL SERVIDOR/A", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 205, 254), HorizontalAlignment = Element.ALIGN_LEFT });
            pdfDoc.Add(tbldatospersonales);
            pdfDoc.Add(new Paragraph(" "));
            var tbldpTitulo = new PdfPTable(new float[] { 100f, 50f, 50f, 50f, 50f, 50f, 50f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tbldpTitulo.AddCell(new PdfPCell(new Paragraph("Nombres y Apellidos:", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tbldpTitulo.AddCell(new PdfPCell(new Paragraph(txt_prinombre.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tbldpTitulo.AddCell(new PdfPCell(new Paragraph(txt_segnombre.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tbldpTitulo.AddCell(new PdfPCell(new Paragraph(txt_priapellido.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tbldpTitulo.AddCell(new PdfPCell(new Paragraph(txt_segapellido.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tbldpTitulo.AddCell(new PdfPCell(new Paragraph("Cédula:", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tbldpTitulo.AddCell(new PdfPCell(new Paragraph(txt_cedula.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            pdfDoc.Add(tbldpTitulo);
            pdfDoc.Add(new Paragraph(" "));
            var tbldaTitulo = new PdfPTable(new float[] { 150f, 150f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tbldaTitulo.AddCell(new PdfPCell(new Paragraph("Departamento / Área en la que trabaja:", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tbldaTitulo.AddCell(new PdfPCell(new Paragraph(txt_areatrabajo.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            pdfDoc.Add(tbldaTitulo);
            pdfDoc.Add(new Paragraph(" "));
            var tblciTitulo = new PdfPTable(new float[] { 200f, 200f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tblciTitulo.AddCell(new PdfPCell(new Paragraph("Cargo Institucional:", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblciTitulo.AddCell(new PdfPCell(new Paragraph(txt_cargoinstitucional.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            pdfDoc.Add(tblciTitulo);
            pdfDoc.Add(new Paragraph(" "));
            var tblmvTitulo = new PdfPTable(new float[] { 70f, 70f, 15f, 60f, 15f, 60f, 35f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tblmvTitulo.AddCell(new PdfPCell(new Paragraph("Modalidad de vinculación:", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblmvTitulo.AddCell(new PdfPCell(new Paragraph("Ley Organica del Sector Público (LOSEP)", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblmvTitulo.AddCell(new PdfPCell(new Paragraph(Convert.ToString(cb_modalidadvinculacionlosep.Checked), cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblmvTitulo.AddCell(new PdfPCell(new Paragraph("Código de trabajo", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblmvTitulo.AddCell(new PdfPCell(new Paragraph(Convert.ToString(cb_modalidadvinculacioncodigotrabajo.Checked), cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblmvTitulo.AddCell(new PdfPCell(new Paragraph("Fecha ingreso al ECU", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblmvTitulo.AddCell(new PdfPCell(new Paragraph(txt_fechaingresoalsisecu.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            pdfDoc.Add(tblmvTitulo);
            pdfDoc.Add(new Paragraph(" "));
            var tblecTitulo = new PdfPTable(new float[] { 40f, 40f, 15f, 40f, 15f, 40f, 15f, 40f, 15f, 40f, 15f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tblecTitulo.AddCell(new PdfPCell(new Paragraph("Estado Civil:", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblecTitulo.AddCell(new PdfPCell(new Paragraph("Soltero", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblecTitulo.AddCell(new PdfPCell(new Paragraph(Convert.ToString(cb_soltero.Checked), cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblecTitulo.AddCell(new PdfPCell(new Paragraph("Casado", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblecTitulo.AddCell(new PdfPCell(new Paragraph(Convert.ToString(cb_casado.Checked), cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblecTitulo.AddCell(new PdfPCell(new Paragraph("Viudo", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblecTitulo.AddCell(new PdfPCell(new Paragraph(Convert.ToString(cb_viudo.Checked), cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblecTitulo.AddCell(new PdfPCell(new Paragraph("Unión Libre", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblecTitulo.AddCell(new PdfPCell(new Paragraph(Convert.ToString(cb_unionlibre.Checked), cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblecTitulo.AddCell(new PdfPCell(new Paragraph("Divorciado", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblecTitulo.AddCell(new PdfPCell(new Paragraph(Convert.ToString(cb_divorciado.Checked), cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            pdfDoc.Add(tblecTitulo);
            pdfDoc.Add(new Paragraph(" "));
            var tblgTitulo = new PdfPTable(new float[] { 30f, 30f, 15f, 30f, 15f, 40f, 30f, 40f, 15f, 15f, 15f, 15f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tblgTitulo.AddCell(new PdfPCell(new Paragraph("Género:", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblgTitulo.AddCell(new PdfPCell(new Paragraph("Masculino", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblgTitulo.AddCell(new PdfPCell(new Paragraph(Convert.ToString(cb_genmasculino.Checked), cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblgTitulo.AddCell(new PdfPCell(new Paragraph("Femenino", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblgTitulo.AddCell(new PdfPCell(new Paragraph(Convert.ToString(cb_genfemenino.Checked), cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblgTitulo.AddCell(new PdfPCell(new Paragraph("Tipo de Sangre:", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblgTitulo.AddCell(new PdfPCell(new Paragraph(txt_tipodesangre.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblgTitulo.AddCell(new PdfPCell(new Paragraph("¿Es donante?", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblgTitulo.AddCell(new PdfPCell(new Paragraph("Si", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblgTitulo.AddCell(new PdfPCell(new Paragraph(Convert.ToString(cb_donantesi.Checked), cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblgTitulo.AddCell(new PdfPCell(new Paragraph("No", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblgTitulo.AddCell(new PdfPCell(new Paragraph(Convert.ToString(cb_donanteno.Checked), cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            pdfDoc.Add(tblgTitulo);
            pdfDoc.Add(new Paragraph(" "));
            var tbltelfTitulo = new PdfPTable(new float[] { 150f, 75f, 100f, 75f, 50f, 150f}) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tbltelfTitulo.AddCell(new PdfPCell(new Paragraph("Teléfono Convencional:", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tbltelfTitulo.AddCell(new PdfPCell(new Paragraph(txt_telconvecional.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tbltelfTitulo.AddCell(new PdfPCell(new Paragraph("Teléfono Celular:", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tbltelfTitulo.AddCell(new PdfPCell(new Paragraph(txt_telcelular.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tbltelfTitulo.AddCell(new PdfPCell(new Paragraph("Email:", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tbltelfTitulo.AddCell(new PdfPCell(new Paragraph(txt_email.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            pdfDoc.Add(tbltelfTitulo);
            pdfDoc.Add(new Paragraph(" "));
            var tbllnTitulo = new PdfPTable(new float[] { 150f, 100f, 150f, 100f, 50, 150f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tbllnTitulo.AddCell(new PdfPCell(new Paragraph("Lugar de Nacimiento:", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tbllnTitulo.AddCell(new PdfPCell(new Paragraph(txt_lugarnacimiento.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tbllnTitulo.AddCell(new PdfPCell(new Paragraph("Fecha de Nacimiento:", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tbllnTitulo.AddCell(new PdfPCell(new Paragraph(txt_fechanacimiento.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tbllnTitulo.AddCell(new PdfPCell(new Paragraph("Edad:", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tbllnTitulo.AddCell(new PdfPCell(new Paragraph(txt_edad.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            pdfDoc.Add(tbllnTitulo);
            pdfDoc.Add(new Paragraph(" "));
            var tblneTitulo = new PdfPTable(new float[] { 40f, 30f, 15f, 30f, 15f, 25f, 15f, 40f, 15f, 30f, 15f, 25f, 15f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tblneTitulo.AddCell(new PdfPCell(new Paragraph("Nivel de Educación:", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblneTitulo.AddCell(new PdfPCell(new Paragraph("Primaria", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblneTitulo.AddCell(new PdfPCell(new Paragraph(Convert.ToString(cb_primaria.Checked), cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblneTitulo.AddCell(new PdfPCell(new Paragraph("Secundaria", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblneTitulo.AddCell(new PdfPCell(new Paragraph(Convert.ToString(cb_secundaria.Checked), cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblneTitulo.AddCell(new PdfPCell(new Paragraph("Superior", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblneTitulo.AddCell(new PdfPCell(new Paragraph(Convert.ToString(cb_superior.Checked), cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblneTitulo.AddCell(new PdfPCell(new Paragraph("Especialización", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblneTitulo.AddCell(new PdfPCell(new Paragraph(Convert.ToString(cb_especializacion.Checked), cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblneTitulo.AddCell(new PdfPCell(new Paragraph("Diplomado", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblneTitulo.AddCell(new PdfPCell(new Paragraph(Convert.ToString(cb_diplomado.Checked), cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblneTitulo.AddCell(new PdfPCell(new Paragraph("Maestría", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblneTitulo.AddCell(new PdfPCell(new Paragraph(Convert.ToString(cb_maestria.Checked), cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            pdfDoc.Add(tblneTitulo);
            pdfDoc.Add(new Paragraph(" "));
            var tblaiTitulo = new PdfPTable(new float[] { 45f, 30f, 15f, 30f, 15f, 50f, 15f, 30f, 15f, 30f, 15f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tblaiTitulo.AddCell(new PdfPCell(new Paragraph("Autoidentificación Étnica:", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblaiTitulo.AddCell(new PdfPCell(new Paragraph("Blanco", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblaiTitulo.AddCell(new PdfPCell(new Paragraph(Convert.ToString(cb_blanco.Checked), cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblaiTitulo.AddCell(new PdfPCell(new Paragraph("Mestizo", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblaiTitulo.AddCell(new PdfPCell(new Paragraph(Convert.ToString(cb_mestizo.Checked), cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblaiTitulo.AddCell(new PdfPCell(new Paragraph("Afrodescendiente", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblaiTitulo.AddCell(new PdfPCell(new Paragraph(Convert.ToString(cb_afro.Checked), cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblaiTitulo.AddCell(new PdfPCell(new Paragraph("Indígena", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblaiTitulo.AddCell(new PdfPCell(new Paragraph(Convert.ToString(cb_indigena.Checked), cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblaiTitulo.AddCell(new PdfPCell(new Paragraph("Montubio", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblaiTitulo.AddCell(new PdfPCell(new Paragraph(Convert.ToString(cb_montubio.Checked), cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            pdfDoc.Add(tblaiTitulo);
            pdfDoc.Add(new Paragraph(" "));
            var tblddTitulo = new PdfPTable(new float[] { 150f, 100f, 100f, 75f, 100, 100f, 100f, 75f, 125f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tblddTitulo.AddCell(new PdfPCell(new Paragraph("Dirección del domicilio:", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblddTitulo.AddCell(new PdfPCell(new Paragraph("Provincia:", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblddTitulo.AddCell(new PdfPCell(new Paragraph(txt_provincia.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblddTitulo.AddCell(new PdfPCell(new Paragraph("Canton:", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblddTitulo.AddCell(new PdfPCell(new Paragraph(txt_canton.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblddTitulo.AddCell(new PdfPCell(new Paragraph("Parroquia:", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblddTitulo.AddCell(new PdfPCell(new Paragraph(txt_parroquia.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblddTitulo.AddCell(new PdfPCell(new Paragraph("Barrio:", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblddTitulo.AddCell(new PdfPCell(new Paragraph(txt_barrio.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            pdfDoc.Add(tblddTitulo);
            pdfDoc.Add(new Paragraph(" "));
            var tblccTitulo = new PdfPTable(new float[] { 150f, 150f, 100f, 150f, 100, 150f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tblccTitulo.AddCell(new PdfPCell(new Paragraph("Calle donde está ubicada la vivienda y numeración:", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblccTitulo.AddCell(new PdfPCell(new Paragraph(txt_calleubicada.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblccTitulo.AddCell(new PdfPCell(new Paragraph("Calle secundaria:", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblccTitulo.AddCell(new PdfPCell(new Paragraph(txt_callesecundaria.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblccTitulo.AddCell(new PdfPCell(new Paragraph("Referencia para ubicar el domicilio:", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblccTitulo.AddCell(new PdfPCell(new Paragraph(txt_refubicardomicilio.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            pdfDoc.Add(tblccTitulo);

            pdfDoc.Close();
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=FichaMedica.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Write(pdfDoc);
            Response.End();
        }
    }
}