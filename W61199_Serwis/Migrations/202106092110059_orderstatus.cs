namespace W61199_Serwis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class orderstatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Repairs", "Status", c => c.Short(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Repairs", "Status");
        }
    }
}
