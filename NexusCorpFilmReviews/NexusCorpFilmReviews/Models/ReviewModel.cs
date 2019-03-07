using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NexusCorpFilmReviews.Models
{
    public class ReviewModel
    {
        //Public property for the Review ID in the Review Model. This is the primary key
        public virtual int ReviewID { get; set; }

        //Public property for the Review in the Review Model
        public virtual string Review { get; set; }

        //Public property for the Review Date Added in the Review Model
        public virtual DateTime ReviewDateAdded { get; set; }

        //Public property for the User ID in the Review Model. This is a foreign key
        public virtual int UserID { get; set; }

        //Public property for the Film ID in the Review Model. This is the foreign key
        public virtual int FilmID { get; set; }
}