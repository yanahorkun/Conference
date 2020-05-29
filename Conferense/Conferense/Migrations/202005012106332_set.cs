namespace Conferense.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class set : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SetFiles", "Name", c => c.String());
            AlterColumn("dbo.SetFiles", "File", c => c.Binary());
           
        }
        
        public override void Down()
        {
            AddColumn("dbo.SetFiles", "FILEURL", c => c.String());
            AddColumn("dbo.SetFiles", "FILINAME", c => c.String());
            AlterColumn("dbo.SetFiles", "File", c => c.String());
            DropColumn("dbo.SetFiles", "Name");
        }
    }
}
