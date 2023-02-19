﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using ZSHOE.Domain.Models.DataContexts;
using ZSHOE.Domain.Models.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ZSHOE.Domain.Business.OrderModule
{

    public class OrderGetAllQuery : IRequest<List<Order>>
    {
        public class OrderGetAllQueryHandler : IRequestHandler<OrderGetAllQuery, List<Order>>
        {
            private readonly ZSHOEDbContext db;

            public OrderGetAllQueryHandler(ZSHOEDbContext db)
            {
                this.db = db;
            }
            public async Task<List<Order>> Handle(OrderGetAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Orders
                .Where(o => o.DeletedDate == null && o.IsDelivered == false)
                .ToListAsync(cancellationToken);

                return data;
            }
        }


    }
}
