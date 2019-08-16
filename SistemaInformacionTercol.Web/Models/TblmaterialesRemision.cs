using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class TblmaterialesRemision
    {
        public int Intmrconsecutivo { get; set; }
        public int? IntmrnumeroRemision { get; set; }
        public string Varmrpara { get; set; }
        public string Varmrpor { get; set; }
        public string VarmrreferenciaProducto { get; set; }
        public double? Flomrcantidad { get; set; }
        public double? Flomrcosto { get; set; }
        public int? Intmrnumpat { get; set; }
    }
}
