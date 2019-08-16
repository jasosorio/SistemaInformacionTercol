using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class TblrecepcionProveedors
    {
        public int Intrpsnumero { get; set; }
        public DateTime? Datrpsfecha { get; set; }
        public int? Intrpsproveedor { get; set; }
        public string Varrpsobservaciones { get; set; }
    }
}
