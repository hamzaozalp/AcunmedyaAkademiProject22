namespace AcunmedyaAkademiProject2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Siparis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderName = c.String(),
                        OrderDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tatlis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SatisSayisi = c.Int(nullable: false),
                        Ad = c.String(),
                        ResimUrl = c.String(),
                        Aciklama = c.String(),
                        Fiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tatlis");
            DropTable("dbo.Siparis");
        }
    }
}
