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
    public class BlogPostRecentQuery : IRequest<List<BlogPost>>
    {

        public int Size { get; set; }
        public int PostId { get; set; }

        public class BlogPostRecentQueryHandler : IRequestHandler<BlogPostRecentQuery, List<BlogPost>>
        {
            private readonly ZSHOEDbContext db;

            public BlogPostRecentQueryHandler(ZSHOEDbContext db)
            {
                this.db = db;
            }
            public async Task<List<BlogPost>> Handle(BlogPostRecentQuery request, CancellationToken cancellationToken)
            {
                var posts = await db.BlogPosts
                    .Include(bp =>bp.TagCloud)
                     .Where(bp => bp.DeletedDate == null && bp.PublishedDate != null)
                     .OrderByDescending(bp => bp.PublishedDate)
                     .Take(request.Size < 4 ? 4 : request.Size)
                     .ToListAsync(cancellationToken);

                return posts;
            }
        }

    }
}