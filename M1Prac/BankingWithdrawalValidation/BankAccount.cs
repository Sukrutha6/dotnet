using System;

public class BankAccount
{
    private int balance;

    public BankAccount(int initialBalance)
    {
        balance = initialBalance;
    }

    public void Withdraw(int amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be greater than zero.");
        }

        if (amount > balance)
        {
            throw new InvalidOperationException("Insufficient balance.");
        }

        balance -= amount;
        Console.WriteLine($"Remaining Balance: {balance}");
    }
}
