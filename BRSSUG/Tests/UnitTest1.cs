using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using DataAccessLayer;
using DataAccessLayer.Entities;
using DataAccessLayer.Queries;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using Tests.Properties;

namespace Tests
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

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            Database.SetInitializer(new Initializer());

            var context = MockRepository.GenerateStrictMock<IDbContext>();
            context.Stub(x => x.AsQueryable<Product>()).Return(
                new List<Product> {new Product() {Color = "Red"}, new Product(){Color = "Blue"}}.AsQueryable());
            IRepository repo = new Repository(context);
            
            var query = new ProductsByColorQuery("Blue");

            var result = repo.Find(query);
            result.ToList();
            
            Assert.AreEqual(1,result.Count());
            Assert.IsTrue(result.All(x=>x.Color == "Blue"));
        }
    }

    public class Initializer : DropCreateDatabaseIfModelChanges<AdventureWorksContext>
    {
        protected override void Seed(AdventureWorksContext context)
        {
            context.Set<Product>().Add(new Product() {});

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
