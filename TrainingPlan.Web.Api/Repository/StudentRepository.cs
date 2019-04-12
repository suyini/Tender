using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrainingPlan.Data;
using TrainingPlan.Models;

namespace TrainingPlan.Web.Api.Repository
{
    public class StudentRepository
    {
        TraingingPlanContext db_context = new TraingingPlanContext();
        //id查询课程
        /*public IQueryable GetCourse(int id)
        {
            return db_context.Courses.Find(id);
        }*/
       /*public IEnumerable<Scheme> GetSchemes(string name,int grade)
        {
            var scheme = db_context.Schemes
                        .Where(d => d.MajorName == name && d.Grade <= grade);
        }*/
    }
}