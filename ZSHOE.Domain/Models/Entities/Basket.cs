using ZSHOE.Domain.Models.Entities;
using ZSHOE.Domain.Models.Entities.Membership;

namespace ZSHOE.Domain.Models.Entities
{
    public class Basket
    {
        public int UserId { get; set; }
        public virtual ZSHOEUser User { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
