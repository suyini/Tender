using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrainingPlan.Data;
using TrainingPlan.Models;

namespace TrainingPlan.Web.Api.Repository
{
    public class MajorRepository
    {
        TraingingPlanContext context = new TraingingPlanContext();

       /// <summary>
       /// 显示系里的专业
       /// </summary>
       /// <param name="d_name"></param>
       /// <returns></returns>
       public IEnumerable<Major> GetMajor(string d_name)
        {
            var major_Name = context.Majors
                 .Where(d => d.DepartmentName == d_name)
                 .ToList();
            return major_Name;

        }
        

    }
}