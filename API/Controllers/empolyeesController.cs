using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mis321_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class empolyeesController : ControllerBase
    {
        // GET: api/empolyees
        [EnableCors("Another policy")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/empolyees/5
        [EnableCors("Another policy")]
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/empolyees
        [EnableCors("Another policy")]
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/empolyees/5
        [EnableCors("Another policy")]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [EnableCors("Another policy")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
