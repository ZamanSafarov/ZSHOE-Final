using ZSHOE.Domain.Business.BlogPostModule;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ZSHOE.Domain.Business.ProductModule;

namespace ZSHOE.Domain.AppCode.ViewComponents
{
    public class RatedProductsViewComponent : ViewComponent
    {
        private readonly IMediator mediator;

        public RatedProductsViewComponent(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var query = new RatedProductsQuery() { Size = 5}; 

            var posts = await mediator.Send(query);

            return View(posts);
        }
    }
}
