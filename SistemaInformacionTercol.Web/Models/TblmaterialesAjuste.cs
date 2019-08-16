using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class TblmaterialesAjuste
    {
        public int Intmajconsecutivo { get; set; }
        public int? Intmajnumero { get; set; }
        public string Varmajtipo { get; set; }
        public string Varmajen { get; set; }
        public int? Intmajen1 { get; set; }
        public string Varmajtipo1 { get; set; }
        public string Varmajproducto { get; set; }
        public double? Flomajcantidad { get; set; }
        public string Varmajunidad { get; set; }
        public int? Intmajacept { get; set; }
        public string Varmajen2 { get; set; }
        public string Varmajobservaciones { get; set; }
    }
}
