using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLogic.QueryObjects;


namespace DataAccess.QueryObjects
{
    public class QueryObject : IQueryObject
    {
        public Func<IDbContext, int> ContextQuery { get; set; }

        protected void CheckContextAndQuery(IDbContext context)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (this.ContextQuery == null) throw new InvalidOperationException("Null Query cannot be executed.");
        }

        #region IQueryObject<T> Members

        public virtual int Execute(IDbContext context)
        {
            CheckContextAndQuery(context);
            return this.ContextQuery(context);
        }

        #endregion
    }
}
