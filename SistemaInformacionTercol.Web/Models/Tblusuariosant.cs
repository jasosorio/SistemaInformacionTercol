using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class Tblusuariosant
    {
        public byte Idusuario { get; set; }
        public byte Idperfil { get; set; }
        public string Strlogin { get; set; }
        public string Strdescripcion { get; set; }
        public string Password { get; set; }
        public int Estado { get; set; }
    }
}
