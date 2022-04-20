using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace NetFramework.Layers.ADO.Net
{
    public class CDLogin
    {
        private CDConnection conexion = new CDConnection();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable VerificarLogin(String usuario, String passoword)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SpEntidadLogins";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@UserNameEntidad", usuario);
                comando.Parameters.AddWithValue("@PassworEntidad", passoword);
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                conexion.CerrarConexion();
                return tabla;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
