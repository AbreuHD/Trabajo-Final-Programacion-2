using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using NetFramework.Layers.ADO.Net.CapaNegocio;

namespace NetFramework.Layers.ADO.Net.CapaNegocio
{
    public class CNGruposEntidades
    {
        private CapaDatos.CDGruposEntidades objGrupoEntidades = new CapaDatos.CDGruposEntidades();
        public DataTable MostrarEntidades()
        {
            DataTable tabla = new DataTable();
            tabla = objGrupoEntidades.Mostrar();
            return tabla;
        }

        public bool AddDatos(String descripcion, String comentario, String sStatus, int noEliminable) {
            return objGrupoEntidades.AddDatos(descripcion, comentario, sStatus, noEliminable);
        }

        public bool EditDatos(String id, String descripcion, String comentario, String sStatus, int noEliminable)
        {
            return objGrupoEntidades.EditDatos(int.Parse(id), descripcion, comentario, sStatus, noEliminable);
        }

        public bool EliminarDatos(String id)
        {
            return objGrupoEntidades.EliminarDatos(int.Parse(id));
        }

    }
}
