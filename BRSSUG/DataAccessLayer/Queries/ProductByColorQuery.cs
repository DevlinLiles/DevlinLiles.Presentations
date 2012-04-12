using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Queries
{
    public class ProductsByColorQuery : IQueryObject<Product>
    {
        public ProductsByColorQuery(string color)
        {
            ContextQuery = (c) => c.AsQueryable<Product>().Where(x => x.Color == color).Include(x=>x.BillOfMaterials);
        }

        private Func<ExtendedDbContext, IEnumerable<Product>> ContextQuery;

        public IEnumerable<Product> Execute(ExtendedDbContext extendedDbContext)
        {
            return ContextQuery(extendedDbContext);
        }
    }

    public class ProductById : IScalarObject<Product>
    {
        private Func<ExtendedDbContext, Product> ContextQuery =
            (c) => c.AsQueryable<Product>().FirstOrDefault(x => x.ProductID == 1);
        public IEnumerable<Product> Execute(ExtendedDbContext extendedDbContext)
        {
            throw new NotImplementedException();
        }
    }

    public interface IScalarObject<T> : IQueryObject<T>
    {
    }
}