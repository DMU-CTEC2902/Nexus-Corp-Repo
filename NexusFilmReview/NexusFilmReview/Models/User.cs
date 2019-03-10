using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NexusFilmReview.Models
{
    public class User
    {
        //Public property for the User ID in the User Model. This is the primary key
        public virtual int UserID { get; set; }

        //Public property for the User First Name in the User Model
        public virtual string UserFirstName { get; set; }

        //Public property for the User Last Name in the User Model
        public virtual string UserLastName { get; set; }

        //Public property for the User Email in the User Model
        public virtual string UserEmail { get; set; }

        //Public property for the User Phone Number in the User Model
        public virtual string UserPhoneNo { get; set; }
    }
}