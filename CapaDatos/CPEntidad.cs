using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CPEntidad
    {
        private CPConnection connection = new CPConnection();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public DataTable Mostrar()
        {
            cmd.Connection = connection.AbrirConexion();
            cmd.CommandText = "set * from Entidad";
            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            return tabla;
        }
    }
}
