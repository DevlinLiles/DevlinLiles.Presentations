using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Models;

namespace DataAccess
{
    public class Repository : IRepository
    {
        public IQueryable<T> AsQueryable<T>() where T : class
        {
            var context = new AdventureWorksContext();
            return context.Set<T>();
        }
    }
    public interface IRepository
    {
        IQueryable<T> AsQueryable<T>() where T : class;
    }
}
