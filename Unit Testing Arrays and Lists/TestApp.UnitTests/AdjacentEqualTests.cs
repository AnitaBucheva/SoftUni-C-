using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    // TODO: finish test
    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> numbers = new();
        string expected = string.Empty;

        // Act
        string actual = AdjacentEqual.Sum(numbers);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    // TODO: finish test
    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
      
        // Arrange
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5};
        string expected = "1 2 3 4 5";

        // Act
        string actual = AdjacentEqual.Sum(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // Arrange
        List<int> numbers = new List<int> { 6, 2, 2, 3, 4, 5 };
        string expected = "6 4 3 4 5";

        // Act
        string actual = AdjacentEqual.Sum(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        // Arrange
        List<int> numbers = new List<int> { 2, 2 };
        string expected = "4";

        // Act
        string actual = AdjacentEqual.Sum(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        // Arrange
        List<int> numbers = new List<int> { 20, 20, 4, 5,  };
        string expected = "40 4 5";

        // Act
        string actual = AdjacentEqual.Sum(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        // Arrange
        List<int> numbers = new List<int> { 20, 40, 50, 50 };
        string expected = "20 40 100";

        // Act
        string actual = AdjacentEqual.Sum(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    { 
        // Arrange
        List<int> numbers = new List<int> { -2, -5, -5, 12 };
        string expected = "-2 -10 12";

        // Act
        string actual = AdjacentEqual.Sum(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
