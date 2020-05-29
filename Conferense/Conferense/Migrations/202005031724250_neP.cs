namespace Conferense.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class neP : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.SetInfoes", newName: "SetInfo");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.SetInfos", newName: "SetInfoes");
        }
    }
}
