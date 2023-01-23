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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ZSHOE.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutInfoesController : Controller
    {

        private readonly ZSHOEDbContext db;
        private readonly IMediator mediator;

        public AboutInfoesController(ZSHOEDbContext db, IMediator mediator)
        {
            this.db = db;
            this.mediator = mediator;
        }

        [Authorize(Policy = "admin.aboutinfoes.index")]
        public async Task<IActionResult> Index()
        {
            return View(await db.AboutInfos.ToListAsync());
        }

        [Authorize(Policy = "admin.aboutinfoes.details")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutInfo = await db.AboutInfos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aboutInfo == null)
            {
                return NotFound();
            }

            return View(aboutInfo);
        }

        [Authorize(Policy = "admin.aboutinfoes.create")]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Policy = "admin.aboutinfoes.create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AboutInfoPostCommand command)
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

        [Authorize(Policy = "admin.aboutinfoes.edit")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutInfo = await db.AboutInfos.FindAsync(id);
            if (aboutInfo == null)
            {
                return NotFound();
            }
            return View(aboutInfo);
        }

        [Authorize(Policy = "admin.aboutinfoes.edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ImagePath,OurVision,OurMission,Id,CreatedDate,DeletedDate")] AboutInfo aboutInfo)
        {
            if (id != aboutInfo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(aboutInfo);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AboutInfoExists(aboutInfo.Id))
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
            return View(aboutInfo);
        }

        [Authorize(Policy = "admin.aboutinfoes.delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutInfo = await db.AboutInfos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aboutInfo == null)
            {
                return NotFound();
            }

            return View(aboutInfo);
        }

        [Authorize(Policy = "admin.aboutinfoes.delete")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aboutInfo = await db.AboutInfos.FindAsync(id);
            db.AboutInfos.Remove(aboutInfo);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AboutInfoExists(int id)
        {
            return db.AboutInfos.Any(e => e.Id == id);
        }
    }
}
