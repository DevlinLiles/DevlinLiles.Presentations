namespace Infrastructure.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddAssignToOnActivity : DbMigration
    {
        public override void Up()
        {
            AddColumn("Activities", "AssignedTo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("Activities", "AssignedTo");
        }
    }
}
