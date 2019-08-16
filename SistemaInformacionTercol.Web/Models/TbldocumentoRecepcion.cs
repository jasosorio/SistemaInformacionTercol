using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class TbldocumentoRecepcion
    {
        public int Intdrconsecutivo { get; set; }
        public int? IntdrtipoDocumento { get; set; }
        public string VardrnumeroDocumento { get; set; }
        public int? IntdrtipoOrden { get; set; }
        public int? Intdrproveedor { get; set; }
        public int? Intdrpagado { get; set; }
        public DateTime? DatdrfechaGeneracion { get; set; }
        public string VardrresponsablesRegistro { get; set; }
        public string VardrfechasRegistro { get; set; }
        public DateTime? DatdrfechaPago { get; set; }
        public string VardrresponsablesPago { get; set; }
        public string VardrfechasPago { get; set; }
        public int? IntdrnumeroDocumento { get; set; }
    }
}
