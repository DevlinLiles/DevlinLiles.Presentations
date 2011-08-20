using System;
using System.Data.Objects;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Core.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Infrastructure.Queries;

namespace Infrastructure.Tests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            //
            // TODO: Add constructor logic here
            //
        }


        [TestMethod]
        public void ShouldFilterToOnlyBlueProducts()
        {
            //arrange
            var items = new List<Product>()
                            {
                                new Product() {Color = "Red"},
                                new Product() {Color = "Blue"}
                            }.AsQueryable();

            //act
            
            var returnedItems = items.GetAllBlueProducts();

            ((ObjectQuery<Product>) returnedItems).ToTraceString();
            //assert
            Assert.AreEqual(1, returnedItems.Count());

        }
    }
}
