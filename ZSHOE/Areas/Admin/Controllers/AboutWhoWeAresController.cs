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
    public class AboutWhoWeAresController : Controller
    {
        private readonly ZSHOEDbContext db;
        private readonly IMediator mediator;

        public AboutWhoWeAresController(ZSHOEDbContext db, IMediator mediator)
        {
            this.db = db;
            this.mediator = mediator;
        }

        [Authorize(Policy = "admin.aboutwhoweares.index")]
        public async Task<IActionResult> Index()
        {
            return View(await db.AboutWhoWeAre.ToListAsync());
        }

        [Authorize(Policy = "admin.aboutwhoweares.details")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutWhoWeAre = await db.AboutWhoWeAre
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aboutWhoWeAre == null)
            {
                return NotFound();
            }

            return View(aboutWhoWeAre);
        }

        [Authorize(Policy = "admin.aboutwhoweares.create")]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Policy = "admin.aboutwhoweares.create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AboutWhoPostCommand command)
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

        [Authorize(Policy = "admin.aboutwhoweares.edit")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutWhoWeAre = await db.AboutWhoWeAre.FindAsync(id);
            if (aboutWhoWeAre == null)
            {
                return NotFound();
            }
            return View(aboutWhoWeAre);
        }

        [Authorize(Policy = "admin.aboutwhoweares.edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Description,Body,ImagePath,Id,CreatedDate,DeletedDate")] AboutWhoWeAre aboutWhoWeAre)
        {
            if (id != aboutWhoWeAre.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(aboutWhoWeAre);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AboutWhoWeAreExists(aboutWhoWeAre.Id))
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
            return View(aboutWhoWeAre);
        }

        [Authorize(Policy = "admin.aboutwhoweares.delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutWhoWeAre = await db.AboutWhoWeAre
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aboutWhoWeAre == null)
            {
                return NotFound();
            }

            return View(aboutWhoWeAre);
        }

        [Authorize(Policy = "admin.aboutwhoweares.delete")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aboutWhoWeAre = await db.AboutWhoWeAre.FindAsync(id);
            db.AboutWhoWeAre.Remove(aboutWhoWeAre);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AboutWhoWeAreExists(int id)
        {
            return db.AboutWhoWeAre.Any(e => e.Id == id);
        }
    }
}
