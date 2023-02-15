using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZSHOE.Domain.AppCode.Infrastructure;
using ZSHOE.Domain.Models.Entities.Membership;

namespace ZSHOE.Domain.Models.Entities
{
    public class ProductRate
    {
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public byte Rate { get; set; }
        public int? CreatedByUserId { get; set; }
        public ZSHOEUser CreatedByUser { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow.AddHours(4);
        public int? DeletedUserId { get; set; }
        public ZSHOEUser DeletedByUser { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
