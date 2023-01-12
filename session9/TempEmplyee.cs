using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session9
{
    internal class TempEmplyee:Employee
    {
        public int salaryPerHour { get; set; }
        public int totalHour { get; set; }
        public override void EmployeeSalary()
        {
            Console.WriteLine("salary={0}", salaryPerHour * totalHour);
        }
    }
}
