using EmployeeManagement.Data.Entities;

namespace EmployeeApi.Repositories
{
    public class Repository
    {
        public EmployeeMangamentSysytemContext EmployeeMangamentSysytemContext { get; set; }
        public Repository()
        {
            this.EmployeeMangamentSysytemContext = new EmployeeMangamentSysytemContext();
        }

        public List<TblEmp> GetAllEmployees()
        {
            return EmployeeMangamentSysytemContext.TblEmps.ToList();
        }

        public TblEmp GetEmployee(int EmpId)
        {
            var Emp = EmployeeMangamentSysytemContext.TblEmps.Where(d => d.EmpId == EmpId).FirstOrDefault();
            return Emp;

        }

        public void DeleteEmployee(int EmpId)
        {
            var Emp = EmployeeMangamentSysytemContext.TblEmps.Where(d => d.EmpId == EmpId).FirstOrDefault();
            EmployeeMangamentSysytemContext.TblEmps.Remove(Emp);
            EmployeeMangamentSysytemContext.SaveChanges();



        }

        public void AddEmployee(TblEmp tblEmp)
        {
            EmployeeMangamentSysytemContext.Add(tblEmp);
            EmployeeMangamentSysytemContext.SaveChanges();
        }
        public void UpdateEmployee(TblEmp tblEmp)
        {
            EmployeeMangamentSysytemContext.Update(tblEmp);
            EmployeeMangamentSysytemContext.SaveChanges();
        }


    }
}
