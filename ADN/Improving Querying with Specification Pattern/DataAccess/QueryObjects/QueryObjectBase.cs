using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Diagnostics;
using System.Linq;
using System.Text;
using BusinessLogic.QueryObjects;


namespace DataAccess.QueryObjects
{
    public abstract class QueryObjectBase<T> : IQueryObject<T>
    {
        protected Func<IDbContext, IQueryable<T>> ContextQuery { get; set; }
        protected IDbContext Context { get; set; }

        protected void CheckContextAndQuery()
        {
            if (Context == null) throw new InvalidOperationException("Context cannot be null.");
            if (this.ContextQuery == null) throw new InvalidOperationException("Null Query cannot be executed.");
        }

        protected virtual IQueryable<T> ExtendQuery()
        {
            try
            {
                return this.ContextQuery(Context);
            }
            catch (Exception)
            {                
                throw; //just here to catch while debugging
            }
        }

        #region IQueryObject<T> Members

        public virtual IEnumerable<T> Execute(IDbContext context)
        {
            Context = context;
            CheckContextAndQuery();
            var query = this.ExtendQuery();
            Debug.Write(((ObjectQuery<T>)query).ToTraceString());
            return query.ToList();    
        }

        #endregion
    }
}
