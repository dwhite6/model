using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Models.Interfaces;
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class empolyeesController : ControllerBase
    {
        // GET: api/empolyees
        [EnableCors("AnotherPolicy")]
        [HttpGet]
        public List<Employee> Get()
        {
            IReadAllData readObject = new ReadData();
            return readObject.GetAllEmployees();
        }

        // GET: api/empolyees/5
        [EnableCors("AnotherPolicy")]
        [HttpGet("{id}", Name = "Get")]
        public Employee Get(int id)
        {
            IGetEmployee readObject = new ReadData();
            return readObject.GetEmployee(id);
        }

        // POST: api/empolyees
        [EnableCors("AnotherPolicy")]
        [HttpPost]
        public void Post([FromBody] Employee value)
        {
            ISaveData insertObject = new SaveData();
            insertObject.SaveEmployee(value);
        }

        // PUT: api/empolyees/5
        [EnableCors("AnotherPolicy")]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [EnableCors("AnotherPolicy")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ISaveData insertObject = new SaveData();
            insertObject.DeleteEmployee(id);
        }
    }
}
