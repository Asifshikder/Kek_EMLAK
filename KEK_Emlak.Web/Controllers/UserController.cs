using KEK_Emlak.Data.Entities;
using KEK_Emlak.Service.Interface;
using KEK_Emlak.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KEK_Emlak.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService productService;
        private readonly UserManager<ApplicationUser> userManager;

        public UserController(ILogger<HomeController> logger,
            IProductService productService,
            UserManager<ApplicationUser> userManager
            )
        {
            _logger = logger;
            this.productService = productService;
            this.userManager = userManager;
        }
        public IActionResult UserProfile(string id)
        {
            var products = productService.GetProducts().Where(s => s.AddedBy == id).Take(30);
            var user = userManager.FindByIdAsync(id).Result;
            UserModel userModel = new UserModel();
            List<ProductModel> models = new List<ProductModel>();
            userModel.UserId = user.Id;
            userModel.FullName = user.FullName;
            userModel.UserImage = user.UserImage;
            userModel.Address = user.Address;
            userModel.Email = user.Email;
            userModel.UserTypeId = user.UserTypeId;
            userModel.UserTypeName = user.UserTypeId==1?"Admin":user.UserTypeId==2?"Satış Danışmanı":user.UserTypeId==3?"Üye":"";
            userModel.PhoneNumber = user.PhoneNumber;
            if (products != null)
            {
              
                foreach(var item in products)
                {
                    ProductModel product = new ProductModel();
                    product.ProductId = item.Id;
                    product.ProductName = item.Name;
                    product.Price = item.Price;
                    product.Area = item.Area;
                    product.DisplayImage = item.DisplayImage;
                    models.Add(product);
                }
            }
            userModel.Product = models;
            return View(userModel);
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult AllSeller()
        {
            var users = userManager.Users.Where(s => s.UserTypeId == 2).ToList();
            return View(users);
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult AllMember()
        {
            var users = userManager.Users.Where(s => s.UserTypeId == 3).ToList();
            return View(users);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult AllUser()
        {
            var users = userManager.Users.Where(s => s.UserTypeId != 1).ToList();
            return View(users);
        }
    }
}
