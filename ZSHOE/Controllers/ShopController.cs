using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using System.Threading.Tasks;
using ZSHOE.Domain.AppCode.Extensions;
using ZSHOE.Domain.Business.BasketModule;
using ZSHOE.Domain.Business.ProductModule;
using ZSHOE.Domain.Models.DataContexts;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using ZSHOE.Domain.Models.Entities.ViewModels;
using ZSHOE.Domain.Models.Entities;

namespace ZSHOE.WebUI.Controllers
{


    public class ShopController : Controller
    {
        private readonly ZSHOEDbContext db;
        private readonly IMediator mediator;

        public ShopController(ZSHOEDbContext db, IMediator mediator)
        {
            this.db = db;
            this.mediator = mediator;
        }


        [AllowAnonymous]
        public async Task<IActionResult> Index(ProductFilterQuery query)
        {
            var response = await mediator.Send(query);

            if (Request.IsAjaxRequest())
            {
                //return Json(response);
                return PartialView("_Products", response);
            }

            return View(response);
        }



        


        [AllowAnonymous]
        public async Task<IActionResult> Details(ProductSingleQuery query)
        {

            var product = await mediator.Send(query);

            var productCatalog = await db.ProductCatalogItems.FirstOrDefaultAsync(bpl => bpl.ProductId == product.Id);


            var vm = new ProductDetailsViewModel()
            {
                Product = product,
                ProductCatalog = productCatalog,


            };

            if (product == null)
            {
                return NotFound();
            }

            return View(vm);
        }


        [AllowAnonymous]
        [Route("/wishlist")]
        public async Task<IActionResult> Wishlist(WishlistQuery query)
        {
            var favs = await mediator.Send(query);

            if (Request.IsAjaxRequest())
            {
                return PartialView("_WishlistBody", favs);
            }

            return View(favs);
        }



        #region BasketRegion



        [Route("/basket")]
        public async Task<IActionResult> Basket(ProductBasketQuery query)
        {
            var response = await mediator.Send(query);

            return View(response);
        }




        [HttpPost]
        [Route("/basket")]
        public async Task<IActionResult> Basket(AddToBasketCommand command)
        {
            var response = await mediator.Send(command);

            return Json(response);
        }



        [HttpPost]
        public async Task<IActionResult> RemoveFromBasket(RemoveFromBasketCommand command)
        {
            var response = await mediator.Send(command);

            return Json(response);
        }



        [HttpPost]
        public async Task<IActionResult> ChangeBasketQuantity(ChangeBasketQuantityCommand command)
        {
            var response = await mediator.Send(command);

            return Json(response);
        }

        #endregion


        [Route("/checkout")]
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SetProductRate(SetRateCommand command)
        {
            var response = await mediator.Send(command);

            return Json(response);
        }

        //[AllowAnonymous]
        //public async Task<IActionResult> SearchProducts(string searchTerm)
        //{
        //    var products = await mediator.Send(new SearchProductQuery { SearchTerm = searchTerm });

        //    if (Request.IsAjaxRequest())
        //    {
        //        return PartialView("_SearchResults", products);
        //    }


        //    var brands = await db.Brands.Where(b => b.DeletedDate == null).ToListAsync();

        //    var categories = await db.Categories
        //        .Include(c => c.Children)
        //        .ThenInclude(c => c.Children)
        //        .ThenInclude(c => c.Children)
        //        .ThenInclude(c => c.Children)
        //        .Where(c => c.DeletedDate == null && c.ParentId == null).ToListAsync();

        //    var maxPrice = Math.Ceiling(db.Products.Where(p => p.DeletedDate == null).Select(p => p.Price).Max());

        //    var vm = new ProductViewModel()
        //    {
        //        Brands = brands,
        //        Categories = categories,
        //        Products = products.ToList(),
        //        MaxPrice = maxPrice
        //    };

        //    return View("Index", vm);
        //}


    }
}