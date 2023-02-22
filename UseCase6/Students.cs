using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCase6
{
    internal class Students:School
    {
        public string SchoolId { get; set; }
        public string GradeLevel { get; set; }
      
        public void EnrollInClasses()
        {
            Console.WriteLine("Enroll in A class");
        }
        public void ViewGrade()
        {
            Console.WriteLine("Grade=" + GradeLevel);
        }
    }
}
