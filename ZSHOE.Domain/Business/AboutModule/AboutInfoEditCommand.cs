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
using Microsoft.EntityFrameworkCore;

namespace ZSHOE.Domain.Business.BlogPostModule
{
    public class AboutInfoEditCommand : IRequest<JsonResponse>
    {
        public int Id { get; set; } 
        public string OurVision { get; set; }
        public string OurMission { get; set; }
        public IFormFile Image { get; set; }
        public string ImagePath { get; set; }

        public class AboutEditCommandHandler : IRequestHandler<AboutInfoEditCommand, JsonResponse>
        {
            private readonly ZSHOEDbContext db;
            private readonly IHostEnvironment env;

            public AboutEditCommandHandler(ZSHOEDbContext db, IHostEnvironment env)
            {
                this.db = db;
                this.env = env;
            }
            public async Task<JsonResponse> Handle(AboutInfoEditCommand request, CancellationToken cancellationToken)
            {
                var entity = await db.AboutInfos
                       .FirstOrDefaultAsync(bp => bp.Id == request.Id && bp.DeletedDate == null);

                if (entity == null)
                {
                    return null;
                }

                entity.OurVision = request.OurVision;
                entity.OurMission = request.OurMission;

                if (request.Image == null)
                    goto end;


                string extexsion = Path.GetExtension(request.Image.FileName); //.jpg, png 

                request.ImagePath = $"aboutInfo-{Guid.NewGuid().ToString().ToLower()}{extexsion}";

                string fullPath = env.GetImagePhysicalPath(request.ImagePath);


                using (var fs = new FileStream(fullPath, FileMode.Create, FileAccess.Write))
                {
                    request.Image.CopyTo(fs);
                }

                string oldPath = env.GetImagePhysicalPath(entity.ImagePath);



                //env.ArchiveImage(entity.ImagePath);

                entity.ImagePath = request.ImagePath;

            end:
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
