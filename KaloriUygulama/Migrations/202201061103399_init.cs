namespace KaloriUygulama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Besins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BesinAd = c.String(),
                        Gram = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Kalori = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Yag = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Protein = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Karbonhidrat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BesinResimYolu = c.String(),
                        KategoriId = c.Int(nullable: false),
                        PorsiyonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kategoris", t => t.KategoriId, cascadeDelete: true)
                .ForeignKey("dbo.Porsiyons", t => t.PorsiyonId, cascadeDelete: true)
                .Index(t => t.KategoriId)
                .Index(t => t.PorsiyonId);
            
            CreateTable(
                "dbo.Kategoris",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KategoriAd = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OgunDetays",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adet = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OgunDetayGram = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OgunDetayKalori = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OgunDetayYag = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OgunDetayProtein = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OgunDetayKarbonhidrat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BesinId = c.Int(nullable: false),
                        OgunId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Besins", t => t.BesinId, cascadeDelete: true)
                .ForeignKey("dbo.Oguns", t => t.OgunId, cascadeDelete: true)
                .Index(t => t.BesinId)
                .Index(t => t.OgunId);
            
            CreateTable(
                "dbo.Oguns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.Int(nullable: false),
                        YenmeTarihi = c.DateTime(nullable: false),
                        KullaniciId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kullanicis", t => t.KullaniciId, cascadeDelete: true)
                .Index(t => t.KullaniciId);
            
            CreateTable(
                "dbo.Kullanicis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        Eposta = c.String(),
                        Parola = c.String(),
                        SifreIpucu = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Porsiyons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PorsiyonAd = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Besins", "PorsiyonId", "dbo.Porsiyons");
            DropForeignKey("dbo.OgunDetays", "OgunId", "dbo.Oguns");
            DropForeignKey("dbo.Oguns", "KullaniciId", "dbo.Kullanicis");
            DropForeignKey("dbo.OgunDetays", "BesinId", "dbo.Besins");
            DropForeignKey("dbo.Besins", "KategoriId", "dbo.Kategoris");
            DropIndex("dbo.Oguns", new[] { "KullaniciId" });
            DropIndex("dbo.OgunDetays", new[] { "OgunId" });
            DropIndex("dbo.OgunDetays", new[] { "BesinId" });
            DropIndex("dbo.Besins", new[] { "PorsiyonId" });
            DropIndex("dbo.Besins", new[] { "KategoriId" });
            DropTable("dbo.Porsiyons");
            DropTable("dbo.Kullanicis");
            DropTable("dbo.Oguns");
            DropTable("dbo.OgunDetays");
            DropTable("dbo.Kategoris");
            DropTable("dbo.Besins");
        }
    }
}
