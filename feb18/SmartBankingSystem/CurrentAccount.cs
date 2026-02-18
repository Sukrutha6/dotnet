using SmartBankingSystem.Exceptions;

namespace SmartBankingSystem.Models
{
    public class CurrentAccount : BankAccount
    {
        private const decimal OverdraftLimit = 50000;

        public CurrentAccount(string accNo, string name, decimal balance)
            : base(accNo, name, balance) { }

        public override void Withdraw(decimal amount)
        {
            if (Balance - amount < -OverdraftLimit)
                throw new InsufficientBalanceException("Overdraft limit exceeded.");

            Balance -= amount;
            TransactionHistory.Add($"Withdrawn: {amount}");
        }

        public override decimal CalculateInterest()
        {
            return 0;
        }
    }
}
