using SmartBankingSystem.Exceptions;

namespace SmartBankingSystem.Models
{
    public class SavingsAccount : BankAccount
    {
        private const decimal MinBalance = 1000;

        public SavingsAccount(string accNo, string name, decimal balance)
            : base(accNo, name, balance) { }

        public override void Withdraw(decimal amount)
        {
            if (Balance - amount < MinBalance)
                throw new MinimumBalanceException("Minimum balance must be maintained.");

            base.Withdraw(amount);
        }

        public override decimal CalculateInterest()
        {
            return Balance * 0.04m;
        }
    }
}
