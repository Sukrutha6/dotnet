using System;
using StudentIndexer;
class StudentIndexer
{
    // Public properties
    public int Rno { get; set; }
    public string Name { get; set; }

    // Private field
    private string address;

    // Array to store books
    private string[] books = new string[5];

    // Constructor
    public Student(int rno, string name, string address)
    {
        Rno = rno;
        Name = name;
        this.address = address;
    }

    // Indexer for books
    public string this[int index]
    {
        get
        {
            return books[index];
        }
        set
        {
            books[index] = value;
        }
    }

    // Method to display student details
    public void Display()
    {
        Console.WriteLine("Roll No: " + Rno);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Address: " + address);
    }
}