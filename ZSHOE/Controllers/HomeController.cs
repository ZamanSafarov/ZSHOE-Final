using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using ZSHOE.Domain.AppCode.Extensions;
using ZSHOE.Domain.Models.DataContexts;
using ZSHOE.Domain.Models.Entities;
using ZSHOE.Domain.Models.Entities.ViewModels;

namespace ZSHOE.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ZSHOEDbContext db;
        private readonly IMediator mediator;

        public HomeController(ZSHOEDbContext db, IMediator mediator)
        {
            this.db = db;
            this.mediator = mediator;
        }
        [AllowAnonymous]

        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]

        public IActionResult Contact()
        {
            var contactInfo = db.ContactInfos.FirstOrDefault();

            return View(new ContactPostInfoViewModel
            {
                ContactInfos = contactInfo
            });
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Contact(ContactPostInfoViewModel vm)
        {
            if (ModelState.IsValid)
            {
                db.ContactPosts.Add(vm.ContactPosts);

                await db.SaveChangesAsync();

                var response = new
                {
                    error = false,
                    message = "Your request has been accepted, we'll reply soon"
                };

                return Json(response);
            }

            var responseError = new
            {
                error = true,
                message = "Information is not correct, please try again",
                state = ModelState.GetError()
            };
            return Json(responseError);
        }
        [AllowAnonymous]
        public IActionResult Faq()
        {
            var data = db.Faqs.Where(f => f.DeletedDate == null).ToList();
            return View(data);

        }

        [AllowAnonymous]
        public IActionResult MyAccount()
        {
            return View();
        }
        public async Task<IActionResult> About()
        {
            var aboutBrand = await db.AboutBrands.FirstOrDefaultAsync(ab => ab.DeletedDate == null);
            var aboutInfo = await db.AboutInfos.FirstOrDefaultAsync(ai => ai.DeletedDate == null);
            var aboutTeam = db.AboutTeam.Where(at => at.DeletedDate == null).ToList();
            var aboutCustomer = db.AboutCustomers.Where(ac => ac.DeletedDate == null).ToList();
            var aboutWhoWeAre = await db.AboutWhoWeAre.FirstOrDefaultAsync(aw => aw.DeletedDate == null);
            var vm = new AboutViewModel
            {
                AboutInfos = aboutInfo,
                AboutWhoWeAre = aboutWhoWeAre,
                AboutBrands = aboutBrand,
                AboutCustomers = aboutCustomer,
                AboutTeam = aboutTeam
            };
            return View(vm);
        }

    }
}
