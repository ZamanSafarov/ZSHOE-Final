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

    public class OrderRemoveCommand : IRequest<Order>
    {
        public int Id { get; set; }

        public class OrderRemoveCommandHandler : IRequestHandler<OrderRemoveCommand, Order>
        {
            private readonly ZSHOEDbContext db;

            public OrderRemoveCommandHandler(ZSHOEDbContext db)
            {
                this.db = db;
            }

            public async Task<Order> Handle(OrderRemoveCommand request, CancellationToken cancellationToken)
            {
                var data = db.Orders.FirstOrDefault(m => m.Id == request.Id && m.DeletedDate == null);

                if (data == null)
                {
                    return null;
                }

                data.DeletedDate = DateTime.UtcNow.AddHours(4);

                await db.SaveChangesAsync(cancellationToken);
                return data;
            }
        }
    }
}
