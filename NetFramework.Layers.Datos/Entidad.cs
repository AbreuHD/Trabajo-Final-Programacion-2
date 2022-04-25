using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Layers.Datos
{
    public class Entidad
    {
        public int IdEntidad { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public string TipoEntidad { get; set; }
        public string TipoDocumento { get; set; }
        public decimal NumeroDocumento { get; set; }
        public string Teléfonos { get; set; }
        public string URLPaginaWeb { get; set; }
        public string URLFacebook { get; set; }
        public string URLInstagram { get; set; }
        public string URLTwitter { get; set; }
        public string URLTikTok { get; set; }
        public decimal IdGrupoEntidad { get; set; }
        public decimal IdTipoEntidad { get; set; }
        public int LimiteCredito { get; set; }
        public string UserNameEntidad { get; set; }
        public string PassworEntidad { get; set; }
        public string RolUserEntidad { get; set; }
        public string Comentario { get; set; }
        public string SStatus { get; set; }
        public bool NoEliminable { get; set; }
        public DateTime? FechaRegistro { get; set; }
    }
}
