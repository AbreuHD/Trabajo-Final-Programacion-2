using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Layers.CapaDatos
{
    public class CNTipoEntidad
    {
        NetFramework.Layers.ADO.Net.CDTipoEntidad objGrupoEntidad = new NetFramework.Layers.ADO.Net.CDTipoEntidad();

        public DataTable MostrarTipoEntidades()
        {
            return objGrupoEntidad.Mostrar();
        }

        public bool Eliminar(String id)
        {
            return objGrupoEntidad.Eliminar(Convert.ToInt32(id));
        }

        public bool AddTipos(String descripcion, String idGrupoEntidad, String comentario, String sStatus, int noEliminable)
        {
            if (descripcion.Equals("") || idGrupoEntidad.Equals("") || comentario.Equals("") || sStatus.Equals("") || noEliminable.ToString().Equals(""))
            {
                return false;
            }
            else { return objGrupoEntidad.AddDatos(descripcion, Convert.ToInt32(idGrupoEntidad), comentario, sStatus, noEliminable); }
        }

        public bool EditTipos(String id, String descripcion, String idGrupoEntidad, String comentario, String sStatus, int noEliminable)
        {
            if(descripcion.Equals("") || idGrupoEntidad.Equals("") || comentario.Equals("") || sStatus.Equals("") || noEliminable.ToString().Equals(""))
            {
                return false;
            }else { return objGrupoEntidad.EditDatos(Convert.ToInt32(id), descripcion, Convert.ToInt32(idGrupoEntidad), comentario, sStatus, noEliminable); }
        }
    }
}
