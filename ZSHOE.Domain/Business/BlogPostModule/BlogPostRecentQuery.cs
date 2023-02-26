using MediatR;
using Microsoft.EntityFrameworkCore;
using ZSHOE.Domain.Models.DataContexts;
using ZSHOE.Domain.Models.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ZSHOE.Domain.Business.BlogPostModule
{
    public class BlogPostPopularQuery : IRequest<List<BlogPost>>
    {

        public int Size { get; set; }
        public int PostId { get; set; }

        public class BlogPostPopularQueryHandler : IRequestHandler<BlogPostPopularQuery, List<BlogPost>>
        {
            private readonly ZSHOEDbContext db;

            public BlogPostPopularQueryHandler(ZSHOEDbContext db)
            {
                this.db = db;
            }
            public async Task<List<BlogPost>> Handle(BlogPostPopularQuery request, CancellationToken cancellationToken)
            {
                var posts = await db.BlogPosts
                     .Where(bp => bp.DeletedDate == null && bp.PublishedDate != null)
                     .OrderByDescending(bp => bp.Likes.Count())
                     .Take(request.Size < 5 ? 5 : request.Size)
                     .ToListAsync(cancellationToken);

                return posts;
            }
        }

    }
}