using System;
class Program
{
    static bool isPrime(int n)
    {
        if (n <= 1) return false;
        if (n <= 3) return true;

        if (n % 2 == 0 || n % 3 == 0) return false;

        for (int i = 5; i * i <= n; i += 6)
        {
            if (n % i == 0 || n % (i + 2) == 0)
                return false;
        }
        return true;
    }

    static void Main()
    {
        Console.WriteLine("Hello, World!");
        string? name = Console.ReadLine();
        int num = 26;
        bool ans = isPrime(num);
        Console.WriteLine(ans);
         Console.Write("Enter your age: ");
        string? input = Console.ReadLine();
         if (int.TryParse(input, out int age))
        {
            Console.WriteLine("Valid age entered: " + age);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }
}
