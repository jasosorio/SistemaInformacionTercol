using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class TblordenCompra
    {
        public int Intocnumero { get; set; }
        public DateTime? Datocfecha { get; set; }
        public int? Intoctipo { get; set; }
        public int? Intocproveedor { get; set; }
        public int? Intocliberada { get; set; }
        public int? Intocanulada { get; set; }
        public int? Intocrecibida { get; set; }
        public int? Intocabierta { get; set; }
        public int? Intocpagada { get; set; }
        public string Varoccondiciones { get; set; }
        public string Varocobservaciones { get; set; }
        public int? IntocevaluacionAtencion { get; set; }
        public double? FloocevaluacionTiempo { get; set; }
        public double? FloocevaluacionCalidad { get; set; }
        public double? FloocevaluacionCantidad { get; set; }
        public double? FloocporcentajeEvaluacionTiempo { get; set; }
        public double? FloocporcentajeEvaluacionCalidad { get; set; }
        public double? FloocporcentajeEvaluacionCantidad { get; set; }
        public DateTime? DatocfechaEvaluacion { get; set; }
        public int? Intocasociada { get; set; }
        public int? Intocterminada { get; set; }
        public string VarocrazonSocialProveedor { get; set; }
        public string Varoctipo { get; set; }
        public int? IntocatencionCompra { get; set; }
        public double? Floocevaltiempo { get; set; }
        public double? Floocevalcantidad { get; set; }
        public double? Floocevalcalidad { get; set; }
        public DateTime? Datocfechaeval { get; set; }
        public double? Floocportiempo { get; set; }
        public double? Floocporcantidad { get; set; }
        public double? Floocporcalidad { get; set; }
    }
}
