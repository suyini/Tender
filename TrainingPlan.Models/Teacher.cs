using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPlan.Models
{
   public class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherPassWord { get; set; }
        public string DepartmenName { get; set; }
        public bool IsMaker { get; set; }

        /*[JsonIgnore()]
        public Department Departments { get; set; }*/

        [JsonIgnore()]
        public virtual ICollection<Course> Courses { get; set; }
        
        [JsonIgnore()]
        public  virtual ICollection<GeneralCourse> GeneralCourses { get; set; }

        [JsonIgnore()]
        public ICollection<PEandEn> PEandEns { get; set; }

        [JsonIgnore()]
        public virtual ICollection<Scheme> Schemes { get; set; }


    }
}
