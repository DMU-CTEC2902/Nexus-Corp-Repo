using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NexusCorpFilmReviews.Models
{
    public class ActorComment
    {
        //Public property for the Actor Comment ID in the Comment Model. This is the primary key
        public virtual int ActorCommentId { get; set; }

        //Public property for the Actor ID in the Comment Model. This is the primary key
        public virtual int ActorId { get; set; }

        //Public property for the Actor Comment in the Comment Model
        public virtual string ActorCommentContent { get; set; }

        //Public property for the Actor Comment Date Added in the Comment Model
        public virtual DateTime ActorCommentDateAdded { get; set; }

        //Public property for the User Name in the Actor Comment Model. 
        public virtual string UserName { get; set; }

        //Connecting the foreign keys to this model

        public virtual Actor Actor { get; set; }
    }
}