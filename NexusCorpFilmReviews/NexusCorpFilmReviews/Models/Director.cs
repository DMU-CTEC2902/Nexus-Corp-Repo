﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NexusCorpFilmReviews.Models
{
    public class Director
    {
        //Public property for the Director ID in the Director Model. This is a primary key
        public virtual int DirectorId { get; set; }

        //Public property for the Director First Name in the Director Model
        [StringLength(50)]
        public virtual string DirectorFirstName { get; set; }

        //Public property for the Director Last Name in the Director Model
        [StringLength(50)]
        public virtual string DirectorLastName { get; set; }

        //Public property for the Director Date of Birth in the Director Model
        public virtual DateTime DirectorDOB { get; set; }

        //Public property for the director age in the director Model
        public virtual int DirectorAge { get; set; }

        //Public property for the Director Gender in the Director Model
        [StringLength(15)]
        public virtual string DirectorGender { get; set; }

    }
}