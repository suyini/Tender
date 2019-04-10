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
    class MajorMap : EntityTypeConfiguration<Major>
    {

        public MajorMap()
        {
            this.HasKey(t => t.MajorId);
            this.ToTable("Major");
            this.Property(t => t.MajorId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.MajorId).HasColumnName("专业代码");
            this.Property(t => t.MajorName).HasColumnName("专业名称");
            this.Property(t => t.DepartmentName).HasColumnName("院系");

            //DepartmentId为外键
            /*this.HasRequired(p => p.Departments)
            .WithMany(b => b.Majors)
            .HasForeignKey(p => p.DepartmentName);*/

        }
    }
}
