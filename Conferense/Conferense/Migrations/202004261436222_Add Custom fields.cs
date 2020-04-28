namespace Conferense.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomfields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Status", c => c.String());
            AddColumn("dbo.AspNetUsers", "FullName", c => c.String());
            AddColumn("dbo.AspNetUsers", "Job_Education", c => c.String());
            AddColumn("dbo.AspNetUsers", "Scientist", c => c.String());
            AddColumn("dbo.AspNetUsers", "Participation", c => c.String());
            AddColumn("dbo.AspNetUsers", "Degree", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Degree");
            DropColumn("dbo.AspNetUsers", "Participation");
            DropColumn("dbo.AspNetUsers", "Scientist");
            DropColumn("dbo.AspNetUsers", "Job_Education");
            DropColumn("dbo.AspNetUsers", "FullName");
            DropColumn("dbo.AspNetUsers", "Status");
        }
    }
}
