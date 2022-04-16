using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDGruposEntidades
    {
        private CDConnection conexion = new CDConnection();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SpGrupoEntidadListar";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public bool AddDatos(String descripcion, String comentario, String sStatus, int noEliminable)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SpGrupoEntidadInsertar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdGrupoEntidad", 0);
            comando.Parameters.AddWithValue("@Descripcion", descripcion);
            comando.Parameters.AddWithValue("@Comentario", comentario);
            comando.Parameters.AddWithValue("@SStatus", sStatus);
            comando.Parameters.AddWithValue("@NoEliminable", noEliminable);
            comando.Parameters.AddWithValue("@FechaRegistro", DateTime.Now.ToString());
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return true;
        }

        public bool EditDatos(int id, String descripcion, String comentario, String sStatus, int noEliminable)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SpGrupoEntidadActualizar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdGrupoEntidad", id);
            comando.Parameters.AddWithValue("@Descripcion", descripcion);
            comando.Parameters.AddWithValue("@Comentario", comentario);
            comando.Parameters.AddWithValue("@SStatus", sStatus);
            comando.Parameters.AddWithValue("@NoEliminable", noEliminable);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return true;
        }

        public bool EliminarDatos(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SpGrupoEntidadEliminar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdGrupoEntidad", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return true;
        }
    }
}
