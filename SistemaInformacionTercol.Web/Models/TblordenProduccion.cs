using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class TblordenProduccion
    {
        public int Intopnumero { get; set; }
        public DateTime? DatopfechaGeneracion { get; set; }
        public string VaropreferenciaProducto { get; set; }
        public int? IntopcantidadOrdenada { get; set; }
        public string Varopnotas { get; set; }
        public string Varopobservaciones { get; set; }
        public double? FloopcantidadInspeccionar { get; set; }
        public int? Intopliberada { get; set; }
        public int? Intopanulada { get; set; }
        public int? Intoprealizada { get; set; }
        public int? Intopabierta { get; set; }
        public string VaropresponsableGeneracion { get; set; }
        public string VaropfechasLiberacion { get; set; }
        public string VaropresponsablesLiberacion { get; set; }
        public string VaropfechasActualizacion { get; set; }
        public string VaropresponsablesActualizacion { get; set; }
        public DateTime? DatopfechaAnulacion { get; set; }
        public string VaropresponsableAnulacion { get; set; }
        public int? IntopcantidadAdelantada { get; set; }
        public int? IntopcantidadConforme { get; set; }
        public int? IntopcantidadNoConforme { get; set; }
        public double? Floopduracion { get; set; }
        public double? FloopcostoUnidad { get; set; }
        public int? Intopcantidad { get; set; }
        public DateTime? Datopfecha { get; set; }
        public string Varopobservaciones1 { get; set; }
        public int? Intopcantidad1 { get; set; }
        public int? Intopterminada { get; set; }
        public DateTime? DatopfechaTermino { get; set; }
        public int? Intopcantidadr { get; set; }
    }
}
