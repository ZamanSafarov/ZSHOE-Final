using ZSHOE.Domain.Business.BlogPostModule;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ZSHOE.Domain.Business.CategoryModule;

namespace ZSHOE.Domain.AppCode.ViewComponents
{
    public class OurCategoriesViewComponent : ViewComponent
    {
        private readonly IMediator mediator;

        public OurCategoriesViewComponent(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var query = new OurCategoriesQuery() { Size = 3};

            var posts = await mediator.Send(query);

            return View(posts);
        }
    }
}
