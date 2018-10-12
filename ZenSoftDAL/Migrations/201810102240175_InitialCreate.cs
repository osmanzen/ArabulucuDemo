namespace ZenSoftDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buro",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        AdSoyad = c.String(),
                        TcKimlikNo = c.String(),
                        SicilNo = c.String(),
                        Adres = c.String(),
                        EPosta = c.String(),
                        VergiNumarsi = c.String(),
                        KomisyonIl = c.String(),
                        KomisyonIlce = c.String(),
                        AktifMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Dava",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        BuroID = c.Guid(),
                        BuroDosyaNo = c.String(),
                        ArabuluculukDosyaNo = c.String(),
                        ArabuluculukBurosu = c.String(),
                        CalisilanYer = c.String(),
                        BasvuruTarihi = c.DateTime(),
                        BitisTarihi = c.DateTime(),
                        BasvurucuID = c.Guid(),
                        BasvurucuVekilID = c.Guid(),
                        BasvurucuNot = c.String(),
                        Durum = c.String(),
                        Sonuc = c.String(),
                        AktifMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Taraf", t => t.BasvurucuID)
                .ForeignKey("dbo.Vekil", t => t.BasvurucuVekilID)
                .ForeignKey("dbo.Buro", t => t.BuroID)
                .Index(t => t.BuroID)
                .Index(t => t.BasvurucuID)
                .Index(t => t.BasvurucuVekilID);
            
            CreateTable(
                "dbo.Taraf",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        TCKimlikNo = c.String(),
                        TarafAdi = c.String(),
                        Adres = c.String(),
                        KisiSirketKurum = c.Int(),
                        Eposta = c.String(),
                        AktifMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.KarsiTaraf",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        TarafID = c.Guid(),
                        VekilID = c.Guid(),
                        DavaID = c.Guid(),
                        KarsiTarafNot = c.String(),
                        YetkiliID = c.Guid(),
                        AktifMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Dava", t => t.DavaID)
                .ForeignKey("dbo.Taraf", t => t.TarafID)
                .ForeignKey("dbo.Vekil", t => t.VekilID)
                .ForeignKey("dbo.SirketYetkilisi", t => t.YetkiliID)
                .Index(t => t.TarafID)
                .Index(t => t.VekilID)
                .Index(t => t.DavaID)
                .Index(t => t.YetkiliID);
            
            CreateTable(
                "dbo.Heyet",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        AdiSoyadi = c.String(),
                        TCKimlikNo = c.String(),
                        Görevi = c.String(),
                        AktifMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Vekil",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        SicilNo = c.String(),
                        AdiSoyadi = c.String(),
                        Adres = c.String(),
                        Eposta = c.String(),
                        BuroIl = c.String(),
                        BuroIlce = c.String(),
                        WebAdresi = c.String(),
                        TCKimlikNo = c.String(),
                        AktifMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TelefonBilgileri",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Numara = c.String(),
                        SabitCepFax = c.Int(),
                        BuroID = c.Guid(),
                        TarafID = c.Guid(),
                        VekilID = c.Guid(),
                        AktifMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Buro", t => t.BuroID)
                .ForeignKey("dbo.Taraf", t => t.TarafID)
                .ForeignKey("dbo.Vekil", t => t.VekilID)
                .Index(t => t.BuroID)
                .Index(t => t.TarafID)
                .Index(t => t.VekilID);
            
            CreateTable(
                "dbo.SirketYetkilisi",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        TCKimlikNo = c.String(),
                        YetkiliAdi = c.String(),
                        Gorevi = c.String(),
                        AktifMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DavaKonusu",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        DavaTuruID = c.Guid(),
                        KonuAdi = c.String(),
                        AktifMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.DavaTuru", t => t.DavaTuruID)
                .Index(t => t.DavaTuruID);
            
            CreateTable(
                "dbo.DavaTuru",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        TurAdi = c.String(),
                        AktifMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Gorusme",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        GorusmeTarihi = c.DateTime(),
                        DavaID = c.Guid(),
                        GorusmeAdi = c.String(),
                        Aciklama = c.String(),
                        GorusmeVeri = c.String(),
                        GorusmeYapildi = c.Boolean(nullable: false),
                        AktifMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Dava", t => t.DavaID)
                .Index(t => t.DavaID);
            
            CreateTable(
                "dbo.HesapBilgileri",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        BankaAdi = c.String(),
                        SubeAdi = c.String(),
                        IBAN = c.String(),
                        BuroID = c.Guid(),
                        AktifMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Buro", t => t.BuroID)
                .Index(t => t.BuroID);
            
            CreateTable(
                "dbo.KarsiTarafHeyetleri",
                c => new
                    {
                        KarsiTarafID = c.Guid(nullable: false),
                        HeyetID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.KarsiTarafID, t.HeyetID })
                .ForeignKey("dbo.KarsiTaraf", t => t.KarsiTarafID, cascadeDelete: true)
                .ForeignKey("dbo.Heyet", t => t.HeyetID, cascadeDelete: true)
                .Index(t => t.KarsiTarafID)
                .Index(t => t.HeyetID);
            
            CreateTable(
                "dbo.IlgiliKurumlar",
                c => new
                    {
                        TarafID = c.Guid(nullable: false),
                        KarsiTarafID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.TarafID, t.KarsiTarafID })
                .ForeignKey("dbo.Taraf", t => t.TarafID, cascadeDelete: true)
                .ForeignKey("dbo.KarsiTaraf", t => t.KarsiTarafID, cascadeDelete: true)
                .Index(t => t.TarafID)
                .Index(t => t.KarsiTarafID);
            
            CreateTable(
                "dbo.TarafVekilleri",
                c => new
                    {
                        TarafID = c.Guid(nullable: false),
                        VekilID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.TarafID, t.VekilID })
                .ForeignKey("dbo.Taraf", t => t.TarafID, cascadeDelete: true)
                .ForeignKey("dbo.Vekil", t => t.VekilID, cascadeDelete: true)
                .Index(t => t.TarafID)
                .Index(t => t.VekilID);
            
            CreateTable(
                "dbo.DavaninKonulari",
                c => new
                    {
                        DavaKonuID = c.Guid(nullable: false),
                        DavaID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.DavaKonuID, t.DavaID })
                .ForeignKey("dbo.Dava", t => t.DavaKonuID, cascadeDelete: true)
                .ForeignKey("dbo.DavaKonusu", t => t.DavaID, cascadeDelete: true)
                .Index(t => t.DavaKonuID)
                .Index(t => t.DavaID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HesapBilgileri", "BuroID", "dbo.Buro");
            DropForeignKey("dbo.Gorusme", "DavaID", "dbo.Dava");
            DropForeignKey("dbo.DavaninKonulari", "DavaID", "dbo.DavaKonusu");
            DropForeignKey("dbo.DavaninKonulari", "DavaKonuID", "dbo.Dava");
            DropForeignKey("dbo.DavaKonusu", "DavaTuruID", "dbo.DavaTuru");
            DropForeignKey("dbo.Dava", "BuroID", "dbo.Buro");
            DropForeignKey("dbo.Dava", "BasvurucuVekilID", "dbo.Vekil");
            DropForeignKey("dbo.Dava", "BasvurucuID", "dbo.Taraf");
            DropForeignKey("dbo.TarafVekilleri", "VekilID", "dbo.Vekil");
            DropForeignKey("dbo.TarafVekilleri", "TarafID", "dbo.Taraf");
            DropForeignKey("dbo.IlgiliKurumlar", "KarsiTarafID", "dbo.KarsiTaraf");
            DropForeignKey("dbo.IlgiliKurumlar", "TarafID", "dbo.Taraf");
            DropForeignKey("dbo.KarsiTaraf", "YetkiliID", "dbo.SirketYetkilisi");
            DropForeignKey("dbo.KarsiTaraf", "VekilID", "dbo.Vekil");
            DropForeignKey("dbo.TelefonBilgileri", "VekilID", "dbo.Vekil");
            DropForeignKey("dbo.TelefonBilgileri", "TarafID", "dbo.Taraf");
            DropForeignKey("dbo.TelefonBilgileri", "BuroID", "dbo.Buro");
            DropForeignKey("dbo.KarsiTaraf", "TarafID", "dbo.Taraf");
            DropForeignKey("dbo.KarsiTarafHeyetleri", "HeyetID", "dbo.Heyet");
            DropForeignKey("dbo.KarsiTarafHeyetleri", "KarsiTarafID", "dbo.KarsiTaraf");
            DropForeignKey("dbo.KarsiTaraf", "DavaID", "dbo.Dava");
            DropIndex("dbo.DavaninKonulari", new[] { "DavaID" });
            DropIndex("dbo.DavaninKonulari", new[] { "DavaKonuID" });
            DropIndex("dbo.TarafVekilleri", new[] { "VekilID" });
            DropIndex("dbo.TarafVekilleri", new[] { "TarafID" });
            DropIndex("dbo.IlgiliKurumlar", new[] { "KarsiTarafID" });
            DropIndex("dbo.IlgiliKurumlar", new[] { "TarafID" });
            DropIndex("dbo.KarsiTarafHeyetleri", new[] { "HeyetID" });
            DropIndex("dbo.KarsiTarafHeyetleri", new[] { "KarsiTarafID" });
            DropIndex("dbo.HesapBilgileri", new[] { "BuroID" });
            DropIndex("dbo.Gorusme", new[] { "DavaID" });
            DropIndex("dbo.DavaKonusu", new[] { "DavaTuruID" });
            DropIndex("dbo.TelefonBilgileri", new[] { "VekilID" });
            DropIndex("dbo.TelefonBilgileri", new[] { "TarafID" });
            DropIndex("dbo.TelefonBilgileri", new[] { "BuroID" });
            DropIndex("dbo.KarsiTaraf", new[] { "YetkiliID" });
            DropIndex("dbo.KarsiTaraf", new[] { "DavaID" });
            DropIndex("dbo.KarsiTaraf", new[] { "VekilID" });
            DropIndex("dbo.KarsiTaraf", new[] { "TarafID" });
            DropIndex("dbo.Dava", new[] { "BasvurucuVekilID" });
            DropIndex("dbo.Dava", new[] { "BasvurucuID" });
            DropIndex("dbo.Dava", new[] { "BuroID" });
            DropTable("dbo.DavaninKonulari");
            DropTable("dbo.TarafVekilleri");
            DropTable("dbo.IlgiliKurumlar");
            DropTable("dbo.KarsiTarafHeyetleri");
            DropTable("dbo.HesapBilgileri");
            DropTable("dbo.Gorusme");
            DropTable("dbo.DavaTuru");
            DropTable("dbo.DavaKonusu");
            DropTable("dbo.SirketYetkilisi");
            DropTable("dbo.TelefonBilgileri");
            DropTable("dbo.Vekil");
            DropTable("dbo.Heyet");
            DropTable("dbo.KarsiTaraf");
            DropTable("dbo.Taraf");
            DropTable("dbo.Dava");
            DropTable("dbo.Buro");
        }
    }
}
