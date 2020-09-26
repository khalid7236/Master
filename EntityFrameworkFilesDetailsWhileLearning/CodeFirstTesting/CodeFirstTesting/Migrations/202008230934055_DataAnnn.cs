namespace CodeFirstTesting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnn : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StudentDetails2", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StudentDetails2", "Name", c => c.String());
        }
    }
}
