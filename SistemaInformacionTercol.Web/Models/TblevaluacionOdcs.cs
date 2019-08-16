using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class TblevaluacionOdcs
    {
        public int Inteoconsecutivo { get; set; }
        public DateTime? DateofechaEvaluacion { get; set; }
        public int? InteonumeroOrden { get; set; }
        public int? InteoitemOrden { get; set; }
        public double? FloeocantidadRecibida { get; set; }
        public double? FloeocantidadVerificada { get; set; }
        public int? InteoevaluacionTiempo { get; set; }
        public int? InteoevaluacionCalidad { get; set; }
        public int? InteoevaluacionCantidad { get; set; }
        public double? FloeoporcentajeEvaluacionTiempo { get; set; }
        public double? FloeoporcentajeEvaluacionCalidad { get; set; }
        public double? FloeoporcentajeEvaluacionCantidad { get; set; }
        public string VareoresponsableEvaluacion { get; set; }
    }
}
