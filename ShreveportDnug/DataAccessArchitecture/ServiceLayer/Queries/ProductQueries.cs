using System.Linq;
using Core.Entities;

namespace Core.Queries
{
    public static class ProductQueries
    {
         public static Product GetById(this IQueryable<Product> items, int id)
         {
             return items.Single(x => x.ProductID == id);
         }
    }
}