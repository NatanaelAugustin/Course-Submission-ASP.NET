using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;

namespace ASP.NET_App.Models.Identities
{
    public class CustomClaimsPrincipalFactory : UserClaimsPrincipalFactory<AppUser, IdentityRole>
    {
        private readonly UserManager<AppUser> userManager;

        public CustomClaimsPrincipalFactory(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IOptions<IdentityOptions> optionsAccessor) : base(userManager, roleManager, optionsAccessor)
        {
            this.userManager = userManager;
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(AppUser user)
        {
            var claimsIdentity = await base.GenerateClaimsAsync(user);

            claimsIdentity.AddClaim(new Claim("DisplayFullName", $"{user.FirstName} {user.LastName}"));

            claimsIdentity.AddClaim(new Claim("DisplayFirstName", $"{user.FirstName}"));

            claimsIdentity.AddClaim(new Claim("DisplayLastName", $"{user.LastName}"));

            return claimsIdentity;
        }
        public override async Task<ClaimsPrincipal> CreateAsync(AppUser user)
        {
            var principal = await base.CreateAsync(user);

            if (user != null && await UserManager.IsInRoleAsync(user, "admin"))
            {
                ((ClaimsIdentity)principal.Identity!).AddClaim(new Claim("IsAdmin", "true"));
            }

            return principal;
        }
    }
}


