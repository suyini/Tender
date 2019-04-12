using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TrainingPlan.Models;
using TrainingPlan.Web.Api.Repository;

namespace TrainingPlan.Web.Api.Controllers
{
    public class MajorController:ApiController
    {
        MajorRepository major = new MajorRepository();

        [HttpGet]
        [Route("api/Major/name")]
        public IEnumerable<Major> GetMajors(string name)
        {
            return major.GetMajor(name);
        }
    }
}