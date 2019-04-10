using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrainingPlan.Data;
using TrainingPlan.Models;

namespace TrainingPlan.Web.Api.Repository
{
    public class DepartmentRepository
    {
        TraingingPlanContext db_context = new TraingingPlanContext();
       
        /// <summary>
        /// 显示所有院系
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Department> GetDepartments()
        {
            return db_context.Departments.ToList();
                
        }
        

    }
}