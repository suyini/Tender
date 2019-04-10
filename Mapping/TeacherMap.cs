using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingPlan.Models;

namespace TrainingPlan.Data
{
    class TeacherMap : EntityTypeConfiguration<Teacher>
    {
        public TeacherMap()
        {
            this.HasKey(t => t.TeacherId);
            this.ToTable("Teacher");
            this.Property(t => t.TeacherId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.TeacherId).HasColumnName("工号");
            this.Property(t => t.TeacherPassWord).HasColumnName("密码");
            this.Property(t => t.TeacherName).HasColumnName("姓名");
            this.Property(t => t.DepartmenName).HasColumnName("系");
            this.Property(t => t.IsMaker).HasColumnName("制定人");

            /*DepartmentId为外键
            this.HasRequired(p => p.Departments)
           .WithMany(b => b.Teachers)
           .HasForeignKey(p=>p.DepartmenName)
            .WillCascadeOnDelete(false);*/

        }
    }
}
