namespace TrainingPlan.Data
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ninth : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Scheme", "专业代码", "dbo.Major");
            DropIndex("dbo.Scheme", new[] { "专业代码" });
            RenameColumn(table: "dbo.Course", name: "CurriculaTime", newName: "开课时间");
            RenameColumn(table: "dbo.Course", name: "CategoryT", newName: "必选");
            RenameColumn(table: "dbo.Course", name: "PrerequisiteCourse", newName: "先修课程");
            AlterColumn("dbo.Course", "类别", c => c.Int(nullable: false));
            AlterColumn("dbo.Course", "必选", c => c.Int(nullable: false));
            AlterColumn("dbo.GCourse", "类别", c => c.Int(nullable: false));
            AlterColumn("dbo.PEandEn", "类别", c => c.Int(nullable: false));
            DropColumn("dbo.Scheme", "专业代码");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Scheme", "专业代码", c => c.Int(nullable: false));
            AlterColumn("dbo.PEandEn", "类别", c => c.String());
            AlterColumn("dbo.GCourse", "类别", c => c.String());
            AlterColumn("dbo.Course", "必选", c => c.String());
            AlterColumn("dbo.Course", "类别", c => c.String());
            RenameColumn(table: "dbo.Course", name: "先修课程", newName: "PrerequisiteCourse");
            RenameColumn(table: "dbo.Course", name: "必选", newName: "CategoryT");
            RenameColumn(table: "dbo.Course", name: "开课时间", newName: "CurriculaTime");
            CreateIndex("dbo.Scheme", "专业代码");
            AddForeignKey("dbo.Scheme", "专业代码", "dbo.Major", "专业代码");
        }
    }
}
