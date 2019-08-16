using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class Tblremision
    {
        public int Intremnumero { get; set; }
        public DateTime? Datremfecha { get; set; }
        public string Varrempara { get; set; }
        public string Varrempor { get; set; }
        public string Varremobservaciones { get; set; }
        public int? Intremnumpat { get; set; }
    }
}
