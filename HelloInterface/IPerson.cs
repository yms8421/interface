using System;

namespace HelloInterface
{
    interface IPerson
    {
        Guid Id { get; set; }
        string FullName { get; set; }
        decimal WalletAmount { get; set; }
    }
}
