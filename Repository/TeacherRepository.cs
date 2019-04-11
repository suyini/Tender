using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TrainingPlan.Data;
using TrainingPlan.Models;
using TrainingPlan.Web.Api.Repository;
namespace TrainingPlan.Web.Api.Repository
{
    public class TeacherRepository
    {
        TraingingPlanContext db_context = new TraingingPlanContext();

        /// <summary>
        /// 老师根据自己的ID查看自己编辑的课程
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
       public IQueryable<Course> GetById(int id)
        {

            var teach = db_context.Teachers
                        .Single(a => a.TeacherId == id);
            var postCount = db_context.Entry(teach)
                         .Collection(b => b.Courses)
                         .Query();
            return postCount;
                         

        }

        /// <summary>
        /// 老师根据课程审核状态查看课程（未处理，已审核，退回)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public List<Course> GetByStatus(int id,int status)
        {

            var teach = db_context.Teachers
                        .Single(a => a.TeacherId == id);
            var postCount = db_context.Entry(teach)
                         .Collection(b => b.Courses)
                         .Query()
                         .Where(b => b.Status == status)
                         .ToList();
            return postCount;


        }
        /// <summary>
        /// 审核课程的老师查询审核课程
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public List<Course> GetCheck(int id, int status)
        {
            var teacher = db_context.Teachers;
            
                            
            var course = db_context.Courses;
            var cour = from a in teacher
                       join b in course
                       on a.DepartmenName equals b.DepartmentName
                       where a.TeacherId==id && b.Status==status
                       select course 
                       .ToList();                 
            return cour;
          }

            /// <summary>
            /// 老师根据自己ID查看培养方案（未处理，已审核，退回，已应用）
            /// </summary>
            /// <param name="id"></param>
            /// <param name="status"></param>
            /// <returns></returns>
            public List<Scheme> GetSchemeBy(int id,int status)
        {

            var teach = db_context.Teachers
                        .Single(a => a.TeacherId == id);
            var scheme = db_context.Entry(teach)
                         .Collection(b => b.Schemes)
                         .Query()
                         .Where(b => b.Status == status)
                         .ToList();
            return scheme;

        }

        public List<Scheme> GetSchemeCourseBy(int id, int status)
        {

            var teach = db_context.Teachers
                        .Single(a => a.TeacherId == id);
            var scheme = db_context.Entry(teach)
                         .Collection(b => b.Schemes)
                         .Query()
                         .Where(b => b.Status == status)
                         .ToList();
            return scheme;

        }


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