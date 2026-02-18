using System;
using System.Collections.Generic;
using SmartBankingSystem.Exceptions;

namespace SmartBankingSystem.Models
{
    public abstract class BankAccount
    {
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public decimal Balance { get; protected set; }

        public List<string> TransactionHistory { get; set; } = new();

        protected BankAccount(string accNo, string name, decimal balance)
        {
            AccountNumber = accNo;
            CustomerName = name;
            Balance = balance;
        }

        public virtual void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new InvalidTransactionException("Deposit must be positive.");

            Balance += amount;
            TransactionHistory.Add($"Deposited: {amount}");
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new InvalidTransactionException("Withdrawal must be positive.");

            if (amount > Balance)
                throw new InsufficientBalanceException("Insufficient balance.");

            Balance -= amount;
            TransactionHistory.Add($"Withdrawn: {amount}");
        }

        public abstract decimal CalculateInterest();

        public void Transfer(BankAccount toAccount, decimal amount)
        {
            Withdraw(amount);
            toAccount.Deposit(amount);

            TransactionHistory.Add($"Transferred {amount} to {toAccount.AccountNumber}");
        }
    }
}
