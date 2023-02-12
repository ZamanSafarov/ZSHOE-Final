﻿using MediatR;
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
    public class BlogPostSingleQuery : IRequest<BlogPost>
    {
        public int Id { get; set; }

        public string Slug { get; set; }

        public class BlogPostSingleQueryHandler : IRequestHandler<BlogPostSingleQuery, BlogPost>
        {
            private readonly ZSHOEDbContext db;

            public BlogPostSingleQueryHandler(ZSHOEDbContext db)
            {
                this.db = db;
            }

            public async Task<BlogPost> Handle(BlogPostSingleQuery request, CancellationToken cancellationToken)
            {
                var query = db.BlogPosts
                    .Include(bp => bp.Likes)
                     .Include(bp => bp.Comments.Where(bpc => bpc.DeletedDate == null))
                     .ThenInclude(c=>c.CreatedByUser)

                     .Include(bp => bp.Category)
                     .Include(bp => bp.TagCloud)
                     .ThenInclude(bp => bp.Tag)

                     .Include(bp => bp.Comments.Where(bpc => bpc.DeletedDate == null))
                     .ThenInclude(c => c.Children.Where(bpc => bpc.DeletedDate == null))
                     .AsQueryable();

                if (string.IsNullOrWhiteSpace(request.Slug))
                {
                    return await query.FirstOrDefaultAsync(m => m.Id == request.Id && m.DeletedDate == null);
                }

                return await query.FirstOrDefaultAsync(m => m.Slug.Equals(request.Slug) && m.DeletedDate == null);
            }
        }

    }
}
