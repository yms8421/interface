using HelloInterface.Enums;
using HelloInterface.Models;
using HelloInterface.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var alper = new BasicPerson
            {
                WalletAmount = 500
            };
            var ali = new BasicPerson
            {
                WalletAmount = 200
            };

            var cash1 = new Cash();
            cash1.Transfer(alper, ali, 100);
            
            var gulsah = new PayPalCustomer();
            var fatih = new BankCustomer();
            var berkay = new BankCustomer()
            {
                AccountNumber = "7788924423",
                FullName = "Berkay TÜZEN",
                WalletAmount = 500,
                Curreny = Currency.Lira
            };


            Console.ReadKey();
        }
    }
}
