using System;
using System.Collections.Generic;

namespace Core.Interfaces
{
    public interface IProductService
    {
        IEnumerable<T> Find<T>(Func<T, bool> where) where T : class;
    }
}