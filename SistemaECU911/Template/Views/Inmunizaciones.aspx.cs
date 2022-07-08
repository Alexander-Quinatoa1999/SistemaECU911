﻿using CapaDatos;
using CapaNegocio;
using HtmlAgilityPack;
using iTextSharp.text;
using iTextSharp.text.pdf;
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
                    inmu = CN_Inmunizaciones.ObtenerInmunizacionesPorId(codigo);
                    int personasid = Convert.ToInt32(inmu.Per_id.ToString());
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
                        txt_cargo.Text = per.Per_cargoOcupacion.ToString();

                        if (inmu != null)
                        {
                            //A
                            txt_numArchivo.Text = inmu.inmu_numArchivo.ToString();

                            //B
                            if (inmu.inmu_fechaTetanos1 == "")
                            {
                                txt_fechatetanos1.Text = inmu.inmu_fechaTetanos1.ToString(); 
                            }
                            else
                            {
                                txt_fechatetanos1.Text = Convert.ToDateTime(inmu.inmu_fechaTetanos1).ToString("yyyy-MM-dd");
                            }
                            txt_loteTetanos1.Text = inmu.inmu_loteTetanos1.ToString();
                            txt_esqueCompleTetanos1.Text = inmu.inmu_esqueCompleTetanos1.ToString();
                            txt_nomCompleResponVacuTetanos1.Text = inmu.inmu_nomCompleResponVacuTetanos1.ToString();
                            txt_estaSaludColocoVacuTetanos1.Text = inmu.inmu_estaSaludColocoVacuTetanos1.ToString();
                            txt_observaTetanos1.Text = inmu.inmu_observaTetanos1.ToString();
                            if (inmu.inmu_fechaTetanos2 == "")
                            {
                                txt_fechatetanos2.Text = inmu.inmu_fechaTetanos2.ToString();
                            }
                            else
                            {
                                txt_fechatetanos2.Text = Convert.ToDateTime(inmu.inmu_fechaTetanos2).ToString("yyyy-MM-dd"); ;
                            }                            
                            txt_loteTetanos2.Text = inmu.inmu_loteTetanos2.ToString();
                            txt_esqueCompleTetanos2.Text = inmu.inmu_esqueCompleTetanos2.ToString();
                            txt_nomCompleResponVacuTetanos2.Text = inmu.inmu_nomCompleResponVacuTetanos2.ToString();
                            txt_estaSaludColocoVacuTetanos2.Text = inmu.inmu_estaSaludColocoVacuTetanos2.ToString();
                            txt_observaTetanos2.Text = inmu.inmu_observaTetanos2.ToString();
                            if (inmu.inmu_fechaTetanos3 == "")
                            {
                                txt_fechatetanos3.Text = inmu.inmu_fechaTetanos3.ToString();
                            }
                            else
                            {
                                txt_fechatetanos3.Text = Convert.ToDateTime(inmu.inmu_fechaTetanos3).ToString("yyyy-MM-dd");
                            }                            
                            txt_loteTetanos3.Text = inmu.inmu_loteTetanos3.ToString();
                            txt_esqueCompleTetanos3.Text = inmu.inmu_esqueCompleTetanos3.ToString();
                            txt_nomCompleResponVacuTetanos3.Text = inmu.inmu_nomCompleResponVacuTetanos3.ToString();
                            txt_estaSaludColocoVacuTetanos3.Text = inmu.inmu_estaSaludColocoVacuTetanos3.ToString();
                            txt_observaTetanos3.Text = inmu.inmu_observaTetanos3.ToString();
                            if (inmu.inmu_fechaTetanos4 == "")
                            {
                                txt_fechatetanos4.Text = inmu.inmu_fechaTetanos4.ToString();
                            }
                            else
                            {
                                txt_fechatetanos4.Text = Convert.ToDateTime(inmu.inmu_fechaTetanos4).ToString("yyyy-MM-dd");
                            }                            
                            txt_loteTetanos4.Text = inmu.inmu_loteTetanos4.ToString();
                            txt_esqueCompleTetanos4.Text = inmu.inmu_esqueCompleTetanos4.ToString();
                            txt_nomCompleResponVacuTetanos4.Text = inmu.inmu_nomCompleResponVacuTetanos4.ToString();
                            txt_estaSaludColocoVacuTetanos4.Text = inmu.inmu_estaSaludColocoVacuTetanos4.ToString();
                            txt_observaTetanos4.Text = inmu.inmu_observaTetanos4.ToString();
                            if (inmu.inmu_fechaTetanos5 == "")
                            {
                                txt_fechatetanos5.Text = inmu.inmu_fechaTetanos5.ToString();
                            }
                            else
                            {
                                txt_fechatetanos5.Text = Convert.ToDateTime(inmu.inmu_fechaTetanos5).ToString("yyyy-MM-dd");
                            }                            
                            txt_loteTetanos5.Text = inmu.inmu_loteTetanos5.ToString();
                            txt_esqueCompleTetanos5.Text = inmu.inmu_esqueCompleTetanos5.ToString();
                            txt_nomCompleResponVacuTetanos5.Text = inmu.inmu_nomCompleResponVacuTetanos5.ToString();
                            txt_estaSaludColocoVacuTetanos5.Text = inmu.inmu_estaSaludColocoVacuTetanos5.ToString();
                            txt_observaTetanos5.Text = inmu.inmu_observaTetanos5.ToString();

                            if (inmu.inmu_fechaHepatitisA1 == "")
                            {
                                txt_fechaHepatitisA1.Text = inmu.inmu_fechaHepatitisA1.ToString();
                            }
                            else
                            {
                                txt_fechaHepatitisA1.Text = Convert.ToDateTime(inmu.inmu_fechaHepatitisA1).ToString("yyyy-MM-dd");
                            }                            
                            txt_loteHepatitisA1.Text = inmu.inmu_loteHepatitisA1.ToString();
                            txt_esqueCompleHepatitisA1.Text = inmu.inmu_esqueCompleHepatitisA1.ToString();
                            txt_nomCompleResponVacuHepatitisA1.Text = inmu.inmu_nomCompleResponVacuHepatitisA1.ToString();
                            txt_estaSaludColocoVaciHepatitisA1.Text = inmu.inmu_estaSaludColocoVaciHepatitisA1.ToString();
                            txt_observaHepatitisA1.Text = inmu.inmu_observaHepatitisA1.ToString();
                            if (inmu.inmu_fechaHepatitisA2 == "")
                            {
                                txt_fechaHepatitisA2.Text = inmu.inmu_fechaHepatitisA2.ToString();
                            }
                            else
                            {
                                txt_fechaHepatitisA2.Text = Convert.ToDateTime(inmu.inmu_fechaHepatitisA2).ToString("yyyy-MM-dd");
                            }                            
                            txt_loteHepatitisA2.Text = inmu.inmu_loteHepatitisA2.ToString();
                            txt_esqueCompleHepatitisA2.Text = inmu.inmu_esqueCompleHepatitisA2.ToString();
                            txt_nomCompleResponVacuHepatitisA2.Text = inmu.inmu_nomCompleResponVacuHepatitisA2.ToString();
                            txt_estaSaludColocoVaciHepatitisA2.Text = inmu.inmu_estaSaludColocoVaciHepatitisA2.ToString();
                            txt_observaHepatitisA2.Text = inmu.inmu_observaHepatitisA2.ToString();
                            if (inmu.inmu_fechaHepatitisA3 == "")
                            {
                                txt_fechaHepatitisA3.Text = inmu.inmu_fechaHepatitisA3.ToString();
                            }
                            else
                            {
                                txt_fechaHepatitisA3.Text = Convert.ToDateTime(inmu.inmu_fechaHepatitisA3).ToString("yyyy-MM-dd");
                            }                            
                            txt_loteHepatitisA3.Text = inmu.inmu_loteHepatitisA3.ToString();
                            txt_esqueCompleHepatitisA3.Text = inmu.inmu_esqueCompleHepatitisA3.ToString();
                            txt_nomCompleResponVacuHepatitisA3.Text = inmu.inmu_nomCompleResponVacuHepatitisA3.ToString();
                            txt_estaSaludColocoVaciHepatitisA3.Text = inmu.inmu_estaSaludColocoVaciHepatitisA3.ToString();
                            txt_observaHepatitisA3.Text = inmu.inmu_observaHepatitisA3.ToString();

                            if (inmu.inmu_fechaHepatitisB1 == "")
                            {
                                txt_fechaHepatitisB1.Text = inmu.inmu_fechaHepatitisB1.ToString();
                            }
                            else
                            {
                                txt_fechaHepatitisB1.Text = Convert.ToDateTime(inmu.inmu_fechaHepatitisB1).ToString("yyyy-MM-dd");
                            }                            
                            txt_loteHepatitisB1.Text = inmu.inmu_loteHepatitisB1.ToString();
                            txt_esqueCompleHepatitisB1.Text = inmu.inmu_esqueCompleHepatitisB1.ToString();
                            txt_nomCompleResponVacuHepatitisB1.Text = inmu.inmu_nomCompleResponVacuHepatitisB1.ToString();
                            txt_estaSaludColocoVaciHepatitisB1.Text = inmu.inmu_estaSaludColocoVaciHepatitisB1.ToString();
                            txt_observaHepatitisB1.Text = inmu.inmu_observaHepatitisB1.ToString();
                            if (inmu.inmu_fechaHepatitisB2 == "")
                            {
                                txt_fechaHepatitisB2.Text = inmu.inmu_fechaHepatitisB2.ToString();
                            }
                            else
                            {
                                txt_fechaHepatitisB2.Text = Convert.ToDateTime(inmu.inmu_fechaHepatitisB2).ToString("yyyy-MM-dd");
                            }                            
                            txt_loteHepatitisB2.Text = inmu.inmu_loteHepatitisB2.ToString();
                            txt_esqueCompleHepatitisB2.Text = inmu.inmu_esqueCompleHepatitisB2.ToString();
                            txt_nomCompleResponVacuHepatitisB2.Text = inmu.inmu_nomCompleResponVacuHepatitisB2.ToString();
                            txt_estaSaludColocoVaciHepatitisB2.Text = inmu.inmu_estaSaludColocoVaciHepatitisB2.ToString();
                            txt_observaHepatitisB2.Text = inmu.inmu_observaHepatitisB2.ToString();
                            if (inmu.inmu_fechaHepatitisB3 == "")
                            {
                                txt_fechaHepatitisB3.Text = inmu.inmu_fechaHepatitisB3.ToString();
                            }
                            else
                            {
                                txt_fechaHepatitisB3.Text = Convert.ToDateTime(inmu.inmu_fechaHepatitisB3).ToString("yyyy-MM-dd");
                            }                            
                            txt_loteHepatitisB3.Text = inmu.inmu_loteHepatitisB3.ToString();
                            txt_esqueCompleHepatitisB3.Text = inmu.inmu_esqueCompleHepatitisB3.ToString();
                            txt_nomCompleResponVacuHepatitisB3.Text = inmu.inmu_nomCompleResponVacuHepatitisB3.ToString();
                            txt_estaSaludColocoVaciHepatitisB3.Text = inmu.inmu_estaSaludColocoVaciHepatitisB3.ToString();
                            txt_observaHepatitisB3.Text = inmu.inmu_observaHepatitisB3.ToString();

                            if (inmu.inmu_fechaInfluenza == "")
                            {
                                txt_fechaInfluenza.Text = inmu.inmu_fechaInfluenza.ToString();
                            }
                            else
                            {
                                txt_fechaInfluenza.Text = Convert.ToDateTime(inmu.inmu_fechaInfluenza).ToString("yyyy-MM-dd");
                            }                            
                            txt_loteInfluenza.Text = inmu.inmu_loteInfluenza.ToString();
                            txt_esqueCompleInfluenza.Text = inmu.inmu_esqueCompleInfluenza.ToString();
                            txt_nomCompleResponVacuInfluenza.Text = inmu.inmu_nomCompleResponVacuInfluenza.ToString();
                            txt_estaSaludColocoVacuInfluenza.Text = inmu.inmu_estaSaludColocoVacuInfluenza.ToString();
                            txt_observaInfluenza.Text = inmu.inmu_observaInfluenza.ToString();

                            if (inmu.inmu_fechaFiebreAmarilla == "")
                            {
                                txt_fechaFiebreAmarilla.Text = inmu.inmu_fechaFiebreAmarilla.ToString();
                            }
                            else
                            {
                                txt_fechaFiebreAmarilla.Text = Convert.ToDateTime(inmu.inmu_fechaFiebreAmarilla).ToString("yyyy-MM-dd");
                            }                            
                            txt_loteFiebreAmarilla.Text = inmu.inmu_loteFiebreAmarilla.ToString();
                            txt_esqueCompleFiebreAmarilla.Text = inmu.inmu_esqueCompleFiebreAmarilla.ToString();
                            txt_nomCompleResponVacuFiebreAmarilla.Text = inmu.inmu_nomCompleResponVacuFiebreAmarilla.ToString();
                            txt_estaSaludColocoVacuFiebreAmarilla.Text = inmu.inmu_estaSaludColocoVacuFiebreAmarilla.ToString();
                            txt_observaFiebreAmarilla.Text = inmu.inmu_observaFiebreAmarilla.ToString();

                            if (inmu.inmu_fechaSarampion1 == "")
                            {
                                txt_fechaSarampion1.Text = inmu.inmu_fechaSarampion1.ToString();
                            }
                            else
                            {
                                txt_fechaSarampion1.Text = Convert.ToDateTime(inmu.inmu_fechaSarampion1).ToString("yyyy-MM-dd");
                            }                            
                            txt_loteSarampion1.Text = inmu.inmu_loteSarampion1.ToString();
                            txt_esqueCompleSarampion1.Text = inmu.inmu_esqueCompleSarampion1.ToString();
                            txt_nomCompleResponVacuSarampion1.Text = inmu.inmu_nomCompleResponVacuSarampion1.ToString();
                            txt_estaSaludColocoVacuSarampion1.Text = inmu.inmu_estaSaludColocoVacuSarampion1.ToString();
                            txt_observaSarampion1.Text = inmu.inmu_observaSarampion1.ToString();
                            if (inmu.inmu_fechaSarampion2 == "")
                            {
                                txt_fechaSarampion2.Text = inmu.inmu_fechaSarampion2.ToString();
                            }
                            else
                            {
                                txt_fechaSarampion2.Text = Convert.ToDateTime(inmu.inmu_fechaSarampion2).ToString("yyyy-MM-dd");
                            }                            
                            txt_loteSarampion2.Text = inmu.inmu_loteSarampion2.ToString();
                            txt_esqueCompleSarampion2.Text = inmu.inmu_esqueCompleSarampion2.ToString();
                            txt_nomCompleResponVacuSarampion2.Text = inmu.inmu_nomCompleResponVacuSarampion2.ToString();
                            txt_estaSaludColocoVacuSarampion2.Text = inmu.inmu_estaSaludColocoVacuSarampion2.ToString();
                            txt_observaSarampion2.Text = inmu.inmu_observaSarampion2.ToString();

                            if (inmu.inmu_1fechaInmuAcuerTipoEmpRies1 == "")
                            {
                                txt_1fechaInmuAcuerTipoEmpRies1.Text = inmu.inmu_1fechaInmuAcuerTipoEmpRies1.ToString();
                            }
                            else
                            {
                                txt_1fechaInmuAcuerTipoEmpRies1.Text = Convert.ToDateTime(inmu.inmu_1fechaInmuAcuerTipoEmpRies1).ToString("yyyy-MM-dd");
                            }                            
                            txt_1loteInmuAcuerTipoEmpRies1.Text = inmu.inmu_1loteInmuAcuerTipoEmpRies1.ToString();
                            txt_1esqueCompleInmuAcuerTipoEmpRies1.Text = inmu.inmu_1esqueCompleInmuAcuerTipoEmpRies1.ToString();
                            txt_1nomCompleResponVacuInmuAcuerTipoEmpRies1.Text = inmu.inmu_1nomCompleResponVacuInmuAcuerTipoEmpRies1.ToString();
                            txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies1.Text = inmu.inmu_1estaSaludColocoVacuInmuAcuerTipoEmpRies1.ToString();
                            txt_1observaInmuAcuerTipoEmpRies1.Text = inmu.inmu_1observaInmuAcuerTipoEmpRies1.ToString();
                            if (inmu.inmu_1fechaInmuAcuerTipoEmpRies2 == "")
                            {
                                txt_1fechaInmuAcuerTipoEmpRies2.Text = inmu.inmu_1fechaInmuAcuerTipoEmpRies2.ToString();
                            }
                            else
                            {
                                txt_1fechaInmuAcuerTipoEmpRies2.Text = Convert.ToDateTime(inmu.inmu_1fechaInmuAcuerTipoEmpRies2).ToString("yyyy-MM-dd");
                            }                            
                            txt_1loteInmuAcuerTipoEmpRies2.Text = inmu.inmu_1loteInmuAcuerTipoEmpRies2.ToString();
                            txt_1esqueCompleInmuAcuerTipoEmpRies2.Text = inmu.inmu_1esqueCompleInmuAcuerTipoEmpRies2.ToString();
                            txt_1nomCompleResponVacuInmuAcuerTipoEmpRies2.Text = inmu.inmu_1nomCompleResponVacuInmuAcuerTipoEmpRies2.ToString();
                            txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies2.Text = inmu.inmu_1estaSaludColocoVacuInmuAcuerTipoEmpRies2.ToString();
                            txt_1observaInmuAcuerTipoEmpRies1.Text = inmu.inmu_1observaInmuAcuerTipoEmpRies2.ToString();
                            if (inmu.inmu_1fechaInmuAcuerTipoEmpRies3 == "")
                            {
                                txt_1fechaInmuAcuerTipoEmpRies3.Text = inmu.inmu_1fechaInmuAcuerTipoEmpRies3.ToString();
                            }
                            else
                            {
                                txt_1fechaInmuAcuerTipoEmpRies3.Text = Convert.ToDateTime(inmu.inmu_1fechaInmuAcuerTipoEmpRies3).ToString("yyyy-MM-dd");
                            }                            
                            txt_1loteInmuAcuerTipoEmpRies3.Text = inmu.inmu_1loteInmuAcuerTipoEmpRies3.ToString();
                            txt_1esqueCompleInmuAcuerTipoEmpRies3.Text = inmu.inmu_1esqueCompleInmuAcuerTipoEmpRies3.ToString();
                            txt_1nomCompleResponVacuInmuAcuerTipoEmpRies3.Text = inmu.inmu_1nomCompleResponVacuInmuAcuerTipoEmpRies3.ToString();
                            txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies3.Text = inmu.inmu_1estaSaludColocoVacuInmuAcuerTipoEmpRies3.ToString();
                            txt_1observaInmuAcuerTipoEmpRies3.Text = inmu.inmu_1observaInmuAcuerTipoEmpRies3.ToString();
                            if (inmu.inmu_1fechaInmuAcuerTipoEmpRies4 == "")
                            {
                                txt_1fechaInmuAcuerTipoEmpRies4.Text = inmu.inmu_1fechaInmuAcuerTipoEmpRies4.ToString();
                            }
                            else
                            {
                                txt_1fechaInmuAcuerTipoEmpRies4.Text = Convert.ToDateTime(inmu.inmu_1fechaInmuAcuerTipoEmpRies4).ToString("yyyy-MM-dd");
                            }                            
                            txt_1loteInmuAcuerTipoEmpRies4.Text = inmu.inmu_1loteInmuAcuerTipoEmpRies4.ToString();
                            txt_1esqueCompleInmuAcuerTipoEmpRies4.Text = inmu.inmu_1esqueCompleInmuAcuerTipoEmpRies4.ToString();
                            txt_1nomCompleResponVacuInmuAcuerTipoEmpRies4.Text = inmu.inmu_1nomCompleResponVacuInmuAcuerTipoEmpRies4.ToString();
                            txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies4.Text = inmu.inmu_1estaSaludColocoVacuInmuAcuerTipoEmpRies4.ToString();
                            txt_1observaInmuAcuerTipoEmpRies4.Text = inmu.inmu_1observaInmuAcuerTipoEmpRies4.ToString();
                            if (inmu.inmu_1fechaInmuAcuerTipoEmpRies5 == "")
                            {
                                txt_1fechaInmuAcuerTipoEmpRies5.Text = inmu.inmu_1fechaInmuAcuerTipoEmpRies5.ToString();
                            }
                            else
                            {
                                txt_1fechaInmuAcuerTipoEmpRies5.Text = Convert.ToDateTime(inmu.inmu_1fechaInmuAcuerTipoEmpRies5).ToString("yyyy-MM-dd");
                            }                            
                            txt_1loteInmuAcuerTipoEmpRies5.Text = inmu.inmu_1loteInmuAcuerTipoEmpRies5.ToString();
                            txt_1esqueCompleInmuAcuerTipoEmpRies5.Text = inmu.inmu_1esqueCompleInmuAcuerTipoEmpRies5.ToString();
                            txt_1nomCompleResponVacuInmuAcuerTipoEmpRies5.Text = inmu.inmu_1nomCompleResponVacuInmuAcuerTipoEmpRies5.ToString();
                            txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies5.Text = inmu.inmu_1estaSaludColocoVacuInmuAcuerTipoEmpRies1.ToString();
                            txt_1observaInmuAcuerTipoEmpRies5.Text = inmu.inmu_1observaInmuAcuerTipoEmpRies5.ToString();
                            if (inmu.inmu_2fechaInmuAcuerTipoEmpRies1 == "")
                            {
                                txt_2fechaInmuAcuerTipoEmpRies1.Text = inmu.inmu_2fechaInmuAcuerTipoEmpRies1.ToString();
                            }
                            else
                            {
                                txt_2fechaInmuAcuerTipoEmpRies1.Text = Convert.ToDateTime(inmu.inmu_2fechaInmuAcuerTipoEmpRies1).ToString("yyyy-MM-dd");
                            }                            
                            txt_2loteInmuAcuerTipoEmpRies1.Text = inmu.inmu_2loteInmuAcuerTipoEmpRies1.ToString();
                            txt_2esqueCompleInmuAcuerTipoEmpRies1.Text = inmu.inmu_2esqueCompleInmuAcuerTipoEmpRies1.ToString();
                            txt_2nomCompleResponVacuInmuAcuerTipoEmpRies1.Text = inmu.inmu_2nomCompleResponVacuInmuAcuerTipoEmpRies1.ToString();
                            txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies1.Text = inmu.inmu_2estaSaludColocoVacuInmuAcuerTipoEmpRies1.ToString();
                            txt_2observaInmuAcuerTipoEmpRies1.Text = inmu.inmu_2observaInmuAcuerTipoEmpRies1.ToString();
                            if (inmu.inmu_2fechaInmuAcuerTipoEmpRies2== "")
                            {
                                txt_2fechaInmuAcuerTipoEmpRies2.Text = inmu.inmu_2fechaInmuAcuerTipoEmpRies2.ToString();
                            }
                            else
                            {
                                txt_2fechaInmuAcuerTipoEmpRies2.Text = Convert.ToDateTime(inmu.inmu_2fechaInmuAcuerTipoEmpRies2).ToString("yyyy-MM-dd");
                            }                            
                            txt_2loteInmuAcuerTipoEmpRies2.Text = inmu.inmu_2loteInmuAcuerTipoEmpRies2.ToString();
                            txt_2esqueCompleInmuAcuerTipoEmpRies2.Text = inmu.inmu_2esqueCompleInmuAcuerTipoEmpRies2.ToString();
                            txt_2nomCompleResponVacuInmuAcuerTipoEmpRies2.Text = inmu.inmu_2nomCompleResponVacuInmuAcuerTipoEmpRies2.ToString();
                            txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies2.Text = inmu.inmu_2estaSaludColocoVacuInmuAcuerTipoEmpRies2.ToString();
                            txt_2observaInmuAcuerTipoEmpRies1.Text = inmu.inmu_2observaInmuAcuerTipoEmpRies2.ToString();
                            if (inmu.inmu_2fechaInmuAcuerTipoEmpRies3 == "")
                            {
                                txt_2fechaInmuAcuerTipoEmpRies3.Text = inmu.inmu_2fechaInmuAcuerTipoEmpRies3.ToString();
                            }
                            else
                            {
                                txt_2fechaInmuAcuerTipoEmpRies3.Text = Convert.ToDateTime(inmu.inmu_2fechaInmuAcuerTipoEmpRies3).ToString("yyyy-MM-dd");
                            }                            
                            txt_2loteInmuAcuerTipoEmpRies3.Text = inmu.inmu_2loteInmuAcuerTipoEmpRies3.ToString();
                            txt_2esqueCompleInmuAcuerTipoEmpRies3.Text = inmu.inmu_2esqueCompleInmuAcuerTipoEmpRies3.ToString();
                            txt_2nomCompleResponVacuInmuAcuerTipoEmpRies3.Text = inmu.inmu_2nomCompleResponVacuInmuAcuerTipoEmpRies3.ToString();
                            txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies3.Text = inmu.inmu_2estaSaludColocoVacuInmuAcuerTipoEmpRies3.ToString();
                            txt_2observaInmuAcuerTipoEmpRies3.Text = inmu.inmu_2observaInmuAcuerTipoEmpRies3.ToString();
                            if (inmu.inmu_2fechaInmuAcuerTipoEmpRies4 == "")
                            {
                                txt_2fechaInmuAcuerTipoEmpRies4.Text = inmu.inmu_2fechaInmuAcuerTipoEmpRies4.ToString();
                            }
                            else
                            {
                                txt_2fechaInmuAcuerTipoEmpRies4.Text = Convert.ToDateTime(inmu.inmu_2fechaInmuAcuerTipoEmpRies4).ToString("yyyy-MM-dd");
                            }                            
                            txt_2loteInmuAcuerTipoEmpRies4.Text = inmu.inmu_2loteInmuAcuerTipoEmpRies4.ToString();
                            txt_2esqueCompleInmuAcuerTipoEmpRies4.Text = inmu.inmu_2esqueCompleInmuAcuerTipoEmpRies4.ToString();
                            txt_2nomCompleResponVacuInmuAcuerTipoEmpRies4.Text = inmu.inmu_2nomCompleResponVacuInmuAcuerTipoEmpRies4.ToString();
                            txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies4.Text = inmu.inmu_2estaSaludColocoVacuInmuAcuerTipoEmpRies4.ToString();
                            txt_2observaInmuAcuerTipoEmpRies4.Text = inmu.inmu_2observaInmuAcuerTipoEmpRies4.ToString();
                            if (inmu.inmu_2fechaInmuAcuerTipoEmpRies5 == "")
                            {
                                txt_2fechaInmuAcuerTipoEmpRies5.Text = inmu.inmu_2fechaInmuAcuerTipoEmpRies5.ToString();
                            }
                            else
                            {
                                txt_2fechaInmuAcuerTipoEmpRies5.Text = Convert.ToDateTime(inmu.inmu_2fechaInmuAcuerTipoEmpRies5).ToString("yyyy-MM-dd");
                            }                            
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

                string cargo = item.Per_cargoOcupacion;
                txt_cargo.Text = cargo;
            }
        }

        private void GuardarInmunizaciones()
        {
            try
            {
                per = CN_HistorialMedico.ObtenerIdPersonasxCedula(Convert.ToInt32(txt_numHClinica.Text));

                int perso = Convert.ToInt32(per.Per_id.ToString());

                inmu = new Tbl_Inmunizaciones();

                //A. Captura de datos Establecimiento
                inmu.inmu_numArchivo = txt_numArchivo.Text;

                //B. Captura de datos Inmunizaciones
                inmu.inmu_fechaTetanos1 = txt_fechatetanos1.Text;
                inmu.inmu_loteTetanos1 = txt_loteTetanos1.Text;
                inmu.inmu_esqueCompleTetanos1 = txt_esqueCompleTetanos1.Text;
                inmu.inmu_nomCompleResponVacuTetanos1 = txt_nomCompleResponVacuTetanos1.Text;
                inmu.inmu_estaSaludColocoVacuTetanos1 = txt_estaSaludColocoVacuTetanos1.Text;
                inmu.inmu_observaTetanos1 = txt_observaTetanos1.Text;
                inmu.inmu_fechaTetanos2 = txt_fechatetanos2.Text;
                inmu.inmu_loteTetanos2 = txt_loteTetanos2.Text;
                inmu.inmu_esqueCompleTetanos2 = txt_esqueCompleTetanos2.Text;
                inmu.inmu_nomCompleResponVacuTetanos2 = txt_nomCompleResponVacuTetanos2.Text;
                inmu.inmu_estaSaludColocoVacuTetanos2 = txt_estaSaludColocoVacuTetanos2.Text;
                inmu.inmu_observaTetanos2 = txt_observaTetanos2.Text;
                inmu.inmu_fechaTetanos3 = txt_fechatetanos2.Text;
                inmu.inmu_loteTetanos3 = txt_loteTetanos3.Text;
                inmu.inmu_esqueCompleTetanos3 = txt_esqueCompleTetanos3.Text;
                inmu.inmu_nomCompleResponVacuTetanos3 = txt_nomCompleResponVacuTetanos3.Text;
                inmu.inmu_estaSaludColocoVacuTetanos3 = txt_estaSaludColocoVacuTetanos3.Text;
                inmu.inmu_observaTetanos3 = txt_observaTetanos3.Text;
                inmu.inmu_fechaTetanos4 = txt_fechatetanos4.Text;
                inmu.inmu_loteTetanos4 = txt_loteTetanos4.Text;
                inmu.inmu_esqueCompleTetanos4 = txt_esqueCompleTetanos4.Text;
                inmu.inmu_nomCompleResponVacuTetanos4 = txt_nomCompleResponVacuTetanos4.Text;
                inmu.inmu_estaSaludColocoVacuTetanos4 = txt_estaSaludColocoVacuTetanos4.Text;
                inmu.inmu_observaTetanos4 = txt_observaTetanos4.Text;
                inmu.inmu_fechaTetanos5 = txt_fechatetanos5.Text;
                inmu.inmu_loteTetanos5 = txt_loteTetanos5.Text;
                inmu.inmu_esqueCompleTetanos5 = txt_esqueCompleTetanos5.Text;
                inmu.inmu_nomCompleResponVacuTetanos5 = txt_nomCompleResponVacuTetanos5.Text;
                inmu.inmu_estaSaludColocoVacuTetanos5 = txt_estaSaludColocoVacuTetanos5.Text;
                inmu.inmu_observaTetanos5 = txt_observaTetanos5.Text;

                inmu.inmu_fechaHepatitisA1 = txt_fechaHepatitisA1.Text;
                inmu.inmu_loteHepatitisA1 = txt_loteHepatitisA1.Text;
                inmu.inmu_esqueCompleHepatitisA1 = txt_esqueCompleHepatitisA1.Text;
                inmu.inmu_nomCompleResponVacuHepatitisA1 = txt_nomCompleResponVacuHepatitisA1.Text;
                inmu.inmu_estaSaludColocoVaciHepatitisA1 = txt_estaSaludColocoVaciHepatitisA1.Text;
                inmu.inmu_observaHepatitisA1 = txt_observaHepatitisA1.Text;
                inmu.inmu_fechaHepatitisA2 = txt_fechaHepatitisA2.Text;
                inmu.inmu_loteHepatitisA2 = txt_loteHepatitisA2.Text;
                inmu.inmu_esqueCompleHepatitisA2 = txt_esqueCompleHepatitisA2.Text;
                inmu.inmu_nomCompleResponVacuHepatitisA2 = txt_nomCompleResponVacuHepatitisA2.Text;
                inmu.inmu_estaSaludColocoVaciHepatitisA2 = txt_estaSaludColocoVaciHepatitisA2.Text;
                inmu.inmu_observaHepatitisA2 = txt_observaHepatitisA2.Text;
                inmu.inmu_fechaHepatitisA3 = txt_fechaHepatitisA3.Text;
                inmu.inmu_loteHepatitisA3 = txt_loteHepatitisA3.Text;
                inmu.inmu_esqueCompleHepatitisA3 = txt_esqueCompleHepatitisA3.Text;
                inmu.inmu_nomCompleResponVacuHepatitisA3 = txt_nomCompleResponVacuHepatitisA3.Text;
                inmu.inmu_estaSaludColocoVaciHepatitisA3 = txt_estaSaludColocoVaciHepatitisA3.Text;
                inmu.inmu_observaHepatitisA3 = txt_observaHepatitisA3.Text;

                inmu.inmu_fechaHepatitisB1 = txt_fechaHepatitisB1.Text;
                inmu.inmu_loteHepatitisB1 = txt_loteHepatitisB1.Text;
                inmu.inmu_esqueCompleHepatitisB1 = txt_esqueCompleHepatitisB1.Text;
                inmu.inmu_nomCompleResponVacuHepatitisB1 = txt_nomCompleResponVacuHepatitisB1.Text;
                inmu.inmu_estaSaludColocoVaciHepatitisB1 = txt_estaSaludColocoVaciHepatitisB1.Text;
                inmu.inmu_observaHepatitisB1 = txt_observaHepatitisB1.Text;
                inmu.inmu_fechaHepatitisB2 = txt_fechaHepatitisB2.Text;
                inmu.inmu_loteHepatitisB2 = txt_loteHepatitisB2.Text;
                inmu.inmu_esqueCompleHepatitisB2 = txt_esqueCompleHepatitisB2.Text;
                inmu.inmu_nomCompleResponVacuHepatitisB2 = txt_nomCompleResponVacuHepatitisB2.Text;
                inmu.inmu_estaSaludColocoVaciHepatitisB2 = txt_estaSaludColocoVaciHepatitisB2.Text;
                inmu.inmu_observaHepatitisB2 = txt_observaHepatitisB2.Text;
                inmu.inmu_fechaHepatitisB3 = txt_fechaHepatitisB3.Text;
                inmu.inmu_loteHepatitisB3 = txt_loteHepatitisB3.Text;
                inmu.inmu_esqueCompleHepatitisB3 = txt_esqueCompleHepatitisB3.Text;
                inmu.inmu_nomCompleResponVacuHepatitisB3 = txt_nomCompleResponVacuHepatitisB3.Text;
                inmu.inmu_estaSaludColocoVaciHepatitisB3 = txt_estaSaludColocoVaciHepatitisB3.Text;
                inmu.inmu_observaHepatitisB3 = txt_observaHepatitisB3.Text;

                inmu.inmu_fechaInfluenza = txt_fechaInfluenza.Text;
                inmu.inmu_loteInfluenza = txt_loteInfluenza.Text;
                inmu.inmu_esqueCompleInfluenza = txt_esqueCompleInfluenza.Text;
                inmu.inmu_nomCompleResponVacuInfluenza = txt_nomCompleResponVacuInfluenza.Text;
                inmu.inmu_estaSaludColocoVacuInfluenza = txt_estaSaludColocoVacuInfluenza.Text;
                inmu.inmu_observaInfluenza = txt_observaInfluenza.Text;

                inmu.inmu_fechaFiebreAmarilla = txt_fechaFiebreAmarilla.Text;
                inmu.inmu_loteFiebreAmarilla = txt_loteFiebreAmarilla.Text;
                inmu.inmu_esqueCompleFiebreAmarilla = txt_esqueCompleFiebreAmarilla.Text;
                inmu.inmu_nomCompleResponVacuFiebreAmarilla = txt_nomCompleResponVacuFiebreAmarilla.Text;
                inmu.inmu_estaSaludColocoVacuFiebreAmarilla = txt_estaSaludColocoVacuFiebreAmarilla.Text;
                inmu.inmu_observaFiebreAmarilla = txt_observaFiebreAmarilla.Text;

                inmu.inmu_fechaSarampion1 = txt_fechaSarampion1.Text;
                inmu.inmu_loteSarampion1 = txt_loteSarampion1.Text;
                inmu.inmu_esqueCompleSarampion1 = txt_esqueCompleSarampion1.Text;
                inmu.inmu_nomCompleResponVacuSarampion1 = txt_nomCompleResponVacuSarampion1.Text;
                inmu.inmu_estaSaludColocoVacuSarampion1 = txt_estaSaludColocoVacuSarampion1.Text;
                inmu.inmu_observaSarampion1 = txt_observaSarampion1.Text;
                inmu.inmu_fechaSarampion2 = txt_fechaSarampion2.Text;
                inmu.inmu_loteSarampion2 = txt_loteSarampion2.Text;
                inmu.inmu_esqueCompleSarampion2 = txt_esqueCompleSarampion2.Text;
                inmu.inmu_nomCompleResponVacuSarampion2 = txt_nomCompleResponVacuSarampion2.Text;
                inmu.inmu_estaSaludColocoVacuSarampion2 = txt_estaSaludColocoVacuSarampion2.Text;
                inmu.inmu_observaSarampion2 = txt_observaSarampion2.Text;

                inmu.inmu_1fechaInmuAcuerTipoEmpRies1 = txt_1fechaInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_1loteInmuAcuerTipoEmpRies1 = txt_1loteInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_1esqueCompleInmuAcuerTipoEmpRies1 = txt_1esqueCompleInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_1nomCompleResponVacuInmuAcuerTipoEmpRies1 = txt_1nomCompleResponVacuInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_1estaSaludColocoVacuInmuAcuerTipoEmpRies1 = txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_1observaInmuAcuerTipoEmpRies1 = txt_1observaInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_1fechaInmuAcuerTipoEmpRies2 = txt_1fechaInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_1loteInmuAcuerTipoEmpRies2 = txt_1loteInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_1esqueCompleInmuAcuerTipoEmpRies2 = txt_1esqueCompleInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_1nomCompleResponVacuInmuAcuerTipoEmpRies2 = txt_1nomCompleResponVacuInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_1estaSaludColocoVacuInmuAcuerTipoEmpRies2 = txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_1observaInmuAcuerTipoEmpRies2 = txt_1observaInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_1fechaInmuAcuerTipoEmpRies3 = txt_1fechaInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_1loteInmuAcuerTipoEmpRies3 = txt_1loteInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_1esqueCompleInmuAcuerTipoEmpRies3 = txt_1esqueCompleInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_1nomCompleResponVacuInmuAcuerTipoEmpRies3 = txt_1nomCompleResponVacuInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_1estaSaludColocoVacuInmuAcuerTipoEmpRies3 = txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_1observaInmuAcuerTipoEmpRies3 = txt_1observaInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_1fechaInmuAcuerTipoEmpRies4 = txt_1fechaInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_1loteInmuAcuerTipoEmpRies4 = txt_1loteInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_1esqueCompleInmuAcuerTipoEmpRies4 = txt_1esqueCompleInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_1nomCompleResponVacuInmuAcuerTipoEmpRies4 = txt_1nomCompleResponVacuInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_1estaSaludColocoVacuInmuAcuerTipoEmpRies4 = txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_1observaInmuAcuerTipoEmpRies4 = txt_1observaInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_1fechaInmuAcuerTipoEmpRies5 = txt_1fechaInmuAcuerTipoEmpRies5.Text;
                inmu.inmu_1loteInmuAcuerTipoEmpRies5 = txt_1loteInmuAcuerTipoEmpRies5.Text;
                inmu.inmu_1esqueCompleInmuAcuerTipoEmpRies5 = txt_1esqueCompleInmuAcuerTipoEmpRies5.Text;
                inmu.inmu_1nomCompleResponVacuInmuAcuerTipoEmpRies5 = txt_1nomCompleResponVacuInmuAcuerTipoEmpRies5.Text;
                inmu.inmu_1estaSaludColocoVacuInmuAcuerTipoEmpRies5 = txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies5.Text;
                inmu.inmu_1observaInmuAcuerTipoEmpRies5 = txt_1observaInmuAcuerTipoEmpRies5.Text;

                inmu.inmu_2fechaInmuAcuerTipoEmpRies1 = txt_2fechaInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_2loteInmuAcuerTipoEmpRies1 = txt_2loteInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_2esqueCompleInmuAcuerTipoEmpRies1 = txt_2esqueCompleInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_2nomCompleResponVacuInmuAcuerTipoEmpRies1 = txt_2nomCompleResponVacuInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_2estaSaludColocoVacuInmuAcuerTipoEmpRies1 = txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_2observaInmuAcuerTipoEmpRies1 = txt_2observaInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_2fechaInmuAcuerTipoEmpRies2 = txt_2fechaInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_2loteInmuAcuerTipoEmpRies2 = txt_2loteInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_2esqueCompleInmuAcuerTipoEmpRies2 = txt_2esqueCompleInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_2nomCompleResponVacuInmuAcuerTipoEmpRies2 = txt_2nomCompleResponVacuInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_2estaSaludColocoVacuInmuAcuerTipoEmpRies2 = txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_2observaInmuAcuerTipoEmpRies2 = txt_2observaInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_2fechaInmuAcuerTipoEmpRies3 = txt_2fechaInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_2loteInmuAcuerTipoEmpRies3 = txt_2loteInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_2esqueCompleInmuAcuerTipoEmpRies3 = txt_2esqueCompleInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_2nomCompleResponVacuInmuAcuerTipoEmpRies3 = txt_2nomCompleResponVacuInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_2estaSaludColocoVacuInmuAcuerTipoEmpRies3 = txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_2observaInmuAcuerTipoEmpRies3 = txt_2observaInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_2fechaInmuAcuerTipoEmpRies4 = txt_2fechaInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_2loteInmuAcuerTipoEmpRies4 = txt_2loteInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_2esqueCompleInmuAcuerTipoEmpRies4 = txt_2esqueCompleInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_2nomCompleResponVacuInmuAcuerTipoEmpRies4 = txt_2nomCompleResponVacuInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_2estaSaludColocoVacuInmuAcuerTipoEmpRies4 = txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_2observaInmuAcuerTipoEmpRies4 = txt_2observaInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_2fechaInmuAcuerTipoEmpRies5 = txt_2fechaInmuAcuerTipoEmpRies5.Text;
                inmu.inmu_2loteInmuAcuerTipoEmpRies5 = txt_2loteInmuAcuerTipoEmpRies5.Text;
                inmu.inmu_2esqueCompleInmuAcuerTipoEmpRies5 = txt_2esqueCompleInmuAcuerTipoEmpRies5.Text;
                inmu.inmu_2nomCompleResponVacuInmuAcuerTipoEmpRies5 = txt_2nomCompleResponVacuInmuAcuerTipoEmpRies5.Text;
                inmu.inmu_2estaSaludColocoVacuInmuAcuerTipoEmpRies5 = txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies5.Text;
                inmu.inmu_2observaInmuAcuerTipoEmpRies5 = txt_2observaInmuAcuerTipoEmpRies5.Text;

                inmu.Per_id = perso;
                
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
                //A. Captura de datos Establecimiento
                inmu.inmu_numArchivo = txt_numArchivo.Text;

                //B. Captura de datos Inmunizaciones
                inmu.inmu_fechaTetanos1 = txt_fechatetanos1.Text;
                inmu.inmu_loteTetanos1 = txt_loteTetanos1.Text;
                inmu.inmu_esqueCompleTetanos1 = txt_esqueCompleTetanos1.Text;
                inmu.inmu_nomCompleResponVacuTetanos1 = txt_nomCompleResponVacuTetanos1.Text;
                inmu.inmu_estaSaludColocoVacuTetanos1 = txt_estaSaludColocoVacuTetanos1.Text;
                inmu.inmu_observaTetanos1 = txt_observaTetanos1.Text;
                inmu.inmu_fechaTetanos2 = txt_fechatetanos2.Text;
                inmu.inmu_loteTetanos2 = txt_loteTetanos2.Text;
                inmu.inmu_esqueCompleTetanos2 = txt_esqueCompleTetanos2.Text;
                inmu.inmu_nomCompleResponVacuTetanos2 = txt_nomCompleResponVacuTetanos2.Text;
                inmu.inmu_estaSaludColocoVacuTetanos2 = txt_estaSaludColocoVacuTetanos2.Text;
                inmu.inmu_observaTetanos2 = txt_observaTetanos2.Text;
                inmu.inmu_fechaTetanos3 = txt_fechatetanos2.Text;
                inmu.inmu_loteTetanos3 = txt_loteTetanos3.Text;
                inmu.inmu_esqueCompleTetanos3 = txt_esqueCompleTetanos3.Text;
                inmu.inmu_nomCompleResponVacuTetanos3 = txt_nomCompleResponVacuTetanos3.Text;
                inmu.inmu_estaSaludColocoVacuTetanos3 = txt_estaSaludColocoVacuTetanos3.Text;
                inmu.inmu_observaTetanos3 = txt_observaTetanos3.Text;
                inmu.inmu_fechaTetanos4 = txt_fechatetanos4.Text;
                inmu.inmu_loteTetanos4 = txt_loteTetanos4.Text;
                inmu.inmu_esqueCompleTetanos4 = txt_esqueCompleTetanos4.Text;
                inmu.inmu_nomCompleResponVacuTetanos4 = txt_nomCompleResponVacuTetanos4.Text;
                inmu.inmu_estaSaludColocoVacuTetanos4 = txt_estaSaludColocoVacuTetanos4.Text;
                inmu.inmu_observaTetanos4 = txt_observaTetanos4.Text;
                inmu.inmu_fechaTetanos5 = txt_fechatetanos5.Text;
                inmu.inmu_loteTetanos5 = txt_loteTetanos5.Text;
                inmu.inmu_esqueCompleTetanos5 = txt_esqueCompleTetanos5.Text;
                inmu.inmu_nomCompleResponVacuTetanos5 = txt_nomCompleResponVacuTetanos5.Text;
                inmu.inmu_estaSaludColocoVacuTetanos5 = txt_estaSaludColocoVacuTetanos5.Text;
                inmu.inmu_observaTetanos5 = txt_observaTetanos5.Text;

                inmu.inmu_fechaHepatitisA1 = txt_fechaHepatitisA1.Text;
                inmu.inmu_loteHepatitisA1 = txt_loteHepatitisA1.Text;
                inmu.inmu_esqueCompleHepatitisA1 = txt_esqueCompleHepatitisA1.Text;
                inmu.inmu_nomCompleResponVacuHepatitisA1 = txt_nomCompleResponVacuHepatitisA1.Text;
                inmu.inmu_estaSaludColocoVaciHepatitisA1 = txt_estaSaludColocoVaciHepatitisA1.Text;
                inmu.inmu_observaHepatitisA1 = txt_observaHepatitisA1.Text;
                inmu.inmu_fechaHepatitisA2 = txt_fechaHepatitisA2.Text;
                inmu.inmu_loteHepatitisA2 = txt_loteHepatitisA2.Text;
                inmu.inmu_esqueCompleHepatitisA2 = txt_esqueCompleHepatitisA2.Text;
                inmu.inmu_nomCompleResponVacuHepatitisA2 = txt_nomCompleResponVacuHepatitisA2.Text;
                inmu.inmu_estaSaludColocoVaciHepatitisA2 = txt_estaSaludColocoVaciHepatitisA2.Text;
                inmu.inmu_observaHepatitisA2 = txt_observaHepatitisA2.Text;
                inmu.inmu_fechaHepatitisA3 = txt_fechaHepatitisA3.Text;
                inmu.inmu_loteHepatitisA3 = txt_loteHepatitisA3.Text;
                inmu.inmu_esqueCompleHepatitisA3 = txt_esqueCompleHepatitisA3.Text;
                inmu.inmu_nomCompleResponVacuHepatitisA3 = txt_nomCompleResponVacuHepatitisA3.Text;
                inmu.inmu_estaSaludColocoVaciHepatitisA3 = txt_estaSaludColocoVaciHepatitisA3.Text;
                inmu.inmu_observaHepatitisA3 = txt_observaHepatitisA3.Text;

                inmu.inmu_fechaHepatitisB1 = txt_fechaHepatitisB1.Text;
                inmu.inmu_loteHepatitisB1 = txt_loteHepatitisB1.Text;
                inmu.inmu_esqueCompleHepatitisB1 = txt_esqueCompleHepatitisB1.Text;
                inmu.inmu_nomCompleResponVacuHepatitisB1 = txt_nomCompleResponVacuHepatitisB1.Text;
                inmu.inmu_estaSaludColocoVaciHepatitisB1 = txt_estaSaludColocoVaciHepatitisB1.Text;
                inmu.inmu_observaHepatitisB1 = txt_observaHepatitisB1.Text;
                inmu.inmu_fechaHepatitisB2 = txt_fechaHepatitisB2.Text;
                inmu.inmu_loteHepatitisB2 = txt_loteHepatitisB2.Text;
                inmu.inmu_esqueCompleHepatitisB2 = txt_esqueCompleHepatitisB2.Text;
                inmu.inmu_nomCompleResponVacuHepatitisB2 = txt_nomCompleResponVacuHepatitisB2.Text;
                inmu.inmu_estaSaludColocoVaciHepatitisB2 = txt_estaSaludColocoVaciHepatitisB2.Text;
                inmu.inmu_observaHepatitisB2 = txt_observaHepatitisB2.Text;
                inmu.inmu_fechaHepatitisB3 = txt_fechaHepatitisB3.Text;
                inmu.inmu_loteHepatitisB3 = txt_loteHepatitisB3.Text;
                inmu.inmu_esqueCompleHepatitisB3 = txt_esqueCompleHepatitisB3.Text;
                inmu.inmu_nomCompleResponVacuHepatitisB3 = txt_nomCompleResponVacuHepatitisB3.Text;
                inmu.inmu_estaSaludColocoVaciHepatitisB3 = txt_estaSaludColocoVaciHepatitisB3.Text;
                inmu.inmu_observaHepatitisB3 = txt_observaHepatitisB3.Text;

                inmu.inmu_fechaInfluenza = txt_fechaInfluenza.Text;
                inmu.inmu_loteInfluenza = txt_loteInfluenza.Text;
                inmu.inmu_esqueCompleInfluenza = txt_esqueCompleInfluenza.Text;
                inmu.inmu_nomCompleResponVacuInfluenza = txt_nomCompleResponVacuInfluenza.Text;
                inmu.inmu_estaSaludColocoVacuInfluenza = txt_estaSaludColocoVacuInfluenza.Text;
                inmu.inmu_observaInfluenza = txt_observaInfluenza.Text;

                inmu.inmu_fechaFiebreAmarilla = txt_fechaFiebreAmarilla.Text;
                inmu.inmu_loteFiebreAmarilla = txt_loteFiebreAmarilla.Text;
                inmu.inmu_esqueCompleFiebreAmarilla = txt_esqueCompleFiebreAmarilla.Text;
                inmu.inmu_nomCompleResponVacuFiebreAmarilla = txt_nomCompleResponVacuFiebreAmarilla.Text;
                inmu.inmu_estaSaludColocoVacuFiebreAmarilla = txt_estaSaludColocoVacuFiebreAmarilla.Text;
                inmu.inmu_observaFiebreAmarilla = txt_observaFiebreAmarilla.Text;

                inmu.inmu_fechaSarampion1 = txt_fechaSarampion1.Text;
                inmu.inmu_loteSarampion1 = txt_loteSarampion1.Text;
                inmu.inmu_esqueCompleSarampion1 = txt_esqueCompleSarampion1.Text;
                inmu.inmu_nomCompleResponVacuSarampion1 = txt_nomCompleResponVacuSarampion1.Text;
                inmu.inmu_estaSaludColocoVacuSarampion1 = txt_estaSaludColocoVacuSarampion1.Text;
                inmu.inmu_observaSarampion1 = txt_observaSarampion1.Text;
                inmu.inmu_fechaSarampion2 = txt_fechaSarampion2.Text;
                inmu.inmu_loteSarampion2 = txt_loteSarampion2.Text;
                inmu.inmu_esqueCompleSarampion2 = txt_esqueCompleSarampion2.Text;
                inmu.inmu_nomCompleResponVacuSarampion2 = txt_nomCompleResponVacuSarampion2.Text;
                inmu.inmu_estaSaludColocoVacuSarampion2 = txt_estaSaludColocoVacuSarampion2.Text;
                inmu.inmu_observaSarampion2 = txt_observaSarampion2.Text;

                inmu.inmu_1fechaInmuAcuerTipoEmpRies1 = txt_1fechaInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_1loteInmuAcuerTipoEmpRies1 = txt_1loteInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_1esqueCompleInmuAcuerTipoEmpRies1 = txt_1esqueCompleInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_1nomCompleResponVacuInmuAcuerTipoEmpRies1 = txt_1nomCompleResponVacuInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_1estaSaludColocoVacuInmuAcuerTipoEmpRies1 = txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_1observaInmuAcuerTipoEmpRies1 = txt_1observaInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_1fechaInmuAcuerTipoEmpRies2 = txt_1fechaInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_1loteInmuAcuerTipoEmpRies2 = txt_1loteInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_1esqueCompleInmuAcuerTipoEmpRies2 = txt_1esqueCompleInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_1nomCompleResponVacuInmuAcuerTipoEmpRies2 = txt_1nomCompleResponVacuInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_1estaSaludColocoVacuInmuAcuerTipoEmpRies2 = txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_1observaInmuAcuerTipoEmpRies2 = txt_1observaInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_1fechaInmuAcuerTipoEmpRies3 = txt_1fechaInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_1loteInmuAcuerTipoEmpRies3 = txt_1loteInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_1esqueCompleInmuAcuerTipoEmpRies3 = txt_1esqueCompleInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_1nomCompleResponVacuInmuAcuerTipoEmpRies3 = txt_1nomCompleResponVacuInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_1estaSaludColocoVacuInmuAcuerTipoEmpRies3 = txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_1observaInmuAcuerTipoEmpRies3 = txt_1observaInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_1fechaInmuAcuerTipoEmpRies4 = txt_1fechaInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_1loteInmuAcuerTipoEmpRies4 = txt_1loteInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_1esqueCompleInmuAcuerTipoEmpRies4 = txt_1esqueCompleInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_1nomCompleResponVacuInmuAcuerTipoEmpRies4 = txt_1nomCompleResponVacuInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_1estaSaludColocoVacuInmuAcuerTipoEmpRies4 = txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_1observaInmuAcuerTipoEmpRies4 = txt_1observaInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_1fechaInmuAcuerTipoEmpRies5 = txt_1fechaInmuAcuerTipoEmpRies5.Text;
                inmu.inmu_1loteInmuAcuerTipoEmpRies5 = txt_1loteInmuAcuerTipoEmpRies5.Text;
                inmu.inmu_1esqueCompleInmuAcuerTipoEmpRies5 = txt_1esqueCompleInmuAcuerTipoEmpRies5.Text;
                inmu.inmu_1nomCompleResponVacuInmuAcuerTipoEmpRies5 = txt_1nomCompleResponVacuInmuAcuerTipoEmpRies5.Text;
                inmu.inmu_1estaSaludColocoVacuInmuAcuerTipoEmpRies5 = txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies5.Text;
                inmu.inmu_1observaInmuAcuerTipoEmpRies5 = txt_1observaInmuAcuerTipoEmpRies5.Text;

                inmu.inmu_2fechaInmuAcuerTipoEmpRies1 = txt_2fechaInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_2loteInmuAcuerTipoEmpRies1 = txt_2loteInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_2esqueCompleInmuAcuerTipoEmpRies1 = txt_2esqueCompleInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_2nomCompleResponVacuInmuAcuerTipoEmpRies1 = txt_2nomCompleResponVacuInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_2estaSaludColocoVacuInmuAcuerTipoEmpRies1 = txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_2observaInmuAcuerTipoEmpRies1 = txt_2observaInmuAcuerTipoEmpRies1.Text;
                inmu.inmu_2fechaInmuAcuerTipoEmpRies2 = txt_2fechaInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_2loteInmuAcuerTipoEmpRies2 = txt_2loteInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_2esqueCompleInmuAcuerTipoEmpRies2 = txt_2esqueCompleInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_2nomCompleResponVacuInmuAcuerTipoEmpRies2 = txt_2nomCompleResponVacuInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_2estaSaludColocoVacuInmuAcuerTipoEmpRies2 = txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_2observaInmuAcuerTipoEmpRies2 = txt_2observaInmuAcuerTipoEmpRies2.Text;
                inmu.inmu_2fechaInmuAcuerTipoEmpRies3 = txt_2fechaInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_2loteInmuAcuerTipoEmpRies3 = txt_2loteInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_2esqueCompleInmuAcuerTipoEmpRies3 = txt_2esqueCompleInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_2nomCompleResponVacuInmuAcuerTipoEmpRies3 = txt_2nomCompleResponVacuInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_2estaSaludColocoVacuInmuAcuerTipoEmpRies3 = txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_2observaInmuAcuerTipoEmpRies3 = txt_2observaInmuAcuerTipoEmpRies3.Text;
                inmu.inmu_2fechaInmuAcuerTipoEmpRies4 = txt_2fechaInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_2loteInmuAcuerTipoEmpRies4 = txt_2loteInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_2esqueCompleInmuAcuerTipoEmpRies4 = txt_2esqueCompleInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_2nomCompleResponVacuInmuAcuerTipoEmpRies4 = txt_2nomCompleResponVacuInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_2estaSaludColocoVacuInmuAcuerTipoEmpRies4 = txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_2observaInmuAcuerTipoEmpRies4 = txt_2observaInmuAcuerTipoEmpRies4.Text;
                inmu.inmu_2fechaInmuAcuerTipoEmpRies5 = txt_2fechaInmuAcuerTipoEmpRies5.Text;
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

        protected void btn_imprimir_Click(object sender, EventArgs e)
        {
            HtmlNode.ElementsFlags["img"] = HtmlElementFlag.Closed;
            HtmlNode.ElementsFlags["br"] = HtmlElementFlag.Closed;
            Document pdfDoc = new Document(PageSize.A4, 20f, 20f, 20f, 20f);
            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            BaseFont fuente = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, true);
            Font titulo = new Font(fuente, 18f, Font.BOLD, new BaseColor(0, 0, 0));
            BaseFont fuente2 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, true);
            Font parrafo = new Font(fuente2, 12f, Font.NORMAL, new BaseColor(0, 0, 0));
            BaseFont fuente3 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, true);
            Font cuadro = new Font(fuente3, 10f, Font.NORMAL, new BaseColor(0, 0, 0));

            pdfDoc.Open();
            pdfDoc.Add(new Paragraph("GESTIÓN DE SEGURIDAD Y SALUD OCUPACIONAL", titulo) { Alignment = Element.ALIGN_CENTER });
            pdfDoc.Add(new Paragraph("HISTORIA CLÍNICA OCUPACIONAL - INMUNIZACIONES", titulo) { Alignment = Element.ALIGN_CENTER });
            pdfDoc.Add(new Chunk(Chunk.NEWLINE));
            var tblinf = new PdfPTable(new float[] { 70f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tblinf.AddCell(new PdfPCell(new Paragraph("A. DATOS DEL ESTABLECIMIENTO - EMPRESA Y USUARIO", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 205, 254), HorizontalAlignment = Element.ALIGN_LEFT });
            pdfDoc.Add(tblinf);
            var tblinfTitulo = new PdfPTable(new float[] { 80f, 40f, 40f, 60f, 50f, 50f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tblinfTitulo.AddCell(new PdfPCell(new Paragraph("INSTITUCIÓN DEL SISTEMA O NOMBRE DE LA EMPRESA", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblinfTitulo.AddCell(new PdfPCell(new Paragraph("RUC", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblinfTitulo.AddCell(new PdfPCell(new Paragraph("CIIU", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblinfTitulo.AddCell(new PdfPCell(new Paragraph("ESTABLECIMIENTO DE SALUD", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblinfTitulo.AddCell(new PdfPCell(new Paragraph("NÚMERO DE HISTORIA CLÍNICA", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblinfTitulo.AddCell(new PdfPCell(new Paragraph("NÚMERO DE ARCHIVO", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            pdfDoc.Add(tblinfTitulo);
            var tblinfDatos = new PdfPTable(new float[] { 80f, 40f, 40f, 60f, 50f, 50f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tblinfDatos.AddCell(new PdfPCell(new Paragraph(txt_nomEmpresa.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblinfDatos.AddCell(new PdfPCell(new Paragraph(txt_rucEmp.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblinfDatos.AddCell(new PdfPCell(new Paragraph(txt_ciiu.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblinfDatos.AddCell(new PdfPCell(new Paragraph(txt_estableSalud.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblinfDatos.AddCell(new PdfPCell(new Paragraph(txt_numHClinica.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblinfDatos.AddCell(new PdfPCell(new Paragraph(txt_numArchivo.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            pdfDoc.Add(tblinfDatos);
            pdfDoc.Add(new Paragraph(" "));
            var tblTitulo = new PdfPTable(new float[] { 20f, 20f, 20f, 20f, 20f, 20f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tblTitulo.AddCell(new PdfPCell(new Paragraph("PRIMER NOMBRE", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblTitulo.AddCell(new PdfPCell(new Paragraph("SEGUNDO NOMBRE", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblTitulo.AddCell(new PdfPCell(new Paragraph("PRIMER APELLIDO", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblTitulo.AddCell(new PdfPCell(new Paragraph("SEGUNDO APELLIDO", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblTitulo.AddCell(new PdfPCell(new Paragraph("SEXO", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblTitulo.AddCell(new PdfPCell(new Paragraph("CARGO / OCUPACIÓN", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            pdfDoc.Add(tblTitulo);
            var tblDatos = new PdfPTable(new float[] { 20f, 20f, 20f, 20f, 20f, 20f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tblDatos.AddCell(new PdfPCell(new Paragraph(txt_priNombre.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblDatos.AddCell(new PdfPCell(new Paragraph(txt_segNombre.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblDatos.AddCell(new PdfPCell(new Paragraph(txt_priApellido.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblDatos.AddCell(new PdfPCell(new Paragraph(txt_segApellido.Text, cuadro)) { BorderColor = new BaseColor(0238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblDatos.AddCell(new PdfPCell(new Paragraph(txt_sexo.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblDatos.AddCell(new PdfPCell(new Paragraph(txt_cargo.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            pdfDoc.Add(tblDatos);
            pdfDoc.Add(new Paragraph(" "));
            var tblinm = new PdfPTable(new float[] { 70f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tblinm.AddCell(new PdfPCell(new Paragraph("B. INMUNIZACIONES", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 205, 254), HorizontalAlignment = Element.ALIGN_LEFT });
            pdfDoc.Add(tblinm);
            var tblinmTitulo = new PdfPTable(new float[] { 30f, 20f, 20f, 20f, 30f, 40f, 50f, 80f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tblinmTitulo.AddCell(new PdfPCell(new Paragraph("VACUNAS", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblinmTitulo.AddCell(new PdfPCell(new Paragraph("DOSIS", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblinmTitulo.AddCell(new PdfPCell(new Paragraph("FECHA", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblinmTitulo.AddCell(new PdfPCell(new Paragraph("LOTE", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblinmTitulo.AddCell(new PdfPCell(new Paragraph("ESQUEMA COMPLETO (MARCAR X)", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblinmTitulo.AddCell(new PdfPCell(new Paragraph("NOMBRES COMPLETOS DEL RESPONSABLE DE LA VACUNACIÓN", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblinmTitulo.AddCell(new PdfPCell(new Paragraph("ESTABLACIMIENTO DE SALUD DONDE SE COLOCÓ LA VACUNA", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            tblinmTitulo.AddCell(new PdfPCell(new Paragraph("OBSERVACIONES", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(205, 254, 204), HorizontalAlignment = Element.ALIGN_CENTER });
            pdfDoc.Add(tblinmTitulo);
            var tbltdDatos = new PdfPTable(new float[] { 30f, 20f, 20f, 20f, 30f, 40f, 50f, 80f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tbltdDatos.AddCell(new PdfPCell(new Paragraph("TÉTANOS - DIFETERIA", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE, Rowspan = 5 });
            tbltdDatos.AddCell(new PdfPCell(new Paragraph("1º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tbltdDatos.AddCell(new PdfPCell(new Paragraph(txt_fechatetanos1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbltdDatos.AddCell(new PdfPCell(new Paragraph(txt_loteTetanos1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbltdDatos.AddCell(new PdfPCell(new Paragraph(txt_esqueCompleTetanos1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbltdDatos.AddCell(new PdfPCell(new Paragraph(txt_nomCompleResponVacuTetanos1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbltdDatos.AddCell(new PdfPCell(new Paragraph(txt_estaSaludColocoVacuTetanos1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbltdDatos.AddCell(new PdfPCell(new Paragraph(txt_observaTetanos1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });

            tbltdDatos.AddCell(new PdfPCell(new Paragraph("2º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tbltdDatos.AddCell(new PdfPCell(new Paragraph(txt_fechatetanos2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tbltdDatos.AddCell(new PdfPCell(new Paragraph(txt_loteTetanos2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbltdDatos.AddCell(new PdfPCell(new Paragraph(txt_esqueCompleTetanos2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbltdDatos.AddCell(new PdfPCell(new Paragraph(txt_nomCompleResponVacuTetanos2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbltdDatos.AddCell(new PdfPCell(new Paragraph(txt_estaSaludColocoVacuTetanos2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbltdDatos.AddCell(new PdfPCell(new Paragraph(txt_observaTetanos2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });

            tbltdDatos.AddCell(new PdfPCell(new Paragraph("3º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tbltdDatos.AddCell(new PdfPCell(new Paragraph(txt_fechatetanos3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbltdDatos.AddCell(new PdfPCell(new Paragraph(txt_loteTetanos3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbltdDatos.AddCell(new PdfPCell(new Paragraph(txt_esqueCompleTetanos3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbltdDatos.AddCell(new PdfPCell(new Paragraph(txt_nomCompleResponVacuTetanos3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbltdDatos.AddCell(new PdfPCell(new Paragraph(txt_estaSaludColocoVacuTetanos3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbltdDatos.AddCell(new PdfPCell(new Paragraph(txt_observaTetanos3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });

            tbltdDatos.AddCell(new PdfPCell(new Paragraph("4º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tbltdDatos.AddCell(new PdfPCell(new Paragraph(txt_fechatetanos4.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbltdDatos.AddCell(new PdfPCell(new Paragraph(txt_loteTetanos4.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbltdDatos.AddCell(new PdfPCell(new Paragraph(txt_esqueCompleTetanos4.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbltdDatos.AddCell(new PdfPCell(new Paragraph(txt_nomCompleResponVacuTetanos4.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbltdDatos.AddCell(new PdfPCell(new Paragraph(txt_estaSaludColocoVacuTetanos4.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbltdDatos.AddCell(new PdfPCell(new Paragraph(txt_observaTetanos4.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });

            tbltdDatos.AddCell(new PdfPCell(new Paragraph("5º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tbltdDatos.AddCell(new PdfPCell(new Paragraph(txt_fechatetanos5.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbltdDatos.AddCell(new PdfPCell(new Paragraph(txt_loteTetanos5.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbltdDatos.AddCell(new PdfPCell(new Paragraph(txt_esqueCompleTetanos5.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbltdDatos.AddCell(new PdfPCell(new Paragraph(txt_nomCompleResponVacuTetanos5.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbltdDatos.AddCell(new PdfPCell(new Paragraph(txt_estaSaludColocoVacuTetanos5.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbltdDatos.AddCell(new PdfPCell(new Paragraph(txt_observaTetanos5.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            pdfDoc.Add(tbltdDatos);
            var tblhaDatos = new PdfPTable(new float[] { 30f, 20f, 20f, 20f, 30f, 40f, 50f, 80f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tblhaDatos.AddCell(new PdfPCell(new Paragraph("HEPATITIS A", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE, Rowspan = 5 });
            tblhaDatos.AddCell(new PdfPCell(new Paragraph("1º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tblhaDatos.AddCell(new PdfPCell(new Paragraph(txt_fechaHepatitisA1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblhaDatos.AddCell(new PdfPCell(new Paragraph(txt_loteHepatitisA1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblhaDatos.AddCell(new PdfPCell(new Paragraph(txt_esqueCompleHepatitisA1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblhaDatos.AddCell(new PdfPCell(new Paragraph(txt_nomCompleResponVacuHepatitisA1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblhaDatos.AddCell(new PdfPCell(new Paragraph(txt_estaSaludColocoVaciHepatitisA1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblhaDatos.AddCell(new PdfPCell(new Paragraph(txt_observaHepatitisA1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });

            tblhaDatos.AddCell(new PdfPCell(new Paragraph("2º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tblhaDatos.AddCell(new PdfPCell(new Paragraph(txt_fechaHepatitisA2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblhaDatos.AddCell(new PdfPCell(new Paragraph(txt_loteHepatitisA2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblhaDatos.AddCell(new PdfPCell(new Paragraph(txt_esqueCompleHepatitisA2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblhaDatos.AddCell(new PdfPCell(new Paragraph(txt_nomCompleResponVacuHepatitisA2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblhaDatos.AddCell(new PdfPCell(new Paragraph(txt_estaSaludColocoVaciHepatitisA2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblhaDatos.AddCell(new PdfPCell(new Paragraph(txt_observaHepatitisA2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });

            tblhaDatos.AddCell(new PdfPCell(new Paragraph("3º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tblhaDatos.AddCell(new PdfPCell(new Paragraph(txt_fechaHepatitisA3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblhaDatos.AddCell(new PdfPCell(new Paragraph(txt_loteHepatitisA3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblhaDatos.AddCell(new PdfPCell(new Paragraph(txt_esqueCompleHepatitisA3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblhaDatos.AddCell(new PdfPCell(new Paragraph(txt_nomCompleResponVacuHepatitisA3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblhaDatos.AddCell(new PdfPCell(new Paragraph(txt_estaSaludColocoVaciHepatitisA3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblhaDatos.AddCell(new PdfPCell(new Paragraph(txt_observaHepatitisA3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            pdfDoc.Add(tblhaDatos);
            var tblhbDatos = new PdfPTable(new float[] { 30f, 20f, 20f, 20f, 30f, 40f, 50f, 80f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tblhbDatos.AddCell(new PdfPCell(new Paragraph("HEPATITIS B", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE, Rowspan = 5 });
            tblhbDatos.AddCell(new PdfPCell(new Paragraph("1º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tblhbDatos.AddCell(new PdfPCell(new Paragraph(txt_fechaHepatitisB1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblhbDatos.AddCell(new PdfPCell(new Paragraph(txt_loteHepatitisB1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblhbDatos.AddCell(new PdfPCell(new Paragraph(txt_esqueCompleHepatitisB1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblhbDatos.AddCell(new PdfPCell(new Paragraph(txt_nomCompleResponVacuHepatitisB1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblhbDatos.AddCell(new PdfPCell(new Paragraph(txt_estaSaludColocoVaciHepatitisB1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblhbDatos.AddCell(new PdfPCell(new Paragraph(txt_observaHepatitisB1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });

            tblhbDatos.AddCell(new PdfPCell(new Paragraph("2º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tblhbDatos.AddCell(new PdfPCell(new Paragraph(txt_fechaHepatitisB2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblhbDatos.AddCell(new PdfPCell(new Paragraph(txt_loteHepatitisB2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblhbDatos.AddCell(new PdfPCell(new Paragraph(txt_esqueCompleHepatitisB2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblhbDatos.AddCell(new PdfPCell(new Paragraph(txt_nomCompleResponVacuHepatitisB2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblhbDatos.AddCell(new PdfPCell(new Paragraph(txt_estaSaludColocoVaciHepatitisB2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblhbDatos.AddCell(new PdfPCell(new Paragraph(txt_observaHepatitisB2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });

            tblhbDatos.AddCell(new PdfPCell(new Paragraph("3º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tblhbDatos.AddCell(new PdfPCell(new Paragraph(txt_fechaHepatitisB3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblhbDatos.AddCell(new PdfPCell(new Paragraph(txt_loteHepatitisB3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblhbDatos.AddCell(new PdfPCell(new Paragraph(txt_esqueCompleHepatitisB3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblhbDatos.AddCell(new PdfPCell(new Paragraph(txt_nomCompleResponVacuHepatitisB3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblhbDatos.AddCell(new PdfPCell(new Paragraph(txt_estaSaludColocoVaciHepatitisB3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblhbDatos.AddCell(new PdfPCell(new Paragraph(txt_observaHepatitisB3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            pdfDoc.Add(tblhbDatos);
            var tblieDatos = new PdfPTable(new float[] { 30f, 20f, 20f, 20f, 30f, 40f, 50f, 80f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tblieDatos.AddCell(new PdfPCell(new Paragraph("INFLUENZA ESTACIONARIA", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE, Rowspan = 5 });
            tblieDatos.AddCell(new PdfPCell(new Paragraph("DOSIS ÚNICA", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tblieDatos.AddCell(new PdfPCell(new Paragraph(txt_fechaInfluenza.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblieDatos.AddCell(new PdfPCell(new Paragraph(txt_loteInfluenza.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblieDatos.AddCell(new PdfPCell(new Paragraph(txt_esqueCompleInfluenza.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblieDatos.AddCell(new PdfPCell(new Paragraph(txt_nomCompleResponVacuInfluenza.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblieDatos.AddCell(new PdfPCell(new Paragraph(txt_estaSaludColocoVacuInfluenza.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblieDatos.AddCell(new PdfPCell(new Paragraph(txt_observaInfluenza.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            pdfDoc.Add(tblieDatos);
            var tblfaDatos = new PdfPTable(new float[] { 30f, 20f, 20f, 20f, 30f, 40f, 50f, 80f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tblfaDatos.AddCell(new PdfPCell(new Paragraph("FIEBRE AMARILLA", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE, Rowspan = 5 });
            tblfaDatos.AddCell(new PdfPCell(new Paragraph("DOSIS ÚNICA", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tblfaDatos.AddCell(new PdfPCell(new Paragraph(txt_fechaFiebreAmarilla.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblfaDatos.AddCell(new PdfPCell(new Paragraph(txt_loteFiebreAmarilla.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblfaDatos.AddCell(new PdfPCell(new Paragraph(txt_esqueCompleFiebreAmarilla.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblfaDatos.AddCell(new PdfPCell(new Paragraph(txt_nomCompleResponVacuFiebreAmarilla.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblfaDatos.AddCell(new PdfPCell(new Paragraph(txt_estaSaludColocoVacuFiebreAmarilla.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblfaDatos.AddCell(new PdfPCell(new Paragraph(txt_observaFiebreAmarilla.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            pdfDoc.Add(tblfaDatos);
            var tblsrDatos = new PdfPTable(new float[] { 30f, 20f, 20f, 20f, 30f, 40f, 50f, 80f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tblsrDatos.AddCell(new PdfPCell(new Paragraph("SARAMPIÓN - RUBÉOLA", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE, Rowspan = 5 });
            tblsrDatos.AddCell(new PdfPCell(new Paragraph("1º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tblsrDatos.AddCell(new PdfPCell(new Paragraph(txt_fechaSarampion1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblsrDatos.AddCell(new PdfPCell(new Paragraph(txt_loteSarampion1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblsrDatos.AddCell(new PdfPCell(new Paragraph(txt_esqueCompleSarampion1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblsrDatos.AddCell(new PdfPCell(new Paragraph(txt_nomCompleResponVacuSarampion1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblsrDatos.AddCell(new PdfPCell(new Paragraph(txt_estaSaludColocoVacuSarampion1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblsrDatos.AddCell(new PdfPCell(new Paragraph(txt_observaSarampion1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });

            tblsrDatos.AddCell(new PdfPCell(new Paragraph("2º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tblsrDatos.AddCell(new PdfPCell(new Paragraph(txt_fechaSarampion2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_CENTER });
            tblsrDatos.AddCell(new PdfPCell(new Paragraph(txt_loteSarampion2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblsrDatos.AddCell(new PdfPCell(new Paragraph(txt_esqueCompleSarampion2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblsrDatos.AddCell(new PdfPCell(new Paragraph(txt_nomCompleResponVacuSarampion2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblsrDatos.AddCell(new PdfPCell(new Paragraph(txt_estaSaludColocoVacuSarampion2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tblsrDatos.AddCell(new PdfPCell(new Paragraph(txt_observaHepatitisB2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            pdfDoc.Add(tblsrDatos);
            var tblerDatos = new PdfPTable(new float[] { 100f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tblerDatos.AddCell(new PdfPCell(new Paragraph("INMUNIZACIONES DE ACUERDO AL TIPO DE EMPRESA Y RIESGO", cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            pdfDoc.Add(tblerDatos);
            var tbler1Datos = new PdfPTable(new float[] { 30f, 20f, 20f, 20f, 30f, 40f, 50f, 80f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tbler1Datos.AddCell(new PdfPCell(new Paragraph(" ", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE, Rowspan = 5 });
            tbler1Datos.AddCell(new PdfPCell(new Paragraph("1º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tbler1Datos.AddCell(new PdfPCell(new Paragraph(txt_1fechaInmuAcuerTipoEmpRies1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler1Datos.AddCell(new PdfPCell(new Paragraph(txt_1loteInmuAcuerTipoEmpRies1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler1Datos.AddCell(new PdfPCell(new Paragraph(txt_1esqueCompleInmuAcuerTipoEmpRies1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler1Datos.AddCell(new PdfPCell(new Paragraph(txt_1nomCompleResponVacuInmuAcuerTipoEmpRies1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler1Datos.AddCell(new PdfPCell(new Paragraph(txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler1Datos.AddCell(new PdfPCell(new Paragraph(txt_1observaInmuAcuerTipoEmpRies1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });

            tbler1Datos.AddCell(new PdfPCell(new Paragraph("2º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tbler1Datos.AddCell(new PdfPCell(new Paragraph(txt_1fechaInmuAcuerTipoEmpRies2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler1Datos.AddCell(new PdfPCell(new Paragraph(txt_1loteInmuAcuerTipoEmpRies2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler1Datos.AddCell(new PdfPCell(new Paragraph(txt_1esqueCompleInmuAcuerTipoEmpRies2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler1Datos.AddCell(new PdfPCell(new Paragraph(txt_1nomCompleResponVacuInmuAcuerTipoEmpRies2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler1Datos.AddCell(new PdfPCell(new Paragraph(txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler1Datos.AddCell(new PdfPCell(new Paragraph(txt_1observaInmuAcuerTipoEmpRies2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });

            tbler1Datos.AddCell(new PdfPCell(new Paragraph("3º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tbler1Datos.AddCell(new PdfPCell(new Paragraph(txt_1fechaInmuAcuerTipoEmpRies3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler1Datos.AddCell(new PdfPCell(new Paragraph(txt_1loteInmuAcuerTipoEmpRies3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler1Datos.AddCell(new PdfPCell(new Paragraph(txt_1esqueCompleInmuAcuerTipoEmpRies3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler1Datos.AddCell(new PdfPCell(new Paragraph(txt_1nomCompleResponVacuInmuAcuerTipoEmpRies3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler1Datos.AddCell(new PdfPCell(new Paragraph(txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler1Datos.AddCell(new PdfPCell(new Paragraph(txt_1observaInmuAcuerTipoEmpRies3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });

            tbler1Datos.AddCell(new PdfPCell(new Paragraph("4º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tbler1Datos.AddCell(new PdfPCell(new Paragraph(txt_1fechaInmuAcuerTipoEmpRies4.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler1Datos.AddCell(new PdfPCell(new Paragraph(txt_1loteInmuAcuerTipoEmpRies4.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler1Datos.AddCell(new PdfPCell(new Paragraph(txt_1esqueCompleInmuAcuerTipoEmpRies4.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler1Datos.AddCell(new PdfPCell(new Paragraph(txt_1nomCompleResponVacuInmuAcuerTipoEmpRies4.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler1Datos.AddCell(new PdfPCell(new Paragraph(txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies4.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler1Datos.AddCell(new PdfPCell(new Paragraph(txt_1observaInmuAcuerTipoEmpRies4.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });

            tbler1Datos.AddCell(new PdfPCell(new Paragraph("5º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tbler1Datos.AddCell(new PdfPCell(new Paragraph(txt_1fechaInmuAcuerTipoEmpRies5.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler1Datos.AddCell(new PdfPCell(new Paragraph(txt_1loteInmuAcuerTipoEmpRies5.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler1Datos.AddCell(new PdfPCell(new Paragraph(txt_1esqueCompleInmuAcuerTipoEmpRies5.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler1Datos.AddCell(new PdfPCell(new Paragraph(txt_1nomCompleResponVacuInmuAcuerTipoEmpRies5.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler1Datos.AddCell(new PdfPCell(new Paragraph(txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies5.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler1Datos.AddCell(new PdfPCell(new Paragraph(txt_1observaInmuAcuerTipoEmpRies5.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            pdfDoc.Add(tbler1Datos);
            var tbler2Datos = new PdfPTable(new float[] { 30f, 20f, 20f, 20f, 30f, 40f, 50f, 80f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tbler2Datos.AddCell(new PdfPCell(new Paragraph(" ", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE, Rowspan = 5 });
            tbler2Datos.AddCell(new PdfPCell(new Paragraph("1º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tbler2Datos.AddCell(new PdfPCell(new Paragraph(txt_2fechaInmuAcuerTipoEmpRies1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler2Datos.AddCell(new PdfPCell(new Paragraph(txt_2loteInmuAcuerTipoEmpRies1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler2Datos.AddCell(new PdfPCell(new Paragraph(txt_2esqueCompleInmuAcuerTipoEmpRies1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler2Datos.AddCell(new PdfPCell(new Paragraph(txt_2nomCompleResponVacuInmuAcuerTipoEmpRies1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler2Datos.AddCell(new PdfPCell(new Paragraph(txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler2Datos.AddCell(new PdfPCell(new Paragraph(txt_2observaInmuAcuerTipoEmpRies1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });

            tbler2Datos.AddCell(new PdfPCell(new Paragraph("2º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tbler2Datos.AddCell(new PdfPCell(new Paragraph(txt_2fechaInmuAcuerTipoEmpRies2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler2Datos.AddCell(new PdfPCell(new Paragraph(txt_2loteInmuAcuerTipoEmpRies2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler2Datos.AddCell(new PdfPCell(new Paragraph(txt_2esqueCompleInmuAcuerTipoEmpRies2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler2Datos.AddCell(new PdfPCell(new Paragraph(txt_2nomCompleResponVacuInmuAcuerTipoEmpRies2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler2Datos.AddCell(new PdfPCell(new Paragraph(txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler2Datos.AddCell(new PdfPCell(new Paragraph(txt_2observaInmuAcuerTipoEmpRies2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });

            tbler2Datos.AddCell(new PdfPCell(new Paragraph("3º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tbler2Datos.AddCell(new PdfPCell(new Paragraph(txt_2fechaInmuAcuerTipoEmpRies3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler2Datos.AddCell(new PdfPCell(new Paragraph(txt_2loteInmuAcuerTipoEmpRies3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler2Datos.AddCell(new PdfPCell(new Paragraph(txt_2esqueCompleInmuAcuerTipoEmpRies3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler2Datos.AddCell(new PdfPCell(new Paragraph(txt_2nomCompleResponVacuInmuAcuerTipoEmpRies3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler2Datos.AddCell(new PdfPCell(new Paragraph(txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler2Datos.AddCell(new PdfPCell(new Paragraph(txt_2observaInmuAcuerTipoEmpRies3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });

            tbler2Datos.AddCell(new PdfPCell(new Paragraph("4º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tbler2Datos.AddCell(new PdfPCell(new Paragraph(txt_2fechaInmuAcuerTipoEmpRies4.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler2Datos.AddCell(new PdfPCell(new Paragraph(txt_2loteInmuAcuerTipoEmpRies4.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler2Datos.AddCell(new PdfPCell(new Paragraph(txt_2esqueCompleInmuAcuerTipoEmpRies4.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler2Datos.AddCell(new PdfPCell(new Paragraph(txt_2nomCompleResponVacuInmuAcuerTipoEmpRies4.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler2Datos.AddCell(new PdfPCell(new Paragraph(txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies4.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler2Datos.AddCell(new PdfPCell(new Paragraph(txt_2observaInmuAcuerTipoEmpRies4.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });

            tbler2Datos.AddCell(new PdfPCell(new Paragraph("5º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tbler2Datos.AddCell(new PdfPCell(new Paragraph(txt_2fechaInmuAcuerTipoEmpRies5.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler2Datos.AddCell(new PdfPCell(new Paragraph(txt_2loteInmuAcuerTipoEmpRies5.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler2Datos.AddCell(new PdfPCell(new Paragraph(txt_2esqueCompleInmuAcuerTipoEmpRies5.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler2Datos.AddCell(new PdfPCell(new Paragraph(txt_2nomCompleResponVacuInmuAcuerTipoEmpRies5.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler2Datos.AddCell(new PdfPCell(new Paragraph(txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies5.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler2Datos.AddCell(new PdfPCell(new Paragraph(txt_2observaInmuAcuerTipoEmpRies5.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            pdfDoc.Add(tbler2Datos);
            var tbler3Datos = new PdfPTable(new float[] { 30f, 20f, 20f, 20f, 30f, 40f, 50f, 80f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tbler3Datos.AddCell(new PdfPCell(new Paragraph(" ", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE, Rowspan = 5 });
            tbler3Datos.AddCell(new PdfPCell(new Paragraph("1º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tbler3Datos.AddCell(new PdfPCell(new Paragraph(txt_1fechaInmuAcuerTipoEmpRies1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler3Datos.AddCell(new PdfPCell(new Paragraph(txt_1loteInmuAcuerTipoEmpRies1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler3Datos.AddCell(new PdfPCell(new Paragraph(txt_1esqueCompleInmuAcuerTipoEmpRies1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler3Datos.AddCell(new PdfPCell(new Paragraph(txt_1nomCompleResponVacuInmuAcuerTipoEmpRies1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler3Datos.AddCell(new PdfPCell(new Paragraph(txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler3Datos.AddCell(new PdfPCell(new Paragraph(txt_1observaInmuAcuerTipoEmpRies1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });

            tbler3Datos.AddCell(new PdfPCell(new Paragraph("2º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tbler3Datos.AddCell(new PdfPCell(new Paragraph(txt_1fechaInmuAcuerTipoEmpRies2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler3Datos.AddCell(new PdfPCell(new Paragraph(txt_1loteInmuAcuerTipoEmpRies2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler3Datos.AddCell(new PdfPCell(new Paragraph(txt_1esqueCompleInmuAcuerTipoEmpRies2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler3Datos.AddCell(new PdfPCell(new Paragraph(txt_1nomCompleResponVacuInmuAcuerTipoEmpRies2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler3Datos.AddCell(new PdfPCell(new Paragraph(txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler3Datos.AddCell(new PdfPCell(new Paragraph(txt_1observaInmuAcuerTipoEmpRies2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });

            tbler3Datos.AddCell(new PdfPCell(new Paragraph("3º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tbler3Datos.AddCell(new PdfPCell(new Paragraph(txt_1fechaInmuAcuerTipoEmpRies3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler3Datos.AddCell(new PdfPCell(new Paragraph(txt_1loteInmuAcuerTipoEmpRies3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler3Datos.AddCell(new PdfPCell(new Paragraph(txt_1esqueCompleInmuAcuerTipoEmpRies3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler3Datos.AddCell(new PdfPCell(new Paragraph(txt_1nomCompleResponVacuInmuAcuerTipoEmpRies3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler3Datos.AddCell(new PdfPCell(new Paragraph(txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler3Datos.AddCell(new PdfPCell(new Paragraph(txt_1observaInmuAcuerTipoEmpRies3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });

            tbler3Datos.AddCell(new PdfPCell(new Paragraph("4º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tbler3Datos.AddCell(new PdfPCell(new Paragraph(txt_1fechaInmuAcuerTipoEmpRies4.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler3Datos.AddCell(new PdfPCell(new Paragraph(txt_1loteInmuAcuerTipoEmpRies4.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler3Datos.AddCell(new PdfPCell(new Paragraph(txt_1esqueCompleInmuAcuerTipoEmpRies4.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler3Datos.AddCell(new PdfPCell(new Paragraph(txt_1nomCompleResponVacuInmuAcuerTipoEmpRies4.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler3Datos.AddCell(new PdfPCell(new Paragraph(txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies4.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler3Datos.AddCell(new PdfPCell(new Paragraph(txt_1observaInmuAcuerTipoEmpRies4.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });

            tbler3Datos.AddCell(new PdfPCell(new Paragraph("5º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tbler3Datos.AddCell(new PdfPCell(new Paragraph(txt_1fechaInmuAcuerTipoEmpRies5.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler3Datos.AddCell(new PdfPCell(new Paragraph(txt_1loteInmuAcuerTipoEmpRies5.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler3Datos.AddCell(new PdfPCell(new Paragraph(txt_1esqueCompleInmuAcuerTipoEmpRies5.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler3Datos.AddCell(new PdfPCell(new Paragraph(txt_1nomCompleResponVacuInmuAcuerTipoEmpRies5.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler3Datos.AddCell(new PdfPCell(new Paragraph(txt_1estaSaludColocoVacuInmuAcuerTipoEmpRies5.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler3Datos.AddCell(new PdfPCell(new Paragraph(txt_1observaInmuAcuerTipoEmpRies5.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            pdfDoc.Add(tbler3Datos);
            var tbler4Datos = new PdfPTable(new float[] { 30f, 20f, 20f, 20f, 30f, 40f, 50f, 80f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tbler4Datos.AddCell(new PdfPCell(new Paragraph(" ", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE, Rowspan = 5 });
            tbler4Datos.AddCell(new PdfPCell(new Paragraph("1º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tbler4Datos.AddCell(new PdfPCell(new Paragraph(txt_2fechaInmuAcuerTipoEmpRies1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler4Datos.AddCell(new PdfPCell(new Paragraph(txt_2loteInmuAcuerTipoEmpRies1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler4Datos.AddCell(new PdfPCell(new Paragraph(txt_2esqueCompleInmuAcuerTipoEmpRies1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler4Datos.AddCell(new PdfPCell(new Paragraph(txt_2nomCompleResponVacuInmuAcuerTipoEmpRies1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler4Datos.AddCell(new PdfPCell(new Paragraph(txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler4Datos.AddCell(new PdfPCell(new Paragraph(txt_2observaInmuAcuerTipoEmpRies1.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });

            tbler4Datos.AddCell(new PdfPCell(new Paragraph("2º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tbler4Datos.AddCell(new PdfPCell(new Paragraph(txt_2fechaInmuAcuerTipoEmpRies2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler4Datos.AddCell(new PdfPCell(new Paragraph(txt_2loteInmuAcuerTipoEmpRies2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler4Datos.AddCell(new PdfPCell(new Paragraph(txt_2esqueCompleInmuAcuerTipoEmpRies2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler4Datos.AddCell(new PdfPCell(new Paragraph(txt_2nomCompleResponVacuInmuAcuerTipoEmpRies2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler4Datos.AddCell(new PdfPCell(new Paragraph(txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler4Datos.AddCell(new PdfPCell(new Paragraph(txt_2observaInmuAcuerTipoEmpRies2.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });

            tbler4Datos.AddCell(new PdfPCell(new Paragraph("3º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tbler4Datos.AddCell(new PdfPCell(new Paragraph(txt_2fechaInmuAcuerTipoEmpRies3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler4Datos.AddCell(new PdfPCell(new Paragraph(txt_2loteInmuAcuerTipoEmpRies3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler4Datos.AddCell(new PdfPCell(new Paragraph(txt_2esqueCompleInmuAcuerTipoEmpRies3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler4Datos.AddCell(new PdfPCell(new Paragraph(txt_2nomCompleResponVacuInmuAcuerTipoEmpRies3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler4Datos.AddCell(new PdfPCell(new Paragraph(txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler4Datos.AddCell(new PdfPCell(new Paragraph(txt_2observaInmuAcuerTipoEmpRies3.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });

            tbler4Datos.AddCell(new PdfPCell(new Paragraph("4º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tbler4Datos.AddCell(new PdfPCell(new Paragraph(txt_2fechaInmuAcuerTipoEmpRies4.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler4Datos.AddCell(new PdfPCell(new Paragraph(txt_2loteInmuAcuerTipoEmpRies4.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler4Datos.AddCell(new PdfPCell(new Paragraph(txt_2esqueCompleInmuAcuerTipoEmpRies4.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler4Datos.AddCell(new PdfPCell(new Paragraph(txt_2nomCompleResponVacuInmuAcuerTipoEmpRies4.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler4Datos.AddCell(new PdfPCell(new Paragraph(txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies4.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler4Datos.AddCell(new PdfPCell(new Paragraph(txt_2observaInmuAcuerTipoEmpRies4.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });

            tbler4Datos.AddCell(new PdfPCell(new Paragraph("5º", cuadro)) { BorderColor = new BaseColor(238, 240, 242), BackgroundColor = new BaseColor(204, 255, 255), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
            tbler4Datos.AddCell(new PdfPCell(new Paragraph(txt_2fechaInmuAcuerTipoEmpRies5.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler4Datos.AddCell(new PdfPCell(new Paragraph(txt_2loteInmuAcuerTipoEmpRies5.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler4Datos.AddCell(new PdfPCell(new Paragraph(txt_2esqueCompleInmuAcuerTipoEmpRies5.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler4Datos.AddCell(new PdfPCell(new Paragraph(txt_2nomCompleResponVacuInmuAcuerTipoEmpRies5.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler4Datos.AddCell(new PdfPCell(new Paragraph(txt_2estaSaludColocoVacuInmuAcuerTipoEmpRies5.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            tbler4Datos.AddCell(new PdfPCell(new Paragraph(txt_2observaInmuAcuerTipoEmpRies5.Text, cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            pdfDoc.Add(tbler4Datos);
            var tbllvDatos = new PdfPTable(new float[] { 100f }) { WidthPercentage = 100, HorizontalAlignment = Element.ALIGN_CENTER };
            tbllvDatos.AddCell(new PdfPCell(new Paragraph("La vacuna de la Fiebre Amarilla es obligatoria para quien viva o se desplace en la Región Amazónica, su aplicación es hasta los 59 años de edad", cuadro)) { BorderColor = new BaseColor(238, 240, 242), HorizontalAlignment = Element.ALIGN_LEFT });
            pdfDoc.Add(tbllvDatos);
            pdfDoc.Close();
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Inmunizaciones_" + txt_numHClinica.Text + "_" + DateTime.Today + ".pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Write(pdfDoc);
            Response.End();
        }
    }
}