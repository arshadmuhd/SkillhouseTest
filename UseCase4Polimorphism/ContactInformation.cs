using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCase4
{
    internal class ContactInformation
    {
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public double PhoneNumber { get; set; }
    }
}
