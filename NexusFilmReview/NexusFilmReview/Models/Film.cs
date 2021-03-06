﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NexusFilmReview.Models
{
    public class Film
    {
        //Public property for the Film ID in the Film Model. This is the primary key
        public virtual int FilmID { get; set; }

        //Public property for the Film Name in the Film Model
        public virtual string FilmName { get; set; }

        //Public property for the Film Description in the Film Model
        public virtual string FilmDescription { get; set; }

        //Public property for the Release Date in the Film Model
        public virtual DateTime ReleaseDate { get; set; }

        //Public property for the Rating in the Film Model
        public virtual int Rating { get; set; }

        //Public property for the User ID in the Film Model. This is a foreign key
        public virtual int UserID { get; set; }

        //Public property for the Credit ID in the Film Model. This is a foreign key
        public virtual int CreditID { get; set; }

        //Public property for the Genre ID in the Film Model. This is a foreign key
        public virtual int GenreID { get; set; }

        //Connecting the foreign keys to this model

        //User ID foreign key
        public virtual User User { get; set; }

        //Credit ID foreign key
        public virtual Credit Credit { get; set; }

        //Genre ID foreign key
        public virtual Genre Genre { get; set; }
    }
}