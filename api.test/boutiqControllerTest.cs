using System;
using Moq;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using boutiq.Data;
using boutiq.Models;
using boutiqApi.Controllers;

namespace api.test
{
    [TestFixture]
    // ̣test for the ideal situation when a post is made with the right values
    public class boutiqControllerTest
    {
        [TestCase]
        public void WhenBoutiqueItemIsAdded()
        {
            //Arrange
            Boutiq botiq = new Boutiq
            {
                Id = 1,
                Type = "George",
                Description = "this is george",
                cost = 234234
            };

            var bi = new Mock<IBoutiqInterface>();
            bi.Setup(p => p.CreateBotiqItem(botiq));

            var controller = new BoutiqController(bi.Object);
            var resul = controller.PostBoutiqItem(botiq);

            Assert.AreEqual(resul, botiq);
        }


        [TestCase]
        public void WhenBoutiqueItemIsAdded()
        {
            //Arrange
            Boutiq botiq = new Boutiq
            {
                Id = 1,
                Type = "George",
                Description = "this is george",
                cost = 234234
            };

            var bi = new Mock<IBoutiqInterface>();
            bi.Setup(p => p.CreateBotiqItem(botiq));

            var controller = new BoutiqController(bi.Object);
            var resul = controller.PostBoutiqItem(botiq);

            Assert.AreEqual(resul, botiq);
        }


    }
}
