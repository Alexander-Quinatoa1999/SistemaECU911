using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    //public class CN_SocioEconomico
    //{

    //    //private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();
    //    private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

    //    //metodo traer para traer Datos Generales SSO 
    //    public static Tbl_DatosGeneralesSSO obtenerDatosGeneralesSSO(int personaid)
    //    {
    //        var datgensso = dc.Tbl_DatosGeneralesSSO.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.DatGeneralesSSO_estado == "A");
    //        return datgensso;
    //    }

    //    //metodo traer para traer Salud SSO 
    //    public static Tbl_SaludSSO obtenerDatosSaludSSO(int personaid)
    //    {
    //        var datsaludsso = dc.Tbl_SaludSSO.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.SaludSSO_estado == "A");
    //        return datsaludsso;
    //    }

    //    //metodo traer para traer Informacion Familiar SSO 
    //    public static Tbl_InformacionFamiliarSSO obtenerDatosInformacionFamiliarSSO(int personaid)
    //    {
    //        var datinfofamisso = dc.Tbl_InformacionFamiliarSSO.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.InfoFamiliarSSO_estado == "A");
    //        return datinfofamisso;
    //    }

    //    //metodo traer para traer Actividad Tiempo Libre SSO 
    //    public static Tbl_ActTiempoLibreSSO obtenerDatosActividadTiempoLibreSSO(int personaid)
    //    {
    //        var datactiemlibsso = dc.Tbl_ActTiempoLibreSSO.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.ActReTiemLibreSSO_estado == "A");
    //        return datactiemlibsso;
    //    }

    //    //metodo traer para traer Informacion Estabilidad Familiar SSO 
    //    public static Tbl_InfoEstabilidadFamiliarSSO obtenerDatosEstabilidadFamiliarSSO(int personaid)
    //    {
    //        var datestfamisso = dc.Tbl_InfoEstabilidadFamiliarSSO.FirstOrDefault(per => per.Per_id.Equals(personaid) && per.InfoEstabFamiliarSSO_estado == "A");
    //        return datestfamisso;
    //    }

    //    //----------------------------------------------------------------------------------------------------------------------------
    //    //------------------------------------------ METODOS PARA GUARDAR Y MODIFICAR DATOS  -----------------------------------------
    //    //----------------------------------------------------------------------------------------------------------------------------

    //    //1. DATOS GENERALES SSO

    //    //Metodo para guardar DATOS GENERALES SSO
    //    public static void guardarDatosGenerlaesSSO(Tbl_DatosGeneralesSSO datosgensso)
    //    {
    //        try
    //        {
    //            datosgensso.DatGeneralesSSO_estado = "A";
    //            dc.Tbl_DatosGeneralesSSO.InsertOnSubmit(datosgensso);
    //            dc.SubmitChanges();
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new ArgumentException("Datos No Guardados" + ex.Message);
    //        }
    //    }

    //    //2. SALUD SSO

    //    //Metodo para guardar DATOS SALUD SSO
    //    public static void guardarDatosSaludSSO(Tbl_SaludSSO datosaludsso)
    //    {
    //        try
    //        {
    //            datosaludsso.SaludSSO_estado = "A";
    //            dc.Tbl_SaludSSO.InsertOnSubmit(datosaludsso);
    //            dc.SubmitChanges();
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new ArgumentException("Datos No Guardados" + ex.Message);
    //        }
    //    }

    //    //3. INFORMACION FAMILIAR SSO

    //    //Metodo para guardar INFORMACION FAMILIAR SSO
    //    public static void guardarDatosInformacionFamiliarSSO(Tbl_InformacionFamiliarSSO datoinfofamsso)
    //    {
    //        try
    //        {
    //            datoinfofamsso.InfoFamiliarSSO_estado = "A";
    //            dc.Tbl_InformacionFamiliarSSO.InsertOnSubmit(datoinfofamsso);
    //            dc.SubmitChanges();
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new ArgumentException("Datos No Guardados" + ex.Message);
    //        }
    //    }

    //    //4. ACTIVIDADES QUE REALIZA EN SU TIEMPO LIBRE SSO

    //    //Metodo para guardar ACTIVIDADES QUE REALIZA EN SU TIEMPO LIBRE SSO
    //    public static void guardarDatosActividadTiempoLibreSSO(Tbl_ActTiempoLibreSSO datoactiemlibresso)
    //    {
    //        try
    //        {
    //            datoactiemlibresso.ActReTiemLibreSSO_estado = "A";
    //            dc.Tbl_ActTiempoLibreSSO.InsertOnSubmit(datoactiemlibresso);
    //            dc.SubmitChanges();
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new ArgumentException("Datos No Guardados" + ex.Message);
    //        }
    //    }

    //    //5. INFORMACION ESTABILIDAD FAMILIAR SSO

    //    //Metodo para guardar INFORMACION ESTABILIDAD FAMILIAR SSO
    //    public static void guardarDatosInformacionEstabilidadFamiliarSSO(Tbl_InfoEstabilidadFamiliarSSO datoinfoestafamisso)
    //    {
    //        try
    //        {
    //            datoinfoestafamisso.InfoEstabFamiliarSSO_estado = "A";
    //            dc.Tbl_InfoEstabilidadFamiliarSSO.InsertOnSubmit(datoinfoestafamisso);
    //            dc.SubmitChanges();
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new ArgumentException("Datos No Guardados" + ex.Message);
    //        }
    //    }

    //}
}
