using ASP.NET_App.Models.Identities;
using ASP.NET_App.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ASP.NET_App.Services
{
    public class AuthenticationService
    {
        public readonly UserManager<AppUser> _userManager;
        public readonly AddressService _addressService;

        public AuthenticationService(UserManager<AppUser> userManger, AddressService addressService)
        {
            _userManager = userManger;
            _addressService = addressService;
        }

        public async Task<bool> UserAlreadyExistsAsync(Expression<Func<AppUser, bool>> expression)
        {
            return await _userManager.Users.AnyAsync(expression);

        }

        public async Task<bool> RegisterUserAsync(RegisterViewModel viewModel)
        {
            AppUser appUser = viewModel;

            var result = await _userManager.CreateAsync(appUser, viewModel.Password);
            if (result.Succeeded)
            {
                var addressEntity = await _addressService.GetorCreateAsync(viewModel);
                if (addressEntity != null)
                {
                    await _addressService.AddAddressAsync(appUser, addressEntity);
                    return true;
                }

            }

            return false;
        }
    }

}
