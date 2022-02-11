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

        //private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();
        private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        //metodo para guardar
        public static void guardarPedidoExamenes(Tbl_PedidoExamenes pedexa)
        {
            try
            {
                pedexa.PedExam_estado = "A";
                //pedexa.PedExam_bioHematicaHema = "Si";
                //pedexa.PedExam_hematocritoHema = "Si";
                //pedexa.PedExam_hemoglobinaHema = "Si";
                //pedexa.PedExam_vsgHema = "Si";
                dc.Tbl_PedidoExamenes.InsertOnSubmit(pedexa);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Datos No Guardados" + ex.Message);
            }
        }

    }
}
