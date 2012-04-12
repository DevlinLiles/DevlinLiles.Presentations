using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UI;
using UI.Controllers;
using UI.Models;

namespace UI.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Welcome to ASP.NET MVC!", result.ViewBag.Message);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void ShouldAllowForAGameSetupThatCreatesLocations()
        {
            var controller = new HomeController();

            ViewResult result = (ViewResult)controller.CreateGame();

            Assert.IsNotNull(result.Model);
            var typedModel = result.Model as GameModel;
            Assert.IsNotNull(typedModel.Players);
            Assert.IsNotNull(typedModel.Locations);
        }

        [TestMethod]
        public void ShouldAllowForGameSetupThatCreatesPlayers()
        {
            
        }

    }
}
