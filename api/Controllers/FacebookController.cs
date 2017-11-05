using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api.Controllers
{
    public class FacebookController : ApiController
    {
        // GET: api/Facebook
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Facebook/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Facebook
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Facebook/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Facebook/5
        public void Delete(int id)
        {
        }
    }
}
