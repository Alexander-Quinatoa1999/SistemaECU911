using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{

    public class CN_PedidoExamenes
    {

        private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        public static List<Tbl_Empresa> ObtenerEmpresa()
        {
            var listaEmp = dc.Tbl_Empresa.Where(emp => emp.Emp_estado == 'A');
            return listaEmp.ToList();
        }

        public static Tbl_PedidoExamenes ObtenerPedidoExamenesPorId(int id)
        {
            var pedid = dc.Tbl_PedidoExamenes.FirstOrDefault(pedexa => pedexa.pedExa_id.Equals(id) && pedexa.pedExa_estado == "A");
            return pedid;
        }

        public static Tbl_PedidoExamenes ObtenerPedidoExamenesPer(int personaid)
        {
            var pedid = dc.Tbl_PedidoExamenes.FirstOrDefault(pedexa => pedexa.Per_id.Equals(personaid) && pedexa.pedExa_estado == "A");
            return pedid;
        }

        public static List<Tbl_Profesional> ObtenerProfesional()
        {
            var lista = dc.Tbl_Profesional.Where(prof => prof.prof_estado == "A");
            return lista.ToList();
        }

        //----------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------ METODOS PARA GUARDAR Y MODIFICAR DATOS  -----------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------

        public static void GuardarPedidoExamenes(Tbl_PedidoExamenes pedexa)
        {
            try
            {
                pedexa.pedExa_estado = "A";
                pedexa.pedExa_fechaHoraGuardado = DateTime.Now;
                dc.Tbl_PedidoExamenes.InsertOnSubmit(pedexa);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de HC PEDIDO EXAMENES" + ex.Message);
            }
        }

        public static void ModificarPedidoExamenes(Tbl_PedidoExamenes pedexa)
        {
            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique los datos de HC PEDIDO EXAMENES" + ex.Message);
            }
        }

    }
}
