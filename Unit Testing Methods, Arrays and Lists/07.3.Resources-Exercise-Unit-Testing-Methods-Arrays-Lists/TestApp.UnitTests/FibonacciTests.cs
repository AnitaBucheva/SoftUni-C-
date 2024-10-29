using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        //Act
        int result = Fibonacci.CalculateFibonacci(0);
        //Assert
        Assert.AreEqual(0, result);
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        //Act
        int result = Fibonacci.CalculateFibonacci(1);
        //Assert
        Assert.AreEqual(1, result);
    }
}