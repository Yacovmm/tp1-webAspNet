namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelAmigoEdited : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Amigoes", newName: "Amigo");
            AddColumn("dbo.Amigo", "Birthday", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Amigo", "Name", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Amigo", "LastName", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Amigo", "Email", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Amigo", "Email", c => c.String());
            AlterColumn("dbo.Amigo", "LastName", c => c.String());
            AlterColumn("dbo.Amigo", "Name", c => c.String());
            DropColumn("dbo.Amigo", "Birthday");
            RenameTable(name: "dbo.Amigo", newName: "Amigoes");
        }
    }
}
