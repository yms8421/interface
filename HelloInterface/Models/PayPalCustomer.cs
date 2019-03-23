using System;
using TransferInternalTypes;

namespace HelloInterface.Models
{
    class PayPalCustomer : IPerson
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string EMail { get; set; }
        public decimal WalletAmount { get; set; }
    }
}
