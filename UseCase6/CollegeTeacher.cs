using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCase6
{
    internal class CollegeTeacher:Teacher
    {
        public string ResearchAreas { get; set; }
        public string Publications { get; set;}
        public void ApplyforGrants()
        {
            Console.WriteLine("Apply for Grants");
        }
        public void ScheduleOfficeHours()
        {
            Console.WriteLine("Schedule Office Hours");
        }
    }
}
