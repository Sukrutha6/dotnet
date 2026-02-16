using System;
using StudentIndexer;
class StudentIndexer
{
    static void Main()
    {
        Student s = new Student(101, "Sukrutha", "Hyderabad");

        // Assign books using indexer
        s[0] = "C Programming";
        s[1] = "Data Structures";
        s[2] = "Operating Systems";

        // Display student info
        s.Display();

        Console.WriteLine("Books owned:");
        Console.WriteLine(s[0]);
        Console.WriteLine(s[1]);
        Console.WriteLine(s[2]);
    }
}
