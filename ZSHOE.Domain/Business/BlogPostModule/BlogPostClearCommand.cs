﻿using MediatR;
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
    public class BlogPostClearCommand : IRequest<BlogPost>
    {
        public int Id { get; set; }
        public class BlogPostClearCommandHandler : IRequestHandler<BlogPostClearCommand, BlogPost>
        {
            private readonly ZSHOEDbContext db;

            public BlogPostClearCommandHandler(ZSHOEDbContext db)
            {
                this.db = db;
            }

            public async Task<BlogPost> Handle(BlogPostClearCommand request, CancellationToken cancellationToken)
            {
                var data = db.BlogPosts.FirstOrDefault(m => m.Id == request.Id && m.DeletedDate != null);

                if (data == null)
                {
                    return null;
                }

                db.BlogPosts.Remove(data);
                await db.SaveChangesAsync(cancellationToken);
                return data;
            }
        }
    }
}

