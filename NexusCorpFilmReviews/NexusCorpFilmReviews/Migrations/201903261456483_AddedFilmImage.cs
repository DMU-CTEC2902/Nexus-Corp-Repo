namespace NexusCorpFilmReviews.Migrations
{
    //using System;
    //using System.Data.Entity.Migrations;
    
    //public partial class AddedFilmImage : DbMigration
    //{
    //    public override void Up()
    //    {
    //        CreateTable(
    //            "dbo.ActorComments",
    //            c => new
    //                {
    //                    ActorCommentId = c.Int(nullable: false, identity: true),
    //                    ActorId = c.Int(nullable: false),
    //                    ActorCommentContent = c.String(maxLength: 200),
    //                    ActorCommentDateAdded = c.DateTime(nullable: false),
    //                    UserName = c.String(),
    //                })
    //            .PrimaryKey(t => t.ActorCommentId)
    //            .ForeignKey("dbo.Actors", t => t.ActorId, cascadeDelete: true)
    //            .Index(t => t.ActorId);
            
    //        CreateTable(
    //            "dbo.Actors",
    //            c => new
    //                {
    //                    ActorId = c.Int(nullable: false, identity: true),
    //                    ActorFirstName = c.String(maxLength: 50),
    //                    ActorLastName = c.String(maxLength: 50),
    //                    ActorDOB = c.DateTime(nullable: false),
    //                    ActorAge = c.Int(nullable: false),
    //                    ActorGender = c.String(maxLength: 15),
    //                })
    //            .PrimaryKey(t => t.ActorId);
            
    //        CreateTable(
    //            "dbo.DirectorComments",
    //            c => new
    //                {
    //                    DirectorCommentId = c.Int(nullable: false, identity: true),
    //                    DirectorId = c.Int(nullable: false),
    //                    DirectorCommentContent = c.String(maxLength: 200),
    //                    DirectorCommentDateAdded = c.DateTime(nullable: false),
    //                    UserName = c.String(maxLength: 50),
    //                })
    //            .PrimaryKey(t => t.DirectorCommentId)
    //            .ForeignKey("dbo.Directors", t => t.DirectorId, cascadeDelete: true)
    //            .Index(t => t.DirectorId);
            
    //        CreateTable(
    //            "dbo.Directors",
    //            c => new
    //                {
    //                    DirectorId = c.Int(nullable: false, identity: true),
    //                    DirectorFirstName = c.String(maxLength: 50),
    //                    DirectorLastName = c.String(maxLength: 50),
    //                    DirectorDOB = c.DateTime(nullable: false),
    //                    DirectorAge = c.Int(nullable: false),
    //                    DirectorGender = c.String(maxLength: 15),
    //                })
    //            .PrimaryKey(t => t.DirectorId);
            
    //        CreateTable(
    //            "dbo.Films",
    //            c => new
    //                {
    //                    FilmId = c.Int(nullable: false, identity: true),
    //                    GenreId = c.Int(nullable: false),
    //                    ActorId = c.Int(nullable: false),
    //                    DirectorId = c.Int(nullable: false),
    //                    FilmName = c.String(nullable: false),
    //                    FilmDescription = c.String(maxLength: 500),
    //                    ReleaseDate = c.DateTime(nullable: false),
    //                    Rating = c.Int(nullable: false),
    //                    FilmImage = c.String(),
    //                    GenreType = c.String(maxLength: 50),
    //                    UserName = c.String(maxLength: 20),
    //                })
    //            .PrimaryKey(t => t.FilmId)
    //            .ForeignKey("dbo.Actors", t => t.ActorId, cascadeDelete: true)
    //            .ForeignKey("dbo.Directors", t => t.DirectorId, cascadeDelete: true)
    //            .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
    //            .Index(t => t.GenreId)
    //            .Index(t => t.ActorId)
    //            .Index(t => t.DirectorId);
            
    //        CreateTable(
    //            "dbo.Genres",
    //            c => new
    //                {
    //                    GenreId = c.Int(nullable: false, identity: true),
    //                    GenreType = c.String(maxLength: 50),
    //                })
    //            .PrimaryKey(t => t.GenreId);
            
    //        CreateTable(
    //            "dbo.Gossips",
    //            c => new
    //                {
    //                    GossipId = c.Int(nullable: false, identity: true),
    //                    GossipContent = c.String(maxLength: 500),
    //                    GossipContentDateAdded = c.DateTime(nullable: false),
    //                    UserName = c.String(maxLength: 50),
    //                })
    //            .PrimaryKey(t => t.GossipId);
            
    //        CreateTable(
    //            "dbo.Reviews",
    //            c => new
    //                {
    //                    ReviewId = c.Int(nullable: false, identity: true),
    //                    FilmId = c.Int(nullable: false),
    //                    ReviewContent = c.String(maxLength: 500),
    //                    ReviewDateAdded = c.DateTime(nullable: false),
    //                    UserName = c.String(maxLength: 50),
    //                })
    //            .PrimaryKey(t => t.ReviewId)
    //            .ForeignKey("dbo.Films", t => t.FilmId, cascadeDelete: true)
    //            .Index(t => t.FilmId);
            
    //    }
        
    //    public override void Down()
    //    {
    //        DropForeignKey("dbo.Reviews", "FilmId", "dbo.Films");
    //        DropForeignKey("dbo.Films", "GenreId", "dbo.Genres");
    //        DropForeignKey("dbo.Films", "DirectorId", "dbo.Directors");
    //        DropForeignKey("dbo.Films", "ActorId", "dbo.Actors");
    //        DropForeignKey("dbo.DirectorComments", "DirectorId", "dbo.Directors");
    //        DropForeignKey("dbo.ActorComments", "ActorId", "dbo.Actors");
    //        DropIndex("dbo.Reviews", new[] { "FilmId" });
    //        DropIndex("dbo.Films", new[] { "DirectorId" });
    //        DropIndex("dbo.Films", new[] { "ActorId" });
    //        DropIndex("dbo.Films", new[] { "GenreId" });
    //        DropIndex("dbo.DirectorComments", new[] { "DirectorId" });
    //        DropIndex("dbo.ActorComments", new[] { "ActorId" });
    //        DropTable("dbo.Reviews");
    //        DropTable("dbo.Gossips");
    //        DropTable("dbo.Genres");
    //        DropTable("dbo.Films");
    //        DropTable("dbo.Directors");
    //        DropTable("dbo.DirectorComments");
    //        DropTable("dbo.Actors");
    //        DropTable("dbo.ActorComments");
    //    }
    //}
}
