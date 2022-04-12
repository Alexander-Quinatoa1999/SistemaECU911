using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Evolucion
    {

        //private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        ////metodo traer para traer Tbl_Evolucion Evolucion x persona
        //public static Tbl_EvolucionEvolucion obtenerEvolucionxPerEvolucion(int personaid)
        //{
        //    var evoevolucion = dc.Tbl_EvolucionEvolucion.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.evo_estado == "A");
        //    return evoevolucion;
        //}

        ////metodo traer para traer Prescripciones Evolucion x persona
        //public static Tbl_PrescripcionesEvolucion obtenerPrescripcionesxPerEvolucion(int personaid)
        //{
        //    var presevolucion = dc.Tbl_PrescripcionesEvolucion.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.pres_estado == "A");
        //    return presevolucion;
        //}


        ////----------------------------------------------------------------------------------------------------------------------------
        ////------------------------------------------ METODOS PARA GUARDAR Y MODIFICAR DATOS  -----------------------------------------
        ////----------------------------------------------------------------------------------------------------------------------------


        ////B. EVOLUCION

        ////Metodo para guardar datos Evolucion
        //public static void guardarEvolucionEvolucion(Tbl_EvolucionEvolucion evoevolucion)
        //{
        //    try
        //    {
        //        evoevolucion.evo_estado = "A";
        //        dc.Tbl_EvolucionEvolucion.InsertOnSubmit(evoevolucion);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}

        ////C. PRESCRIPCIONES

        ////Metodo para guardar datos Prescripciones
        //public static void guardarPrescripcionesEvolucion(Tbl_PrescripcionesEvolucion presevolucion)
        //{
        //    try
        //    {
        //        presevolucion.pres_estado = "A";
        //        dc.Tbl_PrescripcionesEvolucion.InsertOnSubmit(presevolucion);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}

    }
}
