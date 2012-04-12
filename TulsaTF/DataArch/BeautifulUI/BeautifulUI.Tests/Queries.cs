using System;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using BeautifulUI.Tests.Properties;
using Core.Entities;
using Core.Queries;
using Infrastructure.Implementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BeautifulUI.Tests
{
    [TestClass]
    public class Queries
    {
        public static Random rand = new Random();
        [TestMethod]
        public void TestMethod1()
        {
            var context = new Repository(new AdventureWorksContext(Settings.Default.Connection));


            var query = context.Find<Product>().FilterByColor("Blue");

            Console.WriteLine(((DbQuery<Product>)query).ToString());

        }

        [TestMethod]
        public void Name()
        {
            Console.WriteLine(rand.Next(1,25));

        }
    }
}
