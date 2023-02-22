using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCase6
{
    internal class HighSchoolTeacher:Teacher
    {
        public string SubjectTaught { get; set; }
        public void CreateLessonsPlans()
        {
            Console.WriteLine("Create Lessons Plans");
        }
        public void ScheduleParentTeacherConferences()
        {
            Console.WriteLine("Schedule Parent-Teacher Conferences");
        }
    }
}
