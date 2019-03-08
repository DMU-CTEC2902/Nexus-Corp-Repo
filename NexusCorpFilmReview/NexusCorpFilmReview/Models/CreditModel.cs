using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NexusCorpFilmReview.Models
{
    public class CreditModel
    {
        //Public property for the Credit ID in the Credit Model. This is a primary key
        public virtual int CreditID { get; set; }

        //Public property for the Actor ID in the Credit Model. This is a foreign key
        public virtual int ActorID { get; set; }

        //Public property for the Director ID in the Credit Model. This is a foreign key
        public virtual int DirectorID { get; set; }

        //Connecting the foreign keys to this model

        //Actor ID foreign key
        public virtual ActorModel ActorModel { get; set; }

        //Director ID foreign key
        public virtual DirectorModel DirectorModel { get; set; }
    }
}