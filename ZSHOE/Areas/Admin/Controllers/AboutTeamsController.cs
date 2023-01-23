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
    public class AboutTeamsController : Controller
    {
        private readonly ZSHOEDbContext db;
        private readonly IMediator mediator;

        public AboutTeamsController(ZSHOEDbContext db, IMediator mediator)
        {
            this.db = db;
            this.mediator = mediator;
        }

        [Authorize(Policy = "admin.aboutteams.index")]
        public async Task<IActionResult> Index()
        {
            return View(await db.AboutTeam.ToListAsync());
        }

        [Authorize(Policy = "admin.aboutteams.details")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutTeam = await db.AboutTeam
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aboutTeam == null)
            {
                return NotFound();
            }

            return View(aboutTeam);
        }

        [Authorize(Policy = "admin.aboutteams.create")]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Policy = "admin.aboutteams.create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AboutTeamPostCommand command)
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

        [Authorize(Policy = "admin.aboutteams.edit")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutTeam = await db.AboutTeam.FindAsync(id);
            if (aboutTeam == null)
            {
                return NotFound();
            }
            return View(aboutTeam);
        }

        [Authorize(Policy = "admin.aboutteams.edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Position,Description,FacebookLink,InstagramLink,TwitterLink,Id,CreatedDate,DeletedDate")] AboutTeam aboutTeam)
        {
            if (id != aboutTeam.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(aboutTeam);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AboutTeamExists(aboutTeam.Id))
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
            return View(aboutTeam);
        }

        [Authorize(Policy = "admin.aboutteams.delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutTeam = await db.AboutTeam
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aboutTeam == null)
            {
                return NotFound();
            }

            return View(aboutTeam);
        }

        [Authorize(Policy = "admin.aboutteams.delete")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aboutTeam = await db.AboutTeam.FindAsync(id);
            db.AboutTeam.Remove(aboutTeam);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AboutTeamExists(int id)
        {
            return db.AboutTeam.Any(e => e.Id == id);
        }
    }
}
