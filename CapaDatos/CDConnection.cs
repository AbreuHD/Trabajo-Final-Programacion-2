using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CapaDatos
{
    public class CDConnection
    {
        private SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
        //new SqlConnection("Server=(local);DataBase= SellPoint;Integrated Security=true");

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {   
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
