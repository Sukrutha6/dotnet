using System;

class Program
{
    public static void Main()
    {
        MyData obj = new MyData();

        obj[0] = "C";
        obj[1] = "C++";
        obj[2] = "C#";

        Console.WriteLine("First: " + obj[0]);
        Console.WriteLine("Second: " + obj[1]);
        Console.WriteLine("Third: " + obj[2]);
    }
}
