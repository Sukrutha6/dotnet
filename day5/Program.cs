
using System;
using MainConstructor;
public class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Take the input");
        IndianEmployee employee=new IndianEmployee()
        {
            salary=100000,
            EmpId=2,
            taxamount=2
        };
        Console.WriteLine(employee.CalTax());
    }
}
