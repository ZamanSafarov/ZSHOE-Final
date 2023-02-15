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

namespace ZSHOE.Domain.Business.BrandModule
{
    public class BrandGetSingleQuery : IRequest<Brand>
    {
        public int Id { get; set; }

        public class BrandGetSingleQueryHandler : IRequestHandler<BrandGetSingleQuery, Brand>
        {
            private readonly ZSHOEDbContext db;

            public BrandGetSingleQueryHandler(ZSHOEDbContext db)
            {
                this.db = db;
            }

            public async Task<Brand> Handle(BrandGetSingleQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Brands
                    .FirstOrDefaultAsync(p => p.Id == request.Id);

                return data;
            }
        }

    }
}
