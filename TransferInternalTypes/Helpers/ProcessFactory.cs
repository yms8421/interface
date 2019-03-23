using TransferInternalTypes;
using TransferInternalTypes.Enums;
using TransferInternalTypes.Process;

namespace TransferInternalTypes.Helpers
{
    public class ProcessFactory
    {
        public ITransfer GetProcess(ProcessType processType)
        {
            switch (processType)
            {
                case ProcessType.Cash:
                    return new Cash();
                case ProcessType.DirectTransfer:
                    return new DirectTransfer();
                case ProcessType.MobileTransfer:
                    return new MobileTransfer();
                case ProcessType.PayPal:
                    return new PayPal();
                case ProcessType.WesternUnion:
                    return new WesternUnion();
                default:
                    return new object() as ITransfer;//Run time error
            }
        }
    }
}
