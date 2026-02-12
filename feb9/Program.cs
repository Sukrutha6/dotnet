using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        await SaveAsync();                // Task (no return)
        int total = await GetTotalAsync(); // Task<int> (returns value)
        Console.WriteLine(total);
    }

    static async Task SaveAsync()
    {
        await Task.Delay(300); // pretend we saved to DB
        Console.WriteLine("Saved!");
    }

    static async Task<int> GetTotalAsync()
    {
        await Task.Delay(300); // pretend we calculated
        return 42;
    }
}