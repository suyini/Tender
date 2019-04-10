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
        public Student GetStudent(int id)
        {
            return db_context.Students.Find(id);
        }

    }
}