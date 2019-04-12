using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TrainingPlan.Data;
using TrainingPlan.Models;

namespace TrainingPlan.Web.Api.Repository
{
  
    public class SchemeRepository
    {
        TraingingPlanContext context = new TraingingPlanContext();

        /// <summary>
        /// 根据自己的id和方案状态查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Scheme> getById(int id,int status)
        {
            var scheme = context.Schemes
                        .Where(t => t.TeacherId == id&&t.Status==status)
                        .ToList();
            return scheme;
        }

        /// <summary>
        /// 显示与培养方案关联的课程
        /// </summary>
        /// <param name="scheme"></param>
        /// <returns></returns>
        public List<Course> GetSchemCourse(Scheme scheme)
        {

            var postCount = context.Entry(scheme)
                         .Collection(b => b.Courses)
                         .Query()
                         .ToList();
            return postCount;

        }

    }
}