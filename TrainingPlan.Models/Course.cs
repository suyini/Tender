using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPlan.Models
{
    public class Course
    {
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]//不自动增长
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseEname { get; set; }
        public string DepartmentName { get; set; }
        public string CurriculaTime { get; set; }
        public string CategoryO { get; set; } //1，2，3，4  公共，学科，专业，工作
        public string CategoryT { get; set; }//1，2必修，选修
        public string PrerequisiteCourse{ get; set; }
        public int TotalPeriod { get; set; }
        public int TeachingPeriod { get; set; }
        public int ExpermentPeriod { get; set; }
        public  int OtherPeriod { get; set; }
        public string CreditHour { get; set; }
        public string TeachingMethod { get; set; }
        public string EvaulationMethod { get; set; }
        public int TeacherId { get; set; }
        public string Remark { get; set; }
        public int Status { get; set; }

        [JsonIgnore()]
        public virtual Teacher Teachers { get; set; }

        /*[JsonIgnore()]
        public virtual Department Departments { get; set; }*/

        [JsonIgnore()]
        public virtual ICollection<Scheme> Schemes { get; set; }

        [JsonIgnore()]
        public virtual ICollection<Major> Majors { get; set; }
    }
}
