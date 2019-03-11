using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NexusCorpFilmReviews.Models
{
    public class Credit
    {
        //Public property for the Credit ID in the Credit Model. This is a primary key
        public virtual int CreditId { get; set; }

        //Public property for the Actor ID in the Credit Model. This is a foreign key
        public virtual int ActorId { get; set; }

        //Public property for the Director ID in the Credit Model. This is a foreign key
        public virtual int DirectorId { get; set; }

        //Connecting the foreign keys to this model

        //Actor ID foreign key
        public virtual Actor Actor { get; set; }

        //Director ID foreign key
        public virtual Director Director { get; set; }
    }
}