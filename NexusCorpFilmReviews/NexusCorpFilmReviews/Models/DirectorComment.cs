using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NexusCorpFilmReviews.Models
{
    public class DirectorComment
    {
        //Public property for the Director Comment ID in the Comment Model. This is the primary key
        public virtual int DirectorCommentId { get; set; }

        //Public property for the Director ID in the Comment Model. This is the primary key
        public virtual int DirectorId { get; set; }

        //Public property for the Director Comment in the Comment Model
        [StringLength(200)]
        public virtual string DirectorCommentContent { get; set; }

        //Public property for the Director Comment Date Added in the Comment Model
        public virtual DateTime DirectorCommentDateAdded { get; set; }

        //Public property for the User Name in the Review Model. 
        public virtual string UserName { get; set; }

        //Connecting the foreign keys to this model
        public virtual Director Director { get; set; }

    }
}