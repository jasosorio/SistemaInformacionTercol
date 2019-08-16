using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class TblitemsOdc
    {
        public int Intiodcconsecutivo { get; set; }
        public int? IntiodcnumeroOdc { get; set; }
        public string VariodcreferenciaProducto { get; set; }
        public double? FloiodccantidadOrdenada { get; set; }
        public double? FloiodccostoUnitario { get; set; }
        public double? FloiodccantidadRecibida { get; set; }
        public double? FloiodccantidadVerificada { get; set; }
        public double? FloiodcevaluacionTiempo { get; set; }
        public double? FloiodcevaluacionCalidad { get; set; }
        public double? FloiodcevaluacionCantidad { get; set; }
        public double? FloiodcporcentajeEvaluacionTiempo { get; set; }
        public double? FloiodcporcentajeEvaluacionCalidad { get; set; }
        public double? FloiodcporcentajeEvaluacionCantidad { get; set; }
        public DateTime? DatiodcfechaEvaluacion { get; set; }
        public int? Intiodcanulado { get; set; }
        public int? Intiodcrecibido { get; set; }
        public int? Intiodcabierto { get; set; }
        public int? Intiodcpagado { get; set; }
        public double? Floiodccantidad { get; set; }
        public double? Floiodccantidad1 { get; set; }
        public double? Floiodccantidadr { get; set; }
        public double? Floiodccantidadver { get; set; }
        public double? Floiodccosto { get; set; }
        public int? Intiodcestado { get; set; }
        public string VariodcrazonSocialProveedor { get; set; }
        public string Variodcobservaciones { get; set; }
        public string VariodctipoOrden { get; set; }
        public string Variodccondiciones { get; set; }
        public double? Floiodcevaltiempo { get; set; }
        public double? Floiodcevalcantidad { get; set; }
        public double? Floiodcevalcalidad { get; set; }
        public DateTime? Datiodcfechaeval { get; set; }
        public double? Floiodcportiempo { get; set; }
        public double? Floiodcporcantidad { get; set; }
        public double? Floiodcporcalidad { get; set; }
    }
}
