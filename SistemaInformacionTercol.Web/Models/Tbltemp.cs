using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class Tbltemp
    {
        public int Inttmpconsecutivo { get; set; }
        public int? Vartmpproveedor { get; set; }
        public string Vartmpproducto { get; set; }
        public double? Flotmpcantidad { get; set; }
    }
}
