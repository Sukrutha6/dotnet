// 1. Create a simple base class `Animal` with a method `Speak()`. Derive a `Dog` class that overrides it.

// using System;
// class Animal
// {
//     public virtual void Speak()
//     {
//         Console.WriteLine("Animals make sounds");
//     }
// }
// class Dog : Animal
// {
//     public override void Speak()
//     {
//         Console.WriteLine("Dog barks");
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Animal a = new Dog();
//         a.Speak();
//     }
// }

// 2. Create a `Person` class with a method `GetDetails()`. Derive a `Student` class that overrides it.

// using System;
// class Person
// {
//     public virtual void GetDetails()
//     {
//         Console.WriteLine("This is a person.");

//     }
// }
// class Student : Person
// {
//     public override void GetDetails()
//     {
//         Console.WriteLine("This is a student.");
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Person p = new Student();
//         p.GetDetails();
//     }
// }

// 3. Implement an `Employee` base class with a method `CalculateSalary()`. Create a `Manager` class that adds a bonus to salary.

// using System;
// class Employee
// {
//     public virtual double CalculateSalary()
//     {
//         return 40000;
//     }
// }
// class Manager : Employee
// {
//     public override double CalculateSalary()
//     {
//         return base.CalculateSalary() + 10000;
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Employee emp = new Manager();
//         Console.WriteLine($"Salary: {emp.CalculateSalary()}");
//     }
// }

