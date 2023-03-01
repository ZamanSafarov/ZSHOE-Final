using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZSHOE.Domain.AppCode.Infrastructure;

namespace ZSHOE.Domain.Models.Entities.Membership
{
    public class ZSHOEForgotPassword:BaseEntity
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
