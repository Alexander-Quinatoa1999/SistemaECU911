﻿using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaECU911.Template.Views
{
    public partial class Personas : System.Web.UI.Page
    {

        private readonly DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        private Tbl_Personas per = new Tbl_Personas();
        private Tbl_Usuarios usu = new Tbl_Usuarios();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["cod"] != null)
                {
                    int codigo = Convert.ToInt32(Request["cod"]);
                    per = CN_Personas.ObtenerPersonaPorId(codigo);
                    //int personasid = Convert.ToInt32(per.Per_id.ToString());
                    //per = CN_Personas.ObtenerPersonaPorId(personasid);

                    btn_guardar.Text = "Actualizar";

                    if (per != null)
                    {
                        txt_priNombre.Text = per.Per_priNombre.ToString();
                        txt_segNombre.Text = per.Per_segNombre.ToString();
                        txt_priApellido.Text = per.Per_priApellido.ToString();
                        txt_segApellido.Text = per.Per_segApellido.ToString();
                        txt_cedula.Text = per.Per_cedula.ToString();
                        if (per.Per_fechaNacimiento == "")
                        {
                            txt_fechaNacimiento.Text = per.Per_fechaNacimiento.ToString();
                        }
                        else
                        {
                            txt_fechaNacimiento.Text = Convert.ToDateTime(per.Per_fechaNacimiento).ToString("yyyy-MM-dd");
                        }                        
                        ddl_genero.Text = per.Per_genero.ToString();
                        ddl_zonal.Text = per.Emp_id.ToString();
                        if (per.Per_fechInicioTrabajo == "")
                        {
                            txt_fechaIngresoTrabajo.Text = per.Per_fechInicioTrabajo.ToString();
                        }
                        else
                        {
                            txt_fechaIngresoTrabajo.Text = Convert.ToDateTime(per.Per_fechInicioTrabajo).ToString("yyyy-MM-dd");
                        }
                        ddl_puestoTrabajo.Text = per.Per_puestoTrabajo.ToString();                        
                        ddl_cargo.Text = per.Per_cargoOcupacion.ToString();
                        ddl_area.Text = per.Per_areaTrabajo.ToString();
                        ddl_estado.Text = per.Per_estado.ToString();
                    }
                }
                Timer1.Enabled = false;
                CargarZonales();
                Validaciones();
            }
        }

        private void Validaciones()
        {
            ddl_estado.Text = "ACTIVO";
        }

        private void GuardarPersona()
        {
            try
            {   
                bool existeCedula = CN_Personas.autentificarxCedula(txt_cedula.Text);

                if (existeCedula)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "mensaje", "swal('Error!','El paciente ya existe !! Verifique el número de cedula', 'error')", true);
                }
                else
                {
                    per = new Tbl_Personas();
                    usu = new Tbl_Usuarios();

                    //Datos Tbl_Personas
                    per.Per_priNombre = txt_priNombre.Text.ToUpper();
                    per.Per_segNombre = txt_segNombre.Text.ToUpper();
                    per.Per_priApellido = txt_priApellido.Text.ToUpper();
                    per.Per_segApellido = txt_segApellido.Text.ToUpper();
                    per.Per_cedula = txt_cedula.Text.ToUpper();
                    per.Per_fechaNacimiento = txt_fechaNacimiento.Text.ToUpper();
                    per.Per_genero = ddl_genero.Text.ToUpper();
                    per.Emp_id = Convert.ToInt32(ddl_zonal.Text.ToUpper());
                    per.Per_fechInicioTrabajo = txt_fechaIngresoTrabajo.Text.ToUpper();
                    per.Per_puestoTrabajo = ddl_puestoTrabajo.Text.ToUpper();
                    per.Per_cargoOcupacion = ddl_cargo.Text.ToUpper();
                    per.Per_areaTrabajo = ddl_area.Text.ToUpper();
                    per.Per_estado = ddl_estado.Text.ToUpper();

                    //Datos Tbl_Usuarios
                    usu.usu_cedula = txt_cedula.Text.ToUpper();
                    usu.usu_priApellido = txt_priApellido.Text.ToUpper();
                    usu.usu_segApellido = txt_segApellido.Text.ToUpper();
                    usu.usu_priNombre = txt_priNombre.Text.ToUpper();
                    usu.usu_segNombre = txt_segNombre.Text.ToUpper();
                    usu.usu_nomlogin = txt_cedula.Text.ToUpper();
                    usu.usu_pass = GetMD5(txt_cedula.Text.ToUpper());
                    usu.tusu_id = 2;
                    usu.usu_estado = ddl_estado.SelectedValue;

                    CN_Personas.GuardarPersona(per);
                    CN_Usuarios.save(usu);

                    //Mensaje de confirmacion
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "mensaje", "swal('Exito!', 'Paciente Registrado Exitosamente', 'success')", true);
                    Timer1.Enabled = true;
                }

            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "mensaje", "swal('Error!', 'El Paciente No Fue Registrado', 'error')", true);
            }
        }

        private void ModificarPersona(Tbl_Personas per)
        {
            try
            {
                //Datos Update Tbl_Personas
                per.Per_priNombre = txt_priNombre.Text.ToUpper();
                per.Per_segNombre = txt_segNombre.Text.ToUpper();
                per.Per_priApellido = txt_priApellido.Text.ToUpper();
                per.Per_segApellido = txt_segApellido.Text.ToUpper();
                per.Per_cedula = txt_cedula.Text.ToUpper();
                per.Per_fechaNacimiento = txt_fechaNacimiento.Text.ToUpper();
                per.Per_genero = ddl_genero.Text.ToUpper();
                per.Emp_id = Convert.ToInt32(ddl_zonal.SelectedValue);
                per.Per_fechInicioTrabajo = txt_fechaIngresoTrabajo.Text.ToUpper();
                per.Per_puestoTrabajo = ddl_puestoTrabajo.Text.ToUpper();
                per.Per_cargoOcupacion = ddl_cargo.Text.ToUpper();
                per.Per_areaTrabajo = ddl_area.Text.ToUpper();
                per.Per_estado = ddl_estado.SelectedValue;

                //Datos Update Tbl_Usuarios
                usu.usu_estado = ddl_estado.SelectedValue;

                CN_Personas.ModificarPersona(per);
                CN_Usuarios.modify(usu);

                ScriptManager.RegisterStartupScript(this, this.GetType(), "mensaje", "swal('Exito!', 'Datos Modificados Exitosamente', 'success')", true);
                Timer1.Enabled = true;
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "mensaje", "swal('Error!', 'Datos No Modificados', 'error')", true);
            }
        }

        private void Guardar_modificar_datos(int perso)
        {
            if (perso == 0)
            {
                GuardarPersona();
            }
            else
            {
                per = CN_Personas.ObtenerPersonaPorId(perso);

                if (per != null)
                {
                    ModificarPersona(per);
                }
            }
        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            Guardar_modificar_datos(Convert.ToInt32(Request["cod"]));
        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/Views/Inicio.aspx");
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/Views/Inicio.aspx");
        }

        private void CargarZonales()
        {
            List<Tbl_Empresa> listaEmp = new List<Tbl_Empresa>();
            listaEmp = CN_Personas.ObtenerEmpresa();
            listaEmp.Insert(0, new Tbl_Empresa() { Emp_zonal = "Seleccione...." });

            ddl_zonal.DataSource = listaEmp;
            ddl_zonal.DataTextField = "Emp_zonal";
            ddl_zonal.DataValueField = "Emp_id";
            ddl_zonal.DataBind();
        }

        public static string GetMD5(string str)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}