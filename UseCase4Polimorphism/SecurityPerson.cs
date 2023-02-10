using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCase4
{
    internal class SecurityPerson:Employee
    {
        public ShiftTime Shift { get; set; }


        public override void Work()
        {
            Console.WriteLine("Hi, there. I am working as security.");
        }
        public void OpenDoor()
        {
            Console.WriteLine(" I open the door and greet customers.");
        }
    }
}
