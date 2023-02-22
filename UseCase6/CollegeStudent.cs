using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCase6
{
    internal class CollegeStudent:Students
    {
        public string Major { get; set; }
        public string Minor { get; set; }
        public void RegisterForExam()
        {
            Console.WriteLine("Registered for Exam");
        }
        public void ApplyforGraduation()
        {
            Console.WriteLine("Applied for Graduation");
        }
    }
}
