using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLogic.QueryObjects;

namespace DataAccess.QueryObjects
{
    public interface IQueryObject
    {
        int Execute(IDbContext context);
    }
    
    public interface IQueryObject<out T>
    {
        IEnumerable<T> Execute(IDbContext context);
    }
}
