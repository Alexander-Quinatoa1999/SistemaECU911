﻿using CapaDatos;
using CapaNegocio;
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

namespace SistemaECU911.Template.Views_Pacientes
{
    public partial class SocioEconomico : System.Web.UI.Page
    {

        DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        //Objeto de la tabla personas
        private Tbl_Personas per = new Tbl_Personas();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txt_fecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
                CargarDatosModificar();
            }
        }

        //Metodo obtener cedula por numero de historia clinica
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

        private void CargarDatosModificar()
        {
            try
            {
                if (Request["cod"] != null)
                {
                    int codigo = Convert.ToInt32(Request["cod"]);

                    per = CN_HistorialMedico.ObtenerPersonasxId(codigo);
                    int perso = Convert.ToInt32(per.Per_id.ToString());

                    //datosgensso = CN_SocioEconomico.obtenerDatosGeneralesSSO(perso);
                    //datosaludsso = CN_SocioEconomico.obtenerDatosSaludSSO(perso);
                    //datoinfofamsso = CN_SocioEconomico.obtenerDatosInformacionFamiliarSSO(perso);
                    //datoactiemlibresso = CN_SocioEconomico.obtenerDatosActividadTiempoLibreSSO(perso);
                    //datoinfoestafamisso = CN_SocioEconomico.obtenerDatosEstabilidadFamiliarSSO(perso);

                    btn_guardarsso.Visible = true;

                    if (per != null)
                    {
                        ////1. MOSTRAR DATOS GENERALES SSO
                        //txt_cedula.Text = per.Per_Cedula.ToString();
                        //txt_priapellido.Text = per.Per_priApellido.ToString();
                        //txt_segapellido.Text = per.Per_segApellido.ToString();
                        //txt_prinombre.Text = per.Per_priNombre.ToString();
                        //txt_segnombre.Text = per.Per_segNombre.ToString();
                        //txt_areatrabajo.Text = datosgensso.DatGeneralesSSO_departamento_area.ToString();
                        //txt_cargoinstitucional.Text = datosgensso.DatGeneralesSSO_carga_institucional.ToString();
                        ////txt_nombramiento.Text = datosgensso.DatGeneralesSSO_tipocontrato_nombramiento.ToString();
                        ////txt_nombraprovisional.Text = datosgensso.DatGeneralesSSO_tipocontrato_nombraprovisional.ToString();
                        ////txt_contratoocasional.Text = datosgensso.DatGeneralesSSO_tipocontrato_contratocasional.ToString();
                        ////txt_codigotrabajoContrato.Text = datosgensso.DatGeneralesSSO_tipocontrato_codigotrabajo.ToString();
                        ////txt_modalidadlosep.Text = datosgensso.DatGeneralesSSO_modalidadcontrato_leyorgserpublico.ToString();
                        ////txt_codigotrabajoModalidad.Text = datosgensso.DatGeneralesSSO_modalidadcontrato_codigotrabajo.ToString();
                        //txt_fechaingreso.Text = datosgensso.DatGeneralesSSO_fecha_ingreso_al_Ecu.ToString();
                        ////txt_soltero.Text = datosgensso.DatGeneralesSSO_estadocivil_soltero.ToString();
                        ////txt_casado.Text = datosgensso.DatGeneralesSSO_estadocivil_casado.ToString();
                        ////txt_viudo.Text = datosgensso.DatGeneralesSSO_estadocivil_viudo.ToString();
                        ////txt_unionlibre.Text = datosgensso.DatGeneralesSSO_estadocivil_unionlibre.ToString();
                        ////txt_divorciado.Text = datosgensso.DatGeneralesSSO_estadocivil_divorciado.ToString();
                        //txt_genero.Text = datosgensso.DatGeneralesSSO_genero.ToString();
                        //txt_tiposangre.Text = datosgensso.DatGeneralesSSO_tipodesangre.ToString();
                        //txt_telfconvencional.Text = datosgensso.DatGeneralesSSO_telefonoconvencional.ToString();
                        //txt_telfcelular.Text = datosgensso.DatGeneralesSSO_telefonocelular.ToString();
                        //txt_email.Text = datosgensso.DatGeneralesSSO_email.ToString();
                        //txt_lugarnacimiento.Text = datosgensso.DatGeneralesSSO_lugardenacimiento.ToString();
                        //txt_fechanacimiento.Text = per.Per_fechNacimiento.ToString();
                        //txt_edad.Text = per.Per_fechNacimiento.ToString();
                        ////txt_primaria.Text = datosgensso.DatGeneralesSSO_niveleducativo_primaria.ToString();
                        ////txt_secundaria.Text = datosgensso.DatGeneralesSSO_niveleducativo_secundaria.ToString();
                        ////txt_superior.Text = datosgensso.DatGeneralesSSO_niveleducativo_superior.ToString();
                        ////txt_especializacion.Text = datosgensso.DatGeneralesSSO_niveleducativo_especializacion.ToString();
                        ////txt_diploma.Text = datosgensso.DatGeneralesSSO_niveleducativo_diplomado.ToString();
                        ////txt_maestria.Text = datosgensso.DatGeneralesSSO_niveleducativo_maestrias.ToString();
                        ////txt_blanco.Text = datosgensso.DatGeneralesSSO_autoidentificacionetnica_blanco.ToString();
                        ////txt_mestizo.Text = datosgensso.DatGeneralesSSO_autoidentificacionetnica_mestizo.ToString();
                        ////txt_afrodescendiente.Text = datosgensso.DatGeneralesSSO_autoidentificacionetnica_afrodescendiente.ToString();
                        ////txt_indigena.Text = datosgensso.DatGeneralesSSO_autoidentificacionetnica_indigena.ToString();
                        ////txt_montubio.Text = datosgensso.DatGeneralesSSO_autoidentificacionetnica_montubio.ToString();
                        //txt_provincia.Text = datosgensso.DatGeneralesSSO_direcciondomicilio_provincia.ToString();
                        //txt_canton.Text = datosgensso.DatGeneralesSSO_direcciondomicilio_canton.ToString();
                        //txt_canton.Text = datosgensso.DatGeneralesSSO_direcciondomicilio_parroquia.ToString();
                        //txt_barrio.Text = datosgensso.DatGeneralesSSO_direcciondomicilio_barrio.ToString();
                        //txt_callevivienda.Text = datosgensso.DatGeneralesSSO_calleubicadaviviendaynumeracion.ToString();
                        //txt_callesecundaria.Text = datosgensso.DatGeneralesSSO_callesecundaria.ToString();
                        //txt_referenciadomicilio.Text = datosgensso.DatGeneralesSSO_referencia_ubicar_domicilio.ToString();
                        ////txt_norte.Text = datosgensso.DatGeneralesSSO_sectorvive_norte.ToString();
                        ////txt_centro.Text = datosgensso.DatGeneralesSSO_sectorvive_centro.ToString();
                        ////txt_sur.Text = datosgensso.DatGeneralesSSO_sectorvive_sur.ToString();
                        ////txt_otro.Text = datosgensso.DatGeneralesSSO_sectorvive_otro.ToString();
                        //txt_otrosector.Text = datosgensso.DatGeneralesSSO_sectorvive_otroindique.ToString();
                        ////txt_casa.Text = datosgensso.DatGeneralesSSO_tipovivienda_casa.ToString();
                        ////txt_departamento.Text = datosgensso.DatGeneralesSSO_tipovivienda_departamento.ToString();
                        ////txt_otravivienda.Text = datosgensso.DatGeneralesSSO_tipovivienda_otro.ToString();
                        ////txt_siserviciobasico.Text = datosgensso.DatGeneralesSSO_tipovivienda_cuentaserviciosbasicossi.ToString();
                        ////txt_noserviciobasico.Text = datosgensso.DatGeneralesSSO_tipovivienda_cuentaserviciosbasicosno.ToString();
                        //txt_personasvivenconusted.Text = datosgensso.DatGeneralesSSO_cuantaspersonasvivenconusted.ToString();
                        //txt_personasviveneventualconusted.Text = datosgensso.DatGeneralesSSO_cuantaspersonasviveneventualconusted.ToString();
                        //txt_nomapeemergencia.Text = datosgensso.DatGeneralesSSO_personacontactoemergencia_nombresyapellidos.ToString();
                        //txt_parentesco.Text = datosgensso.DatGeneralesSSO_personacontactoemergencia_parentesco.ToString();
                        //txt_telfemergencia.Text = datosgensso.DatGeneralesSSO_personacontactoemergencia_telefono.ToString();
                        //txt_calleprincipalfamiliar.Text = datosgensso.DatGeneralesSSO_personacontactoemergencia_direccion_calleprincipal.ToString();
                        //txt_numdomiciliofamiliar.Text = datosgensso.DatGeneralesSSO_personacontactoemergencia_direccion_numdomicilio.ToString();
                        //txt_callesecundariafamiliar.Text = datosgensso.DatGeneralesSSO_personacontactoemergencia_direccion_callesecundaria.ToString();
                        //txt_referenciadomiciliofamiliar.Text = datosgensso.DatGeneralesSSO_personacontactoemergencia_direccion_referenciaubicardomicilio.ToString();
                        ////txt_siahorro.Text = datosgensso.DatGeneralesSSO_destinadineroahorro_si.ToString();
                        ////txt_noahorro.Text = datosgensso.DatGeneralesSSO_destinadineroahorro_no.ToString();
                        ////txt_sivehiculo.Text = datosgensso.DatGeneralesSSO_vehiculopropio_si.ToString();
                        ////txt_novehiculo.Text = datosgensso.DatGeneralesSSO_vehiculopropio_no.ToString();
                        ////txt_sirecorrido.Text = datosgensso.DatGeneralesSSO_recorridoinstitucional_si.ToString();
                        ////txt_norecorrido.Text = datosgensso.DatGeneralesSSO_recorridoinstitucional_no.ToString();
                        ////txt_noexisterecorrido.Text = datosgensso.DatGeneralesSSO_recorridoinstitucional_noexiste.ToString();
                        //txt_distanciadomicilio.Text = datosgensso.DatGeneralesSSO_distancia_domicilio_trabajo.ToString();

                        ////2. MOSTRAR DATOS SALUD SSO
                        //txt_poseeenfermedad.Text = datosaludsso.SaludSSO_poseeenfermedad.ToString();
                        ////txt_sidiscapacidad.Text = datosaludsso.SaludSSO_discapacidad_si.ToString();
                        ////txt_nodiscapacidad.Text = datosaludsso.SaludSSO_discapacidad_no.ToString();
                        ////txt_tipodiscapacidad.Text = datosaludsso.SaludSSO_discapacidad_tipo.ToString();
                        //txt_porcentajediscapacidad.Text = datosaludsso.SaludSSO_discapacidad_porcentaje.ToString();
                        //txt_numcarnetconadis.Text = datosaludsso.SaludSSO_discapacidad_carnetconadis.ToString();
                        //txt_fechacaducidadcarnet.Text = datosaludsso.SaludSSO_discapacidad_caducidadcarnetconadis.ToString();
                        ////txt_noconyugeembarazada.Text = datosaludsso.SaludSSO_conyugueembarazada_no.ToString();
                        ////txt_simeenceuntroembarazada.Text = datosaludsso.SaludSSO__si_me_encuentro_embarazada.ToString();
                        ////txt_simiconyugeembarazada.Text = datosaludsso.SaludSSO__si_mi_conyugue_esta_embarazada.ToString();
                        //txt_mesgestacion.Text = datosaludsso.SaludSSO__mes_embarazo.ToString();
                        //txt_diasgestacion.Text = datosaludsso.SaludSSO__dias_embarazo.ToString();
                        //txt_fechatentativaparto.Text = datosaludsso.SaludSSO_fecha_tentativa_parto.ToString();
                        ////txt_siperiodolactancia.Text = datosaludsso.SaludSSO_periodo_lactancia_si.ToString();
                        ////txt_noperiodolactancia.Text = datosaludsso.SaludSSO_periodo_lactancia_no.ToString();
                        //txt_fechaculminacionlactancia.Text = datosaludsso.SaludSSO_periodo_lactancia_fechaculminacion.ToString();
                        ////txt_sienfermedadcronica.Text = datosaludsso.SaludSSO_enfermedad_cronica_si.ToString();
                        ////txt_noenfermedadcronica.Text = datosaludsso.SaludSSO_enfermedad_cronica_no.ToString();
                        //txt_cualenfermedadcronica.Text = datosaludsso.SaludSSO_enfermedad_cronica_cual.ToString();
                        //txt_otrasenfermedades.Text = datosaludsso.SaludSSO_enfermedad_cronica_otras.ToString();
                        ////txt_sienfermedadrara.Text = datosaludsso.SaludSSO_enfermedad_rara_si.ToString();
                        ////txt_noenfermedadrara.Text = datosaludsso.SaludSSO_enfermedad_rara_no.ToString();
                        ////txt_cualenfermedadrara.Text = datosaludsso.SaludSSO_enfermedad_rara_cual.ToString();
                        ////txt_sialcohol.Text = datosaludsso.SaludSSO_consume_alcohol_si.ToString();
                        ////txt_noalcohol.Text = datosaludsso.SaludSSO_consume_alcohol_no.ToString();
                        ////txt_cerveza.Text = datosaludsso.SaludSSO_consume_alcohol_tipo_cerveza.ToString();
                        ////txt_ron.Text = datosaludsso.SaludSSO_consume_alcohol_tipo_ron.ToString();
                        ////txt_whisky.Text = datosaludsso.SaludSSO_consume_alcohol_tipo_whisky.ToString();
                        //txt_otroalcohol.Text = datosaludsso.SaludSSO_consume_alcohol_tipo_otro.ToString();
                        //txt_frecuenciaalcohol.Text = datosaludsso.SaludSSO_consume_alcohol_frecuencia_consumo.ToString();
                        //txt_tiempoconsumoalcohol.Text = datosaludsso.SaludSSO_consume_alcohol_tiempo_consumo.ToString();
                        ////txt_sitabaco.Text = datosaludsso.SaludSSO_consume_tabaco_si.ToString();
                        ////txt_notabaco.Text = datosaludsso.SaludSSO_consume_tabaco_no.ToString();
                        //txt_frecuenciatabaco.Text = datosaludsso.SaludSSO_consume_tabaco_frecuencia_consumo.ToString();
                        //txt_cantidadtabaco.Text = datosaludsso.SaludSSO_consume_tabaco_cantidad_consumo.ToString();
                        //txt_tiempoconsumotabaco.Text = datosaludsso.SaludSSO_consume_tabaco_tiempo_consumo.ToString();
                        ////txt_sipsicotropica.Text = datosaludsso.SaludSSO_consume_sustancia_psicotropica_si.ToString();
                        ////txt_nopsicotropica.Text = datosaludsso.SaludSSO_consume_sustancia_psicotropica_no.ToString();
                        //txt_tipopsicotropica.Text = datosaludsso.SaludSSO_consume_sustancia_psicotropica_tipo.ToString();
                        //txt_frecuenciapsicotropica.Text = datosaludsso.SaludSSO_consume_sustancia_psicotropica_frecuencia_consumo.ToString();
                        //txt_factorespsicotropica.Text = datosaludsso.SaludSSO_consume_sustancia_psicotropica_factores_psicosociales.ToString();

                        ////3. MOSTRAR INFORMACION FAMILIAR SSO
                        //txt_nomapeconyuge.Text = datoinfofamsso.InfoFamiliarSSO_nombres_apellidos_conyugue.ToString();
                        //txt_numhijos.Text = datoinfofamsso.InfoFamiliarSSO_numero_hijos.ToString();
                        //txt_numdependientes.Text = datoinfofamsso.InfoFamiliarSSO_numero_dependientes.ToString();
                        //txt_nomapefam1.Text = datoinfofamsso.InfoFamiliarSSO_nombres_apellidos_familiar1.ToString();
                        //txt_fechanacfam1.Text = datoinfofamsso.InfoFamiliarSSO_fecha_nacimiento_familiar1.ToString();
                        //txt_edadfam1.Text = datoinfofamsso.InfoFamiliarSSO_edad_familiar1.ToString();
                        //txt_nomapefam2.Text = datoinfofamsso.InfoFamiliarSSO_nombres_apellidos_familiar2.ToString();
                        //txt_fechanacfam2.Text = datoinfofamsso.InfoFamiliarSSO_fecha_nacimiento_familiar2.ToString();
                        //txt_edadfam2.Text = datoinfofamsso.InfoFamiliarSSO_edad_familiar2.ToString();
                        ////txt_siperdis.Text = datoinfofamsso.InfoFamiliarSSO_nucleofamiliar_persona_discapacidad_si.ToString();
                        ////txt_noperdis.Text = datoinfofamsso.InfoFamiliarSSO_nucleofamiliar_persona_discapacidad_no.ToString();
                        ////txt_sicargodis.Text = datoinfofamsso.InfoFamiliarSSO_acargo_de_persona_discapacidad_si.ToString();
                        ////txt_nocargodis.Text = datoinfofamsso.InfoFamiliarSSO_acargo_de_persona_discapacidad_no.ToString();
                        //txt_nomapefamdis.Text = datoinfofamsso.InfoFamiliarSSO_nombres_apellidos_familiar_discapacidad.ToString();
                        //txt_fechacadis.Text = datoinfofamsso.InfoFamiliarSSO_fecha_caducidad_carnet_familiar_discapacidad.ToString();
                        //txt_tipodis.Text = datoinfofamsso.InfoFamiliarSSO_familiar_discapacidad_tipo.ToString();
                        //txt_porcdis.Text = datoinfofamsso.InfoFamiliarSSO_familiar_discapacidad_porcentaje.ToString();
                        //txt_parendis.Text = datoinfofamsso.InfoFamiliarSSO_familiar_discapacidad_parentesco.ToString();
                        //txt_fechanacdis.Text = datoinfofamsso.InfoFamiliarSSO_familiar_discapacidad_fecha_nacimiento.ToString();
                        ////txt_siMies.Text = datoinfofamsso.InfoFamiliarSSO_registrar_dependencia_familiar_MIES_si.ToString();
                        ////txt_noMies.Text = datoinfofamsso.InfoFamiliarSSO_registrar_dependencia_familiar_MIES_no.ToString();
                        //txt_carnetMies.Text = datoinfofamsso.InfoFamiliarSSO_registrar_dependencia_familiar_MIES_numcarnet.ToString();
                        ////txt_sifamcatas.Text = datoinfofamsso.InfoFamiliarSSO_familiar_enfermedad_catastrofica_rara_si.ToString();
                        ////txt_nofamcatas.Text = datoinfofamsso.InfoFamiliarSSO_familiar_enfermedad_catastrofica_rara_no.ToString();
                        //txt_indicarfamcatas.Text = datoinfofamsso.InfoFamiliarSSO_familiar_enfermedad_catastrofica_rara_parentesco.ToString();
                        ////txt_siacargofamcatas.Text = datoinfofamsso.InfoFamiliarSSO_a_cargo_familiar_enfermedad_catastrofica_rara_si.ToString();
                        ////txt_noacargofamcatas.Text = datoinfofamsso.InfoFamiliarSSO_a_cargo_familiar_enfermedad_catastrofica_rara_no.ToString();
                        //txt_tipoacargofamcatas.Text = datoinfofamsso.InfoFamiliarSSO_a_cargo_familiar_enfermedad_catastrofica_rara_tipoenfermedad.ToString();

                        ////4. MPSTRAR DATOS DE ACTIVIDADES QUE REALIZA EN SU TIEMPO LIBRE SSO
                        ////txt_hogar.Text = datoactiemlibresso.ActReTiemLibreSSO_hogar.ToString();
                        ////txt_paseosfam.Text = datoactiemlibresso.ActReTiemLibreSSO_paseos_familiares.ToString();
                        ////txt_estudios.Text = datoactiemlibresso.ActReTiemLibreSSO_estudios.ToString();
                        ////txt_actartisticas.Text = datoactiemlibresso.ActReTiemLibreSSO_actividades_artisticas.ToString();
                        //txt_otratc.Text = datoactiemlibresso.ActReTiemLibreSSO_otros.ToString();
                        //txt_trabajocomplementario.Text = datoactiemlibresso.ActReTiemLibreSSO_trabajo_complementario.ToString();
                        //txt_detalleact.Text = datoactiemlibresso.ActReTiemLibreSSO_detalle_actividad.ToString();
                        //txt_tiempact.Text = datoactiemlibresso.ActReTiemLibreSSO_tiempo_actividad.ToString();
                        //txt_hacecuantoact.Text = datoactiemlibresso.ActReTiemLibreSSO_hace_cuanto_tiempo_actividad.ToString();
                        ////txt_sideportiva.Text = datoactiemlibresso.ActReTiemLibreSSO_actividad_deportiva_si.ToString();
                        ////txt_nodeportiva.Text = datoactiemlibresso.ActReTiemLibreSSO_actividad_deportiva_no.ToString();
                        //txt_especificaract.Text = datoactiemlibresso.ActReTiemLibreSSO_actividad_deportiva_especificar.ToString();
                        //txt_frecuenciaact.Text = datoactiemlibresso.ActReTiemLibreSSO_actividad_deportiva_frecuencia.ToString();
                        //txt_edadpractica.Text = datoactiemlibresso.ActReTiemLibreSSO_actividad_deportiva_edad.ToString();
                        ////txt_silesion.Text = datoactiemlibresso.ActReTiemLibreSSO_lesion_si.ToString();
                        ////txt_nolesion.Text = datoactiemlibresso.ActReTiemLibreSSO_lesion_no.ToString();
                        //txt_tipolesion.Text = datoactiemlibresso.ActReTiemLibreSSO_lesion_tipo.ToString();
                        //txt_edadlesion.Text = datoactiemlibresso.ActReTiemLibreSSO_lesion_edad.ToString();
                        ////txt_sitratamiento.Text = datoactiemlibresso.ActReTiemLibreSSO_lesion_tratamiento_si.ToString();
                        ////txt_notratamiento.Text = datoactiemlibresso.ActReTiemLibreSSO_lesion_tratamiento_no.ToString();

                        ////5. MOSTRAR DATOS DE INFORMACION ESTABILIDAD FAMILIAR SSO
                        ////txt_nuclear.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_tipo_familia_nuclear.ToString();
                        ////txt_ampliada.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_tipo_familia_ampliada.ToString();
                        ////txt_monoparental.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_tipo_familia_monoparental.ToString();
                        ////txt_padremadresoltero.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_tipo_familia_padremadresoltero.ToString();
                        ////txt_vivesolo.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_tipo_familia_vive_solo.ToString();
                        ////txt_viveamigos.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_tipo_familia_vive_amigos.ToString();
                        ////txt_familiasinhijos.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_tipo_familia_sin_hijos.ToString();
                        ////txt_familiarmuybueno.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_evaluacion_relacion_familiar_muybueno.ToString();
                        ////txt_familiarbueno.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_evaluacion_relacion_familiar_bueno.ToString();
                        ////txt_familiaregular.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_evaluacion_relacion_familiar_regular.ToString();
                        ////txt_familiaregular.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_evaluacion_relacion_familiar_mala.ToString();
                        //txt_familiarporque.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_evaluacion_relacion_familiar_porque.ToString();
                        ////txt_parejamuybueno.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_evaluacion_relacion_pareja_muybueno.ToString();
                        ////txt_parejabueno.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_evaluacion_relacion_pareja_bueno.ToString();
                        ////txt_parejaregular.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_evaluacion_relacion_pareja_regular.ToString();
                        ////txt_parejaregular.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_evaluacion_relacion_pareja_mala.ToString();
                        //txt_parejaporque.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_evaluacion_relacion_pareja_porque.ToString();
                        ////txt_hijosmuybueno.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_evaluacion_relacion_hijos_muybueno.ToString();
                        ////txt_hijosbueno.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_evaluacion_relacion_hijos_bueno.ToString();
                        ////txt_hijosregular.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_evaluacion_relacion_hijos_regular.ToString();
                        ////txt_hijosregular.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_evaluacion_relacion_hijos_mala.ToString();
                        //txt_hijosporque.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_evaluacion_relacion_hijos_porque.ToString();
                        ////txt_antpenales.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_problemas_familiares_antpenales.ToString();
                        ////txt_economicos.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_problemas_familiares_economicos.ToString();
                        ////txt_comunicacion.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_problemas_familiares_comunicacion.ToString();
                        ////txt_conyugales.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_problemas_familiares_conyugales.ToString();
                        ////txt_crianzahijos.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_problemas_familiares_crianza_hijos.ToString();
                        ////txt_adicciones.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_problemas_familiares_adicciones.ToString();
                        ////txt_fisica.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_problemas_familiares_violencia_fisica.ToString();
                        ////txt_psicologica.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_problemas_familiares_violencia_psicologica.ToString();
                        ////txt_verbal.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_problemas_familiares_violencia_verbal.ToString();
                        ////txt_sexual.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_problemas_familiares_violencia_sexual.ToString();
                        //txt_observaciones.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_problemas_familiares_observaciones.ToString();
                        ////txt_rolsi.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_miembro_familiar_rol_si.ToString();
                        ////txt_rolno.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_miembro_familiar_rol_no.ToString();
                        ////txt_saludmuybuena.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_salud_familia_muybueno.ToString();
                        ////txt_saludbuena.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_salud_familia_bueno.ToString();
                        ////txt_saludregular.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_salud_familia_regular.ToString();
                        ////txt_saludmala.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_salud_familia_mala.ToString();
                        //txt_saludporque.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_salud_familia_porque.ToString();
                        ////txt_funcional.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_familia_funcional.ToString();
                        ////txt_disfuncional.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_familia_disfuncional.ToString();
                        //txt_observacion.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_familia_observaciones.ToString();
                        //txt_adicional.Text = datoinfoestafamisso.InfoEstabFamiliarSSO_informacion_adicional.ToString();
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Error')", true);
                    }

                }
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Guardados Incompletos')", true);
            }
        }

        protected void btn_guardarsso_Click(object sender, EventArgs e)
        {

        }

        protected void btn_cancelarsso_Click(object sender, EventArgs e)
        {

        }
    }
}