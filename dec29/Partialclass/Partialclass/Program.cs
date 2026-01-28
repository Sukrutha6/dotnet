using System;
using Partialclass;
namespace Partialclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Checker checker = new Checker();

            checker.ID = 20;
            checker.Number = 30;
            checker.Name = "Sukrutha";

            Console.WriteLine("Addition: " + checker.Addd());
            Console.WriteLine(checker.Display());
        }
    }
}
