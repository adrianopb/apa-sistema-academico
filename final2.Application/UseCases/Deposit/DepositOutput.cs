using final2.Application.Outputs;

namespace final2.Application.UseCases.Deposit
{
    public class DepositOutput
    {
        public TransactionOutput Transaction { get; private set; }
        public double UpdatedBalance { get; private set; }
        public DepositOutput()
        {

        }

        public DepositOutput(TransactionOutput transaction, double updatedBalance)
        {
            Transaction = transaction;
            UpdatedBalance = updatedBalance;
        }
    }
}
