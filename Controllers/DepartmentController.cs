using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TrainingPlan.Models;
using TrainingPlan.Web.Api.Repository;

namespace TrainingPlan.Web.Api.Controllers
{
    public class DepartmentController:ApiController
    {
        DepartmentRepository Depart = new DepartmentRepository();

        [HttpGet]
        [Route("api/Department")]
        public IEnumerable<Department> GetAll()
        {
            return Depart.GetDepartments();
        }
    }
}