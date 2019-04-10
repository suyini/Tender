﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TrainingPlan.Models;
using TrainingPlan.Web.Api.Repository;
using TrainingPlan.Data;

namespace TrainingPlan.Web.Api.Controllers
{
    public class StudentController:ApiController
    {
       StudentRepository CourseCon = new StudentRepository();

        [HttpGet]
        [Route("api/Student/{id}")]
        public Student GetCourse(int id)
        {

            return CourseCon.GetStudent(id);
        }
    }
}