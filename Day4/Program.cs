using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;


public class Parent 
{
    public string Name{ get; set; }
    public int age {get; set; }

    private string address;
    public Parent(string address){
        Console.WriteLine("Inside parent Constructor");
        this.address = address;
    }
     
    static void setAddress(string address){
        this.address = address;
    }

    string getAddress()
    {
        return address;
    }

}
public class Program
{
    public void main()
    {
        string add = "Hyderabad";
        Parent parent = new Parent(add);

        Console.WriteLine("hello world");
    }
}