using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using NetFramework.Layers.ADO.Net;

namespace NetFramework.Layers.CapaDatos
{
    public class CNGruposEntidades
    {
        private CDGruposEntidades objGrupoEntidades = new CDGruposEntidades();
        public DataTable MostrarEntidades()
        {
            return objGrupoEntidades.Mostrar();
        }

        public bool AddDatos(String descripcion, String comentario, String sStatus, int noEliminable) {
            if(descripcion.Equals("") || comentario.Equals("") || sStatus.Equals("") || noEliminable.ToString().Equals(""))
            {
                return false;
            }
            else { return objGrupoEntidades.AddDatos(descripcion, comentario, sStatus, noEliminable); }
        }

        public bool EditDatos(String id, String descripcion, String comentario, String sStatus, int noEliminable)
        {
            if (descripcion.Equals("") || comentario.Equals("") || sStatus.Equals("") || noEliminable.ToString().Equals(""))
            {
                return false;
            }
            else { return objGrupoEntidades.EditDatos(int.Parse(id), descripcion, comentario, sStatus, noEliminable); }
        }

        public bool EliminarDatos(String id)
        {
            return objGrupoEntidades.EliminarDatos(int.Parse(id));
        }

    }
}
