namespace Conferense.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class n : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SetInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        data1 = c.String(),
                        data2 = c.String(),
                        data3 = c.String(),
                        data4 = c.String(),
                        data5 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SetInfoes");
        }
    }
}
