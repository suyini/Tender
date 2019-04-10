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
    class DepartmentMap : EntityTypeConfiguration<Department>
    {
        public DepartmentMap()
        {
            this.HasKey(t => t.DepartmentId);
            this.ToTable("Department");
            this.Property(t => t.DepartmentId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.DepartmentId).HasColumnName("系代码");
            this.Property(t => t.DepartmentName).HasColumnName("系名称");
  
            //AdministratorId外键
            this.HasRequired(p => p.Administrators)
            .WithMany(b => b.Departments)
            .HasForeignKey(p => p.AdministratorId)
             .WillCascadeOnDelete(false);
          
           

        }

       
    }
}
