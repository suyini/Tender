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
        public IEnumerable<PEandEnCourse> GetByCatogory(string category)
        {
            return peAndEn.GetByCategory(category);
        }

        public IEnumerable<PEandEnCourse> GetByDepartment(string d_name)
        {
            return peAndEn.GetByDepartment(d_name);
        }
    }
}