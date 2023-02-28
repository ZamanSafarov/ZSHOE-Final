using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZSHOE.Domain.Models.DataContexts;
using ZSHOE.Domain.Models.Entities;

namespace ZSHOE.Domain.Business.ProductModule
{
   
    public class RatedProductsQuery : IRequest<List<Product>>
    {

        public int Size { get; set; }
        public int ProductId { get; set; }

        public class RatedProductsQueryHandler : IRequestHandler<RatedProductsQuery, List<Product>>
        {
            private readonly ZSHOEDbContext db;

            public RatedProductsQueryHandler(ZSHOEDbContext db)
            {
                this.db = db;
            }
            public async Task<List<Product>> Handle(RatedProductsQuery request, CancellationToken cancellationToken)
            {
                var posts = await db.Products
                    .Include(p => p.ProductCatalog)
                    .ThenInclude(p => p.Color)
                    .Include(p => p.ProductImages.Where(i => i.DeletedDate == null))
                    .Include(p => p.Brand)
                    .Include(p => p.Category)
                     .Where(p => p.Rate >3 && p.DeletedDate == null)
                     .OrderByDescending(p => p.Rate)
                     .Take(request.Size < 4 ? 4 : request.Size)
                     .ToListAsync(cancellationToken);

                return posts;
            }
        }

    }
}
