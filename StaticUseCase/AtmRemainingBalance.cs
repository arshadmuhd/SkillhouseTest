using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StaticUseCase
{
    internal static class AtmRemainingBalance
    {
        public static int Atmbalance { get; set; }
        
        public static void RemainingBalanceInAtm()
        {
            
            Console.WriteLine("Balnce is {0}", Atmbalance);
        }
    }
}
