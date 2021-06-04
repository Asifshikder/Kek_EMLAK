using KEK_Emlak.Data.Entities;
using KEK_Emlak.Repo.Repository;
using KEK_Emlak.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace KEK_Emlak.Service.Services
{
   public class CategoryService:ICategoryService
    {
        private readonly IRepository<Category> categoryRepository;
        public CategoryService( IRepository<Category> categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public void DeleteCategory(int id)
        {
            Category Category = categoryRepository.Get(id);
            categoryRepository.Delete(Category);

        }

        public Category GetCategory(int id)
        {
            return categoryRepository.Get(id);
        }

        public IEnumerable<Category> GetCategorys()
        {
            return categoryRepository.GetAll();
        }

        public void InsertCategory(Category Category)
        {
            categoryRepository.Insert(Category);
        }

        public void UpdateCategory(Category Category)
        {
            categoryRepository.Update(Category);
        }
        public int count()
        {
            return categoryRepository.count();
        }

    }
}
