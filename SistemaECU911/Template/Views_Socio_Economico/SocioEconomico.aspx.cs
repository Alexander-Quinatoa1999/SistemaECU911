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

                    per = CN_HistorialMedico.ObtenerPersonasxId(codigo);
                    sso = CN_SocioEconomico.ObtenerSocioEconomicoPer(codigo);
                    btn_guardar.Text = "Actualizar";

                    if (per != null)
                    {
                        txt_cedula.Text = per.Per_Cedula.ToString();
                        txt_priapellido.Text = per.Per_priApellido.ToString();
                        txt_segapellido.Text = per.Per_segApellido.ToString();
                        txt_prinombre.Text = per.Per_priNombre.ToString();
                        txt_segnombre.Text = per.Per_segNombre.ToString();

                        if (sso != null)
                        {
                            //1.
                            txt_areatrabajo.Text = sso.Socio_economico_departamento_area.ToString();
                            txt_cargoinstitucional.Text = sso.Socio_economico_carga_institucional.ToString();
                            //txt_nombramiento.Text = sso.Socio_economico_tipocontrato_nombramiento.ToString();
                            //txt_nombraprovisional.Text = sso.Socio_economico_tipocontrato_nombraprovisional.ToString();
                            //txt_contratoocasional.Text = sso.Socio_economico_tipocontrato_contratocasional.ToString();
                            //txt_codigotrabajoContrato.Text = sso.Socio_economico_tipocontrato_codigotrabajo.ToString();
                            //txt_modalidadlosep.Text = sso.Socio_economico_modalidadcontrato_leyorgserpublico.ToString();
                            //txt_codigotrabajoModalidad.Text = sso.Socio_economico_modalidadcontrato_codigotrabajo.ToString();
                            txt_fechaingreso.Text = sso.Socio_economico_fecha_ingreso_al_Ecu.ToString();
                            //txt_soltero.Text = sso.Socio_economico_estadocivil_soltero.ToString();
                            //txt_casado.Text = sso.Socio_economico_estadocivil_casado.ToString();
                            //txt_viudo.Text = sso.Socio_economico_estadocivil_viudo.ToString();
                            //txt_unionlibre.Text = sso.Socio_economico_estadocivil_unionlibre.ToString();
                            //txt_divorciado.Text = sso.Socio_economico_estadocivil_divorciado.ToString();
                            txt_genero.Text = sso.Socio_economico_genero.ToString();
                            txt_tiposangre.Text = sso.Socio_economico_tipodesangre.ToString();
                            txt_telfconvencional.Text = sso.Socio_economico_telefonoconvencional.ToString();
                            txt_telfcelular.Text = sso.Socio_economico_telefonocelular.ToString();
                            txt_email.Text = sso.Socio_economico_email.ToString();
                            txt_lugarnacimiento.Text = sso.Socio_economico_lugardenacimiento.ToString();
                            txt_fechanacimiento.Text = per.Per_fechNacimiento.ToString();
                            txt_edad.Text = per.Per_fechNacimiento.ToString();
                            //txt_primaria.Text = sso.Socio_economico_niveleducativo_primaria.ToString();
                            //txt_secundaria.Text = sso.Socio_economico_niveleducativo_secundaria.ToString();
                            //txt_superior.Text = sso.Socio_economico_niveleducativo_superior.ToString();
                            //txt_especializacion.Text = sso.Socio_economico_niveleducativo_especializacion.ToString();
                            //txt_diploma.Text = sso.Socio_economico_niveleducativo_diplomado.ToString();
                            //txt_maestria.Text = sso.Socio_economico_niveleducativo_maestrias.ToString();
                            //txt_blanco.Text = sso.Socio_economico_autoidentificacionetnica_blanco.ToString();
                            //txt_mestizo.Text = sso.Socio_economico_autoidentificacionetnica_mestizo.ToString();
                            //txt_afrodescendiente.Text = sso.Socio_economico_autoidentificacionetnica_afrodescendiente.ToString();
                            //txt_indigena.Text = sso.Socio_economico_autoidentificacionetnica_indigena.ToString();
                            //txt_montubio.Text = sso.Socio_economico_autoidentificacionetnica_montubio.ToString();
                            txt_provincia.Text = sso.Socio_economico_direcciondomicilio_provincia.ToString();
                            txt_canton.Text = sso.Socio_economico_direcciondomicilio_canton.ToString();
                            txt_canton.Text = sso.Socio_economico_direcciondomicilio_parroquia.ToString();
                            txt_barrio.Text = sso.Socio_economico_direcciondomicilio_barrio.ToString();
                            txt_callevivienda.Text = sso.Socio_economico_calleubicadaviviendaynumeracion.ToString();
                            txt_callesecundaria.Text = sso.Socio_economico_callesecundaria.ToString();
                            txt_referenciadomicilio.Text = sso.Socio_economico_referencia_ubicar_domicilio.ToString();
                            //txt_norte.Text = sso.Socio_economico_sectorvive_norte.ToString();
                            //txt_centro.Text = sso.Socio_economico_sectorvive_centro.ToString();
                            //txt_sur.Text = sso.Socio_economico_sectorvive_sur.ToString();
                            //txt_otro.Text = sso.Socio_economico_sectorvive_otro.ToString();
                            txt_otrosector.Text = sso.Socio_economico_sectorvive_otroindique.ToString();
                            //txt_casa.Text = sso.Socio_economico_tipovivienda_casa.ToString();
                            //txt_departamento.Text = sso.Socio_economico_tipovivienda_departamento.ToString();
                            //txt_otravivienda.Text = sso.Socio_economico_tipovivienda_otro.ToString();
                            //txt_siserviciobasico.Text = sso.Socio_economico_tipovivienda_cuentaserviciosbasicossi.ToString();
                            //txt_noserviciobasico.Text = sso.Socio_economico_tipovivienda_cuentaserviciosbasicosno.ToString();
                            txt_personasvivenconusted.Text = sso.Socio_economico_cuantaspersonasvivenconusted.ToString();
                            txt_personasviveneventualconusted.Text = sso.Socio_economico_cuantaspersonasviveneventualconusted.ToString();
                            txt_nomapeemergencia.Text = sso.Socio_economico_personacontactoemergencia_nombresyapellidos.ToString();
                            txt_parentesco.Text = sso.Socio_economico_personacontactoemergencia_parentesco.ToString();
                            txt_telfemergencia.Text = sso.Socio_economico_personacontactoemergencia_telefono.ToString();
                            txt_calleprincipalfamiliar.Text = sso.Socio_economico_personacontactoemergencia_direccion_calleprincipal.ToString();
                            txt_numdomiciliofamiliar.Text = sso.Socio_economico_personacontactoemergencia_direccion_numdomicilio.ToString();
                            txt_callesecundariafamiliar.Text = sso.Socio_economico_personacontactoemergencia_direccion_callesecundaria.ToString();
                            txt_referenciadomiciliofamiliar.Text = sso.Socio_economico_personacontactoemergencia_direccion_referenciaubicardomicilio.ToString();
                            //txt_siahorro.Text = sso.Socio_economico_destinadineroahorro_si.ToString();
                            //txt_noahorro.Text = sso.Socio_economico_destinadineroahorro_no.ToString();
                            //txt_sivehiculo.Text = sso.Socio_economico_vehiculopropio_si.ToString();
                            //txt_novehiculo.Text = sso.Socio_economico_vehiculopropio_no.ToString();
                            //txt_sirecorrido.Text = sso.Socio_economico_recorridoinstitucional_si.ToString();
                            //txt_norecorrido.Text = sso.Socio_economico_recorridoinstitucional_no.ToString();
                            //txt_noexisterecorrido.Text = sso.Socio_economico_recorridoinstitucional_noexiste.ToString();
                            txt_distanciadomicilio.Text = sso.Socio_economico_distancia_domicilio_trabajo.ToString();

                            //2.
                            txt_poseeenfermedad.Text = sso.Socio_economico_poseeenfermedad.ToString();
                            //txt_sidiscapacidad.Text = sso.Socio_economico_discapacidad_si.ToString();
                            //txt_nodiscapacidad.Text = sso.Socio_economico_discapacidad_no.ToString();
                            //txt_tipodiscapacidad.Text = sso.Socio_economico_discapacidad_tipo.ToString();
                            txt_porcentajediscapacidad.Text = sso.Socio_economico_discapacidad_porcentaje.ToString();
                            txt_numcarnetconadis.Text = sso.Socio_economico_discapacidad_carnetconadis.ToString();
                            txt_fechacaducidadcarnet.Text = sso.Socio_economico_discapacidad_carnetconadis.ToString();
                            //txt_noconyugeembarazada.Text = sso.Socio_economico_conyugueembarazada_no.ToString();
                            //txt_simeenceuntroembarazada.Text = sso.Socio_economico__si_me_encuentro_embarazada.ToString();
                            //txt_simiconyugeembarazada.Text = sso.Socio_economico__si_mi_conyugue_esta_embarazada.ToString();
                            txt_mesgestacion.Text = sso.Socio_economico__mes_embarazo.ToString();
                            txt_diasgestacion.Text = sso.Socio_economico__dias_embarazo.ToString();
                            txt_fechatentativaparto.Text = sso.Socio_economico_fecha_tentativa_parto.ToString();
                            //txt_siperiodolactancia.Text = sso.Socio_economico_periodo_lactancia_si.ToString();
                            //txt_noperiodolactancia.Text = sso.Socio_economico_periodo_lactancia_no.ToString();
                            txt_fechaculminacionlactancia.Text = sso.Socio_economico_periodo_lactancia_fechaculminacion.ToString();
                            //txt_sienfermedadcronica.Text = sso.Socio_economico_enfermedad_cronica_si.ToString();
                            //txt_noenfermedadcronica.Text = sso.Socio_economico_enfermedad_cronica_no.ToString();
                            txt_cualenfermedadcronica.Text = sso.Socio_economico_enfermedad_cronica_cual.ToString();
                            txt_otrasenfermedades.Text = sso.Socio_economico_enfermedad_cronica_otras.ToString();
                            //txt_sienfermedadrara.Text = sso.Socio_economico_enfermedad_rara_si.ToString();
                            //txt_noenfermedadrara.Text = sso.Socio_economico_enfermedad_rara_no.ToString();
                            //txt_cualenfermedadrara.Text = sso.Socio_economico_enfermedad_rara_cual.ToString();
                            //txt_sialcohol.Text = sso.Socio_economico_consume_alcohol_si.ToString();
                            //txt_noalcohol.Text = sso.Socio_economico_consume_alcohol_no.ToString();
                            //txt_cerveza.Text = sso.Socio_economico_consume_alcohol_tipo_cerveza.ToString();
                            //txt_ron.Text = sso.Socio_economico_consume_alcohol_tipo_ron.ToString();
                            //txt_whisky.Text = sso.Socio_economico_consume_alcohol_tipo_whisky.ToString();
                            txt_otroalcohol.Text = sso.Socio_economico_consume_alcohol_tipo_otro.ToString();
                            txt_frecuenciaalcohol.Text = sso.Socio_economico_consume_alcohol_frecuencia_consumo.ToString();
                            txt_tiempoconsumoalcohol.Text = sso.Socio_economico_consume_alcohol_tiempo_consumo.ToString();
                            //txt_sitabaco.Text = sso.Socio_economico_consume_tabaco_si.ToString();
                            //txt_notabaco.Text = sso.Socio_economico_consume_tabaco_no.ToString();
                            txt_frecuenciatabaco.Text = sso.Socio_economico_consume_tabaco_frecuencia_consumo.ToString();
                            txt_cantidadtabaco.Text = sso.Socio_economico_consume_tabaco_cantidad_consumo.ToString();
                            txt_tiempoconsumotabaco.Text = sso.Socio_economico_consume_tabaco_tiempo_consumo.ToString();
                            //txt_sipsicotropica.Text = sso.Socio_economico_consume_sustancia_psicotropica_si.ToString();
                            //txt_nopsicotropica.Text = sso.Socio_economico_consume_sustancia_psicotropica_no.ToString();
                            txt_tipopsicotropica.Text = sso.Socio_economico_consume_sustancia_psicotropica_tipo.ToString();
                            txt_frecuenciapsicotropica.Text = sso.Socio_economico_consume_sustancia_psicotropica_frecuencia_consumo.ToString();
                            txt_factorespsicotropica.Text = sso.Socio_economico_consume_sustancia_psicotropica_factores_psicosociales.ToString();

                            //3.
                            txt_nomapeconyuge.Text = sso.Socio_economico_nombres_apellidos_conyugue.ToString();
                            txt_numhijos.Text = sso.Socio_economico_numero_hijos.ToString();
                            txt_numdependientes.Text = sso.Socio_economico_numero_dependientes.ToString();
                            txt_nomapefam1.Text = sso.Socio_economico_nombres_apellidos_familiar1.ToString();
                            txt_fechanacfam1.Text = sso.Socio_economico_fecha_nacimiento_familiar1.ToString();
                            txt_edadfam1.Text = sso.Socio_economico_edad_familiar1.ToString();
                            txt_nomapefam2.Text = sso.Socio_economico_nombres_apellidos_familiar2.ToString();
                            txt_fechanacfam2.Text = sso.Socio_economico_fecha_nacimiento_familiar2.ToString();
                            txt_edadfam2.Text = sso.Socio_economico_edad_familiar2.ToString();
                            //txt_siperdis.Text = sso.Socio_economico_nucleofamiliar_persona_discapacidad_si.ToString();
                            //txt_noperdis.Text = sso.Socio_economico_nucleofamiliar_persona_discapacidad_no.ToString();
                            //txt_sicargodis.Text = sso.Socio_economico_acargo_de_persona_discapacidad_si.ToString();
                            //txt_nocargodis.Text = sso.Socio_economico_acargo_de_persona_discapacidad_no.ToString();
                            txt_nomapefamdis.Text = sso.Socio_economico_nombres_apellidos_familiar_discapacidad1.ToString();
                            txt_fechacadis.Text = sso.Socio_economico_fecha_caducidad_carnet_familiar_discapacidad1.ToString();
                            txt_tipodis.Text = sso.Socio_economico_familiar_discapacidad_tipo1.ToString();
                            txt_porcdis.Text = sso.Socio_economico_familiar_discapacidad_porcentaje1.ToString();
                            txt_parendis.Text = sso.Socio_economico_familiar_discapacidad_parentesco1.ToString();
                            txt_fechanacdis.Text = sso.Socio_economico_familiar_discapacidad_fecha_nacimiento1.ToString();
                            //txt_siMies.Text = sso.Socio_economico_registrar_dependencia_familiar_MIES_si.ToString();
                            //txt_noMies.Text = sso.Socio_economico_registrar_dependencia_familiar_MIES_no.ToString();
                            txt_carnetMies.Text = sso.Socio_economico_registrar_dependencia_familiar_MIES_numcarnet.ToString();
                            //txt_sifamcatas.Text = sso.Socio_economico_familiar_enfermedad_catastrofica_rara_si.ToString();
                            //txt_nofamcatas.Text = sso.Socio_economico_familiar_enfermedad_catastrofica_rara_no.ToString();
                            txt_indicarfamcatas.Text = sso.Socio_economico_familiar_enfermedad_catastrofica_rara_parentesco.ToString();
                            //txt_siacargofamcatas.Text = sso.Socio_economico_a_cargo_familiar_enfermedad_catastrofica_rara_si.ToString();
                            //txt_noacargofamcatas.Text = sso.Socio_economico_a_cargo_familiar_enfermedad_catastrofica_rara_no.ToString();
                            txt_tipoacargofamcatas.Text = sso.Socio_economico_a_cargo_familiar_enfermedad_catastrofica_rara_tipoenfermedad.ToString();

                            //4.
                            //txt_hogar.Text = sso.Socio_economico_hogar.ToString();
                            //txt_paseosfam.Text = sso.Socio_economico_paseos_familiares.ToString();
                            //txt_estudios.Text = sso.Socio_economico_estudios.ToString();
                            //txt_actartisticas.Text = sso.Socio_economico_actividades_artisticas.ToString();
                            txt_otratc.Text = sso.Socio_economico_otros.ToString();
                            txt_trabajocomplementario.Text = sso.Socio_economico_trabajo_complementario.ToString();
                            txt_detalleact.Text = sso.Socio_economico_detalle_actividad.ToString();
                            txt_tiempact.Text = sso.Socio_economico_tiempo_actividad.ToString();
                            txt_hacecuantoact.Text = sso.Socio_economico_hace_cuanto_tiempo_actividad.ToString();
                            //txt_sideportiva.Text = sso.Socio_economico_actividad_deportiva_si.ToString();
                            //txt_nodeportiva.Text = sso.Socio_economico_actividad_deportiva_no.ToString();
                            txt_especificaract.Text = sso.Socio_economico_actividad_deportiva_especificar.ToString();
                            txt_frecuenciaact.Text = sso.Socio_economico_actividad_deportiva_frecuencia.ToString();
                            txt_edadpractica.Text = sso.Socio_economico_actividad_deportiva_edad.ToString();
                            //txt_silesion.Text = sso.Socio_economico_lesion_si.ToString();
                            //txt_nolesion.Text = sso.Socio_economico_lesion_no.ToString();
                            txt_tipolesion.Text = sso.Socio_economico_lesion_tipo.ToString();
                            txt_edadlesion.Text = sso.Socio_economico_lesion_edad.ToString();
                            //txt_sitratamiento.Text = sso.Socio_economico_lesion_tratamiento_si.ToString();
                            //txt_notratamiento.Text = sso.Socio_economico_lesion_tratamiento_no.ToString();

                            //5. MOSTRAR DATOS DE INFORMACION ESTABILIDAD FAMILIAR SSO
                            //txt_nuclear.Text = sso.Socio_economico_tipo_familia_nuclear.ToString();
                            //txt_ampliada.Text = sso.Socio_economico_tipo_familia_ampliada.ToString();
                            //txt_monoparental.Text = sso.Socio_economico_tipo_familia_monoparental.ToString();
                            //txt_padremadresoltero.Text = sso.Socio_economico_tipo_familia_padremadresoltero.ToString();
                            //txt_vivesolo.Text = sso.Socio_economico_tipo_familia_vive_solo.ToString();
                            //txt_viveamigos.Text = sso.Socio_economico_tipo_familia_vive_amigos.ToString();
                            //txt_familiasinhijos.Text = sso.Socio_economico_tipo_familia_sin_hijos.ToString();
                            //txt_familiarmuybueno.Text = sso.Socio_economico_evaluacion_relacion_familiar_muybueno.ToString();
                            //txt_familiarbueno.Text = sso.Socio_economico_evaluacion_relacion_familiar_bueno.ToString();
                            //txt_familiaregular.Text = sso.Socio_economico_evaluacion_relacion_familiar_regular.ToString();
                            //txt_familiaregular.Text = sso.Socio_economico_evaluacion_relacion_familiar_mala.ToString();
                            txt_familiarporque.Text = sso.Socio_economico_evaluacion_relacion_familiar_porque.ToString();
                            //txt_parejamuybueno.Text = sso.Socio_economico_evaluacion_relacion_pareja_muybueno.ToString();
                            //txt_parejabueno.Text = sso.Socio_economico_evaluacion_relacion_pareja_bueno.ToString();
                            //txt_parejaregular.Text = sso.Socio_economico_evaluacion_relacion_pareja_regular.ToString();
                            //txt_parejaregular.Text = sso.Socio_economico_evaluacion_relacion_pareja_mala.ToString();
                            txt_parejaporque.Text = sso.Socio_economico_evaluacion_relacion_pareja_porque.ToString();
                            //txt_hijosmuybueno.Text = sso.Socio_economico_evaluacion_relacion_hijos_muybueno.ToString();
                            //txt_hijosbueno.Text = sso.Socio_economico_evaluacion_relacion_hijos_bueno.ToString();
                            //txt_hijosregular.Text = sso.Socio_economico_evaluacion_relacion_hijos_regular.ToString();
                            //txt_hijosregular.Text = sso.Socio_economico_evaluacion_relacion_hijos_mala.ToString();
                            txt_hijosporque.Text = sso.Socio_economico_evaluacion_relacion_hijos_porque.ToString();
                            //txt_antpenales.Text = sso.Socio_economico_problemas_familiares_antpenales.ToString();
                            //txt_economicos.Text = sso.Socio_economico_problemas_familiares_economicos.ToString();
                            //txt_comunicacion.Text = sso.Socio_economico_problemas_familiares_comunicacion.ToString();
                            //txt_conyugales.Text = sso.Socio_economico_problemas_familiares_conyugales.ToString();
                            //txt_crianzahijos.Text = sso.Socio_economico_problemas_familiares_crianza_hijos.ToString();
                            //txt_adicciones.Text = sso.Socio_economico_problemas_familiares_adicciones.ToString();
                            //txt_fisica.Text = sso.Socio_economico_problemas_familiares_violencia_fisica.ToString();
                            //txt_psicologica.Text = sso.Socio_economico_problemas_familiares_violencia_psicologica.ToString();
                            //txt_verbal.Text = sso.Socio_economico_problemas_familiares_violencia_verbal.ToString();
                            //txt_sexual.Text = sso.Socio_economico_problemas_familiares_violencia_sexual.ToString();
                            txt_observaciones.Text = sso.Socio_economico_problemas_familiares_observaciones.ToString();
                            //txt_rolsi.Text = sso.Socio_economico_miembro_familiar_rol_si.ToString();
                            //txt_rolno.Text = sso.Socio_economico_miembro_familiar_rol_no.ToString();
                            //txt_saludmuybuena.Text = sso.Socio_economico_salud_familia_muybueno.ToString();
                            //txt_saludbuena.Text = sso.Socio_economico_salud_familia_bueno.ToString();
                            //txt_saludregular.Text = sso.Socio_economico_salud_familia_regular.ToString();
                            //txt_saludmala.Text = sso.Socio_economico_salud_familia_mala.ToString();
                            txt_saludporque.Text = sso.Socio_economico_salud_familia_porque.ToString();
                            //txt_funcional.Text = sso.Socio_economico_familia_funcional.ToString();
                            //txt_disfuncional.Text = sso.Socio_economico_familia_disfuncional.ToString();
                            txt_observacion.Text = sso.Socio_economico_familia_observaciones.ToString();
                            txt_adicional.Text = sso.Socio_economico_informacion_adicional.ToString();
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
                string oConn = @"Data Source=.;Initial Catalog=SistemaECU911;Integrated Security=True";

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
                        where c.Per_Cedula == cedula
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
                    //1. Captura de DATOS GENERALES SSO
                    Socio_economico_departamento_area = txt_areatrabajo.Text,
                    Socio_economico_carga_institucional = txt_cargoinstitucional.Text,
                    //Socio_economico_tipocontrato_nombramiento = txt_nombramiento.Text,
                    //Socio_economico_tipocontrato_nombraprovisional = txt_nombraprovisional.Text,
                    //Socio_economico_tipocontrato_contratocasional = txt_contratoocasional.Text,
                    //Socio_economico_tipocontrato_codigotrabajo = txt_codigotrabajoContrato.Text,
                    //Socio_economico_modalidadcontrato_leyorgserpublico = txt_modalidadlosep.Text,
                    //Socio_economico_modalidadcontrato_codigotrabajo = txt_codigotrabajoModalidad.Text,
                    Socio_economico_fecha_ingreso_al_Ecu = Convert.ToDateTime(txt_fechaingreso.Text),
                    //Socio_economico_estadocivil_soltero = txt_soltero.Text,
                    //Socio_economico_estadocivil_casado = txt_casado.Text,
                    //Socio_economico_estadocivil_viudo = txt_viudo.Text,
                    //Socio_economico_estadocivil_unionlibre = txt_unionlibre.Text,
                    //Socio_economico_estadocivil_divorciado = txt_divorciado.Text,
                    Socio_economico_genero = txt_genero.Text,
                    Socio_economico_tipodesangre = txt_tiposangre.Text,
                    Socio_economico_telefonoconvencional = txt_telfconvencional.Text,
                    Socio_economico_telefonocelular = txt_telfcelular.Text,
                    Socio_economico_email = txt_email.Text,
                    Socio_economico_lugardenacimiento = txt_lugarnacimiento.Text,
                    //Socio_economico_niveleducativo_primaria = txt_primaria.Text,
                    //Socio_economico_niveleducativo_secundaria = txt_secundaria.Text,
                    //Socio_economico_niveleducativo_superior = txt_superior.Text,
                    //Socio_economico_niveleducativo_especializacion = txt_especializacion.Text,
                    //Socio_economico_niveleducativo_diplomado = txt_diploma.Text,
                    //Socio_economico_niveleducativo_maestrias = txt_maestria.Text,
                    //Socio_economico_autoidentificacionetnica_blanco = txt_blanco.Text,
                    //Socio_economico_autoidentificacionetnica_mestizo = txt_mestizo.Text,
                    //Socio_economico_autoidentificacionetnica_afrodescendiente = txt_afrodescendiente.Text,
                    //Socio_economico_autoidentificacionetnica_indigena = txt_indigena.Text,
                    //Socio_economico_autoidentificacionetnica_montubio = txt_montubio.Text,
                    Socio_economico_direcciondomicilio_provincia = txt_provincia.Text,
                    Socio_economico_direcciondomicilio_canton = txt_canton.Text,
                    Socio_economico_direcciondomicilio_parroquia = txt_canton.Text,
                    Socio_economico_direcciondomicilio_barrio = txt_barrio.Text,
                    Socio_economico_calleubicadaviviendaynumeracion = txt_callevivienda.Text,
                    Socio_economico_callesecundaria = txt_callesecundaria.Text,
                    Socio_economico_referencia_ubicar_domicilio = txt_referenciadomicilio.Text,
                    //Socio_economico_sectorvive_norte = txt_norte.Text,
                    //Socio_economico_sectorvive_centro = txt_centro.Text,
                    //Socio_economico_sectorvive_sur = txt_sur.Text,
                    //Socio_economico_sectorvive_otro = txt_otro.Text,
                    Socio_economico_sectorvive_otroindique = txt_otrosector.Text,
                    //Socio_economico_tipovivienda_casa = txt_casa.Text,
                    //Socio_economico_tipovivienda_departamento = txt_departamento.Text,
                    Socio_economico_tipovivienda_otro = txt_otravivienda.Text,
                    //Socio_economico_tipovivienda_cuentaserviciosbasicossi = txt_siserviciobasico.Text,
                    //Socio_economico_tipovivienda_cuentaserviciosbasicosno = txt_noserviciobasico.Text,
                    Socio_economico_cuantaspersonasvivenconusted = txt_personasvivenconusted.Text,
                    Socio_economico_cuantaspersonasviveneventualconusted = txt_personasviveneventualconusted.Text,
                    Socio_economico_personacontactoemergencia_nombresyapellidos = txt_nomapeemergencia.Text,
                    Socio_economico_personacontactoemergencia_parentesco = txt_parentesco.Text,
                    Socio_economico_personacontactoemergencia_telefono = txt_telfemergencia.Text,
                    Socio_economico_personacontactoemergencia_direccion_calleprincipal = txt_calleprincipalfamiliar.Text,
                    Socio_economico_personacontactoemergencia_direccion_numdomicilio = txt_numdomiciliofamiliar.Text,
                    Socio_economico_personacontactoemergencia_direccion_callesecundaria = txt_callesecundariafamiliar.Text,
                    Socio_economico_personacontactoemergencia_direccion_referenciaubicardomicilio = txt_referenciadomiciliofamiliar.Text,
                    //Socio_economico_destinadineroahorro_si = txt_siahorro.Text,
                    //Socio_economico_destinadineroahorro_no = txt_noahorro.Text,
                    //Socio_economico_vehiculopropio_si = txt_sivehiculo.Text,
                    //Socio_economico_vehiculopropio_no = txt_novehiculo.Text,
                    //Socio_economico_recorridoinstitucional_si = txt_sirecorrido.Text,
                    //Socio_economico_recorridoinstitucional_no = txt_norecorrido.Text,
                    //Socio_economico_recorridoinstitucional_noexiste = txt_noexisterecorrido.Text,
                    Socio_economico_distancia_domicilio_trabajo = txt_distanciadomicilio.Text,

                    //2. Captura de DATOS SALUD SSO
                    Socio_economico_poseeenfermedad = txt_poseeenfermedad.Text,
                    //Socio_economico_discapacidad_si = txt_sidiscapacidad.Text,
                    //Socio_economico_discapacidad_no = txt_nodiscapacidad.Text,
                    //Socio_economico_discapacidad_tipo = txt_tipodiscapacidad.Text,
                    Socio_economico_discapacidad_porcentaje = Convert.ToInt32(txt_porcentajediscapacidad.Text),
                    Socio_economico_discapacidad_carnetconadis = txt_numcarnetconadis.Text,
                    Socio_economico_discapacidad_fechacaducidadcarnetconadis = Convert.ToDateTime(txt_fechacaducidadcarnet.Text),
                    //Socio_economico_conyugueembarazada_no = txt_noconyugeembarazada.Text,
                    //Socio_economico__si_me_encuentro_embarazada = txt_simeenceuntroembarazada.Text,
                    //Socio_economico__si_mi_conyugue_esta_embarazada = txt_simiconyugeembarazada.Text,
                    Socio_economico__mes_embarazo = txt_mesgestacion.Text,
                    Socio_economico__dias_embarazo = txt_diasgestacion.Text,
                    Socio_economico_fecha_tentativa_parto = Convert.ToDateTime(txt_fechatentativaparto.Text),
                    //Socio_economico_periodo_lactancia_si = txt_siperiodolactancia.Text,
                    //Socio_economico_periodo_lactancia_no = txt_noperiodolactancia.Text,
                    Socio_economico_periodo_lactancia_fechaculminacion = Convert.ToDateTime(txt_fechaculminacionlactancia.Text),
                    //Socio_economico_enfermedad_cronica_si = txt_sienfermedadcronica.Text,
                    //Socio_economico_enfermedad_cronica_no = txt_noenfermedadcronica.Text,
                    Socio_economico_enfermedad_cronica_cual = txt_cualenfermedadcronica.Text,
                    Socio_economico_enfermedad_cronica_otras = txt_otrasenfermedades.Text,
                    //Socio_economico_enfermedad_rara_si = txt_sienfermedadrara.Text,
                    //Socio_economico_enfermedad_rara_no = txt_noenfermedadrara.Text,
                    //Socio_economico_enfermedad_rara_cual = txt_cualenfermedadrara.Text,
                    //Socio_economico_consume_alcohol_si = txt_sialcohol.Text,
                    //Socio_economico_consume_alcohol_no = txt_noalcohol.Text,
                    //Socio_economico_consume_alcohol_tipo_cerveza = txt_cerveza.Text,
                    //Socio_economico_consume_alcohol_tipo_ron = txt_ron.Text,
                    //Socio_economico_consume_alcohol_tipo_whisky = txt_whisky.Text,
                    Socio_economico_consume_alcohol_tipo_otro = txt_otroalcohol.Text,
                    Socio_economico_consume_alcohol_frecuencia_consumo = txt_frecuenciaalcohol.Text,
                    Socio_economico_consume_alcohol_tiempo_consumo = txt_tiempoconsumoalcohol.Text,
                    //Socio_economico_consume_tabaco_si = txt_sitabaco.Text,
                    //Socio_economico_consume_tabaco_no = txt_notabaco.Text,
                    Socio_economico_consume_tabaco_frecuencia_consumo = txt_frecuenciatabaco.Text,
                    Socio_economico_consume_tabaco_cantidad_consumo = txt_cantidadtabaco.Text,
                    Socio_economico_consume_tabaco_tiempo_consumo = txt_tiempoconsumotabaco.Text,
                    //Socio_economico_consume_sustancia_psicotropica_si = txt_sipsicotropica.Text,
                    //Socio_economico_consume_sustancia_psicotropica_no = txt_nopsicotropica.Text,
                    Socio_economico_consume_sustancia_psicotropica_tipo = txt_tipopsicotropica.Text,
                    Socio_economico_consume_sustancia_psicotropica_frecuencia_consumo = txt_frecuenciapsicotropica.Text,
                    Socio_economico_consume_sustancia_psicotropica_factores_psicosociales = txt_factorespsicotropica.Text,

                    //3. Captura de INFORMACION FAMILIAR SSO
                    Socio_economico_nombres_apellidos_conyugue = txt_nomapeconyuge.Text,
                    Socio_economico_numero_hijos = txt_numhijos.Text,
                    Socio_economico_numero_dependientes = txt_numdependientes.Text,
                    Socio_economico_nombres_apellidos_familiar1 = txt_nomapefam1.Text,
                    Socio_economico_fecha_nacimiento_familiar1 = Convert.ToDateTime(txt_fechanacfam1.Text),
                    Socio_economico_edad_familiar1 = Convert.ToInt32(txt_edadfam1.Text),
                    Socio_economico_nombres_apellidos_familiar2 = txt_nomapefam2.Text,
                    Socio_economico_fecha_nacimiento_familiar2 = Convert.ToDateTime(txt_fechanacfam2.Text),
                    Socio_economico_edad_familiar2 = Convert.ToInt32(txt_edadfam2.Text),
                    //Socio_economico_nucleofamiliar_persona_discapacidad_si = txt_siperdis.Text,
                    //Socio_economico_nucleofamiliar_persona_discapacidad_no = txt_noperdis.Text,
                    //Socio_economico_acargo_de_persona_discapacidad_si = txt_sicargodis.Text,
                    //Socio_economico_acargo_de_persona_discapacidad_no = txt_nocargodis.Text,
                    Socio_economico_nombres_apellidos_familiar_discapacidad1 = txt_nomapefamdis.Text,
                    Socio_economico_fecha_caducidad_carnet_familiar_discapacidad1 = Convert.ToDateTime(txt_fechacadis.Text),
                    Socio_economico_familiar_discapacidad_tipo1 = txt_tipodis.Text,
                    Socio_economico_familiar_discapacidad_porcentaje1 = Convert.ToInt32(txt_porcdis.Text),
                    Socio_economico_familiar_discapacidad_parentesco1 = txt_parendis.Text,
                    Socio_economico_familiar_discapacidad_fecha_nacimiento1 = Convert.ToDateTime(txt_fechanacdis.Text),
                    //Socio_economico_registrar_dependencia_familiar_MIES_si = txt_siMies.Text,
                    //Socio_economico_registrar_dependencia_familiar_MIES_no = txt_noMies.Text,
                    Socio_economico_registrar_dependencia_familiar_MIES_numcarnet = txt_carnetMies.Text,
                    //Socio_economico_familiar_enfermedad_catastrofica_rara_si = txt_sifamcatas.Text,
                    //Socio_economico_familiar_enfermedad_catastrofica_rara_no = txt_nofamcatas.Text,
                    Socio_economico_familiar_enfermedad_catastrofica_rara_parentesco = txt_indicarfamcatas.Text,
                    //Socio_economico_a_cargo_familiar_enfermedad_catastrofica_rara_si = txt_siacargofamcatas.Text,
                    //Socio_economico_a_cargo_familiar_enfermedad_catastrofica_rara_no = txt_noacargofamcatas.Text,
                    Socio_economico_a_cargo_familiar_enfermedad_catastrofica_rara_tipoenfermedad = txt_tipoacargofamcatas.Text,

                    //4. Captura de ACTIVIDADES QUE REALIZA EN SU TIEMPO LIBRE SSO
                    //Socio_economico_hogar = txt_hogar.Text,
                    //Socio_economico_paseos_familiares = txt_paseosfam.Text,
                    //Socio_economico_estudios = txt_estudios.Text,
                    //Socio_economico_actividades_artisticas = txt_actartisticas.Text,
                    Socio_economico_otros = txt_otratc.Text,
                    Socio_economico_trabajo_complementario = txt_trabajocomplementario.Text,
                    Socio_economico_detalle_actividad = txt_detalleact.Text,
                    Socio_economico_tiempo_actividad = txt_tiempact.Text,
                    Socio_economico_hace_cuanto_tiempo_actividad = txt_hacecuantoact.Text,
                    //Socio_economico_actividad_deportiva_si = txt_sideportiva.Text,
                    //Socio_economico_actividad_deportiva_no = txt_nodeportiva.Text,
                    Socio_economico_actividad_deportiva_especificar = txt_especificaract.Text,
                    Socio_economico_actividad_deportiva_frecuencia = txt_frecuenciaact.Text,
                    Socio_economico_actividad_deportiva_edad = Convert.ToInt32(txt_edadpractica.Text),
                    //Socio_economico_lesion_si = txt_silesion.Text,
                    //Socio_economico_lesion_no = txt_nolesion.Text,
                    Socio_economico_lesion_tipo = txt_tipolesion.Text,
                    Socio_economico_lesion_edad = Convert.ToInt32(txt_edadlesion.Text),
                    //Socio_economico_lesion_tratamiento_si = txt_sitratamiento.Text,
                    //Socio_economico_lesion_tratamiento_no = txt_notratamiento.Text,

                    //5. Captura de INFORMACION ESTABILIDAD FAMILIAR SSO
                    //Socio_economico_tipo_familia_nuclear = txt_nuclear.Text,
                    //Socio_economico_tipo_familia_ampliada = txt_ampliada.Text,
                    //Socio_economico_tipo_familia_monoparental = txt_monoparental.Text,
                    //Socio_economico_tipo_familia_padremadresoltero = txt_padremadresoltero.Text,
                    //Socio_economico_tipo_familia_vive_solo = txt_vivesolo.Text,
                    //Socio_economico_tipo_familia_vive_amigos = txt_viveamigos.Text,
                    //Socio_economico_tipo_familia_sin_hijos = txt_familiasinhijos.Text,
                    //Socio_economico_evaluacion_relacion_familiar_muybueno = txt_familiarmuybueno.Text,
                    //Socio_economico_evaluacion_relacion_familiar_bueno = txt_familiarbueno.Text,
                    //Socio_economico_evaluacion_relacion_familiar_regular = txt_familiaregular.Text,
                    //Socio_economico_evaluacion_relacion_familiar_mala = txt_familiaregular.Text,
                    Socio_economico_evaluacion_relacion_familiar_porque = txt_familiarporque.Text,
                    //Socio_economico_evaluacion_relacion_pareja_muybueno = txt_parejamuybueno.Text,
                    //Socio_economico_evaluacion_relacion_pareja_bueno = txt_parejabueno.Text,
                    //Socio_economico_evaluacion_relacion_pareja_regular = txt_parejaregular.Text,
                    //Socio_economico_evaluacion_relacion_pareja_mala = txt_parejaregular.Text,
                    //Socio_economico_evaluacion_relacion_pareja_porque = txt_parejaporque.Text,
                    //Socio_economico_evaluacion_relacion_hijos_muybueno = txt_hijosmuybueno.Text,
                    //Socio_economico_evaluacion_relacion_hijos_bueno = txt_hijosbueno.Text,
                    //Socio_economico_evaluacion_relacion_hijos_regular = txt_hijosregular.Text,
                    //Socio_economico_evaluacion_relacion_hijos_mala = txt_hijosregular.Text,
                    Socio_economico_evaluacion_relacion_hijos_porque = txt_hijosporque.Text,
                    //Socio_economico_problemas_familiares_antpenales = txt_antpenales.Text,
                    //Socio_economico_problemas_familiares_economicos = txt_economicos.Text,
                    //Socio_economico_problemas_familiares_comunicacion = txt_comunicacion.Text,
                    //Socio_economico_problemas_familiares_conyugales = txt_conyugales.Text,
                    //Socio_economico_problemas_familiares_crianza_hijos = txt_crianzahijos.Text,
                    //Socio_economico_problemas_familiares_adicciones = txt_adicciones.Text,
                    //Socio_economico_problemas_familiares_violencia_fisica = txt_fisica.Text,
                    //Socio_economico_problemas_familiares_violencia_psicologica = txt_psicologica.Text,
                    //Socio_economico_problemas_familiares_violencia_verbal = txt_verbal.Text,
                    //Socio_economico_problemas_familiares_violencia_sexual = txt_sexual.Text,
                    Socio_economico_problemas_familiares_observaciones = txt_observaciones.Text,
                    //Socio_economico_miembro_familiar_rol_si = txt_rolsi.Text,
                    //Socio_economico_miembro_familiar_rol_no = txt_rolno.Text,
                    //Socio_economico_salud_familia_muybueno = txt_saludmuybuena.Text,
                    //Socio_economico_salud_familia_bueno = txt_saludbuena.Text,
                    //Socio_economico_salud_familia_regular = txt_saludregular.Text,
                    //Socio_economico_salud_familia_mala = txt_saludmala.Text,
                    Socio_economico_salud_familia_porque = txt_saludporque.Text,
                    //Socio_economico_familia_funcional = txt_funcional.Text,
                    //Socio_economico_familia_disfuncional = txt_disfuncional.Text,
                    Socio_economico_familia_observaciones = txt_observacion.Text,
                    Socio_economico_informacion_adicional = txt_adicional.Text,
                    Per_id = perso
                };

                CN_SocioEconomico.GuardarSocioEconomico(sso);

                //Mensaje de confirmacion
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Guardados Exitosamente')", true);

                Response.Redirect("~/Template/Views/PacientesSocioEconomico.aspx");

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
                //1.
                sso.Socio_economico_departamento_area = txt_areatrabajo.Text;
                sso.Socio_economico_carga_institucional = txt_cargoinstitucional.Text;
                //sso.Socio_economico_tipocontrato_nombramiento = txt_nombramiento.Text;
                //sso.Socio_economico_tipocontrato_nombraprovisional = txt_nombraprovisional.Text;
                //sso.Socio_economico_tipocontrato_contratocasional = txt_contratoocasional.Text;
                //sso.Socio_economico_tipocontrato_codigotrabajo = txt_codigotrabajoContrato.Text;
                //sso.Socio_economico_modalidadcontrato_leyorgserpublico = txt_modalidadlosep.Text;
                //sso.Socio_economico_modalidadcontrato_codigotrabajo = txt_codigotrabajoModalidad.Text;
                sso.Socio_economico_fecha_ingreso_al_Ecu = Convert.ToDateTime(txt_fechaingreso.Text);
                //sso.Socio_economico_estadocivil_soltero = txt_soltero.Text;
                //sso.Socio_economico_estadocivil_casado = txt_casado.Text;
                //sso.Socio_economico_estadocivil_viudo = txt_viudo.Text;
                //sso.Socio_economico_estadocivil_unionlibre = txt_unionlibre.Text;
                //sso.Socio_economico_estadocivil_divorciado = txt_divorciado.Text;
                sso.Socio_economico_genero = txt_genero.Text;
                sso.Socio_economico_tipodesangre = txt_tiposangre.Text;
                sso.Socio_economico_telefonoconvencional = txt_telfconvencional.Text;
                sso.Socio_economico_telefonocelular = txt_telfcelular.Text;
                sso.Socio_economico_email = txt_email.Text;
                sso.Socio_economico_lugardenacimiento = txt_lugarnacimiento.Text;
                //sso.Socio_economico_niveleducativo_primaria = txt_primaria.Text;
                //sso.Socio_economico_niveleducativo_secundaria = txt_secundaria.Text;
                //sso.Socio_economico_niveleducativo_superior = txt_superior.Text;
                //sso.Socio_economico_niveleducativo_especializacion = txt_especializacion.Text;
                //sso.Socio_economico_niveleducativo_diplomado = txt_diploma.Text;
                //sso.Socio_economico_niveleducativo_maestrias = txt_maestria.Text;
                //sso.Socio_economico_autoidentificacionetnica_blanco = txt_blanco.Text;
                //sso.Socio_economico_autoidentificacionetnica_mestizo = txt_mestizo.Text;
                //sso.Socio_economico_autoidentificacionetnica_afrodescendiente = txt_afrodescendiente.Text;
                //sso.Socio_economico_autoidentificacionetnica_indigena = txt_indigena.Text;
                //sso.Socio_economico_autoidentificacionetnica_montubio = txt_montubio.Text;
                sso.Socio_economico_direcciondomicilio_provincia = txt_provincia.Text;
                sso.Socio_economico_direcciondomicilio_canton = txt_canton.Text;
                sso.Socio_economico_direcciondomicilio_parroquia = txt_canton.Text;
                sso.Socio_economico_direcciondomicilio_barrio = txt_barrio.Text;
                sso.Socio_economico_calleubicadaviviendaynumeracion = txt_callevivienda.Text;
                sso.Socio_economico_callesecundaria = txt_callesecundaria.Text;
                sso.Socio_economico_referencia_ubicar_domicilio = txt_referenciadomicilio.Text;
                //sso.Socio_economico_sectorvive_norte = txt_norte.Text;
                //sso.Socio_economico_sectorvive_centro = txt_centro.Text;
                //sso.Socio_economico_sectorvive_sur = txt_sur.Text;
                //sso.Socio_economico_sectorvive_otro = txt_otro.Text;
                sso.Socio_economico_sectorvive_otroindique = txt_otrosector.Text;
                //sso.Socio_economico_tipovivienda_casa = txt_casa.Text;
                //sso.Socio_economico_tipovivienda_departamento = txt_departamento.Text;
                sso.Socio_economico_tipovivienda_otro = txt_otravivienda.Text;
                //sso.Socio_economico_tipovivienda_cuentaserviciosbasicossi = txt_siserviciobasico.Text;
                //sso.Socio_economico_tipovivienda_cuentaserviciosbasicosno = txt_noserviciobasico.Text;
                sso.Socio_economico_cuantaspersonasvivenconusted = txt_personasvivenconusted.Text;
                sso.Socio_economico_cuantaspersonasviveneventualconusted = txt_personasviveneventualconusted.Text;
                sso.Socio_economico_personacontactoemergencia_nombresyapellidos = txt_nomapeemergencia.Text;
                sso.Socio_economico_personacontactoemergencia_parentesco = txt_parentesco.Text;
                sso.Socio_economico_personacontactoemergencia_telefono = txt_telfemergencia.Text;
                sso.Socio_economico_personacontactoemergencia_direccion_calleprincipal = txt_calleprincipalfamiliar.Text;
                sso.Socio_economico_personacontactoemergencia_direccion_numdomicilio = txt_numdomiciliofamiliar.Text;
                sso.Socio_economico_personacontactoemergencia_direccion_callesecundaria = txt_callesecundariafamiliar.Text;
                sso.Socio_economico_personacontactoemergencia_direccion_referenciaubicardomicilio = txt_referenciadomiciliofamiliar.Text;
                //sso.Socio_economico_destinadineroahorro_si = txt_siahorro.Text;
                //sso.Socio_economico_destinadineroahorro_no = txt_noahorro.Text;
                //sso.Socio_economico_vehiculopropio_si = txt_sivehiculo.Text;
                //sso.Socio_economico_vehiculopropio_no = txt_novehiculo.Text;
                //sso.Socio_economico_recorridoinstitucional_si = txt_sirecorrido.Text;
                //sso.Socio_economico_recorridoinstitucional_no = txt_norecorrido.Text;
                //sso.Socio_economico_recorridoinstitucional_noexiste = txt_noexisterecorrido.Text;
                sso.Socio_economico_distancia_domicilio_trabajo = txt_distanciadomicilio.Text;

                //2. Captura de DATOS SALUD SSO
                sso.Socio_economico_poseeenfermedad = txt_poseeenfermedad.Text;
                //sso.Socio_economico_discapacidad_si = txt_sidiscapacidad.Text;
                //sso.Socio_economico_discapacidad_no = txt_nodiscapacidad.Text;
                //sso.Socio_economico_discapacidad_tipo = txt_tipodiscapacidad.Text;
                sso.Socio_economico_discapacidad_porcentaje = Convert.ToInt32(txt_porcentajediscapacidad.Text);
                sso.Socio_economico_discapacidad_carnetconadis = txt_numcarnetconadis.Text;
                sso.Socio_economico_discapacidad_fechacaducidadcarnetconadis = Convert.ToDateTime(txt_fechacaducidadcarnet.Text);
                //sso.Socio_economico_conyugueembarazada_no = txt_noconyugeembarazada.Text;
                //sso.Socio_economico__si_me_encuentro_embarazada = txt_simeenceuntroembarazada.Text;
                //sso.Socio_economico__si_mi_conyugue_esta_embarazada = txt_simiconyugeembarazada.Text;
                sso.Socio_economico__mes_embarazo = txt_mesgestacion.Text;
                sso.Socio_economico__dias_embarazo = txt_diasgestacion.Text;
                sso.Socio_economico_fecha_tentativa_parto = Convert.ToDateTime(txt_fechatentativaparto.Text);
                //sso.Socio_economico_periodo_lactancia_si = txt_siperiodolactancia.Text;
                //sso.Socio_economico_periodo_lactancia_no = txt_noperiodolactancia.Text;
                sso.Socio_economico_periodo_lactancia_fechaculminacion = Convert.ToDateTime(txt_fechaculminacionlactancia.Text);
                //sso.Socio_economico_enfermedad_cronica_si = txt_sienfermedadcronica.Text;
                //sso.Socio_economico_enfermedad_cronica_no = txt_noenfermedadcronica.Text;
                sso.Socio_economico_enfermedad_cronica_cual = txt_cualenfermedadcronica.Text;
                sso.Socio_economico_enfermedad_cronica_otras = txt_otrasenfermedades.Text;
                //sso.Socio_economico_enfermedad_rara_si = txt_sienfermedadrara.Text;
                //sso.Socio_economico_enfermedad_rara_no = txt_noenfermedadrara.Text;
                //sso.Socio_economico_enfermedad_rara_cual = txt_cualenfermedadrara.Text;
                //sso.Socio_economico_consume_alcohol_si = txt_sialcohol.Text;
                //sso.Socio_economico_consume_alcohol_no = txt_noalcohol.Text;
                //sso.Socio_economico_consume_alcohol_tipo_cerveza = txt_cerveza.Text;
                //sso.Socio_economico_consume_alcohol_tipo_ron = txt_ron.Text;
                //sso.Socio_economico_consume_alcohol_tipo_whisky = txt_whisky.Text;
                sso.Socio_economico_consume_alcohol_tipo_otro = txt_otroalcohol.Text;
                sso.Socio_economico_consume_alcohol_frecuencia_consumo = txt_frecuenciaalcohol.Text;
                sso.Socio_economico_consume_alcohol_tiempo_consumo = txt_tiempoconsumoalcohol.Text;
                //sso.Socio_economico_consume_tabaco_si = txt_sitabaco.Text;
                //sso.Socio_economico_consume_tabaco_no = txt_notabaco.Text;
                sso.Socio_economico_consume_tabaco_frecuencia_consumo = txt_frecuenciatabaco.Text;
                sso.Socio_economico_consume_tabaco_cantidad_consumo = txt_cantidadtabaco.Text;
                sso.Socio_economico_consume_tabaco_tiempo_consumo = txt_tiempoconsumotabaco.Text;
                //sso.Socio_economico_consume_sustancia_psicotropica_si = txt_sipsicotropica.Text;
                //sso.Socio_economico_consume_sustancia_psicotropica_no = txt_nopsicotropica.Text;
                sso.Socio_economico_consume_sustancia_psicotropica_tipo = txt_tipopsicotropica.Text;
                sso.Socio_economico_consume_sustancia_psicotropica_frecuencia_consumo = txt_frecuenciapsicotropica.Text;
                sso.Socio_economico_consume_sustancia_psicotropica_factores_psicosociales = txt_factorespsicotropica.Text;

                //3. Captura de INFORMACION FAMILIAR SSO
                sso.Socio_economico_nombres_apellidos_conyugue = txt_nomapeconyuge.Text;
                sso.Socio_economico_numero_hijos = txt_numhijos.Text;
                sso.Socio_economico_numero_dependientes = txt_numdependientes.Text;
                sso.Socio_economico_nombres_apellidos_familiar1 = txt_nomapefam1.Text;
                sso.Socio_economico_fecha_nacimiento_familiar1 = Convert.ToDateTime(txt_fechanacfam1.Text);
                sso.Socio_economico_edad_familiar1 = Convert.ToInt32(txt_edadfam1.Text);
                sso.Socio_economico_nombres_apellidos_familiar2 = txt_nomapefam2.Text;
                sso.Socio_economico_fecha_nacimiento_familiar2 = Convert.ToDateTime(txt_fechanacfam2.Text);
                sso.Socio_economico_edad_familiar2 = Convert.ToInt32(txt_edadfam2.Text);
                //sso.Socio_economico_nucleofamiliar_persona_discapacidad_si = txt_siperdis.Text;
                //sso.Socio_economico_nucleofamiliar_persona_discapacidad_no = txt_noperdis.Text;
                //sso.Socio_economico_acargo_de_persona_discapacidad_si = txt_sicargodis.Text;
                //sso.Socio_economico_acargo_de_persona_discapacidad_no = txt_nocargodis.Text;
                sso.Socio_economico_nombres_apellidos_familiar_discapacidad1 = txt_nomapefamdis.Text;
                sso.Socio_economico_fecha_caducidad_carnet_familiar_discapacidad1 = Convert.ToDateTime(txt_fechacadis.Text);
                sso.Socio_economico_familiar_discapacidad_tipo1 = txt_tipodis.Text;
                sso.Socio_economico_familiar_discapacidad_porcentaje1 = Convert.ToInt32(txt_porcdis.Text);
                sso.Socio_economico_familiar_discapacidad_parentesco1 = txt_parendis.Text;
                sso.Socio_economico_familiar_discapacidad_fecha_nacimiento1 = Convert.ToDateTime(txt_fechanacdis.Text);
                //sso.Socio_economico_registrar_dependencia_familiar_MIES_si = txt_siMies.Text;
                //sso.Socio_economico_registrar_dependencia_familiar_MIES_no = txt_noMies.Text;
                sso.Socio_economico_registrar_dependencia_familiar_MIES_numcarnet = txt_carnetMies.Text;
                //sso.Socio_economico_familiar_enfermedad_catastrofica_rara_si = txt_sifamcatas.Text;
                //sso.Socio_economico_familiar_enfermedad_catastrofica_rara_no = txt_nofamcatas.Text;
                sso.Socio_economico_familiar_enfermedad_catastrofica_rara_parentesco = txt_indicarfamcatas.Text;
                //sso.Socio_economico_a_cargo_familiar_enfermedad_catastrofica_rara_si = txt_siacargofamcatas.Text;
                //sso.Socio_economico_a_cargo_familiar_enfermedad_catastrofica_rara_no = txt_noacargofamcatas.Text;
                sso.Socio_economico_a_cargo_familiar_enfermedad_catastrofica_rara_tipoenfermedad = txt_tipoacargofamcatas.Text;

                //4.
                //sso.Socio_economico_hogar = txt_hogar.Text;
                //sso.Socio_economico_paseos_familiares = txt_paseosfam.Text;
                //sso.Socio_economico_estudios = txt_estudios.Text;
                //sso.Socio_economico_actividades_artisticas = txt_actartisticas.Text;
                sso.Socio_economico_otros = txt_otratc.Text;
                sso.Socio_economico_trabajo_complementario = txt_trabajocomplementario.Text;
                sso.Socio_economico_detalle_actividad = txt_detalleact.Text;
                sso.Socio_economico_tiempo_actividad = txt_tiempact.Text;
                sso.Socio_economico_hace_cuanto_tiempo_actividad = txt_hacecuantoact.Text;
                //sso.Socio_economico_actividad_deportiva_si = txt_sideportiva.Text;
                //sso.Socio_economico_actividad_deportiva_no = txt_nodeportiva.Text;
                sso.Socio_economico_actividad_deportiva_especificar = txt_especificaract.Text;
                sso.Socio_economico_actividad_deportiva_frecuencia = txt_frecuenciaact.Text;
                sso.Socio_economico_actividad_deportiva_edad = Convert.ToInt32(txt_edadpractica.Text);
                //sso.Socio_economico_lesion_si = txt_silesion.Text;
                //sso.Socio_economico_lesion_no = txt_nolesion.Text;
                sso.Socio_economico_lesion_tipo = txt_tipolesion.Text;
                sso.Socio_economico_lesion_edad = Convert.ToInt32(txt_edadlesion.Text);
                //sso.Socio_economico_lesion_tratamiento_si = txt_sitratamiento.Text;
                //sso.Socio_economico_lesion_tratamiento_no = txt_notratamiento.Text;

                //5.
                //sso.Socio_economico_tipo_familia_nuclear = txt_nuclear.Text;
                //sso.Socio_economico_tipo_familia_ampliada = txt_ampliada.Text;
                //sso.Socio_economico_tipo_familia_monoparental = txt_monoparental.Text;
                //sso.Socio_economico_tipo_familia_padremadresoltero = txt_padremadresoltero.Text;
                //sso.Socio_economico_tipo_familia_vive_solo = txt_vivesolo.Text;
                //sso.Socio_economico_tipo_familia_vive_amigos = txt_viveamigos.Text;
                //sso.Socio_economico_tipo_familia_sin_hijos = txt_familiasinhijos.Text;
                //sso.Socio_economico_evaluacion_relacion_familiar_muybueno = txt_familiarmuybueno.Text;
                //sso.Socio_economico_evaluacion_relacion_familiar_bueno = txt_familiarbueno.Text;
                //sso.Socio_economico_evaluacion_relacion_familiar_regular = txt_familiaregular.Text;
                //sso.Socio_economico_evaluacion_relacion_familiar_mala = txt_familiaregular.Text;
                sso.Socio_economico_evaluacion_relacion_familiar_porque = txt_familiarporque.Text;
                //sso.Socio_economico_evaluacion_relacion_pareja_muybueno = txt_parejamuybueno.Text;
                //sso.Socio_economico_evaluacion_relacion_pareja_bueno = txt_parejabueno.Text;
                //sso.Socio_economico_evaluacion_relacion_pareja_regular = txt_parejaregular.Text;
                //sso.Socio_economico_evaluacion_relacion_pareja_mala = txt_parejaregular.Text;
                //sso.Socio_economico_evaluacion_relacion_pareja_porque = txt_parejaporque.Text;
                //sso.Socio_economico_evaluacion_relacion_hijos_muybueno = txt_hijosmuybueno.Text;
                //sso.Socio_economico_evaluacion_relacion_hijos_bueno = txt_hijosbueno.Text;
                //sso.Socio_economico_evaluacion_relacion_hijos_regular = txt_hijosregular.Text;
                //sso.Socio_economico_evaluacion_relacion_hijos_mala = txt_hijosregular.Text;
                sso.Socio_economico_evaluacion_relacion_hijos_porque = txt_hijosporque.Text;
                //sso.Socio_economico_problemas_familiares_antpenales = txt_antpenales.Text;
                //sso.Socio_economico_problemas_familiares_economicos = txt_economicos.Text;
                //sso.Socio_economico_problemas_familiares_comunicacion = txt_comunicacion.Text;
                //sso.Socio_economico_problemas_familiares_conyugales = txt_conyugales.Text;
                //sso.Socio_economico_problemas_familiares_crianza_hijos = txt_crianzahijos.Text;
                //sso.Socio_economico_problemas_familiares_adicciones = txt_adicciones.Text;
                //sso.Socio_economico_problemas_familiares_violencia_fisica = txt_fisica.Text;
                //sso.Socio_economico_problemas_familiares_violencia_psicologica = txt_psicologica.Text;
                //sso.Socio_economico_problemas_familiares_violencia_verbal = txt_verbal.Text;
                //sso.Socio_economico_problemas_familiares_violencia_sexual = txt_sexual.Text;
                sso.Socio_economico_problemas_familiares_observaciones = txt_observaciones.Text;
                //sso.Socio_economico_miembro_familiar_rol_si = txt_rolsi.Text;
                //sso.Socio_economico_miembro_familiar_rol_no = txt_rolno.Text;
                //sso.Socio_economico_salud_familia_muybueno = txt_saludmuybuena.Text;
                //sso.Socio_economico_salud_familia_bueno = txt_saludbuena.Text;
                //sso.Socio_economico_salud_familia_regular = txt_saludregular.Text;
                //sso.Socio_economico_salud_familia_mala = txt_saludmala.Text;
                sso.Socio_economico_salud_familia_porque = txt_saludporque.Text;
                //sso.Socio_economico_familia_funcional = txt_funcional.Text;
                //sso.Socio_economico_familia_disfuncional = txt_disfuncional.Text;
                sso.Socio_economico_familia_observaciones = txt_observacion.Text;
                sso.Socio_economico_informacion_adicional = txt_adicional.Text;

                CN_SocioEconomico.ModificarSocioEconomico(sso);

                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Modificados Exitosamente')", true);
                Response.Redirect("~/Template/Views_Socio_Economico/PacientesSocioEconomico.aspx");
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Modificados')", true);
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