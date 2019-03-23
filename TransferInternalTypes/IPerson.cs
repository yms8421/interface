using System;

namespace TransferInternalTypes
{
    public interface IPerson
    {
        Guid Id { get; set; }
        string FullName { get; set; }
        decimal WalletAmount { get; set; }
    }
}
