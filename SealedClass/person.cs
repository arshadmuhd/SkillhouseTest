using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{
    internal sealed class person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }   
    }
}
