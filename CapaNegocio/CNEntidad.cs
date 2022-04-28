using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace NetFramework.Layers.ADO.Net.CapaNegocio
{
    public class CNEntidad
    {
        private CDEntidad objEntidad = new CDEntidad();

        public DataTable MostrarEntidades()
        {
            return objEntidad.Mostrar(); ;
        }

        public bool Editar(int id, String userNameEntidad, String passworEntidad, String descripcion,
                            String direccion, String localidad, String tipoEntidad, String tipoDocumento,
                            String telefono, String uRLPaginaWeb, String uRLFacebook,
                            String numeroDocumento, String uRLInstagram, String uRLTwitter, String uRLTikTok,
                            String comentario, String idTipoEntidad, String limiteCredito, String idGrupoEntidad, String sStatus,
                            String rolUserEntidad, int noEliminable)

        {
            if (userNameEntidad.Equals("") || passworEntidad.Equals("") || descripcion.Equals("") ||
                direccion.Equals("") || localidad.Equals("") || tipoEntidad.Equals("") || tipoDocumento.Equals("") ||
                telefono.Equals("") || uRLPaginaWeb.Equals("") || uRLFacebook.Equals("") ||
                numeroDocumento.Equals("") || uRLInstagram.Equals("") || uRLTwitter.Equals("") || uRLTikTok.Equals("") ||
                comentario.Equals("") || idTipoEntidad.Equals("") || limiteCredito.Equals("") || idGrupoEntidad.Equals("") ||
                sStatus.Equals("") || rolUserEntidad.Equals("") || noEliminable.ToString().Equals(""))
            {
                return false;
            }
            else
            {
                return objEntidad.Editar(id, userNameEntidad, passworEntidad, descripcion,
                                  direccion, localidad, tipoEntidad, tipoDocumento,
                                  telefono, uRLPaginaWeb, uRLFacebook,
                                  numeroDocumento, uRLInstagram, uRLTwitter, uRLTikTok,
                                  comentario, int.Parse(idTipoEntidad), int.Parse(limiteCredito), int.Parse(idGrupoEntidad), sStatus, rolUserEntidad, noEliminable);
            }

        }

        public bool Crear(String userNameEntidad, String passworEntidad, String descripcion,
                          String direccion, String localidad, String tipoEntidad, String tipoDocumento,
                          String telefono, String uRLPaginaWeb, String uRLFacebook,
                          String numeroDocumento, String uRLInstagram, String uRLTwitter, String uRLTikTok,
                          String comentario, String idTipoEntidad, String limiteCredito, String idGrupoEntidad, String sStatus,
                          String rolUserEntidad, int noEliminable)
        {
            if (userNameEntidad.Equals("") || passworEntidad.Equals("") || descripcion.Equals("") ||
                direccion.Equals("") || localidad.Equals("") || tipoEntidad.Equals("") || tipoDocumento.Equals("") ||
                telefono.Equals("") || uRLPaginaWeb.Equals("") || uRLFacebook.Equals("") ||
                numeroDocumento.Equals("") || uRLInstagram.Equals("") || uRLTwitter.Equals("") || uRLTikTok.Equals("") ||
                comentario.Equals("") || idTipoEntidad.Equals("") || limiteCredito.Equals("") || idGrupoEntidad.Equals("") || 
                sStatus.Equals("") || rolUserEntidad.Equals("") || noEliminable.ToString().Equals(""))
            {
                return false;
            }
            else
            {
                return objEntidad.Insertar(userNameEntidad, passworEntidad, descripcion,
                    direccion, localidad, tipoEntidad, tipoDocumento,
                    telefono, uRLPaginaWeb, uRLFacebook,
                    numeroDocumento, uRLInstagram, uRLTwitter, uRLTikTok,
                    comentario, Convert.ToInt32(idTipoEntidad), Convert.ToInt32(limiteCredito), Convert.ToInt32(idGrupoEntidad),
                    sStatus, rolUserEntidad, noEliminable);

            }
        }

        public bool Eliminar(String ID)
        {
            return objEntidad.Eliminar(int.Parse(ID));
        }

    }

}
