using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using SistemaInformacionTercol.Web.Models;

namespace SistemaInformacionTercol.Web.Helpers
{
    interface IUserHelper
    {
        Task<Tblusuarios> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(Tblusuarios Usuario, string Password);

        Task CheckRoleAsync(string Perfil);

        Task AddUserToRoleAsync(Tblusuarios Usuario, string Perfil);

        Task<bool> IsUserInRoleAsync(Tblusuarios Usuario, string Perfil);

        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();
    }

}