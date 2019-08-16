using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class Tblclientet
    {
        public int Intcltcodigo { get; set; }
        public string VarcltrazonSocial { get; set; }
        public string Varcltnit { get; set; }
        public string Varcltdireccion { get; set; }
        public int? Intcltciudad { get; set; }
        public string Varclttelefono { get; set; }
        public string Varcltfax { get; set; }
        public string Varcltemail { get; set; }
        public string Varcltcontacto { get; set; }
        public int? Intcltestado { get; set; }
        public int? IntcltcontroladoCalidad { get; set; }
        public int? IntclttipoCalidad { get; set; }
        public double? Flocltevaluacion { get; set; }
        public DateTime? DatcltfechaEvaluacion { get; set; }
        public double? Flocltdescuento { get; set; }
        public int? IntclttiempoEntrega { get; set; }
        public int? Intcltplazo { get; set; }
        public string Varcltproducto { get; set; }
        public string VarcltevaluacionesCalidad { get; set; }
        public string Varcltactualizaciones { get; set; }
        public string VarcltquienRealiza { get; set; }
        public DateTime? DatcltfechaIngreso { get; set; }
        public double? Flocltdescuentov { get; set; }
        public string Varcltciudad { get; set; }
    }
}
