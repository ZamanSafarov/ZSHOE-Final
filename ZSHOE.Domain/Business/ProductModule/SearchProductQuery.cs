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
    public class SearchProductQuery : IRequest<IEnumerable<Product>>
    {
        public string SearchTerm { get; set; }

        public class SearchProductQueryHandler : IRequestHandler<SearchProductQuery, IEnumerable<Product>>
        {
            private readonly ZSHOEDbContext db;

            public SearchProductQueryHandler(ZSHOEDbContext db)
            {
                this.db = db;
            }


            public async Task<IEnumerable<Product>> Handle(SearchProductQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Products
                    .Include(p=>p.Category)
                    .Include(p=>p.Brand)
                        .Include(p => p.ProductImages)
                        .Where(p => p.Name.Contains(request.SearchTerm) || p.Category.Name.Contains(request.SearchTerm) || p.Brand.Name.Contains(request.SearchTerm) && p.DeletedDate == null)
                        .Select(p => new Product
                        {
                            Id = p.Id,
                            Name = p.Name,
                            ProductImages = p.ProductImages,
                            Price = p.Price

                        })
                        .ToListAsync();

                return data;
            }
        }
    }
}
