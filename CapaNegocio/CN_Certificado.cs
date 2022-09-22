using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Certificado
    {
        private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        public static List<Tbl_Empresa> ObtenerEmpresa()
        {
            var listaEmp = dc.Tbl_Empresa.Where(emp => emp.Emp_estado == "A");
            return listaEmp.ToList();
        }

        public static Tbl_Certificado ObtenerCertificadoPorId(int id)
        {
            var cerid = dc.Tbl_Certificado.FirstOrDefault(certi => certi.certi_id.Equals(id) && certi.certi_estado == "A");
            return cerid;
        }

        public static Tbl_Certificado ObtenerCertificadoPer(int persoid)
        {
            var cerid = dc.Tbl_Certificado.FirstOrDefault(certi => certi.Per_id.Equals(persoid) && certi.certi_estado == "A");
            return cerid;
        }

        //metodo para traer profesional
        public static List<Tbl_Profesional> ObtenerProfesional()
        {
            var lista = dc.Tbl_Profesional.Where(prof => prof.prof_estado == "A");
            return lista.ToList();
        }

        //----------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------ METODOS PARA GUARDAR Y MODIFICAR DATOS  -----------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------

        // Metodo para guardar datos de Ficha Medica
        public static void GuardarCertificado(Tbl_Certificado certificado)
        {
            try
            {
                certificado.certi_estado = "A";
                dc.Tbl_Certificado.InsertOnSubmit(certificado);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de HC CERTIFICADO" + ex.Message);
            }
        }

        // Metodo para modificar datos de la Ficha Medica
        public static void ModificarCertificado(Tbl_Certificado certificado)
        {
            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de HC CERTIFICADO" + ex.Message);
            }
        }
    }
}
