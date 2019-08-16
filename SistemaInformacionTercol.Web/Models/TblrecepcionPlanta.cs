using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class TblrecepcionPlanta
    {
        public int Intrpconsecutivo { get; set; }
        public string Varrpforma { get; set; }
        public string VarrpoperarioEntrega { get; set; }
        public string Varrpobservaciones { get; set; }
        public int? Intrpnumero { get; set; }
        public int? IntrpcantidadPosibleRecibir { get; set; }
        public string Varrpreferencia { get; set; }
        public int? IntrpcantidadRecibida { get; set; }
    }
}
