namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Amigoes", "Birthday");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Amigoes", "Birthday", c => c.DateTime(nullable: false));
        }
    }
}
