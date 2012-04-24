namespace Jabbot.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "HostedSprockets",
                c => new
                    {
                        HostedSprocketId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.HostedSprocketId);
            
            CreateTable(
                "Settings",
                c => new
                    {
                        SettingId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Value = c.String(),
                        Sprocket_HostedSprocketId = c.Int(),
                    })
                .PrimaryKey(t => t.SettingId)
                .ForeignKey("HostedSprockets", t => t.Sprocket_HostedSprocketId)
                .Index(t => t.Sprocket_HostedSprocketId);
            
        }
        
        public override void Down()
        {
            DropIndex("Settings", new[] { "Sprocket_HostedSprocketId" });
            DropForeignKey("Settings", "Sprocket_HostedSprocketId", "HostedSprockets");
            DropTable("Settings");
            DropTable("HostedSprockets");
        }
    }
}
