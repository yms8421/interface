using HelloInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferInternalTypes.Enums;

namespace HelloInterface
{
    class ProgramOld
    {
        static void Main(string[] args)
        {
            var alper = new BasicPerson("Alper Köklü")
            {
                WalletAmount = 500
            };
            var ali = new BasicPerson("Ali Ercan")
            {
                WalletAmount = 200
            };

            //Cash artık oluşturulamaz çünkü diğer library'de ve internal
            //var cash1 = new Cash();
            //cash1.Transfer(alper, ali, 100);
            
            var gulsah = new PayPalCustomer();
            var fatih = new BankCustomer();
            var berkay = new BankCustomer()
            {
                AccountNumber = "7788924423",
                FullName = "Berkay TÜZEN",
                WalletAmount = 500,
                Curreny = Currency.Lira
            };
            //var bank = new DirectTransfer();
            //bank.Transfer(fatih, gulsah, 125);

            Console.ReadKey();
        }
    }
}
