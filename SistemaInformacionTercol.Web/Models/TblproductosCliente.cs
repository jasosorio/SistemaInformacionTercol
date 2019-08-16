using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class TblproductosCliente
    {
        public int Intpctconsecutivo { get; set; }
        public string Varpctpor { get; set; }
        public int? Intpctnumero { get; set; }
        public string Varpctcliente { get; set; }
        public double? Flopctcantidad { get; set; }
        public string Varpctproducto { get; set; }
        public string Varpctobservaciones { get; set; }
    }
}
