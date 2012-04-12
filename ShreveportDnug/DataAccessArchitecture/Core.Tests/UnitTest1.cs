using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Core.Entities;
using Core.Queries;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Tests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var data = new List<Product>()
                           {
                               new Product() {ProductID = 1},
                               new Product() {ProductID = 2}

                           }.AsQueryable();

            Product returnValue = data.GetById(1);
            
            Assert.AreEqual(1, returnValue.ProductID);
        }
    }
}
