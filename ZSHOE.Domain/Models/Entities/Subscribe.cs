using ZSHOE.Domain.AppCode.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;

namespace ZSHOE.Domain.Models.Entities
{
    public class Subscribe:BaseEntity
    {

        [Required(ErrorMessage = "{0} cannot be left empty")]
        public string Email { get; set; }
        public bool IsApproved { get; set; } = false;
        public DateTime? ApprovedDate { get; set; }
    }
}
