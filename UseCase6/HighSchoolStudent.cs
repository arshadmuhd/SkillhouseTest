using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCase6
{
    internal class HighSchoolStudent:Students
    {
        public int Gpa { get; set; }
        public string ExtraCurricularActivities { get; set; }
        public void RequestTranscript()
        {
            Console.WriteLine("Responded a transcript");
        }
        public void RecomendationLetter()
        {
            Console.WriteLine("Recomendation letter from MLA");
        }
    }
}
