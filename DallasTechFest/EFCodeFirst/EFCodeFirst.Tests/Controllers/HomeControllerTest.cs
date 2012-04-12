using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EFCodeFirst;
using EFCodeFirst.Controllers;
using System.Data.Entity;
using EFCodeFirst.Repository;
using EFCodeFirst.Tests.Properties;
using EFCodeFirst.Domain;

namespace EFCodeFirst.Tests.Controllers
{
    public class BlueProductQuery : Type
    {
        public BlueProductQuery()
        {
            
        }
    }
    [TestClass]
    public class HomeControllerTest
    {

        [TestMethod]
        public void ShouldConnectionToTheDatabase()
        {
            var context = new AdventureWorksContext(Settings.Default.Connection);

            IQueryable<Product> set = context.Set(new BlueProductQuery());

            set.Where(x => x.Category == new ProductCategory());

            set.
        }
    }
}
