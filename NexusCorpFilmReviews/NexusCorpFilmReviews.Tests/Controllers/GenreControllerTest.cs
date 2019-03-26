using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NexusCorpFilmReviews.Controllers;
using System.Web.Mvc;
using NexusCorpFilmReviews.Models;

namespace NexusCorpFilmReviews.Tests.Controllers
{
    [TestClass]
    public class GenreControllerTest
    {
        ////test to see if it can find the controller index
        //[TestMethod]
        //public void Index()
        //{
        //    //Arrange
        //    GenresController controller = new GenresController();

        //    // Act
        //    ViewResult result = controller.Index() as ViewResult;

        //    // Assert
        //    Assert.IsNotNull(result);
        //}

        ////test to see if you can find the correct genre details
        //[TestMethod]
        //public void Details()
        //{
        //    //Arrange
        //    GenresController controller = new GenresController();

        //    //created an object to hold a genre
        //    Genre newGenre = new Genre();
        //    // Act
        //    ViewResult Genre = controller.Details(1) as ViewResult;
        //    //places the details found in details 1 into the new object
        //    newGenre = Genre.Model as Genre;
        //    // Assert
        //    Assert.AreEqual(newGenre.GenreType, "Science Fiction");
        //}
    }
}
