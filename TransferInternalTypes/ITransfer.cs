namespace TransferInternalTypes
{
    public interface ITransfer
    {
        void Transfer(IPerson from, IPerson to, decimal amount);
        void Rollback(string transactionId);
    }
}
