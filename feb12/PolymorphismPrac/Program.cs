// 1. Create a base class `Shape` with a method `Draw()`. Derive `Circle` and `Square` classes that override the `Draw()` method.

// using System;
// class Shape
// {
//     public virtual void Draw()
//     {
//         Console.WriteLine("Drawing a shape");
//     }
// }
// class Circle : Shape
// {
//     public override void Draw()
//     {
//         Console.WriteLine("Drawing a circle");
//     }
// }
// class Square : Shape
// {
//     public override void Draw()
//     {
//         Console.WriteLine("Drawing a square");
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Shape s1 = new Circle();
//         s1.Draw();
//         Shape s2 = new Square();
//         s2.Draw();
//     }
// }

// 2. Implement a `Payment` class with a method `ProcessPayment()`. Extend it to `CreditCardPayment` and `PayPalPayment` with different implementations.

using System;
class Payment
{
    public virtual void ProcessPayment()
    {
        Console.WriteLine("Processing payment");
    }
}
class CreditCradPayment : Payment
{
    public override void ProcessPayment()
    {
        Console.WriteLine("Processing credit card payment");
    }
}
class PayPalPayment : Payment
{
    public override void ProcessPayment()
    {
        Console.WriteLine("Processing PayPal payment");
    }
}
class Program
{
    static void Main()
    {
        Payment p1 = new CreditCradPayment();
        p1.ProcessPayment();
        Payment p2 = new PayPalPayment();
        p2.ProcessPayment();
    }
}