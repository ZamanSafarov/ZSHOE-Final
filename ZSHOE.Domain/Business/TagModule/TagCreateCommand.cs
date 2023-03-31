using MediatR;
using ZSHOE.Domain.Models.DataContexts;
using ZSHOE.Domain.Models.Entities;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;

namespace ZSHOE.Domain.Business.TagModule
{
    public class TagCreateCommand : IRequest<Tag>
    {
        [Required]
        public string Text { get; set; }


        public class TagCreateCommandHandler : IRequestHandler<TagCreateCommand, Tag>
        {
            private readonly ZSHOEDbContext db;

            public TagCreateCommandHandler(ZSHOEDbContext db)
            {
                this.db = db;
            }

            public async Task<Tag> Handle(TagCreateCommand request, CancellationToken cancellationToken)
            {
                var entity = new Tag();

                entity.Text = request.Text;

                await db.Tags.AddAsync(entity, cancellationToken);
                await db.SaveChangesAsync(cancellationToken);

                return entity;
            }


        }
    }

}
