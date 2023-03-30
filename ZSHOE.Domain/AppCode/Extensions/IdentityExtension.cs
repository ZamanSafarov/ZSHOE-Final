
using ZSHOE.Domain.Models.DataContexts;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ZSHOE.Domain.AppCode.Extensions
{
    public static partial class Extension
    {
        public static string[] policies = null;
        public static string GetPrincipalName(this ClaimsPrincipal principal)
        {
            string name = principal.Claims.FirstOrDefault(c => c.Type.Equals("name"))?.Value;
            string surname = principal.Claims.FirstOrDefault(c => c.Type.Equals("surname"))?.Value;

            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(surname))
            {
                return $"{name} {surname}";
            }

            return principal.Claims.FirstOrDefault(c => c.Type.Equals(ClaimTypes.Email))?.Value;
        }

        public static int GetCurrentUserId(this ClaimsPrincipal principal)
        {
            var userId = Convert.ToInt32(principal.Claims.FirstOrDefault(c => c.Type.Equals(ClaimTypes.NameIdentifier))?.Value);

            return userId;
        }

        public static int GetCurrentUserId(this IActionContextAccessor ctx)
        {
            return ctx.ActionContext.HttpContext.User.GetCurrentUserId();
        }

        public static int GetCurrentUserId(this ClaimsIdentity identity)
        {
            return Convert.ToInt32(
                    identity.Claims.FirstOrDefault(c =>
                    c.Type.Equals(ClaimTypes.NameIdentifier)).Value
                    );
        }

        public static bool HasAccess(this ClaimsPrincipal principal, string policyName)
        {
            return principal.IsInRole("SuperAdmin") || principal.HasClaim(c => c.Type.Equals(policyName) && c.Value.Equals("1"));
        }
    }
}
