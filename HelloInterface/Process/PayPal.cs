using System;

namespace HelloInterface.Process
{
    class PayPal : TransferBase, ITransfer
    {
        public void Rollback(string transactionId)
        {
            throw new NotImplementedException();
        }

        public void Transfer(IPerson from, IPerson to, decimal amount)
        {
            base.TransferMoney(from, to, amount);
        }
    }
}
