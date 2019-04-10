using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrainingPlan.Models;
using TrainingPlan.Data;


namespace TrainingPlan.Web.Api.Repository
{
    public class PEandEnRepository
    {
        TraingingPlanContext context = new TraingingPlanContext();

        /// <summary>
        /// 根据课程类别查看课程
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public IEnumerable<PEandEnCourse> GetByCategory(string category)
        {
            var course = context.PEandEnCourses
                        .Where(d => d.FCategory == category)
                        .ToList();
            return course;

        }

        /// <summary>
        /// 根据开课院系查看课程
        /// </summary>
        /// <param name="d_name"></param>
        /// <returns></returns>
        public IEnumerable<PEandEnCourse> GetByDepartment(string d_name)
        {

            var course = context.PEandEnCourses
                        .Where(d => d.DepartmentId == d_name)
                        .ToList();
            return course;
        }
    }
}