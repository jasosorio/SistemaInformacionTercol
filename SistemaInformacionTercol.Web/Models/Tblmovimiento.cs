using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class Tblmovimiento
    {
        public int Intmovconsecutivo { get; set; }
        public string Varmovtipo { get; set; }
        public string VarmovrealizadoPor { get; set; }
        public int? IntmovnumeroPatenta { get; set; }
        public double? Flomovcantidad { get; set; }
        public string Varmovunidad { get; set; }
        public string VarmovreferenciaProducto { get; set; }
        public string VarmovtipoReferencia { get; set; }
        public string Varmovde { get; set; }
        public string Varmovpara { get; set; }
        public string Varmovafecta { get; set; }
        public string Varmovrecibio { get; set; }
        public DateTime? Datmovfecha { get; set; }
        public double? Flomovcantidad1 { get; set; }
        public double? Flomovcantidad2 { get; set; }
        public string VarmovresponsableMovimiento { get; set; }
    }
}
