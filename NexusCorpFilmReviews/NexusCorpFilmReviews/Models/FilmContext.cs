using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using NexusCorpFilmReviews.Models;

namespace NexusCorpFilmReviews.Models
{
    public class FilmContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public FilmContext() : base("name=FilmContext")
        {
        }

        public DbSet<Film> Films { get; set; }

        public DbSet<Actor> Actors { get; set; }

        public DbSet<Director> Directors { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<ActorComment> ActorComments { get; set; }

        public DbSet<DirectorComment> DirectorComments { get; set; }

        public DbSet<Gossip> Gossips { get; set; }

        public DbSet<Review> Reviews { get; set; }
    }
}
