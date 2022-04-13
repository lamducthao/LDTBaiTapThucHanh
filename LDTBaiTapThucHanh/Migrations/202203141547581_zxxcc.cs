namespace LDTBaiTapThucHanh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zxxcc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DonHangs",
                c => new
                    {
                        ThemSP = c.String(nullable: false, maxLength: 128),
                        XoaSP = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ThemSP);
            
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        TenKH = c.String(nullable: false, maxLength: 128),
                        MaKH = c.String(nullable: false),
                        GioiTinh = c.String(nullable: false),
                        DiaChi = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Sdt = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TenKH);
            
            CreateTable(
                "dbo.SanPhams",
                c => new
                    {
                        TenSp = c.String(nullable: false, maxLength: 128),
                        MaSp = c.String(nullable: false),
                        SoLUONG = c.String(nullable: false),
                        NgaySanSuat = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TenSp);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SanPhams");
            DropTable("dbo.KhachHangs");
            DropTable("dbo.DonHangs");
        }
    }
}
