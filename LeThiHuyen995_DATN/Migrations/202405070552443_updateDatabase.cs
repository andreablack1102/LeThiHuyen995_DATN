namespace LeThiHuyen995_DATN.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Order", "TypePayment", c => c.Int(nullable: false));
            DropColumn("dbo.tb_Product", "IsFeature");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Product", "IsFeature", c => c.Boolean(nullable: false));
            DropColumn("dbo.tb_Order", "TypePayment");
        }
    }
}
