using System;

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount(10000);

        Console.WriteLine("Enter withdrawal amount:");
        int amount = int.Parse(Console.ReadLine());

        try
        {
            account.Withdraw(amount);
            Console.WriteLine("Withdrawal successful!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Transaction logged.");
        }
    }
}
