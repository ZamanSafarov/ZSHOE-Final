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

namespace ZSHOE.Domain.Business.CategoryModule
{
    
    public class OurCategoriesQuery : IRequest<List<Category>>
    {

        public int Size { get; set; }
        public int CategoryId { get; set; }

        public class OurCategoriesQueryHandler : IRequestHandler<OurCategoriesQuery, List<Category>>
        {
            private readonly ZSHOEDbContext db;

            public OurCategoriesQueryHandler(ZSHOEDbContext db)
            {
                this.db = db;
            }
            public async Task<List<Category>> Handle(OurCategoriesQuery request, CancellationToken cancellationToken)
            {
                var posts = await db.Categories
                     .Where(c => c.DeletedDate == null && c.CreatedDate != null)
                     .OrderByDescending(c => c.CreatedDate)
                     .Take(request.Size < 3 ? 3 : request.Size)
                     .ToListAsync(cancellationToken);

                return posts;
            }
        }

    }
}
