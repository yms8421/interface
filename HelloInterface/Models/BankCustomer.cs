﻿using TransferInternalTypes.Enums;
using System;
using TransferInternalTypes;

namespace HelloInterface.Models
{
    class BankCustomer : IPerson
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string AccountNumber { get; set; }
        public Currency Curreny { get; set; }
        public decimal WalletAmount { get; set; }
    }
}
