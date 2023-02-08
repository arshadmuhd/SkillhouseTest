using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsecaseInhertance
{
    internal class Student:Lecturer
 
    {
        public int RollNo { get; set; }
        public int TotalMarks { get; set; }
        public string SemesterName { get; set; }
        public Project projectInfo { get; set; }
        public override void Walk()
        {
            Console.WriteLine("Hi, there. My name is {0}. I am walking.", name);
        }
        public override void Work()
        {
            Console.WriteLine("Hi, there. I am learning");
        }

        public void PayFees()
        {
            Console.WriteLine(" I am paying Fees");
        }

    }
}
