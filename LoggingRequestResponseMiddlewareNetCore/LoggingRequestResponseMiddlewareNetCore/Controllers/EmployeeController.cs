using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoggingRequestResponseMiddlewareNetCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoggingRequestResponseMiddlewareNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult<Employee> GetByID(int id)
        {
            var employee = new Employee()
            {
                ID = id,
                FirstName = "firstName",
                LastName = "lastName",
                DateOfBirth = DateTime.Now.AddYears(-30)
            };

            return Ok(employee);
        }
    }
}