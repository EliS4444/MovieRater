namespace MovieRater.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedMediaParentObject : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Media", "Title", c => c.String(nullable: false));
            AddColumn("dbo.Media", "MovieId", c => c.Int());
            AddColumn("dbo.Media", "ShowId", c => c.Int());
            AlterColumn("dbo.Media", "CreatedUtc", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.Media", "Description", c => c.String(nullable: false));
            DropColumn("dbo.Media", "MovieName");
            DropColumn("dbo.Media", "MovieDescription");
            DropColumn("dbo.Media", "ShowName");
            DropColumn("dbo.Media", "CreatedUtc1");
            DropColumn("dbo.Media", "ModifiedUtc1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Media", "ModifiedUtc1", c => c.DateTimeOffset(precision: 7));
            AddColumn("dbo.Media", "CreatedUtc1", c => c.DateTimeOffset(precision: 7));
            AddColumn("dbo.Media", "ShowName", c => c.String());
            AddColumn("dbo.Media", "MovieDescription", c => c.String());
            AddColumn("dbo.Media", "MovieName", c => c.String());
            AlterColumn("dbo.Media", "Description", c => c.String());
            AlterColumn("dbo.Media", "CreatedUtc", c => c.DateTimeOffset(precision: 7));
            DropColumn("dbo.Media", "ShowId");
            DropColumn("dbo.Media", "MovieId");
            DropColumn("dbo.Media", "Title");
        }
    }
}
