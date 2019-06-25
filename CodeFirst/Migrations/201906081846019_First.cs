namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItirafAlkislari",
                c => new
                    {
                        AlkisID = c.Int(nullable: false, identity: true),
                        AlkisiYapanUyeID = c.Int(nullable: false),
                        AlkisiAlanItirafID = c.Int(nullable: false),
                        AlkisTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AlkisID)
                .ForeignKey("dbo.Itiraflar", t => t.AlkisiAlanItirafID)
                .ForeignKey("dbo.Uyeler", t => t.AlkisiYapanUyeID)
                .Index(t => t.AlkisiYapanUyeID)
                .Index(t => t.AlkisiAlanItirafID);
            
            CreateTable(
                "dbo.Itiraflar",
                c => new
                    {
                        ItirafID = c.Int(nullable: false, identity: true),
                        ItirafBaslik = c.String(nullable: false, maxLength: 150),
                        ItirafMetin = c.String(nullable: false, maxLength: 1500),
                        ItirafTarihi = c.DateTime(),
                        ItirafiYapanUyeID = c.Int(nullable: false),
                        ItirafinKategorisiID = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ItirafID)
                .ForeignKey("dbo.Kategoriler", t => t.ItirafinKategorisiID)
                .ForeignKey("dbo.Uyeler", t => t.ItirafiYapanUyeID)
                .Index(t => t.ItirafiYapanUyeID)
                .Index(t => t.ItirafinKategorisiID);
            
            CreateTable(
                "dbo.Kategoriler",
                c => new
                    {
                        KategoriID = c.Byte(nullable: false),
                        KategoriAdi = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.KategoriID);
            
            CreateTable(
                "dbo.Uyeler",
                c => new
                    {
                        UyeID = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(nullable: false, maxLength: 250),
                        Sifre = c.String(nullable: false, maxLength: 16, fixedLength: true, unicode: false),
                        DogumTarihi = c.DateTime(),
                        UyeninSehriID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UyeID)
                .ForeignKey("dbo.Sehirler", t => t.UyeninSehriID)
                .Index(t => t.UyeninSehriID);
            
            CreateTable(
                "dbo.Sehirler",
                c => new
                    {
                        SehirID = c.Int(nullable: false, identity: true),
                        SehirAdi = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.SehirID);
            
            CreateTable(
                "dbo.Yorumlar",
                c => new
                    {
                        YorumID = c.Int(nullable: false, identity: true),
                        YorumMetni = c.String(nullable: false, maxLength: 350),
                        YorumYapanUyeID = c.Int(nullable: false),
                        YorumAlanItirafID = c.Int(nullable: false),
                        YorumTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.YorumID)
                .ForeignKey("dbo.Uyeler", t => t.YorumYapanUyeID)
                .ForeignKey("dbo.Itiraflar", t => t.YorumAlanItirafID)
                .Index(t => t.YorumYapanUyeID)
                .Index(t => t.YorumAlanItirafID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItirafAlkislari", "AlkisiYapanUyeID", "dbo.Uyeler");
            DropForeignKey("dbo.ItirafAlkislari", "AlkisiAlanItirafID", "dbo.Itiraflar");
            DropForeignKey("dbo.Yorumlar", "YorumAlanItirafID", "dbo.Itiraflar");
            DropForeignKey("dbo.Itiraflar", "ItirafiYapanUyeID", "dbo.Uyeler");
            DropForeignKey("dbo.Yorumlar", "YorumYapanUyeID", "dbo.Uyeler");
            DropForeignKey("dbo.Uyeler", "UyeninSehriID", "dbo.Sehirler");
            DropForeignKey("dbo.Itiraflar", "ItirafinKategorisiID", "dbo.Kategoriler");
            DropIndex("dbo.Yorumlar", new[] { "YorumAlanItirafID" });
            DropIndex("dbo.Yorumlar", new[] { "YorumYapanUyeID" });
            DropIndex("dbo.Uyeler", new[] { "UyeninSehriID" });
            DropIndex("dbo.Itiraflar", new[] { "ItirafinKategorisiID" });
            DropIndex("dbo.Itiraflar", new[] { "ItirafiYapanUyeID" });
            DropIndex("dbo.ItirafAlkislari", new[] { "AlkisiAlanItirafID" });
            DropIndex("dbo.ItirafAlkislari", new[] { "AlkisiYapanUyeID" });
            DropTable("dbo.Yorumlar");
            DropTable("dbo.Sehirler");
            DropTable("dbo.Uyeler");
            DropTable("dbo.Kategoriler");
            DropTable("dbo.Itiraflar");
            DropTable("dbo.ItirafAlkislari");
        }
    }
}
