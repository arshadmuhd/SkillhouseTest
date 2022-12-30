using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session8_Test
{
    internal class Accountant:Employee
    {
        public void work()
        {
            Console.WriteLine("Hi, I am looking at Accounts\n");
        }
        public void display()
        {
            Console.WriteLine("Id={0}\nName={1} {2}\n Age={3}", employeeId, employeeFirstName, employeeLastName, employeeAge);
            work();
        }

    }
}
