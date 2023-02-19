
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZSHOE.Domain.Models.Entities;
using ZSHOE.Domain.Models.DataContexts;

namespace ZSHOE.Domain.Business.OrderModule
{
    public class CancelledOrderRemoveBackCommand : IRequest<Order>
    {
        public int Id { get; set; }
        public class CancelledOrderRemoveBackCommandHandler : IRequestHandler<CancelledOrderRemoveBackCommand, Order>
        {
            private readonly ZSHOEDbContext db;

            public CancelledOrderRemoveBackCommandHandler(ZSHOEDbContext db)
            {
                this.db = db;
            }

            public async Task<Order> Handle(CancelledOrderRemoveBackCommand request, CancellationToken cancellationToken)
            {
                var data = db.Orders.FirstOrDefault(m => m.Id == request.Id && m.DeletedDate != null);

                if (data == null)
                {
                    return null;
                }

                data.DeletedDate = null;
                data.IsDelivered = false;

                await db.SaveChangesAsync(cancellationToken);
                return data;
            }
        }
    }
}

