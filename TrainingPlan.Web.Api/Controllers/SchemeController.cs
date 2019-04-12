using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TrainingPlan.Web.Api.Controllers
{
    public class SchemeController : ApiController
    {
        // GET: api/Scheme
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Scheme/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Scheme
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Scheme/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Scheme/5
        public void Delete(int id)
        {
        }
    }
}
