using System.Collections.Generic;
using System.Linq;
using Core.Entities;

namespace Core.Queries
{
    public static class ProductQueries
    {
         public static IEnumerable<Product> FilterByColor(this IQueryable<Product> products, string color)
         {
             return products.Where(x => x.Color == color);
         }
    }
  
}
