using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrainingPlan.Data;
using TrainingPlan.Models;

namespace TrainingPlan.Web.Api.Repository
{
    public class CourseRepository
    {
        TraingingPlanContext db_context = new TraingingPlanContext();

        //查询课程
        public Course GetStudent(int id)
        {
            return db_context.Courses.Find(id);
        }
       
        public IEnumerable<Course> GetALL()
        {
            return db_context.Courses.ToList();
        }
        
        //添加课程
        public void AddCourse()
        {
            using (db_context)
            {
                var course = new Models.Course();
                db_context.Courses.Add(course);
                if (db_context.SaveChanges() > 0)
                {
                    Console.WriteLine("添加成功");
                }
                else
                {
                    Console.WriteLine("添加失败");
                }

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
        public void ModifiedCourse(int id)
        {
            using (db_context)
            {
                var course = new Models.Course();
                db_context.Entry(course).State = System.Data.Entity.EntityState.Modified;
                db_context.SaveChanges();
            }
        }
       
            
        }
       


    }

