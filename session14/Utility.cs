using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session14
{
    internal class Utility
    {
        //Generic method
        public void DisplayList<T>(List<T> listitem)
        {
            foreach(var item in listitem)
            {
                Console.WriteLine(item);
            }
        }
        /* public void DisplayList(List<int> listitem)
       {
           foreach (var item in listitem)
           {
               Console.WriteLine(item);
           }
       }*/
        /* public void DisplayList(List<double> listitem)
         {
             foreach (var item in listitem)
             {
                 Console.WriteLine(item);
             }
         }*/
    }
}
