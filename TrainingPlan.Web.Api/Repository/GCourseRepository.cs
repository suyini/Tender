using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrainingPlan.Data;
using TrainingPlan.Models;

namespace TrainingPlan.Web.Api.Repository
{
    public class GCourseRepository
    {
        TraingingPlanContext context = new TraingingPlanContext();

        /// <summary>
        /// 根据院系查看限选课程
        /// </summary>
        /// <param name="d_name"></param>
        /// <returns></returns>
        public List<IGrouping<string,GeneralCourse>>  GetByDepartment(string d_name)
        {

            var course = context.GeneralCourses
                         .Where(d => d.DepartmentId == d_name)
                         .GroupBy(d => d.FCategory)
                         .ToList();
                       
        
            return course;
        }

        /// <summary>
        /// 根据种类查看课程信息
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public IEnumerable<GeneralCourse> GetByCategory(string category)
        {
            var course = context.GeneralCourses
                        .Where(d => d.FCategory == category)
                        .ToList();
            return course;

        }
     

        /// <summary>
        /// 根据开课院系和课程类别查询
        /// </summary>
        /// <param name="d_name"></param>
        /// <param name="category"></param>
        /// <returns></returns>
       public List<IGrouping<string,GeneralCourse>> GetByDeAndCa(string d_name,string category)
        {
            var coure = context.GeneralCourses
                        .Where(d => d.FCategory == category && d.DepartmentId == d_name)
                        .GroupBy(d=>d.FCategory)
                        .ToList();
            return coure;
        }


    }
}