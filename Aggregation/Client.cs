namespace Aggregation
{
    public class Client
    {
        private readonly Deposit[] deposits;

        public Client()
        {
            deposits = new Deposit[10];
        }

        public bool AddDeposit(Deposit deposit)
        {
            for (int i = 0; i < deposits.Length; i++)
                if (deposits[i] == null)
                {
                    deposits[i] = deposit;
                    return true;
                }
            return false;
        }

        public decimal TotalIncome()
        {
            decimal res = 0;

            for (int i = 0; i < deposits.Length; i++)
            {
                if (deposits[i] != null)
                    res += deposits[i].Income();
            }
            return res;
        }

        public decimal MaxIncome()
        {
            decimal max_income = deposits[0].Income();

            for (int i = 0; i < deposits.Length; i++)
            {
                if (deposits[i] != null && max_income < deposits[i].Income())
                {
                    max_income = deposits[i].Income();
                }
            }
            return max_income;
        }
        public decimal GetIncomeByNumber(int i)
        {
            decimal res = 0;
            if (deposits[i--] != null)
            {
                res = deposits[i].Income();
            }
            return res;
        }
    }
}