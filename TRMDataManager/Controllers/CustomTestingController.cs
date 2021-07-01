using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using TRMDataManager.Library.Models;
using TRMDataManager.Library.DataAccess;

namespace TRMDataManager.Controllers
{
    public class CustomTestingController : ApiController
    {
        // GET api/<controller>
        [AllowAnonymous]
        [HttpGet]
        public async Task<IEnumerable<TestingModel>> Get()
        {
            TestingModelData data = new TestingModelData();
            return data.GetTestingBlogs();
        }
    }
}