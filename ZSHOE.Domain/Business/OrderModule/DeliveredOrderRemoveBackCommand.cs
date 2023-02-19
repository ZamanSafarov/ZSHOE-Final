using MediatR;
using ZSHOE.Domain.Models.DataContexts;
using ZSHOE.Domain.Models.Entities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ZSHOE.Domain.Business.OrderModule
{
    public class DeliveredOrderRemoveBackCommand : IRequest<Order>
    {
        public int Id { get; set; }
        public class DeliveredOrderRemoveBackCommandHandler : IRequestHandler<DeliveredOrderRemoveBackCommand, Order>
        {
            private readonly ZSHOEDbContext db;

            public DeliveredOrderRemoveBackCommandHandler(ZSHOEDbContext db)
            {
                this.db = db;
            }

            public async Task<Order> Handle(DeliveredOrderRemoveBackCommand request, CancellationToken cancellationToken)
            {
                var data = db.Orders.FirstOrDefault(m => m.Id == request.Id && m.IsDelivered == true);

                if (data == null)
                {
                    return null;
                }

                data.IsDelivered = false;

                await db.SaveChangesAsync(cancellationToken);
                return data;
            }
        }
    }
}

