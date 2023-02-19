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

namespace ZSHOE.Domain.Business.BasketModule
{
    public class ChangeBasketQuantityCommand : IRequest<JsonResponse>
    {
        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public class ChangeBasketQuantityCommandHandler : IRequestHandler<ChangeBasketQuantityCommand, JsonResponse>
        {
            private readonly ZSHOEDbContext db;
            private readonly IActionContextAccessor ctx;

            public ChangeBasketQuantityCommandHandler(ZSHOEDbContext db, IActionContextAccessor ctx)
            {
                this.db = db;
                this.ctx = ctx;
            }

            public async Task<JsonResponse> Handle(ChangeBasketQuantityCommand request, CancellationToken cancellationToken)
            {
                var userId = ctx.GetCurrentUserId();

                var basketItem = await db.Basket.FirstOrDefaultAsync(b => b.ProductId == request.ProductId && b.UserId == userId, cancellationToken);

                if (basketItem == null)
                {
                    basketItem = new Basket
                    {
                        UserId = userId,
                        ProductId = request.ProductId,
                        Quantity = request.Quantity < 1 ? 1 : request.Quantity
                    };

                    await db.Basket.AddAsync(basketItem, cancellationToken);
                    await db.SaveChangesAsync();

                    var response = new JsonResponse
                    {
                        Error = false,
                        Message = "Product was added to the basket"
                    };

                    var product = await db.Products.FirstOrDefaultAsync(b => b.Id == request.ProductId
                                            && b.DeletedDate == null, cancellationToken);


                    response.Value = new
                    {
                        Name = product.Name,
                        Price = product.Price,
                        Summary = await db.Basket.Where(b => b.UserId == userId).Include(b => b.Product).SumAsync(b => b.Quantity * b.Product.Price, cancellationToken),
                        Total = (basketItem.Quantity * product.Price).ToString("0.00"),
                        //Quantity = (await db.Basket.FirstOrDefaultAsync(b => b.UserId == userId && b.ProductId == product.Id)).Quantity
                    };

                    return response;
                }

                basketItem.Quantity = request.Quantity;

                await db.SaveChangesAsync(cancellationToken);

                var response2 = new JsonResponse
                {
                    Error = false,
                    Message = "Quantity of the product was changed"
                };

                var product2 = await db.Products.FirstOrDefaultAsync(b => b.Id == request.ProductId
                                       && b.DeletedDate == null, cancellationToken);


                response2.Value = new
                {
                    Name = product2.Name,
                    Id = product2.Id,
                    Price = product2.Price,
                    Total = (basketItem.Quantity * product2.Price).ToString("0.00"),
                    Summary = await db.Basket.Where(b => b.UserId == userId).Include(b => b.Product).SumAsync(b => b.Quantity * b.Product.Price, cancellationToken),
                    //Quantity = (db.Basket.FirstOrDefault(b => b.UserId == userId && b.ProductId == product2.Id)).Quantity
                };

                return response2;
            }


        }
    }
}