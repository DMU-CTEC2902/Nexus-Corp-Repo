﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NexusCorpFilmReviews.Models
{
    public class Review
    {
        //Public property for the Review ID in the Review Model. This is the primary key
        public virtual int ReviewId { get; set; }

        //Public property for the Review in the Review Model
        public virtual string ReviewContent { get; set; }

        //Public property for the Review Date Added in the Review Model
        public virtual DateTime ReviewDateAdded { get; set; }

        //Public property for the User ID in the Review Model. This is a foreign key
        public virtual int UserId { get; set; }

        //Public property for the Film ID in the Review Model. This is the foreign key
        public virtual int FilmId { get; set; }

        //Connecting the foreign keys to this model

        //User ID foreign key
        public virtual User User { get; set; }

        //Film ID foreign key
        public virtual Film Film { get; set; }

    }
}