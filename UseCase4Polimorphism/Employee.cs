using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCase4
{
    internal abstract class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        
        
        public ContactInformation Contact { get; set; }

        

        public abstract void Walk()
        {
            Console.WriteLine("Hi, there. I am managngthe store.");
        }
        public abstract void Work();




    }
}
