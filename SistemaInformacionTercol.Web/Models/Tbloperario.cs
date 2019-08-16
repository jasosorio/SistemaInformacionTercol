using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class Tbloperario
    {
        public int Intopecodigo { get; set; }
        public string Varopenombre { get; set; }
        public string Varopeapellido { get; set; }
        public string Varopeinicial { get; set; }
        public double? FloopesalarioHora { get; set; }
        public int? Intopeestado { get; set; }
        public DateTime? DatopefechaIngreso { get; set; }
    }
}
