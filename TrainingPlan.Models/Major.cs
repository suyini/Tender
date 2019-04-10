using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPlan.Models
{
    public class Major
    {
        public int MajorId { get; set; }
        public string MajorName { get; set; }
        public string DepartmentName { get; set; }


       /* [JsonIgnore()]

        public ICollection<Scheme> Schemes { get; set; }*/

        [JsonIgnore()]
        public virtual ICollection<Course> Courses { get; set; }
    }
}
