using System;
using TransferInternalTypes;

namespace HelloInterface.Models
{
    class BasicPerson : IPerson
    {
        public BasicPerson(string name)
        {
            Id = Guid.NewGuid();
            FullName = name;
        }
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public decimal WalletAmount { get; set; }
        public override string ToString()
        {
            return $"{FullName} - {WalletAmount}";
        }
    }
}
