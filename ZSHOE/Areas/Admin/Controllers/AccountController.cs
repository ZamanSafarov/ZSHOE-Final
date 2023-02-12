using ZSHOE.Domain.AppCode.Extensions;
using ZSHOE.Domain.Models.Entities.Membership;
using ZSHOE.Domain.Models.FormModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ZSHOE.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly SignInManager<ZSHOEUser> signInManager;
        private readonly UserManager<ZSHOEUser> userManager;

        public AccountController(SignInManager<ZSHOEUser> signInManager, UserManager<ZSHOEUser> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }


        [Authorize(Policy = "admin.account.signin")]
   
        public IActionResult Signin()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Policy = "admin.account.signin")]
        public async Task<IActionResult> Signin(LoginFormModel user)
        {
            ZSHOEUser foundedUser = null;


            if (user.UserName == null || user.Password == null)
            {
                if (Request.IsAjaxRequest())
                {
                    return Json(new
                    {
                        error = true,
                        message = "İstifadəçi adınız və ya şifrəniz yanlışdır"
                    });
                }

                ViewBag.Message = "İstifadəçi adınız və ya şifrəniz yanlışdır";
                goto end;
            }

            if (user.UserName.IsEmail())
            {
                foundedUser = await userManager.FindByEmailAsync(user.UserName);
            }
            else
            {
                foundedUser = await userManager.FindByNameAsync(user.UserName);
            }

            if (foundedUser == null)
            {
                if (Request.IsAjaxRequest())
                {
                    return Json(new
                    {
                        error = true,
                        message = "İstifadəçi adınız və ya şifrəniz yanlışdır"
                    });
                }

                ViewBag.Message = "İstifadəçi adınız və ya şifrəniz yanlışdır";
                goto end;
            }


            if (foundedUser.EmailConfirmed == false)
            {
                ViewBag.Message = "Zəhmət olmasa emailinizə gələn təsdiq linkindən hesabınızı doğrulayın";
                goto end;
            }

            var signInResult = await signInManager.PasswordSignInAsync(foundedUser, user.Password, true, true);



            if (!signInResult.Succeeded)
            {
                if (Request.IsAjaxRequest())
                {
                    return Json(new
                    {
                        error = true,
                        message = "İstifadəçi adınız və ya şifrəniz yanlışdır"
                    });
                }

                ViewBag.Message = "İstifadəçi adınız və ya şifrəniz yanlışdır";
                goto end;
            }

            if (Request.IsAjaxRequest())
            {
                return Json(new
                {
                    error = false,
                    message = "Daxil oldunuz"
                });
            }

            var callbackUrl = Request.Query["ReturnUrl"];

            if (!string.IsNullOrWhiteSpace(callbackUrl))
            {
                return Redirect(callbackUrl);
            }
            return RedirectToAction("Index", "Dashboard");


        end:
            return View(user);
        }
    }
}