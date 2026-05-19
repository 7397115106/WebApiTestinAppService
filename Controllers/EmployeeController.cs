using Microsoft.AspNetCore.Mvc;

namespace Test_My_New_Webapi_application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employees = new List<string>
            {
                "Harish",
                "Ravi",
                "Kiran",
                "Pavan",
                "Rajesh"
            };

            return Ok(employees);
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            return Ok($"Employee Id: {id}");
        }

        [HttpPost]
        public IActionResult AddEmployee(string name)
        {
            return Ok($"Employee Added: {name}");
        }
    }
}
