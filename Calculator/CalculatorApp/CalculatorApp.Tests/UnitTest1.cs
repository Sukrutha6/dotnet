namespace CalculatorApp.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
    [Test_Method]
    public void Add_Positive(){
        Calculator ab=new Calculator();
        int actual= ab.Add(2,3);
        int expected=10;
        Assert.AreEqual(expected,actual);
    }
     public void Add_Negative(){
        Calculator ab=new Calculator();
        int actual= ab.Add(2,-3);
        int expected=-1;
        Assert.AreEqual(expected,actual);
}
}