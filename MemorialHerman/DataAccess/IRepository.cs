using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess
{
    public interface IRepository
    {
        T Get<T>(ISingleObjectQuery<T> query) where T : class;
        IEnumerable<T> Find<T>(IQueryObject<T> query) where T : class;
    }

    public interface ISingleObjectQuery<T>
    {
        T Execute(IDbContext context);
    }

    public interface IQueryObject<T>
    {
        IEnumerable<T> Execute(IDbContext context);
    }

    public interface IDbContext
    {
        IQueryable<T> AsQueryable<T>() where T : class;
    }

    public class QueryObject<T> : IQueryObject<T>
    {
        public Func<IDbContext, IQueryable<T>> ContextQuery;

        public IEnumerable<T> Execute(IDbContext context)
        {
            return ContextQuery(context);
        }
    }

}