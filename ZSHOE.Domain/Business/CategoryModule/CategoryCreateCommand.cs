using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using ZSHOE.Domain.AppCode.Extensions;
using ZSHOE.Domain.AppCode.Infrastructure;
using ZSHOE.Domain.Models.DataContexts;
using ZSHOE.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZSHOE.Domain.Business.CategoryModule
{
    public class CategoryCreateCommand : IRequest<Category>
    {
        [Required]
        public string Name { get; set; }

        public int? ParentId { get; set; }


        public class CategoryCreateCommandHandler : IRequestHandler<CategoryCreateCommand, Category>
        {
            private readonly ZSHOEDbContext db;

            public CategoryCreateCommandHandler(ZSHOEDbContext db)
            {
                this.db = db;
            }

            public async Task<Category> Handle(CategoryCreateCommand request, CancellationToken cancellationToken)
            {
                var entity = new Category();


                entity.Name = request.Name;
                entity.ParentId = request.ParentId;
                

                await db.Categories.AddAsync(entity, cancellationToken);
                await db.SaveChangesAsync(cancellationToken);

                return entity;
            }


        }
    }

}
