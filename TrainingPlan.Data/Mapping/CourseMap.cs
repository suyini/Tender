using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingPlan.Models;

namespace TrainingPlan.Data.Mapping
{
    class CourseMap:EntityTypeConfiguration<Course>
    {
        public CourseMap()
        {
            this.HasKey(t => t.CourseId);
            this.ToTable("Course");
            this.Property(t=>t.CourseId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.CourseId).HasColumnName("课程号");
            this.Property(t => t.CourseName).HasColumnName("课程名称"); //课程名称
            this.Property(t => t.CourseEname).HasColumnName("英文名称");
            this.Property(t => t.DepartmentName).HasColumnName("开课学院");
            this.Property(t => t.CurriculaTime).HasColumnName("开课时间");//
            this.Property(t => t.CreditHour).HasColumnName("学分");//学分
            this.Property(t => t.CategoryO).HasColumnName("类别"); //类别
            this.Property(t => t.CategoryT).HasColumnName("必选");
            this.Property(t => t.PrerequisiteCourse).HasColumnName("先修课程");
            this.Property(t => t.TotalPeriod).HasColumnName("总学时");//总学时
            this.Property(t => t.TeachingPeriod).HasColumnName("授课学时");//授课学时
            this.Property(t => t.ExpermentPeriod).HasColumnName("实验学时");//实验课时
            this.Property(t => t.TeachingMethod).HasColumnName("授课方式");//授课方式
            this.Property(t => t.EvaulationMethod).HasColumnName("考核方式");//考核方式
            this.Property(t => t.TeacherId).HasColumnName("制定人");
            this.Property(t => t.Remark).HasColumnName("备注");//备注
            this.Property(t => t.Status).HasColumnName("审核状态");

            //课程和专业多对多
            this.HasMany(t => t.Majors)
               .WithMany(t => t.Courses)
               .Map(m =>
               {
                   m.ToTable("CourseMajor");
                   m.MapLeftKey("CourseId");
                   m.MapRightKey("MajorId");
               });

            //老师外键
            this.HasRequired(p => p.Teachers)
           .WithMany(b => b.Courses)
           .HasForeignKey(p => p.TeacherId)
             .WillCascadeOnDelete(false);

        }
    }
}
