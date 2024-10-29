using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        //Arrange
        char[] input = { '0', '1', 'a', 'b' };
        //Act
        char[] result = Fake.RemoveStringNumbers(input);
        //Assert
        Assert.That(result, Is.EqualTo(new char[] {'a', 'b'}));
     }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        //Arrange
        char[] input = { 'c', 'd', 'a', 'b' };
        //Act
        char[] result = Fake.RemoveStringNumbers(input);
        //Assert
        Assert.That(result, Is.EqualTo(input));
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        //Arrange
        char[] input = Array.Empty<char>();
        //Act
        char[] result = Fake.RemoveStringNumbers(input);
        //Assert
        Assert.That(result, Is.Empty);
    }
}
