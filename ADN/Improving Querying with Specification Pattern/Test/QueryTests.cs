using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLogic;
using DataAccess.Queries;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using DataAccess;
using BusinessLogic.QueryObjects;
using Test.Properties;

namespace Test
{
    [TestClass]
    public class QueryTests
    {
        [TestMethod]
        public void ShouldFilterTestData()
        {
            //Arrange
            IQueryable<Blog> items = new List<Blog>
                                         {
                                             new Blog()
                                                 {
                                                     Creationdate = DateTime.Now,
                                                     ShortDescription = "Test",
                                                     Title = "Test"
                                                 },
                                             new Blog()
                                                 {
                                                     Creationdate = DateTime.Now,
                                                     ShortDescription = "not this one",
                                                     Title = "Blog"
                                                 },
                                             new Blog()
                                                 {
                                                     Creationdate = DateTime.Now,
                                                     ShortDescription = "not this",
                                                     Title = "TeBlog"
                                                 },
                                             new Blog()
                                                 {
                                                     Creationdate = DateTime.Now,
                                                     ShortDescription = "not this one",
                                                     Title = "TestBlog"
                                                 }

                                         }.AsQueryable();

            var context = MockRepository.GenerateStrictMock<IDbContext>();
            context.Expect(x => x.AsQueryable<Blog>()).Return(items.AsQueryable());
            var repository = new BlogRepository(context);

            //Act
            var spec = new TitleNameQuery("Test");
            var returnedValues = repository.Find(spec);

            //Assert
            Assert.AreEqual(1, returnedValues.Count());
        }


        [TestMethod]
        public void ShouldConnectToTheDatabase()
        {
            var repository = new BlogRepository(new BlogContext(Settings.Default.BlogConnection));
            var results = repository.Find(new TitleNameQuery("Test"));
        }
    }
}
