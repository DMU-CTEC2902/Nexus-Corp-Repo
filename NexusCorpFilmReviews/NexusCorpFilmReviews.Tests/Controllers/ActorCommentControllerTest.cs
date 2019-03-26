using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NexusCorpFilmReviews.Controllers;
using System.Web.Mvc;
using NexusCorpFilmReviews.Models;

namespace NexusCorpFilmReviews.Tests.Controllers
{
    [TestClass]
    public class ActorCommentControllerTest
    {
        ////test to see if it can find the controller index
        //[TestMethod]
        //public void Index()
        //{
        //    //Arrange
        //    ActorCommentsController controller = new ActorCommentsController();

        //    // Act
        //    ViewResult result = controller.Index() as ViewResult;

        //    // Assert
        //    Assert.IsNotNull(result);
        //}

        //[TestMethod]
        //public void Details()
        //{
        //    //Arrange
        //    ActorCommentsController controller = new ActorCommentsController();

        //    //created an object to hold a actor comment
        //    ActorComment newActorComment = new ActorComment();
        //    // Act
        //    ViewResult ActorComment = controller.Details(1) as ViewResult;
        //    //places the details found in details 1 into the new object
        //    newActorComment = ActorComment.Model as ActorComment;
        //    // Assert
        //    Assert.AreEqual(newActorComment.ActorCommentContent, "She is very talented");
        //}
    }
}
