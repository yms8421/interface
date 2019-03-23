using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferInternalTypes.Process
{
    class DirectTransfer : TransferBase, ITransfer
    {
        public void Rollback(string transactionId)
        {
            throw new NotImplementedException();
        }

        public void Transfer(IPerson from, IPerson to, decimal amount)
        {
            Console.WriteLine("Havale Para Gönderimi");
            //100 satır kod - bazı kurallar ve kontroller
            base.TransferMoney(from, to, amount);
        }
    }
}
