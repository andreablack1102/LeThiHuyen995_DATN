namespace LeThiHuyen995_DATN.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeAdv : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Adv", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Adv", "Description", c => c.String(maxLength: 500));
        }
    }
}
