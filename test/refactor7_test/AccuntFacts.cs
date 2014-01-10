using Xunit;
using refactor7;

namespace refactor7_test
{
    public class AccuntFacts
    {
        [Fact]
        public void should_get_bank_charge_when_days_less_than_1()
        {
            var account = new Account(new AccountType(true), 0);
            Assert.Equal(14.5, account.BankCharge());
        }
        
        [Fact]
        public void should_get_bank_charge_when_isPremium_and_days_less_than_7()
        {
            var account = new Account(new AccountType(true), 2);
            Assert.Equal(14.5, account.BankCharge());
        }
        
        [Fact]
        public void should_get_bank_charge_when_isPremium_and_days_more_than_7()
        {
            var account = new Account(new AccountType(true), 8);
            Assert.Equal(15.35, account.BankCharge());
        }
        
        [Fact]
        public void should_get_bank_charge_when_not_isPremium()
        {
            var account = new Account(new AccountType(false), 8);
            Assert.Equal(18.5, account.BankCharge());
        }

//step2 to unlock
//        [Fact]
//        public void should_get_overdraft_charge()
//        {
//            var account = new Account(new AccountType(false), 8);
//            Assert.Equal(14, account.OverdraftCharge());
//        }
    }
}
