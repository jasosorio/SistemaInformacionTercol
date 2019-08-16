using System.ComponentModel.DataAnnotations;

namespace SistemaInformacionTercol.Web.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Usuario { get; set; }

        [Required]
        [MinLength(6)]
        public string Contraseña { get; set; }

        public bool Recordarme { get; set; }
    }
}

