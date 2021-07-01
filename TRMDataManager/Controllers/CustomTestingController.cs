using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using TRMDataManager.Library.DataAccess

namespace TRMDataManager.Controllers
{
    public class CustomTestingController : ApiController
    {
        // GET api/<controller>
        [AllowAnonymous]
        [HttpGet]
        [Route("api/calldb")]
        public async Task<IEnumerable<TestingModel>> Get()
        {

        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}