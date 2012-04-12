using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BusinessLogic;
using DataAccess.QueryObjects;
using BusinessLogic.QueryObjects;

namespace DataAccess
{
    public class BlogRepository : IRepository, IDisposable
    {
        private readonly IDbContext _context;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
                if (_context != null)
                    _context.Dispose();
        }

        ~BlogRepository()
        {
            Dispose(false);
        }
        public BlogRepository(IDbContext context)
        {
            _context = context;
        }
        
        public IEnumerable<T> Find<T>(IQueryObject<T> spec) where T : class
        {
            return spec.Execute(_context);
        }
    }
}
