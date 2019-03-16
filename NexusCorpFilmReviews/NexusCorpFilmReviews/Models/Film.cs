using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NexusCorpFilmReviews.Models
{
    public class Film
    {
        //Public property for the Film ID in the Film Model. This is the primary key
        public virtual int FilmId { get; set; }

        //Public property for the Genre ID in the Film Model. This is a foreign key
        public virtual int GenreId { get; set; }

        //Public property for the Actor ID in the Film Model. This is a foreign key
        public virtual int ActorId { get; set; }

        //Public property for the Director ID in the Film Model. This is a foreign key
        public virtual int DirectorId { get; set; }

        //Public property for the Film Name in the Film Model
        [Required]
        public virtual string FilmName { get; set; }
        [StringLength(100)]
        //Public property for the Film Description in the Film Model
        public virtual string FilmDescription { get; set; }

        //Public property for the Release Date in the Film Model
        public virtual DateTime ReleaseDate { get; set; }

        //Public property for the Rating in the Film Model
        public virtual int Rating { get; set; }

        [StringLength(50)]
        //Public property for the Genre Type in the Film Model
        public virtual string GenreType { get; set; }

        [StringLength(20)]
        //Public property for the User Name in the Film Model
        public virtual string UserName { get; set; }

        //Connecting the foreign keys to this model

        //Genre ID foreign key
        public virtual Genre Genre { get; set; }
        public virtual Actor Actor { get; set; }
        public virtual Director Director { get; set; }


    }
}