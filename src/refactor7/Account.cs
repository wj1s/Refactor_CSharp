namespace refactor7
{
    public class Account
    {
        private readonly int daysOverdrawn;
        private readonly AccountType accountType;

        public Account(AccountType accountType, int daysOverdrawn)
        {
            this.accountType = accountType;
            this.daysOverdrawn = daysOverdrawn;
        }

        public double OverdraftCharge()
        {
            if (accountType.isPremium())
            {
                double result = 10;
                if (daysOverdrawn > 7) result += (daysOverdrawn - 7)*0.85;
                return result;
            }
            return daysOverdrawn*1.75;
        }

        public double BankCharge()
        {
            return 4.5 + OverdraftCharge();
        }
    }
}
