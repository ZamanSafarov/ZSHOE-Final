using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ZSHOE.Domain.Models.DataContexts;

namespace ZSHOE.WebUI.Controllers
{
    [AllowAnonymous]
    public class CouponController : Controller
    {
        private readonly ZSHOEDbContext _context;

        public CouponController(ZSHOEDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult ApplyCoupon(string couponCode)
        {
            var coupon = _context.Coupons.FirstOrDefault(c => c.Code == couponCode);
            if (coupon == null)
            {
                TempData["error"] = "Invalid coupon code.";
                return RedirectToAction("Checkout");
            }

            HttpContext.Session.SetString("CouponCode", couponCode);
            HttpContext.Session.SetInt32("DiscountAmount", (int)coupon.DiscountAmount);

            TempData["success"] = "Coupon applied successfully!";
            return RedirectToAction("Checkout");
        }
    }
}
