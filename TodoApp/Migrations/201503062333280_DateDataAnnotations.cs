namespace TodoApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateDataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Todoes", "Priority", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Todoes", "Priority", c => c.String());
        }
    }
}
