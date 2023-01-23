using ZSHOE.Domain.AppCode.Services;
using ZSHOE.Domain.Models.DataContexts;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using ZSHOE.Domain.Models.Entities.Membership;
using ZSHOE.Domain.Models.DataContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using ZSHOE.Domain.AppCode.Providers;
using ZSHOE.Domain.AppCode.Extensions;

namespace ZSHOE.WebUI
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;   // json file larini oxuya bilmek uchun
        }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(cfg => {

                var policy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build();

                cfg.Filters.Add(new AuthorizeFilter(policy));
            });

            services.AddDbContext<ZSHOEDbContext>(cfg =>
            {
                cfg.UseSqlServer(configuration.GetConnectionString("cString"));
            })
            .AddIdentity<ZSHOEUser, ZSHOERole>()
            .AddEntityFrameworkStores<ZSHOEDbContext>()
            .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(cfg => {
                cfg.User.RequireUniqueEmail = true;
                cfg.Password.RequireDigit = false;
                cfg.Password.RequireUppercase = false;
                cfg.Password.RequireLowercase = false;
                cfg.Password.RequireNonAlphanumeric = false;
                cfg.Password.RequiredUniqueChars = 1; //123
                cfg.Lockout.DefaultLockoutTimeSpan = new TimeSpan(0, 1, 0);
                cfg.Lockout.MaxFailedAccessAttempts = 3;
                cfg.Password.RequiredLength = 3;

            });

            services.ConfigureApplicationCookie(cfg =>
            {
                cfg.LoginPath = "/signin.html";
                cfg.AccessDeniedPath = "/accesdenied.html";

                cfg.Cookie.Name = "ZSHOE";
                cfg.Cookie.HttpOnly = true;
                cfg.ExpireTimeSpan = new TimeSpan(0, 15, 0);
            });



            services.AddAuthentication();
            services.AddAuthorization(cfg =>
            {
                foreach (var policyName in Extension.policies)
                {
                    cfg.AddPolicy(policyName, p =>
                    {
                        p.RequireAssertion(handler =>
                        {
                            return handler.User.IsInRole("SuperAdmin") ||
                            handler.User.HasClaim(policyName, "1");
                        });
                    });

                }
            });

            services.AddScoped<UserManager<ZSHOEUser>>();
            services.AddScoped<SignInManager<ZSHOEUser>>();
            services.AddScoped<RoleManager<ZSHOERole>>();


            services.Configure<EmailServiceOptions>(cfg =>
            {
                configuration.GetSection("emailAccount").Bind(cfg);
            });

            services.AddSingleton<EmailService>();
            services.AddSingleton<CryptoService>();


            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
            services.AddScoped<IClaimsTransformation, AppClaimProvider>();

            services.AddRouting(cfg =>   
            {
                cfg.LowercaseUrls = true;
            });


            var asemblies = AppDomain.CurrentDomain.GetAssemblies().AsEnumerable().Where(a => a.FullName.StartsWith("ZSHOE."));

            services.AddMediatR(asemblies.ToArray());

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, RoleManager<ZSHOERole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.SeedMembership();
            ZSHOEDbSeed.SeedUserRole(roleManager);

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(cfg =>
            {
                cfg.MapAreaControllerRoute("defaultAdmin", "admin", "admin/{controller=dashboard}/{action=index}/{id?}");

                cfg.MapControllerRoute(
                name: "default-accesdenied",
                pattern: "accesdenied.html",
                defaults: new
                {
                    area = "",
                    controller = "account",
                    action = "accesdenied"
                });

                cfg.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");
            });
        }
    }
}