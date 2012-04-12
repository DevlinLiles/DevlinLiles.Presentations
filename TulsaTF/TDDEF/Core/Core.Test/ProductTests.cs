using System;
using System.Data.Entity;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Core.Entities;
using Core.Interfaces;
using Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace Core.Test
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class ProductTests
    {
        private static IDbContext dbContext;
        private static DbSet<Product> returnValue;
        private static IRepository context;

        [ClassInitialize]
        public static void Setup(TestContext testContext)
        {
            dbContext = MockRepository.GenerateStrictMock<IDbContext>();
            returnValue = MockRepository.GenerateStrictMock<DbSet<Product>>();
            dbContext.Stub(x => x.Set<Product>()).Return(returnValue);
            context = new Repository(dbContext);
            
        }

        [TestMethod]
        public void ShouldAddNewProducts()
        {
            context.Add(new Product());

            dbContext.AssertWasCalled(x=>x.Set<Product>());
            returnValue.AssertWasCalled(x=>x.Add(Arg<Product>.Is.Anything));
        }

        [TestMethod]
        public void ShouldRemoveOldProducts()
        {
            context.Remove(new Product());

            dbContext.AssertWasCalled(x => x.Set<Product>());
            returnValue.AssertWasCalled(x => x.Remove(Arg<Product>.Is.Anything));
        }

        [TestMethod]
        public void ShouldUpdateProducts()
        {
            context.Commit();

            dbContext.AssertWasCalled(x=>x.SaveChanges());
        }
    }
}
