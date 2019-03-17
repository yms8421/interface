using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AloneClassApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var neslihan = Account.GetAccount(1000);
            neslihan.GetCash(100);
            neslihan.GetCash(100);

            var deniz = Account.GetAccount();
            deniz.GetCash(100);

            var gamze = Account.GetAccount();
            gamze.GetCash(1000);
        }
    }
    /// <summary>
    /// Singleton Design Pattern
    /// </summary>
    class Account
    {
        private static Account instance;
        private decimal amount;
        private Account(decimal startValue)
        {
            amount = startValue;
        }
        public decimal Amount { get { return amount; } }

        public void GetCash(decimal amount)
        {
            if (this.amount < amount)
            {
                throw new Exception("Hesapta yeterli miktarda para bulunmamaktadır");
            }
            this.amount -= amount;
        }
        public static Account GetAccount(decimal startValue = 0)
        {
            if (instance == null)
            {
                instance = new Account(startValue);
            }
            else if (startValue > 0)
            {
                throw new Exception("Hesap zaten var. Başlangıç değerini artık belirleyemezsiniz");
            }
            return instance;

            //return new Account(startValue); //bu daha iyi bir yazım stili
        }
    }
}
