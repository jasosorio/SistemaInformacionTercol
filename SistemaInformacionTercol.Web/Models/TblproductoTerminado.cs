using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class TblproductoTerminado
    {
        public int Intptconsecutivo { get; set; }
        public string Varptreferencia { get; set; }
        public string Varptdescripcion { get; set; }
        public int? Intptlinea { get; set; }
        public string VarptunidadMedida { get; set; }
        public double? Floptcosto { get; set; }
        public DateTime? DatptfechaActproces { get; set; }
        public DateTime? DatptfechaActcompo { get; set; }
        public double? Floptcantidad { get; set; }
        public string VarptdensidadKgUn { get; set; }
        public string Varptpatron { get; set; }
        public string VarptfechaAprobaPatron { get; set; }
        public string VarptdocumentoOPlano { get; set; }
        public string VarptfechaAprobaPlano { get; set; }
        public string Varptguia { get; set; }
        public string VarptusoGuia { get; set; }
        public string VarptfechaAprobaGuia { get; set; }
        public double? FloptprecioVentav { get; set; }
        public double? FloptprecioVentan { get; set; }
        public double? Floptdescuento { get; set; }
        public int? IntptautoLiberable { get; set; }
        public double? FloptpuntoMinimo { get; set; }
        public double? FloptpuntoMaximo { get; set; }
    }
}
