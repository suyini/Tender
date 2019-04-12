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
    class AdministratorMap:EntityTypeConfiguration<Administrator>
    {
        public AdministratorMap()
        {
            this.HasKey(t => t.AdministratorId);
            this.ToTable("Administrator");
            this.Property(t => t.AdministratorId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.AdministratorId).HasColumnName("工号");
            this.Property(t => t.AdministratorName).HasColumnName("姓名");
            this.Property(t => t.AdministratorPassWord).HasColumnName("密码");


        }
    }
}
