using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPlan.Models
{
    public class PEandEnCourse
    {
        public int GCourseId { get; set; }
        public string GCourseName { get; set; }
        public string EnglishName { get; set; }
        public  string DepartmentId { get; set; }
        public string FCategory { get; set; }
        public string PrerequisiteCourse { get; set; }
        public int TotalPeriod { get; set; }
        public int TeachingPeriod { get; set; }
        public int ExpermentPeriod { get; set; }
        public int OtherPeriod { get; set; }
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
    }
}
