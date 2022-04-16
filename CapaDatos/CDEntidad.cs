using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDEntidad
    {
        private CDConnection conexion = new CDConnection();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SpEntidadListar";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Editar( int id, String userNameEntidad, String passworEntidad, String descripcion,
                            String direccion, String localidad, String tipoEntidad, String tipoDocumento,
                            String telefono, String uRLPaginaWeb, String uRLFacebook,
                            String numeroDocumento, String uRLInstagram, String uRLTwitter, String uRLTikTok,
                            String comentario, int idTipoEntidad, int limiteCredito, int idGrupoEntidad, String sStatus,
                            String rolUserEntidad, int noEliminable)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SpEntidadActualizar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdEntidad", id);
            comando.Parameters.AddWithValue("@UserNameEntidad", userNameEntidad);
            comando.Parameters.AddWithValue("@PassworEntidad", passworEntidad);
            comando.Parameters.AddWithValue("@Descripcion", descripcion);
            comando.Parameters.AddWithValue("@Direccion", direccion);
            comando.Parameters.AddWithValue("@Localidad", localidad);
            comando.Parameters.AddWithValue("@TipoEntidad", tipoEntidad);
            comando.Parameters.AddWithValue("@TipoDocumento", tipoDocumento);
            comando.Parameters.AddWithValue("@Teléfonos", telefono);
            comando.Parameters.AddWithValue("@URLPaginaWeb", uRLPaginaWeb);
            comando.Parameters.AddWithValue("@URLFacebook", uRLFacebook);
            comando.Parameters.AddWithValue("@NumeroDocumento", numeroDocumento);
            comando.Parameters.AddWithValue("@URLInstagram", uRLInstagram);
            comando.Parameters.AddWithValue("@URLTwitter", uRLTwitter);
            comando.Parameters.AddWithValue("@URLTikTok", uRLTikTok);
            comando.Parameters.AddWithValue("@Comentario", comentario);
            comando.Parameters.AddWithValue("@IdTipoEntidad", idTipoEntidad);
            comando.Parameters.AddWithValue("@LimiteCredito", limiteCredito);
            comando.Parameters.AddWithValue("@IdGrupoEntidad", idGrupoEntidad);
            comando.Parameters.AddWithValue("@SStatus", sStatus);
            comando.Parameters.AddWithValue("@RolUserEntidad", rolUserEntidad);
            comando.Parameters.AddWithValue("@NoEliminable", noEliminable);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Insertar(String userNameEntidad, String passworEntidad, String descripcion,
                             String direccion, String localidad, String tipoEntidad, String tipoDocumento,
                             String telefono, String uRLPaginaWeb, String uRLFacebook,
                             String numeroDocumento, String uRLInstagram, String uRLTwitter, String uRLTikTok,
                             String comentario, int idTipoEntidad, int limiteCredito, int idGrupoEntidad, String sStatus,
                             String rolUserEntidad, int noEliminable)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SpEntidadInsertar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdEntidad", 0);
            comando.Parameters.AddWithValue("@UserNameEntidad", userNameEntidad);
            comando.Parameters.AddWithValue("@PassworEntidad", passworEntidad);
            comando.Parameters.AddWithValue("@Descripcion", descripcion);
            comando.Parameters.AddWithValue("@Direccion", direccion);
            comando.Parameters.AddWithValue("@Localidad", localidad);
            comando.Parameters.AddWithValue("@TipoEntidad", tipoEntidad);
            comando.Parameters.AddWithValue("@TipoDocumento", tipoDocumento);
            comando.Parameters.AddWithValue("@Teléfonos", telefono);
            comando.Parameters.AddWithValue("@URLPaginaWeb", uRLPaginaWeb);
            comando.Parameters.AddWithValue("@URLFacebook", uRLFacebook);
            comando.Parameters.AddWithValue("@NumeroDocumento", numeroDocumento);
            comando.Parameters.AddWithValue("@URLInstagram", uRLInstagram);
            comando.Parameters.AddWithValue("@URLTwitter", uRLTwitter);
            comando.Parameters.AddWithValue("@URLTikTok", uRLTikTok);
            comando.Parameters.AddWithValue("@Comentario", comentario);
            comando.Parameters.AddWithValue("@IdTipoEntidad", idTipoEntidad);
            comando.Parameters.AddWithValue("@LimiteCredito", limiteCredito);
            comando.Parameters.AddWithValue("@IdGrupoEntidad", idGrupoEntidad);
            comando.Parameters.AddWithValue("@SStatus", sStatus);
            comando.Parameters.AddWithValue("@RolUserEntidad", rolUserEntidad);
            comando.Parameters.AddWithValue("@NoEliminable", noEliminable);
            comando.Parameters.AddWithValue("@FechaRegistro", DateTime.Now.ToString());
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        
        public bool Eliminar(int ID)
        {   
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SpEntidadEliminar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdEntidad", ID);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            return true;
        }
    }
}

