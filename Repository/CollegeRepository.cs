using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrainingPlan.Data;
using TrainingPlan.Models;

namespace TrainingPlan.Web.Api.Repository
{
    public class CollegeRepository
    {
        TraingingPlanContext context = new TraingingPlanContext();

        
        //显示全部学院
        /*public void GetDepartment()
        {
            using (context)
            {
                var name = context.GeneralCourses
                     .Select(c => c.CollegeName)
                     .ToList();
            }
        }*/
    }
}