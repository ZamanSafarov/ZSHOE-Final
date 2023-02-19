using ZSHOE.Domain.Models.DataContexts;
using ZSHOE.Domain.Models.Entities;
using ZSHOE.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZSHOE.Domain.Business.ProductModule
{
    public class ProductSingleQuery : IRequest<Product>
    {
        public int Id { get; set; }

        public class ProductSingleQueryHandler : IRequestHandler<ProductSingleQuery, Product>
        {
            private readonly ZSHOEDbContext db;

            public ProductSingleQueryHandler(ZSHOEDbContext db)
            {
                this.db = db;
            }
            public async Task<Product> Handle(ProductSingleQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Products
                    .Include(p=>p.ProductCatalog)
                    .ThenInclude(p=>p.Size)
                    .Include(p => p.ProductCatalog)
                    .ThenInclude(p=>p.Color)
                    .Include(p=>p.ProductImages.Where(i=>i.DeletedDate == null))
                    .Include(p=>p.Brand)
                    .Include(p=>p.Category)
                    .FirstOrDefaultAsync(m => m.Id == request.Id && m.DeletedDate == null,cancellationToken);

                return data;
            }
        }
    }
}
