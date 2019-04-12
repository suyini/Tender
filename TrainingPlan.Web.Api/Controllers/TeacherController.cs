using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Data.Entity;
using System.Web.Http;
using TrainingPlan.Models;
using TrainingPlan.Web.Api.Repository;
using TrainingPlan.Data;

namespace TrainingPlan.Web.Api.Controllers
{
    public class TeacherController:ApiController
    {
        TraingingPlanContext context = new TraingingPlanContext();
        TeacherRepository teach = new TeacherRepository();
        SchemeRepository scheme = new SchemeRepository();
        
        /// <summary>
        /// 根据自己的ID查看课程
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Teacher/GetById/{id}")]
        public IQueryable<Course> GetById(int id)
        {
            return teach.GetById(id);
        }

        /// <summary>
        /// 根据课程审核状态查看课程
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Teacher/GetByStatus/{id}/{status}")]
        public List<Course> GetByStatus(int id,int status)
        {
            return teach.GetByStatus(id, status);
        }

        [HttpGet]
        [Route("Teacher/GetCheck/{id}/{status}")]
        public IHttpActionResult GetCheck(int id,int status)
        {


            return Json(teach.GetCheck(id, status));
        }
    }
}