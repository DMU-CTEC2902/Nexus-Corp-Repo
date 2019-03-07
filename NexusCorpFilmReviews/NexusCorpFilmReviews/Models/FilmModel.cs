using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NexusCorpFilmReviews.Models
{
    public class FilmModel
    {
        //Public property for the Film ID in the Film Model. This is the primary key
        public virtual int FilmID { get; set; }

        //Public property for the Film Name in the Film Model
        public virtual string FilmName { get; set; }

        //Public property for the Film Description in the Film Model
        public virtual string FilmDescription { get; set; }

        //Public property for the Release Date in the Film Model
        public virtual DateTime ReleaseDate { get; set; }

        //Public property for the User ID in the Film Model. This is a foreign key
        public virtual int UserID { get; set; }

        //Public property for the Credit ID in the Film Model. This is a foreign key
        public virtual int CreditID { get; set; }

        //Public property for the Genre ID in the Film Model. This is a foreign key
        public virtual int GenreID { get; set; }
    }
}