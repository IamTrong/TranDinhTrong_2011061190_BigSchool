namespace TranDinhTrong_2011061190.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttendance : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "Category_Id" });
            RenameColumn(table: "dbo.Courses", name: "Category_Id", newName: "CategoryId");
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        AttendeeId = c.String(nullable: false, maxLength: 128),
                        Attendee_Id = c.String(maxLength: 128),
                        Course_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AttendeeId)
                .ForeignKey("dbo.AspNetUsers", t => t.Attendee_Id)
                .ForeignKey("dbo.Courses", t => t.Course_Id)
                .Index(t => t.Attendee_Id)
                .Index(t => t.Course_Id);
            
            AlterColumn("dbo.Courses", "CategoryId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Courses", "CategoryId");
            AddForeignKey("dbo.Courses", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Attendances", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.Attendances", "Attendee_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Courses", new[] { "CategoryId" });
            DropIndex("dbo.Attendances", new[] { "Course_Id" });
            DropIndex("dbo.Attendances", new[] { "Attendee_Id" });
            AlterColumn("dbo.Courses", "CategoryId", c => c.Byte());
            DropTable("dbo.Attendances");
            RenameColumn(table: "dbo.Courses", name: "CategoryId", newName: "Category_Id");
            CreateIndex("dbo.Courses", "Category_Id");
            AddForeignKey("dbo.Courses", "Category_Id", "dbo.Categories", "Id");
        }
    }
}
