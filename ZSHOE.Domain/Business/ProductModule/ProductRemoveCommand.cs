using ZSHOE.Domain.Models.DataContexts;
using ZSHOE.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;
using ZSHOE.Domain.Models.Entities;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using ZSHOE.Domain.AppCode.Extensions;

namespace ZSHOE.Domain.Business.ProductModule
{
    public class ProductRemoveCommand : IRequest<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public class ProductRemoveCommandHandler : IRequestHandler<ProductRemoveCommand, Product>
        {
            private readonly ZSHOEDbContext db;
            private readonly IActionContextAccessor ctx;

            public ProductRemoveCommandHandler(ZSHOEDbContext db,IActionContextAccessor ctx)
            {
                this.db = db;
                this.ctx = ctx;
            }
            public async Task<Product> Handle(ProductRemoveCommand request, CancellationToken cancellationToken)
            {
                var data = await db.Products
                    .Include(p=>p.ProductCatalog)
                    .FirstOrDefaultAsync(m => m.Id == request.Id && m.DeletedDate == null, cancellationToken);

                if (data == null)
                {
                    return null;
                }

                data.DeletedDate = DateTime.UtcNow.AddHours(4);
                data.DeletedByUserId = ctx.GetCurrentUserId();

                var productItems = await db.ProductCatalogItems.Where(pc => pc.ProductId == data.Id).ToListAsync();

                foreach (var item in productItems)
                {
                    item.DeletedDate = DateTime.UtcNow.AddHours(4);
                }

                await db.SaveChangesAsync(cancellationToken);


                return data;
            }
        }
    }
}
