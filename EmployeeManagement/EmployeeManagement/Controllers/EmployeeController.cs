using EmployeeManagement.Repository.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [Authorize]
    [Route("api/[Controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployee _IEmployee;
        public EmployeeController(IEmployee employee)
        {
           _IEmployee= employee;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAllEmployee()
        {

            return Ok(_IEmployee.GetAll());
        }
    }
}
