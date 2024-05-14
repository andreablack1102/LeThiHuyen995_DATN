namespace LeThiHuyen995_DATN.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateSubcribe1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Subscribe", "CreatedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.tb_Subscribe", "CreatedTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Subscribe", "CreatedTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.tb_Subscribe", "CreatedDate");
        }
    }
}
