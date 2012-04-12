using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace BusinessLogic.QueryObjects
{
    public interface IDbContext : IDisposable
    {
        IQueryable<T> AsQueryable<T>() where T : class;
    }
}
