using System;

class Program
{
    public static bool Valid(string email)
    {
        bool check = false;

        if (email.EndsWith("@gmail.com") &&
            email.Count(c => c == '@') == 1 &&
            email.Count(c => c == '.') == 1)
        {
            check = true;
        }

        return check;
    }

    public static void Main()
    {
        string email = Console.ReadLine();

        if (string.IsNullOrEmpty(email))
        {
            Console.WriteLine(false);
            return;
        }

        bool check = Valid(email);
        Console.WriteLine(check);
    }
}
