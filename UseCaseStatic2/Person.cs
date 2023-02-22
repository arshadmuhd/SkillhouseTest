using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCaseStatic2
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Job { get; set; }
        public int BottlePurchase { get; set; }
        public int RefillBottle { get; set; }

        public void buy()
        {
            BeverageVendingMachine.Buy(BottlePurchase);
        }

        public void Refill()
        {
            BeverageVendingMachine.Refil(RefillBottle);
        }

        public void check()
        {
            BeverageVendingMachine.Check();
        }
    }
}
