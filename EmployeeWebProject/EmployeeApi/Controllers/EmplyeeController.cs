using EmployeeApi.Repositories;
using EmployeeManagement.Data.Entities;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmplyeeController : ControllerBase
    {
        public Repository Repository{ get; set; }
        
        public EmplyeeController()
        {
            this.Repository= new Repository();
        }

        [HttpGet("GetAllEmployees")]
        public List<TblEmp> GetAllEmployees()
        {
            return Repository.GetAllEmployees();
        }

        [HttpGet("GetEmployee/{EmpId}")]
        public TblEmp GetEmployee(int EmpId)
        {
            return Repository.GetEmployee(EmpId);
        }

        [HttpDelete("GetEmployee/{EmpId}")]
        public void DeleteEmployee(int EmpId)
        {
             Repository.DeleteEmployee(EmpId);
        }

        [HttpPost("AddEmployee")]
        public void AddEmployee(TblEmp tblEmp)
        {
           TblEmp tblEmp1 = new TblEmp();
            tblEmp1.EmpId = tblEmp.EmpId;
            tblEmp1.EmpName= tblEmp.EmpName;
            tblEmp1.EmpAddress= tblEmp.EmpAddress;
            tblEmp1.EmpSalary = tblEmp.EmpSalary;
            tblEmp1.Designation=tblEmp.Designation;
            Repository.AddEmployee(tblEmp1);
        }

        [HttpPost("UpdateEmployee")]
        public void UpdateEmployee(TblEmp tblEmp)
        {
            TblEmp tblEmp1 = new TblEmp();
            tblEmp1.EmpId = tblEmp.EmpId;
            tblEmp1.EmpName = tblEmp.EmpName;
            tblEmp1.EmpAddress = tblEmp.EmpAddress;
            tblEmp1.EmpSalary = tblEmp.EmpSalary;
            tblEmp1.Designation = tblEmp.Designation;
            Repository.UpdateEmployee(tblEmp1);
        }


    }
}
