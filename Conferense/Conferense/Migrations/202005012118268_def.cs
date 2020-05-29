namespace Conferense.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class def : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SetFiles", "UserId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SetFiles", "UserId", c => c.Int(nullable: false));
        }
    }
}
