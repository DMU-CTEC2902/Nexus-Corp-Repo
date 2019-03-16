using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NexusCorpFilmReviews.Models
{
    public class Actor
    {
        //Public property for the Actor ID in the Actor Model. This is a primary key
        public virtual int ActorId { get; set; }

        //Public property for the Actor First Name in the Actor Model
        public virtual string ActorFirstName { get; set; }

        //Public property for the Actor Last Name in the Actor Model
        public virtual string ActorLastName { get; set; }

        //Public property for the Actor Date of Birth in the Actor Model
        public virtual DateTime ActorDOB { get; set; }

        //Public property for the Actor age in the Actor Model
        public virtual int ActorAge { get; set; }

        //Public property for the Actor Gender in the Actor Model
        public virtual string ActorGender { get; set; }

    }
}