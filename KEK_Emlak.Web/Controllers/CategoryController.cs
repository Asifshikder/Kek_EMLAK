using KEK_Emlak.Data.Entities;
using KEK_Emlak.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KEK_Emlak.Web.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var catlist = categoryService.GetCategorys();
            return View(catlist);
        } 
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            categoryService.InsertCategory(category);
            return RedirectToAction(nameof(Index));
        } 
        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(categoryService.GetCategory(id));
        }
        [HttpPost]
        public IActionResult Update(Category category)
        {
            categoryService.UpdateCategory(category);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(categoryService.GetCategory(id));
        }
        [HttpPost]
        public IActionResult DeleteConfirm(Category category)
        {
            categoryService.DeleteCategory(category.Id);
            return RedirectToAction(nameof(Index));
        }
    }
}
