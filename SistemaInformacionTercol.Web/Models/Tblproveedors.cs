using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class Tblproveedors
    {
        public int Intpscodigo { get; set; }
        public string VarpsrazonSocial { get; set; }
        public string Varpsnit { get; set; }
        public string Varpsdireccion { get; set; }
        public int? Intpsciudad { get; set; }
        public string Varpstelefono { get; set; }
        public string Varpsfax { get; set; }
        public string Varpsemail { get; set; }
        public string Varpscontacto { get; set; }
        public int? Intpsestado { get; set; }
        public int? IntpscontroladoCalidad { get; set; }
        public int? IntpstipoCalidad { get; set; }
        public double? Flopsevaluacion { get; set; }
        public DateTime? DatpsfechaEvaluacion { get; set; }
        public double? Flopsdescuento { get; set; }
        public int? IntpstiempoEntrega { get; set; }
        public int? Intpsplazo { get; set; }
        public string Varpsproducto { get; set; }
        public string VarpsevaluacionesCalidad { get; set; }
        public string Varpsactualizaciones { get; set; }
        public string VarpsquienRealiza { get; set; }
        public DateTime? DatpsfechaIngreso { get; set; }
        public string Varpsde { get; set; }
        public string Varpsciudad { get; set; }
    }
}
