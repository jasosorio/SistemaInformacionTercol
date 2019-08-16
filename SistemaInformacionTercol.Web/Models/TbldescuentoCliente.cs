using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class TbldescuentoCliente
    {
        public int Intdeccodigo { get; set; }
        public int? Intdeccliente { get; set; }
        public int? IntdectipoDescuento { get; set; }
        public double? Flodecdescuento { get; set; }
    }
}
