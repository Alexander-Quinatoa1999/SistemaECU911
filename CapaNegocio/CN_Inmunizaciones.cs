using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Inmunizaciones
    {
        ////private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();
        //private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        ////metodo traer para traer Datos Inmunizaciones
        //public static Tbl_InmunizacionesInmunizaciones obtenerInmunizaciones(int personaid)
        //{
        //    var datinmunizaciones = dc.Tbl_InmunizacionesInmunizaciones.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.inmu_estado == "A");
        //    return datinmunizaciones;
        //}

        ////----------------------------------------------------------------------------------------------------------------------------
        ////------------------------------------------ METODOS PARA GUARDAR Y MODIFICAR DATOS  -----------------------------------------
        ////----------------------------------------------------------------------------------------------------------------------------

        ////B. Inmunizaciones

        ////Metodo para guardar Datos Inmunizaciones
        //public static void guardarInmunizaciones(Tbl_InmunizacionesInmunizaciones datinmunizaciones)
        //{
        //    try
        //    {
        //        datinmunizaciones.inmu_estado = "A";
        //        dc.Tbl_InmunizacionesInmunizaciones.InsertOnSubmit(datinmunizaciones);
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Datos No Guardados" + ex.Message);
        //    }
        //}
    }
}
