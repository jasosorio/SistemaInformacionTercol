using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class TblsegOpcionMenu
    {
        public byte Idopcion { get; set; }
        public string Strnombre { get; set; }
        public DateTime Dtmfecha { get; set; }
        public string Strdescripcion { get; set; }
        public string Strlink { get; set; }
        public int? Intnivel { get; set; }
        public int? Intidopcion { get; set; }
    }
}
