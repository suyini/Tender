using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingPlan.Models;

namespace TrainingPlan.Data.Mapping
{
    class StudentMap:EntityTypeConfiguration <Student>
    {
        public StudentMap()
        {
            this.HasKey(t => t.StudentId);
            this.ToTable("Student");
            this.Property(t => t.StudentId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.StudentId).HasColumnName("学号");
            this.Property(t => t.StudentName).HasColumnName("姓名");
            this.Property(t => t.StudentPassWord).HasColumnName("密码");
            this.Property(t => t.StudentFaculty).HasColumnName("学院");
            this.Property(t => t.StudentMajor).HasColumnName("专业");
            this.Property(t => t.Grade).HasColumnName("年级");


        }
    }
}
