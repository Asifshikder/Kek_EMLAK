using KEK_Emlak.Data.Entities;
using KEK_Emlak.Service.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KEK_Emlak.Web.Controllers
{
    public class FullFillmentController : Controller
    {
        private RoleManager<IdentityRole> roleManager;
        private UserManager<ApplicationUser> userManager;
        private SignInManager<ApplicationUser> signInManager;
        private IUserTypeService userTypeService;

        public FullFillmentController(RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IUserTypeService userTypeService
            )
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.userTypeService = userTypeService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            ViewBag.Message = string.Empty;
            var counter = userTypeService.count();
            if (counter < 1)
            {
                UserType type1 = new UserType() { Name = "Admin" };
                UserType type2 = new UserType() { Name = "Seller" };
                UserType type3 = new UserType() { Name = "Member" };
                userTypeService.InsertUserType(type1);
                userTypeService.InsertUserType(type2);
                userTypeService.InsertUserType(type3);
            }

            if (roleManager.Roles.Count() == 0)
            {
                IdentityRole model = new IdentityRole();
                IdentityRole model1 = new IdentityRole();
                IdentityRole model2 = new IdentityRole();
                model.Name = "Admin";
                model1.Name = "Member";
                model2.Name = "Seller";
                await roleManager.CreateAsync(model);
                await roleManager.CreateAsync(model1);
                await roleManager.CreateAsync(model2);
                ViewBag.Message = "Hazır";
            }
            var check = userManager.FindByEmailAsync("admin@mail.com");
            if (check.Result == null)
            {
                ApplicationUser user = new ApplicationUser();
                user.PhoneNumber = "0909099032432";
                user.UserName = "KekEmlak";
                user.FullName = "KEK Emlak";
                user.Email = "admin@mail.com";
                var password = "admin1234";
                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Admin");
                }
                ViewBag.Message = "Merhaba";
            }
            return View();
        }
    }
}
