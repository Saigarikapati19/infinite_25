namespace Codechallenge8._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Directorname", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Directorname");
        }
    }
}
