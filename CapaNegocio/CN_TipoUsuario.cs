using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_TipoUsuario
    {

        //Instanciamos el dbml
        private static DataClassesECU911DataContext dc = new DataClassesECU911DataContext();

        //Metodo para obtener responsables por usuario
        public static Tbl_TipoUsuario obtenerTusuarioxUsuario(int id)
        {
            var tpuid = dc.Tbl_TipoUsuario.FirstOrDefault(tip => tip.tusu_id.Equals(id) && tip.tusu_estado == 'A');
            return tpuid;
        }

    }
}
