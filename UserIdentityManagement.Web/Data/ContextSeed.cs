using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
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

        public static async Task SeedSuperAdminAsync(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            var defaultUser = new ApplicationUser
            {
                UserName = "superadmin",
                Email = "superadmin@mail.com",
                Name = "Murat Can",
                LastName = "Kurt",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };
            //var superAdminRoleId = roleManager.FindByNameAsync(Enums.Roles.SuperAdmin.ToString()).Result.Id;

            if (userManager.Users.All(u => u.Id != defaultUser.Id)) //check if there is no user in database with defaultUser's Id.
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "123Pa$$word.");
                    foreach (var role in Enum.GetValues(typeof(Enums.Roles)))
                    {
                        await userManager.AddToRoleAsync(defaultUser, role.ToString());
                    }
                }
            }
        }
    }
}
