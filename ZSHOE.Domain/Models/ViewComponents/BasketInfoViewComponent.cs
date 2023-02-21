using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZSHOE.Domain.Business.ProductModule;

namespace ZSHOE.Domain.Models.ViewComponents
{
    public class BasketInfoViewComponent: ViewComponent
    {
        private readonly IMediator mediator;

        public BasketInfoViewComponent(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var query = new ProductBasketQuery();
           var response= await mediator.Send(query);
            return View(response);
        }
    }
}
