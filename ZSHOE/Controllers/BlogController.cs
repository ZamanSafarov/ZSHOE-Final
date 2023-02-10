using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ZSHOE.Domain.AppCode.Extensions;
using ZSHOE.Domain.Business.BlogPostModule;
using ZSHOE.Domain.Models.DataContexts;

namespace ZSHOE.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly ZSHOEDbContext db;
        private readonly IMediator mediator;

        public BlogController(ZSHOEDbContext db, IMediator mediator)
        {
            this.db = db;
            this.mediator = mediator;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index(BlogPostGetAllQuery query)
        {
            var response = await mediator.Send(query);

            if (Request.IsAjaxRequest())
            {
                return PartialView("_PostBody", response);
            }
            return View(response);
        }


        [AllowAnonymous]
        [Route("/blog/{slug}")]
        public async Task<IActionResult> Details(BlogPostSingleQuery query)
        {
            var entity = await mediator.Send(query);

            if (entity == null)
            {
                return NotFound();
            }

            return View(entity);
        }

        [HttpPost]
        [Route("/post-comment")]
        public async Task<IActionResult> PostComment(BlogPostCommentCommand command)
        {

            try
            {

                var response = await mediator.Send(command);

                return PartialView("_Comments", response);

            }
            catch (System.Exception ex)
            {

                return Json(new
                {
                    error = true,
                    message = ex.Message
                });

            }

        }
    }
}