using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCase6
{
    internal class Teacher:School
    {
        public string EmployeeId { get; set; }
        public string Department { get; set; }
        
        public void ViewSchedule()
        {
            Console.WriteLine("View schedule");
        }
        public void EnterGrades()
        {
            Console.WriteLine("Enter Grades");
        }
    }
}
