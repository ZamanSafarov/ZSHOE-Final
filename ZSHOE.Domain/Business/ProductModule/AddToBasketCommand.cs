using ZSHOE.Domain.AppCode.Extensions;
using ZSHOE.Domain.AppCode.Infrastructure;
using ZSHOE.Domain.Models.DataContexts;
using ZSHOE.Domain.Models.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ZSHOE.Domain.Business.ProductModule
{
    public class AddToBasketCommand : IRequest<JsonResponse>
    {
        public int ProductId { get; set; }

        public class AddToBasketCommandHandler : IRequestHandler<AddToBasketCommand, JsonResponse>
        {
            private readonly ZSHOEDbContext db;
            private readonly IActionContextAccessor ctx;

            public AddToBasketCommandHandler(ZSHOEDbContext db, IActionContextAccessor ctx)
            {
                this.db = db;
                this.ctx = ctx;
            }


            public async Task<JsonResponse> Handle(AddToBasketCommand request, CancellationToken cancellationToken)
            {
                var userId = ctx.GetCurrentUserId();


                //if (userId == 0)
                //{
                //    return new JsonResponse
                //    {
                //        Error = true,
                //        Message = "You should login to your account first"
                //    };
                //}

                var alreadyExists = await db.Basket.AnyAsync(b => b.ProductId == request.ProductId && b.UserId == userId, cancellationToken);

                if (alreadyExists)
                {
                    return new JsonResponse
                    {
                        Error = true,
                        Message = "Product already exist in your basket"
                    };
                }


                var basketItem = new Basket
                {
                    UserId = userId,
                    ProductId = request.ProductId,
                    Quantity = 1
                };

                await db.Basket.AddAsync(basketItem, cancellationToken);
                await db.SaveChangesAsync(cancellationToken);

                #region Baskete elave olunandan sonra wishlistden silinme
                //var value = ctx.GetIntArrayFromCookie("favorites");
                //if (value != null)
                //{
                //    var newFavIds = value.Where(fi => fi != request.ProductId);
                //    var cookieValue = string.Join(",", newFavIds);
                //    var cookie = new KeyValuePair<string, string>("favorites", cookieValue);
                //    ctx.ActionContext.HttpContext.Request.Cookies.Append(cookie);
                //    ctx.SetValueToCookie("favorites", cookieValue);
                //}

                #endregion

                var info = await (from b in db.Basket
                                  join p in db.Products on b.ProductId equals p.Id
                                  where b.UserId == userId
                                  select new
                                  {
                                      b.UserId,
                                      SubTotal = p.Price * b.Quantity
                                  })
                                                 .GroupBy(g => g.UserId)
                                                 .Select(g => new
                                                 {
                                                     Total = g.Sum(m => m.SubTotal),
                                                     Count = g.Count()
                                                 })
                                                 .FirstOrDefaultAsync(cancellationToken);

                var addedProduct = await db.Basket
                    .Include(b => b.Product)
                    .ThenInclude(p => p.ProductImages.Where(i => i.IsMain == true))
                    .FirstOrDefaultAsync(b => b.UserId == userId && b.ProductId == request.ProductId);


                return new JsonResponse
                {
                    Error = false,
                    Message = "Product was added to the basket",
                    Value = new
                    {
                        Product = addedProduct,
                        BasketInfo = info
                    }
                };
            }
        }
    }
}