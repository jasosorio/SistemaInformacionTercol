using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class TbldatosProcesodp
    {
        public int Intdpoconsecutivo { get; set; }
        public int? IntdponumeroOrden { get; set; }
        public int? IntdpocodigoProceso { get; set; }
        public int? IntdpocodigoOperario { get; set; }
        public double? Flodpocantidad { get; set; }
        public int? Intdpoinspeccion { get; set; }
        public int? Intdpotermino { get; set; }
        public double? Flodpoduracionh { get; set; }
        public double? Flodpocostouni { get; set; }
        public double? Flodpocostocan { get; set; }
        public DateTime? Datdpofechaini { get; set; }
        public DateTime? Datdpofechafin { get; set; }
        public TimeSpan? Timdpohoraini { get; set; }
        public TimeSpan? Timdpohorafin { get; set; }
        public int? Intdpopasada { get; set; }
        public int? Intdpoayudante { get; set; }
        public int? Intdpoinspeccion1 { get; set; }
        public int? Intdpoalis { get; set; }
        public int? Intdpopasada1 { get; set; }
        public int? Intdpotermino1 { get; set; }
    }
}
