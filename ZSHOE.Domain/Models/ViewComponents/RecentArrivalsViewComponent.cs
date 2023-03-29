
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ZSHOE.Domain.Business.ProductModule;

namespace ZSHOE.Domain.AppCode.ViewComponents
{
    public class RecentArrivalsViewComponent : ViewComponent
    {
        private readonly IMediator mediator;

        public RecentArrivalsViewComponent(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var query = new ProductRecentArrivalsQuery() { Size = 5};

            var posts = await mediator.Send(query);

            return View(posts);
        }
    }
}
