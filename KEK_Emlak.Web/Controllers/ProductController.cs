using KEK_Emlak.Data.Entities;
using KEK_Emlak.Service.Interface;
using KEK_Emlak.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KEK_Emlak.Web.Controllers
{
    public class ProductController : Controller
    {
        private IProductService productService;
        private ICategoryService categoryService;
        private IFileHandler fileHandler;
        private UserManager<ApplicationUser> userManager;
        private SignInManager<ApplicationUser> signInManager;
        private ISellService sellService;

        public ProductController(IProductService productService, ISellService sellService, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ICategoryService categoryService, IFileHandler fileHandler)
        {
            this.productService = productService;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.categoryService = categoryService;
            this.fileHandler = fileHandler;
            this.sellService = sellService;
        }
        [HttpGet]
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> Index()
        {
           
                  var  products = productService.GetProducts();
               

            return View(products);
        }
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> UserProduct()
        {
            var cUser = GetCurrentUserAsync().Result;
            IEnumerable<Product> products = new List<Product>();
            string userrole = string.Empty;
            if (cUser != null)
            {
                if (await userManager.IsInRoleAsync(cUser ,"Admin"))
                {
                    products = productService.GetProducts();
                }
                if (await userManager.IsInRoleAsync(cUser, "Seller"))
                {
                    products = productService.GetProducts().Where(s => s.AddedBy == cUser.Id);
                }
            }

            return View(products);
        }
        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            ViewBag.Cagetories = new SelectList(categoryService.GetCategorys().ToList(), "Id", "Name");
            return View();
        }
        
        [HttpGet]
        public IActionResult Details(int id)
        {
            ProductVM product = new ProductVM();
            string user = string.Empty;
            if (signInManager.IsSignedIn(User))
            {
                 user = GetCurrentUserAsync().Result.Id.ToString();
            }
            var prs = productService.GetProduct(id);
            product.Id = prs.Id;
            product.Name = prs.Name;
            product.Details = prs.Details;
            product.DisplayImage = prs.DisplayImage;
            product.Image2 = prs.Image2;
            product.Image3 = prs.Image3;
            product.Image5 = prs.Image5;
            product.Image4 = prs.Image4;
            product.Price = prs.Price;
            product.Area = prs.Area;
            product.Location = prs.Location;
            product.AddedBy = prs.AddedBy;
            product.canBuy = prs.AddedBy == user ? false : true;
            product.CategoryName =categoryService.GetCategory(prs.CategoryId).Name;
            return View(product);
        }

        [HttpPost]
        public IActionResult Create(ProductVM model)
        {
            string displayImage = null;
            string Image1 = null;
            string image2 = null;
            string image3 = null;
            string image4 = null;
            Product product = new Product();
            if (model.DisplayImageFile != null)
            {
                 displayImage = fileHandler.UploadFile("Product", model.DisplayImageFile);
            }
            if (model.Image2File != null)
            {
                 Image1 = fileHandler.UploadFile("Product", model.Image2File);
            }
            if (model.Image3File != null)
            {
                 image2 = fileHandler.UploadFile("Product", model.Image3File);
            }
            if (model.Image4File != null)
            {
                 image3 = fileHandler.UploadFile("Product", model.Image4File);
            }
            if (model.Image5File != null) 
            { 
                 image4 = fileHandler.UploadFile("Product", model.Image5File); 
            }
            product.Name = model.Name;
            product.Details = model.Details;
            product.DisplayImage = displayImage;
            product.Image2 = Image1;
            product.Image3 = image2;
            product.Image4 = image3;
            product.Image5 = image4;
            product.Price = model.Price;
            product.Area = model.Area;
            product.Location = model.Location;
            product.CategoryId = model.CategoryId;
            product.AddedBy = GetCurrentUserAsync().Result.Id;
            productService.InsertProduct(product);
            return RedirectToAction(nameof(UserProduct));
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Cagetories = new SelectList(categoryService.GetCategorys().ToList(), "Id", "Name");
            var model = productService.GetProduct(id);
            ProductVM product = new ProductVM();
            product.Name = model.Name;
            product.Details = model.Details;
            product.DisplayImage = model.DisplayImage;
            product.Image2 = model.Image2;
            product.Image3 = model.Image3;
            product.Image4 = model.Image4;
            product.Image5 = model.Image5;
            product.Price = model.Price;
            product.Area = model.Area;
            product.Location = model.Location;
            product.CategoryId = model.CategoryId;
            return View(product);
        }

        [HttpPost]
        public IActionResult Update(ProductVM model)
        {
            string displayImage = null;
            string Image1 = null;
            string image2 = null;
            string image3 = null;
            string image4 = null;
            Product product = new Product();
            if (model.DisplayImageFile != null)
            {
                displayImage = fileHandler.UpdateFile(model.DisplayImage, "Product", model.DisplayImageFile);
                product.DisplayImage = displayImage;
            }
            else
            {
                product.DisplayImage = model.DisplayImage; ;
            }
            if (model.Image2File != null)
            {
                Image1 = fileHandler.UpdateFile(model.Image2,"Product", model.Image2File);
                product.Image2 = Image1;
            }
            else
            {
                product.Image2 = model.Image2; ;
            }
            if (model.Image3File != null)
            {
                image2 = fileHandler.UpdateFile(model.Image3,"Product", model.Image3File);
                product.Image3 = image2;
            }
            else
            {
                product.Image3 = model.Image3; ;
            }
            if (model.Image4File != null)
            {
                image3 = fileHandler.UpdateFile(model.Image4, "Product", model.Image4File);
                product.Image4 = image3;
            }
            else
            {
                product.Image4 = model.Image4; ;
            }
            if (model.Image5File != null)
            {
                image4 = fileHandler.UpdateFile(model.Image5, "Product", model.Image5File);
                product.Image5 = image4;
            }
            else
            {
                product.Image5 = model.Image5; ;
            }
            product.Id = model.Id;
            product.Name = model.Name;
            product.Details = model.Details;
            product.Price = model.Price;
            product.Area = model.Area;
            product.Location = model.Location;
            product.CategoryId = model.CategoryId;
            product.AddedBy = GetCurrentUserAsync().Result.Id;
            productService.UpdateProduct(product);
            return RedirectToAction(nameof(UserProduct));
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = productService.GetProduct(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult DeleteConfirm(Product product)
        {
            productService.DeleteProduct(product.Id);
            return RedirectToAction(nameof(UserProduct));
        }



        [HttpGet]
        [Authorize]
        public IActionResult Sells()
        {
            var user = GetCurrentUserAsync().Result;
            List<SellVM> sells = new List<SellVM>();
            var lst = sellService.GetSells().Where(s=>s.SellerId==user.Id).ToList();
            foreach (var item in lst)
            {
                var product = productService.GetProducts().Where(s => s.Id == item.ProductId).FirstOrDefault();
                var name = product.Name;
                SellVM sell = new SellVM();
                sell.SellId = item.Id;
                sell.ProductName = name;
                sell.Price = item.Price;
                sells.Add(sell);
            }
            return View(sells);
        }
        [HttpGet]
        [Authorize]
        public IActionResult AllSells()
        {
            List<SellVM> sells = new List<SellVM>();
            var lst = sellService.GetSells().ToList();
            foreach(var item in lst)
            {
                var product = productService.GetProducts().Where(s => s.Id == item.ProductId).FirstOrDefault();
                var name = product.Name;
                SellVM sell = new SellVM();
                sell.SellId = item.Id;
                sell.ProductName = name;
                sell.Price = item.Price;
                sells.Add(sell);
            }
            return View(sells);
        }
        private Task<ApplicationUser> GetCurrentUserAsync() => userManager.GetUserAsync(HttpContext.User);

    }
    public class SellVM
    {
        public int SellId { get; set; }
        public string ProductName { get; set; }
        public long Price { get; set; }
    }
}
