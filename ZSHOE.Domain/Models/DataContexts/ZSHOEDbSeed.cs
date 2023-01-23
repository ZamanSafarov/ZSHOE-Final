using ZSHOE.Domain.Models.Entities.Membership;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ZSHOE.Domain.Models.DataContext
{
    public static class ZSHOEDbSeed
    {
        public static IApplicationBuilder SeedMembership(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var signInManager = scope.ServiceProvider.GetRequiredService<SignInManager<ZSHOEUser>>();
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ZSHOEUser>>();
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<ZSHOERole>>();
                var configuration = scope.ServiceProvider.GetRequiredService<IConfiguration>();

                string superAdminRoleName = configuration["defaultAccount:superAdmin"];
                string superAdminEmail = configuration["defaultAccount:email"];
                string superAdminUserName = configuration["defaultAccount:username"];
                string superAdminPassword = configuration["defaultAccount:password"];
                string superAdminName= configuration["defaultAccount:name"];
                string superAdminSurname = configuration["defaultAccount:surname"];

                var superAdminRole = roleManager.FindByNameAsync(superAdminRoleName).Result;


                if (superAdminRole == null)
                {
                    superAdminRole = new ZSHOERole
                    {
                        Name = superAdminRoleName,
                    };

                    var roleResult = roleManager.CreateAsync(superAdminRole).Result;

                    if (!roleResult.Succeeded)
                    {
                        throw new Exception("Problem at RoleCreating.....");
                    }
                }

                var superAdminUser = userManager.FindByEmailAsync(superAdminEmail).Result;

                if (superAdminUser == null)
                {
                    superAdminUser = new ZSHOEUser
                    {
                        Email = superAdminEmail,
                        UserName = superAdminUserName,
                        EmailConfirmed = true,
                        Name = superAdminName,
                        Surname = superAdminSurname,
                    };

                    var userResult = userManager.CreateAsync(superAdminUser, superAdminPassword).Result;

                    if (!userResult.Succeeded)
                    {
                        throw new Exception("Problem occurred when user is created");
                    }
                }

                var isInRole = userManager.IsInRoleAsync(superAdminUser, superAdminRole.Name).Result;

                if (isInRole != true)
                {
                    userManager.AddToRoleAsync(superAdminUser, superAdminRole.Name).Wait();
                }

            }


            return app;
        }
        public static void SeedUserRole(RoleManager<ZSHOERole> roleManager)
        {

            if (!roleManager.RoleExistsAsync("User").Result)
            {
                ZSHOERole role = new ZSHOERole();
                role.Name = "User";

                IdentityResult roleResult = roleManager.

                CreateAsync(role).Result;
            }
            if (!roleManager.RoleExistsAsync("Moderator").Result)
            {
                ZSHOERole role = new ZSHOERole();
                role.Name = "Moderator";

                IdentityResult roleResult = roleManager.

                CreateAsync(role).Result;
            }

        }
    }
}