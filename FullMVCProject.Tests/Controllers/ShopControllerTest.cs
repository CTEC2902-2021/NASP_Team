using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using FullMVCProject.Controllers;
using FullMVCProject.Models;

namespace FullMVCProject.Controllers
{
    [TestClass]
    public class ShopControllerTest
    {

        [TestMethod]
        public void IndexWelcomeMessage()
        {

            //Arrange
            PlayerModel model = new PlayerModel();
            TeamController controller = new TeamController(model);


            //Act
            ViewResult result = controller.Index();


            //Assert
            Assert.AreEqual("Welcome to the shop!. Check out our players",
              controller.ViewBag.WelcomeMessage);

        }

        [TestMethod]
        public void ProductName()
        {
            //Arrange
            PlayerModel model = new PlayerModel();
            TeamController controller = new TeamController(model);

            //Act
            ViewResult viewResult = controller.Player();
            PlayerModel result = viewResult.Model as PlayerModel;


            //Assert 
            Assert.AreEqual("Shah Chisti", result.Name);
        }

        [TestMethod]
        public void PlayerIsGoodScorer()
        {
            //Arrange
            PlayerModel model = new PlayerModel();
            TeamController controller = new TeamController(model);
            //Act
            ViewResult result = controller.Player();
            Assert.AreEqual("Bling!", result.ViewBag.SubTitle);
        }
        [TestMethod]
        public void PlayerIsTooSlow()
        {
            //Arrange
            PlayerModel model = new PlayerModel();
            model.Name = "Test player 1";
            model.Description = "Description of Tplayer 1";
            model.strength = 3;

            //Inject the controller's dependency on the model so we can test it
            TeamController controller = new TeamController(model);

            //Act
            ViewResult result = controller.Player();
            Assert.AreEqual("slow as an snail", result.ViewBag.SubTitle);
        }
    }
}
