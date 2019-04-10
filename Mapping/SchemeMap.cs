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
    class SchemeMap :  EntityTypeConfiguration<Scheme>
    {
        public SchemeMap()
        {
            this.HasKey(t => t.SchemeId);
            this.ToTable("Scheme");
            this.Property(t => t.SchemeId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.SchemeId).HasColumnName("方案代码");
            //this.Property(t => t.MajorId).HasColumnName("专业代码");
            this.Property(t => t.MajorName).HasColumnName("专业名称");
            this.Property(t => t.TeacherId).HasColumnName("负责人");
            this.Property(t => t.Grade).HasColumnName("年级");
            this.Property(t => t.TrainingObjectives).HasColumnName("培养目标");
            this.Property(t => t.TrainingStandard).HasColumnName("培养规格");
            this.Property(t => t.DemandOfCredit).HasColumnName("准毕学分");
            this.Property(t => t.PublicCommonality).HasColumnName("公共基础课");
            this.Property(t => t.SubjectBasisRequired).HasColumnName("学科基础必修");
            this.Property(t => t.SubjectBasisOptional).HasColumnName("学科基础选修");
            this.Property(t => t.ProfesssionRequired).HasColumnName("专业知识必修");
            this.Property(t => t.ProfessionOptional).HasColumnName("专业知识选修");
            this.Property(t => t.JobSkillsRequired).HasColumnName("工作技能必修");
            this.Property(t => t.JobSkillsOptional).HasColumnName("工作技能选修");
            this.Property(t => t.Status).HasColumnName("审核状态");
            this.HasMany(t => t.Courses)
                .WithMany(t => t.Schemes)
                .Map(m =>
                {
                    m.ToTable("SchemeCourse");
                    m.MapLeftKey("SchemeId");
                    m.MapRightKey("CourseId");
                });

            /*MajorId外键
           this.HasRequired(t => t.Majors)
                .WithMany(t => t.Schemes)
                .HasForeignKey(t => t.MajorId)
                .WillCascadeOnDelete(false);*/

            //TeacherId外键
            this.HasRequired(t => t.Teachers)
                .WithMany(t => t.Schemes)
                .HasForeignKey(t => t.TeacherId)
                .WillCascadeOnDelete(false);
        }


    }
}
