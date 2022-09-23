﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaECU911.Template.Views_Socio_Economico
{
    public partial class PrincipalSSO : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["TrabajoSocial"] != null)
            {
                string usulogeado = Session["TrabajoSocial"].ToString();
                string priNom = Session["prinombre"].ToString();
                string segNom = Session["segnombre"].ToString();
                string priApe = Session["priapellido"].ToString();
                string segApe = Session["segapellido"].ToString();
                string resRol = Session["rol"].ToString();
                lbl_nombre.Text = priNom + " " + segNom;
                lbl_apellido.Text = priApe + " " + segApe;
                lbl_rol.Text = resRol;
            }
            else
            {
                Response.Redirect("../../index.aspx");
            }
        }

        protected void Lnb_CerrarSesion_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("../../index.aspx");
        }
    }
}