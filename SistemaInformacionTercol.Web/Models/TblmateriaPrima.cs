using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class TblmateriaPrima
    {
        public int Intmpconsecutivo { get; set; }
        public string Varmpreferencia { get; set; }
        public string Varmpdescripcion { get; set; }
        public int? Intmplinea { get; set; }
        public string VarmpunidadMedida { get; set; }
        public double? Flompotro { get; set; }
        public double? Flompespesor { get; set; }
        public double? Flomplargo { get; set; }
        public double? Flompancho { get; set; }
        public double? FlompcostoUnidad { get; set; }
        public string Varmpevaluador { get; set; }
        public string Varmptipo { get; set; }
        public double? Flompcantidad { get; set; }
        public string VarmpdensidadKgUn { get; set; }
        public string Varmppatron { get; set; }
        public string VarmpfechaAprobaPatron { get; set; }
        public string VarmpdocumentoOPlano { get; set; }
        public string VarmpfechaAprobaPlano { get; set; }
        public string Varmpguia { get; set; }
        public string VarmpusoGuia { get; set; }
        public string VarmpfechaAprobaGuia { get; set; }
        public double? FlompprecioVentav { get; set; }
        public double? FlompprecioVentan { get; set; }
        public double? Flompdescuento { get; set; }
        public int? IntmpautoLiberable { get; set; }
        public double? FlomppuntoMinimo { get; set; }
        public double? FlomppuntoMaximo { get; set; }
        public int? Intmpestado { get; set; }
    }
}
