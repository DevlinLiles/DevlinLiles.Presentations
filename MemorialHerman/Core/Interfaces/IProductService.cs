using System.Collections.Generic;
using DataAccess.Entities;

namespace Core.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProductsByColor(string color);
    }
}