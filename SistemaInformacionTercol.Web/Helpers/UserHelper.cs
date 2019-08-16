using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using SistemaInformacionTercol.Web.Models;

namespace SistemaInformacionTercol.Web.Helpers
{
    public class UserHelper : IUserHelper
    {
        private readonly UserManager<Tblusuarios> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<Tblusuarios> _signInManager;

        public UserHelper(
            UserManager<Tblusuarios> userManager,
            RoleManager<IdentityRole> roleManager,
            SignInManager<Tblusuarios> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public async Task<IdentityResult> AddUserAsync(Tblusuarios Usuario, string Password)
        {
            return await _userManager.CreateAsync(Usuario, Password);
        }

        public async Task AddUserToRoleAsync(Tblusuarios Usuario, string Perfil)
        {
            await _userManager.AddToRoleAsync(Usuario, Perfil);
        }

        public async Task CheckRoleAsync(string Perfil)
        {
            var roleExists = await _roleManager.RoleExistsAsync(Perfil);
            if (!roleExists)
            {
                await _roleManager.CreateAsync(new IdentityRole
                {
                    Name = Perfil
                });
            }
        }

        public async Task<Tblusuarios> GetUserByEmailAsync(string email)
        {
            return await _userManager.FindByEmailAsync(email);
        }

        public async Task<bool> IsUserInRoleAsync(Tblusuarios Usuario, string Perfil)
        {
            return await _userManager.IsInRoleAsync(Usuario, Perfil);
        }

        public async Task<SignInResult> LoginAsync(LoginViewModel model)
        {
            return await _signInManager.PasswordSignInAsync(
                model.Usuario,
                model.Contraseña,
                model.Recordarme,
                false);
        }

        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }
    }
}
