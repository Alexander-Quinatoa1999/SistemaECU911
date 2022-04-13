using CapaDatos;
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

namespace SistemaECU911.Template.Views
{
    public partial class Inmunizaciones : System.Web.UI.Page
    {
        DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        //Objeto de la tabla personas
        private Tbl_Personas per = new Tbl_Personas();

        //Objeto de la tabla inmunizaciones
        private Tbl_Inmunizaciones inmu = new Tbl_Inmunizaciones();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["cod"] != null)
                {
                    int codigo = Convert.ToInt32(Request["cod"]);
                    per = CN_HistorialMedico.ObtenerPersonasxId(codigo);
                    inmu = CN_Inmunizaciones.ObtenerInmunizacionesPer(codigo);
                    btn_guardar.Text = "Actualizar";

                    if (per != null)
                    {
                        //A
                        txt_priNombre.Text = per.Per_priNombre.ToString();
                        txt_segNombre.Text = per.Per_segNombre.ToString();
                        txt_priApellido.Text = per.Per_priApellido.ToString();
                        txt_segApellido.Text = per.Per_segApellido.ToString();
                        txt_sexo.Text = per.Per_genero.ToString();
                        txt_numHClinica.Text = per.Per_Cedula.ToString();

                        if (inmu != null)
                        {
                            //B
                            txt_fechatetanos1.Text = inmu.inmu_fechaTetanos1.ToString();
                            txt_loteTetanos1.Text = inmu.inmu_loteTetanos1.ToString();
                            txt_esqueCompleTetanos1.Text = inmu.inmu_esqueCompleTetanos1.ToString();
                            txt_nomCompleResponVacuTetanos1.Text = inmu.inmu_nomCompleResponVacuTetanos1.ToString();
                            txt_estaSaludColocoVacuTetanos1.Text = inmu.inmu_estaSaludColocoVacuTetanos1.ToString();
                            txt_observaTetanos1.Text = inmu.inmu_observaTetanos1.ToString();
                            txt_fechatetanos2.Text = inmu.inmu_fechaTetanos2.ToString();
                            txt_loteTetanos2.Text = inmu.inmu_loteTetanos2.ToString();
                            txt_esqueCompleTetanos2.Text = inmu.inmu_esqueCompleTetanos2.ToString();
                            txt_nomCompleResponVacuTetanos2.Text = inmu.inmu_nomCompleResponVacuTetanos2.ToString();
                            txt_estaSaludColocoVacuTetanos2.Text = inmu.inmu_estaSaludColocoVacuTetanos2.ToString();
                            txt_observaTetanos2.Text = inmu.inmu_observaTetanos2.ToString();
                            txt_fechatetanos3.Text = inmu.inmu_fechaTetanos3.ToString();
                            txt_loteTetanos3.Text = inmu.inmu_loteTetanos3.ToString();
                            txt_esqueCompleTetanos3.Text = inmu.inmu_esqueCompleTetanos3.ToString();
                            txt_nomCompleResponVacuTetanos3.Text = inmu.inmu_nomCompleResponVacuTetanos3.ToString();
                            txt_estaSaludColocoVacuTetanos3.Text = inmu.inmu_estaSaludColocoVacuTetanos3.ToString();
                            txt_observaTetanos3.Text = inmu.inmu_observaTetanos3.ToString();
                            txt_fechatetanos4.Text = inmu.inmu_fechaTetanos4.ToString();
                            txt_loteTetanos4.Text = inmu.inmu_loteTetanos4.ToString();
                            txt_esqueCompleTetanos4.Text = inmu.inmu_esqueCompleTetanos4.ToString();
                            txt_nomCompleResponVacuTetanos4.Text = inmu.inmu_nomCompleResponVacuTetanos4.ToString();
                            txt_estaSaludColocoVacuTetanos4.Text = inmu.inmu_estaSaludColocoVacuTetanos4.ToString();
                            txt_observaTetanos4.Text = inmu.inmu_observaTetanos4.ToString();
                            txt_fechatetanos5.Text = inmu.inmu_fechaTetanos5.ToString();
                            txt_loteTetanos5.Text = inmu.inmu_loteTetanos5.ToString();
                            txt_esqueCompleTetanos5.Text = inmu.inmu_esqueCompleTetanos5.ToString();
                            txt_nomCompleResponVacuTetanos5.Text = inmu.inmu_nomCompleResponVacuTetanos5.ToString();
                            txt_estaSaludColocoVacuTetanos5.Text = inmu.inmu_estaSaludColocoVacuTetanos5.ToString();
                            txt_observaTetanos5.Text = inmu.inmu_observaTetanos5.ToString();

                            txt_fechaHepatitisA1.Text = inmu.inmu_fechaHepatitisA1.ToString();
                            txt_loteHepatitisA1.Text = inmu.inmu_loteHepatitisA1.ToString();
                            txt_esqueCompleHepatitisA1.Text = inmu.inmu_esqueCompleHepatitisA1.ToString();
                            txt_nomCompleResponVacuHepatitisA1.Text = inmu.inmu_nomCompleResponVacuHepatitisA1.ToString();
                            txt_estaSaludColocoVaciHepatitisA1.Text = inmu.inmu_estaSaludColocoVaciHepatitisA1.ToString();
                            txt_observaHepatitisA1.Text = inmu.inmu_observaHepatitisA1.ToString();
                            txt_fechaHepatitisA2.Text = inmu.inmu_fechaHepatitisA2.ToString();
                            txt_loteHepatitisA2.Text = inmu.inmu_loteHepatitisA2.ToString();
                            txt_esqueCompleHepatitisA2.Text = inmu.inmu_esqueCompleHepatitisA2.ToString();
                            txt_nomCompleResponVacuHepatitisA2.Text = inmu.inmu_nomCompleResponVacuHepatitisA2.ToString();
                            txt_estaSaludColocoVaciHepatitisA2.Text = inmu.inmu_estaSaludColocoVaciHepatitisA2.ToString();
                            txt_observaHepatitisA2.Text = inmu.inmu_observaHepatitisA2.ToString();
                            txt_fechaHepatitisA3.Text = inmu.inmu_fechaHepatitisA3.ToString();
                            txt_loteHepatitisA3.Text = inmu.inmu_loteHepatitisA3.ToString();
                            txt_esqueCompleHepatitisA3.Text = inmu.inmu_esqueCompleHepatitisA3.ToString();
                            txt_nomCompleResponVacuHepatitisA3.Text = inmu.inmu_nomCompleResponVacuHepatitisA3.ToString();
                            txt_estaSaludColocoVaciHepatitisA3.Text = inmu.inmu_estaSaludColocoVaciHepatitisA3.ToString();
                            txt_observaHepatitisA3.Text = inmu.inmu_observaHepatitisA3.ToString();

                            txt_fechaHepatitisB1.Text = inmu.inmu_fechaHepatitisB1.ToString();
                            txt_loteHepatitisB1.Text = inmu.inmu_loteHepatitisB1.ToString();
                            txt_esqueCompleHepatitisB1.Text = inmu.inmu_esqueCompleHepatitisB1.ToString();
                            txt_nomCompleResponVacuHepatitisB1.Text = inmu.inmu_nomCompleResponVacuHepatitisB1.ToString();
                            txt_estaSaludColocoVaciHepatitisB1.Text = inmu.inmu_estaSaludColocoVaciHepatitisB1.ToString();
                            txt_observaHepatitisB1.Text = inmu.inmu_observaHepatitisB1.ToString();
                            txt_fechaHepatitisB2.Text = inmu.inmu_fechaHepatitisB2.ToString();
                            txt_loteHepatitisB2.Text = inmu.inmu_loteHepatitisB2.ToString();
                            txt_esqueCompleHepatitisB2.Text = inmu.inmu_esqueCompleHepatitisB2.ToString();
                            txt_nomCompleResponVacuHepatitisB2.Text = inmu.inmu_nomCompleResponVacuHepatitisB2.ToString();
                            txt_estaSaludColocoVaciHepatitisB2.Text = inmu.inmu_estaSaludColocoVaciHepatitisB2.ToString();
                            txt_observaHepatitisB2.Text = inmu.inmu_observaHepatitisB2.ToString();
                            txt_fechaHepatitisB3.Text = inmu.inmu_fechaHepatitisB3.ToString();
                            txt_loteHepatitisB3.Text = inmu.inmu_loteHepatitisB3.ToString();
                            txt_esqueCompleHepatitisB3.Text = inmu.inmu_esqueCompleHepatitisB3.ToString();
                            txt_nomCompleResponVacuHepatitisB3.Text = inmu.inmu_nomCompleResponVacuHepatitisB3.ToString();
                            txt_estaSaludColocoVaciHepatitisB3.Text = inmu.inmu_estaSaludColocoVaciHepatitisB3.ToString();
                            txt_observaHepatitisB3.Text = inmu.inmu_observaHepatitisB3.ToString();

                            txt_fechaInfluenza.Text = inmu.inmu_fechaInfluenza.ToString();
                            txt_loteInfluenza.Text = inmu.inmu_loteInfluenza.ToString();
                            txt_esqueCompleInfluenza.Text = inmu.inmu_esqueCompleInfluenza.ToString();
                            txt_nomCompleResponVacuInfluenza.Text = inmu.inmu_nomCompleResponVacuInfluenza.ToString();
                            txt_estaSaludColocoVacuInfluenza.Text = inmu.inmu_estaSaludColocoVacuInfluenza.ToString();
                            txt_observaInfluenza.Text = inmu.inmu_observaInfluenza.ToString();

                            txt_fechaFiebreAmarilla.Text = inmu.inmu_fechaFiebreAmarilla.ToString();
                            txt_loteFiebreAmarilla.Text = inmu.inmu_loteFiebreAmarilla.ToString();
                            txt_esqueCompleFiebreAmarilla.Text = inmu.inmu_esqueCompleFiebreAmarilla.ToString();
                            txt_nomCompleResponVacuFiebreAmarilla.Text = inmu.inmu_nomCompleResponVacuFiebreAmarilla.ToString();
                            txt_estaSaludColocoVacuFiebreAmarilla.Text = inmu.inmu_estaSaludColocoVacuFiebreAmarilla.ToString();
                            txt_observaFiebreAmarilla.Text = inmu.inmu_observaFiebreAmarilla.ToString();

                            txt_fechaSarampion1.Text = inmu.inmu_fechaSarampion1.ToString();
                            txt_loteSarampion1.Text = inmu.inmu_loteSarampion1.ToString();
                            txt_esqueCompleSarampion1.Text = inmu.inmu_esqueCompleSarampion1.ToString();
                            txt_nomCompleResponVacuSarampion1.Text = inmu.inmu_nomCompleResponVacuSarampion1.ToString();
                            txt_estaSaludColocoVacuSarampion1.Text = inmu.inmu_estaSaludColocoVacuSarampion1.ToString();
                            txt_observaSarampion1.Text = inmu.inmu_observaSarampion1.ToString();
                            txt_fechaSarampion2.Text = inmu.inmu_fechaSarampion2.ToString();
                            txt_loteSarampion2.Text = inmu.inmu_loteSarampion2.ToString();
                            txt_esqueCompleSarampion2.Text = inmu.inmu_esqueCompleSarampion2.ToString();
                            txt_nomCompleResponVacuSarampion2.Text = inmu.inmu_nomCompleResponVacuSarampion2.ToString();
                            txt_estaSaludColocoVacuSarampion2.Text = inmu.inmu_estaSaludColocoVacuSarampion2.ToString();
                            txt_observaSarampion2.Text = inmu.inmu_observaSarampion2.ToString();

                            txt_1fechaInmuAcuerTipoEmpRies1.Text = inmu.inmu_1fechaInmuAcuerTipoEmpRies1.ToString();
                            txt_1loteInmuAcuerTipoEmpRies1.Text = inmu.inmu_1loteInmuAcuerTipoEmpRies1.ToString();
                            txt_1esqueCompleInmuAcuerTipoEmpRies1.Text = inmu.inmu_1esqueCompleInmuAcuerTipoEmpRies1.ToString();
                            txt_1nomCompleResponVacuInmuAcuerTipoEmpRies1.Text = inmu.inmu_1nomCompleResponVacuInmuAcuerTipoEmpRies1.ToString();
                            txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies1.Text = inmu.inmu_1estaSaludColocoVacuInmuAcuerTipoEmpRies1.ToString();
                            txt_1observaInmuAcuerTipoEmpRies1.Text = inmu.inmu_1observaInmuAcuerTipoEmpRies1.ToString();
                            txt_1fechaInmuAcuerTipoEmpRies2.Text = inmu.inmu_1fechaInmuAcuerTipoEmpRies2.ToString();
                            txt_1loteInmuAcuerTipoEmpRies2.Text = inmu.inmu_1loteInmuAcuerTipoEmpRies2.ToString();
                            txt_1esqueCompleInmuAcuerTipoEmpRies2.Text = inmu.inmu_1esqueCompleInmuAcuerTipoEmpRies2.ToString();
                            txt_1nomCompleResponVacuInmuAcuerTipoEmpRies2.Text = inmu.inmu_1nomCompleResponVacuInmuAcuerTipoEmpRies2.ToString();
                            txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies2.Text = inmu.inmu_1estaSaludColocoVacuInmuAcuerTipoEmpRies2.ToString();
                            txt_1observaInmuAcuerTipoEmpRies1.Text = inmu.inmu_1observaInmuAcuerTipoEmpRies2.ToString();
                            txt_1fechaInmuAcuerTipoEmpRies3.Text = inmu.inmu_1fechaInmuAcuerTipoEmpRies3.ToString();
                            txt_1loteInmuAcuerTipoEmpRies3.Text = inmu.inmu_1loteInmuAcuerTipoEmpRies3.ToString();
                            txt_1esqueCompleInmuAcuerTipoEmpRies3.Text = inmu.inmu_1esqueCompleInmuAcuerTipoEmpRies3.ToString();
                            txt_1nomCompleResponVacuInmuAcuerTipoEmpRies3.Text = inmu.inmu_1nomCompleResponVacuInmuAcuerTipoEmpRies3.ToString();
                            txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies3.Text = inmu.inmu_1estaSaludColocoVacuInmuAcuerTipoEmpRies3.ToString();
                            txt_1observaInmuAcuerTipoEmpRies3.Text = inmu.inmu_1observaInmuAcuerTipoEmpRies3.ToString();
                            txt_1fechaInmuAcuerTipoEmpRies4.Text = inmu.inmu_1fechaInmuAcuerTipoEmpRies4.ToString();
                            txt_1loteInmuAcuerTipoEmpRies4.Text = inmu.inmu_1loteInmuAcuerTipoEmpRies4.ToString();
                            txt_1esqueCompleInmuAcuerTipoEmpRies4.Text = inmu.inmu_1esqueCompleInmuAcuerTipoEmpRies4.ToString();
                            txt_1nomCompleResponVacuInmuAcuerTipoEmpRies4.Text = inmu.inmu_1nomCompleResponVacuInmuAcuerTipoEmpRies4.ToString();
                            txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies4.Text = inmu.inmu_1estaSaludColocoVacuInmuAcuerTipoEmpRies4.ToString();
                            txt_1observaInmuAcuerTipoEmpRies4.Text = inmu.inmu_1observaInmuAcuerTipoEmpRies4.ToString();
                            txt_1fechaInmuAcuerTipoEmpRies5.Text = inmu.inmu_1fechaInmuAcuerTipoEmpRies5.ToString();
                            txt_1loteInmuAcuerTipoEmpRies5.Text = inmu.inmu_1loteInmuAcuerTipoEmpRies5.ToString();
                            txt_1esqueCompleInmuAcuerTipoEmpRies5.Text = inmu.inmu_1esqueCompleInmuAcuerTipoEmpRies5.ToString();
                            txt_1nomCompleResponVacuInmuAcuerTipoEmpRies5.Text = inmu.inmu_1nomCompleResponVacuInmuAcuerTipoEmpRies5.ToString();
                            txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies5.Text = inmu.inmu_1estaSaludColocoVacuInmuAcuerTipoEmpRies1.ToString();
                            txt_1observaInmuAcuerTipoEmpRies5.Text = inmu.inmu_1observaInmuAcuerTipoEmpRies5.ToString();

                            txt_2fechaInmuAcuerTipoEmpRies1.Text = inmu.inmu_2fechaInmuAcuerTipoEmpRies1.ToString();
                            txt_2loteInmuAcuerTipoEmpRies1.Text = inmu.inmu_2loteInmuAcuerTipoEmpRies1.ToString();
                            txt_2esqueCompleInmuAcuerTipoEmpRies1.Text = inmu.inmu_2esqueCompleInmuAcuerTipoEmpRies1.ToString();
                            txt_2nomCompleResponVacuInmuAcuerTipoEmpRies1.Text = inmu.inmu_2nomCompleResponVacuInmuAcuerTipoEmpRies1.ToString();
                            txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies1.Text = inmu.inmu_2estaSaludColocoVacuInmuAcuerTipoEmpRies1.ToString();
                            txt_2observaInmuAcuerTipoEmpRies1.Text = inmu.inmu_2observaInmuAcuerTipoEmpRies1.ToString();
                            txt_2fechaInmuAcuerTipoEmpRies2.Text = inmu.inmu_2fechaInmuAcuerTipoEmpRies2.ToString();
                            txt_2loteInmuAcuerTipoEmpRies2.Text = inmu.inmu_2loteInmuAcuerTipoEmpRies2.ToString();
                            txt_2esqueCompleInmuAcuerTipoEmpRies2.Text = inmu.inmu_2esqueCompleInmuAcuerTipoEmpRies2.ToString();
                            txt_2nomCompleResponVacuInmuAcuerTipoEmpRies2.Text = inmu.inmu_2nomCompleResponVacuInmuAcuerTipoEmpRies2.ToString();
                            txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies2.Text = inmu.inmu_2estaSaludColocoVacuInmuAcuerTipoEmpRies2.ToString();
                            txt_2observaInmuAcuerTipoEmpRies1.Text = inmu.inmu_2observaInmuAcuerTipoEmpRies2.ToString();
                            txt_2fechaInmuAcuerTipoEmpRies3.Text = inmu.inmu_2fechaInmuAcuerTipoEmpRies3.ToString();
                            txt_2loteInmuAcuerTipoEmpRies3.Text = inmu.inmu_2loteInmuAcuerTipoEmpRies3.ToString();
                            txt_2esqueCompleInmuAcuerTipoEmpRies3.Text = inmu.inmu_2esqueCompleInmuAcuerTipoEmpRies3.ToString();
                            txt_2nomCompleResponVacuInmuAcuerTipoEmpRies3.Text = inmu.inmu_2nomCompleResponVacuInmuAcuerTipoEmpRies3.ToString();
                            txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies3.Text = inmu.inmu_2estaSaludColocoVacuInmuAcuerTipoEmpRies3.ToString();
                            txt_2observaInmuAcuerTipoEmpRies3.Text = inmu.inmu_2observaInmuAcuerTipoEmpRies3.ToString();
                            txt_2fechaInmuAcuerTipoEmpRies4.Text = inmu.inmu_2fechaInmuAcuerTipoEmpRies4.ToString();
                            txt_2loteInmuAcuerTipoEmpRies4.Text = inmu.inmu_2loteInmuAcuerTipoEmpRies4.ToString();
                            txt_2esqueCompleInmuAcuerTipoEmpRies4.Text = inmu.inmu_2esqueCompleInmuAcuerTipoEmpRies4.ToString();
                            txt_2nomCompleResponVacuInmuAcuerTipoEmpRies4.Text = inmu.inmu_2nomCompleResponVacuInmuAcuerTipoEmpRies4.ToString();
                            txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies4.Text = inmu.inmu_2estaSaludColocoVacuInmuAcuerTipoEmpRies4.ToString();
                            txt_2observaInmuAcuerTipoEmpRies4.Text = inmu.inmu_2observaInmuAcuerTipoEmpRies4.ToString();
                            txt_2fechaInmuAcuerTipoEmpRies5.Text = inmu.inmu_2fechaInmuAcuerTipoEmpRies5.ToString();
                            txt_2loteInmuAcuerTipoEmpRies5.Text = inmu.inmu_2loteInmuAcuerTipoEmpRies5.ToString();
                            txt_2esqueCompleInmuAcuerTipoEmpRies5.Text = inmu.inmu_2esqueCompleInmuAcuerTipoEmpRies5.ToString();
                            txt_2nomCompleResponVacuInmuAcuerTipoEmpRies5.Text = inmu.inmu_2nomCompleResponVacuInmuAcuerTipoEmpRies5.ToString();
                            txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies5.Text = inmu.inmu_2estaSaludColocoVacuInmuAcuerTipoEmpRies1.ToString();
                            txt_2observaInmuAcuerTipoEmpRies5.Text = inmu.inmu_2observaInmuAcuerTipoEmpRies5.ToString();
                        } 

                    }
                }
            }
        }

        //Metodo obtener cedula por numero de HC CERTIFICADO
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
                        where c.Per_Cedula == cedula
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

            }
        }

        private void GuardarInmunizaciones()
        {
            try
            {
                per = CN_HistorialMedico.ObtenerIdPersonasxCedula(Convert.ToInt32(txt_numHClinica.Text));

                int perso = Convert.ToInt32(per.Per_id.ToString());

                inmu = new Tbl_Inmunizaciones 
                {
                    //B. Captura de datos Inmunizaciones
                    inmu_fechaTetanos1 = Convert.ToDateTime(txt_fechatetanos1.Text),
                    inmu_loteTetanos1 = txt_loteTetanos1.Text,
                    inmu_esqueCompleTetanos1 = txt_esqueCompleTetanos1.Text,
                    inmu_nomCompleResponVacuTetanos1 = txt_nomCompleResponVacuTetanos1.Text,
                    inmu_estaSaludColocoVacuTetanos1 = txt_estaSaludColocoVacuTetanos1.Text,
                    inmu_observaTetanos1 = txt_observaTetanos1.Text,
                    inmu_fechaTetanos2 = Convert.ToDateTime(txt_fechatetanos2.Text),
                    inmu_loteTetanos2 = txt_loteTetanos2.Text,
                    inmu_esqueCompleTetanos2 = txt_esqueCompleTetanos2.Text,
                    inmu_nomCompleResponVacuTetanos2 = txt_nomCompleResponVacuTetanos2.Text,
                    inmu_estaSaludColocoVacuTetanos2 = txt_estaSaludColocoVacuTetanos2.Text,
                    inmu_observaTetanos2 = txt_observaTetanos2.Text,
                    inmu_fechaTetanos3 = Convert.ToDateTime(txt_fechatetanos2.Text),
                    inmu_loteTetanos3 = txt_loteTetanos3.Text,
                    inmu_esqueCompleTetanos3 = txt_esqueCompleTetanos3.Text,
                    inmu_nomCompleResponVacuTetanos3 = txt_nomCompleResponVacuTetanos3.Text,
                    inmu_estaSaludColocoVacuTetanos3 = txt_estaSaludColocoVacuTetanos3.Text,
                    inmu_observaTetanos3 = txt_observaTetanos3.Text,
                    inmu_fechaTetanos4 = Convert.ToDateTime(txt_fechatetanos4.Text),
                    inmu_loteTetanos4 = txt_loteTetanos4.Text,
                    inmu_esqueCompleTetanos4 = txt_esqueCompleTetanos4.Text,
                    inmu_nomCompleResponVacuTetanos4 = txt_nomCompleResponVacuTetanos4.Text,
                    inmu_estaSaludColocoVacuTetanos4 = txt_estaSaludColocoVacuTetanos4.Text,
                    inmu_observaTetanos4 = txt_observaTetanos4.Text,
                    inmu_fechaTetanos5 = Convert.ToDateTime(txt_fechatetanos5.Text),
                    inmu_loteTetanos5 = txt_loteTetanos5.Text,
                    inmu_esqueCompleTetanos5 = txt_esqueCompleTetanos5.Text,
                    inmu_nomCompleResponVacuTetanos5 = txt_nomCompleResponVacuTetanos5.Text,
                    inmu_estaSaludColocoVacuTetanos5 = txt_estaSaludColocoVacuTetanos5.Text,
                    inmu_observaTetanos5 = txt_observaTetanos5.Text,

                    inmu_fechaHepatitisA1 = Convert.ToDateTime(txt_fechaHepatitisA1.Text),
                    inmu_loteHepatitisA1 = txt_loteHepatitisA1.Text,
                    inmu_esqueCompleHepatitisA1 = txt_esqueCompleHepatitisA1.Text,
                    inmu_nomCompleResponVacuHepatitisA1 = txt_nomCompleResponVacuHepatitisA1.Text,
                    inmu_estaSaludColocoVaciHepatitisA1 = txt_estaSaludColocoVaciHepatitisA1.Text,
                    inmu_observaHepatitisA1 = txt_observaHepatitisA1.Text,
                    inmu_fechaHepatitisA2 = Convert.ToDateTime(txt_fechaHepatitisA2.Text),
                    inmu_loteHepatitisA2 = txt_loteHepatitisA2.Text,
                    inmu_esqueCompleHepatitisA2 = txt_esqueCompleHepatitisA2.Text,
                    inmu_nomCompleResponVacuHepatitisA2 = txt_nomCompleResponVacuHepatitisA2.Text,
                    inmu_estaSaludColocoVaciHepatitisA2 = txt_estaSaludColocoVaciHepatitisA2.Text,
                    inmu_observaHepatitisA2 = txt_observaHepatitisA2.Text,
                    inmu_fechaHepatitisA3 = Convert.ToDateTime(txt_fechaHepatitisA3.Text),
                    inmu_loteHepatitisA3 = txt_loteHepatitisA3.Text,
                    inmu_esqueCompleHepatitisA3 = txt_esqueCompleHepatitisA3.Text,
                    inmu_nomCompleResponVacuHepatitisA3 = txt_nomCompleResponVacuHepatitisA3.Text,
                    inmu_estaSaludColocoVaciHepatitisA3 = txt_estaSaludColocoVaciHepatitisA3.Text,
                    inmu_observaHepatitisA3 = txt_observaHepatitisA3.Text,

                    inmu_fechaHepatitisB1 = Convert.ToDateTime(txt_fechaHepatitisB1.Text),
                    inmu_loteHepatitisB1 = txt_loteHepatitisB1.Text,
                    inmu_esqueCompleHepatitisB1 = txt_esqueCompleHepatitisB1.Text,
                    inmu_nomCompleResponVacuHepatitisB1 = txt_nomCompleResponVacuHepatitisB1.Text,
                    inmu_estaSaludColocoVaciHepatitisB1 = txt_estaSaludColocoVaciHepatitisB1.Text,
                    inmu_observaHepatitisB1 = txt_observaHepatitisB1.Text,
                    inmu_fechaHepatitisB2 = Convert.ToDateTime(txt_fechaHepatitisB2.Text),
                    inmu_loteHepatitisB2 = txt_loteHepatitisB2.Text,
                    inmu_esqueCompleHepatitisB2 = txt_esqueCompleHepatitisB2.Text,
                    inmu_nomCompleResponVacuHepatitisB2 = txt_nomCompleResponVacuHepatitisB2.Text,
                    inmu_estaSaludColocoVaciHepatitisB2 = txt_estaSaludColocoVaciHepatitisB2.Text,
                    inmu_observaHepatitisB2 = txt_observaHepatitisB2.Text,
                    inmu_fechaHepatitisB3 = Convert.ToDateTime(txt_fechaHepatitisB3.Text),
                    inmu_loteHepatitisB3 = txt_loteHepatitisB3.Text,
                    inmu_esqueCompleHepatitisB3 = txt_esqueCompleHepatitisB3.Text,
                    inmu_nomCompleResponVacuHepatitisB3 = txt_nomCompleResponVacuHepatitisB3.Text,
                    inmu_estaSaludColocoVaciHepatitisB3 = txt_estaSaludColocoVaciHepatitisB3.Text,
                    inmu_observaHepatitisB3 = txt_observaHepatitisB3.Text,

                    inmu_fechaInfluenza = Convert.ToDateTime(txt_fechaInfluenza.Text),
                    inmu_loteInfluenza = txt_loteInfluenza.Text,
                    inmu_esqueCompleInfluenza = txt_esqueCompleInfluenza.Text,
                    inmu_nomCompleResponVacuInfluenza = txt_nomCompleResponVacuInfluenza.Text,
                    inmu_estaSaludColocoVacuInfluenza = txt_estaSaludColocoVacuInfluenza.Text,
                    inmu_observaInfluenza = txt_observaInfluenza.Text,

                    inmu_fechaFiebreAmarilla = Convert.ToDateTime(txt_fechaFiebreAmarilla.Text),
                    inmu_loteFiebreAmarilla = txt_loteFiebreAmarilla.Text,
                    inmu_esqueCompleFiebreAmarilla = txt_esqueCompleFiebreAmarilla.Text,
                    inmu_nomCompleResponVacuFiebreAmarilla = txt_nomCompleResponVacuFiebreAmarilla.Text,
                    inmu_estaSaludColocoVacuFiebreAmarilla = txt_estaSaludColocoVacuFiebreAmarilla.Text,
                    inmu_observaFiebreAmarilla = txt_observaFiebreAmarilla.Text,

                    inmu_fechaSarampion1 = Convert.ToDateTime(txt_fechaSarampion1.Text),
                    inmu_loteSarampion1 = txt_loteSarampion1.Text,
                    inmu_esqueCompleSarampion1 = txt_esqueCompleSarampion1.Text,
                    inmu_nomCompleResponVacuSarampion1 = txt_nomCompleResponVacuSarampion1.Text,
                    inmu_estaSaludColocoVacuSarampion1 = txt_estaSaludColocoVacuSarampion1.Text,
                    inmu_observaSarampion1 = txt_observaSarampion1.Text,
                    inmu_fechaSarampion2 = Convert.ToDateTime(txt_fechaSarampion2.Text),
                    inmu_loteSarampion2 = txt_loteSarampion2.Text,
                    inmu_esqueCompleSarampion2 = txt_esqueCompleSarampion2.Text,
                    inmu_nomCompleResponVacuSarampion2 = txt_nomCompleResponVacuSarampion2.Text,
                    inmu_estaSaludColocoVacuSarampion2 = txt_estaSaludColocoVacuSarampion2.Text,
                    inmu_observaSarampion2 = txt_observaSarampion2.Text,

                    inmu_1fechaInmuAcuerTipoEmpRies1 = Convert.ToDateTime(txt_1fechaInmuAcuerTipoEmpRies1.Text),
                    inmu_1loteInmuAcuerTipoEmpRies1 = txt_1loteInmuAcuerTipoEmpRies1.Text,
                    inmu_1esqueCompleInmuAcuerTipoEmpRies1 = txt_1esqueCompleInmuAcuerTipoEmpRies1.Text,
                    inmu_1nomCompleResponVacuInmuAcuerTipoEmpRies1 = txt_1nomCompleResponVacuInmuAcuerTipoEmpRies1.Text,
                    inmu_1estaSaludColocoVacuInmuAcuerTipoEmpRies1 = txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies1.Text,
                    inmu_1observaInmuAcuerTipoEmpRies1 = txt_1observaInmuAcuerTipoEmpRies1.Text,
                    inmu_1fechaInmuAcuerTipoEmpRies2 = Convert.ToDateTime(txt_1fechaInmuAcuerTipoEmpRies2.Text),
                    inmu_1loteInmuAcuerTipoEmpRies2 = txt_1loteInmuAcuerTipoEmpRies2.Text,
                    inmu_1esqueCompleInmuAcuerTipoEmpRies2 = txt_1esqueCompleInmuAcuerTipoEmpRies2.Text,
                    inmu_1nomCompleResponVacuInmuAcuerTipoEmpRies2 = txt_1nomCompleResponVacuInmuAcuerTipoEmpRies2.Text,
                    inmu_1estaSaludColocoVacuInmuAcuerTipoEmpRies2 = txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies2.Text,
                    inmu_1observaInmuAcuerTipoEmpRies2 = txt_1observaInmuAcuerTipoEmpRies2.Text,
                    inmu_1fechaInmuAcuerTipoEmpRies3 = Convert.ToDateTime(txt_1fechaInmuAcuerTipoEmpRies3.Text),
                    inmu_1loteInmuAcuerTipoEmpRies3 = txt_1loteInmuAcuerTipoEmpRies3.Text,
                    inmu_1esqueCompleInmuAcuerTipoEmpRies3 = txt_1esqueCompleInmuAcuerTipoEmpRies3.Text,
                    inmu_1nomCompleResponVacuInmuAcuerTipoEmpRies3 = txt_1nomCompleResponVacuInmuAcuerTipoEmpRies3.Text,
                    inmu_1estaSaludColocoVacuInmuAcuerTipoEmpRies3 = txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies3.Text,
                    inmu_1observaInmuAcuerTipoEmpRies3 = txt_1observaInmuAcuerTipoEmpRies3.Text,
                    inmu_1fechaInmuAcuerTipoEmpRies4 = Convert.ToDateTime(txt_1fechaInmuAcuerTipoEmpRies4.Text),
                    inmu_1loteInmuAcuerTipoEmpRies4 = txt_1loteInmuAcuerTipoEmpRies4.Text,
                    inmu_1esqueCompleInmuAcuerTipoEmpRies4 = txt_1esqueCompleInmuAcuerTipoEmpRies4.Text,
                    inmu_1nomCompleResponVacuInmuAcuerTipoEmpRies4 = txt_1nomCompleResponVacuInmuAcuerTipoEmpRies4.Text,
                    inmu_1estaSaludColocoVacuInmuAcuerTipoEmpRies4 = txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies4.Text,
                    inmu_1observaInmuAcuerTipoEmpRies4 = txt_1observaInmuAcuerTipoEmpRies4.Text,
                    inmu_1fechaInmuAcuerTipoEmpRies5 = Convert.ToDateTime(txt_1fechaInmuAcuerTipoEmpRies5.Text),
                    inmu_1loteInmuAcuerTipoEmpRies5 = txt_1loteInmuAcuerTipoEmpRies5.Text,
                    inmu_1esqueCompleInmuAcuerTipoEmpRies5 = txt_1esqueCompleInmuAcuerTipoEmpRies5.Text,
                    inmu_1nomCompleResponVacuInmuAcuerTipoEmpRies5 = txt_1nomCompleResponVacuInmuAcuerTipoEmpRies5.Text,
                    inmu_1estaSaludColocoVacuInmuAcuerTipoEmpRies5 = txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies5.Text,
                    inmu_1observaInmuAcuerTipoEmpRies5 = txt_1observaInmuAcuerTipoEmpRies5.Text,

                    inmu_2fechaInmuAcuerTipoEmpRies1 = Convert.ToDateTime(txt_2fechaInmuAcuerTipoEmpRies1.Text),
                    inmu_2loteInmuAcuerTipoEmpRies1 = txt_2loteInmuAcuerTipoEmpRies1.Text,
                    inmu_2esqueCompleInmuAcuerTipoEmpRies1 = txt_2esqueCompleInmuAcuerTipoEmpRies1.Text,
                    inmu_2nomCompleResponVacuInmuAcuerTipoEmpRies1 = txt_2nomCompleResponVacuInmuAcuerTipoEmpRies1.Text,
                    inmu_2estaSaludColocoVacuInmuAcuerTipoEmpRies1 = txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies1.Text,
                    inmu_2observaInmuAcuerTipoEmpRies1 = txt_2observaInmuAcuerTipoEmpRies1.Text,
                    inmu_2fechaInmuAcuerTipoEmpRies2 = Convert.ToDateTime(txt_2fechaInmuAcuerTipoEmpRies2.Text),
                    inmu_2loteInmuAcuerTipoEmpRies2 = txt_2loteInmuAcuerTipoEmpRies2.Text,
                    inmu_2esqueCompleInmuAcuerTipoEmpRies2 = txt_2esqueCompleInmuAcuerTipoEmpRies2.Text,
                    inmu_2nomCompleResponVacuInmuAcuerTipoEmpRies2 = txt_2nomCompleResponVacuInmuAcuerTipoEmpRies2.Text,
                    inmu_2estaSaludColocoVacuInmuAcuerTipoEmpRies2 = txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies2.Text,
                    inmu_2observaInmuAcuerTipoEmpRies2 = txt_2observaInmuAcuerTipoEmpRies2.Text,
                    inmu_2fechaInmuAcuerTipoEmpRies3 = Convert.ToDateTime(txt_2fechaInmuAcuerTipoEmpRies3.Text),
                    inmu_2loteInmuAcuerTipoEmpRies3 = txt_2loteInmuAcuerTipoEmpRies3.Text,
                    inmu_2esqueCompleInmuAcuerTipoEmpRies3 = txt_2esqueCompleInmuAcuerTipoEmpRies3.Text,
                    inmu_2nomCompleResponVacuInmuAcuerTipoEmpRies3 = txt_2nomCompleResponVacuInmuAcuerTipoEmpRies3.Text,
                    inmu_2estaSaludColocoVacuInmuAcuerTipoEmpRies3 = txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies3.Text,
                    inmu_2observaInmuAcuerTipoEmpRies3 = txt_2observaInmuAcuerTipoEmpRies3.Text,
                    inmu_2fechaInmuAcuerTipoEmpRies4 = Convert.ToDateTime(txt_2fechaInmuAcuerTipoEmpRies4.Text),
                    inmu_2loteInmuAcuerTipoEmpRies4 = txt_2loteInmuAcuerTipoEmpRies4.Text,
                    inmu_2esqueCompleInmuAcuerTipoEmpRies4 = txt_2esqueCompleInmuAcuerTipoEmpRies4.Text,
                    inmu_2nomCompleResponVacuInmuAcuerTipoEmpRies4 = txt_2nomCompleResponVacuInmuAcuerTipoEmpRies4.Text,
                    inmu_2estaSaludColocoVacuInmuAcuerTipoEmpRies4 = txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies4.Text,
                    inmu_2observaInmuAcuerTipoEmpRies4 = txt_2observaInmuAcuerTipoEmpRies4.Text,
                    inmu_2fechaInmuAcuerTipoEmpRies5 = Convert.ToDateTime(txt_2fechaInmuAcuerTipoEmpRies5.Text),
                    inmu_2loteInmuAcuerTipoEmpRies5 = txt_2loteInmuAcuerTipoEmpRies5.Text,
                    inmu_2esqueCompleInmuAcuerTipoEmpRies5 = txt_2esqueCompleInmuAcuerTipoEmpRies5.Text,
                    inmu_2nomCompleResponVacuInmuAcuerTipoEmpRies5 = txt_2nomCompleResponVacuInmuAcuerTipoEmpRies5.Text,
                    inmu_2estaSaludColocoVacuInmuAcuerTipoEmpRies5 = txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies5.Text,
                    inmu_2observaInmuAcuerTipoEmpRies5 = txt_2observaInmuAcuerTipoEmpRies5.Text,

                    Per_id = perso
                };
                
                CN_Inmunizaciones.GuardarInmunizaciones(inmu);

                //Mensaje de confirmacion
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Guardados Exitosamente')", true);

                Response.Redirect("~/Template/Views/PacientesInmunizaciones.aspx");

            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Guardados')", true);
            }

        }

        private void ModificarHistorial(Tbl_Inmunizaciones inmu)
        {
            try
            {
                //B. Captura de datos Inmunizaciones
                inmu.inmu_fechaTetanos1 = Convert.ToDateTime(txt_fechatetanos1.Text);
                inmu.inmu_loteTetanos1 = txt_loteTetanos1.Text;
                inmu.inmu_esqueCompleTetanos1 = txt_esqueCompleTetanos1.Text;
                inmu.inmu_nomCompleResponVacuTetanos1 = txt_nomCompleResponVacuTetanos1.Text;
                inmu.inmu_estaSaludColocoVacuTetanos1 = txt_estaSaludColocoVacuTetanos1.Text;
                inmu.inmu_observaTetanos1 = txt_observaTetanos1.Text;
                inmu.inmu_fechaTetanos2 = Convert.ToDateTime(txt_fechatetanos2.Text);
                inmu.inmu_loteTetanos2 = txt_loteTetanos2.Text;
                inmu.inmu_esqueCompleTetanos2 = txt_esqueCompleTetanos2.Text;
                inmu.inmu_nomCompleResponVacuTetanos2 = txt_nomCompleResponVacuTetanos2.Text;
                inmu.inmu_estaSaludColocoVacuTetanos2 = txt_estaSaludColocoVacuTetanos2.Text;
                inmu.inmu_observaTetanos2 = txt_observaTetanos2.Text;
                inmu.inmu_fechaTetanos3 = Convert.ToDateTime(txt_fechatetanos2.Text);
                inmu.inmu_loteTetanos3 = txt_loteTetanos3.Text;
                inmu.inmu_esqueCompleTetanos3 = txt_esqueCompleTetanos3.Text;
                inmu.inmu_nomCompleResponVacuTetanos3 = txt_nomCompleResponVacuTetanos3.Text;
                inmu.inmu_estaSaludColocoVacuTetanos3 = txt_estaSaludColocoVacuTetanos3.Text;
                inmu.inmu_observaTetanos3 = txt_observaTetanos3.Text;
                inmu.inmu_fechaTetanos4 = Convert.ToDateTime(txt_fechatetanos4.Text);
                inmu.inmu_loteTetanos4 = txt_loteTetanos4.Text;
                inmu.inmu_esqueCompleTetanos4 = txt_esqueCompleTetanos4.Text;
                inmu.inmu_nomCompleResponVacuTetanos4 = txt_nomCompleResponVacuTetanos4.Text;
                inmu.inmu_estaSaludColocoVacuTetanos4 = txt_estaSaludColocoVacuTetanos4.Text;
                inmu.inmu_observaTetanos4 = txt_observaTetanos4.Text;
                inmu.inmu_fechaTetanos5 = Convert.ToDateTime(txt_fechatetanos5.Text);
                inmu.inmu_loteTetanos5 = txt_loteTetanos5.Text;
                inmu.inmu_esqueCompleTetanos5 = txt_esqueCompleTetanos5.Text;
                inmu.inmu_nomCompleResponVacuTetanos5 = txt_nomCompleResponVacuTetanos5.Text;
                inmu.inmu_estaSaludColocoVacuTetanos5 = txt_estaSaludColocoVacuTetanos5.Text;
                inmu.inmu_observaTetanos5 = txt_observaTetanos5.Text;

                inmu.inmu_fechaHepatitisA1 = Convert.ToDateTime(txt_fechaHepatitisA1.Text);
                inmu.inmu_loteHepatitisA1 = txt_loteHepatitisA1.Text;
                inmu.inmu_esqueCompleHepatitisA1 = txt_esqueCompleHepatitisA1.Text;
                inmu.inmu_nomCompleResponVacuHepatitisA1 = txt_nomCompleResponVacuHepatitisA1.Text;
                inmu.inmu_estaSaludColocoVaciHepatitisA1 = txt_estaSaludColocoVaciHepatitisA1.Text;
                inmu.inmu_observaHepatitisA1 = txt_observaHepatitisA1.Text;
                inmu.inmu_fechaHepatitisA2 = Convert.ToDateTime(txt_fechaHepatitisA2.Text);
                inmu.inmu_loteHepatitisA2 = txt_loteHepatitisA2.Text;
                inmu.inmu_esqueCompleHepatitisA2 = txt_esqueCompleHepatitisA2.Text;
                inmu.inmu_nomCompleResponVacuHepatitisA2 = txt_nomCompleResponVacuHepatitisA2.Text;
                inmu.inmu_estaSaludColocoVaciHepatitisA2 = txt_estaSaludColocoVaciHepatitisA2.Text;
                inmu.inmu_observaHepatitisA2 = txt_observaHepatitisA2.Text;
                inmu.inmu_fechaHepatitisA3 = Convert.ToDateTime(txt_fechaHepatitisA3.Text);
                inmu.inmu_loteHepatitisA3 = txt_loteHepatitisA3.Text;
                inmu.inmu_esqueCompleHepatitisA3 = txt_esqueCompleHepatitisA3.Text;
                inmu.inmu_nomCompleResponVacuHepatitisA3 = txt_nomCompleResponVacuHepatitisA3.Text;
                inmu.inmu_estaSaludColocoVaciHepatitisA3 = txt_estaSaludColocoVaciHepatitisA3.Text;
                inmu.inmu_observaHepatitisA3 = txt_observaHepatitisA3.Text;

                inmu.inmu_fechaHepatitisB1 = Convert.ToDateTime(txt_fechaHepatitisB1.Text);
                inmu.inmu_loteHepatitisB1 = txt_loteHepatitisB1.Text;
                inmu.inmu_esqueCompleHepatitisB1 = txt_esqueCompleHepatitisB1.Text;
                inmu.inmu_nomCompleResponVacuHepatitisB1 = txt_nomCompleResponVacuHepatitisB1.Text;
                inmu.inmu_estaSaludColocoVaciHepatitisB1 = txt_estaSaludColocoVaciHepatitisB1.Text;
                inmu.inmu_observaHepatitisB1 = txt_observaHepatitisB1.Text;
                inmu.inmu_fechaHepatitisB2 = Convert.ToDateTime(txt_fechaHepatitisB2.Text);
                inmu.inmu_loteHepatitisB2 = txt_loteHepatitisB2.Text;
                inmu.inmu_esqueCompleHepatitisB2 = txt_esqueCompleHepatitisB2.Text;
                inmu.inmu_nomCompleResponVacuHepatitisB2 = txt_nomCompleResponVacuHepatitisB2.Text;
                inmu.inmu_estaSaludColocoVaciHepatitisB2 = txt_estaSaludColocoVaciHepatitisB2.Text;
                inmu.inmu_observaHepatitisB2 = txt_observaHepatitisB2.Text;
                inmu.inmu_fechaHepatitisB3 = Convert.ToDateTime(txt_fechaHepatitisB3.Text);
                inmu.inmu_loteHepatitisB3 = txt_loteHepatitisB3.Text;
                inmu.inmu_esqueCompleHepatitisB3 = txt_esqueCompleHepatitisB3.Text;
                inmu.inmu_nomCompleResponVacuHepatitisB3 = txt_nomCompleResponVacuHepatitisB3.Text;
                inmu.inmu_estaSaludColocoVaciHepatitisB3 = txt_estaSaludColocoVaciHepatitisB3.Text;
                inmu.inmu_observaHepatitisB3 = txt_observaHepatitisB3.Text;

                inmu.inmu_fechaInfluenza = Convert.ToDateTime(txt_fechaInfluenza.Text);
                inmu.inmu_loteInfluenza = txt_loteInfluenza.Text;
                inmu.inmu_esqueCompleInfluenza = txt_esqueCompleInfluenza.Text;
                inmu.inmu_nomCompleResponVacuInfluenza = txt_nomCompleResponVacuInfluenza.Text;
                inmu.inmu_estaSaludColocoVacuInfluenza = txt_estaSaludColocoVacuInfluenza.Text;
                inmu.inmu_observaInfluenza = txt_observaInfluenza.Text;

                inmu.inmu_fechaFiebreAmarilla = Convert.ToDateTime(txt_fechaFiebreAmarilla.Text);
                inmu.inmu_loteFiebreAmarilla = txt_loteFiebreAmarilla.Text;
                inmu.inmu_esqueCompleFiebreAmarilla = txt_esqueCompleFiebreAmarilla.Text;
                inmu.inmu_nomCompleResponVacuFiebreAmarilla = txt_nomCompleResponVacuFiebreAmarilla.Text;
                inmu.inmu_estaSaludColocoVacuFiebreAmarilla = txt_estaSaludColocoVacuFiebreAmarilla.Text;
                inmu.inmu_observaFiebreAmarilla = txt_observaFiebreAmarilla.Text;

                inmu.inmu_fechaSarampion1 = Convert.ToDateTime(txt_fechaSarampion1.Text);
                inmu.inmu_loteSarampion1 = txt_loteSarampion1.Text;
                inmu.inmu_esqueCompleSarampion1 = txt_esqueCompleSarampion1.Text;
                inmu.inmu_nomCompleResponVacuSarampion1 = txt_nomCompleResponVacuSarampion1.Text;
                inmu.inmu_estaSaludColocoVacuSarampion1 = txt_estaSaludColocoVacuSarampion1.Text;
                inmu.inmu_observaSarampion1 = txt_observaSarampion1.Text;
                inmu.inmu_fechaSarampion2 = Convert.ToDateTime(txt_fechaSarampion2.Text);
                inmu.inmu_loteSarampion2 = txt_loteSarampion2.Text;
                inmu.inmu_esqueCompleSarampion2 = txt_esqueCompleSarampion2.Text;
                inmu.inmu_nomCompleResponVacuSarampion2 = txt_nomCompleResponVacuSarampion2.Text;
                inmu.inmu_estaSaludColocoVacuSarampion2 = txt_estaSaludColocoVacuSarampion2.Text;
                inmu.inmu_observaSarampion2 = txt_observaSarampion2.Text;

                inmu.inmu_1fechaInmuAcuerTipoEmpRies1 = Convert.ToDateTime(txt_1fechaInmuAcuerTipoEmpRies1.Text);
                inmu.inmu_1loteInmuAcuerTipoEmpRies1 = txt_1loteInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_1esqueCompleInmuAcuerTipoEmpRies1 = txt_1esqueCompleInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_1nomCompleResponVacuInmuAcuerTipoEmpRies1 = txt_1nomCompleResponVacuInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_1estaSaludColocoVacuInmuAcuerTipoEmpRies1 = txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_1observaInmuAcuerTipoEmpRies1 = txt_1observaInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_1fechaInmuAcuerTipoEmpRies2 = Convert.ToDateTime(txt_1fechaInmuAcuerTipoEmpRies2.Text);
                inmu.inmu_1loteInmuAcuerTipoEmpRies2 = txt_1loteInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_1esqueCompleInmuAcuerTipoEmpRies2 = txt_1esqueCompleInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_1nomCompleResponVacuInmuAcuerTipoEmpRies2 = txt_1nomCompleResponVacuInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_1estaSaludColocoVacuInmuAcuerTipoEmpRies2 = txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_1observaInmuAcuerTipoEmpRies2 = txt_1observaInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_1fechaInmuAcuerTipoEmpRies3 = Convert.ToDateTime(txt_1fechaInmuAcuerTipoEmpRies3.Text);
                inmu.inmu_1loteInmuAcuerTipoEmpRies3 = txt_1loteInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_1esqueCompleInmuAcuerTipoEmpRies3 = txt_1esqueCompleInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_1nomCompleResponVacuInmuAcuerTipoEmpRies3 = txt_1nomCompleResponVacuInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_1estaSaludColocoVacuInmuAcuerTipoEmpRies3 = txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_1observaInmuAcuerTipoEmpRies3 = txt_1observaInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_1fechaInmuAcuerTipoEmpRies4 = Convert.ToDateTime(txt_1fechaInmuAcuerTipoEmpRies4.Text);
                inmu.inmu_1loteInmuAcuerTipoEmpRies4 = txt_1loteInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_1esqueCompleInmuAcuerTipoEmpRies4 = txt_1esqueCompleInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_1nomCompleResponVacuInmuAcuerTipoEmpRies4 = txt_1nomCompleResponVacuInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_1estaSaludColocoVacuInmuAcuerTipoEmpRies4 = txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_1observaInmuAcuerTipoEmpRies4 = txt_1observaInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_1fechaInmuAcuerTipoEmpRies5 = Convert.ToDateTime(txt_1fechaInmuAcuerTipoEmpRies5.Text);
                inmu.inmu_1loteInmuAcuerTipoEmpRies5 = txt_1loteInmuAcuerTipoEmpRies5.Text;
                inmu.inmu_1esqueCompleInmuAcuerTipoEmpRies5 = txt_1esqueCompleInmuAcuerTipoEmpRies5.Text;
                inmu.inmu_1nomCompleResponVacuInmuAcuerTipoEmpRies5 = txt_1nomCompleResponVacuInmuAcuerTipoEmpRies5.Text;
                inmu.inmu_1estaSaludColocoVacuInmuAcuerTipoEmpRies5 = txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies5.Text;
                inmu.inmu_1observaInmuAcuerTipoEmpRies5 = txt_1observaInmuAcuerTipoEmpRies5.Text;

                inmu.inmu_2fechaInmuAcuerTipoEmpRies1 = Convert.ToDateTime(txt_2fechaInmuAcuerTipoEmpRies1.Text);
                inmu.inmu_2loteInmuAcuerTipoEmpRies1 = txt_2loteInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_2esqueCompleInmuAcuerTipoEmpRies1 = txt_2esqueCompleInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_2nomCompleResponVacuInmuAcuerTipoEmpRies1 = txt_2nomCompleResponVacuInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_2estaSaludColocoVacuInmuAcuerTipoEmpRies1 = txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_2observaInmuAcuerTipoEmpRies1 = txt_2observaInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_2fechaInmuAcuerTipoEmpRies2 = Convert.ToDateTime(txt_2fechaInmuAcuerTipoEmpRies2.Text);
                inmu.inmu_2loteInmuAcuerTipoEmpRies2 = txt_2loteInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_2esqueCompleInmuAcuerTipoEmpRies2 = txt_2esqueCompleInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_2nomCompleResponVacuInmuAcuerTipoEmpRies2 = txt_2nomCompleResponVacuInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_2estaSaludColocoVacuInmuAcuerTipoEmpRies2 = txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_2observaInmuAcuerTipoEmpRies2 = txt_2observaInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_2fechaInmuAcuerTipoEmpRies3 = Convert.ToDateTime(txt_2fechaInmuAcuerTipoEmpRies3.Text);
                inmu.inmu_2loteInmuAcuerTipoEmpRies3 = txt_2loteInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_2esqueCompleInmuAcuerTipoEmpRies3 = txt_2esqueCompleInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_2nomCompleResponVacuInmuAcuerTipoEmpRies3 = txt_2nomCompleResponVacuInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_2estaSaludColocoVacuInmuAcuerTipoEmpRies3 = txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_2observaInmuAcuerTipoEmpRies3 = txt_2observaInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_2fechaInmuAcuerTipoEmpRies4 = Convert.ToDateTime(txt_2fechaInmuAcuerTipoEmpRies4.Text);
                inmu.inmu_2loteInmuAcuerTipoEmpRies4 = txt_2loteInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_2esqueCompleInmuAcuerTipoEmpRies4 = txt_2esqueCompleInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_2nomCompleResponVacuInmuAcuerTipoEmpRies4 = txt_2nomCompleResponVacuInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_2estaSaludColocoVacuInmuAcuerTipoEmpRies4 = txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_2observaInmuAcuerTipoEmpRies4 = txt_2observaInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_2fechaInmuAcuerTipoEmpRies5 = Convert.ToDateTime(txt_2fechaInmuAcuerTipoEmpRies5.Text);
                inmu.inmu_2loteInmuAcuerTipoEmpRies5 = txt_2loteInmuAcuerTipoEmpRies5.Text;
                inmu.inmu_2esqueCompleInmuAcuerTipoEmpRies5 = txt_2esqueCompleInmuAcuerTipoEmpRies5.Text;
                inmu.inmu_2nomCompleResponVacuInmuAcuerTipoEmpRies5 = txt_2nomCompleResponVacuInmuAcuerTipoEmpRies5.Text;
                inmu.inmu_2estaSaludColocoVacuInmuAcuerTipoEmpRies5 = txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies5.Text;
                inmu.inmu_2observaInmuAcuerTipoEmpRies5 = txt_2observaInmuAcuerTipoEmpRies5.Text;

                CN_Inmunizaciones.ModificarInmunizaciones(inmu);

                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Modificados Exitosamente')", true);
                Response.Redirect("~/Template/Views/Pacientes.aspx");
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Modificados')", true);

            }
        }

        private void guardar_modificar_datos(int inmunizaciones)
        {
            if (inmunizaciones == 0)
            {
                GuardarInmunizaciones();
            }
            else
            {

                inmu = CN_Inmunizaciones.ObtenerInmunizacionesPorId(inmunizaciones);

                if (inmu != null)
                {
                    ModificarHistorial(inmu);
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