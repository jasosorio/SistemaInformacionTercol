using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class Tblcliente
    {
        public int Intclconsecutivo { get; set; }
        public double? Floclcantidad { get; set; }
        public string VarclreferenciaProducto { get; set; }
        public string VarclrazonSocial { get; set; }
        public string VarcltipoReferencia { get; set; }
        public string Varclunidad { get; set; }
    }
}
