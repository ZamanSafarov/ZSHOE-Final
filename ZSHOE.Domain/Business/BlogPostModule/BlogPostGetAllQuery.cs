using ZSHOE.Domain.AppCode.Infrastructure;
using ZSHOE.Domain.Models.DataContexts;
using ZSHOE.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ZSHOE.Domain.Business.BlogPostModule
{
    public class BlogPostGetAllQuery : PaginateModel, IRequest<PagedViewModel<BlogPost>>
    {

        public class BlogPostGetAllQueryHandler : IRequestHandler<BlogPostGetAllQuery, PagedViewModel<BlogPost>>
        {
            private readonly ZSHOEDbContext db;

            public BlogPostGetAllQueryHandler(ZSHOEDbContext db)
            {
                this.db = db;
            }
            public async Task<PagedViewModel<BlogPost>> Handle(BlogPostGetAllQuery request, CancellationToken cancellationToken)
            {
                //var posts = await db.BlogPosts
                //.Where(bp => bp.DeletedDate == null && bp.PublishedDate != null)
                //.ToListAsync(cancellationToken);

                int skipSize = (request.PageIndex - 1) * request.PageSize;

                var query = db.BlogPosts
                .Where(bp => bp.DeletedDate == null && bp.PublishedDate != null)
                .Include(bp => bp.TagCloud)
                .ThenInclude(bpc=>bpc.Tag)
                .Distinct()
                .OrderByDescending(bp => bp.PublishedDate)
                .AsQueryable();

                var pagedModel = new PagedViewModel<BlogPost>(query, request);

                return pagedModel;
            }
        }
    }
}
