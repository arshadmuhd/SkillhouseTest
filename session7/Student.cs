using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session7
{
    internal class Student  
    {
        /*internal Student(string name,int id,string mark)
        {
            this.sName = name;
            this.sId = id;
            this.sMark = mark;
        }*/


        private string sName { get; set; }
        private int sId { get; set; }
        public int sMark { get; set; }

        public void getValues()
        {
            Console.WriteLine("Enter student name:");
             sName=Console.ReadLine();
            Console.WriteLine("Enter student Id:");
             sId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student mark:");
             sMark = Convert.ToInt32(Console.ReadLine());

        }
        public void collegeName()
        {
            Console.WriteLine("SHREE DEVI INSTITUTE");
        }

       public void display()
        {
            Console.WriteLine("Name= {0}\nId= {1}\nMark= {2}",sName,sId,sMark);
            collegeName();
        }
    }
}
