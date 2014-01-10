namespace refactor7
{
    public class AccountType
    {
        private readonly bool premium;

        public AccountType(bool premium)
        {
            this.premium = premium;
        }

        public bool isPremium()
        {
            return premium;
        }
    }
}