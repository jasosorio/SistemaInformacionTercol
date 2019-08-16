using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class TbltelefonoCliente
    {
        public int Inttccodigo { get; set; }
        public int? Inttccliente { get; set; }
        public int? InttctipoTelefono { get; set; }
        public string Vartctelefono { get; set; }
    }
}
