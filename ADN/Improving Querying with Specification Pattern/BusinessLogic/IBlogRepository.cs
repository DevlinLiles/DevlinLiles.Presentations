using System.Collections.Generic;
using DataAccess.QueryObjects;

namespace BusinessLogic
{
    public interface IRepository
    {
        IEnumerable<T> Find<T>(IQueryObject<T> spec) where T : class;
    }
}
