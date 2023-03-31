﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ZSHOE.Domain.AppCode.Extensions;
using ZSHOE.Domain.AppCode.Services;
using ZSHOE.Domain.Models.DataContexts;
using ZSHOE.Domain.Models.Entities;
using ZSHOE.Domain.Models.Entities.Membership;
using ZSHOE.Domain.Models.Entities.ViewModels;

namespace ZSHOE.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ZSHOEDbContext db;
        private readonly CryptoService cryptoService;
        private readonly EmailService emailService;
        private readonly ILogger<HomeController> logger;

        public HomeController(ZSHOEDbContext db, CryptoService cryptoService, EmailService emailService,ILogger<HomeController> logger)
        {
            this.db = db;
            this.cryptoService = cryptoService;
            this.emailService = emailService;
            this.logger = logger;
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

        public IActionResult MyAccount()
        {
            var data = db.Users.FirstOrDefault(u=>u.Id == User.GetCurrentUserId()); 
            return View(data);
        }
        [AllowAnonymous]
        public async Task<IActionResult> About()
        {
            var aboutInfo = await db.AboutInfos.FirstOrDefaultAsync(ai => ai.DeletedDate == null);
            var aboutTeam = db.AboutTeam.Where(at => at.DeletedDate == null).ToList();
            var aboutCustomer = db.AboutCustomers.Where(ac => ac.DeletedDate == null).ToList();
            var aboutWhoWeAre = await db.AboutWhoWeAre.FirstOrDefaultAsync(aw => aw.DeletedDate == null);
            var vm = new AboutViewModel
            {
                AboutInfos = aboutInfo,
                AboutWhoWeAre = aboutWhoWeAre,
                AboutCustomers = aboutCustomer,
                AboutTeam = aboutTeam
            };
            return View(vm);
        }

        [HttpPost]

        public async Task<IActionResult> Subscribe(Subscribe model)
        {

            if (model.Email == null)
            {
                return Json(new
                {
                    error = true,
                    message = "Should Not Be Empty"
                });
            }

            if (!model.Email.IsEmail())
            {
                return Json(new
                {
                    error = true,
                    message = "Email is not avaible or correct, please try again"
                });
            }

            if (!ModelState.IsValid)
            {
                string msg = ModelState.Values.First().Errors[0].ErrorMessage;

                return Json(new
                {
                    error = true,
                    message = msg
                });
            }

            var entity = db.Subscribes.FirstOrDefault(s => s.Email.Equals(model.Email));

            if (entity != null && entity.IsApproved == true)
            {
                return Json(new
                {
                    error = false,
                    message = "You have already subscribed"
                });
            }

            if (entity == null)
            {
                db.Subscribes.Add(model);
                db.SaveChanges();
            }
            else if (entity != null)
            {
                model.Id = entity.Id;
            }

            string token = $"{model.Id}-{model.Email}-{Guid.NewGuid()}";

            token = cryptoService.Encrypt(token, true);


            string message = $"Please approve your subscription with this <a href='{Request.Scheme}://{Request.Host}/approve-subscribe?token={token}'>link</a> ";


            await emailService.SendMailAsync(model.Email, "Subscribe Approve Message", message);

            return Json(new
            {
                error = false,
                message = "We sent a confirmation message to your Email"
            });

        }



        [Route("/approve-subscribe")]
        public IActionResult SubscribeApprove(string token)
        {

            token = cryptoService.Decrypt(token);

            Match match = Regex.Match(token, @"^(?<id>\d+)-(?<email>[^-]+)-(?<randomKey>.*)$");



            if (match.Success)
            {
                int id = Convert.ToInt32(match.Groups["id"].Value);
                string email = match.Groups["email"].Value;
                string randomKey = match.Groups["randomKey"].Value;

                var entity = db.Subscribes.FirstOrDefault(s => s.Id == id && s.DeletedDate == null);

                if (entity == null)
                {
                    ViewBag.Message = Tuple.Create(true, "Token Error");
                    goto end;
                }

                if (entity.IsApproved)
                {
                    ViewBag.Message = Tuple.Create(true, "Your request was already confirmed");

                    goto end;
                }

                entity.IsApproved = true;
                entity.ApprovedDate = DateTime.UtcNow.AddHours(4);
                db.SaveChanges();


                ViewBag.Message = Tuple.Create(false, "Your request confirmed");

            }
            else
            {
                ViewBag.Message = Tuple.Create(true, "Token Error");
            }

        end:
            return View();


        }

    } 
}
