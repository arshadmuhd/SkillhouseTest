using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticUseCase
{
    internal class BusStopATM
    {
        public static int AtmBalance { get; set; }
        public int DepositAmount { get; set; }
        public int WithdrawAmount { get; set; }

        public void DisplayDepositAmount()
        {
            Console.WriteLine("Deposited Amount {0}",this.DepositAmount);
        }
        public void DisplayWithdrawAmount()
        {
            Console.WriteLine("Withdrawn Amount {0}", this.WithdrawAmount);
        }


    }
}
