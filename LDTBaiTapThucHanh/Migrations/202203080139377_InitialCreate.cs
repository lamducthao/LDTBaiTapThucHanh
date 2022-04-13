namespace LDTBaiTapThucHanh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        MaStudent = c.String(nullable: false, maxLength: 128),
                        TenStudent = c.String(),
                    })
                .PrimaryKey(t => t.MaStudent);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
