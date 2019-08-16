using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class Tblproveedormp
    {
        public int Intpmpcodigo { get; set; }
        public string VarpmprazonSocial { get; set; }
        public string Varpmpnit { get; set; }
        public string Varpmpdireccion { get; set; }
        public int? Intpmpciudad { get; set; }
        public string Varpmptelefono { get; set; }
        public string Varpmpfax { get; set; }
        public string Varpmpemail { get; set; }
        public string Varpmpcontacto { get; set; }
        public int? Intpmpestado { get; set; }
        public int? IntpmpcontroladoCalidad { get; set; }
        public int? IntpmptipoCalidad { get; set; }
        public double? Flopmpevaluacion { get; set; }
        public DateTime? DatpmpfechaEvaluacion { get; set; }
        public double? Flopmpdescuento { get; set; }
        public int? IntpmptiempoEntrega { get; set; }
        public int? Intpmpplazo { get; set; }
        public string Varpmpproducto { get; set; }
        public string VarpmpevaluacionesCalidad { get; set; }
        public string Varpmpactualizaciones { get; set; }
        public string VarpmpquienRealiza { get; set; }
        public DateTime? DatpmpfechaIngreso { get; set; }
        public string Varpmpde { get; set; }
        public string Varpmpciudad { get; set; }
    }
}
