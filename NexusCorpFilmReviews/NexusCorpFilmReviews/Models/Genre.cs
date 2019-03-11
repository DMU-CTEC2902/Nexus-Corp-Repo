using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NexusCorpFilmReviews.Models
{
    public class Genre
    {
        //Public property for the Genre ID in the Genre model. This is the primary key
        public virtual int GenreId { get; set; }

        //Public property for the Genre in the Genre model
        public virtual string GenreType { get; set; }
    }
}