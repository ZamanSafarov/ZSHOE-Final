using MediatR;
using Microsoft.EntityFrameworkCore;
using ZSHOE.Domain.Models.DataContexts;
using ZSHOE.Domain.Models.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ZSHOE.Domain.Business.ProductModule
{
    public class ProductRecentArrivalsQuery : IRequest<List<Product>>
    {

        public int Size { get; set; }
        public int ProductId { get; set; }

        public class ProductRecentArrivalsQueryHandler : IRequestHandler<ProductRecentArrivalsQuery, List<Product>>
        {
            private readonly ZSHOEDbContext db;

            public ProductRecentArrivalsQueryHandler(ZSHOEDbContext db)
            {
                this.db = db;
            }
            public async Task<List<Product>> Handle(ProductRecentArrivalsQuery request, CancellationToken cancellationToken)
            {
                var posts = await db.Products
                    .Include(p => p.ProductCatalog)
                    .ThenInclude(p => p.Color)
                    .Include(p => p.ProductImages.Where(i => i.DeletedDate == null))
                    .Include(p => p.Brand)
                    .Include(p => p.Category)
                     .Where(bp => bp.DeletedDate == null && bp.CreatedDate != null)
                     .OrderByDescending(bp => bp.CreatedDate)
                     .Take(request.Size < 4 ? 4 : request.Size)
                     .ToListAsync(cancellationToken);

                return posts;
            }
        }

    }
}