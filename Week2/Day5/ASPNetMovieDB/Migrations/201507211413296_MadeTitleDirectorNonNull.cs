namespace ASPNetMovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeTitleDirectorNonNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "Director", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Director", c => c.String());
            AlterColumn("dbo.Movies", "Title", c => c.String());
        }
    }
}
