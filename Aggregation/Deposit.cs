namespace Aggregation
{
    public abstract class Deposit
    {
        public readonly decimal amount;
        public readonly int period;

        public decimal Amount
        {
            get { return amount; }
        }

        public int Period
        {
            get { return period; }
        }

        public Deposit(decimal depositAmount, int depositPeriod)
        {
            amount = depositAmount;
            period = depositPeriod;
        }

        public abstract decimal Income();

    }
}