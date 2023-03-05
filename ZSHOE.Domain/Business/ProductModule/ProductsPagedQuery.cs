using ZSHOE.Domain.AppCode.Infrastructure;
using ZSHOE.Domain.Models.DataContexts;
using ZSHOE.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ZSHOE.Domain.Business.ProductModule
{
    public class ProductsPagedQuery :PaginateModel, IRequest<PagedViewModel<Product>>
    {
        public class ProductsPagedQueryHandler : IRequestHandler<ProductsPagedQuery, PagedViewModel<Product>>
        {
            private readonly ZSHOEDbContext db;

            public ProductsPagedQueryHandler(ZSHOEDbContext db)
            {
                this.db = db;
            }

            public async Task<PagedViewModel<Product>> Handle(ProductsPagedQuery request, CancellationToken cancellationToken)
            {
                var query = db.Products
                    .Include(p => p.ProductImages.Where(i => i.DeletedDate == null))
                    .Include(p=>p.Brand)
                    .Include(p=>p.Category)
                    .Where(m => m.DeletedDate == null)
                    .OrderByDescending(p=>p.Id)
                    .AsQueryable();

                var pagedDate = new PagedViewModel<Product>(query, request);

                return pagedDate;
            }
        }
    }
}
