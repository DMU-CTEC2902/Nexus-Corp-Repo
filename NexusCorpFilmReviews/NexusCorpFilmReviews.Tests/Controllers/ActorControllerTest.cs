using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NexusCorpFilmReviews.Controllers;
using System.Web.Mvc;
using NexusCorpFilmReviews.Models;

namespace NexusCorpFilmReviews.Tests.Controllers
{
    [TestClass]
    public class ActorControllerTest
    {
        ////test to see if it can find the controller index
        //[TestMethod]
        //public void Index()
        //{
        //    //Arrange
        //    ActorsController controller = new ActorsController();

        //    // Act
        //    ViewResult result = controller.Index() as ViewResult;

        //    // Assert
        //    Assert.IsNotNull(result);
        //}

        //[TestMethod]
        //public void Details()
        //{
        //    //Arrange
        //    ActorsController controller = new ActorsController();

        //    //created an object to hold a actor
        //    Actor newActor = new Actor();
        //    // Act
        //    ViewResult Actor = controller.Details(1) as ViewResult;
        //    //places the details found in details 1 into the new object
        //    newActor = Actor.Model as Actor;
        //    // Assert
        //    Assert.AreEqual(newActor.ActorFirstName, "Brie");
        //}


    }
}
