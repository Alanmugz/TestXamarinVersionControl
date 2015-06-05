using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Test1.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "Alan Mulligan", "John Murphy", "Mary O'Neil" };
        }

        // GET api/values/5
        public int Get(int id)
        {
            return id;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        	Console.WriteLine("Inserted!!")
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
			Console.WriteLine("Deleted!!")
        }
    }
}