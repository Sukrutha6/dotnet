// 1. Reverse a string without using built-in functions.

// using System;
// using System.Globalization;
// class Program
// {
//     static void Main()
//     {
//         string input = "hello";
//         char[] reversed = new char[input.Length];
//         for(int i=0; i<input.Length; i++)
//         {
//             reversed[i] = input[input.Length-1-i];
//         }
//         Console.WriteLine(new string(reversed));
//     }
// }

// 2. Find the largest element in an integer array.

// using System;
// class Program
// {
//     static void Main()
//     {
//         int[] numbers = {3, 5, 2, 8, 1};
//         int max = numbers[0];
//         foreach(int num in numbers)
//         {
//             if(num>max) max=num;
//         }
//         Console.WriteLine($"Largest number: {max}");
//     }
// }

// 3. Remove duplicates from a list using a HashSet.

// using System;
// class Program
// {
//     static void Main()
//     {
//         List<int> numbers = new List<int> {1, 2, 3, 2, 4, 1, 5};
//         HashSet<int> uniqueNumbers = new HashSet<int> (numbers);
//         Console.WriteLine(string.Join(", ", uniqueNumbers));
//     }
// }

// 4. Find the frequency of elements in an array using a Dictionary.

// using System;
// class Program
// {
//     static void Main()
//     {
//         int[] numbers = {1, 2, 2, 3, 3, 3, 4};
//         Dictionary<int, int> frequency = new Dictionary<int, int>();

//         foreach(int num in numbers)
//         {
//             if(frequency.ContainsKey(num))
//             {
//                 frequency[num]++;
//             }
//             else
//             {
//                 frequency[num] = 1;
//             }
//         }

//         foreach(var kvp in frequency)
//         {
//             Console.WriteLine($"Number: {kvp.Key}, Frequency: {kvp.Value}");
//         }
//     }
// }

// 5. Check if a given string is a palindrome.

using System;
class Program
{
    static void Main()
    {
        string input = "racecar";
        bool isPalindrome = true;
        for(int i=0; i<input.Length/2; i++)
        {
            if(input[i] != input[input.Length - 1 - i])
            {
            isPalindrome = false;
                break;
            }
        }
        Console.WriteLine(isPalindrome ? "Palindrome" : "Not a palindrome");
    }
}