using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class Tblnovedades
    {
        public int Intnovconsecutivo { get; set; }
        public string VarnovdebidaA { get; set; }
        public string Varnovnovedad { get; set; }
        public string Varnovafecta { get; set; }
        public string VarnovrealizadaPor { get; set; }
        public DateTime? Datnovfecha { get; set; }
        public TimeSpan? Timnovhora { get; set; }
    }
}
