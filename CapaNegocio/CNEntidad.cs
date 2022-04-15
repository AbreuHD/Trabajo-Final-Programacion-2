using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaNegocio
{
    public class CNEntidad
    {
        private CapaDatos.CPEntidad objEntidad = new CapaDatos.CPEntidad();
        
        public DataTable MostrarEntidades()
        {
            DataTable dt = new DataTable();
            dt = objEntidad.Mostrar();
            return dt;
        }
    }
}
