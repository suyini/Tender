﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TrainingPlan.Models;
using TrainingPlan.Web.Api.Repository;

namespace TrainingPlan.Web.Api.Controllers
{
    public class CourseController:ApiController
    {
        CourseRepository Coursecon = new CourseRepository();

        [HttpGet]
        [Route("api/Course/{id}")]
        public Course GetCourse(int id)
        {
            return Coursecon.GetStudent(id);
        }

        [HttpGet]
        [Route("api/Course")]
        public IEnumerable<Course> GetAll()
        {
            return Coursecon.GetALL();
        }
        
    }
}