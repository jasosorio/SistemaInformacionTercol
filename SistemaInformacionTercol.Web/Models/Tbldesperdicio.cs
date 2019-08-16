using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class Tbldesperdicio
    {
        public int Intdsconsecutivo { get; set; }
        public double? Flodscantidad { get; set; }
        public string VardsreferenciaProducto { get; set; }
        public string VardstipoReferencia { get; set; }
        public string Vardsunidad { get; set; }
    }
}
