using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class TblitemsTemporalGodcs
    {
        public int Intitgoconsecutivo { get; set; }
        public int? IntitgonumeroOdcs { get; set; }
        public string VaritgoreferenciaProducto { get; set; }
        public double? Floitgocantidad { get; set; }
        public double? FloitgovalorPactado { get; set; }
    }
}
