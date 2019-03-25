using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NexusCorpFilmReviews.Controllers;
using System.Web.Mvc;
using NexusCorpFilmReviews.Models;
namespace NexusCorpFilmReviews.Tests.Controllers
{
    [TestClass]
    public class FilmControllerTest
    {
        private Film _film;
        private FilmsController _filmsController;

        [TestInitialize]
        public void SetUp()
        {
            _film = new Film
            {
                FilmId = 1,
                GenreId = 1,
                ActorId = 1,
                DirectorId = 1,
                FilmName = "jhygfjuhfv",
                FilmDescription = "hjusfghjugk",
                ReleaseDate = new DateTime(2017, 01, 01),
                Rating = 5,
                GenreType = "comdey"
            };
            _filmsController = new FilmsController();
        }

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

        //[TestMethod]
        //public void Details()
        //{
        //    // Arrange
        //    FilmsController controller = new FilmsController();

        //    // Act
        //    ViewResult Film = controller.Details() as ViewResult;

        //    // Assert
        //    Assert.AreEqual(Details, Film.ViewBag.Message);
        //}

    }
}
