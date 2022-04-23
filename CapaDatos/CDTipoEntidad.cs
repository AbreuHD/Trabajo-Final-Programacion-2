using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace NetFramework.Layers.ADO.Net
{
    //static Exception a;
    public class CDTipoEntidad
    {
        public CDConnection conexion = new CDConnection();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SpTipoEntidadListar";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                conexion.CerrarConexion();
                return tabla;
            }catch (Exception e) { return null; }
        }

        public bool Eliminar(int id)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SpTipoEntidadEliminar";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdTipoEntidad", id);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
                return true;
            }catch(Exception e) { return false; }
        }

        public bool AddDatos(String descripcion, int idGrupoEntidad, String comentario, String sStatus, int noEliminable)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SpTipoEntidadInsertar";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdTipoEntidad", 0);
                comando.Parameters.AddWithValue("@Descripcion", descripcion);
                comando.Parameters.AddWithValue("@IdGrupoEntidad", idGrupoEntidad);
                comando.Parameters.AddWithValue("@Comentario", comentario);
                comando.Parameters.AddWithValue("@SStatus", sStatus);
                comando.Parameters.AddWithValue("@NoEliminable", noEliminable);
                comando.Parameters.AddWithValue("@FechaRegistro", DateTime.Now.ToString());
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
                return true;
            }catch(Exception ex) { throw ex; return false; }
        
        }

        public bool EditDatos(int id, String descripcion, int idGrupoEntidad, String comentario, String sStatus, int noEliminable)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SpTipoEntidadActualizar";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdTipoEntidad", id);
                comando.Parameters.AddWithValue("@Descripcion", descripcion);
                comando.Parameters.AddWithValue("@IdGrupoEntidad", idGrupoEntidad);
                comando.Parameters.AddWithValue("@Comentario", comentario);
                comando.Parameters.AddWithValue("@SStatus", sStatus);
                comando.Parameters.AddWithValue("@NoEliminable", noEliminable);
                comando.Parameters.AddWithValue("@FechaRegistro", DateTime.Now.ToString());
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
                return true;
            } catch(Exception e) { return false; }

        }
    }
}
