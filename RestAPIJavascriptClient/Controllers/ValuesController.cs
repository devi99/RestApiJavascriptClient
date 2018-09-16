using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestAPIJavascriptClient.DTO;

namespace RestAPIJavascriptClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<JSONPost> Get(int id)
        {
            JSONPost returnData = new JSONPost
            {
                Name = "naam",
                Email = "test@test.com"
            };
            return returnData;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] JSONPost value)
        {
            var testname = value.Name;
            var testpwd = value.Email;

            return;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
