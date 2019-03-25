using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NexusCorpFilmReviews.Controllers;
using NexusCorpFilmReviews.Models;
using System.Web.Mvc;

namespace NexusCorpFilmReviews.Tests.Controllers
{
    [TestClass]
    public class FilmControllerTest
    {

        //[TestMethod]
        //public void Index()
        //{
        //    // Arrange
        //    FilmsController controller = new FilmsController();

        //    // Act
        //    ViewResult result = controller.Index() as ViewResult;

        //    // Assert
        //    Assert.IsNotNull(result);
        //}

        [TestMethod]
        public void Details()
        {
            // Arrange
            FilmsController controller = new FilmsController();
            //created an object to hold a film
            Film newFilm = new Film();
            // Act
            ViewResult Film = controller.Details(1) as ViewResult;
            //places the details found in details 1 into the new object
            newFilm = Film.Model as Film;
            // Assert
            Assert.AreEqual(newFilm.FilmName, "Captain Marvel");
        }

        [TestMethod]
        public void TestFilm()
        {

            //created an object to hold a film
            Film newFilm = new Film();
            newFilm.FilmName = "test";

            // Arrange
            FilmsController controller = new FilmsController(newFilm);


            // Act
            ViewResult Film = controller.DetailsTest() as ViewResult;
            //places the details found in details 1 into the new object
            newFilm = Film.Model as Film;
            // Assert
            Assert.AreEqual(newFilm.FilmName, "test");
        }
    }
}
