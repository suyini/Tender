using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace TrainingPlan.Models
{
    public class Administrator
    {
        public int AdministratorId { get; set; }
        public string AdministratorName { get; set; }
        public string AdministratorPassWord { get; set; }

        [JsonIgnore()]
        public ICollection<Department> Departments { get; set; }
    }
}
