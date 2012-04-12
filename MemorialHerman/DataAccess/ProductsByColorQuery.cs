using System.Linq;
using DataAccess.Entities;

namespace DataAccess
{
    public class ProductsByColorQuery : QueryObject<Product>
    {
        public ProductsByColorQuery(string color)
        {
            ContextQuery = c => c.AsQueryable<Product>().Where(x => x.Color == color);
        }
    }
}