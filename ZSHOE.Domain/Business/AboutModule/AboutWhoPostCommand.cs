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
using ZSHOE.Domain.Models.DataContexts;
using ZSHOE.Domain.AppCode.Infrastructure;
using ZSHOE.Domain.Models.Entities;
using ZSHOE.Domain.AppCode.Extensions;

namespace ZSHOE.Domain.Business.BlogPostModule
{
    public class AboutWhoPostCommand : IRequest<JsonResponse>
    {
        public string Description { get; set; }
        public string Body { get; set; }
        public IFormFile Image { get; set; }
        public string ImagePath { get; set; }

        public class AboutPostCommandHandler : IRequestHandler<AboutWhoPostCommand, JsonResponse>
        {
            private readonly ZSHOEDbContext db;
            private readonly IHostEnvironment env;

            public AboutPostCommandHandler(ZSHOEDbContext db, IHostEnvironment env)
            {
                this.db = db;
                this.env = env;
            }
            public async Task<JsonResponse> Handle(AboutWhoPostCommand request, CancellationToken cancellationToken)
            {
                var entity = new AboutWhoWeAre();

                entity.Description = request.Description;
                entity.Body = request.Body;


                if (request.Image == null)
                    goto end;

                string extension = Path.GetExtension(request.Image.FileName);//.jpg

                request.ImagePath = $"aboutWho-{Guid.NewGuid().ToString().ToLower()}{extension}";
                string fullPath = env.GetImagePhysicalPath(request.ImagePath);

                using (var fs = new FileStream(fullPath, FileMode.Create, FileAccess.Write))
                {
                    request.Image.CopyTo(fs);
                }

                entity.ImagePath = request.ImagePath;

            end:
                entity.Slug = request.Description.ToSlug();

                await db.AboutWhoWeAre.AddAsync(entity, cancellationToken);
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
