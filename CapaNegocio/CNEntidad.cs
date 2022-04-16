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

        public void Editar( int id, String userNameEntidad, String passworEntidad, String descripcion,
                            String direccion, String localidad, String tipoEntidad, String tipoDocumento,
                            String telefono, String uRLPaginaWeb, String uRLFacebook,
                            String numeroDocumento, String uRLInstagram, String uRLTwitter, String uRLTikTok,
                            String comentario, String idTipoEntidad, String limiteCredito, String idGrupoEntidad, String sStatus,
                            String rolUserEntidad, int noEliminable)

        {
            int idEntidad = int.Parse(idTipoEntidad);
            int intidGrupoEntidad = int.Parse(idGrupoEntidad);

            objEntidad.Editar(id, userNameEntidad, passworEntidad, descripcion,
                              direccion, localidad, tipoEntidad, tipoDocumento,
                              telefono, uRLPaginaWeb, uRLFacebook,
                              numeroDocumento, uRLInstagram, uRLTwitter, uRLTikTok,
                              comentario, idEntidad, int.Parse(limiteCredito), intidGrupoEntidad, sStatus, rolUserEntidad, noEliminable);
        }

        public void Crear(String userNameEntidad, String passworEntidad, String descripcion,
                          String direccion, String localidad, String tipoEntidad, String tipoDocumento,
                          String telefono, String uRLPaginaWeb, String uRLFacebook,
                          String numeroDocumento, String uRLInstagram, String uRLTwitter, String uRLTikTok,
                          String comentario, String idTipoEntidad, String limiteCredito, String idGrupoEntidad, String sStatus,
                          String rolUserEntidad, int noEliminable)
        {
            objEntidad.Insertar(userNameEntidad, passworEntidad, descripcion,
                                direccion, localidad, tipoEntidad, tipoDocumento,
                                telefono, uRLPaginaWeb, uRLFacebook,
                                numeroDocumento, uRLInstagram, uRLTwitter, uRLTikTok,
                                comentario, Convert.ToInt32(idTipoEntidad), Convert.ToInt32(limiteCredito), Convert.ToInt32(idGrupoEntidad),
                                sStatus, rolUserEntidad, noEliminable);
        }

        public bool Eliminar(String ID)
        {
            return objEntidad.Eliminar(int.Parse(ID));
        }

    }

}
