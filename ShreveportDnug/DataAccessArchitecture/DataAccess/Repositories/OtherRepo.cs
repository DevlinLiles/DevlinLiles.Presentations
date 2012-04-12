using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Interfaces;

namespace Infrastructure.Repositories
{
    public class OtherRepo : IRepository
    {
        private readonly AdventureWorksContext _context;

        public OtherRepo(AdventureWorksContext context)
        {
            _context = context;
        }

        public T Get<T>(Func<T, bool> where) where T : class
        {
            return _context.Set<T>().SingleOrDefault(where);
        }

        public IQueryable<T> Find<T>() where T : class
        {
            return _context.Set<T>();
        }

        public void Add<T>(T item) where T : class
        {
            _context.Set<T>().Add(item);
        }

        public void Remove<T>(T item) where T : class
        {
            _context.Set<T>().Remove(item);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}

