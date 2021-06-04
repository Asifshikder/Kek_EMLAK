using KEK_Emlak.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KEK_Emlak.Service.Interface
{
   public interface ICategoryService
    {
        IEnumerable<Category> GetCategorys();
        Category GetCategory(int id);
        void InsertCategory(Category Category);
        void UpdateCategory(Category Category);
        void DeleteCategory(int id);
        int count();
    }
}
