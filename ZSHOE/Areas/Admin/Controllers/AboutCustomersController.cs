using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
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

        // GET: Admin/AboutCustomers
        public async Task<IActionResult> Index()
        {
            return View(await db.AboutCustomers.ToListAsync());
        }

        // GET: Admin/AboutCustomers/Details/5
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

        // GET: Admin/AboutCustomers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/AboutCustomers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
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

        // GET: Admin/AboutCustomers/Edit/5
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

        // POST: Admin/AboutCustomers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
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

        // GET: Admin/AboutCustomers/Delete/5
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

        // POST: Admin/AboutCustomers/Delete/5
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
