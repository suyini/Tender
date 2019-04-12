using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TrainingPlan.Models;
using TrainingPlan.Web.Api.Repository;

namespace TrainingPlan.Web.Api.Controllers
{
    public class GCourseController:ApiController
    {
        GCourseRepository gcourse = new GCourseRepository();

        [HttpGet]
        [Route("GCourse/GetByCategory/{category}")]
        public IEnumerable<GeneralCourse> GetByCategory(string category)
        {
            return gcourse.GetByCategory(category);
        }

        [HttpGet]
        [Route("GCourse/GetByDepartment/{d_name}")]
        public List<IGrouping<string, GeneralCourse>> GetByDepartment(string d_name)
        {
            return gcourse.GetByDepartment(d_name);
        }


        [HttpGet]
        [Route("GCourse/GetByDepartment/{d_name}/category")]
        public List<IGrouping<string, GeneralCourse>> GetByDeAndCa(string d_name,string category)
        {
            return gcourse.GetByDepartment(d_name);
        }

    }
}