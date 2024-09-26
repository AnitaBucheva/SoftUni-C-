using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> number = new List<int> { 5 };
        List<int> expected = new List<int> { 5 };
       // Act
       List<int> result = GaussTrick.SumPairs(number);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> number = new List<int> { 5, 15, 10, 12 };
        List<int> expected = new List<int> { 17, 25 };
        //Test with up to 4 elements

        // Act
        List<int> result = GaussTrick.SumPairs(number);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        List<int> number = new List<int> { 5, 15, 100, 10, 12 };
        List<int> expected = new List<int> { 17, 25, 100 };
        //Test with up to 4 elements

        // Act
        List<int> result = GaussTrick.SumPairs(number);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        List<int> number = new List<int> { 5, 15, 100, 10, 12, 10 };
        List<int> expected = new List<int> { 15, 27, 110 };
        //Test with up to 4 elements

        // Act
        List<int> result = GaussTrick.SumPairs(number);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        List<int> number = new List<int> { 5, 15, 100, 43, 10, 12, 10 };
        List<int> expected = new List<int> { 15, 27, 110, 43 };
        //Test with up to 4 elements

        // Act
        List<int> result = GaussTrick.SumPairs(number);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
