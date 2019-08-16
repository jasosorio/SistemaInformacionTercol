using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class TbldetalleOrdenProduccion
    {
        public int Intdoconsecutivo { get; set; }
        public int IntdonumeroOrden { get; set; }
        public DateTime? DatdofechaProceso { get; set; }
        public string VardocodigoMaquina { get; set; }
        public int IntdocodigoProceso { get; set; }
        public double? FlododuracionProceso { get; set; }
        public int? IntdocantidadConforme { get; set; }
        public string VardocodigoOperario { get; set; }
        public double? Flodocoscan { get; set; }
        public double? Flodocosuni { get; set; }
        public int? Intdoinspeccion { get; set; }
        public int? Intdoinspeccion1 { get; set; }
        public string Vardoalistador { get; set; }
    }
}
