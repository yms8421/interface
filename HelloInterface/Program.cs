
using HelloInterface.Models;
using System;
using TransferInternalTypes.Enums;
using TransferInternalTypes.Helpers;

namespace HelloInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlamalar
            var alper = new BasicPerson("Alper Köklü")
            {
                WalletAmount = 500
            };
            var ali = new BasicPerson("Ali Ercan")
            {
                WalletAmount = 200
            };
            #endregion

            var factory = new ProcessFactory();
            while (true)
            {
                var type = GetProcessType();
                var service = factory.GetProcess(type);
                service.Transfer(alper, ali, 100);

                Console.WriteLine(alper);
                Console.WriteLine(ali);

                Console.WriteLine("Devam Etmek için bir tuşa basınız");
                Console.ReadKey();
            }
        }

        static ProcessType GetProcessType()
        {
            while (true)
            {
                Console.Write("Süreç Türü Seçiniz....: ");
                var t = Console.ReadKey();
                Console.WriteLine();
                int.TryParse(t.KeyChar.ToString(), out int value);
                if (value > 0 && value <= 5)
                {
                    return (ProcessType)value;
                }
            }
        }
    }
}
