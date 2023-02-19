using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ZSHOE.Domain.AppCode.Infrastructure;
using ZSHOE.Domain.Models.Entities.Membership;

namespace ZSHOE.Domain.Models.Entities
{
    public class Order : BaseEntity
    {

        [Required(ErrorMessage = "{0} cannot be left empty")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "{0} cannot be left empty")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "{0} cannot be left empty")]
        public string PhoneNumber { get; set; }

        public decimal TotalAmount { get; set; }

        [Required(ErrorMessage = "{0} cannot be left empty")]
        public string Address { get; set; }

        public virtual ZSHOEUser User { get; set; }

        public int UserId { get; set; }

        public bool IsDelivered { get; set; } = false;

        public ICollection<OrderProduct> OrderProducts { get; set; }


    }
}
