using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UseCase6
{
    internal class School
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        
        public void UpdateContactInformation()
        {
            Console.WriteLine("Updated Contact Information");


    }
    }
}
