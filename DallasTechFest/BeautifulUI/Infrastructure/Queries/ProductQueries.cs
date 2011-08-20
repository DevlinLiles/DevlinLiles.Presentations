using System.Linq;
using Core.Domain.Entities;

namespace Infrastructure.Queries
{
    public static class ProductQueries
    {
        private static readonly string Blue = "Blue";

        public static IQueryable<Product> GetAllBlueProducts(this IQueryable<Product> products)
        {
            return products.Where(x => x.Color == Blue);
        }
    }
}