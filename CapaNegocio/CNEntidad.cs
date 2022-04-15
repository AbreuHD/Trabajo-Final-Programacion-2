using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CNEntidad
    {
        private CDEntidad objEntidad = new CDEntidad();
        
        public DataTable MostrarEntidades()
        {
            DataTable tabla = new DataTable();
            tabla = objEntidad.Mostrar();
            return tabla;
        }
    }
}
