using MediatR;
using Microsoft.EntityFrameworkCore;
using ZSHOE.Domain.Models.DataContexts;
using ZSHOE.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZSHOE.Domain.Business.OrderModule
{
    public class OrderGetSingleQuery : IRequest<Order>
    {
        public int Id { get; set; }

        public class OrderGetSingleQueryHandler : IRequestHandler<OrderGetSingleQuery, Order>
        {
            private readonly ZSHOEDbContext db;

            public OrderGetSingleQueryHandler(ZSHOEDbContext db)
            {
                this.db = db;
            }

            public async Task<Order> Handle(OrderGetSingleQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Orders
                    .Include(o => o.User)
                    .Include(o => o.OrderProducts.Where(op => op.DeletedDate == null))
                    .ThenInclude(op => op.Product)
                    .ThenInclude(p => p.ProductImages.Where(i => i.DeletedDate == null && i.IsMain == true))
                    .FirstOrDefaultAsync(p => p.Id == request.Id);

                return data;
            }
        }

    }
}
