﻿namespace LeThiHuyen995_DATN.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangModels : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_News", "Alias", c => c.String(maxLength: 150));
            AlterColumn("dbo.tb_News", "Image", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_News", "SeoTitle", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_News", "SeoDescription", c => c.String(maxLength: 500));
            AlterColumn("dbo.tb_News", "SeoKeywords", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Posts", "Alias", c => c.String(maxLength: 150));
            AlterColumn("dbo.tb_Posts", "Image", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Posts", "SeoTitle", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Posts", "SeoDescription", c => c.String(maxLength: 500));
            AlterColumn("dbo.tb_Posts", "SeoKeywords", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Product", "Alias", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Product", "ProductCode", c => c.String(maxLength: 50));
            AlterColumn("dbo.tb_Product", "Image", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Product", "SeoTitle", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Product", "SeoKeywords", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_ProductCategory", "SeoTitle", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_ProductCategory", "SeoDescription", c => c.String(maxLength: 500));
            AlterColumn("dbo.tb_ProductCategory", "SeoKeywords", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_ProductCategory", "SeoKeywords", c => c.String());
            AlterColumn("dbo.tb_ProductCategory", "SeoDescription", c => c.String());
            AlterColumn("dbo.tb_ProductCategory", "SeoTitle", c => c.String());
            AlterColumn("dbo.tb_Product", "SeoKeywords", c => c.String());
            AlterColumn("dbo.tb_Product", "SeoTitle", c => c.String());
            AlterColumn("dbo.tb_Product", "Image", c => c.String());
            AlterColumn("dbo.tb_Product", "ProductCode", c => c.String());
            AlterColumn("dbo.tb_Product", "Alias", c => c.String());
            AlterColumn("dbo.tb_Posts", "SeoKeywords", c => c.String());
            AlterColumn("dbo.tb_Posts", "SeoDescription", c => c.String());
            AlterColumn("dbo.tb_Posts", "SeoTitle", c => c.String());
            AlterColumn("dbo.tb_Posts", "Image", c => c.String());
            AlterColumn("dbo.tb_Posts", "Alias", c => c.String());
            AlterColumn("dbo.tb_News", "SeoKeywords", c => c.String());
            AlterColumn("dbo.tb_News", "SeoDescription", c => c.String());
            AlterColumn("dbo.tb_News", "SeoTitle", c => c.String());
            AlterColumn("dbo.tb_News", "Image", c => c.String());
            AlterColumn("dbo.tb_News", "Alias", c => c.String());
        }
    }
}
