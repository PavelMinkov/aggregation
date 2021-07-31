namespace Aggregation
{
    public class SpecialDeposit : Deposit
    {
        public SpecialDeposit(decimal Amount, int Period) : base(Amount, Period) { }

        public override decimal Income()
        {
            decimal sum = base.Amount;
            decimal procent = 0.01M;

            for (int i = 0; i < base.Period; i++)
            {
                sum = sum + (sum * procent);
                procent += 0.01M;
            }
            return sum - base.Amount;
        }
    }
}