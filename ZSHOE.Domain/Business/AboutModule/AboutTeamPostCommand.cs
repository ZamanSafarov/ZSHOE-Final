using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using ZSHOE.Domain.AppCode.Extensions;
using ZSHOE.Domain.AppCode.Infrastructure;
using ZSHOE.Domain.Models.DataContexts;
using ZSHOE.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace ZSHOE.Domain.Business.BlogPostModule
{
    public class AboutTeamPostCommand : IRequest<JsonResponse>
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public string FacebookLink { get; set; }
        public string InstagramLink { get; set; }
        public string TwitterLink { get; set; }
        public IFormFile Image { get; set; }
        public string ImagePath { get; set; }

        public class AboutPostCommandHandler : IRequestHandler<AboutTeamPostCommand, JsonResponse>
        {
            private readonly ZSHOEDbContext db;
            private readonly IHostEnvironment env;

            public AboutPostCommandHandler(ZSHOEDbContext db, IHostEnvironment env)
            {
                this.db = db;
                this.env = env;
            }
            public async Task<JsonResponse> Handle(AboutTeamPostCommand request, CancellationToken cancellationToken)
            {
                var entity = new AboutTeam();
                
                entity.Name = request.Name;
                entity.Position = request.Position;
                entity.Description = request.Description;
                entity.FacebookLink = request.FacebookLink;
                entity.InstagramLink = request.InstagramLink;
                entity.TwitterLink = request.TwitterLink;


                if (request.Image == null)
                    goto end;

                string extension = Path.GetExtension(request.Image.FileName);//.jpg

                request.ImagePath = $"aboutTeam-{Guid.NewGuid().ToString().ToLower()}{extension}";
                string fullPath = env.GetImagePhysicalPath(request.ImagePath);

                using (var fs = new FileStream(fullPath, FileMode.Create, FileAccess.Write))
                {
                    request.Image.CopyTo(fs);
                }

                entity.ImagePath = request.ImagePath;

            end:
                entity.Slug = request.Description.ToSlug();

                await db.AboutTeam.AddAsync(entity, cancellationToken);
                await db.SaveChangesAsync(cancellationToken);

                return new JsonResponse
                {
                    Error = false,
                    Message = "Success"
                };
            }
        }
    }
}
