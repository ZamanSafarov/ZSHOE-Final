using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ZSHOE.Domain.Business.SubscribeModule;
using ZSHOE.Domain.Models.DataContexts;
using ZSHOE.Domain.Models.Entities;

namespace ZSHOE.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubscribesController : Controller
    {
        private readonly ZSHOEDbContext db;
        private readonly IMediator mediator;

        public SubscribesController(ZSHOEDbContext db, IMediator mediator)
        {
            this.db = db;
            this.mediator = mediator;
        }

        [Authorize(Policy = "admin.subscribes.index")]
        public async Task<IActionResult> Index(SubscribeGetAllQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }


        [Authorize(Policy = "admin.subscribes.delete")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(SubscribeRemoveCommand command)
        {
            var response = await mediator.Send(command);

            if (response == null)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));
        }

        private bool SubscribeExists(int id)
        {
            return db.Subscribes.Any(e => e.Id == id);
        }
    }
}