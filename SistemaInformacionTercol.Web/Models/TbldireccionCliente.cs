using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class TbldireccionCliente
    {
        public int Intdccodigo { get; set; }
        public int? Intdccliente { get; set; }
        public int? Intdcciudad { get; set; }
        public string Vardcdireccion { get; set; }
    }
}
