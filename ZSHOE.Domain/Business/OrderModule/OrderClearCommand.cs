using MediatR;
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
    public class OrderClearCommand : IRequest<Order>
    {
        public int Id { get; set; }
        public class OrderClearCommandHandler : IRequestHandler<OrderClearCommand, Order>
        {
            private readonly ZSHOEDbContext db;

            public OrderClearCommandHandler(ZSHOEDbContext db)
            {
                this.db = db;
            }

            public async Task<Order> Handle(OrderClearCommand request, CancellationToken cancellationToken)
            {
                var data = db.Orders.FirstOrDefault(m => m.Id == request.Id && m.DeletedDate != null);

                if (data == null)
                {
                    return null;
                }

                db.Orders.Remove(data);
                await db.SaveChangesAsync(cancellationToken);
                return data;
            }
        }
    }
}

