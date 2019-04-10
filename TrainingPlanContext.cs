using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TrainingPlan.Models;
using TrainingPlan.Data.Mapping;
using System.Data.Entity.Migrations;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TrainingPlan.Data
{
    public class TraingingPlanContext : DbContext
    {
        public TraingingPlanContext() : base("name=TrainingPlanContext")
        {

        }
        public DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Models.Course> Courses { get; set; }
        public virtual DbSet<Scheme> Schemes { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<PEandEnCourse> PEandEnCourses { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<PEandEn> PEandEns { get; set; }

        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
           
            modelBuilder.Configurations.Add(new TeacherMap());
            modelBuilder.Configurations.Add(new CourseMap());
            modelBuilder.Configurations.Add(new GeneralCourseMap());
            modelBuilder.Configurations.Add(new PEandEnMap());
            modelBuilder.Configurations.Add(new SchemeMap());
            modelBuilder.Configurations.Add(new MajorMap());
            modelBuilder.Configurations.Add(new DepartmentMap());
            modelBuilder.Configurations.Add(new StudentMap());
            modelBuilder.Configurations.Add(new AdministratorMap());
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();//禁止多对多的级联删除

        }
        internal sealed class EFDbMigrationsConfiguration : DbMigrationsConfiguration<TraingingPlanContext>
        {
            public EFDbMigrationsConfiguration()
            {
                AutomaticMigrationsEnabled = true;//任何Model Class的修改將會自动直接更新DB
                AutomaticMigrationDataLossAllowed = true;  //可接受自动迁移期间的数据丢失的值
            }
        }

    }
}
