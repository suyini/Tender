using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TrainingPlan.Data;
using TrainingPlan.Models;
using TrainingPlan.Web.Api.Repository;

namespace TrainingPlan.Web.Api.Controllers
{
    public class PEandEnController:ApiController
    {
        PEandEnRepository peAndEn = new PEandEnRepository();

        [HttpGet]
        [Route("PEandEn/GetByCategory/{category}")]
        public IEnumerable<GeneralCourse> GetByCategory(string category)
        {
            return peAndEn.GetByCategory(category);
        }


        [HttpGet]
        [Route("PEandEn/GetByDepartment/{d_name}")]
        public IEnumerable<GeneralCourse> GetByDepartment(string d_name)
        {
            return peAndEn.GetByDepartment(d_name);
        }
    }
}