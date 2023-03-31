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

namespace ZSHOE.Domain.Business.TagModule
{
    public class TagGetSingleQuery : IRequest<Tag>
    {
        public int Id { get; set; }

        public class TagGetSingleQueryHandler : IRequestHandler<TagGetSingleQuery, Tag>
        {
            private readonly ZSHOEDbContext db;

            public TagGetSingleQueryHandler(ZSHOEDbContext db)
            {
                this.db = db;
            }

            public async Task<Tag> Handle(TagGetSingleQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Tags
                    .FirstOrDefaultAsync(p => p.Id == request.Id);

                return data;
            }
        }

    }
}
