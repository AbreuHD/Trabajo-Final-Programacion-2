﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Layers.Datos
{
    public class TipoEntidad
    {
        public decimal IdTipoEntidad { get; set; }
        public string Descripcion { get; set; }
        public decimal IdGrupoEntidad { get; set; }
        public string Comentario { get; set; }
        public string SStatus { get; set; }
        public bool NoEliminable { get; set; }
    }
}