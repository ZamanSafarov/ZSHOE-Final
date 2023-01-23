using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ZSHOE.Domain.AppCode.Services;
using ZSHOE.Domain.Models.DataContexts;
using ZSHOE.Domain.Models.Entities;

namespace ZSHOE.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactPostsController : Controller
    {
        private readonly ZSHOEDbContext db;
        private readonly EmailService emailService;

        public ContactPostsController(ZSHOEDbContext db, EmailService emailService)
        {
            this.db = db;
            this.emailService = emailService;
        }

        [Authorize(Policy = "admin.contactposts.index")]
        public async Task<IActionResult> Index()
        {
            return View(await db.ContactPosts.ToListAsync());
        }

        [Authorize(Policy = "admin.contactposts.details")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactPost = await db.ContactPosts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactPost == null)
            {
                return NotFound();
            }

            return View(contactPost);
        }
        [Authorize(Policy = "admin.contactposts.reply")]
        public async Task<IActionResult> Reply(int? id)
        {
            if (id == null)
            {
                NotFound();
            }

            var contactPost = await db.ContactPosts.FirstOrDefaultAsync(m => m.Id == id);
            if (contactPost == null)
            {
                return NotFound();
            }

            return View(contactPost);
        }
        [Authorize(Policy = "admin.contactposts.reply")]
        [HttpPost]
        public async Task<IActionResult> Reply(int id, [FromForm][Bind("Name, Email, Phone, Content, Subject, Answer, EmailAnswer")] ContactPost model)
        {
            var entity = db.ContactPosts.FirstOrDefault(bp => bp.Id == id && bp.AnswerDate == null);

            if (!ModelState.IsValid)
            {
                return Json(new
                {
                    error = true,
                    message = "Xeta"
                });
            }

            //entity.AnswerDate = DateTime.UtcNow.AddHours(4);
            entity.Answer = model.Answer;
            entity.EmailAnswer = model.EmailAnswer;
            await db.SaveChangesAsync();

            await emailService.SendMailAsync(model.Email, model.EmailAnswer, model.Answer);

            return Json(new
            {
                error = false,
                message = "Your answer has been sended"
            });
        }

        [Authorize(Policy = "admin.contactposts.delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactPost = await db.ContactPosts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactPost == null)
            {
                return NotFound();
            }

            return View(contactPost);
        }

        [Authorize(Policy = "admin.contactposts.delete")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contactPost = await db.ContactPosts.FindAsync(id);
            db.ContactPosts.Remove(contactPost);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactPostExists(int id)
        {
            return db.ContactPosts.Any(e => e.Id == id);
        }
    }
}
