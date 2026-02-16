// using System;
// class Employee
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public Employee(int id, string name)
//     {
//         Id = id;
//         Name = name;
//     }

//     public void Display()
//     {
//         Console.WriteLine("Employee Id   : " + Id);
//         Console.WriteLine("Employee Name : " + Name);
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Employee emp1 = new Employee(101, "Sukrutha");
//         Employee emp2 = new Employee(102, "Karthik");

//         emp1.Display();
//         Console.WriteLine();
//         emp2.Display();

//         Console.ReadLine(); 
//     }
// }


using System;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public void Display()
    {
        Console.WriteLine("Employee Id   : " + Id);
        Console.WriteLine("Employee Name : " + Name);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee emp1 = new Employee
        {
            Id = 101,
            Name = "Sukrutha"
        };

        Employee emp2 = new Employee
        {
            Id = 102,
            Name = "Karthik"
        };
        emp1.Display();
        Console.WriteLine();
        emp2.Display();

        Console.ReadLine();
    }
}
