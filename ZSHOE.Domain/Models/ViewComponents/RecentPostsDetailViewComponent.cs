using ZSHOE.Domain.Business.BlogPostModule;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ZSHOE.Domain.AppCode.ViewComponents
{
    public class RecentPostsDetailViewComponent : ViewComponent
    {
        private readonly IMediator mediator;

        public RecentPostsDetailViewComponent(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var query = new BlogPostRecentQuery() { Size = 5};

            var posts = await mediator.Send(query);

            return View(posts);
        }
    }
}
