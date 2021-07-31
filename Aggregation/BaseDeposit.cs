namespace Aggregation
{
    public class BaseDeposit : Deposit
    {
        public BaseDeposit(decimal Amount, int Period) : base(Amount, Period) { }

        public override decimal Income()
        {
            decimal sum = base.Amount;
            decimal procent = 0.05M;

            for (int i = 0; i < base.Period; i++)
            {
                sum = sum + (sum * procent);
            }
            return sum - base.Amount;
        }
    }
}