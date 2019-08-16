using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class TblmaterialesPlanta
    {
        public int Intmapconsecutivo { get; set; }
        public int? Intmapnumero { get; set; }
        public string Varmapproducto { get; set; }
        public string Varmapoperario { get; set; }
        public double? Flomapcantidad { get; set; }
        public string Varmapobservaciones { get; set; }
    }
}
