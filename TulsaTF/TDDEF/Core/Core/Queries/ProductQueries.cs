using System.Collections.Generic;
using System.Linq;
using Core.Entities;

namespace Core.Queries
{
    public static class ProductQueries
    {
         public static IQueryable<Product> FilterByColor(this IQueryable<Product> products, string color)
         {
             return products.Where(x => x.Color == color);
         }

        public static IQueryable<IGrouping<string, Product>> GroupByColor(this IQueryable<Product> products)
        {
            return products.GroupBy(x => x.Color);
        }
    }
}