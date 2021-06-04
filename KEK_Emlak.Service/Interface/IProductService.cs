
using KEK_Emlak.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KEK_Emlak.Service.Interface
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(int id);
        void InsertProduct(Product Product);
        void UpdateProduct(Product Product);
        void DeleteProduct(int id);
        int count();
    }
}

