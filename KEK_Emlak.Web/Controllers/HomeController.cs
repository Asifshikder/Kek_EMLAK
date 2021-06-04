using KEK_Emlak.Data.Entities;
using KEK_Emlak.Service.Interface;
using KEK_Emlak.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace KEK_Emlak.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService productService;
        private readonly UserManager<ApplicationUser> userManager;

        public HomeController(ILogger<HomeController> logger,
            IProductService productService,
            UserManager<ApplicationUser> userManager
            )
        {
            _logger = logger;
            this.productService = productService;
            this.userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            IndexModel model = new IndexModel();
            int num = 20;
            HttpContext.Session.SetInt32("Num", 60);
            var productlist = productService.GetProducts().Take(num).ToList();
            var userlist = userManager.Users.Where(s=>s.UserTypeId==2).Take(num).ToList();
            List<ProductModel> lstpro = new List<ProductModel>();
            List<SellerModel> lstSeller = new List<SellerModel>();
            foreach(var item in productlist)
            {
                ProductModel product = new ProductModel();
                product.ProductId = item.Id;
                product.ProductName = item.Name;
                product.Price = item.Price;
                product.Area = item.Area;
                product.DisplayImage = item.DisplayImage;
                lstpro.Add(product);
            } 
            foreach(var item in userlist)
            {
                SellerModel seller = new SellerModel();
                seller.UserId = item.Id;
                seller.UserName = item.FullName;
                seller.UserImage = item.UserImage;
                seller.UserTypeName = "Satış Danışmanı" ;
                lstSeller.Add(seller);
            }
         
            model.Products = lstpro;
            model.Sellers = lstSeller;
            return View(model);
        }

        [HttpGet]
        public IActionResult AllProduct()
        {
            var productlist = productService.GetProducts().ToList();
            List<ProductModel> lstpro = new List<ProductModel>();
            foreach (var item in productlist)
            {
                ProductModel product = new ProductModel();
                product.ProductId = item.Id;
                product.ProductName = item.Name;
                product.Price = item.Price;
                product.Area = item.Area;
                product.DisplayImage = item.DisplayImage;
                lstpro.Add(product);
            }
            return View(lstpro);
        }
        [HttpGet]
        public IActionResult Members()
        {
            List<MemberModel> lstMember = new List<MemberModel>();
            var mmbrlist = userManager.Users.Where(s => s.UserTypeId == 3).ToList();

            foreach (var item in mmbrlist)
            {
                MemberModel member = new MemberModel();
                member.UserId = item.Id;
                member.UserName = item.FullName;
                member.UserImage = item.UserImage;
                member.UserTypeName = "Üye";
                lstMember.Add(member);
            }
            return View(lstMember);
        }
        [HttpGet]

        public IActionResult Sellers()
        {
            List<SellerModel> lstSeller = new List<SellerModel>();
            var userlist = userManager.Users.Where(s => s.UserTypeId == 2).ToList();

            foreach (var item in userlist)
            {
                SellerModel seller = new SellerModel();
                seller.UserId = item.Id;
                seller.UserName = item.FullName;
                seller.UserImage = item.UserImage;
                seller.UserTypeName = "Satış Danışmanı";
                lstSeller.Add(seller);
            }
            return View(lstSeller);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
