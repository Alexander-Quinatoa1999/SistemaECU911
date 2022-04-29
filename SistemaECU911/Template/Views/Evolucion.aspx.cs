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

namespace SistemaECU911.Template.Views
{
    public partial class Evolucion : System.Web.UI.Page
    {

        DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        private Tbl_Personas per = new Tbl_Personas();

        private Tbl_Evolucion evo = new Tbl_Evolucion();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["cod"] != null)
                {
                    int codigo = Convert.ToInt32(Request["cod"]);
                    evo = CN_Evolucion.ObtenerEvolucionPorId(codigo);
                    int personasid = Convert.ToInt32(evo.Per_id.ToString());
                    per = CN_HistorialMedico.ObtenerPersonasxId(personasid);

                    btn_guardar.Text = "Actualizar";

                    if (per != null)
                    {
                        //A
                        txt_priNombre.Text = per.Per_priNombre.ToString();
                        txt_segNombre.Text = per.Per_segNombre.ToString();
                        txt_priApellido.Text = per.Per_priApellido.ToString();
                        txt_segApellido.Text = per.Per_segApellido.ToString();
                        txt_sexo.Text = per.Per_genero.ToString();
                        txt_numHClinica.Text = per.Per_cedula.ToString();
                        txt_puestoTrabajo.Text = per.Per_puestoTrabajo.ToString();

                        if (evo != null)
                        {
                            //A
                            txt_numArchivo.Text = evo.evo_numArchivo.ToString();

                            //B
                            txt_fecha1.Text = evo.evo_fecha1.ToString();
                            txt_hora1.Text = evo.evo_hora1.ToString();
                            txt_notas1.Text = evo.evo_notasEvolucion1.ToString();
                            txt_fecha2.Text = evo.evo_fecha2.ToString();
                            txt_hora2.Text = evo.evo_hora2.ToString();
                            txt_notas2.Text = evo.evo_notasEvolucion2.ToString();
                            txt_fecha3.Text = evo.evo_fecha3.ToString();
                            txt_hora3.Text = evo.evo_hora3.ToString();
                            txt_notas3.Text = evo.evo_notasEvolucion3.ToString();
                            txt_fecha4.Text = evo.evo_fecha4.ToString();
                            txt_hora4.Text = evo.evo_hora4.ToString();
                            txt_notas4.Text = evo.evo_notasEvolucion4.ToString();
                            txt_fecha5.Text = evo.evo_fecha5.ToString();
                            txt_hora5.Text = evo.evo_hora5.ToString();
                            txt_notas5.Text = evo.evo_notasEvolucion5.ToString();
                            txt_fecha6.Text = evo.evo_fecha6.ToString();
                            txt_hora6.Text = evo.evo_hora6.ToString();
                            txt_notas6.Text = evo.evo_notasEvolucion6.ToString();
                            txt_fecha7.Text = evo.evo_fecha7.ToString();
                            txt_hora7.Text = evo.evo_hora7.ToString();
                            txt_notas7.Text = evo.evo_notasEvolucion7.ToString();
                            txt_fecha8.Text = evo.evo_fecha8.ToString();
                            txt_hora8.Text = evo.evo_hora8.ToString();
                            txt_notas8.Text = evo.evo_notasEvolucion8.ToString();
                            txt_fecha9.Text = evo.evo_fecha9.ToString();
                            txt_hora9.Text = evo.evo_hora9.ToString();
                            txt_notas9.Text = evo.evo_notasEvolucion9.ToString();
                            txt_fecha10.Text = evo.evo_fecha10.ToString();
                            txt_hora10.Text = evo.evo_hora10.ToString();
                            txt_notas10.Text = evo.evo_notasEvolucion10.ToString();
                            txt_fecha11.Text = evo.evo_fecha11.ToString();
                            txt_hora11.Text = evo.evo_hora11.ToString();
                            txt_notas11.Text = evo.evo_notasEvolucion11.ToString();
                            txt_fecha12.Text = evo.evo_fecha12.ToString();
                            txt_hora12.Text = evo.evo_hora12.ToString();
                            txt_notas12.Text = evo.evo_notasEvolucion12.ToString();
                            txt_fecha13.Text = evo.evo_fecha13.ToString();
                            txt_hora13.Text = evo.evo_hora13.ToString();
                            txt_notas13.Text = evo.evo_notasEvolucion13.ToString();
                            txt_fecha14.Text = evo.evo_fecha14.ToString();
                            txt_hora14.Text = evo.evo_hora14.ToString();
                            txt_notas14.Text = evo.evo_notasEvolucion14.ToString();
                            txt_fecha15.Text = evo.evo_fecha15.ToString();
                            txt_hora15.Text = evo.evo_hora15.ToString();
                            txt_notas15.Text = evo.evo_notasEvolucion15.ToString();

                            //C
                            txt_farmacoterapia1.Text = evo.evo_farmacoIndicaciones1.ToString();
                            txt_administracion1.Text = evo.evo_adminisFarmacos1.ToString();
                            txt_farmacoterapia2.Text = evo.evo_farmacoIndicaciones2.ToString();
                            txt_administracion2.Text = evo.evo_adminisFarmacos2.ToString();
                            txt_farmacoterapia3.Text = evo.evo_farmacoIndicaciones3.ToString();
                            txt_administracion3.Text = evo.evo_adminisFarmacos3.ToString();
                            txt_farmacoterapia4.Text = evo.evo_farmacoIndicaciones4.ToString();
                            txt_administracion4.Text = evo.evo_adminisFarmacos4.ToString();
                            txt_farmacoterapia5.Text = evo.evo_farmacoIndicaciones5.ToString();
                            txt_administracion5.Text = evo.evo_adminisFarmacos5.ToString();
                            txt_farmacoterapia6.Text = evo.evo_farmacoIndicaciones6.ToString();
                            txt_administracion6.Text = evo.evo_adminisFarmacos6.ToString();
                            txt_farmacoterapia7.Text = evo.evo_farmacoIndicaciones7.ToString();
                            txt_administracion7.Text = evo.evo_adminisFarmacos7.ToString();
                            txt_farmacoterapia8.Text = evo.evo_farmacoIndicaciones8.ToString();
                            txt_administracion8.Text = evo.evo_adminisFarmacos8.ToString();
                            txt_farmacoterapia9.Text = evo.evo_farmacoIndicaciones9.ToString();
                            txt_administracion9.Text = evo.evo_adminisFarmacos9.ToString();
                            txt_farmacoterapia10.Text = evo.evo_farmacoIndicaciones10.ToString();
                            txt_administracion10.Text = evo.evo_adminisFarmacos10.ToString();
                            txt_farmacoterapia11.Text = evo.evo_farmacoIndicaciones11.ToString();
                            txt_administracion11.Text = evo.evo_adminisFarmacos11.ToString();
                            txt_farmacoterapia12.Text = evo.evo_farmacoIndicaciones12.ToString();
                            txt_administracion12.Text = evo.evo_adminisFarmacos12.ToString();
                            txt_farmacoterapia13.Text = evo.evo_farmacoIndicaciones13.ToString();
                            txt_administracion13.Text = evo.evo_adminisFarmacos13.ToString();
                            txt_farmacoterapia14.Text = evo.evo_farmacoIndicaciones14.ToString();
                            txt_administracion14.Text = evo.evo_adminisFarmacos14.ToString();
                            txt_farmacoterapia15.Text = evo.evo_farmacoIndicaciones15.ToString();
                            txt_administracion15.Text = evo.evo_adminisFarmacos15.ToString();
                        }
                    }
                }
            }
        }

        //Metodo obtener cedula por numero de HC EVOLUCION
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

        protected void txt_numHClinica_TextChanged(object sender, EventArgs e)
        {
            ObtenerCedula();
        }

        private void ObtenerCedula()
        {
            string cedula = txt_numHClinica.Text;

            var lista = from c in dc.Tbl_Personas
                        where c.Per_cedula == cedula
                        select c;

            foreach (var item in lista)
            {
                string priNombre = item.Per_priNombre;
                txt_priNombre.Text = priNombre;

                string segNombre = item.Per_segNombre;
                txt_segNombre.Text = segNombre;

                string priApellido = item.Per_priApellido;
                txt_priApellido.Text = priApellido;

                string segApellido = item.Per_segApellido;
                txt_segApellido.Text = segApellido;

                string sexo = item.Per_genero;
                txt_sexo.Text = sexo;

                string puestoTrabajo = item.Per_puestoTrabajo;
                txt_puestoTrabajo.Text = puestoTrabajo;

            }
        }

        private void GuardarEvolucion()
        {
            try
            {
                per = CN_HistorialMedico.ObtenerIdPersonasxCedula(Convert.ToInt32(txt_numHClinica.Text));

                int perso = Convert.ToInt32(per.Per_id.ToString());

                evo = new Tbl_Evolucion 
                {
                    //A Captura de datos Establecimiento
                    evo_numArchivo = txt_numArchivo.Text,

                    //B. Captura de datos Evolucion
                    evo_fecha1 = Convert.ToDateTime(txt_fecha1.Text),
                    evo_hora1 = Convert.ToDateTime(txt_hora1.Text),
                    evo_notasEvolucion1 = txt_notas1.Text,
                    evo_fecha2 = Convert.ToDateTime(txt_fecha2.Text),
                    evo_hora2 = Convert.ToDateTime(txt_hora2.Text),
                    evo_notasEvolucion2 = txt_notas2.Text,
                    evo_fecha3 = Convert.ToDateTime(txt_fecha3.Text),
                    evo_hora3 = Convert.ToDateTime(txt_hora3.Text),
                    evo_notasEvolucion3 = txt_notas3.Text,
                    evo_fecha4 = Convert.ToDateTime(txt_fecha4.Text),
                    evo_hora4 = Convert.ToDateTime(txt_hora4.Text),
                    evo_notasEvolucion4 = txt_notas4.Text,
                    evo_fecha5 = Convert.ToDateTime(txt_fecha5.Text),
                    evo_hora5 = Convert.ToDateTime(txt_hora5.Text),
                    evo_notasEvolucion5 = txt_notas5.Text,
                    evo_fecha6 = Convert.ToDateTime(txt_fecha6.Text),
                    evo_hora6 = Convert.ToDateTime(txt_hora6.Text),
                    evo_notasEvolucion6 = txt_notas6.Text,
                    evo_fecha7 = Convert.ToDateTime(txt_fecha7.Text),
                    evo_hora7 = Convert.ToDateTime(txt_hora7.Text),
                    evo_notasEvolucion7 = txt_notas7.Text,
                    evo_fecha8 = Convert.ToDateTime(txt_fecha8.Text),
                    evo_hora8 = Convert.ToDateTime(txt_hora8.Text),
                    evo_notasEvolucion8 = txt_notas8.Text,
                    evo_fecha9 = Convert.ToDateTime(txt_fecha9.Text),
                    evo_hora9 = Convert.ToDateTime(txt_hora9.Text),
                    evo_notasEvolucion9 = txt_notas9.Text,
                    evo_fecha10 = Convert.ToDateTime(txt_fecha10.Text),
                    evo_hora10 = Convert.ToDateTime(txt_hora10.Text),
                    evo_notasEvolucion10 = txt_notas10.Text,
                    evo_fecha11 = Convert.ToDateTime(txt_fecha11.Text),
                    evo_hora11 = Convert.ToDateTime(txt_hora11.Text),
                    evo_notasEvolucion11 = txt_notas11.Text,
                    evo_fecha12 = Convert.ToDateTime(txt_fecha12.Text),
                    evo_hora12 = Convert.ToDateTime(txt_hora12.Text),
                    evo_notasEvolucion12 = txt_notas12.Text,
                    evo_fecha13 = Convert.ToDateTime(txt_fecha13.Text),
                    evo_hora13 = Convert.ToDateTime(txt_hora13.Text),
                    evo_notasEvolucion13 = txt_notas13.Text,
                    evo_fecha14 = Convert.ToDateTime(txt_fecha14.Text),
                    evo_hora14 = Convert.ToDateTime(txt_hora14.Text),
                    evo_notasEvolucion14 = txt_notas14.Text,
                    evo_fecha15 = Convert.ToDateTime(txt_fecha15.Text),
                    evo_hora15 = Convert.ToDateTime(txt_hora15.Text),
                    evo_notasEvolucion15 = txt_notas15.Text,

                    //C. Captura de Datos Prescripcion
                    evo_farmacoIndicaciones1 = txt_farmacoterapia1.Text,
                    evo_adminisFarmacos1 = txt_administracion1.Text,
                    evo_farmacoIndicaciones2 = txt_farmacoterapia2.Text,
                    evo_adminisFarmacos2 = txt_administracion2.Text,
                    evo_farmacoIndicaciones3 = txt_farmacoterapia3.Text,
                    evo_adminisFarmacos3 = txt_administracion3.Text,
                    evo_farmacoIndicaciones4 = txt_farmacoterapia4.Text,
                    evo_adminisFarmacos4 = txt_administracion4.Text,
                    evo_farmacoIndicaciones5 = txt_farmacoterapia5.Text,
                    evo_adminisFarmacos5 = txt_administracion5.Text,
                    evo_farmacoIndicaciones6 = txt_farmacoterapia6.Text,
                    evo_adminisFarmacos6 = txt_administracion6.Text,
                    evo_farmacoIndicaciones7 = txt_farmacoterapia7.Text,
                    evo_adminisFarmacos7 = txt_administracion7.Text,
                    evo_farmacoIndicaciones8 = txt_farmacoterapia8.Text,
                    evo_adminisFarmacos8 = txt_administracion8.Text,
                    evo_farmacoIndicaciones9 = txt_farmacoterapia9.Text,
                    evo_adminisFarmacos9 = txt_administracion9.Text,
                    evo_farmacoIndicaciones10 = txt_farmacoterapia10.Text,
                    evo_adminisFarmacos10 = txt_administracion10.Text,
                    evo_farmacoIndicaciones11 = txt_farmacoterapia11.Text,
                    evo_adminisFarmacos11 = txt_administracion11.Text,
                    evo_farmacoIndicaciones12 = txt_farmacoterapia12.Text,
                    evo_adminisFarmacos12 = txt_administracion12.Text,
                    evo_farmacoIndicaciones13 = txt_farmacoterapia13.Text,
                    evo_adminisFarmacos13 = txt_administracion13.Text,
                    evo_farmacoIndicaciones14 = txt_farmacoterapia14.Text,
                    evo_adminisFarmacos14 = txt_administracion14.Text,
                    evo_farmacoIndicaciones15 = txt_farmacoterapia15.Text,
                    evo_adminisFarmacos15 = txt_administracion15.Text,
                    Per_id = perso
                };

                CN_Evolucion.GuardarEvolucion(evo);

                //Mensaje de confirmacion
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Guardados Exitosamente')", true);

                Response.Redirect("~/Template/Views/PacientesEvolucion.aspx");

            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Guardados')", true);
            }
        }

        private void ModificarEvolucion(Tbl_Evolucion evo)
        {
            try
            {
                //A Captura de datos Establecimiento
                evo.evo_numArchivo = txt_numArchivo.Text;

                //B. Captura de datos Evolucion
                evo.evo_fecha1 = Convert.ToDateTime(txt_fecha1.Text);
                evo.evo_hora1 = Convert.ToDateTime(txt_hora1.Text);
                evo.evo_notasEvolucion1 = txt_notas1.Text;
                evo.evo_fecha2 = Convert.ToDateTime(txt_fecha2.Text);
                evo.evo_hora2 = Convert.ToDateTime(txt_hora2.Text);
                evo.evo_notasEvolucion2 = txt_notas2.Text;
                evo.evo_fecha3 = Convert.ToDateTime(txt_fecha3.Text);
                evo.evo_hora3 = Convert.ToDateTime(txt_hora3.Text);
                evo.evo_notasEvolucion3 = txt_notas3.Text;
                evo.evo_fecha4 = Convert.ToDateTime(txt_fecha4.Text);
                evo.evo_hora4 = Convert.ToDateTime(txt_hora4.Text);
                evo.evo_notasEvolucion4 = txt_notas4.Text;
                evo.evo_fecha5 = Convert.ToDateTime(txt_fecha5.Text);
                evo.evo_hora5 = Convert.ToDateTime(txt_hora5.Text);
                evo.evo_notasEvolucion5 = txt_notas5.Text;
                evo.evo_fecha6 = Convert.ToDateTime(txt_fecha6.Text);
                evo.evo_hora6 = Convert.ToDateTime(txt_hora6.Text);
                evo.evo_notasEvolucion6 = txt_notas6.Text;
                evo.evo_fecha7 = Convert.ToDateTime(txt_fecha7.Text);
                evo.evo_hora7 = Convert.ToDateTime(txt_hora7.Text);
                evo.evo_notasEvolucion7 = txt_notas7.Text;
                evo.evo_fecha8 = Convert.ToDateTime(txt_fecha8.Text);
                evo.evo_hora8 = Convert.ToDateTime(txt_hora8.Text);
                evo.evo_notasEvolucion8 = txt_notas8.Text;
                evo.evo_fecha9 = Convert.ToDateTime(txt_fecha9.Text);
                evo.evo_hora9 = Convert.ToDateTime(txt_hora9.Text);
                evo.evo_notasEvolucion9 = txt_notas9.Text;
                evo.evo_fecha10 = Convert.ToDateTime(txt_fecha10.Text);
                evo.evo_hora10 = Convert.ToDateTime(txt_hora10.Text);
                evo.evo_notasEvolucion10 = txt_notas10.Text;
                evo.evo_fecha11 = Convert.ToDateTime(txt_fecha11.Text);
                evo.evo_hora11 = Convert.ToDateTime(txt_hora11.Text);
                evo.evo_notasEvolucion11 = txt_notas11.Text;
                evo.evo_fecha12 = Convert.ToDateTime(txt_fecha12.Text);
                evo.evo_hora12 = Convert.ToDateTime(txt_hora12.Text);
                evo.evo_notasEvolucion12 = txt_notas12.Text;
                evo.evo_fecha13 = Convert.ToDateTime(txt_fecha13.Text);
                evo.evo_hora13 = Convert.ToDateTime(txt_hora13.Text);
                evo.evo_notasEvolucion13 = txt_notas13.Text;
                evo.evo_fecha14 = Convert.ToDateTime(txt_fecha14.Text);
                evo.evo_hora14 = Convert.ToDateTime(txt_hora14.Text);
                evo.evo_notasEvolucion14 = txt_notas14.Text;
                evo.evo_fecha15 = Convert.ToDateTime(txt_fecha15.Text);
                evo.evo_hora15 = Convert.ToDateTime(txt_hora15.Text);
                evo.evo_notasEvolucion15 = txt_notas15.Text;

                //C. Captura de Datos Prescripcion
                evo.evo_farmacoIndicaciones1 = txt_farmacoterapia1.Text;
                evo.evo_adminisFarmacos1 = txt_administracion1.Text;
                evo.evo_farmacoIndicaciones2 = txt_farmacoterapia2.Text;
                evo.evo_adminisFarmacos2 = txt_administracion2.Text;
                evo.evo_farmacoIndicaciones3 = txt_farmacoterapia3.Text;
                evo.evo_adminisFarmacos3 = txt_administracion3.Text;
                evo.evo_farmacoIndicaciones4 = txt_farmacoterapia4.Text;
                evo.evo_adminisFarmacos4 = txt_administracion4.Text;
                evo.evo_farmacoIndicaciones5 = txt_farmacoterapia5.Text;
                evo.evo_adminisFarmacos5 = txt_administracion5.Text;
                evo.evo_farmacoIndicaciones6 = txt_farmacoterapia6.Text;
                evo.evo_adminisFarmacos6 = txt_administracion6.Text;
                evo.evo_farmacoIndicaciones7 = txt_farmacoterapia7.Text;
                evo.evo_adminisFarmacos7 = txt_administracion7.Text;
                evo.evo_farmacoIndicaciones8 = txt_farmacoterapia8.Text;
                evo.evo_adminisFarmacos8 = txt_administracion8.Text;
                evo.evo_farmacoIndicaciones9 = txt_farmacoterapia9.Text;
                evo.evo_adminisFarmacos9 = txt_administracion9.Text;
                evo.evo_farmacoIndicaciones10 = txt_farmacoterapia10.Text;
                evo.evo_adminisFarmacos10 = txt_administracion10.Text;
                evo.evo_farmacoIndicaciones11 = txt_farmacoterapia11.Text;
                evo.evo_adminisFarmacos11 = txt_administracion11.Text;
                evo.evo_farmacoIndicaciones12 = txt_farmacoterapia12.Text;
                evo.evo_adminisFarmacos12 = txt_administracion12.Text;
                evo.evo_farmacoIndicaciones13 = txt_farmacoterapia13.Text;
                evo.evo_adminisFarmacos13 = txt_administracion13.Text;
                evo.evo_farmacoIndicaciones14 = txt_farmacoterapia14.Text;
                evo.evo_adminisFarmacos14 = txt_administracion14.Text;
                evo.evo_farmacoIndicaciones15 = txt_farmacoterapia15.Text;
                evo.evo_adminisFarmacos15 = txt_administracion15.Text;

                CN_Evolucion.ModificarEvolucion(evo);

                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Modificados Exitosamente')", true);
                Response.Redirect("~/Template/Views/PacientesEvolucion.aspx");
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Modificados')", true);
            }
        }

        private void guardar_modificar_datos(int evolucion)
        {
            if (evolucion == 0 )
            {
                GuardarEvolucion();
            }
            else
            {
                evo = CN_Evolucion.ObtenerEvolucionPorId(evolucion);

                if (evo != null)
                {
                    ModificarEvolucion(evo);
                }

            }
        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            guardar_modificar_datos(Convert.ToInt32(Request["cod"]));
        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/Views/Inicio.aspx");
        }
    }
}