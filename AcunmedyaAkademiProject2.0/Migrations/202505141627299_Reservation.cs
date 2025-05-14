namespace AcunmedyaAkademiProject2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Reservation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationId = c.Int(nullable: false, identity: true),
                        ReservationName = c.String(),
                        ReservationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReservationId);
            
            DropTable("dbo.Siparis");
            DropTable("dbo.Tatlis");
        }
        
        public override void Down()
        {
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
            
            CreateTable(
                "dbo.Siparis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderName = c.String(),
                        OrderDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Reservations");
        }
    }
}
