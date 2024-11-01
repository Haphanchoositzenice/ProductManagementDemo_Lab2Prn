using System;
using BusinessObjects;
using System.Collections.Generic;
using DataAccessLayer;

namespace Repositories
{
    public interface IProductRepository
    {
        void SaveProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
        List<Product> GetProducts();
        Product GetProductById(int productId);
    }
}
