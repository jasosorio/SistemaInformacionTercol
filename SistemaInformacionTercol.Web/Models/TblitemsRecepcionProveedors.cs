using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class TblitemsRecepcionProveedors
    {
        public int Intirpsconsecutivo { get; set; }
        public int? IntirpsnumeroRps { get; set; }
        public string VarirpsreferenciaProducto { get; set; }
        public double? FloirpscantidadRecibida { get; set; }
    }
}
