namespace Aggregation
{
    public class LongDeposit : Deposit
    {
        public LongDeposit(decimal Amount, int Period) : base(Amount, Period) { }

        public override decimal Income()
        {
            decimal sum = base.Amount;
            decimal procent = 0.15M;

            if (base.Period > 6)
                for (int i = 0; i < base.Period - 6; i++)
                {
                    sum = sum + (sum * procent);
                }
            return sum - base.Amount;
        }
    }
}