using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NexusCorpFilmReviews.Controllers;
using System.Web.Mvc;
using NexusCorpFilmReviews.Models;

namespace NexusCorpFilmReviews.Tests.Controllers
{
    [TestClass]
    public class DirectorControllerTest
    {
        ////test to see if it can find the controller index
        //[TestMethod]
        //public void Index()
        //{
        //    //Arrange
        //    DirectorsController controller = new DirectorsController();

        //    // Act
        //    ViewResult result = controller.Index() as ViewResult;

        //    // Assert
        //    Assert.IsNotNull(result);
        //}

        //[TestMethod]
        //public void Details()
        //{
        //    //Arrange
        //    DirectorsController controller = new DirectorsController();

        //    //created an object to hold a director
        //    Director newDirector = new Director();
        //    // Act
        //    ViewResult Director = controller.Details(1) as ViewResult;
        //    //places the details found in details 1 into the new object
        //    newDirector = Director.Model as Director;
        //    // Assert
        //    Assert.AreEqual(newDirector.DirectorFirstName, "Anna");
        //}

    }
}
