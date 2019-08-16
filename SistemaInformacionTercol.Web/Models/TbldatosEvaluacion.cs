using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class TbldatosEvaluacion
    {
        public int Intdeconsecutivo { get; set; }
        public int? Intdenodcs { get; set; }
        public string Vardeproveedor { get; set; }
        public string VardereferenciaProducto { get; set; }
        public double? FlodecantidadRecibida { get; set; }
        public double? FlodecantidadVerificada { get; set; }
        public int? Intdevaltiempo { get; set; }
        public int? Intdevalcantidad { get; set; }
        public int? Intdevalcalidad { get; set; }
        public string Varderesponsable { get; set; }
        public DateTime? Datdefecha { get; set; }
        public double? Flodeportiempo { get; set; }
        public double? Flodeporcantidad { get; set; }
        public double? Flodeporcalidad { get; set; }
    }
}
