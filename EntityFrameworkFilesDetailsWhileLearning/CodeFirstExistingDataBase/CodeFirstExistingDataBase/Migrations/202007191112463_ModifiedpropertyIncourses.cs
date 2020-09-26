namespace CodeFirstExistingDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedpropertyIncourses : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Name", c => c.String(nullable : false));
            Sql("Update Courses Set Name = Title");
            DropColumn("dbo.Courses", "Title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Title", c => c.String(nullable: false));
            Sql("Update Courses Set Title = Name");
            DropColumn("dbo.Courses", "Name");
        }
    }
}
