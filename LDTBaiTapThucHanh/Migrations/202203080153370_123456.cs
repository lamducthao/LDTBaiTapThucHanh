namespace LDTBaiTapThucHanh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _123456 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.String(nullable: false, maxLength: 128),
                        EmployeeName = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
