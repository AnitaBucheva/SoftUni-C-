using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        //Act
        long result = PrimeFactor.FindLargestPrimeFactor(5);
        //Assert
        Assert.AreEqual(5, result);
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        //Act
        long result = PrimeFactor.FindLargestPrimeFactor(123456789123456789);
        //Assert
        Assert.AreEqual(52579, result);
    }
}
