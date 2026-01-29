// using System;
// using System.Text.RegularExpressions;
// class Program
// {
//     static void Main()
//     {
//         string input = "Error: TIMEOUT while calling API";
//         string pattern = @"timeout";

//         var rx = new Regex(
//             pattern,
//             RegexOptions.IgnoreCase,
//             TimeSpan.FromMilliseconds(0.5) // match timeout
//         );

//         Console.WriteLine(rx.IsMatch(input) ? "Found" : "Not Found");
//     }
// }

//=======================================================================================//

// using System;
// class Program
// {
//     public static void Main()
//     {
//         var list=new List<byte[]>();
//         for(int i = 0; i < 300000; i++)
//         {
//             list.Add(new byte[1024]);

//         }
//         Console.WriteLine("Allocate");
//         Console.WriteLine("Total memory: " + GC.GetTotalMemory(forceFullCollection: false));
//     }
// }

//=======================================================================================//

// using System;
// class Program
// {
//     public static void Main()
//     {
//         var list=new List<double[]>();
//         for(int i = 0; i < 300000; i++)
//         {
//             list.Add(new double[1024]);

//         }
//         Console.WriteLine("Allocate");
//         Console.WriteLine("Total memory: " + GC.GetTotalMemory(forceFullCollection: false));
//     }
// }

//=======================================================================================//


// using System;
// using ExtentionMethodDemo;
// namespace ExtentionMethodDemo
// {
// class Program
// {
//     public static void Main()
//     {
//         BigMan obj = new BigMan();

//         obj.Names.Add("Karthik");
//         obj.Names.Add("Sukrutha");
//         obj.Names.Add("Honey");

//         Console.WriteLine("Before Dispose:");
//         foreach (var name in obj.Names)
//             Console.WriteLine(name);

//         obj.Dispose();

//         Console.WriteLine("\nAfter Dispose:");

//         if (obj.Names == null)
//             Console.WriteLine("Names collection released successfully.");
//         else
//             Console.WriteLine("Still allocated.");
//     }
// }
// }

//=======================================================================================//

using System;
using Generics;

class Program
{
    static void Main()
    {
        MyCollection c = new MyCollection();

        c.Add("Sukrutha");
        c.Add("Karthik");
        c.Add("Honey");

        Console.WriteLine(c.Contains("Karthik"));
        Console.WriteLine(c.Count);

        c.Clear();
        Console.WriteLine(c.Count);
    }
}
