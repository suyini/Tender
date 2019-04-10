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
    class GeneralCourseMap : EntityTypeConfiguration<PEandEnCourse>
    {
        public GeneralCourseMap()
        {
            this.HasKey(t => t.GCourseId);
            this.ToTable("GCourse");
            this.Property(t => t.GCourseId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.GCourseId).HasColumnName("课程号");
            this.Property(t => t.GCourseName).HasColumnName("课程名称"); //课程名称
            this.Property(t => t.EnglishName).HasColumnName("英文名称");
            this.Property(t => t.CreditHour).HasColumnName("学分");//学分
            this.Property(t => t.DepartmentId).HasColumnName("开课院系"); //开课院系
            this.Property(t => t.PrerequisiteCourse).HasColumnName("先修课程");
            this.Property(t => t.FCategory).HasColumnName("类别"); //类别
            this.Property(t => t.TotalPeriod).HasColumnName("总学时");//总学时
            this.Property(t => t.TeachingPeriod).HasColumnName("授课学时");//授课学时
            this.Property(t => t.ExpermentPeriod).HasColumnName("实验学时");//实验课时
            this.Property(t => t.TeachingMethod).HasColumnName("授课方式");//授课方式
            this.Property(t => t.EvaulationMethod).HasColumnName("考核方式");//考核方式
            this.Property(t => t.TeacherId).HasColumnName("制定人");
            this.Property(t => t.Remark).HasColumnName("备注");//备注
            this.Property(t => t.Status).HasColumnName("审核状态");
            //老师外键
            this.HasRequired(p => p.Teachers)
                .WithMany(b=>b.GeneralCourses)
           .HasForeignKey(p => p.TeacherId);
        }
    }
}
