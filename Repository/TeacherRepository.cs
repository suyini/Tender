using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrainingPlan.Data;
using TrainingPlan.Models;
using TrainingPlan.Web.Api.Repository;
namespace TrainingPlan.Web.Api.Repository
{
    public class TeacherRepository
    {
        TraingingPlanContext db_context = new TraingingPlanContext();

        //老师根据自己id查询自己编辑的课程
        /*public IQueryable GetCourse(int id)
        {
            return db_context.Courses.Find(id);
        }*/ 
        
        //添加课程
        public void AddCourse()
        {
            using (db_context)
            {
                var course = new Models.Course();
                db_context.Courses.Add(course);
                db_context.SaveChanges();
            }
        }
        //删除课程
        public void DeleteCourse(int id)
        {
            using (db_context)
            {
                var course = db_context.Courses.First();
                db_context.Courses.Remove(course);
                db_context.SaveChanges();
            }
        }

        //修改课程

    }
}