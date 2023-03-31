

using ZSHOE.Domain.AppCode.Extensions;
using ZSHOE.Domain.AppCode.Services;
using ZSHOE.Domain.Models.Entities.Membership;
using ZSHOE.Domain.Models.FormModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ZSHOE.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<ZSHOEUser> signInManager;
        private readonly UserManager<ZSHOEUser> userManager;
        private readonly EmailService emailService;
        private readonly RoleManager<ZSHOERole> roleManager;

        public AccountController(SignInManager<ZSHOEUser> signInManager, UserManager<ZSHOEUser> userManager, EmailService emailService, RoleManager<ZSHOERole> roleManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.emailService = emailService;
            this.roleManager = roleManager;
        }
        [AllowAnonymous]
        [Route("/signin.html")]
        public IActionResult Signin()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("/signin.html")]
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
                        message = "Email or Password is invalid,please try valid one"
                    });
                }

                ViewBag.Message = "Email or Password is invalid,please try valid one";
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
                        message = "Email or Password is invalid,please try valid one"
                    });
                }

                ViewBag.Message = "Email or Password is invalid,please try valid one";
                goto end;
            }


            if (foundedUser.EmailConfirmed == false)
            {
                ViewBag.Message = "Please verify your account from the confirmation link sent to your email";
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
                        message = "Email or Password is invalid,please try valid one"
                    });
                }

                ViewBag.Message = "Email or Password is invalid,please try valid one";
                goto end;
            }

            if (Request.IsAjaxRequest())
            {
                return Json(new
                {
                    error = false,
                    message = "You are Signed in"
                });
            }

            var callbackUrl = Request.Query["ReturnUrl"];

            if (!string.IsNullOrWhiteSpace(callbackUrl))
            {
                return Redirect(callbackUrl);
            }

            return RedirectToAction("Index", "Home");

        end:
            return View(user);
        }


        [AllowAnonymous]
        [Route("/register.html")]
        public IActionResult Register()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("/register.html")]
        public async Task<IActionResult> Register(RegisterFormModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ZSHOEUser();

                user.Email = model.Email;
                user.UserName = model.Email;
                user.Name = model.Name;
                user.Surname = model.Surname;
                //user.EmailConfirmed = true;

                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    var token = await userManager.GenerateEmailConfirmationTokenAsync(user);
                    string path = $"{Request.Scheme}://{Request.Host}/registration-confirm.html?email={user.Email}&token={token}";

                    var emailResponse = await emailService.SendMailAsync(user.Email, "Registration for ZSHOE e-commerce website", $"Please verify your account with this <a href='{path}'>link</a>.");

                    if (emailResponse)
                    {
                        ViewBag.Message = "Registration completed successfully";
                    }
                    else
                    {
                        ViewBag.Message = "There was an error sending to email, please try again";
                    }

                    await userManager.AddToRoleAsync(user, "User");
                    //await signInManager.SignInAsync(user, false);

                    return RedirectToAction(nameof(Signin));
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                    ViewBag.Message = error.Description;
                }
            }

            return View(model);

        }

        [AllowAnonymous]
        [Route("registration-confirm.html")]
        public async Task<IActionResult> RegisterConfirm(string email, string token)
        {
            var foundedUser = await userManager.FindByEmailAsync(email);
            if (foundedUser == null)
            {
                ViewBag.Message = "Incorrect Token";
                goto end;
            }
            token = token.Replace(" ", "+");
            var result = await userManager.ConfirmEmailAsync(foundedUser, token);

            if (!result.Succeeded)
            {
                ViewBag.Message = "Incorrect Token";
                goto end;
            }

            ViewBag.Message = "Your account has been verified";
        end:
            return RedirectToAction(nameof(Signin));
        }


        [AllowAnonymous]
        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ZSHOEForgotPassword model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var foundedUser = await userManager.FindByEmailAsync(model.Email);

            if (foundedUser != null && await userManager.IsEmailConfirmedAsync(foundedUser))
            {
                var token = await userManager.GeneratePasswordResetTokenAsync(foundedUser);
                token = token.Replace(" ", "+");
                string path = $"{Request.Scheme}://{Request.Host}/reset-password.html?email={foundedUser.Email}&token={token}";

                var emailResponse = await emailService.SendMailAsync(foundedUser.Email, "Login for ZSHOE", $"Update your password via <a href='{path}'>link</a>!");
                return View("ForgotPasswordConfirmation");
            }
            return View(model);
        }
        [AllowAnonymous]
        [Route("reset-password.html")]
        [HttpGet]
        public IActionResult ResetPassword(string token, string email)
        {
            if (token == null || email == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var model = new ResetPasswordModel();
            model.Token = token.Replace(" ", "+");
            model.Email = email;
            return View(model);
        }
        [AllowAnonymous]
        [Route("reset-password.html")]
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var foundedUser = await userManager.FindByEmailAsync(model.Email);

            if (foundedUser == null)
            {
                return View(model);
            }
            var result = await userManager.ResetPasswordAsync(foundedUser, model.Token.Replace(" ", "+"), model.Password);

            if (result.Succeeded)
            {
                return View("ResetPasswordConfirmation");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return View(model);
        }



        [Route("/logout.html")]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "home");
        }

        [AllowAnonymous]
        [Route("/NotFound")]
        public IActionResult AccesDenied()
        {
            return View();
        }

        public async Task CreateRole()
        {
            if (!await roleManager.RoleExistsAsync("User"))
            {
                var userRole = new ZSHOERole { Name = "User" };

                await roleManager.CreateAsync(userRole);
            }

        }


        //public IActionResult HandleAction(string actionName)
        //{
        //    if (string.IsNullOrEmpty(actionName))
        //    {
        //        // Redirect to the Access Denied action
        //        return RedirectToAction("AccessDenied");
        //    }
        //    else
        //    {
        //        return RedirectToAction("Index", "home");
        //    }
        //}
    }
}