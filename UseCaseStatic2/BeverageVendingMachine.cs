using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCaseStatic2
{
    internal static class BeverageVendingMachine
    {
        public static string Name { get; set; }
        public static int  CurrrentInventory { get; set; }
        public static void Buy(int BuyCount)
        {
            CurrrentInventory-=BuyCount;
            Console.WriteLine("no of Bottles Purchased={0}", BuyCount);
            Check();
        }

        public static void Check()
        {
            
            Console.WriteLine("Currrent no of Bottles={0}",CurrrentInventory);
        }

        public static void Refil(int Recount)
        {
            CurrrentInventory+=Recount;
            Console.WriteLine("no of Bottles Refilled={0}",Recount);
            Check();
        }

    }
}
