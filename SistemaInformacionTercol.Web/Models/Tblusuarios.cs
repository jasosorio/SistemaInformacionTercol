using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class Tblusuarios 
    {
        //TODO Poner required
        [Display(Name = "ID")]
        public byte Idusuario { get; set; }
        [Display(Name = "Perfil")]
        public byte Idperfil { get; set; }
        [Display(Name = "Usuario")]
        public string Strlogin { get; set; }
        [Display(Name = "Descripción")]
        public string Strdescripcion { get; set; }
        [Display(Name = "Contraseña")]
        public string Password { get; set; }
        public int Estado { get; set; }
    }
}
