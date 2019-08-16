using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class Tblpadre
    {
        public string VarpadreferenciaProducto { get; set; }
        public string VarpadreferenciaPadre { get; set; }
        public double? Flopadcantidad { get; set; }
        public string Varpadtipo { get; set; }
        public double? Flopadcosto { get; set; }
        public string Varpadunidad { get; set; }
        public string Varpadtipo1 { get; set; }
        public double? Flopadcosto1 { get; set; }
    }
}
