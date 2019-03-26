namespace NexusCorpFilmReviews.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteGenreTypeFromFilmModel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Films", "GenreType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Films", "GenreType", c => c.String(maxLength: 50));
        }
    }
}
