using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session10
{
    internal class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeAge { get; set; }
        public int salary { get; set; }
        public Work Work { get; set; }

        public void display()
        {
            Console.WriteLine("name={0}\nId={1}\nAge={2}",EmployeeName,EmployeeID,EmployeeAge);
        }

    }
}
