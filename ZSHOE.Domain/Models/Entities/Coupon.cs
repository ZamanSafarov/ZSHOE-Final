using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZSHOE.Domain.AppCode.Infrastructure;

namespace ZSHOE.Domain.Models.Entities
{
    public class Coupon:BaseEntity
    {
        public string Code { get; set; }
        public decimal DiscountAmount { get; set; }
    }
}
