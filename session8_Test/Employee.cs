using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session8_Test
{
    internal class Employee
    {
        protected int employeeId { get; set; }
        protected string employeeFirstName { get; set; }
        protected string employeeLastName { get; set; }
        protected int employeeAge { get; set; }

        /*public void getId(int id)
        {
            employeeId = id;
        }*/
        public void getValues(int id,string fname, string lname,int age)
        {
            employeeId = id;
            employeeFirstName = fname;
            employeeLastName = lname;
            employeeAge = age;
        }
        /*public void getLname(string lname)
        {
            employeeLastName = lname;
        }
        public void getAge(int age)
        {
            employeeAge = age;
        }*/
    }
}
