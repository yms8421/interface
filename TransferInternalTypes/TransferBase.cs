namespace TransferInternalTypes
{
    abstract class TransferBase
    {
        //protected => çünkü dışarıdan kullanımlar bu mnethodun direkt kullanılmasını istemiyoruz. Bkz: Cash.cs
        protected void TransferMoney(IPerson from, IPerson to, decimal amount)
        {
            if (from.WalletAmount >= amount)
            {
                to.WalletAmount += amount;
                from.WalletAmount -= amount;
            }
        }
    }
}
