using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using TestWebApp.Models;

namespace TestWebApp.Controllers
{
    public class ValiController : ApiController
    {
        // POST api/values
        public IHttpActionResult Post([FromBody]MyModel value)
        {
            var serialized = JsonConvert.SerializeObject(value);
            return Ok(new {test = serialized});
        }
    }
}
