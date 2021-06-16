namespace W61199_Serwis.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class zer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Repairs",
                c => new
                    {
                        RepairId = c.Int(nullable: false, identity: true),
                        DeviceId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Note = c.String(),
                        Costs = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.RepairId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Devices", t => t.DeviceId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.DeviceId)
                .Index(t => t.UserId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Devices",
                c => new
                    {
                        DeviceId = c.Int(nullable: false, identity: true),
                        Producer = c.String(),
                        Model = c.String(),
                        SerialNumber = c.String(),
                    })
                .PrimaryKey(t => t.DeviceId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Repairs", "UserId", "dbo.Users");
            DropForeignKey("dbo.Repairs", "DeviceId", "dbo.Devices");
            DropForeignKey("dbo.Repairs", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Repairs", new[] { "CustomerId" });
            DropIndex("dbo.Repairs", new[] { "UserId" });
            DropIndex("dbo.Repairs", new[] { "DeviceId" });
            DropTable("dbo.Users");
            DropTable("dbo.Devices");
            DropTable("dbo.Repairs");
            DropTable("dbo.Customers");
        }
    }
}
