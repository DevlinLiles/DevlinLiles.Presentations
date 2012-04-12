using System.Collections.Generic;
using Core.Interfaces;
using DataAccess;
using DataAccess.Entities;

namespace Core
{
    public class ProductService : IProductService
    {
        public IEnumerable<Product> GetAllProductsByColor(string color)
        {
            var repository = new Repository();
            return repository.Find(new ProductsByColorQuery(color));
        }
    }
}