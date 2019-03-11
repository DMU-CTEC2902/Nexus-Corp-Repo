using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NexusCorpFilmReviews.Models
{
    public class Gossip
    {
        //Public property for the Gossip ID in the Gossip Model. This is a primary key
        public virtual int GossipId { get; set; }

        //Public property for the Gossip Comment in the Gossip Model
        public virtual string GossipContent { get; set; }

        //Public property for the Gossip Comment Date Added in the Gossip Model
        public virtual DateTime GossipContentDateAdded { get; set; }

        //Public property for the User Name in the Gossip Model. 
        public virtual string UserName { get; set; }
    }
}