using MediatR;
using ZSHOE.Domain.Models.DataContexts;
using ZSHOE.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZSHOE.Domain.Models.Entities;

namespace ZSHOE.Domain.Business.BrandModule
{

    public class BrandRemoveCommand : IRequest<Brand>
    {
        public int Id { get; set; }

        public class BrandRemoveCommandHandler : IRequestHandler<BrandRemoveCommand, Brand>
        {
            private readonly ZSHOEDbContext db;

            public BrandRemoveCommandHandler(ZSHOEDbContext db)
            {
                this.db = db;
            }

            public async Task<Brand> Handle(BrandRemoveCommand request, CancellationToken cancellationToken)
            {
                var data = db.Brands.FirstOrDefault(m => m.Id == request.Id && m.DeletedDate == null);

                if (data == null)
                {
                    return null;
                }

                data.DeletedDate = DateTime.UtcNow.AddHours(4);

                await db.SaveChangesAsync(cancellationToken);
                return data;
            }
        }
    }
}
