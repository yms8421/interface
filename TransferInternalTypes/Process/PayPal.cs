﻿using System;

namespace TransferInternalTypes.Process
{
    class PayPal : TransferBase, ITransfer
    {
        public void Rollback(string transactionId)
        {
            throw new NotImplementedException();
        }

        public void Transfer(IPerson from, IPerson to, decimal amount)
        {
            Console.WriteLine("PayPal Para Gönderimi");
            //100 satır kod - bazı kurallar ve kontroller
            base.TransferMoney(from, to, amount);
        }
    }
}
