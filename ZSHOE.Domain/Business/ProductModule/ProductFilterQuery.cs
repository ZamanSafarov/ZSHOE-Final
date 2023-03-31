using ZSHOE.Domain.AppCode.Infrastructure;
using ZSHOE.Domain.Models.DataContexts;
using ZSHOE.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ZSHOE.Domain.Models.Entities;

namespace ZSHOE.Domain.Business.ProductModule
{
    public class ProductFilterQuery : PaginateModel, IRequest<PagedViewModel<Product>>
    {
        public int[] Colors { get; set; }
        public int[] Sizes { get; set; }
        public int[] Categories { get; set; }
        public int[] Brands { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public class ProductFilterQueryHandler : IRequestHandler<ProductFilterQuery, PagedViewModel<Product>>
        {
            private readonly ZSHOEDbContext db;

            public ProductFilterQueryHandler(ZSHOEDbContext db)
            {
                this.db = db;
            }

            public async Task<PagedViewModel<Product>> Handle(ProductFilterQuery request, CancellationToken cancellationToken)
            {
                var query = db.ProductCatalogItems
                    .AsQueryable();

               

                if (request.Colors != null && request.Colors.Length > 0)
                {
                    query = query.Where(q => request.Colors.Contains(q.ColorId));
                }

                if (request.Sizes != null && request.Sizes.Length > 0)
                {
                    query = query.Where(q => request.Sizes.Contains(q.SizeId));
                }


               


                var productIds = await query.Select(q => q.ProductId)
                    .Distinct()
                    .ToArrayAsync(cancellationToken);

                var productQuery = db.Products
                    .Include(p => p.ProductImages.Where(i=>i.DeletedDate==null))
                    .Where(p => productIds.Contains(p.Id)&& p.DeletedDate==null)
                    .AsQueryable();

                if (request.Categories != null && request.Categories.Length > 0)
                {
                    productQuery = productQuery.Where(q => request.Categories.Contains(q.CategoryId));
                }

                if (request.Brands != null && request.Brands.Length > 0)
                {
                    productQuery = productQuery.Where(q => request.Brands.Contains(q.BrandId));
                }

              
                if (request.Min > 0 && request.Min <= request.Max)
                {
                    productQuery = productQuery.Where(q => q.Price >= request.Min && q.Price <= request.Max);
                }

                productQuery = productQuery
                    .Include(q => q.Category)
                    .OrderByDescending(q => q.Id);
                    

                var pagedModel = new PagedViewModel<Product>(productQuery, request);

                return pagedModel;
            }
        }
    }
}