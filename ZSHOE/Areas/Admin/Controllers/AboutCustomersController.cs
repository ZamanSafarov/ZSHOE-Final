using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ZSHOE.Domain.Business.BlogPostModule;
using ZSHOE.Domain.Models.DataContexts;
using ZSHOE.Domain.Models.Entities;

namespace ZSHOE.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutCustomersController : Controller
    {
        private readonly ZSHOEDbContext db;
        private readonly IMediator mediator;

        public AboutCustomersController(ZSHOEDbContext db, IMediator mediator)
        {
            this.db = db;
            this.mediator = mediator;
        }

        [Authorize(Policy = "admin.aboutcustomers.index")]
        public async Task<IActionResult> Index()
        {
            return View(await db.AboutCustomers.ToListAsync());
        }

        [Authorize(Policy = "admin.aboutcustomers.details")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutCustomer = await db.AboutCustomers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aboutCustomer == null)
            {
                return NotFound();
            }

            return View(aboutCustomer);
        }

        [Authorize(Policy = "admin.aboutcustomers.create")]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Policy = "admin.aboutcustomers.create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AboutCustomerPostCommand command)
        {
            if (command.Image == null)
            {
                ModelState.AddModelError("ImagePath", "Shekil Gonderilmelidir");
            }

            if (ModelState.IsValid)
            {
                var response = await mediator.Send(command);
                if (response.Error == false)
                {
                    return RedirectToAction(nameof(Index));
                }
            }

            return View(command);
        }

        [Authorize(Policy = "admin.aboutcustomers.edit")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutCustomer = await db.AboutCustomers.FindAsync(id);
            if (aboutCustomer == null)
            {
                return NotFound();
            }
            return View(aboutCustomer);
        }

        [Authorize(Policy = "admin.aboutcustomers.edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ImagePath,Description,Name,Position,Id,CreatedDate,DeletedDate")] AboutCustomer aboutCustomer)
        {
            if (id != aboutCustomer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(aboutCustomer);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AboutCustomerExists(aboutCustomer.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(aboutCustomer);
        }

        [Authorize(Policy = "admin.aboutcustomers.delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutCustomer = await db.AboutCustomers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aboutCustomer == null)
            {
                return NotFound();
            }

            return View(aboutCustomer);
        }

        [Authorize(Policy = "admin.aboutcustomers.delete")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aboutCustomer = await db.AboutCustomers.FindAsync(id);
            db.AboutCustomers.Remove(aboutCustomer);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AboutCustomerExists(int id)
        {
            return db.AboutCustomers.Any(e => e.Id == id);
        }
    }
}
