using EmployeeWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> EmpDetails = new List<Employee>()
        {
            new Employee
            {
                EmployeeId=1001,
                EmployeeAge=26,
                EmployeeName="Arshad",
                Address="Kerala"
            },
              new Employee
            {
                EmployeeId=1002,
                EmployeeAge=23,
                EmployeeName="Rahul",
                Address="mangalore"
            },
                new Employee
            {
                EmployeeId=1003,
                EmployeeAge=25,
                EmployeeName="Ajmal",
                Address="pune"
            },
        };


        [HttpGet("GetAllEmployees")]
        public List<Employee> GetAllEmployees() => EmpDetails;


        [HttpGet("GetEmployee")]
        public Employee GetEmployee(int id)
        {
            var EmployeeDetails = EmpDetails.Where(d => d.EmployeeId == id).FirstOrDefault();
            return EmployeeDetails;
        }

        [HttpPost("AddEmployee")]
        public void AddEmployee(Employee employee)
        {
            EmpDetails.Add(employee);
        }

        [HttpDelete("DeleteEmployee")]
        public void DeleteEmployee(int id)
        {
            var EmployeeDetails = EmpDetails.Where(d => d.EmployeeId == id).FirstOrDefault();
            EmpDetails.Remove(EmployeeDetails);
        }

    }
}
