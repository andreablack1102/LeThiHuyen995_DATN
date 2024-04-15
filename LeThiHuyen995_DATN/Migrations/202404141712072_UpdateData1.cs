namespace LeThiHuyen995_DATN.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Adv", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Adv", "ModifiedBy", c => c.String());
            AddColumn("dbo.tb_Category", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Category", "ModifiedBy", c => c.String());
            AddColumn("dbo.tb_News", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_News", "ModifiedBy", c => c.String());
            AddColumn("dbo.tb_Posts", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Posts", "ModifiedBy", c => c.String());
            AddColumn("dbo.tb_Contact", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Contact", "ModifiedBy", c => c.String());
            AddColumn("dbo.tb_Order", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Order", "ModifiedBy", c => c.String());
            AddColumn("dbo.tb_Product", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Product", "ModifiedBy", c => c.String());
            AddColumn("dbo.tb_ProductCategory", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_ProductCategory", "ModifiedBy", c => c.String());
            DropColumn("dbo.tb_Adv", "ModifierDate");
            DropColumn("dbo.tb_Adv", "ModifierBy");
            DropColumn("dbo.tb_Category", "ModifierDate");
            DropColumn("dbo.tb_Category", "ModifierBy");
            DropColumn("dbo.tb_News", "ModifierDate");
            DropColumn("dbo.tb_News", "ModifierBy");
            DropColumn("dbo.tb_Posts", "ModifierDate");
            DropColumn("dbo.tb_Posts", "ModifierBy");
            DropColumn("dbo.tb_Contact", "ModifierDate");
            DropColumn("dbo.tb_Contact", "ModifierBy");
            DropColumn("dbo.tb_Order", "ModifierDate");
            DropColumn("dbo.tb_Order", "ModifierBy");
            DropColumn("dbo.tb_Product", "ModifierDate");
            DropColumn("dbo.tb_Product", "ModifierBy");
            DropColumn("dbo.tb_ProductCategory", "ModifierDate");
            DropColumn("dbo.tb_ProductCategory", "ModifierBy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_ProductCategory", "ModifierBy", c => c.String());
            AddColumn("dbo.tb_ProductCategory", "ModifierDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Product", "ModifierBy", c => c.String());
            AddColumn("dbo.tb_Product", "ModifierDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Order", "ModifierBy", c => c.String());
            AddColumn("dbo.tb_Order", "ModifierDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Contact", "ModifierBy", c => c.String());
            AddColumn("dbo.tb_Contact", "ModifierDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Posts", "ModifierBy", c => c.String());
            AddColumn("dbo.tb_Posts", "ModifierDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_News", "ModifierBy", c => c.String());
            AddColumn("dbo.tb_News", "ModifierDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Category", "ModifierBy", c => c.String());
            AddColumn("dbo.tb_Category", "ModifierDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Adv", "ModifierBy", c => c.String());
            AddColumn("dbo.tb_Adv", "ModifierDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.tb_ProductCategory", "ModifiedBy");
            DropColumn("dbo.tb_ProductCategory", "ModifiedDate");
            DropColumn("dbo.tb_Product", "ModifiedBy");
            DropColumn("dbo.tb_Product", "ModifiedDate");
            DropColumn("dbo.tb_Order", "ModifiedBy");
            DropColumn("dbo.tb_Order", "ModifiedDate");
            DropColumn("dbo.tb_Contact", "ModifiedBy");
            DropColumn("dbo.tb_Contact", "ModifiedDate");
            DropColumn("dbo.tb_Posts", "ModifiedBy");
            DropColumn("dbo.tb_Posts", "ModifiedDate");
            DropColumn("dbo.tb_News", "ModifiedBy");
            DropColumn("dbo.tb_News", "ModifiedDate");
            DropColumn("dbo.tb_Category", "ModifiedBy");
            DropColumn("dbo.tb_Category", "ModifiedDate");
            DropColumn("dbo.tb_Adv", "ModifiedBy");
            DropColumn("dbo.tb_Adv", "ModifiedDate");
        }
    }
}
