using ZSHOE.Domain.Business.BlogPostModule;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ZSHOE.Domain.AppCode.ViewComponents
{
    public class PopularPostsViewComponent : ViewComponent
    {
        private readonly IMediator mediator;

        public PopularPostsViewComponent(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var query = new BlogPostPopularQuery() { Size = 4 };

            var posts = await mediator.Send(query);

            return View(posts);
        }
    }
}
