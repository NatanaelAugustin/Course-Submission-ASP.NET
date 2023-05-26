using ASP.NET_App.Models.Identities;
using ASP.NET_App.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace ASP.NET_App.Services
{
    public class AuthenticationService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly AddressService _addressService;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SeedService _seedService;


        public AuthenticationService(UserManager<AppUser> userManger, AddressService addressService, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager, SeedService seedService)
        {
            _userManager = userManger;
            _addressService = addressService;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _seedService = seedService;
        }

        public async Task<bool> UserAlreadyExistsAsync(RegisterViewModel viewModel)
        {
            return await _userManager.Users.AnyAsync(x => x.Email == viewModel.Email);

        }

        public async Task<bool> RegisterUserAsync(RegisterViewModel viewModel)
        {
            await _seedService.SeedRoles();

            var roleName = "user";

            if (!await _userManager.Users.AnyAsync())
                roleName = "admin";

            AppUser appUser = viewModel;

            var result = await _userManager.CreateAsync(appUser, viewModel.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(appUser, roleName);

                var addressEntity = await _addressService.GetorCreateAsync(viewModel);
                if (addressEntity != null)
                {
                    await _addressService.AddAddressAsync(appUser, addressEntity);
                    return true;
                }

            }

            return false;
        }

        public async Task<bool> LoginAsync(LoginViewModel viewModel)
        {
            var appUser = await _userManager.Users.FirstOrDefaultAsync(x => x.Email == viewModel.Email);
            if (appUser != null)
            {
                var result = await _signInManager.PasswordSignInAsync(appUser, viewModel.Password, viewModel.RememberMe, false);
                return result.Succeeded;
            }
            return false;
        }
    }

}
