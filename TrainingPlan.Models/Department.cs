using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPlan.Models
{
    public class Department
    {
        public int DepartmentId{ get; set; }
        public string DepartmentName { get; set; }
        public int AdministratorId { get; set; }

        [JsonIgnore()]
        public ICollection<Major> Majors { get; set; }

        [JsonIgnore()]
        public ICollection<Teacher> Teachers { get; set; }

        [JsonIgnore()]
        public Administrator Administrators { get; set; }
        //课程

       /* [JsonIgnore()]
        public ICollection<Course> Courses { get; set; }
        //通识课

        [JsonIgnore()]
        public ICollection<GeneralCourse> GeneralCourse { get; set; }
        //外语、体育课

        [JsonIgnore()]
        public ICollection<PEandEn> PEandEns { get; set; }*/
    }
}
