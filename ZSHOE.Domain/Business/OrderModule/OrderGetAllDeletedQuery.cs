using MediatR;
using Microsoft.EntityFrameworkCore;
using ZSHOE.Domain.Models.DataContexts;
using ZSHOE.Domain.Models.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace ZSHOE.Domain.Business.OrderModule
{
    public class OrderGetAllCancelledQuery : IRequest<List<Order>>
    {
        public class OrderGetAllCancelledHandler : IRequestHandler<OrderGetAllCancelledQuery, List<Order>>
        {
            private readonly ZSHOEDbContext db;

            public OrderGetAllCancelledHandler(ZSHOEDbContext db)
            {
                this.db = db;
            }


            public async Task<List<Order>> Handle(OrderGetAllCancelledQuery request, CancellationToken cancellationToken)
            {
                var completedOrders = await db.Orders
                    .Where(o => o.DeletedDate != null)
                    .ToListAsync(cancellationToken);


                return completedOrders;
            }
        }
    }
}
