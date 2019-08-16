using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class TblproductoProceso
    {
        public int Intppconsecutivo { get; set; }
        public string Varppreferencia { get; set; }
        public string Varppdescripcion { get; set; }
        public int? Intpplinea { get; set; }
        public string VarppunidadMedida { get; set; }
        public double? Flopplargo { get; set; }
        public double? Floppancho { get; set; }
        public double? Floppcosto { get; set; }
        public string Varpptipo { get; set; }
        public double? Floppservicio { get; set; }
        public DateTime? DatppfechaActproces { get; set; }
        public DateTime? DatppfechaActcompo { get; set; }
        public double? Floppcantidad { get; set; }
        public string VarppdensidadKgUn { get; set; }
        public string Varpppatron { get; set; }
        public string VarppfechaAprobaPatron { get; set; }
        public string VarppdocumentoOPlano { get; set; }
        public string VarppfechaAprobaPlano { get; set; }
        public string Varppguia { get; set; }
        public string VarppusoGuia { get; set; }
        public string VarppfechaAprobaGuia { get; set; }
        public double? FloppprecioVentav { get; set; }
        public double? FloppprecioVentan { get; set; }
        public double? Floppdescuento { get; set; }
        public int? IntppautoLiberable { get; set; }
        public double? FlopppuntoMinimo { get; set; }
        public double? FlopppuntoMaximo { get; set; }
        public int? Intppestado { get; set; }
    }
}
