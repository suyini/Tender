namespace TrainingPlan.Data
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hund : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administrator",
                c => new
                    {
                        工号 = c.Int(nullable: false),
                        姓名 = c.String(),
                        密码 = c.String(),
                    })
                .PrimaryKey(t => t.工号);
            
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        系代码 = c.Int(nullable: false),
                        系名称 = c.String(),
                        AdministratorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.系代码)
                .ForeignKey("dbo.Administrator", t => t.AdministratorId)
                .Index(t => t.AdministratorId);
            
            CreateTable(
                "dbo.Major",
                c => new
                    {
                        专业代码 = c.Int(nullable: false),
                        专业名称 = c.String(),
                        系代码 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.专业代码)
                .ForeignKey("dbo.Department", t => t.系代码, cascadeDelete: true)
                .Index(t => t.系代码);
            
            CreateTable(
                "dbo.Course",
                c => new
                    {
                        课程号 = c.Int(nullable: false),
                        课程名称 = c.String(),
                        英文名称 = c.String(),
                        DepartmentId = c.String(),
                        CurriculaTime = c.String(),
                        类别 = c.String(),
                        CategoryT = c.String(),
                        PrerequisiteCourse = c.String(),
                        总学时 = c.Int(nullable: false),
                        授课学时 = c.Int(nullable: false),
                        实验学时 = c.Int(nullable: false),
                        OtherPeriod = c.Int(nullable: false),
                        学分 = c.String(),
                        授课方式 = c.String(),
                        考核方式 = c.String(),
                        制定人 = c.Int(nullable: false),
                        备注 = c.String(),
                        审核状态 = c.String(),
                    })
                .PrimaryKey(t => t.课程号)
                .ForeignKey("dbo.Teacher", t => t.制定人)
                .Index(t => t.制定人);
            
            CreateTable(
                "dbo.Scheme",
                c => new
                    {
                        方案代码 = c.Int(nullable: false),
                        年级 = c.String(),
                        专业代码 = c.Int(nullable: false),
                        专业名称 = c.String(),
                        负责人 = c.Int(nullable: false),
                        培养目标 = c.String(),
                        培养规格 = c.String(),
                        准毕学分 = c.String(),
                        公共基础课 = c.String(),
                        学科基础必修 = c.String(),
                        学科基础选修 = c.String(),
                        专业知识必修 = c.String(),
                        专业知识选修 = c.String(),
                        工作技能必修 = c.String(),
                        工作技能选修 = c.String(),
                        审核状态 = c.String(),
                    })
                .PrimaryKey(t => t.方案代码)
                .ForeignKey("dbo.Major", t => t.专业代码)
                .ForeignKey("dbo.Teacher", t => t.负责人)
                .Index(t => t.专业代码)
                .Index(t => t.负责人);
            
            CreateTable(
                "dbo.Teacher",
                c => new
                    {
                        工号 = c.Int(nullable: false),
                        姓名 = c.String(),
                        密码 = c.String(),
                        系 = c.Int(nullable: false),
                        制定人 = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.工号)
                .ForeignKey("dbo.Department", t => t.系)
                .Index(t => t.系);
            
            CreateTable(
                "dbo.GCourse",
                c => new
                    {
                        课程号 = c.Int(nullable: false),
                        课程名称 = c.Int(nullable: false),
                        英文名称 = c.String(),
                        开课院系 = c.String(),
                        类别 = c.String(),
                        先修课程 = c.String(),
                        总学时 = c.Int(nullable: false),
                        授课学时 = c.Int(nullable: false),
                        实验学时 = c.Int(nullable: false),
                        OtherPeriod = c.Int(nullable: false),
                        学分 = c.String(),
                        授课方式 = c.String(),
                        考核方式 = c.String(),
                        制定人 = c.Int(nullable: false),
                        备注 = c.String(),
                        审核状态 = c.String(),
                    })
                .PrimaryKey(t => t.课程号)
                .ForeignKey("dbo.Teacher", t => t.制定人, cascadeDelete: true)
                .Index(t => t.制定人);
            
            CreateTable(
                "dbo.PEandEn",
                c => new
                    {
                        课程号 = c.Int(nullable: false),
                        课程名称 = c.Int(nullable: false),
                        英文名称 = c.String(),
                        开课院系 = c.String(),
                        类别 = c.String(),
                        先修课程 = c.String(),
                        总学时 = c.Int(nullable: false),
                        授课学时 = c.Int(nullable: false),
                        实验学时 = c.Int(nullable: false),
                        OtherPeriod = c.Int(nullable: false),
                        学分 = c.String(),
                        授课方式 = c.String(),
                        考核方式 = c.String(),
                        制定人 = c.Int(nullable: false),
                        备注 = c.String(),
                        审核状态 = c.String(),
                    })
                .PrimaryKey(t => t.课程号)
                .ForeignKey("dbo.Teacher", t => t.制定人, cascadeDelete: true)
                .Index(t => t.制定人);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        学号 = c.Int(nullable: false),
                        姓名 = c.String(),
                        密码 = c.String(),
                        学院 = c.String(),
                        年级 = c.String(),
                        专业 = c.String(),
                    })
                .PrimaryKey(t => t.学号);
            
            CreateTable(
                "dbo.CourseMajor",
                c => new
                    {
                        CourseId = c.Int(nullable: false),
                        MajorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CourseId, t.MajorId })
                .ForeignKey("dbo.Course", t => t.CourseId)
                .ForeignKey("dbo.Major", t => t.MajorId)
                .Index(t => t.CourseId)
                .Index(t => t.MajorId);
            
            CreateTable(
                "dbo.SchemeCourse",
                c => new
                    {
                        SchemeId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SchemeId, t.CourseId })
                .ForeignKey("dbo.Scheme", t => t.SchemeId)
                .ForeignKey("dbo.Course", t => t.CourseId)
                .Index(t => t.SchemeId)
                .Index(t => t.CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Major", "系代码", "dbo.Department");
            DropForeignKey("dbo.Course", "制定人", "dbo.Teacher");
            DropForeignKey("dbo.Scheme", "负责人", "dbo.Teacher");
            DropForeignKey("dbo.PEandEn", "制定人", "dbo.Teacher");
            DropForeignKey("dbo.GCourse", "制定人", "dbo.Teacher");
            DropForeignKey("dbo.Teacher", "系", "dbo.Department");
            DropForeignKey("dbo.Scheme", "专业代码", "dbo.Major");
            DropForeignKey("dbo.SchemeCourse", "CourseId", "dbo.Course");
            DropForeignKey("dbo.SchemeCourse", "SchemeId", "dbo.Scheme");
            DropForeignKey("dbo.CourseMajor", "MajorId", "dbo.Major");
            DropForeignKey("dbo.CourseMajor", "CourseId", "dbo.Course");
            DropForeignKey("dbo.Department", "AdministratorId", "dbo.Administrator");
            DropIndex("dbo.SchemeCourse", new[] { "CourseId" });
            DropIndex("dbo.SchemeCourse", new[] { "SchemeId" });
            DropIndex("dbo.CourseMajor", new[] { "MajorId" });
            DropIndex("dbo.CourseMajor", new[] { "CourseId" });
            DropIndex("dbo.PEandEn", new[] { "制定人" });
            DropIndex("dbo.GCourse", new[] { "制定人" });
            DropIndex("dbo.Teacher", new[] { "系" });
            DropIndex("dbo.Scheme", new[] { "负责人" });
            DropIndex("dbo.Scheme", new[] { "专业代码" });
            DropIndex("dbo.Course", new[] { "制定人" });
            DropIndex("dbo.Major", new[] { "系代码" });
            DropIndex("dbo.Department", new[] { "AdministratorId" });
            DropTable("dbo.SchemeCourse");
            DropTable("dbo.CourseMajor");
            DropTable("dbo.Student");
            DropTable("dbo.PEandEn");
            DropTable("dbo.GCourse");
            DropTable("dbo.Teacher");
            DropTable("dbo.Scheme");
            DropTable("dbo.Course");
            DropTable("dbo.Major");
            DropTable("dbo.Department");
            DropTable("dbo.Administrator");
        }
    }
}
