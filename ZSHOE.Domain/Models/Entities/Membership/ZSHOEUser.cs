using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ZSHOE.Domain.Models.Entities.Membership
{
    public class ZSHOEUser : IdentityUser<int>
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
    }
}
