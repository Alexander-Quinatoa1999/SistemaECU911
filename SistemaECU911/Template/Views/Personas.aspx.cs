using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaECU911.Template.Views
{
    public partial class Personas : System.Web.UI.Page
    {

        private readonly DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        private Tbl_Personas per = new Tbl_Personas();

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
                        txt_puestoTrabajo.Text = per.Per_puestoTrabajo.ToString();                        
                        txt_cargo.Text = per.Per_cargoOcupacion.ToString();
                        txt_area.Text = per.Per_areaTrabajo.ToString();
                        ddl_estado.Text = per.Per_estado.ToString();
                    }
                }
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
                per = new Tbl_Personas();

                per.Per_priNombre = txt_priNombre.Text;
                per.Per_segNombre = txt_segNombre.Text;
                per.Per_priApellido = txt_priApellido.Text;
                per.Per_segApellido = txt_segApellido.Text;
                per.Per_cedula = txt_cedula.Text;
                per.Per_fechaNacimiento = txt_fechaNacimiento.Text;
                per.Per_genero = ddl_genero.Text;
                per.Emp_id = Convert.ToInt32(ddl_zonal.Text);
                per.Per_fechInicioTrabajo = txt_fechaIngresoTrabajo.Text;
                per.Per_puestoTrabajo = txt_puestoTrabajo.Text;                
                per.Per_cargoOcupacion = txt_cargo.Text;
                per.Per_areaTrabajo = txt_area.Text;
                per.Per_estado = ddl_estado.Text;

                CN_Personas.GuardarPersona(per);

                //Mensaje de confirmacion
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Guardados Exitosamente')", true);

                Response.Redirect("~/Template/Views/Inicio.aspx");

            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Guardados')", true);
            }
        }

        private void ModificarPersona(Tbl_Personas per)
        {
            try
            {
                per.Per_priNombre = txt_priNombre.Text;
                per.Per_segNombre = txt_segNombre.Text;
                per.Per_priApellido = txt_priApellido.Text;
                per.Per_segApellido = txt_segApellido.Text;
                per.Per_cedula = txt_cedula.Text;
                per.Per_fechaNacimiento = txt_fechaNacimiento.Text;
                per.Per_genero = ddl_genero.Text;
                per.Emp_id = Convert.ToInt32(ddl_zonal.SelectedValue);
                per.Per_fechInicioTrabajo = txt_fechaIngresoTrabajo.Text;
                per.Per_puestoTrabajo = txt_puestoTrabajo.Text;
                per.Per_cargoOcupacion = txt_cargo.Text;
                per.Per_areaTrabajo = txt_area.Text;
                per.Per_estado = ddl_estado.SelectedValue;

                CN_Personas.ModificarPersona(per);

                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Modificados Exitosamente')", true);
                Response.Redirect("~/Template/Views/Inicio.aspx");
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos No Modificados')", true);
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
    }
}