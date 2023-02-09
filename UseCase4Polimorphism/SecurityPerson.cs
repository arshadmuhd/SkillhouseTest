using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCase4
{
    internal class SecurityPerson:Employee
    {
        public override void Walk()
        {
            Console.WriteLine("Hi, there. My name is {0}. I am walking", Name);

        }
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
