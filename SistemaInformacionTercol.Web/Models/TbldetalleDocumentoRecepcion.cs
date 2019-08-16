using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class TbldetalleDocumentoRecepcion
    {
        public int Intddrconsecutivo { get; set; }
        public int? IntddridDocumento { get; set; }
        public int? IntddritemDocumento { get; set; }
        public double? Floddrcantidad { get; set; }
        public double? FloddrcantidadPagada { get; set; }
        public int? Intddrpagado { get; set; }
        public string VarddrresponsablesRegistroDocumento { get; set; }
        public string VarddrfechasRegistroDocumento { get; set; }
        public string VarddrresponsablesPagoDocumento { get; set; }
        public string VarddrfechasPagoDocumento { get; set; }
    }
}
