using KEK_Emlak.Data.Entities;
using KEK_Emlak.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KEK_Emlak.Web.Controllers
{
    public class AccountController : Controller
    {
        private RoleManager<IdentityRole> roleManager;
        private UserManager<ApplicationUser> userManager;
        private SignInManager<ApplicationUser> signInManager;
        private IFileHandler fileHandler;

        public AccountController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IFileHandler fileHandler)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.fileHandler = fileHandler;
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = "/")
        {
            if (signInManager.IsSignedIn(User))
            {
                return RedirectToAction("Index", "Home");
            }
            returnUrl = returnUrl.Replace("%2F", "/");
            LoginVM login = new LoginVM()
            {
                ReturnUrl = returnUrl
            };
            return View(login);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            var user = await userManager.FindByEmailAsync(login.Email);

            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, login.Password, false, false);
                if (result.Succeeded)
                {
                    if (string.IsNullOrEmpty(login.ReturnUrl))
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    return Redirect(login.ReturnUrl);
                }
            }
            ModelState.AddModelError("IncorrectInput", "Username or Password is incorrect");
            return View(login);
        }

        [HttpGet]
        public IActionResult MemberRegister(string returnUrl)
        {
            if (signInManager.IsSignedIn(User))
            {
                return RedirectToAction("Index", "Home");
            }
            var model = new RegisterVM
            {
                ReturnUrl = returnUrl
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SellerRegister(RegisterVM register)
        {

            var usercheck = await userManager.FindByEmailAsync(register.Email ?? "");
            if (usercheck != null)
            {
                ModelState.AddModelError("Email", "User already exists!");
            }
            else
            {
                ApplicationUser user = new ApplicationUser();
                user.UserTypeId = 2;
                SetDataToApplicationUser(ref user, ref register);
                var result = await userManager.CreateAsync(user, register.Password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Seller");
                    if (register.ReturnUrl != null)
                    {
                        return Redirect(register.ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }

            }
            return View(register);
        }
        [HttpGet]
        public IActionResult SellerRegister(string returnUrl)
        {
            if (signInManager.IsSignedIn(User))
            {
                return RedirectToAction("Index", "Home");
            }
            var model = new RegisterVM
            {
                ReturnUrl = returnUrl
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MemberRegister(RegisterVM register)
        {

            var usercheck = await userManager.FindByEmailAsync(register.Email ?? "");
            if (usercheck != null)
            {
                ModelState.AddModelError("Email", "User already exists!");
            }
            else
            {
                ApplicationUser user = new ApplicationUser();
                user.UserTypeId = 3;
                SetDataToApplicationUser(ref user, ref register);
                var result = await userManager.CreateAsync(user, register.Password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Member");
                    if (register.ReturnUrl != null)
                    {
                        return Redirect(register.ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }

            }
            return View(register);
        }
        private object SetDataToApplicationUser(ref ApplicationUser user, ref RegisterVM register)
        {
            user.Email = register.Email;
            user.FullName = register.FullName;
            user.UserName = register.Email;
            user.PhoneNumber = register.Phone;
            user.Address = register.Address;
            return user;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            if (signInManager.IsSignedIn(User))
            {
                await signInManager.SignOutAsync();
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Logout(ApplicationUser user)
        {
            if (signInManager.IsSignedIn(User))
            {
                await signInManager.SignOutAsync();
            }
            return RedirectToAction("Index", "Home");
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => userManager.GetUserAsync(HttpContext.User);

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Profile()
        {
            ApplicationUser usr = await GetCurrentUserAsync();
            return View(usr);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> ChangeProfilePicture()
        {
            IFormFile file = Request.Form.Files[0];
            var profilePicUrl = fileHandler.UploadFile("UserImage", file);
            ApplicationUser usr = await GetCurrentUserAsync();
            usr.UserImage = profilePicUrl;
            var result = await userManager.UpdateAsync(usr);
            if (result.Succeeded)
            {
                ViewBag.message = "Successfully Updated";
            }
            return RedirectToAction(nameof(Profile));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> ChangePassword(PasswordVM model)
        {
            //PasswordVM model = new PasswordVM();
            var user = await userManager.GetUserAsync(HttpContext.User);
            var token = await userManager.GeneratePasswordResetTokenAsync(user);
            model.UserID = user.Id;
            model.Email = user.Email;
            model.BaseCode = token;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ChangePasswordConfirm(PasswordVM model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByIdAsync(model.UserID);
                var result = await userManager.ChangePasswordAsync(user, model.OldPassword, model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(Profile));
                }
                else
                {
                    model.Errormessage = "Password did not match";
                    return View("ChangePassword", model);
                }
            }
            return View("ChangePassword", model);
        }

        [HttpGet]
        public IActionResult ForgotPassword(LoginVM model)
        {
            return View(model);
        }



        [HttpGet]
        public async Task<IActionResult> ResetPasswordMail(LoginVM model)
        {
            ViewBag.Link = string.Empty;
            var user = await userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                ModelState.AddModelError("Email", "There is no account assosiated with this email.");
            }
            else
            {
                var token = await userManager.GeneratePasswordResetTokenAsync(user);
                var link = Url.Action(nameof(ResetPassword), "Account", new { userID = user.Id, code = token }, Request.Scheme, Request.Host.ToString());
                ViewBag.Link = link;
            }

            return View();
        }
        public IActionResult ResetPassword(string userID, string code)
        {
            PasswordVM recover = new PasswordVM();
            recover.UserID = userID;
            recover.BaseCode = code;
            return View(recover);
        }
        [HttpPost]
        public async Task<IActionResult> ResetPasswordConfirm(PasswordVM model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByIdAsync(model.UserID);
                var result = await userManager.ResetPasswordAsync(user, model.BaseCode, model.Password);
                if (result.Succeeded)
                {
                    await signInManager.PasswordSignInAsync(user, model.Password, false, false);
                }
                return RedirectToAction(nameof(Profile));
            }
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(string id)
        {
            var user = userManager.FindByIdAsync(id).Result;
            return View(user);
        }


        [HttpPost]
        public async Task<IActionResult> DeleteConfirm(ApplicationUser user)
        {
            var users = await userManager.FindByIdAsync(user.Id);
            var result = await userManager.DeleteAsync(users);
            return Redirect("/User/AllUser");
        }
    }
}
