namespace refactor7
{
    public class Account
    {
        private readonly int daysOverdrawn;
        private readonly AccountType type;

        public Account(AccountType type, int daysOverdrawn)
        {
            this.type = type;
            this.daysOverdrawn = daysOverdrawn;
        }

        private double OverdraftCharge()
        {
            if (type.isPremium())
            {
                double result = 10;
                if (daysOverdrawn > 7) result += (daysOverdrawn - 7)*0.85;
                return result;
            }
            return daysOverdrawn*1.75;
        }

        public double BankCharge()
        {
            var result = 4.5;
            if (daysOverdrawn > 0)
            {
                result += OverdraftCharge();
            }
            return result;
        }
    }
}
