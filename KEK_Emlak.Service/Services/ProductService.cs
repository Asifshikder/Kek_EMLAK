
using KEK_Emlak.Data.Entities;
using KEK_Emlak.Repo.Repository;
using KEK_Emlak.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace KEK_Emlak.Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> productRepository;
        private readonly IRepository<Category> categoryRepository;
        public ProductService(IRepository<Product> productRepository,IRepository<Category> categoryRepository)
        {
            this.productRepository = productRepository;
            this.categoryRepository = categoryRepository;
        }

        public void DeleteProduct(int id)
        {
            Product Product = productRepository.Get(id);
            productRepository.Delete(Product);

        }

        public Product GetProduct(int id)
        {
            return productRepository.Get(id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return productRepository.GetAll();
        }

        public void InsertProduct(Product Product)
        {
            productRepository.Insert(Product);
        }

        public void UpdateProduct(Product Product)
        {
            productRepository.Update(Product);
        }
        public int count()
        {
            return productRepository.count();
        }

    }
}

