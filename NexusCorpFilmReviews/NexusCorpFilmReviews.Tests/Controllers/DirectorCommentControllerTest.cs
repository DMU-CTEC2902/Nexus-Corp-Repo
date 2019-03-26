using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NexusCorpFilmReviews.Controllers;
using System.Web.Mvc;
using NexusCorpFilmReviews.Models;

namespace NexusCorpFilmReviews.Tests.Controllers
{
    [TestClass]
    public class DirectorCommentControllerTest
    {
        ////test to see if it can find the controller index
        //[TestMethod]
        //public void Index()
        //{
        //    //Arrange
        //    DirectorCommentsController controller = new DirectorCommentsController();

        //    // Act
        //    ViewResult result = controller.Index() as ViewResult;

        //    // Assert
        //    Assert.IsNotNull(result);
        //}

        //[TestMethod]
        //public void Details()
        //{
        //    //Arrange
        //    DirectorCommentsController controller = new DirectorCommentsController();

        //    //created an object to hold a director comment
        //    DirectorComment newDirectorComment = new DirectorComment();
        //    // Act
        //    ViewResult DirectorComment = controller.Details(1) as ViewResult;
        //    //places the details found in details 1 into the new object
        //    newDirectorComment = DirectorComment.Model as DirectorComment;
        //    // Assert
        //    Assert.AreEqual(newDirectorComment.DirectorCommentContent, "Great production producted");
        //}
    }
}
