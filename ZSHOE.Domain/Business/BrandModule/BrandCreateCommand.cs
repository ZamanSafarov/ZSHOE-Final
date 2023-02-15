using MediatR;
using ZSHOE.Domain.Models.DataContexts;
using ZSHOE.Domain.Models.Entites;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;
using ZSHOE.Domain.Models.Entities;

namespace ZSHOE.Domain.Business.BrandModule
{
    public class BrandCreateCommand : IRequest<Brand>
    {
        [Required]
        public string Name { get; set; }


        public class BrandCreateCommandHandler : IRequestHandler<BrandCreateCommand, Brand>
        {
            private readonly ZSHOEDbContext db;

            public BrandCreateCommandHandler(ZSHOEDbContext db)
            {
                this.db = db;
            }

            public async Task<Brand> Handle(BrandCreateCommand request, CancellationToken cancellationToken)
            {
                var entity = new Brand();

                entity.Name = request.Name;

                await db.Brands.AddAsync(entity, cancellationToken);
                await db.SaveChangesAsync(cancellationToken);

                return entity;
            }


        }
    }

}
