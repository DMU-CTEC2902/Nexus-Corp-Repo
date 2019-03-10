using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NexusFilmReview.Models
{
    public class ActorModel
    {
        //Public property for the Actor ID in the Actor Model. This is a primary key
        public virtual int ActorID { get; set; }

        //Public property for the Actor First Name in the Actor Model
        public virtual string ActorFirstName { get; set; }

        //Public property for the Actor Last Name in the Actor Model
        public virtual string ActorLastName { get; set; }

        //Public property for the Actor Date of Birth in the Actor Model
        public virtual DateTime ActorDOB { get; set; }

        //Public property for the Actor Gender in the Actor Model
        public virtual string ActorGender { get; set; }
    }
}