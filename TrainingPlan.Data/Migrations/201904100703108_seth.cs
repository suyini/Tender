namespace TrainingPlan.Data
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seth : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Major", "系代码", "dbo.Department");
            DropForeignKey("dbo.Teacher", "系", "dbo.Department");
            DropIndex("dbo.Major", new[] { "系代码" });
            DropIndex("dbo.Teacher", new[] { "系" });
            RenameColumn(table: "dbo.Major", name: "系代码", newName: "Department_DepartmentId");
            AddColumn("dbo.Major", "院系", c => c.String());
            AddColumn("dbo.Course", "开课学院", c => c.String());
            AddColumn("dbo.Teacher", "Department_DepartmentId", c => c.Int());
            AlterColumn("dbo.Major", "Department_DepartmentId", c => c.Int());
            AlterColumn("dbo.Course", "审核状态", c => c.Int(nullable: false));
            AlterColumn("dbo.Scheme", "审核状态", c => c.Int(nullable: false));
            AlterColumn("dbo.Teacher", "系", c => c.String());
            AlterColumn("dbo.GCourse", "审核状态", c => c.Int(nullable: false));
            AlterColumn("dbo.PEandEn", "审核状态", c => c.Int(nullable: false));
            CreateIndex("dbo.Major", "Department_DepartmentId");
            CreateIndex("dbo.Teacher", "Department_DepartmentId");
            AddForeignKey("dbo.Major", "Department_DepartmentId", "dbo.Department", "系代码");
            AddForeignKey("dbo.Teacher", "Department_DepartmentId", "dbo.Department", "系代码");
            DropColumn("dbo.Course", "DepartmentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Course", "DepartmentId", c => c.String());
            DropForeignKey("dbo.Teacher", "Department_DepartmentId", "dbo.Department");
            DropForeignKey("dbo.Major", "Department_DepartmentId", "dbo.Department");
            DropIndex("dbo.Teacher", new[] { "Department_DepartmentId" });
            DropIndex("dbo.Major", new[] { "Department_DepartmentId" });
            AlterColumn("dbo.PEandEn", "审核状态", c => c.String());
            AlterColumn("dbo.GCourse", "审核状态", c => c.String());
            AlterColumn("dbo.Teacher", "系", c => c.Int(nullable: false));
            AlterColumn("dbo.Scheme", "审核状态", c => c.String());
            AlterColumn("dbo.Course", "审核状态", c => c.String());
            AlterColumn("dbo.Major", "Department_DepartmentId", c => c.Int(nullable: false));
            DropColumn("dbo.Teacher", "Department_DepartmentId");
            DropColumn("dbo.Course", "开课学院");
            DropColumn("dbo.Major", "院系");
            RenameColumn(table: "dbo.Major", name: "Department_DepartmentId", newName: "系代码");
            CreateIndex("dbo.Teacher", "系");
            CreateIndex("dbo.Major", "系代码");
            AddForeignKey("dbo.Teacher", "系", "dbo.Department", "系代码");
            AddForeignKey("dbo.Major", "系代码", "dbo.Department", "系代码", cascadeDelete: true);
        }
    }
}
