using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;
using UserIdentityManagement.Web.Models;

namespace UserIdentityManagement.Web.Data
{
    public class ContextSeed
    {
        public static async Task SeedRoleAsync(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            //await roleManager.CreateAsync(new IdentityRole(Enums.Roles.SuperAdmin.ToString()));
            //await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Admin.ToString()));
            //await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Moderator.ToString()));
            //await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Basic.ToString()));

            foreach (var role in Enum.GetValues(typeof(Enums.Roles)))
            {
                await roleManager.CreateAsync(new IdentityRole(role.ToString()));
            }
        }
    }
}
