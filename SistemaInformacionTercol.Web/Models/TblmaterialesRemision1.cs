using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class TblmaterialesRemision1
    {
        public int Intmr1consecutivo { get; set; }
        public int? Intmr1numero { get; set; }
        public string Varmr1producto { get; set; }
        public string Varmr1proveedor { get; set; }
        public double? Flomr1cantidad { get; set; }
        public string Varmr1observaciones { get; set; }
    }
}
