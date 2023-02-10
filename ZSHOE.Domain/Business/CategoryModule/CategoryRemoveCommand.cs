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

namespace ZSHOE.Domain.Business.CategoryModule
{

    public class CategoryRemoveCommand : IRequest<Category>
    {
        public int Id { get; set; }

        public class CategoryRemoveCommandHandler : IRequestHandler<CategoryRemoveCommand, Category>
        {
            private readonly ZSHOEDbContext db;

            public CategoryRemoveCommandHandler(ZSHOEDbContext db)
            {
                this.db = db;
            }

            public async Task<Category> Handle(CategoryRemoveCommand request, CancellationToken cancellationToken)
            {
                var data = db.Categories
                    .Include(c => c.Children.Where(ch => ch.DeletedDate == null))
                    .FirstOrDefault(m => m.Id == request.Id && m.DeletedDate == null);

                if (data == null)
                {
                    return null;
                }

                data.DeletedDate = DateTime.UtcNow.AddHours(4);

                var children = data.Children.Where(c => c.ParentId == data.Id);

                foreach (var item in children)
                {
                    item.DeletedDate = DateTime.UtcNow.AddHours(4);
                }

                await db.SaveChangesAsync(cancellationToken);
                return data;
            }
        }
    }
}
