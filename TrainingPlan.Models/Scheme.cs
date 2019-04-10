using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPlan.Models
{
   public  class Scheme
    {
        public int SchemeId { get; set; }
        public string Grade { get; set; }
        //public int MajorId { get; set; }
        public string MajorName { get; set; }
        public int TeacherId { get; set; }
        public string TrainingObjectives { get; set; }
        public string TrainingStandard { get; set; }
        public string DemandOfCredit { get; set; }
        public string PublicCommonality { get; set; }
        public string SubjectBasisRequired { get; set; }
        public string SubjectBasisOptional { get; set; }
        public string ProfesssionRequired { get; set; }
        public string ProfessionOptional { get; set; }
        public string JobSkillsRequired { get; set; }
        public string JobSkillsOptional { get; set; }
        public int Status { get; set; }

        /*[JsonIgnore()]
        public virtual Major Majors { get; set; }*/
        [JsonIgnore()]
        public virtual Teacher Teachers { get; set; }

        [JsonIgnore()]
        public virtual ICollection<Course> Courses { get; set; }

    }
}
