using System;
using Moq;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using boutiq.Data;
using boutiq.Models;
using boutiqApi.Controllers;
using System.Linq;

namespace api.test
{
    [TestFixture]
    // ̣test for the ideal situation when a post is made with the right values
    public class boutiqControllerTest
    {

        // test the create function
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

            var repo = new Mock<IBoutiqInterface>();
            repo.Setup(p => p.CreateBotiqItem(botiq));

            var controller = new BoutiqController(repo.Object);
            var Postresult = controller.PostBoutiqItem(botiq);

            Assert.AreEqual(Postresult, botiq);
        }



        // test the getAll function
        [TestCase]
        public void WhenBoutiqItemsAreRetrieved()
        {
            var botiq = new Boutiq
            {
                Id = 1,
                Type = "George",
                Description = "this is george",
                cost = 234234
            };

            /// //////////

            // var botiq = new[] {
            //   new Boutiq {
            //     Id = 1,
            //     Type = "George",
            //     Description = "this is george",
            //     cost = 234234
            // },
            //  new Boutiq{
            //     Id = 2,
            //     Type = "George2",
            //     Description = "this is george",
            //     cost = 234234
            // }
            // };

            var repo = new Mock<IBoutiqInterface>();
            repo.Setup(p => p.CreateBotiqItem(botiq));

            repo.Setup(p => p.GetAllBoutiqItems());
            var controller = new BoutiqController(repo.Object);
            var getResult = controller.GetAllBoutiqItems();
            Assert.IsNotNull(getResult);
            // Assert.AreEqual(3, getResult.Local.Count);
            // Assert.AreEqual(getResult, botiq.ToList());

        }





        // test the update botique item function
        [TestCase]
        public void UpdateBoutiqItem()
        {
            //Arrange
            Boutiq botiq = new Boutiq
            {

                Type = "George",
                Description = "this is george",
                cost = 234234
            };

            Boutiq botiqs = new Boutiq
            {
                Id = 1,
                Type = "Georgess",
                Description = "this is george",
                cost = 234234
            };

            var bi = new Mock<IBoutiqInterface>();
            bi.Setup(p => p.CreateBotiqItem(botiq));
            // var bb = new Mock<IBoutiqInterface>();
            bi.Setup(p => p.UpdateBoutiqItems(botiq));


            var controller = new BoutiqController(bi.Object);
            var resul = controller.UpdateBoutiqItems(botiqs);

            Assert.AreEqual(resul, null);
            // Assert.AreEqual(resul, botiqs);
        }

        // test the delete function
        [TestCase]
        public void DeleteBoutiqItem(int id)
        {
            //Arrange
            Boutiq botiq = new Boutiq
            {

                Type = "George",
                Description = "this is george",
                cost = 234234
            };

            Boutiq botiqs = new Boutiq
            {
                Id = 1,
                Type = "George",
                Description = "this is george",
                cost = 234234
            };

            var bi = new Mock<IBoutiqInterface>();
            bi.Setup(p => p.CreateBotiqItem(botiq));
            bi.Setup(p => p.DeleteBoutiqItem(botiq));


            var controller = new BoutiqController(bi.Object);
            var resul = controller.DeleteBoutiqItem(1);

            Assert.AreEqual(resul, null);
        }
    }
}

