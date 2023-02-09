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
        public double Salary { get; set; }
        public Store StoreInfo { get; set; }
        public ContactInformation Contact { get; set; }

        public ShiftTime Shift { get; set; }

        public abstract void Walk();
        public abstract void Work();




    }
}
