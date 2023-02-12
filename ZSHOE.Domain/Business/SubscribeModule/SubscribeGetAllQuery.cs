
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

namespace ZSHOE.Domain.Business.SubscribeModule
{

    public class SubscribeGetAllQuery : IRequest<List<Subscribe>>
    {
        public class SubscribeGetAllQueryHandler : IRequestHandler<SubscribeGetAllQuery, List<Subscribe>>
        {
            private readonly ZSHOEDbContext db;

            public SubscribeGetAllQueryHandler(ZSHOEDbContext db)
            {
                this.db = db;
            }
            public async Task<List<Subscribe>> Handle(SubscribeGetAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Subscribes
                .Where(bp => bp.DeletedDate == null)
                .ToListAsync(cancellationToken);

                return data;
            }
        }


    }
}