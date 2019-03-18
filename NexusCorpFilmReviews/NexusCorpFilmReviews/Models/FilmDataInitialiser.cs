using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace NexusCorpFilmReviews.Models
{
    public class FilmDataInitialiser: DropCreateDatabaseAlways<FilmContext>
    {
        protected override void Seed(FilmContext context)
        {
            //Intialise the genre class
            Genre genre1 = new Genre();
            //set the genre id
            genre1.GenreId = 1;
            //set the genre type
            genre1.GenreType = "Science Fiction";
            //add genre 1 to the context
            context.Genres.Add(genre1);

            //Intialise the genre class
            Genre genre2 = new Genre();
            //set the genre id
            genre2.GenreId = 2;
            //set the genre type
            genre2.GenreType = "Comedy";
            //add genre 2 to the context
            context.Genres.Add(genre2);

            //Intialise the genre class
            Genre genre3 = new Genre();
            //set the genre id
            genre3.GenreId = 3;
            //set the genre type
            genre3.GenreType = "Action";
            //add genre 3 to the context
            context.Genres.Add(genre3);

            //Intialise the genre class
            Genre genre4 = new Genre();
            //set the genre id
            genre4.GenreId = 4;
            //set the genre type
            genre4.GenreType = "Romance";
            //add genre 4 to the context
            context.Genres.Add(genre4);

            //Intialise the genre class
            Genre genre5 = new Genre();
            //set the genre id
            genre5.GenreId = 5;
            //set the genre type
            genre5.GenreType = "Drama";
            //add genre 5 to the context
            context.Genres.Add(genre5);

            //Intialise the genre class
            Genre genre6 = new Genre();
            //set the genre id
            genre6.GenreId = 6;
            //set the genre type
            genre6.GenreType = "Fantasy";
            //add genre 6 to the context
            context.Genres.Add(genre6);

            //Intialise the genre class
            Genre genre7 = new Genre();
            //set the genre id
            genre7.GenreId = 7;
            //set the genre type
            genre7.GenreType = "Thriller";
            //add genre 7 to the context
            context.Genres.Add(genre7);

            //Intialise the genre class
            Genre genre8 = new Genre();
            //set the genre id
            genre8.GenreId = 8;
            //set the genre type
            genre8.GenreType = "Mystery";
            //add genre 8 to the context
            context.Genres.Add(genre8);

            //Intialise the genre class
            Genre genre9 = new Genre();
            //set the genre id
            genre9.GenreId = 9;
            //set the genre type
            genre9.GenreType = "Animation";
            //add genre 9 to the context
            context.Genres.Add(genre9);

            //Intialise the genre class
            Genre genre10 = new Genre();
            //set the genre id
            genre10.GenreId = 10;
            //set the genre type
            genre10.GenreType = "Romantic Comedy";
            //add genre 10 to the context
            context.Genres.Add(genre10);

            //Intialise the actor class
            Actor actor1 = new Actor();
            //sets the actor id
            actor1.ActorId = 1;
            //sets the actor first name
            actor1.ActorFirstName = "Brie";
            //sets the actor last name
            actor1.ActorLastName = "Larson";
            //sets the date of birth 
            actor1.ActorDOB = new DateTime(1989, 10, 01);
            //sets the gender 
            actor1.ActorGender = "Female";
            //sets the age
            actor1.ActorAge = 29;
            //adds the actor to the context
            context.Actors.Add(actor1);

            //Intialise the actor class
            Actor actor2 = new Actor();
            //sets the actor id
            actor2.ActorId = 2;
            //sets the actor first name
            actor2.ActorFirstName = "Leonardo ";
            //sets the actor last name
            actor2.ActorLastName = "DiCaprio";
            //sets the date of birth 
            actor2.ActorDOB = new DateTime(1974, 11, 11);
            //sets the gender 
            actor2.ActorGender = "Male";
            //sets the age
            actor2.ActorAge = 45;
            //adds the actor to the context
            context.Actors.Add(actor2);

            //Intialise the actor class
            Actor actor3 = new Actor();
            //sets the actor id
            actor3.ActorId = 3;
            //sets the actor first name
            actor3.ActorFirstName = "Chris ";
            //sets the actor last name
            actor3.ActorLastName = "Pine";
            //sets the date of birth 
            actor3.ActorDOB = new DateTime(1980, 08, 26);
            //sets the gender 
            actor3.ActorGender = "Male";
            //sets the age
            actor3.ActorAge = 38;
            //adds the actor to the context
            context.Actors.Add(actor3);

            //Intialise the actor class
            Actor actor4 = new Actor();
            //sets the actor id
            actor4.ActorId = 4;
            //sets the actor first name
            actor4.ActorFirstName = "Scarlett";
            //sets the actor last name
            actor4.ActorLastName = "Johansson";
            //sets the date of birth 
            actor4.ActorDOB = new DateTime(1984, 11, 22);
            //sets the gender 
            actor4.ActorGender = "Female";
            //sets the age
            actor4.ActorAge = 34;
            //adds the actor to the context
            context.Actors.Add(actor4);

            //Intialise the director class
            Director director1 = new Director();
            //sets the director id
            director1.DirectorId = 1;
            //sets the director first name
            director1.DirectorFirstName = "Anna";
            //sets the director last name
            director1.DirectorLastName = " Boden";
            //sets the date of birth 
            director1.DirectorDOB = new DateTime(1972, 09, 20);
            //sets the gender 
            director1.DirectorGender = "Female";
            //sets the age
            director1.DirectorAge = 42;
            //adds the director to the context
            context.Directors.Add(director1);

            //Intialise the director class
            Director director2 = new Director();
            //sets the director id
            director2.DirectorId = 2;
            //sets the director first name
            director2.DirectorFirstName = "Steven";
            //sets the director last name
            director2.DirectorLastName = " Spielberg";
            //sets the date of birth 
            director2.DirectorDOB = new DateTime(1946, 10, 18);
            //sets the gender 
            director2.DirectorGender = "Male";
            //sets the age
            director2.DirectorAge = 72;
            //adds the director to the context
            context.Directors.Add(director2);

            //Intialise the director class
            Director director3 = new Director();
            //sets the director id
            director3.DirectorId = 3;
            //sets the director first name
            director3.DirectorFirstName = "Danny";
            //sets the director last name
            director3.DirectorLastName = " Boyle";
            //sets the date of birth 
            director3.DirectorDOB = new DateTime(1956, 10, 20);
            //sets the gender 
            director3.DirectorGender = "Male";
            //sets the age
            director3.DirectorAge = 62;
            //adds the director to the context
            context.Directors.Add(director3);

            //Intialise the actor comment class
            ActorComment actorComment1 = new ActorComment();
            //sets actor comment id
            actorComment1.ActorCommentId = 1;
            //references the actor id
            actorComment1.ActorId = 1;
            //sets the actor comment context
            actorComment1.ActorCommentContent = "She is very talented";
            //sets actor comment date added
            actorComment1.ActorCommentDateAdded = new DateTime(2019, 01, 05);
            //sets the user name
            actorComment1.UserName = "Bob Bartlet";
            //adds the actor comment to the context
            context.ActorComments.Add(actorComment1);

            //Intialise the director comment class
            DirectorComment directorComment1 = new DirectorComment();
            //sets director comment id
            directorComment1.DirectorCommentId = 1;
            //references the director id
            directorComment1.DirectorId = 1;
            //sets the director comment context
            directorComment1.DirectorCommentContent = "Great production producted";
            //sets director comment date added
            directorComment1.DirectorCommentDateAdded = new DateTime(2019, 01, 05);
            //sets the user name
            directorComment1.UserName = "Bob Bartlet";
            //adds the director comment to the context
            context.DirectorComments.Add(directorComment1);

            //Intialise the film class
            Film film1 = new Film();
            //sets the film id
            film1.FilmId = 1;
            //refrences the genre id
            film1.GenreId = 1;
            //Refernce to the actor id
            film1.ActorId = 1;
            //Refernce to the actor id
            film1.DirectorId = 1;
            //sets the film name
            film1.FilmName = "Captain Marvel";
            //sets the film description
            film1.FilmDescription = "This is the latest super hero movie. It is part of the Marvel franchise";
            //sets the release date
            film1.ReleaseDate = new DateTime(2019, 01, 01);
            //sets the rating
            film1.Rating = 6;
            //sets the genre type
            film1.GenreType = "Science Fiction";
            //adds film to the context
            context.Films.Add(film1);

            //Intialise the film class
            Film film2 = new Film();
            //sets the film id
            film2.FilmId = 2;
            //refrences the genre id
            film2.GenreId = 1;
            //Refernce to the actor id
            film2.ActorId = 2;
            //Refernce to the actor id
            film2.DirectorId = 2;
            //sets the film name
            film2.FilmName = "Catch Me If You Can";
            //sets the film description
            film2.FilmDescription = "A seasoned FBI agent pursues Frank Abagnale Jr. who, before his 19th birthday, successfully forged millions of dollars' worth of checks while posing as a Pan Am pilot, a doctor, and a legal prosecutor.";
            //sets the release date
            film2.ReleaseDate = new DateTime(2002, 01, 27);
            //sets the rating
            film2.Rating = 6;
            //sets the genre type
            film2.GenreType = "Science Fiction";
            //adds film to the context
            context.Films.Add(film2);

            //Intialise the review class
            Review review1 = new Review();
            //sets director comment id
            review1.ReviewId = 1;
            //references the director id
            review1.FilmId = 1;
            //sets the director comment context
            review1.ReviewContent = "The graphics of the films are amazing!!";
            //sets director comment date added
            review1.ReviewDateAdded = new DateTime(2019, 01, 02);
            //sets the user name
            review1.UserName = "Bob Bartlet";
            //adds the review to the context
            context.Reviews.Add(review1);

            

            //Intialise the gossip class
            Gossip gossip1 = new Gossip();
            //sets the gossip id
            gossip1.GossipId = 1;
            //sets the gossip content
            gossip1.GossipContent = "Brie Larson went on a mystery date";
            //sets the gossip date added
            gossip1.GossipContentDateAdded = new DateTime(2019, 01, 10);
            //sets the user name
            gossip1.UserName = "Bob Bartlet";
            //adds he gossip to the context
            context.Gossips.Add(gossip1);


            base.Seed(context);
        }
    }
}