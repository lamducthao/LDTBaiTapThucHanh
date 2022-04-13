namespace LDTBaiTapThucHanh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aqwx : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KhoHangs",
                c => new
                    {
                        ThemSP = c.String(nullable: false, maxLength: 128),
                        XoaSP = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ThemSP);
            
            DropTable("dbo.Employees");
            DropTable("dbo.People");
            DropTable("dbo.Students");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        MaStudent = c.String(nullable: false, maxLength: 128),
                        TenStudent = c.String(),
                    })
                .PrimaryKey(t => t.MaStudent);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonID = c.String(nullable: false, maxLength: 128),
                        PersonName = c.String(),
                    })
                .PrimaryKey(t => t.PersonID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.String(nullable: false, maxLength: 128),
                        EmployeeName = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
            DropTable("dbo.KhoHangs");
        }
    }
}
