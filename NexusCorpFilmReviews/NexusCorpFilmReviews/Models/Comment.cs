using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NexusCorpFilmReviews.Models
{
    public class Comment
    {
        //Public property for the Comment ID in the Comment Model. This is the primary key
        public virtual int CommentId { get; set; }

        //Public property for the Comment in the Comment Model
        public virtual string CommentContent { get; set; }

        //Public property for the Comment Date Added in the Comment Model
        public virtual DateTime CommentDateAdded { get; set; }

        //Public property for the User ID in the Comment Model. This is a foreign key
        public virtual int UserId { get; set; }

        //Public property for the Credit ID in the Comment Model. This is a foreign key
        public virtual int CreditId { get; set; }

        //Connecting the foreign keys to this model

        //User ID foreign key
        public virtual User User { get; set; }

        //Credit ID foreign key
        public virtual Credit Credit { get; set; }
    }
}