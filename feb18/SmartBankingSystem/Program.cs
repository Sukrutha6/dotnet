using System;
using System.Collections.Generic;
using System.Linq;
using SmartBankingSystem.Models;
using SmartBankingSystem.Exceptions;

namespace SmartBankingSystem
{
    class Program
    {
        static List<BankAccount> accounts = new();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n===== SMART BANKING SYSTEM =====");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Transfer");
                Console.WriteLine("5. Show LINQ Reports");
                Console.WriteLine("6. Exit");

                var choice = Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1": CreateAccount(); break;
                        case "2": Deposit(); break;
                        case "3": Withdraw(); break;
                        case "4": Transfer(); break;
                        case "5": ShowReports(); break;
                        case "6": return;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        static void CreateAccount()
        {
            Console.Write("Type (S/C/L): ");
            string type = Console.ReadLine();

            Console.Write("Account No: ");
            string accNo = Console.ReadLine();

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Initial Balance: ");
            decimal balance = decimal.Parse(Console.ReadLine());

            BankAccount account = type switch
            {
                "S" => new SavingsAccount(accNo, name, balance),
                "C" => new CurrentAccount(accNo, name, balance),
                "L" => new LoanAccount(accNo, name, balance),
                _ => throw new InvalidTransactionException("Invalid type")
            };

            accounts.Add(account);
        }

        static BankAccount Find(string accNo)
            => accounts.First(a => a.AccountNumber == accNo);

        static void Deposit()
        {
            Console.Write("Account No: ");
            Find(Console.ReadLine()).Deposit(decimal.Parse(Console.ReadLine()));
        }

        static void Withdraw()
        {
            Console.Write("Account No: ");
            Find(Console.ReadLine()).Withdraw(decimal.Parse(Console.ReadLine()));
        }

        static void Transfer()
        {
            Console.Write("From: ");
            var from = Find(Console.ReadLine());

            Console.Write("To: ");
            var to = Find(Console.ReadLine());

            Console.Write("Amount: ");
            from.Transfer(to, decimal.Parse(Console.ReadLine()));
        }

        static void ShowReports()
        {
            Console.WriteLine("\nAccounts with Balance > 50,000:");
            var rich = accounts.Where(a => a.Balance > 50000);
            foreach (var a in rich)
                Console.WriteLine(a.CustomerName);

            Console.WriteLine("\nTotal Bank Balance:");
            Console.WriteLine(accounts.Sum(a => a.Balance));

            Console.WriteLine("\nTop 3 Highest Balance:");
            var top3 = accounts.OrderByDescending(a => a.Balance).Take(3);
            foreach (var a in top3)
                Console.WriteLine(a.CustomerName);

            Console.WriteLine("\nGroup By Account Type:");
            var grouped = accounts.GroupBy(a => a.GetType().Name);
            foreach (var g in grouped)
                Console.WriteLine($"{g.Key}: {g.Count()}");

            Console.WriteLine("\nCustomers starting with R:");
            var rNames = accounts.Where(a => a.CustomerName.StartsWith("R"));
            foreach (var a in rNames)
                Console.WriteLine(a.CustomerName);
        }
    }
}
