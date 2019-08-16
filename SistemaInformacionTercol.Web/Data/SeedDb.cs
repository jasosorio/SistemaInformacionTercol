using SistemaInformacionTercol.Web.Helpers;
using SistemaInformacionTercol.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaInformacionTercol.Web.Data
{
    public class SeedDb
    {
        private readonly sigt2Context _context;
        //private readonly IUserHelper _userHelper;

        public SeedDb(
            sigt2Context context/*,
            IUserHelper userHelper*/)
        {
            _context = context;
            //_userHelper = userHelper;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            /*await CheckRoles();
            await CheckPropertyTypesAsync();
            await CheckPropertiesAsync();
            await CheckContractsAsync();

        }

        private Task CheckPropertyTypesAsync()
        {
            throw new NotImplementedException();
        }

        private Task CheckPropertiesAsync()
        {
            throw new NotImplementedException();
        }

        private Task CheckContractsAsync()
        {
            throw new NotImplementedException();
        }

        private async Task CheckRoles()
        {
            await _userHelper.CheckRoleAsync("Manager");*/
        }
    }   
}
