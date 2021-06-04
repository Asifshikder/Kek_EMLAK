using KEK_Emlak.Data.Entities;
using KEK_Emlak.Service.Interface;
using KEK_Emlak.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KEK_Emlak.Web.Controllers
{
  
    public class BuyController : Controller
    {
        private IProductService productService;
        private UserManager<ApplicationUser> userManager;
        private SignInManager<ApplicationUser> signInManager;
        private IBuyService buyService;
        private ISellService sellService;

        public BuyController(IProductService productService, UserManager<ApplicationUser> userManager, 
            SignInManager<ApplicationUser> signInManager,
            ISellService sellService,
            IBuyService buyService)
        {
            this.productService = productService;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.buyService = buyService;
            this.sellService = sellService;
        }
        [HttpPost]
        [Authorize]
        public IActionResult BuyProduct(ProductVM product)
        {
            var user = GetCurrentUserAsync().Result;
            Buy buy = new Buy();
            buy.BuyerId = user.Id;
            buy.ProductId = product.Id;
            buy.Price = product.Price;
            Sell sell = new Sell();
            sell.SellerId = product.AddedBy;
            sell.ProductId = product.Id;
            sell.Price = product.Price;
            buyService.InsertBuy(buy);
            sellService.InsertSell(sell);
            return Redirect("/Buy/Emlak"); 
        }  
        [HttpGet]
        [Authorize]
        public IActionResult Emlak()
        {
            var user = GetCurrentUserAsync().Result;
            List<BuyVM> sells = new List<BuyVM>();
            var lst = buyService.GetBuys().Where(s => s.BuyerId == user.Id).ToList();
            foreach (var item in lst)
            {
                var product = productService.GetProducts().Where(s => s.Id == item.ProductId).FirstOrDefault();
                var name = product.Name;
                BuyVM sell = new BuyVM();
                sell.BuyId = item.Id;
                sell.ProductName = name;
                sell.Price = item.Price;
                sells.Add(sell);
            }
            return View(sells);
        }
          
        [HttpGet]
        [Authorize(Roles ="Admin")]
        public IActionResult AllBuys()
        {
            List<BuyVM> buys = new List<BuyVM>();
            var lst = buyService.GetBuys().ToList();
            foreach (var item in lst)
            {
                var product = productService.GetProducts().Where(s => s.Id == item.ProductId).FirstOrDefault();
                var name = product.Name;
                BuyVM sell = new BuyVM();
                sell.BuyId = item.Id;
                sell.ProductName = name;
                sell.Price = item.Price;
                buys.Add(sell);
            }
            return View(buys);
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => userManager.GetUserAsync(HttpContext.User);

    }
    public class BuyVM
    {
        public int BuyId { get; set; }
        public string ProductName { get; set; }
        public long Price { get; set; }

    }
}
