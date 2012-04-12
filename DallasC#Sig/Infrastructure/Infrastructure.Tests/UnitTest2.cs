using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Infrastructure.Entities;

namespace Infrastructure.Tests
{
    [TestClass]
    public class QueryTest
    {
        [TestMethod]
        public void ShouldReturnAnObject()
        {
            var context = new IncentivesContext();

            var set = context.Set<Employee>();

            set.SingleOrDefault(x => x.Id == 1);
        }
    }
}
