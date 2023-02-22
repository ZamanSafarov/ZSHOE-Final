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

namespace ZSHOE.Domain.Business.BlogPostModule
{
    public class BlogPostGetLikesQuery : IRequest<List<BlogPostLike>>
    {
        public int BlogPostId { get; set; }

        public class BlogPostGetLikesQueryHandler : IRequestHandler<BlogPostGetLikesQuery, List<BlogPostLike>>
        {
            private readonly ZSHOEDbContext db;

            public BlogPostGetLikesQueryHandler(ZSHOEDbContext db)
            {
                this.db = db;
            }

            public async Task<List<BlogPostLike>> Handle(BlogPostGetLikesQuery request, CancellationToken cancellationToken)
            {
                var data = await db.BlogPostLikes
                    .Include(bpc => bpc.BlogPost)
                    .Include(bpc => bpc.CreatedByUser)
                    .Where(bpc => bpc.DeletedDate == null && bpc.BlogPostId == request.BlogPostId)
                    .ToListAsync();

                return data;
            }
        }
    }
}
