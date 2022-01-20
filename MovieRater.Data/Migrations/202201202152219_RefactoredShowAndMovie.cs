namespace MovieRater.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RefactoredShowAndMovie : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Media", "MovieId");
            DropColumn("dbo.Media", "ShowId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Media", "ShowId", c => c.Int());
            AddColumn("dbo.Media", "MovieId", c => c.Int());
        }
    }
}
