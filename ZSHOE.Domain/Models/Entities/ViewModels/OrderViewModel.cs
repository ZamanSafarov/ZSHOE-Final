using ZSHOE.Domain.Models.Entities;
using System.Collections.Generic;

namespace ZSHOE.Domain.Models.ViewModels.OrderViewModel
{
    public class OrderViewModel
    {
        public IEnumerable<Basket> BasketProducts { get; set; }

        public Order OrderDetails { get; set; }
    }
}
