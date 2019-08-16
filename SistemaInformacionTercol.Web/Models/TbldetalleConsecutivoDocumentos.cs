using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class TbldetalleConsecutivoDocumentos
    {
        public int IntdcdnumeroItem { get; set; }
        public int? IntdcdnumeroCd { get; set; }
        public string VardcdreferenciaItem { get; set; }
        public double? FlodcdcantidadItem { get; set; }
        public double? FlodcdcostoUnidadItem { get; set; }
    }
}
