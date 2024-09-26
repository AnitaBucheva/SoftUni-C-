using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
       List<int> number = new List<int>() { 15};
        int expected = 15;
        // Act
        int actual = MaxNumber.FindMax(number);
        //Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        List<int> number = new List<int>() { 10, 15, 700, 1, 10 };
        int expected = 700;
        // Act
        int actual = MaxNumber.FindMax(number);
        //Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {

        List<int> number = new List<int>() { -10, -15, -700, -1, -10 };
        int expected = -1;
        // Act
        int actual = MaxNumber.FindMax(number);
        //Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {

        List<int> number = new List<int>() { -10, 15, -700, 1, -10 };
        int expected = 15;
        // Act
        int actual = MaxNumber.FindMax(number);
        //Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {

        List<int> number = new List<int>() { 10, 15, 700, 700, 10 };
        int expected = 700;
        // Act
        int actual = MaxNumber.FindMax(number);
        //Assert
        Assert.AreEqual(expected, actual);
    }
}
