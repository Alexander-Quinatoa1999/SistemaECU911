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

namespace SistemaECU911.Template.Views_Socio_Economico
{
    public partial class SocioEconomico : System.Web.UI.Page
    {

        DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        private Tbl_Personas per = new Tbl_Personas();

        private Tbl_SocioEconomico sso = new Tbl_SocioEconomico();

        protected void Page_Load(object sender, EventArgs e)
        {
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

                        if (sso != null)
                        {
                            txt_fecha.Text = sso.Socio_economico_fechaHora.ToString();

                            //Datos Generales
                            txt_fechaingresoalsisecu.Text = sso.Socio_economico_fecha_ingreso_al_Ecu.ToString();
                            txt_tipodesangre.Text = sso.Socio_economico_tipodesangre.ToString();

                            txt_telconvecional.Text = sso.Socio_economico_telefonoconvencional.ToString();
                            txt_telcelular.Text = sso.Socio_economico_telefonocelular.ToString();
                            txt_email.Text = sso.Socio_economico_email.ToString();

                            txt_lugarnacimiento.Text = sso.Socio_economico_lugardenacimiento.ToString();
                            txt_fechanacimiento.Text = sso.Socio_economico_fechadeNacimiento.ToString();
                            txt_edad.Text = sso.Socio_economico_edad.ToString();

                            txt_provincia.Text = sso.Socio_economico_direcciondomicilio_provincia.ToString();
                            txt_canton.Text = sso.Socio_economico_direcciondomicilio_canton.ToString();
                            txt_canton.Text = sso.Socio_economico_direcciondomicilio_parroquia.ToString();
                            txt_barrio.Text = sso.Socio_economico_direcciondomicilio_barrio.ToString();

                            txt_calleubicada.Text = sso.Socio_economico_calle_vivienda_numeracion.ToString();
                            txt_callesecundaria.Text = sso.Socio_economico_calle_secundaria.ToString();
                            txt_refubicardomicilio.Text = sso.Socio_economico_referencia_ubicar_domicilio.ToString();

                            txt_otrosector.Text = sso.Socio_economico_sectorvive_otro_indique.ToString();
                            txt_tipoviviendaotro.Text = sso.Socio_economico_tipovivienda_otro_indique.ToString();

                            txt_personanvivenusted.Text = sso.Socio_economico_cuantas_personas_viven_con_usted.ToString();
                            txt_personanviveneventualusted.Text = sso.Socio_economico_cuantas_personas_viven_eventual_con_usted.ToString();
                            txt_emernomyape.Text = sso.Socio_economico_contacto_emergencia_nombres_apellidos.ToString();
                            txt_emeparentesco.Text = sso.Socio_economico_contacto_emergencia_parentesco.ToString();
                            txt_emetelefono.Text = sso.Socio_economico_contacto_emergencia_telefono.ToString();
                            txt_emecalleprincipal.Text = sso.Socio_economico_contacto_emergencia_calle_principal.ToString();
                            txt_emenumdomicilio.Text = sso.Socio_economico_contacto_emergencia_numero_domicilio.ToString();
                            txt_emecallesecun.Text = sso.Socio_economico_contacto_emergencia_calle_secundaria.ToString();
                            txt_emerefubicardomicilio.Text = sso.Socio_economico_contacto_emergencia_referencia_domicilio.ToString();

                            txt_distanciadomiciotrabajo.Text = sso.Socio_economico_distancia_domicilio_trabajo.ToString();

                            //Salud
                            txt_poseeenfermedadingresarEcu.Text = sso.Socio_economico_posee_enfermedad.ToString();
                            txt_tipodiscapacidad.Text = sso.Socio_economico_discapacidad_tipo.ToString();
                            txt_porcentajediscapacidad.Text = sso.Socio_economico_discapacidad_porcentaje.ToString();
                            txt_numcarnetconadis.Text = sso.Socio_economico_discapacidad_carnet_conadis.ToString();
                            txt_fechacaducidadcarnet.Text = sso.Socio_economico_discapacidad_fecha_caducidad_carnet.ToString();

                            txt_mesgestacion.Text = sso.Socio_economico_mes_gestacion.ToString();
                            txt_fechatentativaparto.Text = sso.Socio_economico_fecha_tentativa_parto.ToString();
                            txt_fechaculmicacionlactancia.Text = sso.Socio_economico_periodo_lactancia_fecha_culminacion.ToString();

                            txt_cualcatastrofica.Text = sso.Socio_economico_enfermedad_cronica_cual.ToString();
                            txt_otrasenfermedades.Text = sso.Socio_economico_enfermedad_cronica_otras.ToString();
                            txt_enfermedadraracual.Text = sso.Socio_economico_enfermedad_rara_cual.ToString();

                            txt_frecuenciaconsumoalcohol.Text = sso.Socio_economico_consume_alcohol_frecuencia_consumo.ToString();
                            txt_tiempoconsumoalcohol.Text = sso.Socio_economico_consume_alcohol_tiempo_consumo.ToString();
                            txt_frecuenciaconsumotabaco.Text = sso.Socio_economico_consume_tabaco_frecuencia_consumo.ToString();
                            txt_tiempoconsumotabaco.Text = sso.Socio_economico_consume_tabaco_tiempo_consumo.ToString();
                            txt_sustanciapsicotropicatipo.Text = sso.Socio_economico_consume_sustancia_psicotropica_tipo.ToString();
                            txt_sustanciapsicotropicafrecuencia.Text = sso.Socio_economico_consume_sustancia_psicotropica_frecuencia_consumo.ToString();

                            //Situacion económica del servidor
                            txt_totalingreso1.Text = sso.Socio_economico_total_ingresos_mensuales_proyectados_1.ToString();
                            txt_ayudafamiliares1.Text = sso.Socio_economico_ayuda_padres1.ToString();
                            txt_otrosingresos1.Text = sso.Socio_economico_otros_ingresos1.ToString();
                            txt_alimentacion.Text = sso.Socio_economico_total_egresos_mensuales_proyectados_alimentacion.ToString();

                            txt_totalingreso2.Text = sso.Socio_economico_total_ingresos_mensuales_proyectados_2.ToString();
                            txt_ayudafamiliares2.Text = sso.Socio_economico_ayuda_padres2.ToString();
                            txt_otrosingresos2.Text = sso.Socio_economico_otros_ingresos2.ToString();
                            txt_vivienda.Text = sso.Socio_economico_total_egresos_mensuales_proyectados_vivienda.ToString();

                            txt_totalingreso3.Text = sso.Socio_economico_total_ingresos_mensuales_proyectados_3.ToString();
                            txt_ayudafamiliares3.Text = sso.Socio_economico_ayuda_padres3.ToString();
                            txt_otrosingresos3.Text = sso.Socio_economico_otros_ingresos3.ToString();
                            txt_educacion.Text = sso.Socio_economico_total_egresos_mensuales_proyectados_educacion.ToString();

                            txt_totalingreso4.Text = sso.Socio_economico_total_ingresos_mensuales_proyectados_4.ToString();
                            txt_ayudafamiliares4.Text = sso.Socio_economico_ayuda_padres4.ToString();
                            txt_otrosingresos4.Text = sso.Socio_economico_otros_ingresos4.ToString();
                            txt_serviciosbasicos.Text = sso.Socio_economico_total_egresos_mensuales_proyectados_servicios_basicos.ToString();

                            txt_totalingreso5.Text = sso.Socio_economico_total_ingresos_mensuales_proyectados_5.ToString();
                            txt_ayudafamiliares5.Text = sso.Socio_economico_ayuda_padres5.ToString();
                            txt_otrosingresos5.Text = sso.Socio_economico_otros_ingresos5.ToString();
                            txt_Salud.Text = sso.Socio_economico_total_egresos_mensuales_proyectados_salud.ToString();

                            txt_totalingreso6.Text = sso.Socio_economico_total_ingresos_mensuales_proyectados_6.ToString();
                            txt_ayudafamiliares6.Text = sso.Socio_economico_ayuda_padres6.ToString();
                            txt_otrosingresos6.Text = sso.Socio_economico_otros_ingresos6.ToString();
                            txt_movilizacion.Text = sso.Socio_economico_total_egresos_mensuales_proyectados_movilizacion.ToString();

                            txt_totalingreso7.Text = sso.Socio_economico_total_ingresos_mensuales_proyectados_7.ToString();
                            txt_ayudafamiliares7.Text = sso.Socio_economico_ayuda_padres7.ToString();
                            txt_otrosingresos7.Text = sso.Socio_economico_otros_ingresos7.ToString();
                            txt_deudas.Text = sso.Socio_economico_total_egresos_mensuales_proyectados_deudas.ToString();

                            txt_totalingreso8.Text = sso.Socio_economico_total_ingresos_mensuales_proyectados_8.ToString();
                            txt_ayudafamiliares8.Text = sso.Socio_economico_ayuda_padres8.ToString();
                            txt_otrosingresos8.Text = sso.Socio_economico_otros_ingresos8.ToString();
                            txt_otropensionesvarios.Text = sso.Socio_economico_total_egresos_mensuales_proyectados_otros.ToString();

                            txt_totalingreso9.Text = sso.Socio_economico_total_ingresos_mensuales_proyectados_total_9.ToString();
                            txt_ayudafamiliares9.Text = sso.Socio_economico_ayuda_padres_total9.ToString();
                            txt_otrosingresos9.Text = sso.Socio_economico_otros_ingresos_total9.ToString();
                            txt_totalegresosmensualesproyectados.Text = sso.Socio_economico_total_egresos_mensuales_proyectados_total.ToString();

                            txt_totalfinal.Text = sso.Socio_economico_total_egresos_mensuales_proyectados_total_general.ToString();

                            txt_valorcasa.Text = sso.Socio_economico_descripcion_mueble_valor_casa.ToString();
                            txt_direccioncasa.Text = sso.Socio_economico_descripcion_mueble_detalle_direccion_casa.ToString();
                            txt_valordepartamento.Text = sso.Socio_economico_descripcion_mueble_valor_departamento.ToString();
                            txt_direcciondepartamento.Text = sso.Socio_economico_descripcion_mueble_detalle_direccion_departamento.ToString();
                            txt_valorvehiculo.Text = sso.Socio_economico_descripcion_mueble_valor_vehiculo.ToString();
                            txt_detallevehiculo.Text = sso.Socio_economico_descripcion_mueble_detalle_detalle_vehiculo.ToString();
                            txt_valorterreno.Text = sso.Socio_economico_descripcion_mueble_valor_terreno.ToString();
                            txt_sectorterreno.Text = sso.Socio_economico_descripcion_mueble_detalle_sector_terreno.ToString();
                            txt_valornegocio.Text = sso.Socio_economico_descripcion_mueble_valor_negocio.ToString();
                            txt_detallenegocio.Text = sso.Socio_economico_descripcion_mueble_detalle_detalle_negocio.ToString();
                            txt_valormueblesenseres.Text = sso.Socio_economico_descripcion_mueble_valor_muebles_enseres.ToString();
                            txt_detallemueblesenseres.Text = sso.Socio_economico_descripcion_mueble_detalle_detalle_muebles_enseres.ToString();

                            txt_otrodescrpcionfamilia.Text = sso.Socio_economico_caracteristica_vivienda_descripcion_otra_especifique.ToString();
                            txt_otratenencia.Text = sso.Socio_economico_caracteristica_vivienda_tenencia_otra_especifique.ToString();
                            txt_otrotipodecasa.Text = sso.Socio_economico_caracteristica_vivienda_tipo_otro_especifique.ToString();
                            txt_otradistribucioncasa.Text = sso.Socio_economico_caracteristica_vivienda_distribucion_otro_especifique.ToString();
                            txt_otrainformacioncasa.Text = sso.Socio_economico_caracteristica_vivienda_otro_especifique.ToString();
                            txt_movilizadecasaatrabajo.Text = sso.Socio_economico_como_moviliza_vivienda_a_trabajo.ToString();

                            //Información Familiar
                            txt_nomapellidos1.Text = sso.Socio_economico_nombres_apellidos_familiar1.ToString();
                            txt_parentesco1.Text = sso.Socio_economico_parentesco_familiar1.ToString();
                            txt_fechanacimiento1.Text = sso.Socio_economico_fecha_nacimiento_familiar1.ToString();
                            txt_edad1.Text = sso.Socio_economico_edad_familiar1.ToString();

                            txt_nomapellidos2.Text = sso.Socio_economico_nombres_apellidos_familiar2.ToString();
                            txt_parentesco2.Text = sso.Socio_economico_parentesco_familiar2.ToString();
                            txt_fechanacimiento2.Text = sso.Socio_economico_fecha_nacimiento_familiar2.ToString();
                            txt_edad2.Text = sso.Socio_economico_edad_familiar2.ToString();

                            txt_nomapellidos3.Text = sso.Socio_economico_nombres_apellidos_familiar3.ToString();
                            txt_parentesco3.Text = sso.Socio_economico_parentesco_familiar3.ToString();
                            txt_fechanacimiento3.Text = sso.Socio_economico_fecha_nacimiento_familiar3.ToString();
                            txt_edad3.Text = sso.Socio_economico_edad_familiar3.ToString();

                            txt_nomapellidos4.Text = sso.Socio_economico_nombres_apellidos_familiar4.ToString();
                            txt_parentesco4.Text = sso.Socio_economico_parentesco_familiar4.ToString();
                            txt_fechanacimiento4.Text = sso.Socio_economico_fecha_nacimiento_familiar4.ToString();
                            txt_edad4.Text = sso.Socio_economico_edad_familiar4.ToString();

                            txt_nomapellidos5.Text = sso.Socio_economico_nombres_apellidos_familiar5.ToString();
                            txt_parentesco5.Text = sso.Socio_economico_parentesco_familiar5.ToString();
                            txt_fechanacimiento5.Text = sso.Socio_economico_fecha_nacimiento_familiar5.ToString();
                            txt_edad5.Text = sso.Socio_economico_edad_familiar5.ToString();

                            txt_familiardiscapacitadonomape1.Text = sso.Socio_economico_nombres_apellidos_familiar_discapacidad1.ToString();
                            txt_familiardiscapacitadofechacaducidadcarnet1.Text = sso.Socio_economico_fecha_caducidad_carnet_familiar_discapacidad1.ToString();
                            txt_familiardiscapacitadotipodiscapacidad1.Text = sso.Socio_economico_familiar_discapacidad_tipo1.ToString();
                            txt_familiardiscapacitadoporcentajediscapacidad1.Text = sso.Socio_economico_familiar_discapacidad_porcentaje1.ToString();
                            txt_familiardiscapacitadoparentesco1.Text = sso.Socio_economico_familiar_discapacidad_parentesco1.ToString();
                            txt_familiardiscapacitadofechanacimiento1.Text = sso.Socio_economico_familiar_discapacidad_fecha_nacimiento1.ToString();

                            txt_familiardiscapacitadonomape2.Text = sso.Socio_economico_nombres_apellidos_familiar_discapacidad2.ToString();
                            txt_familiardiscapacitadofechacaducidadcarnet2.Text = sso.Socio_economico_fecha_caducidad_carnet_familiar_discapacidad2.ToString();
                            txt_familiardiscapacitadotipodiscapacidad2.Text = sso.Socio_economico_familiar_discapacidad_tipo2.ToString();
                            txt_familiardiscapacitadoporcentajediscapacidad2.Text = sso.Socio_economico_familiar_discapacidad_porcentaje2.ToString();
                            txt_familiardiscapacitadoparentesco2.Text = sso.Socio_economico_familiar_discapacidad_parentesco2.ToString();
                            txt_familiardiscapacitadofechanacimiento2.Text = sso.Socio_economico_familiar_discapacidad_fecha_nacimiento2.ToString();

                            txt_numcarnetMSP.Text = sso.Socio_economico_registrar_dependencia_familiar_MT_numero_carnetMSP.ToString();
                            txt_familiarenfermedadraraparentesco.Text = sso.Socio_economico_familiar_enfermedad_catastrofica_rara_parentesco.ToString();
                            txtfamiliarenfermedadraratipo.Text = sso.Socio_economico_a_cargo_familiar_enfermedad_catastrofica_rara_tipoenfermedad.ToString();

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
                            if (sso.Socio_economico_modalidadcontrato_leyorgserpublico == null)
                            {
                                cb_modalidadlosep.Checked = false;
                            }
                            else
                            {
                                cb_modalidadlosep.Checked = true;
                            }
                            if (sso.Socio_economico_modalidadcontrato_codigotrabajo == null)
                            {
                                cb_modalidadcodigotrabajo.Checked = false;
                            }
                            else
                            {
                                cb_modalidadcodigotrabajo.Checked = true;
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
                            //Titulo
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
                            if (sso.Socio_economico_titulo_doctorado == null)
                            {
                                cb_doctorado.Checked = false;
                            }
                            else
                            {
                                cb_doctorado.Checked = true;
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
                            if (sso.Socio_economico_sectorvive_otro == null)
                            {
                                cb_otro_sector.Checked = false;
                            }
                            else
                            {
                                cb_otro_sector.Checked = true;
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
                            if (sso.Socio_economico_tipovivienda_otro == null)
                            {
                                cb_otrovivienda.Checked = false;
                            }
                            else
                            {
                                cb_otrovivienda.Checked = true;
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
                            if (sso.Socio_economico_recorrido_institucional_no_existe == null)
                            {
                                cb_recorridonoexiste.Checked = false;
                            }
                            else
                            {
                                cb_recorridonoexiste.Checked = true;
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
                            //Embarazada 
                            if (sso.Socio_economico_conyugue_embarazada_si == null)
                            {
                                cb_embarazadasi.Checked = false;
                            }
                            else
                            {
                                cb_embarazadasi.Checked = true;
                            }
                            if (sso.Socio_economico_conyugue_embarazada_no == null)
                            {
                                cb_embarazadano.Checked = false;
                            }
                            else
                            {
                                cb_embarazadano.Checked = true;
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
                            //Consumo sustancia psicotrópica
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
                            //Enfermedad catastrófica en su nucleo
                            if (sso.Socio_economico_familiar_enfermedad_catastrofica_rara_si == null)
                            {
                                cb_familiarenfermedadrarasi.Checked = false;
                            }
                            else
                            {
                                cb_familiarenfermedadrarasi.Checked = true;
                            }
                            if (sso.Socio_economico_familiar_enfermedad_catastrofica_rara_no == null)
                            {
                                cb_familiarenfermedadrarano.Checked = false;
                            }
                            else
                            {
                                cb_familiarenfermedadrarano.Checked = true;
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
                            if (sso.Socio_economico_otro == null)
                            {
                                cb_otraactividad.Checked = false;
                            }
                            else
                            {
                                cb_otraactividad.Checked = true;
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
                            if (sso.Socio_economico_tipo_familia_padremadresoltero == null)
                            {
                                cb_padremadresoltero.Checked = false;
                            }
                            else
                            {
                                cb_padremadresoltero.Checked = true;
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
                            if (sso.Socio_economico_problemas_familiares_antpenales == null)
                            {
                                cb_antpenales.Checked = false;
                            }
                            else
                            {
                                cb_antpenales.Checked = true;
                            }
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
                txt_fecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            }
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
                    //Datos Generales
                    Socio_economico_fecha_ingreso_al_Ecu = Convert.ToDateTime(txt_fechaingresoalsisecu.Text),
                    Socio_economico_tipodesangre = txt_tipodesangre.Text,

                    Socio_economico_telefonoconvencional = txt_telconvecional.Text,
                    Socio_economico_telefonocelular = txt_telcelular.Text,
                    Socio_economico_email = txt_email.Text,

                    Socio_economico_lugardenacimiento = txt_lugarnacimiento.Text,
                    Socio_economico_fechadeNacimiento = Convert.ToDateTime(txt_fechanacimiento.Text),
                    Socio_economico_edad = Convert.ToInt32(txt_edad.Text),

                    Socio_economico_direcciondomicilio_provincia = txt_provincia.Text,
                    Socio_economico_direcciondomicilio_canton = txt_canton.Text,
                    Socio_economico_direcciondomicilio_parroquia = txt_canton.Text,
                    Socio_economico_direcciondomicilio_barrio = txt_barrio.Text,

                    Socio_economico_calle_vivienda_numeracion = txt_calleubicada.Text,
                    Socio_economico_calle_secundaria = txt_callesecundaria.Text,
                    Socio_economico_referencia_ubicar_domicilio = txt_refubicardomicilio.Text,

                    Socio_economico_sectorvive_otro_indique = txt_otrosector.Text,
                    Socio_economico_tipovivienda_otro_indique = txt_tipoviviendaotro.Text,

                    Socio_economico_cuantas_personas_viven_con_usted = txt_personanvivenusted.Text,
                    Socio_economico_cuantas_personas_viven_eventual_con_usted = txt_personanviveneventualusted.Text,
                    Socio_economico_contacto_emergencia_nombres_apellidos = txt_emernomyape.Text,
                    Socio_economico_contacto_emergencia_parentesco = txt_emeparentesco.Text,
                    Socio_economico_contacto_emergencia_telefono = txt_emetelefono.Text,
                    Socio_economico_contacto_emergencia_calle_principal = txt_emecalleprincipal.Text,
                    Socio_economico_contacto_emergencia_numero_domicilio = txt_emenumdomicilio.Text,
                    Socio_economico_contacto_emergencia_calle_secundaria = txt_emecallesecun.Text,
                    Socio_economico_contacto_emergencia_referencia_domicilio = txt_emerefubicardomicilio.Text,

                    Socio_economico_distancia_domicilio_trabajo = txt_distanciadomiciotrabajo.Text,

                    //Salud
                    Socio_economico_posee_enfermedad = txt_poseeenfermedadingresarEcu.Text,
                    Socio_economico_discapacidad_tipo = txt_tipodiscapacidad.Text,
                    Socio_economico_discapacidad_porcentaje = Convert.ToInt32(txt_porcentajediscapacidad.Text),
                    Socio_economico_discapacidad_carnet_conadis = txt_numcarnetconadis.Text,
                    Socio_economico_discapacidad_fecha_caducidad_carnet = Convert.ToDateTime(txt_fechacaducidadcarnet.Text),

                    Socio_economico_mes_gestacion = txt_mesgestacion.Text,
                    Socio_economico_fecha_tentativa_parto = Convert.ToDateTime(txt_fechatentativaparto.Text),
                    Socio_economico_periodo_lactancia_fecha_culminacion = Convert.ToDateTime(txt_fechaculmicacionlactancia.Text),

                    Socio_economico_enfermedad_cronica_cual = txt_cualcatastrofica.Text,
                    Socio_economico_enfermedad_cronica_otras = txt_otrasenfermedades.Text,
                    Socio_economico_enfermedad_rara_cual = txt_enfermedadraracual.Text,

                    Socio_economico_consume_alcohol_frecuencia_consumo = txt_frecuenciaconsumoalcohol.Text,
                    Socio_economico_consume_alcohol_tiempo_consumo = txt_tiempoconsumoalcohol.Text,
                    Socio_economico_consume_tabaco_frecuencia_consumo = txt_frecuenciaconsumotabaco.Text,
                    Socio_economico_consume_tabaco_tiempo_consumo = txt_tiempoconsumotabaco.Text,
                    Socio_economico_consume_sustancia_psicotropica_tipo = txt_sustanciapsicotropicatipo.Text,
                    Socio_economico_consume_sustancia_psicotropica_frecuencia_consumo = txt_sustanciapsicotropicafrecuencia.Text,

                    //Situacion económica del servidor
                    Socio_economico_total_ingresos_mensuales_proyectados_1 = Convert.ToInt32(txt_totalingreso1.Text),
                    Socio_economico_ayuda_padres1 = Convert.ToInt32(txt_ayudafamiliares1.Text),
                    Socio_economico_otros_ingresos1 = Convert.ToInt32(txt_otrosingresos1.Text),
                    Socio_economico_total_egresos_mensuales_proyectados_alimentacion = Convert.ToInt32(txt_alimentacion.Text),

                    Socio_economico_total_ingresos_mensuales_proyectados_2 = Convert.ToInt32(txt_totalingreso2.Text),
                    Socio_economico_ayuda_padres2 = Convert.ToInt32(txt_ayudafamiliares2.Text),
                    Socio_economico_otros_ingresos2 = Convert.ToInt32(txt_otrosingresos2.Text),
                    Socio_economico_total_egresos_mensuales_proyectados_vivienda = Convert.ToInt32(txt_vivienda.Text),

                    Socio_economico_total_ingresos_mensuales_proyectados_3 = Convert.ToInt32(txt_totalingreso3.Text),
                    Socio_economico_ayuda_padres3 = Convert.ToInt32(txt_ayudafamiliares3.Text),
                    Socio_economico_otros_ingresos3 = Convert.ToInt32(txt_otrosingresos3.Text),
                    Socio_economico_total_egresos_mensuales_proyectados_educacion = Convert.ToInt32(txt_educacion.Text),

                    Socio_economico_total_ingresos_mensuales_proyectados_4 = Convert.ToInt32(txt_totalingreso4.Text),
                    Socio_economico_ayuda_padres4 = Convert.ToInt32(txt_ayudafamiliares4.Text),
                    Socio_economico_otros_ingresos4 = Convert.ToInt32(txt_otrosingresos4.Text),
                    Socio_economico_total_egresos_mensuales_proyectados_servicios_basicos = Convert.ToInt32(txt_serviciosbasicos.Text),

                    Socio_economico_total_ingresos_mensuales_proyectados_5 = Convert.ToInt32(txt_totalingreso5.Text),
                    Socio_economico_ayuda_padres5 = Convert.ToInt32(txt_ayudafamiliares5.Text),
                    Socio_economico_otros_ingresos5 = Convert.ToInt32(txt_otrosingresos5.Text),
                    Socio_economico_total_egresos_mensuales_proyectados_salud = Convert.ToInt32(txt_Salud.Text),

                    Socio_economico_total_ingresos_mensuales_proyectados_6 = Convert.ToInt32(txt_totalingreso6.Text),
                    Socio_economico_ayuda_padres6 = Convert.ToInt32(txt_ayudafamiliares6.Text),
                    Socio_economico_otros_ingresos6 = Convert.ToInt32(txt_otrosingresos6.Text),
                    Socio_economico_total_egresos_mensuales_proyectados_movilizacion = Convert.ToInt32(txt_movilizacion.Text),

                    Socio_economico_total_ingresos_mensuales_proyectados_7 = Convert.ToInt32(txt_totalingreso7.Text),
                    Socio_economico_ayuda_padres7 = Convert.ToInt32(txt_ayudafamiliares7.Text),
                    Socio_economico_otros_ingresos7 = Convert.ToInt32(txt_otrosingresos7.Text),
                    Socio_economico_total_egresos_mensuales_proyectados_deudas = Convert.ToInt32(txt_deudas.Text),

                    Socio_economico_total_ingresos_mensuales_proyectados_8 = Convert.ToInt32(txt_totalingreso8.Text),
                    Socio_economico_ayuda_padres8 = Convert.ToInt32(txt_ayudafamiliares8.Text),
                    Socio_economico_otros_ingresos8 = Convert.ToInt32(txt_otrosingresos8.Text),
                    Socio_economico_total_egresos_mensuales_proyectados_otros = Convert.ToInt32(txt_otropensionesvarios.Text),

                    Socio_economico_total_ingresos_mensuales_proyectados_total_9 = Convert.ToInt32(txt_totalingreso9.Text),
                    Socio_economico_ayuda_padres_total9 = Convert.ToInt32(txt_ayudafamiliares9.Text),
                    Socio_economico_otros_ingresos_total9 = Convert.ToInt32(txt_otrosingresos9.Text),
                    Socio_economico_total_egresos_mensuales_proyectados_total = Convert.ToInt32(txt_totalegresosmensualesproyectados.Text),

                    Socio_economico_total_egresos_mensuales_proyectados_total_general = Convert.ToInt32(txt_totalfinal.Text),

                    Socio_economico_descripcion_mueble_valor_casa = Convert.ToInt32(txt_valorcasa.Text),
                    Socio_economico_descripcion_mueble_detalle_direccion_casa = txt_direccioncasa.Text,
                    Socio_economico_descripcion_mueble_valor_departamento = Convert.ToInt32(txt_valordepartamento.Text),
                    Socio_economico_descripcion_mueble_detalle_direccion_departamento = txt_direcciondepartamento.Text,
                    Socio_economico_descripcion_mueble_valor_vehiculo = Convert.ToInt32(txt_valorvehiculo.Text),
                    Socio_economico_descripcion_mueble_detalle_detalle_vehiculo = txt_detallevehiculo.Text,
                    Socio_economico_descripcion_mueble_valor_terreno = Convert.ToInt32(txt_valorterreno.Text),
                    Socio_economico_descripcion_mueble_detalle_sector_terreno = txt_sectorterreno.Text,
                    Socio_economico_descripcion_mueble_valor_negocio = Convert.ToInt32(txt_valornegocio.Text),
                    Socio_economico_descripcion_mueble_detalle_detalle_negocio = txt_detallenegocio.Text,
                    Socio_economico_descripcion_mueble_valor_muebles_enseres = Convert.ToInt32(txt_valormueblesenseres.Text),
                    Socio_economico_descripcion_mueble_detalle_detalle_muebles_enseres = txt_detallemueblesenseres.Text,

                    Socio_economico_caracteristica_vivienda_descripcion_otra_especifique = txt_otrodescrpcionfamilia.Text,
                    Socio_economico_caracteristica_vivienda_tenencia_otra_especifique = txt_otratenencia.Text,
                    Socio_economico_caracteristica_vivienda_tipo_otro_especifique = txt_otrotipodecasa.Text,
                    Socio_economico_caracteristica_vivienda_distribucion_otro_especifique = txt_otradistribucioncasa.Text,
                    Socio_economico_caracteristica_vivienda_otro_especifique = txt_otrainformacioncasa.Text,
                    Socio_economico_como_moviliza_vivienda_a_trabajo = txt_movilizadecasaatrabajo.Text,

                    //Información Familiar
                    Socio_economico_nombres_apellidos_familiar1 = txt_nomapellidos1.Text,
                    Socio_economico_parentesco_familiar1 = txt_parentesco1.Text,
                    Socio_economico_fecha_nacimiento_familiar1 = Convert.ToDateTime(txt_fechanacimiento1.Text),
                    Socio_economico_edad_familiar1 = Convert.ToInt32(txt_edad1.Text),

                    Socio_economico_nombres_apellidos_familiar2 = txt_nomapellidos2.Text,
                    Socio_economico_parentesco_familiar2 = txt_parentesco2.Text,
                    Socio_economico_fecha_nacimiento_familiar2 = Convert.ToDateTime(txt_fechanacimiento2.Text),
                    Socio_economico_edad_familiar2 = Convert.ToInt32(txt_edad2.Text),

                    Socio_economico_nombres_apellidos_familiar3 = txt_nomapellidos3.Text,
                    Socio_economico_parentesco_familiar3 = txt_parentesco3.Text,
                    Socio_economico_fecha_nacimiento_familiar3 = Convert.ToDateTime(txt_fechanacimiento3.Text),
                    Socio_economico_edad_familiar3 = Convert.ToInt32(txt_edad3.Text),

                    Socio_economico_nombres_apellidos_familiar4 = txt_nomapellidos4.Text,
                    Socio_economico_parentesco_familiar4 = txt_parentesco4.Text,
                    Socio_economico_fecha_nacimiento_familiar4 = Convert.ToDateTime(txt_fechanacimiento4.Text),
                    Socio_economico_edad_familiar4 = Convert.ToInt32(txt_edad4.Text),

                    Socio_economico_nombres_apellidos_familiar5 = txt_nomapellidos5.Text,
                    Socio_economico_parentesco_familiar5 = txt_parentesco5.Text,
                    Socio_economico_fecha_nacimiento_familiar5 = Convert.ToDateTime(txt_fechanacimiento5.Text),
                    Socio_economico_edad_familiar5 = Convert.ToInt32(txt_edad5.Text),

                    Socio_economico_nombres_apellidos_familiar_discapacidad1 = txt_familiardiscapacitadonomape1.Text,
                    Socio_economico_fecha_caducidad_carnet_familiar_discapacidad1 = Convert.ToDateTime(txt_familiardiscapacitadofechacaducidadcarnet1.Text),
                    Socio_economico_familiar_discapacidad_tipo1 = txt_familiardiscapacitadotipodiscapacidad1.Text,
                    Socio_economico_familiar_discapacidad_porcentaje1 = Convert.ToInt32(txt_familiardiscapacitadoporcentajediscapacidad1.Text),
                    Socio_economico_familiar_discapacidad_parentesco1 = txt_familiardiscapacitadoparentesco1.Text,
                    Socio_economico_familiar_discapacidad_fecha_nacimiento1 = Convert.ToDateTime(txt_familiardiscapacitadofechanacimiento1.Text),

                    Socio_economico_nombres_apellidos_familiar_discapacidad2 = txt_familiardiscapacitadonomape2.Text,
                    Socio_economico_fecha_caducidad_carnet_familiar_discapacidad2 = Convert.ToDateTime(txt_familiardiscapacitadofechacaducidadcarnet2.Text),
                    Socio_economico_familiar_discapacidad_tipo2 = txt_familiardiscapacitadotipodiscapacidad2.Text,
                    Socio_economico_familiar_discapacidad_porcentaje2 = Convert.ToInt32(txt_familiardiscapacitadoporcentajediscapacidad2.Text),
                    Socio_economico_familiar_discapacidad_parentesco2 = txt_familiardiscapacitadoparentesco2.Text,
                    Socio_economico_familiar_discapacidad_fecha_nacimiento2 = Convert.ToDateTime(txt_familiardiscapacitadofechanacimiento2.Text),

                    Socio_economico_registrar_dependencia_familiar_MT_numero_carnetMSP = txt_numcarnetMSP.Text,
                    Socio_economico_familiar_enfermedad_catastrofica_rara_parentesco = txt_familiarenfermedadraraparentesco.Text,
                    Socio_economico_a_cargo_familiar_enfermedad_catastrofica_rara_tipoenfermedad = txtfamiliarenfermedadraratipo.Text,

                    //Actividad tiempo libre
                    Socio_economico_otro_especifique = txt_otraactividad.Text,
                    Socio_economico_actividad_economica_adicional_detalle = txt_actividadeconomicadetalle.Text,
                    Socio_economico_actividad_economica_adicional_tiempo_destina = txt_actividadeconomicatiempodestina.Text,
                    Socio_economico_actividad_economica_adicional_hace_tiempo = txt_actividadeconomicatiemporealiza.Text,
                    Socio_economico_actividad_deportiva_especificar = txt_especifiquedeporte.Text,
                    Socio_economico_actividad_deportiva_frecuencia = txt_frecuenciadeporte.Text,
                    Socio_economico_actividad_deportiva_edad = Convert.ToInt32(txt_edadpracticadeporte.Text),
                    Socio_economico_lesion_tipo = txt_tipolesion.Text,
                    Socio_economico_lesion_edad = Convert.ToInt32(txt_edadlesion.Text),

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
                if (cb_modalidadlosep.Checked == true)
                {
                    sso.Socio_economico_modalidadcontrato_leyorgserpublico = "SI";
                }
                if (cb_modalidadcodigotrabajo.Checked == true)
                {
                    sso.Socio_economico_modalidadcontrato_codigotrabajo = "SI";
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
                //Titulo
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
                if (cb_doctorado.Checked == true)
                {
                    sso.Socio_economico_titulo_doctorado = "SI";
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
                if (cb_otro_sector.Checked == true)
                {
                    sso.Socio_economico_sectorvive_otro = "SI";
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
                if (cb_otrovivienda.Checked == true)
                {
                    sso.Socio_economico_tipovivienda_otro = "SI";
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
                if (cb_recorridonoexiste.Checked == true)
                {
                    sso.Socio_economico_recorrido_institucional_no_existe = "SI";
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
                //Embarazada 
                if (cb_embarazadasi.Checked == true)
                {
                    sso.Socio_economico_conyugue_embarazada_si = "SI";
                }
                if (cb_embarazadano.Checked == true)
                {
                    sso.Socio_economico_conyugue_embarazada_no = "SI";
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

                //INFORMACION FAMILIAR
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
                //Enfermedad catastrófica en su nucleo
                if (cb_familiarenfermedadrarasi.Checked == true)
                {
                    sso.Socio_economico_familiar_enfermedad_catastrofica_rara_si = "SI";
                }
                if (cb_familiarenfermedadrarano.Checked == true)
                {
                    sso.Socio_economico_familiar_enfermedad_catastrofica_rara_no = "SI";
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
                if (cb_otraactividad.Checked == true)
                {
                    sso.Socio_economico_otro = "SI";
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
                if (cb_padremadresoltero.Checked == true)
                {
                    sso.Socio_economico_tipo_familia_padremadresoltero = "SI";
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
                if (cb_antpenales.Checked == true)
                {
                    sso.Socio_economico_problemas_familiares_antpenales = "SI";
                }
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
                sso.Socio_economico_fechaHora = Convert.ToDateTime(txt_fecha.Text);

                //Datos Generales
                sso.Socio_economico_fecha_ingreso_al_Ecu = Convert.ToDateTime(txt_fechaingresoalsisecu.Text);
                sso.Socio_economico_tipodesangre = txt_tipodesangre.Text;

                sso.Socio_economico_telefonoconvencional = txt_telconvecional.Text;
                sso.Socio_economico_telefonocelular = txt_telcelular.Text;
                sso.Socio_economico_email = txt_email.Text;

                sso.Socio_economico_lugardenacimiento = txt_lugarnacimiento.Text;
                sso.Socio_economico_fechadeNacimiento = Convert.ToDateTime(txt_fechanacimiento.Text);
                sso.Socio_economico_edad = Convert.ToInt32(txt_edad.Text);

                sso.Socio_economico_direcciondomicilio_provincia = txt_provincia.Text;
                sso.Socio_economico_direcciondomicilio_canton = txt_canton.Text;
                sso.Socio_economico_direcciondomicilio_parroquia = txt_canton.Text;
                sso.Socio_economico_direcciondomicilio_barrio = txt_barrio.Text;

                sso.Socio_economico_calle_vivienda_numeracion = txt_calleubicada.Text;
                sso.Socio_economico_calle_secundaria = txt_callesecundaria.Text;
                sso.Socio_economico_referencia_ubicar_domicilio = txt_refubicardomicilio.Text;

                sso.Socio_economico_sectorvive_otro_indique = txt_otrosector.Text;
                sso.Socio_economico_tipovivienda_otro_indique = txt_tipoviviendaotro.Text;

                sso.Socio_economico_cuantas_personas_viven_con_usted = txt_personanvivenusted.Text;
                sso.Socio_economico_cuantas_personas_viven_eventual_con_usted = txt_personanviveneventualusted.Text;
                sso.Socio_economico_contacto_emergencia_nombres_apellidos = txt_emernomyape.Text;
                sso.Socio_economico_contacto_emergencia_parentesco = txt_emeparentesco.Text;
                sso.Socio_economico_contacto_emergencia_telefono = txt_emetelefono.Text;
                sso.Socio_economico_contacto_emergencia_calle_principal = txt_emecalleprincipal.Text;
                sso.Socio_economico_contacto_emergencia_numero_domicilio = txt_emenumdomicilio.Text;
                sso.Socio_economico_contacto_emergencia_calle_secundaria = txt_emecallesecun.Text;
                sso.Socio_economico_contacto_emergencia_referencia_domicilio = txt_emerefubicardomicilio.Text;

                sso.Socio_economico_distancia_domicilio_trabajo = txt_distanciadomiciotrabajo.Text;

                //Salud
                sso.Socio_economico_posee_enfermedad = txt_poseeenfermedadingresarEcu.Text;
                sso.Socio_economico_discapacidad_tipo = txt_tipodiscapacidad.Text;
                sso.Socio_economico_discapacidad_porcentaje = Convert.ToInt32(txt_porcentajediscapacidad.Text);
                sso.Socio_economico_discapacidad_carnet_conadis = txt_numcarnetconadis.Text;
                sso.Socio_economico_discapacidad_fecha_caducidad_carnet = Convert.ToDateTime(txt_fechacaducidadcarnet.Text);

                sso.Socio_economico_mes_gestacion = txt_mesgestacion.Text;
                sso.Socio_economico_fecha_tentativa_parto = Convert.ToDateTime(txt_fechatentativaparto.Text);
                sso.Socio_economico_periodo_lactancia_fecha_culminacion = Convert.ToDateTime(txt_fechaculmicacionlactancia.Text);

                sso.Socio_economico_enfermedad_cronica_cual = txt_cualcatastrofica.Text;
                sso.Socio_economico_enfermedad_cronica_otras = txt_otrasenfermedades.Text;
                sso.Socio_economico_enfermedad_rara_cual = txt_enfermedadraracual.Text;

                sso.Socio_economico_consume_alcohol_frecuencia_consumo = txt_frecuenciaconsumoalcohol.Text;
                sso.Socio_economico_consume_alcohol_tiempo_consumo = txt_tiempoconsumoalcohol.Text;
                sso.Socio_economico_consume_tabaco_frecuencia_consumo = txt_frecuenciaconsumotabaco.Text;
                sso.Socio_economico_consume_tabaco_tiempo_consumo = txt_tiempoconsumotabaco.Text;
                sso.Socio_economico_consume_sustancia_psicotropica_tipo = txt_sustanciapsicotropicatipo.Text;
                sso.Socio_economico_consume_sustancia_psicotropica_frecuencia_consumo = txt_sustanciapsicotropicafrecuencia.Text;

                //Situacion económica del servidor
                sso.Socio_economico_total_ingresos_mensuales_proyectados_1 = Convert.ToInt32(txt_totalingreso1.Text);
                sso.Socio_economico_ayuda_padres1 = Convert.ToInt32(txt_ayudafamiliares1.Text);
                sso.Socio_economico_otros_ingresos1 = Convert.ToInt32(txt_otrosingresos1.Text);
                sso.Socio_economico_total_egresos_mensuales_proyectados_alimentacion = Convert.ToInt32(txt_alimentacion.Text);

                sso.Socio_economico_total_ingresos_mensuales_proyectados_2 = Convert.ToInt32(txt_totalingreso2.Text);
                sso.Socio_economico_ayuda_padres2 = Convert.ToInt32(txt_ayudafamiliares2.Text);
                sso.Socio_economico_otros_ingresos2 = Convert.ToInt32(txt_otrosingresos2.Text);
                sso.Socio_economico_total_egresos_mensuales_proyectados_vivienda = Convert.ToInt32(txt_vivienda.Text);

                sso.Socio_economico_total_ingresos_mensuales_proyectados_3 = Convert.ToInt32(txt_totalingreso3.Text);
                sso.Socio_economico_ayuda_padres3 = Convert.ToInt32(txt_ayudafamiliares3.Text);
                sso.Socio_economico_otros_ingresos3 = Convert.ToInt32(txt_otrosingresos3.Text);
                sso.Socio_economico_total_egresos_mensuales_proyectados_educacion = Convert.ToInt32(txt_educacion.Text);

                sso.Socio_economico_total_ingresos_mensuales_proyectados_4 = Convert.ToInt32(txt_totalingreso4.Text);
                sso.Socio_economico_ayuda_padres4 = Convert.ToInt32(txt_ayudafamiliares4.Text);
                sso.Socio_economico_otros_ingresos4 = Convert.ToInt32(txt_otrosingresos4.Text);
                sso.Socio_economico_total_egresos_mensuales_proyectados_servicios_basicos = Convert.ToInt32(txt_serviciosbasicos.Text);

                sso.Socio_economico_total_ingresos_mensuales_proyectados_5 = Convert.ToInt32(txt_totalingreso5.Text);
                sso.Socio_economico_ayuda_padres5 = Convert.ToInt32(txt_ayudafamiliares5.Text);
                sso.Socio_economico_otros_ingresos5 = Convert.ToInt32(txt_otrosingresos5.Text);
                sso.Socio_economico_total_egresos_mensuales_proyectados_salud = Convert.ToInt32(txt_Salud.Text);

                sso.Socio_economico_total_ingresos_mensuales_proyectados_6 = Convert.ToInt32(txt_totalingreso6.Text);
                sso.Socio_economico_ayuda_padres6 = Convert.ToInt32(txt_ayudafamiliares6.Text);
                sso.Socio_economico_otros_ingresos6 = Convert.ToInt32(txt_otrosingresos6.Text);
                sso.Socio_economico_total_egresos_mensuales_proyectados_movilizacion = Convert.ToInt32(txt_movilizacion.Text);

                sso.Socio_economico_total_ingresos_mensuales_proyectados_7 = Convert.ToInt32(txt_totalingreso7.Text);
                sso.Socio_economico_ayuda_padres7 = Convert.ToInt32(txt_ayudafamiliares7.Text);
                sso.Socio_economico_otros_ingresos7 = Convert.ToInt32(txt_otrosingresos7.Text);
                sso.Socio_economico_total_egresos_mensuales_proyectados_deudas = Convert.ToInt32(txt_deudas.Text);

                sso.Socio_economico_total_ingresos_mensuales_proyectados_8 = Convert.ToInt32(txt_totalingreso8.Text);
                sso.Socio_economico_ayuda_padres8 = Convert.ToInt32(txt_ayudafamiliares8.Text);
                sso.Socio_economico_otros_ingresos8 = Convert.ToInt32(txt_otrosingresos8.Text);
                sso.Socio_economico_total_egresos_mensuales_proyectados_otros = Convert.ToInt32(txt_otropensionesvarios.Text);

                sso.Socio_economico_total_ingresos_mensuales_proyectados_total_9 = Convert.ToInt32(txt_totalingreso9.Text);
                sso.Socio_economico_ayuda_padres_total9 = Convert.ToInt32(txt_ayudafamiliares9.Text);
                sso.Socio_economico_otros_ingresos_total9 = Convert.ToInt32(txt_otrosingresos9.Text);
                sso.Socio_economico_total_egresos_mensuales_proyectados_total = Convert.ToInt32(txt_totalegresosmensualesproyectados.Text);

                sso.Socio_economico_total_egresos_mensuales_proyectados_total_general = Convert.ToInt32(txt_totalfinal.Text);

                sso.Socio_economico_descripcion_mueble_valor_casa = Convert.ToInt32(txt_valorcasa.Text);
                sso.Socio_economico_descripcion_mueble_detalle_direccion_casa = txt_direccioncasa.Text;
                sso.Socio_economico_descripcion_mueble_valor_departamento = Convert.ToInt32(txt_valordepartamento.Text);
                sso.Socio_economico_descripcion_mueble_detalle_direccion_departamento = txt_direcciondepartamento.Text;
                sso.Socio_economico_descripcion_mueble_valor_vehiculo = Convert.ToInt32(txt_valorvehiculo.Text);
                sso.Socio_economico_descripcion_mueble_detalle_detalle_vehiculo = txt_detallevehiculo.Text;
                sso.Socio_economico_descripcion_mueble_valor_terreno = Convert.ToInt32(txt_valorterreno.Text);
                sso.Socio_economico_descripcion_mueble_detalle_sector_terreno = txt_sectorterreno.Text;
                sso.Socio_economico_descripcion_mueble_valor_negocio = Convert.ToInt32(txt_valornegocio.Text);
                sso.Socio_economico_descripcion_mueble_detalle_detalle_negocio = txt_detallenegocio.Text;
                sso.Socio_economico_descripcion_mueble_valor_muebles_enseres = Convert.ToInt32(txt_valormueblesenseres.Text);
                sso.Socio_economico_descripcion_mueble_detalle_detalle_muebles_enseres = txt_detallemueblesenseres.Text;

                sso.Socio_economico_caracteristica_vivienda_descripcion_otra_especifique = txt_otrodescrpcionfamilia.Text;
                sso.Socio_economico_caracteristica_vivienda_tenencia_otra_especifique = txt_otratenencia.Text;
                sso.Socio_economico_caracteristica_vivienda_tipo_otro_especifique = txt_otrotipodecasa.Text;
                sso.Socio_economico_caracteristica_vivienda_distribucion_otro_especifique = txt_otradistribucioncasa.Text;
                sso.Socio_economico_caracteristica_vivienda_otro_especifique = txt_otrainformacioncasa.Text;
                sso.Socio_economico_como_moviliza_vivienda_a_trabajo = txt_movilizadecasaatrabajo.Text;

                //Información Familiar
                sso.Socio_economico_nombres_apellidos_familiar1 = txt_nomapellidos1.Text;
                sso.Socio_economico_parentesco_familiar1 = txt_parentesco1.Text;
                sso.Socio_economico_fecha_nacimiento_familiar1 = Convert.ToDateTime(txt_fechanacimiento1.Text);
                sso.Socio_economico_edad_familiar1 = Convert.ToInt32(txt_edad1.Text);

                sso.Socio_economico_nombres_apellidos_familiar2 = txt_nomapellidos2.Text;
                sso.Socio_economico_parentesco_familiar2 = txt_parentesco2.Text;
                sso.Socio_economico_fecha_nacimiento_familiar2 = Convert.ToDateTime(txt_fechanacimiento2.Text);
                sso.Socio_economico_edad_familiar2 = Convert.ToInt32(txt_edad2.Text);

                sso.Socio_economico_nombres_apellidos_familiar3 = txt_nomapellidos3.Text;
                sso.Socio_economico_parentesco_familiar3 = txt_parentesco3.Text;
                sso.Socio_economico_fecha_nacimiento_familiar3 = Convert.ToDateTime(txt_fechanacimiento3.Text);
                sso.Socio_economico_edad_familiar3 = Convert.ToInt32(txt_edad3.Text);

                sso.Socio_economico_nombres_apellidos_familiar4 = txt_nomapellidos4.Text;
                sso.Socio_economico_parentesco_familiar4 = txt_parentesco4.Text;
                sso.Socio_economico_fecha_nacimiento_familiar4 = Convert.ToDateTime(txt_fechanacimiento4.Text);
                sso.Socio_economico_edad_familiar4 = Convert.ToInt32(txt_edad4.Text);

                sso.Socio_economico_nombres_apellidos_familiar5 = txt_nomapellidos5.Text;
                sso.Socio_economico_parentesco_familiar5 = txt_parentesco5.Text;
                sso.Socio_economico_fecha_nacimiento_familiar5 = Convert.ToDateTime(txt_fechanacimiento5.Text);
                sso.Socio_economico_edad_familiar5 = Convert.ToInt32(txt_edad5.Text);

                sso.Socio_economico_nombres_apellidos_familiar_discapacidad1 = txt_familiardiscapacitadonomape1.Text;
                sso.Socio_economico_fecha_caducidad_carnet_familiar_discapacidad1 = Convert.ToDateTime(txt_familiardiscapacitadofechacaducidadcarnet1.Text);
                sso.Socio_economico_familiar_discapacidad_tipo1 = txt_familiardiscapacitadotipodiscapacidad1.Text;
                sso.Socio_economico_familiar_discapacidad_porcentaje1 = Convert.ToInt32(txt_familiardiscapacitadoporcentajediscapacidad1.Text);
                sso.Socio_economico_familiar_discapacidad_parentesco1 = txt_familiardiscapacitadoparentesco1.Text;
                sso.Socio_economico_familiar_discapacidad_fecha_nacimiento1 = Convert.ToDateTime(txt_familiardiscapacitadofechanacimiento1.Text);

                sso.Socio_economico_nombres_apellidos_familiar_discapacidad2 = txt_familiardiscapacitadonomape2.Text;
                sso.Socio_economico_fecha_caducidad_carnet_familiar_discapacidad2 = Convert.ToDateTime(txt_familiardiscapacitadofechacaducidadcarnet2.Text);
                sso.Socio_economico_familiar_discapacidad_tipo2 = txt_familiardiscapacitadotipodiscapacidad2.Text;
                sso.Socio_economico_familiar_discapacidad_porcentaje2 = Convert.ToInt32(txt_familiardiscapacitadoporcentajediscapacidad2.Text);
                sso.Socio_economico_familiar_discapacidad_parentesco2 = txt_familiardiscapacitadoparentesco2.Text;
                sso.Socio_economico_familiar_discapacidad_fecha_nacimiento2 = Convert.ToDateTime(txt_familiardiscapacitadofechanacimiento2.Text);

                sso.Socio_economico_registrar_dependencia_familiar_MT_numero_carnetMSP = txt_numcarnetMSP.Text;
                sso.Socio_economico_familiar_enfermedad_catastrofica_rara_parentesco = txt_familiarenfermedadraraparentesco.Text;
                sso.Socio_economico_a_cargo_familiar_enfermedad_catastrofica_rara_tipoenfermedad = txtfamiliarenfermedadraratipo.Text;

                //Actividad tiempo libre
                sso.Socio_economico_otro_especifique = txt_otraactividad.Text;
                sso.Socio_economico_actividad_economica_adicional_detalle = txt_actividadeconomicadetalle.Text;
                sso.Socio_economico_actividad_economica_adicional_tiempo_destina = txt_actividadeconomicatiempodestina.Text;
                sso.Socio_economico_actividad_economica_adicional_hace_tiempo = txt_actividadeconomicatiemporealiza.Text;
                sso.Socio_economico_actividad_deportiva_especificar = txt_especifiquedeporte.Text;
                sso.Socio_economico_actividad_deportiva_frecuencia = txt_frecuenciadeporte.Text;
                sso.Socio_economico_actividad_deportiva_edad = Convert.ToInt32(txt_edadpracticadeporte.Text);
                sso.Socio_economico_lesion_tipo = txt_tipolesion.Text;
                sso.Socio_economico_lesion_edad = Convert.ToInt32(txt_edadlesion.Text);

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
                if (cb_modalidadlosep.Checked == true)
                {
                    sso.Socio_economico_modalidadcontrato_leyorgserpublico = "SI";
                }
                else
                {
                    sso.Socio_economico_modalidadcontrato_leyorgserpublico = null;
                }
                if (cb_modalidadcodigotrabajo.Checked == true)
                {
                    sso.Socio_economico_modalidadcontrato_codigotrabajo = "SI";
                }
                else
                {
                    sso.Socio_economico_modalidadcontrato_codigotrabajo = null;
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
                //Titulo
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
                if (cb_doctorado.Checked == true)
                {
                    sso.Socio_economico_titulo_doctorado = "SI";
                }
                else
                {
                    sso.Socio_economico_titulo_doctorado = null;
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
                if (cb_otro_sector.Checked == true)
                {
                    sso.Socio_economico_sectorvive_otro = "SI";
                }
                else
                {
                    sso.Socio_economico_sectorvive_otro = null;
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
                if (cb_otrovivienda.Checked == true)
                {
                    sso.Socio_economico_tipovivienda_otro = "SI";
                }
                else
                {
                    sso.Socio_economico_tipovivienda_otro = null;
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
                if (cb_recorridonoexiste.Checked == true)
                {
                    sso.Socio_economico_recorrido_institucional_no_existe = "SI";
                }
                else
                {
                    sso.Socio_economico_recorrido_institucional_no_existe = null;
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
                //Embarazada 
                if (cb_embarazadasi.Checked == true)
                {
                    sso.Socio_economico_conyugue_embarazada_si = "SI";
                }
                else
                {
                    sso.Socio_economico_conyugue_embarazada_si = null;
                }
                if (cb_embarazadano.Checked == true)
                {
                    sso.Socio_economico_conyugue_embarazada_no = "SI";
                }
                else
                {
                    sso.Socio_economico_conyugue_embarazada_no = null;
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
                //Enfermedad catastrófica en su nucleo
                if (cb_familiarenfermedadrarasi.Checked == true)
                {
                    sso.Socio_economico_familiar_enfermedad_catastrofica_rara_si = "SI";
                }
                else
                {
                    sso.Socio_economico_familiar_enfermedad_catastrofica_rara_si = null;
                }
                if (cb_familiarenfermedadrarano.Checked == true)
                {
                    sso.Socio_economico_familiar_enfermedad_catastrofica_rara_no = "SI";
                }
                else
                {
                    sso.Socio_economico_familiar_enfermedad_catastrofica_rara_no = null;
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
                if (cb_otraactividad.Checked == true)
                {
                    sso.Socio_economico_otro = "SI";
                }
                else
                {
                    sso.Socio_economico_otro = null;
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
                if (cb_padremadresoltero.Checked == true)
                {
                    sso.Socio_economico_tipo_familia_padremadresoltero = "SI";
                }
                else
                {
                    sso.Socio_economico_tipo_familia_padremadresoltero = null;
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
                if (cb_antpenales.Checked == true)
                {
                    sso.Socio_economico_problemas_familiares_antpenales = "SI";
                }
                else
                {
                    sso.Socio_economico_problemas_familiares_antpenales = null;
                }
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
            Guardar_modificar_datos(Convert.ToInt32(Request["cod"]));
        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/Views_Socio_Economico/Inicio.aspx");
        }
    }
}