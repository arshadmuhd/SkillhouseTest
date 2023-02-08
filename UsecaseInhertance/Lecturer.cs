using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace UsecaseInhertance
{
    internal class Lecturer
    {
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public  Department deprt { get; set; }
        public double salary { get; set; }
        public ContactInformation contact { get; set; }
        public virtual void Walk()
        {
            Console.WriteLine("Hi, there. My name is {0}. I am walking", name);
        }
        public virtual void Work()
        {
            Console.WriteLine("Hi, there. I am teaching to my students");
        }
        public void GetSalary() 
        {
            Console.WriteLine(" Thank you for the salary");
        }

    }
}
