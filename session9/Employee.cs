using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session9
{
    internal abstract class Employee
    {
        public string EmployeeName { get; set; }
        public int EmployeeID { get; set; } 
        public string Employeedesignation { get; set; }
        public string EmployeeAdress { get; set; }

        public abstract void EmployeeSalary();
        public void display()
        {
            Console.WriteLine("Name={0}\nID={1}\nDesignation{2}\nAddress={3}",EmployeeName,EmployeeID,Employeedesignation,EmployeeAdress);
        }

    }
}
