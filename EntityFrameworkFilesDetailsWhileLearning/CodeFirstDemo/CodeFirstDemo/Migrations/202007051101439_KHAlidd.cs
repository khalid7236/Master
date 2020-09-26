namespace CodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KHAlidd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StudentDetails2", "Names", c => c.String());
            DropColumn("dbo.StudentDetails2", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StudentDetails2", "Name", c => c.String());
            DropColumn("dbo.StudentDetails2", "Names");
        }
    }
}
