using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeBlogFitness.BL.Controllers;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace CodeBlogFitness.BL.Controllers

{
    [TestClass()]
    public class UserControllersTests
    {      
        [TestMethod]
        public void SetNewUserDataTest()
        {
            //Arrange
            var userName = Guid.NewGuid().ToString();
            var birthDate = DateTime.Now.AddYears(-18);
            var weight = 90;
            var height = 190;
            var gender = "man";
            var controller = new UserController(userName);
            //act
            controller.SetNewUserData(gender, 
                                      birthDate,
                                      weight, 
                                      height);

            var controller2 = new UserController(userName);

            //assert
            Assert.AreEqual(userName, controller2.CurrentUser.Name);
            Assert.AreEqual(birthDate, controller2.CurrentUser.BirthDate);
            Assert.AreEqual(weight, controller2.CurrentUser.Weight);
            Assert.AreEqual(height, controller2.CurrentUser.Height);
            Assert.AreEqual(gender, controller2.CurrentUser.Gender.Name);

            //done
        }

        [TestMethod]
        public void SaveTest()
        {
            //Arrange
            var userName = Guid.NewGuid().ToString();
            //Act
            var controller = new UserController(userName);
            //Assert

            Assert.AreEqual(userName, controller.CurrentUser.Name); ;
        }

        [TestMethod]
        public void AddTest()
        {
            //Arrange
            var userName = Guid.NewGuid().ToString();
            var foodName = Guid.NewGuid().ToString();
            var rnd = new Random();
            var userController = new UserController(userName);
            var eatingController = new EatingController(userController.CurrentUser);

            var food = 
            //Act
            var controller = new UserController(userName);
            //Assert

            Assert.AreEqual(userName, controller.CurrentUser.Name); 
            var data  = Encoding
        }


    }
}
