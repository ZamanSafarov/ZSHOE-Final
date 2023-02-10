using MediatR;
using Microsoft.EntityFrameworkCore;
using ZSHOE.Domain.Models.DataContexts;
using ZSHOE.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZSHOE.Domain.Business.BlogPostModule
{
    public class BlogPostGetSingleCommentQuery : IRequest<BlogPostComment>
    {
        public int Id { get; set; }
        public class BlogPostGetSingleCommentQueryHandler : IRequestHandler<BlogPostGetSingleCommentQuery, BlogPostComment>
        {
            private readonly ZSHOEDbContext db;

            public BlogPostGetSingleCommentQueryHandler(ZSHOEDbContext db)
            {
                this.db = db;
            }

            public async Task<BlogPostComment> Handle(BlogPostGetSingleCommentQuery request, CancellationToken cancellationToken)
            {
                var data = await db.BlogPostComments
                    .Include(bpc=>bpc.CreatedByUser)
                    .FirstOrDefaultAsync(bpc => bpc.Id == request.Id);

                return data;
            }
        }
    }
}
