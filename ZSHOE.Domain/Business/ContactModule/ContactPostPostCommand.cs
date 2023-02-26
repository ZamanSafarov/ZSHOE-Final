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
    public class ContactPostPostCommand : IRequest<JsonResponse>
    {
        public string Location { get; set; }

        public string PhoneNumber { get; set; }

        public string CompanyEmail { get; set; }
        public IFormFile Image { get; set; }
        public string ImagePath { get; set; }

        public class ContactPostPostCommandHandler : IRequestHandler<ContactPostPostCommand, JsonResponse>
        {
            private readonly ZSHOEDbContext db;
            private readonly IHostEnvironment env;

            public ContactPostPostCommandHandler(ZSHOEDbContext db, IHostEnvironment env)
            {
                this.db = db;
                this.env = env;
            }
            public async Task<JsonResponse> Handle(ContactPostPostCommand request, CancellationToken cancellationToken)
            {
                var entity = new ContactInfo();

                entity.Location = request.Location;
                entity.PhoneNumber = request.PhoneNumber;
                entity.CompanyEmail = request.CompanyEmail;

                if (request.Image == null)
                    goto end;

                string extension = Path.GetExtension(request.Image.FileName);//.jpg

                request.ImagePath = $"ContactInfo-{Guid.NewGuid().ToString().ToLower()}{extension}";
                string fullPath = env.GetImagePhysicalPath(request.ImagePath);

                using (var fs = new FileStream(fullPath, FileMode.Create, FileAccess.Write))
                {
                    request.Image.CopyTo(fs);
                }

                entity.ImagePath = request.ImagePath;

            end:
                entity.Slug = request.ImagePath.ToSlug();

                await db.ContactInfos.AddAsync(entity, cancellationToken);
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
