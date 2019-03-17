using System;

namespace HelloInterface.Models
{
    class PayPalCustomer : PersonBase, IPerson
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string EMail { get; set; }
        public decimal WalletAmount { get; set; }
    }
}
