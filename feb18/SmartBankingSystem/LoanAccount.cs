using System;

namespace SmartBankingSystem.Models
{
    public class LoanAccount : BankAccount
    {
        public LoanAccount(string accNo, string name, decimal loanAmount)
            : base(accNo, name, -loanAmount) { }

        public override void Deposit(decimal amount)
        {
            throw new InvalidTransactionException("Loan accounts cannot deposit.");
        }

        public override decimal CalculateInterest()
        {
            return Balance * 0.08m;
        }
    }
}
